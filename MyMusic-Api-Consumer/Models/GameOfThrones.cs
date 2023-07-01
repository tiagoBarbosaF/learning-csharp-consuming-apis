using System.Text.Json.Serialization;

namespace MyMusic_Api_Consumer.Models;

internal class GameOfThrones
{
    [JsonPropertyName("url")] public string? Url { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("gender")] public string? Gender { get; set; }
    [JsonPropertyName("culture")] public string? Culture { get; set; }
    [JsonPropertyName("born")] public string? Born { get; set; }
    [JsonPropertyName("died")] public string? Died { get; set; }
    [JsonPropertyName("titles")] public string[]? Titles { get; set; }
    [JsonPropertyName("aliases")] public string[]? Aliases { get; set; }
    [JsonPropertyName("father")] public string? Father { get; set; }
    [JsonPropertyName("mother")] public string? Mother { get; set; }
    [JsonPropertyName("spouse")] public string? Spouse { get; set; }
    [JsonPropertyName("allegiances")] public string[]? Allegiances { get; set; }
    [JsonPropertyName("books")] public string[]? Books { get; set; }
    [JsonPropertyName("povBooks")] public string[]? PovBooks { get; set; }
    [JsonPropertyName("tvSeries")] public string[]? TvSeries { get; set; }
    [JsonPropertyName("playedBy")] public string[]? PlayedBy { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Url: \"{Url}\"\n" +
                          $"Name: {Name}\n" +
                          $"Gender: {Gender}\n" +
                          $"Aliases: {string.Join(", ", Aliases!)}\n" +
                          $"Books: [{string.Join(", ", Books!.Select(book=> $"\"{book}\""))}]\n" +
                          $"Tv Series: [{string.Join(", ", TvSeries!.Select(tv=> $"\"{tv}\""))}]\n" +
                          $"---------------------------------------------------------------");
    }
}