// See https://aka.ms/new-console-template for more information
using System.Drawing;

List<string> dinosaurs = new List<string>();

Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

dinosaurs.Add("Tyrannosaurus");
dinosaurs.Add("Amargasaurus");
dinosaurs.Add("Mamenchisaurus");
dinosaurs.Add("Deinonychus");
dinosaurs.Add("Compsognathus");
Console.WriteLine();
foreach (string dinosaur in dinosaurs)
{
    Console.WriteLine(dinosaur);
}