namespace Vendor_Addresses
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
            this.dgVendorAddresses = new System.Windows.Forms.DataGridView();
            this.RetrevealBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVendorAddresses
            // 
            this.dgVendorAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVendorAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendorAddresses.Location = new System.Drawing.Point(12, 12);
            this.dgVendorAddresses.Name = "dgVendorAddresses";
            this.dgVendorAddresses.Size = new System.Drawing.Size(655, 351);
            this.dgVendorAddresses.TabIndex = 0;
            this.dgVendorAddresses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RetrevealBT
            // 
            this.RetrevealBT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RetrevealBT.Location = new System.Drawing.Point(304, 379);
            this.RetrevealBT.Name = "RetrevealBT";
            this.RetrevealBT.Size = new System.Drawing.Size(75, 23);
            this.RetrevealBT.TabIndex = 1;
            this.RetrevealBT.Text = "Retrive";
            this.RetrevealBT.UseVisualStyleBackColor = true;
            this.RetrevealBT.Click += new System.EventHandler(this.RetrevealBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 414);
            this.Controls.Add(this.RetrevealBT);
            this.Controls.Add(this.dgVendorAddresses);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorAddresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVendorAddresses;
        private System.Windows.Forms.Button RetrevealBT;
    }
}

