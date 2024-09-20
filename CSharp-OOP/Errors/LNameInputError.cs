using CSharp_OOP.Models.Person;

namespace CSharp_OOP.Errors;

public class LNameInputError : UserError
{
    public override string UEMessage() =>
        "You tried to enter a lastname that didn't meet the length requirement. " +
        $"Enter a first name that is between {Person.MIN_LNAME_LENGTH} and {Person.MAX_LNAME_LENGTH}.";
}