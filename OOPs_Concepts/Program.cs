using Amazon;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Person
            Person person = new Person(new DateTime(1998, 3, 1));
            //var person = Person.Parse("Rupesh");
            //person.Name = "Rupesh";
            //person.SetBirthdate(DateTime.Now);
            //Console.WriteLine(person.GetBirthdate());
            //person.Introduce("Kumar");

            //Console.WriteLine(person.Age);
            #endregion

            #region Customer
            //var customer = new Customer(1, "Jhon");
            ////Console.WriteLine(customer.Id);
            ////Console.WriteLine(customer.Name);
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());
            //customer.Promote();
            //Console.WriteLine(customer.Orders.Count);

            var customer = new Customer();
            //var rating = customer.CalculateRating();

            //RateCalculator calculator = new Amazon.RateCalculator();
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
            //UseParams();
            #endregion

            #region Indexer/Cookie
            //var cookie = new HttpCookie();
            //cookie["name"] = "Rupesh";
            //Console.WriteLine(cookie["name"]);
            #endregion

            #region Inheritance/Text
            //var text = new Text();
            //text.Width = 100;
            //text.Height = 100;
            //text.copy();
            #endregion

            #region Compostion
            //var dbMigrator = new DbMigrator(new Logger());
            //var logger = new Logger();
            //var installer = new Installer(logger);
            //dbMigrator.Migrate();
            //installer.Install();
            #endregion

            //var test = new Test();
            ////test.x
            //var test2 = new Test2(5);

            //Console.WriteLine(test2.CW());

            #region Constructor and Inheritance / Car
            //var car = new Car("JH01EH5397");
            #endregion

            #region Upcasting/Downcasting
            //Text text = new Text();
            //Upcasting
            //Shape shape = text;
            //text.Width = 100;
            //shape.Width = 200;
            //Console.WriteLine(text.Width);

            ////StreamReader reader = new StreamReader(new MemoryStream());
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("string");
            //list.Add(new Text());

            //var anotherList = new List<int>();
            //anotherList.Add(1);


            //downcasting
            //Shape shape = new Text();
            //Text text = (Text)shape; // Downcasting
            //text.
            #endregion

            #region Boxing/Unboxing
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Rupesh");
            //list.Add(DateAndTime.Today);

            ////var number = (int)list[1];

            //var anotherList = new List<int>();
            //anotherList.Add(1);

            //var names = new List<string>();
            //names.Add("Rupesh");

            #endregion

            #region Stack

            var stack = new Stack();
            stack.Push(1);
            stack.Push("Rupesh");
            stack.Push(DateAndTime.Today);
            //stack.Push(null);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

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

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }
    }

}