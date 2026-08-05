# Guía de Estudio - Ejercicio 5: Desafío Final (Clases y Colecciones)

## 1. Concepto Clave
El **Desafío Final** combina todo lo aprendido: **Clases**, **Propiedades**, **Constructores** y **Colecciones (`List<T>`)**.
* **Composición:** Una clase (como `Garage`) puede contener adentro una lista dinámica (`List<string>`) para administrar sus propios elementos de forma organizada.

---

## 2. Mapa Estructural de Clases

```text
┌────────────────────────────────────────────────────────┐
│                        CLASE                           │
│                        Garage                          │
├────────────────────────────────────────────────────────┤
│  • ListaAutos : List<string>                           │
├────────────────────────────────────────────────────────┤
│  + Garage()             ──► Inicializa la lista vacía  │
│  + AgregarAuto(string)  ──► .Add() a la lista interna  │
│  + MostrarGarage()      ──► Recorre con foreach        │
└────────────────────────────────────────────────────────┘
                           ▲
                           │
                 es usado por ( new )
                           │
┌────────────────────────────────────────────────────────┐
│                    ZONA DE PRUEBAS                     │
│                 Ejercicio5_Desafio                     │
├────────────────────────────────────────────────────────┤
│  + Ejecutar() ──► Crea miGarage, agrega autos y muestra│
└────────────────────────────────────────────────────────┘
```

---

## 3. Palabras Clave y Acciones

| Concepto | Qué hace |
| :--- | :--- |
| **`public List<string> ListaAutos { get; set; }`** | Crea una propiedad dentro de la clase que funcionará como una lista dinámica de textos. |
| **`miGarage.AgregarAuto("...")`** | Ejecuta un método de la clase que internamente hace un `.Add()` a su lista. |
| **`miGarage.MostrarGarage()`** | Ejecuta un método de la clase que recorre la lista interna con un `foreach` y la imprime. |

---

## 4. Código Completo Comentado por Niveles

```csharp
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
```

---

## 5. Salida en Consola (`dotnet run`)

```text
--- AUTOS EN EL GARAGE ---
- Tesla Model Y
- Chevrolet Bolt
```
---

## 6. Flujo de Ejecución del Programa

```text
                Inicio del programa
                        │
                        ▼
        Ejecutar() crea un objeto Garage
                        │
                        ▼
            Constructor Garage()
                        │
                        ▼
      ListaAutos = new List<string>()
                        │
                        ▼
      AgregarAuto("Tesla Model Y")
                        │
                        ▼
   ListaAutos.Add("Tesla Model Y")
                        │
                        ▼
     AgregarAuto("Chevrolet Bolt")
                        │
                        ▼
 ListaAutos.Add("Chevrolet Bolt")
                        │
                        ▼
          MostrarGarage()
                        │
                        ▼
 foreach recorre ListaAutos
                        │
                        ▼
     Console.WriteLine(auto)
                        │
                        ▼
                    Fin
```

---

## 7. ¿Qué ocurre en la memoria?

Cuando escribimos:

```csharp
Garage miGarage = new Garage();
```

sucede lo siguiente:

```text
               Memoria

miGarage
   │
   ▼
┌────────────────────────────┐
│ Garage                     │
│────────────────────────────│
│ ListaAutos ───────────────┐│
└───────────────────────────│┘
                            ▼
                    ┌───────────────────┐
                    │ List<string>      │
                    │───────────────────│
                    │ "Tesla Model Y"   │
                    │ "Chevrolet Bolt"  │
                    └───────────────────┘
```

La variable **miGarage** guarda una referencia al objeto `Garage`, y ese objeto contiene una lista donde se almacenan los nombres de los autos.

---

## 8. Explicación de `List<T>`

Una **List** es una colección dinámica.

A diferencia de un arreglo (**array**), una lista puede crecer automáticamente según sea necesario.

```csharp
List<string> autos = new List<string>();
```

Aquí:

- **List** → Tipo de colección.
- **string** → Tipo de dato que almacenará.
- **autos** → Nombre de la variable.
- **new List<string>()** → Crea una lista vacía.

### Ejemplo

```csharp
autos.Add("Tesla");
autos.Add("Toyota");
autos.Add("Mazda");
```

La lista queda así:

```text
Índice    Valor
------    ----------------
0         Tesla
1         Toyota
2         Mazda
```

---

## 9. ¿Qué hace `.Add()`?

El método **Add()** agrega un nuevo elemento al final de la lista.

```csharp
ListaAutos.Add("Tesla");
```

Antes:

```text
ListaAutos
──────────
Chevrolet
Toyota
```

Después:

```text
ListaAutos
──────────
Chevrolet
Toyota
Tesla
```

---

## 10. ¿Qué hace `foreach`?

`foreach` sirve para recorrer automáticamente todos los elementos de una colección.

Su sintaxis es:

```csharp
foreach (tipo variable in coleccion)
{
    // instrucciones
}
```

En este ejercicio:

```csharp
foreach (string auto in ListaAutos)
{
    Console.WriteLine(auto);
}
```

Significa:

1. Toma el primer elemento.
2. Lo guarda temporalmente en la variable **auto**.
3. Ejecuta el código del bloque.
4. Repite el proceso hasta terminar la colección.

Visualmente:

```text
ListaAutos

Tesla Model Y
Chevrolet Bolt
Toyota Corolla

        │
        ▼
foreach

auto = Tesla Model Y
↓

auto = Chevrolet Bolt
↓

auto = Toyota Corolla
↓

Fin
```

---

## 11. Relación entre las clases

```text
                 Garage
          ┌─────────────────┐
          │ ListaAutos      │
          │ AgregarAuto()   │
          │ MostrarGarage() │
          └────────▲────────┘
                   │
              usa el objeto
                   │
             new Garage()
                   │
        Ejercicio5_Desafio
        ┌─────────────────┐
        │ Ejecutar()      │
        └─────────────────┘
```

La clase **Garage** contiene toda la lógica para administrar los autos.

La clase **Ejercicio5_Desafio** simplemente crea un objeto `Garage` y utiliza sus métodos.

---

## 12. Conceptos importantes del ejercicio

| Concepto | Explicación |
|----------|-------------|
| **Clase** | Es un molde para crear objetos. |
| **Objeto** | Es una instancia creada con `new`. |
| **Propiedad** | Guarda información del objeto. |
| **Constructor** | Inicializa el objeto cuando se crea. |
| **Método** | Acción que puede realizar una clase. |
| **List<T>** | Colección dinámica que puede aumentar o disminuir su tamaño. |
| **Add()** | Agrega un elemento al final de la lista. |
| **foreach** | Recorre todos los elementos de una colección. |
| **Composición** | Una clase contiene otra estructura de datos (como una lista) para organizar información. |

---

## 13. Errores comunes

### ❌ Olvidar inicializar la lista

```csharp
public List<string> ListaAutos { get; set; }
```

Si nunca hacemos:

```csharp
ListaAutos = new List<string>();
```

al ejecutar:

```csharp
ListaAutos.Add("Tesla");
```

ocurrirá el error:

```text
NullReferenceException
```

Esto sucede porque la lista todavía no existe en memoria.

---

### ❌ Crear la variable sin usar `new`

Incorrecto:

```csharp
Garage miGarage;
```

Luego:

```csharp
miGarage.AgregarAuto("Tesla");
```

también producirá un:

```text
NullReferenceException
```

porque el objeto nunca fue creado.

---

### ❌ Olvidar llamar al método

Si nunca ejecutamos:

```csharp
miGarage.MostrarGarage();
```

los autos estarán guardados en la lista, pero nunca aparecerán en la consola.

---

## 14. Resumen del ejercicio

```text
Clase Garage
      │
      ▼
Tiene una lista de autos
      │
      ▼
Constructor crea la lista vacía
      │
      ▼
AgregarAuto() usa Add()
      │
      ▼
Los autos quedan almacenados
      │
      ▼
MostrarGarage() usa foreach
      │
      ▼
Cada auto se imprime en pantalla
```

---

## 15. Lo que debes recordar para la prueba

- Una **clase** es un molde para crear objetos.
- Un **objeto** se crea utilizando la palabra reservada `new`.
- El **constructor** prepara el objeto para que pueda usarse.
- `List<T>` es una colección dinámica que almacena elementos del tipo indicado (`string`, `int`, etc.).
- `Add()` agrega un elemento al final de la lista.
- `foreach` recorre automáticamente todos los elementos de una colección.
- Es necesario inicializar una lista (`new List<T>()`) antes de utilizarla.
- Una clase puede contener otras estructuras de datos, como una `List<T>`, lo que se conoce como **composición**.