#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-sps-sps`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/" "fibo-be-sps-sps"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : sole proprietor^^xsd:string</para>
    ///   <para>skos:definition : party that owns a business, has the rights to all profits from that business and is considered a single entity (unincorporated) together with that business for tax and liability purposes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A sole proprietor has unlimited liability with respect to any business debts.^^xsd:string</para>
    ///   <para>cmns-av:synonym : sole owner^^xsd:stringcmns-av:synonym : sole trader^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietor">fibo-be-sps-sps:SoleProprietor</a>
    /// </summary>
    let SoleProprietor = _prefixId.prefix "SoleProprietor"
    /// <summary>
    ///   <para>rdfs:label : sole proprietorship^^xsd:string</para>
    ///   <para>skos:definition : unincorporated business owned by a single person^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/SoleProprietorship">fibo-be-sps-sps:SoleProprietorship</a>
    /// </summary>
    let SoleProprietorship = _prefixId.prefix "SoleProprietorship"
