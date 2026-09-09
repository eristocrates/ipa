#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-cxtid`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/ContextualIdentifiers/" "cmns-cxtid"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : contextual identification scheme^^xsd:string</para>
    ///   <para>skos:definition : identification scheme that applies within one or more contexts^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualIdentifiers/ContextualIdentificationScheme">cmns-cxtid:ContextualIdentificationScheme</a>
    /// </summary>
    let ContextualIdentificationScheme =
        _prefixId.prefix "ContextualIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : contextual identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying that with which it is associated, within a specified context^^xsd:string</para>
    ///   <para>skos:note : The context within which an identifier is unique may be limited to a given data source, registry or jurisdiction, or may be designed to be globally unique such as a legal entity identifier issued by a registrar authorized by the Global LEI Foundation. Such identifiers may have other features associated with them, such as the date they were originally issued, and information related to registration, validation, recency, and so forth.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualIdentifiers/ContextualIdentifier">cmns-cxtid:ContextualIdentifier</a>
    /// </summary>
    let ContextualIdentifier = _prefixId.prefix "ContextualIdentifier"
    /// <summary>
    ///   <para>rdfs:label : structured identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying that with which it is associated, that includes other codes or identifiers, or that is constructed from other notions^^xsd:string</para>
    ///   <para>skos:example : A vehicle identification number (VIN) includes a world-wide manufacturer identifier, a vehicle description (i.e., make, model), check digits, the year, plant and a specific vehicle number.^^xsd:stringskos:example : An international security identification number (ISIN) includes a country code and the national security identification number (NSIN), as defined in ISO 6166.^^xsd:string</para>
    ///   <para>skos:note : Many structured identifiers can be validated using a regular expression, such as a social security number in the United States.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualIdentifiers/StructuredIdentifier">cmns-cxtid:StructuredIdentifier</a>
    /// </summary>
    let StructuredIdentifier = _prefixId.prefix "StructuredIdentifier"
