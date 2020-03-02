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
    public partial class TransForm : Form
    {
        int trns, acqu, need; //양도가액, 취득가액, 필요경비
        transCal tc; //계산을 도와줄 transCal 클래스의 tc 선언
        acquDetailForm ad; //취득가액을 세부적으로 입력할 수 있는 폼 acquDetailForm ad선언

        public TransForm()
        {
            InitializeComponent();
            tc = new transCal(); 
            
        }

        //양도가액 입력하는 버튼
        private void trnsBtn_Click(object sender, EventArgs e)
        {
            trns = 0;
            if (trnsTxt.Text.Length == 0)
            {
                MessageBox.Show("양도가액 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                trns = int.Parse(trnsTxt.Text);
                tc.setTrns(trns);
                trnsTxt.Text = String.Format("{0:#,###}", trns);
            }
        }
        
        //취득가액의 상세입력을 처리하는 버튼
        private void acquDetailBtn_Click(object sender, EventArgs e)
        {
            int total;
            ad = new acquDetailForm();
            this.AddOwnedForm(ad);
            ad.ShowDialog();

            total = int.Parse(acquTxt.Text);
            acqu = total;
            tc.setAcqu(acqu);
            acquTxt.Text = String.Format("{0:#,###}", acqu);
        }

        //필요경비 입력하는 버튼
        private void needBtn_Click(object sender, EventArgs e)
        {
            need = 0;
            if (acquTxt.Text.Length == 0)
            {
                MessageBox.Show("필요경비를 입력해주세요", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                need = int.Parse(needTxt.Text);
                tc.setNeed(need);
                needTxt.Text = String.Format("{0:#,###}", need);
            }
        }

        //양도차익 계산해주는 이벤트
        private void minusBtn_Click(object sender, EventArgs e)
        {
            int result = tc.minuCal();
            minusTxt.Text = String.Format("{0:#,###}", result);
        }

        //선택한 보유기간에 따른 공제율을 tc객체에 넣어서 장기보유특별공제액을 계산해주는 이벤트
        private void per1Btn_Click(object sender, EventArgs e)
        {
            int select;

            select = comboBox1.SelectedIndex;
            if (select == 0)
            {
                tc.setPer1(0);
            }
            else if (select == 1)
            {
                tc.setPer1(0.06);
            }
            else if (select == 2)
            {
                tc.setPer1(0.08);
            }
            else if (select == 3)
            {
                tc.setPer1(0.1);
            }
            else if (select == 4)
            {
                tc.setPer1(0.12);
            }
            else if (select == 5)
            {
                tc.setPer1(0.14);
            }
            else if (select == 6)
            {
                tc.setPer1(0.16);
            }
            else if (select == 7)
            {
                tc.setPer1(0.18);
            }
            else if (select == 8)
            {
                tc.setPer1(0.20);
            }
            else if (select == 9)
            {
                tc.setPer1(0.22);
            }
            else if (select == 10)
            {
                tc.setPer1(0.24);
            }
            else if (select == 11)
            {
                tc.setPer1(0.26);
            }
            else if (select == 12)
            {
                tc.setPer1(0.28);
            }
            else if (select == 13)
            {
                tc.setPer1(0.3);
            }

            int result;

            result = tc.longCal();

            if (result == 0)
            {
                longTxt.Text = "0";
            }
            else
            {
                longTxt.Text = String.Format("{0:#,###}", result);
            }
        }

        //양도소득금액을 계산해주는 이벤트
        private void achvBtn_Click(object sender, EventArgs e)
        {
            int result;
                
            result = tc.achCal();
            if (result == 0)
            {
                stndTxt.Text = "0"; //공제액으로 인한 세금을 안내도 되는 상황
            }
            else
            {
                achvTxt.Text = String.Format("{0:#,###}", result);
            }
        }

        //양도소득 과세표준을 계산해주는 이벤트
        private void stndBtn_Click(object sender, EventArgs e)
        {
            int result;

            result = tc.stndCal();
            if (result == 0)
            {                
                stndTxt.Text = "0"; //공제액으로 인한 세금을 안내도 되는 상황
            }
            else
            {
                stndTxt.Text = String.Format("{0:#,###}", result);
            }
        }

        //세율을 처리하는 이벤트
        private void per2Btn_Click(object sender, EventArgs e)
        {
            int select;

            select = comboBox2.SelectedIndex;
            if (select == 0)
            {
                tc.setPer2(0.7);
            }
            else if (select == 1)
            {
                tc.setPer2(0.4);
            }
            else if (select == 2)
            {
                tc.setPer2(0.15);
            }

            int result;
            result = tc.rsltCal();

            rsltTxt.Text = String.Format("{0:#,###}", result);
        }
        
        //메인메뉴로 돌아가는 이벤트 
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
