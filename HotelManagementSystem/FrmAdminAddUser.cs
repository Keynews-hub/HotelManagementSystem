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

namespace HotelManagementSystem
{
    public partial class FrmAdminAddUser : Form
    {
        public FrmAdminAddUser()
        {
            InitializeComponent();
        }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";

        private void btn_add_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txtpassword.Text;
            string role = txtrole.Text;
            string status = txtstatus.Text;

            if (username == "" || password == "" || role == "" || status == "")
            {
                MessageBox.Show("Please fill the blank fields", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string checkUser = "SELECT username from users WHERE username  = @usern";

                    using (SqlCommand command = new SqlCommand(checkUser, connect))
                    {
                        command.Parameters.AddWithValue("@usern",username.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string tempUsern = txt_username.Text.Substring(0, 1).ToUpper() + txt_username.Text.Substring(1);
                            MessageBox.Show($"{tempUsern} is a;ready exist", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (password.Length < 8)
                        {
                            MessageBox.Show("Password Invalid", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        { 
                            string insertQuery = "INSERT INTO users (username, password, role, status, date_register)" +
                                "VALUES(@usern, @pass, @role, @status, @regDate)";

                            using (SqlCommand comand = new SqlCommand(insertQuery, connect))
                            {
                                comand.Parameters.AddWithValue("@usern", username.Trim());
                                comand.Parameters.AddWithValue("@pass", password.Trim());
                                comand.Parameters.AddWithValue("@role", role.Trim());
                                comand.Parameters.AddWithValue("@status", status.Trim());
                               
                                DateTime today = DateTime.Now;
                                comand.Parameters.AddWithValue("regDate", today);

                                comand.ExecuteNonQuery();

                                MessageBox.Show("User add Successfully", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                    }
                }
            }
        }
    }
}
