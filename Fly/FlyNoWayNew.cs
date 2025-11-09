using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Fly
{
    public class FlyNoWayNew : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I Can't Fly New");
        }
    }
}
