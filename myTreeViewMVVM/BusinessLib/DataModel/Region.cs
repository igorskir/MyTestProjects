using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.DataModel
{
    public class Region
    {
        public Region(string regionName)
        {
            RegionName = regionName;
        }
        public string RegionName { get; private set; }

        readonly List<State> _states = new List<State>();
        public List<State> States
        {
            get { return _states; }
        }
    }
}
