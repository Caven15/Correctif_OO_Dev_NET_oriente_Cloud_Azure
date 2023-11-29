using Generique.Models;

Console.WriteLine("--- Simulation banque ---");

// Création de la personne 
Console.WriteLine("- Création de Jhon");
Personne personne = new Personne("Doe", "Jhon", new DateTime(1993, 04, 22));

// création de la labanque
Console.WriteLine("- Création de belfius");
Banque banque = new Banque()
{
    Nom = "Belfius"
};

// Création du compte courant
Console.WriteLine("- Création compte courant");
Courant courant = new Courant("000-000-000-001", 1000, personne);

// Ajout du compte a la banque
Console.WriteLine("- Ajout du compte a la banque");
banque.Ajouter(courant);

// retrait sur le compte
Console.WriteLine("- Dépôt de 200 sur le compte ajouté");
banque["000-000-000-001"].Depot(200);

// retrait sur le compte => vérifier l'activation de l'évent
Console.WriteLine("- Retrait de 400 sur le compte ajouté");
banque["000-000-000-001"].Retrait(400);