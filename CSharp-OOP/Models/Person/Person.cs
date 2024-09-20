namespace CSharp_OOP.Models.Person;

public class Person
{
    private string fName = string.Empty;
    private string lName = string.Empty;
    private int age;
    private double height;
    private double weight;
    
    public const int MIN_AGE = 1;
    public const int MIN_FNAME_LENGTH = 2;
    public const int MAX_FNAME_LENGTH = 10;
    
    public const int MIN_LNAME_LENGTH = 3;
    public const int MAX_LNAME_LENGTH = 15;

    public Person(string fName, string lName, int age = 1, double height = 0.0, double weight = 0.0)
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
            if (value.Length < MIN_FNAME_LENGTH || value.Length > MAX_FNAME_LENGTH)
                throw new ArgumentException("First name must be between 2 and 10 characters long.");

            fName = value;
        }
    }

    public string LName
    {
        get => lName;
        set
        {
            if (value.Length < MIN_LNAME_LENGTH || value.Length > MAX_LNAME_LENGTH)
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
            if (value < MIN_AGE)
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