using Microsoft.Win32.SafeHandles;
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
                || string.IsNullOrEmpty(txt_Price.Text) || cb_Status.SelectedIndex == -1 || pb_rooms.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void FrmRooms_Load(object sender, EventArgs e)
        {
            combo_status();
            combo_type();
            displayData();
        }
        public void displayData()
        {
            roomsData rooms = new roomsData();
            List<roomsData> listRooms = rooms.getRoomsData();
            DataGridViewRooms.DataSource = listRooms;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
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

                        try
                        {
                            string insertQuery = "INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register) VALUES (@RoomID, @Type, @RoomName, @Price, @path, @Status, @date_reg)";

                            string path = Path.Combine(@"D:\Projects\Project Sistem Informasi\HotelManagementSystem\HotelManagementSystem\room_directoory\" + txt_roomId.Text.Trim() + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(pb_rooms.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@RoomID", txt_roomId.Text.Trim());
                                cmd.Parameters.AddWithValue("@Type", cb_Type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@RoomName", txt_RoomName.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", txt_Price.Text.Trim());
                                cmd.Parameters.AddWithValue("@path", path);
                                cmd.Parameters.AddWithValue("@Status", cb_Status.SelectedItem.ToString());

                                DateTime current = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date_reg", current);


                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayData();

                                MessageBox.Show("Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                    
            }
        }

        private void combo_type()
        {
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string queryType = "SELECT type_name FROM types";

            SqlCommand command = new SqlCommand(queryType, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                cb_Type.Items.Add(dr["type_name"].ToString());
            }

        }

        private void combo_status()
        {

            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string queryType = "SELECT * FROM status";

            SqlCommand command = new SqlCommand(queryType, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cb_Status.Items.Add(dr["status"].ToString());
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
                    ImagePath = open.FileName;
                    pb_rooms.ImageLocation = ImagePath;
                }
                
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    if (MessageBox.Show(" Are you sure wants to update ID: " + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(connection))
                        {
                            connect.Open();

                            string queryUpdate = @"UPDATE rooms SET room_id = @RoomID, type = @Type, room_name = @RoomName, price = @price, status = @status, date_update = @date where id = @id";

                            using (SqlCommand command = new SqlCommand(queryUpdate, connect))
                            {
                                command.Parameters.AddWithValue("@RoomID", txt_roomId.Text.Trim());
                                command.Parameters.AddWithValue("@Type", cb_Type.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@RoomName", txt_RoomName.Text.Trim());
                                command.Parameters.AddWithValue("@price", txt_Price.Text.Trim());
                                //command.Parameters.AddWithValue("@path", pb_rooms.ImageLocation);
                                command.Parameters.AddWithValue("@Status", cb_Status.SelectedItem.ToString());

                                DateTime current = DateTime.Today;
                                command.Parameters.AddWithValue("@date", current);
                                command.Parameters.AddWithValue("@id", id);

                                command.ExecuteNonQuery();

                               
                                displayData();

                                MessageBox.Show("Room Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               

            }
        }

        public void clearFields()
        {
            txt_roomId.Text = "";
            txt_RoomName.Text = "";
            txt_Price.Text = "";
            cb_Status.SelectedIndex = -1;
            cb_Type.SelectedIndex = -1;
            pb_rooms.Image = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int id;
        private void ViewRooms(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            { 
                
                DataGridViewRow row  = DataGridViewRooms.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                txt_roomId.Text = row.Cells[1].Value.ToString();
                cb_Type.Text = row.Cells[2].Value.ToString();
                txt_RoomName.Text = row.Cells[3].Value.ToString();
                txt_Price.Text = row.Cells[4].Value.ToString();
                pb_rooms.ImageLocation = row.Cells[5].Value.ToString();
                cb_Status.Text = row.Cells[6].Value.ToString();

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    if (MessageBox.Show(" Are you sure wants to Delete: " + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(connection))
                        {
                            connect.Open();

                            string queryDelete = @"Delete from rooms where id = @id ";
                            using (SqlCommand command = new SqlCommand(queryDelete, connect))
                            {
                              
                                DateTime current = DateTime.Today;
                                command.Parameters.AddWithValue("@delete", current);
                                command.Parameters.AddWithValue("@id", id);

                                command.ExecuteNonQuery();
                                clearFields();
                                displayData();

                                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
    }
}
