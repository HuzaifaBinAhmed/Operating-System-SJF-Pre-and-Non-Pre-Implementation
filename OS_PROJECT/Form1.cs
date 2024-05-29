using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {

        }

        private void btndone_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter a value before pressing done");
            }
            else
            {
                int i = int.Parse(textBox1.Text);
                if (i > 15)
                {
                    i = 15;
                }
                int x = 0;
                if (rdnPre.Checked)
                {
                    x = 1;
                }
                else if (rdnNon.Checked)
                {
                    x = 0;
                }
                else
                {
                    MessageBox.Show("Select a option before pressing done");
                    return;
                }
                Form2 fm = new Form2(i, x);
                fm.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            rdnPre.Parent = pictureBox1;
            rdnNon.Parent = pictureBox1;
            btndone.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            rdnPre.BackColor = System.Drawing.Color.Transparent;
            rdnNon.BackColor = System.Drawing.Color.Transparent;
            btndone.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;

        }
    }
}
