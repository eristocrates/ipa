open System
open System.IO

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\StringErgonomics.fsx"
open StringErgonomics

[<Literal>]
let cmdDirectoryPathString =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Shell\Powershell"

[<Literal>]
let binDirectoryPathString =
    @"C:\Repositories\eristocrates\ipa\Application\graphviz\Graphviz-14.1.4-win64\bin"

let stems =
    [|


       "acyclic"
       "bcomps"
       "ccomps"
       "circo"
       "cluster"
       "diffimg"
       "dijkstra"
       "dot"
       "dot2gxl"
       "dot_builtins"
       "edgepaint"
       "fdp"
       "gc"
       "gml2gv"
       "graphml2gv"
       "gv2gml"
       "gv2gxl"
       "gvcolor"
       "gvgen"
       "gvmap"
       "gvpack"
       "gvpr"
       "gxl2dot"
       "gxl2gv"
       "mingle"
       "mm2gv"
       "neato"
       "nop"
       "osage"
       "patchwork"
       "prune"
       "sccmap"
       "sfdp"
       "tred"
       "twopi"
       "unflatten"

       |]

let percent = "%"

stems
|> Array.Parallel.iter (fun stem ->


    let exeFilePath = Path.Combine(binDirectoryPathString, $"{stem}.exe")
    let cmdFilePath = Path.Combine(cmdDirectoryPathString, $"{stem}.cmd")


    let cmdFileContent =
        trimmedString
            $"""
@echo off
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& {exeFilePath}" {percent}*
                    """

    File.WriteAllText(cmdFilePath, cmdFileContent)


)
