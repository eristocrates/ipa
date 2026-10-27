#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#load @".paket/load/main.group.fsx"

open System
open System.Globalization
open System.Collections
open System.Xml
open System.Xml.Linq

open IriTools
open NLanguageTag

[<CustomEquality; CustomComparison>]
type Iri =
    | IRIREF of IriReference
    | PrefixedName of PrefixedName

    member this.identity =
        match this with
        | IRIREF iriref -> iriref.uri.OriginalString
        | PrefixedName prefixedName -> prefixedName.identity

    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"
and [<CustomEquality; CustomComparison>] PrefixedName = {
    vocabulary: RdfVocabulary
    localName: string
} with

    member this.namespaceName = this.vocabulary.namespaceIri.identity

    member this.identity = this.namespaceName + this.localName
    override this.Equals(other: obj) =
        match other with
        | :? PrefixedName as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? PrefixedName as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"
and RdfVocabulary = {
    namespacePrefix: string
    namespaceIri: Iri
    distributionIris: Iri list
    documentIris: Iri list
}
