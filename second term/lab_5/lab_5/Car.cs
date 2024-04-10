using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Car : Vehicle, IHasDoors
    {
        // Additional properties
        public string Make { get; private set; }
        public string Model { get; private set; }
        private bool areDoorsOpen;

        // Constructor with more parameters
        public Car(int speed, string make, string model) : base(speed)
        {
            Make = make;
            Model = model;
            areDoorsOpen = false; // Doors are initially closed
        }

        // Implementation of IHasDoors
        public bool CheckIfDoorsAreOpen()
        {
            return areDoorsOpen;
        }

        // Method to open doors
        public void OpenDoors()
        {
            areDoorsOpen = true;
        }

        // Method to close doors
        public void CloseDoors()
        {
            areDoorsOpen = false;
        }

        // Override the GetNumberOfWheels method
        public override int GetNumberOfWheels() => 4;

        // Method to change the car's speed
        public void ChangeSpeed(int newSpeed)
        {
            Speed = newSpeed;
        }

        // Display car details
        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Speed: {Speed}km/h, Doors Open: {CheckIfDoorsAreOpen()}");
        }
    }
}
