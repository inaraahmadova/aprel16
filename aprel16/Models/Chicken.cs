using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal class Chicken:Bird
    {
        public override void Eat()
        {
            Console.WriteLine("chicken ate wheat");
        }
        public override void Fly()
        {
            Console.WriteLine("chicken can not fly");
            base.Fly();
        }
    }
}
