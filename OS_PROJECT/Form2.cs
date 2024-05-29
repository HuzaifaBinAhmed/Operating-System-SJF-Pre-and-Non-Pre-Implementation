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
    public partial class Form2 : Form
    {
        public int pre;
        public int y;
        private Random random;
        public Form2(int i,int PreNonPre)
        {
            
            y = i;
            InitializeComponent();
            pre = PreNonPre;
            random = new Random();
            int yStart = 50;
            int xLabel = 50;
            int xTextBox = 150;
            int xArrivalTextBox = 250;
            int labelYOffset = 20;
            Label[] labels = new Label[i];


            System.Windows.Forms.Label burstTimeLabel = new System.Windows.Forms.Label();
            burstTimeLabel.Text = "Burst Time";
            burstTimeLabel.BackColor = System.Drawing.Color.Transparent;
            burstTimeLabel.BringToFront();
            burstTimeLabel.Location = new System.Drawing.Point(xTextBox, yStart - labelYOffset);
            this.Controls.Add(burstTimeLabel);

            System.Windows.Forms.Label arrivalTimeLabel = new System.Windows.Forms.Label();
            arrivalTimeLabel.Text = "Arrival Time";
            arrivalTimeLabel.BackColor = System.Drawing.Color.Transparent;
            arrivalTimeLabel.Location = new System.Drawing.Point(xArrivalTextBox, yStart - labelYOffset);
            this.Controls.Add(arrivalTimeLabel);

            for (int j = 0; j < i; j++)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Text = "P" + j.ToString();
                label.BackColor = System.Drawing.Color.Transparent;
                label.Location = new System.Drawing.Point(xLabel, yStart + j * 30);
                this.Controls.Add(label);
                labels[j] = label;
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + j.ToString();
                textBox.Location = new System.Drawing.Point(xTextBox, yStart + j * 30);
                string p = "textBox" + 0;

                textBox.Text = GenerateRandomNumber().ToString();
                this.Controls.Add(textBox);

                System.Windows.Forms.TextBox arrivalTimeTextBox = new System.Windows.Forms.TextBox();
                arrivalTimeTextBox.Name = "arrivalTextBox" + j.ToString();
                arrivalTimeTextBox.Location = new System.Drawing.Point(xArrivalTextBox, yStart + j * 30);

                    arrivalTimeTextBox.Text = GenerateRandomNumber().ToString();

                this.Controls.Add(arrivalTimeTextBox);
            }
            PictureBox pictureBox = new PictureBox();

            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            string username = Environment.UserName;
            string imagePath = $@"C:\Users\{username}\Desktop\images.jpeg";

            try
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
            this.Controls.Add(pictureBox);

            pictureBox.SendToBack();
            burstTimeLabel.Parent = pictureBox;
            arrivalTimeLabel.Parent = pictureBox;
            burstTimeLabel.ForeColor = Color.White;
            arrivalTimeLabel.ForeColor = Color.White;
            for (int z = 0; z < i; z++)
            {
                labels[z].Parent = pictureBox;
                labels[z].ForeColor = Color.White;
            }

        }
        private int GenerateRandomNumber()
        {
            return random.Next(1, 10); 
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btndone_Click(object sender, EventArgs e)
        {

            int[] burstTimes = new int[y];
            int[] arrivalTimes = null;
            
                arrivalTimes = new int[y];
            
            for (int j = 0; j < y; j++)
            {
                TextBox textBox = Controls.Find("textBox" + j.ToString(), true).FirstOrDefault() as TextBox;

                if (textBox != null && int.TryParse(textBox.Text, out int burstTime))
                {
                    burstTimes[j] = burstTime;
                }
                else
                {
                    
                }

                    TextBox arrivalTextBox = Controls.Find("arrivalTextBox" + j.ToString(), true).FirstOrDefault() as TextBox;
                    if (arrivalTextBox != null && int.TryParse(arrivalTextBox.Text, out int arrivalTime))
                    {
                        arrivalTimes[j] = arrivalTime;
                    }
                    else
                    {
                    }
                
            }

            SJF fm = new SJF(pre,burstTimes, arrivalTimes);
            fm.Show();
        }
    }
}
