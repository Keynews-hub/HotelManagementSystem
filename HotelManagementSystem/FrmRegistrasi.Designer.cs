namespace HotelManagementSystem
{
    partial class FrmRegistrasi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sign_In = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Passwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sign_Up = new System.Windows.Forms.Button();
            this.CB_Password = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Confirm_Password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_Sign_In);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 449);
            this.panel1.TabIndex = 0;
            // 
            // btn_Sign_In
            // 
            this.btn_Sign_In.BackColor = System.Drawing.Color.Black;
            this.btn_Sign_In.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sign_In.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign_In.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_In.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sign_In.Location = new System.Drawing.Point(50, 382);
            this.btn_Sign_In.Name = "btn_Sign_In";
            this.btn_Sign_In.Size = new System.Drawing.Size(259, 40);
            this.btn_Sign_In.TabIndex = 6;
            this.btn_Sign_In.Text = "Sign In";
            this.btn_Sign_In.UseVisualStyleBackColor = false;
            this.btn_Sign_In.Click += new System.EventHandler(this.btn_Sign_In_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(395, 120);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(344, 22);
            this.txt_Username.TabIndex = 1;
            // 
            // txt_Passwoord
            // 
            this.txt_Passwoord.Location = new System.Drawing.Point(395, 184);
            this.txt_Passwoord.Name = "txt_Passwoord";
            this.txt_Passwoord.PasswordChar = '*';
            this.txt_Passwoord.Size = new System.Drawing.Size(344, 22);
            this.txt_Passwoord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // btn_Sign_Up
            // 
            this.btn_Sign_Up.BackColor = System.Drawing.Color.Black;
            this.btn_Sign_Up.FlatAppearance.BorderSize = 0;
            this.btn_Sign_Up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sign_Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sign_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign_Up.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_Up.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sign_Up.Location = new System.Drawing.Point(603, 341);
            this.btn_Sign_Up.Name = "btn_Sign_Up";
            this.btn_Sign_Up.Size = new System.Drawing.Size(136, 40);
            this.btn_Sign_Up.TabIndex = 5;
            this.btn_Sign_Up.Text = "Sign Up";
            this.btn_Sign_Up.UseVisualStyleBackColor = false;
            this.btn_Sign_Up.Click += new System.EventHandler(this.btn_Sign_Up_Click);
            // 
            // CB_Password
            // 
            this.CB_Password.AutoSize = true;
            this.CB_Password.Location = new System.Drawing.Point(395, 270);
            this.CB_Password.Name = "CB_Password";
            this.CB_Password.Size = new System.Drawing.Size(125, 20);
            this.CB_Password.TabIndex = 6;
            this.CB_Password.Text = "Show Password";
            this.CB_Password.UseVisualStyleBackColor = true;
            this.CB_Password.CheckedChanged += new System.EventHandler(this.CB_Password_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm Password :";
            // 
            // txt_Confirm_Password
            // 
            this.txt_Confirm_Password.Location = new System.Drawing.Point(395, 242);
            this.txt_Confirm_Password.Name = "txt_Confirm_Password";
            this.txt_Confirm_Password.PasswordChar = '*';
            this.txt_Confirm_Password.Size = new System.Drawing.Size(344, 22);
            this.txt_Confirm_Password.TabIndex = 7;
            // 
            // FrmRegistrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Confirm_Password);
            this.Controls.Add(this.CB_Password);
            this.Controls.Add(this.btn_Sign_Up);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Passwoord);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegistrasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrasi";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Passwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sign_Up;
        private System.Windows.Forms.Button btn_Sign_In;
        private System.Windows.Forms.CheckBox CB_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Confirm_Password;
    }
}