using System.Text.Json.Serialization;

namespace MyMusic_Api_Consumer.Models;

internal class Songs
{
    private List<string> _tones = new() { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("artist")] public string? Artist { get; set; }
    [JsonPropertyName("song")] public string? Name { get; set; }
    [JsonPropertyName("duration_ms")] public long Duration { get; set; }
    [JsonPropertyName("year")] public string? Year { get; set; }
    [JsonPropertyName("popularity")] public string? Popularity { get; set; }
    [JsonPropertyName("key")] public int Key { get; set; }
    public string Tones => _tones[Key];
    [JsonPropertyName("genre")] public string? Genre { get; set; }

    public void ShowDetails() =>
        Console.WriteLine($"Artist: {Artist}\n" +
                          $"Music: {Name}\n" +
                          $"Duration: {Duration / 1000} sec\n" +
                          $"Genre: {Genre}\n" +
                          $"Popularity: {Popularity}\n" +
                          $"Tones: {Tones}\n" +
                          $"---------------------------------------------");

    public void ShowMusicsByTone(string tone)
    {
        var findTone = _tones.FindIndex(find => find.Equals(tone));

        if (Key == findTone)
            Console.WriteLine($"Artist: {Artist}\n" +
                              $"Music: {Name}\n" +
                              $"Duration: {Duration / 1000} sec\n" +
                              $"Genre: {Genre}\n" +
                              $"Popularity: {Popularity}\n" +
                              $"Tones: {Tones}\n" +
                              $"---------------------------------------------");
    }
}