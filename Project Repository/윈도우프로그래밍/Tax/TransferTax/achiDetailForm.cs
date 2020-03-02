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
    public partial class achiDetailForm : Form
    {
        int[] money; //각각의 텍스트박스에 입력된 금액을 저장하는 money배열
        int total; //총 취득가액을 저장할 total 변수
        public achiDetailForm()
        {
            InitializeComponent();
            money = new int[7];
            for (int i = 0; i < money.Length; i++)
            {
                money[i] = 0;
            }
            total = 0;
        }

        //취득가액 외에 포함된 금액이 있으면 체크박스에 체크
        //체크하면 금액 입력 텍스트박스와 버튼이 나온다.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = sender as CheckBox;

            if (ch.Name.Equals(checkBox1.Name))
            {
                box2.Visible = !box2.Visible;
                btn2.Visible = !btn2.Visible;
            }
            else if (ch.Name.Equals(checkBox2.Name))
            {
                box3.Visible = !box3.Visible;
                btn3.Visible = !btn3.Visible;
            }
            else if (ch.Name.Equals(checkBox3.Name))
            {
                box4.Visible = !box4.Visible;
                btn4.Visible = !btn4.Visible;
            }
            else if (ch.Name.Equals(checkBox4.Name))
            {
                box5.Visible = !box5.Visible;
                btn5.Visible = !btn5.Visible;
            }
            else if (ch.Name.Equals(checkBox5.Name))
            {
                box6.Visible = !box6.Visible;
                btn6.Visible = !btn6.Visible;
            }
            else if (ch.Name.Equals(checkBox6.Name))
            {
                box7.Visible = !box7.Visible;
                btn7.Visible = !btn7.Visible;
            }
        }

        //해당하는 금액을 텍스트박스에 입력하고 그 금액을 저장하기위한 입력버튼
        private void btn1_Click(object sender, EventArgs e)
        {
            int num;

            Button bt = sender as Button;

            if (bt.Name.Equals(btn1.Name))
            {
                if (box1.Text.Length == 0)
                {
                    MessageBox.Show("취득가액을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box1.Text);
                    money[0] = num;
                    box1.Text = String.Format("{0:#,###}", num);
                }
            }
            else if (bt.Name.Equals(btn2.Name))
            {
                if (box2.Text.Length == 0)
                {
                    MessageBox.Show("건설자금 이자를 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box2.Text);
                    money[1] = num;
                    box2.Text = String.Format("{0:#,###}", num);
                }
            }
            else if (bt.Name.Equals(btn3.Name))
            {
                if (box3.Text.Length == 0)
                {
                    MessageBox.Show("할부이자, 연체료를 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box3.Text);
                    money[2] = num;
                    box3.Text = String.Format("{0:#,###}", num);
                }
            }
            else if (bt.Name.Equals(btn4.Name))
            {
                if (box4.Text.Length == 0)
                {
                    MessageBox.Show("용역비, 수수료를 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box4.Text);
                    money[3] = num;
                    box4.Text = String.Format("{0:#,###}", num);
                }
            }
            else if (bt.Name.Equals(btn5.Name))
            {
                if (box5.Text.Length == 0)
                {
                    MessageBox.Show("채무인수액을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box5.Text);
                    money[4] = num;
                    box5.Text = String.Format("{0:#,###}", num);
                }
            }
            else if (bt.Name.Equals(btn6.Name))
            {
                if (box6.Text.Length == 0)
                {
                    MessageBox.Show("주택채권 매각차손을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box6.Text);
                    money[5] = num;
                    box6.Text = String.Format("{0:#,###}", num);
                }
            }
            else if (bt.Name.Equals(btn7.Name))
            {
                if (box7.Text.Length == 0)
                {
                    MessageBox.Show("기타를 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box7.Text);
                    money[6] = num;
                    box7.Text = String.Format("{0:#,###}", num);
                }
            }
            
        }

        //취득가액과 취득가액 외의 금액의 총액을 계산해주는 이벤트
        private void btn8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < money.Length; i++)
            {
                if (money[i] != 0)
                {
                    total += money[i];
                }
            }

            resultBox.Text = String.Format("{0:#,###}", total);
        }

        //총 취득가액을 achiForm의 achiTxt에 전달해주고 폼을 종료시켜주는 이벤트
        private void rsltBtn_Click(object sender, EventArgs e)
        {
            ((achiForm)Owner).achiTxt.Text = total.ToString();
            Close();
        }

        
    }
}
