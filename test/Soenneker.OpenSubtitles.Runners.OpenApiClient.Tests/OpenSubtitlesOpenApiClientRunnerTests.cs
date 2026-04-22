using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenSubtitles.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenSubtitlesOpenApiClientRunnerTests : HostedUnitTest
{
    public OpenSubtitlesOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
