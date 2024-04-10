using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Moped : Vehicle
    {
        public float FuelLevel { get; private set; } // Represented in percentage (0 to 100)
        public bool EngineIsRunning { get; private set; }

        // Constructor with an additional parameter for fuel level
        public Moped(int speed, float initialFuelLevel) : base(speed)
        {
            FuelLevel = initialFuelLevel;
            EngineIsRunning = false; // Engine starts off by default
        }

        public override int GetNumberOfWheels() => 2;

        // Start the engine if there's enough fuel and the engine isn't already running
        public void StartEngine()
        {
            if (FuelLevel > 0 && !EngineIsRunning)
            {
                EngineIsRunning = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("Cannot start engine. Either it's already running or there's no fuel.");
            }
        }

        // Stop the engine
        public void StopEngine()
        {
            if (EngineIsRunning)
            {
                EngineIsRunning = false;
                Console.WriteLine("Engine stopped.");
            }
            else
            {
                Console.WriteLine("Engine is not running.");
            }
        }

        // Method to refuel the moped
        public void Refuel(float amount)
        {
            FuelLevel += amount;
            if (FuelLevel > 100)
            {
                FuelLevel = 100; // Max out at 100%
            }
            Console.WriteLine($"Refueled. Current fuel level: {FuelLevel}%.");
        }

        // Display moped details
        public void DisplayDetails()
        {
            Console.WriteLine($"Speed: {Speed}km/h, Fuel Level: {FuelLevel}%, Engine Running: {EngineIsRunning}");
        }
    }
}
