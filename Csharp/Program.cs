// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.Write("Dew");
//int num1 = 10;
//int num2 = 20;
//Console.WriteLine("num1= ", num1);
//Console.WriteLine("num2= ", num2);

//long num1 = 30000000000;
//string text = 'asffs';
//char text1 = "dew"; 
//double d1 = 700;
//int d2 = Convert.ToInt32(d1);

//string num1 = "1000";
//string num2 = "200000";
//int num3 = int.Parse(num1);
//int num4 = int.Parse(num2);
//Console.WriteLine(num3 + num4);


//Console.Write("Num1= ");
///   string num1 = int.Parse(Console.ReadLine());
//Console.Write("Num2= ");
// string num2 = int.Parse(Console.ReadLine());
//Console.WriteLine(${num1} + { num2} = {num1 + num1 2  });


///////////////////////////Lab2///////////////////////////////////////////////////////////////////////////////////
///Console.Write("Input Position = ");
//string pos = Console.ReadLine();
//Console.Write("Input Salary = ");
//float salary = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("-----------------------------");
//if (pos == "Assistant")
//{
// float bonus1 = salary * 1.05f;
// float nsalary1 = salary + bonus1;
//  Console.WriteLine("Your Position = " + pos);
//  Console.WriteLine("Your Salary = " + salary);
//  Console.WriteLine("Your Salary will be increased to = " + nsalary1);

//}
//else if (pos == "IT Support")
//{
//  float bonus2 = salary * 1.07f;
//    float nsalary2 = salary + bonus2;
//   Console.WriteLine("Your Position = " + pos);
//    Console.WriteLine("Your Salary will be increased to = " + nsalary2);
//}
//else if (pos == "Senior Developer")
//{
//  float bonus3 = salary * 1.10f;
//  float nsalary3 = salary + bonus3;
//  Console.WriteLine("Your Position = " + pos);
//  Console.WriteLine("Your Salary = " + salary);
//  Console.WriteLine("Your Salary will be increased to = " + nsalary3);
//}
//else if (pos == "Administrator")
//{
//  float bonus4 = salary * 1.08f;
///   float nsalary4 = salary + bonus4;
//   Console.WriteLine("Your Position = " + pos);
//    Console.WriteLine("Your Salary = " + salary);
//    Console.WriteLine("Your Salary will be increased to = " + nsalary4);
//}
//else
//{
//    float bonus5 = salary * 1.03f;
//    float nsalary5 = salary + bonus5;
//    Console.WriteLine("Your Position = " + pos);
//    Console.WriteLine("Your Salary = " + salary);
//    Console.WriteLine("Your Salary will be increased to = " + nsalary5);
//}

///////////////////////////////////////Lab2//////////////////////////////////////////////////////////////////////
//Loop
//while loop
//int num = 0;
//while (num <= 5)
//{
//  ++num;
// Console.WriteLine("Exit Loop"); 
//}
///////////////////////////////////////Lab3//////////////////////////////////////////////////////////////////////
/*using System;

class Program
{
    static void Main(string[] args)
    {
        int numStudents;
        do
        {
            Console.Write("Enter number of students: ");
        } while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0);

        string[] studentIDs = new string[numStudents];
        double[] studentScores = new double[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Enter student ID for student {i + 1}: ");
            string id = Console.ReadLine();
            studentIDs[i] = id;

            double score;
            do
            {
                Console.Write($"Enter score for student {i + 1}: ");
            } while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100);
            studentScores[i] = score;
        }

        char input;
        do
        {
            Console.Write("Exit? (Y/N): ");
            input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (input != 'Y' && input != 'N');

        if (input == 'Y')
        {
            Console.WriteLine("Student Data:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student ID: {studentIDs[i]}, Score: {studentScores[i]}");
            }
        }
        else
        {
            Main(args);
        }
    }
}*/
///////////////////////////////////////Lab3//////////////////////////////////////////////////////////////////////
//////////////////////////////////////Lab4/////////////////////////////////////////////////////////////////////////
class Animal
{
    public string name;
    public void Speak()
    {
        Console.WriteLine("Hello animal!");
    }
}

class Dog : Animal
{
    public string breed;

    public void Bark()
    {
        Console.WriteLine("Woof woof!");
    }

    public Dog(string name, string breed)
    {
        this.name = name;
        this.breed = breed;
    }  
    public Dog(string name)
    {
        this.name = name;
        this.breed = "Unknown";
    }
}
class Program
{
    static void Main(string[] args)
    {   
        Dog myDog = new Dog("Buddy", "Labrador Retriever");
        myDog.Speak();
        myDog.Bark();
        Console.WriteLine("My name is {0}.", myDog.name);      
        Console.WriteLine("I am a {0} {1}.", myDog.breed, typeof(Dog).Name);
    }
}
////////////////////////////Lab4/////////////////////////////////////////////////////////////////////////


















