using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Task
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.n.ToString();
            if (textBox1.Text.Length != 0)
            {
                resultLabel.Text = "Самое большое число: " + Logic.Solve(int.Parse(textBox1.Text));
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n))
            {
                resultLabel.Text = "Самое большое число: " + Logic.Solve(n);
                Properties.Settings.Default.n = textBox1.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("В строке должны быть только цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 3)
            {
                findButton.Enabled = true;
            }
            else
            {
                findButton.Enabled = false;
            }
        }
    }
}
