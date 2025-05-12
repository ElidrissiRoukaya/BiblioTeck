public class Emprunt
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
