namespace DoxAletheia

open System

open DoxAletheia
open ParserCombinator.Data
open ParserCombinator.ResourceIdentifier
open StringExtensions
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open GrammarErgonomics
open Interval_Range
open IntervalErgonomics
open Code_Point_Rule
open Code_Line_Rule
open XParsec
open FSharp.HashCollections






type Mime_Type =
    { registry: string
      name: string }

    member this.data_namespace_name = sprintf "data:%s;charset=UTF-8;" this.name

    member this.data_prefix local_name =
        Namespaced_IRI.parse this.data_namespace_name local_name
        |> NamespacedName


    member this.iana_iri =
        Namespaced_IRI.parse (sprintf "https://www.iana.org/assignments/media-types/%s/" this.registry) this.name
        |> NamespacedName

    member this.resource_iri =
        Namespaced_IRI.parse (sprintf "http://www.w3.org/ns/iana/media-types/%s/%s#" this.registry this.name) "Resource"
        |> NamespacedName

    member this.spar_iri =
        Namespaced_IRI.parse (sprintf "https://w3id.org/spar/mediatype/%s/%s#" this.registry this.name) "Resource"
        |> NamespacedName




type Iana_Status =
    | HistoricalStatus
    | PermanentStatus
    | ProvisionalStatus

type Iana_Scheme =
    { name: string
      description: string
      cri: int
      status: Iana_Status }
