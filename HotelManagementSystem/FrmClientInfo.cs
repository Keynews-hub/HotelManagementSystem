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
    public partial class FrmClientInfo : Form
    {
        public FrmClientInfo()
        {
            InitializeComponent();
            displayBookID();
        }

        string Connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";


        public void displayBookID()
        { 
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();

            int getBook = 0;

            string selectBID = "SELECT COUNT(id) FROM customers";

            using (SqlCommand cmd = new SqlCommand( ))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = selectBID;

                
                getBook = Convert.ToInt32(cmd.ExecuteScalar());
                if (Convert.ToInt32(getBook) == 0)
                {
                    getBook += 1;
                }
                else
                {
                    getBook += 1;
                }

                    list_BookID.Text = $"BID-{getBook}";
            }
        }

        public void comboGenders()
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();

            string showGender = @"select * from  genders";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = showGender;

            SqlDataAdapter adaptern = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptern.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cb_gender.Items.Add(dr["gender"].ToString());
            }
        }
        private void btn_booknow_Click(object sender, EventArgs e)
        {
            
            string fullName = txt_fullName.Text;
            string emailAddress = txt_emailAddress.Text;
            string contactNumber = txt_contactNumber.Text;
            string Address = txt_address.Text;
            string gender = cb_gender.SelectedItem.ToString();
            
            

            if (fullName == "" || emailAddress == "" || contactNumber == "" || Address == "" || gender == ""|| hotelData.roomID == "")
            {

                MessageBox.Show("Please fill the blank field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (SqlConnection connect = new SqlConnection(Connection))
                {
                    connect.Open();
                    string insertQuery = @"INSERT INTO customers" + "(book_id, full_name, email, contact, gender, address, room_id, price, status_payment, status, date_from, date_to, date_booKed)" +
                        "VALUES (@BookID, @Fullname, @email, @contact, @gender, @Address, @roomID, @Price, @Statuspayment, @Status, @Datefrm, @Dateto, @Datebooked)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connect))
                    {
                        command.Parameters.AddWithValue("@BookID", list_BookID.Text.Trim());
                        command.Parameters.AddWithValue("@Fullname", fullName);
                        command.Parameters.AddWithValue("@email", emailAddress);
                        command.Parameters.AddWithValue("@contact", contactNumber);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@roomID", hotelData.roomID);
                        command.Parameters.AddWithValue("@Price", hotelData.price);
                        command.Parameters.AddWithValue("@Statuspayment", "Paid");
                        command.Parameters.AddWithValue("@Status", "Checked In");
                        command.Parameters.AddWithValue("@Datefrm", hotelData.fromDate);
                        command.Parameters.AddWithValue("@Dateto", hotelData.toDate);

                        DateTime today = DateTime.Today;
                        command.Parameters.AddWithValue("@Datebooked", today);

                        command.ExecuteNonQuery();
                        updateRoomStatus();
                        MessageBox.Show("Booked Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                    }


                }

            }

        }

        private void FrmClientInfo_Load(object sender, EventArgs e)
        {
            comboGenders();
        }

        public void updateRoomStatus()
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            
            string updateStatus = "UPDATE rooms SET status = @status where room_id = @roomID";

            SqlCommand command = new SqlCommand(updateStatus, connect);

            command.Parameters.AddWithValue("@status", "UNAVAILABLE");
            command.Parameters.AddWithValue("@roomID", hotelData.roomID);
           command.ExecuteNonQuery();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fullName.Text = "";
            txt_emailAddress.Text = "";
            txt_contactNumber.Text = "";
            txt_address.Text = "";
            cb_gender.SelectedIndex = -1;
        }
    }
}
