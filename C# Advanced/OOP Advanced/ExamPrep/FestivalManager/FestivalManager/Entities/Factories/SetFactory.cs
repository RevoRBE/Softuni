using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FestivalManager.Entities.Factories
{
	using Contracts;
	using Entities.Contracts;
	using Sets;

	public class SetFactory : ISetFactory
	{
		public ISet CreateSet(string name, string type)
		{
            Assembly assembly = Assembly.GetCallingAssembly();

            Type setType = assembly.GetTypes().FirstOrDefault(t => t.Name == type);
            var ctors = setType.GetConstructors();
            //Set set = (Set)ctors[0].Invoke(new object[] { name });
            return (ISet)Activator.CreateInstance(setType, name);
		}
	}
}
