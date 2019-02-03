using System;
using FluentBuilders.Examples.Models;

namespace FluentBuilders.Examples
{
    public class PassengerContext : FluentContext<Passenger>
    {
        public PassengerContext WithName(string firstName, string lastName)
        {
            this.AddBuilderFunction(passenger =>
            {
                passenger.FirstName = firstName;
                passenger.LastName = lastName;
                return passenger;
            });

            return this;
        }

        public PassengerContext BornOn(int year, int month, int day)
        {
            this.AddBuilderFunction(passenger =>
            {
                passenger.Birthdate = new DateTime(year, month, day);
                return passenger;
            });

            return this;
        }

        public PassengerContext OfType(PassengerType passengerType)
        {
            this.AddBuilderFunction(passenger =>
            {
                passenger.PassengerType = passengerType;
                return passenger;
            });

            return this;
        }
    }
}
