namespace CSharp_OOP.Models.Animals;

public class Pelican : Bird
{
    public double BeakLength { get; set; }

    public Pelican(string name, int age, int weight, double wingSpan, double beakLength) : base(name, age, weight,
        wingSpan)
    {
        BeakLength = beakLength;
    }

    public override string Stats()
    {
        return base.Stats() + $",\n{nameof(BeakLength)}: {BeakLength}";
    }
}