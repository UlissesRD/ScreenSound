using ScreenSound._04.FIltros;
using ScreenSound._04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta)!;
        //musicas[1].ShowSongDetails();
        //LinqFilter.FilterAllMusicGenres(musicas);
        //LinqOrder.DisplaySortedArtistList(musicas);
        //LinqFilter.FilterArtistsByGenre(musicas, "pop");
        //LinqFilter.FilterSongsByArtist(musicas, "U2");

        //var DanielTopSongs = new FavoriteSongs("Daniel");
        //DanielTopSongs.AddFavoriteSong(musicas[1]);
        //DanielTopSongs.AddFavoriteSong(musicas[377]);
        //DanielTopSongs.AddFavoriteSong(musicas[4]);
        //DanielTopSongs.AddFavoriteSong(musicas[6]);
        //DanielTopSongs.AddFavoriteSong(musicas[1467]);

        //DanielTopSongs.DisplayFavoriteSongs();

        //var EmilyTopSongs = new FavoriteSongs("Emily");
        //EmilyTopSongs.AddFavoriteSong(musicas[500]);
        //EmilyTopSongs.AddFavoriteSong(musicas[637]);
        //EmilyTopSongs.AddFavoriteSong(musicas[428]);
        //EmilyTopSongs.AddFavoriteSong(musicas[13]);
        //EmilyTopSongs.AddFavoriteSong(musicas[71]);

        //EmilyTopSongs.DisplayFavoriteSongs();

        //EmilyTopSongs.CreateJSONFile();

        LinqFilter.FilterSharpSongs(musicas);

    }
    catch (Exception ex) 
    {
        Console.WriteLine($"We got a problem: {ex.Message}");
    }
}
