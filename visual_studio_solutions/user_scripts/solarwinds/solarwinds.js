// ==UserScript==
// @name         IPA
// @namespace    http://tampermonkey.net/
// @version      2026-01-22
// @description  try to take over the world!
// @author       You
// @match        https://leoncountyfl.samanage.com/*
// @icon         https://www.google.com/s2/favicons?sz=64&domain=samanage.com
// @grant        none
// ==/UserScript==
(() => {
  "use strict";

  // You will set this before running.
  const custom =
    "https://leoncountyfl.samanage.com/custom.json?context=incidents&is_portal_mode=false";

  // ---- UI ----
  const panel = document.createElement("div");
  panel.id = "ipa-panel";
  panel.style.position = "fixed";
  panel.style.top = "12px";
  panel.style.right = "12px";
  panel.style.zIndex = "2147483647";
  panel.style.padding = "10px 12px";
  panel.style.border = "1px solid rgba(0,0,0,0.2)";
  panel.style.borderRadius = "10px";
  panel.style.background = "rgba(20,20,20,0.92)";
  panel.style.color = "#fff";
  panel.style.font =
    "12px/1.35 system-ui, -apple-system, Segoe UI, Roboto, Arial, sans-serif";
  panel.style.boxShadow = "0 8px 30px rgba(0,0,0,0.35)";
  panel.style.minWidth = "260px";

  const title = document.createElement("div");
  title.textContent = "Fetch + Save";
  title.style.fontWeight = "600";
  title.style.marginBottom = "6px";

  const status = document.createElement("div");
  status.textContent = "Status: idle";
  status.style.opacity = "0.9";
  status.style.marginBottom = "8px";
  status.style.whiteSpace = "nowrap";
  status.style.overflow = "hidden";
  status.style.textOverflow = "ellipsis";

  const btn = document.createElement("button");
  btn.textContent = "Fetch custom and download";
  btn.style.width = "100%";
  btn.style.cursor = "pointer";
  btn.style.padding = "8px 10px";
  btn.style.borderRadius = "8px";
  btn.style.border = "1px solid rgba(255,255,255,0.25)";
  btn.style.background = "rgba(255,255,255,0.12)";
  btn.style.color = "#fff";
  btn.style.font = "inherit";

  const hint = document.createElement("div");
  hint.textContent = "Downloads response as a file.";
  hint.style.marginTop = "8px";
  hint.style.opacity = "0.7";

  panel.appendChild(title);
  panel.appendChild(status);
  panel.appendChild(btn);
  panel.appendChild(hint);
  document.documentElement.appendChild(panel);

  // ---- Helpers ----
  function setStatus(text) {
    status.textContent = `Status: ${text}`;
  }

  function downloadText(filename, text) {
    const blob = new Blob([text], { type: "text/plain;charset=utf-8" });
    const url = URL.createObjectURL(blob);

    const a = document.createElement("a");
    a.href = url;
    a.download = filename;
    a.style.display = "none";
    document.body.appendChild(a);
    a.click();

    // Cleanup
    setTimeout(() => {
      URL.revokeObjectURL(url);
      a.remove();
    }, 500);
  }

  function safeFilenameFromUrl(u) {
    try {
      const url = new URL(u, location.href);
      const path = url.pathname
        .replace(/[\/\\]+/g, "_")
        .replace(/[^a-zA-Z0-9._-]/g, "_");
      return path && path !== "_" ? path : "response";
    } catch {
      return "response";
    }
  }

  // ---- Action ----
  let inFlight = false;

  btn.addEventListener("click", async () => {
    if (inFlight) return;
    inFlight = true;
    btn.disabled = true;
    btn.style.opacity = "0.7";

    try {
      setStatus("fetching…");

      // Running inside the authenticated browser context means cookies are included automatically.
      // credentials: 'include' is explicit; same-origin cookies are included by default, but this is clearer.
      const resp = await fetch(custom, {
        method: "GET",
        credentials: "include",
        redirect: "follow",
      });

      // If you expect JSON, you can switch to: await resp.text() is safest for arbitrary responses.
      const bodyText = await resp.text();

      const ts = new Date();
      const iso = ts.toISOString().replace(/[:.]/g, "-");
      const base = safeFilenameFromUrl(custom);
      const filename = `${base}_${iso}_http${resp.status}.txt`;

      downloadText(filename, bodyText);

      setStatus(`saved (${resp.status}) → ${filename}`);
    } catch (err) {
      setStatus(`error: ${String(err && err.message ? err.message : err)}`);
      console.error("Fetch+Save userscript error:", err);
    } finally {
      inFlight = false;
      btn.disabled = false;
      btn.style.opacity = "1";
    }
  });
})();
