using ScreenSound._04.Modelos;

namespace ScreenSound._04.FIltros;

internal class LinqOrder
{
    public static void DisplaySortedArtistList(List<Music> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        //Português:
        //Estamos ordenando a lista de musicas pelos artistas, depois disso selecionamos apenas a propriedade artista,
        //tiramos o que é repetido e transformamos esse novo filtro em uma list

        //Inglês
        //We are sorting the list of songs by artists, then we select only the artist property,
        //remove duplicates, and convert this new filter into a list
        Console.WriteLine("Sorted list of artists");
        foreach (var artista in artistasOrdenados) 
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
