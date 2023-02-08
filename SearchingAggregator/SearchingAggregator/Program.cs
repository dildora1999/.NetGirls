var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string apiKey = "AIzaSyDC34SnzV2hidaSfRwkRsf9tK9VEkidsZA";
string get = "https://www.googleapis.com/customsearch/v1?key=AIzaSyDC34SnzV2hidaSfRwkRsf9tK9VEkidsZA&cx=43b3fb91d81c04455&q=Ganieva";
using HttpClient client = new();
await ProcessRepositoriesAsync(client, get, app);

static async Task ProcessRepositoriesAsync(HttpClient client, string get, WebApplication app)
{
    var json = await client.GetStringAsync(
        get);

    app.MapGet("/", () => json);
}


app.Run();