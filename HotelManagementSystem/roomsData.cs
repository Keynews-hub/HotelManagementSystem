using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class roomsData
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";


        public int ID { set; get; }

        public string RoomID { set; get; }
        public string RoomType { set; get; }
        public string RoomName { set; get; }
        public string Price { set; get; }
        public string Image { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<roomsData> getRoomsData()
        {
            List<roomsData> roomList = new List<roomsData>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string showQuery = "SELECT * FROM rooms";

                using (SqlCommand command = new SqlCommand(showQuery, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        roomsData rData = new roomsData();
                        rData.ID = (int)reader["id"];
                        rData.RoomID = reader["room_id"].ToString();
                        rData.RoomType = reader["type"].ToString();
                        rData.RoomName = reader["room_name"].ToString();
                        rData.Price = reader["price"].ToString();
                        rData.Image = reader["image_path"].ToString();
                        rData.Status = reader["status"].ToString();
                        rData.Date = reader["date_register"].ToString();

                        roomList.Add(rData);
                    }
                    return roomList;

                }
            }
        
        }
    }
}
