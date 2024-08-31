using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( Calculator.add(10, 20));
            Console.WriteLine(Calculator.sub(10, 20));
            Console.WriteLine(Student.UniversityName);

            Student student1 = new Student("123456");
            student1.Name = "Hafizur Rahman";
            student1.Email = "h@gmail.com";
            string uname = Student.UniversityName;

            Console.WriteLine(student1.Name+ " " + student1.Email+" "+uname);
        }
    }
}
