using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Bicycle : TwoWheeledVehicle
    {
        public int GearCount { get; private set; }
        public int CurrentGear { get; private set; }
        public string BikeType { get; private set; } // "Mountain" or "Road"

        // Constructor with additional parameters for gear count and bike type
        public Bicycle(int speed, int gearCount, string bikeType) : base(speed)
        {
            GearCount = gearCount;
            CurrentGear = 1; // Default starting gear
            BikeType = bikeType;
        }

        // Method to change gears
        public void ChangeGear(int gear)
        {
            if (gear < 1 || gear > GearCount)
            {
                Console.WriteLine("Invalid gear selected.");
            }
            else
            {
                CurrentGear = gear;
                Console.WriteLine($"Gear changed to {CurrentGear}.");
            }
        }

        // Simulate pedaling faster
        public void PedalFaster()
        {
            Speed += 2; // Increase speed; this is a simplistic model
            Console.WriteLine($"Pedaling faster. Current speed: {Speed}km/h.");
        }

        // Simulate pedaling slower
        public void PedalSlower()
        {
            Speed -= 2; // Decrease speed but ensure it doesn't go below zero
            if (Speed < 0)
            {
                Speed = 0;
            }
            Console.WriteLine($"Pedaling slower. Current speed: {Speed}km/h.");
        }

        // Display bicycle details
        public void DisplayDetails()
        {
            Console.WriteLine($"Bike Type: {BikeType}, Speed: {Speed}km/h, Gear: {CurrentGear}/{GearCount}");
        }
    }
}
