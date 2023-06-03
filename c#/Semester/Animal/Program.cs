using Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class AnimalMain
    {
        private static void Main(string[] args)
        {
            //코드 7-8: 코드 중복
            List<Dog> Dogs = new List<Dog>();
            List<Cat> Cats = new List<Cat>();
            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

            //코드 7-9: 다형성을 사용한 코드 중복 해결
            List<Animal> Anals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };
            foreach (var item in Anals)
            {
                item.Eat();
                item.Sleep();

                //코드 7-10: 무작정 변환해서 호출
                //예외가 발생하므로 주석

                 //((Cat)item).Meow();
            }

            //코드 7-12: 오브젝트 객체의 다형성 예제(1)
            List<object> listOfObjectA = new List<object>();
            listOfObjectA.Add(new Dog());
            listOfObjectA.Add(new Cat());

            //코드 7-13: 오브젝트 객체의 다형성 예제(2)
            List<object> listOfObjectB = new List<object>();
            listOfObjectB.Add(new Dog());
            listOfObjectB.Add(new Cat());
            listOfObjectB.Add(52);
            listOfObjectB.Add(521);
            listOfObjectB.Add(52.273f);
            listOfObjectB.Add(52.273);
        }
    }
}

