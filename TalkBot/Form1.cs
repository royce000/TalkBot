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
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// デバッグログにログを追加するメソッド
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="text">ログ内容</param>
        public void AddDebugLog(string name, string text)
        {
            DateTime now = DateTime.Now;

            string time = now.ToString("HH:mm:ss");
            string log = name == "" ? string.Format("[{0}] <?> {1}", time, text) : string.Format("[{0}] <1> {2}", time, name, text);

            debugLogTextBox.AppendText(log + "\n");
            debugLogTextBox.SelectionStart = debugLogTextBox.Text.Length;
            debugLogTextBox.ScrollToCaret();
        }
    }
}