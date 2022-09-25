// Create a Inheritance of Car with a class demonstrating 
// Car information of Father & that same car is inherited by the son so display Car information of Child

// Car class will have members:
// ```
// noOfWheels
// CarLicensPlateRegNo
// CarUserName
// CarUserLicenceNo

using System;
class Car
{
    public void noOfWheels( int noOfWheels = 4)
    {
        Console.WriteLine("Car's Wheels : " + noOfWheels);
    }
    public void CarLicensPlateRegNo (int CarLicensPlateRegNo = 240523625)
    {
        Console.WriteLine("Car's License number : " + CarLicensPlateRegNo);
    }

    public virtual void CarUserName (string CarUserName)
    {
        Console.WriteLine("User's name : " + CarUserName);
    }
    public virtual void CarUserLicenceNo (int CarUserLicenceNo)
    {
        Console.WriteLine("User's License number : " + CarUserLicenceNo);
    }

}
class Father : Car
{
    public override void CarUserName(string CarUserName)
    {
        base.CarUserName(CarUserName);
    }
    public override void CarUserLicenceNo(int CarUserLicenceNo)
    {
        base.CarUserLicenceNo(CarUserLicenceNo);
    }
}
class Son : Car
{
    public override void CarUserName(string CarUserName)
    {
        base.CarUserName(CarUserName);
    }
    public override void CarUserLicenceNo(int CarUserLicenceNo)
    {
        base.CarUserLicenceNo(CarUserLicenceNo);
    }
}

class Program
{
    static void Main()
    {
        Car Car = new Car();
        Car Father = new Father();
        Father.CarUserName("Mahbub Islam Khan Parvez");
        Father.CarUserLicenceNo(110225315);
        Father.CarLicensPlateRegNo();
        Father.noOfWheels();

        Console.WriteLine("\n");

        Car Son = new Son();
        Son.CarUserName("Mahfuz Islam Khan jabed");
        Son.CarUserLicenceNo(560305922);
        Son.CarLicensPlateRegNo();
        Son.noOfWheels();

        
    }
}