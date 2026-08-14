using System;
namespace Pixelverse
{
    class Program
    {

        public struct Juegos
        {
            public int ID;
            public string Nombre;
            public int Stock;
            public double Precio;
            public string Categoria; //OPCIONAL
        }

        public struct Cliente
        {
            public int ID;
            public int IDproductoDeseado;

            /*
            public string Nombre; //OPCIONAL
            public string Apellido; //OPCIONAL
            public int Numero; //OPCIONAL */

        }



        public static class Inventario
        {

            public static void Mostrar(Juegos[] catalogo)
            {
                Console.WriteLine("ID\t\tPRECIO\t\tSTOCK\t\tNOMBRE");

                for (int i = 0; i < catalogo.Length; i++)
                {


                    Console.WriteLine($"{catalogo[i].ID}\t\t{catalogo[i].Precio}\t\t{catalogo[i].Stock}\t\t{catalogo[i].Nombre}");


                }

            }

            public static void CargarCatalogoInicial(Juegos[] catalogo)
            {
                string nombre;
                double precio;
                Console.WriteLine("Ingresa el nombre del juego");
                nombre = Console.ReadLine();

                catalogo[0] = new Juegos { ID = 1, Nombre = nombre, Stock = 3, Precio = 14.99, Categoria = "Accion/Mundo Abierto" };
                catalogo[1] = new Juegos { ID = 2, Nombre = "Far Cry 4", Stock = 7, Precio = 4.99, Categoria = "Accion/Mundo Abierto" };
                catalogo[2] = new Juegos { ID = 3, Nombre = "GTA V", Stock = 3, Precio = 14.99, Categoria = "Accion/Mundo Abierto" };
                catalogo[3] = new Juegos { ID = 4, Nombre = "FIFA 24", Stock = 7, Precio = 4.99, Categoria = "Deportes" };


            }

        }

        public class Carrito
        {

            public int ID { get; set; }

            public static void Agregar(int IDJuego, Juegos[] catalogo)
            {
                int cantidadJuegos = 0;
                string[] nombreJuegosEnCarrito = new string[10];

                Console.WriteLine($"Agregando al carrito {catalogo[IDJuego].Nombre}");
                catalogo[IDJuego].Stock--;
                cantidadJuegos++;


                nombreJuegosEnCarrito[cantidadJuegos] += catalogo[IDJuego].Nombre;

                Console.WriteLine("Carrito actual:");

                foreach (string s in nombreJuegosEnCarrito)
                {
                    Console.WriteLine(s);
                }

            }


            // public static int Confirmar (int[,]MesCompra,int IDJuego, Juegos[] catalogo )
            //{

            // }
            public static void Modificar()
            {
                Console.WriteLine("Modificar carrito.");
                Console.WriteLine("Carrito actual: ");
            }
        }



        static void Main()
        { //MAIN

            Juegos[] catalogo = new Juegos[5]; //limite fijo de juegos;


            Inventario.CargarCatalogoInicial(catalogo);

            Inventario.Mostrar(catalogo);


            Carrito.Agregar(2, catalogo);

            Inventario.Mostrar(catalogo);   

            Carrito.Agregar(1, catalogo);

            Inventario.Mostrar(catalogo);

            Carrito.Agregar(0, catalogo);

            Inventario.Mostrar(catalogo);

        }


    }

}