module Program

open Browser.Dom

let main () =
    // For userscripts, this is a common “proof of life”
    console.log ("Hello from Fable userscript-style code")

    document.body.insertAdjacentHTML (
        "afterbegin",
        "<div style='position:fixed;top:0;left:0;z-index:999999;background:yellow;padding:6px;'>Fable says hi</div>"
    )

main ()
