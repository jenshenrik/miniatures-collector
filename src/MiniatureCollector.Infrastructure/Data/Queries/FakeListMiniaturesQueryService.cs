using System.Reflection.Emit;
using MiniatureCollector.Application.Miniatures;
using MiniatureCollector.Application.Miniatures.List;
using MiniatureCollector.Domain.MiniatureAggregate;
using MiniatureCollector.Domain.MiniatureAggregate.Enumerations;

namespace MiniatureCollector.Infrastructure.Data.Queries;

public class FakeListMiniaturesQueryService : IListMiniaturesQueryService
{
    public Task<IEnumerable<MiniatureDTO>> ListAsync(CancellationToken cancellationToken)
    {
        MiniatureDTO[] result = {
            new (MiniatureId.From(Guid.NewGuid()), "Lady Justice", Station.Master, new[] { Faction.Guild }),
            new (MiniatureId.From(Guid.NewGuid()), "The Judge", Station.Henchman, new[] { Faction.Guild })
        };

        return Task.FromResult(result.AsEnumerable());
    }
}