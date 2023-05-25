using ConsoleApp1.abstractClass;
using ConsoleApp1.AC;
using ConsoleApp1.Inherit;
using ConsoleApp1.interfaces;
using ConsoleApp1.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메인 함수 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inherit 
            
            ChildClass child = new ChildClass(); // child 선언 
            child.ParentMethod(); 
            child.ChildMethod();

            // Interface
            Animal animal = new Cat();
            animal.MakeSound();

            // AbstractClass

            AbsAnimal absAnimal = new abstractClass.Dog();

            absAnimal.Eat();
            absAnimal.sleeping();

            // 맛있는 피자!
            MainPizza pizza = new MainPizza();

            // 전부 똑같은 재료만 들어간 피자 8조각! 
            pizza.PizzaWholePrint(PizzaEnum.cheese);

            // 이제 2 조각씩 조각난 피자를 만들꺼에요 
            int count = 2;
            List<PizzaEnum> pizzaEnum = new List<PizzaEnum>();
            pizzaEnum.Add(PizzaEnum.peperoni);
            pizzaEnum.Add(PizzaEnum.pineapple);
            pizzaEnum.Add(PizzaEnum.potato);
            pizzaEnum.Add(PizzaEnum.bacon);
            
            // 페페로니 파인애플 감자 베이켠 2조각씩 내보내는 메소드
            pizza.PizzaPrint(pizzaEnum, count);


            // public Person(string name, int age) -> 대소문자 유의해서 보기
            Person person = new Person("Kim",30);
            person.Age = 35; // setter 첨가 
            // person.age = 30;

            person.print();

            // Sealed 된 콘텐츠를 불러오기 
            Sealed.Sealing sealing = new Sealed.Sealing();
            sealing.SealedPrint();
            // 이건 public 메소드라 가능 


        }
    }
}
