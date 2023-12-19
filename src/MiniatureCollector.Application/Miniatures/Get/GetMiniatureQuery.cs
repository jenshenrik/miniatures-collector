using Ardalis.Result;
using Ardalis.SharedKernel;
using MiniatureCollector.Domain.MiniatureAggregate;

namespace MiniatureCollector.Application.Miniatures.Get;

public record GetMiniatureQuery(MiniatureId MiniatureId) : IQuery<Result<MiniatureDTO>>;