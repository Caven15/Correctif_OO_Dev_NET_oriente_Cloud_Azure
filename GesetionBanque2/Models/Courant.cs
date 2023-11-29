using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque2.Models
{
    public class Courant
    {
        #region Attriuts + auto prop's
        public string Numero { get; set; } = string.Empty;
        public double Solde { get; set; }
        private double _LigneDeCredit { get; set; }
        public Personne Titulaire { get; set; }
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

        public void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant doit être supérieur a zéro !");
                return; // à remplacer par une exception
            }

            if (Solde - montant <= _LigneDeCredit)
            {
                Console.WriteLine("Solde insufissant !");
                return; // à remplacer par une exception
            }

            Solde -= montant;
        }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant doit être supérieur a zéro !");
                return; // à remplacer par une exception
            }

            Solde += montant;
        }

        #endregion
    }
}
