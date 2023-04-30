using System;

namespace LINQexample
{
    class Program
    {
        static void Main (string[] args)
        {
            // LINQ simple query with one list same can be done with array
            var digit = new List<int> {1,9,8,7,6,4,2,1,3,0,}; 
            var MyQuery = from dig in digit
                            where dig < 5
                                select dig;
            
            Console.WriteLine("The number less than 5 are: ");
            foreach (var item in MyQuery)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();

            // LINQ combined query with string array and num array
            int[] num = {5, 6, 4, 3, 2, 0, 1};
            string[] name = {"Ajinkya", "Pratiksha", "Amul", "Ajiay", "Sakshi", "Ajay", "Sam"};
            
            var que = from n in num
                        select name[n];

            Console.WriteLine("LINQ combined query output is: ");
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
        } 
    }
}