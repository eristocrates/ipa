namespace http.www.w3.org._2001.XMLSchema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module xsd =
    let _namespace_iri = Namespace_Iri xsd |> NamespaceIRI
    /// <summary>
    ///   <para>xsd:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#">http://www.w3.org/2001/XMLSchema#</seealso>
    let _prefix_iri = Prefixed_Name(xsd, "") |> PrefixedName
    /// <summary>
    ///   <para>xsd:AnyURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#AnyURI">http://www.w3.org/2001/XMLSchema#AnyURI</seealso>
    let AnyURI = Prefixed_Name(xsd, "AnyURI") |> PrefixedName
    /// <summary>
    ///   <para>xsd:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#Area">http://www.w3.org/2001/XMLSchema#Area</seealso>
    let Area = Prefixed_Name(xsd, "Area") |> PrefixedName
    /// <summary>
    ///   <para>xsd:Boolean</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#Boolean">http://www.w3.org/2001/XMLSchema#Boolean</seealso>
    let Boolean = Prefixed_Name(xsd, "Boolean") |> PrefixedName
    /// <summary>
    ///   <para>xsd:DateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#DateTime">http://www.w3.org/2001/XMLSchema#DateTime</seealso>
    let DateTime = Prefixed_Name(xsd, "DateTime") |> PrefixedName
    /// <summary>
    ///   <para>xsd:Double</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#Double">http://www.w3.org/2001/XMLSchema#Double</seealso>
    let Double = Prefixed_Name(xsd, "Double") |> PrefixedName
    /// <summary>
    ///   <para>xsd:ENTITIES</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `ENTITIES` represents the `ENTITIES` attribute type from [XML]. The _value
    ///     space_ of `ENTITIES` is the set of finite, non-zero-length sequences of
    ///     `ENTITY` values that have been declared as unparsed entities in a document
    ///     type definition. The _lexical space_ of `ENTITIES` is the set of
    ///     space-separated lists of tokens, of which each token is in the _lexical
    ///     space_ of `ENTITY`. The _item type_ of `ENTITIES` is `ENTITY`. `ENTITIES` is
    ///     derived from `anySimpleType` in two steps: an anonymous list type is
    ///     defined, whose _item type_ is `ENTITY`; this is the _base type_ of `ENTITIES`,
    ///     which restricts its value space to lists with at least one item.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ENTITIES"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#ENTITIES">http://www.w3.org/2001/XMLSchema#ENTITIES</seealso>
    let ENTITIES = Prefixed_Name(xsd, "ENTITIES") |> PrefixedName
    /// <summary>
    ///   <para>xsd:ENTITY</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `ENTITY` represents the `ENTITY` attribute type from [XML]. The _value space_
    ///      of `ENTITY` is the set of all strings that match the `NCName` production in
    ///      [Namespaces in XML] and have been declared as an unparsed entity in a
    ///      document type definition. The _lexical space_ of ENTITY is the set of all
    ///      strings that match the NCName production in [Namespaces in XML]. The
    ///      _base type_ of ENTITY is NCName.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ENTITY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#ENTITY">http://www.w3.org/2001/XMLSchema#ENTITY</seealso>
    let ENTITY = Prefixed_Name(xsd, "ENTITY") |> PrefixedName
    /// <summary>
    ///   <para>xsd:ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `ID` represents the `ID` attribute type from [XML]. The _value space_ of `ID` is
    ///      the set of all strings that match the `NCName` production in [Namespaces
    ///      in XML]. The _lexical space_ of `ID` is the set of all strings that match
    ///      the `NCName` production in [Namespaces in XML]. The _base type_ of `ID` is
    ///      `NCName`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#ID">http://www.w3.org/2001/XMLSchema#ID</seealso>
    let ID = Prefixed_Name(xsd, "ID") |> PrefixedName
    /// <summary>
    ///   <para>xsd:IDREF</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `IDREF` represents the `IDREF` attribute type from [XML]. The _value space_ of
    ///     `IDREF` is the set of all strings that match the `NCName` production in
    ///     [Namespaces in XML]. The _lexical space_ of `IDREF` is the set of strings
    ///     that match the `NCName` production in [Namespaces in XML]. The _base type_
    ///     of `IDREF` is `NCName`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IDREF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#IDREF">http://www.w3.org/2001/XMLSchema#IDREF</seealso>
    let IDREF = Prefixed_Name(xsd, "IDREF") |> PrefixedName
    /// <summary>
    ///   <para>xsd:IDREFS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `IDREFS` represents the `IDREFS` attribute type from [XML]. The _value space_
    ///     of `IDREFS` is the set of finite, non-zero-length sequences of `IDREF`s. The
    ///     _lexical space_ of `IDREFS` is the set of space-separated lists of tokens, of
    ///     which each token is in the _lexical space_ of `IDREF`. The _item type_ of
    ///     `IDREFS` is `IDREF`. `IDREFS` is derived from `anySimpleType` in two steps: an
    ///     anonymous list type is defined, whose _item type_ is `IDREF`; this is the
    ///     _base type_ of `IDREFS`, which restricts its value space to lists with at
    ///     least one item.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IDREFS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#IDREFS">http://www.w3.org/2001/XMLSchema#IDREFS</seealso>
    let IDREFS = Prefixed_Name(xsd, "IDREFS") |> PrefixedName
    /// <summary>
    ///   <para>xsd:Integer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#Integer">http://www.w3.org/2001/XMLSchema#Integer</seealso>
    let Integer = Prefixed_Name(xsd, "Integer") |> PrefixedName
    /// <summary>
    ///   <para>xsd:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#Location">http://www.w3.org/2001/XMLSchema#Location</seealso>
    let Location = Prefixed_Name(xsd, "Location") |> PrefixedName
    /// <summary>
    ///   <para>xsd:NCName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `NCName` represents XML "non-colonized" Names. The _value space_ of `NCName`
    ///      is the set of all strings which match the `NCName` production of
    ///      [Namespaces in XML]. The _lexical space_ of `NCName` is the set of all
    ///      strings which match the `NCName` production of [Namespaces in XML]. The
    ///      _base type_ of `NCName` is `Name`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NCName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#NCName">http://www.w3.org/2001/XMLSchema#NCName</seealso>
    let NCName = Prefixed_Name(xsd, "NCName") |> PrefixedName
    /// <summary>
    ///   <para>xsd:NMTOKEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `NMTOKEN` represents the `NMTOKEN` attribute type from [XML]. The _value
    ///      space_ of `NMTOKEN` is the set of tokens that match the `Nmtoken` production
    ///      in [XML]. The _lexical space_ of `NMTOKEN` is the set of strings that
    ///      match the Nmtoken production in [XML]. The _base type_ of `NMTOKEN` is
    ///      `token`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NMTOKEN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#NMTOKEN">http://www.w3.org/2001/XMLSchema#NMTOKEN</seealso>
    let NMTOKEN = Prefixed_Name(xsd, "NMTOKEN") |> PrefixedName
    /// <summary>
    ///   <para>xsd:NMTOKENS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `NMTOKENS` represents the `NMTOKENS` attribute type from [XML]. The _value
    ///     space_ of `NMTOKENS` is the set of finite, non-zero-length sequences of
    ///     `NMTOKEN`s. The _lexical space_ of `NMTOKENS` is the set of space-separated
    ///     lists of tokens, of which each token is in the _lexical space_ of `NMTOKEN`.
    ///     The _item type_ of `NMTOKENS` is `NMTOKEN`. `NMTOKENS` is derived from
    ///     `anySimpleType` in two steps: an anonymous list type is defined, whose
    ///     _item type_ is `NMTOKEN`; this is the _base type_ of `NMTOKENS`, which
    ///     restricts its value space to lists with at least one item.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NMTOKENS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#NMTOKENS">http://www.w3.org/2001/XMLSchema#NMTOKENS</seealso>
    let NMTOKENS = Prefixed_Name(xsd, "NMTOKENS") |> PrefixedName
    /// <summary>
    ///   <para>xsd:NOTATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `NOTATION` represents the `NOTATION` attribute type from [XML]. The _value
    ///     space_ of `NOTATION` is the set of `QNames` of notations declared in the
    ///     current schema. The _lexical space_ of `NOTATION` is the set of all names of
    ///     notations declared in the current schema (in the form of `QNames`).
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NOTATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#NOTATION">http://www.w3.org/2001/XMLSchema#NOTATION</seealso>
    let NOTATION = Prefixed_Name(xsd, "NOTATION") |> PrefixedName
    /// <summary>
    ///   <para>xsd:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `Name` represents XML Names. The _value space_ of `Name` is the set of all
    ///     strings which match the `Name` production of [XML]. The _lexical space_ of
    ///     `Name` is the set of all strings which match the `Name` production of [XML].
    ///     The _base type_ of `Name` is `token`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#Name">http://www.w3.org/2001/XMLSchema#Name</seealso>
    let Name = Prefixed_Name(xsd, "Name") |> PrefixedName
    /// <summary>
    ///   <para>xsd:QName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `QName` represents XML qualified names. The _value space_ of `QName` is the set
    ///     of tuples `{namespace name, local part}`, where namespace name is an `anyURI`
    ///     and local part is an `NCName`. The _lexical space_ of `QName` is the set of
    ///     strings that match the `QName` production of [Namespaces in XML].
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"QName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#QName">http://www.w3.org/2001/XMLSchema#QName</seealso>
    let QName = Prefixed_Name(xsd, "QName") |> PrefixedName
    /// <summary>
    ///   <para>xsd:String</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#String">http://www.w3.org/2001/XMLSchema#String</seealso>
    let String = Prefixed_Name(xsd, "String") |> PrefixedName
    /// <summary>
    ///   <para>xsd:anyAtomicType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `anyAtomicType` is a special _restriction_ of `anySimpleType`. The _value_ and
    ///     _lexical spaces_ of `anyAtomicType` are the unions of the _value_ and
    ///     _lexical spaces_ of all the _primitive_ datatypes, and `anyAtomicType` is
    ///     their _base type_.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"(any)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"anySimpleType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#anyAtomicType">http://www.w3.org/2001/XMLSchema#anyAtomicType</seealso>
    let anyAtomicType = Prefixed_Name(xsd, "anyAtomicType") |> PrefixedName
    /// <summary>
    ///   <para>xsd:anySimpleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     The definition of `anySimpleType` is a special _restriction_ of `anyType`. The
    ///     _lexical space_ of a`nySimpleType` is the set of all sequences of Unicode
    ///     characters, and its _value space_ includes all _atomic values_ and all
    ///     finite-length lists of zero or more _atomic values_.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"anySimpleType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#anySimpleType">http://www.w3.org/2001/XMLSchema#anySimpleType</seealso>
    let anySimpleType = Prefixed_Name(xsd, "anySimpleType") |> PrefixedName
    /// <summary>
    ///   <para>xsd:anyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     The root of the [XML Schema 1.1] datatype heirarchy.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"anyType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#anyType">http://www.w3.org/2001/XMLSchema#anyType</seealso>
    let anyType = Prefixed_Name(xsd, "anyType") |> PrefixedName
    /// <summary>
    ///   <para>xsd:anyURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `anyURI` represents an Internationalized Resource Identifier Reference
    ///     (IRI). An `anyURI` value can be absolute or relative, and may have an
    ///     optional fragment identifier (i.e., it may be an IRI Reference). This
    ///     type should be used when the value fulfills the role of an IRI, as
    ///     defined in [RFC 3987] or its successor(s) in the IETF Standards Track.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:anyURI"</para><para>"anyURI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#anyURI">http://www.w3.org/2001/XMLSchema#anyURI</seealso>
    let anyURI = Prefixed_Name(xsd, "anyURI") |> PrefixedName
    /// <summary>
    ///   <para>xsd:anyUri</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#anyUri">http://www.w3.org/2001/XMLSchema#anyUri</seealso>
    let anyUri = Prefixed_Name(xsd, "anyUri") |> PrefixedName
    /// <summary>
    ///   <para>xsd:base64Binary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `base64Binary` represents arbitrary Base64-encoded binary data. For
    ///     `base64Binary` data the entire binary stream is encoded using the `Base64`
    ///     Encoding defined in [RFC 3548], which is derived from the encoding
    ///     described in [RFC 2045].
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"base64Binary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#base64Binary">http://www.w3.org/2001/XMLSchema#base64Binary</seealso>
    let base64Binary = Prefixed_Name(xsd, "base64Binary") |> PrefixedName
    /// <summary>
    ///   <para>xsd:booelan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#booelan">http://www.w3.org/2001/XMLSchema#booelan</seealso>
    let booelan = Prefixed_Name(xsd, "booelan") |> PrefixedName
    /// <summary>
    ///   <para>xsd:boolean</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `boolean` represents the values of two-valued logic.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"boolean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:boolean"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#boolean">http://www.w3.org/2001/XMLSchema#boolean</seealso>
    let boolean = Prefixed_Name(xsd, "boolean") |> PrefixedName
    /// <summary>
    ///   <para>xsd:byte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `byte` is _derived_ from `short` by setting the value of `maxInclusive` to be
    ///     `127` and `minInclusive` to be `-128`. The _base type_ of `byte` is `short`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"byte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#byte">http://www.w3.org/2001/XMLSchema#byte</seealso>
    let byte = Prefixed_Name(xsd, "byte") |> PrefixedName
    /// <summary>
    ///   <para>xsd:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#citation">http://www.w3.org/2001/XMLSchema#citation</seealso>
    let citation = Prefixed_Name(xsd, "citation") |> PrefixedName
    /// <summary>
    ///   <para>xsd:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"
    ///     `date` represents top-open intervals of exactly one day in length on the
    ///     timelines of `dateTime`, beginning on the beginning moment of each day, up to
    ///     but not including the beginning moment of the next day). For non-timezoned
    ///     values, the top-open intervals disjointly cover the non-timezoned timeline,
    ///     one per day. For timezoned values, the intervals begin at every minute and
    ///     therefore overlap.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:date"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#date">http://www.w3.org/2001/XMLSchema#date</seealso>
    let date = Prefixed_Name(xsd, "date") |> PrefixedName
    /// <summary>
    ///   <para>xsd:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `dateTime` represents instants of time, optionally marked with a particular
    ///     time zone offset. Values representing the same instant but having different
    ///     time zone offsets are equal but not identical.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:dateTime"</para><para>"dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#dateTime">http://www.w3.org/2001/XMLSchema#dateTime</seealso>
    let dateTime = Prefixed_Name(xsd, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>xsd:dateTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     The `dateTimeStamp` datatype is _derived_ from `dateTime` by giving the value
    ///     required to its `explicitTimezone` facet. The result is that all values of
    ///     `dateTimeStamp` are required to have explicit time zone offsets and the
    ///     datatype is totally ordered.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dateTimeStamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#dateTimeStamp">http://www.w3.org/2001/XMLSchema#dateTimeStamp</seealso>
    let dateTimeStamp = Prefixed_Name(xsd, "dateTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>xsd:datetime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#datetime">http://www.w3.org/2001/XMLSchema#datetime</seealso>
    let datetime = Prefixed_Name(xsd, "datetime") |> PrefixedName
    /// <summary>
    ///   <para>xsd:dayTimeDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `dayTimeDuration` is a datatype _derived_ from `duration` by restricting its
    ///      _lexical representations_ to instances of `dayTimeDurationLexicalRep`. The
    ///      _value space_ of `dayTimeDuration` is therefore that of `duration` restricted
    ///      to those whose `months` property is `0`. This results in a `duration` datatype
    ///      which is totally ordered.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dayTimeDuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#dayTimeDuration">http://www.w3.org/2001/XMLSchema#dayTimeDuration</seealso>
    let dayTimeDuration = Prefixed_Name(xsd, "dayTimeDuration") |> PrefixedName
    /// <summary>
    ///   <para>xsd:decimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `decimal` represents a subset of the real numbers, which can be represented
    ///     by decimal numerals. The _value space_ of decimal is the set of numbers
    ///     that can be obtained by dividing an integer by a non-negative power of ten,
    ///     i.e., expressible as `i / 10n` where `i` and `n` are integers and `n ≥ 0`.
    ///     Precision is not reflected in this value space; the number `2.0` is not
    ///     distinct from the number `2.00`. The order relation on `decimal` is the order
    ///     relation on real numbers, restricted to this subset.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"decimal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#decimal">http://www.w3.org/2001/XMLSchema#decimal</seealso>
    let decimal = Prefixed_Name(xsd, "decimal") |> PrefixedName
    /// <summary>
    ///   <para>xsd:double</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     The `double` datatype is patterned after the IEEE double-precision 64-bit
    ///     floating point datatype [IEEE 754-2008]. Each floating point datatype has a
    ///     value space that is a subset of the rational numbers. Floating point
    ///     numbers are often used to approximate arbitrary real numbers.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:double"</para><para>"double"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#double">http://www.w3.org/2001/XMLSchema#double</seealso>
    let double = Prefixed_Name(xsd, "double") |> PrefixedName
    /// <summary>
    ///   <para>xsd:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `duration` is a datatype that represents durations of time. The concept of
    ///     duration being captured is drawn from those of [ISO 8601], specifically
    ///     durations without fixed endpoints. For example, "15 days" (whose most
    ///     common lexical representation in duration is `"'P15D'"`) is a duration value;
    ///     "15 days beginning 12 July 1995" and "15 days ending 12 July 1995" are not
    ///     duration values. duration can provide addition and subtraction operations
    ///     between duration values and between duration/dateTime value pairs, and can
    ///     be the result of subtracting dateTime values. However, only addition to
    ///     `dateTime` is required for XML Schema processing and is defined in the
    ///     function `dateTimePlusDuration`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#duration">http://www.w3.org/2001/XMLSchema#duration</seealso>
    let duration = Prefixed_Name(xsd, "duration") |> PrefixedName
    /// <summary>
    ///   <para>xsd:float</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     The `float` datatype is patterned after the IEEE single-precision 32-bit
    ///     floating point datatype [IEEE 754-2008]. Its value space is a subset of the
    ///     rational numbers. Floating point numbers are often used to approximate
    ///     arbitrary real numbers.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"float"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:float"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#float">http://www.w3.org/2001/XMLSchema#float</seealso>
    let float = Prefixed_Name(xsd, "float") |> PrefixedName
    /// <summary>
    ///   <para>xsd:gDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `gDay` represents whole days within an arbitrary month—days that recur at the
    ///     same point in each (Gregorian) month. This datatype is used to represent a
    ///     specific day of the month. To indicate, for example, that an employee gets
    ///     a paycheck on the 15th of each month. (Obviously, days beyond 28 cannot
    ///     occur in all months; they are nonetheless permitted, up to 31.)
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gDay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:gDay"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#gDay">http://www.w3.org/2001/XMLSchema#gDay</seealso>
    let gDay = Prefixed_Name(xsd, "gDay") |> PrefixedName
    /// <summary>
    ///   <para>xsd:gMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `gMonth` represents whole (Gregorian) months within an arbitrary year—months
    ///     that recur at the same point in each year. It might be used, for example,
    ///     to say what month annual Thanksgiving celebrations fall in different
    ///     countries (`--11` in the United States, `--10` in Canada, and possibly other
    ///     months in other countries).
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gMonth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:gMonth"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#gMonth">http://www.w3.org/2001/XMLSchema#gMonth</seealso>
    let gMonth = Prefixed_Name(xsd, "gMonth") |> PrefixedName
    /// <summary>
    ///   <para>xsd:gMonthDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `gMonthDay` represents whole calendar days that recur at the same point in
    ///     each calendar year, or that occur in some arbitrary calendar year.
    ///     (Obviously, days beyond 28 cannot occur in all Februaries; 29 is
    ///     nonetheless permitted.)
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:gMonthDay"</para><para>"gMonthDay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#gMonthDay">http://www.w3.org/2001/XMLSchema#gMonthDay</seealso>
    let gMonthDay = Prefixed_Name(xsd, "gMonthDay") |> PrefixedName
    /// <summary>
    ///   <para>xsd:gMonthYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#gMonthYear">http://www.w3.org/2001/XMLSchema#gMonthYear</seealso>
    let gMonthYear = Prefixed_Name(xsd, "gMonthYear") |> PrefixedName
    /// <summary>
    ///   <para>xsd:gYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `gYear` represents Gregorian calendar years.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gYear"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:gYear"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#gYear">http://www.w3.org/2001/XMLSchema#gYear</seealso>
    let gYear = Prefixed_Name(xsd, "gYear") |> PrefixedName
    /// <summary>
    ///   <para>xsd:gYearMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `gYearMonth` represents specific whole Gregorian months in specific Gregorian years.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gYearMonth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Year-Month"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:gYearMonth"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#gYearMonth">http://www.w3.org/2001/XMLSchema#gYearMonth</seealso>
    let gYearMonth = Prefixed_Name(xsd, "gYearMonth") |> PrefixedName
    /// <summary>
    ///   <para>xsd:hexBinary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     hexBinary` represents arbitrary hex-encoded binary data.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hexBinary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#hexBinary">http://www.w3.org/2001/XMLSchema#hexBinary</seealso>
    let hexBinary = Prefixed_Name(xsd, "hexBinary") |> PrefixedName
    /// <summary>
    ///   <para>xsd:int</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///       `int` is _derived_ from `long` by setting the value of `maxInclusive` to be
    ///       `2147483647` and `minInclusive` to be `-2147483648`. The _base type_ of `int`
    ///       is `long`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"int"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#int">http://www.w3.org/2001/XMLSchema#int</seealso>
    let int = Prefixed_Name(xsd, "int") |> PrefixedName
    /// <summary>
    ///   <para>xsd:integer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `integer` is _derived_ from `decimal` by fixing the value of `fractionDigits`
    ///      to be `0` and disallowing the trailing decimal point. This results in the
    ///      standard mathematical concept of the integer numbers. The _value space_ of
    ///      `integer` is the infinite set `{...,-2,-1,0,1,2,...}`. The _base type_ of
    ///      `integer` is `decimal`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:integer"</para><para>"integer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#integer">http://www.w3.org/2001/XMLSchema#integer</seealso>
    let integer = Prefixed_Name(xsd, "integer") |> PrefixedName
    /// <summary>
    ///   <para>xsd:lang</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#lang">http://www.w3.org/2001/XMLSchema#lang</seealso>
    let lang = Prefixed_Name(xsd, "lang") |> PrefixedName
    /// <summary>
    ///   <para>xsd:langString</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#langString">http://www.w3.org/2001/XMLSchema#langString</seealso>
    let langString = Prefixed_Name(xsd, "langString") |> PrefixedName
    /// <summary>
    ///   <para>xsd:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `language` represents formal natural language identifiers, as defined by [BCP
    ///     47] (currently represented by [RFC 4646] and [RFC 4647]) or its
    ///     successor(s). The _value space_ and _lexical space_ of `language` are the set
    ///     of all strings that conform to the pattern `[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#language">http://www.w3.org/2001/XMLSchema#language</seealso>
    let language = Prefixed_Name(xsd, "language") |> PrefixedName
    /// <summary>
    ///   <para>xsd:length</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#length">http://www.w3.org/2001/XMLSchema#length</seealso>
    let length = Prefixed_Name(xsd, "length") |> PrefixedName
    /// <summary>
    ///   <para>xsd:long</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `long` is _derived_ from `integer` by setting the value of `maxInclusive` to
    ///      be `9223372036854775807` and `minInclusive` to be `-9223372036854775808`. The
    ///      _base type_ of `long` is `integer`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"long"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#long">http://www.w3.org/2001/XMLSchema#long</seealso>
    let long = Prefixed_Name(xsd, "long") |> PrefixedName
    /// <summary>
    ///   <para>xsd:maxExclusive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#maxExclusive">http://www.w3.org/2001/XMLSchema#maxExclusive</seealso>
    let maxExclusive = Prefixed_Name(xsd, "maxExclusive") |> PrefixedName
    /// <summary>
    ///   <para>xsd:maxInclusive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#maxInclusive">http://www.w3.org/2001/XMLSchema#maxInclusive</seealso>
    let maxInclusive = Prefixed_Name(xsd, "maxInclusive") |> PrefixedName
    /// <summary>
    ///   <para>xsd:minExclusive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#minExclusive">http://www.w3.org/2001/XMLSchema#minExclusive</seealso>
    let minExclusive = Prefixed_Name(xsd, "minExclusive") |> PrefixedName
    /// <summary>
    ///   <para>xsd:minInclusive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#minInclusive">http://www.w3.org/2001/XMLSchema#minInclusive</seealso>
    let minInclusive = Prefixed_Name(xsd, "minInclusive") |> PrefixedName
    /// <summary>
    ///   <para>xsd:minLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#minLength">http://www.w3.org/2001/XMLSchema#minLength</seealso>
    let minLength = Prefixed_Name(xsd, "minLength") |> PrefixedName
    /// <summary>
    ///   <para>xsd:negativeInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `negativeInteger` is _derived_ from `nonPositiveInteger` by setting the value
    ///      of `maxInclusive` to be `-1`. This results in the standard mathematical
    ///      concept of the negative integers. The _value space_ of `negativeInteger` is
    ///      the infinite set `{...,-2,-1}`. The _base type_ of `negativeInteger` is
    ///      `nonPositiveInteger`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:negativeInteger"</para><para>"negativeInteger"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#negativeInteger">http://www.w3.org/2001/XMLSchema#negativeInteger</seealso>
    let negativeInteger = Prefixed_Name(xsd, "negativeInteger") |> PrefixedName
    /// <summary>
    ///   <para>xsd:nonNegativeInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `nonNegativeInteger` is _derived_ from `integer` by setting the value of
    ///      `minInclusive` to be `0`. This results in the standard mathematical concept
    ///      of the non-negative integers. The _value space_ of `nonNegativeInteger` is
    ///      the infinite set `{0,1,2,...}`. The _base type_ of `nonNegativeInteger` is
    ///      `integer`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nonNegativeInteger"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:nonNegativeInteger"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#nonNegativeInteger">http://www.w3.org/2001/XMLSchema#nonNegativeInteger</seealso>
    let nonNegativeInteger = Prefixed_Name(xsd, "nonNegativeInteger") |> PrefixedName
    /// <summary>
    ///   <para>xsd:nonPositiveInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `nonPositiveInteger` is _derived_ from `integer` by setting the value of
    ///     `maxInclusive` to be `0`. This results in the standard mathematical concept
    ///     of the non-positive integers. The _value space_ of `nonPositiveInteger` is
    ///     the infinite set `{...,-2,-1,0}`. The _base type_ of `nonPositiveInteger` is
    ///     `integer`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:nonPositiveInteger"</para><para>"nonPositiveInteger"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#nonPositiveInteger">http://www.w3.org/2001/XMLSchema#nonPositiveInteger</seealso>
    let nonPositiveInteger = Prefixed_Name(xsd, "nonPositiveInteger") |> PrefixedName
    /// <summary>
    ///   <para>xsd:normalizedString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `normalizedString` represents white space normalized strings. The _value
    ///     space_ of `normalizedString` is the set of strings that do not contain the
    ///     carriage return (`#xD`), line feed (`#xA`) nor tab (`#x9`) characters. The
    ///     _lexical space_ of `normalizedString` is the set of strings that do not
    ///     contain the carriage return (`#xD`), line feed (`#xA`) nor tab (`#x9`)
    ///     characters. The _base type_ of `normalizedString` is `string`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"normalizedString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#normalizedString">http://www.w3.org/2001/XMLSchema#normalizedString</seealso>
    let normalizedString = Prefixed_Name(xsd, "normalizedString") |> PrefixedName
    /// <summary>
    ///   <para>xsd:number</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#number">http://www.w3.org/2001/XMLSchema#number</seealso>
    let number = Prefixed_Name(xsd, "number") |> PrefixedName
    /// <summary>
    ///   <para>xsd:numeric</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#numeric">http://www.w3.org/2001/XMLSchema#numeric</seealso>
    let numeric = Prefixed_Name(xsd, "numeric") |> PrefixedName
    /// <summary>
    ///   <para>xsd:pattern</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#pattern">http://www.w3.org/2001/XMLSchema#pattern</seealso>
    let pattern = Prefixed_Name(xsd, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>xsd:positiveInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `positiveInteger` is _derived_ from `nonNegativeInteger` by setting the value
    ///      of `minInclusive` to be `1`. This results in the standard mathematical
    ///      concept of the positive integer numbers. The _value space_ of
    ///      `positiveInteger` is the infinite set `{1,2,...}`. The _base type_ of
    ///      `positiveInteger` is `nonNegativeInteger`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"positiveInteger"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:positiveInteger"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#positiveInteger">http://www.w3.org/2001/XMLSchema#positiveInteger</seealso>
    let positiveInteger = Prefixed_Name(xsd, "positiveInteger") |> PrefixedName
    /// <summary>
    ///   <para>xsd:short</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `short` is _derived_ from `int` by setting the value of `maxInclusive` to be
    ///     `32767` and `minInclusive` to be `-32768`. The _base type_ of `short` is `int`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"short"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#short">http://www.w3.org/2001/XMLSchema#short</seealso>
    let short = Prefixed_Name(xsd, "short") |> PrefixedName
    /// <summary>
    ///   <para>xsd:string</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     The `string` datatype represents character strings in XML.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xsd:string"</para><para>"string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"String"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#string">http://www.w3.org/2001/XMLSchema#string</seealso>
    let string = Prefixed_Name(xsd, "string") |> PrefixedName
    /// <summary>
    ///   <para>xsd:success</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"has input"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#success">http://www.w3.org/2001/XMLSchema#success</seealso>
    let success = Prefixed_Name(xsd, "success") |> PrefixedName
    /// <summary>
    ///   <para>xsd:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `time` represents instants of time that recur at the same point in each
    ///     calendar day, or that occur in some arbitrary calendar day.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"xsd:time"</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#time">http://www.w3.org/2001/XMLSchema#time</seealso>
    let time = Prefixed_Name(xsd, "time") |> PrefixedName
    /// <summary>
    ///   <para>xsd:token</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `token` represents tokenized strings. The _value space_ of `token` is the set
    ///      of strings that do not contain the carriage return (`#xD`), line feed (`#xA`)
    ///      nor tab (`#x9`) characters, that have no leading or trailing spaces (`#x20`)
    ///      and that have no internal sequences of two or more spaces. The _lexical
    ///      space_ of `token` is the set of strings that do not contain the carriage
    ///      return (`#xD`), line feed (`#xA`) nor tab (`#x9`) characters, that have no
    ///      leading or trailing spaces (`#x20`) and that have no internal sequences of
    ///      two or more spaces. The _base type_ of `token` is `normalizedString`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#token">http://www.w3.org/2001/XMLSchema#token</seealso>
    let token = Prefixed_Name(xsd, "token") |> PrefixedName
    /// <summary>
    ///   <para>xsd:unsignedByte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///       `unsignedByte` is _derived_ from `unsignedShort` by setting the value of
    ///       `maxInclusive` to be `255`. The _base type_ of `unsignedByte` is
    ///       `unsignedShort`.
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unsignedByte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#unsignedByte">http://www.w3.org/2001/XMLSchema#unsignedByte</seealso>
    let unsignedByte = Prefixed_Name(xsd, "unsignedByte") |> PrefixedName
    /// <summary>
    ///   <para>xsd:unsignedInt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///     `unsignedInt` is _derived_ from `unsignedLong` by setting the value of
    ///     `maxInclusive` to be `4294967295`. The _base type_ of `unsignedInt` is
    ///     `unsignedLong`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unsignedInt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#unsignedInt">http://www.w3.org/2001/XMLSchema#unsignedInt</seealso>
    let unsignedInt = Prefixed_Name(xsd, "unsignedInt") |> PrefixedName
    /// <summary>
    ///   <para>xsd:unsignedLong</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `unsignedLong` is _derived_ from `nonNegativeInteger` by setting the value of
    ///      `maxInclusive` to be `18446744073709551615`. The _base type_ of `unsignedLong`
    ///      is `nonNegativeInteger`.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unsignedLong"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#unsignedLong">http://www.w3.org/2001/XMLSchema#unsignedLong</seealso>
    let unsignedLong = Prefixed_Name(xsd, "unsignedLong") |> PrefixedName
    /// <summary>
    ///   <para>xsd:unsignedShort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///        `unsignedShort` is _derived_ from `unsignedInt` by setting the value of
    ///        `maxInclusive` to be `65535`. The _base type_ of `unsignedShort` is
    ///        `unsignedInt`.
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unsignedShort"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#unsignedShort">http://www.w3.org/2001/XMLSchema#unsignedShort</seealso>
    let unsignedShort = Prefixed_Name(xsd, "unsignedShort") |> PrefixedName
    /// <summary>
    ///   <para>xsd:yearMonthDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///      `yearMonthDuration` is a datatype _derived_ from `duration` by restricting its
    ///      _lexical representations_ to instances of `yearMonthDurationLexicalRep`. The
    ///      _value space_ of `yearMonthDuration` is therefore that of `duration`
    ///      restricted to those whose `seconds` property is `0`. This results in a
    ///      `duration` datatype which is totally ordered.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"yearMonthDuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2001/XMLSchema#yearMonthDuration">http://www.w3.org/2001/XMLSchema#yearMonthDuration</seealso>
    let yearMonthDuration = Prefixed_Name(xsd, "yearMonthDuration") |> PrefixedName
