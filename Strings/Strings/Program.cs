string misterio = "🥰";
int contador = 0;

foreach (char c in misterio)
{
    contador++;
    Console.WriteLine($"Iteración {contador}: He encontrado un char (pero no se ve bien solo)");
}

Console.WriteLine($"Total de chars: {misterio.Length}");