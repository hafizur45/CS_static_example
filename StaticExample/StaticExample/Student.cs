using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    internal class Student
    {

        static Student()
        {
            UniversityName = "DIU";
        }
        public Student()
        {

        }
        public Student(String regNo)
        {
            RegNo = regNo;
        }
        public string Name {  get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public static string UniversityName {  get; set; }
    }
}
