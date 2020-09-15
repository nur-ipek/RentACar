using RentACar.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentACar.DAL
{
    public class UsersManagement
    {
        SqlConnection sqlConnection;

        public UsersManagement()
        {
            sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionPathRentACar);
        }
        public bool AddUsers(Users user)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddUsers", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@FirstName", user.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", user.LastName);
            sqlCommand.Parameters.AddWithValue("@MailAdress", user.MailAdress);
            sqlCommand.Parameters.AddWithValue("@Password", user.Password);

            sqlConnection.Open();
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }
       

        public List<Users> GetUsers()
        {
            List<Users> usersList = new List<Users>();
            SqlCommand sqlCommand = new SqlCommand("SP_CheckLogin", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                Users users = new Users();
                users.UserID = (int)sqlDataReader["UserID"];
                users.FirstName = sqlDataReader["FirstName"].ToString();
                users.LastName = sqlDataReader["LastName"].ToString();
                users.MailAdress = sqlDataReader["MailAdress"].ToString();
                users.Password = sqlDataReader["Password"].ToString();
                users.UserType = (bool)sqlDataReader["UserType"];
                usersList.Add(users);

            }
            sqlConnection.Close();
            return usersList;
        }
    }
}
