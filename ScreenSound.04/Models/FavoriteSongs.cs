using System.Text.Json;
namespace ScreenSound._04.Modelos;

internal class FavoriteSongs
{
    public string? Nome{ get; set; }
    public List<Music> ListFavoriteSongs { get; }

    public FavoriteSongs(string nome)
    {
        Nome = nome;
        ListFavoriteSongs = new List<Music>(); 
    }

    public void AddFavoriteSong(Music musica)
    {
        ListFavoriteSongs.Add(musica);
    }

    public void DisplayFavoriteSongs()
    {
        Console.WriteLine($"Those are the favorite songs -> {Nome}");
        foreach (var musica in ListFavoriteSongs)
        {
            Console.WriteLine($"- {musica.Nome} from {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void CreateJSONFile()
    {
        string json = JsonSerializer.Serialize( new
        {
            nome = Nome,
            musicas = ListFavoriteSongs
        });
        string nomedoArquivo = $"favorite-songs-{Nome}.json";

        File.WriteAllText(nomedoArquivo, json);
        Console.WriteLine($"The JSON file was successfully created! {Path.GetFullPath(nomedoArquivo)}");
    }
}
