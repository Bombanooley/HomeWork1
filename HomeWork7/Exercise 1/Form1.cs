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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            res = 0;
            form2 = new Form2(this);
            btnUndo.Left = (btnThrow.Left - btnUndo.Width) / 2;
            stack.Push(0);
            lblNum.Left = (btnPlus.Left - lblNum.Width) / 2;
        }
        public static long res;
        string msg = "Количество ходов: ";
        public static string msgQ;
        public static int minSteps;
        uint count;
        Stack<long> stack = new Stack<long>();

        Form2 form2;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblNum.Text = (long.Parse(lblNum.Text) + 1).ToString();
            lblCount.Text = msg + (++count).ToString();
            stack.Push(long.Parse(lblNum.Text));
            btnUndo.Enabled = true;
            lblNum.Left = (btnPlus.Left - lblNum.Width) / 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblNum.Text = (long.Parse(lblNum.Text) * 2).ToString();
            lblCount.Text = msg + (++count).ToString();
            stack.Push(long.Parse(lblNum.Text));
            btnUndo.Enabled = true;
            lblNum.Left = (btnPlus.Left - lblNum.Width) / 2;
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            lblNum.Text = "0";
            lblNum.Left = (btnPlus.Left - lblNum.Width) / 2;
            count = 0;
            lblCount.Text = msg + count.ToString();
            btnUndo.Enabled = false;
            stack.Clear();
            stack.Push(0);

        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            count--;
            stack.Pop();
            if (count == 0) btnUndo.Enabled = false;
            lblCount.Text = msg + count.ToString();
            lblNum.Text = stack.Peek().ToString();
            lblNum.Left = (btnPlus.Left - lblNum.Width) / 2;
        }
    }
}
