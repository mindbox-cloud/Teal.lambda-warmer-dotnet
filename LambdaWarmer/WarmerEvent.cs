using System.Text.Json.Serialization;

namespace LambdaWarmer;

public class WarmerEvent
{
    public bool Warmer { get; set; }

    public int Concurrency { get; set; }

    public int InvocationNumber { get; set; }
    
    public int TotalInvocation { get; set; }
    
    public string? CorrelationId { get; set; }
}

// ReSharper disable once ClassNeverInstantiated.Global
public sealed class WarmerEvent<TRequest> : WarmerEvent
{
    [JsonIgnore]
    public TRequest Request { get; set; } = default!;
}