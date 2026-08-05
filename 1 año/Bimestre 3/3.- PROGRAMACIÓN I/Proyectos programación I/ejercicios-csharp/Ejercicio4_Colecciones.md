# Guía de Estudio - Ejercicio 4: Colecciones en C#

## 1. Concepto Clave
Una **Colección (`List<T>`)** es una estructura de datos dinámica que almacena varios elementos del mismo tipo dentro de una sola variable.
* **Diferencia clave:** A diferencia de un arreglo estático (`Array`), la `List<T>` no tiene un tamaño fijo: **crece y se reduce automáticamente** a medida que agregas o eliminas elementos.

---

## 2. Mapa Estructural de Colecciones

```text
┌────────────────────────────────────────────────────────┐
│                      LISTA                             │
│               List<string> listaAutos                  │
├────────────────────────────────────────────────────────┤
│  Índice [0] ──► "Tesla Model 3"                        │
│  Índice [1] ──► "Nissan Leaf"   ──( .Remove() )──► ❌  │
│  Índice [2] ──► "Hyundai Ioniq"                        │
├────────────────────────────────────────────────────────┤
│  • .Count   ──► Devuelve la cantidad de elementos      │
│  • .Add()   ──► Inserta un elemento al final           │
│  • .Remove()──► Borra por coincidencia exacta          │
└────────────────────────────────────────────────────────┘
```

---

## 3. Palabras Clave de C# vs Java

| Concepto | En Java | En C# |
| :--- | :--- | :--- |
| **Librería necesaria** | `import java.util.ArrayList;` | `using System.Collections.Generic;` |
| **Crear lista dinámica** | `ArrayList<String> lista = new ArrayList<>();` | `List<string> lista = new List<string>();` |
| **Obtener tamaño** | `lista.size()` | `lista.Count` |
| **Agregar elemento** | `lista.add("texto")` | `lista.Add("texto")` |

---

## 4. Métodos Clave de `List<T>`

1. **`List<T> nombre = new List<T>();`** -> Declara e inicializa una lista vacía.
2. **`.Add(valor)`** -> Agrega un nuevo elemento al final de la lista.
3. **`.Count`** -> Propiedad que devuelve el número total de elementos almacenados en la lista.
4. **`[índice]`** -> Acceso directo al elemento por su posición (iniciando en `[0]`).
5. **`.Remove(valor)`** -> Elimina la primera aparición del elemento indicado y reacomoda el resto.

---

## 5. Código Completo Comentado por Niveles

```csharp
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
```

---

## 6. Salida en Consola (`dotnet run`)

```text
--- LISTA INICIAL ---
- Tesla Model 3
- Nissan Leaf
- Hyundai Ioniq

Total de autos: 3
El primer auto es: Tesla Model 3

--- LISTA ACTUALIZADA ---
- Tesla Model 3
- Hyundai Ioniq
```
``!!