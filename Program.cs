using System;

namespace arrayClass
{
    class Program
    {
        static void Main(string[] args)

        {
            var rnd = new Random();
            var arr = new int[10];
            for (var i = 0; i < 10; i++)//give you the index
            {
                var r1 = rnd.Next(1, 10);
                arr[i] = r1;
            }

            
            foreach (var x in arr)//give you the value
            {
                var r1 = rnd.Next(1, 10);
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Array.Sort(arr);
            Array.Reverse(arr);



        }


    }
}

