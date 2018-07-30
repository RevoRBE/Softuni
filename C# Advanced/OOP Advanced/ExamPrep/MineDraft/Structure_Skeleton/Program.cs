using Minedraft.Core;
using Minedraft.Entities;
using Minedraft.IO;

public class Program
{
    public static void Main(string[] args)
    {
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        IHarvesterFactory harvesterFactory = new HarvesterFactory();
        IProviderFactory providerFactory = new ProviderFactory();
        IEnergyRepository energyRepository = new EnergyRepository();
        IHarvesterController harvesterController = new HarvesterController(harvesterFactory, energyRepository);
        IProviderController providerController = new ProviderController(providerFactory, energyRepository);
        ICommandInterpreter interpreter = new CommandInterpreter(harvesterController, providerController);
        Engine engine = new Engine(interpreter, reader, writer);
        engine.Run();
    }
}