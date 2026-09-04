#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-loan-spc-com`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/" "fibo-loan-spc-com"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : commercial loan</para>
    ///   <para>skos:definition : loan extended to a corporation, commercial enterprise, joint venture, or other organization as opposed to a consumer</para>
    ///   <para>cmns-av:explanatoryNote : Such loans may include those that provide working capital, are used to finance the purchase of equipment and/or materials, for facilities and/or improvement of facilities, and so forth, and are typically secured.</para>
    ///   <para>cmns-av:synonym : commercial and industrial loan</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/CommercialLoan">fibo-loan-spc-com:CommercialLoan</a>
    /// </summary>
    let CommercialLoan = _prefixId.prefix "CommercialLoan"
    /// <summary>
    ///   <para>rdfs:label : has business purpose description^^xsd:string</para>
    ///   <para>skos:definition : provides a description of the purpose of the loan from the perspective of the borrower^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/hasBusinessPurposeDescription">fibo-loan-spc-com:hasBusinessPurposeDescription</a>
    /// </summary>
    let hasBusinessPurposeDescription = _prefixId.prefix "hasBusinessPurposeDescription"
