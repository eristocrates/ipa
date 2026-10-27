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
open Meziantou.Framework
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

module private Unsafe =
    let inline cast<'FromType, 'ToType> (fromValue: 'FromType) : 'ToType =
#if !FABLE_COMPILER
        // virtually undocumented inline MSIL escape hatch that technically allows for declaring arbitrary type conversions to accomodate for typing manual IL operations
        // the (# "il instructions" value : Type #) construct is found all over FSharp.Core, and at least mentioned in some articles like https://dev.to/entomy/cs-generic-math-from-f-31a7
        // but by passing no actual IL code in the quotes, the same input value can be effectively retyped at will
        // the developer is taking manual responsibility for ensuring both types are aliases of one another, to accompilsh conversion without runtime exceptions.

        (# "" fromValue : 'ToType #)
#else
        unbox<'ToType> fromValue
#endif

[<AutoOpen>]
[<MeasureAnnotatedAbbreviation>]
type string<[<Measure>] 'DatatypeMeasure> = string

type UMX =
    static member inline tag<[<Measure>] 'DatatypeMeasure>(x: string) : string<'DatatypeMeasure> = Unsafe.cast x
    static member inline untag<[<Measure>] 'DatatypeMeasure>(x: string<'DatatypeMeasure>) : string = Unsafe.cast x
    static member inline cast<[<Measure>] 'FromDatatypeMeasure, [<Measure>] 'ToDatatypeMeasure>(literal: string<'FromDatatypeMeasure>) : string<'ToDatatypeMeasure> =
        Unsafe.cast literal

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
    member this.UrlPattern = UrlPattern.Create(sprintf "%s{:localName}" this.identity)
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
type InitialTextDirection =
    | Ltr
    | Rtl

    static member tryParse(rawString: string) =
        match rawString.ToLowerInvariant() with
        | "ltr" -> Some Ltr
        | "rtl" -> Some Rtl
        | _ -> None

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
type FacetValue = {
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
and Datatype<[<Measure>] 'Datatype> = private {
    _datatypeIri: DatatypeIri
} with

    static member ofDatatypeIri(datatypeIri: DatatypeIri) : Datatype<'Datatype> = { _datatypeIri = datatypeIri }
    member this.datatypeIri = this._datatypeIri

    member this.Iri = this._datatypeIri.Iri
    static member (^^)((lexicalForm: System.String), (datatype: Datatype<'Datatype>)) : StaticTypedLiteral<'Datatype> = {
        literal = UMX.tag lexicalForm
        datatype = datatype
    }

and StaticTypedLiteral<[<Measure>] 'Datatype> = {
    literal: string<'Datatype>
    datatype: Datatype<'Datatype>
} with

    static member toTypedLiteral(staticTypedLiteral: StaticTypedLiteral<'Datatype>) : TypedLiteral = {
        lexicalForm = UMX.untag staticTypedLiteral.literal

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

    static member nonNegativeInteger(nonNegativeInteger: uint32) = {
        lexicalForm = string nonNegativeInteger
        datatypeIri = RdfVocabulary.xsd.curie "nonNegativeInteger" |> DatatypeIri
    }

    static member op_Implicit(value: bool) = {
        lexicalForm = if value then "true" else "false"
        datatypeIri = RdfVocabulary.xsd.curie "boolean" |> DatatypeIri
    }

    // byte[] -> xsd:base64Binary
    static member op_Implicit(value: byte array) = {
        lexicalForm = Convert.ToBase64String value
        datatypeIri = RdfVocabulary.xsd.curie "base64Binary" |> DatatypeIri
    }

    // byte -> xsd:unsignedByte
    static member op_Implicit(value: byte) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "unsignedByte" |> DatatypeIri
    }

    // DateOnly -> xsd:date
    static member op_Implicit(value: DateOnly) = {
        lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "date" |> DatatypeIri
    }

    // DateTime -> xsd:dateTime
    static member op_Implicit(value: DateTime) = {
        lexicalForm = value.ToString("yyyy-MM-dd'T'HH:mm:ss.ffffff", CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "dateTime" |> DatatypeIri
    }

    // DateTimeOffset -> xsd:dateTimeStamp
    static member op_Implicit(value: DateTimeOffset) = {
        lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "dateTimeStamp" |> DatatypeIri
    }

    // decimal -> xsd:decimal
    static member op_Implicit(value: decimal) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "decimal" |> DatatypeIri
    }

    // double -> xsd:double
    static member op_Implicit(value: double) = {
        lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "double" |> DatatypeIri
    }

    // int16 -> xsd:short
    static member op_Implicit(value: int16) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "short" |> DatatypeIri
    }

    // int32 -> xsd:int
    static member op_Implicit(value: int32) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "int" |> DatatypeIri
    }

    // int64 -> xsd:long
    static member op_Implicit(value: int64) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "long" |> DatatypeIri
    }

    // sbyte -> xsd:byte
    static member op_Implicit(value: sbyte) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "byte" |> DatatypeIri
    }

    // single -> xsd:float
    static member op_Implicit(value: single) = {
        lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "float" |> DatatypeIri
    }

    // TimeOnly -> xsd:time
    static member op_Implicit(value: TimeOnly) = {
        lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "time" |> DatatypeIri
    }

    // TimeSpan -> xsd:duration
    static member op_Implicit(value: TimeSpan) = {
        lexicalForm = Xml.XmlConvert.ToString value
        datatypeIri = RdfVocabulary.xsd.curie "duration" |> DatatypeIri
    }

    // uint16 -> xsd:unsignedShort
    static member op_Implicit(value: uint16) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "unsignedShort" |> DatatypeIri
    }

    // uint32 -> xsd:unsignedInt
    static member op_Implicit(value: uint32) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "unsignedInt" |> DatatypeIri
    }

    // uint64 -> xsd:unsignedLong
    static member op_Implicit(value: uint64) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatypeIri = RdfVocabulary.xsd.curie "unsignedLong" |> DatatypeIri
    }

    // System.Uri -> xsd:anyURI
    static member op_Implicit(value: Uri) = {
        lexicalForm = value.OriginalString
        datatypeIri = RdfVocabulary.xsd.curie "anyURI" |> DatatypeIri
    }

    // XmlQualifiedName -> xsd:QName
    static member op_Implicit(value: XmlQualifiedName) = {
        lexicalForm = value.ToString()
        datatypeIri = RdfVocabulary.xsd.curie "QName" |> DatatypeIri
    }

    // Guid -> xsd:ID
    static member op_Implicit(value: Guid) = {
        lexicalForm = value.ToString("N")
        datatypeIri = RdfVocabulary.xsd.curie "ID" |> DatatypeIri
    }

    static member nil = {
        lexicalForm = "true"
        datatypeIri = RdfVocabulary.xsi.curie "nil" |> DatatypeIri
    }
    static member inline autotyped(value: ^ValueType) : TypedLiteral = FSharpPlus.Operators.implicit value

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

            static member canonicalMapping(value: System.Uri) : System.String = value.OriginalString

            static member lexicalForm(literal: string<anyURI>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<anyURI> = UMX.tag lexicalForm

            static member literal(value: System.Uri) : string<anyURI> =
                anyURI.canonicalMapping value |> anyURI.literal

            static member value(literal: string<anyURI>) : System.Uri =
                literal |> anyURI.lexicalForm |> System.Uri

            static member datatype: Datatype<anyURI> = {
                _datatypeIri = _namespace.curie "anyURI" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Uri) : StaticTypedLiteral<anyURI> = {
                literal = anyURI.literal value
                datatype = anyURI.datatype
            }

            static member typedLiteral(value: System.Uri) : TypedLiteral =
                anyURI.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        // Generated declarations to paste inside module xsd.Measure.
        // Requires: open System; open System.Globalization
        // Uses existing UMX, Datatype, TypedLiteral, StaticTypedLiteral, _namespace.
        // `literal(string)` is a tag, not lexical validation.
        // CLR mappings below are selected representations, not exhaustive XSD value spaces.

        [<Measure>]
        type base64Binary =
            static member canonicalMapping(value: System.Byte array) : System.String = Convert.ToBase64String(value)

            static member lexicalForm(literal: string<base64Binary>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<base64Binary> = UMX.tag lexicalForm

            static member literal(value: System.Byte array) : string<base64Binary> =
                base64Binary.canonicalMapping value |> base64Binary.literal

            static member value(literal: string<base64Binary>) : System.Byte array =
                let raw = base64Binary.lexicalForm literal
                let value = Convert.FromBase64String(raw)
                value

            static member datatype: Datatype<base64Binary> = {
                _datatypeIri = _namespace.curie "base64Binary" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Byte array) : StaticTypedLiteral<base64Binary> = {
                literal = base64Binary.literal value
                datatype = base64Binary.datatype
            }

            static member typedLiteral(value: System.Byte array) : TypedLiteral =
                base64Binary.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type boolean =
            static member canonicalMapping(value: System.Boolean) : System.String = if value then "true" else "false"

            static member lexicalForm(literal: string<boolean>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<boolean> = UMX.tag lexicalForm

            static member literal(value: System.Boolean) : string<boolean> =
                boolean.canonicalMapping value |> boolean.literal

            static member value(literal: string<boolean>) : System.Boolean =
                let raw = boolean.lexicalForm literal
                let value =
                    match raw with
                    | "true"
                    | "1" -> true
                    | "false"
                    | "0" -> false
                    | _ -> invalidArg "literal" "Invalid xsd:boolean lexical form"
                value

            static member datatype: Datatype<boolean> = {
                _datatypeIri = _namespace.curie "boolean" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Boolean) : StaticTypedLiteral<boolean> = {
                literal = boolean.literal value
                datatype = boolean.datatype
            }

            static member typedLiteral(value: System.Boolean) : TypedLiteral =
                boolean.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type date =
            static member canonicalMapping(value: System.DateOnly) : System.String =
                value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<date>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<date> = UMX.tag lexicalForm

            static member literal(value: System.DateOnly) : string<date> =
                date.canonicalMapping value |> date.literal

            static member value(literal: string<date>) : System.DateOnly =
                let raw = date.lexicalForm literal
                let value = System.DateOnly.ParseExact(raw, "yyyy-MM-dd", CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<date> = {
                _datatypeIri = _namespace.curie "date" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.DateOnly) : StaticTypedLiteral<date> = {
                literal = date.literal value
                datatype = date.datatype
            }

            static member typedLiteral(value: System.DateOnly) : TypedLiteral =
                date.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type dateTime =
            static member canonicalMapping(value: System.DateTime) : System.String =
                value.ToString("o", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<dateTime>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<dateTime> = UMX.tag lexicalForm

            static member literal(value: System.DateTime) : string<dateTime> =
                dateTime.canonicalMapping value |> dateTime.literal

            static member value(literal: string<dateTime>) : System.DateTime =
                let raw = dateTime.lexicalForm literal
                let value = System.DateTime.Parse(raw, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                value

            static member datatype: Datatype<dateTime> = {
                _datatypeIri = _namespace.curie "dateTime" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.DateTime) : StaticTypedLiteral<dateTime> = {
                literal = dateTime.literal value
                datatype = dateTime.datatype
            }

            static member typedLiteral(value: System.DateTime) : TypedLiteral =
                dateTime.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type dateTimeStamp =
            static member canonicalMapping(value: System.DateTimeOffset) : System.String =
                value.ToString("o", CultureInfo.InvariantCulture)
            static member literal(lexicalForm: System.String) : string<dateTimeStamp> = UMX.tag lexicalForm
            static member literal(value: DateTimeOffset) : string<dateTimeStamp> =
                dateTimeStamp.canonicalMapping value |> dateTimeStamp.literal
            static member value(literal: string<dateTimeStamp>) : DateTimeOffset =
                dateTimeStamp.lexicalForm literal |> DateTimeOffset.Parse
            static member lexicalForm(literal: string<dateTimeStamp>) : System.String = UMX.untag literal
            static member datatype: Datatype<dateTimeStamp> = {
                _datatypeIri = _namespace.curie "dateTimeStamp" |> DatatypeIri
            }
            static member staticTypedLiteral(value: System.DateTimeOffset) : StaticTypedLiteral<dateTimeStamp> =

                {
                    literal = dateTimeStamp.canonicalMapping value |> dateTimeStamp.literal
                    datatype = dateTimeStamp.datatype
                }
            static member typedLiteral(value: System.DateTimeOffset) : TypedLiteral =

                dateTimeStamp.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral
        [<Measure>]
        type decimal =
            static member canonicalMapping(value: System.Decimal) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<decimal>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<decimal> = UMX.tag lexicalForm

            static member literal(value: System.Decimal) : string<decimal> =
                decimal.canonicalMapping value |> decimal.literal

            static member value(literal: string<decimal>) : System.Decimal =
                let raw = decimal.lexicalForm literal
                let value = System.Decimal.Parse(raw, NumberStyles.Number, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<decimal> = {
                _datatypeIri = _namespace.curie "decimal" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Decimal) : StaticTypedLiteral<decimal> = {
                literal = decimal.literal value
                datatype = decimal.datatype
            }

            static member typedLiteral(value: System.Decimal) : TypedLiteral =
                decimal.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type integer =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<integer>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<integer> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<integer> =
                integer.canonicalMapping value |> integer.literal

            static member value(literal: string<integer>) : System.Numerics.BigInteger =
                let raw = integer.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<integer> = {
                _datatypeIri = _namespace.curie "integer" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<integer> = {
                literal = integer.literal value
                datatype = integer.datatype
            }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                integer.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type long =
            static member canonicalMapping(value: System.Int64) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<long>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<long> = UMX.tag lexicalForm

            static member literal(value: System.Int64) : string<long> =
                long.canonicalMapping value |> long.literal

            static member value(literal: string<long>) : System.Int64 =
                let raw = long.lexicalForm literal
                let value = System.Int64.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<long> = {
                _datatypeIri = _namespace.curie "long" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Int64) : StaticTypedLiteral<long> = {
                literal = long.literal value
                datatype = long.datatype
            }

            static member typedLiteral(value: System.Int64) : TypedLiteral =
                long.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type int =
            static member canonicalMapping(value: System.Int32) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<int>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<int> = UMX.tag lexicalForm

            static member literal(value: System.Int32) : string<int> =
                int.canonicalMapping value |> int.literal

            static member value(literal: string<int>) : System.Int32 =
                let raw = int.lexicalForm literal
                let value = System.Int32.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<int> = {
                _datatypeIri = _namespace.curie "int" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Int32) : StaticTypedLiteral<int> = {
                literal = int.literal value
                datatype = int.datatype
            }

            static member typedLiteral(value: System.Int32) : TypedLiteral =
                int.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type short =
            static member canonicalMapping(value: System.Int16) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<short>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<short> = UMX.tag lexicalForm

            static member literal(value: System.Int16) : string<short> =
                short.canonicalMapping value |> short.literal

            static member value(literal: string<short>) : System.Int16 =
                let raw = short.lexicalForm literal
                let value = System.Int16.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<short> = {
                _datatypeIri = _namespace.curie "short" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Int16) : StaticTypedLiteral<short> = {
                literal = short.literal value
                datatype = short.datatype
            }

            static member typedLiteral(value: System.Int16) : TypedLiteral =
                short.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type byte =
            static member canonicalMapping(value: System.SByte) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<byte>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<byte> = UMX.tag lexicalForm

            static member literal(value: System.SByte) : string<byte> =
                byte.canonicalMapping value |> byte.literal

            static member value(literal: string<byte>) : System.SByte =
                let raw = byte.lexicalForm literal
                let value = System.SByte.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<byte> = {
                _datatypeIri = _namespace.curie "byte" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.SByte) : StaticTypedLiteral<byte> = {
                literal = byte.literal value
                datatype = byte.datatype
            }

            static member typedLiteral(value: System.SByte) : TypedLiteral =
                byte.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type nonNegativeInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<nonNegativeInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<nonNegativeInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<nonNegativeInteger> =
                if not (value >= System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:nonNegativeInteger value space"
                nonNegativeInteger.canonicalMapping value |> nonNegativeInteger.literal

            static member value(literal: string<nonNegativeInteger>) : System.Numerics.BigInteger =
                let raw = nonNegativeInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)
                if not (value >= System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:nonNegativeInteger value space"
                value

            static member datatype: Datatype<nonNegativeInteger> = {
                _datatypeIri = _namespace.curie "nonNegativeInteger" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<nonNegativeInteger> = {
                literal = nonNegativeInteger.literal value
                datatype = nonNegativeInteger.datatype
            }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                nonNegativeInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type positiveInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<positiveInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<positiveInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<positiveInteger> =
                if not (value > System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:positiveInteger value space"
                positiveInteger.canonicalMapping value |> positiveInteger.literal

            static member value(literal: string<positiveInteger>) : System.Numerics.BigInteger =
                let raw = positiveInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)
                if not (value > System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:positiveInteger value space"
                value

            static member datatype: Datatype<positiveInteger> = {
                _datatypeIri = _namespace.curie "positiveInteger" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<positiveInteger> = {
                literal = positiveInteger.literal value
                datatype = positiveInteger.datatype
            }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                positiveInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedLong =
            static member canonicalMapping(value: System.UInt64) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedLong>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedLong> = UMX.tag lexicalForm

            static member literal(value: System.UInt64) : string<unsignedLong> =
                unsignedLong.canonicalMapping value |> unsignedLong.literal

            static member value(literal: string<unsignedLong>) : System.UInt64 =
                let raw = unsignedLong.lexicalForm literal
                let value = System.UInt64.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedLong> = {
                _datatypeIri = _namespace.curie "unsignedLong" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.UInt64) : StaticTypedLiteral<unsignedLong> = {
                literal = unsignedLong.literal value
                datatype = unsignedLong.datatype
            }

            static member typedLiteral(value: System.UInt64) : TypedLiteral =
                unsignedLong.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedInt =
            static member canonicalMapping(value: System.UInt32) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedInt>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedInt> = UMX.tag lexicalForm

            static member literal(value: System.UInt32) : string<unsignedInt> =
                unsignedInt.canonicalMapping value |> unsignedInt.literal

            static member value(literal: string<unsignedInt>) : System.UInt32 =
                let raw = unsignedInt.lexicalForm literal
                let value = System.UInt32.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedInt> = {
                _datatypeIri = _namespace.curie "unsignedInt" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.UInt32) : StaticTypedLiteral<unsignedInt> = {
                literal = unsignedInt.literal value
                datatype = unsignedInt.datatype
            }

            static member typedLiteral(value: System.UInt32) : TypedLiteral =
                unsignedInt.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedShort =
            static member canonicalMapping(value: System.UInt16) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedShort>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedShort> = UMX.tag lexicalForm

            static member literal(value: System.UInt16) : string<unsignedShort> =
                unsignedShort.canonicalMapping value |> unsignedShort.literal

            static member value(literal: string<unsignedShort>) : System.UInt16 =
                let raw = unsignedShort.lexicalForm literal
                let value = System.UInt16.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedShort> = {
                _datatypeIri = _namespace.curie "unsignedShort" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.UInt16) : StaticTypedLiteral<unsignedShort> = {
                literal = unsignedShort.literal value
                datatype = unsignedShort.datatype
            }

            static member typedLiteral(value: System.UInt16) : TypedLiteral =
                unsignedShort.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedByte =
            static member canonicalMapping(value: System.Byte) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedByte>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedByte> = UMX.tag lexicalForm

            static member literal(value: System.Byte) : string<unsignedByte> =
                unsignedByte.canonicalMapping value |> unsignedByte.literal

            static member value(literal: string<unsignedByte>) : System.Byte =
                let raw = unsignedByte.lexicalForm literal
                let value = System.Byte.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedByte> = {
                _datatypeIri = _namespace.curie "unsignedByte" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Byte) : StaticTypedLiteral<unsignedByte> = {
                literal = unsignedByte.literal value
                datatype = unsignedByte.datatype
            }

            static member typedLiteral(value: System.Byte) : TypedLiteral =
                unsignedByte.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type nonPositiveInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<nonPositiveInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<nonPositiveInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<nonPositiveInteger> =
                if not (value <= System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:nonPositiveInteger value space"
                nonPositiveInteger.canonicalMapping value |> nonPositiveInteger.literal

            static member value(literal: string<nonPositiveInteger>) : System.Numerics.BigInteger =
                let raw = nonPositiveInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)
                if not (value <= System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:nonPositiveInteger value space"
                value

            static member datatype: Datatype<nonPositiveInteger> = {
                _datatypeIri = _namespace.curie "nonPositiveInteger" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<nonPositiveInteger> = {
                literal = nonPositiveInteger.literal value
                datatype = nonPositiveInteger.datatype
            }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                nonPositiveInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type negativeInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<negativeInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<negativeInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<negativeInteger> =
                if not (value < System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:negativeInteger value space"
                negativeInteger.canonicalMapping value |> negativeInteger.literal

            static member value(literal: string<negativeInteger>) : System.Numerics.BigInteger =
                let raw = negativeInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)
                if not (value < System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:negativeInteger value space"
                value

            static member datatype: Datatype<negativeInteger> = {
                _datatypeIri = _namespace.curie "negativeInteger" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<negativeInteger> = {
                literal = negativeInteger.literal value
                datatype = negativeInteger.datatype
            }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                negativeInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type double =
            static member canonicalMapping(value: System.Double) : System.String =
                value.ToString("R", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<double>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<double> = UMX.tag lexicalForm

            static member literal(value: System.Double) : string<double> =
                double.canonicalMapping value |> double.literal

            static member value(literal: string<double>) : System.Double =
                let raw = double.lexicalForm literal
                let value = System.Double.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<double> = {
                _datatypeIri = _namespace.curie "double" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Double) : StaticTypedLiteral<double> = {
                literal = double.literal value
                datatype = double.datatype
            }

            static member typedLiteral(value: System.Double) : TypedLiteral =
                double.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type duration =
            static member canonicalMapping(value: System.TimeSpan) : System.String = System.Xml.XmlConvert.ToString(value)

            static member lexicalForm(literal: string<duration>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<duration> = UMX.tag lexicalForm

            static member literal(value: System.TimeSpan) : string<duration> =
                duration.canonicalMapping value |> duration.literal

            static member value(literal: string<duration>) : System.TimeSpan =
                let raw = duration.lexicalForm literal
                let value = System.Xml.XmlConvert.ToTimeSpan(raw)
                value

            static member datatype: Datatype<duration> = {
                _datatypeIri = _namespace.curie "duration" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.TimeSpan) : StaticTypedLiteral<duration> = {
                literal = duration.literal value
                datatype = duration.datatype
            }

            static member typedLiteral(value: System.TimeSpan) : TypedLiteral =
                duration.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type dayTimeDuration =
            static member canonicalMapping(value: System.TimeSpan) : System.String = System.Xml.XmlConvert.ToString(value)

            static member lexicalForm(literal: string<dayTimeDuration>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<dayTimeDuration> = UMX.tag lexicalForm

            static member literal(value: System.TimeSpan) : string<dayTimeDuration> =
                dayTimeDuration.canonicalMapping value |> dayTimeDuration.literal

            static member value(literal: string<dayTimeDuration>) : System.TimeSpan =
                let raw = dayTimeDuration.lexicalForm literal
                let value = System.Xml.XmlConvert.ToTimeSpan(raw)
                value

            static member datatype: Datatype<dayTimeDuration> = {
                _datatypeIri = _namespace.curie "dayTimeDuration" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.TimeSpan) : StaticTypedLiteral<dayTimeDuration> = {
                literal = dayTimeDuration.literal value
                datatype = dayTimeDuration.datatype
            }

            static member typedLiteral(value: System.TimeSpan) : TypedLiteral =
                dayTimeDuration.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type float =
            static member canonicalMapping(value: System.Single) : System.String =
                value.ToString("R", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<float>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<float> = UMX.tag lexicalForm

            static member literal(value: System.Single) : string<float> =
                float.canonicalMapping value |> float.literal

            static member value(literal: string<float>) : System.Single =
                let raw = float.lexicalForm literal
                let value = System.Single.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<float> = {
                _datatypeIri = _namespace.curie "float" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Single) : StaticTypedLiteral<float> = {
                literal = float.literal value
                datatype = float.datatype
            }

            static member typedLiteral(value: System.Single) : TypedLiteral =
                float.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type hexBinary =
            static member canonicalMapping(value: System.Byte array) : System.String = Convert.ToHexString(value)

            static member lexicalForm(literal: string<hexBinary>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<hexBinary> = UMX.tag lexicalForm

            static member literal(value: System.Byte array) : string<hexBinary> =
                hexBinary.canonicalMapping value |> hexBinary.literal

            static member value(literal: string<hexBinary>) : System.Byte array =
                let raw = hexBinary.lexicalForm literal
                let value = Convert.FromHexString(raw)
                value

            static member datatype: Datatype<hexBinary> = {
                _datatypeIri = _namespace.curie "hexBinary" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.Byte array) : StaticTypedLiteral<hexBinary> = {
                literal = hexBinary.literal value
                datatype = hexBinary.datatype
            }

            static member typedLiteral(value: System.Byte array) : TypedLiteral =
                hexBinary.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type time =
            static member canonicalMapping(value: System.TimeOnly) : System.String =
                value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<time>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<time> = UMX.tag lexicalForm

            static member literal(value: System.TimeOnly) : string<time> =
                time.canonicalMapping value |> time.literal

            static member value(literal: string<time>) : System.TimeOnly =
                let raw = time.lexicalForm literal
                let value = System.TimeOnly.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<time> = {
                _datatypeIri = _namespace.curie "time" |> DatatypeIri
            }

            static member staticTypedLiteral(value: System.TimeOnly) : StaticTypedLiteral<time> = {
                literal = time.literal value
                datatype = time.datatype
            }

            static member typedLiteral(value: System.TimeOnly) : TypedLiteral =
                time.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type yearMonthDuration =
            static member lexicalForm(literal: string<yearMonthDuration>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<yearMonthDuration> = UMX.tag lexicalForm

            static member datatype: Datatype<yearMonthDuration> = {
                _datatypeIri = _namespace.curie "yearMonthDuration" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<yearMonthDuration> = {
                literal = yearMonthDuration.literal lexicalForm
                datatype = yearMonthDuration.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                yearMonthDuration.staticTypedLiteral lexicalForm
                |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gDay =
            static member lexicalForm(literal: string<gDay>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gDay> = UMX.tag lexicalForm

            static member datatype: Datatype<gDay> = {
                _datatypeIri = _namespace.curie "gDay" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gDay> = {
                literal = gDay.literal lexicalForm
                datatype = gDay.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gDay.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gMonth =
            static member lexicalForm(literal: string<gMonth>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gMonth> = UMX.tag lexicalForm

            static member datatype: Datatype<gMonth> = {
                _datatypeIri = _namespace.curie "gMonth" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gMonth> = {
                literal = gMonth.literal lexicalForm
                datatype = gMonth.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gMonth.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gMonthDay =
            static member lexicalForm(literal: string<gMonthDay>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gMonthDay> = UMX.tag lexicalForm

            static member datatype: Datatype<gMonthDay> = {
                _datatypeIri = _namespace.curie "gMonthDay" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gMonthDay> = {
                literal = gMonthDay.literal lexicalForm
                datatype = gMonthDay.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gMonthDay.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gYear =
            static member lexicalForm(literal: string<gYear>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gYear> = UMX.tag lexicalForm

            static member datatype: Datatype<gYear> = {
                _datatypeIri = _namespace.curie "gYear" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gYear> = {
                literal = gYear.literal lexicalForm
                datatype = gYear.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gYear.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gYearMonth =
            static member lexicalForm(literal: string<gYearMonth>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gYearMonth> = UMX.tag lexicalForm

            static member datatype: Datatype<gYearMonth> = {
                _datatypeIri = _namespace.curie "gYearMonth" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gYearMonth> = {
                literal = gYearMonth.literal lexicalForm
                datatype = gYearMonth.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gYearMonth.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type string =
            static member lexicalForm(literal: string<string>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<string> = UMX.tag lexicalForm

            static member datatype: Datatype<string> = {
                _datatypeIri = _namespace.curie "string" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<string> = {
                literal = string.literal lexicalForm
                datatype = string.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                string.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type normalizedString =
            static member lexicalForm(literal: string<normalizedString>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<normalizedString> = UMX.tag lexicalForm

            static member datatype: Datatype<normalizedString> = {
                _datatypeIri = _namespace.curie "normalizedString" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<normalizedString> = {
                literal = normalizedString.literal lexicalForm
                datatype = normalizedString.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                normalizedString.staticTypedLiteral lexicalForm
                |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type token =
            static member lexicalForm(literal: string<token>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<token> = UMX.tag lexicalForm

            static member datatype: Datatype<token> = {
                _datatypeIri = _namespace.curie "token" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<token> = {
                literal = token.literal lexicalForm
                datatype = token.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                token.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type language =
            static member lexicalForm(literal: string<language>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<language> = UMX.tag lexicalForm

            static member datatype: Datatype<language> = {
                _datatypeIri = _namespace.curie "language" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<language> = {
                literal = language.literal lexicalForm
                datatype = language.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                language.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type Name =
            static member lexicalForm(literal: string<Name>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<Name> = UMX.tag lexicalForm

            static member datatype: Datatype<Name> = {
                _datatypeIri = _namespace.curie "Name" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<Name> = {
                literal = Name.literal lexicalForm
                datatype = Name.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                Name.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type NCName =
            static member lexicalForm(literal: string<NCName>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<NCName> = UMX.tag lexicalForm

            static member datatype: Datatype<NCName> = {
                _datatypeIri = _namespace.curie "NCName" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<NCName> = {
                literal = NCName.literal lexicalForm
                datatype = NCName.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                NCName.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type NMTOKEN =
            static member lexicalForm(literal: string<NMTOKEN>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<NMTOKEN> = UMX.tag lexicalForm

            static member datatype: Datatype<NMTOKEN> = {
                _datatypeIri = _namespace.curie "NMTOKEN" |> DatatypeIri
            }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<NMTOKEN> = {
                literal = NMTOKEN.literal lexicalForm
                datatype = NMTOKEN.datatype
            }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                NMTOKEN.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

    let anyURI: Datatype<Measure.anyURI> = Measure.anyURI.datatype
    let base64Binary: Datatype<Measure.base64Binary> = Measure.base64Binary.datatype
    let boolean: Datatype<Measure.boolean> = Measure.boolean.datatype
    let date: Datatype<Measure.date> = Measure.date.datatype
    let dateTime: Datatype<Measure.dateTime> = Measure.dateTime.datatype
    let dateTimeStamp: Datatype<Measure.dateTimeStamp> = Measure.dateTimeStamp.datatype
    let decimal: Datatype<Measure.decimal> = Measure.decimal.datatype
    let integer: Datatype<Measure.integer> = Measure.integer.datatype
    let long: Datatype<Measure.long> = Measure.long.datatype
    let int: Datatype<Measure.int> = Measure.int.datatype
    let short: Datatype<Measure.short> = Measure.short.datatype
    let byte: Datatype<Measure.byte> = Measure.byte.datatype
    let nonNegativeInteger: Datatype<Measure.nonNegativeInteger> = Measure.nonNegativeInteger.datatype
    let positiveInteger: Datatype<Measure.positiveInteger> = Measure.positiveInteger.datatype
    let unsignedLong: Datatype<Measure.unsignedLong> = Measure.unsignedLong.datatype
    let unsignedInt: Datatype<Measure.unsignedInt> = Measure.unsignedInt.datatype
    let unsignedShort: Datatype<Measure.unsignedShort> = Measure.unsignedShort.datatype
    let unsignedByte: Datatype<Measure.unsignedByte> = Measure.unsignedByte.datatype
    let nonPositiveInteger: Datatype<Measure.nonPositiveInteger> = Measure.nonPositiveInteger.datatype
    let negativeInteger: Datatype<Measure.negativeInteger> = Measure.negativeInteger.datatype
    let double: Datatype<Measure.double> = Measure.double.datatype
    let duration: Datatype<Measure.duration> = Measure.duration.datatype
    let dayTimeDuration: Datatype<Measure.dayTimeDuration> = Measure.dayTimeDuration.datatype
    let yearMonthDuration: Datatype<Measure.yearMonthDuration> = Measure.yearMonthDuration.datatype
    let float: Datatype<Measure.float> = Measure.float.datatype
    let gDay: Datatype<Measure.gDay> = Measure.gDay.datatype
    let gMonth: Datatype<Measure.gMonth> = Measure.gMonth.datatype
    let gMonthDay: Datatype<Measure.gMonthDay> = Measure.gMonthDay.datatype
    let gYear: Datatype<Measure.gYear> = Measure.gYear.datatype
    let gYearMonth: Datatype<Measure.gYearMonth> = Measure.gYearMonth.datatype
    let hexBinary: Datatype<Measure.hexBinary> = Measure.hexBinary.datatype
    let string: Datatype<Measure.string> = Measure.string.datatype
    let normalizedString: Datatype<Measure.normalizedString> = Measure.normalizedString.datatype
    let token: Datatype<Measure.token> = Measure.token.datatype
    let language: Datatype<Measure.language> = Measure.language.datatype
    let Name: Datatype<Measure.Name> = Measure.Name.datatype
    let NCName: Datatype<Measure.NCName> = Measure.NCName.datatype
    let NMTOKEN: Datatype<Measure.NMTOKEN> = Measure.NMTOKEN.datatype
    let time: Datatype<Measure.time> = Measure.time.datatype
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
type Autotyped = Autotyped
    with

        static member ($)(_: Autotyped, value: bool) : StaticTypedLiteral<xsd.Measure.boolean> =
            xsd.Measure.boolean.staticTypedLiteral value
        static member ($)(_: Autotyped, value: byte array) : StaticTypedLiteral<xsd.Measure.base64Binary> =
            xsd.Measure.base64Binary.staticTypedLiteral value
        static member ($)(_: Autotyped, value: byte) : StaticTypedLiteral<xsd.Measure.unsignedByte> =
            xsd.Measure.unsignedByte.staticTypedLiteral value
        static member ($)(_: Autotyped, value: DateOnly) : StaticTypedLiteral<xsd.Measure.date> =
            xsd.Measure.date.staticTypedLiteral value
        static member ($)(_: Autotyped, value: DateTime) : StaticTypedLiteral<xsd.Measure.dateTime> =
            xsd.Measure.dateTime.staticTypedLiteral value
        static member ($)(_: Autotyped, value: DateTimeOffset) : StaticTypedLiteral<xsd.Measure.dateTimeStamp> =
            xsd.Measure.dateTimeStamp.staticTypedLiteral value
        static member ($)(_: Autotyped, value: decimal) : StaticTypedLiteral<xsd.Measure.decimal> =
            xsd.Measure.decimal.staticTypedLiteral value
        static member ($)(_: Autotyped, value: double) : StaticTypedLiteral<xsd.Measure.double> =
            xsd.Measure.double.staticTypedLiteral value
        static member ($)(_: Autotyped, value: int16) : StaticTypedLiteral<xsd.Measure.short> =
            xsd.Measure.short.staticTypedLiteral value
        static member ($)(_: Autotyped, value: int32) : StaticTypedLiteral<xsd.Measure.int> =
            xsd.Measure.int.staticTypedLiteral value
        static member ($)(_: Autotyped, value: int64) : StaticTypedLiteral<xsd.Measure.long> =
            xsd.Measure.long.staticTypedLiteral value
        static member ($)(_: Autotyped, value: Numerics.BigInteger) : StaticTypedLiteral<xsd.Measure.integer> =
            xsd.Measure.integer.staticTypedLiteral value
        static member ($)(_: Autotyped, value: sbyte) : StaticTypedLiteral<xsd.Measure.byte> =
            xsd.Measure.byte.staticTypedLiteral value
        static member ($)(_: Autotyped, value: single) : StaticTypedLiteral<xsd.Measure.float> =
            xsd.Measure.float.staticTypedLiteral value
        static member ($)(_: Autotyped, value: String) : StaticTypedLiteral<xsd.Measure.string> =
            xsd.Measure.string.staticTypedLiteral value
        static member ($)(_: Autotyped, value: TimeOnly) : StaticTypedLiteral<xsd.Measure.time> =
            xsd.Measure.time.staticTypedLiteral value
        static member ($)(_: Autotyped, value: TimeSpan) : StaticTypedLiteral<xsd.Measure.duration> =
            xsd.Measure.duration.staticTypedLiteral value
        static member ($)(_: Autotyped, value: uint16) : StaticTypedLiteral<xsd.Measure.unsignedShort> =
            xsd.Measure.unsignedShort.staticTypedLiteral value
        static member ($)(_: Autotyped, value: uint32) : StaticTypedLiteral<xsd.Measure.unsignedInt> =
            xsd.Measure.unsignedInt.staticTypedLiteral value
        static member ($)(_: Autotyped, value: uint64) : StaticTypedLiteral<xsd.Measure.unsignedLong> =
            xsd.Measure.unsignedLong.staticTypedLiteral value
        static member ($)(_: Autotyped, value: Uri) : StaticTypedLiteral<xsd.Measure.anyURI> =
            xsd.Measure.anyURI.staticTypedLiteral value

let inline autotyped value = Autotyped $ value
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

    static member SPO((S: NormativeSubject), (P: NormativePredicate), (O: BasicNormativeObject)) = {
        normativeSubject = S
        normativePredicate = P
        basicNormativeObject = O
    }
    static member SOP((S: NormativeSubject), (O: BasicNormativeObject), (P: NormativePredicate)) = BasicNormativeTriple.SPO(S, P, O)

    static member PSO((P: NormativePredicate), (S: NormativeSubject), (O: BasicNormativeObject)) = BasicNormativeTriple.SPO(S, P, O)

    static member POS((P: NormativePredicate), (O: BasicNormativeObject), (S: NormativeSubject)) = BasicNormativeTriple.SPO(S, P, O)

    static member OSP((O: BasicNormativeObject), (S: NormativeSubject), (P: NormativePredicate)) = BasicNormativeTriple.SPO(S, P, O)

    static member OPS((O: BasicNormativeObject), (S: NormativeSubject), (P: NormativePredicate)) = BasicNormativeTriple.SPO(S, P, O)

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

    static member SPO((S: NormativeSubject), (P: NormativePredicate), (O: NormativeObject)) = {
        normativeSubject = S
        normativePredicate = P
        normativeObject = O
    }
    static member SOP((S: NormativeSubject), (O: NormativeObject), (P: NormativePredicate)) = NormativeTriple.SPO(S, P, O)

    static member PSO((P: NormativePredicate), (S: NormativeSubject), (O: NormativeObject)) = NormativeTriple.SPO(S, P, O)

    static member POS((P: NormativePredicate), (O: NormativeObject), (S: NormativeSubject)) = NormativeTriple.SPO(S, P, O)

    static member OSP((O: NormativeObject), (S: NormativeSubject), (P: NormativePredicate)) = NormativeTriple.SPO(S, P, O)

    static member OPS((O: NormativeObject), (S: NormativeSubject), (P: NormativePredicate)) = NormativeTriple.SPO(S, P, O)
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

type Iri with
    member this.asSubject = IriSubject this
    member this.asPredicate = IriPredicate this
    member this.asObject = IriObject this |> BasicNormativeObject
type BNode with
    member this.asSubject = BNodeSubject this
    member this.asObject = BNodeObject this |> BasicNormativeObject
type Literal with
    member this.asObject = LiteralObject this |> BasicNormativeObject
type TripleTerm with
    member this.asObject = TripleTermObject this
let inline Property
    (curPredicate: NormativePredicate)
    (curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject))
    (curObject: ^Object when ^Object: (member asObject: NormativeObject))
    =
    NormativeTriple.PSO(curPredicate, curSubject.asSubject, curObject.asObject)
