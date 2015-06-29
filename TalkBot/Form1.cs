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


        public Form1()
        {
            InitializeComponent();

            // データのロード
            if (!talkData.LoadTalkData())
            {
                MessageBox.Show("データのロードの失敗しました。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // 話しかけるボタンを押された
        private void talkButton_Click(object sender, EventArgs e)
        {

        }

        // 教育ボタンが押された
        private void educationButton_Click(object sender, EventArgs e)
        {

        }

        // 忘却ボタンが押された
        private void forgettingButton_Click(object sender, EventArgs e)
        {

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
    }
}