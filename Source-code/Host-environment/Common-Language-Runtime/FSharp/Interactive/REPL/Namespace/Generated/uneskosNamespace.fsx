#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module uneskos =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/umu/uneskos#" "uneskos"
    /// <summary>
    ///   <para>skos:definition : Relates a concept scheme with any resource.</para>
    ///   <para>rdfs:label : contains element</para>
    ///   <a href="http://purl.org/umu/uneskos#contains">uneskos:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>skos:definition : Identifies access point concepts into a skos:Collection.</para>
    ///   <para>rdfs:label : has main concept</para>
    ///   <a href="http://purl.org/umu/uneskos#hasMainConcept">uneskos:hasMainConcept</a>
    /// </summary>
    let hasMainConcept = _prefixId.prefix "hasMainConcept"
    /// <summary>
    ///   <para>skos:definition : Relates a Concept Scheme with a ConceptGroup.</para>
    ///   <para>rdfs:label : has Microthesaurus</para>
    ///   <a href="http://purl.org/umu/uneskos#hasMicroThesaurus">uneskos:hasMicroThesaurus</a>
    /// </summary>
    let hasMicroThesaurus = _prefixId.prefix "hasMicroThesaurus"
    /// <summary>
    ///   <para>skos:definition : Relates a concept to a Collection as a access point.</para>
    ///   <para>rdfs:label : is main concept in Collection</para>
    ///   <a href="http://purl.org/umu/uneskos#mainConceptOf">uneskos:mainConceptOf</a>
    /// </summary>
    let mainConceptOf = _prefixId.prefix "mainConceptOf"
    /// <summary>
    ///   <para>skos:definition : Identifies a concept collection.</para>
    ///   <para>rdfs:label : member of</para>
    ///   <a href="http://purl.org/umu/uneskos#memberOf">uneskos:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
