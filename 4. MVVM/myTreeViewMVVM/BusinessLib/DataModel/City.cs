using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.DataModel
{
    public class City
    {
        public City(string cityName)
        {
            CityName = cityName;
        }
        public string CityName { get; private set; }
    }
}
