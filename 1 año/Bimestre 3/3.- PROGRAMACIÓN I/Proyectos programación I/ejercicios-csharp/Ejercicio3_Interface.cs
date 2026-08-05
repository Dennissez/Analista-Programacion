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
    // Explicación: Una interfaz es un contrato obligatorio. NO lleva código, solo firma lo que debe implementarse.

        // --- NIVEL 4A: FIRMA DE PROPIEDAD ---
        int NivelBateria { get; set; }
        // Explicación: Obliga a cualquier clase que use esta interfaz a tener un número para la batería.

        // --- NIVEL 4C: FIRMAS DE MÉTODOS ---
        void CargarBateria();
        // Explicación: Obliga a definir cómo se carga la batería.

        void MostrarNivelBateria();
        // Explicación: Obliga a definir cómo se muestra el nivel de batería.
    }


    // NIVEL 3: EL MOLDE QUE CUMPLE EL CONTRATO (Clase AutoElectrico)
    public class AutoElectrico : IElectrico
    {
    // Explicación: Usamos ':' para indicar que 'AutoElectrico' implementa el contrato 'IElectrico'.

        // --- NIVEL 4A: PROPIEDADES (Implementación obligatoria del contrato) ---
        public string Marca { get; set; }
        // Explicación: Dato propio del auto.

        public int NivelBateria { get; set; }
        // Explicación: Propiedad exigida por la interfaz 'IElectrico'.

        // --- NIVEL 4B: CONSTRUCTOR (Cómo se crea el AutoElectrico) ---
        public AutoElectrico(string marca, int nivelBateriaInicial)
        {
            Marca = marca;
            NivelBateria = nivelBateriaInicial;
        }

        // --- NIVEL 4C: MÉTODOS (Implementación obligatoria del contrato) ---
        public void CargarBateria()
        {
            // Explicación: Carga la batería al 100% y muestra el mensaje.
            NivelBateria = 100;
            Console.WriteLine($"El auto {Marca} ha sido cargado al {NivelBateria}%.");
        }

        public void MostrarNivelBateria()
        {
            // Explicación: Muestra en pantalla el porcentaje actual de carga.
            Console.WriteLine($"Batería actual del {Marca}: {NivelBateria}%.");
        }
    }


    // NIVEL 3: ZONA DE PRUEBAS
    public static class Ejercicio3_Interface
    {
        // --- NIVEL 4C: EL MÉTODO QUE EJECUTA LAS ÓRDENES ---
        public static void Ejecutar()
        {
            // PASO 1: Fabricamos un 'AutoElectrico' llamado 'miAutoElectrico' con 20% de batería.
            AutoElectrico miAutoElectrico = new AutoElectrico("Tesla", 20);

            // PASO 2: Mostramos la batería actual (20%).
            miAutoElectrico.MostrarNivelBateria();

            // PASO 3: Cargamos la batería al 100%.
            miAutoElectrico.CargarBateria();
        }
    }

} // Cierre del Namespace (Cierra la carpeta virtual)