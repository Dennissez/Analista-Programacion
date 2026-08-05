// NIVEL 1: IMPORTACIÓN (Herramientas de C#)
using System; 
// Explicación: Carga las herramientas base para usar órdenes como Console.WriteLine.

using System.Collections.Generic; 
// Explicación: Carga la librería para usar listas dinámicas dentro de nuestras clases.


// NIVEL 2: CARPETA VIRTUAL (Namespace)
namespace EjerciciosCSharp 
{ 
// Explicación: Define el grupo o carpeta virtual donde organizamos nuestras clases.


    // NIVEL 3: EL MOLDE QUE CONTIENE ELEMENTOS (Clase Garage)
    public class Garage
    {
        // --- NIVEL 4A: PROPIEDADES (Lista de autos dentro del Garage) ---
        public List<string> ListaAutos { get; set; }
        // Explicación: Propiedad que guarda una lista de textos con los nombres de los autos.


        // --- NIVEL 4B: CONSTRUCTOR (Cómo se inicializa el Garage) ---
        public Garage()
        {
            ListaAutos = new List<string>();
            // Explicación: Crea la lista vacía al momento de fabricar un nuevo Garage.
        }


        // --- NIVEL 4C: MÉTODOS (Acciones que puede hacer el Garage) ---
        public void AgregarAuto(string auto)
        {
            ListaAutos.Add(auto);
            // Explicación: Método personalizado que recibe un auto y lo agrega a la lista interna.
        }

        public void MostrarGarage()
        {
            Console.WriteLine("--- AUTOS EN EL GARAGE ---");
            foreach (string auto in ListaAutos)
            {
                Console.WriteLine($"- {auto}");
                // Explicación: Recorre la lista interna del garage y muestra cada auto en pantalla.
            }
        }
    }


    // NIVEL 3: ZONA DE PRUEBAS (Clase Ejercicio5_Desafio)
    public static class Ejercicio5_Desafio
    {
        // --- NIVEL 4C: EL MÉTODO QUE EJECUTA LAS ÓRDENES ---
        public static void Ejecutar()
        {
            // PASO 1: Creamos un objeto Garage real usando 'new'
            Garage miGarage = new Garage();
            // Explicación: Inicializa la clase Garage con su lista de autos vacía lista para usarse.

            // PASO 2: Usamos el método AgregarAuto para meter vehículos al garage
            miGarage.AgregarAuto("Tesla Model Y");
            miGarage.AgregarAuto("Chevrolet Bolt");
            // Explicación: Llama a la acción de la clase Garage para guardar los autos en su lista interna.

            // PASO 3: Mostramos el contenido llamando al método MostrarGarage
            miGarage.MostrarGarage();
            // Explicación: Ejecuta la lógica para imprimir todos los autos guardados en el garage.
        }
    }

} // Cierre del Namespace (Cierra la carpeta virtual)