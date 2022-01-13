using System;

namespace Cat_Attack
{
    class Program
    {
        public class Cat
        {
            public Cat(string name = "Cat Name", Cat cat = null)
            {
                this.name = name;
                next_cat = cat;
            }
            public void set_cat(Cat cat)
            {
                next_cat = cat;
            }
            public void name_set(string name) 
            {
                this.name = name;
            }
            public string name { get; private set; }
            public Cat next_cat { get; private set; }
        }
        public Cat next_cat(Cat Sample_cat)
        {
            return Sample_cat.next_cat;
        }
        public static Cat get_to_end(Cat findEnd)
        {
            if(findEnd.next_cat != null)
            {
                return get_to_end(findEnd.next_cat);
            }
            return findEnd;
        }
        static void Main(string[] args)
        {
            Cat ExampleCat0 = new Cat("kaze0");
            Cat ExampleCat1 = new Cat("kaze1");
            Cat ExampleCat2 = new Cat("kaze2");
            ExampleCat0.set_cat(ExampleCat1);
            ExampleCat1.set_cat(ExampleCat2);
            Cat LastCat = get_to_end(ExampleCat0);
            Console.WriteLine("The last cat is: " + LastCat.name);

        }
    }
}