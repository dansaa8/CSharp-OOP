// See https://aka.ms/new-console-template for more information

using CSharp_OOP;

try
{
    Person p1 = PersonHandler.CreatePerson("Kalle", "Karlsson");
    Person p2 = PersonHandler.CreatePerson("Lasse", "Larsson ");
}
catch (ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}