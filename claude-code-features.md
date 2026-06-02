# Claude Code — Comprehensive Feature Reference for Software Engineers

*Ordered from beginner → advanced within each category.*

---

## 1. INSTALLATION & FIRST RUN

| Feature | Description |
|---|---|
| **Native installer** | One-line curl/PowerShell install for macOS, Linux, WSL, Windows CMD/PS |
| **Homebrew cask** | `brew install --cask claude-code` (stable or `@latest` channels) |
| **WinGet** | `winget install Anthropic.ClaudeCode` |
| **Linux package managers** | apt, dnf, apk support for Debian, Fedora/RHEL, Alpine |
| **Auto-update** | Background auto-updates on native installs; manual `brew/winget upgrade` on package managers |
| **Release channels** | `stable` (1 week behind) or `latest` (immediate) via `autoUpdatesChannel` setting |
| **Minimum version lock** | `minimumVersion` setting prevents running below a floor version |

---

## 2. CORE INTERACTIVE CLI

| Feature | Description |
|---|---|
| **`claude`** | Start an interactive session in the current directory |
| **`claude "prompt"`** | Start a session with an initial prompt |
| **`--print` / `-p`** | Non-interactive (headless) mode — print response and exit |
| **`--output-format`** | Output in `text`, `json`, or `stream-json` (for scripting/piping) |
| **`--verbose`** | Show full tool output including bash output |
| **`--debug`** | Enable debug logging |
| **`--max-turns`** | Limit the number of agentic turns per session |
| **Unix piping** | Pipe logs, git diffs, file lists into Claude: `tail app.log \| claude -p "..."` |
| **`!` prefix** | Run a shell command in the current session: `! git status` |
| **`--add-dir`** | Grant Claude access to additional directories outside the working directory |
| **`--dangerously-skip-permissions`** | Bypass all permission prompts (for trusted automation) |

---

## 3. BUILT-IN SLASH COMMANDS

| Command | Description |
|---|---|
| `/help` | Show available commands and usage |
| `/clear` | Clear the current conversation and context |
| `/compact` | Compact context with a summary to free up context window |
| `/model` | Switch the active model mid-session |
| `/memory` | View/edit all loaded CLAUDE.md files and auto memory |
| `/init` | Generate or improve `CLAUDE.md` by analyzing the codebase |
| `/status` | Show current session status, auth method, model |
| `/mcp` | View, authenticate, and manage MCP server connections |
| `/hooks` | View currently configured hooks |
| `/login` / `/logout` | Authenticate or sign out |
| `/bug` | Report a bug to Anthropic |
| `/review` | Review current code changes |
| `/debug` | Run debugging skills |
| `/code-review` | Code review at configurable effort levels (low/medium/high/ultra) |
| `/install-github-app` | Guided setup of Claude's GitHub Actions integration |
| `/schedule` | Create a scheduled routine from the CLI |
| `/loop` | Repeat a prompt within a session (polling/iteration) |
| `/desktop` | Hand off the terminal session to the Desktop app |
| `/teleport` | Pull a web/mobile session into the terminal |
| `/reload-plugins` | Reload plugins in the current session |
| `/plugin` | Install, uninstall, list, or marketplace-add plugins |
| `/fast` | Toggle fast mode (Claude Opus with faster output) |

---

## 4. FILE & CODE OPERATIONS

| Feature | Description |
|---|---|
| **Codebase exploration** | Claude reads and understands entire multi-file projects |
| **File reading** | Read any file by path; uses `@` mention for autocomplete |
| **File editing** | Edit multiple files in a single session across the entire repo |
| **`@` file mention** | Type `@` to fuzzy-search and attach files, MCP resources, or folders |
| **Write new files** | Create new files as part of a task |
| **Multi-file diffs** | Produces diffs across multiple files in one task |
| **Inline diffs (IDE)** | VS Code/JetBrains show diffs inline with accept/reject controls |
| **Plan mode** | Preview planned changes before execution (`--plan` flag or permission mode) |
| **Context window visualization** | Tool shows what's loaded and how much space remains |

---

## 5. GIT INTEGRATION

| Feature | Description |
|---|---|
| **Stage and commit** | Claude stages files, writes commit messages, and creates commits |
| **Branch creation** | Creates and checks out branches |
| **Pull request creation** | Opens PRs with summaries via `gh` CLI |
| **Merge conflict resolution** | Traces and resolves conflicts in code |
| **Git attribution** | Customizable `Co-Authored-By` line and PR badge via `attribution` setting |
| **Git instructions** | Includes git workflow in system prompt (`includeGitInstructions`) |
| **PR URL template** | Custom badge URL template for PR links (`prUrlTemplate`) |

---

## 6. MODEL CONFIGURATION

| Feature | Description |
|---|---|
| **Model selection** | Choose Opus 4.8, Sonnet 4.6, Haiku 4.5, or any supported model |
| **`/model` command** | Switch models mid-session |
| **`model` setting** | Set a default model in `settings.json` |
| **`availableModels`** | Restrict which models users are allowed to select |
| **`modelOverrides`** | Map Anthropic model IDs to Bedrock/Vertex provider-specific ARNs |
| **Extended thinking** | `alwaysThinkingEnabled` / `showThinkingSummaries` settings |
| **Effort levels** | `effortLevel`: `low`, `medium`, `high`, `xhigh` — persisted across sessions |
| **Fast mode** | Claude Opus with faster output; toggle with `/fast` |
| **Ultracode mode** | `ultracode: true` setting for maximum capability |
| **Third-party providers** | Amazon Bedrock, Google Vertex AI, Microsoft Foundry, custom `ANTHROPIC_BASE_URL` |

---

## 7. PERMISSION SYSTEM

| Feature | Description |
|---|---|
| **Permission modes** | `default`, `acceptEdits`, `plan`, `auto`, `dontAsk`, `bypassPermissions` |
| **`permissions.allow`** | Allowlist rules: `Bash(npm run *)`, `Read(~/.zshrc)` |
| **`permissions.deny`** | Denylist rules: `Bash(curl *)`, `Read(./.env)` |
| **`permissions.ask`** | Force a prompt for specific tools: `Bash(git push *)` |
| **`permissions.additionalDirectories`** | Extra directories Claude can read/write |
| **`permissions.defaultMode`** | Set the default mode across all sessions |
| **Tool-level permission rules** | Applies to `Bash`, `Read`, `Edit`, `WebFetch`, `MCP`, `Agent` tools |
| **`disableBypassPermissionsMode`** | Prevent users from enabling bypass mode |
| **`disableAutoMode`** | Prevent auto mode from being activated |
| **`auto` mode configuration** | Custom allow/soft-deny/hard-deny rules in CLAUDE.md `autoMode` block |

---

## 8. MEMORY & CONTEXT PERSISTENCE

### CLAUDE.md Files

| Feature | Description |
|---|---|
| **Project CLAUDE.md** | `./CLAUDE.md` or `./.claude/CLAUDE.md` — shared with team via git |
| **User CLAUDE.md** | `~/.claude/CLAUDE.md` — personal preferences across all projects |
| **Local CLAUDE.md** | `./CLAUDE.local.md` — private, gitignored project-specific notes |
| **Managed/org CLAUDE.md** | Deployed by IT to a system-wide path; cannot be excluded by users |
| **`@path` imports** | Import other files into CLAUDE.md with `@relative/path` syntax |
| **HTML comment stripping** | `<!-- notes -->` blocks are stripped from context (maintainer notes) |
| **`claudeMdExcludes`** | Skip specific CLAUDE.md files by glob pattern (for monorepos) |
| **`claudeMd` managed key** | Embed org-wide instructions directly in `managed-settings.json` |
| **`/init` command** | Auto-generate CLAUDE.md by analyzing codebase; also reads `.cursorrules`, `AGENTS.md` |
| **`AGENTS.md` support** | Import `AGENTS.md` into CLAUDE.md for cross-tool compatibility |
| **Directory hierarchy loading** | CLAUDE.md files walk up from CWD; subdirectory files load on demand |
| **`--add-dir` CLAUDE.md** | Load memory from additional directories with `CLAUDE_CODE_ADDITIONAL_DIRECTORIES_CLAUDE_MD=1` |

### `.claude/rules/` (Path-Scoped Rules)

| Feature | Description |
|---|---|
| **Rules directory** | `.claude/rules/*.md` — modular, topic-specific instruction files |
| **YAML frontmatter `paths`** | Scope rules to specific file patterns: `src/api/**/*.ts` |
| **User-level rules** | `~/.claude/rules/` — personal rules for all projects |
| **Symlinked rule sets** | Link shared rule directories across multiple projects |
| **Recursive discovery** | Rules organized in subdirectories (`frontend/`, `backend/`) |

### Auto Memory

| Feature | Description |
|---|---|
| **Auto memory** | Claude writes its own notes across sessions (build commands, patterns, preferences) |
| **`/memory` command** | Browse, edit, and toggle auto memory from within a session |
| **Storage location** | `~/.claude/projects/<project>/memory/MEMORY.md` + topic files |
| **`autoMemoryDirectory`** | Custom storage path via user settings |
| **Shared across worktrees** | All worktrees of the same git repo share one auto memory directory |
| **`autoMemoryEnabled`** | Toggle auto memory on/off in settings or with env var |
| **Subagent memory** | Subagents can maintain their own separate auto memory |

---

## 9. SESSIONS & CONTEXT MANAGEMENT

| Feature | Description |
|---|---|
| **Session resume** | `claude --resume` or `claude --continue` to resume prior sessions |
| **Session list** | `claude sessions` lists recent sessions |
| **`/compact`** | Compacts the context window with a summary; CLAUDE.md re-injected after |
| **`cleanupPeriodDays`** | Auto-cleanup of session files after N days (default: 30) |
| **Context window explorer** | Visual breakdown of what's consuming context space |
| **Prompt caching** | Automatic prompt caching to reduce API costs on long sessions |
| **Away message** | Session recap shown when returning after being away (`awayMessageEnabled`) |
| **Checkpointing** | Rewind file changes to a prior state within a session |
| **Goal-keeping** | Claude tracks and pursues a stated goal across turns |
| **`--teleport`** | Pull a running web/mobile cloud session into the local terminal |

---

## 10. IDE INTEGRATIONS

| Feature | Description |
|---|---|
| **VS Code extension** | Inline diffs, `@`-mentions, plan review, conversation history, keyboard shortcuts |
| **JetBrains plugin** | IntelliJ IDEA, PyCharm, WebStorm — interactive diff viewing, selection context sharing |
| **Cursor IDE** | Same extension as VS Code |
| **Auto-connect to IDE** | `autoConnectIde` setting auto-connects external terminal to running IDE |
| **Auto-install extension** | `autoInstallIdeExtension` auto-installs IDE extension |
| **External editor context** | `externalEditorContext` prepends Claude's last response in external editor |
| **`/desktop` command** | Move terminal session to Desktop app for visual diff review |

---

## 11. CONFIGURATION SYSTEM

### Settings Files

| Feature | Description |
|---|---|
| **User settings** | `~/.claude/settings.json` — personal, all projects |
| **Project settings** | `.claude/settings.json` — shared via git |
| **Local settings** | `.claude/settings.local.json` — private, gitignored |
| **Managed/policy settings** | System-wide via MDM, plist, registry, or `managed-settings.json` |
| **Schema validation** | `"$schema": "https://json.schemastore.org/claude-code-settings.json"` |
| **Settings priority** | Managed > CLI args > Local > Project > User |
| **Hot reload** | `permissions`, `hooks`, `apiKeyHelper` reload without restart |
| **`ConfigChange` hook** | Fires when any settings file changes |
| **`--settings`** | Pass a custom settings file path at launch |
| **`--setting-sources`** | Control which setting layers to load |

### Key Settings Categories

| Category | Notable Settings |
|---|---|
| **Display** | `outputStyle`, `language`, `editorMode` (vim/normal), `tui`, `viewMode`, `prefersReducedMotion` |
| **Spinner** | `spinnerTipsEnabled`, `spinnerTipsOverride`, `spinnerVerbs` |
| **Git/Attribution** | `attribution.commit`, `attribution.pr`, `prUrlTemplate` |
| **Shell** | `defaultShell` (bash/powershell), `env` (global env vars) |
| **Deep links** | `disableDeepLinkRegistration` |
| **Notifications** | `preferredNotifChannel`, `companyAnnouncements` |
| **Plans** | `plansDirectory` |
| **File suggestions** | `fileSuggestion` (custom `@` autocomplete script) |

---

## 12. ENVIRONMENT VARIABLES

| Feature | Description |
|---|---|
| **`ANTHROPIC_API_KEY`** | Direct API authentication |
| **`ANTHROPIC_BASE_URL`** | Custom API endpoint (proxy, self-hosted) |
| **`CLAUDE_CODE_API_KEY_HELPER`** | Script to dynamically generate auth token |
| **`MCP_TIMEOUT`** | MCP server startup timeout (ms) |
| **`MCP_TOOL_TIMEOUT`** | Per-tool execution timeout |
| **`MAX_MCP_OUTPUT_TOKENS`** | Max tokens for MCP tool output (default 25k) |
| **`ENABLE_TOOL_SEARCH`** | `true`/`false`/`auto`/`auto:N` — control MCP tool deferred loading |
| **`ENABLE_CLAUDEAI_MCP_SERVERS`** | Enable/disable claude.ai connectors in Claude Code |
| **`CLAUDE_CODE_ENABLE_TELEMETRY`** | Enable OpenTelemetry metrics |
| **`OTEL_METRICS_EXPORTER`** | OTLP exporter config |
| **`CLAUDE_CODE_DISABLE_AUTO_MEMORY`** | Disable auto memory |
| **`CLAUDE_ENV_FILE`** | Path for hooks to persist environment variables across turns |
| **`MCP_CLIENT_SECRET`** | Pass OAuth secret non-interactively in CI |

---

## 13. SKILLS (CUSTOM SLASH COMMANDS)

| Feature | Description |
|---|---|
| **Skill file** | `SKILL.md` file at `.claude/skills/<name>/SKILL.md` (or `.claude/commands/<name>.md`) |
| **Invoke with `/name`** | Direct invocation: `/deploy`, `/review-pr` |
| **Auto-invocation** | Claude detects relevant skills from prompt and loads them automatically |
| **Frontmatter control** | YAML frontmatter to configure name, description, invocation control |
| **`allowed-by`** | Control who can invoke: `user`, `claude`, or `both` |
| **`run-in-subagent`** | Execute skill in an isolated subagent context |
| **Hooks in skills** | Embed hook definitions in skill frontmatter |
| **`once: true`** | Run a hook only once per session from skill frontmatter |
| **Dynamic context injection** | Skills can inject runtime context via hooks or scripts |
| **Supporting files** | Skills can have a directory with supporting assets |
| **User-level skills** | `~/.claude/skills/` — available across all projects |
| **Skill overrides** | `skillOverrides` setting for per-skill visibility control |
| **Agent Skills standard** | Compatible with the open agentskills.io standard |
| **Bundled skills** | Pre-installed skills like `/debug`, `/code-review`, `/ultrareview`, `/ultraplan` |

---

## 14. HOOKS (LIFECYCLE AUTOMATION)

### Hook Types

| Type | Description |
|---|---|
| **`command`** | Shell command receiving JSON on stdin |
| **`http`** | HTTP POST to a URL |
| **`mcp_tool`** | Call a tool on a connected MCP server |
| **`prompt`** | Single-turn LLM evaluation for yes/no decisions |
| **`agent`** | Spawn a subagent with tool access (experimental) |

### Hook Events (35+ events across 6 categories)

| Category | Events |
|---|---|
| **Session** | `SessionStart`, `Setup`, `SessionEnd` |
| **Turn** | `UserPromptSubmit`, `UserPromptExpansion`, `Stop`, `StopFailure` |
| **Tool use** | `PreToolUse`, `PermissionRequest`, `PermissionDenied`, `PostToolUse`, `PostToolUseFailure`, `PostToolBatch` |
| **Subagent** | `SubagentStart`, `SubagentStop`, `TeammateIdle` |
| **Task** | `TaskCreated`, `TaskCompleted` |
| **System** | `Notification`, `MessageDisplay`, `ConfigChange`, `CwdChanged`, `FileChanged`, `WorktreeCreate`, `WorktreeRemove`, `PreCompact`, `PostCompact`, `Elicitation`, `ElicitationResult`, `InstructionsLoaded` |

### Hook Capabilities

| Feature | Description |
|---|---|
| **Matcher patterns** | Match by tool name, session source, agent type, file name, error type, etc. |
| **MCP tool matchers** | Pattern: `mcp__<server>__<tool>` |
| **`if` filter** | Permission-rule style filter: `"Bash(git *)"` |
| **Blocking (exit 2)** | Exit code 2 blocks the action; other non-zero shows error |
| **JSON output control** | Return `decision`, `permissionDecision`, `additionalContext`, `systemMessage`, `continue`, `stopReason` |
| **`suppressOutput`** | Hide hook stdout from transcript |
| **`terminalSequence`** | Send desktop notifications via OSC sequences |
| **`additionalContext`** | Inject runtime info into Claude's context |
| **`sessionTitle`** | Dynamically set the session title |
| **`watchPaths`** | Register file paths for `FileChanged` events from `SessionStart` |
| **`$CLAUDE_ENV_FILE`** | Persist env vars across turns (set in `SessionStart`/`CwdChanged`) |
| **Async hooks** | `async: true` — non-blocking; `asyncRewake: true` — wake on exit code 2 |
| **`timeout`** | Per-hook timeout in seconds |
| **`statusMessage`** | Custom spinner message while hook runs |
| **`updatedInput`** | Modify a tool's input before execution (in `PermissionRequest` output) |
| **`reloadSkills`** | Trigger skill reload from `SessionStart` hook output |
| **Exec vs shell form** | `args` present = exec form (no shell tokenization); absent = shell form |
| **`CLAUDE_PROJECT_DIR`** | Path placeholder in hooks for project root |
| **`CLAUDE_PLUGIN_ROOT`** | Path placeholder for plugin installation directory |
| **`CLAUDE_PLUGIN_DATA`** | Path placeholder for persistent plugin data |
| **HTTP hook auth** | `headers` + `allowedEnvVars` for secure token passing |
| **`disableAllHooks`** | Globally disable all hooks |
| **`allowManagedHooksOnly`** | Org policy: only managed/plugin hooks run |
| **Hook hierarchy** | Managed policy > Plugin > Project > Local > User |
| **Hook config scopes** | User, project, local, managed policy, plugin, skill/agent frontmatter |

---

## 15. MCP — MODEL CONTEXT PROTOCOL

### Transports & Setup

| Feature | Description |
|---|---|
| **HTTP/Streamable HTTP** | `claude mcp add --transport http <name> <url>` |
| **SSE (deprecated)** | `claude mcp add --transport sse <name> <url>` |
| **Stdio (local process)** | `claude mcp add <name> -- <command> [args...]` |
| **`claude mcp add-json`** | Add from raw JSON config |
| **`claude mcp add-from-claude-desktop`** | Import servers from Claude Desktop app |
| **`claude mcp list`** | List all configured servers |
| **`claude mcp get <name>`** | Get details for a specific server |
| **`claude mcp remove <name>`** | Remove a server |
| **`claude mcp reset-project-choices`** | Reset project server approval choices |
| **`claude mcp serve`** | Run Claude Code itself as a stdio MCP server |
| **`/mcp` command** | Manage, authenticate, and inspect servers in-session |

### Scopes

| Scope | Description |
|---|---|
| **Local** | Default — private to current project, stored in `~/.claude.json` |
| **Project** | Shared via `.mcp.json` in repo root — committed to git |
| **User** | Available across all projects on your machine |
| **Plugin-provided** | Auto-configured by plugins |
| **claude.ai connectors** | Imported automatically when logged in with Claude.ai account |
| **Managed** | Enterprise-deployed via `managed-mcp.json` |

### Authentication

| Feature | Description |
|---|---|
| **OAuth 2.0** | Full browser OAuth flow via `/mcp` |
| **`--callback-port`** | Fix OAuth callback port for pre-registered redirect URIs |
| **`--client-id` / `--client-secret`** | Pre-configured OAuth credentials |
| **`MCP_CLIENT_SECRET`** | Pass secret non-interactively in CI |
| **`authServerMetadataUrl`** | Override OAuth discovery URL |
| **`oauth.scopes`** | Pin specific OAuth scopes |
| **`headersHelper`** | Dynamic header generation script (Kerberos, SSO, short-lived tokens) |
| **Static headers** | `--header "Authorization: Bearer token"` |
| **Auto token refresh** | Tokens stored securely and refreshed automatically |

### Advanced MCP Features

| Feature | Description |
|---|---|
| **Tool Search** | Deferred loading of MCP tool definitions — tools load on demand to save context |
| **`ENABLE_TOOL_SEARCH`** | `true`/`false`/`auto`/`auto:N` control |
| **`alwaysLoad`** | Force specific server's tools to load upfront, bypassing deferral |
| **`anthropic/alwaysLoad`** | Per-tool `_meta` annotation for always-loading |
| **`anthropic/maxResultSizeChars`** | Per-tool annotation to raise output size limit |
| **`MAX_MCP_OUTPUT_TOKENS`** | Global cap on MCP tool output (env var) |
| **Dynamic tool updates** | `list_changed` notifications — servers update tools without disconnect |
| **Auto-reconnect** | Exponential backoff reconnection for HTTP/SSE servers (5 attempts) |
| **MCP elicitation** | Servers can request structured input mid-task via forms or browser URLs |
| **`Elicitation` hook** | Auto-respond to elicitation requests without showing a dialog |
| **MCP resources** | `@server:protocol://path` — attach MCP resource data via `@` mention |
| **MCP prompts as commands** | `/mcp__servername__promptname` — execute MCP-defined prompts |
| **Channels via MCP** | MCP server declares `claude/channel` capability to push events into session |
| **Environment variable expansion** | `${VAR}` and `${VAR:-default}` in `.mcp.json` config |
| **`MCP_TIMEOUT`** | Server startup timeout (ms) |
| **Per-server tool timeout** | `"timeout"` field in `.mcp.json` entry |
| **`allowedMcpServers` / `deniedMcpServers`** | Org policy for MCP server access control |
| **Plugin MCP servers** | Plugins bundle MCP servers — auto-connect when plugin enabled |
| **`CLAUDE_PROJECT_DIR` in server** | Available as env var inside spawned MCP server processes |
| **Anthropic Directory** | Browse/add reviewed connectors at `claude.ai/directory` |

---

## 16. SUB-AGENTS & AGENT ORCHESTRATION

### Sub-Agents

| Feature | Description |
|---|---|
| **Custom subagent definition** | YAML file at `.claude/agents/<name>.md` or `~/.claude/agents/<name>.md` |
| **Subagent system prompt** | Custom instructions scoped to the subagent |
| **Tool restriction** | Define exactly which tools a subagent can use |
| **Permission isolation** | Independent permission context per subagent |
| **Model override** | Route subagents to faster/cheaper models (e.g., Haiku) |
| **Auto-delegation** | Claude routes tasks to matching subagents based on description |
| **Built-in subagents** | `Explore` (fast read-only search), `general-purpose`, and others |
| **Subagent auto memory** | Subagents maintain their own `~/.claude/projects/<project>/memory/` |
| **`Agent` permission rule** | Control which subagents can be spawned: `Agent(subagent-name)` |
| **`SubagentStart`/`SubagentStop` hooks** | Lifecycle hooks for subagent events |
| **`disableAllAgents`** | Setting to prevent subagent spawning |

### Agent Teams

| Feature | Description |
|---|---|
| **Agent teams** | Multiple Claude Code agents working on subtasks simultaneously |
| **Background agents** | Run parallel sessions and monitor from one screen |
| **Agent view** | Monitor all running agents from a single interface |
| **`disableAgentView`** | Setting to turn off agent view |
| **`teammateMode`** | Display mode: `auto`, `in-process`, `tmux` |
| **`teammateDefaultModel`** | Default model for teammate agents |

### Dynamic Workflows

| Feature | Description |
|---|---|
| **Dynamic workflows** | Orchestrate subagents at scale with programmatic task routing |
| **`disableWorkflows`** | Setting to disable dynamic workflows |
| **TaskCreate tool** | Create tasks for tracking work across agents |
| **TaskGet / TaskList / TaskUpdate / TaskStop / TaskOutput** | Full task management API |
| **`TaskCreated`/`TaskCompleted` hooks** | Fire on task lifecycle events |

---

## 17. WORKTREES

| Feature | Description |
|---|---|
| **Git worktrees** | Run parallel sessions on different branches in isolated directories |
| **`worktree.baseRef`** | Branch worktrees from `"fresh"` (default) or `"head"` |
| **`worktree.symlinkDirectories`** | Directories to symlink into worktrees (e.g., `node_modules`) |
| **`worktree.sparsePaths`** | Use sparse-checkout in worktrees for large monorepos |
| **`worktree.bgIsolation`** | Background session isolation: `"worktree"` (default) or `"none"` |
| **`WorktreeCreate`/`WorktreeRemove` hooks** | Hooks fire on worktree lifecycle |
| **`WorktreeCreate` custom path** | Hook can return a custom path for the new worktree |

---

## 18. SCHEDULING & AUTOMATION

| Feature | Description |
|---|---|
| **`/loop`** | Repeat a prompt within a CLI session; self-paced or interval-based |
| **Desktop scheduled tasks** | Run on your local machine via Desktop app; access local files/tools |
| **Routines** | Anthropic-managed cloud schedules (cron); run when machine is off |
| **Routine triggers** | Time-based cron, API calls, or GitHub events |
| **`/schedule` command** | Create routines from CLI |
| **PushNotification tool** | Send notifications from within an agent session |
| **`RemoteTrigger`** | Trigger routines via API |

---

## 19. CHANNELS (PUSH EVENTS INTO SESSIONS)

| Feature | Description |
|---|---|
| **Channels** | Push external events into a running Claude session via MCP |
| **Supported sources** | Telegram, Discord, iMessage, Slack, webhooks, custom |
| **`--channels` flag** | Opt a server into channel mode at startup |
| **`channelsEnabled`** | Org policy setting to allow/block channels |
| **Elicitation via channels** | Servers can request input via elicitation forms in-session |

---

## 20. REMOTE & CROSS-DEVICE WORK

| Feature | Description |
|---|---|
| **Remote Control** | Continue a local session from any browser or phone |
| **`--teleport`** | Pull web/mobile cloud session into local terminal |
| **Desktop app** | Standalone app with visual diffs, multi-session view, session scheduling |
| **Dispatch** | Send tasks from phone → Desktop session via message |
| **Web app** | `claude.ai/code` — run in browser, start long-running tasks, work on remote repos |
| **Claude iOS app** | Start sessions and continue them on desktop |
| **SSH connections (Desktop)** | `sshConfigs` setting for remote machine sessions from Desktop |
| **`disableRemoteControl`** | Setting to disable Remote Control feature |

---

## 21. CI/CD & GITHUB/GITLAB AUTOMATION

### GitHub Actions

| Feature | Description |
|---|---|
| **`@claude` mention trigger** | Claude responds to `@claude` in PR/issue comments |
| **PR creation from issues** | "Implement this feature" → Claude creates a complete PR |
| **Automated code review** | `/install-github-app` sets up automatic review on every PR |
| **`claude_args` passthrough** | Any Claude Code CLI args passed via `claude_args` in workflow YAML |
| **Skills in Actions** | Invoke skills directly in the `prompt` parameter |
| **Plugin installation in Actions** | `plugin_marketplaces` + `plugins` inputs for workflow plugins |
| **Custom trigger phrase** | `trigger_phrase` param (default `@claude`) |
| **Amazon Bedrock in Actions** | `use_bedrock: true` with OIDC auth (no stored credentials) |
| **Google Vertex AI in Actions** | `use_vertex: true` with Workload Identity Federation |
| **Custom GitHub App** | Bring-your-own GitHub App for branded usernames and custom auth |
| **`CLAUDE.md` respected** | Claude follows project standards in all automated runs |

### GitLab CI/CD

| Feature | Description |
|---|---|
| **GitLab CI integration** | Same Claude Code agent capabilities in GitLab pipelines |

### GitHub Code Review

| Feature | Description |
|---|---|
| **Automatic PR review** | Posted on every PR without a trigger phrase |
| **Inline PR comments** | `--comment` flag posts review findings as inline comments |

---

## 22. PLUGINS

| Feature | Description |
|---|---|
| **Plugin creation** | Bundle skills, hooks, MCP servers, subagents into a distributable unit |
| **`plugin.json`** | Plugin manifest with name, description, components |
| **Plugin marketplaces** | Git repositories hosting collections of plugins |
| **`/plugin install`** | Install a plugin from a marketplace |
| **`/plugin marketplace add`** | Add a new marketplace source |
| **`/reload-plugins`** | Reload all enabled plugins in current session |
| **Plugin scopes** | User or project level |
| **Plugin MCP servers** | Auto-started MCP servers bundled with plugins |
| **Plugin hooks** | Hooks defined in `hooks/hooks.json` within plugin |
| **`CLAUDE_PLUGIN_ROOT`** | Path to plugin installation directory in hooks/MCP |
| **`CLAUDE_PLUGIN_DATA`** | Persistent data directory that survives plugin updates |
| **`plugin_hints`** | Plugins can recommend themselves from the CLI |
| **Plugin trust dialog** | User must approve plugin before it runs |
| **`pluginTrustMessage`** | Custom org message in plugin trust dialog |
| **`allowedChannelPlugins`** | Org policy allowlist for channel plugins |
| **`strictPluginOnlyCustomization`** | Lock customization to plugins only (org policy) |
| **`blockedMarketplaces`** | Org denylist of plugin sources |
| **`mcp-server-dev` plugin** | Official plugin to scaffold new MCP servers |
| **`disableSkillShellExecution`** | Disable inline shell execution in skills |

---

## 23. SANDBOXING & SECURITY

| Feature | Description |
|---|---|
| **`sandbox.enabled`** | Enable bash sandboxing (macOS via Seatbelt; Linux via bubblewrap) |
| **`sandbox.failIfUnavailable`** | Exit if sandbox technology unavailable |
| **`sandbox.autoAllowBashIfSandboxed`** | Auto-approve bash when sandboxed |
| **`sandbox.excludedCommands`** | Commands to run outside sandbox (e.g., `docker *`) |
| **`sandbox.filesystem.allowWrite`** | Writable paths inside sandbox |
| **`sandbox.filesystem.denyWrite`** | Read-only paths inside sandbox |
| **`sandbox.filesystem.denyRead`** | Paths sandbox cannot read |
| **`sandbox.network.allowedDomains`** | Allowlist of outbound domains |
| **`sandbox.network.deniedDomains`** | Blocked outbound domains |
| **`sandbox.network.allowUnixSockets`** | Unix socket allowlist (macOS) |
| **`sandbox.network.allowLocalBinding`** | Allow localhost port binding in sandbox (macOS) |
| **`sandbox.network.allowMachLookup`** | XPC/Mach service names for sandbox (macOS) |
| **Sandbox environments** | Dev containers, Docker, `claude-code-sandbox` image |
| **Prompt injection protection** | Security guidance for external content sources |
| **`skipWebFetchPreflight`** | Skip WebFetch domain safety check |
| **Zero data retention** | ZDR compliance setting |
| **`allowManagedReadPathsOnly`** | Only managed allowRead paths apply |
| **`allowManagedDomainsOnly`** | Only managed network domains apply |

---

## 24. ENTERPRISE & ADMIN FEATURES

### Authentication & Auth Management

| Feature | Description |
|---|---|
| **`forceLoginMethod`** | Restrict to `"claudeai"` or `"console"` login |
| **`forceLoginOrgUUID`** | Lock to specific organization(s) |
| **`apiKeyHelper`** | Custom script to generate API keys (for short-lived tokens) |
| **`awsCredentialExport`** | Script to output AWS credentials JSON |
| **`awsAuthRefresh`** | Script to refresh AWS credentials |
| **`gcpAuthRefresh`** | Script to refresh GCP credentials |
| **`otelHeadersHelper`** | Script to generate dynamic OTEL headers |
| **`policyHelper`** | Executable for dynamic managed policy |
| **`forceRemoteSettingsRefresh`** | Block startup until remote settings fetched |

### Managed Settings Deployment

| Feature | Description |
|---|---|
| **macOS** | `com.anthropic.claudecode` plist / `/Library/Application Support/ClaudeCode/managed-settings.json` |
| **Linux/WSL** | `/etc/claude-code/managed-settings.json` |
| **Windows** | Registry (`HKLM\SOFTWARE\Policies\ClaudeCode`) / `C:\Program Files\ClaudeCode\managed-settings.json` |
| **Drop-in directories** | `managed-settings.d/` for modular policy files |
| **`parentSettingsBehavior`** | Control merge behavior: `"first-wins"` or `"merge"` |
| **`wslInheritsWindowsSettings`** | WSL reads Windows managed policies |
| **`allowManagedPermissionRulesOnly`** | Only managed permission rules apply |
| **`allowManagedHooksOnly`** | Only managed hooks run |
| **`allowManagedMcpServersOnly`** | Only managed MCP servers allowed |
| **`allowedMcpServers` / `deniedMcpServers`** | Managed server allowlist/denylist |
| **`companyAnnouncements`** | Custom messages shown at startup |

### Analytics & Monitoring

| Feature | Description |
|---|---|
| **Usage analytics** | Track team usage and cost from admin console |
| **OpenTelemetry integration** | `CLAUDE_CODE_ENABLE_TELEMETRY=1`, `OTEL_METRICS_EXPORTER`, `OTEL_EXPORTER_OTLP_ENDPOINT` |
| **`otelHeadersHelper`** | Dynamic headers for OTEL collector auth |
| **Monitoring dashboard** | Built-in monitoring for usage tracking |
| **`feedbackSurveyRate`** | Control rate of session quality surveys |

---

## 25. AGENT SDK (PROGRAMMATIC API)

| Feature | Description |
|---|---|
| **Python SDK** | `pip install claude-code-sdk` — programmatic agent control |
| **TypeScript SDK** | `npm install @anthropic-ai/claude-code` — full TypeScript support |
| **Session management** | Create, continue, and persist sessions programmatically |
| **Streaming output** | Stream responses in real-time |
| **Structured output** | Get typed/structured responses from agents |
| **Custom tools** | Define custom tools for agents beyond built-ins |
| **Hook interception** | Intercept and control agent behavior programmatically |
| **File checkpointing** | Rewind file changes to a prior checkpoint |
| **MCP in SDK** | Connect MCP servers programmatically |
| **Subagents in SDK** | Spawn and manage subagents from SDK |
| **Skills in SDK** | Load and invoke skills via SDK |
| **Slash commands in SDK** | Execute slash commands programmatically |
| **Cost/usage tracking** | Per-session token and cost tracking |
| **Session storage** | Persist sessions to external storage (S3, DB, etc.) |
| **Permission configuration** | Configure tool permissions per session |
| **System prompt modification** | Override or append to system prompt |
| **Todo lists** | Track multi-step work with built-in todo tracking |
| **Tool search in SDK** | Scale to many tools with deferred loading |
| **User input handling** | Handle approvals and user input in automated pipelines |
| **Observability** | OpenTelemetry integration for SDK sessions |
| **Hosting** | Deploy SDK agents to cloud infrastructure |
| **Secure deployment guide** | Best practices for production agent security |
| **Plugin support in SDK** | Use plugins within SDK-powered agents |

---

## 26. SPECIALIZED SURFACES

| Feature | Description |
|---|---|
| **Chrome extension (beta)** | Debug live web applications with browser context |
| **Slack integration** | Mention `@Claude` in Slack with a bug report → get a PR back |
| **Computer use** | Let Claude control your computer from the CLI |
| **Voice dictation** | Dictate prompts using voice input |
| **Deep links** | `claude-cli://` protocol handler to launch sessions from links |
| **Fullscreen mode** | `tui: "fullscreen"` for immersive terminal experience |
| **Vim keybindings** | `editorMode: "vim"` for vim-style input |
| **Custom status line** | `statusLine` setting with custom script for bottom-bar display |
| **Custom keybindings** | `~/.claude/keybindings.json` — remap keys and chord shortcuts |
| **`@` autocomplete** | Fuzzy file/resource picker with custom `fileSuggestion` script |

---

## 27. ADVANCED CLOUD DEPLOYMENT

| Feature | Description |
|---|---|
| **Amazon Bedrock** | Route via Bedrock with AWS IAM auth, cross-region inference |
| **Google Vertex AI** | Route via Vertex AI with GCP Workload Identity |
| **Microsoft Azure Foundry** | Route via Azure with managed identity |
| **Claude Platform on AWS** | Dedicated Anthropic-hosted deployment on AWS |
| **GitHub Enterprise Server** | Self-hosted GitHub integration |
| **LLM gateway** | Route via internal API proxy with `ANTHROPIC_BASE_URL` |
| **`modelOverrides`** | Map model IDs to provider-specific endpoints/ARNs |
| **Network configuration** | Enterprise proxy, firewall, and certificate config |
| **Dev containers** | Official devcontainer definition for reproducible environments |

---

## 28. CODE QUALITY & REVIEW TOOLS

| Feature | Description |
|---|---|
| **`/code-review`** | In-session code review at `low`/`medium`/`high`/`ultra` effort levels |
| **`--comment` flag** | Post review findings as inline PR comments |
| **`--fix` flag** | Apply review findings directly to working tree |
| **Ultrareview** | Deep multi-agent cloud review (`/code-review ultra` or `/ultrareview`) |
| **Ultraplan** | Plan complex features in the cloud (`/ultraplan`) |
| **GitHub Code Review** | Automatic review posted on every PR (no trigger needed) |
| **Security review skill** | `/security-review` for security-focused analysis of pending changes |
| **`security-guidance`** | Real-time security issue detection as Claude writes code |

---

## 29. OUTPUT & DISPLAY CUSTOMIZATION

| Feature | Description |
|---|---|
| **`outputStyle`** | `"Explanatory"` or compact output styles |
| **`language`** | Claude responds in any specified language |
| **`viewMode`** | `"default"`, `"verbose"`, `"focus"` transcript views |
| **`syntaxHighlightingDisabled`** | Toggle syntax highlighting |
| **`showTurnDuration`** | Show how long each turn takes |
| **`terminalProgressBarEnabled`** | Progress bar in terminal |
| **`autoScrollEnabled`** | Auto-scroll to latest output |
| **`spinnerVerbs`** | Custom action verbs shown during processing |
| **`showClearContextOnPlanAccept`** | Option to clear context on plan acceptance |
| **`fastModePerSessionOptIn`** | Require per-session opt-in for fast mode |

---

## Summary

This reference covers **29 major feature categories** with **400+ individual features**, spanning from first-run installation through enterprise-grade multi-cloud deployment, agent orchestration, and the full programmatic Agent SDK.

Sources: [Claude Code Documentation](https://code.claude.com/docs/en/overview) — fetched May 2026.
