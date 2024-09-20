using CSharp_OOP.Models.Person;

namespace CSharp_OOP.Errors;

public class FNameInputError : UserError
{
    public override string UEMessage() =>
        "You tried to enter a firstname that didn't meet the length requirement. " +
        $"Enter a first name that is between {Person.MIN_FNAME_LENGTH} and {Person.MAX_FNAME_LENGTH}.";
}