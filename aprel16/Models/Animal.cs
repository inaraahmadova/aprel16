using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel16.Models
{
    internal abstract class Animal
    {
        public byte Age {  get; set; }
        //public void Eat()
        //{
        //    Console.WriteLine(  "Animal ate");
        //}
        public abstract void Eat();
    }
}
