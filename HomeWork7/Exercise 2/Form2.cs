using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class Form2 : Form
    {
        Form1 mf;
        int input, key;
        public Form2(Form1 f)
        {
            InitializeComponent();
            mf = f;
            lblText.Text = "Введите число";
            btOK.Text = "OK";
            lblText.Left = (this.Size.Width - lblText.Width) / 2;
            tbInput.Left = (this.Size.Width - tbInput.Width) / 2;
            btOK.Left = (this.Size.Width - btOK.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = int.TryParse(tbInput.Text, out input);
            if (flag)
            {
                key = Form1.key;
                tbInput.Text = null;
                this.Visible = false;
                if (input > key) mf.lblAnsw.Text = "Меньше";
                else if (input < key) mf.lblAnsw.Text = "Больше";
                else
                {
                    mf.lblAnsw.Text = "Ты угадал!";
                    mf.btTry.Enabled = false;
                }
                mf.lblAnsw.Left = (mf.Size.Width - mf.lblAnsw.Width) / 2;
            }
        }
    }
}
