/*
  Escribir una función/método llamado mezclarArreglos 
que toma 2 arreglos de enteros del MISMO tamaño y 
devuelve un nuevo arreglo del mismo tamaño que el de los de entrada que
contiene los elementos de posiciones impares del primer arreglo
y los de posiciones pares del segundo arreglo.

*/


int mezclarArreglos (int[] arreglo1, int[] array2)
{
    if (arreglo1.Length == array2.Length)
    {
       int [] nuevoArreglo = new int [array2.Length];
        for (int i = 0; i < arreglo1.Length; i++)
        {
            if (i % 2 == 0)
            {
                nuevoArreglo[i] = array2[i];
              
            }
            else
            {
                nuevoArreglo [i] = arreglo1[i];
            }
        }
        foreach (int n in nuevoArreglo) { Console.WriteLine (n); }
    }
    else { throw new ArgumentException("Los arreglos deben ser el mismo tamaño "); }
        return 0;
}



int[] arr0 = new int[4];
int[] arr2 = new int[4];


arr0[0] = 3;
arr0[1] = 3;
arr0[2] = 2;
arr0[3] = 0;

arr2[0] = 7;
arr2[1] = 12;
arr2[2] = 1;
arr2[3] = -6;
/*
arr0 = { 3, 4, 2, 0};

arr2 = { 7, 12,1, -6};

array3 = {3,12,2,-6}

array3[0,2 del primer arreglo]
array3[1,3 del segundo arr]
*/


Console.Write(mezclarArreglos(arr0, arr2));