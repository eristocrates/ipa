open System
open System.IO
open System.Text

#r "nuget: Unquote"
open Swensen.Unquote.Assertions


#r "nuget: dotNetRdf"

#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\netstandard2.0\MyProvider.Runtime.dll"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets
open MyNamespace
open MyProvider

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Namespace_Prefixes.fsx"
open Namespace_Prefixes



type rdf =
    RDF_Generative_Provider<"http://www.w3.org/1999/02/22-rdf-syntax-ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\02\22-rdf-syntax-ns\hash\rdf.ttl">

let a = rdf.``type``


/// https://www.w3.org/TR/xmlschema-1/#Instance_Document_Constructions
type xsi =
    static member _namespace_name = "https://www.w3.org/2001/XMLSchema-instance#"
    /// https://www.w3.org/TR/xmlschema-1/#xsi_type
    static member type_ = NamespacedIri(xsi._namespace_name, "type")
    /// https://www.w3.org/TR/xmlschema-1/#xsi_nil
    static member nil = NamespacedIri(xsi._namespace_name, "nil")
    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    static member schemaLocation = NamespacedIri(xsi._namespace_name, "schemaLocation")

    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    static member noNamespaceSchemaLocation =
        NamespacedIri(xsi._namespace_name, "noNamespaceSchemaLocation")

type xdt =
    static member _namespace_name = "https://www.w3.org/2003/05/xpath-datatypes#"

    /// The datatype xdt:untyped denotes the dynamic type of an element node that has not been validated, or has been validated in skip mode. No predefined types are derived from xdt:untyped.
    static member untyped = NamespacedIri(xdt._namespace_name, "untyped")
    /// The datatype xdt:untypedAtomic denotes untyped atomic data, such as text that has not been assigned a more specific type. An attribute that has been validated in skip mode is represented in the Data Model by an attribute node with the type xdt:untypedAtomic. No predefined types are derived from xdt:untypedAtomic.
    static member untypedAtomic = NamespacedIri(xdt._namespace_name, "untypedAtomic")
    /// The datatype xdt:anyAtomicType is an atomic type that includes all atomic values (and no values that are not atomic). Its base type is xs:anySimpleType from which all simple types, including atomic, list, and union types are derived. All primitive atomic types, such as xs:integer and xs:string, have xdt:anyAtomicType as their base type.
    static member anyAtomicType = NamespacedIri(xdt._namespace_name, "anyAtomicType")
    /// The type xdt:dayTimeDuration is derived from xs:duration by restricting its lexical representation to contain only the days, hours, minutes and seconds components. The value space of xdt:dayTimeDuration is the set of fractional second values. The components of xdt:dayTimeDuration correspond to the day, hour, minute and second components defined in Section 5.5.3.2 of ISO 8601, , respectively. xdt:dayTimeDuration is derived from xs:duration as follows:
    static member dayTimeDuration = NamespacedIri(xdt._namespace_name, "dayTimeDuration")

    /// The type xdt:yearMonthDuration is derived from xs:duration by restricting its lexical representation to contain only the year and month components. The value space of xdt:yearMonthDuration is the set of xs:integer month values. The year and month components of xdt:yearMonthDuration correspond to the Gregorian year and month components defined in section 5.5.3.2 of ISO 8601, respectively.
    static member yearMonthDuration = NamespacedIri(xdt._namespace_name, "yearMonthDuration")

type xsd =
    RDF_Generative_Provider<"http://www.w3.org/2001/XMLSchema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2001\XMLSchema\hash\xsd.ttl">

type owl_time =
    RDF_Generative_Provider<"http://www.w3.org/2006/time#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\time\hash\time.ttl">

module Literal =
    open System
    open System.Globalization
    open System.Xml

    let simple lexical_form = SimpleLiteral lexical_form

    let en lexical_form =
        LanguageString(lexical_form, Language_Subtag.en)

    let en_us lexical_form =
        RegionString(lexical_form, Language_Subtag.en, Region_Subtag.US)

    let datatyped lexical_form datatype =
        DatatypedLiteral(lexical_form, datatype)

    let autotyped<'ValueType> (value: 'ValueType) =
        let value_string, datatype_iri =
            let invariant_string =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> (if value then "true" else "false"), xsd.boolean
            | :? (Byte array) as value -> Convert.ToBase64String(value), xsd.base64Binary
            | :? Byte as value -> invariant_string, xsd.unsignedByte
            | :? DateOnly as value -> value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), xsd.date
            | :? DateTime as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTime
            | :? DateTimeOffset as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTimeStamp
            | :? Decimal as value -> invariant_string, xsd.decimal
            | :? Double as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.double
            | :? Int16 as value -> invariant_string, xsd.short
            | :? Int32 as value -> invariant_string, xsd.int
            | :? Int64 as value -> invariant_string, xsd.long
            | :? SByte as value -> invariant_string, xsd.byte
            | :? Single as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.float
            | :? TimeOnly as value -> value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture), xsd.time
            | :? TimeSpan as value -> Xml.XmlConvert.ToString(value), xsd.duration
            | :? UInt16 as value -> invariant_string, xsd.unsignedShort
            | :? UInt32 as value -> invariant_string, xsd.unsignedInt
            | :? UInt64 as value -> invariant_string, xsd.unsignedLong
            | :? Uri as value -> value.AbsoluteUri, xsd.anyURI
            | :? XmlQualifiedName as value -> value.ToString(), xsd.QName
            | :? Guid as value -> value.ToString(), xsd.ID
            | null -> "true", xsi.nil
            | value when value.GetType() = typeof<Object> -> invariant_string, xdt.anyAtomicType
            | value -> invariant_string, xsd.string

        datatyped value_string datatype_iri

    let true_ = autotyped true
    let false_ = autotyped false

    module Binary =

        let base64 (bytes: Byte array) =
            let value_string = Convert.ToBase64String(bytes)

            datatyped value_string xsd.base64Binary

        let hex (bytes: Byte array) =
            let value_string = Convert.ToHexString(bytes)

            datatyped value_string xsd.hexBinary


    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                datatyped value_string xsd.duration

            let dayTimeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                datatyped value_string xdt.dayTimeDuration


            let yearMonthDuration (years: int) (months: int) =
                let total_months = years * 12 + months

                let value_string =
                    if total_months = 0 then
                        "P0M"
                    else
                        let absolute_months = abs total_months
                        let years_part = absolute_months / 12
                        let months_part = absolute_months % 12
                        let sign = if total_months < 0 then "-" else ""

                        let year_text =
                            if years_part = 0 then
                                ""
                            else
                                $"{years_part}Y"

                        let month_text =
                            if months_part = 0 then
                                ""
                            else
                                $"{months_part}M"

                        $"{sign}P{year_text}{month_text}"

                datatyped value_string xdt.yearMonthDuration


        module date =

            let only (date: DateOnly) =
                let value_string = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                datatyped value_string xsd.date

            let from_datetime (datetime: DateTime) =
                let value_string = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                datatyped value_string xsd.date

            let time (datetime: DateTime) =
                let value_string = datetime.ToString("o", CultureInfo.InvariantCulture)

                datatyped value_string xsd.dateTime

            let timeStamp (datetime_offset: DateTimeOffset) =
                let value_string = datetime_offset.ToString("o", CultureInfo.InvariantCulture)

                datatyped value_string xsd.dateTimeStamp



        module time =

            let only (time: TimeOnly) =
                let value_string = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                datatyped value_string xsd.time

            let from_datetime (datetime: DateTime) =
                let value_string =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                datatyped value_string xsd.time

        module period =

            let day (datetime: DateTime) =
                let value_string =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gDay


            let month (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gMonth


            let monthDay (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gMonthDay


            let year (datetime: DateTime) =
                let value_string = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                datatyped value_string xsd.gYear


            let yearMonth (datetime: DateTime) =
                let value_string =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gYearMonth

            let generalDay (day: int) =
                test <@ day >= 1 && day <= 99 @>
                let value_string = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string owl_time.generalDay


            let generalMonth (month: int) =
                test <@ month >= 1 && month <= 20 @>
                let value_string = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string owl_time.generalMonth


            let generalYear (year: int) =
                let value_string = year.ToString("0000", CultureInfo.InvariantCulture)

                datatyped value_string owl_time.generalYear


    module Numeric =

        let private bigint_value_string (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) =
            datatyped (bigint_value_string value) xsd.integer

        let negativeInteger (value: bigint) =
            test <@ value < 0I @>
            datatyped (bigint_value_string value) xsd.negativeInteger

        let nonNegativeInteger (value: bigint) =
            test <@ value >= 0I @>
            datatyped (bigint_value_string value) xsd.nonNegativeInteger

        let nonPositiveInteger (value: bigint) =
            test <@ value <= 0I @>
            datatyped (bigint_value_string value) xsd.nonPositiveInteger

        let positiveInteger (value: bigint) =
            test <@ value > 0I @>
            datatyped (bigint_value_string value) xsd.positiveInteger









































let inline ntriple
    (subject: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (object: ^ObjectType when ^ObjectType: (member as_object: Object_Term))
    =
    { curSubject = subject.as_subject
      curPredicate = predicate.as_predicate
      curObject = object.as_object }

let inline nquad
    (subject: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (object: ^ObjectType when ^ObjectType: (member as_object: Object_Term))
    (graph_name: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    =
    {

      triple = ntriple subject predicate object
      curGraph = Some graph_name.as_subject

    }


let inline predicateObjectList
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: ^ObjectType array when ^ObjectType: (member as_object: Object_Term))
    : Predicate_Term * Object_Term array =
    predicate.as_predicate,
    objectlist
    |> Array.map (fun objecttlist_item -> objecttlist_item.as_object)



let inline ttriples
    (subjectlist: ^SubjectType array when ^SubjectType: (member as_subject: Subject_Term))
    (predicateObjectLists: (Predicate_Term * Object_Term array) array)
    =
    set [

          for subject in subjectlist do
              for predicate, objectlist in predicateObjectLists do
                  for object in objectlist do
                      { curSubject = subject.as_subject
                        curPredicate = predicate
                        curObject = object } ]















let (^@) lexical_form language_tag =
    LanguageString(lexical_form, language_tag)


let (^^) lexical_form datatype =
    DatatypedLiteral(lexical_form, datatype)


let inline (-~-)
    (subjectlist: ^SubjectType array when ^SubjectType: (member as_subject: Subject_Term))
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    =
    subjectlist, predicate

let inline (---)
    (subject: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    =
    [| subject |] -~- predicate

let inline (-~|)
    (subjectlist: ^SubjectType array when ^SubjectType: (member as_subject: Subject_Term))
    (predicateObjectLists: (Predicate_Term * Object_Term array) array)
    =
    ttriples subjectlist predicateObjectLists

let inline (--|)
    (subject: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    (predicateObjectLists: (Predicate_Term * Object_Term array) array)
    =
    ttriples [| subject |] predicateObjectLists

let inline (-->)
    (subjectlist_predicate: ^SubjectType array * ^PredicateType when ^SubjectType: (member as_subject: Subject_Term) and ^PredicateType: (member as_predicate:
                                Predicate_Term))
    (object: ^ObjectType when ^ObjectType: (member as_object: Object_Term))
    =
    let subjectlist, predicate = subjectlist_predicate
    ttriples subjectlist [| predicateObjectList predicate [| object |] |]

let inline (-->=)
    (subjectlist_predicate: ^SubjectType array * ^PredicateType when ^SubjectType: (member as_subject: Subject_Term) and ^PredicateType: (member as_predicate:
                                Predicate_Term))
    object
    =
    let subjectlist, predicate = subjectlist_predicate
    ttriples subjectlist [| predicateObjectList predicate [| Literal.autotyped object |] |]

let inline (-->@)
    (subjectlist_predicate: ^SubjectType array * ^PredicateType when ^SubjectType: (member as_subject: Subject_Term) and ^PredicateType: (member as_predicate:
                                Predicate_Term))
    (lexical_form: string)
    (language_tag: Language_Subtag)
    =
    let subjectlist, predicate = subjectlist_predicate
    ttriples subjectlist [| predicateObjectList predicate [| lexical_form ^@ language_tag |] |]

let inline (-->^)
    (subjectlist_predicate: ^SubjectType array * ^PredicateType when ^SubjectType: (member as_subject: Subject_Term) and ^PredicateType: (member as_predicate:
                                Predicate_Term))
    (lexical_form: string)
    (datatype: Named_Resource)
    =
    let subjectlist, predicate = subjectlist_predicate
    ttriples subjectlist [| predicateObjectList predicate [| lexical_form ^^ datatype |] |]

let inline (->~)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: ^ObjectType array when ^ObjectType: (member as_object: Object_Term))
    =
    predicateObjectList predicate objectlist

let inline (->~=) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term)) objectlist =
    predicateObjectList
        predicate
        (objectlist
         |> Array.map (fun list_item -> Literal.autotyped list_item))

let inline (->~@)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: string array)
    (language_tag: Language_Subtag)
    =
    predicateObjectList
        predicate
        (objectlist
         |> Array.map (fun lexical_form -> lexical_form ^@ language_tag))

let inline (->~^)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: string array)
    (datatype: Named_Resource)
    =
    predicateObjectList
        predicate
        (objectlist
         |> Array.map (fun lexical_form -> lexical_form ^^ datatype))

let inline (->-)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (object: ^ObjectType when ^ObjectType: (member as_object: Object_Term))
    =
    predicateObjectList predicate [| object |]

let inline (->-=) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term)) object =
    predicateObjectList predicate [| Literal.autotyped object |]

let inline (->-@)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (lexical_form: string)
    (language_tag: Language_Subtag)
    =
    predicateObjectList predicate [| lexical_form ^@ language_tag |]

let inline (->-^)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (lexical_form: string)
    (datatype: Named_Resource)
    =
    predicateObjectList predicate [| lexical_form ^^ datatype |]



























// RDFa Core Initial Context
// https://www.w3.org/2011/rdfa-context/rdfa-1.1
type as_ =
    RDF_Generative_Provider<"https://www.w3.org/ns/activitystreams#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\www.w3.org\ns\activitystreams\hash\as.ttl">

type csvw =
    RDF_Generative_Provider<"http://www.w3.org/ns/csvw#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\csvw\hash\csvw.ttl">

type dcat =
    RDF_Generative_Provider<"http://www.w3.org/ns/dcat#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\dcat\hash\dcat.ttl">

type dqv =
    RDF_Generative_Provider<"http://www.w3.org/ns/dqv#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\dqv\hash\dqv.ttl">

type duv =
    RDF_Generative_Provider<"http://www.w3.org/ns/duv#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\duv\hash\duv.ttl">

type grddl =
    RDF_Generative_Provider<"http://www.w3.org/2003/g/data-view#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2003\g\data-view\hash\grddl.ttl">

type jsonld =
    RDF_Generative_Provider<"http://www.w3.org/ns/json-ld#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\json-ld\hash\jsonld.ttl">

type ldp =
    RDF_Generative_Provider<"http://www.w3.org/ns/ldp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ldp\hash\ldp.ttl">

type ma_ont =
    RDF_Generative_Provider<"http://www.w3.org/ns/ma-ont#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ma-ont\hash\ma-ont.ttl">

type oa =
    RDF_Generative_Provider<"http://www.w3.org/ns/oa#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\oa\hash\oa.ttl">

type odrl =
    RDF_Generative_Provider<"http://www.w3.org/ns/odrl/2/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\odrl\2\slash\odrl.ttl">

type org =
    RDF_Generative_Provider<"http://www.w3.org/ns/org#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\org\hash\org.ttl">

type owl =
    RDF_Generative_Provider<"http://www.w3.org/2002/07/owl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\07\owl\hash\owl.ttl">

type prov =
    RDF_Generative_Provider<"http://www.w3.org/ns/prov#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\prov\hash\prov.ttl">

type qb =
    RDF_Generative_Provider<"http://purl.org/linked-data/cube#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\linked-data\cube\hash\qb.ttl">


type rdfa =
    RDF_Generative_Provider<"http://www.w3.org/ns/rdfa#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\rdfa\hash\rdfa.ttl">

type rdfs =
    RDF_Generative_Provider<"http://www.w3.org/2000/01/rdf-schema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2000\01\rdf-schema\hash\rdfs.ttl">
// TODO get rif 	http://www.w3.org/2007/rif#
// unfortunately involves implementing mapping https://www.w3.org/TR/rif-in-rdf/
type rr =
    RDF_Generative_Provider<"http://www.w3.org/ns/r2rml#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\r2rml\hash\rr.ttl">

type sd =
    RDF_Generative_Provider<"http://www.w3.org/ns/sparql-service-description#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\sparql-service-description\hash\sd.ttl">

type skos =
    RDF_Generative_Provider<"http://www.w3.org/2004/02/skos/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2004\02\skos\core\hash\skos.ttl">

type skosxl =
    RDF_Generative_Provider<"http://www.w3.org/2008/05/skos-xl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2008\05\skos-xl\hash\skosxl.ttl">

type ssno =
    RDF_Generative_Provider<"http://www.w3.org/ns/ssn/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ssn\slash\ssno.ttl">

type sosa =
    RDF_Generative_Provider<"http://www.w3.org/ns/sosa/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\sosa\slash\sosa.ttl">


type void_ =
    RDF_Generative_Provider<"http://rdfs.org/ns/void#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\ns\void\hash\void.ttl">
// TODO get wdr 	http://www.w3.org/2007/05/powder#
type wdrs =
    RDF_Generative_Provider<"http://www.w3.org/2007/05/powder-s#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2007\05\powder-s\hash\wdrs.ttl">

type xhv =
    RDF_Generative_Provider<"http://www.w3.org/1999/xhtml/vocab#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\xhtml\vocab\hash\xhv.ttl">
// TODO get xml 	http://www.w3.org/XML/1998/namespace


type cc =
    RDF_Generative_Provider<"http://creativecommons.org/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\creativecommons.org\ns\hash\cc.ttl">

type ctag =
    RDF_Generative_Provider<"http://commontag.org/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\commontag.org\ns\hash\ctag.ttl">

type dcterms =
    RDF_Generative_Provider<"http://purl.org/dc/terms/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\dc\terms\slash\dcterms.ttl">

type dce =
    RDF_Generative_Provider<"http://purl.org/dc/elements/1.1/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\dc\elements\1.1\slash\dce.ttl">

type foaf =
    RDF_Generative_Provider<"http://xmlns.com/foaf/0.1/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\xmlns.com\foaf\0.1\slash\foaf.ttl">

type gr =
    RDF_Generative_Provider<"http://purl.org/goodrelations/v1#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\goodrelations\v1\hash\gr.ttl">
// TODO get ical 	http://www.w3.org/2002/12/cal/icaltzd#
// unfortunately requires dealing with malformed syntax, multiple rdf:IDs
type cal =
    RDF_Generative_Provider<"http://www.w3.org/2002/12/cal/ical#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\12\cal\ical\hash\cal.ttl">

type og =
    RDF_Generative_Provider<"http://ogp.me/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\ogp.me\ns\hash\og.ttl">

type rev =
    RDF_Generative_Provider<"http://purl.org/stuff/rev#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\stuff\rev\hash\rev.ttl">

type sioc =
    RDF_Generative_Provider<"http://rdfs.org/sioc/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\sioc\ns\hash\sioc.ttl">

type tsioc =
    RDF_Generative_Provider<"http://rdfs.org/sioc/types#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\sioc\types\hash\tsioc.ttl">

type tzont =
    RDF_Generative_Provider<"http://www.w3.org/2006/timezone#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\timezone\hash\tzont.ttl">

type vcard =
    RDF_Generative_Provider<"http://www.w3.org/2006/vcard/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\vcard\ns\hash\vcard.ttl">

type hydra =
    RDF_Generative_Provider<"http://www.w3.org/ns/hydra/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\hydra\core\hash\hydra.ttl">

type schemas =
    RDF_Generative_Provider<"https://schema.org/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\schema.org\slash\schemas.ttl">

type fresnel =
    RDF_Generative_Provider<"http://www.w3.org/2004/09/fresnel#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2004\09\fresnel\hash\fresnel.ttl">

type voaf =
    RDF_Generative_Provider<"http://purl.org/vocommons/voaf#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocommons\voaf\hash\voaf.ttl">

type vann =
    RDF_Generative_Provider<"http://purl.org/vocab/vann/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocab\vann\slash\vann.ttl">

type vaem =
    RDF_Generative_Provider<"http://www.linkedmodel.org/schema/vaem#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.linkedmodel.org\schema\vaem\hash\vaem.ttl">

type lemon =
    RDF_Generative_Provider<"http://lemon-model.net/lemon#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\lemon-model.net\lemon\hash\lemon.ttl">

type ontolex =
    RDF_Generative_Provider<"http://www.w3.org/ns/lemon/ontolex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\ontolex\hash\ontolex.ttl">

type vartrans =
    RDF_Generative_Provider<"http://www.w3.org/ns/lemon/vartrans#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\vartrans\hash\vartrans.ttl">

type synsem =
    RDF_Generative_Provider<"http://www.w3.org/ns/lemon/synsem#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\synsem\hash\synsem.ttl">

type decomp =
    RDF_Generative_Provider<"http://www.w3.org/ns/lemon/decomp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\decomp\hash\lexdcp.ttl">

type lime =
    RDF_Generative_Provider<"http://www.w3.org/ns/lemon/lime#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\lime\hash\lime.ttl">

type lexinfo =
    RDF_Generative_Provider<"http://www.lexinfo.net/ontology/2.0/lexinfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.lexinfo.net\ontology\2.0\lexinfo\hash\lexinfo.ttl">

type termlex =
    RDF_Generative_Provider<"https://termlex.oeg.fi.upm.es/termlex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\termlex.oeg.fi.upm.es\termlex\hash\termlex.ttl">

type fno =
    RDF_Generative_Provider<"https://w3id.org/function/ontology#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\ontology\hash\fno.ttl">

type fnom =
    RDF_Generative_Provider<"https://w3id.org/function/vocabulary/mapping#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\mapping\hash\fnom.ttl">

type fnoi =
    RDF_Generative_Provider<"https://w3id.org/function/vocabulary/implementation#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\implementation\hash\fnoi.ttl">

type fnoc =
    RDF_Generative_Provider<"https://w3id.org/function/vocabulary/composition#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\composition\hash\fnoc.ttl">

type rml_io =
    RDF_Generative_Provider<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-io.ttl">

type rml_cc =
    RDF_Generative_Provider<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-cc.ttl">

type rml_fnml =
    RDF_Generative_Provider<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-fnml.ttl">

type rml_star =
    RDF_Generative_Provider<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-star.ttl">

type sh =
    RDF_Generative_Provider<"http://www.w3.org/ns/shacl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shacl\hash\sh.ttl">

type psh =
    RDF_Generative_Provider<"http://ns.inria.fr/probabilistic-shacl/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\ns.inria.fr\probabilistic-shacl\slash\psh.ttl">

type shsh =
    RDF_Generative_Provider<"http://www.w3.org/ns/shacl-shacl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shacl-shacl\hash\shsh.ttl">

type shex =
    RDF_Generative_Provider<"http://www.w3.org/ns/shex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shex\hash\shex.ttl">

type sp =
    RDF_Generative_Provider<"http://spinrdf.org/sp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\spinrdf.org\sp\hash\sp.ttl">

type spin =
    RDF_Generative_Provider<"http://spinrdf.org/spin#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\spinrdf.org\spin\hash\spin.ttl">

type agrontology =
    RDF_Generative_Provider<"http://aims.fao.org/aos/agrontology#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\aims.fao.org\aos\agrontology\hash\agrontology.ttl">

type nmo =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nmo\hash\nmo.ttl">

type nexif =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\05\10\nexif\hash\nexif.ttl">

type nid3 =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\05\10\nid3\hash\nid3.ttl">

type pimo =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\11\01\pimo\hash\pimo.ttl">

type tmo =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2008\05\20\tmo\hash\tmo.ttl">

type tnrl =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/nrl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nrl\hash\tnrl.ttl">

type tnie =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/nie#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nie\hash\tnie.ttl">

type tnao =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/nao#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nao\hash\tnao.ttl">

type tnco =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/nco#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nco\hash\tnco.ttl">

type tnfo =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/nfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nfo\hash\tnfo.ttl">

type tnmm =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/nmm#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nmm\hash\tnmm.ttl">

type tmfo =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/mfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\mfo\hash\tmfo.ttl">

type tracker =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/tracker#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\tracker\hash\tracker.ttl">

type tslo =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/slo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\slo\hash\tslo.ttl">

type tosinfo =
    RDF_Generative_Provider<"http://tracker.api.gnome.org/ontology/v3/osinfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\osinfo\hash\tosinfo.ttl">

type nie =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/01/19/nie#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\01\19\nie\hash\nie.ttl">

type nco =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/03/22/nco#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nco\hash\nco.ttl">

type nfo =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nfo\hash\nfo.ttl">

type ncal =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\04\02\ncal\hash\ncal.ttl">

type nao =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/08/15/nao#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\08\15\nao\hash\nao.ttl">

type nrl =
    RDF_Generative_Provider<"http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\08\15\nrl\hash\nrl.ttl">

type linkml =
    RDF_Generative_Provider<"https://w3id.org/linkml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.owl.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-annotations.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-annotations.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-datasets.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-datasets.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-extensions.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-extensions.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-mappings.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-mappings.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-types.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-types.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-units.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-units.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-validation.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-validation.ttl">













type dbug =
    static member _namespace_name = "https://eristocrates.dev/ontology/dbug/"

    static member _prefix local_name =
        NamespacedIri(dbug._namespace_name, local_name)

    static member this_ = dbug._prefix "this"
    static member example = dbug._prefix "example"
    static member Alice = dbug._prefix "Alice"
    static member Bob = dbug._prefix "Bob"
    static member Charlie = dbug._prefix "Charlie"
    static member Sasha = dbug._prefix "Sasha"



ntriple dbug.this_ a dbug.example
ntriple dbug.Alice foaf.knows dbug.Bob

ntriple dbug.Alice foaf.name (SimpleLiteral "Alice")



let test_triple = ntriple dbug.Alice a foaf.Person
test_triple.nrepresentation
let test_graph = new ThreadSafeGraph()

module NTriples =
    let parser = NTriplesParser()

    let parse (text: string) (graph: IGraph) =
        use reader = new StringReader(text)
        parser.Load(graph, reader)

NTriples.parse test_triple.nrepresentation test_graph

let map_prefixes (graph: IGraph) =
    global_prefix_declarations
    |> Array.Parallel.iter (fun (namespace_name, prefix_label) ->

        let uri_nodes =
            graph.AllNodes
            |> Seq.toArray
            |> Array.Parallel.choose (fun inode ->
                if inode.NodeType = NodeType.Uri then
                    Some(inode :?> UriNode)
                else
                    None

            )

        let term_is_namespaced =
            uri_nodes
            |> Array.Parallel.exists (fun uri_node ->

                uri_node.Uri.OriginalString.StartsWith(namespace_name)

            )

        if term_is_namespaced then
            graph.NamespaceMap.AddNamespace(prefix_label, new Uri(namespace_name)))

module Turtle =


    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.Rdf11Star)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let write (file_path: string) (graph: VDS.RDF.IGraph) =
        map_prefixes graph
        writer.Save(graph, file_path)

let test_ttl_path = Path.Combine(__SOURCE_DIRECTORY__, "test_graph.ttl")
Turtle.write test_ttl_path test_graph

// TODO next rework lmdb?
// maybe explicitly create property graph types....

dbug.Alice --- a --> foaf.Person

dbug.Alice --- foaf.name -->= "Alice"


ttriples [|

            dbug.Alice
            dbug.Sasha

            |] [|

    predicateObjectList a [| foaf.Person |]
    predicateObjectList
        foaf.knows
        [|

           dbug.Bob
           dbug.Charlie

           |]
|]

let default_graph =

    [|

       dbug.Alice
       dbug.Sasha

       |]
    -~| [|

           a ->- foaf.Person
           foaf.knows
           ->~ [|

                  dbug.Bob
                  dbug.Charlie

                  |]

           |]
