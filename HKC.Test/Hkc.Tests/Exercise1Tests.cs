using FluentAssertions;
using HKC.Exercises;
using Xunit;

namespace HKC.Tests
{
    public class Exercise1Tests
    {
        [Fact]
        public void WithValidNamesOnly_Should_Return_True()
        {
            var names = new[] { "Bob", "Martin", "Greg" };

            var result = Exercise1.AreAllNamesValid(names);

            result.Should().Be(true);
        }

        [Fact]
        public void WithLowerCaseName_Should_Return_false()
        {
            var names = new[] { "Bob", "martin", "Greg" };

            var result = Exercise1.AreAllNamesValid(names);

            result.Should().Be(false);
        }

        [Fact]
        public void AreAllNamesValid_Refactored_Should_Return_True()
        {
            var names = new[] { "Bob", "Martin", "Greg" };

            var result = Exercise1.AreAllNamesValid_Refactored(names);

            result.Should().Be(true);
        }

        [Fact]
        public void AreAllNamesValid_Refactored_Should_Return_false()
        {
            var names = new[] { "Bob", "martin", "Greg" };

            var result = Exercise1.AreAllNamesValid_Refactored(names);

            result.Should().Be(false);
        }
    }
}