using System;
using System.Collections.Generic;
using FluentBuilders.Examples.Models;

namespace FluentBuilders.Examples
{
    public sealed class JourneyContext : FluentContext<Journey>
    {
        public JourneyContext WithSegment(Func<SegmentContext, SegmentContext> factory)
        {
            this.AddBuilderFunction(journey =>
            {
                var segment = factory.Invoke(new SegmentContext()).Build();
                if (journey.Segments == null)
                {
                    journey.Segments = new List<Segment>();
                }

                journey.Segments.Add(segment);
                return journey;
            });
            
            return this;
        }

        public JourneyContext WithPassenger(Func<PassengerContext, PassengerContext> factory)
        {
            this.AddBuilderFunction(journey =>
            {
                var passenger = factory.Invoke(new PassengerContext()).Build();
                if (journey.Passengers == null)
                {
                    journey.Passengers = new List<Passenger>();
                }

                journey.Passengers.Add(passenger);
                return journey;
            });

            return this;
        }
    }
}