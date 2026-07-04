open System
open System.IO

let rootDirectory = @"C:\Repositories\eristocrates\ipa"
let gitignoreFilepath = $"""{rootDirectory}\.gitignore"""
// -----------------------------

let thresholdBytes = 100L * 1024L * 1024L // 100 MiB

let normalizeToGitPath (p: string) = p.Replace('\\', '/')

let relativeGitPath (rootDir: string) (fullPath: string) =
    Path.GetRelativePath(rootDir, fullPath)
    |> normalizeToGitPath

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

        if fi.Exists then
            Some fi.Length
        else
            None
    with
    | _ -> None

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
        yield @".git/objects/pack/"
        yield @"Application/Microsoft/Edge/data_dir/"

        yield
            @"C:/Repositories/eristocrates/ipa/Source-code/Host-environment/Common-Language-Runtime/FSharp/Project/MyProvider/packages/"
        yield ".git/objects/pack/pack-88ea8cb40b1997cd6e35551754c02de933a9b0a0.pack"
        yield ".git/objects/pack/pack-8ff8b05fa6a5bf0473a1bb3dcd159c22df7a13e2.pack"
        yield ".git/objects/pack/pack-f9b9b8199abe090a5206fd8521fa29b9c5fddaa8.pack"
        yield ".git/objects/pack/tmp_pack_swa5ds"
        yield "Application/MMT/content/MMT/LATIN2/.git/objects/pack/pack-43b870377222ffe65ac4f272dcb155d5f932a01c.pack"
        yield "Application/Microsoft/Edge/data_dir/ProvenanceData/2025.10.7.5/vti-b-p32-visual.quant.ort"
        yield "Application/Microsoft/Edge/data_dir/component_crx_cache/f081de18a604e95a175eaf4dd91b35b7f17ad4de24ee2f20eeb034c979bbcccb"
        yield "Application/VSCodium/VSCodium-win32-x64-1.112.01855-insider/VSCodium - Insiders.exe"
        yield "Application/gephi/gephi-0.10.1-windows-x64.exe"
        yield "Language/Java/jdk-15/lib/modules"
        yield "Language/Java/jdk-17.0.2/lib/modules"
        yield "Language/Java/shj/lib/modules"
        yield "Language/Rdf/Owl/owlapi/.git/objects/pack/pack-f625ab40efa82cf5d2cc863eae8247ca82248dc3.pack"
        yield "Language/Rdf/Rml/RMLStreamer-v2.5.0-standalone.jar"
        yield "Language/Rdf/Rml/rmlmapper-8.1.0-r380-all.jar"
        yield "Language/Rdf/Sparql/sparql-anything-server-v1.1.0-geosparql.jar"
        yield "Language/Rdf/Sparql/sparql-anything-server-v1.1.0.jar"
        yield "Language/Rdf/Sparql/sparql-anything-v1.1.0-geosparql.jar"
        yield "Language/Rdf/Sparql/sparql-anything-v1.1.0.jar"
        yield "Language/Xml/basex/Basex122/data/LCPW_OverlayStormwaterInfrastructure_D_WM/tbl.basex"
        yield "Language/Xml/basex/Basex122/data/ucd.all.flat/tbl.basex"
        yield "Persistence/Database/Embedded/Document/FastDB/Unicode/Unicode/Triples.db"


        yield ""
        yield "# ------------------------------------------------------------"
        yield "# GENERATED: ignores files >= 100 MiB"
        yield $"# root: {rootFull}"
        yield "# ------------------------------------------------------------"

        if largeFiles.IsEmpty then
            yield "# (no files met or exceeded the threshold)"
        else
            yield!
                largeFiles
                |> Seq.map (relativeGitPath rootFull)
                |> Seq.map escapeGitignoreLine
    }
    |> Seq.toArray

let outputPath =
    if Path.IsPathRooted(gitignoreFilepath) then
        gitignoreFilepath
    else
        Path.Combine(rootFull, gitignoreFilepath)

Directory.CreateDirectory(Path.GetDirectoryName(outputPath))
|> ignore

File.WriteAllLines(outputPath, gitignoreLines)

printfn "Scanned: %s" rootFull
printfn "Large files found: %d" largeFiles.Length
printfn "Wrote: %s" outputPath
