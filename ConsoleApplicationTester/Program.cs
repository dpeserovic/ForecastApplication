using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTester
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DataSynchronizator dataSynchronizator = new DataSynchronizator();
            var cityList = dataSynchronizator.GetCities();
            foreach (var city in cityList)
            {
                Console.WriteLine(city.CityName);
            }*/

            /*var weatherRepo = new DataSynchronizator();
            var weather = weatherRepo.GetWeather(524901);
            foreach (var w in weather)
            {
                Console.WriteLine(w.DateTime);
            }*/

            /*DataSynchronizator weather = new DataSynchronizator();
            var weatherList = weather.GetWeather(524901);
            foreach (var w in weatherList)
            {
                Console.WriteLine(w.Main);
            }*/

            Console.ReadKey();
        }
    }
}