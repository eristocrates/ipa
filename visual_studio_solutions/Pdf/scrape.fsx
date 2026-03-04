#r "nuget: FsHttp"
#r "nuget: Python.NET"
// https://www.verypdf.com/document/pdf-format-reference/pg_0001.htm

open System
open System.IO
open System.Threading
open FsHttp

type Page =
    { filePath: string
      fileContent: string }

let pages =
    seq {
        for pageIndex in 1..1..1310 do
            let stem = sprintf "pg_%04d" pageIndex
            let uri = $"https://www.verypdf.com/document/pdf-format-reference/{stem}.htm"
            // Thread.Sleep(500)

            let content =
                http { GET uri }
                |> Request.send
                |> Response.toText

            { filePath = $"""C:\Repositories\ipa\visual_studio_solutions\Pdf\pdf-format-reference\{stem}.html"""
              fileContent = content }
    }


pages
|> Seq.iter (fun page ->

    File.WriteAllText(page.filePath, page.fileContent)

)

// TODO run pdfminer.six, possibly from dotnet via fsharp interop
// https://medium.com/asp-dotnet/integrating-python-scripts-with-net-web-api-why-developers-need-this-skill-d2ad070bd749#:~:text=ProcessStartInfo:%20Configures%20the%20process%20to%20run%20the,script%2C%20passing%20num1%20and%20num2%20as%20arguments.
