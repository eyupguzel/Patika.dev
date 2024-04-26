using System;
using System.Reflection.Metadata;

namespace patika.dev
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Eyup";
            string surname = " Guzel";
            Console.WriteLine(name + surname);

            int age = 22;
            Console.WriteLine(age);

            float temperature = 25.86f;
            Console.WriteLine(temperature);

            double area = 5.2 * 3.4;
            Console.WriteLine(area);

            bool tf = 19 < 25;
            Console.WriteLine(tf);

            object person = new object();
            person = name + surname;

            Console.WriteLine(person);

            string a1 = "20";
            int a2 = 24;
            Console.WriteLine(a1 + a2.ToString());

        }





       


}
}
 
