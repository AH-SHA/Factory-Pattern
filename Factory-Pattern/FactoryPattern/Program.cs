using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Does the vehicle have 2 or 4 tires?");
            var tires = int.Parse(Console.ReadLine());

            if (tires != 2 && tires != 4)
            {
                Console.WriteLine("Try again, entered wrong number format or amount");
            }

            //Calling the GetVeichile Method, but need to use the static class infront, since its a static method.
            //Creating a new variable to be able to call the GetVehicle Method and store the results of the scope of the method.

            var answer = VehicleFactory.GetVehicle(tires);
            Console.WriteLine();

            //The newly created variable, can be used to access the individual methods existing in each class, which derived from the stubbed out method in the Interface.
            answer.Drive();
           
            

            

        }
    }
}
