using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form2 : Form
    {
        Form1 mf;
        public Form2(Form1 f)
        {
            mf = f;
            InitializeComponent();

        }

        bool flag;
        long x;

        private void btnOk_Click(object sender, EventArgs e)
        {

            flag = Int64.TryParse(textBox.Text, out x);
            Form1.res = x;
            if (!flag)
                lblMes.Visible = true;
            else
            {
                Form1.minSteps = Min(x);
                if (Form1.minSteps % 10 == 1)
                    mf.lblSteps.Text = $"За {Form1.minSteps} ход";
                else if (Form1.minSteps % 10 > 1 && 
                         Form1.minSteps % 10 < 5)
                    mf.lblSteps.Text = $"За {Form1.minSteps} хода";
                else if ((Form1.minSteps % 10 > 4 && Form1.minSteps % 10 <= 9) ||
                         (Form1.minSteps % 10 == 0))
                    mf.lblSteps.Text = $"За {Form1.minSteps} ходов";


                mf.lblSteps.Left = (mf.btnPlus.Left - mf.lblSteps.Width) / 2;
                mf.lblQuest.Left = (mf.btnPlus.Left - mf.lblQuest.Width) / 2;
                mf.lblQuestMsg.Left = (mf.btnPlus.Left - mf.lblQuestMsg.Width) / 2;
                mf.lblQuestMsg.Visible = true;
                mf.lblNum.Left = (mf.btnPlus.Left - mf.lblNum.Width) / 2;
                mf.lblSteps.Visible = true;
                mf.lblQuest.Text = Form1.res.ToString();
                mf.btnUndo.Enabled = true;
                this.Close();
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox.Text = "";
            lblMes.Visible = false;
        }

        private static int Min(long x)
        {
            int steps = 0;
            bool flag = false;
            while (!flag)
            {
                steps++;
                if (x % 2 == 0) x = x / 2;
                else x--;
                if (x == 0) flag = true;
            }
            return steps;
        }
    }   
}
