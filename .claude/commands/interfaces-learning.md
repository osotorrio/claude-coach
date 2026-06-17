---
description: Add, remove, or change which Claude interfaces you're learning
---
Change the interfaces for the Claude course, per the **INTERFACE SELECTION** section in `CLAUDE.md`.

Re-ask the two `multiSelect` questions with the **`AskUserQuestion` tool** (Q1: CLI / Desktop app / IDE
extension / Web; Q2: Mobile apps / Skip mobile), reflecting my current selection. Then update Learner
Profile → **Interfaces** in `learning/_progress.md` and recompute `TOTAL`:
- **On add** — for already-completed features that apply to a newly-added interface, mark those interface
  demos **pending** and offer a **catch-up pass**; include the new interface in every future feature's loop.
- **On remove** — keep the completed records; stop offering new demos for that interface. Then **re-filter
  the active plan**: drop any feature that now applies to **no** selected interface (don't count it in
  `TOTAL`), and if the **current** feature is one of those, advance to the next applicable feature so the
  course never stalls.

Then show the updated progress line.
