# Apuntes de Programación I — Fundamentos de C# (.NET 8)

---

## 1. Glosario de Conceptos y Entorno de Desarrollo

A continuación se detallan los conceptos clave de entorno, lenguajes y estructuras de datos:

| Término | Definición |
| :--- | :--- |
| **IDE** | *(Integrated Development Environment)* Programa que reúne las herramientas necesarias para desarrollar distintos tipos de aplicaciones. |
| **CONSOLA** | Programas de solo texto que permiten al usuario ingresar texto, opciones y comandos para realizar una acción. |
| **C#** | Lenguaje de programación multiplataforma, fuertemente tipado, orientado a objetos y a componentes. |
| **VS CODE** | IDE/Editor ligero y rápido, desarrollado por Microsoft, lanzado el año 2015 y que reúne una gran variedad de características y herramientas para el desarrollo con el framework de .NET y otros. |
| **TIPOS DE DATOS** | Define el comportamiento y estructura de un valor dentro del lenguaje y cómo se almacenará en memoria. |

---

## 2. Tipos de Datos Principales

| Tipo de Dato | Descripción | Ejemplo de Uso |
| :--- | :--- | :--- |
| **`INT`** | Valores numéricos enteros, ya sean positivos o negativos (sin decimales). | `int edad = 30;` |
| **`DOUBLE`** | Valores numéricos enteros y decimales / punto flotante. | `double precio = 19990.50;` |
| **`STRING`** | Es una cadena de texto y acepta números, letras y caracteres especiales. Usa comillas dobles (`""`). | `string nombre = "Lana del Rey";` |
| **`CHAR`** | De solo un carácter de largo, no puede estar vacío y usa comillas simples (`''`). | `char opcion = 'S';` |
| **`BOOL`** | Solo acepta dos valores: `true` y `false`. | `bool estaDisponible = true;` |
| **`OBJECT`** | Tipo de dato que hace referencia a un objeto sin estructura (clase base en C#). | `object dato = "Genérico";` |

---

## 3. Inferencia de Tipos con `var`

La palabra reservada `var` le indica al compilador que **deduzca automáticamente** el tipo de dato en función del valor asignado a la derecha.

* **Importante:** C# sigue siendo de **tipado fuerte**. Una vez asignado el valor inicial, la variable **no** puede cambiar de tipo.
* **Obligatorio:** Se debe inicializar en la misma línea donde se declara.

```csharp
var edad = 30;                 // El compilador infiere tipo 'int'
var cantante = "Lana del rey"; // El compilador infiere tipo 'string'

// ERROR: No se puede asignar un número a una variable que fue definida como string
// cantante = 100; 
```

---

## 4. Salida de Datos por Consola (`Console`)

Para interactuar con la terminal se utiliza la clase `Console`.

* **`Console.WriteLine()`**: Muestra el mensaje en la pantalla y realiza un salto de línea al final.
* **`Console.Write()`**: Muestra el mensaje en pantalla pero mantiene el cursor en la misma línea.

* **`fdsf`

```csharp
Console.WriteLine("Hello, World!");
```

---

## 5. Formateo y Manipulación de Cadenas (*Strings*)

Existen varias formas de combinar texto con variables en C#:

### A. Concatenación Clásica (Operador `+`)
Une cadenas de texto estáticas con variables mediante el signo `+`.

```csharp
var edad = 30;
Console.WriteLine("Mi edad es: " + edad);
```

### B. Interpolación de Cadenas (`$`)
Permite incrustar variables o expresiones directamente dentro del texto usando llaves `{}`. Es la forma más limpia y moderna.

```csharp
var cancionFavorita = "Cinnamon Girl";
Console.WriteLine($"Mi canción favorita es {cancionFavorita}");
```

### C. Cadenas Verbatim / Multilínea (`@`) e Interpolación Combinada (`$@`)
El carácter `@` permite respetar saltos de línea y espacios tal cual están escritos en el código. Combinado con `$`, permite formatear fichas o bloques de datos fácilmente.

```csharp
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
```

---

## 6. Sintaxis de Comentarios en C#

* **Comentarios de una sola línea (`//`):**
  ```csharp
  // Esto es un comentario de una sola línea
  ```

* **Comentarios multilínea (`/* ... */`):**
  ```csharp
  /* Este es un comentario
     que abarca múltiples
     líneas de código */
  ```

---

## 7. Atajos Teclado Útiles (VS Code & Terminal)

| Atajo | Función |
| :--- | :--- |
| **`Ctrl + S`** | **Guardar archivo:** Guarda los cambios en el disco duro para que `dotnet run` pueda leer las modificaciones. |
| **`Ctrl + Ñ`** | **Abrir / Ocultar la terminal:** Abre la consola integrada en VS Code para ejecutar comandos rápidamente. |
| **`Ctrl + K` + `Ctrl + C`** | Comentar bloque de código seleccionado (añade `//`). |
| **`Ctrl + K` + `Ctrl + U`** | Descomentar bloque de código seleccionado. |

---

## 8. Código Completo de Ejemplo Practicado

```csharp
/* Console: Es la clase que representa la ventana de la consola/terminal. 
   WriteLine: Imprime lo que se le pase dentro y realiza un salto de línea. */

Console.WriteLine("Hello, World!");

// Impresión simple
Console.WriteLine("Django");

// Declaración con var e impresión de variable
var edad = 30;
Console.WriteLine(edad);

// Concatenación clásica (+)
Console.WriteLine("Mi edad es: " + edad);

// Interpolación de cadenas ($)
var cancionFavorita = "Cinnamon Girl";
Console.WriteLine($"Mi canción favorita es {cancionFavorita}");

// Múltiples variables combinadas en concatenación
var cantante = "Lana del rey";
var duracion = 300;
Console.WriteLine("Mi canción favorita es " + cancionFavorita + " de " + cantante + " y dura " + duracion + " segundos");

// Declaración explícita de variables y uso de texto multilínea ($@)
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
```