namespace CSharp_OOP.Models.Animals.Mammals;

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, int weight, string breed) : base(name, age, weight)
    {
        Breed = breed;
    }

    public override string Stats()
    {
        return base.Stats() + $",\n{nameof(Breed)}: {Breed}";
    }

    public override void DoSound()
    {
        Console.WriteLine("Woff woff");
    }

    public void DogSpecificMethod()
    {
        Console.WriteLine("ONLY FOR DOGS!");
    }
}