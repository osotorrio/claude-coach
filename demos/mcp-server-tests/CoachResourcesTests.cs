namespace mcp_server_tests;

public class CoachResourcesTests
{
    [Fact]
    public void MessageOfTheDay_WhenCalled_ReturnsMotdHeading()
    {
        // Arrange & Act
        var result = CoachResources.MessageOfTheDay();

        // Assert
        Assert.Contains("# Claude Coach — MOTD", result);
    }

    [Fact]
    public void MessageOfTheDay_WhenCalled_MentionsResourcesAndPrompts()
    {
        // Arrange & Act
        var result = CoachResources.MessageOfTheDay();

        // Assert
        Assert.Contains("MCP resources & prompts", result);
    }

    [Fact]
    public void CourseStats_WhenCalled_IncludesFeatureCount()
    {
        // Arrange & Act
        var result = CoachResources.CourseStats();

        // Assert
        Assert.Contains("37", result);
    }

    [Fact]
    public void CourseStats_WhenCalled_IncludesWordsPerFeature()
    {
        // Arrange & Act
        var result = CoachResources.CourseStats();

        // Assert
        Assert.Contains("150", result);
    }

    [Fact]
    public void CourseStats_WhenCalled_IncludesReadingSpeed()
    {
        // Arrange & Act
        var result = CoachResources.CourseStats();

        // Assert
        Assert.Contains("238", result);
    }
}
