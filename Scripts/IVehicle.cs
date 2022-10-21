using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicle
{
    
}

public interface IVehicleFactory
{
    public IVehicle Create(VehicleRequirements reqs);
}

public class Unicycle : IVehicle
{

}

public class Bicycle : IVehicle
{

}

public class Tandem : IVehicle
{

}

public class Tricycle : IVehicle
{

}

public class ShopCart : IVehicle
{

}

public class FamilyBike : IVehicle
{

}

public class Car : IVehicle
{

}

public class Motorcycle : IVehicle
{

}

public class Truck : IVehicle
{

}