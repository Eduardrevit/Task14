using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog("Собака", "Гав");
            Console.WriteLine(dog.ShowInfo());

            Cat cat = new Cat("Кошка", "Мяу");
            Console.WriteLine(cat.ShowInfo());

            Console.ReadKey();
        }
          

    }
    
}
