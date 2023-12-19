namespace MiniatureCollector.Application.Miniatures.List;

public interface IListMiniaturesQueryService
{
    Task<IEnumerable<MiniatureDTO>> ListAsync(CancellationToken cancellationToken);
}