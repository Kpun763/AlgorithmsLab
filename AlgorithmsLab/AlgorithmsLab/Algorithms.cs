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

        //The time complexity is O(n) linear time

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

        //This time complexity is O(n) linear time
        public static bool HasRepeatedNames(List<string> names)
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            foreach (string name in names)
                {
                    if (uniqueNames.Contains(name))
                    {
                        return true;
                    }

                    uniqueNames.Add(name);
                }

            return false;
        }

        //Time complexity: O(n^2) - quadratic time
        public static void BubbleSort(List<int> numbers)
        {
            int n = numbers.Count;
            bool swapped;

            for (int i=0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }

    
}
