using aprel16.Models;

namespace aprel16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //Shark akula = new Shark();
            //Eagle qartal = new Eagle();
            ////Cat mestan = new Cat();
            //Chicken ch=new Chicken();
            //ch.Eat();
            //ch.Fly();
            //Animal[] animals = {akula, qartal,mestan};
            //foreach (var animal in animals)
            //{
            //    animal.Eat();
            //}
            //akula.Eat();
            //qartal.Eat();
            //mestan.Eat();

            //Cat mestan=new("ahjsj"); //upcasting
            //Animal[] animals = {akula, qartal,new Chicken("asd'")};
            //Animal animal1 = new Shark();
            //foreach(Animal animal in animals)
            //{
            //    if (animal is Cat)
            //    {
            //        Cat cat = (Cat)animal; //downcasting
            //        cat.Risofkalanmaq();
            //    }
            //    else if(animal is Eagle) 
            //    {
            //        Eagle eagle= (Eagle)animal;
            //        eagle.Hunt();
            //    }
            //    else if (animal is Shark)
            //    {
            //        Shark shark = (Shark)animal;
            //        shark.Sniff();
            //    }
            //}

            //string text = 5 ToString();
            //Convert.ToInt32(23f);
            //int num=Convert.ToInt32((text);

        //    Person inara = new Person()
        //    {
        //        Name = "Inara",
        //        Surname = "Ahmadova",
        //        Age = 20
        //    };
        //    Person fatima = new Person()
        //    {
        //        Name = "Fatima",
        //        Surname = "Abbasova",
        //        Age = 20
        //    };
        //    Console.WriteLine(inara!=fatima);
        //}
        //class Person
        //{
        //    public string Name { get; set; }
        //    public string Surname { get; set; }
        //    public int Age { get; set; }
        //    public int WorkingExperience {  get; set; }

        //    public static bool operator >(Person a, Person b)
        //    {
        //        return a.Age > b.Age;
        //    }
        //    public static bool operator <(Person a, Person b)
        //    { return a.Age < b.Age; }
        //    public static bool operator == (Person a, Person b)
        //    {
        //        if (a.Name != b.Name ||
        //            a.Surname != b.Surname||
        //            a.Age != b.Age) return false;
        //        return true;
        //    }
        //    public static bool operator !=(Person a, Person b)
        //    {
        //        return !(a == b);
        //    }

            Library library = new Library();
            Book book1=new Book("inara","ahmadova");
            Book book2=new  Book("fatima", "abbasova");
            library.AddBook(book1);
            library.AddBook(book2);
            Book book = library[2];
            Console.WriteLine(book.Name+" "+book.Author);


        }
    }
}
