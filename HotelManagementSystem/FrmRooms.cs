using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }

        string  connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_roomId.Text) || string.IsNullOrEmpty(txt_RoomName.Text) || cb_Type.SelectedIndex == -1
                || string.IsNullOrEmpty(txt_Price.Text) || cb_Status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            { 
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                SqlConnection connect = new SqlConnection(connection);
                connect.Open();

                string checkRoom = "SELECT room_id FROM rooms Where room_id = @RoomID";
                SqlCommand command = new SqlCommand(checkRoom, connect);
                command.Parameters.AddWithValue("@RoomID", txt_roomId.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show(txt_roomId.Text.Trim() + "already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                { 
                 string insertQuery = "INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register) VALUES (@RoomID, @Type, @RoomName, @Price, @path, @Status, @date_reg)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connect);

                    cmd.Parameters.AddWithValue("@RoomID", txt_roomId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Type", cb_Type.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RoomName", txt_RoomName.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", txt_Price.Text.Trim());
                    cmd.Parameters.AddWithValue("@path", txt_roomId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", cb_Status.SelectedItem.ToString());

                    DateTime current = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_reg", current);
                }


            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                string ImagePath = "";
                open.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
                if (open.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            { 
            
            }
        }
    }
}
