using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            facePicBox.ImageLocation = talkData.GetImageFilePath(TalkData.Face.Normal);
        }

        // 話しかけるボタンを押された
        private void talkButton_Click(object sender, EventArgs e)
        {
            string iText = talkTextBox.Text;    // 入力文字列を取得

            // コントロールを無効化
            talkTextBox.Enabled = false;
            talkButton.Enabled = false;

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
                facePicBox.ImageLocation = talkData.GetImageFilePath(TalkData.Face.Cry);    // 顔の画像を設定
                BotText.Text = "ちょっと何を言ってるかわかりません";

                // コントロールを有効化
                talkTextBox.Enabled = true;
                talkButton.Enabled = true;

                return;
            }

            facePicBox.ImageLocation = talkData.GetImageFilePath(value.FaceImage);  // 顔の画像を設定
            BotText.Text = value.OutputText;    // 応答文字列表示

            // コントロールを有効化
            talkTextBox.Text = "";
            talkTextBox.Enabled = true;
            talkButton.Enabled = true;
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
                imagePreForm.ChangeImage(talkData.GetImageFilePath((TalkData.Face)EFaceComboBox.SelectedValue));
                imagePreForm.FormClosed += new FormClosedEventHandler(ImagePreviewFormClosed);
                imagePreForm.Show(this);
            }
            else
            {
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

        // フォームが閉じられる
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // データの保存
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
    }
}