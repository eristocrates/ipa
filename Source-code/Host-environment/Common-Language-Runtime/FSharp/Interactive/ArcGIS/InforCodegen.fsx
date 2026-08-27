# time on
fsi.PrintLength <- 3
fsi.ShowDeclarationValues <- false

open System
open System.Threading
open System.IO
open System.Text

open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Xml.Serialization
open System.Xml.Schema


#r "nuget: FSharp.Literals, 2.2.15"
open FSharp.Literals

#r "nuget: FSharp.Data"
open FSharp.Data


#r "nuget: FSharp.XExtensions"
open FSharp.XExtensions
#r "nuget: LitXml"
open LitXml


#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

#r "nuget: Fabulous.AST"

open Fabulous.AST
open Fantomas.Core


#r "nuget: CaseConverter"
open CaseConverter

#r "nuget: SQLProvider.MsSql, 1.5.27"
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
#r "nuget: Microsoft.Data.SqlClient, 5.2.2"
#r "nuget: Microsoft.SqlServer.DacFx, 162.5.57"
open Microsoft.SqlServer
// #r "nuget: Microsoft.Data.SqlClient, 6.0.0"
// open Microsoft.Data.SqlClient







#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics
#load @"C:\Secret\InforSecrets.fsx"
open InforSecrets


type Converters with
    static member to_snake_case(original_string: string) = Converters.ToSnakeCase(original_string)
    static member To_Pascal_Snake_Case(original_string: string) =
        original_string
        |> Converters.ToSnakeCase
        |> Converters.ToTitleCase

type Type with 
    member this.fsharp_name = Literal.stringifyTypeDynamic this

        
type XPathNavigator with
    static member Load(file: FileInfo) =
        XPathDocument(file.FullName).CreateNavigator()
(*
type Dac.Model.TSqlModel with 
        member this.TableValuedFunctions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableValuedFunction")

        member this.ScalarFunctions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ScalarFunction")

        member this.Indexes =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Index")

        member this.CheckConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "CheckConstraint")

        member this.DatabaseOptions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DatabaseOptions")

        member this.DefaultConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DefaultConstraint")

        member this.DmlTriggers =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DmlTrigger")

        member this.ExtendedPropertys =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ExtendedProperty")

        member this.ForeignKeyConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ForeignKeyConstraint")

        member this.Logins =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Login")

        member this.PrimaryKeyConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "PrimaryKeyConstraint")

        member this.Procedures =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Procedure")

        member this.Roles =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Role")

        member this.RoleMemberships =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "RoleMembership")

        member this.Schemas =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Schema")

        member this.Statisticss =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Statistics")

        member this.Synonyms =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Synonym")

        member this.Tables =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Table")

        member this.TableTypes =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableType")

        member this.UniqueConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "UniqueConstraint")

        member this.Users =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "User")

        member this.Views =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "View")



*)





















module Folder = 
    let WebServices = DirectoryInfo @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices"
    let Generated = DirectoryInfo @"C:\Repositories\appsdb\IPS_Sites\integration\InforModel\Generated"



module Document =
    module InforProdSql = 
        module Dacpac = 
            [<Literal>]
            let file_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\operations.dacpac"
            let file = FileInfo file_path

            [<Literal>]
            let xml_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\dapac\model.xml"
            let xml_file = new FileInfo(xml_path)
            let xml_navigator = XPathNavigator.Load(xml_file)
            let xml = XmlProvider<xml_path>.Load(xml_path)
            [<Literal>]
            let xsd_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\dapac\dacpac.xsd"
            let xsd_file = new FileInfo(xsd_path)
            let xsd_navigator = XPathNavigator.Load(xsd_file)
            let xsd = XmlProvider<xsd_path>.Load(xsd_path)
                
    let Types = Path.Combine(Folder.Generated.FullName, "Types.fs") |> FileInfo



let xsd_inferrer = XmlSchemaInference()

module WebServices = 
    [<Literal>]
    let xsd_path =
        @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices\BusinessObjects.xsd"
    let xsd_file = new FileInfo(xsd_path)
    let xsd = XmlProvider<xsd_path>.Load(xsd_path)
    let xsd_navigator = XPathNavigator.Load(xsd_file)

module HansenDataDistribution =
    [<Literal>]
    let xml_path =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"
    let xml_file = new FileInfo(xml_path)
    let xml_navigator = XPathNavigator.Load(xml_file)
    let xml = XmlProvider<xml_path>.Load(xml_path)
    [<Literal>]
    let xsd_path =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xsd"
    let xsd_file = new FileInfo(xsd_path)

    let xsd_navigator = XPathNavigator.Load(xsd_file)
    let xsd = XmlProvider<xsd_path>.Load(xsd_path).Element.ComplexType.Sequence.Element.ComplexType.Sequence


let infer_xsds (xml_path: string) =
    let output_directory =
        Path.GetDirectoryName(Path.GetFullPath(xml_path))

    let base_name =
        Path.GetFileNameWithoutExtension(xml_path)

    let xsd_inferrer = XmlSchemaInference()

    let schemas =
        use reader = XmlReader.Create(xml_path)

        xsd_inferrer.InferSchema(reader).Schemas()
        |> Seq.cast<XmlSchema>
        |> Seq.toArray

    let writer_settings = XmlWriterSettings()
    writer_settings.Indent <- true

    schemas
    |> Array.mapi (fun index schema ->
        let xsd_path =
            if schemas.Length = 1 then
                Path.Combine(output_directory, $"{base_name}.xsd")
            else
                Path.Combine(
                    output_directory,
                    $"{base_name}.{index + 1}.xsd"
                )

        use writer = XmlWriter.Create(xsd_path, writer_settings)
        schema.Write(writer)

        xsd_path)

infer_xsds HansenDataDistribution.xml_path

let extract_xsd_schemas () =
    Directory.GetFiles(Folder.WebServices.FullName, "*.wsdl",SearchOption.AllDirectories)
    |> Array.Parallel.iter (fun wsdl_file_path -> 
        let wsdl_file = new FileInfo(wsdl_file_path)

        let xsd_file = Path.ChangeExtension(wsdl_file_path,".xsd") |> FileInfo
        let wsdl_xdocument = XDocument.Load(wsdl_file.FullName)
        let maybe_xsd_element = 
            wsdl_xdocument.Root.Descendants()
            |> Seq.tryFind(fun descendant -> 
                match descendant.Name.NamespaceName, descendant.Name.LocalName with 
                |"http://www.w3.org/2001/XMLSchema","schema" -> true
                | _ -> false
                )
        match maybe_xsd_element with 
        | Some xsd_element -> xsd_element.Save xsd_file.FullName
        | None -> ()


    )

let xsd_files = 
    Directory.GetFiles(Folder.WebServices.FullName, "*.xsd",SearchOption.AllDirectories)
    |> Array.Parallel.map (fun xsd_file_path -> 
    new FileInfo(xsd_file_path)
    )

let xsd_elements = 

    xsd_files
    |> Array.Parallel.collect (fun xsd_file -> 
    let xsd_xdocument = XDocument.Load(xsd_file.FullName)
    xsd_xdocument.Root.Elements() |> Seq.toArray
    )


let business_object_names = 
    xsd_elements
    |> Array.Parallel.collect (fun xsd_element -> 

            xsd_element.DescendantsAndSelf()
            |> Seq.toArray
            |> Array.choose (fun element -> 
            try
                match element.Attribute "name"  with 
                | name when name.Value = "oBusinessObject" -> Some (element.Attribute "type" |> _.Value.Replace("hns:",""))
                | _ -> None
            with
            | _ -> None
            )
            

    )
    |> Set.ofArray

let business_object_elements = 
    xsd_elements
    |> Array.Parallel.choose (fun element -> 
            try
                let name = element.Attribute "name"
                if business_object_names.Contains(name.Value) then  
                    Some (element)
                else
                    None
            with
            | _ -> None
            )


module XMLSchema = 
    let namespace_name =  "http://www.w3.org/2001/XMLSchema"
    let xnamespace = XNamespace.Get namespace_name
    let prefix_from_context (context_element:XElement) = context_element.GetPrefixOfNamespace xnamespace
    let qname_from_curie(curie:string)(context_element:XElement) = 
        let prefix = prefix_from_context context_element
        XmlQualifiedName(curie[prefix.Length+1..], namespace_name)
    let simple_type_from_qname(qname:XmlQualifiedName) = XmlSchemaType.GetBuiltInSimpleType qname
    let fsharp_type_from_simple_type(simple_type:XmlSchemaSimpleType) = simple_type.Datatype.ValueType.fsharp_name
    let fsharp_type_from_curie(curie:string)(context_element:XElement) = 
        context_element |> qname_from_curie curie |> simple_type_from_qname |> fsharp_type_from_simple_type
let combined_schema =
    

    XElement(
        XMLSchema.xnamespace + "schema",
        XAttribute(XNamespace.Xmlns + "s", XMLSchema.xnamespace),
        XAttribute("elementFormDefault", "qualified"),
        XAttribute("targetNamespace", "http://hansen.com/"),
        business_object_elements
        |> Array.map XElement
    )

// combined_schema.Save(WebServices.xsd_path)
module dacpac = 

        [<Literal>]
        let xml_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\dapac\model.xml"
        let xml_file = new FileInfo(xml_path)
        let xml_navigator = XPathNavigator.Load(xml_file)
        let xml = XmlProvider<xml_path>.Load(xml_path)
        [<Literal>]
        let xsd_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\dapac\dacpac.xsd"
        let xsd_file = new FileInfo(xsd_path)
        let xsd_navigator = XPathNavigator.Load(xsd_file)
        let xsd = XmlProvider<xsd_path>.Load(xsd_path)



module InforProdSql =
    module Data =

        type Provider = 
          SqlDataProvider<
                            ConnectionString=Prod.connection_string,
                            IndividualsAmount=10000,
                            UseOptionTypes=Common.NullableColumnType.OPTION
                          >
        let operations = Provider.GetDataContext()
(*
    module Dac =
        let extract_dacpac () =
            let services = new Dac.DacServices(Prod.connection_string)

            let extractOptions = Dac.DacExtractOptions()
            extractOptions.ExtractAllTableData <- true
            extractOptions.ExtractReferencedServerScopedElements <- true
            extractOptions.ExtractUsageProperties <- true

            services.Extract(
                targetPath = Document.InforProdSql.Dacpac.file_path,
                databaseName = "operations",
                applicationName = "operations",
                applicationVersion = Version(0, 0, 1, 0),
                applicationDescription = null,
                tables = null,
                extractOptions = extractOptions,
                cancellationToken = Nullable<CancellationToken>()
            )
        let Model =
            let options = Dac.Model.ModelLoadOptions()

            options.LoadAsScriptBackedModel <- true
            options.ModelStorageType <- Dac.DacSchemaModelStorageType.Memory

            Dac.Model.TSqlModel.LoadFromDacpac(Document.InforProdSql.Dacpac.file_path, options)
        


type Dac.Model.ObjectIdentifier with 
  member this.display  = InforProdSql.Dac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, false)
  member this.full_display  = InforProdSql.Dac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, true)
  
type Dac.Model.TSqlObject with 
  member this.simple_name  = InforProdSql.Dac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.SimpleName)
  member this.escaped_simple_name  = InforProdSql.Dac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.EscapedSimpleName)
  member this.fully_qualified_name  = InforProdSql.Dac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.FullyQualifiedName)
  member this.escaped_fully_qualified_name  = InforProdSql.Dac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.EscapedFullyQualifiedName)
*)
let test_attribute = HansenDataDistribution.xsd.Elements[0].ComplexType.Attributes[0]

 



HansenDataDistribution.xsd.Elements[2].ComplexType.Sequence.Value.Elements



WebServices.xsd.ComplexTypes[0].Sequence.Elements[0]



let random_schema = InforProdSql.Dac.Model.Schemas |> Seq.find (fun schema -> schema.simple_name = "MetaData")
random_schema.simple_name
random_schema.escaped_simple_name
random_schema.fully_qualified_name
random_schema.escaped_fully_qualified_name
random_schema.Name.display
random_schema.Name.full_display



type Product_Family =
    { name: string
      is_agency_enhancable: bool
      owner: string
      is_hansen: bool 
      required_system_license_name : string option 
      schema: Dac.Model.TSqlObject
      
      }

let product_famiies = 
    HansenDataDistribution.xml.HansenMetadata.ProductFamilies
    |> Array.Parallel.map (fun ProductFamily -> 
        let schema = InforProdSql.Dac.Model.Schemas |> PSeq.find (fun schema -> 
                                                        match schema.fully_qualified_name with 
                                                        | "MetaData" -> schema.fully_qualified_name = ProductFamily.Name
                                                        | _ -> schema.fully_qualified_name = ProductFamily.Name.ToUpperInvariant().Replace('.','_')
                                                        )
        {
            name = ProductFamily.Name
            is_agency_enhancable = ProductFamily.IsAgencyEnhancable
            owner = ProductFamily.Owner
            is_hansen = ProductFamily.IsHansen
            required_system_license_name = ProductFamily.RequiredSystemLicense |> Option.map (fun license -> license.Name)
            schema = schema
        }
    )



let random_product_family = product_famiies |> Array.randomChoice
random_schema.GetReferencing()


dacpac.xml.Model
|> Array.filter (fun entry -> entry)

|> Seq.toArray
random_product_family.schema.ObjectType

HansenDataDistribution.xsd.Elements[0].ComplexType.Attributes[0]

module Types = 

    let fs_text = 
                Ast.Oak() {
                  Ast.Namespace($"Infor") {
                    Ast.Open("System")
                    for element in HansenDataDistribution.xsd.Elements do
                        let type_name = Converters.To_Pascal_Snake_Case element.Name
                    
                        Ast.Record(type_name) {
                            for attribute in element.ComplexType.Attributes do
                                let field_name = Converters.to_snake_case attribute.Name
                                let field_type_name = HansenDataDistribution.xsd.XElement |> XMLSchema.fsharp_type_from_curie test_attribute.Type
                                match type_name, field_name, field_type_name with 
                                | _, "effective_date_time", _ -> Ast.Field(field_name, "DateTime")
                                | _, "expired_date_time", _ -> Ast.Field(field_name, "DateTime option")
                                | _, "type", _ when type_name.Contains("Column") -> Ast.Field("sql_type", "string")
                                | "Table", "type", _  -> Ast.Field("kind", "string")
                                | _, _, _ when field_name.StartsWith("is_") -> Ast.Field(field_name, "bool")
                                | _, _, _ -> Ast.Field(field_name, field_type_name)
                        }

                }
                }
                |> Gen.mkOak
                |> Gen.run    
            
    File.WriteAllText(Document.Types.FullName,fs_text)
    















(*






WebServices.xsd.ComplexTypes
|> Array.Parallel.iter (fun complex_type -> 
    let moniker = complex_type.Name

    let dot_index = moniker.LastIndexOf(".")
    let namespace_name = moniker[0..dot_index-1]
    let local_name = moniker[dot_index+1..]
    
    let fs_file = Path.Combine(Folder.Generated.FullName, $"{moniker}.fs") |> FileInfo

    let fs_text = 
                Ast.Oak() {
                  Ast.Namespace($"Infor.{namespace_name}") {
                    Ast.Open("System")
                    for element in HansenDataDistribution.xsd.Elements do
                        let type_name = Converters.To_Pascal_Snake_Case element.Name
                    
                        Ast.Record(local_name) {
                            for attribute in element.ComplexType.Attributes do
                                let field_name = Converters.to_snake_case attribute.Name
                                let field_type_name = HansenDataDistribution.xsd.XElement |> XMLSchema.fsharp_type_from_curie test_attribute.Type
                                match type_name, field_name, field_type_name with 
                                | _, "effective_date_time", _ -> Ast.Field(field_name, "DateTime")
                                | _, "expired_date_time", _ -> Ast.Field(field_name, "DateTime option")
                                | _, "type", _ when type_name.Contains("Column") -> Ast.Field("sql_type", "string")
                                | "Table", "type", _  -> Ast.Field("kind", "string")
                                | _, _, _ when field_name.StartsWith("is_") -> Ast.Field(field_name, "bool")
                                | _, _, _ -> Ast.Field(field_name, field_type_name)
                        }

                }
                }
                |> Gen.mkOak
                |> Gen.run    
            
    File.WriteAllText(fs_file.FullName,fs_text)
    )







*)
