using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_m.classes
{
    internal class Cachorro: Mamifero
    {
        public double peso { get; set; }

        public override void barulho()
        {
            Console.WriteLine("auauauu");
        }
    }
}
