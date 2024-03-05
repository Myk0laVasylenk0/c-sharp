
// Task 1

//Реалізувати клас, що моделює роботу N-містної автостоянки. Машина під'їжджає до певного місця і їде вгору,
// поки не зустрінеться вільне місце. Клас повинен підтримувати методи, які обслуговують приїзд і від'їзд машини.


using System;
using System.Collections.Generic;

class ParkingLot
{
    private int capacity;
    private Queue<int> availableSpots;

    public ParkingLot(int capacity)
    {
        this.capacity = capacity;
        availableSpots = new Queue<int>();
        for (int i = 1; i <= capacity; i++)
        {
            availableSpots.Enqueue(i);
        }
    }

    public bool ParkCar()
    {
        if (availableSpots.Count == 0)
        {
            Console.WriteLine("Parking lot is full. Cannot park car.");
            return false;
        }
        else
        {
            int spot = availableSpots.Dequeue();
            Console.WriteLine($"Car parked at spot {spot}.");
            return true;
        }
    }

    public void RemoveCar(int spot)
    {
        if (spot > 0 && spot <= capacity)
        {
            availableSpots.Enqueue(spot);
            Console.WriteLine($"Car removed from spot {spot}.");
        }
        else
        {
            Console.WriteLine($"Invalid spot number {spot}. Please provide a valid spot number.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 1: \n");
        ParkingLot parkingLot = new ParkingLot(5);

        parkingLot.ParkCar();
        parkingLot.ParkCar();
        parkingLot.ParkCar();
        parkingLot.ParkCar();
        parkingLot.ParkCar();

        parkingLot.RemoveCar(5);
        parkingLot.RemoveCar(1);

        parkingLot.ParkCar();
        parkingLot.ParkCar();

        Console.ReadLine();

        Console.ReadKey();
        Console.Clear();
    }

}






























