public static class Constants
{
    public const string SuccessfullRegistration = "Successfully registered {0}";

    public const string ProvidersRepaired = "Providers were repaired by {0}";

    public const string OreOutputToday = "Produced {0} ore today!";

    public const string EnergyProducedToday = "Produced {0} energy today!";
   
    public const string ModeChange = "Successfully changed working mode to {0}"; 
  
    public const string OreMined = "Plumbus Ore Mined: {0}";

    public const string DefaultMode = "full";

    public const string CommandNotFound = "{0}command not found";

    public const string InvalidCommand = "{0}command in not ICommand";

    public static string BrokenEntity { get; internal set; }

    public static string EntityNotFound = "No entity found with id - {0}";
    public static string TotalOreProduced = "Total Mined Plumbus Ore: {0}";
}