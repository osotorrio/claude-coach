# Claude Coach — Learn Claude Code, Hands-On

**Claude Coach** is a hands-on, self-guided course that teaches you Claude Code's features one at a time.
Clone this repo, open it in **Claude Code**, type **`/start-learning`**, and a built-in instructor walks
you through each feature — until you've built a real reference project in **your** language that shows
them off.

No prompt-pasting, no setup beyond cloning. The course lives in [`CLAUDE.md`](./CLAUDE.md), which Claude
Code loads automatically, so the moment you open the repo it already knows how to teach you.

---

## ✅ Prerequisites
- **Claude Code** installed and signed in — see the install guide: https://docs.anthropic.com/en/docs/claude-code
- **git** (to clone this repo).
- **Any language/runtime you like** — the course is language-agnostic and adapts demos to your stack
  (e.g. .NET, Node, Python, Rust, Java). Have that toolchain installed if you want to run the demos.

## 🎚️ Recommended model & effort
Set these **before** you start (the course also recommends them in-session on `/start-learning`):

| Use case | Model | Effort | How to set |
|---|---|---|---|
| **Default — whole course** | **Sonnet 4.6** | **High** | `/model` → Sonnet 4.6, then `/effort high` |
| **Advanced themes** (MCP, hooks, subagents, agent teams) | **Opus 4.8** | High | `/model` → Opus 4.8 (try `/fast` for snappier output) |
| **Quick / low-cost runs** | Haiku 4.5 | medium–high | `/model` → Haiku 4.5 |

Sonnet 4.6 at High effort gives the best balance of teaching quality, speed, and cost across a
multi-session course; bump up to Opus 4.8 for the trickier themes. For effort, `high` is recommended,
`medium` saves tokens, and `xhigh` is rarely needed.

## 🚀 Getting started
```bash
git clone <your-fork-or-this-repo-url> claude-coach
cd claude-coach
claude            # start an interactive Claude Code session in the repo
```
Then, in the session, type:
```
/start-learning
```
(or just say **“start learning”**). The instructor will onboard you with a few quick questions, let you
choose **Full** or **Custom** mode, and begin.

---

## 🔑 Commands & keywords

| Command (slash) | What it does |
|---|---|
| `/start-learning` | Begin the course — onboarding, then the first feature. |
| `/resume-learning` | Resume exactly where you left off (reads your saved progress). |
| `/pause-learning` | Save your progress and stop. |
| `/status-learning` | Show progress: completed / current / remaining + demo folders. |
| `/goto-learning <n>` | Jump straight to a feature by number, e.g. `/goto-learning 15`. |

> All course commands are suffixed **`-learning`** on purpose, so they never collide with Claude Code's
> built-in commands (`/resume`, `/status`, `/compact`, …).

**In-session keywords** (plain text while learning): `next` (advance), `skip` (skip this feature),
`repeat` (re-explain/re-run), `where am I` (recap). Natural phrasing works too.

---

## 🧭 Full vs Custom mode
During onboarding you choose:
- **Full** — all **37 features** in order, beginning → end.
- **Custom** — pick **whole themes and/or individual features**; the instructor builds a custom ordered
  plan just for you and tracks progress against it.

You can change scope or jump around at any time with `/goto-learning`.

---

## 📁 Folder rules
```
learning/   ← the instructor's files (auto-managed). You never edit these.
              _progress.md = your saved state · _notes.md = teaching notes
demos/      ← YOURS. Every hands-on demo + your reference project live here.
              one subfolder per feature: demos/[feature-name]/
```
Anything starting with `_` or inside `learning/` is the instructor's; everything in `demos/` is yours.

## 💾 How progress works
Your state is saved to `learning/_progress.md` automatically after every feature and whenever you pause.
Resuming reads that file and continues from the exact next step — it never restarts you from zero.

---

## 📚 Curriculum — 37 features across 7 themes
Driven by [`claude-code-key-features.md`](./claude-code-key-features.md):

1. **Daily Driver** — interactive session, `@` mentions, `!` shell prefix, image input, slash commands, plan mode, extended thinking, model selection, headless mode.
2. **Context & Memory** — CLAUDE.md, `/init`, `.claude/rules/`, auto memory, context management, sessions, checkpointing/rewind.
3. **Configuration & Control** — settings.json, permission modes, permission rules, env vars, sandboxing, display & UX.
4. **Automation & Extensibility** — skills, hooks, MCP servers, MCP resources & prompts, plugins.
5. **Parallelism & Orchestration** — subagents, explore agent, agent teams, worktrees.
6. **Team Collaboration** — git integration, IDE integrations, code review, GitHub Actions.
7. **Remote Access** — remote control, teleport.

Want every last detail? [`claude-code-features.md`](./claude-code-features.md) is a 400+ feature
deep-reference appendix.

---

## 📄 License
MIT — see [LICENSE](./LICENSE).
