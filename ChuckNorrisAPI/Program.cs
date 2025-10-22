using System.Text.Json;

namespace ChuckNorrisAPI;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        string apiUrl = "https://api.chucknorris.io/jokes/random";

        System.Console.WriteLine("Fetching a random Chuck Norris joke... ");

        var response = await client.GetAsync(apiUrl);

        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();

        var joke = JsonSerializer.Deserialize<Joke>(json);



        System.Console.WriteLine(joke.value);




    }
}
