using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal abstract class Bird:Animal
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird flied");
        }
    }
}
