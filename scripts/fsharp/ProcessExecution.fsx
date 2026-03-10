open System
open System.IO
open System.Diagnostics
open System.Text

type ProcessResult =
    { ExitCode: int
      StdOut: string
      StdErr: string }

let executeProcess (processName: string) (processArgs: string) =
    let psi = new ProcessStartInfo(processName, processArgs)
    psi.UseShellExecute <- false // Required to redirect I/O
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.CreateNoWindow <- true

    let proc = Process.Start(psi)
    let output = new StringBuilder()
    let error = new StringBuilder()

    // Asynchronously read the output and error streams
    proc.OutputDataReceived.Add(fun args -> output.Append(args.Data) |> ignore)
    proc.ErrorDataReceived.Add(fun args -> error.Append(args.Data) |> ignore)
    proc.BeginOutputReadLine()
    proc.BeginErrorReadLine()

    proc.WaitForExit() // Wait for the process to exit

    { ExitCode = proc.ExitCode
      StdOut = output.ToString()
      StdErr = error.ToString() }
