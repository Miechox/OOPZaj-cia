using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static object locksmth = new object();
        public static volatile bool InTime = true;
        public static bool IsPrime(long num)
        {
            long i = 0;
            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            if (i == num)
            {
                return true;
            }
            return false;
        }

        static void  Main(string[] args)
        {

            HashSet<long> map = new HashSet<long>();
            Thread thread = new Thread(() =>
            {
                for (long i = 0; InTime; i += 4)
                    if (IsPrime(i))
                        lock (locksmth) { map.Add(i); }
            });
            Thread thread2 = new Thread(() =>
            {
                for (long i = 1; InTime; i += 4)
                    if (IsPrime(i))
                        lock (locksmth) { map.Add(i); }
            });
            Thread thread3 = new Thread(() =>
            {
                for (long i = 2; InTime; i += 4)
                    if (IsPrime(i))
                        lock (locksmth) { map.Add(i); }
            });
            Thread thread4 = new Thread(() =>
            {
                for (long i = 3; InTime; i += 4)
                    if (IsPrime(i))
                        lock (locksmth) { map.Add(i); }
            });
            Thread SleepThread = new Thread(() =>
            {
                Thread.Sleep(10000);
                InTime = false;
            });

           
           

            SleepThread.Start();
            thread.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            SleepThread.Join();
            thread.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();


            Console.WriteLine($"Counter: {map.Count}");
            Console.WriteLine("Done");
        }
    }
}
