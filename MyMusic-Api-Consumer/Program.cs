﻿using MyMusic_Api_Consumer;
using MyMusic_Api_Consumer.Models;

#region Songs - API

var songs = await ClientHttp.GetClient("https://guilhermeonrails.github.io/api-csharp-songs/songs.json", new Songs());

foreach (var song in songs) song.ShowDetails();

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