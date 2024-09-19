// See https://aka.ms/new-console-template for more information

using CSharp_OOP;
using CSharp_OOP.Errors;

Person? p1 = null;
Person? p2 = null;
try
{
    p1 = PersonHandler.CreatePerson("Lasse", "Larsson ");
    p2 = PersonHandler.CreatePerson("Kalle", "Karlsson");
}
catch (ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}

if (p1 != null)
{
    Console.WriteLine(p1.FName);
}

List<UserError> errors = new List<UserError>()
{
    new NumericInputError(),
    new TextInputError(),
    new FNameInputError(),
    new LNameInputError(),
    new AgeInputError(),
};

foreach (UserError error in errors)
{
    Console.WriteLine(error.UEMessage());
}