using CSharp_OOP.Models.Animals.Mammals;
using CSharp_OOP.Models.Person;

namespace CSharp_OOP.Models.Humanoids;

public class Wolfman : Wolf, IPerson
{
    public Wolfman(string name, int age, int weight, bool isAlone) : base(name, age, weight, isAlone)
    {
    }

    public void Talk()
    {
        Console.WriteLine("AWOOO, it's good to be alive!");
    }
}