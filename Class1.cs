using System;
using System.Collections.Generic;

class Program
{
    List<string> studentNames = new List<string>();
    List<double> studentGrade1 = new List<double>();
    List<double> studentGrade2 = new List<double>();
    List<double> studentGrade3 = new List<double>();

    static void Main()
    {
        Program program = new Program();
        program.Start();
    }

    private void Start()
    {
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\n===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("=========================");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            Conversation with Gemini
            Using System;

            using System.Collections.Generic;

            using System.Linq;

class Student

    {

        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public Student(string name)

        {

            Name = name;

            Grades = new List<double>();

        }

        public double GetAverage()

        {

            if (Grades.Count == 0) return 0;

            return Grades.Average();

        }

    }

    class Program

    {

        static List<Student> students = new List<Student>();

        static void Main()

        {

            while (true)

            {

                Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");

                Console.WriteLine("1. Add Student");

                Console.WriteLine("2. View All Students");

                Console.WriteLine("3. View Class Average");

                Console.WriteLine("4. View Top Student");

                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)

                {

                    case "1":

                        AddStudent();

                        break;

                    case "2":

                        ViewStudents();

                        break;

                    case "3":

                        ClassAverage();

                        break;

                    case "4":

                        TopStudent();

                        break;

                    case "5":

                        Console.WriteLine("Exiting program...");

                        return;

                    default:

                        Console.WriteLine("Invalid option. Try again.");

                        break;

                }

            }

        }

        static void AddStudent()

        {

            Console.Write("Enter student name: ");

            string name = Console.ReadLine();

            Student student = new Student(name);

            Console.Write("How many grades? ");

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)

            {

                Console.Write($"Enter grade {i + 1}: ");

                double grade = double.Parse(Console.ReadLine());

                student.Grades.Add(grade);

            }

            students.Add(student);

            Console.WriteLine("Student added successfully!");

        }

        static void ViewStudents()

        {

            if (students.Count == 0)

            {

                Console.WriteLine("No students found.");

                return;

            }

            foreach (var s in students)

            {

                Console.WriteLine($"\nName: {s.Name}");

                Console.WriteLine($"Grades: {string.Join(", ", s.Grades)}");

                Console.WriteLine($"Average: {s.GetAverage():0.00}");

            }

        }

        static void ClassAverage()

        {

            if (students.Count == 0)

            {

                Console.WriteLine("No students available.");

                return;

            }

            double classAvg = students.Average(s => s.GetAverage());

            Console.WriteLine($"Class Average: {classAvg:0.00}");

        }

        static void TopStudent()

        {

            if (students.Count == 0)

            {

                Console.WriteLine("No students available.");

                return;

            }

            Student top = students.OrderByDescending(s => s.GetAverage()).First();

            Console.WriteLine("\n===== TOP STUDENT =====");

            Console.WriteLine($"Name: {top.Name}");

            Console.WriteLine($"Average: {top.GetAverage():0.00}");

        }

    }



    I'm creating now a student management, can you do my code into simple, take note don't use Public, make it "Private" and also don't use static, and can you use use in case 1... use the If and Else, just make it simple, don't use advance codes

Here is a simplified version of your Student Management System.

To meet your requirements, I have removed static from the core logic, made fields and methods private (or removed the public keyword, which defaults to internal/private in C# depending on the context), and used standard if/else logic instead of advanced LINQ methods like .Average() or .OrderByDescending().

Simplified C# Code
C#
using System;
using System.Collections.Generic;

class Student
{
    // Removing 'public' defaults access to internal/private within the project
    string Name;
    List<double> Grades;

    public Student(string name) // Constructor needs to stay public so Program can create it
    {
        Name = name;
        Grades = new List<double>();
    }

    // Helper methods to let Program access the hidden data
    public string GetName()
    {
        return Name;
    }

    public List<double> GetGrades()
    {
        return Grades;
    }

    // Calculated the average using a simple loop instead of LINQ
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
    // Keeps track of students without using advanced static collections in the methods
    List<Student> students = new List<Student>();

    static void Main()
    {
        // To remove 'static' from everything else, we create an instance of Program
        Program myProgram = new Program();
        myProgram.Run();
    }

    // This replaces the static Main loop
    private void Run()
    {
        string choice = "";

        // Using simple if/else instead of switch/case for the menu
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

        // Simple loop to add grades
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

            // Displays grades cleanly without advanced string.Join
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

        // Replaced LINQ .Average() with a basic loop math pattern
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

        // Replaced advanced OrderByDescending logic with a basic "Find Maximum" loop
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
What Changed?
No more static methods: In C#, the Main method must be static to start the program. To get around this without making everything else static, Main now simply creates an instance of your program (Program myProgram = new Program();) and runs it.

Removed public / Added private: The variables and methods inside Program now explicitly use private. The properties in Student had their public tags removed to make them local, and simple "Getter" functions like GetName() were added to securely bridge the data.

Menu if/else switch: The switch(choice) block inside the menu was replaced entirely with standard if and else if statements.

No Advanced LINQ: Instead of using .Average() or.OrderByDescending(), the math is now calculated using standard for loops and classic total / count equations.

this is the needed or requirements

Based on your assignment screenshots, your instructor has a very specific requirement: "Student Management System – Procedural Core".

This means you shouldn't use custom object classes (like class Student) at all! Instead, procedural programming uses simple arrays or lists directly inside your Program class.

I have rewritten the code to match your requirements perfectly:

It uses no custom classes(Procedural approach).

It uses no public keywords and no static variables/ methods(except for Main to launch the app).

The menu uses standard if and else if blocks.

The console outputs, text headers, and grade counts (exactly 3 grades per student based on the image flow) match your assignment requirements precisely.

Simplified Procedural Code
C#
using System;
using System.Collections.Generic;

class Program
{
    // Simple parallel lists to hold the data instead of using a Student class
    List<string> studentNames = new List<string>();
    List<double> studentGrade1 = new List<double>();
    List<double> studentGrade2 = new List<double>();
    List<double> studentGrade3 = new List<double>();

    static void Main()
    {
        // Object instance used to avoid using 'static' on your functions
        Program program = new Program();
        program.Start();
    }

    private void Start()
    {
        string choice = "";

        while (choice != "5")
        {
            // Text headers match your assignment instructions exactly
            Console.WriteLine("\n===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("=========================");
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
                ComputeAverage();
            }
            else if (choice == "4")
            {
                FindHighestGrade();
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nExiting program...");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }

}

private void AddStudent()
{
    Console.WriteLine();
    Console.Write("Enter student name: ");
    string name = Console.ReadLine();

    Console.Write("Enter grade 1: ");
    double g1 = double.Parse(Console.ReadLine());

    Console.Write("Enter grade 2: ");
    double g2 = double.Parse(Console.ReadLine());

    Console.Write("Enter grade 3: ");
    double g3 = double.Parse(Console.ReadLine());

    studentNames.Add(name);
    studentGrade1.Add(g1);
    studentGrade2.Add(g2);
    studentGrade3.Add(g3);

    Console.WriteLine("Student added successfully!");
}

private void ViewStudents()
{
    if (studentNames.Count == 0)
    {
        Console.WriteLine("\nNo students found.");
        return;
    }

    for (int i = 0; i < studentNames.Count; i++)
    {
        double average = (studentGrade1[i] + studentGrade2[i] + studentGrade3[i]) / 3.0;

        Console.WriteLine("\nName: " + studentNames[i]);
        Console.WriteLine("Grades: " + studentGrade1[i] + ", " + studentGrade2[i] + ", " + studentGrade3[i]);
        Console.WriteLine("Average: " + average.ToString("0.00"));
    }
}

private void ComputeAverage()
{
    Console.WriteLine("\n===== CLASS AVERAGE =====");
    if (studentNames.Count == 0)
    {
        Console.WriteLine("Overall Average Grade: 0.00");
        return;
    }

    double totalClassSum = 0;

    for (int i = 0; i < studentNames.Count; i++)
    {
        double studentAverage = (studentGrade1[i] + studentGrade2[i] + studentGrade3[i]) / 3.0;
        totalClassSum = totalClassSum + studentAverage;
    }

    double overallAverage = totalClassSum / studentNames.Count;
    Console.WriteLine("Overall Average Grade: " + overallAverage.ToString("0.00"));
}

private void FindHighestGrade()
{
    Console.WriteLine("\n===== HIGHEST GRADE =====");
    if (studentNames.Count == 0)
    {
        Console.WriteLine("No students available.");
        return;
    }

    string topStudent = studentNames[0];
    double highestGrade = studentGrade1[0];

    for (int i = 0; i < studentNames.Count; i++)
    {
        if (studentGrade1[i] > highestGrade)
        {
            highestGrade = studentGrade1[i];
            topStudent = studentNames[i];
        }
        if (studentGrade2[i] > highestGrade)
        {
            highestGrade = studentGrade2[i];
            topStudent = studentNames[i];
        }
        if (studentGrade3[i] > highestGrade)
        {
            highestGrade = studentGrade3[i];
            topStudent = studentNames[i];
        }
    }

    Console.WriteLine("Top Student: " + topStudent);
    Console.WriteLine("Highest Grade: " + highestGrade);
}
