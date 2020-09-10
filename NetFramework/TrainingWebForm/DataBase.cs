using System.IO;

namespace TrainingWebForm
{
    public class DataBase
    {
        string path = @"C:\Users\WindowsPC\Documents\DataStore.txt";


        public void SaveCar(Car car)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                string carInfo = car.GetCarInfo();
                sw.WriteLine(carInfo);
            } 
        }

    }
}
