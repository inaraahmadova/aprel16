using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal class Cat:Domestic
    {
        public override void Eat()
        {
            Console.WriteLine("cat ate lausania");
        }

        public void Risofkalanmaq()
        {
            Console.WriteLine("Meuw");
        }
    }
}
