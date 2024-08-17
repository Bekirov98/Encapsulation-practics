namespace Models
{
    public class Person
    {
        private static int _id = 0;
        public int Id;
        public string Name;
        public string Surname;
        public Person()
        {
            Id = ++_id;
        }

        public void  PrintInfo()
        {
            Console.WriteLine(Id+"." + " " + Name + " " + Surname);
        }
     
    }

    



}
