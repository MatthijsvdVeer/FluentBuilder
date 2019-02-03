using System;

namespace FluentBuilders.Examples.Models
{
    public class Segment
    {
        public string ArrivalStation { get; set; }

        public string DepartureStation { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }
    }
}