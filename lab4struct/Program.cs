using System;
using static System.Console;
using System.Threading;
using System.Xml.Serialization;

namespace lab4struct
{
    struct Shop
    {
        public string nameMachine;
       
        public int downTime;

        public int workTime;

        public override string ToString()
        {
            return "Некита "+nameMachine + " " + downTime + " " + workTime;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Shop[] shops = new Shop[1];
            shops[0].nameMachine = "sdkhf";
            shops[0].downTime = 4;
            shops[0].workTime = 3;
            foreach (var sho in shops)
            {
                WriteLine(sho);
            }
        }
    }
}