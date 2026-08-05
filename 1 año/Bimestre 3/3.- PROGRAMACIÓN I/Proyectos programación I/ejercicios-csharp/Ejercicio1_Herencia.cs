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