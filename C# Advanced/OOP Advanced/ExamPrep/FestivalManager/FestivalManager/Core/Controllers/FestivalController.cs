namespace FestivalManager.Core.Controllers
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Contracts;
    using Entities.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Factories.Contracts;
    using FestivalManager.Entities.Sets;

    public class FestivalController : IFestivalController
    {
        //private const string TimeFormat = "mm\\:ss";
        private const string TimeFormatLong = "{0:D2}:{1:D2}";
        //private const string TimeFormatThreeDimensional = "{0:3D}:{1:3D}";

        private readonly IStage stage;

        private ISetFactory setFactory;
        private ISongFactory songFactory;
        private IPerformerFactory performerFactory;
        private IInstrumentFactory instrumentFactory;


        public FestivalController(IStage stage, ISetFactory setFactory, ISongFactory songFactory, IPerformerFactory performerFactory, IInstrumentFactory instrumentFactory)
        {
            this.stage = stage;
            this.setFactory = setFactory;
            this.songFactory = songFactory;
            this.performerFactory = performerFactory;
            this.instrumentFactory = instrumentFactory;
        }

        public string ProduceReport()
        {
            var result = string.Empty;

            var totalFestivalLength = new TimeSpan(this.stage.Sets.Sum(s => s.ActualDuration.Ticks));
            var time2str = String.Format(TimeFormatLong, (int)totalFestivalLength.TotalMinutes, totalFestivalLength.Seconds);

            result += ($"Festival length: {time2str}") + "\n";

            foreach (var set in this.stage.Sets)
            {
                var time2str2 = String.Format(TimeFormatLong, (int)set.ActualDuration.TotalMinutes, set.ActualDuration.Seconds);
                result += ($"--{set.Name} ({time2str2}):") + "\n";

                var performersOrderedDescendingByAge = set.Performers.OrderByDescending(p => p.Age);
                foreach (var performer in performersOrderedDescendingByAge)
                {
                    var instruments = string.Join(", ", performer.Instruments
                        .OrderByDescending(i => i.Wear));

                    result += ($"---{performer.Name} ({instruments})") + "\n";
                }

                if (!set.Songs.Any())
                    result += ("--No songs played") + "\n";
                else
                {
                    result += ("--Songs played:") + "\n";
                    foreach (var song in set.Songs)
                    {
                        result += ($"----{song}") + "\n";
                    }
                }
            }

            return result.ToString();
        }

        public string RegisterSet(string[] args)
        {
            string name = args[0];
            string type = args[1];
            ISet set = setFactory.CreateSet(name, type);
            if (set == null)
            {
                throw new ArgumentException("Inavlid set type!");
            }
            this.stage.AddSet(set);
            return String.Format("Registered {0} set", type);
        }

        public string SignUpPerformer(string[] args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);

            var instrumenti = args.Skip(2).ToArray();

            var instrumenti2 = instrumenti
                .Select(i => this.instrumentFactory.CreateInstrument(i))
                .ToArray();

            var performer = this.performerFactory.CreatePerformer(name, age);

            foreach (var instrument in instrumenti2)
            {
                performer.AddInstrument(instrument);
            }

            this.stage.AddPerformer(performer);

            return $"Registered performer {performer.Name}";
        }

        public string RegisterSong(string[] args)
        {
            string stringTime = args[1];
            int[] values = stringTime.Split(':').Select(int.Parse).ToArray();

            TimeSpan ts = new TimeSpan(0, values[0], values[1]);
            ISong song = this.songFactory.CreateSong(args[0], ts);
            if (song == null)
            {
                throw new Exception();
            }
            this.stage.AddSong(song);
            return $"Registered song {song}";
        }

        private string SongRegistration(string[] args)
        {
            var songName = args[0];
            var setName = args[1];

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException("Invalid set provided");
            }

            if (!this.stage.HasSong(songName))
            {
                throw new InvalidOperationException("Invalid song provided");
            }

            var set = this.stage.GetSet(setName);
            var song = this.stage.GetSong(songName);

            set.AddSong(song);

            return $"Added {song} to {set.Name}";
        }

        // Временно!!! Чтобы работало делаем срез на конец месяца
        public string AddPerformerToSet(string[] args)
        {
            return PerformerRegistration(args);
        }

        private string PerformerRegistration(string[] args)
        {
            var performerName = args[0];
            var setName = args[1];

            if (!this.stage.HasPerformer(performerName))
            {
                throw new InvalidOperationException("Invalid performer provided");
            }

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException("Invalid set provided");
            }

            var performer = this.stage.GetPerformer(performerName);
            var set = this.stage.GetSet(setName);

            set.AddPerformer(performer);

            return $"Added {performer.Name} to {set.Name}";
        }

        public string RepairInstruments(string[] args)
        {
            var instrumentsToRepair = this.stage.Performers
                .SelectMany(p => p.Instruments)
                .Where(i => i.Wear < 100)
                .ToArray();

            foreach (var instrument in instrumentsToRepair)
            {
                instrument.Repair();
            }

            return $"Repaired {instrumentsToRepair.Length} instruments";
        }

        public string AddSongToSet(string[] args)
        {
            ISet set = this.stage.Sets.FirstOrDefault(s => s.Name == args[1]);
            if (set == null)
            {
                throw new InvalidOperationException("Invalid set provided");
            }
            ISong song = this.stage.Songs.FirstOrDefault(s => s.Name == args[0]);
            if (song == null)
            {
                throw new InvalidOperationException("Invalid song provided");
            }
            set.AddSong(song);
            return $"Added {song.Name} ({song.Duration:mm\\:ss}) to {set.Name}";
        }
    }
}