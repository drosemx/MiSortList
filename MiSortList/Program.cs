using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<string> dinosaurs = new List<string>();

        dinosaurs.Add("Pachycephalosaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Deinonychus");

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nSort");
        dinosaurs.Sort();

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nBinarySearch and Insert \"Coelophysis\":");
        int index = dinosaurs.BinarySearch("Coelophysis");
        if (index < 0)
        {
            dinosaurs.Insert(~index, "Coelophysis");
        }

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nBinarySearch and Insert \"Tyrannosaurus\":");
        index = dinosaurs.BinarySearch("Tyrannosaurus");
        if (index < 0)
        {
            dinosaurs.Insert(~index, "Tyrannosaurus");
        }

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
        Console.ReadKey();
    }
}






























/* 
  
Este método utiliza el comparador predeterminado Comparer(Of T).Default para el tipo T con el fin de determinar el orden de los elementos de la lista.La propiedad Comparer(Of T).Default comprueba si el tipo T implementa la interfaz genérica IComparable(Of T) y, si está disponible, utiliza esa implementación.En caso contrario, Comparer(Of T).Default comprueba si el tipo T implementa la interfaz IComparable.Si el tipo T no implementa ninguna de las dos interfaces, Comparer(Of T).Default produce una excepción InvalidOperationException.
Este método utiliza Array.Sort, que utiliza a su vez el algoritmo QuickSort.Esta implementación realiza una ordenación inestable; es decir, si hay dos elementos iguales, es posible que no se mantenga su orden.Por el contrario, una ordenación estable conserva el orden de los elementos que son iguales.
Este método suele ser una operación O(n log n), donde n es Count; aunque en el peor caso es una operación O(n ^ 2).
  
  
  
This code example produces the following output:

Pachycephalosaurus
Amargasaurus
Mamenchisaurus
Deinonychus

Sort

Amargasaurus
Deinonychus
Mamenchisaurus
Pachycephalosaurus

BinarySearch and Insert "Coelophysis":

Amargasaurus
Coelophysis
Deinonychus
Mamenchisaurus
Pachycephalosaurus

BinarySearch and Insert "Tyrannosaurus":

Amargasaurus
Coelophysis
Deinonychus
Mamenchisaurus
Pachycephalosaurus
Tyrannosaurus
 URL:ttp://msdn.microsoft.com/es-es/library/b0zbh7b6.aspx
  
  
 */
