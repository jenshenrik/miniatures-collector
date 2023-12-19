using FastEndpoints;
using MediatR;
using MiniatureCollector.Application.Miniatures.List;

namespace MiniatureCollector.API.Miniatures;

public class List : EndpointWithoutRequest<MiniaturesListResponse>
{
    private readonly IMediator _mediator;

    public List(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("/Miniatures");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new ListMiniaturesQuery(null, null), cancellationToken);

        if (result.IsSuccess)
        {
            Response = new MiniaturesListResponse
            {
                Miniatures = result.Value.Select(m =>
                    new MiniatureRecord(m.MiniatureId.Value, m.Name, m.Station, m.Factions)).ToList()
            };
        }
    }
    
}