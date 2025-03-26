using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Dispatchers.Dispatcher.Tests;

[Collection("Collection")]
public class DispatcherTests : FixturedUnitTest
{
    public DispatcherTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
