using Ardalis.SmartEnum;

namespace MiniatureCollector.Domain.MiniatureAggregate.Enumerations;

public sealed class Faction : SmartEnum<Faction>
{
    public static readonly Faction Guild = new Faction("Guild", 0);
    public static readonly Faction Resurrectionists = new Faction("Resurrectionists", 1);
    public static readonly Faction Neverborn = new Faction("Neverborn", 2);
    public static readonly Faction Arcanists = new Faction("Arcanists", 3);
    public static readonly Faction Outcasts = new Faction("Outcasts", 4);
    public static readonly Faction Gremlins = new Faction("Gremlins", 5);
    public static readonly Faction TenThunders = new Faction(" Ten Thunders", 6);
    public static readonly Faction ExplorersSociety = new Faction("Explorer's Society", 7);

    private Faction(string name, int value) : base(name, value)
    {
        
    }
}