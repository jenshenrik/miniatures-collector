using Ardalis.Result;
using Ardalis.SharedKernel;

namespace MiniatureCollector.Application.Miniatures.List;

public record ListMiniaturesQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<MiniatureDTO>>>;