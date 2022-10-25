using Amazon.Lambda.Core;

namespace LambdaWarmer.TestFunction;

public class Payload
{
    public string Input { get; set; } = default!;
}

public class Function : WarmerFunction<Payload, string>
{
    public override Task InternalWarmUpAsync(ILambdaContext context)
    {
        context.Logger.LogInformation("WARM UP");
        return Task.CompletedTask;
    }

    public override Task<string> InternalFunctionHandlerAsync(Payload payload, ILambdaContext context)
    {
        return Task.FromResult(payload.Input.ToUpper());
    }
}