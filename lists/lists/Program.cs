// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

string[] myArray = new string[] { "Doug", "Mike", "Janet", "Matt" };

foreach (string  name in myArray)
{
    Console.WriteLine(name);
}

myArray[0] = "Tim";

foreach (string name in myArray)
{
    Console.WriteLine(name);
}

List<string > myList = new List<string>();
myList.Add("Rocket");
myList.Add("Scout");
foreach (string elements in myList)
{
    Console.WriteLine(elements);
}

Console.WriteLine(myList[1]);

Console.WriteLine(myList.Count());

myList.Insert(1, "Hoover");
foreach(string element in myList)
    Console.WriteLine(element);

myList.Remove("Scout");
foreach (string element in myList)
    Console.WriteLine(element);

myList.RemoveAt(1);
foreach (string element in myList)
    Console.WriteLine(element);
