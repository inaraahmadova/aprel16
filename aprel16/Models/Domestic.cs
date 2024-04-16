using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal abstract class Domestic:Animal
    {
        public void Pet()
        {
            Console.WriteLine("being pet");
        }
    }
}
