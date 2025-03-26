using Microsoft.Extensions.Logging;
using Soenneker.Dispatchers.Dispatcher.Abstract;

namespace Soenneker.Dispatchers.Dispatcher;

/// <inheritdoc cref="IDispatcher"/>
public abstract class Dispatcher : IDispatcher
{
    protected ILogger<Dispatcher> Logger { get; }

    protected Dispatcher(ILogger<Dispatcher> logger)
    {
        Logger = logger;
    }
}