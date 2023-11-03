namespace Amazon
{
    public class Customer
    {
        public int Id;
        public string Name;


        public Customer()
        {
        }
        public Customer(int id) :this()
        { 
            this.Id = id;
        }
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0) 
            //{
            //    Console.WriteLine("Promoted");
            //}

            var calculator = new RateCalculator();
            var rating = calculator.Calculate();

        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }



    }

}
