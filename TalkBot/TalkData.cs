using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TalkBot
{
    public class TalkData
    {
        // コンピューターの表情画像用定数
        public enum Face
        {
            Normal,     // 通常時の顔
            Smile,      // 笑顔
            Angry,      // 怒り顔
            Cry         // 泣き顔
        }

        private DataTable talkDataTable = new DataTable();   // 会話で使用する言葉データを保持するテーブル


        public TalkData()
        {
            // テーブルの初期化
        }

        /// <summary>
        /// 会話で使用する言葉のデータテーブルを取得
        /// </summary>
        public DataTable TalkDataTable { get { return talkDataTable; } }
    }
}