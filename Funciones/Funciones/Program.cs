using System.Runtime.CompilerServices;


static int Sumar (int x, int y)
{
    return x + y;

}
//Console.WriteLine(Sumar(10, 20));

static int Restar (int x, int y) 
{
    return x - y; 
}


//Console.WriteLine(Restar(10, -10));

static int Multiplicar (int valor1, int valor2) { return valor1 * valor2; }

int num1 = 10;
int num2 = 20;

//Console.WriteLine(Multiplicar(num1, num2)); //Llamando a la funcion multiplicar


static double CalcularIva (int x)
{
    const double impuesto = 0.21;
    Console.WriteLine("Hola");

    return x * impuesto;

    

}

static void Mensaje ()
{
    Console.WriteLine("Ingresa el valor de un producto o servicio para calcular el IVA");
}

Mensaje();

int.TryParse(Console.ReadLine(), out num1);

Console.WriteLine($"El IVA para {num1} es");

double resultado = CalcularIva(num1);

Console.WriteLine(resultado);

//LA otra manera de la funcion (void)


static double CalcularIva2()
{
    const double impuesto = 0.21;
    int num1;
    Console.WriteLine("Ingresa el valor de un producto o servicio para calcular el IVA");

    int.TryParse(Console.ReadLine(), out num1);

    Console.WriteLine($"El IVA para {num1} es {num1 * impuesto}");


    return num1 * impuesto;


}


CalcularIva2();
