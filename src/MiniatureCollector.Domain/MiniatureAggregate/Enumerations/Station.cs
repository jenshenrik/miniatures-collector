using Ardalis.SmartEnum;

namespace MiniatureCollector.Domain.MiniatureAggregate.Enumerations;

public sealed class Station : SmartEnum<Station>
{
    public static readonly Station Master = new Station("Master", 0);
    public static readonly Station Henchman = new Station("Henchman", 1);
    public static readonly Station Enforcer = new Station("Enforcer", 2);
    public static readonly Station Minion = new Station("Minion", 3);
    public static readonly Station Peon = new Station("Peon", 4);

    private Station(string name, int value) : base(name, value)
    {
        
    }

}