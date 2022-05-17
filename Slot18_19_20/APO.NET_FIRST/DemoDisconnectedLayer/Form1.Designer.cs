
namespace DemoDisconnectedLayer
{
    partial class frmMyStore
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
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnViewCategories = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(132, 39);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(154, 29);
            this.btnViewProducts.TabIndex = 0;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnViewCategories
            // 
            this.btnViewCategories.Location = new System.Drawing.Point(392, 39);
            this.btnViewCategories.Name = "btnViewCategories";
            this.btnViewCategories.Size = new System.Drawing.Size(163, 29);
            this.btnViewCategories.TabIndex = 0;
            this.btnViewCategories.Text = "View Categories";
            this.btnViewCategories.UseVisualStyleBackColor = true;
            this.btnViewCategories.Click += new System.EventHandler(this.btnViewCategories_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(32, 100);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.Size = new System.Drawing.Size(621, 250);
            this.dgvData.TabIndex = 1;
            // 
            // frmMyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 429);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewCategories);
            this.Controls.Add(this.btnViewProducts);
            this.Name = "frmMyStore";
            this.Text = "My Store";
            this.Load += new System.EventHandler(this.frmMyStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnViewCategories;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

