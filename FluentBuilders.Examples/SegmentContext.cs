using System;
using FluentBuilders.Examples.Models;

namespace FluentBuilders.Examples
{
    public sealed class SegmentContext : FluentContext<Segment>
    {
        public SegmentContext DepartingFrom(string departureStation)
        {
            this.AddBuilderFunction(segment =>
            {
                segment.DepartureStation = departureStation;
                return segment;
            });

            return this;
        }

        public SegmentContext DepartingOn(int year, int month, int day, int hour, int minute)
        {
            this.AddBuilderFunction(segment =>
            {
                segment.DepartureTime = new DateTime(year, month, day, hour, minute, 0);
                return segment;
            });

            return this;
        }

        public SegmentContext ArrivingAt(string departureStation)
        {
            this.AddBuilderFunction(segment =>
            {
                segment.ArrivalStation = departureStation;
                return segment;
            });
            
            return this;
        }

        public SegmentContext ArrivingOn(int year, int month, int day, int hour, int minute)
        {
            this.AddBuilderFunction(segment =>
            {
                segment.ArrivalTime = new DateTime(year, month, day, hour, minute, 0);
                return segment;
            });
            
            return this;
        }
    }
}