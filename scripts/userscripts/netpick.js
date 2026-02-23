// ==UserScript==
// @name         NETPICK2: endpoints -> querystrings (drawer + persistent state + autosave + endpoint-scoped queries)
// @namespace    https://eristocrates.dev/externalism/userscripts/
// @version      0.5.1
// @description  Select endpoints, then querystrings. Persistent state per-origin. Slide-out drawer. Autosave matching fetch/XHR via <a download>. Query selection is endpoint-scoped to avoid cross-endpoint interference.
// @match        *://*/*
// @run-at       document-start
// @grant        none
// ==/UserScript==

(() => {
  "use strict";

  const CHANNEL = "__NETLOG_EVENT__";

  // -----------------------------
  // Persistence (per-origin)
  // -----------------------------
  const STORAGE_KEY = `__netpick2_state__::${location.origin}`;
  const STORAGE_VERSION = 3;

  const MAX_OBSERVED_PAIRS = 8000;

  let saveTimer = null;
  function scheduleSave() {
    if (saveTimer) return;
    saveTimer = setTimeout(() => {
      saveTimer = null;
      persistState();
    }, 250);
  }

  let autoSaveEnabled = true;

  // -----------------------------
  // Data model
  // -----------------------------
  const observedPairs = new Set(); // `${endpointPathname}\u0000${queryString}`
  const selectedEndpointPathnames = new Set();
  const hiddenEndpointPathnames = new Set();
  const ignoreQueryEndpointPathnames = new Set();

  // NEW: endpoint-scoped query selection: Map<endpointPathname, Set<queryString>>
  const selectedQueriesByEndpoint = new Map();

  function trimObservedPairsToMax() {
    if (observedPairs.size <= MAX_OBSERVED_PAIRS) return;
    const toDrop = observedPairs.size - MAX_OBSERVED_PAIRS;
    let i = 0;
    for (const k of observedPairs) {
      observedPairs.delete(k);
      i++;
      if (i >= toDrop) break;
    }
  }

  function persistState() {
    try {
      const payload = {
        v: STORAGE_VERSION,
        observedPairs: Array.from(observedPairs),
        selectedEndpointPathnames: Array.from(selectedEndpointPathnames),
        hiddenEndpointPathnames: Array.from(hiddenEndpointPathnames),
        ignoreQueryEndpointPathnames: Array.from(ignoreQueryEndpointPathnames),

        // Map serialized as: [[ep, [q1,q2...]], ...]
        selectedQueriesByEndpoint: Array.from(
          selectedQueriesByEndpoint.entries(),
        ).map(([ep, set]) => [ep, Array.from(set)]),

        ui: { collapsed: uiCollapsed },
        behavior: { autoSaveEnabled },
      };
      localStorage.setItem(STORAGE_KEY, JSON.stringify(payload));
    } catch (e) {
      try {
        trimObservedPairsToMax();
        const payload = {
          v: STORAGE_VERSION,
          observedPairs: Array.from(observedPairs),
          selectedEndpointPathnames: Array.from(selectedEndpointPathnames),
          hiddenEndpointPathnames: Array.from(hiddenEndpointPathnames),
          selectedQueriesByEndpoint: Array.from(
            selectedQueriesByEndpoint.entries(),
          ).map(([ep, set]) => [ep, Array.from(set)]),
          ui: { collapsed: uiCollapsed },
          behavior: { autoSaveEnabled },
        };
        localStorage.setItem(STORAGE_KEY, JSON.stringify(payload));
      } catch {
        console.warn("[NETPICK2] Persist failed:", e);
      }
    }
  }

  function restoreState() {
    try {
      const raw = localStorage.getItem(STORAGE_KEY);
      if (!raw) return;

      const parsed = JSON.parse(raw);
      if (!parsed) return;

      // Accept v2 (your old file) and v3 (this file)
      if (![3, 2, 1].includes(parsed.v)) return;

      if (Array.isArray(parsed.observedPairs)) {
        for (const k of parsed.observedPairs)
          if (typeof k === "string") observedPairs.add(k);
      }

      if (Array.isArray(parsed.selectedEndpointPathnames)) {
        for (const ep of parsed.selectedEndpointPathnames)
          if (typeof ep === "string") selectedEndpointPathnames.add(ep);
      }

      if (Array.isArray(parsed.hiddenEndpointPathnames)) {
        for (const ep of parsed.hiddenEndpointPathnames)
          if (typeof ep === "string") hiddenEndpointPathnames.add(ep);
      }
      if (Array.isArray(parsed.ignoreQueryEndpointPathnames)) {
        for (const ep of parsed.ignoreQueryEndpointPathnames)
          if (typeof ep === "string") ignoreQueryEndpointPathnames.add(ep);
      }
      // v3 path
      if (Array.isArray(parsed.selectedQueriesByEndpoint)) {
        for (const entry of parsed.selectedQueriesByEndpoint) {
          if (!Array.isArray(entry) || entry.length !== 2) continue;
          const [ep, qsArr] = entry;
          if (typeof ep !== "string") continue;
          if (!Array.isArray(qsArr)) continue;
          const set = new Set();
          for (const q of qsArr) if (typeof q === "string" && q) set.add(q);
          if (set.size) selectedQueriesByEndpoint.set(ep, set);
        }
      }

      // v2 fallback: migrate old global selectedQueryStrings into *no per-endpoint constraint*
      // (We intentionally do not “apply them everywhere”, because that recreates the old bug.)
      // If you want a different migration, say so.

      if (parsed.ui && typeof parsed.ui === "object") {
        if (typeof parsed.ui.collapsed === "boolean")
          uiCollapsed = parsed.ui.collapsed;
      }

      if (parsed.behavior && typeof parsed.behavior === "object") {
        if (typeof parsed.behavior.autoSaveEnabled === "boolean") {
          autoSaveEnabled = parsed.behavior.autoSaveEnabled;
        }
      }
    } catch (e) {
      console.warn("[NETPICK2] Restore failed:", e);
    }
  }

  // -----------------------------
  // URL parsing helpers
  // -----------------------------
  function parseUrl(urlStr) {
    try {
      return new URL(urlStr, location.href);
    } catch {
      return null;
    }
  }

  function endpointPathnameFromUrl(urlStr) {
    const u = parseUrl(urlStr);
    if (u) return u.pathname || "/";
    const s = String(urlStr || "");
    return s.split("#")[0].split("?")[0] || "/";
  }

  function queryStringFromUrl(urlStr) {
    const u = parseUrl(urlStr);
    if (u) return u.search || "";
    const s = String(urlStr || "");
    const noHash = s.split("#")[0];
    const idx = noHash.indexOf("?");
    return idx === -1 ? "" : noHash.slice(idx) || "";
  }

  function endpointNameFromPathname(pathname) {
    const p = String(pathname || "/");
    if (p === "/" || p === "") return "(root)";
    const trimmed = p.endsWith("/") ? p.slice(0, -1) : p;
    const parts = trimmed.split("/").filter(Boolean);
    return parts.length ? parts[parts.length - 1] : "(root)";
  }

  function pairKey(endpointPathname, queryString) {
    return `${endpointPathname}\u0000${queryString}`;
  }

  function availableQueriesForEndpoint(endpointPathname) {
    const qs = new Set();
    for (const k of observedPairs) {
      const [ep, q] = k.split("\u0000");
      if (ep !== endpointPathname) continue;
      if (!q) continue;
      qs.add(q);
    }
    return qs;
  }

  function availableQueriesForSelectedEndpointsUnion() {
    const union = new Set();
    if (selectedEndpointPathnames.size === 0) return union;

    for (const ep of selectedEndpointPathnames) {
      if (ignoreQueryEndpointPathnames.has(ep)) continue; // NEW: do not contribute queries
      const qs = availableQueriesForEndpoint(ep);
      for (const q of qs) union.add(q);
    }
    return union;
  }
  // Ensure per-endpoint selected queries remain valid w.r.t observedPairs (no phantom queries).
  // This is the *correct* reconciliation boundary (endpoint-scoped).
  function reconcileSelectedQueriesByEndpoint() {
    let changed = false;
    for (const [ep, set] of Array.from(selectedQueriesByEndpoint.entries())) {
      const avail = availableQueriesForEndpoint(ep);
      for (const q of Array.from(set)) {
        if (!avail.has(q)) {
          set.delete(q);
          changed = true;
        }
      }
      if (set.size === 0) {
        selectedQueriesByEndpoint.delete(ep);
        changed = true;
      }
    }
    if (changed) scheduleSave();
    return changed;
  }

  // Latent default selection:
  // If endpoint is selected and a new querystring is observed for it, auto-select it FOR THAT ENDPOINT.
  function addObservation(urlStr) {
    const endpointPathname = endpointPathnameFromUrl(urlStr);
    const queryString = queryStringFromUrl(urlStr);
    const k = pairKey(endpointPathname, queryString);
    const wasNew = !observedPairs.has(k);
    if (wasNew) {
      observedPairs.add(k);
      trimObservedPairsToMax();

      if (
        queryString &&
        selectedEndpointPathnames.has(endpointPathname) &&
        !ignoreQueryEndpointPathnames.has(endpointPathname)
      ) {
        let set = selectedQueriesByEndpoint.get(endpointPathname);
        if (!set) {
          set = new Set();
          selectedQueriesByEndpoint.set(endpointPathname, set);
        }
        set.add(queryString);
        publishMirror();
      }

      scheduleSave();
    }

    return { endpointPathname, queryString, wasNew };
  }

  function computeAllEndpoints() {
    const endpoints = new Set();
    for (const k of observedPairs) {
      const [endpointPathname] = k.split("\u0000");
      endpoints.add(endpointPathname);
    }
    for (const ep of selectedEndpointPathnames) endpoints.add(ep);
    return Array.from(endpoints);
  }

  // -----------------------------
  // Mirror to main-world hook
  // -----------------------------
  function publishMirror() {
    try {
      const selectedQueriesByEndpointObj = {};
      for (const [ep, set] of selectedQueriesByEndpoint.entries()) {
        selectedQueriesByEndpointObj[ep] = Array.from(set);
      }

      window.__NETPICK2_MIRROR__ = {
        autoSaveEnabled: !!autoSaveEnabled,
        selectedEndpointPathnames: Array.from(selectedEndpointPathnames),
        ignoreQueryEndpointPathnames: Array.from(ignoreQueryEndpointPathnames),
        selectedQueriesByEndpoint: selectedQueriesByEndpointObj,
      };
    } catch {}
  }

  // -----------------------------
  // UI: slide-out drawer
  // -----------------------------
  let overlay;
  let tabEl;
  let endpointSearchEl, querySearchEl;
  let endpointListEl, queryListEl;
  let selectionSummaryEl;

  let overlayEnabled = true;
  let uiCollapsed = true;

  const DRAWER_WIDTH_PX = 920;
  const TAB_WIDTH_PX = 26;

  function cssButton() {
    return [
      "cursor:pointer",
      "background:rgba(255,255,255,0.08)",
      "color:#eaeaea",
      "border:1px solid rgba(255,255,255,0.18)",
      "border-radius:8px",
      "padding:3px 8px",
      "font:inherit",
    ].join(";");
  }

  function cssInput() {
    return [
      "width:100%",
      "box-sizing:border-box",
      "padding:5px 7px",
      "border-radius:8px",
      "border:1px solid rgba(255,255,255,0.16)",
      "background:rgba(0,0,0,0.20)",
      "color:#eaeaea",
      "outline:none",
      "font:inherit",
    ].join(";");
  }

  function applyDrawerState() {
    if (!overlay) return;

    const slideX = uiCollapsed ? DRAWER_WIDTH_PX : 0;
    overlay.style.transform = `translateX(${slideX}px)`;
    overlay.style.pointerEvents = "auto";

    if (tabEl) {
      tabEl.textContent = uiCollapsed ? "◀" : "▶";
      tabEl.title = uiCollapsed ? "Expand" : "Collapse";
    }
  }

  function setCollapsed(v) {
    uiCollapsed = !!v;
    applyDrawerState();
    scheduleSave();
  }

  function toggleCollapsed() {
    setCollapsed(!uiCollapsed);
  }

  function ensureOverlay() {
    if (overlay) return;

    overlay = document.createElement("div");
    overlay.style.cssText = [
      "position:fixed",
      "right:10px",
      "bottom:10px",
      `width:${DRAWER_WIDTH_PX}px`,
      "height:62vh",
      "z-index:2147483647",
      "background:rgba(15,15,15,0.92)",
      "color:#eaeaea",
      'font:12px/1.35 ui-monospace, SFMono-Regular, Menlo, Consolas, "Liberation Mono", monospace',
      "border:1px solid rgba(255,255,255,0.18)",
      "border-radius:12px",
      "box-shadow:0 10px 30px rgba(0,0,0,0.35)",
      "padding:10px",
      "display:flex",
      "flex-direction:column",
      "gap:8px",
      "box-sizing:border-box",
      "transition:transform 160ms ease",
      "will-change:transform",
    ].join(";");

    tabEl = document.createElement("div");
    tabEl.style.cssText = [
      "position:absolute",
      "left:-22px",
      "bottom:18px",
      "width:22px",
      "height:80px",
      "display:flex",
      "align-items:center",
      "justify-content:center",
      "border-radius:10px 0 0 10px",
      "border:1px solid rgba(255,255,255,0.18)",
      "border-right:none",
      "background:rgba(15,15,15,0.92)",
      "cursor:pointer",
      "user-select:none",
      "opacity:0.95",
    ].join(";");
    tabEl.addEventListener("click", (ev) => {
      ev.stopPropagation();
      toggleCollapsed();
    });
    overlay.appendChild(tabEl);

    const header = document.createElement("div");
    header.style.cssText =
      "display:flex;align-items:center;justify-content:space-between;gap:12px;flex:0 0 auto;";

    const title = document.createElement("div");
    title.style.cssText = "font-weight:600;";
    title.textContent = `NETPICK2 ${location.host}`;

    const controls = document.createElement("div");
    controls.style.cssText =
      "display:flex;align-items:center;gap:10px;opacity:0.88;";

    const hint = document.createElement("div");
    hint.style.cssText = "font-size:11px;opacity:0.75;";
    hint.textContent =
      "Tab collapses/expands. Ctrl+Alt+S collapse. Ctrl+Shift+Alt+S show/hide.";

    const autosaveWrap = document.createElement("label");
    autosaveWrap.style.cssText =
      "display:flex;align-items:center;gap:6px;font-size:11px;opacity:0.9;user-select:none;cursor:pointer;";
    const autosaveCb = document.createElement("input");
    autosaveCb.type = "checkbox";
    autosaveCb.checked = autoSaveEnabled;
    autosaveCb.addEventListener("change", () => {
      autoSaveEnabled = !!autosaveCb.checked;
      publishMirror();
      scheduleSave();
    });
    const autosaveText = document.createElement("span");
    autosaveText.textContent = "Auto-save";
    autosaveWrap.appendChild(autosaveCb);
    autosaveWrap.appendChild(autosaveText);

    const clearSelectionsBtn = document.createElement("button");
    clearSelectionsBtn.textContent = "Clear selections";
    clearSelectionsBtn.style.cssText = cssButton();
    clearSelectionsBtn.addEventListener("click", () => {
      selectedEndpointPathnames.clear();
      // NOTE: we intentionally do NOT clear selectedQueriesByEndpoint here;
      // when endpoints are reselected, their query selections re-apply.
      publishMirror();
      scheduleSave();
      renderAll();
    });

    const clearAllBtn = document.createElement("button");
    clearAllBtn.textContent = "Clear all data";
    clearAllBtn.style.cssText = cssButton();
    clearAllBtn.addEventListener("click", () => {
      observedPairs.clear();
      selectedEndpointPathnames.clear();
      hiddenEndpointPathnames.clear();
      selectedQueriesByEndpoint.clear();
      ignoreQueryEndpointPathnames.clear();
      publishMirror();
      try {
        localStorage.removeItem(STORAGE_KEY);
      } catch {}
      renderAll();
    });

    controls.appendChild(hint);
    controls.appendChild(autosaveWrap);
    controls.appendChild(clearSelectionsBtn);
    controls.appendChild(clearAllBtn);

    header.appendChild(title);
    header.appendChild(controls);

    selectionSummaryEl = document.createElement("div");
    selectionSummaryEl.style.cssText =
      "opacity:0.9;font-size:11px;flex:0 0 auto;";

    const row = document.createElement("div");
    row.style.cssText =
      "display:flex;gap:10px;align-items:stretch;flex:1 1 auto;min-height:0;";

    const endpointPanel = makePanel("Endpoints (Name)");
    endpointSearchEl = endpointPanel.searchEl;
    endpointListEl = endpointPanel.listEl;

    const queryPanel = makePanel("Querystrings (for selected endpoints)");
    querySearchEl = queryPanel.searchEl;
    queryListEl = queryPanel.listEl;

    row.appendChild(endpointPanel.panel);
    row.appendChild(queryPanel.panel);

    overlay.appendChild(header);
    overlay.appendChild(selectionSummaryEl);
    overlay.appendChild(row);

    const attach = () =>
      (document.documentElement || document.body).appendChild(overlay);
    if (document.documentElement) attach();
    else window.addEventListener("DOMContentLoaded", attach, { once: true });

    endpointSearchEl.addEventListener("input", () => renderEndpoints());
    querySearchEl.addEventListener("input", () => renderQueries());

    applyDrawerState();
    renderAll();
  }

  function makePanel(titleText) {
    const panel = document.createElement("div");
    panel.style.cssText = [
      "flex:1",
      "min-width:0",
      "display:flex",
      "flex-direction:column",
      "gap:6px",
      "padding:10px",
      "border-radius:10px",
      "background:rgba(0,0,0,0.22)",
      "border:1px solid rgba(255,255,255,0.12)",
      "box-sizing:border-box",
      "min-height:0",
    ].join(";");

    const header = document.createElement("div");
    header.style.cssText =
      "display:flex;align-items:center;justify-content:space-between;gap:8px;flex:0 0 auto;";

    const title = document.createElement("div");
    title.style.cssText = "font-weight:600;";
    title.textContent = titleText;

    header.appendChild(title);

    const searchEl = document.createElement("input");
    searchEl.type = "text";
    searchEl.placeholder = "search…";
    searchEl.style.cssText = cssInput();

    const listEl = document.createElement("div");
    listEl.style.cssText = [
      "flex:1 1 auto",
      "min-height:0",
      "overflow:auto",
      "border-radius:8px",
      "background:rgba(0,0,0,0.18)",
      "border:1px solid rgba(255,255,255,0.10)",
      "padding:6px",
      "display:flex",
      "flex-direction:column",
      "gap:4px",
      "box-sizing:border-box",
    ].join(";");

    panel.appendChild(header);
    panel.appendChild(searchEl);
    panel.appendChild(listEl);

    return { panel, searchEl, listEl };
  }

  function renderAll() {
    ensureOverlay();

    const selectedQueryEndpointCount = Array.from(
      selectedQueriesByEndpoint.keys(),
    ).length;

    selectionSummaryEl.textContent =
      `Selected endpoints: ${selectedEndpointPathnames.size || "∅"} ; ` +
      `Endpoints w/ query filters: ${selectedQueryEndpointCount || "∅"} ; ` +
      `Observed pairs: ${observedPairs.size}`;

    renderEndpoints();
    renderQueries();
  }

  function mkRow({
    display,
    tooltip,
    selected,
    disabled,
    onChange,
    onHide,
    ignoreQueriesEnabled,
    onIgnoreQueriesToggle,
  }) {
    const row = document.createElement("label");
    row.title = tooltip || "";
    row.style.cssText = [
      "display:flex",
      "align-items:center",
      "gap:8px",
      "padding:5px 7px",
      "border-radius:9px",
      "border:1px solid " +
        (selected ? "rgba(120,160,255,0.95)" : "rgba(255,255,255,0.14)"),
      "background:" +
        (selected ? "rgba(120,160,255,0.28)" : "rgba(255,255,255,0.02)"),
      "box-shadow:" +
        (selected ? "0 0 0 1px rgba(120,160,255,0.30) inset" : "none"),
      "opacity:" + (disabled && !selected ? "0.40" : "1.0"),
      "user-select:none",
      "cursor:" + (disabled && !selected ? "not-allowed" : "pointer"),
    ].join(";");

    const accent = document.createElement("div");
    accent.style.cssText = [
      "width:5px",
      "align-self:stretch",
      "border-radius:8px",
      "background:" +
        (selected ? "rgba(120,160,255,0.95)" : "rgba(255,255,255,0.10)"),
      "flex:0 0 auto",
    ].join(";");

    const cb = document.createElement("input");
    cb.type = "checkbox";
    cb.checked = selected;
    cb.disabled = disabled && !selected;
    cb.style.cssText = "transform:scale(1.05);";
    cb.addEventListener("change", () => onChange(cb.checked));

    const text = document.createElement("div");
    text.textContent = display;
    text.style.cssText =
      "overflow:hidden;text-overflow:ellipsis;white-space:nowrap;flex:1 1 auto;min-width:0;";

    row.appendChild(accent);
    row.appendChild(cb);
    row.appendChild(text);

    if (typeof onHide === "function") {
      const hideBtn = document.createElement("button");
      hideBtn.type = "button";
      hideBtn.textContent = "×";
      hideBtn.title = "Hide this endpoint (until Clear all data)";
      hideBtn.style.cssText = [
        "margin-left:6px",
        "width:20px",
        "height:20px",
        "line-height:18px",
        "display:flex",
        "align-items:center",
        "justify-content:center",
        "border-radius:6px",
        "border:1px solid rgba(255,255,255,0.14)",
        "background:rgba(255,255,255,0.06)",
        "color:#eaeaea",
        "cursor:pointer",
        "padding:0",
        "flex:0 0 auto",
      ].join(";");
      if (typeof onIgnoreQueriesToggle === "function") {
        const qBtn = document.createElement("button");
        qBtn.type = "button";
        qBtn.textContent = ignoreQueriesEnabled ? "●" : "○";
        qBtn.title = ignoreQueriesEnabled
          ? "Querystrings ignored for this endpoint (always matches; hidden from query list)"
          : "Ignore querystrings for this endpoint (always matches; hide from query list)";
        qBtn.style.cssText = [
          "margin-left:6px",
          "width:20px",
          "height:20px",
          "line-height:18px",
          "display:flex",
          "align-items:center",
          "justify-content:center",
          "border-radius:999px",
          "border:1px solid rgba(255,255,255,0.14)",
          "background:rgba(255,255,255,0.06)",
          "color:#eaeaea",
          "cursor:pointer",
          "padding:0",
          "flex:0 0 auto",
        ].join(";");

        qBtn.addEventListener("click", (ev) => {
          ev.preventDefault();
          ev.stopPropagation();
          onIgnoreQueriesToggle();
        });

        row.appendChild(qBtn);
      }
      hideBtn.addEventListener("click", (ev) => {
        ev.preventDefault();
        ev.stopPropagation();
        onHide();
      });

      row.appendChild(hideBtn);
    }

    row.addEventListener("click", (ev) => {
      if (ev.target === cb) return;
      if (
        (typeof onHide === "function" ||
          typeof onIgnoreQueriesToggle === "function") &&
        ev.target &&
        ev.target.tagName === "BUTTON"
      )
        return;
      if (cb.disabled) return;
      cb.checked = !cb.checked;
      onChange(cb.checked);
    });

    return row;
  }

  function renderEndpoints() {
    ensureOverlay();

    const filterText = (endpointSearchEl.value || "").trim().toLowerCase();
    const endpoints = computeAllEndpoints();

    endpoints.sort((a, b) => {
      const an = endpointNameFromPathname(a);
      const bn = endpointNameFromPathname(b);
      const byName = an.localeCompare(bn);
      return byName !== 0 ? byName : a.localeCompare(b);
    });

    endpointListEl.textContent = "";

    let shown = 0;
    for (const ep of endpoints) {
      if (hiddenEndpointPathnames.has(ep)) continue;

      const display = endpointNameFromPathname(ep);
      const searchable = `${display} ${ep}`.toLowerCase();
      if (filterText && !searchable.includes(filterText)) continue;

      shown++;
      const selected = selectedEndpointPathnames.has(ep);

      endpointListEl.appendChild(
        mkRow({
          display,
          tooltip: ep,
          selected,
          disabled: false,
          onChange: (checked) => {
            if (checked) selectedEndpointPathnames.add(ep);
            else selectedEndpointPathnames.delete(ep);

            // IMPORTANT: we do NOT delete query filters when endpoints are unselected.
            // They persist per endpoint and reapply when reselected.

            reconcileSelectedQueriesByEndpoint();
            publishMirror();
            scheduleSave();
            renderAll();
          },
          onHide: () => {
            hiddenEndpointPathnames.add(ep);

            selectedEndpointPathnames.delete(ep);
            selectedQueriesByEndpoint.delete(ep); // hiding an endpoint also drops its query filter state
            ignoreQueryEndpointPathnames.delete(ep);

            reconcileSelectedQueriesByEndpoint();
            publishMirror();
            scheduleSave();
            renderAll();
          },
          ignoreQueriesEnabled: ignoreQueryEndpointPathnames.has(ep),
          onIgnoreQueriesToggle: () => {
            if (ignoreQueryEndpointPathnames.has(ep)) {
              ignoreQueryEndpointPathnames.delete(ep);
            } else {
              ignoreQueryEndpointPathnames.add(ep);

              // Optional but sensible: drop per-endpoint query filter state, since it’s now irrelevant.
              selectedQueriesByEndpoint.delete(ep);
            }

            publishMirror();
            scheduleSave();
            renderAll();
          },
        }),
      );
    }

    if (shown === 0) {
      const msg = document.createElement("div");
      msg.style.cssText = "opacity:0.75;padding:6px;";
      msg.textContent = "(no matches)";
      endpointListEl.appendChild(msg);
    }
  }

  function renderQueries() {
    ensureOverlay();
    queryListEl.textContent = "";

    if (selectedEndpointPathnames.size === 0) {
      const msg = document.createElement("div");
      msg.style.cssText = "opacity:0.75;padding:6px;";
      msg.textContent = "(select one or more endpoints to populate queries)";
      queryListEl.appendChild(msg);
      return;
    }

    reconcileSelectedQueriesByEndpoint();

    const availableUnion = availableQueriesForSelectedEndpointsUnion();
    const filterText = (querySearchEl.value || "").trim().toLowerCase();

    const queries = Array.from(availableUnion).sort((a, b) =>
      a.localeCompare(b),
    );

    let shown = 0;

    for (const q of queries) {
      if (filterText && !q.toLowerCase().includes(filterText)) continue;
      shown++;

      // Determine if this query is selected for ANY of the currently selected endpoints.
      let selectedForSome = false;
      for (const ep of selectedEndpointPathnames) {
        const set = selectedQueriesByEndpoint.get(ep);
        if (set && set.has(q)) {
          selectedForSome = true;
          break;
        }
      }

      queryListEl.appendChild(
        mkRow({
          display: q,
          tooltip: q,
          selected: selectedForSome,
          disabled: false,
          onChange: (checked) => {
            // Apply to selected endpoints that actually have this query observed.
            for (const ep of selectedEndpointPathnames) {
              const avail = availableQueriesForEndpoint(ep);
              if (ignoreQueryEndpointPathnames.has(ep)) continue;
              if (!avail.has(q)) continue;

              if (checked) {
                let set = selectedQueriesByEndpoint.get(ep);
                if (!set) {
                  set = new Set();
                  selectedQueriesByEndpoint.set(ep, set);
                }
                set.add(q);
              } else {
                const set = selectedQueriesByEndpoint.get(ep);
                if (set) {
                  set.delete(q);
                  if (set.size === 0) selectedQueriesByEndpoint.delete(ep);
                }
              }
            }

            publishMirror();
            scheduleSave();
            renderAll();
          },
        }),
      );
    }

    if (shown === 0) {
      const msg = document.createElement("div");
      msg.style.cssText = "opacity:0.75;padding:6px;";
      msg.textContent = "(no querystrings observed yet for selected endpoints)";
      queryListEl.appendChild(msg);
    }
  }

  // Hotkeys
  window.addEventListener(
    "keydown",
    (ev) => {
      if (ev.ctrlKey && ev.altKey && (ev.key === "S" || ev.key === "s")) {
        ensureOverlay();
        toggleCollapsed();
        return;
      }
      if (
        ev.ctrlKey &&
        ev.shiftKey &&
        ev.altKey &&
        (ev.key === "S" || ev.key === "s")
      ) {
        overlayEnabled = !overlayEnabled;
        ensureOverlay();
        overlay.style.display = overlayEnabled ? "flex" : "none";
        return;
      }
    },
    true,
  );

  // -----------------------------
  // Event relay (isolated world)
  // -----------------------------
  window.addEventListener(
    "message",
    (ev) => {
      if (ev.source !== window) return;
      const data = ev.data;
      if (!data || data.channel !== CHANNEL) return;
      if (data.kind === "netlog" && data.url === "installed") return;

      const { wasNew } = addObservation(data.url);
      if (!wasNew) return;

      if (!overlayEnabled) return;
      renderAll();
    },
    false,
  );

  // -----------------------------
  // Main-world injection (visibility + autosave)
  // -----------------------------
  function injectMainWorldHook() {
    const code = `
      (function() {
        'use strict';
        const CHANNEL = ${JSON.stringify(CHANNEL)};

        function emit(payload) {
          try { window.postMessage(Object.assign({ channel: CHANNEL }, payload), '*'); } catch {}
        }

        function parseUrl(urlStr) { try { return new URL(urlStr, location.href); } catch { return null; } }
        function endpointPathnameFromUrl(urlStr) {
          const u = parseUrl(urlStr);
          if (u) return u.pathname || '/';
          const s = String(urlStr || '');
          return s.split('#')[0].split('?')[0] || '/';
        }
        function queryStringFromUrl(urlStr) {
          const u = parseUrl(urlStr);
          if (u) return u.search || '';
          const s = String(urlStr || '');
          const noHash = s.split('#')[0];
          const idx = noHash.indexOf('?');
          return idx === -1 ? '' : (noHash.slice(idx) || '');
        }

        // Remove entire "_=<value>" query argument(s) from the URL used for the filename.
        function stripUnderscoreParam(urlStr) {
          try {
            const u = parseUrl(urlStr);
            if (!u) return String(urlStr || '');
            u.searchParams.delete('_');
            return String(u.host || '') + String(u.pathname || '') + String(u.search || '');
          } catch {
            return String(urlStr || '');
          }
        }

        function sanitizeToDash(s) {
          return String(s || '')
            .replace(/^https?:\\/\\/+/i, '')
            .replace(/[^a-zA-Z0-9]+/g, '-')
            .replace(/-+/g, '-')
            .replace(/^-|-$/g, '');
        }

        function extFromUrl(urlStr) {
          try {
            const u = parseUrl(urlStr);
            if (!u) return '';
            const p = u.pathname || '';
            const m = p.match(/\\.([a-zA-Z0-9]{1,8})$/);
            return m ? '.' + m[1] : '';
          } catch { return ''; }
        }

        function extFromContentType(ct) {
          const s = String(ct || '').toLowerCase();
          if (s.includes('application/json') || s.includes('+json')) return '.json';
          if (s.includes('text/html') || s.includes('application/xhtml')) return '.html';
          if (s.includes('text/plain')) return '.txt';
          return '.txt';
        }

        function matchesSelection(urlStr) {
          const mirror = window.__NETPICK2_MIRROR__;
          if (!mirror || !mirror.autoSaveEnabled) return false;

          const ep = endpointPathnameFromUrl(urlStr);
          const qs = queryStringFromUrl(urlStr);

          const eps = mirror.selectedEndpointPathnames || [];
          if (!eps.length) return false;
          if (eps.indexOf(ep) === -1) return false;

          // Ignore querystrings entirely for whitelisted endpoints
          const ignored = mirror.ignoreQueryEndpointPathnames || [];
          if (ignored.indexOf(ep) !== -1) return true;

          // Endpoint-scoped query enforcement:
          // If this endpoint has an explicit query set, require membership.
          // Otherwise: allow any query (including empty).
          const per = mirror.selectedQueriesByEndpoint || {};
          const qset = per[ep] || [];
          if (Array.isArray(qset) && qset.length > 0) {
            return qset.indexOf(qs) !== -1;
          }
          return true;
        }

        const recent = new Map();
        function shouldDownloadNow(urlStr) {
          const now = Date.now();
          const last = recent.get(urlStr) || 0;
          if (now - last < 1200) return false;
          recent.set(urlStr, now);
          return true;
        }

        function currentLocationForFilename() {
          try {
            const u = parseUrl(location.href);
            if (!u) return String(location.href || '');
            return String(u.host || '') + String(u.pathname || '') + String(u.search || '') + String(u.hash || '');
          } catch {
            return String(location.href || '');
          }
        }

        function filenameBase(locationStr, endpointStr) {
          // Desired shape: <locationUri>'<endpointUri>
          // Both parts are "dash-sanitized" but the apostrophe delimiter is preserved.
          return sanitizeToDash(locationStr) + "'" + sanitizeToDash(endpointStr);
        }

        function triggerDownload(blob, filename) {
          try {
            const objectUrl = URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.href = objectUrl;
            a.download = filename;
            a.style.display = 'none';
            document.documentElement.appendChild(a);
            a.click();
            a.remove();
            setTimeout(() => URL.revokeObjectURL(objectUrl), 30000);
          } catch (e) {
            console.warn('[NETPICK2] download failed:', e);
          }
        }

        async function autosaveFetch(url, resp) {
          try {
            if (!matchesSelection(url)) return;
            if (!shouldDownloadNow(url)) return;

            const loc = currentLocationForFilename();
            const epForName = stripUnderscoreParam(url);
            const base = filenameBase(loc, epForName);

            const urlExt = extFromUrl(url);
            const ct = resp && resp.headers ? resp.headers.get('content-type') : '';
            const ext = urlExt || extFromContentType(ct);

            const blob = await resp.clone().blob();
            triggerDownload(blob, base + ext);
          } catch (e) {
            console.warn('[NETPICK2] autosaveFetch error:', e);
          }
        }

        function autosaveXhr(url, xhr) {
          try {
            if (!matchesSelection(url)) return;
            if (!shouldDownloadNow(url)) return;

            const loc = currentLocationForFilename();
            const epForName = stripUnderscoreParam(url);
            const base = filenameBase(loc, epForName);

            const urlExt = extFromUrl(url);

            let ct = '';
            try { ct = xhr.getResponseHeader && xhr.getResponseHeader('content-type'); } catch {}
            const ext = urlExt || extFromContentType(ct);

            let blob = null;
            const rt = String(xhr.responseType || '');
            if (rt === '' || rt === 'text') {
              blob = new Blob([xhr.responseText], { type: ct || 'text/plain' });
            } else if (rt === 'blob' && xhr.response) {
              blob = xhr.response;
            } else if (rt === 'arraybuffer' && xhr.response) {
              blob = new Blob([xhr.response], { type: ct || 'application/octet-stream' });
            } else if (xhr.responseText) {
              blob = new Blob([xhr.responseText], { type: ct || 'text/plain' });
            } else {
              blob = new Blob([String(xhr.response)], { type: ct || 'text/plain' });
            }

            triggerDownload(blob, base + ext);
          } catch (e) {
            console.warn('[NETPICK2] autosaveXhr error:', e);
          }
        }

        const originalFetch = window.fetch;
        if (typeof originalFetch === 'function') {
          window.fetch = function(input, init) {
            let url = '';
            let method = 'GET';
            try {
              if (typeof input === 'string') url = input;
              else if (input && typeof input.url === 'string') url = input.url;
              else url = String(input);

              if (init && init.method) method = String(init.method).toUpperCase();
              else if (input && input.method) method = String(input.method).toUpperCase();
            } catch {}

            return originalFetch.apply(this, arguments).then(
              (resp) => {
                emit({ kind:'fetch', method, url, status: resp && typeof resp.status === 'number' ? resp.status : null });
                autosaveFetch(url, resp);
                return resp;
              },
              (err)  => {
                emit({ kind:'fetch', method, url, status:'ERR', error:String(err) });
                throw err;
              }
            );
          };
        }

        const OrigXHR = window.XMLHttpRequest;
        if (typeof OrigXHR === 'function') {
          const origOpen = OrigXHR.prototype.open;
          const origSend = OrigXHR.prototype.send;

          OrigXHR.prototype.open = function(method, url) {
            try {
              this.__netpick2_method = String(method || 'GET').toUpperCase();
              this.__netpick2_url = String(url || '');
            } catch {}
            return origOpen.apply(this, arguments);
          };

          OrigXHR.prototype.send = function() {
            const method = this.__netpick2_method || 'GET';
            const url = this.__netpick2_url || '';

            const onLoadEnd = () => {
              emit({ kind:'xhr', method, url, status: typeof this.status === 'number' ? this.status : null });
              autosaveXhr(url, this);
            };

            try { this.addEventListener('loadend', onLoadEnd, { once:true }); } catch {}
            return origSend.apply(this, arguments);
          };
        }

        emit({ kind:'netlog', url:'installed', status:'OK' });
      })();
    `;

    const s = document.createElement("script");
    s.textContent = code;
    (document.documentElement || document.head).appendChild(s);
    s.remove();
  }

  // -----------------------------
  // Boot
  // -----------------------------
  restoreState();
  reconcileSelectedQueriesByEndpoint();
  publishMirror();

  injectMainWorldHook();
  ensureOverlay();
})();
