using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace OS_PROJECT
{
    public partial class SJF : Form
    {
        public int PreNonPre;
        public int[] arrr;
        string ganttchart;
        public int[] arrival;
        public int countt=0;
        public int c = 0;
        int length = 0;
        public bool[] compl;
        public int time = 0;
        public bool[] remaining;

        public SJF(int x,int[] arr,int[] arrarival)
        {
            InitializeComponent();
            PreNonPre = x;
            arrr = arr;
            arrival = arrarival;
            length = arr.Length;
        }

        private void SJF_Load(object sender, EventArgs e)
        {
            lblProcess.MaximumSize = new Size(this.ClientSize.Width - 26, 0);
            lblwaitingg.MaximumSize = new Size(this.ClientSize.Width - 26, 0);
            lblturnaround.MaximumSize = new Size(this.ClientSize.Width - 26, 0);
            lblProcess.Parent = pictureBox1;
            lblProcess.BackColor = System.Drawing.Color.Transparent;
            lblwaitingg.Parent = pictureBox1;
            lblwaitingg.BackColor = System.Drawing.Color.Transparent;
            lblturnaround.Parent = pictureBox1;
            lblturnaround.BackColor = System.Drawing.Color.Transparent;
            avgwaiting.Parent = pictureBox1;
            avgwaiting.BackColor = System.Drawing.Color.Transparent;
            avgturnaround.Parent = pictureBox1;
            avgturnaround.BackColor = System.Drawing.Color.Transparent;
            lblProcess.ForeColor = Color.White;
            lblwaitingg.ForeColor = Color.White;
            lblturnaround.ForeColor = Color.White;
            avgturnaround.ForeColor = Color.White;
            avgwaiting.ForeColor = Color.White;


        }
        private int GetMinBurstIndex(int[] burstTimes, int[] arrivalTimes, int currentTime)
        {
            int minBurstIndex = -1;
            int minBurst = 0;
            for (int i = 0; i < burstTimes.Length; i++)
            {
                if (burstTimes[i] > 0 && arrivalTimes[i] <= currentTime && burstTimes[i] > minBurst)
                {
                    minBurst = burstTimes[i];
                    minBurstIndex = i;
                }
            }
            return minBurstIndex;
        }

        private bool AnyBurstRemaining(int[] burstTimes)
        {
            foreach (int burstTime in burstTimes)
            {
                if (burstTime > 0)
                {
                    return true;
                }
            }
            return false;
        }
        void Premeptive()
        {
            int n = arrr.Length;
            int[] remainingTime = new int[n];
            Array.Copy(arrr, remainingTime, n);

            int[] waitingTime = new int[n];
            int[] turnaroundTime = new int[n];
            int[] completionTime = new int[n];
            int currentTime = 0;
            int completed = 0;
            bool[] isCompleted = new bool[n];

            while (completed != n)
            {
                int minBurstIndex = GetMinBurstIndex(remainingTime, arrival, currentTime);
                if (minBurstIndex == -1)
                {
                    lblProcess.Text = "Idle";
                    currentTime = arrival[GetMinArrivalIndex(arrival, n)];
                }
                else
                {
                    currentTime++;
                    ganttchart += $"P{minBurstIndex} |({currentTime} ms)| ";
                    lblProcess.Text = ganttchart;
                    txtCPU.Text = $"P{minBurstIndex}";
                    txtProcesses.Text = "";

                    int arrmin = arrival[minBurstIndex];
                    for(int i = 0; i < arrival.Length; i++)
                    {
                        if(arrival[i] < arrmin)
                        {
                            arrmin = arrival[i];
                        }
                    }
                    for (int o = 0; o < arrr.Length; o++)
                    {
                        if (o == minBurstIndex)
                        {
                            continue;
                        }
                        else if(isCompleted[o] != true && arrival[minBurstIndex] < arrmin )
                        {
                            txtProcesses.Text += $"P{o}";
                        }
                    }
                    lbltimepassed.Text = Convert.ToString(currentTime);
                    MessageBox.Show("One Second Passed");
                    remainingTime[minBurstIndex]--;

                    if (remainingTime[minBurstIndex] == 0)
                    {
                        isCompleted[minBurstIndex] = true;
                        completed++;
                        completionTime[minBurstIndex] = currentTime;
                        turnaroundTime[minBurstIndex] = completionTime[minBurstIndex] - arrival[minBurstIndex];
                        waitingTime[minBurstIndex] = turnaroundTime[minBurstIndex] - arrr[minBurstIndex];
                        remainingTime[minBurstIndex] = 0;
                        
                    }
                }
            }

            double totalWaitingTime = 0;
            double totalTurnaroundTime = 0;

            for (int i = 0; i < n; i++)
            {
                totalWaitingTime += waitingTime[i];
                totalTurnaroundTime += turnaroundTime[i];
            }

            double avgWaitingTime = totalWaitingTime / n;
            double avgTurnaroundTime = totalTurnaroundTime / n;
            avgwaiting.Text = $"Average Waiting Time: {avgWaitingTime} ms";
            avgturnaround.Text = $"Average Turnaround Time: {avgTurnaroundTime} ms";
            lblturnaround.Text = "";

            for (int i = 0; i < n; i++)
            {
                lblwaitingg.Text += $"P{i} waiting time = {waitingTime[i]} ms | ";
                lblturnaround.Text += $"P{i} turnaround time = {turnaroundTime[i]} ms | ";
            }
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private int GetMinArrivalIndex(int[] arr)
        {
            int minArrivalIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minArrivalIndex])
                {
                    minArrivalIndex = i;
                }
            }
            return minArrivalIndex;
        }

        private int GetMinArrivalIndex(int[] arr, int count)
        {
            int minArrivalIndex = 0;
            for (int i = 1; i < count; i++)
            {
                if (arr[i] < arr[minArrivalIndex])
                {
                    minArrivalIndex = i;
                }
            }
            return minArrivalIndex;
        }
        private int GetMinBurstIndex(int[] arr)
        {
            int minBurstIndex = 0;
            int minBurst = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > minBurst)
                {
                    minBurst = arr[i];
                    minBurstIndex = i;
                }
            }
            return minBurstIndex;
        }
        void NonPreemptiveSJF()
        {
            compl = new bool[arrr.Length];
            int n = arrr.Length;
            int[] completionTime = new int[n];
            int[] waitingTime = new int[n];
            int[] turnaroundTime = new int[n];
            int[] remainingTime = new int[n];
            Array.Copy(arrr, remainingTime, n);

            int currentTime = 0;
            int completed = 0;

            while (completed < n)
            {
                int minBurstIndex = GetMinBurstIndex(remainingTime, arrival, currentTime);
                if (minBurstIndex == -1)
                {
                    currentTime++;
                    continue;
                }
                
                currentTime += arrr[minBurstIndex];
                compl[minBurstIndex] = true;
                completionTime[minBurstIndex] = currentTime;
                turnaroundTime[minBurstIndex] = completionTime[minBurstIndex] - arrival[minBurstIndex];
                waitingTime[minBurstIndex] = turnaroundTime[minBurstIndex] - arrr[minBurstIndex];
                c += arrr[minBurstIndex];
                ganttchart += $"P{minBurstIndex} |({c} ms)| ";
                lblProcess.Text = ganttchart;
                txtCPU.Text = $"P{minBurstIndex}";
                txtProcesses.Text = "";
                for (int o = 0; o < arrr.Length; o++)
                {
                    if (o == minBurstIndex)
                    {
                        continue;
                    }
                    else if (compl[o] != true )
                    {
                        txtProcesses.Text += $"P{o}";

                    }
                }
                lbltimepassed.Text = Convert.ToString(currentTime);
                MessageBox.Show("Continue");
                //MessageBox.Show($"P{minBurstIndex}, t={currentTime}");

                remainingTime[minBurstIndex] = int.MaxValue;
                completed++;

            }

            double totalWaitingTime = 0;
            double totalTurnaroundTime = 0;
            lblturnaround.Text = "";
            for (int i = 0; i < n; i++)
            {
                totalWaitingTime += waitingTime[i];
                totalTurnaroundTime += turnaroundTime[i];
                lblwaitingg.Text += $"P{i} waiting time = {waitingTime[i]} ms | ";
                lblturnaround.Text += $"P{i} turnaround time = {turnaroundTime[i]} ms | ";
            }

            double avgWaitingTime = totalWaitingTime / n;
            double avgTurnaroundTime = totalTurnaroundTime / n;
            avgwaiting.Text = $"Average Waiting Time: {avgWaitingTime} ms";
            avgturnaround.Text = $"Average Turnaround Time: {avgTurnaroundTime} ms";
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void btndebug_Click(object sender, EventArgs e)
        {
            if (countt == 0)
            {
                countt++;
                if (PreNonPre == 1)
                {
                    Premeptive();
                }
                else
                {
                    NonPreemptiveSJF();
                }
            }
            else
            {
                MessageBox.Show("can't run again give new processes");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblProcess_Click(object sender, EventArgs e)
        {

        }
    }
}