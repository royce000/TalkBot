namespace TalkBot
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BotText = new System.Windows.Forms.TextBox();
            this.talkButton = new System.Windows.Forms.Button();
            this.talkTextBox = new System.Windows.Forms.TextBox();
            this.facePicBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TalkDataView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.forgettingButton = new System.Windows.Forms.Button();
            this.FInputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FacePreviewButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EFaceComboBox = new System.Windows.Forms.ComboBox();
            this.educationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EOutputTextBox = new System.Windows.Forms.TextBox();
            this.EInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ChaosTalkCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoTalkCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoTalkTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facePicBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TalkDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BotText);
            this.tabPage1.Controls.Add(this.talkButton);
            this.tabPage1.Controls.Add(this.talkTextBox);
            this.tabPage1.Controls.Add(this.facePicBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BotText
            // 
            this.BotText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotText.BackColor = System.Drawing.Color.Black;
            this.BotText.ForeColor = System.Drawing.Color.Lime;
            this.BotText.Location = new System.Drawing.Point(6, 272);
            this.BotText.Multiline = true;
            this.BotText.Name = "BotText";
            this.BotText.ReadOnly = true;
            this.BotText.Size = new System.Drawing.Size(464, 52);
            this.BotText.TabIndex = 3;
            // 
            // talkButton
            // 
            this.talkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.talkButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.talkButton.Location = new System.Drawing.Point(6, 400);
            this.talkButton.Name = "talkButton";
            this.talkButton.Size = new System.Drawing.Size(464, 30);
            this.talkButton.TabIndex = 2;
            this.talkButton.Text = "話しかける";
            this.talkButton.UseVisualStyleBackColor = true;
            this.talkButton.Click += new System.EventHandler(this.talkButton_Click);
            // 
            // talkTextBox
            // 
            this.talkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.talkTextBox.Location = new System.Drawing.Point(6, 330);
            this.talkTextBox.Multiline = true;
            this.talkTextBox.Name = "talkTextBox";
            this.talkTextBox.Size = new System.Drawing.Size(464, 64);
            this.talkTextBox.TabIndex = 1;
            this.talkTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.talkTextBox_KeyDown);
            // 
            // facePicBox
            // 
            this.facePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facePicBox.Location = new System.Drawing.Point(6, 6);
            this.facePicBox.Name = "facePicBox";
            this.facePicBox.Size = new System.Drawing.Size(464, 260);
            this.facePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.facePicBox.TabIndex = 0;
            this.facePicBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教育";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TalkDataView);
            this.groupBox3.Location = new System.Drawing.Point(6, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "データ";
            // 
            // TalkDataView
            // 
            this.TalkDataView.AllowUserToAddRows = false;
            this.TalkDataView.AllowUserToDeleteRows = false;
            this.TalkDataView.AllowUserToResizeRows = false;
            this.TalkDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TalkDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TalkDataView.Location = new System.Drawing.Point(6, 18);
            this.TalkDataView.MultiSelect = false;
            this.TalkDataView.Name = "TalkDataView";
            this.TalkDataView.ReadOnly = true;
            this.TalkDataView.RowHeadersVisible = false;
            this.TalkDataView.RowTemplate.Height = 21;
            this.TalkDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TalkDataView.Size = new System.Drawing.Size(452, 179);
            this.TalkDataView.TabIndex = 4;
            this.TalkDataView.VirtualMode = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.forgettingButton);
            this.groupBox2.Controls.Add(this.FInputTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 79);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "忘却";
            // 
            // forgettingButton
            // 
            this.forgettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgettingButton.Location = new System.Drawing.Point(6, 43);
            this.forgettingButton.Name = "forgettingButton";
            this.forgettingButton.Size = new System.Drawing.Size(452, 30);
            this.forgettingButton.TabIndex = 4;
            this.forgettingButton.Text = "忘却";
            this.forgettingButton.UseVisualStyleBackColor = true;
            this.forgettingButton.Click += new System.EventHandler(this.forgettingButton_Click);
            // 
            // FInputTextBox
            // 
            this.FInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FInputTextBox.Location = new System.Drawing.Point(96, 18);
            this.FInputTextBox.Name = "FInputTextBox";
            this.FInputTextBox.Size = new System.Drawing.Size(362, 19);
            this.FInputTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "反応する文字列";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.FacePreviewButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EFaceComboBox);
            this.groupBox1.Controls.Add(this.educationButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EOutputTextBox);
            this.groupBox1.Controls.Add(this.EInputTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教育";
            // 
            // FacePreviewButton
            // 
            this.FacePreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FacePreviewButton.Location = new System.Drawing.Point(378, 68);
            this.FacePreviewButton.Name = "FacePreviewButton";
            this.FacePreviewButton.Size = new System.Drawing.Size(80, 23);
            this.FacePreviewButton.TabIndex = 7;
            this.FacePreviewButton.Text = "顔のプレビュー";
            this.FacePreviewButton.UseVisualStyleBackColor = true;
            this.FacePreviewButton.Click += new System.EventHandler(this.FacePreviewButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "表示する顔";
            // 
            // EFaceComboBox
            // 
            this.EFaceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EFaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EFaceComboBox.FormattingEnabled = true;
            this.EFaceComboBox.Location = new System.Drawing.Point(96, 70);
            this.EFaceComboBox.Name = "EFaceComboBox";
            this.EFaceComboBox.Size = new System.Drawing.Size(276, 20);
            this.EFaceComboBox.TabIndex = 5;
            this.EFaceComboBox.SelectedIndexChanged += new System.EventHandler(this.EFaceComboBox_SelectedIndexChanged);
            this.EFaceComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.EFaceComboBox_Format);
            // 
            // educationButton
            // 
            this.educationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.educationButton.Location = new System.Drawing.Point(6, 97);
            this.educationButton.Name = "educationButton";
            this.educationButton.Size = new System.Drawing.Size(452, 30);
            this.educationButton.TabIndex = 4;
            this.educationButton.Text = "教育";
            this.educationButton.UseVisualStyleBackColor = true;
            this.educationButton.Click += new System.EventHandler(this.educationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "出力文字列";
            // 
            // EOutputTextBox
            // 
            this.EOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EOutputTextBox.Location = new System.Drawing.Point(96, 43);
            this.EOutputTextBox.Name = "EOutputTextBox";
            this.EOutputTextBox.Size = new System.Drawing.Size(362, 19);
            this.EOutputTextBox.TabIndex = 2;
            // 
            // EInputTextBox
            // 
            this.EInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EInputTextBox.Location = new System.Drawing.Point(96, 18);
            this.EInputTextBox.Name = "EInputTextBox";
            this.EInputTextBox.Size = new System.Drawing.Size(362, 19);
            this.EInputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "反応する文字列";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.ChaosTalkCheckBox);
            this.tabPage3.Controls.Add(this.AutoTalkCheckBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(476, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ChaosTalkCheckBox
            // 
            this.ChaosTalkCheckBox.AutoSize = true;
            this.ChaosTalkCheckBox.Location = new System.Drawing.Point(6, 28);
            this.ChaosTalkCheckBox.Name = "ChaosTalkCheckBox";
            this.ChaosTalkCheckBox.Size = new System.Drawing.Size(77, 16);
            this.ChaosTalkCheckBox.TabIndex = 1;
            this.ChaosTalkCheckBox.Text = "カオストーク";
            this.ChaosTalkCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoTalkCheckBox
            // 
            this.AutoTalkCheckBox.AutoSize = true;
            this.AutoTalkCheckBox.Checked = true;
            this.AutoTalkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoTalkCheckBox.Location = new System.Drawing.Point(6, 6);
            this.AutoTalkCheckBox.Name = "AutoTalkCheckBox";
            this.AutoTalkCheckBox.Size = new System.Drawing.Size(102, 16);
            this.AutoTalkCheckBox.TabIndex = 0;
            this.AutoTalkCheckBox.Text = "自動トークモード";
            this.AutoTalkCheckBox.UseVisualStyleBackColor = true;
            this.AutoTalkCheckBox.CheckedChanged += new System.EventHandler(this.AutoTalkCheckBox_CheckedChanged);
            // 
            // AutoTalkTimer
            // 
            this.AutoTalkTimer.Enabled = true;
            this.AutoTalkTimer.Interval = 10000;
            this.AutoTalkTimer.Tick += new System.EventHandler(this.AutoTalkTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "キャッシュ生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "キャッシュ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TalkBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facePicBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TalkDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox facePicBox;
        private System.Windows.Forms.TextBox talkTextBox;
        private System.Windows.Forms.Button talkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EOutputTextBox;
        private System.Windows.Forms.Button educationButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button forgettingButton;
        private System.Windows.Forms.TextBox FInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EFaceComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TalkDataView;
        private System.Windows.Forms.TextBox BotText;
        private System.Windows.Forms.Button FacePreviewButton;
        private System.Windows.Forms.Timer AutoTalkTimer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox AutoTalkCheckBox;
        private System.Windows.Forms.CheckBox ChaosTalkCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

