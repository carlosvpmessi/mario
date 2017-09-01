using System;

namespace mario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Altura de la piramide: ");
            int niveles;
            /// Tryparse convierte la representación de una cadena (string) a su equivalente entero (int). Un valor devuelto indica si la conversión tuvo éxito.
            //  devuelve 0 si no se pudo convertir
            int.TryParse( Console.ReadLine(), out niveles);

             dibujarPiramide(niveles);

        }

        static void dibujarPiramide(int niveles){
            
            
            
        }
    }
}
