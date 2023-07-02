using System.Text.Json;

namespace MyMusic_Api_Consumer.Models;

internal class FavoriteSongs
{
    public string Name { get; set; }
    public List<Songs> ListSongs { get; set; }

    public FavoriteSongs(string name)
    {
        Name = name;
        ListSongs = new List<Songs>();
    }

    public void AddFavoriteSongs(Songs song) => ListSongs.Add(song);

    public void ShowFavoriteSongs()
    {
        Console.WriteLine($"{Name} - favorite songs:");

        foreach (var songs in ListSongs) Console.WriteLine($"Artist: {songs.Artist} - {songs.Name}");
    }

    public void GenerateJsonFile()
    {
        var json = JsonSerializer.Serialize(new
        {
            name = Name,
            songs = ListSongs
        });

        var fileName = $"favorite-musics-{Name}.json";

        File.WriteAllText(fileName, json);

        Console.WriteLine("\nJson file created successfully!");
    }
}