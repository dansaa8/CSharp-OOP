namespace CSharp_OOP.Models.Animals.Mammals;

public class Hedgehog : Animal
{
    public int NrOfSpikes { get; set; }

    public Hedgehog(string name, int age, int weight, int nrOfSpikes) : base(name, age, weight)
    {
        NrOfSpikes = nrOfSpikes;
    }

    public override string Stats()
    {
        return base.Stats() + $",\n{nameof(NrOfSpikes)}: {NrOfSpikes}";
    }

    public override void DoSound()
    {
        Console.WriteLine("Hey");
    }
}