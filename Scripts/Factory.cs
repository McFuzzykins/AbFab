using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct VehicleRequirements
{
    public int wheels;
    public int passengers;
    public bool hasEngine;
    public bool hasCargo;
}

public abstract class AbstractVehicleFactory : MonoBehaviour
{
    public abstract IVehicleFactory CycleFactory();
    public abstract IVehicleFactory MotorVehicleFactory();
}

public class VehicleFactory : AbstractVehicleFactory
{
    public override IVehicleFactory CycleFactory()
    {
        return new CycleFactory();
    }

    public override IVehicleFactory MotorVehicleFactory()
    {
        return new MotorVehicleFactory();
    }
}

public class CycleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements reqs)
    {
        switch (reqs.passengers)
        {
            case 1:
                if (reqs.wheels == 1) return new Unicycle();
                return new Bicycle();
            case 2:
                return new Tandem();
            case 3:
                return new Tricycle();
            case 4:
                if (reqs.hasCargo) return new ShopCart();
                return new FamilyBike();
            default:
                return new Bicycle();
        }
    }
}

public class MotorVehicleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements reqs)
    {
        if(reqs.hasCargo)
        {
            return new Truck();
        }
        else if (reqs.wheels <= 2)
        {
            return new Motorcycle();
        }
        else
        {
            return new Car();
        }
    }
}
