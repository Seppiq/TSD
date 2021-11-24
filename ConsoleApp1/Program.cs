using System;
using System.Collections.Generic;

namespace tisd4
{
    class Program
    {
        struct BaggageOfPassenger
        {
            public string nameofpassenger; // имя пассажир
            public int veschi; // количество вещей
            public double ves; // вес в кг

            public BaggageOfPassenger(string nameofpassenger, int veschi, double ves)
            {
                this.nameofpassenger = nameofpassenger;
                this.veschi = veschi;
                this.ves = ves;
            }
        }

        static void Main(string[] args)
        {
            List<BaggageOfPassenger> bop = new List<BaggageOfPassenger>();
            bop.Add(new BaggageOfPassenger("Greg", 5, 4.231)); // добавление
            bop.Add(new BaggageOfPassenger("Antuan", 7, 7.478));
            bop.Add(new BaggageOfPassenger("Alukard", 10, 4.912));
            bop.Add(new BaggageOfPassenger("Aiden", 13, 2.516));
            bop.Add(new BaggageOfPassenger("Persival", 5, 4.482));
            bop.Add(new BaggageOfPassenger("Artur", 7, 5.138));
            bop.Add(new BaggageOfPassenger("Peter", 12, 5.237));
            bop.Add(new BaggageOfPassenger("Rick", 24, 5.653));

            Console.WriteLine("Пассажиры:");
            foreach (BaggageOfPassenger b in bop)
                Console.WriteLine($"{b.nameofpassenger,-10} \t {b.veschi,-10} \t {b.ves,-10}");

            Console.WriteLine();

            

            for (int i = 0; i < bop.Count; i++)
            {
                for (int j = i + 1; j < bop.Count - 1; j++)
                {
                    if (bop[i].veschi == bop[j].veschi & (bop[i].ves - bop[j].ves) < Math.Abs(0.5))
                    {
                        Console.WriteLine($"Количество вещей пассажира " + bop[i].nameofpassenger +
                                          " совпадает с количеством вещей пассажира " + bop[j].nameofpassenger +
                                          " и не различается по весу в 0,5 кг");
                    }
                }
            }
        }
    }
}