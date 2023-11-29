using CorrectifsEvents.Exeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifsEvents.Models
{
    public class Courant : Compte
    {
        #region Attribut
        private double _LigneDeCredit;
        #endregion

        #region Constructeurs

        public Courant(string numero, Personne titulaire, double solde) : base(numero, solde, titulaire)
        {
            //...
        }

        public Courant(string numero, Personne titulaire): this(numero, titulaire, 0)
        {
            //...
        }

        public Courant(string numero, double ligneDeCredit, Personne titulaire) : this(numero, titulaire)
        {
            this.LigneDeCredit = ligneDeCredit;
        }

        #endregion

        #region prop's
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("la ligne de crédit est une valeur positive !");
                }
                _LigneDeCredit = value;
            }
        }
        #endregion

        #region Méthodes
        public override void Retrait(double montant)
        {
            if(montant <= Solde + _LigneDeCredit)
            {
                double ancienSolde = Solde;
                base.Retrait(montant);

                if (ancienSolde >= 0 && Solde < 0)
                {
                    RaisePasseEnNegatifEvent();
                }
            }
            else
            {
                throw new SoldeInsuffisantExeption();
            }
        }

        protected override double CalculInteret()
        {
            return (Solde < 0) ? Solde * 0.0975 : Solde * 0.03;
        }

        #endregion
    }
}
