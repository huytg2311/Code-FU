
namespace WinFormsInvoicesDemo
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
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtDisAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(54, 58);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(67, 20);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "SubTotal";
            this.lblSubTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discount Percent";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer Type";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(236, 58);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(254, 27);
            this.txtSubTotal.TabIndex = 6;
            // 
            // txtDisAmount
            // 
            this.txtDisAmount.Location = new System.Drawing.Point(236, 154);
            this.txtDisAmount.Name = "txtDisAmount";
            this.txtDisAmount.Size = new System.Drawing.Size(254, 27);
            this.txtDisAmount.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(236, 208);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(254, 27);
            this.txtTotal.TabIndex = 9;
            // 
            // cbDiscount
            // 
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Items.AddRange(new object[] {
            "New Member",
            "Silver Member",
            "Gold Member",
            "Diamond Member"});
            this.cbDiscount.Location = new System.Drawing.Point(236, 106);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(151, 28);
            this.cbDiscount.TabIndex = 10;
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Items.AddRange(new object[] {
            "10.0%",
            "15.0%",
            "20.0%",
            "50.0%"});
            this.cbCustomerType.Location = new System.Drawing.Point(236, 263);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(151, 28);
            this.cbCustomerType.TabIndex = 12;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(54, 353);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(94, 29);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(236, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 506);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.cbCustomerType);
            this.Controls.Add(this.cbDiscount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDisAmount);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtDisAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
    }
}

