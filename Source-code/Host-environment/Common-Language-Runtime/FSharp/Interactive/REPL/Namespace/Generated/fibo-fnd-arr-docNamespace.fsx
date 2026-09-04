#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-doc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/" "fibo-fnd-arr-doc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : financial record^^xsd:string</para>
    ///   <para>skos:definition : record of financial information^^xsd:string</para>
    ///   <para>skos:example : Financial records include accounts, agreements, trading books, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/FinancialRecord">fibo-fnd-arr-doc:FinancialRecord</a>
    /// </summary>
    let FinancialRecord = _prefixId.prefix "FinancialRecord"
    /// <summary>
    ///   <para>rdfs:label : has expiration date^^xsd:string</para>
    ///   <para>skos:definition : links something, typically an agreement, contract, document, or perishable item, with an expiration date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasExpirationDate">fibo-fnd-arr-doc:hasExpirationDate</a>
    /// </summary>
    let hasExpirationDate = _prefixId.prefix "hasExpirationDate"
    /// <summary>
    ///   <para>rdfs:label : has record^^xsd:string</para>
    ///   <para>skos:definition : links something to a record that pertains to it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasRecord">fibo-fnd-arr-doc:hasRecord</a>
    /// </summary>
    let hasRecord = _prefixId.prefix "hasRecord"
    /// <summary>
    ///   <para>rdfs:label : has reporting period^^xsd:string</para>
    ///   <para>skos:definition : specifies the reporting period for which a report or something else, such as a market rate or economic indicator, applies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasReportingPeriod">fibo-fnd-arr-doc:hasReportingPeriod</a>
    /// </summary>
    let hasReportingPeriod = _prefixId.prefix "hasReportingPeriod"
    /// <summary>
    ///   <para>rdfs:label : has termination date^^xsd:string</para>
    ///   <para>skos:definition : links something, typically an agreement, contract, document, or process, with a date on which it is scheduled to be or was terminated^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasTerminationDate">fibo-fnd-arr-doc:hasTerminationDate</a>
    /// </summary>
    let hasTerminationDate = _prefixId.prefix "hasTerminationDate"
