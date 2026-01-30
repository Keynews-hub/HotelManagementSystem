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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";

        private void btn_Register_Click(object sender, EventArgs e)
        {
            FrmRegistrasi registrasi = new FrmRegistrasi();
            registrasi.Show ();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Passwoord.Text;


            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users WHERE (username = @usern AND password = @pass) AND status = 'Active'";

                    using (SqlCommand comand = new SqlCommand(selectData, connect))
                    {
                        comand.Parameters.AddWithValue("@usern", username.Trim());
                        comand.Parameters.AddWithValue("@pass", password.Trim());
                        comand.Parameters.AddWithValue("@status", "Active");

                        SqlDataAdapter adapter = new SqlDataAdapter(comand);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Login Successfuly", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using (SqlCommand roleCommand = new SqlCommand(selectRole, connect))
                            {
                                roleCommand.Parameters.AddWithValue("@usern", username.Trim());
                                roleCommand.Parameters.AddWithValue("@pass", password.Trim());

                                string userRole = roleCommand.ExecuteScalar().ToString();

                                if (userRole == "Admin")
                                {
                                    FrmAdminMain adminMain = new FrmAdminMain();
                                    adminMain.Show();
                                    this.Hide();

                                }
                                else if (userRole == "Staff")
                                {
                                    FrmStaffMain staffMain = new FrmStaffMain();
                                    staffMain.Show();
                                    this.Hide();
                                }
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }

        private void CB_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            txt_Passwoord.PasswordChar = CB_ShowPassword.Checked ? '\0' : '*'; 
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Passwoord.Text;

            if (username == "" || password == "")
            {
                //MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users WHERE (username = @usern AND password = @pass) AND status = 'Active'";

                    using (SqlCommand comand = new SqlCommand(selectData, connect))
                    {
                        comand.Parameters.AddWithValue("@usern", username.Trim());
                        comand.Parameters.AddWithValue("@pass", password.Trim());
                        comand.Parameters.AddWithValue("@status", "Active");

                        SqlDataAdapter adapter = new SqlDataAdapter(comand);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Login Successfuly", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }
    }
}
