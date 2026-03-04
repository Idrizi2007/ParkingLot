using System.ComponentModel.Design;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace ParkingLot
{
    public class ParkingLot
    {
        
        private List<ParkingSpot> _parkingSpots;
        public ParkingLot()
        {
               _parkingSpots = new List<ParkingSpot>();
            _parkingSpots.Add(new ParkingSpot("C1", "Car"));
            _parkingSpots.Add(new ParkingSpot("C2", "Car"));
            _parkingSpots.Add(new ParkingSpot("C3", "Car"));
            _parkingSpots.Add(new ParkingSpot("B1", "Bike"));
            _parkingSpots.Add(new ParkingSpot("B2", "Bike"));
            _parkingSpots.Add(new ParkingSpot("B3", "Bike"));
            _parkingSpots.Add(new ParkingSpot("T1", "Truck"));
            _parkingSpots.Add(new ParkingSpot("T2", "Truck"));
            _parkingSpots.Add(new ParkingSpot("T3", "Truck"));
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            foreach (var spot in _parkingSpots)
            {
                if (spot.Assign(vehicle))
                {
                    return true;
                }
                else
                {
                    continue;
                }
              
            }
            return false;

        }
        public bool GetLicensePlate(string License)
        {
            foreach (ParkingSpot parkingSpot in _parkingSpots)
            {

                if (parkingSpot.ParkedVehicle != null)
                {
                    if (parkingSpot.ParkedVehicle.licensePlate == License)
                    {
                        parkingSpot.FreeSpot();
                        return true;

                    }
                   
                }
               

            }
            return false;
        }
    }
}