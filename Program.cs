using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string name="Nikiwe";
            int age;

            //initilization
            name = " Nikiwe";
            age = 10;

            Console.WriteLine("the was once a girl named" +name);
            Console.WriteLine(name +"was "+ age+ "age");
            Console.WriteLine(name + "never really liked her name");
            Console.ReadKey();


        }
    }
}
