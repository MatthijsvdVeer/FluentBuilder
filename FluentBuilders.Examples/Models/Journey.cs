using System.Collections.Generic;

namespace FluentBuilders.Examples.Models
{
    public class Journey
    {
        public IList<Passenger> Passengers { get; set; }

        public IList<Segment> Segments { get; set; }
    }
}