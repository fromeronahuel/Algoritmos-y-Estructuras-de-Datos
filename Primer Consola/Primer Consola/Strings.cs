using System.Diagnostics;

int iteraciones = 50000;
Stopwatch sw = new Stopwatch();

// --- MÉTODO LENTO: Concatenación de String ---
Console.WriteLine($"Ejecutando {iteraciones} concatenaciones con String...");
sw.Start();
string textoLento = "";
for (int i = 0; i < iteraciones; i++)
{
    // Se crea una nueva instancia en memoria en cada paso
    textoLento += "x";
}
sw.Stop();
Console.WriteLine($"Tiempo Lento: {sw.ElapsedMilliseconds} ms");

sw.Reset();