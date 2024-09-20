namespace CSharp_OOP.Models.Animals.Mammals;

public class Wolf : Animal
{
    public bool IsAlone { get; set; }

    public Wolf(string name, int age, int weight, bool isAlone) : base(name, age, weight)
    {
        IsAlone = isAlone;
    }

    public override void DoSound()
    {
        Console.WriteLine("AWOOOOOOOOOOOOOOOOOO");
    }
}