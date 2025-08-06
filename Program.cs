using System;
using ParkingModel;

namespace mainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inicialPrice = 0;
            decimal pricePerHour = 0;

            Console.WriteLine("===========================");
            Console.WriteLine("Welcome to Parking System!");
            Console.WriteLine("===========================");
            Console.WriteLine("Type a inicial price: ");
            inicialPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Now type a price per hour: ");
            pricePerHour = Convert.ToDecimal(Console.ReadLine());

            Parking pk = new Parking(inicialPrice, pricePerHour);

            string option = string.Empty;
            bool showMenu = true;

            while (showMenu)
            {
                Console.WriteLine("");
                Console.WriteLine("Type an option: ");
                Console.WriteLine("[1] -> Add vehicle");
                Console.WriteLine("[2] -> Remove vehicle");
                Console.WriteLine("[3] -> List vehicles");
                Console.WriteLine("[4] -> Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        pk.AddVehicles();
                        break;
                    case "2":
                        Console.Clear();
                        pk.RemoveVehicle();
                        break;
                    case "3":
                        Console.Clear();
                        pk.ListVehicles();
                        break;
                    case "4":
                        Console.Clear();
                        showMenu = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please, choose a valid option!");
                        break;
                }
            }            
        }
    }
}