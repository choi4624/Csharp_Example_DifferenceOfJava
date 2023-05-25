using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Pizza
{

    // 클래스를 여러개 분리 해놓는 방법 
    public partial class MainPizza


    {
        private int count;
        private List<PizzaEnum> pizzaEnums = new List<PizzaEnum>();

        public void PizzaPrint(List<PizzaEnum> pizzaEnum, int count)
        {
            foreach (var item in pizzaEnum)
            {
                Console.WriteLine(item + " 종류 " + count + " 조각 ");
            }
            
        }

    }
}
