using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generique.Models
{
    public class Epargne : Compte
    {
        #region attribut
        private DateTime _DernierRetrait;
        #endregion

        #region Constructeurs

        public Epargne(string numero, Personne titulaire, double solde, DateTime dernierRetrait) : base(numero, solde, titulaire)
        {
            this.DernierRetrait = dernierRetrait;
        }

        public Epargne(string numero, Personne titulaire) : this(numero, titulaire, 0, DateTime.Now)
        {
            //...
        }
        
        #endregion

        #region prop's

        public DateTime DernierRetrait
        {
            get { return _DernierRetrait; }
            private set { _DernierRetrait = value; }
        }

        #endregion

        #region Méthodes

        
        public override void Retrait(double montant)
        {
            double ancienSolde = Solde;
            base.Retrait(montant);

            if ( Solde != ancienSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }

        #endregion
    }
}
