#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-cxtdsg`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/ContextualDesignators/" "cmns-cxtdsg"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : context^^xsd:string</para>
    ///   <para>dct:source : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09, clause 3.6.5^^xsd:stringdct:source : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15^^xsd:string</para>
    ///   <para>skos:definition : situation or frame of reference in which something applies, exists, happens, or is used and that helps to illustrate or explain it^^xsd:string</para>
    ///   <para>skos:note : From a terminology perspective, context provides information, including but not limited to text, that illustrates a concept or the use of a designation for a given situation.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/Context">cmns-cxtdsg:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : contextual designation^^xsd:string</para>
    ///   <para>skos:definition : designation that applies to something in some context^^xsd:string</para>
    ///   <para>skos:note : Contextual designators may be structured such that they include other designators, for example, composite identifiers that include a country code to distinguish national identifiers from one another, for example, in the case of some manufacturing, agricultural, or financial instrument identifiers.^^xsd:stringskos:note : Note that the use of the min 0 cardinality restriction in the definition of this class is provided as a reminder that contextual designators are expected, in most cases, to have some sort of context associated with them. There may be cases where the context is limited to a time period, though, and thus additional context may not be required, or where more direct relationships to provenance, governance, or other contextual information is available.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/ContextualDesignation">cmns-cxtdsg:ContextualDesignation</a>
    /// </summary>
    let ContextualDesignation = _prefixId.prefix "ContextualDesignation"
    /// <summary>
    ///   <para>rdfs:label : contextual name^^xsd:string</para>
    ///   <para>skos:definition : designation by which someone, some place, or something is known in some context^^xsd:string</para>
    ///   <para>skos:note : Names for people may be considered to be personally identifying information (PII), especially when other details are also available. Specifying names as string values attached directly to an individual makes name reconciliation and management, including from a privacy perspective, more challenging.^^xsd:stringskos:note : Names of people, places, and organizations often change over time, and may be used in a particular context, such as a DBA name for a business or legal name for a person.^^xsd:string</para>
    ///   <para>skos:scopeNote : This class is designed to be extended to include provenance details regarding the source for a particular name as well as links to the various contexts in which it is used.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/ContextualName">cmns-cxtdsg:ContextualName</a>
    /// </summary>
    let ContextualName = _prefixId.prefix "ContextualName"
    /// <summary>
    ///   <para>rdfs:label : applies to^^xsd:string</para>
    ///   <para>skos:definition : indicates something for which a context is material, germane, or relevant in some way^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/appliesTo">cmns-cxtdsg:appliesTo</a>
    /// </summary>
    let appliesTo = _prefixId.prefix "appliesTo"
    /// <summary>
    ///   <para>rdfs:label : has applicable period^^xsd:string</para>
    ///   <para>skos:definition : indicates a date period during which something may be used, applies, is valid or is accurate or relevant^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/hasApplicablePeriod">cmns-cxtdsg:hasApplicablePeriod</a>
    /// </summary>
    let hasApplicablePeriod = _prefixId.prefix "hasApplicablePeriod"
    /// <summary>
    ///   <para>rdfs:label : is applicable in^^xsd:string</para>
    ///   <para>skos:definition : indicates a context in which something is relevant^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/isApplicableIn">cmns-cxtdsg:isApplicableIn</a>
    /// </summary>
    let isApplicableIn = _prefixId.prefix "isApplicableIn"
    /// <summary>
    ///   <para>rdfs:label : is used by^^xsd:string</para>
    ///   <para>skos:definition : serves a function or purpose for^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/isUsedBy">cmns-cxtdsg:isUsedBy</a>
    /// </summary>
    let isUsedBy = _prefixId.prefix "isUsedBy"
    /// <summary>
    ///   <para>rdfs:label : uses^^xsd:string</para>
    ///   <para>skos:definition : employs to accomplish some task or achieve some result^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/ContextualDesignators/uses">cmns-cxtdsg:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
