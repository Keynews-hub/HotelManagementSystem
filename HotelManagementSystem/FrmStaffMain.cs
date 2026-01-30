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
    public partial class FrmStaffMain : Form
    {
        public FrmStaffMain()
        {
            InitializeComponent();
        }

        public void displayRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> list = rData.getRoomsData();
            grid_showroom.DataSource = list;
        }

        private void FrmStaffMain_Load(object sender, EventArgs e)
        {
            displayRooms();
        }

        private int getID = 0;
        public decimal price;

        private void grid_showroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = grid_showroom.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                list_roomID.Text = grid_showroom.Rows[e.RowIndex].Cells[1].Value.ToString();
                list_roomType.Text = grid_showroom.Rows[e.RowIndex].Cells[2].Value.ToString();
                list_roomName.Text = grid_showroom.Rows[e.RowIndex].Cells[3].Value.ToString();
                list_price.Text = grid_showroom.Rows[e.RowIndex].Cells[4].Value.ToString();
                list_status.Text = grid_showroom.Rows[e.RowIndex].Cells[6].Value.ToString();
                list_regularPrice.Text = grid_showroom.Rows[e.RowIndex].Cells[4].Value.ToString();

                price = Convert.ToDecimal(row.Cells[4].Value);
                pb_show.ImageLocation = row.Cells[5].Value.ToString();
                
                
            }
        }

      
        private void btn_schedule_Click(object sender, EventArgs e)
        {
            DateTime fromDate = date_bookFrom.Value;
            DateTime toDate = date_bookTo.Value;

            TimeSpan zonaWaktu = toDate - fromDate;
            int days = zonaWaktu.Days;

            if (price < 0)
            {
                MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                list_price.Text = "0";
            }
            else
            {

                list_price.Text = (days * price).ToString();

            }
            //Console.WriteLine(days);

        }
    }
}
