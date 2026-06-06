# Claude Coach — CLI Tool Project
<!-- Last reviewed: 2026-06-06 -->

## Stack
- **Language:** C# / .NET 8+
- **Shell:** PowerShell (Windows)
- **Test framework:** xUnit
- **Build:** `dotnet build` / `dotnet run` / `dotnet test`

## Coding conventions
- Prefer **records** for immutable data (commands, options, results).
- Use **pattern matching** (`switch` expressions, `is`, positional patterns) over long `if/else` chains.
- Keep methods short; extract to private helpers rather than adding comments.
- No `var` when the type isn't obvious from the right-hand side.
- Async all the way down — no `.Result` or `.Wait()`.

## Project structure
```
demos/
  claude-md/        ← CLAUDE.md demo (this feature)
  image-input/      ← Program.cs created from screenshot (feature #4)
  [feature-name]/   ← one subfolder per hands-on demo
learning/           ← INSTRUCTOR-MANAGED — do not edit
  _progress.md
  _notes.md
```

## Off-limits
- `learning/` and any `_`-prefixed file are managed by the Claude Coach instructor brain.
  Do **not** create, edit, or delete anything inside `learning/`.

## Useful commands
```powershell
dotnet build
dotnet run --project src/CliTool
dotnet test
```

## Maintenance
If you notice anything in this file that contradicts the actual code (missing folders, wrong commands, outdated conventions), flag it before starting work. Update the `Last reviewed` date at the top when you make corrections.
