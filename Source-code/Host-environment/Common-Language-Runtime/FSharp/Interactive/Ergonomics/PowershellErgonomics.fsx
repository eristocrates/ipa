open System.Diagnostics

let clip (text: string) =
    let proc = new Process()
    proc.StartInfo.FileName <- "clip"
    proc.StartInfo.UseShellExecute <- false
    proc.StartInfo.RedirectStandardInput <- true
    proc.Start() |> ignore
    proc.StandardInput.Write(text)
    proc.StandardInput.Close()
