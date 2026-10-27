#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#load @".paket/load/main.group.fsx"

open System
open System.Collections
open System.Xml
open System.Xml.Linq

open IriTools
open NLanguageTag

// Units of Measure extensions
// Provides a mechanism for extending units of measure to non-numeric primitives
type XNamespace with
    static member xs = XNamespace.op_Implicit "http://www.w3.org/2001/XMLSchema"
    member this.qname(localName: string) =
        XmlQualifiedName(localName, this.NamespaceName)
    member this.xname(localName: string) = this + localName
type RdfConformance =
    | FullNormativeConformance
    | BasicNormativeConformance
    | NonNormativeNonConformance

[<MeasureAnnotatedAbbreviation>]
type string<[<Measure>] 'DatatypeMeasure> = string
module private Unsafe =
    let inline cast<'a, 'b> (a: 'a) : 'b =
#if !FABLE_COMPILER
        (# "" a : 'b #)
#else
        unbox<'b> a
#endif

type UMX =
    static member inline tag<[<Measure>] 'DatatypeMeasure>(x: string) : string<'DatatypeMeasure> = Unsafe.cast x
    static member inline untag<[<Measure>] 'DatatypeMeasure>(x: string<'DatatypeMeasure>) : string = Unsafe.cast x
    static member inline cast<[<Measure>] 'DatatypeMeasure1, [<Measure>] 'DatatypeMeasure2>(x: string<'DatatypeMeasure1>) : string<'DatatypeMeasure2> = Unsafe.cast x
[<AutoOpen>]
module Operators =
    let inline private _cast< ^TC, ^xm, ^xn when (^TC or ^xm or ^xn): (static member cast: ^xm -> ^xn)> (x: ^xm) =
        ((^TC or ^xm or ^xn): (static member cast: ^xm -> ^xn) x)
    // NB the particular infix operator shadows the rarely used quotation splicing operator
    /// Infix operator used for tagging, untagging, or casting units of measure
    let inline (~%) (x: string) : string<'DatatypeMeasure> =
        _cast<UMX, string, string<'DatatypeMeasure>> x

[<CustomEquality; CustomComparison>]
type Iri =
    | IRIREF of IriReference
    | PrefixedName of PrefixedName

    static member op_Implicit(iriReference: IriReference) = IRIREF iriReference
    static member op_Implicit(prefixedName: PrefixedName) = PrefixedName prefixedName
    static member op_Implicit(iri: Iri) = iri.identity
    static member op_Implicit(iriString: string) = IriReference iriString |> IRIREF
    static member toUri(iri: Iri) = Uri iri.identity
    member this.asUri = Iri.toUri this
    static member op_Implicit(iri: Iri) = iri.asUri
    static member ofUri(uri: Uri) = IriReference uri |> IRIREF
    static member op_Implicit(uri: Uri) = Iri.ofUri uri
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
} with

    member this.identity = this.namespaceIri.identity
    member this.prefixedName(localName: string) = {
        vocabulary = this
        localName = localName
    }
    member this.curie(localName: string) : Iri =
        this.prefixedName localName |> PrefixedName
    static member PREFIX((namespacePrefix: string), (namespaceIriString: string)) = {
        namespacePrefix = namespacePrefix
        namespaceIri = IriReference namespaceIriString |> IRIREF
        distributionIris = []
        documentIris = []
    }
    static member xsd = RdfVocabulary.PREFIX("xsd", "http://www.w3.org/2001/XMLSchema#")
    static member rdf = RdfVocabulary.PREFIX("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#")
    static member rdfs = RdfVocabulary.PREFIX("rdfs", "http://www.w3.org/2000/01/rdf-schema#")
    static member rdfa = RdfVocabulary.PREFIX("rdfa", "http://www.w3.org/ns/rdfa#")
    static member xhtml = RdfVocabulary.PREFIX("xhtml", "http://www.w3.org/1999/xhtml/datatypes/")
    static member owl = RdfVocabulary.PREFIX("owl", "http://www.w3.org/2002/07/owl#")
    static member xsi = RdfVocabulary.PREFIX("xsi", "http://www.w3.org/2001/XMLSchema-instance#")

type LanguageTag with
    member this.identity = this.ToString().ToLowerInvariant()
[<StructuralEquality; StructuralComparison>]
type LiteralIdentity = private {
    lexicalForm: string
    literalDatatype: DatatypeIri
    languageTag: string option
    baseDirection: InitialTextDirection option
}
and DatatypeIri =
    | DatatypeIri of Iri

    static member op_Implicit(iri: Iri) = DatatypeIri iri
    member this.Iri: Iri =
        match this with
        | DatatypeIri iri -> iri
    static member op_Implicit(datatypeIri: DatatypeIri) = datatypeIri.Iri
    member this.identity: string = this.Iri.identity
and FacetValue = {
    constrainingFacet: FacetIri
    restrictionValue: Literal
}

and FacetIri =
    | FacetIri of Iri

    static member op_Implicit(iri: Iri) = FacetIri iri
    member this.Iri: Iri =
        match this with
        | FacetIri iri -> iri
    static member op_Implicit(facetIri: FacetIri) = facetIri.Iri
    member this.identity: string = this.Iri.identity
and InitialTextDirection =
    | Ltr
    | Rtl

    static member tryParse(rawString: string) =
        match rawString.ToLowerInvariant() with
        | "ltr" -> Some Ltr
        | "rtl" -> Some Rtl
        | _ -> None

    member this.identity = this.ToString().ToLowerInvariant()
and Datatype<[<Measure>] 'Datatype> = private {
    _datatypeIri: DatatypeIri
} with

    member this.datatypeIri = this._datatypeIri

    member this.Iri = this._datatypeIri.Iri
    static member (^^)((lexicalForm: System.String), (datatype: Datatype<'Datatype>)) : StaticTypedLiteral<'Datatype> = {
        lexicalForm = UMX.tag lexicalForm
        datatype = datatype
    }

and StaticTypedLiteral<[<Measure>] 'Datatype> = {
    lexicalForm: string<'Datatype>
    datatype: Datatype<'Datatype>
} with

    static member toTypedLiteral(staticTypedLiteral: StaticTypedLiteral<'Datatype>) : TypedLiteral = {
        lexicalForm = UMX.untag staticTypedLiteral.lexicalForm

        datatypeIri = staticTypedLiteral.datatype._datatypeIri
    }

    static member op_Implicit(staticTypedLiteral: StaticTypedLiteral<'Datatype>) =
        StaticTypedLiteral.toTypedLiteral staticTypedLiteral
    static member toLiteral(staticTypedLiteral: StaticTypedLiteral<'Datatype>) =
        StaticTypedLiteral.toTypedLiteral staticTypedLiteral |> TypedLiteral
    static member op_Implicit(staticTypedLiteral: StaticTypedLiteral<'Datatype>) =
        StaticTypedLiteral.toLiteral staticTypedLiteral
    member this.identity: LiteralIdentity = (StaticTypedLiteral.toLiteral this).identity
and TypedLiteral = {
    lexicalForm: string
    datatypeIri: DatatypeIri
} with

    member this.identity: LiteralIdentity = {

        lexicalForm = this.lexicalForm

        literalDatatype = this.datatypeIri

        languageTag = None

        baseDirection = None
    }

and [<CustomEquality; CustomComparison>] Literal =
    | StringLiteral of StringLiteral
    | TypedLiteral of TypedLiteral
    | EmbeddedLiteral of EmbeddedLiteral

    static member (!>=)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "minInclusive" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!>)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "minExclusive" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!<=)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "maxInclusive" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!<)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "maxExclusive" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!@)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.rdf.curie "langRange" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!*)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "pattern" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!.<)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "maxLength" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!.=)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "length" |> FacetIri
        restrictionValue = restrictionValue
    }
    static member (!.>)(restrictionValue: Literal) = {
        constrainingFacet = RdfVocabulary.xsd.curie "minLength" |> FacetIri
        restrictionValue = restrictionValue
    }
    member this.identity: LiteralIdentity =
        match this with

        | StringLiteral(SimpleString simpleString) -> simpleString.identity

        | StringLiteral(LanguageString languageString) -> languageString.identity

        | TypedLiteral typedLiteral -> typedLiteral.identity

        | EmbeddedLiteral embeddedLiteral -> embeddedLiteral.identity
    override this.Equals(other: obj) =
        match other with
        | :? Literal as other -> this.identity = other.identity

        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Literal as other -> compare this.identity other.identity

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<Literal>.Name} with {other.GetType().Name}"
and StringLiteral =
    | SimpleString of SimpleString
    | LanguageString of LanguageString

    member this.identity =
        match this with
        | SimpleString stringLiteral -> stringLiteral.identity
        | LanguageString languageString -> languageString.identity
and SimpleString = {
    simpleString: string
} with

    member this.identity: LiteralIdentity = {
        lexicalForm = this.simpleString
        literalDatatype = RdfVocabulary.xsd.curie "string" |> DatatypeIri
        languageTag = None
        baseDirection = None
    }
and LanguageString = {
    lexicalForm: string
    languageTag: LanguageTag
    baseDirection: InitialTextDirection option
} with

    member this.identity: LiteralIdentity = {
        lexicalForm = this.lexicalForm
        literalDatatype =
            match this.baseDirection with
            | None -> RdfVocabulary.rdf.curie "langString" |> DatatypeIri
            | Some _ -> RdfVocabulary.rdf.curie "dirLangString" |> DatatypeIri
        languageTag = Some this.languageTag.identity
        baseDirection = this.baseDirection
    }
and EmbeddedLiteral =
    | EmbeddedHtml of HtmlLiteral
    | EmbeddedXml of XmlLiteral
    | EmbeddedJson of JsonLiteral

    member this.identity: LiteralIdentity =
        match this with
        | EmbeddedHtml htmlLiteral -> htmlLiteral.identity
        | EmbeddedXml xmlLiteral -> xmlLiteral.identity
        | EmbeddedJson jsonLiteral -> jsonLiteral.identity
and HtmlLiteral = {
    htmlString: string
} with

    member this.datatype = RdfVocabulary.rdf.curie "HTML" |> DatatypeIri
    member this.identity = {
        lexicalForm = this.htmlString
        literalDatatype = this.datatype
        languageTag = None
        baseDirection = None
    }

and XmlLiteral = {
    xmlString: string
} with

    member this.datatype = RdfVocabulary.rdf.curie "XMLLiteral" |> DatatypeIri
    member this.identity = {
        lexicalForm = this.xmlString
        literalDatatype = this.datatype
        languageTag = None
        baseDirection = None
    }

and JsonLiteral = {
    jsonString: string
} with

    member this.datatype = RdfVocabulary.rdf.curie "JSON" |> DatatypeIri
    member this.identity = {
        lexicalForm = this.jsonString
        literalDatatype = this.datatype
        languageTag = None
        baseDirection = None
    }

module xsd =
    let _namespace = RdfVocabulary.xsd
    module Measure =
        [<Measure>]
        type anyURI =
            static member literal(value: System.String) : string<anyURI> = UMX.tag value
            static member Datatype: Datatype<anyURI> = {
                _datatypeIri = _namespace.curie "anyURI" |> DatatypeIri
            }
        [<Measure>]
        type base64Binary =
            static member literal(value: System.String) : string<base64Binary> = UMX.tag value
            static member Datatype: Datatype<base64Binary> = {
                _datatypeIri = _namespace.curie "base64Binary" |> DatatypeIri
            }
        [<Measure>]
        type boolean =
            static member literal(value: System.String) : string<boolean> = UMX.tag value
            static member Datatype: Datatype<boolean> = {
                _datatypeIri = _namespace.curie "boolean" |> DatatypeIri
            }
        [<Measure>]
        type date =
            static member literal(value: System.String) : string<date> = UMX.tag value
            static member Datatype: Datatype<date> = {
                _datatypeIri = _namespace.curie "date" |> DatatypeIri
            }
        [<Measure>]
        type dateTime =
            static member literal(value: System.String) : string<dateTime> = UMX.tag value
            static member Datatype: Datatype<dateTime> = {
                _datatypeIri = _namespace.curie "dateTime" |> DatatypeIri
            }
        [<Measure>]
        type dateTimeStamp =
            static member literal(value: System.String) : string<dateTimeStamp> = UMX.tag value
            static member Datatype: Datatype<dateTimeStamp> = {
                _datatypeIri = _namespace.curie "dateTimeStamp" |> DatatypeIri
            }
        [<Measure>]
        type decimal =
            static member literal(value: System.String) : string<decimal> = UMX.tag value
            static member Datatype: Datatype<decimal> = {
                _datatypeIri = _namespace.curie "decimal" |> DatatypeIri
            }
        [<Measure>]
        type integer =
            static member literal(value: System.String) : string<integer> = UMX.tag value
            static member Datatype: Datatype<integer> = {
                _datatypeIri = _namespace.curie "integer" |> DatatypeIri
            }
        [<Measure>]
        type long =
            static member literal(value: System.String) : string<long> = UMX.tag value
            static member Datatype: Datatype<long> = {
                _datatypeIri = _namespace.curie "long" |> DatatypeIri
            }
        [<Measure>]
        type int =
            static member literal(value: System.String) : string<int> = UMX.tag value
            static member Datatype: Datatype<int> = {
                _datatypeIri = _namespace.curie "int" |> DatatypeIri
            }
        [<Measure>]
        type short =
            static member literal(value: System.String) : string<short> = UMX.tag value
            static member Datatype: Datatype<short> = {
                _datatypeIri = _namespace.curie "short" |> DatatypeIri
            }
        [<Measure>]
        type byte =
            static member literal(value: System.String) : string<byte> = UMX.tag value
            static member Datatype: Datatype<byte> = {
                _datatypeIri = _namespace.curie "byte" |> DatatypeIri
            }
        [<Measure>]
        type nonNegativeInteger =
            static member literal(value: System.String) : string<nonNegativeInteger> = UMX.tag value
            static member Datatype: Datatype<nonNegativeInteger> = {
                _datatypeIri = _namespace.curie "nonNegativeInteger" |> DatatypeIri
            }
        [<Measure>]
        type positiveInteger =
            static member literal(value: System.String) : string<positiveInteger> = UMX.tag value
            static member Datatype: Datatype<positiveInteger> = {
                _datatypeIri = _namespace.curie "positiveInteger" |> DatatypeIri
            }
        [<Measure>]
        type unsignedLong =
            static member literal(value: System.String) : string<unsignedLong> = UMX.tag value
            static member Datatype: Datatype<unsignedLong> = {
                _datatypeIri = _namespace.curie "unsignedLong" |> DatatypeIri
            }
        [<Measure>]
        type unsignedInt =
            static member literal(value: System.String) : string<unsignedInt> = UMX.tag value
            static member Datatype: Datatype<unsignedInt> = {
                _datatypeIri = _namespace.curie "unsignedInt" |> DatatypeIri
            }
        [<Measure>]
        type unsignedShort =
            static member literal(value: System.String) : string<unsignedShort> = UMX.tag value
            static member Datatype: Datatype<unsignedShort> = {
                _datatypeIri = _namespace.curie "unsignedShort" |> DatatypeIri
            }
        [<Measure>]
        type unsignedByte =
            static member literal(value: System.String) : string<unsignedByte> = UMX.tag value
            static member Datatype: Datatype<unsignedByte> = {
                _datatypeIri = _namespace.curie "unsignedByte" |> DatatypeIri
            }
        [<Measure>]
        type nonPositiveInteger =
            static member literal(value: System.String) : string<nonPositiveInteger> = UMX.tag value
            static member Datatype: Datatype<nonPositiveInteger> = {
                _datatypeIri = _namespace.curie "nonPositiveInteger" |> DatatypeIri
            }
        [<Measure>]
        type negativeInteger =
            static member literal(value: System.String) : string<negativeInteger> = UMX.tag value
            static member Datatype: Datatype<negativeInteger> = {
                _datatypeIri = _namespace.curie "negativeInteger" |> DatatypeIri
            }
        [<Measure>]
        type double =
            static member literal(value: System.String) : string<double> = UMX.tag value
            static member Datatype: Datatype<double> = {
                _datatypeIri = _namespace.curie "double" |> DatatypeIri
            }
        [<Measure>]
        type duration =
            static member literal(value: System.String) : string<duration> = UMX.tag value
            static member Datatype: Datatype<duration> = {
                _datatypeIri = _namespace.curie "duration" |> DatatypeIri
            }
        [<Measure>]
        type dayTimeDuration =
            static member literal(value: System.String) : string<dayTimeDuration> = UMX.tag value
            static member Datatype: Datatype<dayTimeDuration> = {
                _datatypeIri = _namespace.curie "dayTimeDuration" |> DatatypeIri
            }
        [<Measure>]
        type yearMonthDuration =
            static member literal(value: System.String) : string<yearMonthDuration> = UMX.tag value
            static member Datatype: Datatype<yearMonthDuration> = {
                _datatypeIri = _namespace.curie "yearMonthDuration" |> DatatypeIri
            }
        [<Measure>]
        type float =
            static member literal(value: System.String) : string<float> = UMX.tag value
            static member Datatype: Datatype<float> = {
                _datatypeIri = _namespace.curie "float" |> DatatypeIri
            }
        [<Measure>]
        type gDay =
            static member literal(value: System.String) : string<gDay> = UMX.tag value
            static member Datatype: Datatype<gDay> = {
                _datatypeIri = _namespace.curie "gDay" |> DatatypeIri
            }
        [<Measure>]
        type gMonth =
            static member literal(value: System.String) : string<gMonth> = UMX.tag value
            static member Datatype: Datatype<gMonth> = {
                _datatypeIri = _namespace.curie "gMonth" |> DatatypeIri
            }
        [<Measure>]
        type gMonthDay =
            static member literal(value: System.String) : string<gMonthDay> = UMX.tag value
            static member Datatype: Datatype<gMonthDay> = {
                _datatypeIri = _namespace.curie "gMonthDay" |> DatatypeIri
            }
        [<Measure>]
        type gYear =
            static member literal(value: System.String) : string<gYear> = UMX.tag value
            static member Datatype: Datatype<gYear> = {
                _datatypeIri = _namespace.curie "gYear" |> DatatypeIri
            }
        [<Measure>]
        type gYearMonth =
            static member literal(value: System.String) : string<gYearMonth> = UMX.tag value
            static member Datatype: Datatype<gYearMonth> = {
                _datatypeIri = _namespace.curie "gYearMonth" |> DatatypeIri
            }
        [<Measure>]
        type hexBinary =
            static member literal(value: System.String) : string<hexBinary> = UMX.tag value
            static member Datatype: Datatype<hexBinary> = {
                _datatypeIri = _namespace.curie "hexBinary" |> DatatypeIri
            }
        [<Measure>]
        type string =
            static member literal(value: System.String) : string<string> = UMX.tag value
            static member Datatype: Datatype<string> = {
                _datatypeIri = _namespace.curie "string" |> DatatypeIri
            }
        [<Measure>]
        type normalizedString =
            static member literal(value: System.String) : string<normalizedString> = UMX.tag value
            static member Datatype: Datatype<normalizedString> = {
                _datatypeIri = _namespace.curie "normalizedString" |> DatatypeIri
            }
        [<Measure>]
        type token =
            static member literal(value: System.String) : string<token> = UMX.tag value
            static member Datatype: Datatype<token> = {
                _datatypeIri = _namespace.curie "token" |> DatatypeIri
            }
        [<Measure>]
        type language =
            static member literal(value: System.String) : string<language> = UMX.tag value
            static member Datatype: Datatype<language> = {
                _datatypeIri = _namespace.curie "language" |> DatatypeIri
            }
        [<Measure>]
        type Name =
            static member literal(value: System.String) : string<Name> = UMX.tag value
            static member Datatype: Datatype<Name> = {
                _datatypeIri = _namespace.curie "Name" |> DatatypeIri
            }
        [<Measure>]
        type NCName =
            static member literal(value: System.String) : string<NCName> = UMX.tag value
            static member Datatype: Datatype<NCName> = {
                _datatypeIri = _namespace.curie "NCName" |> DatatypeIri
            }
        [<Measure>]
        type NMTOKEN =
            static member literal(value: System.String) : string<NMTOKEN> = UMX.tag value
            static member Datatype: Datatype<NMTOKEN> = {
                _datatypeIri = _namespace.curie "NMTOKEN" |> DatatypeIri
            }
        [<Measure>]
        type time =
            static member literal(value: System.String) : string<time> = UMX.tag value
            static member Datatype: Datatype<time> = {
                _datatypeIri = _namespace.curie "time" |> DatatypeIri
            }
    let anyURI: Datatype<Measure.anyURI> = Measure.anyURI.Datatype
    let base64Binary: Datatype<Measure.base64Binary> = Measure.base64Binary.Datatype
    let boolean: Datatype<Measure.boolean> = Measure.boolean.Datatype
    let date: Datatype<Measure.date> = Measure.date.Datatype
    let dateTime: Datatype<Measure.dateTime> = Measure.dateTime.Datatype
    let dateTimeStamp: Datatype<Measure.dateTimeStamp> = Measure.dateTimeStamp.Datatype
    let decimal: Datatype<Measure.decimal> = Measure.decimal.Datatype
    let integer: Datatype<Measure.integer> = Measure.integer.Datatype
    let long: Datatype<Measure.long> = Measure.long.Datatype
    let int: Datatype<Measure.int> = Measure.int.Datatype
    let short: Datatype<Measure.short> = Measure.short.Datatype
    let byte: Datatype<Measure.byte> = Measure.byte.Datatype
    let nonNegativeInteger: Datatype<Measure.nonNegativeInteger> = Measure.nonNegativeInteger.Datatype
    let positiveInteger: Datatype<Measure.positiveInteger> = Measure.positiveInteger.Datatype
    let unsignedLong: Datatype<Measure.unsignedLong> = Measure.unsignedLong.Datatype
    let unsignedInt: Datatype<Measure.unsignedInt> = Measure.unsignedInt.Datatype
    let unsignedShort: Datatype<Measure.unsignedShort> = Measure.unsignedShort.Datatype
    let unsignedByte: Datatype<Measure.unsignedByte> = Measure.unsignedByte.Datatype
    let nonPositiveInteger: Datatype<Measure.nonPositiveInteger> = Measure.nonPositiveInteger.Datatype
    let negativeInteger: Datatype<Measure.negativeInteger> = Measure.negativeInteger.Datatype
    let double: Datatype<Measure.double> = Measure.double.Datatype
    let duration: Datatype<Measure.duration> = Measure.duration.Datatype
    let dayTimeDuration: Datatype<Measure.dayTimeDuration> = Measure.dayTimeDuration.Datatype
    let yearMonthDuration: Datatype<Measure.yearMonthDuration> = Measure.yearMonthDuration.Datatype
    let float: Datatype<Measure.float> = Measure.float.Datatype
    let gDay: Datatype<Measure.gDay> = Measure.gDay.Datatype
    let gMonth: Datatype<Measure.gMonth> = Measure.gMonth.Datatype
    let gMonthDay: Datatype<Measure.gMonthDay> = Measure.gMonthDay.Datatype
    let gYear: Datatype<Measure.gYear> = Measure.gYear.Datatype
    let gYearMonth: Datatype<Measure.gYearMonth> = Measure.gYearMonth.Datatype
    let hexBinary: Datatype<Measure.hexBinary> = Measure.hexBinary.Datatype
    let string: Datatype<Measure.string> = Measure.string.Datatype
    let normalizedString: Datatype<Measure.normalizedString> = Measure.normalizedString.Datatype
    let token: Datatype<Measure.token> = Measure.token.Datatype
    let language: Datatype<Measure.language> = Measure.language.Datatype
    let Name: Datatype<Measure.Name> = Measure.Name.Datatype
    let NCName: Datatype<Measure.NCName> = Measure.NCName.Datatype
    let NMTOKEN: Datatype<Measure.NMTOKEN> = Measure.NMTOKEN.Datatype
    let time: Datatype<Measure.time> = Measure.time.Datatype
    let enumeration = _namespace.curie "enumeration" |> FacetIri
    let fractionDigits = _namespace.curie "fractionDigits" |> FacetIri
    let length = _namespace.curie "length" |> FacetIri
    let maxExclusive = _namespace.curie "maxExclusive" |> FacetIri
    let maxInclusive = _namespace.curie "maxInclusive" |> FacetIri
    let maxLength = _namespace.curie "maxLength" |> FacetIri
    let minExclusive = _namespace.curie "minExclusive" |> FacetIri
    let minInclusive = _namespace.curie "minInclusive" |> FacetIri
    let minLength = _namespace.curie "minLength" |> FacetIri
    let pattern = _namespace.curie "pattern" |> FacetIri
    let totalDigits = _namespace.curie "totalDigits" |> FacetIri
    let whiteSpace = _namespace.curie "whiteSpace" |> FacetIri
    // https://www.w3.org/TR/rdf12-concepts/#xsd-datatypes
    let QName = _namespace.curie "QName"
    let ENTITY = _namespace.curie "ENTITY"
    let ID = _namespace.curie "ID"
    let IDREF = _namespace.curie "IDREF"
    let NOTATION = _namespace.curie "NOTATION"
    let IDREFS = _namespace.curie "IDREFS"
    let ENTITIES = _namespace.curie "ENTITIES"
    let NMTOKENS = _namespace.curie "NMTOKENS"
    let anyType = _namespace.curie "anyType"
    let anySimpleType = _namespace.curie "anySimpleType"
    let anyAtomicType = _namespace.curie "anyAtomicType"
    let element = _namespace.curie "element"
    let attribute = _namespace.curie "attribute"
    let notation = _namespace.curie "notation"
    let schema = _namespace.curie "schema"
    let group = _namespace.curie "group"
    let simpleType = _namespace.curie "simpleType"
    let attributeGroup = _namespace.curie "attributeGroup"
    let anyAttribute = _namespace.curie "anyAttribute"
    let assert_ = _namespace.curie "assert"
    let complexContent = _namespace.curie "complexContent"
    let restriction = _namespace.curie "restriction"
    let extension = _namespace.curie "extension"
    let openContent = _namespace.curie "openContent"
    let any = _namespace.curie "any"
    let defaultOpenContent = _namespace.curie "defaultOpenContent"
    let simpleContent = _namespace.curie "simpleContent"
    let complexType = _namespace.curie "complexType"
    let alternative = _namespace.curie "alternative"
    let all = _namespace.curie "all"
    let choice = _namespace.curie "choice"
    let sequence = _namespace.curie "sequence"
    let include_ = _namespace.curie "include"
    let redefine = _namespace.curie "redefine"
    let override_ = _namespace.curie "override"
    let import = _namespace.curie "import"
    let selector = _namespace.curie "selector"
    let field = _namespace.curie "field"
    let unique = _namespace.curie "unique"
    let key = _namespace.curie "key"
    let keyref = _namespace.curie "keyref"
    let appinfo = _namespace.curie "appinfo"
    let documentation = _namespace.curie "documentation"
    let annotation = _namespace.curie "annotation"
    let facet = _namespace.curie "facet"
    let list = _namespace.curie "list"
    let union = _namespace.curie "union"
    let assertion = _namespace.curie "assertion"
    let explicitTimezone = _namespace.curie "explicitTimezone"

module rdf =
    let _namespace = RdfVocabulary.rdf
    module Measure =
        /// https://www.w3.org/TR/rdf-plain-literal-1/
        [<Measure>]
        type langString =
            static member literal(value: string) : string<langString> = UMX.tag value
            /// https://www.w3.org/TR/rdf-plain-literal-1/
            static member Datatype: Datatype<langString> = {
                _datatypeIri = _namespace.curie "langString" |> DatatypeIri
            }
        [<Measure>]
        type dirLangString =
            static member literal(value: string) : string<dirLangString> = UMX.tag value
            /// https://www.w3.org/TR/rdf-plain-literal-1/
            static member Datatype: Datatype<dirLangString> = {
                _datatypeIri = _namespace.curie "dirLangString" |> DatatypeIri
            }
        [<Measure>]
        type PlainLiteral =
            static member literal(value: string) : string<PlainLiteral> = UMX.tag value
            /// https://www.w3.org/TR/rdf-plain-literal-1/
            static member Datatype: Datatype<PlainLiteral> = {
                _datatypeIri = _namespace.curie "PlainLiteral" |> DatatypeIri
            }
        [<Measure>]
        type HTML =
            static member literal(value: string) : string<HTML> = UMX.tag value
            static member Datatype: Datatype<HTML> = {
                _datatypeIri = _namespace.curie "HTML" |> DatatypeIri
            }
        [<Measure>]
        type JSON =
            static member literal(value: string) : string<JSON> = UMX.tag value
            static member Datatype: Datatype<JSON> = {
                _datatypeIri = _namespace.curie "JSON" |> DatatypeIri
            }
        [<Measure>]
        type XMLLiteral =
            static member literal(value: string) : string<XMLLiteral> = UMX.tag value
            static member Datatype: Datatype<XMLLiteral> = {
                _datatypeIri = _namespace.curie "XMLLiteral" |> DatatypeIri
            }
    let langString = Measure.langString.Datatype
    let dirLangString = Measure.dirLangString.Datatype
    let PlainLiteral = Measure.PlainLiteral.Datatype
    let XMLLiteral = Measure.XMLLiteral.Datatype
    let HTML = Measure.HTML.Datatype
    let JSON = Measure.JSON.Datatype
    let Alt = _namespace.curie "Alt"
    let Bag = _namespace.curie "Bag"
    let CompoundLiteral = _namespace.curie "CompoundLiteral"
    let direction = _namespace.curie "direction"
    let first = _namespace.curie "first"
    let language = _namespace.curie "language"
    let List = _namespace.curie "List"
    let nil = _namespace.curie "nil"
    let object = _namespace.curie "object"
    /// https://www.w3.org/TR/rdf-plain-literal-1/
    let predicate = _namespace.curie "predicate"
    let Property = _namespace.curie "Property"
    let rest = _namespace.curie "rest"
    let Seq = _namespace.curie "Seq"
    let Statement = _namespace.curie "Statement"
    let subject = _namespace.curie "subject"
    let type_ = _namespace.curie "type"
    let value = _namespace.curie "value"
    let langRange = _namespace.curie "langRange" |> FacetIri
    // https://w3c.github.io/rdf-interop/spec/#section-basicenc-definition
    let PropositionForm = _namespace.curie "PropositionForm"
    let propositionFormSubject = _namespace.curie "propositionFormSubject"
    let propositionFormPredicate = _namespace.curie "propositionFormPredicate"
    let propositionFormObject = _namespace.curie "propositionFormObject"
    // https://www.w3.org/TR/rdf12-xml/#coreSyntaxTerms
    let RDF = _namespace.curie "RDF"
    let ID = _namespace.curie "ID"
    let about = _namespace.curie "about"
    let parseType = _namespace.curie "parseType"
    let resource = _namespace.curie "resource"
    let nodeID = _namespace.curie "nodeID"
    let datatype = _namespace.curie "datatype"
    let Description = _namespace.curie "Description"
    // TODO consider conversion to rdf_\d index behavior
    let li = _namespace.curie "li"

// https://www.w3.org/TR/rdf12-xml/#section-Bag-Expand
// let aboutEach = _namespace.curie "aboutEach"
// let aboutEachPrefix = _namespace.curie "aboutEachPrefix"
// let bagID = _namespace.curie "bagID"
module rdfs =
    let _namespace = RdfVocabulary.rdfs
    module Measure =
        [<Measure>]
        type Literal =
            static member literal(value: string) : string<Literal> = UMX.tag value
            static member Datatype: Datatype<Literal> = {
                _datatypeIri = _namespace.curie "Literal" |> DatatypeIri
            }
    let Literal = Measure.Literal.Datatype

    let Class = _namespace.curie "Class"
    let comment = _namespace.curie "comment"
    let Container = _namespace.curie "Container"
    let ContainerMembershipProperty = _namespace.curie "ContainerMembershipProperty"
    let Datatype = _namespace.curie "Datatype"
    let domain = _namespace.curie "domain"
    let isDefinedBy = _namespace.curie "isDefinedBy"
    let label = _namespace.curie "label"
    let member_ = _namespace.curie "member"
    let range = _namespace.curie "range"
    let Resource = _namespace.curie "Resource"
    let seeAlso = _namespace.curie "seeAlso"
    let subClassOf = _namespace.curie "subClassOf"
    let subPropertyOf = _namespace.curie "subPropertyOf"
module xhtml =
    let _namespace = RdfVocabulary.xhtml
    module Measure =
        [<Measure>]
        type Length =
            static member literal(value: string) : string<Length> = UMX.tag value
            static member Datatype: Datatype<Length> = {
                _datatypeIri = _namespace.curie "Length" |> DatatypeIri
            }
        [<Measure>]
        type LinkTypes =
            static member literal(value: string) : string<LinkTypes> = UMX.tag value
            static member Datatype: Datatype<LinkTypes> = {
                _datatypeIri = _namespace.curie "LinkTypes" |> DatatypeIri
            }
        [<Measure>]
        type MediaDesc =
            static member literal(value: string) : string<MediaDesc> = UMX.tag value
            static member Datatype: Datatype<MediaDesc> = {
                _datatypeIri = _namespace.curie "MediaDesc" |> DatatypeIri
            }
        [<Measure>]
        type MultiLength =
            static member literal(value: string) : string<MultiLength> = UMX.tag value
            static member Datatype: Datatype<MultiLength> = {
                _datatypeIri = _namespace.curie "MultiLength" |> DatatypeIri
            }
        [<Measure>]
        type Number =
            static member literal(value: string) : string<Number> = UMX.tag value
            static member Datatype: Datatype<Number> = {
                _datatypeIri = _namespace.curie "Number" |> DatatypeIri
            }
        [<Measure>]
        type Pixels =
            static member literal(value: string) : string<Pixels> = UMX.tag value
            static member Datatype: Datatype<Pixels> = {
                _datatypeIri = _namespace.curie "Pixels" |> DatatypeIri
            }
        [<Measure>]
        type Script =
            static member literal(value: string) : string<Script> = UMX.tag value
            static member Datatype: Datatype<Script> = {
                _datatypeIri = _namespace.curie "Script" |> DatatypeIri
            }
        [<Measure>]
        type Color =
            static member literal(value: string) : string<Color> = UMX.tag value
            static member Datatype: Datatype<Color> = {
                _datatypeIri = _namespace.curie "Color" |> DatatypeIri
            }
        [<Measure>]
        type Text =
            static member literal(value: string) : string<Text> = UMX.tag value
            static member Datatype: Datatype<Text> = {
                _datatypeIri = _namespace.curie "Text" |> DatatypeIri
            }
        [<Measure>]
        type Character =
            static member literal(value: string) : string<Character> = UMX.tag value
            static member Datatype: Datatype<Character> = {
                _datatypeIri = _namespace.curie "Character" |> DatatypeIri
            }
        [<Measure>]
        type Charset =
            static member literal(value: string) : string<Charset> = UMX.tag value
            static member Datatype: Datatype<Charset> = {
                _datatypeIri = _namespace.curie "Charset" |> DatatypeIri
            }
        [<Measure>]
        type Charsets =
            static member literal(value: string) : string<Charsets> = UMX.tag value
            static member Datatype: Datatype<Charsets> = {
                _datatypeIri = _namespace.curie "Charsets" |> DatatypeIri
            }
        [<Measure>]
        type ContentType =
            static member literal(value: string) : string<ContentType> = UMX.tag value
            static member Datatype: Datatype<ContentType> = {
                _datatypeIri = _namespace.curie "ContentType" |> DatatypeIri
            }
        [<Measure>]
        type ContentTypes =
            static member literal(value: string) : string<ContentTypes> = UMX.tag value
            static member Datatype: Datatype<ContentTypes> = {
                _datatypeIri = _namespace.curie "ContentTypes" |> DatatypeIri
            }
        [<Measure>]
        type Datetime =
            static member literal(value: string) : string<Datetime> = UMX.tag value
            static member Datatype: Datatype<Datetime> = {
                _datatypeIri = _namespace.curie "Datetime" |> DatatypeIri
            }
        [<Measure>]
        type FPI =
            static member literal(value: string) : string<FPI> = UMX.tag value
            static member Datatype: Datatype<FPI> = {
                _datatypeIri = _namespace.curie "FPI" |> DatatypeIri
            }
        [<Measure>]
        type FrameTarget =
            static member literal(value: string) : string<FrameTarget> = UMX.tag value
            static member Datatype: Datatype<FrameTarget> = {
                _datatypeIri = _namespace.curie "FrameTarget" |> DatatypeIri
            }
        [<Measure>]
        type LanguageCode =
            static member literal(value: string) : string<LanguageCode> = UMX.tag value
            static member Datatype: Datatype<LanguageCode> = {
                _datatypeIri = _namespace.curie "LanguageCode" |> DatatypeIri
            }
        [<Measure>]
        type LanguageCodes =
            static member literal(value: string) : string<LanguageCodes> = UMX.tag value
            static member Datatype: Datatype<LanguageCodes> = {
                _datatypeIri = _namespace.curie "LanguageCodes" |> DatatypeIri
            }
        [<Measure>]
        type URI =
            static member literal(value: string) : string<URI> = UMX.tag value
            static member Datatype: Datatype<URI> = {
                _datatypeIri = _namespace.curie "URI" |> DatatypeIri
            }
        [<Measure>]
        type URIs =
            static member literal(value: string) : string<URIs> = UMX.tag value
            static member Datatype: Datatype<URIs> = {
                _datatypeIri = _namespace.curie "URIs" |> DatatypeIri
            }
        [<Measure>]
        type URIREF =
            static member literal(value: string) : string<URIREF> = UMX.tag value
            static member Datatype: Datatype<URIREF> = {
                _datatypeIri = _namespace.curie "URIREF" |> DatatypeIri
            }
        [<Measure>]
        type MultiLengths =
            static member literal(value: string) : string<MultiLengths> = UMX.tag value
            static member Datatype: Datatype<MultiLengths> = {
                _datatypeIri = _namespace.curie "MultiLengths" |> DatatypeIri
            }
        [<Measure>]
        type CDATA =
            static member literal(value: string) : string<CDATA> = UMX.tag value
            static member Datatype: Datatype<CDATA> = {
                _datatypeIri = _namespace.curie "CDATA" |> DatatypeIri
            }
        [<Measure>]
        type CURIE =
            static member literal(value: string) : string<CURIE> = UMX.tag value
            static member Datatype: Datatype<CURIE> = {
                _datatypeIri = _namespace.curie "CURIE" |> DatatypeIri
            }
        [<Measure>]
        type CURIEs =
            static member literal(value: string) : string<CURIEs> = UMX.tag value
            static member Datatype: Datatype<CURIEs> = {
                _datatypeIri = _namespace.curie "CURIEs" |> DatatypeIri
            }
        [<Measure>]
        type SafeCURIE =
            static member literal(value: string) : string<SafeCURIE> = UMX.tag value
            static member Datatype: Datatype<SafeCURIE> = {
                _datatypeIri = _namespace.curie "SafeCURIE" |> DatatypeIri
            }
        [<Measure>]
        type SafeCURIEs =
            static member literal(value: string) : string<SafeCURIEs> = UMX.tag value
            static member Datatype: Datatype<SafeCURIEs> = {
                _datatypeIri = _namespace.curie "SafeCURIEs" |> DatatypeIri
            }
        [<Measure>]
        type URIorSafeCURIE =
            static member literal(value: string) : string<URIorSafeCURIE> = UMX.tag value
            static member Datatype: Datatype<URIorSafeCURIE> = {
                _datatypeIri = _namespace.curie "URIorSafeCURIE" |> DatatypeIri
            }
        [<Measure>]
        type URIorSafeCURIEs =
            static member literal(value: string) : string<URIorSafeCURIEs> = UMX.tag value
            static member Datatype: Datatype<URIorSafeCURIEs> = {
                _datatypeIri = _namespace.curie "URIorSafeCURIEs" |> DatatypeIri
            }
        [<Measure>]
        type PREFIX =
            static member literal(value: string) : string<PREFIX> = UMX.tag value
            static member Datatype: Datatype<PREFIX> = {
                _datatypeIri = _namespace.curie "PREFIX" |> DatatypeIri
            }
        [<Measure>]
        type PREFIXes =
            static member literal(value: string) : string<PREFIXes> = UMX.tag value
            static member Datatype: Datatype<PREFIXes> = {
                _datatypeIri = _namespace.curie "PREFIXes" |> DatatypeIri
            }
        [<Measure>]
        type TERM =
            static member literal(value: string) : string<TERM> = UMX.tag value
            static member Datatype: Datatype<TERM> = {
                _datatypeIri = _namespace.curie "TERM" |> DatatypeIri
            }
        [<Measure>]
        type CURIEorIRI =
            static member literal(value: string) : string<CURIEorIRI> = UMX.tag value
            static member Datatype: Datatype<CURIEorIRI> = {
                _datatypeIri = _namespace.curie "CURIEorIRI" |> DatatypeIri
            }
        [<Measure>]
        type CURIEorIRIs =
            static member literal(value: string) : string<CURIEorIRIs> = UMX.tag value
            static member Datatype: Datatype<CURIEorIRIs> = {
                _datatypeIri = _namespace.curie "CURIEorIRIs" |> DatatypeIri
            }
        [<Measure>]
        type SafeCURIEorCURIEorIRI =
            static member literal(value: string) : string<SafeCURIEorCURIEorIRI> = UMX.tag value
            static member Datatype: Datatype<SafeCURIEorCURIEorIRI> = {
                _datatypeIri = _namespace.curie "SafeCURIEorCURIEorIRI" |> DatatypeIri
            }
        [<Measure>]
        type SafeCURIEorCURIEorIRIs =
            static member literal(value: string) : string<SafeCURIEorCURIEorIRIs> = UMX.tag value
            static member Datatype: Datatype<SafeCURIEorCURIEorIRIs> = {
                _datatypeIri = _namespace.curie "SafeCURIEorCURIEorIRIs" |> DatatypeIri
            }
        [<Measure>]
        type AbsIRI =
            static member literal(value: string) : string<AbsIRI> = UMX.tag value
            static member Datatype: Datatype<AbsIRI> = {
                _datatypeIri = _namespace.curie "AbsIRI" |> DatatypeIri
            }
        [<Measure>]
        type TERMorCURIEorAbsIRI =
            static member literal(value: string) : string<TERMorCURIEorAbsIRI> = UMX.tag value
            static member Datatype: Datatype<TERMorCURIEorAbsIRI> = {
                _datatypeIri = _namespace.curie "TERMorCURIEorAbsIRI" |> DatatypeIri
            }
        [<Measure>]
        type TERMorCURIEorAbsIRIs =
            static member literal(value: string) : string<TERMorCURIEorAbsIRIs> = UMX.tag value
            static member Datatype: Datatype<TERMorCURIEorAbsIRIs> = {
                _datatypeIri = _namespace.curie "TERMorCURIEorAbsIRIs" |> DatatypeIri
            }
    let Length = Measure.Length.Datatype
    let LinkTypes = Measure.LinkTypes.Datatype
    let MediaDesc = Measure.MediaDesc.Datatype
    let MultiLength = Measure.MultiLength.Datatype
    let Number = Measure.Number.Datatype
    let Pixels = Measure.Pixels.Datatype
    let Script = Measure.Script.Datatype
    let Color = Measure.Color.Datatype
    let Text = Measure.Text.Datatype
    let Character = Measure.Character.Datatype
    let Charset = Measure.Charset.Datatype
    let Charsets = Measure.Charsets.Datatype
    let ContentType = Measure.ContentType.Datatype
    let ContentTypes = Measure.ContentTypes.Datatype
    let Datetime = Measure.Datetime.Datatype
    let FPI = Measure.FPI.Datatype
    let FrameTarget = Measure.FrameTarget.Datatype
    let LanguageCode = Measure.LanguageCode.Datatype
    let LanguageCodes = Measure.LanguageCodes.Datatype
    let URI = Measure.URI.Datatype
    let URIs = Measure.URIs.Datatype
    let URIREF = Measure.URIREF.Datatype
    let MultiLengths = Measure.MultiLengths.Datatype
    let CDATA = Measure.CDATA.Datatype
    let CURIE = Measure.CURIE.Datatype
    let CURIEs = Measure.CURIEs.Datatype
    let SafeCURIE = Measure.SafeCURIE.Datatype
    let SafeCURIEs = Measure.SafeCURIEs.Datatype
    let URIorSafeCURIE = Measure.URIorSafeCURIE.Datatype
    let URIorSafeCURIEs = Measure.URIorSafeCURIEs.Datatype
    let PREFIX = Measure.PREFIX.Datatype
    let PREFIXes = Measure.PREFIXes.Datatype
    let TERM = Measure.TERM.Datatype
    let CURIEorIRI = Measure.CURIEorIRI.Datatype
    let CURIEorIRIs = Measure.CURIEorIRIs.Datatype
    let SafeCURIEorCURIEorIRI = Measure.SafeCURIEorCURIEorIRI.Datatype
    let SafeCURIEorCURIEorIRIs = Measure.SafeCURIEorCURIEorIRIs.Datatype
    let AbsIRI = Measure.AbsIRI.Datatype
    let TERMorCURIEorAbsIRI = Measure.TERMorCURIEorAbsIRI.Datatype
    let TERMorCURIEorAbsIRIs = Measure.TERMorCURIEorAbsIRIs.Datatype

module rdfa =
    let _namespace = RdfVocabulary.rdfa
    open LitXml
    open FSharp.ViewEngine
    open type Html
    open BrowserApi.Css.Authoring
    type Attribute =
        private
        | RDFa of string

        member this.localName =
            let (RDFa localName) = this
            localName

        member this.Xml = attr this.localName

        member this.Html = _attr this.localName

        member this.css = AttrSelector this.localName
    let about = RDFa "about"
    let content = RDFa "content"
    let datatype = RDFa "datatype"
    let href = RDFa "href"
    let inlist = RDFa "inlist"
    let prefix = RDFa "prefix"
    let property = RDFa "property"
    let rel = RDFa "rel"
    let resource = RDFa "resource"
    let rev = RDFa "rev"
    let src = RDFa "src"
    let typeof_ = RDFa "typeof"
    let vocab = RDFa "vocab"
    let context = _namespace.curie "context"
    let copy = _namespace.curie "copy"
    let DocumentError = _namespace.curie "DocumentError"
    let Error = _namespace.curie "Error"
    let Info = _namespace.curie "Info"
    let Pattern = _namespace.curie "Pattern"
    let PGClass = _namespace.curie "PGClass"
    let PrefixMapping = _namespace.curie "PrefixMapping"
    let PrefixOrTermMapping = _namespace.curie "PrefixOrTermMapping"
    let PrefixRedefinition = _namespace.curie "PrefixRedefinition"
    let term = _namespace.curie "term"
    let TermMapping = _namespace.curie "TermMapping"
    let UnresolvedCURIE = _namespace.curie "UnresolvedCURIE"
    let UnresolvedTerm = _namespace.curie "UnresolvedTerm"
    let uri = _namespace.curie "uri"
    let usesVocabulary = _namespace.curie "usesVocabulary"
    let VocabReferenceError = _namespace.curie "VocabReferenceError"
    let vocabulary = _namespace.curie "vocabulary"
    let Warning = _namespace.curie "Warning"

module owl =
    let _namespace = RdfVocabulary.owl
    module Measure =
        [<Measure>]
        type rational =
            static member literal(value: string) : string<rational> = UMX.tag value
            static member Datatype: Datatype<rational> = {
                _datatypeIri = _namespace.curie "rational" |> DatatypeIri
            }
        [<Measure>]
        type real =
            static member literal(value: string) : string<real> = UMX.tag value
            static member Datatype: Datatype<real> = {
                _datatypeIri = _namespace.curie "real" |> DatatypeIri
            }
    let rational = Measure.rational.Datatype
    let real = Measure.real.Datatype
type NormativeDataset = {
    defaultGraph: NormativeGraph
    namedGraphs: Set<NormativeNamedGraph>
}
and [<CustomEquality; CustomComparison>] NormativeNamedGraph = {
    normativeGraph: NormativeGraph
    graphName: GraphName
} with

    member this.identity = this.graphName
    override this.Equals(other: obj) =
        match other with
        | :? NormativeNamedGraph as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? NormativeNamedGraph as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<NormativeNamedGraph>.Name} with {other.GetType().Name}"
and BasicNormativeGraph = {
    context: Iri option
    basicNormativeTriples: Set<BasicNormativeTriple>
} with

    member this.normativeTriples = this.basicNormativeTriples |> Set.map BasicNormativeTriple.toNormativeTriple
and NormativeGraph =

    {
        context: Iri option
        normativeTriples: Set<NormativeTriple>
    } with

        member this.BNodes =
            this.normativeTriples
            |> Seq.toArray
            |> Array.collect (fun normativeTriple -> normativeTriple.BNodes)
        member this.Iris =
            this.normativeTriples
            |> Seq.toArray
            |> Array.collect (fun normativeTriple -> normativeTriple.Iris)
        member this.BNodeIdentities = this.BNodes |> Array.map (fun (bnode: BNode) -> bnode.identity) |> Set.ofArray

        /// https://w3c.github.io/rdf-interop/spec/#section-basicenc-algo
        member this.basicEncode: BasicNormativeGraph =
            let hasTripleTerms =
                this.normativeTriples
                |> Seq.exists (fun (triple: NormativeTriple) -> triple.normativeObject.IsTripleTermObject)

            let hasPropositionFormMarker =
                this.normativeTriples
                |> Seq.exists (fun triple -> triple.isPropositionFormMarker)

            if hasTripleTerms && hasPropositionFormMarker then
                invalidOp "RDF 1.2 basic encoding is undefined for a hybrid graph containing both triple terms and blank-node rdf:PropositionForm markers."
            // Freshness is checked on the exported blank-node identity, not only on
            // Doxaletheia's (scope, identity) equality, because external RDF libraries
            // generally expose the identifier without our scope component.
            let mutable extantBNodeIdentities = this.BNodeIdentities

            let freshBlankNode () =
                let rec create () =
                    let sinsignId = Guid.NewGuid()
                    let identity = sinsignId.ToString("N")

                    if extantBNodeIdentities.Contains identity then
                        create ()
                    else
                        extantBNodeIdentities <- extantBNodeIdentities.Add identity
                        {
                            sinsignId = sinsignId
                            scope =
                                this.context
                                |> Option.map (fun iri -> iri.identity)
                                |> Option.defaultValue String.Empty
                            localIdentifier = None
                        }

                create ()
            let tripleTermMap = Generic.Dictionary<NormativeTriple, BNode>()
            let outputTriples = ResizeArray<BasicNormativeTriple>()
            let rec encodeNormativeObject (normativeObject: NormativeObject) : BasicNormativeObject =
                match normativeObject with
                | BasicNormativeObject basicObject -> basicObject
                | TripleTermObject tripleTerm -> encodeTripleTerm tripleTerm |> BNodeObject
            and encodeTripleTerm (tripleTerm: TripleTerm) : BNode =
                let (TripleTerm triple) = tripleTerm

                match tripleTermMap.TryGetValue triple with
                | true, existingBlankNode -> existingBlankNode
                | false, _ ->
                    let encodedObject = encodeNormativeObject triple.normativeObject
                    let blankNode = freshBlankNode ()
                    tripleTermMap.Add(triple, blankNode)
                    outputTriples.Add(BasicNormativeTriple.PropositionForm blankNode rdf.type_ (IriObject rdf.PropositionForm))
                    outputTriples.Add(BasicNormativeTriple.PropositionForm blankNode rdf.propositionFormSubject triple.normativeSubject.asBasicNormativeObject)
                    outputTriples.Add(BasicNormativeTriple.PropositionForm blankNode rdf.propositionFormPredicate triple.normativePredicate.asBasicNormativeObject)
                    outputTriples.Add(BasicNormativeTriple.PropositionForm blankNode rdf.propositionFormObject encodedObject)
                    blankNode
            for normativeTriple in this.normativeTriples do
                outputTriples.Add {
                    normativeSubject = normativeTriple.normativeSubject
                    normativePredicate = normativeTriple.normativePredicate
                    basicNormativeObject = encodeNormativeObject normativeTriple.normativeObject
                }
            {
                context = this.context
                basicNormativeTriples = outputTriples |> Set.ofSeq
            }

and NormativeQuad = {
    normativeTriple: NormativeTriple
    graphName: GraphName option
}
and GraphName =
    | GraphName of NormativeSubject

    member this.normativeSubject =
        match this with
        | GraphName normativeSubject -> normativeSubject
    member this.identity =
        match this.normativeSubject with
        | IriSubject iri -> iri.identity
        | BNodeSubject bnode -> bnode.identity

and BasicNormativeTriple = {
    normativeSubject: NormativeSubject
    normativePredicate: NormativePredicate
    basicNormativeObject: BasicNormativeObject
} with

    static member toNormativeTriple(basicNormativeTriple: BasicNormativeTriple) = {
        normativeSubject = basicNormativeTriple.normativeSubject
        normativePredicate = basicNormativeTriple.normativePredicate
        normativeObject = BasicNormativeObject basicNormativeTriple.basicNormativeObject
    }

    member this.asNormativeTriple = BasicNormativeTriple.toNormativeTriple this
    static member op_Implicit(basicNormativeTriple: BasicNormativeTriple) = basicNormativeTriple.asNormativeTriple
    static member PropositionForm (subject: BNode) (predicate: Iri) (objectValue: BasicNormativeObject) = {
        normativeSubject = BNodeSubject subject
        normativePredicate = IriPredicate predicate
        basicNormativeObject = objectValue
    }
    member this.BNodes =
        match this.normativeSubject, this.basicNormativeObject with
        | BNodeSubject bnodeSubject, BNodeObject bnodeObject -> [| bnodeSubject; bnodeObject |]
        | BNodeSubject bnodeSubject, _ -> [| bnodeSubject |]
        | _, BNodeObject bnodeObject -> [| bnodeObject |]
        | _, _ -> [||]
    member this.Iris =
        match this.normativeSubject, this.basicNormativeObject with
        | IriSubject iriSubject, IriObject iriObject -> [| iriSubject; this.normativePredicate.Iri; iriObject |]
        | IriSubject iriSubject, _ -> [| iriSubject; this.normativePredicate.Iri |]
        | _, IriObject iriObject -> [| this.normativePredicate.Iri; iriObject |]
        | _, _ -> [| this.normativePredicate.Iri |]
and NormativeTriple = {
    normativeSubject: NormativeSubject
    normativePredicate: NormativePredicate
    normativeObject: NormativeObject
} with

    member this.BNodes =
        let subjectBNodes =
            match this.normativeSubject with
            | BNodeSubject bnode -> [| bnode |]
            | IriSubject _ -> [||]

        let objectBNodes =
            match this.normativeObject with
            | BasicNormativeObject(BNodeObject bnode) -> [| bnode |]

            | TripleTermObject(TripleTerm triple) -> triple.BNodes

            | _ -> [||]

        Array.append subjectBNodes objectBNodes

    member this.Iris =
        let subjectIris =
            match this.normativeSubject with
            | IriSubject iri -> [| iri |]
            | BNodeSubject _ -> [||]

        let objectIris =
            match this.normativeObject with
            | BasicNormativeObject(IriObject iri) -> [| iri |]

            | TripleTermObject(TripleTerm triple) -> triple.Iris

            | _ -> [||]

        Array.concat [ subjectIris; [| this.normativePredicate.Iri |]; objectIris ]
    member this.isPropositionFormMarker =
        match this.normativeSubject, this.normativePredicate, this.normativeObject with
        | BNodeSubject _, IriPredicate predicate, BasicNormativeObject(IriObject objectIri) when predicate = rdf.type_ && objectIri = rdf.PropositionForm -> true
        | _ -> false
and NormativeSubject =
    | IriSubject of Iri
    | BNodeSubject of BNode

    member this.asBasicNormativeObject = BasicNormativeObject.ofNormativeSubject this

and NormativePredicate =
    | IriPredicate of Iri

    member this.Iri =
        match this with
        | IriPredicate iri -> iri

    member this.asBasicNormativeObject = BasicNormativeObject.ofNormativePredicate this
and BasicNormativeObject =
    | IriObject of Iri
    | BNodeObject of BNode
    | LiteralObject of Literal

    static member ofNormativeSubject(normativeSubject: NormativeSubject) =
        match normativeSubject with
        | IriSubject iri -> IriObject iri
        | BNodeSubject bnode -> BNodeObject bnode
    static member ofNormativePredicate(normativePredicate: NormativePredicate) =
        match normativePredicate with
        | IriPredicate iri -> IriObject iri
and NormativeObject =
    | BasicNormativeObject of BasicNormativeObject
    | TripleTermObject of TripleTerm
and BasicRdfTerm =
    | IriTerm of Iri
    | LiteralTerm of Literal
    | BlankTerm of BNode
and RdfTerm =
    | BasicRdfTerm of BasicRdfTerm
    | RdfTripleTerm of TripleTerm
and TripleTerm = TripleTerm of NormativeTriple
and [<CustomEquality; CustomComparison>] BNode = {
    sinsignId: Guid
    scope: string
    localIdentifier: string option
} with

    member this.identity = this.sinsignId.ToString("N")
    override this.Equals(other: obj) =
        match other with
        | :? BNode as other -> this.identity = other.identity && this.scope = other.scope
        | _ -> false

    override this.GetHashCode() =
        HashCode.Combine(this.scope, this.identity)
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? BNode as other -> compare (this.scope, this.identity) (other.scope, other.identity)

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<BNode>.Name} with {other.GetType().Name}"
