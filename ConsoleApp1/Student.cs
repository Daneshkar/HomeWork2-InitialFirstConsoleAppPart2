using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public Student()
        { }

        public Student(string name, int age)
        {
            Age = age;
            Name = name;
        }

        private string name;
        private int age;
        public int Age {  get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }

        public string Introduce()
        {
            return $"Hello, my name is {Name} and I am {Age} years old.";
        }
    }
}
