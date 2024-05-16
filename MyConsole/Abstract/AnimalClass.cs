using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Abstract
{
    internal abstract class AnimalClass
    {
        void DoEat()
        {
            Console.WriteLine("I am eating");
        }
        public abstract void DoVoice();
        public virtual void DoMove()
        {
            Console.WriteLine("I am moving");
        }
    }
}
