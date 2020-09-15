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
    public class CarsManagement
    {
        SqlConnection sqlConnection;
        public CarsManagement()
        {
            sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionPathRentACar);
        }
        public bool AddCar(Cars car)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddCar", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SasiNo", car.SasiNo);
            sqlCommand.Parameters.AddWithValue("@Km", car.Km);
            sqlCommand.Parameters.AddWithValue("@ModelYear", car.ModelYear);
            sqlCommand.Parameters.AddWithValue("@ModelID", car.ModelID);
            sqlCommand.Parameters.AddWithValue("@Price", car.Price);
            sqlConnection.Open();
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }

        public DataTable GetCar()
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("SP_ListCar", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        //public List<Cars> GetCar()
        //{
        //    List<Cars> cars = new List<Cars>();
        //    SqlCommand sqlCommand = new SqlCommand("SP_ListCar", sqlConnection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlConnection.Open();
        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //    while (sqlDataReader.Read())
        //    {
        //        cars.Add(new Cars()
        //        {
        //            mar
        //        })
        //    }
        //}
    }
}
