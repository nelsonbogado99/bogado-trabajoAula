using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoAula2021
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
        }
    }
    public class Class1
    {
        int i;
        int cont = 0;
        int numero;
        List<int> Listas = new List<int>();

        void principal()
        {
            carga();
            imprimir_lista();
            ingrese_dato();
             ingrese_dato();
            borrar();
            imprimir_lista();
        }

        public void ingrese_dato()
        {
            for (i = 0; i < 3; i++)
            {
                numero = Int32.Parse(Console.ReadLine());
                Listas.Add(numero);

            }

        }

        public void carga()
        {
            Listas.Add(1);
            Listas.Add(2);
            Listas.Add(3);
        }


        public void borrar()
        {
            Console.WriteLine("Ingrese el numero que desaes eliminar");
            numero = Int32.Parse(Console.ReadLine());

        }

        public void imprimir_lista()
        {
            // int contador = 0;
            foreach (int numero in Listas)
            {

                Console.WriteLine(numero + "\n");

                // contador++;

            }
        }
    }
}
