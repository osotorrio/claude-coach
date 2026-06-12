namespace mcp_server_tests;

public class CoachPromptsTests
{
    [Fact]
    public void ExplainFeature_GivenFeature_EmbedsTheFeatureName()
    {
        // Arrange
        const string feature = "MCP resources";

        // Act
        var result = CoachPrompts.ExplainFeature(feature);

        // Assert
        Assert.Contains("\"MCP resources\"", result);
    }

    [Fact]
    public void ExplainFeature_GivenFeature_TargetsIntermediateCSharpDeveloper()
    {
        // Arrange
        const string feature = "hooks";

        // Act
        var result = CoachPrompts.ExplainFeature(feature);

        // Assert
        Assert.Contains("intermediate C#/.NET developer", result);
    }

    [Fact]
    public void ExplainFeature_GivenFeature_AsksForAPitfall()
    {
        // Arrange
        const string feature = "subagents";

        // Act
        var result = CoachPrompts.ExplainFeature(feature);

        // Assert
        Assert.Contains("pitfall", result);
    }
}
