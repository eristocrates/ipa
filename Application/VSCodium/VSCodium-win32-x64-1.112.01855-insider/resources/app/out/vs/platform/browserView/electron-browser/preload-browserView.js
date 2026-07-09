"use strict";(function(){const{contextBridge:e}=require("electron"),t={getSelectedText(){try{return window.getSelection()?.toString()??""}catch{return""}}};try{e.exposeInIsolatedWorld(999,"browserViewAPI",t)}catch(r){console.error(r)}})();

//# sourceMappingURL=https://github.com/VSCodium/sourcemaps/releases/download/insider-61321a14c608c2762ac3ce37cba10265d2b94f4d/core-vs\platform\browserView\electron-browser\preload-browserView.js.map
