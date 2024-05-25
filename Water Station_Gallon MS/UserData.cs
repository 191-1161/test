using System.Collections.Generic;
using System.Data.SqlClient;

namespace Water_Station_Gallon_MS
{
    internal class UserData
    {
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }
        public List<UserData> AllUserData()
        {
            List<UserData> listData = new List<UserData>();

            using (SqlConnection connect
                = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danpi\OneDrive\Documents\newinventory.mdf;Integrated Security=True;Connect Timeout=30
"))
            {
                connect.Open();

                string selectData = "SELECT * FROM usersss";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UserData uData = new UserData();
                        uData.ID = (int)reader["id"];
                        uData.Username = reader["username"].ToString();
                        uData.Password = reader["password"].ToString();
                        uData.Role = reader["role"].ToString();
                        uData.Status = reader["status"].ToString();
                        uData.Date = reader["date"].ToString();

                        listData.Add(uData);

                    }
                }
            }
            return listData;

        }
    }

}
