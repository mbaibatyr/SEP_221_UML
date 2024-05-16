using MyConsole.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Service
{
    internal class Cat : IAnimal
    {
        public void DoEat()
        {
            Console.WriteLine("Drink milk");
        }

        public void DoMove()
        {
            Console.WriteLine("Do run");
        }

        public void DoVoice()
        {
            Console.WriteLine("Do cry");
        }
    }   
}
