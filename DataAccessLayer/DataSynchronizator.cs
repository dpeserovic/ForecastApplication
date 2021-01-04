using DataAccessLayer.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataSynchronizator
    {
        private List<City> _cities = new List<City>();
        private List<Weather> _weather = new List<Weather>();

        //private string url = "http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=d2db85b473b5a08d4c2e2d70bb88f651";

        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";

        public DataSynchronizator()
        {
            StreamReader oSr = new StreamReader("city.list.json");
            string json = "";
            using (oSr)
            {
                json = oSr.ReadToEnd();
            }
            JArray city = JArray.Parse(json);
            foreach (JObject item in city)
            {
                _cities.Add(new City
                {
                    Id = (int)item.GetValue("id"),
                    CityName = (string)item.GetValue("name"),
                    Country = (string)item.GetValue("country"),
                    Lat = (string)item.GetValue("coord")["lat"],
                    Lon = (string)item.GetValue("coord")["lon"]
                });

            }
        }

        public List<City> GetCities()
        {
            return _cities;
        }

        public string SetCurrentURL(int id)
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast?id=" + id + "&APPID=d2db85b473b5a08d4c2e2d70bb88f651";
            return url;
        }

        public string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public List<Weather> GetWeather(int id)
        {
            var weather = new List<Weather>();
            string sUrl = SetCurrentURL(id);
            string json = CallRestMethod(sUrl);
            JObject jsonObject = JObject.Parse(json);
            var list = jsonObject["list"].ToList();
            for (int i = 0; i < list.Count; i++)
            {
                weather.Add(new Weather
                {
                    Id = (int)list[i]["weather"][0]["id"],
                    Main = (string)list[i]["weather"][0]["main"],
                    Description = (string)list[i]["weather"][0]["description"],
                    Icon = (string)list[i]["weather"][0]["icon"],
                    DateTime = (DateTime)list[i]["dt_txt"]
                });
            }
            return weather;
        }

        public List<City> Search(decimal id, string cityName, string country, string lon, string lat)
        {
            var cities = _cities.Where(x => true);
            if (id != 0)
            {
                cities = cities.Where(x => x.Id == id);
            }
            if (!string.IsNullOrEmpty(cityName))
            {
                cities = cities.Where(x => x.CityName == cityName);
            }
            if (!string.IsNullOrEmpty(country))
            {
                cities = cities.Where(x => x.Country == country);
            }
            if (!string.IsNullOrEmpty(lon))
            {
                cities = cities.Where(x => x.Lon == lon);
            }
            if (!string.IsNullOrEmpty(lat))
            {
                cities = cities.Where(x => x.Lat == lat);
            }
            return cities.ToList();
        }

        public void AddCity(City city)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Forecast_Cities (id, name, country, lon, lat) VALUES ('" + city.Id + "','" + city.CityName + "','" + city.Country + "','" + city.Lon + "','" + city.Lat + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public List<City> GetFavorites()
        {
            var cities = new List<City>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Forecast_Cities]";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cities.Add(new City()
                        {
                            Id = (int)reader["id"],
                            CityName = (string)reader["name"],
                            Country = (string)reader["country"],
                            Lon = (string)reader["lon"],
                            Lat = (string)reader["lat"]
                        });
                    }
                }
            }

            return cities;
        }

        public bool IsAdded(int id)
        {
            List<City> cities = GetFavorites();
            for (int i = 0; i < cities.Count(); i++)
            {
                if (id == cities[i].Id)
                    return false;
            }
            return true;
        }

        public void DeleteCity(City city)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Forecast_Cities WHERE id = '" + city.Id + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}