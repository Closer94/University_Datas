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
    public partial class menuForm : Form
    {
        compForm cf;
        startForm sf; //처음시작할때 뜨는 폼 선언
        exitForm ef; //프로그램 종료시 뜨는 폼 선언
        achiForm af;
        public menuForm()
        {
            
            InitializeComponent();

        }

        //메뉴폼이 뜨기전에 시작할때 뜨는 폼을 우선적으로 띄어준다.
        private void menuForm_Load(object sender, EventArgs e) 
        {
            sf = new startForm();
            sf.Size = new System.Drawing.Size(523, 560);
            sf.ShowDialog();
            
        }

        
        //양도소득세 버튼을 눌렀을때
        private void trnsBtn_Click(object sender, EventArgs e) //양도소득세 버튼
        {
            TransForm tf = new TransForm();
            tf.Show();
        }
        
        //종료버튼을 눌렀을때
        private void clsBtn_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "세금계산기", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ef = new exitForm();
                ef.ShowDialog();                
            }
        }

        //취득세 버튼 눌렀을떄
        private void acquBtn_Click(object sender, EventArgs e)
        {
            af = new achiForm();
            af.ShowDialog();

        }

        //종합부동산세 버튼 눌렀을때
        private void compBtn_Click(object sender, EventArgs e)
        {
            cf = new compForm();
            cf.ShowDialog();
        }
    }
}
