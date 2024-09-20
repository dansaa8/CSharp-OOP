
namespace CSharp_OOP.Models.Animals;

public class Bird : Animal
{
    public double WingSpan { get; set; }

    public Bird(string name, int age, int weight, double wingSpan) : base(name, age, weight)
    {
        WingSpan = wingSpan;
    }

    public override void DoSound()
    {
        Console.WriteLine("KRAWWK");
    }
}