using Ardalis.SharedKernel;
using MiniatureCollector.Domain.MiniatureAggregate.Enumerations;

namespace MiniatureCollector.Domain.MiniatureAggregate;

public class Miniature : EntityBase<MiniatureId>, IAggregateRoot
{
    public string Name { get; set; }
    public Station Station { get; set; }
    public IEnumerable<Faction> Factions { get; set; }
}

public readonly record struct MiniatureId(Guid Value)
{
    public static MiniatureId From(Guid value) => new(value);
}