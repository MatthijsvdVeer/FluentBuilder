using System;
using FluentBuilders.Examples.Models;
using FluentBuilders.Examples;
using Xunit;

namespace FluentBuilder.Tests
{
    public class PassengerBuilderTest
    {
        [Fact]
        public void CanBuildPassenger()
        {
            var passenger = PassengerBuilder.Create(p => p);

            Assert.NotNull(passenger);
        }

        [Fact]
        public void CanBuildCompletePassenger()
        {
            var passenger = PassengerBuilder.Create(p =>
                p.WithName("Matthijs", "van der Veer").BornOn(1989, 03, 25).OfType(PassengerType.Adult));

            Assert.Equal(new DateTime(1989, 03, 25), passenger.Birthdate);
            Assert.Equal("Matthijs", passenger.FirstName);
            Assert.Equal("van der Veer", passenger.LastName);
            Assert.Equal(PassengerType.Adult, passenger.PassengerType);
        }
    }
}
