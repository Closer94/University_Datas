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
    public partial class exitForm : Form
    {
        public exitForm()
        {
            InitializeComponent();
        }
        
        //"적게 일하고 돈 많이 벌으러 나가기" 버튼 눌렀을때
        private void button1_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}
