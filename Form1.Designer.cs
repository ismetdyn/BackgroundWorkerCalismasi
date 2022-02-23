
namespace Proje5._22_2BackgroundWorkerile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSay1 = new System.Windows.Forms.Button();
            this.tbSayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSay2 = new System.Windows.Forms.Button();
            this.tbSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSay1);
            this.groupBox1.Controls.Add(this.tbSayi1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem 1";
            // 
            // btnSay1
            // 
            this.btnSay1.AutoSize = true;
            this.btnSay1.Location = new System.Drawing.Point(10, 110);
            this.btnSay1.Name = "btnSay1";
            this.btnSay1.Size = new System.Drawing.Size(100, 26);
            this.btnSay1.TabIndex = 2;
            this.btnSay1.Text = "Başla";
            this.btnSay1.UseVisualStyleBackColor = true;
            this.btnSay1.Click += new System.EventHandler(this.btnSay1_Click);
            // 
            // tbSayi1
            // 
            this.tbSayi1.Location = new System.Drawing.Point(10, 63);
            this.tbSayi1.Name = "tbSayi1";
            this.tbSayi1.Size = new System.Drawing.Size(100, 22);
            this.tbSayi1.TabIndex = 1;
            this.tbSayi1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSay2);
            this.groupBox2.Controls.Add(this.tbSayi2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(154, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem 2";
            // 
            // btnSay2
            // 
            this.btnSay2.AutoSize = true;
            this.btnSay2.Location = new System.Drawing.Point(9, 110);
            this.btnSay2.Name = "btnSay2";
            this.btnSay2.Size = new System.Drawing.Size(100, 26);
            this.btnSay2.TabIndex = 3;
            this.btnSay2.Text = "Başla";
            this.btnSay2.UseVisualStyleBackColor = true;
            this.btnSay2.Click += new System.EventHandler(this.btnSay2_Click);
            // 
            // tbSayi2
            // 
            this.tbSayi2.Location = new System.Drawing.Point(9, 63);
            this.tbSayi2.Name = "tbSayi2";
            this.tbSayi2.Size = new System.Drawing.Size(100, 22);
            this.tbSayi2.TabIndex = 2;
            this.tbSayi2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSay1;
        private System.Windows.Forms.TextBox tbSayi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSay2;
        private System.Windows.Forms.TextBox tbSayi2;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

