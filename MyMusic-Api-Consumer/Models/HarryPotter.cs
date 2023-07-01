using System.Text.Json.Serialization;

namespace MyMusic_Api_Consumer.Models;

internal class HarryPotter
{
    [JsonPropertyName("id")] public Guid Id { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }

    [JsonPropertyName("alternate_names")] public string[]? Aliases { get; set; }

    [JsonPropertyName("house")] public string? House { get; set; }

    public void ShowDetails() => Console.WriteLine($"Id: {Id}\n" +
                                                   $"Name: {Name}\n" +
                                                   $"Aliases: [{string.Join(", ", Aliases!.Select(alias => $"\"{alias}\""))}]\n" +
                                                   $"House: {House}\n" +
                                                   $"---------------------------------------------------------------------------");
}