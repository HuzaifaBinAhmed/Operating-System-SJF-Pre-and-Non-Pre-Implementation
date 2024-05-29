
namespace OS_PROJECT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdnPre = new System.Windows.Forms.RadioButton();
            this.rdnNon = new System.Windows.Forms.RadioButton();
            this.btndone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SJF IMPLEMENTATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Number Of Processes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // rdnPre
            // 
            this.rdnPre.AutoSize = true;
            this.rdnPre.BackColor = System.Drawing.Color.Transparent;
            this.rdnPre.ForeColor = System.Drawing.Color.White;
            this.rdnPre.Location = new System.Drawing.Point(98, 135);
            this.rdnPre.Name = "rdnPre";
            this.rdnPre.Size = new System.Drawing.Size(100, 21);
            this.rdnPre.TabIndex = 6;
            this.rdnPre.TabStop = true;
            this.rdnPre.Text = "Preemptive";
            this.rdnPre.UseVisualStyleBackColor = false;
            // 
            // rdnNon
            // 
            this.rdnNon.AutoSize = true;
            this.rdnNon.ForeColor = System.Drawing.Color.White;
            this.rdnNon.Location = new System.Drawing.Point(249, 135);
            this.rdnNon.Name = "rdnNon";
            this.rdnNon.Size = new System.Drawing.Size(131, 21);
            this.rdnNon.TabIndex = 7;
            this.rdnNon.TabStop = true;
            this.rdnNon.Text = "Non-Preemptive";
            this.rdnNon.UseVisualStyleBackColor = true;
            // 
            // btndone
            // 
            this.btndone.ForeColor = System.Drawing.Color.Black;
            this.btndone.Location = new System.Drawing.Point(184, 179);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(100, 23);
            this.btndone.TabIndex = 8;
            this.btndone.Text = "Done";
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 268);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.rdnNon);
            this.Controls.Add(this.rdnPre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdnPre;
        private System.Windows.Forms.RadioButton rdnNon;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

