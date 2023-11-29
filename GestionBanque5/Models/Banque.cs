using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesetionBanque5.Models
{
    public class Banque
    {
        #region Atributs + auto prop's

        public string Nom { get; set; }
        private Dictionary<string,Compte> _Comptes = new Dictionary<string,Compte>();

        #endregion

        #region Prop's

        public KeyValuePair<string, Compte>[] Comptes
        {
            get { return _Comptes.ToArray(); }
        }

        public Compte? this[string numero]
        {
            get
            {
                Compte c = new Compte();
                _Comptes.TryGetValue(numero, out c);
                return c;
            }
        }

        #endregion

        #region Méthodes

        public void Ajouter(Compte c)
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

            foreach (Compte c in _Comptes.Values)
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
