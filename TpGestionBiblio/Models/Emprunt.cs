<<<<<<< HEAD
﻿public class Emprunt
{
    public int Id { get; set; }

    // Clés étrangères pour les relations
    public int LivreId { get; set; }
    public int AbonneId { get; set; }

    
    public DateTime DateEmprunt { get; set; }
    public DateTime DateRetour { get; set; }

 
    public Livre? Livre { get; set; } 
    public Abonne? Abonne { get; set; }
}
=======
﻿
public class Emprunt
{
    public int Id { get; set; }
    public int LivreId { get; set; }
    public int AbonneId { get; set; }
    public DateTime DateEmprunt { get; set; }
    public DateTime DateRetour { get; set; }

    public Livre? Livre { get; set; } 

    public Abonne? Abonne { get; set; } 
}
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
