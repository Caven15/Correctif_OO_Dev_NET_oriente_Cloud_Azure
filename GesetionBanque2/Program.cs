using GesetionBanque2.Models;
using GestionBanque2.Models;


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

Personne personne3 = new Personne()
{
    Nom = "piaf",
    Prenom = "edith",
    DateNaissance = new DateTime(1955, 11, 08)
};

Courant comptePersonne2 = new Courant()
{
    Numero = "000-000-000-01",
    Titulaire = personne2
};

Courant comptePersonne3 = new Courant()
{
    Numero = "000-000-000-02",
    Titulaire = personne3
};

Banque banque = new Banque()
{
    Nom = "tutu"
};

Console.WriteLine($"le solde de la personne 2 avant dépôt est de {comptePersonne2.Solde}");

comptePersonne2.Depot(500);

Console.WriteLine($"le solde de la personne 2 après dépôt est de {comptePersonne2.Solde}");

comptePersonne2.Retrait(300);

Console.WriteLine($"le solde de la personne 2 après retrait est de {comptePersonne2.Solde}");


// tentative de solde négatif sur un depot

comptePersonne2.Depot(-500);


// ajout de compte a notre banque

banque.Ajouter(comptePersonne2);
banque.Ajouter(comptePersonne3);

// affichage du solde du compte de la personne 2 via indexeur
Console.WriteLine($"Le solde de du compe de la personne 2 est de : {banque["000-000-000-01"].Solde}");

// parcour de mon dictionnaire convertis sous forme de tableau
foreach (var item in banque.Comptes)
{
    Console.WriteLine("--------------");
    Console.WriteLine($"Clé : {item.Key}");
    Console.WriteLine($"Nom : {item.Value.Titulaire.Nom}");
}

