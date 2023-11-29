using GestionBanque3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesetionBanque3.Models
{
    public class Banque
    {
        #region Atributs + auto prop's

        public string Nom { get; set; }
        private Dictionary<string,Courant> _Comptes = new Dictionary<string,Courant>();

        #endregion

        #region Prop's

        public KeyValuePair<string, Courant>[] Comptes
        {
            get { return _Comptes.ToArray(); }
        }

        public Courant? this[string numero]
        {
            get
            {
                Courant c = new Courant();
                _Comptes.TryGetValue(numero, out c);
                return c;
            }
        }

        #endregion

        #region Méthodes

        public void Ajouter(Courant c)
        {
            _Comptes.Add(c.Numero, c);
        }

        public void Supprimer(string numero)
        {
            _Comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne p)
        {
            double avoir = 0.0;

            foreach (Courant c in _Comptes.Values)
            {
                if (c.Titulaire.Nom == p.Nom)
                {
                    avoir += c;
                }
            }

            return avoir;
        }

        #endregion
    }
}
