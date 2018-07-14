// REMOVE any "using" statements, which start with "Travel." BEFORE SUBMITTING

namespace Travel.Tests
{
    using NUnit.Framework;
    using System.Linq;
    using System.Reflection;
    using Travel.Core.Controllers;
    using Travel.Core.Controllers.Contracts;
    using Travel.Entities;
    using Travel.Entities.Airplanes;
    using Travel.Entities.Contracts;

    [TestFixture]
    public class FlightControllerTests
    {
        IFlightController flightController;
        Airport airport;

        [SetUp]
        public void TestInit()
        {
            this.airport = new Airport();
            this.flightController = new FlightController(this.airport);
        }

        [Test]
        public void TestValidConsrtuctor()
        {
            Airport airport = new Airport();
            FlightController flightController = new FlightController(airport);
            FieldInfo field = typeof(FlightController).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(fi => fi.FieldType == typeof(IAirport));
            Airport actualAirport = (Airport)field.GetValue(flightController);
            Assert.That(actualAirport, Is.EqualTo(airport));
        }
        [Test]
        public void ConstructorShouldInitializeWithEmptyAirport()
        {
            Assert.DoesNotThrow(() => new FlightController(this.airport),
                                "FlightController was not initialized with an empty airport!");
        }

        [Test]
        public void IsEjectingPassengersWhenOverbooked()
        {
            
            int i = 0;
            Trip trip = new Trip("source", "destination", new LightAirplane());
            
            trip.Airplane.AddPassenger(new Passenger(i++.ToString()));
            trip.Airplane.AddPassenger(new Passenger(i++.ToString()));
            trip.Airplane.AddPassenger(new Passenger(i++.ToString()));
            trip.Airplane.AddPassenger(new Passenger(i++.ToString()));
            trip.Airplane.AddPassenger(new Passenger(i++.ToString()));
            trip.Airplane.AddPassenger(new Passenger(i++.ToString()));
            flightController.TakeOff();
                        
            Assert.AreEqual(trip.Airplane.Seats, trip.Airplane.Passengers.Count());
        }
    }
}
