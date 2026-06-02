---
description: Start the hands-on Claude Code course (onboarding, then the first feature)
---
Begin the Claude Code course defined in `CLAUDE.md`.

Ask every choice below with the **`AskUserQuestion` tool** so I pick options with the arrow keys
(recommended option first, suffixed "(Recommended)"; the tool auto-adds an "Other" entry for free text).
This is **not** plan mode — `AskUserQuestion` works in a normal session. See the **ASKING QUESTIONS**
section in `CLAUDE.md` for the exact option sets.

**First, show the model & effort welcome** (per the WELCOME section in `CLAUDE.md`): present the tiers as
a selectable prompt — **Sonnet 4.6 + High (Recommended)** / Opus 4.8 (advanced) / Haiku (budget) / keep
current — then tell me the `/model` and `/effort` commands to run for my pick (the tool can't run them
for me) and confirm before continuing.

Then run the **BEFORE WE START** procedure: check whether `learning/_progress.md` exists. If it does, ask
**Resume (Recommended) / Start over** as a selectable prompt. If it does not, run onboarding — **one
selectable question at a time**: experience level, primary language/project type, end goal (preset
project types + "Other"), and **course mode** (Full vs Custom). For **Custom**, present the 7 themes as
two `multiSelect` questions (themes 1–4 and 5–7). Then create a stack-appropriate `.gitignore`, record
everything in `learning/_progress.md`, and begin the first feature of the active plan using the 3-step
teaching loop. Show the progress line at the top of every message.
