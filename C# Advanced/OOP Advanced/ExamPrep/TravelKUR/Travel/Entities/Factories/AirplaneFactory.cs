﻿namespace Travel.Entities.Factories
{
	using Contracts;
	using Airplanes.Contracts;
    using System.Reflection;
    using System;
    using System.Linq;
    using Travel.Entities.Items.Contracts;

    public class AirplaneFactory : IAirplaneFactory
	{
		public IAirplane CreateAirplane(string type)
		{
			var airplaneType = Assembly.GetCallingAssembly().GetTypes()
				.Where(t => typeof(IAirplane).IsAssignableFrom(t))
				.FirstOrDefault(t => t.Name == type);

			var item = (IAirplane)Activator.CreateInstance(airplaneType);

			return item;
		}
	}
}