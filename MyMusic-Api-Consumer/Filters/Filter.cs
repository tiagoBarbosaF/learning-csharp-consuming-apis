using MyMusic_Api_Consumer.Models;

namespace MyMusic_Api_Consumer.Filters;

internal abstract class Filter
{
    public static void FilterSongGenre(IEnumerable<Songs> songs)
    {
        var allGenres = songs.Select(song => song.Genre).Distinct().ToList();

        foreach (var genre in allGenres) Console.WriteLine($"- {genre}");
    }

    public static void FilterOrderArtistsByName(IEnumerable<Songs> songs)
    {
        var allArtists = songs.OrderBy(song => song.Artist).Select(song => new{song.Artist, song.Name}).Distinct().ToList();

        Console.WriteLine($"\nArtists ordered by name:");

        foreach (var artist in allArtists) Console.WriteLine($"- {artist.Artist} | song: {artist.Name}");

        Console.WriteLine($"Total artists: {allArtists.Count}");
    }

    public static void FilterArtistsBySongGenre(IEnumerable<Songs> songs, string genre)
    {
        var allArtists = songs.OrderBy(song => song.Artist)
            .Where(song => song.Genre!.Contains(genre))
            .Select(song => song.Artist).Distinct()
            .ToList();

        Console.WriteLine($"Show artists by genre ({genre})");

        foreach (var artist in allArtists) Console.WriteLine($"- {artist}");
    }

    public static void FilterSongsByArtist(IEnumerable<Songs> songs, string artist)
    {
        var artistSongs = songs.OrderBy(song => song.Artist)
            .Where(song => song.Artist!.Equals(artist))
            .Select(song => new { song.Name, song.Artist })
            .Distinct()
            .ToList();

        Console.WriteLine($"Songs by artist {artist}:");

        foreach (var artistSong in artistSongs) Console.WriteLine($"- {artistSong.Name}");
    }

    public static void FilterSongsByYear(IEnumerable<Songs> songs, string year)
    {
        var songsByYear = songs.OrderBy(song => song.Name)
            .Where(song => song.Year!.Equals(year))
            .Select(song => new { song.Name, song.Year })
            .Distinct()
            .ToList();

        Console.WriteLine($"Songs ordered by the year {year}:");

        foreach (var song in songsByYear) Console.WriteLine($"- {song.Name}");
    }

    public static void FilterByTone(IEnumerable<Songs> songs, string tone)
    {
        var songsByTone = songs.OrderBy(song => song.Name)
            .Where(song => song.Tones.Equals(tone)).Select(song => new { song.Artist, song.Duration, song.Name, song.Tones, song.Genre })
            .Distinct()
            .ToList();

        Console.WriteLine($"Songs by the tone ({tone})");

        foreach (var song in songsByTone)
            Console.WriteLine($"Artist: {song.Artist}\n" +
                              $"Music: {song.Name}\n" +
                              $"Duration: {song.Duration / 1000} sec\n" +
                              $"Genre: {song.Genre}\n" +
                              $"Tones: {song.Tones}\n" +
                              $"---------------------------------------------");
    }
}