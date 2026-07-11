#r "nuget: FSharp.Data"

open System
open System.IO
open System.Xml.Linq
open FSharp.Data

module fibo =
    let localRepository = @"C:\Repositories\fibo"

    let distributionPrePath = "https://spec.edmcouncil.org/fibo/ontology/master/latest"

    module catalog =
        [<Literal>]
        let filePath = @"C:\Repositories\fibo\catalog-v001.xml"

        type Provider = XmlProvider<filePath>
        let xml = Provider.Load(filePath)


let filePaths =
    Array.distinct <| Directory.GetFiles(fibo.localRepository)
    |> Array.filter (fun filePath ->
        let extension = Path.GetExtension(filePath)
        extension = ".xml")
    |> Array.map (fun filePath -> filePath)

File.WriteAllLines(@"filePaths.txt", filePaths)

let dotPathSubstitution (prePath: string) (dotPath: string) =
    match dotPath with
    | _ when dotPath.Chars 0 = '.' -> $"{prePath}{dotPath.Substring(1)}"
    | _ when dotPath.Chars 0 = '/' -> $"{prePath}{dotPath}"
    | _ when dotPath.Chars 0 = '\\' -> $"{prePath}{dotPath}"
    | _ -> $"{prePath}/{dotPath}"

let statements =
    fibo.catalog.xml.Uris
    |> Array.map (fun vocabulary ->
        let distributionString = dotPathSubstitution fibo.distributionPrePath vocabulary.Uri

        let prefixLabel =
            let deDot = vocabulary.Uri.Substring(1).Replace(".rdf", "")
            let suffix = deDot.Replace("/", ".")
            $"fibo{suffix}"

        let statement =
            $"""Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "{vocabulary.Name}" (Some @"{distributionString}") (Some "{prefixLabel}") None"""

        statement

    )

File.WriteAllLines(@"statements.txt", statements)
