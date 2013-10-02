using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Program
    {
        public static bool[] chops = new bool[5];

        static void Main(string[] args)
        {
            Thread phil1 = new Thread(Philosopher1);
            Thread phil2 = new Thread(Philosopher2);
            Thread phil3 = new Thread(Philosopher3);
            Thread phil4 = new Thread(Philosopher4);
            Thread phil5 = new Thread(Philosopher5);

            phil1.Start();
            phil2.Start();
            phil3.Start();
            phil4.Start();
            phil5.Start();
            
        }

        public static void Philosopher1()
        {
            while (true)
            {
                lock (chops)
                {
                    chops[0] = true;
                    lock (chops)
                    {
                        chops[4] = true;
                        Thread.Sleep(1000);
                        chops[0] = false;
                        chops[4] = false;
                        Console.WriteLine("Comio Filosofo 1");
                    }
                }
            }
        }

        public static void Philosopher2()
        {
            while (true)
            {
                lock (chops)
                {
                    chops[1] = true;
                    lock (chops)
                    {
                        chops[0] = true;
                        Thread.Sleep(1000);
                        chops[0] = false;
                        chops[1] = false;
                        Console.WriteLine("Comio Filosofo 2");
                    }
                }
            }
        }

        public static void Philosopher3()
        {
            while (true)
            {
                lock (chops)
                {
                    chops[2] = true;
                    lock (chops)
                    {
                        chops[1] = true;
                        Thread.Sleep(1000);
                        chops[1] = false;
                        chops[2] = false;
                        Console.WriteLine("Comio Filosofo 3");
                    }
                }
            }
        }

        public static void Philosopher4()
        {
            while (true)
            {
                lock (chops)
                {
                    chops[3] = true;
                    lock (chops)
                    {
                        chops[2] = true;
                        Thread.Sleep(1000);
                        chops[2] = false;
                        chops[3] = false;
                        Console.WriteLine("Comio Filosofo 4");
                    }
                }
            }
        }

        public static void Philosopher5()
        {
            while (true)
            {
                lock (chops)
                {
                    chops[4] = true;
                    lock (chops)
                    {
                        chops[3] = true;
                        Thread.Sleep(1000);
                        chops[3] = false;
                        chops[4] = false;
                        Console.WriteLine("Comio Filosofo 5");
                    }
                }
            }
        }
    }
}
