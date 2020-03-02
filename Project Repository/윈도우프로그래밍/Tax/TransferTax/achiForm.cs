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
    public partial class achiForm : Form
    {
        int achi, result;
        achiDetailForm adf; //취득가액 상세폼인 adf 선언
        achiCal ac; //취득세 계산 클래스 ac 선언
        public achiForm()
        {
            InitializeComponent();
            ac = new achiCal(); 
        }

        //취득가액을 상세입력하기 위해 상세 폼을 띄우는 버튼
        private void achiDetailBtn_Click(object sender, EventArgs e)
        {
            int total; 

            adf = new achiDetailForm(); //취득가액 상세폼 adf 생성
            this.AddOwnedForm(adf); //취득세 폼(achiForm)이 취득가액 상세폼 adf를 소유
            adf.ShowDialog();

            total = int.Parse(achiTxt.Text);
            achi = total;
            ac.setAchi(achi);
            achiTxt.Text = String.Format("{0:#,###}", achi);
        }

        //해당되는 취득유형을 선택함에 따라 세율을 결정해주는 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            int select;            

            select = comboBox1.SelectedIndex;

            if (select == 0)
            {                
                ac.setPer(0.01);
            }
            else if (select == 1)
            {
                ac.setPer(0.02);
            }
            else if (select == 2)
            {
                ac.setPer(0.03);
            }
            else if (select == 3)
            {
                ac.setPer(0.028);
            }
            else if (select == 4)
            {
                ac.setPer(0.035);
            }
            else if (select == 5)
            {
                ac.setPer(0.028);
            }
            else if (select == 6)
            {
                ac.setPer(0.028);
            }
            else if (select == 7)
            {
                ac.setPer(0.023);
            }

            result = ac.achiResult();
            resultBox.Text = String.Format("{0:#,###}", result);
        }

        //메인메뉴로 돌아가기 위한 폼 종료
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    
    }
}
