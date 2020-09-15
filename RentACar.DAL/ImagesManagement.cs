using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DAL
{
    public class ImagesManagement
    {
        SqlConnection sqlConnection;
        public ImagesManagement()
        {
            sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionPathRentACar);
        }
        public bool AddImages(Images ımages)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddImages", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Image", ımages.ImageUrl);
            sqlConnection.Open();
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }
    }
}
