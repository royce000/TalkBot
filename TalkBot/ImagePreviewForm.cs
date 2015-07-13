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
    public partial class ImagePreviewForm : Form
    {
        public ImagePreviewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画像プレビューコントロールに画像を設定するメソッド
        /// </summary>
        /// <param name="imgPath">画像ファイルのパス</param>
        public void ChangeImage(string imgPath)
        {
            PreviewImageBox.ImageLocation = imgPath;
        }

        /// <summary>
        /// 画像プレビューコントロールに画像を設定するメソッド
        /// </summary>
        /// <param name="imgPath">画像</param>
        public void ChangeImage(Image img)
        {
            PreviewImageBox.Image = img;
        }
    }
}