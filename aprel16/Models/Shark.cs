using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal class Shark:Fish
    {
        public void Sniff()
        {
            Console.WriteLine("Shark sniffed");
        }
        //public void Eat()
        //{
        //    Console.WriteLine("shark ate little fishes");
        //}

        public override void Eat()
        {
            Console.WriteLine("shark ate little fishes");
        }
    }
}
