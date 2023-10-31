namespace OOPs_Concepts
{
    public class Person
    {
        //public string Name;

        //private DateTime _birthdate;
        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}
        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}

        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get { return DateTime.Now.Year - Birthdate.Year; }
        }

        //    public void Introduce(string to)
        //    {
        //        Console.WriteLine("Hi {0}, I am {1}", to, Name);
        //    }
        //    public static Person Parse(string str)
        //    {
        //        Person person = new Person();
        //        person.Name = str;
        //        return person;
        //    }

    }
}
