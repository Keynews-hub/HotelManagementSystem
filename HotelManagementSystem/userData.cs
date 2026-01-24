using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{

   
    public class userData
    {

        string sqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yusri\OneDrive\Dokumen\Hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string Time { set; get; }

        public List<userData> getUserData()
        {
            List<userData> listdata = new List<userData>();
            SqlConnection connect = new SqlConnection(sqlConnection);
            connect.Open();

            string showQuery = "SELECT * FROM users";
            SqlCommand comand = new SqlCommand(showQuery, connect);
            SqlDataReader reader = comand.ExecuteReader();

            while (reader.Read())
            {
                userData uData = new userData();
                uData.ID = (int)reader["ID"];
                uData.Username = reader["username"].ToString();
                uData.Password = reader["password"].ToString();
                uData.Role = reader["role"].ToString();
                uData.Status = reader["status"].ToString();
                uData.Time = reader["date_register"].ToString();

                listdata.Add(uData);
            }

            return listdata;
        }
    }
}
