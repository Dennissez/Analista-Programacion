# Guía de Estudio - Ejercicio 1: Herencia en C#

## 1. Concepto Clave
La **Herencia** permite que una clase "hija" copie de forma automática los atributos y métodos de una clase "padre".
* **Regla de oro:** Se utiliza herencia solo cuando se cumple la relación **"ES UN"** (ej. Un `Auto` *es un* `Vehiculo`).

---

## 2. Mapa Estructural de Clases

```text
┌────────────────────────────────────────────────────────┐
│                   CLASE PADRE                          │
│                   Vehiculo                             │
├────────────────────────────────────────────────────────┤
│  • Marca  : string                                     │
│  • Modelo : string                                     │
├────────────────────────────────────────────────────────┤
│  + Arrancar()                                          │
└────────────────────────────────────────────────────────┘
                           ▲
                           │
                  hereda de ( : )
                           │
┌────────────────────────────────────────────────────────┐
│                   CLASE HIJA                           │
│                    Auto                                │
├────────────────────────────────────────────────────────┤
│  • CantidadPuertas : int                               │
├────────────────────────────────────────────────────────┤
│  + AbrirMaletera()                                     │
└────────────────────────────────────────────────────────┘
```

---

## 3. Comparativa de Sintaxis (Java vs C#)

| Concepto | En Java | En C# |
| :--- | :--- | :--- |
| **Indicar Herencia** | `class Auto extends Vehiculo` | `class Auto : Vehiculo` |
| **Constructor Padre** | `super(marca, modelo);` | `: base(marca, modelo)` |
| **Propiedades** | Getters y Setters manuales | `public string Marca { get; set; }` |
| **Punto de Entrada** | `public static void main(...)` | `public static void Ejecutar()` |

---

## 4. Orden de Ingreso en C#

1. **`using System;`** -> Importación de herramientas principales.
2. **`namespace EjerciciosCSharp { ... }`** -> Carpeta o grupo virtual del proyecto.
3. **`public class NombreClase { ... }`** -> El molde.
   * **Propiedades:** Atributos/Variables (`Marca`, `Modelo`).
   * **Constructor:** Método de inicialización (`new`).
   * **Métodos:** Acciones (`Arrancar()`).

---

## 5. Glosario para Principiantes

* **Clase (`class`):** El plano o molde (ej. El molde de un juguete).
* **Objeto / Instancia:** El elemento real creado a partir del molde usando la palabra `new` (ej. El juguete real de plástico).
* **Propiedad (`{ get; set; }`):** Característica o dato guardado en la clase (ej. Color, Marca, Precio).
* **Método:** Acción o comportamiento que la clase sabe hacer (ej. `Arrancar()`, `CalcularTotal()`).
* **`: base(...)`:** "Pasarle la pelota" al padre para que él guarde las propiedades que le pertenecen.

---

## 6. Errores Comunes y Cómo Solucionarlos

### ❌ Error 1: Olvidar `: base(...)` en la clase hija
Si la clase padre requiere datos en su constructor, la clase hija está **obligada** a pasárselos.
* **Incorrecto:** `public Auto(string marca) { ... }`
* **Solución:** `public Auto(string marca, string modelo) : base(marca, modelo) { ... }`

### ❌ Error 2: Escribir acciones sueltas en la clase
Intentar ejecutar órdenes fuera de un método marca error.
* **Incorrecto:** Directamente dentro de `class Auto` poner `Console.WriteLine("Hola");`
* **Solución:** Mételo siempre dentro de un método como `public void AbrirMaletera() { ... }`

---

## 7. Pasos para Crear una Clase con Herencia (Checklist)

1. **Identifica el Padre:** ¿Qué datos y acciones comparten todos? (`Vehiculo`).
2. **Crea el Padre:** Define sus propiedades, su constructor y sus métodos.
3. **Crea la Hija con `:`**: Indica de quién hereda (`public class Auto : Vehiculo`).
4. **Conecta los Constructores:** Agrega `: base(...)` en la clase hija.
5. **Agrega lo Propio:** Agrega solo los atributos y métodos exclusivos de la clase hija (`CantidadPuertas`, `AbrirMaletera()`).

---

## 8. Código Completo Comentado por Niveles

```csharp
// NIVEL 1: IMPORTACIÓN (Herramientas de C#)
using System; 
// Explicación: Le dice al programa "abre la caja de herramientas principales de C#". 
// Sin esto, la orden Console.WriteLine no funcionaría.


// NIVEL 2: CARPETA VIRTUAL (Namespace)
namespace EjerciciosCSharp 
{ 
// Explicación: Abre la llave '{' para definir el grupo o la "carpeta" donde guardaremos nuestro código.


    // NIVEL 3: EL MOLDE PADRE (Clase Vehiculo)
    public class Vehiculo 
    { 
    // Explicación: Creamos el primer molde básico. 'public' significa que se puede usar en cualquier lado.

        // --- NIVEL 4A: PROPIEDADES (Datos del Vehiculo) ---
        public string Marca { get; set; }  
        // Explicación: 'string' almacena palabras. 'Marca' guardará el nombre (ej. "Toyota").
        
        public string Modelo { get; set; } 
        // Explicación: 'Modelo' guardará el diseño (ej. "Corolla"). { get; set; } permite leer y escribir el dato.

        // --- NIVEL 4B: CONSTRUCTOR (Cómo se crea el Vehiculo) ---
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;   // Explicación: Guarda la palabra recibida en la propiedad 'Marca'.
            Modelo = modelo; // Explicación: Guarda la palabra recibida en la propiedad 'Modelo'.
        }

        // --- NIVEL 4C: MÉTODOS (Acciones del Vehiculo) ---
        public void Arrancar()
        {
            // Explicación: 'void' significa que solo ejecuta la orden. Imprime el mensaje con la marca y modelo.
            Console.WriteLine($"El vehículo {Marca} {Modelo} está encendido.");
        }
    } 


    // NIVEL 3: EL MOLDE HIJO (Clase Auto)
    public class Auto : Vehiculo
    {
    // Explicación: Usamos ':' para que 'Auto' copie todo lo que tiene 'Vehiculo' (Marca, Modelo, Arrancar).

        // --- NIVEL 4A: PROPIEDADES (Dato propio de Auto) ---
        public int CantidadPuertas { get; set; }
        // Explicación: 'int' guarda números enteros sin decimales (ej. 4 puertas).

        // --- NIVEL 4B: CONSTRUCTOR (Cómo se crea el Auto) ---
        public Auto(string marca, string modelo, int cantidadPuertas) : base(marca, modelo)
        {
            // Explicación: ': base(marca, modelo)' le envía la marca y el modelo al padre para que él los guarde.
            CantidadPuertas = cantidadPuertas; // Explicación: Guarda las puertas en el propio Auto.
        }

        // --- NIVEL 4C: MÉTODOS (Acción propia de Auto) ---
        public void AbrirMaletera()
        {
            // Explicación: Usa la 'CantidadPuertas' de Auto y la 'Marca' y 'Modelo' que heredó de Vehiculo.
            Console.WriteLine($"Abriendo la maletera del {Marca} {Modelo} ({CantidadPuertas} puertas).");
        }
    } 


    // NIVEL 3: ZONA DE PRUEBAS
    public static class Ejercicio1_Herencia 
    {
        // --- NIVEL 4C: EL MÉTODO QUE EJECUTA LAS ÓRDENES ---
        public static void Ejecutar() 
        {
            // PASO 1: Usamos 'new' para tomar el molde 'Auto' y fabricar un auto real llamado 'miAuto'.
            Auto miAuto = new Auto("Toyota", "Corolla", 4);

            // PASO 2: Usamos el punto '.' para pedirle a 'miAuto' que ejecute la acción heredada 'Arrancar()'.
            miAuto.Arrancar();

            // PASO 3: Usamos el punto '.' para pedirle que ejecute su acción propia 'AbrirMaletera()'.
            miAuto.AbrirMaletera();
        }
    }

} // Cierre del Namespace (Cierra la carpeta virtual)
```

---

## 9. Salida en Consola (`dotnet run`)

```text
El vehículo Toyota Corolla está encendido.
Abriendo la maletera del Toyota Corolla (4 puertas).
```