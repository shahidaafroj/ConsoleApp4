using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // Enum for Vehicle Type
    public enum VehicleType
    {
        Car,
        Motorcycle
    }

    // Interface for Interior Design
    public interface IInteriorDesign
    {
        List<string> InteriorDesigns { get; set; }
        void AddInteriorDesign(string design);
    }

    // Interface for Exterior Design
    public interface IExteriorDesign
    {
        List<string> ExteriorDesigns { get; set; }
        void AddExteriorDesign(string design);
    }

    // Abstract Vehicle class
    public abstract class Vehicle
    {
        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        public int EngineCapacity { get; set; }
        public int NumberOfGear { get; set; }
        public VehicleType Type { get; set; }
    }

    // TwoWheeler class inheriting Vehicle and implementing IExteriorDesign
    public abstract class TwoWheeler : Vehicle, IExteriorDesign
    {
        public List<string> ExteriorDesigns { get; set; } = new List<string>();

        public void AddExteriorDesign(string design)
        {
            ExteriorDesigns.Add(design);
        }
    }

    // FourWheeler class inheriting Vehicle and implementing IInteriorDesign
    public abstract class FourWheeler : Vehicle, IInteriorDesign
    {

        public List<string> InteriorDesigns { get; set; } = new List<string>();

        public void AddInteriorDesign(string design)
        {
            InteriorDesigns.Add(design);
        }
    }

    // Car class inheriting FourWheeler
    public sealed class Car : FourWheeler
    {
        public int NumberOfSeat { get; set; }
        public int NumberOfDoor { get; set; }
    }

    // Motorcycle class inheriting TwoWheeler
    public sealed class Motorcycle : TwoWheeler
    {
        public string StartingMethod { get; set; }
        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
        public int Mileage { get; set; }
        public string Cooling { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Select Vehicle Type: 1 for Car, 2 for Motorcycle: ");
                if (int.TryParse(Console.ReadLine(), out int vehicleChoice))
                {
                    if (vehicleChoice == 1)
                    {
                        // Creating and initializing Car object
                        Car car = new Car
                        {
                            ModelNo = "XYZ123",
                            YearMake = 2021,
                            NumberOfSeat = 5,
                            NumberOfGear = 6,
                            NumberOfDoor = 4,
                            EngineCapacity = 2000,
                            Type = VehicleType.Car
                        };
                        car.AddInteriorDesign("Leather Seats");
                        car.AddInteriorDesign("Sunroof");




                        // Displaying Car information
                        Console.WriteLine("Car Information:");
                        Console.WriteLine($"Model No.: {car.ModelNo}");
                        Console.WriteLine($"Year Make: {car.YearMake}");
                        Console.WriteLine($"Number of Seats: {car.NumberOfSeat}");
                        Console.WriteLine($"Number of Gears: {car.NumberOfGear}");
                        Console.WriteLine($"Number of Doors: {car.NumberOfDoor}");
                        Console.WriteLine($"Engine Capacity: {car.EngineCapacity} CC");
                        Console.WriteLine($"Vehicle Type: {car.Type}");
                        Console.WriteLine("Interior Designs:");
                        foreach (var design in car.InteriorDesigns)
                        {
                            Console.WriteLine($"- {design}");
                        }
                    }
                    else if (vehicleChoice == 2)
                    {
                        // Creating and initializing Motorcycle object
                        Motorcycle motorcycle = new Motorcycle
                        {
                            ModelNo = "ABC789",
                            YearMake = 2022,
                            NumberOfGear = 5,
                            StartingMethod = "Electric",
                            EngineCapacity = 150,
                            MaxPower = 20,
                            MaxTorque = 25,
                            Mileage = 40,
                            Cooling = "Liquid",
                            FrontBrake = "Disc",
                            RearBrake = "Drum",
                            Type = VehicleType.Motorcycle
                        };
                        motorcycle.AddExteriorDesign("Sporty Look");
                        motorcycle.AddExteriorDesign("LED Headlights");
                        // Displaying Motorcycle information
                        Console.WriteLine("\nMotorcycle Information:");
                        Console.WriteLine($"Model No.: {motorcycle.ModelNo}");
                        Console.WriteLine($"Year Make: {motorcycle.YearMake}");
                        Console.WriteLine($"Number of Gears: {motorcycle.NumberOfGear}");
                        Console.WriteLine($"Starting Method: {motorcycle.StartingMethod}");
                        Console.WriteLine($"Engine Capacity: {motorcycle.EngineCapacity} CC");
                        Console.WriteLine($"Maximum Power: {motorcycle.MaxPower} BPH");
                        Console.WriteLine($"Maximum Torque: {motorcycle.MaxTorque} NM");
                        Console.WriteLine($"Mileage: {motorcycle.Mileage} KMPL");
                        Console.WriteLine($"Cooling: {motorcycle.Cooling}");
                        Console.WriteLine($"Front Brake: {motorcycle.FrontBrake}");
                        Console.WriteLine($"Rear Brake: {motorcycle.RearBrake}");
                        Console.WriteLine($"Vehicle Type: {motorcycle.Type}");
                        Console.WriteLine("Exterior Designs:");
                        foreach (var design in motorcycle.ExteriorDesigns)
                        {
                            Console.WriteLine($"- {design}");
                        }
                    }
                }
                else
                {
                    Console.Write("Invalid input. Please enter 1 for Car or 2 for Motorcycle: ");

                }
            }
        }
    }

}
