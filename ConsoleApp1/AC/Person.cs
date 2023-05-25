using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AC
{
    public class Person
    {
        private string name;

        // Name 속성은 name 필드에 대한 읽기/쓰기 액세스를 제공
        public string Name { get { return name; } set { name = value; } }

        public Person() { }


        private int age;

        //  Age 속성은 age 필드에 대한 읽기/쓰기 액세스를 제공. 대소문자 주의 
        public int Age { get { return age; } set { age = value; } }
        public Person(string name, int age) { }

        internal void print()
        {
            Console.WriteLine("이름은 " + name + " 나이는 " + age);
        }

    }
}
