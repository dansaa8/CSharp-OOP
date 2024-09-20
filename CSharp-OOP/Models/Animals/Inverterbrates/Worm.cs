namespace CSharp_OOP.Models.Animals.Inverterbrates;

public class Worm : Animal
{
    public bool IsPoisonous { get; set; }

    public Worm(string name, int age, int weight, bool isPoisonous) : base(name, age, weight)
    {
        IsPoisonous = isPoisonous;
    }

    public override void DoSound()
    {
        Console.WriteLine("TSSSSSSSSSSSS");
    }
}