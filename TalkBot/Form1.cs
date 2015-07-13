using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace TalkBot
{
    public partial class Form1 : Form
    {
        private TalkData talkData = new TalkData();
        private ImagePreviewForm imagePreForm = null;


        public Form1()
        {
            InitializeComponent();

            // データのロード
            LoadFormSetting();
            if (!talkData.LoadTalkData())
            {
                MessageBox.Show("データのロードの失敗しました。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            // 教育の顔選択リストボックスに選択肢を追加
            EFaceComboBox.DataSource = Enum.GetValues(typeof(TalkData.Face));

            // データリストのデータソースをセット
            TalkDataView.DataSource = talkData.TalkDataList;

            // 初期の顔画像をセット
            if (talkData.IsCache)
                facePicBox.Image = talkData.GetFaceImage(TalkData.Face.Normal);
            else
                facePicBox.ImageLocation = talkData.GetImageFilePath(TalkData.Face.Normal);

            if (talkData.IsCache)
                label3.Text = "キャッシュ済み";
            else
                label3.Text = "キャッシュ未生成";
        }

        // 話しかけるボタンを押された
        private void talkButton_Click(object sender, EventArgs e)
        {
            string iText = talkTextBox.Text;    // 入力文字列を取得

            // コントロールを無効化
            talkTextBox.Enabled = false;
            talkButton.Enabled = false;
            AutoTalkTimer.Enabled = false;

            // 入力がなかったら処理しない
            if (iText == "")
            {
                // コントロールを有効化
                talkTextBox.Enabled = true;
                talkButton.Enabled = true;

                return;
            }


            TalkData.TalkDataValue value;   // 返答を格納する変数

            // 応答があったかを判定
            if ((value = talkData.GetTalkResponse(iText)) == null)
            {
                // 顔の画像を設定  
                if (talkData.IsCache)
                    facePicBox.Image = talkData.GetFaceImage(TalkData.Face.Cry);
                else
                    facePicBox.ImageLocation = talkData.GetImageFilePath(TalkData.Face.Cry);
                BotText.Text = "ちょっと何を言ってるかわかりません";

                // コントロールを有効化
                talkTextBox.Enabled = true;
                talkButton.Enabled = true;

                return;
            }

            // 顔の画像を設定
            if (talkData.IsCache)
                facePicBox.Image = talkData.GetFaceImage(value.FaceImage);
            else
                facePicBox.ImageLocation = talkData.GetImageFilePath(value.FaceImage);
            BotText.Text = value.OutputText;    // 応答文字列表示

            // コントロールを有効化
            talkTextBox.Text = "";
            talkTextBox.Enabled = true;
            talkButton.Enabled = true;
            AutoTalkTimer.Enabled = true;
        }

        // 話しかけるテキストボックスのキーダウンイベントメソッド
        private void talkTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                talkButton.PerformClick();
            }
        }

        // キャッシュ生成ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            if (talkData.CreateImageCache())
            {
                label3.Text = "キャッシュ済み";
                MessageBox.Show("キャッシュを生成しました");
            }
            else
            {
                label3.Text = "キャッシュ未生成";
                MessageBox.Show("キャッシュの生成に失敗しました");
            }
        }

        // 教育ボタンが押された
        private void educationButton_Click(object sender, EventArgs e)
        {
            // 各値を取得
            string iText = EInputTextBox.Text;
            string oText = EOutputTextBox.Text;
            TalkBot.TalkData.Face face = (TalkData.Face)EFaceComboBox.SelectedValue;

            // 値が適切かを判定
            if (iText == "" || oText == "")
            {
                MessageBox.Show("値が適切ではありません。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!talkData.AddTalkData(new TalkData.TalkDataValue(iText, oText, face)))
            {
                MessageBox.Show("すでに登録済みか、追加に失敗しました。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EInputTextBox.Text = "";
            EOutputTextBox.Text = "";
        }

        // 教育の顔選択が変更時のイベントメソッド
        private void EFaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagePreForm != null)
            {
                imagePreForm.ChangeImage(talkData.GetImageFilePath((TalkData.Face)EFaceComboBox.SelectedValue));
            }
        }

        // 顔の画像プレビューボタン
        private void FacePreviewButton_Click(object sender, EventArgs e)
        {
            if (imagePreForm == null)
            {
                imagePreForm = new ImagePreviewForm();
                if (talkData.IsCache)
                    imagePreForm.ChangeImage(talkData.GetFaceImage((TalkData.Face)EFaceComboBox.SelectedValue));
                else
                    imagePreForm.ChangeImage(talkData.GetImageFilePath((TalkData.Face)EFaceComboBox.SelectedValue));
                imagePreForm.FormClosed += new FormClosedEventHandler(ImagePreviewFormClosed);
                imagePreForm.Show(this);
            }
            else
            {
                if (talkData.IsCache)
                    imagePreForm.ChangeImage(talkData.GetFaceImage((TalkData.Face)EFaceComboBox.SelectedValue));
                else
                    imagePreForm.ChangeImage(talkData.GetImageFilePath((TalkData.Face)EFaceComboBox.SelectedValue));
            }
        }

        // プレビューフォームの閉じられるイベントメソッド
        private void ImagePreviewFormClosed(object sender, FormClosedEventArgs e)
        {
            imagePreForm = null;
        }

        // 忘却ボタンが押された
        private void forgettingButton_Click(object sender, EventArgs e)
        {
            if (FInputTextBox.Text == "") return;   // 何も入力されてない場合は処理しない


            DialogResult dResult;
            dResult = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // 閉じないを選択
            if (dResult == DialogResult.No)
            {
                return;
            }

            string iText = FInputTextBox.Text;

            // データの削除
            if (!talkData.DeleteTalkData(iText))
            {
                MessageBox.Show("削除失敗しました", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FInputTextBox.Text = "";
        }

        // 自動トークモードのチェック状態変化
        private void AutoTalkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoTalkCheckBox.Checked)
            {
                ChaosTalkCheckBox.Enabled = true;
                AutoTalkTimer.Enabled = true;
            }
            else
            {
                ChaosTalkCheckBox.Enabled = false;
                AutoTalkTimer.Enabled = false;
            }
        }

        // フォームが閉じられる
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // データの保存
            SaveFormSetting();
            if (!talkData.SaveTalkData())
            {
                DialogResult dResult;
                dResult = MessageBox.Show("データの保存に失敗しました。\r\nこのまま終了しますか？", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                // 閉じないを選択
                if (dResult == DialogResult.No)
                {
                    e.Cancel = true;

                    return;
                }
            }
        }

        // 自動でしゃべるタイマー
        private void AutoTalkTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Random rdm = new Random();

                // カオスモードではない
                if (!ChaosTalkCheckBox.Checked)
                {
                    switch (rdm.Next(3))
                    {
                        case 0:
                            // 顔の画像を設定
                            if (talkData.IsCache)
                                facePicBox.Image = talkData.GetFaceImage(TalkData.Face.Smile);
                            else
                                facePicBox.ImageLocation = talkData.GetImageFilePath(TalkData.Face.Smile);
                            BotText.Text = "何か質問ある？";
                            break;

                        case 1:
                            // 顔の画像を設定
                            if (talkData.IsCache)
                                facePicBox.Image = talkData.GetFaceImage(TalkData.Face.Normal);
                            else
                                facePicBox.ImageLocation = talkData.GetImageFilePath(TalkData.Face.Normal);
                            BotText.Text = "ひまだなぁ";
                            break;

                        case 2:
                            // 顔の画像を設定
                            if (talkData.IsCache)
                                facePicBox.Image = talkData.GetFaceImage(TalkData.Face.Deconditioning);
                            else
                                facePicBox.ImageLocation = talkData.GetImageFilePath(TalkData.Face.Deconditioning);
                            BotText.Text = "もしかして・・・放置・・・？";
                            break;
                    }
                }
                else
                {
                    TalkData.TalkDataValue value;   // 返答を格納する変数

                    // ランダムに文字列をゲット
                    int selectIndex = rdm.Next(talkData.TalkDataList.Count);

                    value = talkData.TalkDataList[selectIndex];
                    // 顔の画像を設定
                    if (talkData.IsCache)
                        facePicBox.Image = talkData.GetFaceImage(value.FaceImage);
                    else
                        facePicBox.ImageLocation = talkData.GetImageFilePath(value.FaceImage);
                    BotText.Text = value.OutputText;    // 応答文字列表示
                }
            }
            catch
            {

            }
        }

        // 顔選択リストボックスの文字列変換
        private void EFaceComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            //教育の顔選択肢がわかりやすい文字列になるようにする
            switch ((TalkData.Face)e.ListItem)
            {
                case TalkData.Face.Angry:
                    e.Value = "怒り顔"; break;
                case TalkData.Face.Cry:
                    e.Value = "泣き顔"; break;
                case TalkData.Face.Normal:
                    e.Value = "ノーマル"; break;
                case TalkData.Face.Smile:
                    e.Value = "笑顔"; break;
                case TalkData.Face.Love:
                    e.Value = "好き"; break;
                case TalkData.Face.Wink:
                    e.Value = "ウィンク"; break;
                case TalkData.Face.Deconditioning:
                    e.Value = "うぇぇ・・の顔"; break;
            }
        }

        private bool LoadFormSetting()
        {
            try
            {
                if (!File.Exists("FormData.xml")) return true;  // ファイルがない場合

                // フォームのデータクラス初期化
                FormConfig fc = new FormConfig();

                // データファイルへのアクセス準備
                using (FileStream fs = new FileStream("FormData.xml", FileMode.Open))
                {
                    // Xml解析用インスタンスの初期化
                    XmlSerializer ser = new XmlSerializer(typeof(FormConfig));

                    // データの読み出し
                    fc = (FormConfig)ser.Deserialize(fs);
                }

                // データを復元
                AutoTalkCheckBox.Checked = fc.isAutoTalk;
                ChaosTalkCheckBox.Checked = fc.isChaosTalk;

            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Formの設定データを保存するメソッド
        /// </summary>
        /// <returns></returns>
        private bool SaveFormSetting()
        {
            try
            {
                // フォームのデータクラス初期化
                FormConfig fc = new FormConfig();
                fc.isAutoTalk = AutoTalkCheckBox.Checked;
                fc.isChaosTalk = ChaosTalkCheckBox.Checked;

                // ファイル保存をする準備
                using (FileStream fs = new FileStream("FormData.xml", FileMode.Create))
                {
                    // Xmlファイル保存用インスタンスの初期化
                    XmlSerializer ser = new XmlSerializer(typeof(FormConfig));

                    // ファイルを保存
                    ser.Serialize(fs, fc);
                    fs.Close();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }

    [Serializable]
    public class FormConfig
    {
        public bool isAutoTalk { get; set; }
        public bool isChaosTalk { get; set; }
    }
}