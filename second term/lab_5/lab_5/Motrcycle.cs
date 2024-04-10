using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Motorcycle : TwoWheeledVehicle
    {
        public bool EngineIsRunning { get; private set; }
        public float FuelLevel { get; private set; } // Represented in liters
        public int Gear { get; private set; }
        public int MaxGear { get; private set; }

        // Constructor with additional parameters for fuel level and max gear
        public Motorcycle(int speed, float fuelLevel, int maxGear) : base(speed)
        {
            FuelLevel = fuelLevel;
            EngineIsRunning = false; // Engine starts off by default
            Gear = 0; // Neutral gear
            MaxGear = maxGear;
        }

        public void StartEngine()
        {
            if (!EngineIsRunning && FuelLevel > 0)
            {
                EngineIsRunning = true;
                Console.WriteLine("Motorcycle engine started.");
            }
            else
            {
                Console.WriteLine("Cannot start engine. Check if there's enough fuel.");
            }
        }

        public void StopEngine()
        {
            if (EngineIsRunning)
            {
                EngineIsRunning = false;
                Console.WriteLine("Motorcycle engine stopped.");
            }
        }

        public void Refuel(float amount)
        {
            FuelLevel += amount;
            Console.WriteLine($"Refueled. Current fuel level: {FuelLevel} liters.");
        }

        public void ChangeGear(int gear)
        {
            if (gear >= 0 && gear <= MaxGear)
            {
                Gear = gear;
                Console.WriteLine($"Gear changed to {Gear}.");
            }
            else
            {
                Console.WriteLine("Invalid gear selection.");
            }
        }

        public void Accelerate()
        {
            if (EngineIsRunning && FuelLevel > 0)
            {
                Speed += 10; // Simplified acceleration
                FuelLevel -= 0.5f; // Consumes fuel
                Console.WriteLine($"Accelerating. Current speed: {Speed}km/h. Fuel level: {FuelLevel} liters.");
            }
            else
            {
                Console.WriteLine("Cannot accelerate. Engine is off or no fuel.");
            }
        }

        public void Brake()
        {
            if (Speed > 0)
            {
                Speed -= 10; // Simplified braking
                if (Speed < 0) Speed = 0;
                Console.WriteLine($"Braking. Current speed: {Speed}km/h.");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Motorcycle - Speed: {Speed}km/h, Engine: {(EngineIsRunning ? "On" : "Off")}, Fuel: {FuelLevel} liters, Gear: {Gear}/{MaxGear}");
        }
    }
}
