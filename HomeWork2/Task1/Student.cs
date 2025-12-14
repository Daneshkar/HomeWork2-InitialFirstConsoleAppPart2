using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task1
{
    public class Student
    {
        private string _name;
        private int _age;
        public Student(string Name, int Age)
        {
            _name = Name;
            _age = Age;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age 
        { 
            get { return _age; } 
            set { _age = value; }
        
        }
        public void introduce() 
        {
            Console.WriteLine($"Hello, my name is {Name} and i am {Age} years old");
        }

    }
} 