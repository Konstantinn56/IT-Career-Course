using System;
using System.Collections.Generic;

namespace PizzaEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaInfo = Console.ReadLine().Split();
            Pizza pizza = new Pizza(pizzaInfo[1], int.Parse(pizzaInfo[2]));


            string[] info = Console.ReadLine().Split();
            while (!info[0].Equals("END"))
            {
                switch (info[0])
                {
                    case "Dough":
                        Dough dough = new Dough(info[1], info[2], double.Parse(info[3]));
                        pizza.AddDough(dough);
                        break;
                    case "Topping":
                        Topping topping = new Topping(info[1], double.Parse(info[2]));
                        pizza.AddTopping(topping);
                        break;
                }
                info = Console.ReadLine().Split();
            }
            Console.WriteLine(pizza);
        }
    }
}
