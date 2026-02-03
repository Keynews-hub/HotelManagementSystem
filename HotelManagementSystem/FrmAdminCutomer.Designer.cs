namespace HotelManagementSystem
{
    partial class FrmAdminCutomer
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
            this.GrodViewAdminCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrodViewAdminCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrodViewAdminCustomer
            // 
            this.GrodViewAdminCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrodViewAdminCustomer.Location = new System.Drawing.Point(39, 64);
            this.GrodViewAdminCustomer.Name = "GrodViewAdminCustomer";
            this.GrodViewAdminCustomer.RowHeadersWidth = 51;
            this.GrodViewAdminCustomer.RowTemplate.Height = 24;
            this.GrodViewAdminCustomer.Size = new System.Drawing.Size(1048, 548);
            this.GrodViewAdminCustomer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.GrodViewAdminCustomer);
            this.panel1.Location = new System.Drawing.Point(22, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 646);
            this.panel1.TabIndex = 1;
            // 
            // FrmAdminCutomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 685);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdminCutomer";
            this.Text = "FrmAdminCutomer";
            this.Load += new System.EventHandler(this.FrmAdminCutomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrodViewAdminCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrodViewAdminCustomer;
        private System.Windows.Forms.Panel panel1;
    }
}