using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesetionBanque7.Models
{
    public class Courant : Compte
    {
        #region Attriuts + auto prop's
        private double _LigneDeCredit { get; set; }
        #endregion

        #region Prop's
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set
            {
                if (value < 0)
                {
                    return; // à remplacer plus tard par une exception
                }

                _LigneDeCredit = value;
            }
        }
        #endregion

        #region Méthodes

        public override void Retrait(double montant)
        {
            Retrait(montant, _LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            return (Solde < 0) ? Solde * 0.0975 : Solde * 0.03;
        }

        #endregion
    }
}
