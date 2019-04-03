
using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new Program().countCharacter());
            Console.ReadLine();
            //new Program().returnCount();

        }

        private int countCharacter()
        {
            var character = 0;
            //FileStream fileStream = new FileStream("C:\\Users\\grini\\OneDrive\\Documents\\AppyDocs.txt\\Git@appy.txt", FileMode.Open);
            using (StreamReader rdr = new StreamReader("C:\\Users\\grini\\OneDrive\\Documents\\AppyDocs.txt\\Git@appy.txt"))
            {
                var count = rdr.ReadToEnd();
                character = count.Length;
                Thread.Sleep(4000);
            }
            return character;
        }

        //private async void returnCount()
        //{
        //    Task<int> task = new Task<int>(countCharacter);
        //    task.Start();
        //    var x = "Counting in progress...";
        //    int reply = await task.
        //    Console.WriteLine("The count is " + reply);


        //}


    }
}
