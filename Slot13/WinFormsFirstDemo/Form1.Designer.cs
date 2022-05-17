
namespace WinFormsFirstDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncome01 = new System.Windows.Forms.TextBox();
            this.txtIncome02 = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income 01: ";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Income 02:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Average Salary: ";
            // 
            // txtIncome01
            // 
            this.txtIncome01.Location = new System.Drawing.Point(194, 52);
            this.txtIncome01.Name = "txtIncome01";
            this.txtIncome01.Size = new System.Drawing.Size(300, 27);
            this.txtIncome01.TabIndex = 1;
            // 
            // txtIncome02
            // 
            this.txtIncome02.Location = new System.Drawing.Point(194, 132);
            this.txtIncome02.Name = "txtIncome02";
            this.txtIncome02.Size = new System.Drawing.Size(300, 27);
            this.txtIncome02.TabIndex = 1;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(194, 207);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(300, 27);
            this.txtMonth.TabIndex = 1;
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAverage.Location = new System.Drawing.Point(208, 307);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(264, 29);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "Average Income";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Months: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtIncome02);
            this.Controls.Add(this.txtIncome01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIncome01;
        private System.Windows.Forms.TextBox txtIncome02;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label label4;
    }
}

