using System;
using System.IO;

namespace TameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Emblem emblems = new Emblem();

            using (StreamReader file = new StreamReader("../../../Input/Input.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }

        public bool GivenAllegiance()
        {
            bool givenAllegiance = false;

            return givenAllegiance;
        }


    }
}
