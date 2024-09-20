namespace CSharp_OOP.Models.Animals.Mammals;

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, int weight, string breed) : base(name, age, weight)
    {
        Breed = breed;
    }


    public override void DoSound()
    {
        Console.WriteLine("Woff woff");
    }
}