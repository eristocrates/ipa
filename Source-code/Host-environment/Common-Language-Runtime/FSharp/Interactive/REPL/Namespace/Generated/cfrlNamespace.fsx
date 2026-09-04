#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cfrl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#" "cfrl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : This property links a Company with a Loan instance.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasLoan">cfrl:hasLoan</a>
    /// </summary>
    let hasLoan = _prefixId.prefix "hasLoan"
    /// <summary>
    ///   <para>rdfs:comment : This property links a Company with a Financial Report instance.^^xsd:string</para>
    ///   <a href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasReport">cfrl:hasReport</a>
    /// </summary>
    let hasReport = _prefixId.prefix "hasReport"
