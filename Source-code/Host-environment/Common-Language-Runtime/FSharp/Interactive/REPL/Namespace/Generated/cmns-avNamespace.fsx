#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-av`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/AnnotationVocabulary/" "cmns-av"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : abbreviation^^xsd:string</para>
    ///   <para>skos:definition : designation formed by omitting parts from the full form of a term that denotes the same concept^^xsd:string</para>
    ///   <para>skos:example : Chemical Symbols: H, O, Mg; Units of Measure: Km, Kg, G^^xsd:string</para>
    ///   <para>skos:note : Abbreviations can be created by removing individual words, or can be acronyms, initialisms, or clipped terms.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09^^xsd:stringcmns-av:adaptedFrom : ISO 31-0 Quantities and units - General principles^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The symbols for quantities are generally single letters of the Latin or Greek alphabet, sometimes with subscripts or other modifying signs. These letters, including those that are members of the Greek alphabet are not symbols for the purposes of this ontology, however, they are abbreviations. Expressions of chemical formulae may, however, include a combination of abbreviations and symbols, as needed to define a given quantity.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that any SPARQL or other query using entailment for the rdfs:label on any construct will return not only the rdfs:label but all labels that are specified using subproperties of rdfs:label, such as abbreviation.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/abbreviation">cmns-av:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>rdfs:label : acronym^^xsd:string</para>
    ///   <para>skos:definition : abbreviation that is made up of the initial letters of the components of the full form of a term or proper name or from syllables of the full form^^xsd:string</para>
    ///   <para>skos:example : Examples of acronyms are: laser, ISO, GATT, UNESCO, UNICEF^^xsd:string</para>
    ///   <para>skos:note : Acronyms are frequently pronounced syllabically. It may be useful to use this property for generation of acronym lists.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that any SPARQL or other query using entailment for the rdfs:label on any construct will return not only the rdfs:label but all labels that are specified using subproperties of rdfs:label, such as acronym.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/acronym">cmns-av:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>rdfs:label : adapted from^^xsd:string</para>
    ///   <para>skos:definition : document or other source from which a given term (or its definition) was adapted (i.e., is compatible with but not quoted); the range for this annotation can be a string, URI, or citation^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This annotation should be used to indicate that a reference was used, for example, as input to the development of a definition or term but would not be considered infringing on a copyright.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/adaptedFrom">cmns-av:adaptedFrom</a>
    /// </summary>
    let adaptedFrom = _prefixId.prefix "adaptedFrom"
    /// <summary>
    ///   <para>rdfs:label : copyright^^xsd:string</para>
    ///   <para>skos:definition : exclusive legal right, given to an originator or an assignee to print, publish, perform, film, or record literary, artistic, or musical material, and to authorize others to do the same^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This annotation is typically used to describe an artifact such as a controlled vocabulary, ontology, or other similar resource.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/copyright">cmns-av:copyright</a>
    /// </summary>
    let copyright = _prefixId.prefix "copyright"
    /// <summary>
    ///   <para>rdfs:label : direct source^^xsd:string</para>
    ///   <para>skos:definition : quoted reference for the subject resource; the range for this annotation can be a string, URI, or bibliographic citation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/directSource">cmns-av:directSource</a>
    /// </summary>
    let directSource = _prefixId.prefix "directSource"
    /// <summary>
    ///   <para>rdfs:label : explanatory note^^xsd:string</para>
    ///   <para>skos:definition : note that provides additional explanatory material for a resource^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/explanatoryNote">cmns-av:explanatoryNote</a>
    /// </summary>
    let explanatoryNote = _prefixId.prefix "explanatoryNote"
    /// <summary>
    ///   <para>rdfs:label : logical definition^^xsd:string</para>
    ///   <para>skos:definition : definition in the form of a formal expression, such as the mathematical or logic representation, for the resource^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/logicalDefinition">cmns-av:logicalDefinition</a>
    /// </summary>
    let logicalDefinition = _prefixId.prefix "logicalDefinition"
    /// <summary>
    ///   <para>rdfs:label : symbol^^xsd:string</para>
    ///   <para>skos:definition : abbreviation that is a design or mark, or other non-alpha-numeric character(s) conventionally used to represent something, such as a currency or mathematical sign or operator^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that any SPARQL or other query using entailment for the rdfs:label on any construct will return not only the rdfs:label but all labels that are specified using subproperties of rdfs:label, such as symbol.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/symbol">cmns-av:symbol</a>
    /// </summary>
    let symbol = _prefixId.prefix "symbol"
    /// <summary>
    ///   <para>rdfs:label : synonym^^xsd:string</para>
    ///   <para>skos:definition : designation that can be substituted for the primary representation of something^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that any SPARQL or other query using entailment for the rdfs:label on any construct will return not only the rdfs:label but all labels that are specified using subproperties of rdfs:label, such as synonym.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/synonym">cmns-av:synonym</a>
    /// </summary>
    let synonym = _prefixId.prefix "synonym"
    /// <summary>
    ///   <para>rdfs:label : usage note^^xsd:string</para>
    ///   <para>skos:definition : note that provides information about how a given resource is used or may be extended^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/AnnotationVocabulary/usageNote">cmns-av:usageNote</a>
    /// </summary>
    let usageNote = _prefixId.prefix "usageNote"
