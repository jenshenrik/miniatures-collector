using Ardalis.Specification;

namespace MiniatureCollector.Domain.MiniatureAggregate.Specifications;

public class MiniatureByIdSpec : Specification<Miniature>
{
    public MiniatureByIdSpec(MiniatureId miniatureId)
    {
        Query.Where(miniature => miniature.Id == miniatureId);
    }
}