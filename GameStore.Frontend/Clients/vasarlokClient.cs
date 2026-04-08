using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class VasarlokClient(HttpClient httpClient)
{
    public async Task<VasarlokSummary[]> GetVasarlokAsync()
    => await httpClient.GetFromJsonAsync<VasarlokSummary[]>("vasarlok") ?? [];

    public async Task AddVasarloAsync(VasarlokSummary vasarlok) => await httpClient.PostAsJsonAsync("vasarlok", vasarlok);
    public async Task<VasarlokSummary> GetVasarloAsync(int id) =>
        await httpClient.GetFromJsonAsync<VasarlokSummary>($"vasarlok/{id}")
        ?? throw new InvalidOperationException($"Vásárló {id} nem található.");

    public async Task UpdateVasarloAsync(VasarlokSummary updatedvasarlo) =>
        await httpClient.PutAsJsonAsync($"vasarlok/{updatedvasarlo.Vasarlo_ID}", updatedvasarlo);

    public async Task DeleteVasarloAsync(int id) =>
        await httpClient.DeleteAsync($"vasarlok/{id}");
}




