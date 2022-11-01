using FluentAssertions;
using HKC.Exercises;
using Xunit;
using static HKC.Exercises.Exercise2;

namespace HKC.Tests
{
    public class Exercise2Tests
    {
        [Fact]
        public void WithNoCats_Should_Return_False()
        {
            var pets = new[]
            {
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f)
            };

            var result = Exercise2.AreThereAnyBigCats(pets);

            result.Should().Be(false);
        }

        [Fact]
        public void WithBigCats_Should_Return_True()
        {
            var pets = new[]
            {
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Paws", PetType.Cat, 1f),
                new Pet(8, "Big Foot", PetType.Cat, 2.1f)
            };

            var result = Exercise2.AreThereAnyBigCats(pets);

            result.Should().Be(true);
        }
    }
}