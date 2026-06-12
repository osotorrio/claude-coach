---
description: Rewrite my prompt into an optimal AI-coding-agent prompt, show it, and wait for my OK before acting.
---
The text below is my raw request — often dictated by voice, so expect run-on phrasing, filler words,
repeats, and missing punctuation:

$ARGUMENTS

Do the following — do NOT start the actual work yet:
1. Rewrite my request into an improved prompt optimized for an AI coding agent. A good rewrite:
   - Makes the goal explicit and unambiguous.
   - Fills in reasonable missing context/assumptions, and states those assumptions.
   - Structures it into: **Goal**, **Constraints/Requirements**, **Expected output**.
   - Cleans up dictation artifacts.
   - Preserves my original intent; never invents requirements I didn't imply.
2. Print the rewrite in a clearly labeled block titled **"Refined prompt:"**.
3. STOP and ask: **"Proceed with this? (yes / edit)"**.
4. On my response:
   - Approve (yes / go / proceed / ok) -> act on the **refined** prompt, not my original wording.
   - Edits -> apply them, re-show the refined prompt, and ask again.

If `$ARGUMENTS` is empty, ask me to provide the prompt instead of inventing one.
