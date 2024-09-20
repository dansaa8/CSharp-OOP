namespace CSharp_OOP.Models.Animals.Mammals;

public class Horse : Animal
{
    public double WithersHeight { get; set; }

    public Horse(string name, int age, int weight, double withersHeight) : base(name, age, weight)
    {
        WithersHeight = withersHeight;
    }

    public override string Stats()
    {
        return base.Stats() + $"\n{nameof(WithersHeight)}: {WithersHeight}";
    }

    public override void DoSound()
    {
        Console.WriteLine("I-HA-HA-HA-HA");
    }
}