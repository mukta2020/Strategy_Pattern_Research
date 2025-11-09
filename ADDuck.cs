using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class ADDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("ADDuck Display");
        }

        public override void Swim()
        {
            Console.WriteLine("ADDuck Cann't Swim");
        }
    }
}
