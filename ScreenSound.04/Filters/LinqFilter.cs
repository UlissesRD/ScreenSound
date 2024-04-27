using ScreenSound._04.Modelos;

namespace ScreenSound._04.FIltros;

internal class LinqFilter
{
    public static void FilterAllMusicGenres(List<Music> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        //Select: Seleciona algo, nesse caso, os gêneros musicais
        //Distinct: Não repete os gêneros
        //ToList: Transforma em List
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FilterArtistsByGenre(List<Music> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas./*OrderBy(musicas => musicas.Artista).*/Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Displaying artists by musical genre >>> {genero}");
        foreach (var artist in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterSongsByArtist(List<Music> musicas, string nomeDoArtista)
    {
        var musicasFiltradas = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasFiltradas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FilterSharpSongs(List<Music> musicas)
    {
        Console.WriteLine($"These are the songs in C SHARP(C#)");
        Console.WriteLine();
        foreach (var musica in musicas)
        {
            if (musica.Key == 1)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
        Console.WriteLine();

        //OR:

        //var musicasEmCSharp = musicas
        //.Where(musica => musica.Tonalidade.Equals("C#"))
        //.Select(musica => musica.Nome)
        //.ToList();
        //Console.WriteLine("Músicas em C#:");
        //foreach (var musica in musicasEmCSharp)
        //{
        //    Console.WriteLine($"- {musica}");
        //}
    }
}
