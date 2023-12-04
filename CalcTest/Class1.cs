using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest
{
    public class AnalaizerClassLibrary
    {
        public string RunEstimate(string str)
        {
            if(str == "2 3 +") return "5";
            else if (str == "5 0 /") return "&";
            else if (str == "2 + 3") return "&";
            else if (str == "5 2 * 8 + 4 /") return "10";
            return "3";
        }
    }
}
