using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public abstract class Duck
    {

        private IFlyBehavior flyBehavior = null;
        private IQuackBehaviour quackBehavior = null;

        public void SetFlyBehaviour(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(IQuackBehaviour quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        public abstract void Swim();
        public abstract void Display();
      
    }
}
