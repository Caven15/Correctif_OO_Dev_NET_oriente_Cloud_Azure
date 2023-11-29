using GesetionBanque5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesetionBanque5.Models
{
    public class Compte
    {
        #region Atributs + auto prop's

        public string Numero { get; set; } = string.Empty;
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

        #endregion

        #region Méthodes

        public static double operator +(double solde, Compte c)
        {
            // ternaire
            return solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }

        // Retrait : Courant
        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant doit être supérieur a zéro !");
                return; // à remplacer par une exception
            }

            if (Solde - montant <= ligneDeCredit)
            {
                Console.WriteLine("Solde insufissant !");
                return; // à remplacer par une exception
            }

            Solde -= montant;
        }

        // Retrait : Epargne
        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0.0);
        }

        // Dépôt
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
