# Feature #25 — MCP Servers (Filesystem)

This folder documents the **Model Context Protocol (MCP)** demo from the Claude Coach course.

## What is MCP?
MCP is an open standard for connecting Claude Code to **external capabilities**. An MCP server is a
separate program that exposes **tools** (and optionally **resources** and **prompts** — see feature #26)
which Claude can call. Tools surface in-session with the naming pattern `mcp__<server>__<tool>`.

## The server we added
We added the official **filesystem** server, scoped to this repo's `demos/` directory:

```sh
claude mcp add filesystem -s project -- npx -y @modelcontextprotocol/server-filesystem "C:\Projects\claude-coach\demos"
```

This wrote the config to **`.mcp.json`** at the repo root.

> **Windows note:** if the server shows `failed` in `/mcp` (an `npx` spawn wrinkle), re-add it with a
> `cmd /c` wrapper:
> ```sh
> claude mcp add filesystem -s project -- cmd /c npx -y @modelcontextprotocol/server-filesystem "C:\Projects\claude-coach\demos"
> ```

## Key concepts demonstrated
- **Transport — `stdio`:** Claude launches the server as a child process and talks over stdin/stdout.
  (Remote servers use `http`/`sse` transports instead.)
- **Scope — `project`:** config lives in `.mcp.json` and is shared with anyone who clones the repo,
  after a one-time approval prompt. Other scopes: `local` (this machine only) and `user` (all your projects).
- **Security boundary:** the server is locked to `C:\Projects\claude-coach\demos` and refuses any read or
  write outside that path. That's why a directory tree only ever shows `demos/`.
- **Discovery:** `/mcp` in the TUI lists connected servers and their tools; `claude mcp list` does the same
  from the shell.

## Tools this server exposes (partial)
`list_directory`, `directory_tree`, `read_text_file`, `read_multiple_files`, `write_file`,
`create_directory`, `move_file`, `search_files`, `get_file_info`, `list_allowed_directories`.

## What we ran
- `mcp__filesystem__directory_tree` on `demos/` — listed the demo subfolders.
- `mcp__filesystem__create_directory` + `mcp__filesystem__write_file` — created this `demos/mcp/` folder
  and wrote **this very README** through the MCP server (not Claude Code's built-in file tools).
