using CorrectifsEvents.Exeption;
using CorrectifsEvents.Interfaces;
using CorrectifsEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifsEvents.Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        #region attribut
        private string _Numero;
        private double _Solde;
        private Personne _Titulaire;
        public event PassageEnNegatifDelegate PassageEnNegatifEvent;
        #endregion

        #region Constructeurs

        public Compte(string numero, double solde, Personne titulaire)
        {
            this.Numero = numero;
            this.Solde = solde;
            this.Titulaire = titulaire;
        }

        public Compte(string numero, Personne titulaire) : this(numero, 0,titulaire)
        {
            // déjà completés dans le constructeur parent de la classe
        }

        #endregion

        #region prop's
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            private set { _Titulaire = value; }
        }
        #endregion

        #region Méthodes

        protected void RaisePasseEnNegatifEvent()
        {
            //if (PassageEnNegatifEvent != null)
            //{
            //    PassageEnNegatifEvent(this);
            //}
            PassageEnNegatifEvent?.Invoke(this); // Simplification au niveau de l'écrit
        }

        public static double operator +(double Solde, Compte c)
        {
            return Solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }
        /// <summary>
        /// ici c'est la description de ma méthode
        /// </summary>
        /// <param name="montant">Montant a introduire en double </param>
        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0.0);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (montant <= 0)
            {
                throw new SoldeInsuffisantExeption();
            }

            Solde -= montant;
        }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Solde += montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            _Solde += CalculInteret();
        }

        #endregion
    }
}