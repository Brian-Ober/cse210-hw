using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

      //  string carMake = "Honda";
       // string carModel = "Civic";
       // int carMilage = 33;

       var car1 = new Car();
       car1._make = "Honda";
       car1._model ="Civic";
       car1._mileage = 30;
       car1._gallonsOfFuel = 10;
       car1.owner = new Owner();
       car1.owner.name = "Bob";
       car1.owner.phoneNumber = "234-567-8167";

       int miles = car1.RemainingMile();

       var cars = new List<Car>();
       cars.Add(car1);

       Console.WriteLine($"There are {miles} miles remaining");


       var job1 = new Job();
       job1._company = "Namify";
       job1._jobTitle = "Line Associate";
       job1._startYear = 2020;
       job1._endYear = 2021;

       job1.Display();

       var job2 = new Job();
       job2._company = "Fedex";
       job2._jobTitle = "Package Handler";
       job2._startYear = 2021;
       job2._endYear = 2023;
       
       Resume myResume = new Resume();
       myResume._name = "Brian Ober";

       myResume.jobs.Add(job1);
       myResume.jobs.Add(job2);

       myResume.DisplayResume();
    }
}

public class Owner 
{
    public string name;
    public string phoneNumber;
}

