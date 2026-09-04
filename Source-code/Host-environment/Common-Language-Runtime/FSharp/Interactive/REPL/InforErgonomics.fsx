#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

open FSharp.Data

#r "nuget: Microsoft.SqlServer.DacFx, 162.5.57"

open Microsoft.SqlServer

open Dubzer.WhatwgUrl




module HansenDataDistribution =
    [<Literal>]
    let xmlFilePath =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"

    type Provider = XmlProvider<UseOriginalNames=true, PreferDateOnly=true, Sample=xmlFilePath>
    let xml = Provider.Load xmlFilePath




(*


#load @"C:\Secret\InforSecrets.fsx"
open InforSecrets

type InforProdSql = SqlDataProvider<IndividualsAmount=1000, UseOptionTypes=Common.NullableColumnType.OPTION, CaseSensitivityChange = Common.CaseSensitivityChange.ORIGINAL,
    SsdtPath = Prod.dapac,
    ConnectionString=Prod.connection_string>

let operations = InforProdSql.GetDataContext()


*)



module Dacpac =
    [<Literal>]
    let xmlFilePath =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\dapac\model.xml"

    type Provider = XmlProvider<UseOriginalNames=true, PreferDateOnly=true, Sample=xmlFilePath>
    let xml = Provider.Load xmlFilePath

    let Model =
        let options = Dac.Model.ModelLoadOptions()

        options.LoadAsScriptBackedModel <- true
        options.ModelStorageType <- Dac.DacSchemaModelStorageType.Memory

        Dac.Model.TSqlModel.LoadFromDacpac(
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\operations.dacpac",
            options
        )



type Dac.Model.ObjectIdentifier with
    member this.display =
        Dacpac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, false)

    member this.fullDisplay =
        Dacpac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, true)

type Dac.Model.TSqlObject with
    member this.simpleName =
        Dacpac.Model.DisplayServices.GetElementName(this, Dac.Model.ElementNameStyle.SimpleName)

    member this.escapedSimpleName =
        Dacpac.Model.DisplayServices.GetElementName(this, Dac.Model.ElementNameStyle.EscapedSimpleName)

    member this.fullyQualifiedName =
        Dacpac.Model.DisplayServices.GetElementName(this, Dac.Model.ElementNameStyle.FullyQualifiedName)

    member this.escapedFullyQualifiedName =
        Dacpac.Model.DisplayServices.GetElementName(this, Dac.Model.ElementNameStyle.EscapedFullyQualifiedName)

module Infor =
    module infortest =
        let test_operations = DomUrl "https://infortest.leoncountyfl.gov/test_operations/"

(*
  member this.maybeProductFamily =
    HansenDataDistribution.xml.hansenMetadata.productFamilies
    |> Array.tryFind (fun productFamily ->
                            match this.fullyQualifiedName with
                            | "MetaData" -> this.fullyQualifiedName = productFamily.name
                            | _ -> this.fullyQualifiedName = productFamily.name.ToUpperInvariant().Replace('.','_')
    )
  member this.maybeTable =
    HansenDataDistribution.xml.hansenMetadata.productFamilies
    |> Array.tryPick (fun productFamily ->
                        productFamily.tables
                        |> Array.tryFind (fun table ->
                            match this.fullyQualifiedName with
                            | "MetaData" -> this.fullyQualifiedName = table.name
                            | _ -> this.fullyQualifiedName = table.name.ToUpperInvariant().Replace('.','_')
                        )
    )

  *)

(*

HansenDataDistribution.xml.hansenMetadata.productFamilies
|> Array.filter (fun productFamily -> productFamily.name = "AssetManagement.Storm")
|> Array.collect (fun productFamily -> productFamily.tables |> Array.filter (fun table -> table.databaseName.StartsWith("COMP")))
|> Array.collect (fun table -> table.columns |> Array.filter (fun column -> column.name = "AssetKey") )
|> Array.head




frontTab.page.GoTo Infor.infortest.test_operations
frontTab.childFrames[0]
let selectedNodes = El.Iframe * Attr.Id.Equals "menuAndView" |> frontTab.document.DocumentElement.QuerySelectorAll

selectedNodes
frontTab.document.Body

frontTab.childFrames[0]



let menuAndView = frontTab.childFrames |> Array.find (fun browserFrame -> browserFrame.frame.DomUrl.Pathname.EndsWith("Menu.aspx"))


type InforMenuItem =
    {
        menuItem :Dom.Element
    }
    static member fromId (id:string) =
        {
            menuItem = Attr.Id.Equals id |> menuAndView.document.QuerySelector
        }
    member this.pathName =  this.menuItem.OwnerDocument.DomUrl.Absolute.HashTerminated.asIriReference.asPathName ./ this.menuItem.Id
    member this.selector = El.Li * Attr.Id.Equals (string this.menuItem.Id)
    member this.labelFor = string this.menuItem.Id |> Attr.Aria.LabelledBy.Equals  |> menuAndView.document.QuerySelector
    member this.Click() = menuAndView.frame.Click this.selector
    member this.name = this.menuItem.FirstChild.TextContent
    member this.sampleIdentifier = $"{this.name}HtmlPath"
    member this.HtmlAbbrev = Ast.Abbrev($"{this.name}HtmlProvider",$"HtmlProvider<PreferOptionals = true, PreferDateOnly = true, Sample = {this.sampleIdentifier}>")
    member this.XmlAbbrev = Ast.Abbrev($"{this.name}XmlProvider", $"XmlProvider<UseOriginalNames = true, PreferDateOnly = true, Sample = {this.sampleIdentifier}>")
    member this.WriteHtmlText() =  this.menuItem.outerHTML |> this.pathName.writeTextFileExtension ".html"
    member this.htmlFile = this.pathName.asFileExtension ".html"

    member this.ProviderText =
        if not this.htmlFile.Exists then
            this.WriteHtmlText()
        Ast.Oak(){
            Ast.AnonymousModule(){
                Ast.Value(this.sampleIdentifier, Ast.VerbatimString(this.htmlFile.FullName))
                |> _.attribute(
                    Ast.Attribute("Literal")
                )
                this.HtmlAbbrev
                this.XmlAbbrev
            }
        }
        |> Gen.mkOak
        |> Gen.run

module InforMenu =
    let Asset_Management = InforMenuItem.fromId "AstMngmnt"
    let Inventory = InforMenuItem.fromId "Invntry"
    let Work_Management = InforMenuItem.fromId "WrkMngmnt"
    let Customer_Service = InforMenuItem.fromId "CstmrSrvc"
    let Resources = InforMenuItem.fromId "Rsrcs"
    let System = InforMenuItem.fromId "Systm"
    let Portal = InforMenuItem.fromId "Prtl"

[<Literal>]
let SystemHtmlPath =
    @"C:\Iri\https\infortest.leoncountyfl.gov\test_operations\Menu.aspx\hash\Systm.html"

type SystemHtmlProvider = HtmlProvider<PreferOptionals = true, PreferDateOnly = true, Sample = SystemHtmlPath>
type SystemXmlProvider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true, Sample = SystemHtmlPath>
let SystemHtml = SystemHtmlProvider.Load SystemHtmlPath
let SystemXHtml = SystemXmlProvider.Parse InforMenu.System.menuItem.outerHTML
SystemXHtml.ul.lis[0].ul
SystemHtml.Lists
let monikers = SystemXHtml.ul.lis |> Array.choose (fun li -> li.moniker)
SystemXHtml.ul.lis[0]

InforMenu.System.ProviderText |> clip
InforMenu.System.WriteHtmlText()
InforMenu.System.htmlFile
InforMenu.System.pathName
InforMenu.System.Click()
InforMenu.System.menuItem.Children[1u].Children[0u].Children[1u].Children[0u].Children[0u].TextContent
InforMenu.System.menuItem.TagName
InforMenu.System.menuItem.Children[0u].TagName
InforMenu.System.menuItem.outerHTML |> clip

let inforMenuItems = menuAndView.menuitems |> Array.map (fun menuitem -> { menuItem = menuitem})

*)
