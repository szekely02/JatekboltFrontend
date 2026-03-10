using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class RendelesekClient(HttpClient httpClient)
{    
    

    public async Task AddrendelesAsync(RendelesekDetails rendelesek) => await httpClient.PostAsJsonAsync("rendelesek", rendelesek);

    public async Task<RendelesekDetails> GetrendelesAsync(int id) =>
        await httpClient.GetFromJsonAsync<RendelesekDetails>($"rendelesek/{id}")
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    public async Task UpdaterendelesAsync(RendelesekDetails updatedrendeles) =>
        await httpClient.PutAsJsonAsync($"rendelesek/{updatedrendeles.Rendelesek_ID}", updatedrendeles);
    public async Task DeleterendelesAsync(int id) =>
        await httpClient.DeleteAsync($"rendelesek/{id}");
}
