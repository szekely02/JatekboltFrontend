using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class VasarlokClient(HttpClient httpClient)
{    


    public async Task AddvasarloAsync(VasarlokDetails vasarlok) => await httpClient.PostAsJsonAsync("vasarlok", vasarlok);

    public async Task<vasarlokSummary> GetvasarloAsync(int id) =>
        await httpClient.GetFromJsonAsync<vasarlokSummary>($"vasarlok/{id}")
        ?? throw new InvalidOperationException($"Game with ID {id} not found.");
    public async Task UpdatevasarloAsync(vasarlokSummary updatedvasarlo) =>
        await httpClient.PutAsJsonAsync($"vasarlok/{updatedvasarlo.Vasarlo_ID}", updatedvasarlo);
    public async Task DeletevasarloAsync(int id) =>
        await httpClient.DeleteAsync($"vasarlok/{id}");
}
 