﻿using System;
using System.Threading.Tasks;

namespace Single_MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton single = new Singleton();

            Parallel.Invoke(
                 () => AcessoThread1(),
                 () => AcessoThread2()
            );
            Console.ReadLine();
        }
        private static void AcessoThread1()
        {
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Thread 1");
        }
        private static void AcessoThread2()
        {
            Singleton s2 = Singleton.Instance;
            Console.WriteLine("Thread 2");
        }
    }
}
