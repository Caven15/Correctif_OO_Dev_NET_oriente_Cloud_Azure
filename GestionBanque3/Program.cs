using GesetionBanque3.Models;
using GestionBanque3.Models;

// Création de ma personne
Personne personne = new Personne()
{
    Nom = "Smith",
    Prenom = "Jhon",
    DateNaissance = new DateTime(1955, 11, 08)
};

// création de plisueurs compte apartenant a la personne
Courant comptePersonne = new Courant()
{
    Numero = "000-000-000-01",
    Titulaire = personne
};

Courant compte2Personne = new Courant()
{
    Numero = "000-000-000-02",
    Titulaire = personne
};

Courant compte3Personne = new Courant()
{
    Numero = "000-000-000-03",
    Titulaire = personne
};

// Depot sur les différents comptes de la personne
comptePersonne.Depot(500);
compte2Personne.Depot(800);
compte3Personne.Depot(1200);

// Création de la banque + ajout des compte de la personne
Banque banque = new Banque();

banque.Ajouter(comptePersonne);
banque.Ajouter(compte2Personne);
banque.Ajouter(compte3Personne);

// Utilisation de la méthodes AvoirDesComptes pour avoir le total de tout les comptes
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine($"Somme des avoir du compte de la personne : {banque.AvoirDesComptes(personne)} Eur.");
Console.WriteLine("-----------------------------------------------------------");
