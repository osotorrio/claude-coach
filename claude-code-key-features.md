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

**Interface key:** **CLI** · **Desk** = Desktop app · **IDE** = VS Code / JetBrains · **Web** = claude.ai · **Mob** = Mobile apps

> This is the **curriculum**. `claude-code-features.md` is an optional, exhaustive deep-reference
> appendix (all interfaces) you may cite for detail — it is **not** the lesson order.

---

## 1. Daily Driver — Core Interaction

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 1  | Interactive session | ✓ | ✓ | ✓ | ✓ | ✓ | Start/continue a session on any surface (`claude`, the app, the extension, claude.ai/code). |
| 2  | @ mentions / attach context | ✓ | ✓ | ✓ | ✓ | ✓ | CLI/IDE/Desktop: fuzzy **`@`**. Web/Mobile: attach via file picker or paste. |
| 3  | `!` shell prefix | ✓ | ✓ | ✓ | — | — | Desktop/IDE: only in local, terminal-backed sessions. |
| 4  | Image input | ✓ | ✓ | ✓ | ✓ | ✓ | Paste/drag/upload screenshots & mockups; Mobile via camera or photos. |
| 5  | Voice dictation | — | ✓ | — | ✓ | ✓ | Dictate prompts; most useful on Mobile / Web / Desktop. |
| 6  | Built-in slash commands | ✓ | ✓ | ✓ | ✓ | ✓ | Web/Mobile expose a **subset** (no filesystem- or CLI-only commands). |
| 7  | Plan mode | ✓ | ✓ | ✓ | ✓ | — | CLI/IDE: Shift+Tab. Web: via the session menu. |
| 8  | Extended thinking & effort levels | ✓ | ✓ | ✓ | ✓ | ✓ | Thinking is everywhere; CLI-style effort levels (`/effort`, `/fast`) are CLI/Desktop/IDE. |
| 9  | Model selection | ✓ | ✓ | ✓ | ✓ | ✓ | A model picker (Opus / Sonnet / Haiku) on every surface. |
| 10 | Headless mode & piping | ✓ | — | — | — | — | `claude -p "…"` for scripts; pipe logs/diffs in, text/JSON out. **CLI only.** |

## 2. Context & Memory

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 11 | CLAUDE.md | ✓ | ✓ | ✓ | ✓ | — | Web cloud sessions honor the repo's CLAUDE.md; you author it on CLI/Desktop/IDE. |
| 12 | `/init` | ✓ | ✓ | ✓ | ✓ | — | Auto-generate a starter CLAUDE.md from the codebase. |
| 13 | `.claude/rules/` | ✓ | ✓ | ✓ | ✓ | — | Path-scoped instruction files; honored wherever the repo is loaded. |
| 14 | Auto memory (`/memory`) | ✓ | ✓ | ✓ | — | — | Cross-session notes in local `~/.claude`; CLI/Desktop/IDE share it. |
| 15 | Projects | — | ✓ | — | ✓ | ✓ | claude.ai **project knowledge + custom instructions** — the GUI analog of CLAUDE.md. |
| 16 | Context management (`/compact`, `/clear`) | ✓ | ✓ | ✓ | ✓ | ✓ | GUIs auto-manage context; the commands may live in a menu. |
| 17 | Sessions (resume / continue) | ✓ | ✓ | ✓ | ✓ | ✓ | CLI: `--resume` / `--continue`. GUIs: a session list/history. |
| 18 | Checkpointing / rewind | ✓ | ✓ | ✓ | — | — | Roll file changes back to an earlier point within a session (local edits). |

## 3. Configuration & Control

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 19 | settings.json (layered config) | ✓ | ✓ | ✓ | — | — | File-based (user → project → local → managed). Web/Mobile use **in-app preferences** instead. |
| 20 | Permission modes | ✓ | ✓ | ✓ | — | — | `default`/`acceptEdits`/`plan`/`bypassPermissions`. Web/Mobile prompt for approval but don't expose the named modes. |
| 21 | Permission rules (allow / deny / ask) | ✓ | ✓ | ✓ | — | — | Per-tool patterns, e.g. `Bash(npm run *)`. File-based. |
| 22 | Environment variables | ✓ | ✓ | ✓ | — | — | Auth, MCP timeouts, telemetry. Desktop/IDE inherit the launch env. |
| 23 | Sandboxing | ✓ | ✓ | ✓ | ✓ | — | Local: OS sandbox (Seatbelt/bubblewrap) via settings. Web: cloud sessions are sandboxed by default. |
| 24 | Display & UX | ✓ | ✓ | ✓ | ✓ | ✓ | CLI exposes all (output styles, status line, vim, keybindings); GUIs expose appearance/theme. |

## 4. Automation & Extensibility

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 25 | Skills (custom slash commands) | ✓ | ✓ | ✓ | ✓ | — | Repo/user skills; cloud sessions run them, but you author on CLI/Desktop/IDE. |
| 26 | Hooks | ✓ | ✓ | ✓ | — | — | Run scripts/HTTP/agents on lifecycle events (pre/post tool use, start, stop…). Local config. |
| 27 | MCP servers | ✓ | ✓ | ✓ | — | — | Connect external tools & data over stdio/HTTP. On Web/Mobile the equivalent is **Connectors (#28)**. |
| 28 | Connectors | — | ✓ | — | ✓ | ✓ | claude.ai's MCP-backed integrations — the **GUI counterpart to MCP servers**; enable from a catalog. |
| 29 | MCP resources & prompts | ✓ | ✓ | ✓ | — | — | `@server:…` to attach data; `/mcp__server__prompt` to run prompts. |
| 30 | Plugins | ✓ | ✓ | ✓ | — | — | Bundle skills + hooks + MCP + subagents into one installable unit; share via marketplaces. |

## 5. Parallelism & Orchestration

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 31 | Subagents | ✓ | ✓ | ✓ | ✓ | — | Delegate to specialized agents with their own context, tools, and model. Cloud sessions can spawn them. |
| 32 | Explore agent | ✓ | ✓ | ✓ | ✓ | — | Built-in fast read-only codebase search that keeps your main context clean. |
| 33 | Agent teams | ✓ | ✓ | ✓ | — | — | Run multiple agents on subtasks at once; the monitoring view is CLI/Desktop/IDE. |
| 34 | Worktrees | ✓ | ✓ | ✓ | — | — | Parallel sessions on isolated branches (local git worktrees). |

## 6. Team Collaboration

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 35 | Git integration | ✓ | ✓ | ✓ | ✓ | ✓ | Stage, commit (with attribution), branch, open PRs. Web/Mobile commit & open PRs on a **cloud branch**. |
| 36 | Inline diffs & accept/reject | — | ✓ | ✓ | — | — | Visual diff review with accept/reject controls (IDE/Desktop). CLI shows text diffs in-terminal. |
| 37 | Selection-context sharing | — | — | ✓ | — | — | Send the current editor selection to Claude. **IDE only.** |
| 38 | Code review (`/code-review`, `/security-review`) | ✓ | ✓ | ✓ | ✓ | — | Effort levels, `--comment` / `--fix`. Ultrareview runs in the cloud. |
| 39 | GitHub / GitLab automation (`@claude`, Actions) | ✓ | — | — | — | — | Server-side CI; set up from CLI (`/install-github-app`), triggered by `@claude` in PRs/issues. |
| 40 | Visual multi-session view | — | ✓ | — | ✓ | — | Monitor multiple running sessions; richest in the Desktop app (Web lists cloud sessions). |

## 7. Remote Access & Cross-Device

| #  | Feature | CLI | Desk | IDE | Web | Mob | Notes |
|----|---------|:---:|:----:|:---:|:---:|:---:|-------|
| 41 | Desktop app | — | ✓ | — | — | — | Standalone app: visual diffs, multi-session, **local scheduled tasks**, SSH connections. |
| 42 | Web app (Claude Code on the web) | — | — | — | ✓ | ✓ | claude.ai/code: cloud sessions, remote repos, long-running tasks, environments. Reachable from Mobile. |
| 43 | Mobile apps (iOS / Android) | — | — | — | — | ✓ | Start/continue sessions on the go; push notifications. |
| 44 | Scheduled tasks & routines | ✓ | ✓ | — | ✓ | ✓ | `/loop` (in-session) + cloud **routines** (`/schedule`) that run when your machine is off. |
| 45 | Dispatch | — | ✓ | — | — | ✓ | Send a task from your phone to a running **Desktop** session. |
| 46 | Remote control | ✓ | ✓ | — | ✓ | ✓ | Attach to a running CLI/Desktop session (the **host**) from a browser/phone (the **controller**). |
| 47 | Teleport | ✓ | ✓ | — | ✓ | ✓ | Pull a cloud Web/Mobile session (the **source**) down into a local CLI/Desktop terminal (the **target**). |
| 48 | `/desktop` handoff | ✓ | ✓ | — | — | — | Hand a running terminal session to the Desktop app for visual review. |

---

*48 features across 7 themes, five interfaces. Shared features show per-interface differences in Notes;
single-✓ rows are interface-specific. For exhaustive per-setting detail, see `claude-code-features.md`.*
