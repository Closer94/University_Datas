namespace TransferTax
{
    partial class compForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compForm));
            this.label01 = new System.Windows.Forms.Label();
            this.pubBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stndBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.perBox = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label01
            // 
            this.label01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label01.Font = new System.Drawing.Font("굴림", 12F);
            this.label01.Location = new System.Drawing.Point(24, 65);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(231, 20);
            this.label01.TabIndex = 2;
            this.label01.Text = "1. 주택 공시가격 합계액";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pubBox
            // 
            this.pubBox.Location = new System.Drawing.Point(277, 64);
            this.pubBox.Name = "pubBox";
            this.pubBox.Size = new System.Drawing.Size(260, 25);
            this.pubBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(135, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "2. 과세표준";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stndBox
            // 
            this.stndBox.Location = new System.Drawing.Point(277, 107);
            this.stndBox.Name = "stndBox";
            this.stndBox.ReadOnly = true;
            this.stndBox.Size = new System.Drawing.Size(260, 25);
            this.stndBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(176, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "3. 세율";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox1.Location = new System.Drawing.Point(51, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(258, 21);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "과세 기준일 현재 만 60세 이상";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(35, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(645, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "※1세대 1주택자인 경우에만 아래에 해당하는 것을 체크해주세요.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox2.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox2.Location = new System.Drawing.Point(51, 296);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(271, 21);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "과세 기준일 현재 5년 이상 보유";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "만 60세 이상 만 65세 미만",
            "만 65세 이상 만 70세 미만",
            "만 70세 이상"});
            this.comboBox1.Location = new System.Drawing.Point(337, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 23);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5년 이상 10년 미만 보유",
            "10년 이상 보유"});
            this.comboBox2.Location = new System.Drawing.Point(337, 294);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(315, 23);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(568, 64);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 25);
            this.btn1.TabIndex = 49;
            this.btn1.Text = "입력";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(568, 107);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 25);
            this.btn2.TabIndex = 50;
            this.btn2.Text = "결과";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(681, 249);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 25);
            this.btn4.TabIndex = 51;
            this.btn4.Text = "입력";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Visible = false;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(681, 296);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 25);
            this.btn5.TabIndex = 52;
            this.btn5.Text = "입력";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Visible = false;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // perBox
            // 
            this.perBox.Location = new System.Drawing.Point(277, 150);
            this.perBox.Name = "perBox";
            this.perBox.Size = new System.Drawing.Size(260, 25);
            this.perBox.TabIndex = 53;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(568, 150);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 25);
            this.btn3.TabIndex = 54;
            this.btn3.Text = "입력";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(159, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "산출세액";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(277, 361);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(260, 25);
            this.resultBox.TabIndex = 56;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(568, 359);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 25);
            this.btn6.TabIndex = 57;
            this.btn6.Text = "결과";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(277, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 55);
            this.button1.TabIndex = 58;
            this.button1.Text = "메인메뉴로 돌아가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // compForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.perBox);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stndBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pubBox);
            this.Controls.Add(this.label01);
            this.Name = "compForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "종합부동산세";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label01;
        public System.Windows.Forms.TextBox pubBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox stndBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        public System.Windows.Forms.TextBox perBox;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button1;
    }
}