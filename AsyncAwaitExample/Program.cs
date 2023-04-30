using System;

namespace AsyncAwait
{
    class Program
    {
        static void Main (string[] args)
        {
            Methodm1();
            Console.WriteLine("Main Method Thread");
        }

        public static async Task Methodm1()
        {
            await Task.Run(new Action (LongTask));
            Console.WriteLine("New Methodm1 Thread");
        }

        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
}