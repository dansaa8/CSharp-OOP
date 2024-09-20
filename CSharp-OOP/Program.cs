#region Frågor

// Fråga: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
//        attribut, i vilken klass bör vi lägga det?
// Svar: I Bird.cs

// Fråga: Om alla djur behöver det nya attributet, vart skulle man lägga det då? 
// Svar: I Animal.cs

// Fråga: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
// Svar: Det fungerar inte eftersom att horse inte är en direkt eller indirekt subclass till dog.
//       De har ingen direkt koppling till varandra.

// Fråga: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
// Svar: Om vi syftar på enbart alla djur, men även Humanoids (som har något arv från djur) så hade List<Animal>
//       fungerat bra eftersom att Animal är base classen som alla Animals ärver från och därmed kan tolkas som animal.

#endregion


using CSharp_OOP.Errors;
using CSharp_OOP.Models.Animals;
using CSharp_OOP.Models.Animals.Inverterbrates;
using CSharp_OOP.Models.Animals.Mammals;
using CSharp_OOP.Models.Humanoids;
using CSharp_OOP.Models.Person;

#region Person

Person? p1 = null;
Person? p2 = null;
try
{
    p1 = PersonHandler.CreatePerson("Lasse", "Larsson ");
    p2 = PersonHandler.CreatePerson("Kalle", "Karlsson");
}
catch (ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}

if (p1 != null)
{
    Console.WriteLine(p1.FName);
}

#endregion


#region Errors

List<UserError> errors = new List<UserError>
{
    new NumericInputError(),
    new TextInputError(),
    new FNameInputError(),
    new LNameInputError(),
    new AgeInputError(),
};

foreach (UserError error in errors)
{
    Console.WriteLine(error.UEMessage());
}

#endregion


#region Animals

List<Animal> animals = new List<Animal>
{
    new Pelican("Petra", 16, 12, 1.8, 0.5),
    new Worm("Max", 1, 1, false),
    new Wolfman("Wolfgang", 34, 72, true),
    new Dog("Jack", 3, 8, "Jack Russell"),
    new Dog("Chihi", 6, 2, "Chihuahua")
};

foreach (Animal animal in animals)
{
    Console.Write($"\n{animal.GetType().Name} makes the sound: ");
    animal.DoSound();

    if (animal is IPerson iPerson)
    {
        Console.Write("and says: ");
        iPerson.Talk();
    }

    // Det som händer här är att vi kallar på Stats() metoden som varje subclass till Animal har ärvt.
    // Stats() metoden är virtual vilket betyder att den kan overridas. Så i varje class som direkt eller
    // indirekt ärver från Animal så overridar vi Stats() metoden, genom att lägga till en ny implementation. 
    // Den nya implementationen av Stats() kallar på den närmast ärvda implementationen utav Stats() innan
    // de nya properties som finns i subclassen läggs till i den nya Stats() implementationen.
    // På så sätt så får vi alltid propertiesen utskrivna från basklassen utan att behöva skriva det från scratch
    // varje gång.
    Console.WriteLine(animal.Stats());
}

// endast hundar
foreach (Animal animal in animals)
{
    // Fungerar ej:
    // animal.DogSpecificMethod();
    
    // Anledningen till detta är för att när en class tolkas som Animal, så har den inte kännedom om 
    // sin subclass funktionalitet. Motsatt riktning fungerar dock.
    
    // Därmed så kan man kolla Om animal kan tolkas som Dog,
    // genom nedanstående if-sats. Om nuvarande animal i listan 
    // Kan tolkas som dog, så typecastar vi den till Dog-type och
    // refereras genom variabeln dog.
    if (animal is Dog dog)
    {
        Console.WriteLine(animal.Stats());
        
        // När animal har blivit typecastad till Dog-type, så kan vi komma åt specifika class-medlemmar
        // som inte Animal typen kände till.
        dog.DogSpecificMethod();
    }
}

#endregion

#region Dogs

List<Dog> dogs = new List<Dog>
{
    new Dog("Jack", 3, 8, "Jack Russell"),
    new Dog("Chihi", 6, 2, "Chihuaua"),
    new Dog("Rotten", 9, 52, "Rottweiler")
};

// Fungerar inte:
// dogs.Add(new Horse()); 

#endregion