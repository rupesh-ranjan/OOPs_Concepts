using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            #region Person
            // Person person = new Person();
            //var person = Person.Parse("Rupesh");
            ////person.Name = "Rupesh";
            //person.Introduce("Kumar");
            #endregion

            #region Customer
            //var customer = new Customer(1, "Jhon");
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);
            #endregion

            #region Order
            //var customer = new Customer();
            //var order = new Order();
            //customer.Orders.Add(order);
            #endregion

            #region Point
            //UsePoints();
            #endregion

            #region Calculator
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));

            #endregion

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(new Point(10, 20));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
    
}