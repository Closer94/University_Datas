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
    public partial class compForm : Form
    {
        long pub, stand, result; //종부세는 금액이 크기에 int보다 long형으로 선언
        double per;
        compCal cc; //종부세 계산해주는 클래스 cc 선언
        public compForm()
        {
            InitializeComponent();
            cc = new compCal();
        }

        //해당하는 체크박스를 체크했을때 콤보박스와 입력 버튼이 등장하는 이벤트 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = sender as CheckBox;

            if (ch.Name.Equals(checkBox1.Name))
            {
                comboBox1.Visible = !comboBox1.Visible;
                btn4.Visible = !btn4.Visible;
            }
            else if(ch.Name.Equals(checkBox2.Name))
            {
                comboBox2.Visible = !comboBox2.Visible;
                btn5.Visible = !btn5.Visible;
            }
        }

        //
        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            
            //주택 공시가격 합계액을 입력하는 버튼
            if (bt.Name.Equals(btn1.Name))
            {
                if (pubBox.Text.Length == 0)
                {
                    MessageBox.Show("주택 공시가격 합계액 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pub = long.Parse(pubBox.Text);
                    cc.setPub(pub);
                    pubBox.Text = String.Format("{0:#,###}", pub);
                }

            }
            //공시가격 합계액에 추가 연산 과정을 거쳐 과세표준 텍스트 박스에 금액이 나오는 버튼
            else if (bt.Name.Equals(btn2.Name))
            {
                stand = (long)((pub - 600000000) * 0.8);
                cc.setStand(stand);
                stndBox.Text = String.Format("{0:#,###}", stand);
            }
            //세율을 입력하는 버튼
            else if (bt.Name.Equals(btn3.Name))
            {
                if (perBox.Text.Length == 0)
                {
                    MessageBox.Show("세율을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    per = double.Parse(perBox.Text);
                    cc.setPer1(per);

                }
            }
            //나이 선택시 해당하는 공제율을 추가적으로 연산에 넣어준다.
            else if (bt.Name.Equals(btn4.Name))
            {
                int select;

                select = comboBox1.SelectedIndex;
                if (select == 0)
                {
                    cc.setPer2(0.1);
                }
                else if (select == 1)
                {
                    cc.setPer2(0.2);
                }
                else if (select == 2)
                {
                    cc.setPer3(0.3);
                }                            
                
            }
            //해당하는 보유기간에 따른 공제율을 추가적으로 연산에 넣어준다.
            else if (bt.Name.Equals(btn5.Name))
            {
                int select;

                select = comboBox2.SelectedIndex;

                if (select == 0)
                {
                    cc.setPer3(0.2);
                }
                else if (select == 1)
                {
                    cc.setPer3(0.4);
                }

            }
            //산출세액 계산하는 버튼
            else if (bt.Name.Equals(btn6.Name))
            {
                result = cc.totalResult();
                resultBox.Text = String.Format("{0:#,###}", result); 
            }
        }
       
        //메인메뉴로 돌아가기위한 폼 종료 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    
    }
}
