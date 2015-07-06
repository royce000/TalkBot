using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace TalkBot
{
    public class TalkData
    {
        // コンピューターの表情画像用定数
        public enum Face
        {
            Normal,         // 通常時の顔
            Smile,          // 笑顔
            Angry,          // 怒り顔
            Cry,            // 泣き顔
            Love,           // ハート顔
            Wink,           // ウィンクの顔
            Deconditioning  // 体調不良の顔
        }


        private BindingList<TalkDataValue> talkDataList = new BindingList<TalkDataValue>();   // 会話で使用する言葉データを保持するリスト



        #region メソッド

        public TalkData()
        {

        }

        /// <summary>
        /// <para>応答リストにデータを追加するメソッド</para>
        /// <para>同じ反応文字列だったり追加に失敗した場合は、戻り値がfalseなります</para>
        /// </summary>
        /// <param name="value">トークデータ</param>
        /// <returns>追加処理の結果</returns>
        public bool AddTalkData(TalkDataValue value)
        {
            try
            {
                for (int i = 0; i < talkDataList.Count; i++)
                {
                    // すでに存在している場合
                    if (talkDataList[i].InputText == value.InputText)
                        return false;
                }

                talkDataList.Add(value);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// <para>応答リストのデータを削除するメソッド</para>
        /// <para>削除に失敗した場合や、存在しない場合は、戻り値がfalseになります</para>
        /// </summary>
        /// <param name="inputText">削除したい反応文字列</param>
        /// <returns>削除処理の結果</returns>
        public bool DeleteTalkData(string inputText)
        {
            // データが存在しない
            if (talkDataList.Count < 0)
                return false;

            try
            {
                for (int i = 0; i < talkDataList.Count; i++)
                {
                    // データが存在
                    if (talkDataList[i].InputText == inputText)
                    {
                        talkDataList.RemoveAt(i); // 削除
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// <para>入力文字列を元に、反応する文字列を探し返します</para>
        /// <para>存在しない場合は、戻り値がnullになります</para>
        /// </summary>
        /// <param name="inputText">入力文字列</param>
        /// <returns></returns>
        public TalkDataValue GetTalkResponse(string inputText)
        {
            for (int i = 0; i < talkDataList.Count; i++)
            {
                if (talkDataList[i].InputText == inputText)
                    return talkDataList[i];
            }

            return null;
        }

        /// <summary>
        /// 指定した表情の画像のパスを取得するメソッド
        /// </summary>
        /// <param name="face">表情</param>
        /// <returns>指定した表情画像のファイルパス</returns>
        public string GetImageFilePath(Face face)
        {
            return String.Format("img/Face_{0}.png", face);
        }

        /// <summary>
        /// <para>トークデータを読み込むメソッド</para>
        /// <para>成功するとtrue, 失敗すると戻り値がfalseになります。</para>
        /// </summary>
        /// <returns></returns>
        public bool LoadTalkData()
        {
            try
            {
                if (!File.Exists("talkData.xml")) return true;  // ファイルがない場合

                // 読み込んだデータを一時保存するリスト
                System.Collections.ArrayList al = new System.Collections.ArrayList();

                // データファイルへのアクセス準備
                using (FileStream fs = new FileStream("talkData.xml", FileMode.Open))
                {
                    // Xml解析用インスタンスの初期化
                    XmlSerializer ser = new XmlSerializer(typeof(System.Collections.ArrayList), new Type[] { typeof(TalkDataValue) });

                    // データの読み出し
                    al = (System.Collections.ArrayList)ser.Deserialize(fs);
                }

                // 読み出したデータを管理リストへ変換
                for (int i = 0; i < al.Count; i++)
                {
                    TalkDataValue tdv = (TalkDataValue)al[i];

                    talkDataList.Add(new TalkDataValue(tdv.InputText, tdv.OutputText, tdv.FaceImage));
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// <para>トークデータを保存するメソッド</para>
        /// <para>成功するとtrue, 失敗すると戻り値がfalseになります。</para>
        /// </summary>
        /// <returns></returns>
        public bool SaveTalkData()
        {
            try
            {
                // 保存するデータを一時リストへ変換
                System.Collections.ArrayList al = new System.Collections.ArrayList();
                al.AddRange(talkDataList);

                // ファイル保存をする準備
                using (FileStream fs = new FileStream("talkData.xml", FileMode.Create))
                {
                    // Xmlファイル保存用インスタンスの初期化
                    XmlSerializer ser = new XmlSerializer(typeof(System.Collections.ArrayList), new Type[] { typeof(TalkDataValue) });

                    // ファイルを保存
                    ser.Serialize(fs, al);
                    fs.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        #endregion

        #region プロパティ

        /// <summary>
        /// 会話で使用する言葉のデータリストを取得
        /// </summary>
        public BindingList<TalkDataValue> TalkDataList { get { return talkDataList; } }

        #endregion


        [Serializable]
        public class TalkDataValue
        {
            #region メソッド

            // コンストラクター
            public TalkDataValue()
            {
                this.InputText = "";
                this.OutputText = "";
                this.FaceImage = Face.Normal;
            }

            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="inputText">反応文字列</param>
            /// <param name="outputText">応答文字列</param>
            /// <param name="faceImage">表情画像</param>
            public TalkDataValue(string inputText, string outputText, Face faceImage)
            {
                this.SetAllValue(inputText, outputText, faceImage);
            }

            /// <summary>
            /// すべてのプロパティに値をセットするメソッド
            /// </summary>
            /// <param name="inputText">反応文字列</param>
            /// <param name="outputText">応答文字列</param>
            /// <param name="faceImage">表情画像フラグ</param>
            public void SetAllValue(string inputText, string outputText, Face faceImage)
            {
                this.InputText = inputText;
                this.OutputText = outputText;
                this.FaceImage = faceImage;
            }

            #endregion

            #region プロパティ

            /// <summary>入力された文字列（反応文字列）</summary>
            public string InputText { get; set; }

            /// <summary>応答する文字列</summary>
            public string OutputText { get; set; }

            /// <summary>どの表情をするかのフラグ定数</summary>
            public Face FaceImage { get; set; }

            #endregion
        }
    }
}