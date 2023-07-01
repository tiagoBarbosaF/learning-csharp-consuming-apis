using System.Text.Json.Serialization;

namespace MyMusic_Api_Consumer.Models;

internal class Songs
{
    [JsonPropertyName("artist")] public string? Artist { get; set; }
    [JsonPropertyName("song")] public string? Name { get; set; }
    [JsonPropertyName("duration_ms")] public long Duration { get; set; }
    [JsonPropertyName("explicit")] public string? Explicited { get; set; }
    [JsonPropertyName("year")] public string? Year { get; set; }
    [JsonPropertyName("popularity")] public string? Popularity { get; set; }
    [JsonPropertyName("danceability")] public string? Danceability { get; set; }
    [JsonPropertyName("energy")] public string? Energy { get; set; }
    [JsonPropertyName("key")] public int Key { get; set; }
    [JsonPropertyName("loudness")] public string? Loudness { get; set; }
    [JsonPropertyName("mode")] public string? Mode { get; set; }
    [JsonPropertyName("speechiness")] public string? Speechiness { get; set; }
    [JsonPropertyName("acousticness")] public string? Acousticness { get; set; }
    [JsonPropertyName("instrumentalness")] public string? Instrumentalness { get; set; }
    [JsonPropertyName("liveness")] public string? Liveness { get; set; }
    [JsonPropertyName("valence")] public string? Valence { get; set; }
    [JsonPropertyName("tempo")] public string? Tempo { get; set; }
    [JsonPropertyName("genre")] public string? Genre { get; set; }

    public void ShowDetails() =>
        Console.WriteLine($"Artist: {Artist}\n" +
                          $"Music: {Name}\n" +
                          $"Duration: {Duration/1000} sec\n" +
                          $"Genre: {Genre}\n" +
                          $"Popularity: {Popularity}\n" +
                          $"---------------------------------------------");
}