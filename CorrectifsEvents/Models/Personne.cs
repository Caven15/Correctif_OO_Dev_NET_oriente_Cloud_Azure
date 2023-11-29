using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifsEvents.Models
{
    public class Personne
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaiss { get; private set; }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaiss = dateNaiss;
        }
    }
}
