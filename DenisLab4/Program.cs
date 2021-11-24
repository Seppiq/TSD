using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using static System.Console;

namespace DenisLab4
{
    struct Group
    {
        private string lastName;

        private string adress;

        private int house;

        private int bornOn;

        public int House
        {
            get => house;
            set => house = value;
        }


        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Adress
        {
            get => adress;
            set => adress = value;
        }

        public int BornOn
        {
            get => bornOn;
            set => bornOn = value;
        }

        public Group(string lastName, string adress, int house, int bornOn)
        {
            this.lastName = lastName;
            this.adress = adress;
            this.house = house;
            this.bornOn = bornOn;
        }

        public override string ToString()
        {
            return LastName + " " + adress + " " + House + " " + bornOn;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            Console.WriteLine("Изначальный список");
            groups.Add(new Group("Илларионов", "Восьмой", 8, 2002));
            groups.Add(new Group("Шех", "Цыганский переулок", 9, 2007));
            groups.Add(new Group("Карпов", "Сельская", 1, 2004));
            
            foreach (var i in groups)
            {
                WriteLine(i);
            }
            

            var selectedUsers = groups.Where(u=> u.House == 1);
            Console.WriteLine("\nЖители, живущие в доме #1 ");
            foreach (var i in selectedUsers)
            {
                WriteLine(i);
            }
            
            Console.WriteLine("\nЖители, живущие в доме #8 ");
            foreach (var i in groups)
            {
                if (i.House == 8)
                {
                    WriteLine(i);
                }
            }

            Console.WriteLine("\nСовершеннолетние ");
            foreach (var i in groups)
            {
                if (i.BornOn <= 2002)
                {
                    WriteLine(i);
                }
            }

            
        }
    }
}