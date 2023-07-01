using System.Text.Json;

namespace MyMusic_Api_Consumer;

public class ClientHttp
{
    public static async Task<List<T>> GetClient<T>(string uri, T anyClass)
    {
        using var client = new HttpClient();
        try
        {
            var response = await client.GetStringAsync(uri);

            var items = JsonSerializer.Deserialize<List<T>>(response)!;

            return items;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            return new List<T>();
        }
    }
}