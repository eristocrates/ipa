#time on
fsi.PrintLength <- 1
fsi.ShowDeclarationValues <- false
#r "nuget: Newtonsoft.Json, 13.0.0.0"

#I @"D:\https\com\github\eristocrates\ipa\dll"
#I @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx\.paket\load"
#load "Me.fsx"
open Me
#load "Clipboard.fsx"
open Clipboard
//#load @".paket/load/main.group.fsx"
#r "DoxAletheia.Runtime.dll"
open DoxAletheia
open DoxAletheia.Runtime
open type Functional

// open Ada.Url
open AngleSharp.Attributes
open AngleSharp.Dom
open AngleSharp.Html.Parser
open FSharp.Collections.ParallelSeq

open BrowserApi.Css.Authoring
open canopy
// open Dubzer.WhatwgUrl
open DynamicObj
open Fabulous.AST.Json
// open Fli
open Flurl
// open FolkerKinzel.MimeTypes
open FSharp.Data
open FSharp.Data.JsonExtensions
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open FSharp.Json
// open FSharpPlus
// open FsHttp
// open FsPublicSuffix
open HCollections
// open Iana
// open IriTools
// open Json.More
open Json.Path
open Json.Pointer
// open JsonStructure
// open Meziantou.Framework
// open MimeDetective
// open Nager.PublicSuffix
// open Nager.PublicSuffix.Models
// open Nager.PublicSuffix.RuleParsers
// open Nager.PublicSuffix.RuleProviders
// open Newtonsoft.Json
// open Newtonsoft.Json.Linq
// open NJsonSchema
open NLanguageTag
// open NuGet
// open NuGet.CatalogReader
// open NuGet.Common
// open NuGet.Protocol
// open NuGet.Protocol.Core.Types
// open NuGet.Protocol.Resources
open OpenQA.Selenium
open OpenQA.Selenium.Edge
open OpenQA.Selenium.Remote
open ProviderImplementation.ProvidedTypes
open PuppeteerSharp
open PuppeteerSharp.Cdp
// open RDFSharp.Model
open ShapeSifter
open ShapeSifter.Patterns
open System
open System.Collections
// open System.Collections.Concurrent
// open System.ComponentModel.DataAnnotations
// open System.Diagnostics
open System.Globalization
open System.IO
open System.Linq
// open System.Net
// open System.Numerics
open System.Reflection
// open System.Security.Cryptography
open System.Text
open System.Text.Json
// open System.Text.Json.Schema
// open System.Text.Json.Serialization
// open System.Text.RegularExpressions
// open System.Threading
// open System.Threading.Tasks
// open System.Xml
// open System.Xml.Schema
// open System.Xml.Linq
open System
open System.IO
open System.Collections.Generic
open Newtonsoft.Json
open System.Globalization
open System.Xml.XPath
// open Tavis.UriTemplates
open TypeEquality
open TypeShape
open TypeShape.Core
// open VDS.Common.Tries
open VDS.RDF
open WebSharper.Core
#r "nuget: Esri.ArcGISRuntime, 300.0.0"
open Esri.ArcGISRuntime
open FSharp.Interop.Excel

open Microsoft.FSharp.Linq.RuntimeHelpers
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Reflection
open Microsoft.VisualBasic.FileIO
open BasicGraphActivePattern
open type RdfTerm

type JsonNode = Nodes.JsonNode
type JsonNodeObject = Nodes.JsonObject
type JsonNodeArray = Nodes.JsonArray
type JsonNodeValue = Nodes.JsonValue
module FSharpLiteral = FSharp.Literals.Literal
module TType = ShapeSifter.Patterns

let Neapolitan_Pizza =
    File.ReadAllText(@"D:\https\com\github\eristocrates\ipa\cook\Neapolitan-Pizza.cook")
    |> CookLangNet.CookLangParser.parse

type UriSchemes = Iana.RegistryProvider.``Uniform Resource Identifier (URI) Schemes``.``Uniform Resource Identifier (URI) Schemes``
type PublicSuffixes = PublicSuffixList.PublicSuffixProvider
type Mime = Iana.InternetMediaTypeProvider

(*

type xsd = VocabularyProvider<"xsd", "http://www.w3.org/2001/XMLSchema#", @"D:\http\org\w3\www\2001\XMLSchema&num;\text\turtle.ttl">
type rdfa = VocabularyProvider<"rdfa", "http://www.w3.org/ns/rdfa#", @"D:\http\org\w3\www\ns\rdfa&num;\text\turtle.ttl">
type void_ = VocabularyProvider<"void", "http://rdfs.org/ns/void#", @"D:\http\org\rdfs\ns\void&num;\text\turtle.ttl">
type dc = VocabularyProvider<"dc", "http://purl.org/dc/elements/1.1/", @"D:\http\org\purl\dc\elements\1.1&sol;\text\turtle.ttl">
type dcat = VocabularyProvider<"dcat", "http://www.w3.org/ns/dcat#", @"D:\http\org\w3\www\ns\dcat&num;\text\turtle.ttl">
type dcterms = VocabularyProvider<"dcterms", "http://purl.org/dc/terms/", @"D:\http\org\purl\dc\terms&sol;\text\turtle.ttl">
type org = VocabularyProvider<"org", "http://www.w3.org/ns/org#", @"D:\http\org\w3\www\ns\org&num;\text\turtle.ttl">
type jsonld = VocabularyProvider<"jsonld", "http://www.w3.org/ns/json-ld#", @"D:\http\org\w3\www\ns\json-ld&num;\text\turtle.ttl">
type agrontology = VocabularyProvider<"agrontology", "http://aims.fao.org/aos/agrontology#", @"D:\http\org\fao\aims\aos\agrontology&num;\text\turtle.ttl">
type goodrelations = VocabularyProvider<"goodrelations", "http://purl.org/goodrelations/v1#", @"D:\http\org\purl\goodrelations\v1&num;\text\turtle.ttl">
type schemorg = VocabularyProvider<"schemorg", "https://schema.org/", @"D:\https\org\schema&sol;\text\turtle.ttl">
type valueflows = VocabularyProvider<"valueflows", "https://w3id.org/valueflows/ont/vf#", @"D:\https\org\w3id\valueflows\ont\vf&num;\text\turtle.ttl">
type skosxl = VocabularyProvider<"skosxl", "http://www.w3.org/2008/05/skos-xl#", @"D:\http\org\w3\www\2008\05\skos-xl&num;\text\turtle.ttl">
type om = VocabularyProvider<"om", "https://open-metadata.org/ontology/", @"D:\https\org\open-metadata\ontology&sol;\text\turtle.ttl">
type jsonschema = VocabularyProvider<"jsonschema", "https://www.w3.org/2019/wot/json-schema#", @"D:\https\org\w3\www\2019\wot\json-schema&num;\text\turtle.ttl">

type obo = VocabularyProvider<"obo", "http://purl.obolibrary.org/obo/", """
    D:\http\org\purl\heals\foodon&sol;\text\turtle.ttl
    D:\http\org\obolibrary\purl\obo\ro.owl&num;\text\turtle.ttl
    D:\http\org\obolibrary\purl\obo\bfo.owl&num;\text\turtle.ttl
    """>

*)

type rdf = VocabularyProvider<"rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#", @"D:\http\org\w3\www\1999\02\22-rdf-syntax-ns&num;\text\turtle.ttl">
type rdfs = VocabularyProvider<"rdfs", "http://www.w3.org/2000/01/rdf-schema#", @"D:\http\org\w3\www\2000\01\rdf-schema&num;\text\turtle.ttl">
type owl = VocabularyProvider<"owl", "http://www.w3.org/2002/07/owl#", @"D:\http\org\w3\www\2002\07\owl&num;\text\turtle.ttl">
type foaf = VocabularyProvider<"foaf", "http://xmlns.com/foaf/0.1/", @"D:\http\com\xmlns\foaf\0.1&sol;\text\turtle.ttl">
type jsonvalues = VocabularyProvider<"json", "https://ontology.inferal.com/modules/json-values/", @"D:\https\com\inferal\ontology\modules\json-values&sol;\text\turtle.ttl">
type skos = VocabularyProvider<"skos", "http://www.w3.org/2004/02/skos/core#", @"D:\http\org\w3\www\2004\02\skos\core&num;\text\turtle.ttl">
type time = VocabularyProvider<"time", "http://www.w3.org/2006/time#", @"D:\http\org\w3\www\2006\time&num;\text\turtle.ttl">
type huto = VocabularyProvider<"huto", "http://ns.inria.fr/huto/", @"D:\http\fr\inria\ns\huto&sol;\text\turtle.ttl">
type fx = VocabularyProvider<"fx", "http://sparql.xyz/facade-x/ns/", @"D:\http\xyz\sparql\facade-x\ns&sol;\text\turtle.ttl">
type fxe = VocabularyProvider<"fx", "http://sparql.xyz/facade-x/engine/", @"D:\http\xyz\sparql\facade-x\engine%sol;\text\turtle.ttl">

module fxd =
    let _namespace = RdfVocabulary.PREFIX("fxd", "http://sparql.xyz/facade-x/data/")
    type fxd =
        static member acquisition_date = _namespace.curie "acquisition_date"
        static member acquisition_number = _namespace.curie "acquisition_number"
        static member adjusted_amount = _namespace.curie "adjusted_amount"
        static member amount = _namespace.curie "amount"
        static member available_date = _namespace.curie "available_date"
        static member brand_description = _namespace.curie "brand_description"
        static member brand_name = _namespace.curie "brand_name"
        static member brand_owner = _namespace.curie "brand_owner"
        static member branded_food_category = _namespace.curie "branded_food_category"
        static member carbohydrate_value = _namespace.curie "carbohydrate_value"
        static member code = _namespace.curie "code"
        static member data_points = _namespace.curie "data_points"
        static member data_source = _namespace.curie "data_source"
        static member data_type = _namespace.curie "data_type"
        static member derivation_code = _namespace.curie "derivation_code"
        static member derivation_description = _namespace.curie "derivation_description"
        static member derivation_id = _namespace.curie "derivation_id"
        static member description = _namespace.curie "description"
        static member discontinued_date = _namespace.curie "discontinued_date"
        static member end_date = _namespace.curie "end_date"
        static member expiration_date = _namespace.curie "expiration_date"
        static member fat_value = _namespace.curie "fat_value"
        static member fdc_id = _namespace.curie "fdc_id"
        static member fdc_id_of_acquisition_food = _namespace.curie "fdc_id_of_acquisition_food"
        static member fdc_id_of_input_food = _namespace.curie "fdc_id_of_input_food"
        static member fdc_id_of_sample_food = _namespace.curie "fdc_id_of_sample_food"
        static member fdc_publication_date = _namespace.curie "fdc_publication_date"
        static member Field = _namespace.curie "Field"
        static member food_attribute_type_id = _namespace.curie "food_attribute_type_id"
        static member food_category_id = _namespace.curie "food_category_id"
        static member food_code = _namespace.curie "food_code"
        static member food_group_code = _namespace.curie "food_group_code"
        static member food_nutrient_conversion_factor_id = _namespace.curie "food_nutrient_conversion_factor_id"
        static member food_nutrient_id = _namespace.curie "food_nutrient_id"
        static member foodClass = _namespace.curie "foodClass"
        static member foodid = _namespace.curie "foodid"
        static member footnote = _namespace.curie "footnote"
        static member foundation_year_acquired = _namespace.curie "foundation_year_acquired"
        static member GLOBAL = _namespace.curie "GLOBAL"
        static member gram_weight = _namespace.curie "gram_weight"
        static member gtin_upc = _namespace.curie "gtin_upc"
        static member household_serving_fulltext = _namespace.curie "household_serving_fulltext"
        static member id = _namespace.curie "id"
        static member ingredient_code = _namespace.curie "ingredient_code"
        static member Ingredient_description = _namespace.curie "Ingredient_description"
        static member ingredients = _namespace.curie "ingredients"
        static member is_refuse = _namespace.curie "is_refuse"
        static member lab_method_id = _namespace.curie "lab_method_id"
        static member label_weight = _namespace.curie "label_weight"
        static member location = _namespace.curie "location"
        static member loq = _namespace.curie "loq"
        static member market_class = _namespace.curie "market_class"
        static member market_country = _namespace.curie "market_country"
        static member max = _namespace.curie "max"
        static member max_value = _namespace.curie "max_value"
        static member measure_unit_id = _namespace.curie "measure_unit_id"
        static member median = _namespace.curie "median"
        static member method = _namespace.curie "method"
        static member microbe_code = _namespace.curie "microbe_code"
        static member min = _namespace.curie "min"
        static member min_value = _namespace.curie "min_value"
        static member min_year_acquired = _namespace.curie "min_year_acquired"
        static member modified_date = _namespace.curie "modified_date"
        static member modifier = _namespace.curie "modifier"
        static member name = _namespace.curie "name"
        static member NDB_number = _namespace.curie "NDB_number"
        static member not_a_significant_source_of = _namespace.curie "not_a_significant_source_of"
        static member nutrient_code = _namespace.curie "nutrient_code"
        static member nutrient_id = _namespace.curie "nutrient_id"
        static member nutrient_name = _namespace.curie "nutrient_name"
        static member nutrient_nbr = _namespace.curie "nutrient_nbr"
        static member nutrient_value = _namespace.curie "nutrient_value"
        static member nutrient_value_ = _namespace.curie "nutrient_value_"
        static member package_weight = _namespace.curie "package_weight"
        static member pct_weight = _namespace.curie "pct_weight"
        static member portion_code = _namespace.curie "portion_code"
        static member portion_description = _namespace.curie "portion_description"
        static member preparation_state_code = _namespace.curie "preparation_state_code"
        static member protein_value = _namespace.curie "protein_value"
        static member publication_date = _namespace.curie "publication_date"
        static member rank = _namespace.curie "rank"
        static member retention_code = _namespace.curie "retention_code"
        static member retention_description = _namespace.curie "retention_description"
        static member sales_type = _namespace.curie "sales_type"
        static member sample_lot_nbr = _namespace.curie "sample_lot_nbr"
        static member scientific_name = _namespace.curie "scientific_name"
        static member sell_by_date = _namespace.curie "sell_by_date"
        static member seq_num = _namespace.curie "seq_num"
        static member serving_size = _namespace.curie "serving_size"
        static member serving_size_unit = _namespace.curie "serving_size_unit"
        static member short_description = _namespace.curie "short_description"
        static member sr_addmod_year = _namespace.curie "sr_addmod_year"
        static member sr_code = _namespace.curie "sr_code"
        static member sr_description = _namespace.curie "sr_description"
        static member start_date = _namespace.curie "start_date"
        static member state = _namespace.curie "state"
        static member store_city = _namespace.curie "store_city"
        static member store_name = _namespace.curie "store_name"
        static member store_state = _namespace.curie "store_state"
        static member subbrand_name = _namespace.curie "subbrand_name"
        static member survey_flag = _namespace.curie "survey_flag"
        static member technique = _namespace.curie "technique"
        static member trade_channel = _namespace.curie "trade_channel"
        static member treatment = _namespace.curie "treatment"
        static member unit = _namespace.curie "unit"
        static member unit_name = _namespace.curie "unit_name"
        static member uom = _namespace.curie "uom"
        static member upc_code = _namespace.curie "upc_code"
        static member value = _namespace.curie "value"
        static member wweia_category_code = _namespace.curie "wweia_category_code"
        static member wweia_food_category_code = _namespace.curie "wweia_food_category_code"
        static member wweia_food_category_description = _namespace.curie "wweia_food_category_description"
open fxd

// obo.

module governmentjobs =
    let ApplicationsSystemsAnalystI =
        iriref "https://www.governmentjobs.com/careers/leoncountyfl/classspecs/1183950"
        |> foaf.NamedIndividual'.Document

module myfuelmaster =
    let https = iriref "https://myfuelmaster.com/" |> foaf.NamedIndividual'.Document
    let desktop_support_technician =
        iriref "https://myfuelmaster.com/job/desktop-support-technician-8"
        |> foaf.NamedIndividual'.Document

module wellsfargo =
    let _namespace = RdfVocabulary.personal "wellsfargo"
    let everydayChecking = _namespace.curie "everydayChecking"
    let platinumCard = _namespace.curie "platinumCard"
    let installmentLoans = _namespace.curie "installmentLoans"
    let wellsFargoRewards = _namespace.curie "wellsFargoRewards"

    module checking =
        let everyday = Iri.ref "https://www.wellsfargo.com/checking/everyday"
module usaa =
    let _namespace = RdfVocabulary.personal "usaa"
    let checking = _namespace.curie "checking"
    let platinumVisa = _namespace.curie "platinumVisa"
    let usaaSavings = _namespace.curie "usaaSavings"

    module banking =

        let checking = Iri.ref "https://www.usaa.com/banking/checking"
        let savings = Iri.ref "https://www.usaa.com/banking/savings"
module crew =
    let checkingAccountDisclosure = Iri.ref "https://www.trycrew.com/pdfjs/web/viewer?file=%2Fdocs%2Fdeposit-agreement.pdf#h.g82ej3s9bgif"

module gov =
    module leoncountyfl =
        module cms =
            let OfficeofInformationTechnology =
                Iri.ref "https://cms.leoncountyfl.gov/Government/Departments/Information-and-Technology/Office-of-Information-Technology"
                |> foaf.NamedIndividual'.Document
module leinfo =
    let _namespace = RdfVocabulary.ensurePrefix ("lei", "http://lei.info/")
    let _l1 = RdfVocabulary.ensurePrefix ("leiL1", "http://lei.info/voc/l1/")
    type leinfo =
        static member WellsFargoNationalBank = _namespace.curie "KB1H1DSPRFMYMCUFXT09"
        static member USAAFederalSavingsBank = _namespace.curie "C5654JQHZUHN0772B561"
        static member BangorSavingsBank = _namespace.curie "549300JEBULFT3BSU682"
open leinfo

module dbug =
    let _namespace = RdfVocabulary.personal "dbug"
    type dbug =
        static member testIndividual = _namespace.curie "testIndividual" |> NamedIndividualIri |> Individual
        static member Bob = _namespace.curie "Bob" |> foaf.NamedIndividual'.Person
        static member Alice = _namespace.curie "Alice" |> foaf.NamedIndividual'.Person
open dbug

module commonplace =
    let _namespace = RdfVocabulary.personal "commonplace"
    let _ontology = OntologyBuilder _namespace.namespaceIri
    type commonplace =
        static member eristocrates = _namespace.curie "eristocrates" |> foaf.NamedIndividual'.Person
        static member syrislove = _namespace.curie "syrislove" |> foaf.NamedIndividual'.Person
        static member WellsFargoEverydayChecking = _namespace.curie "WellsFargoEverydayChecking"
        static member WellsFargoEverydayCheckingAccount = _namespace.curie "WellsFargoEverydayCheckingAccount"
        static member WellsFargoEverydayCheckingAccountCurrentBalance = _namespace.curie "WellsFargoEverydayCheckingAccountCurrentBalance"
        static member WellsFargoEverydayCheckingAccountAvailableBalance = _namespace.curie "WellsFargoEverydayCheckingAccountAvailableBalance"
        static member USAAClassicChecking = _namespace.curie "USAAClassicChecking"
        static member USAAClassicCheckingAccount = _namespace.curie "USAAClassicCheckingAccount"
        static member USAAClassicCheckingAccountCurrentBalance = _namespace.curie "USAAClassicCheckingAccountCurrentBalance"
        static member USAAClassicCheckingAccountAvailableBalance = _namespace.curie "USAAClassicCheckingAccountAvailableBalance"
        static member USAAClassicSavings = _namespace.curie "USAAClassicSavings"
        static member USAAClassicSavingsAccount = _namespace.curie "USAAClassicSavingsAccount"
        static member USAAClassicSavingsAccountCurrentBalance = _namespace.curie "USAAClassicSavingsAccountCurrentBalance"
        static member USAAClassicSavingsAccountAvailableBalance = _namespace.curie "USAAClassicSavingsAccountAvailableBalance"
        static member CrewFinanceChecking = _namespace.curie "CrewFinanceChecking"
        static member CrewFinanceCheckingAccount = _namespace.curie "CrewFinanceCheckingAccount"
        static member CrewFinanceCheckingAccountCurrentBalance = _namespace.curie "CrewFinanceCheckingAccountCurrentBalance"
        static member CrewFinanceCheckingAccountAvailableBalance = _namespace.curie "CrewFinanceCheckingAccountAvailableBalance"
        static member hasCurrentBalance = _namespace.curie "hasCurrentBalance"
        static member hasAvailableBalance = _namespace.curie "hasAvailableBalance"
        static member CurrentBalance = _namespace.curie "CurrentBalance"
        static member AvailableBalance = _namespace.curie "AvailableBalance"
open commonplace

module fdc_dataset =
    let _namespace = RdfVocabulary.personal "fdc_dataset"
    let _ontology = OntologyBuilder _namespace.namespaceIri
    type fdc_dataset =
        static member acquisition_date = _namespace.curie "acquisition_date"
        static member acquisition_number = _namespace.curie "acquisition_number"
        static member adjusted_amount = _namespace.curie "adjusted_amount"
        static member amount = _namespace.curie "amount"
        static member available_date = _namespace.curie "available_date"
        static member brand_description = _namespace.curie "brand_description"
        static member brand_name = _namespace.curie "brand_name"
        static member brand_owner = _namespace.curie "brand_owner"
        static member branded_food_category = _namespace.curie "branded_food_category"
        static member carbohydrate_value = _namespace.curie "carbohydrate_value"
        static member code = _namespace.curie "code"
        static member data_points = _namespace.curie "data_points"
        static member data_source = _namespace.curie "data_source"
        static member data_type = _namespace.curie "data_type"
        static member derivation_code = _namespace.curie "derivation_code"
        static member derivation_description = _namespace.curie "derivation_description"
        static member derivation_id = _namespace.curie "derivation_id"
        static member description = _namespace.curie "description"
        static member discontinued_date = _namespace.curie "discontinued_date"
        static member end_date = _namespace.curie "end_date"
        static member expiration_date = _namespace.curie "expiration_date"
        static member fat_value = _namespace.curie "fat_value"
        static member fdc_id = _namespace.curie "fdc_id"
        static member fdc_id_of_acquisition_food = _namespace.curie "fdc_id_of_acquisition_food"
        static member fdc_id_of_input_food = _namespace.curie "fdc_id_of_input_food"
        static member fdc_id_of_sample_food = _namespace.curie "fdc_id_of_sample_food"
        static member fdc_publication_date = _namespace.curie "fdc_publication_date"
        static member Field = _namespace.curie "Field"
        static member food_attribute_type_id = _namespace.curie "food_attribute_type_id"
        static member food_category_id = _namespace.curie "food_category_id"
        static member food_code = _namespace.curie "food_code"
        static member food_group_code = _namespace.curie "food_group_code"
        static member food_nutrient_conversion_factor_id = _namespace.curie "food_nutrient_conversion_factor_id"
        static member food_nutrient_id = _namespace.curie "food_nutrient_id"
        static member foodClass = _namespace.curie "foodClass"
        static member foodid = _namespace.curie "foodid"
        static member footnote = _namespace.curie "footnote"
        static member foundation_year_acquired = _namespace.curie "foundation_year_acquired"
        static member GLOBAL = _namespace.curie "GLOBAL"
        static member gram_weight = _namespace.curie "gram_weight"
        static member gtin_upc = _namespace.curie "gtin_upc"
        static member household_serving_fulltext = _namespace.curie "household_serving_fulltext"
        static member id = _namespace.curie "id"
        static member ingredient_code = _namespace.curie "ingredient_code"
        static member Ingredient_description = _namespace.curie "Ingredient_description"
        static member ingredients = _namespace.curie "ingredients"
        static member is_refuse = _namespace.curie "is_refuse"
        static member lab_method_id = _namespace.curie "lab_method_id"
        static member label_weight = _namespace.curie "label_weight"
        static member location = _namespace.curie "location"
        static member loq = _namespace.curie "loq"
        static member market_class = _namespace.curie "market_class"
        static member market_country = _namespace.curie "market_country"
        static member max = _namespace.curie "max"
        static member max_value = _namespace.curie "max_value"
        static member measure_unit_id = _namespace.curie "measure_unit_id"
        static member median = _namespace.curie "median"
        static member method = _namespace.curie "method"
        static member microbe_code = _namespace.curie "microbe_code"
        static member min = _namespace.curie "min"
        static member min_value = _namespace.curie "min_value"
        static member min_year_acquired = _namespace.curie "min_year_acquired"
        static member modified_date = _namespace.curie "modified_date"
        static member modifier = _namespace.curie "modifier"
        static member name = _namespace.curie "name"
        static member NDB_number = _namespace.curie "NDB_number"
        static member not_a_significant_source_of = _namespace.curie "not_a_significant_source_of"
        static member nutrient_code = _namespace.curie "nutrient_code"
        static member nutrient_id = _namespace.curie "nutrient_id"
        static member nutrient_name = _namespace.curie "nutrient_name"
        static member nutrient_nbr = _namespace.curie "nutrient_nbr"
        static member nutrient_value = _namespace.curie "nutrient_value"
        static member nutrient_value_ = _namespace.curie "nutrient_value_"
        static member package_weight = _namespace.curie "package_weight"
        static member pct_weight = _namespace.curie "pct_weight"
        static member portion_code = _namespace.curie "portion_code"
        static member portion_description = _namespace.curie "portion_description"
        static member preparation_state_code = _namespace.curie "preparation_state_code"
        static member protein_value = _namespace.curie "protein_value"
        static member publication_date = _namespace.curie "publication_date"
        static member rank = _namespace.curie "rank"
        static member retention_code = _namespace.curie "retention_code"
        static member retention_description = _namespace.curie "retention_description"
        static member sales_type = _namespace.curie "sales_type"
        static member sample_lot_nbr = _namespace.curie "sample_lot_nbr"
        static member scientific_name = _namespace.curie "scientific_name"
        static member sell_by_date = _namespace.curie "sell_by_date"
        static member seq_num = _namespace.curie "seq_num"
        static member serving_size = _namespace.curie "serving_size"
        static member serving_size_unit = _namespace.curie "serving_size_unit"
        static member short_description = _namespace.curie "short_description"
        static member sr_addmod_year = _namespace.curie "sr_addmod_year"
        static member sr_code = _namespace.curie "sr_code"
        static member sr_description = _namespace.curie "sr_description"
        static member start_date = _namespace.curie "start_date"
        static member state = _namespace.curie "state"
        static member store_city = _namespace.curie "store_city"
        static member store_name = _namespace.curie "store_name"
        static member store_state = _namespace.curie "store_state"
        static member subbrand_name = _namespace.curie "subbrand_name"
        static member survey_flag = _namespace.curie "survey_flag"
        static member technique = _namespace.curie "technique"
        static member trade_channel = _namespace.curie "trade_channel"
        static member treatment = _namespace.curie "treatment"
        static member unit = _namespace.curie "unit"
        static member unit_name = _namespace.curie "unit_name"
        static member uom = _namespace.curie "uom"
        static member upc_code = _namespace.curie "upc_code"
        static member value = _namespace.curie "value"
        static member wweia_category_code = _namespace.curie "wweia_category_code"
        static member wweia_food_category_code = _namespace.curie "wweia_food_category_code"
        static member wweia_food_category_description = _namespace.curie "wweia_food_category_description"

let a = rdf.``type``

let inline (-//) (curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject)) (predicateObjects: PredicateObject list) =
    predicateObjects
    |> List.map (fun predicateObject -> curSubject.asSubject --/ predicateObject)

let (.@) (lexicalForm: string) (languageTag: LanguageTag) = {
    lexicalForm = lexicalForm
    languageTag = languageTag
    baseDirection = None
}

let (@@) (lexicalForm: string) (languageTag: LanguageTag, baseDirection: InitialTextDirection) = {
    lexicalForm = lexicalForm
    languageTag = languageTag
    baseDirection = Some baseDirection
}

let foodCsv = CsvFile.Load @"D:\https\gov\usda\nal\fdc\fdc-datasets\FoodData_Central_csv_2026-10-29\food.csv"
foodCsv.Headers

type CsvFile with

    member this.predicates =
        match this.Headers with
        | Some headers -> headers |> Array.map (fun header -> fxd._namespace.curie header |> IriPredicate)
        | None -> [||]

    member this.triplfy(subjectMapping: CsvRow -> Iri) =

        let predicates = this.predicates

        this.Rows
        |> Seq.collect (fun row ->
            let subject = subjectMapping row

            Array.zip predicates row.Columns
            |> Seq.map (fun (predicate, column) -> subject --/ predicate /-> column.literal))

type JsonLine =
    | JsonObjectLine of pointer: JsonPointer * path: JsonPath
    | JsonArrayLine of pointer: JsonPointer * path: JsonPath
    | JsonStringLine of pointer: JsonPointer * path: JsonPath * value: string
    | JsonNumberLine of pointer: JsonPointer * path: JsonPath * value: string
    | JsonBooleanLine of pointer: JsonPointer * path: JsonPath * value: bool
    | JsonNullLine of pointer: JsonPointer * path: JsonPath

    member this.pointer =
        match this with
        | JsonObjectLine(pointer, _)
        | JsonArrayLine(pointer, _)
        | JsonStringLine(pointer, _, _)
        | JsonNumberLine(pointer, _, _)
        | JsonBooleanLine(pointer, _, _)
        | JsonNullLine(pointer, _) -> pointer

    member this.path =
        match this with
        | JsonObjectLine(_, path)
        | JsonArrayLine(_, path)
        | JsonStringLine(_, path, _)
        | JsonNumberLine(_, path, _)
        | JsonBooleanLine(_, path, _)
        | JsonNullLine(_, path) -> path
type JsonLineContainer = {
    pointer: JsonPointer
    path: JsonPath
    isArray: bool
    mutable nextIndex: int
    mutable propertyName: string option
}
module JsonLine =

    let stream (filePath: string) : seq<JsonLine> =
        seq {
            use file = File.OpenRead(filePath)
            use text = new StreamReader(file)
            use reader = new JsonTextReader(text)

            reader.DateParseHandling <- DateParseHandling.None

            let containers = Stack<JsonLineContainer>()

            let nextLocation () =
                if containers.Count = 0 then
                    JsonPointer.Empty, JsonPath.Root
                else
                    let parent = containers.Peek()

                    if parent.isArray then
                        let index = parent.nextIndex
                        parent.nextIndex <- index + 1

                        parent.pointer.Combine(index), parent.path.Append(index)

                    else
                        match parent.propertyName with
                        | Some propertyName ->
                            parent.propertyName <- None

                            let path =
                                if propertyName = "" then
                                    JsonPath.Parse(parent.path.ToString() + "[\"\"]")
                                else
                                    parent.path.Append(propertyName)

                            parent.pointer.Combine(propertyName), path

                        | None -> failwith "Expected JSON property name."

            while reader.Read() do
                match reader.TokenType with

                | JsonToken.PropertyName -> containers.Peek().propertyName <- Some(string reader.Value)

                | JsonToken.StartObject ->
                    let pointer, path = nextLocation ()

                    containers.Push {
                        pointer = pointer
                        path = path
                        isArray = false
                        nextIndex = 0
                        propertyName = None
                    }

                    yield JsonObjectLine(pointer, path)

                | JsonToken.StartArray ->
                    let pointer, path = nextLocation ()

                    containers.Push {
                        pointer = pointer
                        path = path
                        isArray = true
                        nextIndex = 0
                        propertyName = None
                    }

                    yield JsonArrayLine(pointer, path)

                | JsonToken.EndObject
                | JsonToken.EndArray -> containers.Pop() |> ignore

                | JsonToken.String ->
                    let pointer, path = nextLocation ()

                    yield JsonStringLine(pointer, path, string reader.Value)

                | JsonToken.Integer
                | JsonToken.Float ->
                    let pointer, path = nextLocation ()

                    yield JsonNumberLine(pointer, path, Convert.ToString(reader.Value, CultureInfo.InvariantCulture))

                | JsonToken.Boolean ->
                    let pointer, path = nextLocation ()

                    yield JsonBooleanLine(pointer, path, unbox<bool> reader.Value)

                | JsonToken.Null ->
                    let pointer, path = nextLocation ()

                    yield JsonNullLine(pointer, path)

                | JsonToken.Comment -> ()

                | token -> failwithf "Unsupported JSON token: %A" token
        }

    let serialize (line: JsonLine) =

        use text = new StringWriter()
        use writer = new JsonTextWriter(text)

        writer.WriteStartObject()

        writer.WritePropertyName("pointer")
        writer.WriteValue(line.pointer.ToString())

        writer.WritePropertyName("path")
        writer.WriteValue(line.path.ToString())

        writer.WritePropertyName("kind")

        match line with
        | JsonObjectLine _ -> writer.WriteValue("object")

        | JsonArrayLine _ -> writer.WriteValue("array")

        | JsonStringLine(_, _, value) ->
            writer.WriteValue("string")
            writer.WritePropertyName("value")
            writer.WriteValue(value)

        | JsonNumberLine(_, _, value) ->
            writer.WriteValue("number")
            writer.WritePropertyName("value")
            writer.WriteRawValue(value)

        | JsonBooleanLine(_, _, value) ->
            writer.WriteValue("boolean")
            writer.WritePropertyName("value")
            writer.WriteValue(value)

        | JsonNullLine _ ->
            writer.WriteValue("null")
            writer.WritePropertyName("value")
            writer.WriteNull()

        writer.WriteEndObject()
        writer.Flush()

        text.ToString()
module branded_food =
    [<Literal>]
    let jsonFilePath = @"D:\https\gov\usda\nal\fdc\fdc-datasets\FoodData_Central_branded_food_json_2026-10-29.json"
    // type Provider = JsonProvider<UseOriginalNames = true,  OmitNullFields = true, RootName = "PayStubSummaryList", Sample = jsonFilePath >
    // let json = Provider.Load jsonFilePath
    let jsonl = JsonLine.stream jsonFilePath

type FxResource = {
    localReference: string option
    remoteReference: string option
    datasources: FxDataSource * seq<FxDataSource>
}
and FxDataSource = {
    sourceName: string
    rootContainer: FxRoot
}
and FxRoot = {
    rootIri: Iri option
    typeIris: Iri list
    slots: seq<FxSlot>
}
and FxContainer = {
    containerIri: Iri option
    typeIris: Iri list
    slots: seq<FxSlot * SlotFiller>
}
and FxSlot =
    | NumberSlot of int
    | StringSlot of string
and SlotFiller =
    | SlotContainer of FxContainer
    | SlotValue of FxValue
and FxValue = FxLiteral of Literal

type RdfVocabulary with
    member this.curie(jsonPointer: JsonPointer) =
        fun (sourceName: string) ->
            let localName = $"{sourceName}#{jsonPointer.ToString()}"
            this.curie localName
type JsonPointer with
    member this.tryParent =
        match this.GetParent() |> Option.ofNullable with
        | Some parentPointer -> Some parentPointer
        | None -> None
    member this.parent = this.tryParent.Value

type JsonPath with
    member this.FxSlot =
        let lastSegment = this.Segments |> Array.last
        match lastSegment.Selectors |> Array.last with
        | :? NameSelector as selector -> StringSlot selector.Name
        | :? IndexSelector as selector -> NumberSlot selector.Index

module fdc =
    let _namespace = RdfVocabulary.PREFIX("fdc", "https://fdc.nal.usda.gov/fdc-datasets/")

type FxSlot with
    member this.Iri =
        match this with
        | StringSlot localName -> fxd._namespace.curie localName |> IriPredicate
        | NumberSlot index -> rdf.vocabulary'.curie $"_{index + 1}" |> IriPredicate
    member this.nameLiteral =
        match this with
        | StringSlot localName -> localName.literal
        | NumberSlot index -> xsd.Measure.int.typedLiteral index |> TypedLiteral
let souceName = "FoodData_Central_branded_food_json_2026-10-29.json"

type JsonLine with

    member this.triplify(sourceName: string) : seq<NormativeTriple> =

        seq {
            let iri (pointer: JsonPointer) =
                sourceName |> fdc._namespace.curie pointer

            let subject = iri this.pointer

            match this with
            | JsonObjectLine(pointer, _)
            | JsonArrayLine(pointer, _) when pointer = JsonPointer.Empty ->

                yield subject --/ a /-> fx.Root.Iri

            | JsonObjectLine(pointer, path)
            | JsonArrayLine(pointer, path) ->

                let parent = iri pointer.parent
                let predicate = path.FxSlot.Iri

                yield parent --/ predicate /-> subject

            | JsonStringLine _
            | JsonNumberLine _
            | JsonBooleanLine _
            | JsonNullLine _ ->

                let parent = iri this.pointer.parent
                let predicate = this.path.FxSlot.Iri
                let literal = Literal.autotyped this
                yield parent --/ predicate /-> literal

        }
let brandedFoodLines = branded_food.jsonl |> Seq.take 10 |> Seq.toArray
// TODO fix autotyped. maybe use type shapes?
// let foodTriples = foodCsv.triplfy (fun row -> row.GetColumn "fdc_id" |> fdc._namespace.curie)
let brandedFoodTriples =
    branded_food.jsonl
    |> Seq.take 10
    |> Seq.collect (fun jsonline -> jsonline.triplify "FoodData_Central_branded_food_json_2026-10-29.json")
let brandedFoodPrefixes = brandedFoodTriples |> Seq.collect Turtle.prefixID |> Seq.distinct

brandedFoodPrefixes |> String.Clipboard.clip
let sampleTriples =
    brandedFoodLines[0].triplify "FoodData_Central_branded_food_json_2026-10-29.json"
    |> Seq.toArray
match sampleTriples[0] with
| BGP(subject, P fxd.fdc_id, LO object') -> true
| _ -> false

sampleTriples |> Array.map Turtle.triple |> String.Clipboard.clip

// TODO add fuzzy mime search

// let vocabulary = RdfVocabulary.PREFIX("huto", @"http://ns.inria.fr/huto/")
// vocabulary.clipProvider
// (*
// *)
// let download = irlref "http://aims.fao.org/aos/agrontology#"
//
// download.localReference.clip
//
// Directory.CreateDirectory @"D:\http\fr\inria\ns\huto&sol;\text\"
//
// let loader = new VDS.RDF.Parsing.Loader()
// let conversionGraph = new VDS.RDF.ThreadSafeGraph()
//
// loader.LoadGraph(conversionGraph, Uri @"D:\http\xyz\sparql\facade-x\ns&sol;\text\owl-manchester.omn")
// conversionGraph.SaveToFile(@"D:\http\org\fao\aims\aos\agrontology&num;\text\turtle.ttl")
// valueflows.
// schemas

let foafDocumentTriples =
    [
        governmentjobs.ApplicationsSystemsAnalystI.Iri
        gov.leoncountyfl.cms.OfficeofInformationTechnology.Iri
        myfuelmaster.desktop_support_technician.Iri
        myfuelmaster.https.Iri
    ]
    -+/ a /-> foaf.Document

let foafDocumentAssertions =
    foaf.Document.Class
    |> ClassAssertion [
        governmentjobs.ApplicationsSystemsAnalystI.Individual
        gov.leoncountyfl.cms.OfficeofInformationTechnology.Individual
        myfuelmaster.desktop_support_technician.Individual
        myfuelmaster.https.Individual
    ]

let foafPersonTriples =
    [ commonplace.eristocrates.Iri; commonplace.syrislove.Iri ]
    -+/ a /-> foaf.Person

let foafPersonAssertions =
    foaf.Person.Class
    |> ClassAssertion [ commonplace.eristocrates.Individual; commonplace.syrislove.Individual ]

let eristocratesTriples =
    commonplace.eristocrates.Iri
    -// [
        foaf.firstName /-> myFirstName
        foaf.familyName /-> myLastName
        foaf.lastName /-> myLastName
        foaf.surname /-> myLastName
        foaf.age /-> myBirthday.currentAge
        foaf.nick /-> myUsername
        foaf.knows /-> commonplace.syrislove
    // foaf.workInfoHomepage/-> governmentjobs.ApplicationsSystemsAnalystI
    // foaf.workplaceHomepage/-> gov.leoncountyfl.cms.OfficeofInformationTechnology
    ]

let syrisTriples =
    commonplace.syrislove.Iri
    -// [

        foaf.firstName /-> syrisFirstName
        foaf.familyName /-> syrisLastName
        foaf.lastName /-> syrisLastName
        foaf.surname /-> syrisLastName
        foaf.age /-> syrisBirthday.currentAge
        foaf.nick /-> syrisUsername
        foaf.knows /-> commonplace.eristocrates
    // foaf.workInfoHomepage/->myfuelmaster.desktop_support_technician
    // foaf.workplaceHomepage/->myfuelmaster.https
    ]

let ontology =
    OntologyBuilder commonplace._namespace.namespaceIri {
        yield
            foaf.Person.Class
            |> ClassAssertion [ commonplace.eristocrates.Individual; commonplace.syrislove.Individual ]

        yield
            commonplace.eristocrates.Facts [
                foaf.firstName.Fact myFirstName
                foaf.familyName.Fact myLastName
                foaf.lastName.Fact myLastName
                foaf.surname.Fact myLastName
                foaf.age.Fact myBirthday.currentAge
                foaf.nick.Fact myUsername
            ]
        yield
            commonplace.eristocrates.Facts [
                foaf.knows.Fact commonplace.syrislove
                foaf.workInfoHomepage.Fact governmentjobs.ApplicationsSystemsAnalystI
                foaf.workplaceHomepage.Fact gov.leoncountyfl.cms.OfficeofInformationTechnology
            ]

        yield
            commonplace.syrislove.Facts [
                foaf.firstName.Fact syrisFirstName
                foaf.familyName.Fact syrisLastName
                foaf.lastName.Fact syrisLastName
                foaf.surname.Fact syrisLastName
                foaf.age.Fact syrisBirthday.currentAge
                foaf.nick.Fact syrisUsername
            ]
        yield
            commonplace.syrislove.Facts [
                foaf.knows.Fact commonplace.eristocrates
                foaf.workInfoHomepage.Fact myfuelmaster.desktop_support_technician
                foaf.workplaceHomepage.Fact myfuelmaster.https
            ]

    }

let OWLOntology = OWLSharp.Ontology.OWLOntology.ofOntology ontology
let rdfGraph = OWLOntology.ToRDFGraphAsync().Result
rdfGraph.ToTurtle @"C:\Secret\Me\Me.ttl"

// RDFSharp.Model.RDFGraph.ofNTriples ntriples
// let ntriples = NTriples.ntriplesDoc ontology
// File.WriteAllText("D:\https\com\github\eristocrates\ipa\scratch\scratch.owl", LitXml.ElementBuilder.writeToString (Owl.Xml.Ontology ontology))

// Attach to our existing Edge instance.
