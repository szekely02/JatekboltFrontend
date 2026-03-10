using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class TermekekClient(HttpClient httpClient)
{    

    public async Task AddtermekAsync(Termekekdetails termekek) => await httpClient.PostAsJsonAsync("termekek", termekek);

    public async Task<Termekeksummary> GettermekAsync(int id) =>
        await httpClient.GetFromJsonAsync<Termekeksummary>($"termekek/{id}")
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    public async Task UpdatetermekAsync(Termekeksummary updatedGame) =>
        await httpClient.PutAsJsonAsync($"termekek/{updatedGame.termek_ID}", updatedGame);
    public async Task DeletetermekAsync(int id) =>
        await httpClient.DeleteAsync($"termekek/{id}");
}
