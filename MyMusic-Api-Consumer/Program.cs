using MyMusic_Api_Consumer;
using MyMusic_Api_Consumer.Filters;
using MyMusic_Api_Consumer.Models;

#region Songs - API

var songs = await ClientHttp.GetClient("https://guilhermeonrails.github.io/api-csharp-songs/songs.json", new Songs());

// foreach (var song in songs)
// {
//     song.ShowMusicsByTone("Eb");
// }


#region Filters

// Filter.FilterSongGenre(songs);
// Filter.FilterOrderArtistsByName(songs);
// Filter.FilterArtistsBySongGenre(songs, "rock");
// Filter.FilterSongsByArtist(songs, "U2");
// Filter.FilterSongsByYear(songs, "2014");
Filter.FilterByTone(songs, "C#");

#endregion


#region Creating Json File

// foreach (var song in songs) song.ShowDetails();
// var favoriteSongs = new FavoriteSongs("Tiago");
// favoriteSongs.AddFavoriteSongs(songs[10]);
// favoriteSongs.AddFavoriteSongs(songs[20]);
// favoriteSongs.AddFavoriteSongs(songs[100]);
// favoriteSongs.AddFavoriteSongs(songs[210]);
// favoriteSongs.AddFavoriteSongs(songs[1010]);
//
// favoriteSongs.ShowFavoriteSongs();
// favoriteSongs.GenerateJsonFile();

#endregion



#endregion


#region Game of thrones - API

var gameOfThroneChars =
    await ClientHttp.GetClient("https://www.anapioficeandfire.com/api/characters/", new GameOfThrones());

// foreach (var chars in gameOfThroneChars) chars.ShowDetails();

#endregion


#region Harry Potter - API

var harryPotters =
    await ClientHttp.GetClient("https://hp-api.onrender.com/api/characters/house/gryffindor", new HarryPotter());

// foreach (var harryPotter in harryPotters) harryPotter.ShowDetails();

#endregion