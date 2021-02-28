using System;
using System.Collections.Generic;

namespace BuilderPattern.CarExampleWithInterface
{
    /// <summary>

    /// MainApp startup class for Real-World

    /// Builder Design Pattern.

    /// </summary>

    public class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        public static void Main()
        {
            //MotorCycleBuilder builder;

            // Create shop with vehicle builders

            Shop shop = new Shop();

            // Construct and display vehicles

            var  sooterBuilder = new ScooterBuilder();
            shop.Construct(sooterBuilder);
            sooterBuilder.GetProduct().Show();

            var carBuilder = new CarBuilder();
            shop.Construct(carBuilder);
            carBuilder.GetProduct().Show();

            var motorCycleBuilder = new MotorCycleBuilder();
            shop.Construct(motorCycleBuilder);
            motorCycleBuilder.GetProduct().Show();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Director' class

    /// </summary>

    internal class Shop

    {
        // Builder uses a complex series of steps

        public void Construct(IVehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }

    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>

    public interface IVehicleBuilder

    {
        void BuildFrame();

        void BuildEngine();

        void BuildWheels();

        void BuildDoors();
    }

    /// <summary>

    /// The 'ConcreteBuilder1' class

    /// </summary>

    internal class MotorCycleBuilder : IVehicleBuilder
    {
        private Vehicle vehicle = new Vehicle();

        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }

        public void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }

        public void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public Vehicle GetProduct()
        {
            Vehicle result = this.vehicle;

            return result;
        }
    }

    /// <summary>

    /// The 'ConcreteBuilder2' class

    /// </summary>

    internal class CarBuilder : IVehicleBuilder

    {
        private Vehicle vehicle = new Vehicle();

        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }

        public void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public void BuildDoors()
        {
            vehicle["doors"] = "4";
        }

        public Vehicle GetProduct()
        {
            Vehicle result = this.vehicle;

            return result;
        }
    }

    ///// <summary>

    ///// The 'ConcreteBuilder3' class

    ///// </summary>

    internal class ScooterBuilder : IVehicleBuilder

    {
        private Vehicle vehicle = new Vehicle();

        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        public void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }

        public void BuildEngine()
        {
            vehicle["engine"] = "50 cc";
        }

        public void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public Vehicle GetProduct()
        {
            Vehicle result = this.vehicle;

            return result;
        }
    }

    /// <summary>

    /// The 'Product' class

    /// </summary>

    public class Vehicle
    {
        private string _vehicleType;

        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor

        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        public Vehicle()
        {
        }

        // Indexer

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}