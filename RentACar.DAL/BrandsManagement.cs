using RentACar.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentACar.DAL
{

    public class BrandsManagement
    {
        SqlConnection sqlConnection;
        public BrandsManagement()
        {
            sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionPathRentACar);
        }

        public bool AddBrands(Brands brands)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddBrand", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@BrandName", brands.BrandName);

            sqlConnection.Open();
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;

        }

        public List<Brands> GetBrands()
        {
            List<Brands> Brands = new List<Brands>();
            SqlCommand sqlCommand = new SqlCommand("SP_ListBrand", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Brands.Add(new Brands()
                {
                    BrandID = (int)sqlDataReader["BrandID"],
                    BrandName = sqlDataReader["BrandName"].ToString()
                });
            }
            sqlConnection.Close();
            return Brands;
        }

    }
}
