namespace CSharp_OOP.Errors;

public class NumericInputError : UserError
{
    public override string UEMessage() =>
        "You tried to use a numeric input in a text only field. This fired an error!";
}