using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo.Lista.Trabajo_de_lista_2
{
    class Ejercicio_4
    {

        public static void Main(string[] args)
        {

            int i = 4;




            List<int> numeroL = new List<int>();

            numeroL.Add(1);
            numeroL.Add(2);
            numeroL.Add(3);
            numeroL.Add(4);
            numeroL.Add(5);



            imprimir_lista(i);



            void imprimir_lista(int b)
            {
                if (b >= 0)
                {
                    Console.WriteLine(numeroL[b]);
                    b--;
                    imprimir_lista(b);

                }



            }

        }
    }
}
