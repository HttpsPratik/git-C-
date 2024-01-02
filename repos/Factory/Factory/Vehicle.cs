namespace Factory;

public interface Vehicle
{
    void Drive();
}
public interface VehicleFactory
{
    Vehicle CreateVehicle();
}