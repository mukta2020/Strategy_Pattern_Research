using Strategy_Pattern.Fly;
using Strategy_Pattern.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class MallarDuck : Duck
    {
        public MallarDuck()
        {
           
            
        }
        public override void Display()
        {
            Console.WriteLine("Mallar Duck");
        }

        
        public override void Swim()
        {
            
        }
    }
}
