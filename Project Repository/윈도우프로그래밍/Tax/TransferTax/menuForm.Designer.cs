namespace TransferTax
{
    partial class menuForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.trnsBtn = new System.Windows.Forms.Button();
            this.compBtn = new System.Windows.Forms.Button();
            this.acquBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trnsBtn
            // 
            this.trnsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trnsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trnsBtn.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trnsBtn.Location = new System.Drawing.Point(192, 266);
            this.trnsBtn.Name = "trnsBtn";
            this.trnsBtn.Size = new System.Drawing.Size(252, 52);
            this.trnsBtn.TabIndex = 0;
            this.trnsBtn.Text = "양도소득세";
            this.trnsBtn.UseVisualStyleBackColor = false;
            this.trnsBtn.Click += new System.EventHandler(this.trnsBtn_Click);
            // 
            // compBtn
            // 
            this.compBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.compBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.compBtn.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.compBtn.Location = new System.Drawing.Point(192, 334);
            this.compBtn.Name = "compBtn";
            this.compBtn.Size = new System.Drawing.Size(252, 52);
            this.compBtn.TabIndex = 1;
            this.compBtn.Text = "종합부동산세";
            this.compBtn.UseVisualStyleBackColor = false;
            this.compBtn.Click += new System.EventHandler(this.compBtn_Click);
            // 
            // acquBtn
            // 
            this.acquBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.acquBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acquBtn.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.acquBtn.Location = new System.Drawing.Point(192, 199);
            this.acquBtn.Name = "acquBtn";
            this.acquBtn.Size = new System.Drawing.Size(252, 52);
            this.acquBtn.TabIndex = 2;
            this.acquBtn.Text = "취득세";
            this.acquBtn.UseVisualStyleBackColor = false;
            this.acquBtn.Click += new System.EventHandler(this.acquBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("한컴 소망 B", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "주택에 대한 세금계산헬퍼 입니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("한컴 소망 B", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "계산할 세금의 종류를 선택해 주세요.";
            // 
            // clsBtn
            // 
            this.clsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clsBtn.Font = new System.Drawing.Font("문체부 돋음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clsBtn.Location = new System.Drawing.Point(192, 401);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(252, 52);
            this.clsBtn.TabIndex = 5;
            this.clsBtn.Text = "프로그램 종료";
            this.clsBtn.UseVisualStyleBackColor = false;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 485);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acquBtn);
            this.Controls.Add(this.compBtn);
            this.Controls.Add(this.trnsBtn);
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "세금 계산";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trnsBtn;
        private System.Windows.Forms.Button compBtn;
        private System.Windows.Forms.Button acquBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clsBtn;
    }
}

