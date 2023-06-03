using Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹다."); }
        public void Sleep() { Console.WriteLine("콜콜 잔다."); }
    }
    class Dog : Animal
    {
        public string Coloe { get; set; }

        public void Bark() { Console.WriteLine("멍멍 짓다"); }
    }
    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("뫼옹 운다."); }
    }
}
