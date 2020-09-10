using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace Cars
{
    public class Database
    {
        private string path = @"C:\Users\WindowsPC\Documents\DatabaseCar.txt";
        private string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["CarsConnectionString"].ConnectionString;

        public void SaveCar(Cars car)
        {
            using (StreamWriter sw = File.AppendText(path))
            {


                string carInfo = string.Format("{0} | {1} | {2} | {3}",
                    car._make,
                    car._model,
                    car._price,
                    car._year);

                sw.WriteLine(carInfo);
            }
        }

        public string[] GetAllCars()
        {
            string[] list = File.ReadAllLines(path);
            return list;
        }

        public void DeleteCar(int selectIndexOfRowToRemove)
        {
            string[] oldlist = File.ReadAllLines(path);
            string[] newList = new string[oldlist.Length - 1];

            int newListIndex =0 ;
            for (int oldListIndex = 0; oldListIndex < oldlist.Length; oldListIndex++)
            {
                if(selectIndexOfRowToRemove != oldListIndex)
                newList[newListIndex] = oldlist[oldListIndex];
                newListIndex++;
            }
        }
        
        public void UpdateCar(string newCarInfo, int selectIndex) 
        {

        }

        public List<Make> GetAllMakes()
         {
            List<Make> makes = new List<Make>();
            using(SqlConnection connection  = new SqlConnection(CONNECTION_STRING))
            {
                using(SqlCommand cmd = new SqlCommand("sp_GetAllMakes", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Make m = new Make();
                            m.Id = Convert.ToInt32(reader["Make"]);
                            m.MakeType = reader["Make"].ToString();

                            makes.Add(m);
                        }
                    }
                }
            }
            return makes;

         }

         public List<Model> GetModelsByMakeId(int makeId)
         {
            List<Model> models = new List<Model>();

            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))

           

            return models;
         }

        
    }
}
