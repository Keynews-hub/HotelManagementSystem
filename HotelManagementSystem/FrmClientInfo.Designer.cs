namespace HotelManagementSystem
{
    partial class FrmClientInfo
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
            this.client_BookID = new System.Windows.Forms.Panel();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.btn_booknow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contactNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_BookID = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.client_BookID.SuspendLayout();
            this.SuspendLayout();
            // 
            // client_BookID
            // 
            this.client_BookID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.client_BookID.Controls.Add(this.cb_gender);
            this.client_BookID.Controls.Add(this.btn_booknow);
            this.client_BookID.Controls.Add(this.label7);
            this.client_BookID.Controls.Add(this.txt_address);
            this.client_BookID.Controls.Add(this.label6);
            this.client_BookID.Controls.Add(this.label5);
            this.client_BookID.Controls.Add(this.txt_contactNumber);
            this.client_BookID.Controls.Add(this.label4);
            this.client_BookID.Controls.Add(this.txt_emailAddress);
            this.client_BookID.Controls.Add(this.label3);
            this.client_BookID.Controls.Add(this.list_BookID);
            this.client_BookID.Controls.Add(this.btn_clear);
            this.client_BookID.Controls.Add(this.txt_fullName);
            this.client_BookID.Controls.Add(this.label1);
            this.client_BookID.Location = new System.Drawing.Point(12, 12);
            this.client_BookID.Name = "client_BookID";
            this.client_BookID.Size = new System.Drawing.Size(933, 444);
            this.client_BookID.TabIndex = 0;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(616, 63);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(270, 24);
            this.cb_gender.TabIndex = 14;
            // 
            // btn_booknow
            // 
            this.btn_booknow.Location = new System.Drawing.Point(188, 303);
            this.btn_booknow.Name = "btn_booknow";
            this.btn_booknow.Size = new System.Drawing.Size(261, 71);
            this.btn_booknow.TabIndex = 13;
            this.btn_booknow.Text = "Book Now";
            this.btn_booknow.UseVisualStyleBackColor = true;
            this.btn_booknow.Click += new System.EventHandler(this.btn_booknow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address : ";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(616, 115);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(270, 124);
            this.txt_address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact Number : ";
            // 
            // txt_contactNumber
            // 
            this.txt_contactNumber.Location = new System.Drawing.Point(236, 216);
            this.txt_contactNumber.Name = "txt_contactNumber";
            this.txt_contactNumber.Size = new System.Drawing.Size(213, 22);
            this.txt_contactNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email Address : ";
            // 
            // txt_emailAddress
            // 
            this.txt_emailAddress.Location = new System.Drawing.Point(236, 165);
            this.txt_emailAddress.Name = "txt_emailAddress";
            this.txt_emailAddress.Size = new System.Drawing.Size(213, 22);
            this.txt_emailAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name : ";
            // 
            // list_BookID
            // 
            this.list_BookID.AutoSize = true;
            this.list_BookID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_BookID.Location = new System.Drawing.Point(236, 56);
            this.list_BookID.Name = "list_BookID";
            this.list_BookID.Size = new System.Drawing.Size(220, 27);
            this.list_BookID.TabIndex = 3;
            this.list_BookID.Text = "________________";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(625, 303);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(261, 71);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_fullName
            // 
            this.txt_fullName.Location = new System.Drawing.Point(236, 113);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(213, 22);
            this.txt_fullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID : ";
            // 
            // FrmClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(977, 475);
            this.Controls.Add(this.client_BookID);
            this.Name = "FrmClientInfo";
            this.Text = "FrmClientInfo";
            this.Load += new System.EventHandler(this.FrmClientInfo_Load);
            this.client_BookID.ResumeLayout(false);
            this.client_BookID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel client_BookID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contactNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_emailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label list_BookID;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_booknow;
        private System.Windows.Forms.ComboBox cb_gender;
    }
}