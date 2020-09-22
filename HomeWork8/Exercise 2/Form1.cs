using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Семиков Сергей

//Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Left = (Width - numericUpDown1.Width) / 2;
            textBox1.Left = (Width - textBox1.Width) / 2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                { 
                    numericUpDown1.Value = int.Parse(textBox1.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Введите натуральное число", "Неверный формат");
                    textBox1.Clear();
                    numericUpDown1.Value = 0;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Введено слишком большое число", "Переполнение");
                    textBox1.Clear();
                    numericUpDown1.Value = 0;
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Введено слишком большое число", "Переполнение");
                    textBox1.Clear();
                    numericUpDown1.Value = 0;
                }
            }
        }
    }
}
