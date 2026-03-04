namespace ParkingLot
{
    public abstract class Vehicle
    {
        public string licensePlate { get; set; }
        public string vehicleType { get; private set; }
        public  Vehicle(string LicensePlate, string model, string VehicleType)
        {
            this.vehicleType = VehicleType;
            this.licensePlate = LicensePlate;
        }
        
    }

    public class  Car : Vehicle
    {
        private string _licenseplate{ get; set; }
        private string _model{ get; set; }
        public Car(string LicensePlate, string model, string VehicleType)
            : base(LicensePlate, model, VehicleType)
        {
            _licenseplate = LicensePlate;
            _model = model;
        }
    }

    public class Bike : Vehicle
    {
        private string _licenseplate{ get; set; }
        private string _model{ get; set; }
        public Bike(string LicensePlate, string model, string VehicleType)
            :base(LicensePlate, model, VehicleType)
        {
            _licenseplate = LicensePlate;
            _model = model;
        }
    }
     public class Truck : Vehicle
    {
        private string _licenseplate{ get; set; }
        private string _model{ get; set; }
        public Truck(string LicensePlate, string model, string VehicleType)
            :base(LicensePlate, model, VehicleType)
        {
            _licenseplate = LicensePlate;
            _model = model;
        }
    }
}