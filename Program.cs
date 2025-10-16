using ovningsuppgift_automatiskt_namn_och_mejl;

var person = new Person("Kalle", "Anka");
PrintPerson(person);

person.FirstName = "Kajsa";
PrintPerson(person);

person.FirstName = "Jan";
person.LastName = "Långben";
person.Domain = "spoonerville.goof";
PrintPerson(person);

Console.WriteLine();
Console.Write("Ange en mejl: ");
Console.ForegroundColor = ConsoleColor.Cyan;
person.Email = Console.ReadLine() ?? "";
Console.ResetColor();
PrintPerson(person);

static void PrintPerson(Person person)
{
    Console.Write($"{person.FirstName} {person.LastName} har följande mejl: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(person.Email);
    Console.ResetColor();
}
