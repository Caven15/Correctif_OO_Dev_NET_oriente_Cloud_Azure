using GesetionBanque4_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque4_2.Models
{
    public class Epargne : Compte
    {
        #region Attributs + auto prop's
        public DateTime DernierRetrait { get; set; }
        #endregion

        #region Méthodes
        public override void Retrait(double montant)
        {
            double ancienSolde = Solde;
            base.Retrait(montant);

            if (Solde != ancienSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        #endregion
    }
}
