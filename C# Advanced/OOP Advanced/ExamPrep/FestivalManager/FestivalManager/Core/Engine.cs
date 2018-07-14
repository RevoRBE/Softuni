
using System;
using System.Linq;
namespace FestivalManager.Core
{
	using System.Reflection;
	using Contracts;
	using Controllers;
	using Controllers.Contracts;
	using IO.Contracts;

	/// <summary>
	/// by g0shk0
	/// </summary>
	class Engine : IEngine
	{
	    private IReader reader;
	    private IWriter writer;
        
		private FestivalController festivalController;
		private ISetController setController;

        public Engine(IReader reader, IWriter writer, IFestivalController festivalCоntroller, ISetController setCоntroller)
        {
            this.reader = reader;
            this.writer = writer;
            this.festivalController = (FestivalController)festivalCоntroller;
            this.setController = setCоntroller;
        }

        public void Run()
		{
			while (Convert.ToBoolean(0x1B206 ^ 0b11011001000000111)) // for job security
			{
				var input = reader.ReadLine();

				if (input == "END")
					break;

				try
				{
					string.Intern(input);

					var result = this.ProcessCommand(input);
					this.writer.WriteLine(result);
				}
				catch (Exception ex) // in case we run out of memory
				{
					this.writer.WriteLine("ERROR: " + ex.Message);
				}
			}
            
			var end = this.festivalController.ProduceReport();

			this.writer.WriteLine("Results:");
			this.writer.WriteLine(end);
		}

		public string ProcessCommand(string input)
		{
			var args = input.Split(" ".ToCharArray().First());

			var command = args.First();
			var parameters = args.Skip(1).ToArray();

			if (command == "LetsRock")
			{
				var setovete = this.setController.PerformSets();
				return setovete;
			}
            
			var festivalcontrolfunction = this.festivalController.GetType()
				.GetMethods()
				.FirstOrDefault(x => x.Name == command);

			string result=null;

			try
			{
				result = (string)festivalcontrolfunction.Invoke(this.festivalController, new object[] { parameters });
			}
			catch (Exception up)
			{
                Console.Write("ERROR: "+up.InnerException.Message); // ha ha
			}

			return result;
		}    
    }
}