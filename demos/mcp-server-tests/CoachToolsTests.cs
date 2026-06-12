namespace mcp_server_tests;

public class CoachToolsTests
{
    [Fact]
    public void CoachEcho_GivenMessage_PrefixesWithCoachServerSays()
    {
        // Arrange
        const string message = "hello";

        // Act
        var result = CoachTools.CoachEcho(message);

        // Assert
        Assert.Equal("🎓 Coach server says: hello", result);
    }

    [Fact]
    public void CoachEcho_EmptyMessage_ReturnsPrefixOnly()
    {
        // Arrange
        var message = string.Empty;

        // Act
        var result = CoachTools.CoachEcho(message);

        // Assert
        Assert.Equal("🎓 Coach server says: ", result);
    }

    [Fact]
    public void CoachEcho_GivenMessage_EmbedsTheMessage()
    {
        // Arrange
        const string message = "MCP is live";

        // Act
        var result = CoachTools.CoachEcho(message);

        // Assert
        Assert.Contains("MCP is live", result);
    }
}
