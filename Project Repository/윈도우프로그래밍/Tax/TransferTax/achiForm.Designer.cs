namespace TransferTax
{
    partial class achiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(achiForm));
            this.label01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.achiTxt = new System.Windows.Forms.TextBox();
            this.achiDetailBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label01
            // 
            this.label01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label01.Font = new System.Drawing.Font("굴림", 12F);
            this.label01.Location = new System.Drawing.Point(43, 56);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(114, 20);
            this.label01.TabIndex = 1;
            this.label01.Text = "1. 취득가액";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(78, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "2. 세율";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // achiTxt
            // 
            this.achiTxt.Location = new System.Drawing.Point(178, 56);
            this.achiTxt.Name = "achiTxt";
            this.achiTxt.ReadOnly = true;
            this.achiTxt.Size = new System.Drawing.Size(260, 25);
            this.achiTxt.TabIndex = 6;
            // 
            // achiDetailBtn
            // 
            this.achiDetailBtn.Location = new System.Drawing.Point(456, 55);
            this.achiDetailBtn.Name = "achiDetailBtn";
            this.achiDetailBtn.Size = new System.Drawing.Size(75, 25);
            this.achiDetailBtn.TabIndex = 35;
            this.achiDetailBtn.Text = "상세입력";
            this.achiDetailBtn.UseVisualStyleBackColor = true;
            this.achiDetailBtn.Click += new System.EventHandler(this.achiDetailBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "유상승계취득(취득 당시 가액 6억원 이하)",
            "유상승계취득(취득 당시 가액 6억원 초과 9억원 이하)",
            "유상승계취득(취득 당시 가액 9억원 초과)",
            "상속취득",
            "증여취득(개인인경우)",
            "증여취득(비영리사업자)",
            "원시취득",
            "공유, 합유, 총유물의 분할"});
            this.comboBox1.Location = new System.Drawing.Point(178, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 23);
            this.comboBox1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 37;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(65, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "산출세액";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(178, 172);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(260, 25);
            this.resultBox.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(178, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 55);
            this.button2.TabIndex = 40;
            this.button2.Text = "메인메뉴로 돌아가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // achiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.achiDetailBtn);
            this.Controls.Add(this.achiTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label01);
            this.Name = "achiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "취득세";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button achiDetailBtn;
        public System.Windows.Forms.TextBox achiTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button2;
    }
}