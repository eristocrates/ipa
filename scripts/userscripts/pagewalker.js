// ==UserScript==
// @name         Pagination Inspector + Walker (Click -> Wait -> Reinspect)
// @namespace    https://example.local/
// @version      1.4.0
// @description  Slide panel to inspect pagination container and paginate by repeating: inspect -> click Next -> wait 1s -> inspect (persists selector per-site).
// @match        *://*/*
// @grant        GM_getValue
// @grant        GM_setValue
// ==/UserScript==

(function () {
  "use strict";

  /* -----------------------------------------------------------
     Persistence (per-site, keyed by origin)
  ----------------------------------------------------------- */

  const STORAGE_KEY = "pagination_inspector_per_site_config_v5";

  function getSiteKey() {
    return window.location.origin;
  }

  function loadAllConfig() {
    const data = GM_getValue(STORAGE_KEY, null);
    return data && typeof data === "object" ? data : {};
  }

  function saveAllConfig(all) {
    GM_setValue(STORAGE_KEY, all);
  }

  function loadSiteConfig() {
    const all = loadAllConfig();
    return (
      all[getSiteKey()] || {
        paginationSelector: "",
        isPaginating: false,
      }
    );
  }

  function saveSiteConfig(partial) {
    const all = loadAllConfig();
    const key = getSiteKey();
    const existing = all[key] || {
      paginationSelector: "",
      isPaginating: false,
    };
    all[key] = { ...existing, ...partial };
    saveAllConfig(all);
  }

  /* -----------------------------------------------------------
     Tunables
  ----------------------------------------------------------- */

  const STEP_WAIT_MS = 1000; // what you asked for
  const LOOP_TICK_MIN_MS = 50; // internal guard for tight loops
  const MAX_NO_PROGRESS_CYCLES = 5; // safety stop if DOM appears unchanged repeatedly

  function sleep(ms) {
    return new Promise((resolve) => setTimeout(resolve, ms));
  }

  /* -----------------------------------------------------------
     Panel UI (default CLOSED)
  ----------------------------------------------------------- */

  const panel = document.createElement("div");
  panel.id = "pagination-inspector-panel";

  panel.innerHTML = `
    <div class="pi-handle" id="pi-handle" title="Toggle panel">▶</div>

    <div class="header">
      <strong>Pagination Inspector</strong>
      <span class="pi-origin" id="pi-origin"></span>
    </div>

    <div class="body">
      <div class="controls">
        <button id="pi-set">Set selector</button>
        <button id="pi-clear">Clear saved</button>
        <button id="pi-paginate">Paginate</button>
      </div>

      <div class="status" id="pi-status"></div>
      <div class="meta" id="pi-meta"></div>
      <div id="pi-results"></div>
    </div>
  `;

  document.documentElement.appendChild(panel);

  const style = document.createElement("style");
  style.textContent = `
    #pagination-inspector-panel {
      position: fixed;
      top: 0;
      left: 0;
      height: 100vh;
      width: 460px;
      background: #111;
      color: #eee;
      font-family: monospace;
      font-size: 12px;
      border-right: 1px solid #444;
      transform: translateX(-100%);
      transition: transform 0.25s ease;
      z-index: 999999;
      display: flex;
      flex-direction: column;
    }
    #pagination-inspector-panel.open { transform: translateX(0); }

    #pagination-inspector-panel .pi-handle {
      position: absolute;
      top: 16px;
      right: -28px;
      width: 28px;
      height: 72px;
      background: #222;
      border: 1px solid #444;
      border-left: none;
      color: #eee;
      display: flex;
      align-items: center;
      justify-content: center;
      cursor: pointer;
      user-select: none;
      border-top-right-radius: 6px;
      border-bottom-right-radius: 6px;
      box-shadow: 0 0 0 1px rgba(0,0,0,0.25);
    }

    #pagination-inspector-panel .header {
      padding: 8px 10px;
      background: #222;
      display: flex;
      align-items: baseline;
      gap: 8px;
      border-bottom: 1px solid #333;
    }

    #pagination-inspector-panel .pi-origin {
      color: #aaa;
      font-size: 11px;
      white-space: nowrap;
      overflow: hidden;
      text-overflow: ellipsis;
      max-width: 300px;
    }

    #pagination-inspector-panel .body {
      padding: 8px;
      overflow-y: auto;
      flex: 1;
    }

    #pagination-inspector-panel .controls {
      display: flex;
      gap: 8px;
      margin-bottom: 10px;
      flex-wrap: wrap;
    }

    #pagination-inspector-panel button {
      padding: 6px 10px;
      background: #333;
      color: #eee;
      border: 1px solid #555;
      cursor: pointer;
    }

    #pagination-inspector-panel button.danger {
      border-color: #a33;
    }

    #pagination-inspector-panel .status {
      margin-bottom: 8px;
      color: #bbb;
      white-space: pre-wrap;
    }

    #pagination-inspector-panel .meta {
      margin: 6px 0 10px 0;
      color: #bbb;
      border: 1px solid #2a2a2a;
      background: #151515;
      padding: 6px;
      word-break: break-word;
      white-space: pre-wrap;
    }

    #pagination-inspector-panel .result-item {
      margin-bottom: 6px;
      padding: 6px;
      border: 1px solid #333;
      background: #181818;
      word-break: break-word;
    }

    #pagination-inspector-panel .next-candidate {
      border-color: #4caf50;
      background: #1e2b1e;
    }

    #pagination-inspector-panel .error { color: #f44336; }
  `;
  document.head.appendChild(style);

  const handle = panel.querySelector("#pi-handle");

  function setHandleGlyph() {
    handle.textContent = panel.classList.contains("open") ? "◀" : "▶";
  }

  function openPanel() {
    if (!panel.classList.contains("open")) {
      panel.classList.add("open");
      setHandleGlyph();
    }
  }

  handle.addEventListener("click", () => {
    panel.classList.toggle("open");
    setHandleGlyph();
    if (panel.classList.contains("open")) {
      const cfg = loadSiteConfig();
      const sel = (cfg.paginationSelector || "").trim();
      if (sel) inspect(sel);
    }
  });

  setHandleGlyph();

  /* -----------------------------------------------------------
     UI refs / helpers
  ----------------------------------------------------------- */

  const originSpan = panel.querySelector("#pi-origin");
  const statusDiv = panel.querySelector("#pi-status");
  const metaDiv = panel.querySelector("#pi-meta");
  const resultsDiv = panel.querySelector("#pi-results");
  const paginateBtn = panel.querySelector("#pi-paginate");

  originSpan.textContent = getSiteKey();

  function setStatus(text, isError) {
    statusDiv.innerHTML = isError ? `<span class="error">${text}</span>` : text;
  }

  function setMeta(text) {
    metaDiv.textContent = text || "";
  }

  function clearResults() {
    resultsDiv.innerHTML = "";
  }

  function refreshPaginateButtonAppearance() {
    const cfg = loadSiteConfig();
    if (cfg.isPaginating) {
      paginateBtn.textContent = "Stop";
      paginateBtn.classList.add("danger");
    } else {
      paginateBtn.textContent = "Paginate";
      paginateBtn.classList.remove("danger");
    }
  }

  /* -----------------------------------------------------------
     Pagination detection + inspection
  ----------------------------------------------------------- */

  function detectNextLink(anchors) {
    for (const a of anchors) {
      if ((a.getAttribute("rel") || "").toLowerCase() === "next") return a;
    }
    for (const a of anchors) {
      const label = (a.getAttribute("aria-label") || "").toLowerCase();
      if (label.includes("next")) return a;
    }
    for (const a of anchors) {
      const text = (a.textContent || "").trim().toLowerCase();
      if (text.includes("next") || text === ">" || text === "»") return a;
    }
    return null;
  }

  function linkIsDisabled(el) {
    if (!el) return true;

    const ariaDisabled = (el.getAttribute("aria-disabled") || "").toLowerCase();
    if (ariaDisabled === "true") return true;

    const href = el.getAttribute("href");
    if (!href || !href.trim()) return true;

    const parentLi = el.closest("li");
    if (parentLi && parentLi.classList.contains("disabled")) return true;

    return false;
  }

  function renderAnchor(a, isNext) {
    const div = document.createElement("div");
    div.className = "result-item" + (isNext ? " next-candidate" : "");
    div.innerHTML = `
      <div><strong>Text:</strong> ${(a.textContent || "").trim()}</div>
      <div><strong>Href:</strong> ${a.getAttribute("href") || "(none)"}</div>
      <div><strong>rel:</strong> ${a.getAttribute("rel") || "(none)"}</div>
      <div><strong>aria-label:</strong> ${a.getAttribute("aria-label") || "(none)"}</div>
    `;
    resultsDiv.appendChild(div);
  }

  function inspect(selector) {
    clearResults();

    if (!selector) {
      setStatus(
        "No selector saved for this site. Click “Set selector”.",
        false,
      );
      setMeta("");
      return { container: null, anchors: [], next: null, signature: "" };
    }

    setStatus(`Using saved selector: ${selector}`, false);
    setMeta("");

    let container;
    try {
      container = document.querySelector(selector);
    } catch {
      setStatus(
        "Saved selector is invalid CSS. Click “Set selector” to fix it.",
        true,
      );
      setMeta(selector);
      return { container: null, anchors: [], next: null, signature: "" };
    }

    if (!container) {
      setStatus(
        "Selector is valid, but no element matched on this page (yet).",
        true,
      );
      setMeta(selector);
      return { container: null, anchors: [], next: null, signature: "" };
    }

    const anchors = Array.from(container.querySelectorAll("a"));
    if (anchors.length === 0) {
      setStatus("Container matched, but contains no <a> elements.", true);
      setMeta(`Matched: ${container.tagName.toLowerCase()} (anchors: 0)`);
      return {
        container,
        anchors: [],
        next: null,
        signature: container.innerHTML,
      };
    }

    const nextCandidate = detectNextLink(anchors);

    const containerId = container.id ? `#${container.id}` : "";
    const containerClasses = container.className
      ? "." + String(container.className).trim().replace(/\s+/g, ".")
      : "";

    setMeta(
      `Matched: ${container.tagName.toLowerCase()}${containerId}${containerClasses}\n` +
        `Anchors: ${anchors.length}\n` +
        `Next detected: ${nextCandidate ? "YES" : "NO"}\n` +
        `Next disabled: ${nextCandidate ? String(linkIsDisabled(nextCandidate)) : "n/a"}\n` +
        `URL: ${window.location.href}`,
    );

    for (const a of anchors) renderAnchor(a, a === nextCandidate);

    // Signature used only for “no progress” detection
    const signature = container.innerHTML;

    return { container, anchors, next: nextCandidate, signature };
  }

  /* -----------------------------------------------------------
     Paginate loop: click -> wait 1s -> reinspect -> repeat
  ----------------------------------------------------------- */

  let loopRunningInMemory = false;

  async function paginateLoop() {
    if (loopRunningInMemory) return;
    loopRunningInMemory = true;

    let noProgressCycles = 0;
    let lastSignature = null;
    let lastUrl = null;

    try {
      while (true) {
        const cfg = loadSiteConfig();
        if (!cfg.isPaginating) {
          setStatus("Paginating: stopped.", false);
          return;
        }

        const selector = (cfg.paginationSelector || "").trim();
        if (!selector) {
          setStatus("Paginating: no selector saved. Stopping.", true);
          saveSiteConfig({ isPaginating: false });
          refreshPaginateButtonAppearance();
          return;
        }

        const { next, signature } = inspect(selector);

        // progress heuristic: URL or container signature must change eventually
        const urlNow = window.location.href;
        const progressed =
          (lastUrl !== null && urlNow !== lastUrl) ||
          (lastSignature !== null && signature !== lastSignature);

        if (lastUrl !== null || lastSignature !== null) {
          if (!progressed) noProgressCycles += 1;
          else noProgressCycles = 0;
        }

        lastUrl = urlNow;
        lastSignature = signature;

        if (noProgressCycles >= MAX_NO_PROGRESS_CYCLES) {
          setStatus(
            `Paginating: stopped (no observable progress for ${MAX_NO_PROGRESS_CYCLES} cycles).`,
            true,
          );
          saveSiteConfig({ isPaginating: false });
          refreshPaginateButtonAppearance();
          return;
        }

        if (!next) {
          setStatus("Paginating: done (no Next detected).", false);
          saveSiteConfig({ isPaginating: false });
          refreshPaginateButtonAppearance();
          return;
        }

        if (linkIsDisabled(next)) {
          setStatus("Paginating: done (Next is disabled).", false);
          saveSiteConfig({ isPaginating: false });
          refreshPaginateButtonAppearance();
          return;
        }

        setStatus("Paginating: clicking Next…", false);
        next.click();

        setStatus(
          `Paginating: waiting ${STEP_WAIT_MS}ms, then re-inspecting…`,
          false,
        );
        await sleep(STEP_WAIT_MS);

        // Guard against pathological tight loop if STEP_WAIT_MS is changed very low
        await sleep(LOOP_TICK_MIN_MS);
      }
    } finally {
      loopRunningInMemory = false;
    }
  }

  /* -----------------------------------------------------------
     Controls
  ----------------------------------------------------------- */

  const setBtn = panel.querySelector("#pi-set");
  const clearBtn = panel.querySelector("#pi-clear");

  setBtn.addEventListener("click", () => {
    const existing = loadSiteConfig().paginationSelector || "";
    const next = prompt(
      "Enter pagination container CSS selector (saved per-site):",
      existing,
    );
    if (next === null) return;

    const trimmed = (next || "").trim();
    saveSiteConfig({ paginationSelector: trimmed });

    openPanel();
    if (trimmed) inspect(trimmed);
    else setStatus("Selector cleared (empty).", false);
  });

  clearBtn.addEventListener("click", () => {
    saveSiteConfig({ paginationSelector: "", isPaginating: false });
    refreshPaginateButtonAppearance();
    clearResults();
    setStatus(
      "Cleared saved selector for this site (and stopped pagination).",
      false,
    );
    setMeta("");
    openPanel();
  });

  paginateBtn.addEventListener("click", () => {
    const cfg = loadSiteConfig();
    const selector = (cfg.paginationSelector || "").trim();

    if (!selector) {
      openPanel();
      setStatus(
        "Cannot paginate: no selector saved. Click “Set selector” first.",
        true,
      );
      return;
    }

    if (cfg.isPaginating) {
      saveSiteConfig({ isPaginating: false });
      refreshPaginateButtonAppearance();
      setStatus("Paginating: stop requested.", false);
      return;
    }

    saveSiteConfig({ isPaginating: true });
    refreshPaginateButtonAppearance();
    openPanel();

    paginateLoop().catch((e) => {
      console.error("[PaginationWalker] loop error:", e);
      setStatus("Paginating: error (see console).", true);
      saveSiteConfig({ isPaginating: false });
      refreshPaginateButtonAppearance();
    });
  });

  /* -----------------------------------------------------------
     Auto-inspect; resume loop if already paginating
  ----------------------------------------------------------- */

  refreshPaginateButtonAppearance();

  window.addEventListener("DOMContentLoaded", () => {
    const cfg = loadSiteConfig();
    const sel = (cfg.paginationSelector || "").trim();

    if (sel) {
      inspect(sel);
      if (cfg.isPaginating) {
        openPanel();
        paginateLoop();
      }
    } else {
      setStatus(
        "No selector saved for this site. Click “Set selector”.",
        false,
      );
    }
  });
})();
