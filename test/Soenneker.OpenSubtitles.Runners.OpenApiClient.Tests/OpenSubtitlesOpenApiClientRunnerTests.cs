using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenSubtitles.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenSubtitlesOpenApiClientRunnerTests : FixturedUnitTest
{
    public OpenSubtitlesOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
