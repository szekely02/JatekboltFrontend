using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class RendelesekClient(HttpClient httpClient)
{
    public async Task<RendelesekSummary[]> GetRendelesekAsync()
    => await httpClient.GetFromJsonAsync<RendelesekSummary[]>("rendelesek") ?? [];

    public async Task AddrendelesAsync(RendelesekSummary rendelesek) => await httpClient.PostAsJsonAsync("rendelesek", rendelesek);

    public async Task<RendelesekSummary> GetrendelesAsync(int id) =>
        await httpClient.GetFromJsonAsync<RendelesekSummary>($"rendelesek/{id}")
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    public async Task UpdaterendelesAsync(RendelesekSummary updatedrendeles) =>
        await httpClient.PutAsJsonAsync($"rendelesek/{updatedrendeles.Rendelesek_ID}", updatedrendeles);
    public async Task DeleterendelesAsync(int id) =>
        await httpClient.DeleteAsync($"rendelesek/{id}");
}
