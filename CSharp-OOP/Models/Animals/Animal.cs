namespace CSharp_OOP.Models.Animals;

public abstract class Animal
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }

    public Animal(string name, int age, int weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }


    public abstract void DoSound();
}