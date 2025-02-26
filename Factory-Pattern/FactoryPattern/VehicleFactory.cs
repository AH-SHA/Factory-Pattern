using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        
        public static IVehicle GetVehicle(int tires)
        {

            switch (tires)
            {
                case 2:
                    return new Motorcycle();
                    break;

                case 4:
                    return new Car();
                    break;

                default:  //???Why can't the default term only use a break, instead of also needing a term
                    return new Car();
                    break;

            }


            
            


        }
        
     }

        
}
