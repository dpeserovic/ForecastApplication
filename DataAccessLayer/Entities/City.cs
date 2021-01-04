using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public string Lon { get; set; }
        public string Lat { get; set; }
    }
}