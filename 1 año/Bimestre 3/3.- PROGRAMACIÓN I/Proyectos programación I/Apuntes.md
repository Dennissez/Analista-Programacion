# 📘 Mis Apuntes de Programación 1

Este archivo contiene los comandos básicos de la terminal para administrar mis proyectos de C# 12.

---

### 1. Crear un proyecto nuevo desde cero
Se usa para generar una carpeta nueva con todo lo necesario para la tarea.
```bash
dotnet new console -o NombreDeTuTarea
```

### 2. Entrar a la carpeta del proyecto
Es obligatorio hacerlo antes de correr el código para que la terminal sepa dónde está parada.
```bash
cd NombreDeTuTarea
```

### 3. Ejecutar y ver el resultado del código
Traduce el archivo .cs y muestra el resultado real en la pantalla negra.
```bash
dotnet run
```

---

### 💡 Comandos extra de ayuda:
* `cls` -> Limpia todo el texto de la terminal si se llena de errores.
* `cd ..` -> Te saca de la carpeta actual y te regresa una carpeta hacia atrás.

---

## 1. Conceptos Fundamentales de POO

La Programación Orientada a Objetos en C# se basa en cuatro principios fundamentales:

* **Abstracción:** Permite crear clases para representar atributos y comportamientos relevantes del sistema.
* **Encapsulamiento:** Oculta el estado interno y funcional de un objeto, siendo accesible solo mediante métodos públicos.
* **Herencia:** Permite que una clase hija herede comportamientos (métodos) y características (propiedades/atributos) desde una clase padre.
* **Polimorfismo:** Permite que una clase padre trate a instancias de clases hijas y que las clases hijas redefinan comportamientos.

---

## 2. Herencia y Polimorfismo en C#

### a. Uso de `base`
Para invocar un método o propiedad de la clase padre desde la clase hija, se utiliza la palabra reservada `base`.

```csharp
public class Personal
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }

    protected string ObtenerInformacion()
    {
        return $"Id: {Id} - Nombre: {Nombre} {Apellido}";
    }
}

public class Profesor : Personal
{
    public Profesor() : base() {}

    public string MostrarInfoDesdeClaseProfesor()
    {
        return base.ObtenerInformacion();
    }
}
```

### b. Sobreescritura de Métodos (`virtual` y `override`)
Para permitir que un método de la clase padre sea sobreescrito en la clase hija, se declara con `virtual`. La clase hija utiliza `override` para redefinir el comportamiento.

```csharp
// Clase Padre
public virtual string MetodoVirtual()
{
    return "Soy un método virtual desde la clase padre!";
}

// Clase Hija
public override string MetodoVirtual()
{
    return "Soy un método virtual de la clase padre que ha sido sobreescrito en la clase hijo!";
}
```

### c. Reglas de Instanciación en Polimorfismo
* La clase padre **puede** crear instancias de la clase hija: `Personal historia = new Profesor();`.
* La clase hija **no puede** crear instancias de la clase padre directamente (genera error `CS0266`).

---

## 3. Interfaces (`interface`)

Una `interface` define un **contrato** obligatorio que las clases deben implementar.
* Por convención, sus nombres inician con `I` mayúscula (ejemplo: `IPersistente`).
* Sus miembros no llevan modificadores de acceso (son públicos por defecto).
* No contienen la implementación de los métodos, solo la firma.

```csharp
public interface IPersistente
{
    bool ObtenerPersonalPorId(int id);
    bool Estado { get; set; }
}

public class Personal : IPersistente
{
    public bool Estado { get; set; }

    public bool ObtenerPersonalPorId(int id)
    {
        // Implementación requerida
        return true;
    }
}
```

---

## 4. Colecciones en Memoria

Las colecciones permiten almacenar datos temporalmente durante la ejecución de la aplicación.

### a. `List<T>` (Genérica)
Es una colección fuertemente tipada. Solo acepta elementos del tipo especificado `T` (o valores transformados a dicho tipo). Utiliza índices posicionales en base `0`.

| Método / Propiedad | Tipo de Retorno | Descripción | Ejemplo |
| :--- | :--- | :--- | :--- |
| `Add(T item)` | `void` | Agrega un nuevo elemento al final de la lista. | `colores.Add("rojo");` |
| `Clear()` | `void` | Elimina todos los elementos de la lista. | `colores.Clear();` |
| `Contains(T item)` | `bool` | Determina si la lista contiene el valor especificado. | `colores.Contains("rojo");` |
| `Insert(int i, T item)` | `void` | Inserta un elemento en el índice especificado. | `colores.Insert(5, "verde");` |
| `Remove(T item)` | `void` | Remueve la primera ocurrencia del objeto. | `colores.Remove("verde");` |
| `RemoveAt(int i)` | `void` | Remueve el elemento en la posición del índice. | `colores.RemoveAt(4);` |
| `Count` | `int` | Obtiene el número de elementos en la lista. | `colores.Count;` |
| `Item[int i]` | `T` | Obtiene un elemento según el índice entregado. | `colores[2];` |

### b. `ArrayList` (No Genérica)
Colección no genérica utilizada para almacenar elementos cuya estructura o tipo de dato es desconocido. *(No se recomienda su uso por rendimiento)*.

| Método / Propiedad | Tipo de Retorno | Descripción | Ejemplo |
| :--- | :--- | :--- | :--- |
| `Add(Object value)` | `int` | Agrega un objeto al final de la lista. | `colores.Add("rojo");` |
| `AddRange(ICollection)` | `void` | Añade una colección de datos al final. | `colores.AddRange(otrasSillas);` |
| `Sort()` | `void` | Ordena los elementos dentro de la lista. | `colores.Sort();` |
| `ToArray()` | `object[]` | Retorna la colección como un objeto Array. | `colores.ToArray();` |
| `Capacity` | `int` | Establece u obtiene el número de elementos soportados. | `colores.Capacity;` |