using Ardalis.Result;
using Ardalis.SharedKernel;

namespace MiniatureCollector.Application.Miniatures.List;

public class ListMiniaturesHandler : IQueryHandler<ListMiniaturesQuery, Result<IEnumerable<MiniatureDTO>>>
{
    private readonly IListMiniaturesQueryService _service;

    public ListMiniaturesHandler(IListMiniaturesQueryService service)
    {
        _service = service;
    }
    
    public async Task<Result<IEnumerable<MiniatureDTO>>> Handle(ListMiniaturesQuery request, CancellationToken cancellationToken)
    {
        var result = await _service.ListAsync(cancellationToken);
        return Result.Success(result);
    }
}