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
            this.GridViewAdminCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAdminCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewAdminCustomer
            // 
            this.GridViewAdminCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAdminCustomer.Location = new System.Drawing.Point(39, 58);
            this.GridViewAdminCustomer.Name = "GridViewAdminCustomer";
            this.GridViewAdminCustomer.RowHeadersWidth = 51;
            this.GridViewAdminCustomer.RowTemplate.Height = 24;
            this.GridViewAdminCustomer.Size = new System.Drawing.Size(1048, 554);
            this.GridViewAdminCustomer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.GridViewAdminCustomer);
            this.panel1.Location = new System.Drawing.Point(22, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 646);
            this.panel1.TabIndex = 1;
            // 
            // FrmAdminCutomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1176, 685);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdminCutomer";
            this.Text = "FrmAdminCutomer";
            this.Load += new System.EventHandler(this.FrmAdminCutomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAdminCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewAdminCustomer;
        private System.Windows.Forms.Panel panel1;
    }
}