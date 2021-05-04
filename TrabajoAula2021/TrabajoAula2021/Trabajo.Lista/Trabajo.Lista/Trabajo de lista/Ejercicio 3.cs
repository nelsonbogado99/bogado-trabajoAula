using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo.Lista.Trabajo_de_lista_2
{
    class Ejercicio_3
    {

        public static void Main(string[] args)
        {

            int i = 0;
            int numero;


            List<int> numeroL = new List<int>();

            numeroL.Add(1);
            numeroL.Add(2);
            numeroL.Add(3);
            numeroL.Add(4);
            numeroL.Add(5);


            Console.WriteLine("Ingrese el numero que desea buscar en el lista");

            numero = Int32.Parse(Console.ReadLine());

            imprimir_lista(numero, i);



            void imprimir_lista(int a, int b)
            {
                if (b > 4)
                {
                    Console.WriteLine("NULL");
                }

                else if (numeroL[b] == a)
                {
                    Console.WriteLine("En la lista el encontro el numero buscado y es el: " + a);
                }
                else if (b <= 4)
                {
                    b++;
                    imprimir_lista(a, b);

                }



            }

        }
    }
}
