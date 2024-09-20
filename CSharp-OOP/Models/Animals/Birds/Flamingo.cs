namespace CSharp_OOP.Models.Animals;

public class Flamingo : Bird
{
    public double LegLength { get; set; }

    public Flamingo(string name, int age, int weight, double wingSpan, double legLength) : base(name, age, weight,
        wingSpan)
    {
        LegLength = legLength;
    }
}