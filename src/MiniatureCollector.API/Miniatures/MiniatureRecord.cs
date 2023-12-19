using MiniatureCollector.Domain.MiniatureAggregate.Enumerations;

namespace MiniatureCollector.API.Miniatures;

public record MiniatureRecord(
    Guid Id, 
    string Name, 
    Station Station, 
    IEnumerable<Faction> Factions
);