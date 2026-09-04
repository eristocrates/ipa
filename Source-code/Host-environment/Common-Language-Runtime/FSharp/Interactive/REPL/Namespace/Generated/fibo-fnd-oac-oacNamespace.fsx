#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-oac-oac`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/" "fibo-fnd-oac-oac"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ownership control situation^^xsd:string</para>
    ///   <para>skos:definition : situation in which some party owns and controls something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/OwnershipControlSituation">fibo-fnd-oac-oac:OwnershipControlSituation</a>
    /// </summary>
    let OwnershipControlSituation = _prefixId.prefix "OwnershipControlSituation"
    /// <summary>
    ///   <para>rdfs:label : is owned and controlled by^^xsd:string</para>
    ///   <para>skos:definition : relates something to the party that owns, influences, manages and directs it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/isOwnedAndControlledBy">fibo-fnd-oac-oac:isOwnedAndControlledBy</a>
    /// </summary>
    let isOwnedAndControlledBy = _prefixId.prefix "isOwnedAndControlledBy"
    /// <summary>
    ///   <para>rdfs:label : owns and controls^^xsd:string</para>
    ///   <para>skos:definition : directs and exercises authoritative or dominating influence over some thing that is also owned^^xsd:string</para>
    ///   <para>skos:editorialNote : basic rule: if x controls y and x owns y then x owns and controls y
    /// SWRL rule: controls(?x, ?y), owns(?x, ?y) -&gt; ownsAndControls(?x, ?y)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/ownsAndControls">fibo-fnd-oac-oac:ownsAndControls</a>
    /// </summary>
    let ownsAndControls = _prefixId.prefix "ownsAndControls"
