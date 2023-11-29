using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generique.Models
{
    public class Banque
    {

        #region attribut
        public string Nom { get; set; }
        Dictionary<string, Compte> _Comptes = new Dictionary<string, Compte>();
        #endregion

        #region prop's
        public KeyValuePair<string, Compte>[] Comptes
        {
            get { return _Comptes.ToArray(); }
        }

        public Compte this[string numero]
        {
            get
            {
                Compte c;
                _Comptes.TryGetValue(numero, out c);
                return c;
            }
        }
        #endregion

        #region méthodes
        /// <summary>
        /// permet d'ajouter un compte à la liste
        /// </summary>
        /// <param name="c">comtpe Compte a renvoyer</param>
        public void Ajouter(Compte c)
        {
            _Comptes.Add(c.Numero, c);
            c.PassageEnNegatifEvent += PassageEnNegatifAction;
        }

        public void Supprimer(string numero)
        {
            Compte c = _Comptes[numero];

            if(c != null)
            {
                c.PassageEnNegatifEvent -= PassageEnNegatifAction;
                _Comptes.Remove(numero);
            }
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

        private void PassageEnNegatifAction(Compte c)
        {
            Console.WriteLine($"Le compte {c.Numero} vient de passer en négatif ");
        }
        #endregion

    }
}
