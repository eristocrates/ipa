#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-utl-av`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/" "fibo-fnd-utl-av"

    let _namespaceIri = _prefixId.prefix ""
    let Informative = _prefixId.prefix "Informative"
    /// <summary>
    ///   <para>rdfs:label : maturity level^^xsd:string</para>
    ///   <para>skos:definition : classifier used to indicate the state of an artifact with respect to its development lifecycle^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : FIBO currently has three maturity levels: Informative, Provisional, and Release.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/MaturityLevel">fibo-fnd-utl-av:MaturityLevel</a>
    /// </summary>
    let MaturityLevel = _prefixId.prefix "MaturityLevel"
    /// <summary>
    ///   <para>rdfs:label : module^^xsd:string</para>
    ///   <para>skos:definition : classifier used to indicate a category used to modularize something based on principles of the model driven architecture methodology (MDA), including but not limited to separation of concerns, coherence, and establishing clear logical boundaries in order to increase reusability and maintainability^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A module should be designed to reflect these principles, including a small number of models that have well-defined relationships with one another, that form a coherent and cohesive whole for some purpose, and that have clear boundaries or interfaces to other modules.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Module">fibo-fnd-utl-av:Module</a>
    /// </summary>
    let Module = _prefixId.prefix "Module"
    let Provisional = _prefixId.prefix "Provisional"
    let Release = _prefixId.prefix "Release"
    /// <summary>
    ///   <para>rdfs:label : common designation^^xsd:string</para>
    ///   <para>skos:definition : frequently used designation for an entity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://pe.usps.com/cpim/ftp/pubs/Pub28/pub28.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/commonDesignation">fibo-fnd-utl-av:commonDesignation</a>
    /// </summary>
    let commonDesignation = _prefixId.prefix "commonDesignation"
    /// <summary>
    ///   <para>rdfs:label : definition origin^^xsd:string</para>
    ///   <para>skos:definition : document or other source from which a given definition was taken directly; the range for this annotation can be a string, URI, or BibliographicCitation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/definitionOrigin">fibo-fnd-utl-av:definitionOrigin</a>
    /// </summary>
    let definitionOrigin = _prefixId.prefix "definitionOrigin"
    /// <summary>
    ///   <para>rdfs:label : has maturity level^^xsd:string</para>
    ///   <para>skos:definition : links something to its state with respect to a development lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/hasMaturityLevel">fibo-fnd-utl-av:hasMaturityLevel</a>
    /// </summary>
    let hasMaturityLevel = _prefixId.prefix "hasMaturityLevel"
    /// <summary>
    ///   <para>rdfs:label : preferred designation^^xsd:string</para>
    ///   <para>skos:definition : recommended designation for an entity in some context^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://pe.usps.com/cpim/ftp/pubs/Pub28/pub28.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/preferredDesignation">fibo-fnd-utl-av:preferredDesignation</a>
    /// </summary>
    let preferredDesignation = _prefixId.prefix "preferredDesignation"
    /// <summary>
    ///   <para>rdfs:label : term origin^^xsd:string</para>
    ///   <para>skos:definition : document or other source from which a given term was taken directly; the range for this annotation can be a string, URI, or BibliographicCitation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/termOrigin">fibo-fnd-utl-av:termOrigin</a>
    /// </summary>
    let termOrigin = _prefixId.prefix "termOrigin"
