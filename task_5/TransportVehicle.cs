using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal interface TransportVehicle
    {
        bool isDriving { get; set; }
        void go();

        void stop();
    }
}
