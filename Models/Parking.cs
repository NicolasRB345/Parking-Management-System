using System.Security.Cryptography.X509Certificates;

namespace ParkingModel
{
    public class Parking
    {
        private decimal inicialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();
        private List<DateTime> time_added = new List<DateTime>();

        public Parking(decimal inicialPrice, decimal pricePerHour)
        {
            this.inicialPrice = inicialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicles()
        {
            Console.WriteLine("Type the vehicle license plate to be added: ");
            string? licensePlate = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(licensePlate)) // verify if licensePlate is not null or contain space.
            {
                vehicles.Add(licensePlate);
                time_added.Add(DateTime.Now);
                Console.WriteLine($"Vehicle [{licensePlate}] has just parked at {DateTime.Now}");
            }
            else
            {
                Console.WriteLine("Pleade, type a valid license plate");
            }
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Type the vehicle license plate to be removed: ");
            string? licensePlate = Console.ReadLine();

            if (licensePlate != null && vehicles.Any(x => x.ToUpper() == licensePlate.ToUpper()))
            {
                Console.WriteLine("Type how many hours was the vehicle parked: ");
                decimal hoursParked = Convert.ToDecimal(Console.ReadLine());
                decimal totalPrice = inicialPrice + pricePerHour * hoursParked;
                Console.WriteLine($"Vehicle {licensePlate} was removed of the Parking at {DateTime.Now}. Total price: ${totalPrice}");
                int index_vehicle = vehicles.IndexOf(licensePlate); // take the index vehicle to remove the time parked associated.
                vehicles.Remove(licensePlate);
                time_added.Remove(time_added[index_vehicle]); // remove the time parked associated by the index vehicle removed

            }
            else
            {
                Console.WriteLine("Sorry :( We cannot found your vehicle, be sure that you type the licence plate right.");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("Vehicles parked: ");
                for (int i = 0; i < vehicles.Count; i++)
                {
                    Console.WriteLine($"V {i}º - {vehicles[i]} at {time_added[i]}");
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles parked.");
            }
        }
    }
}