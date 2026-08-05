# Guía de Estudio - Program.cs (Punto de Entrada)

## 1. Concepto Clave

El archivo **Program.cs** es el **punto de entrada** de una aplicación de consola en C#.

Cuando ejecutamos el programa con:

```bash
dotnet run
```

el sistema busca automáticamente el método **`Main()`**, ya que es el primer método que se ejecuta. Desde allí se controla el flujo completo del programa.

En este proyecto, `Main()` tiene como función mostrar el nombre de cada ejercicio en la consola y llamar al método `Ejecutar()` correspondiente.

---

## 2. ¿Qué hace Program.cs?

- Contiene el método **Main()**.
- Controla el orden de ejecución del programa.
- Muestra títulos para identificar cada ejercicio.
- Llama a los métodos `Ejecutar()` de cada clase.
- Finaliza cuando termina el último ejercicio.

---

## 3. Mapa Estructural

```text
┌─────────────────────────────────────────────┐
│                 Program.cs                  │
├─────────────────────────────────────────────┤
│ Main()                                      │
│                                             │
│ Console.WriteLine()                         │
│ ↓                                           │
│ Ejercicio1_Herencia.Ejecutar()              │
│ ↓                                           │
│ Console.WriteLine()                         │
│ ↓                                           │
│ Ejercicio2_Polimorfismo.Ejecutar()          │
│ ↓                                           │
│ Console.WriteLine()                         │
│ ↓                                           │
│ Ejercicio3_Interface.Ejecutar()             │
│ ↓                                           │
│ Console.WriteLine()                         │
│ ↓                                           │
│ Ejercicio4_Colecciones.Ejecutar()           │
│ ↓                                           │
│ Console.WriteLine()                         │
│ ↓                                           │
│ Ejercicio5_Desafio.Ejecutar()               │
└─────────────────────────────────────────────┘
```

---

## 4. Flujo de Ejecución

```text
Usuario ejecuta

dotnet run
      │
      ▼
Program.cs
      │
      ▼
Main()
      │
      ▼
Muestra título del Ejercicio 1
      │
      ▼
Ejercicio1_Herencia.Ejecutar()
      │
      ▼
Muestra título del Ejercicio 2
      │
      ▼
Ejercicio2_Polimorfismo.Ejecutar()
      │
      ▼
Muestra título del Ejercicio 3
      │
      ▼
Ejercicio3_Interface.Ejecutar()
      │
      ▼
Muestra título del Ejercicio 4
      │
      ▼
Ejercicio4_Colecciones.Ejecutar()
      │
      ▼
Muestra título del Ejercicio 5
      │
      ▼
Ejercicio5_Desafio.Ejecutar()
      │
      ▼
Fin del programa
```

---

## 5. Palabras Clave

| Concepto | Explicación |
| :--- | :--- |
| **`Main()`** | Es el método principal. Todo programa de consola comienza aquí. |
| **`Console.WriteLine()`** | Muestra texto en la consola. |
| **`Ejecutar()`** | Método que contiene el código de cada ejercicio. |
| **`\n`** | Inserta un salto de línea antes del siguiente texto. |

---

## 6. Código Comentado por Niveles

```csharp
// NIVEL 1: IMPORTACIÓN (Herramientas de C#)
using System;
// Explicación: Importa las funciones básicas del lenguaje, como Console.WriteLine.


// NIVEL 2: CARPETA VIRTUAL (Namespace)
namespace EjerciciosCSharp
{
    // Explicación: Agrupa todas las clases del proyecto en un mismo espacio de nombres.

    // NIVEL 3: CLASE PRINCIPAL (Program)
    class Program
    {
        // Explicación: Es la clase que contiene el punto de entrada del programa.

        // --- NIVEL 4: MÉTODO PRINCIPAL (Main) ---
        static void Main(string[] args)
        {
            // Explicación: Main() es el primer método que ejecuta C# al iniciar el programa.

            // PASO 1: Ejecutar el ejercicio de Herencia
            Console.WriteLine("=== EJERCICIO 1: HERENCIA ===");
            Ejercicio1_Herencia.Ejecutar();

            // PASO 2: Ejecutar el ejercicio de Polimorfismo
            Console.WriteLine("\n=== EJERCICIO 2: POLIMORFISMO ===");
            Ejercicio2_Polimorfismo.Ejecutar();

            // PASO 3: Ejecutar el ejercicio de Interfaces
            Console.WriteLine("\n=== EJERCICIO 3: INTERFAZ ===");
            Ejercicio3_Interface.Ejecutar();

            // PASO 4: Ejecutar el ejercicio de Colecciones
            Console.WriteLine("\n=== EJERCICIO 4: COLECCIONES ===");
            Ejercicio4_Colecciones.Ejecutar();

            // PASO 5: Ejecutar el Desafío Final
            Console.WriteLine("\n=== EJERCICIO 5: DESAFÍO FINAL ===");
            Ejercicio5_Desafio.Ejecutar();
        }
    }
}
```

---

## 7. ¿Qué ocurre durante la ejecución?

Cuando el programa inicia:

1. Se ejecuta automáticamente el método **Main()**.
2. Se imprime el título del primer ejercicio.
3. Se llama al método `Ejecutar()` del primer ejercicio.
4. Cuando ese método termina, el programa vuelve a `Main()`.
5. Se repite el proceso con los demás ejercicios.
6. Después del último ejercicio, el programa finaliza.

Visualmente:

```text
Main()
 │
 ├──────────────► Ejercicio 1
 │                   │
 │◄──────────────────┘
 │
 ├──────────────► Ejercicio 2
 │                   │
 │◄──────────────────┘
 │
 ├──────────────► Ejercicio 3
 │                   │
 │◄──────────────────┘
 │
 ├──────────────► Ejercicio 4
 │                   │
 │◄──────────────────┘
 │
 ├──────────────► Ejercicio 5
 │                   │
 │◄──────────────────┘
 │
 ▼
Fin
```

---

## 8. Salida Esperada

```text
=== EJERCICIO 1: HERENCIA ===
...

=== EJERCICIO 2: POLIMORFISMO ===
...

=== EJERCICIO 3: INTERFAZ ===
...

=== EJERCICIO 4: COLECCIONES ===
...

=== EJERCICIO 5: DESAFÍO FINAL ===
...
```

Cada ejercicio mostrará su propia información en la consola.

---

## 9. Conceptos importantes

| Concepto | Significado |
| :--- | :--- |
| **Programa** | Conjunto de instrucciones que ejecuta el computador. |
| **Main()** | Método donde comienza la ejecución del programa. |
| **Clase** | Molde que contiene propiedades y métodos. |
| **Método** | Acción que puede realizar una clase. |
| **Namespace** | Organiza las clases dentro del proyecto. |
| **Console.WriteLine()** | Escribe texto en la consola. |
| **Llamada a un método** | Ejecuta el código contenido dentro de otro método. |

---

## 10. Errores comunes

### ❌ El método `Main()` no existe

Si el proyecto no tiene un método `Main()`, el programa no sabrá dónde comenzar y no podrá ejecutarse.

---

### ❌ Escribir mal el nombre del método

Incorrecto:

```csharp
Ejercicio1_Herencia.Ejecutra();
```

Correcto:

```csharp
Ejercicio1_Herencia.Ejecutar();
```

Los nombres deben coincidir exactamente con los declarados.

---

### ❌ No usar `Console.WriteLine()`

Si se elimina:

```csharp
Console.WriteLine("=== EJERCICIO 1 ===");
```

el ejercicio seguirá ejecutándose, pero el usuario no sabrá cuándo comienza cada uno.

---

## 11. Resumen

```text
Program.cs
      │
      ▼
Main()
      │
      ▼
Muestra un título
      │
      ▼
Llama a Ejecutar()
      │
      ▼
Espera que termine
      │
      ▼
Continúa con el siguiente ejercicio
      │
      ▼
Finaliza el programa
```

---

## 12. Lo que debes recordar para la prueba

- Todo programa de consola comienza en el método **`Main()`**.
- `Program.cs` es el archivo principal del proyecto.
- `Console.WriteLine()` muestra información en la consola.
- Una llamada a un método ejecuta el código contenido en ese método.
- El programa ejecuta las instrucciones de forma secuencial, una después de otra.
- Cuando un método termina, el flujo regresa al lugar desde donde fue llamado.
- En este proyecto, `Program.cs` coordina la ejecución de todos los ejercicios.
