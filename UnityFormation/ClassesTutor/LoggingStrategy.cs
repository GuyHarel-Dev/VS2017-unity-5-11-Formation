using System;
using System.Diagnostics;
using Unity.Builder;
using Unity.Strategies;

public class LoggingStrategy : BuilderStrategy
{
    public override void PreBuildUp(ref BuilderContext context)
    {
        Console.WriteLine($"Resolving type: {context.RegistrationType.Name}");
        Debug.WriteLine($"Resolving type: {context.RegistrationType.Name}");
        base.PreBuildUp(ref context);
    }
}
