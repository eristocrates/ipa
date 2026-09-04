#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cbs =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://betalinkeddata.cbs.nl/def/cbs#" "cbs"

    /// <summary>
    ///   <para>rdfs:label : Buurt</para>
    ///   <a href="http://betalinkeddata.cbs.nl/def/cbs#Buurt">cbs:Buurt</a>
    /// </summary>
    let Buurt = _prefixId.prefix "Buurt"
    /// <summary>
    ///   <para>rdfs:label : Gemeente (Geografisch)</para>
    ///   <a href="http://betalinkeddata.cbs.nl/def/cbs#Gemeente_Geografisch">cbs:Gemeente_Geografisch</a>
    /// </summary>
    let Gemeente_Geografisch = _prefixId.prefix "Gemeente_Geografisch"
    /// <summary>
    ///   <para>rdfs:label : Land (Geografisch)</para>
    ///   <a href="http://betalinkeddata.cbs.nl/def/cbs#Land_Geografisch">cbs:Land_Geografisch</a>
    /// </summary>
    let Land_Geografisch = _prefixId.prefix "Land_Geografisch"
    /// <summary>
    ///   <para>rdfs:label : Regio</para>
    ///   <a href="http://betalinkeddata.cbs.nl/def/cbs#Regio">cbs:Regio</a>
    /// </summary>
    let Regio = _prefixId.prefix "Regio"
    /// <summary>
    ///   <para>rdfs:label : Wijk</para>
    ///   <a href="http://betalinkeddata.cbs.nl/def/cbs#Wijk">cbs:Wijk</a>
    /// </summary>
    let Wijk = _prefixId.prefix "Wijk"
    /// <summary>
    ///   <para>rdfs:label : indelingswijziging</para>
    ///   <a href="http://betalinkeddata.cbs.nl/def/cbs#indelingswijziging">cbs:indelingswijziging</a>
    /// </summary>
    let indelingswijziging = _prefixId.prefix "indelingswijziging"
    /// <summary>
    ///   <para>rdfs:label : regiocode</para>
    ///   <a href="http://betalinkeddata.cbs.nl/def/cbs#regiocode">cbs:regiocode</a>
    /// </summary>
    let regiocode = _prefixId.prefix "regiocode"
