using System.Linq.Expressions;

namespace ParkingLot
{
    public class ParkingSpot
    {
        private string _spotId;
        private string _spottype;
        public Vehicle? ParkedVehicle { get; private set; }
        private Vehicle? _vehicle {  get ; set; }

        public ParkingSpot(string SpotId, string SpotType)
        {
            _spotId = SpotId;
            _spottype = SpotType;
        }

        public bool CanFit(Vehicle vehicle)
        {
            if ((_vehicle == null) && (_spottype == vehicle.vehicleType))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Assign(Vehicle vehicle)
        {
            if (CanFit(vehicle))
            {
                _vehicle = vehicle;
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool FreeSpot() 
        {
            if (_vehicle != null)
            {
                _vehicle = null;
                return true;
            }
            else
            {
                return false;
            }
        }

        

     
    }
}