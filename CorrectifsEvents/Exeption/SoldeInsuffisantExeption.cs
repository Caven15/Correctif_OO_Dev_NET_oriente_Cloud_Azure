using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifsEvents.Exeption
{
    public class SoldeInsuffisantExeption : Exception
    {
        public SoldeInsuffisantExeption() : base("Solde insuffisant !!")
        {
            //...
        }
    }
}
