open System
open System.IO

// -----------------------------
// Edit these two variables
// -----------------------------
let rootDirectory = @"C:\Repositories\ipa"
let gitignoreFilepath = $"""{rootDirectory}\.gitignore"""
// -----------------------------

let thresholdBytes = 100L * 1024L * 1024L // 100 MiB

let normalizeToGitPath (p: string) = p.Replace('\\', '/')

let relativeGitPath (rootDir: string) (fullPath: string) =
    Path.GetRelativePath(rootDir, fullPath) |> normalizeToGitPath

let escapeGitignoreLine (line: string) =
    // Avoid accidental comment/negation if the path starts with '#' or '!'
    if
        line.StartsWith("#", StringComparison.Ordinal)
        || line.StartsWith("!", StringComparison.Ordinal)
    then
        "\\" + line
    else
        line

let enumerateFilesRecursive (rootDir: string) : seq<string> =
    let opts = EnumerationOptions()
    opts.RecurseSubdirectories <- true
    opts.IgnoreInaccessible <- true
    opts.AttributesToSkip <- FileAttributes.ReparsePoint
    Directory.EnumerateFiles(rootDir, "*", opts)

let tryFileSize (path: string) =
    try
        let fi = FileInfo(path)

        if fi.Exists then Some fi.Length else None
    with _ ->
        None

let rootFull = Path.GetFullPath(rootDirectory)

if not (Directory.Exists(rootFull)) then
    failwith $"rootDirectory does not exist: {rootFull}"

let largeFiles =
    enumerateFilesRecursive rootFull
    |> Seq.choose (fun fp ->
        match tryFileSize fp with
        | Some size when size >= thresholdBytes -> Some fp
        | _ -> None)
    |> Seq.distinct
    |> Seq.sort
    |> Seq.toList

let gitignoreLines =
    seq {
        yield @"**bin/"
        yield @"**obj/"
        yield @"**.vs/"
        yield @".fake"
        yield @"secret/"
        yield ""
        yield "# ------------------------------------------------------------"
        yield "# GENERATED: ignores files >= 100 MiB"
        yield $"# root: {rootFull}"
        yield "# ------------------------------------------------------------"

        if largeFiles.IsEmpty then
            yield "# (no files met or exceeded the threshold)"
        else
            yield! largeFiles |> Seq.map (relativeGitPath rootFull) |> Seq.map escapeGitignoreLine
    }
    |> Seq.toArray

let outputPath =
    if Path.IsPathRooted(gitignoreFilepath) then
        gitignoreFilepath
    else
        Path.Combine(rootFull, gitignoreFilepath)

Directory.CreateDirectory(Path.GetDirectoryName(outputPath)) |> ignore

File.WriteAllLines(outputPath, gitignoreLines)

printfn "Scanned: %s" rootFull
printfn "Large files found: %d" largeFiles.Length
printfn "Wrote: %s" outputPath
