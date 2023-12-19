using MiniatureCollector.Domain.MiniatureAggregate;
using MiniatureCollector.Domain.MiniatureAggregate.Enumerations;

namespace MiniatureCollector.Application.Miniatures;

public record MiniatureDTO(MiniatureId MiniatureId, string Name, Station Station, IEnumerable<Faction> Factions);