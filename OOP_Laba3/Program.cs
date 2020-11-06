using System;

namespace OOP_Laba3
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new LinkedList<int>();
            int a = 0;
            int n = 5;
            while (n > 0)
            {
                Random rand = new Random();
                a = rand.Next(0, 101);
                if (a % 5 == 0)
                    list.Add(5);
                if (a % 5 == 1)
                    list.Delete(5);
                if (a % 5 == 2)
                    list.AppendHead(2);
                if (a % 5 == 3)
                    list.InsertAfter(5, 4);
                if (a % 5 == 4)
                    list.Clear();
                n--;
                foreach (var item in list)
                {
                    Console.WriteLine(item + " ");
                }
            }
            /*
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(4, 8);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
            */
            
        }
    }
}
