using Amazon.Lambda.Core;

namespace LambdaWarmer.TestFunction;

public class Payload
{
    public string Input { get; set; } = default!;
}

public class Function : WarmerFunction<Payload, string>
{
    protected override Task InternalWarmUpAsync(ILambdaContext context)
    {
        context.Logger.LogInformation("WARM UP");
        return Task.CompletedTask;
    }

    protected override Task<string> InternalFunctionHandlerAsync(Payload payload, ILambdaContext context)
    {
        return Task.FromResult(payload.Input.ToUpper());
    }
}