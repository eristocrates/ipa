#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module brk =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://brk.basisregistraties.overheid.nl/def/brk#" "brk"

    /// <summary>
    ///   <para>rdfs:label : KadastraleGrens^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#KadastraleGrens">brk:KadastraleGrens</a>
    /// </summary>
    let KadastraleGrens = _prefixId.prefix "KadastraleGrens"
    /// <summary>
    ///   <para>rdfs:label : Perceel^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#Perceel">brk:Perceel</a>
    /// </summary>
    let Perceel = _prefixId.prefix "Perceel"
    /// <summary>
    ///   <para>rdfs:label : begrenzingPerceel^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#begrenzingPerceel">brk:begrenzingPerceel</a>
    /// </summary>
    let begrenzingPerceel = _prefixId.prefix "begrenzingPerceel"
    /// <summary>
    ///   <para>rdfs:label : grenslijn^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#grenslijn">brk:grenslijn</a>
    /// </summary>
    let grenslijn = _prefixId.prefix "grenslijn"
    /// <summary>
    ///   <para>rdfs:label : kadastraleGemeente^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGemeente">brk:kadastraleGemeente</a>
    /// </summary>
    let kadastraleGemeente = _prefixId.prefix "kadastraleGemeente"
    /// <summary>
    ///   <para>rdfs:label : kadastraleGrootte^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#kadastraleGrootte">brk:kadastraleGrootte</a>
    /// </summary>
    let kadastraleGrootte = _prefixId.prefix "kadastraleGrootte"
    /// <summary>
    ///   <para>rdfs:label : perceelnummer^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummer">brk:perceelnummer</a>
    /// </summary>
    let perceelnummer = _prefixId.prefix "perceelnummer"
    /// <summary>
    ///   <para>rdfs:label : perceelnummerRotatie^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#perceelnummerRotatie">brk:perceelnummerRotatie</a>
    /// </summary>
    let perceelnummerRotatie = _prefixId.prefix "perceelnummerRotatie"
    /// <summary>
    ///   <para>rdfs:label : plaatscoordinaten^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#plaatscoordinaten">brk:plaatscoordinaten</a>
    /// </summary>
    let plaatscoordinaten = _prefixId.prefix "plaatscoordinaten"
    /// <summary>
    ///   <para>rdfs:label : sectie^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#sectie">brk:sectie</a>
    /// </summary>
    let sectie = _prefixId.prefix "sectie"
    /// <summary>
    ///   <para>rdfs:label : soortGrootte^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#soortGrootte">brk:soortGrootte</a>
    /// </summary>
    let soortGrootte = _prefixId.prefix "soortGrootte"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <a href="http://brk.basisregistraties.overheid.nl/def/brk#typeGrens">brk:typeGrens</a>
    /// </summary>
    let typeGrens = _prefixId.prefix "typeGrens"
