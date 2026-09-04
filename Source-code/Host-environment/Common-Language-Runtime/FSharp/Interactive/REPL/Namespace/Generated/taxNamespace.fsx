#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tax =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/EUTaxO#" "tax"
    let ``_2.0.0`` = _prefixId.prefix "2.0.0"
    /// <summary>
    ///   <para>rdfs:label : Animalia^^xsd:string</para>
    ///   <para>rdfs:comment : Animalia kingdom^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#Animalia">tax:Animalia</a>
    /// </summary>
    let Animalia = _prefixId.prefix "Animalia"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.org/biodiversity/taxon/Taxon^^xsd:anyURI</para>
    ///   <para>rdfs:label : Taxon^^xsd:string</para>
    ///   <para>rdfs:comment : Base taxon class^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#Taxon">tax:Taxon</a>
    /// </summary>
    let Taxon = _prefixId.prefix "Taxon"
    /// <summary>
    ///   <para>rdfs:label : belongs to^^xsd:string</para>
    ///   <para>rdfs:comment : Defines a hierarchy from more generic taxa, to more specific ones^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#belongsTo">tax:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>rdfs:label : brackets^^xsd:string</para>
    ///   <para>rdfs:comment : Whether to use brackets for the correct nomenclature of a taxon^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#brackets">tax:brackets</a>
    /// </summary>
    let brackets = _prefixId.prefix "brackets"
    /// <summary>
    ///   <para>rdfs:label : id^^xsd:string</para>
    ///   <para>rdfs:comment : id from the EUdaphobase database^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#id">tax:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : kingdom^^xsd:string</para>
    ///   <para>rdfs:comment : The kingdom of a specific taxon^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#kingdom">tax:kingdom</a>
    /// </summary>
    let kingdom = _prefixId.prefix "kingdom"
    /// <summary>
    ///   <para>rdfs:label : phylum^^xsd:string</para>
    ///   <para>rdfs:comment : The phylum of a specific taxon^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#phylum">tax:phylum</a>
    /// </summary>
    let phylum = _prefixId.prefix "phylum"
    /// <summary>
    ///   <para>rdfs:label : synonym^^xsd:string</para>
    ///   <para>rdfs:comment : Relates if two taxon are synonyms^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#synonym">tax:synonym</a>
    /// </summary>
    let synonym = _prefixId.prefix "synonym"
    /// <summary>
    ///   <para>rdfs:label : synonyms exist^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not synonyms exists for a given taxon^^xsd:string</para>
    ///   <a href="https://w3id.org/EUTaxO#synonyms_exist">tax:synonyms_exist</a>
    /// </summary>
    let synonyms_exist = _prefixId.prefix "synonyms_exist"
