using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace RomaLab4
{
    struct Work
    {
        private string nameMashine;

        private int time;

        private int timeWork;
        
        public string NameMashine
        {
            get => nameMashine;
            set => nameMashine = value;
        }

        public int Time
        {
            get => time;
            set => time = value;
        }

        public int TimeWork
        {
            get => timeWork;
            set => timeWork = value;
        }

        public Work(string nameMashine, int time, int timeWork)
        {
            this.nameMashine = nameMashine;
            this.time = time;
            this.timeWork = timeWork;
        }
        
        public override string ToString()
        {
            return nameMashine + " " + time + " " + timeWork;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Work> works = new List<Work>();
            Console.WriteLine("Изначальный список:");
            works.Add(new Work("sdg54", 0, 12));
            works.Add(new Work("tyr54", 8, 16));
            works.Add(new Work("ytr54", 2, 20));

            works.Sort((a, b) => a.Time.CompareTo(b.Time));
            works.Reverse();
            foreach (var i in works)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Станки без простоя");
            foreach (var i in works)
            {
                if (i.Time > 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("Станки без простоя#2");
            var workss = works.Where(u=> u.Time > 0);
            foreach (var i in workss)
            {
                Console.WriteLine(i);
            }

            int sum = 0;
            Console.WriteLine("Время простоя");
            foreach (var i in works)
            {
                sum += i.Time;
                Console.WriteLine(i.Time);
            }

            Console.WriteLine("Сумма простоев станков " + sum);
            Console.WriteLine("Топ-2 по времени простоя");
            Console.WriteLine(works[0]);
            Console.WriteLine(works[1]);
        }
    }
}