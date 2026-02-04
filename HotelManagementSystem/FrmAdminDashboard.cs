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
    public partial class FrmAdminDashboard : Form
    {
        public FrmAdminDashboard()
        {
            InitializeComponent();
        }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            dislayAllRooms();
            displayTotalStaff();
            displayAvailableRooms();
            displayAvailableRooms();
            displayProfit();
            displayTotalProfit();
        }

        public void  refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
           
            dislayAllRooms();
            displayTotalStaff();
            displayAvailableRooms();
            displayAvailableRooms();
            displayProfit();
            displayTotalProfit();
        }

        public void displayTotalStaff()
        { 
            SqlConnection connect  = new SqlConnection(connection);
            connect.Open();

            string selectQuery = "SELECT COUNT (id) FROM users WHERE role = 'staff'";

            using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
            {

                object result = cmd.ExecuteScalar();

                if(result != DBNull.Value)
                {

                    list_Totalstaff.Text = result.ToString();
                }
            }

        }
        public void displayAvailableRooms()
        {
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string selectQueryRooms = "SELECT COUNT (ID) FROM users WHERE status = 'Active' OR status = 'Available'";

            using (SqlCommand cmd = new SqlCommand(selectQueryRooms, connect))
            {

                object result = cmd.ExecuteScalar();
                if(result != DBNull.Value)
                {
                    list_Availablerooms.Text = result.ToString();
                }
            }
        }
        public void displayProfit()
        {
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string selectQueryProfit = "SELECT SUM (price) FROM customers WHERE date_booked = @dbook";

            using (SqlCommand cmd = new SqlCommand(selectQueryProfit, connect))
            {
                DateTime today = DateTime.Today;
                cmd.Parameters.AddWithValue("@dbook", today);

                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    list_Profit.Text = "Rp." + result.ToString();
                }
            }
        }

        public void displayTotalProfit()
        {
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string selectQueryTotal = "SELECT SUM(price) FROM customers";

            using(SqlCommand cmd = new SqlCommand(selectQueryTotal, connect))
            {
             
                var result = cmd.ExecuteScalar();
                if(result != DBNull.Value)
                {
                    list_Totalprofit.Text = "Rp." + result.ToString();
                }
            }
        }

        public void dislayAllRooms()
        { 
            roomsData rData = new roomsData();
            List<roomsData> showRooms = rData.getRoomsData();

            GridAdminDashboard.DataSource = showRooms;
        }
    }
}
