using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLab
{
    internal class Algorithms
    {
        //The time complexity is O(1) constant time
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        //The time complexity is O(1) constant time

        public static bool AllNumbersLessThan100(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                if (num >= 100)
                {
                    return false;
                }
            }
            return true;
        }
    }

    
}
