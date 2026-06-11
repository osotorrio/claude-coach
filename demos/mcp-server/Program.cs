using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = Host.CreateApplicationBuilder(args);

// A stdio MCP server speaks JSON-RPC over stdout, so every log line MUST go to
// stderr — anything written to stdout would corrupt the protocol stream.
builder.Logging.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Trace);

// Register the MCP server and auto-discover everything this assembly publishes:
// tools (model-invoked), prompts (user-invoked templates), resources (attachable data).
builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly()
    .WithPromptsFromAssembly()
    .WithResourcesFromAssembly();

await builder.Build().RunAsync();


/// <summary>A TOOL — the model decides to call this; the user never invokes it directly.</summary>
[McpServerToolType]
public static class CoachTools
{
    [McpServerTool,
     Description("Echoes a message back, prefixed by the Coach server. Proves the server's tools are live.")]
    public static string CoachEcho(string message) => $"🎓 Coach server says: {message}";
}

/// <summary>A RESOURCE — read-only data you attach inline with an @-mention.</summary>
[McpServerResourceType]
public static class CoachResources
{
    [McpServerResource(UriTemplate = "coach://motd", Name = "coach_motd", MimeType = "text/markdown"),
     Description("The Claude Coach 'message of the day' — a short read-only note you attach with @.")]
    public static string MessageOfTheDay() =>
        "# Claude Coach — MOTD\n\n" +
        "You are learning **MCP resources & prompts**.\n\n" +
        "- A *resource* is read-only data the server publishes; you attach it with `@`.\n" +
        "- A *prompt* is a reusable template the server publishes; you run it as a slash command.\n";

    [McpServerResource(UriTemplate = "coach://course-stats", Name = "course_stats", MimeType = "text/markdown"),
     Description("Raw course facts (data only, no calculations): feature count, estimated words per feature, and average human reading speed.")]
    public static string CourseStats() =>
        "# Claude Coach — Course Stats (raw data, no calculations)\n\n" +
        "- Number of features in the course: 37\n" +
        "- Estimated words to explain one feature: 150\n" +
        "- Average human reading speed: 238 words per minute\n";
}

/// <summary>A PROMPT — a reusable template that surfaces as a /mcp__coach__explain_feature command.</summary>
[McpServerPromptType]
public static class CoachPrompts
{
    [McpServerPrompt(Name = "explain_feature"),
     Description("Builds a prompt asking Claude to explain a Claude Code feature to an intermediate C# dev.")]
    public static string ExplainFeature(
        [Description("The Claude Code feature to explain, e.g. 'MCP resources'.")] string feature) =>
        $"Explain the Claude Code feature \"{feature}\" to an intermediate C#/.NET developer. " +
        "Keep it under 5 sentences, give one concrete example, and note one common pitfall.";
}
