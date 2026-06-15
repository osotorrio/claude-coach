# Git integration (feature #32)

This folder demonstrates **feature #32 — Git integration**: driving the full Git
workflow through Claude Code in natural language.

## What Claude can do with Git
- **Read state:** summarize `git log`, `git status`, `git diff`, and branch tracking in one request.
- **Stage & commit:** select changes and write a structured, conventional-style commit message
  derived from the *actual* diff — not a generic placeholder.
- **Branch & push:** create branches, push to a remote, and open PRs via the `gh` CLI.

## Safety model (course rules in action)
- Claude **never pushes or discards** without an explicit confirmation (the commit-check prompt).
- On the default branch it **branches first** rather than committing straight to `main`.
- Commit messages follow conventional commits (`feat:`, `fix:`, …) and end with a
  `Co-Authored-By: Claude` trailer.

> All coursework happens on the `my-learning` branch, keeping `main` clean.
