#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module care =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/care#" "care"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : caring</para>
    ///   <para>skos:definition : Caring for a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/care#Caring">care:Caring</a>
    /// </summary>
    let Caring = _prefixId.prefix "Caring"
    /// <summary>
    ///   <para>rdfs:label : home for the elderly</para>
    ///   <para>skos:definition : Environment wherein elderly are cared for.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/care#ElderlyHome">care:ElderlyHome</a>
    /// </summary>
    let ElderlyHome = _prefixId.prefix "ElderlyHome"
    /// <summary>
    ///   <para>rdfs:label : care environment</para>
    ///   <para>skos:definition : Environment wherein a human is cared for.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/care#Environment">care:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>skos:definition : Specifying a human a person cares for.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/care#caresFor">care:caresFor</a>
    /// </summary>
    let caresFor = _prefixId.prefix "caresFor"
