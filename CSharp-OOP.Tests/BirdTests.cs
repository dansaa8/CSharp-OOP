using CSharp_OOP.Models.Animals;

namespace CSharp_OOP.Tests;

public class BirdTests
{
    [Fact]
    public void BirdStats()
    {
        //Arrange
        Bird bird = new Bird("Peter", 5, 25, 2);

        //Act
        string expectedStats = "Name: Peter,\nAge: 5,\nWeight: 25,\nWingSpan: 2";


        //Assert
        Assert.Equal(expectedStats, bird.Stats());
    }

    [Fact]
    public void PelicanStats()
    {
        //Arrange
        Pelican pelican = new Pelican("Luke", 7, 30, 1.5, 1);
        
        //Act
        string expectedStats = "Name: Luke,\nAge: 7,\nWeight: 30,\nWingSpan: 1,5,\nBeakLength: 1";
        
        //Assert
        Assert.Equal(expectedStats, pelican.Stats());
        
    }
}