namespace Factory
{
    public class BikeFactory : VehicleFactory
    {
        public Vehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}