#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

open UglyToad.PdfPig.Tokens
open UglyToad.PdfPig


type DictionaryToken with
    member this.data = this.Data |> Seq.toArray

type Structure with
    member this.catalogAcroForm = this.Catalog.CatalogDictionary.Data["AcroForm"]
    member this.catalogMarkInfo = this.Catalog.CatalogDictionary.Data["MarkInfo"]
    member this.catalogMetadata = this.Catalog.CatalogDictionary.Data["Metadata"]
    member this.catalogOCProperties = this.Catalog.CatalogDictionary.Data["OCProperties"]
    member this.catalogOutlines = this.Catalog.CatalogDictionary.Data["Outlines"]
    member this.catalogPages = this.Catalog.CatalogDictionary.Data["Pages"]

    member this.catalogStructTreeRoot =
        this.Catalog.CatalogDictionary.Data["StructTreeRoot"]

    member this.catalogType = this.Catalog.CatalogDictionary.Data["Type"]
