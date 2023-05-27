using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Tram : PublicTransport
    {

        public int numberVagons;
        public int crewCount;
        public int countPassangerInVagon;

        public Tram(int numberVagons, int crewCount, int countPassangerInVagon)
        {
            this.numberVagons = numberVagons;
            this.crewCount = crewCount;
            this.countPassangerInVagon = countPassangerInVagon;
        }

        public override void addPassangers()
        {
            if (isDriving)
            {
                if (numberPassengers < numberVagons * countPassangerInVagon)
                {
                    numberPassengers++;
                    Console.WriteLine("Теперь пассажиров " + numberPassengers);
                }
                else
                {
                    Console.WriteLine("Мест нет");
                }
            } else
            {
                Console.WriteLine("Трамвай не вышел на маршрут");
            }
            
        }

        public override void changeRoute(int newNumber)
        {
            numberRoute = newNumber;
            Console.WriteLine("Новый маршрут " + numberRoute);
        }

        public override void removePassangers()
        {
            if (isDriving)
            {
                if (numberPassengers > 0)
                {
                    numberPassengers--;
                    Console.WriteLine("Теперь пассажиров " + numberPassengers);
                }
                else
                {
                    Console.WriteLine("В трамвае никого нет");
                }
            }
            else
            {
                Console.WriteLine("Трамвай не вышел на маршрут");
            }
        }

        public void addVagon()
        {
            numberVagons++;
            Console.WriteLine("Теперь вагонов " + numberVagons);
        }

        public void removeVagon()
        {
            if (numberVagons > 0){ 
                numberVagons--;
                Console.WriteLine("Теперь вагонов " + numberVagons);
            } else
            {
                Console.WriteLine("У трамвая больше нет вагонов");
            }
        }
    }
}
