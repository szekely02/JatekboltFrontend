using System.ComponentModel.DataAnnotations;

namespace GameStore.Frontend.Models;

public class TermekekSummary
{
    public int Jatek_ID { get; set; }

    [Required]
    public string Cim { get; set; }

    [Required]
    public string Platform { get; set; }

    [Required]
    public string Kiado { get; set; }

    [Required]
    public string Mufaj { get; set; }

    [Required]
    public DateTime megjelenesi_datum { get; set; }

    [Required]
    public string korhatar_besorolas { get; set; }

    [Required]
    [MinLength(5)]
    public string leiras { get; set; }

    [Required]
    public int ar { get; set; }

    public int akcios_ar { get; set; }

    [Required]
    public int Raktarkeszlet { get; set; }
}