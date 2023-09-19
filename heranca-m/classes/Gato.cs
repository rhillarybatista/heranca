using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_m.classes
{
    internal class Gato: Mamifero
    {
        public string cordeolho { get; set; }
        public override void barulho()
        {
            Console.WriteLine("miau");
        }
    }
}
