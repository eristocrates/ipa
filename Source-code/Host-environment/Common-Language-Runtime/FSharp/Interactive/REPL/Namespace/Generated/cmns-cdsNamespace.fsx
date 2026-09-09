#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-cds`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/CodesAndCodeSets/" "cmns-cds"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : code element^^xsd:string</para>
    ///   <para>dct:source : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters denoting something for some purpose, within a specified context, according to some rule set^^xsd:string</para>
    ///   <para>skos:example : An example of a code set that has multiple versions are the International Statistical Classification of Diseases and Related Health Problems (ICD) codes such as ICD-9, ICD-10, and so forth, that specify the same codes across multiple versions.^^xsd:string</para>
    ///   <para>skos:note : Note that codes may be included in multiple code lists, especially in cases where there are multiple versions of those code lists. ICD-9 and ICD-10 are examples of code sets that specify, in some cases, the same codes, but across different versions of those code sets.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/CodesAndCodeSets/CodeElement">cmns-cds:CodeElement</a>
    /// </summary>
    let CodeElement = _prefixId.prefix "CodeElement"
    /// <summary>
    ///   <para>rdfs:label : code set^^xsd:string</para>
    ///   <para>dct:source : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15^^xsd:string</para>
    ///   <para>skos:definition : system of alpha-numeric symbols, or combinations of symbols, that stand for specified values in some context^^xsd:string</para>
    ///   <para>skos:note : Note that a given code set will typically include a finite and known list of codes. Code sets may also be versioned. ICD-9 and ICD-10 are examples of code sets that specify, in some cases, the same codes, but across different versions of those code sets.^^xsd:string</para>
    ///   <para>cmns-av:synonym : coding scheme^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/CodesAndCodeSets/CodeSet">cmns-cds:CodeSet</a>
    /// </summary>
    let CodeSet = _prefixId.prefix "CodeSet"
