using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimentional arrays.
            int[] intArray = new int[5];
            string[] stringArray = new string[5];

            int[] intPopulatedArray = new int[] { 1, 2, 3, 4, 5, 6 };
            string[] stringPopulatedArray = new string[] { "one", "two", "three" };

            intArray[0] = 5;

            int firstElement = intArray[0];
            Console.WriteLine(firstElement);

            //multi-dimentional arrays/ Jagged array.
            int[,] intMultiArray = new int[2, 3]; //2 rows 3 columns.
            int[,] intMultiArrayWithContent = { { 1, 2, 3}, {4, 5, 6 } };
           
            Console.WriteLine(intMultiArrayWithContent[0, 1]);

            //Array of a class.
            Dog[] dogArray = new Dog[2];
            dogArray[0] = new Dog() { Name = "Rover"};
          
            Console.WriteLine("Name of the dog is " + dogArray[0].Name);

            //List         
            List<string> strings = new List<string>();
            strings.Add("My first string");//add am element
            strings.Add("Another string");//add an element
            strings.Insert(0, "My string");//Add in some particular position.

            strings.Remove("Another string");//mention item
            strings.RemoveAt(0);//mention index

            strings.Sort();//sort the list alphabetically.

            Console.WriteLine(strings[0]);


            List<Dog> dogs = new List<Dog>()
            {
                new Dog() {Id = 1, Name = "Rover", Legs = 4 },
                new Dog() {Id = 2, Name = "Fido", Legs = 3}
            };

            //To access a class list.
            for(int i=0; i<2; i++)
            {
                Dog dogFirstElement = dogs[i];
                Console.WriteLine(dogFirstElement.Name + " has " + dogFirstElement.Legs + " legs.");
            }

            //Another way to access a class list through Linq.
            //Linq returns IEnumarable. So, need to convert it in list.
            List<Dog> results = (from d in dogs
                                where d.Id == 1
                                select d).ToList();

            //To get a single element
            Dog foundDog = (from d in dogs
                           where d.Id == 1
                           select d).FirstOrDefault();

            //If use var then no need to convert into list explicitly.
            var findDog = from d in dogs
                          where d.Id == 1
                          select d;

            //Linq method/Lambda is also very usefull to access a list.
            var findDoggy = dogs.Where(d => d.Id == 1);
            var findDoggy1 = dogs.FirstOrDefault(d => d.Id == 1);

            Console.WriteLine(foundDog.Name);
            //Dictionary, key and value pair.
            Dictionary<int, string> Names = new Dictionary<int, string>();
            Names.Add(0, "Arpita");
            Names.Add(1, "Debo");

            Names.Remove(0);
            Console.WriteLine(Names[1]);


            Console.ReadLine();
        }
    }
}
