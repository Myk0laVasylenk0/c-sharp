
using lab_5;
using System;

// Варіант 3
// Створити суперклас Транспортний засіб і підкласи Мотоцикл, Велосипед,
// Мопед, Автомобіль, Потяг, Двоколісний транспорт. Подумати, які з вищенаведених
// підкласів також можуть бути суперкласами. За допомогою конструктора задати швидкість
// кожного засобу. Визначити, чи відкриті двері у транспортному засобі, якщо вони там є.
// Визначити кількість коліс у кожному засобі.

namespace VehicleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car instance
            Car myCar = new Car(60, "Toyota", "Camry");
            myCar.OpenDoors();
            myCar.ChangeSpeed(80);
            myCar.DisplayDetails();
            myCar.CloseDoors();

            Console.WriteLine();

            // Train instance
            Train myTrain = new Train(100, 8);
            myTrain.AddCarriage();
            myTrain.StartTrain();
            myTrain.DisplayTrainDetails();
            myTrain.StopTrain();
            myTrain.OpenDoors();

            Console.WriteLine();

            // Moped instance
            Moped myMoped = new Moped(25, 5.0f);
            myMoped.StartEngine();
            myMoped.Refuel(2);
            myMoped.DisplayDetails();

            Console.WriteLine();

            // Bicycle instance
            Bicycle myBike = new Bicycle(15, 21, "Mountain");
            myBike.ChangeGear(3);
            myBike.PedalFaster();
            myBike.DisplayDetails();

            Console.WriteLine();

            // Motorcycle instance
            Motorcycle myMotorcycle = new Motorcycle(45, 10.0f, 6);
            myMotorcycle.StartEngine();
            myMotorcycle.ChangeGear(1);
            myMotorcycle.Accelerate();
            myMotorcycle.Brake();
            myMotorcycle.DisplayDetails();
        }
    }
}