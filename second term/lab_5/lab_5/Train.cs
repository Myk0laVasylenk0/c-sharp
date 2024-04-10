using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Train : Vehicle, IHasDoors
    {
        public int NumberOfCarriages { get; private set; }
        private bool areDoorsOpen;
        private bool isTrainInMotion;

        public Train(int speed, int numberOfCarriages) : base(speed)
        {
            NumberOfCarriages = numberOfCarriages;
            areDoorsOpen = false;
            isTrainInMotion = false;
        }

        public bool CheckIfDoorsAreOpen()
        {
            // Can check if the train is in motion and return false if it is
            return !isTrainInMotion && areDoorsOpen;
        }

        public void OpenDoors()
        {
            if (!isTrainInMotion)
            {
                areDoorsOpen = true;
            }
        }

        public void CloseDoors()
        {
            areDoorsOpen = false;
        }

        public override int GetNumberOfWheels()
        {
            // Assuming each carriage has a standard set of wheels, this could be dynamic
            return 8 * NumberOfCarriages;
        }

        public void AddCarriage()
        {
            NumberOfCarriages++;
        }

        public void RemoveCarriage()
        {
            if (NumberOfCarriages > 1) // Prevent a train from having 0 carriages
            {
                NumberOfCarriages--;
            }
        }

        public void StartTrain()
        {
            isTrainInMotion = true;
            CloseDoors(); // Automatically close doors when train starts
        }

        public void StopTrain()
        {
            isTrainInMotion = false;
            // Doors can be opened manually after the train stops
        }

        public void DisplayTrainDetails()
        {
            Console.WriteLine($"Train Speed: {Speed}km/h, Number of Carriages: {NumberOfCarriages}, Doors Open: {CheckIfDoorsAreOpen()}, In Motion: {isTrainInMotion}");
        }
    }
}
