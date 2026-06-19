# Claude — Key Features Every Engineer Should Learn

*A scannable cheat sheet. Grouped by theme; within each theme, basics first → advanced last.*
*Scope: all the ways you work with Claude — the **CLI**, the **Desktop** app, the **IDE** extension
(VS Code / JetBrains / Cursor), the **Web** app (claude.ai), and the **Mobile** apps (iOS / Android).*

## How to read this
- Each feature has one **global number (`#`)**, ordered **basic → advanced** across the whole course.
- The five interface columns show where a feature applies: **✓** = available · **—** = not applicable.
- A feature with **✓ in two or more** columns is **shared**; the **Notes** column flags any
  per-interface differences.
- A feature with **✓ in exactly one** column is **interface-specific**.

**Interface key:** **CLI** · **Desk** = Desktop app · **IDE** = VS Code / JetBrains / Cursor · **Web** = claude.ai · **Mob** = Mobile apps

> This is the **curriculum**. `claude-code-features.md` is an optional, exhaustive deep-reference
> appendix (all interfaces) you may cite for detail — it is **not** the lesson order.

---

## 1. Daily Driver — Core Interaction

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 1  | Interactive session | ✓ | ✓ | ✓ | ✓ | ✓ | Start/continue a session on any surface (`claude`, the app, the extension, claude.ai/code); manage its working directories with `/add-dir` and relocate with `/cd`. |
| 2  | @ mentions / attach context | ✓ | ✓ | ✓ | ✓ | ✓ | CLI/IDE/Desktop: fuzzy **`@`**. Web/Mobile: attach via file picker or paste. |
| 3  | `!` shell prefix | ✓ | ✓ | ✓ | — | — | Desktop/IDE: only in local, terminal-backed sessions. |
| 4  | Image input | ✓ | ✓ | ✓ | ✓ | ✓ | Paste/drag/upload screenshots & mockups; Mobile via camera or photos. |
| 5  | Voice dictation | ✓ | ✓ | — | ✓ | ✓ | Dictate prompts; CLI via `/voice` (`hold`/`tap`/`off`, needs a claude.ai account). Most useful on Mobile / Web / Desktop. |
| 6  | Built-in slash commands | ✓ | ✓ | ✓ | ✓ | ✓ | Web/Mobile expose a **subset** (no filesystem- or CLI-only commands). |
| 7  | Plan mode | ✓ | ✓ | ✓ | ✓ | — | CLI/IDE: Shift+Tab or `/plan`. Web: via the session menu. `/ultraplan` drafts a plan in the cloud to review in-browser. |
| 8  | Extended thinking & effort levels | ✓ | ✓ | ✓ | ✓ | ✓ | Thinking is everywhere; CLI-style effort levels (`/effort`, `/fast`) are CLI/Desktop/IDE. |
| 9  | Model selection | ✓ | ✓ | ✓ | ✓ | ✓ | A model picker (Opus / Sonnet / Haiku) on every surface. |
| 10 | Headless mode & piping | ✓ | — | — | — | — | `claude -p "…"` for scripts; pipe logs/diffs in, text/JSON out. **CLI only.** |
| 11 | Run & verify your app | ✓ | ✓ | ✓ | ✓ | — | Bundled skills (`/run`, `/verify`, `/run-skill-generator`, v2.1.145+): drive the **running** app to confirm a change works, not just tests. `/run-skill-generator` records a per-project launch recipe; cloud sessions can run them too. |

## 2. Context & Memory

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 12 | CLAUDE.md | ✓ | ✓ | ✓ | ✓ | — | Web cloud sessions honor the repo's CLAUDE.md; you author it on CLI/Desktop/IDE. |
| 13 | `/init` | ✓ | ✓ | ✓ | ✓ | — | Auto-generate a starter CLAUDE.md from the codebase. |
| 14 | `.claude/rules/` | ✓ | ✓ | ✓ | ✓ | — | Path-scoped instruction files; honored wherever the repo is loaded. |
| 15 | Auto memory (`/memory`) | ✓ | ✓ | ✓ | — | — | Cross-session notes in local `~/.claude`; CLI/Desktop/IDE share it. |
| 16 | Projects | — | ✓ | — | ✓ | ✓ | claude.ai **project knowledge + custom instructions** — the GUI analog of CLAUDE.md. |
| 17 | Context management (`/compact`, `/clear`) | ✓ | ✓ | ✓ | ✓ | ✓ | `/context` visualizes window usage; `/compact`/`/clear` free it; `/export` saves the transcript. GUIs auto-manage context; commands may live in a menu. |
| 18 | Sessions (resume / continue) | ✓ | ✓ | ✓ | ✓ | ✓ | CLI: `--resume` / `--continue`. GUIs: a session list/history. |
| 19 | Conversation branching | ✓ | ✓ | ✓ | — | — | `/branch` forks the **conversation** to try another direction without losing the current thread (return via `/resume`); `/fork` (v2.1.161+) hands a copy to a background subagent instead. Local sessions. |
| 20 | Checkpointing / rewind | ✓ | ✓ | ✓ | — | — | Roll file changes back to an earlier point within a session (local edits). |

## 3. Configuration & Control

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 21 | settings.json (layered config) | ✓ | ✓ | ✓ | — | — | File-based (user → project → local → managed). Web/Mobile use **in-app preferences** instead. |
| 22 | Permission modes | ✓ | ✓ | ✓ | — | — | `default`/`acceptEdits`/`plan`/`bypassPermissions`. Web/Mobile prompt for approval but don't expose the named modes. |
| 23 | Permission rules (allow / deny / ask) | ✓ | ✓ | ✓ | — | — | Per-tool patterns, e.g. `Bash(npm run *)`. File-based. |
| 24 | Environment variables | ✓ | ✓ | ✓ | — | — | Auth, MCP timeouts, telemetry. Desktop/IDE inherit the launch env. |
| 25 | Sandboxing | ✓ | ✓ | ✓ | ✓ | — | Local: OS sandbox (Seatbelt/bubblewrap) via settings. Web: cloud sessions are sandboxed by default. |
| 26 | Display & UX | ✓ | ✓ | ✓ | ✓ | ✓ | CLI exposes all — `/theme`, `/statusline`, `/keybindings`, `/focus`, `/tui`; output style & Vim mode are now set via `/config`. GUIs expose appearance/theme. |
| 27 | Usage & cost tracking | ✓ | ✓ | ✓ | ✓ | ✓ | `/usage` (`/cost`, `/stats`) shows session cost, plan limits, and a per-skill/subagent/plugin/MCP breakdown; pair with `/context` (#17) to see context-window budget. GUIs surface usage & limits in account/settings. |

## 4. Automation & Extensibility

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 28 | Skills (custom slash commands) | ✓ | ✓ | ✓ | ✓ | — | Repo/user skills; cloud sessions run them, but you author on CLI/Desktop/IDE. |
| 29 | Hooks | ✓ | ✓ | ✓ | — | — | Run scripts/HTTP/agents on lifecycle events (pre/post tool use, start, stop…). Local config. |
| 30 | MCP servers | ✓ | ✓ | ✓ | — | — | Connect external tools & data over stdio/HTTP. On Web/Mobile the equivalent is **Connectors (#31)**. |
| 31 | Connectors | — | ✓ | — | ✓ | ✓ | claude.ai's MCP-backed integrations — the **GUI counterpart to MCP servers**; enable from a catalog. |
| 32 | MCP resources & prompts | ✓ | ✓ | ✓ | — | — | `@server:…` to attach data; `/mcp__server__prompt` to run prompts. |
| 33 | Plugins | ✓ | ✓ | ✓ | — | — | Bundle skills + hooks + MCP + subagents into one installable unit; share via marketplaces. |

## 5. Parallelism & Orchestration

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 34 | Subagents | ✓ | ✓ | ✓ | ✓ | — | Delegate to specialized agents with their own context, tools, and model. Cloud sessions can spawn them. |
| 35 | Explore agent | ✓ | ✓ | ✓ | ✓ | — | Built-in fast read-only codebase search that keeps your main context clean. |
| 36 | Agent teams | ✓ | ✓ | ✓ | — | — | Run multiple agents on subtasks at once; the monitoring view is CLI/Desktop/IDE. |
| 37 | Worktrees | ✓ | ✓ | ✓ | — | — | Parallel sessions on isolated branches (local git worktrees). |
| 38 | Goal-driven autonomy | ✓ | ✓ | ✓ | — | — | `/goal` keeps Claude working across turns **until a condition is met** (vs `/loop`'s time interval, #50). Also drivable headless (`-p`) and via Remote Control. |
| 39 | Background & forked agents | ✓ | ✓ | ✓ | — | — | Detach a session to run async (`/background` / `/bg`), fork a conversation-aware subagent (`/fork`), and monitor with `/tasks`; `/batch` decomposes a large change into per-worktree subagents. Local sessions. |

## 6. Team Collaboration

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 40 | Git integration | ✓ | ✓ | ✓ | ✓ | ✓ | Stage, commit (with attribution), branch, open PRs. Web/Mobile commit & open PRs on a **cloud branch**. |
| 41 | Inline diffs & accept/reject | — | ✓ | ✓ | — | — | Visual diff review with accept/reject controls (IDE/Desktop). CLI shows text diffs in-terminal. |
| 42 | Selection-context sharing | — | — | ✓ | — | — | Send the current editor selection to Claude. **IDE only.** |
| 43 | Code review (`/code-review`, `/security-review`) | ✓ | ✓ | ✓ | ✓ | — | Effort levels, `--comment` / `--fix`; `/review` for a local PR pass, `/simplify` for cleanup-only. `/code-review ultra` (ultrareview) runs in the cloud. |
| 44 | GitHub / GitLab automation (`@claude`, Actions) | ✓ | — | — | — | — | Server-side CI; set up from CLI (`/install-github-app`), triggered by `@claude` in PRs/issues. |
| 45 | Cloud PR autofix | ✓ | ✓ | ✓ | ✓ | — | `/autofix-pr` spawns a Claude Code on the web session that watches your branch's PR and pushes fixes when CI fails or reviewers comment. Initiated locally (needs `gh` + web access); runs in the cloud. |
| 46 | Visual multi-session view | — | ✓ | — | ✓ | — | Monitor multiple running sessions; richest in the Desktop app (Web lists cloud sessions). |

## 7. Remote Access & Cross-Device

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 47 | Desktop app | — | ✓ | — | — | — | Standalone app: visual diffs, multi-session, **local scheduled tasks**, SSH connections. |
| 48 | Web app (Claude Code on the web) | — | — | — | ✓ | ✓ | claude.ai/code: cloud sessions, remote repos, long-running tasks, environments. Reachable from Mobile. |
| 49 | Mobile apps (iOS / Android) | — | — | — | — | ✓ | Start/continue sessions on the go; push notifications. |
| 50 | Scheduled tasks & routines | ✓ | ✓ | — | ✓ | ✓ | `/loop` (in-session) + cloud **routines** (`/schedule`) that run when your machine is off. |
| 51 | Dispatch | — | ✓ | — | — | ✓ | Send a task from your phone to a running **Desktop** session. |
| 52 | Remote control | ✓ | ✓ | — | ✓ | ✓ | Attach to a running CLI/Desktop session (the **host**) from a browser/phone (the **controller**). |
| 53 | Teleport | ✓ | ✓ | — | ✓ | ✓ | Pull a cloud Web/Mobile session (the **source**) down into a local CLI/Desktop terminal (the **target**). |
| 54 | `/desktop` handoff | ✓ | ✓ | — | — | — | Hand a running terminal session to the Desktop app for visual review. |

---

*54 features across 7 themes, five interfaces. Shared features show per-interface differences in Notes;
single-✓ rows are interface-specific. For exhaustive per-setting detail, see `claude-code-features.md`.*
