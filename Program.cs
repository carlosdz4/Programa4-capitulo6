// See https://aka.ms/new-console-template for more information
using Programa4_capitulo6;

Persona personaObj  = new Persona() { Edad = 18 , Nombre = "Carlos" };

Console.WriteLine($"{personaObj.Nombre} tiene {personaObj.Edad} de edad");

Empleado empleadoObj = new Empleado() { Edad = 20 , Nombre = "Maria" , Sueldo= 50000 };

Console.WriteLine($"\nLa empleada {empleadoObj.Nombre} tiene {empleadoObj.Edad} años con un sueldo { empleadoObj.Sueldo} pesos ");

