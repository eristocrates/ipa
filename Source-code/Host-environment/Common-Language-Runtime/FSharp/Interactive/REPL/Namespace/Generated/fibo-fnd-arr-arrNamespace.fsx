#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-arr`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/" "fibo-fnd-arr-arr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : scheme^^xsd:string</para>
    ///   <para>skos:definition : structure or means of organizing information such as a blueprint, schema, numbering system, organization structure, measurement system, plan, taxonomy, or language for organizing information^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/Scheme">fibo-fnd-arr-arr:Scheme</a>
    /// </summary>
    let Scheme = _prefixId.prefix "Scheme"
    /// <summary>
    ///   <para>rdfs:label : has collection size^^xsd:string</para>
    ///   <para>skos:definition : indicates the number of elements in a given collection^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/hasCollectionSize">fibo-fnd-arr-arr:hasCollectionSize</a>
    /// </summary>
    let hasCollectionSize = _prefixId.prefix "hasCollectionSize"
