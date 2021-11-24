using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading;
using System.Xml.XPath;

namespace lab4
{
    struct Shop
    {
        private string nameMachine;

        private int downTime;

        private int workTime;

        public string NameMachine
        {
            get => nameMachine;
            set => nameMachine = value;
        }

        public int DownTime
        {
            get => downTime;
            set => downTime = value;
        }

        public int WorkTime
        {
            get => workTime;
            set => workTime = value;
        }


        public Shop(string nameMachine, int downTime, int workTime)
        {
            this.nameMachine = nameMachine;
            this.downTime = downTime;
            this.workTime = workTime;
        }

        public override string ToString()
        {
            return "Номер модели " + nameMachine + " Время простоя " + downTime + " Время работы " + workTime;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            List<Shop> shops = new List<Shop>();
            shops.Add(new Shop("1Df6", 12, 12));
            shops.Add(new Shop("1Sf3", 10, 14));
            shops.Add(new Shop("2Dh2", 13, 11));
            shops.Add(new Shop("2Df64", 8, 16));
            shops.Add(new Shop("13Rf77", 16, 8));

            double sum = 0;
            double sum1 = 0;

            shops.Sort((a, b) => a.DownTime.CompareTo(b.DownTime));

            foreach (Shop i in shops)
            {
                sum1 += i.WorkTime;
                sum += i.DownTime;
                Console.WriteLine(i);
            }

            for (int i = 0; i < shops.Count - 1 - i; i++)
            {
                (shops[i], shops[shops.Count - i - 1]) = (shops[shops.Count - i - 1], shops[i]);
            }   //reverse

            double downTime = sum1 / (sum + sum1) * 100;
            
            Console.WriteLine("Общее время простоя = " + sum);
            Console.WriteLine("Общий процент простоя = " + downTime);

            Console.WriteLine("Топ-2 элемента по значению времени простоя");
            Console.WriteLine(shops[shops.Count-1]);
            Console.WriteLine(shops[shops.Count-2]);
        }
    }
}