//sw.stop(); METODO para detener conteo de reloj
//sw.start();METODO para inicioar conteo de reloj
//sw.reset(); METODO para reiniciar conteo de reloj,

using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int iteraciones = 50000;
        Stopwatch sw = new Stopwatch();

        // --- MÉTODO LENTO: Concatenación de String ---
        Console.WriteLine($"Ejecutando {iteraciones} concatenaciones con String...");
        sw.Start();
        string textoLento = "";
        for (int i = 0; i < 50000; i++)
        {
            // Se crea una nueva instancia en memoria en cada paso
            textoLento += "x";
        }
        sw.Stop();
        Console.WriteLine($"Tiempo Lento: {sw.ElapsedMilliseconds} ms");

        sw.Reset();

        // --- MÉTODO RÁPIDO: StringBuilder ---
        Console.WriteLine($"\nEjecutando {iteraciones} concatenaciones con StringBuilder...");
        sw.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 1000000; i++)
        {
            // Se modifica el buffer interno existente
            sb.Append("x");
        }
        string resultado = sb.ToString();
        sw.Stop();
        Console.WriteLine($"Tiempo Rápido: {sw.ElapsedMilliseconds} ms");
    }
}
