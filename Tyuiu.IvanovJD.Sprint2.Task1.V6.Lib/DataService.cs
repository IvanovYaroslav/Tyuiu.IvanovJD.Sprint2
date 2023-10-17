using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovJD.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c < d);  //false
            res[1] = (c < b) & (a == d);   //false
            res[2] = (b + 5 == c) || (a > d); // true
            res[3] = (a == b) && (d < c);  // false
            res[4] = !res[0];    // true
            res[5] = (d > c) ^ (a == b);//false
            return res;
        }
    }
}
