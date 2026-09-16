#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module env =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/environment#" "env"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : community environment</para>
    ///   <para>skos:definition : Environment of a community of any kind.</para>
    ///   <para>rdfs:comment : E.g. the human colon as an environment for bacteria.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/environment#CommunityEnvironment">env:CommunityEnvironment</a>
    /// </summary>
    let CommunityEnvironment = _prefixId.prefix "CommunityEnvironment"
    /// <summary>
    ///   <para>rdfs:label : environment</para>
    ///   <para>skos:definition : Surroundings as aggregate of things, conditions, and influences.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/environment#Environment">env:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>rdfs:label : home</para>
    ///   <para>skos:definition : human principal residence</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/environment#Home">env:Home</a>
    /// </summary>
    let Home = _prefixId.prefix "Home"
    /// <summary>
    ///   <para>rdfs:label : human community environment</para>
    ///   <para>skos:definition : Man-made surroundings that provide the setting for human activity, ranging from the large-scale civic surroundings to the personal places.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/environment#HumanCommunityEnvironment">env:HumanCommunityEnvironment</a>
    /// </summary>
    let HumanCommunityEnvironment = _prefixId.prefix "HumanCommunityEnvironment"
    /// <summary>
    ///   <para>skos:definition : Specifying something contained by an environment.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/environment#environmentOf">env:environmentOf</a>
    /// </summary>
    let environmentOf = _prefixId.prefix "environmentOf"
    /// <summary>
    ///   <para>skos:definition : Specifying an environment containing something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/environment#hasEnvironment">env:hasEnvironment</a>
    /// </summary>
    let hasEnvironment = _prefixId.prefix "hasEnvironment"
