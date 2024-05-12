using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos el contador en 1
            int contador = 1;

            // Mientras el contador sea menor o igual a 10, imprimimos el número y luego incrementamos el contador
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Espera a que el usuario presione una tecla antes de salir de la consola
            Console.ReadKey();
        }
    }
}

