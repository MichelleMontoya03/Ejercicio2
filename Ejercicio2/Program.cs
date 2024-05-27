using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEntradasNorte = 0;
            double totalDineroNorte = 0;

            Console.WriteLine("Desea Comprar Entradas, Digite S si su respuesta es SI o N si su respuesta en NO");
            string respuesta = Console.ReadLine();

            if (respuesta == "N")
            {
                Console.Write("Saliendo del Sistema");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
                if (respuesta == "S")
            {



                for (int i = 0; i == 0; i++)
                {

                    Console.Write("\nDigite \n" +
                        "N para Sol norte\n" +
                        "S para Sol sur\n" +
                        "O para sombra Oeste\n" +
                        "E para sombra Este\n");

                    string opcion = Console.ReadLine();

                    if (opcion == "N")
                    {
                        double precioEntradaNorte = 10500;
                        double subtotal = 0;
                        double total = 0;

                        Console.WriteLine("Digite la cantidad de Entradas que desea");
                        int cantidadEntradas = int.Parse(Console.ReadLine());

                        if (cantidadEntradas < 0 || cantidadEntradas > 5)
                        {
                            Console.WriteLine("Solo es permitido comprar un maximo de 4 entradas por persona");
                            i = i - 1;
                        }
                        else
                        if (cantidadEntradas > 0 && cantidadEntradas < 5)
                        {
                            subtotal = cantidadEntradas * precioEntradaNorte;
                            total = total + subtotal;

                            cantidadEntradasNorte = cantidadEntradasNorte + cantidadEntradas;
                            totalDineroNorte = totalDineroNorte + total;

                            Console.WriteLine("Desea comprar mas entradas, Digite S si su respuesta es SI y N si su respuesta es NO");
                            respuesta = Console.ReadLine();

                            if (respuesta == "S")
                            {

                                i = i - 1;

                            }
                            else { }



                        }
                    }
}
