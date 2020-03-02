using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferTax
{
    public partial class startForm : Form
    {
        
        public startForm()
        {
            InitializeComponent();
        }

        //메인 메뉴기 나오게 해준다.
        private void button1_Click(object sender, EventArgs e)  
        {
            Close();
        }

        //종료하는 버튼
        private void button2_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "세금계산기", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
