using Ardalis.Result;
using Ardalis.SharedKernel;
using MiniatureCollector.Domain.MiniatureAggregate.Specifications;

namespace MiniatureCollector.Application.Miniatures.Get;

public class GetMinatureHandler : IQueryHandler<GetMiniatureQuery, Result<MiniatureDTO>>
{
    public Task<Result<MiniatureDTO>> Handle(GetMiniatureQuery request, CancellationToken cancellationToken)
    {
        var specification = new MiniatureByIdSpec(request.MiniatureId);

        throw new NotImplementedException();
    }
}