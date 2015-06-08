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