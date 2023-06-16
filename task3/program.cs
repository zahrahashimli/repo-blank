using System;

namespace _3june_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Zahra", "Hashimli", 5);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Surname: " + student.Surname);
            Console.WriteLine("Age: " + student.Age);
            student.Learn();

            Console.WriteLine('\n');

            Teacher teacher = new Teacher("Niyazi", "Babayev", 6);
            Console.WriteLine("Name: " + teacher.Name);
            Console.WriteLine("Surname: " + teacher.Surname);
            Console.WriteLine("Age: " + teacher.Age);
            teacher.Explain();


        }
    }



    




}
