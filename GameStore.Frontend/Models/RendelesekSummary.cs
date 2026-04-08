using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;

namespace GameStore.Frontend.Models;

public class RendelesekSummary
{
  public int Rendelesek_ID { get; set; }
  public int Vasarlo_ID { get; set; }
  public int termek_ID { get; set; }
  public DateTime Rendeles_datuma { get; set; }
  public string fizetesi_mod { get; set; }
  public string szallitasi_mod { get; set; }
}
