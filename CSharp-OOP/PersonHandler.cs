namespace CSharp_OOP;

public static class PersonHandler
{
    public static Person CreatePerson(string fname, string lname, int age = 0, double height = 0.0, double weight = 0.0)
    {
        return new Person(fname, lname, age, height, weight);
    }

    public static void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }

    public static void SetFName(Person pers, string fname)
    {
        pers.FName = fname;
    }

    public static void SetLName(Person pers, string lname)
    {
        pers.LName = lname;
    }

    public static void SetHeight(Person pers, double height)
    {
        pers.Height = height;
    }

    public static void SetWeight(Person pers, double weight)
    {
        pers.Weight = weight;
    }
}