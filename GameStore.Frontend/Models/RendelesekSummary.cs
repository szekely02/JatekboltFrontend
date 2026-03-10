namespace GameStore.Frontend.Models;

public class RendelesekSummary
{
    public string Vasarlo_ID { get; set; }
    public int termek_ID { get; set; }
    public DateOnly Rendeles_datuma { get; set; }
    public string fizetesi_mod { get; set; }
    public string szallitasi_mod { get; set; }
}
