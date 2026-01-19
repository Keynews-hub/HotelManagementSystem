namespace HotelManagementSystem
{
    partial class FrmLogin
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Passwoord = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Register = new System.Windows.Forms.Button();
            this.CB_ShowPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Black;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Login.Location = new System.Drawing.Point(606, 267);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(137, 40);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username :";
            // 
            // txt_Passwoord
            // 
            this.txt_Passwoord.Location = new System.Drawing.Point(399, 199);
            this.txt_Passwoord.Name = "txt_Passwoord";
            this.txt_Passwoord.PasswordChar = '*';
            this.txt_Passwoord.Size = new System.Drawing.Size(344, 22);
            this.txt_Passwoord.TabIndex = 8;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(399, 135);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(344, 22);
            this.txt_Username.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_Register);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 449);
            this.panel1.TabIndex = 6;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Black;
            this.btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(36, 375);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(259, 40);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // CB_ShowPassword
            // 
            this.CB_ShowPassword.AutoSize = true;
            this.CB_ShowPassword.Location = new System.Drawing.Point(399, 227);
            this.CB_ShowPassword.Name = "CB_ShowPassword";
            this.CB_ShowPassword.Size = new System.Drawing.Size(125, 20);
            this.CB_ShowPassword.TabIndex = 12;
            this.CB_ShowPassword.Text = "Show Password";
            this.CB_ShowPassword.UseVisualStyleBackColor = true;
            this.CB_ShowPassword.CheckedChanged += new System.EventHandler(this.CB_ShowPassword_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_ShowPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Passwoord);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Passwoord;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.CheckBox CB_ShowPassword;
    }
}

