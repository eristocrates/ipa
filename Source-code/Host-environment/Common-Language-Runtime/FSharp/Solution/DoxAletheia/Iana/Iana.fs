namespace DoxAletheia
open DoxAletheia

open System





open StringExtensions
open ArrayErgonomics
open GrammarErgonomics
open FSharp.HashCollections






type Mime_Type =
    { registry: string
      name: string }

    member this.data_namespace_name = sprintf "data:%s;charset=UTF-8;" this.name

    member this.data_prefix local_name = Prefixed_Name({namespace_name = this.data_namespace_name ; namespace_prefix = "mime" + this.name},local_name) |> PrefixedName
        
        


    member this.iana_iri = Prefixed_Name({namespace_name = sprintf "https://www.iana.org/assignments/media-types/%s/" this.registry ; namespace_prefix = "iana" + this.name},this.name) |> PrefixedName
        
        

    member this.resource_iri = Prefixed_Name({namespace_name = sprintf "http://www.w3.org/ns/iana/media-types/%s/%s#" this.registry this.name; namespace_prefix = "mime" + this.name},"Resource") |> PrefixedName
        
        

    member this.spar_iri = Prefixed_Name({namespace_name = sprintf "https://w3id.org/spar/mediatype/%s/%s#" this.registry this.name; namespace_prefix = "sparmime" + this.name},"Resource") |> PrefixedName





type Iana_Status =
    | HistoricalStatus
    | PermanentStatus
    | ProvisionalStatus

type Iana_Scheme =
    { name: string
      description: string
      cri: int
      status: Iana_Status }
