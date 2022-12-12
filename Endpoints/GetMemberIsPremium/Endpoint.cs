namespace fastEndpointsDemoApi.Endpoints.GetMemberIsPremium;

public class Endpoint : Endpoint<Request>
{
    public override void Configure()
    {
        Get("/get_member_is_premium");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var response = new Response
        {
            IsPremium =  req.TotalSpend >= 100000
        };

        await SendAsync(response, cancellation: ct);
    }
}