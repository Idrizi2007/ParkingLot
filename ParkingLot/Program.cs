using System.Security.Cryptography.X509Certificates;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();
            Car car1 = new Car("ABXZ-2134", "Toyota", "Car");
            parkingLot.ParkVehicle(car1);
            parkingLot.GetLicensePlate("ABXZ-2134");
            
        }
    }
}