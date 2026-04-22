using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dispatchers.Dispatcher.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DispatcherTests : HostedUnitTest
{
    public DispatcherTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
