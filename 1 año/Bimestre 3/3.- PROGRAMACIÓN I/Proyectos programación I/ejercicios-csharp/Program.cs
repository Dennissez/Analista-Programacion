// NIVEL 1: IMPORTACIÓN (Herramientas de C#)
using System;
// Explicación: Importa las funciones básicas de C#, como Console.WriteLine.


// NIVEL 2: CARPETA VIRTUAL (Namespace)
namespace EjerciciosCSharp
{
    // Explicación: Agrupa todas las clases del proyecto dentro del mismo espacio de nombres.

    // NIVEL 3: CLASE PRINCIPAL (Punto de inicio del programa)
    class Program
    {
        // Explicación: Esta es la clase principal donde comienza la ejecución del programa.

        // --- NIVEL 4: MÉTODO PRINCIPAL (Main) ---
        static void Main(string[] args)
        {
            // Explicación: Main() es el primer método que ejecuta C# al iniciar el programa.

            // PASO 1: Ejecutar el Ejercicio 1
            Console.WriteLine("=== EJERCICIO 1: HERENCIA ===");
            // Explicación: Muestra un título en la consola para identificar el ejercicio.

            Ejercicio1_Herencia.Ejecutar();
            // Explicación: Llama al método Ejecutar() de la clase Ejercicio1_Herencia.


            // PASO 2: Ejecutar el Ejercicio 2
            Console.WriteLine("\n=== EJERCICIO 2: POLIMORFISMO ===");
            // Explicación: Imprime una línea en blanco (\n) y el título del segundo ejercicio.

            Ejercicio2_Polimorfismo.Ejecutar();
            // Explicación: Ejecuta el código correspondiente al ejercicio de Polimorfismo.


            // PASO 3: Ejecutar el Ejercicio 3
            Console.WriteLine("\n=== EJERCICIO 3: INTERFAZ ===");
            // Explicación: Muestra el encabezado del tercer ejercicio.

            Ejercicio3_Interface.Ejecutar();
            // Explicación: Llama al método Ejecutar() de la clase Ejercicio3_Interface.


            // PASO 4: Ejecutar el Ejercicio 4
            Console.WriteLine("\n=== EJERCICIO 4: COLECCIONES ===");
            // Explicación: Muestra el encabezado del cuarto ejercicio.

            Ejercicio4_Colecciones.Ejecutar();
            // Explicación: Ejecuta el ejercicio relacionado con las colecciones.


            // PASO 5: Ejecutar el Ejercicio 5
            Console.WriteLine("\n=== EJERCICIO 5: DESAFÍO FINAL ===");
            // Explicación: Muestra el encabezado del último ejercicio.

            Ejercicio5_Desafio.Ejecutar();
            // Explicación: Ejecuta el desafío final, donde se integran clases, propiedades, constructores y colecciones.
        }
    }
}