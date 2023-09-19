using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace heranca_m.classes
{
    internal class Mamifero
    {
        public string raca { get; set; }

        //pode ser sbc pelos filhos
        public virtual void barulho  ()
        {
            Console.WriteLine( this.raca + "Fazendo barulho");
        }

        
        public DateTime datan { get; set; }
    }
}
