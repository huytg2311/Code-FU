
namespace WinFormsPaymentBasicDemo
{
    partial class frmCustomer
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
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lblPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboNames
            // 
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(167, 33);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(262, 28);
            this.cboNames.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Payment Method: ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Location = new System.Drawing.Point(294, 160);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(135, 29);
            this.btnSelectPayment.TabIndex = 3;
            this.btnSelectPayment.Text = "Select Payment";
            this.btnSelectPayment.UseVisualStyleBackColor = true;
            this.btnSelectPayment.Click += new System.EventHandler(this.btnSelectPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Location = new System.Drawing.Point(41, 160);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(234, 97);
            this.lblPayment.TabIndex = 2;
            this.lblPayment.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 383);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.cboNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectPayment;
        private System.Windows.Forms.PictureBox lblPayment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}

