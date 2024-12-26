using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            Pizza margherita = new PizzaBuilder()
                .SetSize("Medium")
                .SetCrust("Thin")
                .AddTopping("Cheese")
                .AddTopping("Tomato")
                .Build();

            Console.WriteLine("Margherita Pizza:");
            Console.WriteLine(margherita);


            Pizza chickenranch = new PizzaBuilder()
                .SetSize("Large")
                .SetCrust("Stuffed")
                .AddTopping("Pepperoni")
                .AddTopping("Cheese")
                .AddTopping("Olives")
                .Build();

            Console.WriteLine("\nchicken ranch Pizza:");
            Console.WriteLine(chickenranch);
        }
    }
    public class Pizza
    {
        public string Size { get; set; }
        public string Crust { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }

        public override string ToString()
        {
            return $"Size: {Size}, Crust: {Crust}, Toppings: {string.Join(", ", Toppings)}";
        }
    }

    // PizzaBuilder class
    public class PizzaBuilder
    {
        private readonly Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public PizzaBuilder SetSize(string size)
        {
            _pizza.Size = size;
            return this;
        }

        public PizzaBuilder SetCrust(string crust)
        {
            _pizza.Crust = crust;
            return this;
        }

        public PizzaBuilder AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }

    


}
