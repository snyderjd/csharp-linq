using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========== Restriction/Filtering Operations ==========

            // Find the words in the collection that start with the letter "L"
            List<string> fruits = new List<string>(){
                "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"
            };

            IEnumerable<string> lFruits = from fruit in fruits
                where fruit[0] == char.Parse("L")
                select fruit;

            foreach(string fruit in lFruits)
            {
                // Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            
            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);
            
            foreach(int num in fourSixMultiples)
            {
                // Console.WriteLine(num);
            }

            // ========== Ordering Operations ==========
//             // Order these student names alphabetically, in descending order (Z to A)
//             List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

//             List<string> descend = ...

            // Order these student names alphabetically, indescending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina", "Kathleen", "Sophia", "Amir", "Douglas",
                "Zarley", "Beatrice", "Theodora", "William", "Svetlana", "Charisse", "Yolanda", "Gregorio",
                "Jean-Paul", "Evangelina", "Viktor", "Jacqueline", "Francisco", "Tre"
            };

            IEnumerable<string> orderedNames = from name in names
                orderby name descending
                select name;

            foreach(string name in orderedNames)
            {
                // Console.WriteLine(name);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> nums = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> ascendingNums = from num in nums
                orderby num ascending
                select num;

            foreach(int num in ascendingNums)
            {
                // Console.Write($"{num}, ");
            }







        }
    }
}
