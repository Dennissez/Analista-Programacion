# Guía de Estudio - Ejercicio 3: Interfaces en C#

## 1. Concepto Clave
Una **Interfaz** es un **contrato obligatorio**. No contiene código ni lógica; únicamente define *qué* propiedades y métodos debe tener obligatoriamente cualquier clase que decida usarla.
* **Término correcto:** Las clases no heredan interfaces, las **implementan** (`implements`).

---

## 2. Mapa Estructural de Clases

```text
┌────────────────────────────────────────────────────────┐
│                      INTERFAZ                          │
│                     IElectrico                         │
├────────────────────────────────────────────────────────┤
│  • NivelBateria : int { get; set; }  (Solo firma)      │
├────────────────────────────────────────────────────────┤
│  + CargarBateria()                   (Sin código)      │
│  + MostrarNivelBateria()             (Sin código)      │
└────────────────────────────────────────────────────────┘
                           ▲
                           │
               implementa ( : )
                           │
┌────────────────────────────────────────────────────────┐
│                       CLASE                            │
│                   AutoElectrico                        │
├────────────────────────────────────────────────────────┤
│  • Marca        : string { get; set; }                 │
│  • NivelBateria : int { get; set; }  (Obligatoria)     │
├────────────────────────────────────────────────────────┤
│  + CargarBateria()       ──► { NivelBateria = 100; }   │
│  + MostrarNivelBateria() ──► { Console.WriteLine... }  │
└────────────────────────────────────────────────────────┘
```

---

## 3. Palabras Clave de C# vs Java

| Concepto | En Java | En C# |
| :--- | :--- | :--- |
| **Implementar interfaz** | `class Auto implements IElectrico` | `class Auto : IElectrico` |
| **Convención de nombre** | Sin regla estricta (ej. `Electric`) | Siempre inicia con **`I`** mayúscula (`IElectrico`) |
| **Cuerpo del método** | Firma terminada en `;` | Firma terminada en `;` |

---

## 4. Reglas Sintácticas de una Interfaz

1. **Solo Firmas:** Los métodos no llevan llaves `{ }` ni código interno, terminan en punto y coma `;`.
2. **Sin Modificadores:** No se escribe `public` dentro de la interfaz; todo por defecto es público.
3. **Cumplimiento Total:** Si una clase implementa una interfaz y olvida escribir *aunque sea uno* de los métodos exigidos, C# dará un error de compilación.

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


    // NIVEL 3: EL CONTRATO O INTERFAZ (IElectrico)
    public interface IElectrico
    {
    // Explicación: Define las exigencias que deben cumplir las clases eléctricas.

        // --- NIVEL 4A: FIRMA DE PROPIEDAD ---
        int NivelBateria { get; set; }
        // Explicación: Obliga a tener una propiedad numérica para la batería.

        // --- NIVEL 4C: FIRMAS DE MÉTODOS ---
        void CargarBateria();
        // Explicación: Firma del método para cargar. No lleva llaves { }, termina en ';'.

        void MostrarNivelBateria();
        // Explicación: Firma del método para consultar el estado actual.
    }


    // NIVEL 3: EL MOLDE QUE CUMPLE EL CONTRATO (Clase AutoElectrico)
    public class AutoElectrico : IElectrico
    {
    // Explicación: El uso de ':' indica que AutoElectrico IMPLEMENTA la interfaz IElectrico.

        // --- NIVEL 4A: PROPIEDADES ---
        public string Marca { get; set; }
        // Explicación: Propiedad propia de la clase AutoElectrico.

        public int NivelBateria { get; set; }
        // Explicación: Propiedad exigida obligatoriamente por la interfaz IElectrico.

        // --- NIVEL 4B: CONSTRUCTOR (Cómo se crea el AutoElectrico) ---
        public AutoElectrico(string marca, int nivelBateriaInicial)
        {
            Marca = marca;
            NivelBateria = nivelBateriaInicial;
            // Explicación: Asigna los valores que entran al crear el objeto a sus propiedades correspondientes.
        }

        // --- NIVEL 4C: MÉTODOS (Implementación del contrato) ---
        public void CargarBateria()
        {
            // Explicación: Lógica real que exige IElectrico. Cambia la batería al 100% e informa.
            NivelBateria = 100;
            Console.WriteLine($"El auto {Marca} ha sido cargado al {NivelBateria}%.");
        }

        public void MostrarNivelBateria()
        {
            // Explicación: Lógica real para imprimir en consola el porcentaje actual.
            Console.WriteLine($"Batería actual del {Marca}: {NivelBateria}%.");
        }
    }


    // NIVEL 3: ZONA DE PRUEBAS
    public static class Ejercicio3_Interface
    {
        // --- NIVEL 4C: EL MÉTODO QUE EJECUTA LAS ÓRDENES ---
        public static void Ejecutar()
        {
            // PASO 1: Creamos un 'AutoElectrico' real llamado 'miAutoElectrico' de marca "Tesla" al 20%.
            AutoElectrico miAutoElectrico = new AutoElectrico("Tesla", 20);

            // PASO 2: Consultamos su batería inicial.
            miAutoElectrico.MostrarNivelBateria();

            // PASO 3: Ejecutamos la carga completa.
            miAutoElectrico.CargarBateria();
        }
    }

} // Cierre del Namespace (Cierra la carpeta virtual)
```

---

## 6. Salida en Consola (`dotnet run`)

```text
Batería actual del Tesla: 20%.
El auto Tesla ha sido cargado al 100%.
```