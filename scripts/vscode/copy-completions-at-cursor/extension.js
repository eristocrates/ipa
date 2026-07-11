const vscode = require("vscode");

const completionKindNames = Object.entries(vscode.CompletionItemKind).reduce((acc, [name, value]) => {
  acc[value] = name;
  return acc;
}, {});

function labelToString(label) {
  if (typeof label === "string") return label;
  if (label && typeof label.label === "string") return label.label;
  return String(label ?? "");
}

function textOrEmpty(value) {
  if (value === undefined || value === null) return "";
  if (typeof value === "string") return value.replace(/\s+/g, " ").trim();
  if (value.value && typeof value.value === "string") return value.value.replace(/\s+/g, " ").trim();
  return String(value).replace(/\s+/g, " ").trim();
}

async function activate(context) {
  const disposable = vscode.commands.registerCommand("copy-completions-at-cursor.copy", async () => {
    const editor = vscode.window.activeTextEditor;
    if (!editor) {
      vscode.window.showWarningMessage("No active editor.");
      return;
    }

    const document = editor.document;
    const position = editor.selection.active;

    let completionList;
    try {
      completionList = await vscode.commands.executeCommand(
        "vscode.executeCompletionItemProvider",
        document.uri,
        position,
        ".",
        10000
      );
    } catch (error) {
      vscode.window.showErrorMessage(`Completion provider failed: ${error.message ?? error}`);
      return;
    }

    const items = completionList && Array.isArray(completionList.items)
      ? completionList.items
      : [];

    if (items.length === 0) {
      vscode.window.showWarningMessage("No completion items were returned at the cursor position.");
      return;
    }

    const header = [
      `Document: ${document.uri.toString()}`,
      `Position: line ${position.line + 1}, character ${position.character + 1}`,
      `Completion items: ${items.length}`,
      "",
      ["index", "label", "kind", "detail", "sortText", "filterText", "insertText", "documentation"].join("\t")
    ];

    const rows = items.map((item, index) => {
      const label = labelToString(item.label);
      const kind = completionKindNames[item.kind] ?? textOrEmpty(item.kind);
      const detail = textOrEmpty(item.detail);
      const sortText = textOrEmpty(item.sortText);
      const filterText = textOrEmpty(item.filterText);
      const insertText = textOrEmpty(item.insertText);
      const documentation = textOrEmpty(item.documentation);

      return [
        index + 1,
        label,
        kind,
        detail,
        sortText,
        filterText,
        insertText,
        documentation
      ].map(value => String(value).replace(/\t/g, " ")).join("\t");
    });

    const output = header.concat(rows).join("\n");

    await vscode.env.clipboard.writeText(output);

    const outputDocument = await vscode.workspace.openTextDocument({
      content: output,
      language: "plaintext"
    });
    await vscode.window.showTextDocument(outputDocument, { preview: false });

    vscode.window.showInformationMessage(`Copied and opened ${items.length} completion items.`);
  });

  context.subscriptions.push(disposable);
}

function deactivate() {}

module.exports = { activate, deactivate };
