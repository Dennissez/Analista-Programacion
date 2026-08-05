# Guía de Estudio - Ejercicio 2: Polimorfismo en C#

## 1. Concepto Clave
El **Polimorfismo** (muchas formas) permite que clases hijas tengan comportamientos diferentes usando un mismo nombre de método.
* **Sobrescritura (`override`):** La clase hija reescribe la acción del padre para adaptarla a su propia naturaleza.

---

## 2. Mapa Estructural de Clases

```text
┌────────────────────────────────────────────────────────┐
│                   CLASE PADRE                          │
│                   VehiculoBase                         │
├────────────────────────────────────────────────────────┤
│  • Marca : string                                      │
├────────────────────────────────────────────────────────┤
│  + HacerSonido()  [virtual] ──► "Sonido genérico..."  │
└────────────────────────────────────────────────────────┘
                           ▲
             ┌─────────────┴─────────────┐
             │                           │
  hereda de ( : )             hereda de ( : )
             │                           │
┌─────────────────────────┐ ┌─────────────────────────┐
│       CLASE HIJA        │ │       CLASE HIJA        │
│          Auto2          │ │          Moto           │
├─────────────────────────┤ ├─────────────────────────┤
│ + HacerSonido()         │ │ + HacerSonido()         │
│   [override]            │ │   [override]            │
│   ──► "BRRRRMM!"        │ │   ──► "RUUUUMMMM!"      │
└─────────────────────────┘ └─────────────────────────┘
```

---

## 3. Palabras Clave de C# vs Java

| Concepto | En Java | En C# |
| :--- | :--- | :--- |
| **Permitir Sobrescribir** | Automático en todos los métodos | Palabra **`virtual`** en el padre |
| **Sobrescribir Método** | Anotación `@Override` | Palabra **`override`** en el método |
| **Constructor Flecha** | No disponible | Sintaxis corta: `=> Marca = marca;` |

---

## 4. El Nuevo Detalle: `=>` (Expression-Bodied Member)

En la plantilla viste esta línea:
```csharp
public VehiculoBase(string marca) => Marca = marca;
```
Esto es solo una **forma resumida** de escribir métodos o constructores de 1 sola línea en C#. Es exactamente igual a escribir:
```csharp
public VehiculoBase(string marca)
{
    Marca = marca;
}
```

---

## 5. Código Completo Comentado por Niveles

```csharp
// NIVEL 1: IMPORTACIÓN (Herramientas de C#)
using System; 
// Explicación: Le dice al programa "abre la caja de herramientas principales de C#". 
// Sin esto, la orden Console.WriteLine no funcionaría.


// NIVEL 2: CARPETA VIRTUAL (Namespace)
namespace EjerciciosCSharp 
{ 
// Explicación: Abre la llave '{' para definir el grupo o la "carpeta" donde guardaremos nuestro código.


    // NIVEL 3: EL MOLDE PADRE (Clase VehiculoBase)
    public class VehiculoBase
    {
    // Explicación: Creamos el molde básico. 'public' permite usarlo en cualquier parte.

        // --- NIVEL 4A: PROPIEDADES (Datos de VehiculoBase) ---
        public string Marca { get; set; }
        // Explicación: 'string' almacena texto. 'Marca' guardará el nombre del fabricante (ej. "Toyota").

        // --- NIVEL 4B: CONSTRUCTOR (Cómo se crea el VehiculoBase) ---
        public VehiculoBase(string marca) => Marca = marca;
        // Explicación: Recibe la palabra 'marca'. '=>' es un atajo que guarda esa palabra directamente en la propiedad 'Marca'.

        // --- NIVEL 4C: MÉTODOS (Acción con permiso de modificación) ---
        public virtual void HacerSonido()
        {
            // Explicación: 'virtual' es la clave del polimorfismo. Otorga permiso a las clases hijas para cambiar este método.
            Console.WriteLine("Sonido genérico de vehículo...");
        }
    }


    // NIVEL 3: EL MOLDE HIJO 1 (Clase Auto2)
    public class Auto2 : VehiculoBase
    {
    // Explicación: Usamos ':' para que 'Auto2' herede la propiedad 'Marca' y el método 'HacerSonido()' de 'VehiculoBase'.

        // --- NIVEL 4B: CONSTRUCTOR (Cómo se crea el Auto2) ---
        public Auto2(string marca) : base(marca)
        {
            // Explicación: ': base(marca)' le envía la marca recibida al padre para que él la guarde en su propiedad.
        }

        // --- NIVEL 4C: MÉTODOS (Acción modificada con Polimorfismo) ---
        public override void HacerSonido()
        {
            // Explicación: 'override' usa el permiso 'virtual' del padre para cambiar el sonido genérico por el del auto.
            Console.WriteLine($"{Marca}: ¡Brum Brum!");
        }
    }


    // NIVEL 3: EL MOLDE HIJO 2 (Clase Moto)
    public class Moto : VehiculoBase
    {
    // Explicación: Usamos ':' para que 'Moto' también herede todo de 'VehiculoBase'.

        // --- NIVEL 4B: CONSTRUCTOR (Cómo se crea la Moto) ---
        public Moto(string marca) : base(marca)
        {
            // Explicación: Le reenvía la marca al constructor del padre 'VehiculoBase'.
        }

        // --- NIVEL 4C: MÉTODOS (Acción modificada con Polimorfismo) ---
        public override void HacerSonido()
        {
            // Explicación: 'override' cambia la respuesta del padre por el sonido característico de la moto.
            Console.WriteLine($"{Marca}: ¡Ruuuuum!");
        }
    }


    // NIVEL 3: ZONA DE PRUEBAS
    public static class Ejercicio2_Polimorfismo
    {
        // --- NIVEL 4C: EL MÉTODO QUE EJECUTA LAS ÓRDENES ---
        public static void Ejecutar()
        {
            // PASO 1: Usamos 'new' para fabricar un auto real llamado 'miAuto' pasándole la marca "Toyota".
            Auto2 miAuto = new Auto2("Toyota");

            // PASO 2: Usamos 'new' para fabricar una moto real llamada 'miMoto' pasándole la marca "Yamaha".
            Moto miMoto = new Moto("Yamaha");

            // PASO 3: Usamos el punto '.' para pedirle a 'miAuto' que ejecute su propia versión de 'HacerSonido()'.
            miAuto.HacerSonido();

            // PASO 4: Usamos el punto '.' para pedirle a 'miMoto' que ejecute su propia versión de 'HacerSonido()'.
            miMoto.HacerSonido();
        }
    }

} // Cierre del Namespace (Cierra la carpeta virtual)
```

---

## 6. Salida en Consola (`dotnet run`)

```text
Toyota: ¡Brum Brum!
Yamaha: ¡Ruuuuum!
```