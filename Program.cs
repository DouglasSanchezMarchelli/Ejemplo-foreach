using System;
using System.Collections.Generic;

namespace EjemploForeach
{
class Program
{
 static void Main(string[] args)
 {
 Console.WriteLine("Ejemplo de Uso de foreach");
 Console.WriteLine("_________________________");

  // Crear una lista de números
  List<int> numeros = new List<int> {10,20,30,40,50 };

 // Usar foreach para recorrer la lista
  foreach (int numero in numeros)
  {
  Console.WriteLine(numero);
  }
  }
 }
}
