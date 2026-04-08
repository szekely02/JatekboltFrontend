using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class TermekekClient(HttpClient httpClient)
{

    public async Task<TermekekSummary[]> GetTermekekAsync()
    => await httpClient.GetFromJsonAsync<TermekekSummary[]>("termekek") ?? [];

    public async Task AddtermekAsync(TermekekSummary termekek) => await httpClient.PostAsJsonAsync("termekek", termekek);

    public async Task<TermekekSummary> GettermekAsync(int id) =>
        await httpClient.GetFromJsonAsync<TermekekSummary>($"termekek/{id}")
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");

    public async Task UpdatetermekAsync(TermekekSummary updatedGame) =>
        await httpClient.PutAsJsonAsync($"termekek/{updatedGame.Jatek_ID}", updatedGame);

    public async Task DeletetermekAsync(int id) =>
        await httpClient.DeleteAsync($"termekek/{id}");
}