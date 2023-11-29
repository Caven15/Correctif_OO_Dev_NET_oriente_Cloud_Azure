using GesetionBanque4_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque4_1.Models
{
    public class Epargne
    {
        #region Attributs + auto prop's
        public string Numero { get; set; } = string.Empty;
        public double Solde { get; set; }
        public Personne Titulaire { get; set; }
        public DateTime DernierRetrait { get; set; }
        #endregion

        #region Méthodes
        public void Retrait(double montant)
        {
            if (montant <= 0)
            {
                return; // à remplacer par une exception
            }

            if ((Solde - montant) < 0)
            {
            }
            DernierRetrait = DateTime.Now;
            Solde -= montant;
        }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                return; // à remplacer par une exception
            }
            Solde += montant;
        }

        #endregion
    }
}
