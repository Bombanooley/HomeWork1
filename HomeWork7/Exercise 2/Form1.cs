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
    public partial class Form1 : Form
    {
        Random r = new Random();
        public static int key;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2(this);
            key = r.Next(1,100);
            lblAnsw.Text = "Угадай число";
            lblAnsw.Left = (this.Size.Width - lblAnsw.Width) / 2;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            key = r.Next(1,100);
            btTry.Enabled = true;
            lblAnsw.Text = "Угадай число";
            lblAnsw.Left = (this.Size.Width - lblAnsw.Width) / 2;
        }

        private void btTry_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }
    }
}
