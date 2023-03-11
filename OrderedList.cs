using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTest
{
    class OrderedList
    {
        static void Main(string[] args)
        {
            // Defining a list of unsorted and possible duplicate numbers
            List<int> listOfNums = new List<int>() { 6, 4, 8, 4, 1, 9, 50, 68, 32, 6 };
            
            // Removes any duplicates and sorts the numbers in descending order.
            IEnumerable<int> listOfUniqueNums = listOfNums.Distinct().OrderByDescending(n => n);
            
            // Prints the new list.
            Console.WriteLine(string.Join(", ", listOfUniqueNums));
        }
    }
}