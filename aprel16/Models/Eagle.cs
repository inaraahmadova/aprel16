using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal class Eagle:Bird
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Hunt()
        {
            Console.WriteLine("eagle ate snake");
        }
    }
}
