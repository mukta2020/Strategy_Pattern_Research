using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Quack
{
    public class Squack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("SQuack");
        }
    }
}
