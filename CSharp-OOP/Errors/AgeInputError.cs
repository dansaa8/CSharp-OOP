using CSharp_OOP.Models.Person;

namespace CSharp_OOP.Errors;

public class AgeInputError : UserError
{
    public override string UEMessage() =>
        $"You tried to enter an age that was too low. Age needs to be {Person.MIN_AGE} more.";
}