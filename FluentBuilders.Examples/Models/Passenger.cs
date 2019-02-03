using System;

namespace FluentBuilders.Examples.Models
{
    public class Passenger
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public PassengerType PassengerType { get; set; }
    }
}