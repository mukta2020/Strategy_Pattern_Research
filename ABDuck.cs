using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class ABDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("AB Duck Display");
        }

        public override void Swim()
        {
            Console.WriteLine("AB Duck Can't Swim");
        }
    }
}
