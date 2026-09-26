using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rabbit rabbit = new Rabbit();
            rabbit.flee();

            Hauk hauk = new Hauk();
            hauk.flee();
            hauk.hunt();
        }

        interface IPrey
        {
            void flee();
        }
        interface IPredator
        {
            void hunt();
        }
        class Rabbit : IPrey
        {
            public void flee()
         
            {
                Console.WriteLine("The rabbit runs away !!");
            }
        }

        class   Hauk : IPrey , IPredator
        {
            public void flee()
            {
                Console.WriteLine("Haunk Fly away!!");
            }
            public void hunt()
            {
                Console.WriteLine("haulk is out for a run !!");
            }

        }
    }
}
