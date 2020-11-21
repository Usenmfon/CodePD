using System;

namespace CodePD
{
    class Program
    {
        class Circle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Circle Draw");
            }
        }

        class People
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Country { get; set; }
        }

            class African : People
            {
                public African(string name)
                {
                    this.Name = name;
                    Console.WriteLine($"The first person here is {this.Name}");
                }
                public void Data(string name, int age, string country)
                {
                    Console.WriteLine($"I am {name} age {age} from {country}");
                }
            }
        static void Main(string[] args)
        {
            African a1 = new African("Usenmfon");
            a1.Data("Samuel",24,"Nigeria");
            IShape c = new Circle();
            c.Draw();
        }
    }
}
