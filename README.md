[![](https://img.shields.io/nuget/v/soenneker.dispatchers.dispatcher.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dispatchers.dispatcher/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dispatchers.dispatcher/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dispatchers.dispatcher/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dispatchers.dispatcher.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dispatchers.dispatcher/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dispatchers.dispatcher/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dispatchers.dispatcher/actions/workflows/codeql.yml)

# Soenneker.Dispatchers.Dispatcher

Provides a marker interface and a logging base class for application-specific dispatchers.

## Installation

```bash
dotnet add package Soenneker.Dispatchers.Dispatcher
```

## Usage

```csharp
using Microsoft.Extensions.Logging;
using Soenneker.Dispatchers.Dispatcher;

public sealed class NotificationDispatcher(ILogger<Dispatcher> logger)
    : Dispatcher(logger)
{
    public Task Dispatch(string message, CancellationToken cancellationToken = default)
    {
        Logger.LogInformation("Dispatching notification");
        return Send(message, cancellationToken);
    }

    private static Task Send(string message, CancellationToken cancellationToken) =>
        Task.CompletedTask;
}
```

`Dispatcher` only stores the logger and exposes it to derived classes through the protected `Logger` property. It does not define dispatch methods, select handlers, queue work, manage retries, or register services. Those behaviors and any application-specific interface belong in the derived dispatcher.

All subclasses use the `Soenneker.Dispatchers.Dispatcher.Dispatcher` logging category because the constructor accepts `ILogger<Dispatcher>`.

`IDispatcher` is an empty marker contract. Use it when discovery or registration code needs a common dispatcher type; it does not provide callable members.
