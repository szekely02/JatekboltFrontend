using GameStore.Frontend.Clients;
using GameStore.Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
var gameStoreApiUrl = builder.Configuration["GameStoreApiUrl"] ?? 
    throw new InvalidOperationException("GameStoreApiUrl configuration is missing.");
    
builder.Services.AddHttpClient<TermekekClient>(
    client => client.BaseAddress = new Uri(gameStoreApiUrl)
);
builder.Services.AddHttpClient<VasarlokClient>(
    client => client.BaseAddress = new Uri(gameStoreApiUrl)
);
builder.Services.AddHttpClient<RendelesekClient>(
    client => client.BaseAddress = new Uri(gameStoreApiUrl)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();

