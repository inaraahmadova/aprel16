using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal abstract class Fish:Animal
    {
        public void Swim()
        {
            Console.WriteLine("Fish swam");
        }
    }
}
