#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-cls`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/" "fibo-fnd-arr-cls"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : industry sector classification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating classifiers to organizations by industry sector^^xsd:string</para>
    ///   <para>skos:example : Examples include the North American Industry Classification System (NAICS) and Standardized Industry Classification (SIC) in the U.S. and Canada, and the NACE (Nomenclature Générale des Activités Économiques dans les Communautés Européennes) in the EU, developed by governments to classify industries. They also include commercial classification schemes, such as the Global Industry Standard Classification (GICS) developed jointly by Morgan Stanley Capital International (MSCI) and Standard and Poor's, and competing schemes including the Industry Classification Benchmark (ICB) system, maintained by Dow Jones and London's FTSE Group, among others.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassificationScheme">fibo-fnd-arr-cls:IndustrySectorClassificationScheme</a>
    /// </summary>
    let IndustrySectorClassificationScheme =
        _prefixId.prefix "IndustrySectorClassificationScheme"

    /// <summary>
    ///   <para>rdfs:label : industry sector classifier^^xsd:string</para>
    ///   <para>skos:definition : standardized classification or delineation for an organization, or possibly for a security representing an interest in a given organization, per some scheme for such delineation, by industry^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassifier">fibo-fnd-arr-cls:IndustrySectorClassifier</a>
    /// </summary>
    let IndustrySectorClassifier = _prefixId.prefix "IndustrySectorClassifier"
