// See https://aka.ms/new-console-template for more information

string[] myArray = new string[] { "Doug", "Mike", "Janet", "Winnie" };

for (int i =0; i < myArray.Length; i++ )
{
    Console.WriteLine($"Hello, {myArray[i]}!");
}

foreach (string name in myArray)
{
    Console.WriteLine($"Good bye, {name}!");
}