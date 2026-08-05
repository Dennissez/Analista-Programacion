// NIVEL 1: IMPORTACIÓN (Herramientas de C#)
using System; 
// Explicación: Carga las herramientas base para usar órdenes como Console.WriteLine.

using System.Collections.Generic; 
// Explicación: Carga la librería necesaria para trabajar con Colecciones y Listas dinámicas.


// NIVEL 2: CARPETA VIRTUAL (Namespace)
namespace EjerciciosCSharp 
{ 
// Explicación: Define el grupo o carpeta virtual donde organizamos nuestras clases.


    // NIVEL 3: ZONA DE PRUEBAS (Clase Ejercicio4_Colecciones)
    public static class Ejercicio4_Colecciones
    {
        // --- NIVEL 4C: EL MÉTODO QUE EJECUTA LAS ÓRDENES ---
        public static void Ejecutar()
        {
            // --- NIVEL 4A: DECLARACIÓN Y CREACIÓN DE LA COLECCIÓN ---
            List<string> listaAutos = new List<string>();
            // Explicación: 'List<string>' crea una lista dinámica que solo almacena texto.


            // --- NIVEL 4C: OPERACIONES DE MÉTODOS EN LA LISTA ---

            // PASO 1: Agregar elementos a la lista (.Add)
            listaAutos.Add("Tesla Model 3");
            listaAutos.Add("Nissan Leaf");
            listaAutos.Add("Hyundai Ioniq");
            // Explicación: El método .Add() inserta nuevos elementos al final de la lista.


            // PASO 2: Recorrer e imprimir los elementos de la lista
            Console.WriteLine("--- LISTA INICIAL ---");
            foreach (string auto in listaAutos)
            {
                Console.WriteLine($"- {auto}");
                // Explicación: El bucle foreach pasa por cada texto guardado en 'listaAutos' y lo imprime.
            }


            // PASO 3: Consultar propiedades y posiciones de la lista
            Console.WriteLine($"\nTotal de autos: {listaAutos.Count}");
            // Explicación: '.Count' devuelve el número total de elementos guardados (3).

            Console.WriteLine($"El primer auto es: {listaAutos[0]}");
            // Explicación: El índice '[0]' accede al primer elemento de la colección.


            // PASO 4: Eliminar un elemento (.Remove)
            listaAutos.Remove("Nissan Leaf");
            // Explicación: El método .Remove() busca la coincidencia exacta de texto y la borra de la lista.


            // PASO 5: Verificar la lista actualizada
            Console.WriteLine("\n--- LISTA ACTUALIZADA ---");
            foreach (string auto in listaAutos)
            {
                Console.WriteLine($"- {auto}");
                // Explicación: Vuelve a recorrer la lista para mostrar que "Nissan Leaf" ya no existe.
            }
        }
    }

} // Cierre del Namespace (Cierra la carpeta virtual)