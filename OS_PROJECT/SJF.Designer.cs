
namespace OS_PROJECT
{
    partial class SJF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SJF));
            this.btndebug = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblwaitingg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblresponse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblturnaround = new System.Windows.Forms.Label();
            this.avgwaiting = new System.Windows.Forms.Label();
            this.avgturnaround = new System.Windows.Forms.Label();
            this.lblgantt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtProcesses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltimepassed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndebug
            // 
            this.btndebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndebug.Location = new System.Drawing.Point(515, 602);
            this.btndebug.Name = "btndebug";
            this.btndebug.Size = new System.Drawing.Size(288, 38);
            this.btndebug.TabIndex = 0;
            this.btndebug.Text = "Run";
            this.btndebug.UseVisualStyleBackColor = true;
            this.btndebug.Click += new System.EventHandler(this.btndebug_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(12, 67);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 24);
            this.lblProcess.TabIndex = 3;
            this.lblProcess.Click += new System.EventHandler(this.lblProcess_Click);
            // 
            // lblwaitingg
            // 
            this.lblwaitingg.AutoSize = true;
            this.lblwaitingg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaitingg.Location = new System.Drawing.Point(14, 207);
            this.lblwaitingg.Name = "lblwaitingg";
            this.lblwaitingg.Size = new System.Drawing.Size(0, 24);
            this.lblwaitingg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Waiting Time";
            // 
            // lblresponse
            // 
            this.lblresponse.AutoSize = true;
            this.lblresponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresponse.Location = new System.Drawing.Point(224, 236);
            this.lblresponse.Name = "lblresponse";
            this.lblresponse.Size = new System.Drawing.Size(0, 24);
            this.lblresponse.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 10;
            // 
            // lblturnaround
            // 
            this.lblturnaround.AutoSize = true;
            this.lblturnaround.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblturnaround.Location = new System.Drawing.Point(12, 342);
            this.lblturnaround.Name = "lblturnaround";
            this.lblturnaround.Size = new System.Drawing.Size(0, 24);
            this.lblturnaround.TabIndex = 11;
            // 
            // avgwaiting
            // 
            this.avgwaiting.AutoSize = true;
            this.avgwaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgwaiting.Location = new System.Drawing.Point(482, 554);
            this.avgwaiting.Name = "avgwaiting";
            this.avgwaiting.Size = new System.Drawing.Size(0, 24);
            this.avgwaiting.TabIndex = 12;
            // 
            // avgturnaround
            // 
            this.avgturnaround.AutoSize = true;
            this.avgturnaround.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgturnaround.Location = new System.Drawing.Point(482, 509);
            this.avgturnaround.Name = "avgturnaround";
            this.avgturnaround.Size = new System.Drawing.Size(0, 24);
            this.avgturnaround.TabIndex = 13;
            // 
            // lblgantt
            // 
            this.lblgantt.AutoSize = true;
            this.lblgantt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgantt.Location = new System.Drawing.Point(580, 9);
            this.lblgantt.Name = "lblgantt";
            this.lblgantt.Size = new System.Drawing.Size(161, 32);
            this.lblgantt.TabIndex = 14;
            this.lblgantt.Text = "Gantt Chart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1375, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Turnaround Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Average Time";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(18, 13);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(36, 17);
            this.lblCPU.TabIndex = 18;
            this.lblCPU.Text = "CPU";
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(79, 9);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(100, 22);
            this.txtCPU.TabIndex = 19;
            // 
            // txtProcesses
            // 
            this.txtProcesses.Location = new System.Drawing.Point(946, 8);
            this.txtProcesses.Name = "txtProcesses";
            this.txtProcesses.Size = new System.Drawing.Size(155, 22);
            this.txtProcesses.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ready Queue";
            // 
            // lbltimepassed
            // 
            this.lbltimepassed.AutoSize = true;
            this.lbltimepassed.Location = new System.Drawing.Point(244, 14);
            this.lbltimepassed.Name = "lbltimepassed";
            this.lbltimepassed.Size = new System.Drawing.Size(46, 17);
            this.lbltimepassed.TabIndex = 22;
            this.lbltimepassed.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Time:";
            // 
            // SJF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbltimepassed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcesses);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblgantt);
            this.Controls.Add(this.avgturnaround);
            this.Controls.Add(this.avgwaiting);
            this.Controls.Add(this.lblturnaround);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblresponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblwaitingg);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.btndebug);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SJF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SJF";
            this.Load += new System.EventHandler(this.SJF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndebug;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblwaitingg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblresponse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblturnaround;
        private System.Windows.Forms.Label avgwaiting;
        private System.Windows.Forms.Label avgturnaround;
        private System.Windows.Forms.Label lblgantt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtProcesses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltimepassed;
        private System.Windows.Forms.Label label7;
    }
}