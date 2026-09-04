#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mdi =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/multidimensional-interface/ontology#" "mdi"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : RangeFragment</para>
    ///   <para>rdfs:comment : A Linked Data Fragment that has an interval as selector, which apply to dimensional resources at one of its n dimensions.</para>
    ///   <a href="https://w3id.org/multidimensional-interface/ontology#RangeFragment">mdi:RangeFragment</a>
    /// </summary>
    let RangeFragment = _prefixId.prefix "RangeFragment"
    /// <summary>
    ///   <para>rdfs:label : RangeGate</para>
    ///   <para>rdfs:comment : A Linked Data interface through which Range Fragments can be selected by interval. This interface selects all Range Fragments whose interval overlap with the Range Gate’s interval.</para>
    ///   <a href="https://w3id.org/multidimensional-interface/ontology#RangeGate">mdi:RangeGate</a>
    /// </summary>
    let RangeGate = _prefixId.prefix "RangeGate"
    /// <summary>
    ///   <para>rdfs:label : interval final</para>
    ///   <para>rdfs:comment : The upper bound of an interval, excluding this value.</para>
    ///   <a href="https://w3id.org/multidimensional-interface/ontology#final">mdi:final</a>
    /// </summary>
    let final = _prefixId.prefix "final"
    /// <summary>
    ///   <para>rdfs:label : has range gate</para>
    ///   <para>rdfs:comment : A link to the Range Gate of a Multidimensional Index of a datasource.</para>
    ///   <a href="https://w3id.org/multidimensional-interface/ontology#hasRangeGate">mdi:hasRangeGate</a>
    /// </summary>
    let hasRangeGate = _prefixId.prefix "hasRangeGate"
    /// <summary>
    ///   <para>rdfs:label : interval initial</para>
    ///   <para>rdfs:comment : The lower bound of an interval, including this value.</para>
    ///   <a href="https://w3id.org/multidimensional-interface/ontology#initial">mdi:initial</a>
    /// </summary>
    let initial = _prefixId.prefix "initial"
