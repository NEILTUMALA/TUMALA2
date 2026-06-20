
using System;
using System.Collections.Generic;

class Student
{
    
    string Name;
    List<double> Grades;

    public Student(string name) 
    {
        Name = name;
        Grades = new List<double>();
    }

  
    public string GetName()
    {
        return Name;
    }

    public List<double> GetGrades()
    {
        return Grades;
    }

 
    public double GetAverage()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }

        double total = 0;
        for (int i = 0; i < Grades.Count; i++)
        {
            total = total + Grades[i];
        }

        return total / Grades.Count;
    }
}

class Program
{
    List<Student> students = new List<Student>();

    static void Main()
    {
       
        Program myProgram = new Program();
        myProgram.Run();
    }

    
    private void Run()
    {
        string choice = "";

        
        while (choice != "5")
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. View Class Average");
            Console.WriteLine("4. View Top Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                AddStudent();
            }
            else if (choice == "2")
            {
                ViewStudents();
            }
            else if (choice == "3")
            {
                ClassAverage();
            }
            else if (choice == "4")
            {
                TopStudent();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting program...");
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }

    private void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Student student = new Student(name);

        Console.Write("How many grades? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter grade " + (i + 1) + ": ");
            double grade = double.Parse(Console.ReadLine());
            student.GetGrades().Add(grade);
        }

        students.Add(student);
        Console.WriteLine("Student added successfully!");
    }

    private void ViewStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        for (int i = 0; i < students.Count; i++)
        {
            Student s = students[i];
            Console.WriteLine("\nName: " + s.GetName());

            Console.Write("Grades: ");
            for (int g = 0; g < s.GetGrades().Count; g++)
            {
                Console.Write(s.GetGrades()[g] + " ");
            }

            Console.WriteLine("\nAverage: " + s.GetAverage());
        }
    }

    private void ClassAverage()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        double totalSum = 0;
        for (int i = 0; i < students.Count; i++)
        {
            totalSum = totalSum + students[i].GetAverage();
        }

        double classAvg = totalSum / students.Count;
        Console.WriteLine("Class Average: " + classAvg);
    }

    private void TopStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        Student top = students[0];
        for (int i = 1; i < students.Count; i++)
        {
            if (students[i].GetAverage() > top.GetAverage())
            {
                top = students[i];
            }
        }

        Console.WriteLine("\n===== TOP STUDENT =====");
        Console.WriteLine("Name: " + top.GetName());
        Console.WriteLine("Average: " + top.GetAverage());
    }
}

