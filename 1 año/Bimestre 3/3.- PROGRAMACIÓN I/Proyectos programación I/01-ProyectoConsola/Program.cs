/* Console: Es la clase que representa la ventana de la consola/terminal. 
   WriteLine: Significa "Write Line" (Escribir Línea). Imprime lo que le pongas dentro y salta a la siguiente línea. */

Console.WriteLine("Hello, World!");

// Mascota

Console.WriteLine("Django");

// Se crea la variable edad y se imprime en la pantalla de la consola

var edad = 30;
Console.WriteLine(edad);

// Es una instrucción que une una cadena de texto fija con el valor de una variable mediante el operador +, para luego mostrar el mensaje completo en la pantalla.

Console.WriteLine("Mi edad es: " + edad);

/* Se crea la variable cancionFavorita y se escribe la instrucción que une una cadena de texto fija con el valor de una variable mediante el operador +, para luego 
   mostrar el mensaje completo en la pantalla. */

var cancionFavorita = "Cinnamon Girl";
Console.WriteLine("Mi canción favorita es " + cancionFavorita);

/* Se crea la variable cancionFavorita y se imprime utilizando 
   interpolación de cadenas ($) para insertar la variable directamente */

Console.WriteLine($"Mi canción favorita es {cancionFavorita}");

// Se crearon dos variables de tipo string (cantante) e int (duración)

var cantante = "Lana del rey";
var duracion = 300;

Console.WriteLine("Mi canción favorita es " + cancionFavorita + " de " + cantante + " y dura " + duracion + " segundos");

/* Se declaran cuatro variables con sus respectivos tipos de datos:
   - id (int): Identificador único del producto
   - producto (string): Nombre o descripción del producto
   - valor (int): Precio del producto
   - estaDisponible (bool): Estado de disponibilidad (true/false)
   
   Luego se imprimen en consola combinando interpolación ($) y texto
   multilínea (@) para darle formato limpio. */

int id = 1;
string producto = "Notebook Asus ROG";
int valor = 1250000;
bool estaDisponible = true;

Console.WriteLine($@"
     id: {id}
     Producto: {producto}
     Valor: {valor}
     Disponible: {estaDisponible}
     ");