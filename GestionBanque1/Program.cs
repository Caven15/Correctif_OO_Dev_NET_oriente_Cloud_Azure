using GestionBanque1.Models;


//Personne personne1 = new Personne();
//personne1.Nom = "Jhon";
//personne1.Prenom = "Doe";
//personne1.DateNaissance = new DateTime(1999, 05, 15);


Personne personne2 = new Personne()
{
    Nom = "Smith",
    Prenom = "Jhon",
    DateNaissance = new DateTime(1955, 11, 08)
};

Courant comptePersonne2 = new Courant()
{
    Numero = "000-000-000-01",
    Titulaire = personne2
};

Console.WriteLine($"le solde de la personne 2 avant dépôt est de {comptePersonne2.Solde}");

comptePersonne2.Depot(500);

Console.WriteLine($"le solde de la personne 2 après dépôt est de {comptePersonne2.Solde}");

comptePersonne2.Retrait(300);

Console.WriteLine($"le solde de la personne 2 après retrait est de {comptePersonne2.Solde}");


// tentative de solde négatif sur un depot

comptePersonne2.Depot(-500);
