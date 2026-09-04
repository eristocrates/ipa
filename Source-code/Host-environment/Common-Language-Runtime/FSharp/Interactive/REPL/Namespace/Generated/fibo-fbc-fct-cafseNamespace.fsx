#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-cafse`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/" "fibo-fbc-fct-cafse"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Canadian credit union^^xsd:string</para>
    ///   <para>skos:definition : not-for-profit financial institution, typically formed by the employees of a company, labor union, or religious group, operated as a cooperative association organized for the purpose of promoting thrift among its members and creating a source of credit for provident or productive purposes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/CanadianCreditUnion">fibo-fbc-fct-cafse:CanadianCreditUnion</a>
    /// </summary>
    let CanadianCreditUnion = _prefixId.prefix "CanadianCreditUnion"
