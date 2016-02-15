using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample_1
{
    //delegate int CountDelegate(string message);
    class StringHelper
    {
        

        public int GetCount(string inputString)
        {
            return inputString.Length;
        }

        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(s => s == 'A');
        }
    }
}
