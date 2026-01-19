using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace HotelManagementSystem
{
    public partial class FrmRegistrasi : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
        public FrmRegistrasi()
        {
            InitializeComponent();
        }

        private void CB_Password_CheckedChanged(object sender, EventArgs e)
        {
            txt_Passwoord.PasswordChar = CB_Password.Checked ? '\0' : '*';
            txt_Confirm_Password.PasswordChar = CB_Password.Checked ? '\0' : '*';
        }

        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btn_Sign_Up_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text == "" || txt_Passwoord.Text == "" || txt_Confirm_Password.Text == "")
            {
                MessageBox.Show("Please fill all blanks fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string checkEmail = "SELECT username from users WHERE username  = @usern";

                    using (SqlCommand command = new SqlCommand(checkEmail, connect))
                    {
                        command.Parameters.AddWithValue("@usern", txt_Username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table  = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempEmail = txt_Username.Text.Substring(0, 1).ToUpper() + txt_Username.Text.Substring(1);
                            MessageBox.Show($"{tempEmail} is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txt_Passwoord.Text.Length < 8)
                        {
                            MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txt_Passwoord.Text != txt_Confirm_Password.Text)
                        {
                            MessageBox.Show("Password doesn't match", "Error Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string query = "INSERT INTO users (username, password, role, status, date_register)" +
                                "VALUES(@usern, @pass, @role, @status, @regDate)";

                            using (SqlCommand comand = new SqlCommand(query, connect))
                            {
                                comand.Parameters.AddWithValue("@usern", txt_Username.Text.Trim());
                                comand.Parameters.AddWithValue("@pass", txt_Passwoord.Text.Trim());
                                comand.Parameters.AddWithValue("@role", "staff");
                                comand.Parameters.AddWithValue("@status", "active");

                                DateTime today = DateTime.Now;
                                comand.Parameters.AddWithValue("@regDate", today);

                                comand.ExecuteNonQuery();

                                MessageBox.Show("Registration Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FrmLogin login = new FrmLogin();
                                login.Show();
                                this.Hide();
                            }

                        }
                                
                    }
                }
            }
        }
    }
}
