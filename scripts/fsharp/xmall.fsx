#load "ProcessExecution.fsx"

open ProcessExecution
open System
open System.IO


module java =
    let filePath = @"C:\shim\java.bat"

(*
        Usage:  dtdanalyzer {[-s] <system-id> | -d <xml-file> | -p <public-id>}
        [<options>] [<out>]

This utility analyzes a DTD and writes an XML output file.
-h,--help                    Get help.
-v,--version                 Print version number and exit.
-s,--system <system-id>      Use the given filename or system identifier to
                   find the DTD. This could be a relative pathname,
                   if the DTD exists in a file on your system, or an
                   HTTP URL. The '-s' switch is optional. Note that
                   if a catalog is in use, what looks like a
                   filename might resolve to something else
                   entirely.
-d,--doc <xml-file>          Specify an XML document used to find the DTD.
                   This could be just a "stub" file, that contains
                   nothing other than the doctype declaration and a
                   root element. This file doesn't need to be valid
                   according to the DTD.
-p,--public <public-id>      Use the given public identifier to find the DTD.
                   This would be used in conjunction with an OASIS
                   catalog file.
-c,--catalog <catalog-file>  Specify a file to use as the OASIS catalog, to
                   resolve system and public identifiers.
-x,--xslt <xslt>             An XSLT script to run to post-process the output.
-t,--title <dtd-title>       Specify the title of this DTD.
-r,--roots <roots>           Specify the set of possible root elements for
                   documents conforming to this DTD.
--docproc <cmd>           Command to use to process structured comments.
                   This command should take its input on stdin, and
                   produce valid XHTML on stdout.
-m,--markdown                Causes structured comments to be processed as
                   Markdown. Requires pandoc to be installed on the
                   system, and accessible to this process. Same as
                   "--docproc pandoc".  If you want to supply your
                   own Markdown processor, or any other processor,
                   use the --docproc option.
-P,--param <param=value>     Parameter name & value to pass to the XSLT.  You
                   can use multiple instances of this option.
-q,--debug                   Turns on debugging messages.
    *)
module dtdanalyzer =
    let filePath = @"C:\shim\DtdAnalyzer-0.5\dtdanalyzer.bat"

    let command (inputFilePath: string) (outputDirectoryPath: string) =
        let inputFileName = Path.GetFileName inputFilePath
        let outputFilePath = Path.Combine(outputDirectoryPath, $"{inputFileName}.xml")

        executeProcess filePath $""" "{inputFilePath}" "{outputFilePath}" """
        |> ignore
(*
    Usage:  dtdschematron {[-s] <system-id> | -d <xml-file> | -p <public-id>} [-f]
    [-c <catalog>] [-t <title>] [<out>]

This generates a schematron file from a DTD.
-h,--help                    Get help.
-v,--version                 Print version number and exit.
-s,--system <system-id>      Use the given filename or system identifier to
             find the DTD. This could be a relative pathname,
             if the DTD exists in a file on your system, or an
             HTTP URL. The '-s' switch is optional. Note that
             if a catalog is in use, what looks like a
             filename might resolve to something else
             entirely.
-d,--doc <xml-file>          Specify an XML document used to find the DTD.
             This could be just a "stub" file, that contains
             nothing other than the doctype declaration and a
             root element. This file doesn't need to be valid
             according to the DTD.
-p,--public <public-id>      Use the given public identifier to find the DTD.
             This would be used in conjunction with an OASIS
             catalog file.
-f,--full                    If this option is given, then a complete
             schematron will be generated from the DTD, as
             opposed to just extracting the rules in the
             annotations.
-c,--catalog <catalog-file>  Specify a file to use as the OASIS catalog, to
             resolve system and public identifiers.
-t,--title <dtd-title>       Specify the title of this DTD.
-r,--roots <roots>           Specify the set of possible root elements for
             documents conforming to this DTD.
--docproc <cmd>           Command to use to process structured comments.
             This command should take its input on stdin, and
             produce valid XHTML on stdout.
-m,--markdown                Causes structured comments to be processed as
             Markdown. Requires pandoc to be installed on the
             system, and accessible to this process. Same as
             "--docproc pandoc".  If you want to supply your
             own Markdown processor, or any other processor,
             use the --docproc option.
-P,--param <param=value>     Parameter name & value to pass to the XSLT.  You
             can use multiple instances of this option.
*)
module dtdschematron =
    let filePath = @"C:\shim\DtdAnalyzer-0.5\dtdschematron.bat"

    let command (inputFilePath: string) (outputDirectoryPath: string) =
        let inputFileName = Path.GetFileName inputFilePath
        let outputFilePath = Path.Combine(outputDirectoryPath, $"{inputFileName}.sch")


        executeProcess filePath $"""-f "{inputFilePath}" "{outputFilePath}" """
        |> ignore


// https://relaxng.org/jclark/trang-manual.html
module trang =
    let filePath = @"C:\shim\trang.jar"

    [<RequireQualifiedAccess>]
    type InputModule =
        | rng
        | rnc
        | dtd
        | xml
        static member flag = "I"

    [<RequireQualifiedAccess>]
    type OutputModule =
        | rng
        | rnc
        | dtd
        | xsd
        static member flag = "O"
        static member all = [| rng; rnc; dtd; xsd |]

    //usage: java com.thaiopensource.relaxng.translate.Driver [-C catalogFileOrUri] [-I rng|rnc|dtd|xml] [-O rng|rnc|dtd|xsd] [-i input-param] [-o output-param] inputFileOrUri ... outputFile
    let command
        (inputFileExtension: InputModule)
        (outputFileExtension: OutputModule)
        (inputFilePath: string)
        (outputDirectoryPath: string)
        =
        let inputFileName = Path.GetFileName inputFilePath


        Directory.CreateDirectory outputDirectoryPath
        |> ignore

        let outputFileName = $"{inputFileName}.{outputFileExtension.ToString()}"

        let outputFilePath = Path.Combine(outputDirectoryPath, outputFileName)

        executeProcess
            java.filePath
            $"""-jar {filePath} -{InputModule.flag} {inputFileExtension.ToString()} -{OutputModule.flag} {outputFileExtension.ToString()} "{inputFilePath}" "{outputFilePath}" """
        |> Console.WriteLine

        if outputFileExtension = OutputModule.dtd then
            dtdanalyzer.command outputFilePath outputDirectoryPath
            dtdschematron.command outputFilePath outputDirectoryPath





let xmall (inputFilePath: string) (outputDirectory: string) =
    let fileExtension =
        let inputExtension = (Path.GetExtension inputFilePath).TrimStart('.')

        match inputExtension with
        | "rng" -> trang.InputModule.rng
        | "rnc" -> trang.InputModule.rnc
        | "dtd" -> trang.InputModule.dtd
        | "xml"
        | "Xml"
        | "config"
        | "wsdl"
        | "asmx"
        | "aspx"

         -> trang.InputModule.xml
        | _ -> failwith $"{inputExtension} is not a known fileExtension"

    trang.OutputModule.all
    |> Array.Parallel.iter (fun outputFileExtension ->
        trang.command fileExtension outputFileExtension inputFilePath outputDirectory
        |> ignore

    )



module IPS_2025_04_01 =
    let inputRootDirectoryPath =
        @"D:\Surface\United_States_Government\County\Leon\Management_Information_Systems\Infor\Servers\InforProd\D\Downloads\IPS_2025_04_01"

    let outputRootDirectoryPath =
        $"""D:\Artifact\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\Files\IPS_2025_04_01"""

    let xmlFilePaths =
        Directory.EnumerateFiles(inputRootDirectoryPath, "*.xml", SearchOption.AllDirectories)
        |> List.ofSeq

    let configFilePaths =
        Directory.EnumerateFiles(inputRootDirectoryPath, "*.config", SearchOption.AllDirectories)
        |> List.ofSeq

    let aspxFilePaths =
        Directory.EnumerateFiles(inputRootDirectoryPath, "*.aspx", SearchOption.AllDirectories)
        |> List.ofSeq

    let inputFilePaths =
        xmlFilePaths @ configFilePaths @ aspxFilePaths
        |> Array.ofList

    inputFilePaths
    |> Array.Parallel.iter (fun inputFilePath ->

        let outputDirectoryPath =
            inputFilePath.Replace(inputRootDirectoryPath, outputRootDirectoryPath)

        xmall inputFilePath outputDirectoryPath

    )


module IPS_Web_Services_2025_04_01 =
    let inputRootDirectoryPath =
        @"D:\Surface\United_States_Government\County\Leon\Management_Information_Systems\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01"

    let outputRootDirectoryPath =
        $"""D:\Artifact\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\Files\IPS_Web_Services_2025_04_01"""

    let xmlFilePaths =
        Directory.EnumerateFiles(inputRootDirectoryPath, "*.xml", SearchOption.AllDirectories)
        |> List.ofSeq

    let configFilePaths =
        Directory.EnumerateFiles(inputRootDirectoryPath, "*.config", SearchOption.AllDirectories)
        |> List.ofSeq

    let wsdlFilePaths =
        Directory.EnumerateFiles(inputRootDirectoryPath, "*.wsdl", SearchOption.AllDirectories)
        |> List.ofSeq


    let inputFilePaths =
        xmlFilePaths @ configFilePaths @ wsdlFilePaths
        |> Array.ofList

    inputFilePaths
    |> Array.Parallel.iter (fun inputFilePath ->

        let outputDirectoryPath =
            inputFilePath.Replace(inputRootDirectoryPath, outputRootDirectoryPath)

        xmall inputFilePath outputDirectoryPath

    )
