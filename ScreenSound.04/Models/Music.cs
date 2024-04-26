using System.Text.Json.Serialization;

namespace ScreenSound._04.Modelos;

internal class Music
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
   
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade 
    {
        get 
        {
            return tonalidades[Key];
        }
    }

    public void ShowSongDetails()
    {
        Console.WriteLine($"Artist: {Artista}");
        Console.WriteLine($"Music: {Nome}");
        Console.WriteLine($"Duration in seconds: {Duracao / 1000}");
        Console.WriteLine($"Genre: {Genero}");
        Console.WriteLine($"Key: {Tonalidade}\n");
    }
}
