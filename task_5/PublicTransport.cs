using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal abstract class PublicTransport : TransportVehicle
    {
        public bool isDriving { get; set; }

        public int numberPassengers = 0;
        public int numberRoute = 0;

        public void go()
        {
            isDriving = true;
            Console.WriteLine("Движение началось");
        }

        public void stop()
        {
            isDriving = false;
            Console.WriteLine("Движение закончилось");
        }

        public abstract void addPassangers();

        public abstract void removePassangers();

        public abstract void changeRoute(int newNumber);
    }
}
