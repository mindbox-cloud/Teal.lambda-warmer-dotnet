namespace LambdaWarmer;

public sealed class WarmerConfig
{
    public TimeSpan Delay { get; set; } = TimeSpan.FromMilliseconds(75);

    public bool Log { get; set; } = true;
}