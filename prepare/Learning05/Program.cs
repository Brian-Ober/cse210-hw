using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!\n");

        var people = new List<Person> {
            new Student("id1", "Student1", "Software Engineering"),
            new Employee("id2", "Employee2", "CSEE")
        };
        
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            
            string color = s.GetColor();

            
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}

public class Person
{
    private string _id;
    private string _name;
    protected Person (string id, string name)
    {
        _id = id;
        _name = name;
    }
}

public class Student: Person {
    private string _classTaken;
    public Student (string id, string name, string classTaken): base(id, name)
    {
        _classTaken = classTaken;
    }
}

public class Employee: Person {
    private string _department;
    public Employee (string id, string name, string department): base(id, name)
    {
        _department = department;
    }
}