using System;
using System.Threading;
using System.Collections.Generic;

namespace Lab1
{
    public class Program
    {
        static object padLock = new object();
        static List<String> shared = new List<String>();

        static Program p = new Program();
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Thread th1 = new Thread(() => Program.SmallerPrimeV1(n));
            th1.Start();
            th1.Join();
            

            Thread th2 = new Thread(() => Program.SmallerPrimeV2(n));
            th2.Start();
            th2.Join();

            //SmallerPrimeV2(n);

            //Console.WriteLine("Numarul v1 este {0}", SmallerPrimeV1(n));
            //Console.WriteLine("Numarul v2 este {0}", SmallerPrimeV2(n));

            foreach (String s in shared) Console.WriteLine(s);
        }

        public static bool IsPrime(int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            for (int d = 3; d * d <= x; d += 2)
                if (x % d == 0) return false;
            return true;
        }

        public static void SmallerPrimeV1(int n)
        {
            lock (padLock)
            {
                String info = "Start fir: fir1 " + Convert.ToDateTime(DateTime.Now) + " numar dat = " + n;
                shared.Add(info);
            }
            while (!IsPrime(n) && n > 0) n--;
            
            Console.WriteLine("Numarul v1 este {0}", n);

            lock (padLock)
            {
                String info = "End fir: fir1 " + Convert.ToDateTime(DateTime.Now) + " numar prim = " + n;
                shared.Add(info);
            }
        }

        public static void SmallerPrimeV2(int n)
        {
            lock (padLock)
            {
                String info = "Start fir: fir2 " + Convert.ToDateTime(DateTime.Now) + " numar dat = " + n ;
                shared.Add(info);
            }
            if (n < 3) n = 0;
            int i = 3;
            int number = 2;
            while(i < n - 1)
            {
                if (IsPrime(i)) number = i;
                i+=2;
            }

            Console.WriteLine("Numarul v2 este {0}", number);
            lock (padLock)
            {
                String info = "End fir: fir2 " + Convert.ToDateTime(DateTime.Now) + " numar prim = " + number;
                shared.Add(info);
            }
        }
    }

   
}
