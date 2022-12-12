namespace fastEndpointsDemoApi.Endpoints.GetMemberIsPremium;

public class Request
{
    public decimal TotalSpend { get; set; }
}

public class Response
{
    public bool IsPremium { get; set; }
}