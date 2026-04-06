//tipo de dato + nombreFuncion (parametros) {
//logica de funcion
//}


//Crear una funcion que sume 3 valores ingresados
static int suma (int x, int y, int z)
{
    int suma = x + y + z;
    return suma;
}
int valorX = 10;

int resultado = suma(valorX, 10, 30);

Console.WriteLine(resultado);


//Crear una funcion que reste 3 valores ingresados y el resultado lo
//multiplique por 2

static int restaYmultiplicacion (int numero1, int numero2, int num3)
{
    int resta = numero1 - numero2 - num3;
    int resultadoFinal = resta * 2;
    return resultadoFinal;
}

//Llamo a mi funcion
Console.WriteLine(restaYmultiplicacion(20, 20, 'C'));