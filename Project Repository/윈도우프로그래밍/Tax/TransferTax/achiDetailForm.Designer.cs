namespace TransferTax
{
    partial class achiDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(achiDetailForm));
            this.btn8 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btn5 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.rsltBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box7 = new System.Windows.Forms.TextBox();
            this.box6 = new System.Windows.Forms.TextBox();
            this.box5 = new System.Windows.Forms.TextBox();
            this.box4 = new System.Windows.Forms.TextBox();
            this.box3 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(536, 477);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 25);
            this.btn8.TabIndex = 67;
            this.btn8.Text = "총액계산";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox6.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox6.Location = new System.Drawing.Point(44, 410);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(64, 21);
            this.checkBox6.TabIndex = 45;
            this.checkBox6.Text = "기타";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox1.Location = new System.Drawing.Point(44, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 21);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "건설자금 이자";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(460, 43);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 25);
            this.btn1.TabIndex = 66;
            this.btn1.Text = "입력";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox2.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox2.Location = new System.Drawing.Point(44, 189);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(161, 21);
            this.checkBox2.TabIndex = 40;
            this.checkBox2.Text = "할부이자, 연체료";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(537, 408);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 25);
            this.btn7.TabIndex = 65;
            this.btn7.Text = "입력";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Visible = false;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox3.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox3.Location = new System.Drawing.Point(44, 238);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(523, 21);
            this.checkBox3.TabIndex = 41;
            this.checkBox3.Text = "취득에 필요한 용역을 제공받은 대가로 지급하는 용역비, 수수료";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(538, 360);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 25);
            this.btn6.TabIndex = 63;
            this.btn6.Text = "입력";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Visible = false;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox4.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox4.Location = new System.Drawing.Point(44, 317);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 21);
            this.checkBox4.TabIndex = 42;
            this.checkBox4.Text = "채무인수액";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(538, 315);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 25);
            this.btn5.TabIndex = 62;
            this.btn5.Text = "입력";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Visible = false;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox5.Font = new System.Drawing.Font("굴림", 10F);
            this.checkBox5.Location = new System.Drawing.Point(44, 362);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(175, 21);
            this.checkBox5.TabIndex = 43;
            this.checkBox5.Text = "주택채권 매각차손";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(538, 275);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 25);
            this.btn4.TabIndex = 61;
            this.btn4.Text = "입력";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Visible = false;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(538, 187);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 25);
            this.btn3.TabIndex = 60;
            this.btn3.Text = "입력";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(538, 134);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 25);
            this.btn2.TabIndex = 59;
            this.btn2.Text = "입력";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rsltBtn
            // 
            this.rsltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rsltBtn.Font = new System.Drawing.Font("굴림", 11F);
            this.rsltBtn.Location = new System.Drawing.Point(230, 536);
            this.rsltBtn.Name = "rsltBtn";
            this.rsltBtn.Size = new System.Drawing.Size(137, 42);
            this.rsltBtn.TabIndex = 58;
            this.rsltBtn.Text = "입력하기";
            this.rsltBtn.UseVisualStyleBackColor = false;
            this.rsltBtn.Click += new System.EventHandler(this.rsltBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(229, 479);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(290, 25);
            this.resultBox.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(40, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "총 취득가액 :";
            // 
            // box7
            // 
            this.box7.Location = new System.Drawing.Point(229, 408);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(290, 25);
            this.box7.TabIndex = 55;
            this.box7.Visible = false;
            // 
            // box6
            // 
            this.box6.Location = new System.Drawing.Point(230, 360);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(290, 25);
            this.box6.TabIndex = 53;
            this.box6.Visible = false;
            // 
            // box5
            // 
            this.box5.Location = new System.Drawing.Point(230, 315);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(290, 25);
            this.box5.TabIndex = 52;
            this.box5.Visible = false;
            // 
            // box4
            // 
            this.box4.Location = new System.Drawing.Point(230, 275);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(290, 25);
            this.box4.TabIndex = 51;
            this.box4.Visible = false;
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(230, 187);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(290, 25);
            this.box3.TabIndex = 50;
            this.box3.Visible = false;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(230, 134);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(290, 25);
            this.box2.TabIndex = 49;
            this.box2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(40, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "취득가액 :";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(147, 45);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(290, 25);
            this.box1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "취득가액외  포함된 것을 체크하여 입력해주세요.";
            // 
            // clsBtn
            // 
            this.clsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clsBtn.Font = new System.Drawing.Font("굴림", 11F);
            this.clsBtn.Location = new System.Drawing.Point(382, 536);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(137, 42);
            this.clsBtn.TabIndex = 68;
            this.clsBtn.Text = "현재창 종료";
            this.clsBtn.UseVisualStyleBackColor = false;
            this.clsBtn.Click += new System.EventHandler(this.rsltBtn_Click);
            // 
            // achiDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 620);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.rsltBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Name = "achiDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "achiDetailForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button rsltBtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box7;
        private System.Windows.Forms.TextBox box6;
        private System.Windows.Forms.TextBox box5;
        private System.Windows.Forms.TextBox box4;
        private System.Windows.Forms.TextBox box3;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clsBtn;
    }
}