namespace CSharp_OOP.Models.Animals;

public class Swan : Bird
{
    public double SwimSpeed { get; set; }

    public Swan(string name, int age, int weight, double wingSpan, double swimSpeed) : base(name, age, weight, wingSpan)
    {
        SwimSpeed = swimSpeed;
    }

    public override string Stats()
    {
        return base.Stats() + $",\n{nameof(SwimSpeed)}: {SwimSpeed}";
    }
}