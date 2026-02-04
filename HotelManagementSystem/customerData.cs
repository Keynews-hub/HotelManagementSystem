using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace HotelManagementSystem
{
    public class customerData
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public int id { set; get; }
        public string bookID { set; get; }
        public string fullName { set; get; }
        public string email { set; get; }
        public string contact { set; get; }
        public string gender { set; get; }
        public string address { set; get; }
        public string roomID { set; get; }
        public string price { set; get; }
        public string statusPayment { set; get; }
        public string status {  set; get; }
        public string checkIn { set; get; }
        public string checkOut { set; get; }
        public string BookDate { set; get; }

        public List<customerData> listCustomerData()
        {
            List<customerData> listData = new List<customerData>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string showQuery = @"SELECT * FROM customers";

                using (SqlCommand cmd = new SqlCommand(showQuery, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customerData data = new customerData();
                        data.id = (int)reader["id"];
                        data.bookID = reader["book_id"].ToString();
                        data.fullName = reader["full_name"].ToString();
                        data.email = reader["email"].ToString();
                        data.contact = reader["contact"].ToString();
                        data.gender = reader["gender"].ToString();
                        data.address = reader["address"].ToString();
                        data.roomID = reader["room_id"].ToString();
                        data.price = reader["price"].ToString();
                        data.statusPayment = reader["status_payment"].ToString();
                        data.status = reader["status"].ToString();
                        data.checkIn = reader["date_from"].ToString();
                        data.checkOut = reader["date_to"].ToString();
                        data.BookDate = reader["date_booked"].ToString(); ;

                        listData.Add(data);
                    }
                }

            }

            return listData;
        }

        
    }
}
