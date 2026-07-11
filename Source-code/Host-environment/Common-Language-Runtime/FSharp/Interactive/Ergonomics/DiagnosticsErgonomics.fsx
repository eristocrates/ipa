open System
open System.IO
open System.Diagnostics

type Timed_Operation<'T> =
    { MillisecondsTaken: int64
      ReturnedValue: 'T }

let startwatch (func: unit -> 'T) : Timed_Operation<'T> =
    let timer = Stopwatch.StartNew()
    let result = func ()
    timer.Stop()

    { MillisecondsTaken = timer.ElapsedMilliseconds
      ReturnedValue = result }



type Load_Dependency =
    {

      file_path: string
      depends_on: Load_Dependency array

     }
    member this.file_name = Path.GetFileNameWithoutExtension(this.file_path)

let start_grep (pattern: string) (filePath: string) =
    try
        File.ReadAllLines(filePath)
        |> Seq.toArray
        |> Array.Parallel.choose (fun line ->

            if line.StartsWith(pattern) then
                Some line
            else
                None)
    with
    | err -> failwithf "File not found: %s with error %s" filePath err.Message

let rec load_dependencies target_file_path =
    let dependencies =
        start_grep "#load" target_file_path
        |> Array.map (fun load_directive ->

            let from_open_quote = load_directive.IndexOf '"' + 1
            let to_close_quote = load_directive.LastIndexOf '"' - 1
            load_dependencies load_directive[from_open_quote..to_close_quote]



        )

    { file_path = target_file_path
      depends_on = dependencies }
