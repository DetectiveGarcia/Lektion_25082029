List<string> names = [];

//WriteLine för input
//ReadLine för output

Console.Write("Ange ett namn: ");
names.Add(Console.ReadLine()!);

Console.WriteLine("Namn i listan: ");
foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("Tryck på valfri tangent för att avsluta...");
Console.ReadKey();