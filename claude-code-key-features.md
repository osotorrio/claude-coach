# Claude Code — Key Features Every Engineer Should Learn

*A scannable cheat sheet. Grouped by theme; within each group, essentials first.*
*Scope: the Claude Code CLI — day-to-day dev + team/CI workflows (as of mid-2026).*

## 1. Daily Driver — Core Interaction
- **Interactive session** — run `claude` in your repo; pass a prompt to start a task.
- **`@` mentions** — fuzzy-find and attach files, folders, or MCP resources inline.
- **`!` shell prefix** — run a shell command and feed its output into the session.
- **Image input** — paste/drag screenshots & mockups (errors, designs) into the prompt.
- **Built-in slash commands** — `/help`, `/clear`, `/compact`, `/init`, `/status`, `/model`…
- **Plan mode** — make Claude research and propose an approach before editing (Shift+Tab).
- **Extended thinking & effort levels** — dial reasoning depth; `/fast` for quick Opus output.
- **Model selection** — `/model` to switch Opus / Sonnet / Haiku mid-session.
- **Headless mode & piping** — `claude -p "…"` for scripts; pipe logs/diffs in, text/JSON out.

## 2. Context & Memory
- **CLAUDE.md** — project/user/local memory auto-loaded each session; compose with `@imports`.
- **`/init`** — auto-generate a starter CLAUDE.md from your codebase.
- **`.claude/rules/`** — modular instruction files scoped to file globs (path-scoped rules).
- **Auto memory** — Claude keeps its own cross-session notes; manage with `/memory`.
- **Context management** — `/compact` to summarize & reclaim space, `/clear` to reset.
- **Sessions** — resume earlier work with `--continue` / `--resume`.
- **Checkpointing / rewind** — roll file changes back to an earlier point in the session.

## 3. Configuration & Control
- **settings.json** — layered config (user → project → local → managed) with set precedence.
- **Permission modes** — `default`, `acceptEdits`, `plan`, `bypassPermissions`; switch per session.
- **Permission rules** — `allow` / `deny` / `ask` patterns per tool, e.g. `Bash(npm run *)`.
- **Environment variables** — control auth, MCP timeouts, telemetry, and behavior.
- **Sandboxing** — run bash in an OS sandbox with filesystem/network allowlists.
- **Display & UX** — output styles, custom status line, vim mode, custom keybindings.

## 4. Automation & Extensibility
- **Skills** — custom & bundled slash commands; auto-invoked when relevant or called by `/name`.
- **Hooks** — run scripts/HTTP/agents on lifecycle events (pre/post tool use, start, stop…).
- **MCP servers** — connect external tools & data (DBs, APIs, browsers) over stdio/HTTP.
- **MCP resources & prompts** — `@server:…` to attach data; `/mcp__server__prompt` to run prompts.
- **Plugins** — bundle skills + hooks + MCP + subagents into one installable unit; share via marketplaces.

## 5. Parallelism & Orchestration
- **Subagents** — delegate to specialized agents with their own context, tools, and model.
- **Explore agent** — built-in fast read-only codebase search that keeps your main context clean.
- **Agent teams** — run multiple agents on subtasks at once, monitored from one view.
- **Worktrees** — parallel sessions on isolated branches without touching your working tree.

## 6. Team Collaboration
- **Git integration** — stage, commit (with attribution), branch, and open PRs via `gh`.
- **IDE integrations** — VS Code / JetBrains / Cursor with inline diffs and selection context.
- **Code review** — `/code-review` at effort levels, `/security-review`, `--comment` / `--fix`.
- **GitHub Actions** — `@claude` in issues/PRs to implement changes or auto-review every PR.

## 7. Remote Access (from the CLI)
- **Remote control** — attach to your running local terminal session from a browser or phone to view & steer it.
- **Teleport** — `/teleport` pulls a running web/mobile session back into your local terminal.
