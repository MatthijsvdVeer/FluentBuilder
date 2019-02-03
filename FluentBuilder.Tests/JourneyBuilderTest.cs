using FluentBuilders.Examples;
using FluentBuilders.Examples.Models;
using Xunit;

namespace FluentBuilder.Tests
{
    public class JourneyBuilderTest
    {

        [Fact]
        public void CanBuildJourney()
        {
            var journey = JourneyBuilder.Create(j => j);

            Assert.NotNull(journey);
        }

        [Fact]
        public void CanAddPassenger()
        {
            var journey = JourneyBuilder.Create(j => j.WithPassenger(p => p));

            Assert.Equal(1, journey.Passengers.Count);
        }

        [Fact]
        public void CanAddMultiplePassengers()
        {
            var journey = JourneyBuilder.Create(j => j.WithPassenger(p => p).WithPassenger(p => p).WithPassenger(p => p));

            Assert.Equal(3, journey.Passengers.Count);
        }

        [Fact]
        public void CanAddSegment()
        {
            var journey = JourneyBuilder.Create(j => j.WithSegment(s => s));

            Assert.Equal(1, journey.Segments.Count);
        }

        [Fact]
        public void CanAddMultipleSegments()
        {
            var journey = JourneyBuilder.Create(j => j.WithSegment(s => s).WithSegment(s => s).WithSegment(s => s));

            Assert.Equal(3, journey.Segments.Count);
        }

        [Fact]
        public void CanBuildCompleteJourney()
        {
            JourneyBuilder.Create(j =>
                j.WithPassenger(p =>
                        p.WithName("Matthijs", "van der Veer").BornOn(1989, 03, 25).OfType(PassengerType.Adult))
                    .WithSegment(s =>
                        s.DepartingFrom("AMS").DepartingOn(2019, 03, 08, 15, 20).ArrivingAt("BCN")
                            .ArrivingOn(2019, 03, 08, 17, 30))
                    .WithSegment(s =>
                        s.DepartingFrom("BCN").DepartingOn(2019, 03, 09, 14, 10).ArrivingAt("AMS")
                            .ArrivingOn(2019, 03, 09, 16, 20)));
        }
    }
}
