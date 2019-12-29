namespace App1_Company.Model
{
    public abstract class Person
    {
        protected string Name { get; set; }

        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }
    }
}
