using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Human
    {
        public string name;
        public int age;

        public Human() { }

        public Human(string _name)
        {
            name = _name;
        }

        public Human(int _age)
        {
            age = _age;
            name = "Undefined";
        }

        public Human(string _name, int _age)
        {
            age = _age;
            name = _name;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
        public void SayHi()
        {
            Console.WriteLine("Привет!!!!");
        }
    }
}
