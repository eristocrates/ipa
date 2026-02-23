// ==UserScript==
// @name         Open same-domain links in background tabs
// @namespace    https://eristocrates.dev/userscripts/
// @version      1.1.0
// @description  Tiny bottom-left button that opens all same-domain links in background tabs (includes fragments + relative hrefs).
// @match        *://*/*
// @grant        GM_openInTab
// @grant        GM.getValue
// @grant        GM.setValue
// ==/UserScript==

(function () {
  "use strict";

  // ---- Domain policy ----
  // "Same domain" here means same registrable domain (example.com), allowing subdomains.
  // This heuristic is not PSL-correct for eTLDs like co.uk; say so if you need PSL correctness.
  function registrableDomain(hostname) {
    const parts = hostname.split(".").filter(Boolean);
    if (parts.length <= 2) return hostname;
    return parts.slice(-2).join(".");
  }

  const pageDomain = registrableDomain(location.hostname);

  // ---- URL resolution + filtering ----
  function resolveHrefToUrl(href) {
    // Handles absolute, relative, and fragment hrefs via URL() resolution.
    return new URL(href, location.href);
  }

  function isOpenableScheme(urlObj) {
    return urlObj.protocol === "http:" || urlObj.protocol === "https:";
  }

  function isSkippableRawHref(href) {
    if (!href) return true;
    const s = href.trim();
    if (!s) return true;

    // Keep fragments, including "#foo" and "#".
    // Filter only truly non-navigational / non-http(s) schemes.
    if (/^(javascript:|mailto:|tel:|sms:|data:|blob:|about:)/i.test(s))
      return true;

    return false;
  }

  function normalizedForDedup(urlObj) {
    // Keep hash (you want fragments to work).
    // Normalize only trivial syntactic differences that tend to duplicate.
    const u = new URL(urlObj.toString());

    // Trim trailing slash for non-root paths to reduce duplicates:
    if (u.pathname.length > 1 && u.pathname.endsWith("/")) {
      u.pathname = u.pathname.slice(0, -1);
    }
    return u.toString();
  }

  function isSameDomain(urlObj) {
    return registrableDomain(urlObj.hostname) === pageDomain;
  }

  function collectSameDomainLinks() {
    const anchors = Array.from(document.querySelectorAll("a[href]"));
    const out = new Set();

    for (const a of anchors) {
      const raw = a.getAttribute("href");
      if (isSkippableRawHref(raw)) continue;

      let u;
      try {
        u = resolveHrefToUrl(raw);
      } catch {
        continue;
      }

      if (!isOpenableScheme(u)) continue;
      if (!isSameDomain(u)) continue;

      const normalized = normalizedForDedup(u);
      out.add(normalized);
    }

    return Array.from(out);
  }

  // ---- Tab opening (background) ----
  function openInBackground(url) {
    // Preferred: userscript manager API
    if (typeof GM_openInTab === "function") {
      // Tampermonkey + Violentmonkey support this options object.
      // active:false => background, insert:true => adjacent-ish, setParent:true => group under current tab (where supported).
      GM_openInTab(url, { active: false, insert: true, setParent: true });
      return;
    }

    // Fallback: cannot reliably force "background" in modern browsers.
    // Some browsers open in a background tab anyway; others will focus it.
    const w = window.open(url, "_blank", "noopener,noreferrer");
    // Attempt to re-focus current window; not guaranteed.
    try {
      window.focus();
    } catch {}
    try {
      if (w) w.blur();
    } catch {}
  }

  function openAll() {
    const urls = collectSameDomainLinks();

    // Guardrail: avoid accidental tab storms. Raise/remove if desired.
    const HARD_CAP = 200;
    const toOpen = urls.slice(0, HARD_CAP);

    // Reverse order so earlier DOM links end up closer to current tab (browser-dependent).
    for (let i = toOpen.length - 1; i >= 0; i--) {
      openInBackground(toOpen[i]);
    }

    const capped = urls.length > HARD_CAP ? ` (capped at ${HARD_CAP})` : "";
    btn.title = `Opened ${toOpen.length} background tabs${capped}`;
    badge.textContent = String(toOpen.length);
    badge.style.display = "block";
    setTimeout(() => (badge.style.display = "none"), 2500);
  }

  // ---- UI ----
  const btn = document.createElement("button");
  btn.type = "button";
  btn.textContent = "↗";
  btn.title = "Open all same-domain links in background tabs";
  btn.addEventListener("click", openAll);

  Object.assign(btn.style, {
    position: "fixed",
    left: "10px",
    bottom: "10px",
    width: "22px",
    height: "22px",
    padding: "0",
    margin: "0",
    border: "1px solid rgba(0,0,0,0.35)",
    borderRadius: "6px",
    background: "rgba(255,255,255,0.85)",
    color: "#111",
    fontSize: "14px",
    lineHeight: "20px",
    cursor: "pointer",
    zIndex: 2147483647,
    boxShadow: "0 1px 4px rgba(0,0,0,0.2)",
    userSelect: "none",
  });

  const badge = document.createElement("div");
  Object.assign(badge.style, {
    position: "fixed",
    left: "34px",
    bottom: "10px",
    padding: "2px 6px",
    borderRadius: "999px",
    background: "rgba(0,0,0,0.75)",
    color: "white",
    fontSize: "12px",
    zIndex: 2147483647,
    display: "none",
  });

  document.documentElement.appendChild(btn);
  document.documentElement.appendChild(badge);
})();
