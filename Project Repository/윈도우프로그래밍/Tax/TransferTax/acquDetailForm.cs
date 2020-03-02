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
    public partial class acquDetailForm : Form
    {
        int[] money; //각각의 텍스트박에 입력된 금액을 저장하는 money배열
        int total; //총 취득가액을 저장할 total 변수

        public acquDetailForm()
        {
            InitializeComponent();
            money = new int[8];
            for (int i = 0; i < money.Length; i++)
            {
                money[i] = 0;
            }
            total = 0;
        }

        //체크박스를 체크했을때 금액을 입력하는 텍스트 박스와 입력하는 버튼을 보이게 해주는 이벤트
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Name.Equals(checkBox1.Name))
            {

                box2.Visible = !box2.Visible;
                btn2.Visible = !btn2.Visible;

            }
            else if (cb.Name.Equals(checkBox2.Name))
            {

                box3.Visible = !box3.Visible;
                btn3.Visible = !btn3.Visible;

            }
            else if (cb.Name.Equals(checkBox3.Name))
            {

                box4.Visible = !box4.Visible;
                btn4.Visible = !btn4.Visible;

            }
            else if (cb.Name.Equals(checkBox4.Name))
            {

                box5.Visible = !box5.Visible;
                btn5.Visible = !btn5.Visible;

            }
            else if (cb.Name.Equals(checkBox5.Name))
            {

                box6.Visible = !box6.Visible;
                btn6.Visible = !btn6.Visible;

            }
            else if (cb.Name.Equals(checkBox6.Name))
            {

                box7.Visible = !box7.Visible;
                btn7.Visible = !btn7.Visible;

            }
            else if (cb.Name.Equals(checkBox7.Name))
            {
                box8.Visible = !box8.Visible;
                btn8.Visible = !btn8.Visible;

            }
        }
        //btn1일때는 취득가액을 입력하게 해주는 이벤트 핸들러임과 동시에
        //체크한 체크박스에 해당하는 종류의 금액이 입력되면 그 금액을 money배열에 값을 넣어주는 이벤트
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
                    MessageBox.Show("취득세액을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("등록면허세액을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("부동산중개보수액을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("법무사비용을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("소송,화해비용 을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("컨설팅비용을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box7.Text);
                    money[6] = num;
                    box7.Text = String.Format("{0:#,###}", num);
                }
            }
            else if (bt.Name.Equals(btn8.Name))
            {
                if (box8.Text.Length == 0)
                {
                    MessageBox.Show("기타란을 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    num = int.Parse(box8.Text);
                    money[7] = num;
                    box8.Text = String.Format("{0:#,###}", num);
                }
            }
        }

        //취득가액과 체크한 항목의 금액을 총 합산하여 총 취득가액에 금액을 표시해주는 이벤트
        private void btn9_Click(object sender, EventArgs e)
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

        //TransForm에 "2. 취득가액" 텍스트 박스에 금액이 전달되 이벤트
        private void rsltBtn_Click(object sender, EventArgs e)
        {
            ((TransForm)Owner).acquTxt.Text = total.ToString();
            Close();
        }
    }
}
