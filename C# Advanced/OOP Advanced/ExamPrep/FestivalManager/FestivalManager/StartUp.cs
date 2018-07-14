namespace FestivalManager
{
    using System.Collections.Generic;
    using Core;
    using Core.Controllers;
    using Core.Controllers.Contracts;
    using Core.IO;
    using Core.IO.Contracts;
    using Entities;
    using Entities.Contracts;
    using FestivalManager.Entities.Factories;
    using FestivalManager.Entities.Factories.Contracts;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            IWriter writer = new CustomWriter();
            IReader reader = new StringReader();
            ISetFactory setFactory = new SetFactory();
            ISongFactory songFactory = new SongFactory();
            IPerformerFactory performerFactory = new PerformerFactory();
            IInstrumentFactory instrumentFactory = new InstrumentFactory();
            IStage stage = new Stage();
            IFestivalController festivalController = new FestivalController(stage, setFactory, songFactory, performerFactory, instrumentFactory);
            ISetController setController = new SetController(stage);

            var engine = new Engine(reader, writer, festivalController, setController);

            engine.Run();
        }
    }
}