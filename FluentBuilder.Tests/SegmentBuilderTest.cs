using System;
using FluentBuilders.Examples;
using Xunit;

namespace FluentBuilder.Tests
{
    public class SegmentBuilderTest
    {
        [Fact]
        public void CanCreateSegment()
        {
            var segment = SegmentBuilder.Create(s => s);

            Assert.NotNull(segment);
        }

        [Fact]
        public void CanCreateCompleteSegment()
        {
            var segment = SegmentBuilder.Create(s =>
                s.DepartingFrom("AMS").DepartingOn(2019, 03, 08, 15, 20).ArrivingAt("BCN")
                    .ArrivingOn(2019, 03, 08, 17, 30));

            Assert.Equal("AMS", segment.DepartureStation);
            Assert.Equal("BCN", segment.ArrivalStation);
            Assert.Equal(new DateTime(2019, 03, 08, 15, 20, 00), segment.DepartureTime);
            Assert.Equal(new DateTime(2019, 03, 08, 17, 30, 00), segment.ArrivalTime);
        }
    }
}
