
using System.ComponentModel.DataAnnotations;

namespace GameStore.Frontend.Models;

public class VasarlokSummary
{
    public int Vasarlo_ID { get; set; }

    [Required]
    public string Nev { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string telefonszam { get; set; }

    [Required]
    public string szallitasi_cim { get; set; }
}
