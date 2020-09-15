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
    public class ModelsManagement
    {
        SqlConnection sqlConnection;
        public ModelsManagement()
        {
            sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionPathRentACar);
        }
        public List<Models> GetModels(Brands brands)
        {
            List<Models> models = new List<Models>();
            SqlCommand sqlCommand = new SqlCommand("SP_ListModel", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@BrandID", brands.BrandID);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                models.Add(new Models()
                {
                    ModelID = (int)sqlDataReader["ModelID"],
                    ModelName = sqlDataReader["ModelName"].ToString()

                });
            }
            sqlConnection.Close();
            return models;
        }
        public bool AddModels(Models model)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddModel", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ModelName", model.ModelName);
            sqlCommand.Parameters.AddWithValue("@BrandID", model.BrandID);
            sqlConnection.Open();
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
           
        }

        
    }
}
