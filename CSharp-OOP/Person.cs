namespace CSharp_OOP;

public class Person
{
    private string fName = string.Empty;
    private string lName = string.Empty;
    private int age;
    private double height;
    private double weight;

    public Person(string fName, string lName, int age = 0, double height = 0.0, double weight = 0.0)
    {
        FName = fName;
        LName = lName;
        Age = age;
        Height = height;
        Weight = weight;
    }


    public string FName
    {
        get => fName;
        set
        {
            if (value.Length < 2 || value.Length > 10)
                throw new ArgumentException("First name must be between 2 and 10 characters long.");

            fName = value;
        }
    }

    public string LName
    {
        get => lName;
        set
        {
            if (value.Length < 3 || value.Length > 15)
            {
                throw new ArgumentException("Last name must be between 3 and 15 characters long.");
            }

            lName = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be larger than 0 .");
            }

            age = value;
        }
    }

    public double Height
    {
        get => height;
        set => height = value;
    }

    public double Weight
    {
        get => weight;
        set => weight = value;
    }
}