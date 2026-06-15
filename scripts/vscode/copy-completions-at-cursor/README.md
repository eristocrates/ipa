# Copy Completions at Cursor

This is a local disposable VS Code extension. It adds one command:

- Copy Completions at Cursor

Usage:

1. Open this folder in VS Code.
2. Press F5.
3. A second VS Code window opens: Extension Development Host.
4. In that second window, open the real project/file where you need completions.
5. Put the cursor immediately after the dot, for example after `A.`.
6. Open the Command Palette.
7. Run `Copy Completions at Cursor`.

The command copies the completion list to the clipboard and also opens it in a new text tab.
