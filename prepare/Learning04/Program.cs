using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        var person = new Person("id1", "Person1");
        var student = new Student("id2", "Student2", "Software Engineering");
        var emloyee = new Employee("id3", "Employee3", "CSEE");

        List<Person> people = new List<Person>();
        people.Add(person);
        people.Add(student);
        people.Add(emloyee);


        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}

public class Person {
    protected string _id;
    protected string _name;

    public Person(string id, string name) {
        _id = id;
        _name = name;
    }

    public void Display() 
    {
        Console.WriteLine($"Name = {_name}");
    }
}

public class Student: Person {
    private string _major;

    public Student(string studentId, string studentName, string major): base(studentId, studentName)
    {
        _major = major;
    }

    public void DisplayStudentSummary() 
    {
        Console.WriteLine($"{_name}: {_major}");
    }
}

public class Employee: Person {
    private string _department;

    public Employee(string employeeID, string employeeName, string department ): base (employeeID, employeeName)
    {
        _department = department;
    }
}

public class Vehicle {
    protected string _make;
    protected string _model;
    protected int _miles;

    public Vehicle(string make, string model, int miles)
    {
        _make = make;
        _model = model;
        _miles = miles;
    }
}

public class Car: Vehicle {
    public Car(string make, string model, int miles) : base(make, model, miles)
    {
    }
}

public class Truck: Vehicle {
    private int _towing;

    public Truck(string make, string model, int miles, int towing) : base(make, model, miles)
    {
        _towing = towing;

    }
}

public class Shape {
    protected string _color;
    public Shape(string color)
    {
        _color = color;
    }
}

public class Circle: Shape {
    private float _radius;

    public Circle(string color, float radius): base(color)
    {
        _radius=radius;
    }

    public float Area() {
        float pi =  (float)3.14;
        return pi * _radius * _radius;
    }
}

public class Square: Shape {
    private float _sideLength;

    public Square(string color, float sideLength): base(color)
    {
        _sideLength = sideLength;
    }

    public float Area() {
        return _sideLength * _sideLength;
    }
}