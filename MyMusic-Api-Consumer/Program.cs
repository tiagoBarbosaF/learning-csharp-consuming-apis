// using var client = new HttpClient();
// try
// {
//     var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
//     Console.WriteLine(response);
// }
// catch (Exception e)
// {
//     Console.WriteLine($"Exception: {e.Message}");
// }

using System.Net.Http.Json;

using var client = new HttpClient();
var response = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/bulbasaur");
Console.WriteLine(response);