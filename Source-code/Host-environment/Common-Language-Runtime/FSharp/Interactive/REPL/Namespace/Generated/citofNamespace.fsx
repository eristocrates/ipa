#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module citof =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2013/03/cito-functions/" "citof"

    /// <summary>
    ///   <para>rdfs:comment : A class defining the set of citation types having a particular function.</para>
    ///   <para>rdfs:label : citation function</para>
    ///   <a href="http://www.essepuntato.it/2013/03/cito-functions/CitationFunction">citof:CitationFunction</a>
    /// </summary>
    let CitationFunction = _prefixId.prefix "CitationFunction"
    /// <summary>
    ///   <para>rdfs:comment : A class defining the set of citation types having a factual function.</para>
    ///   <para>rdfs:label : factual function</para>
    ///   <a href="http://www.essepuntato.it/2013/03/cito-functions/FactualFunction">citof:FactualFunction</a>
    /// </summary>
    let FactualFunction = _prefixId.prefix "FactualFunction"
    /// <summary>
    ///   <para>rdfs:comment : A class defining the set of citation types having a negative rhetorical function.</para>
    ///   <para>rdfs:label : negative rhetorical function</para>
    ///   <a href="http://www.essepuntato.it/2013/03/cito-functions/NegativeRhetoricalFunction">citof:NegativeRhetoricalFunction</a>
    /// </summary>
    let NegativeRhetoricalFunction = _prefixId.prefix "NegativeRhetoricalFunction"
    /// <summary>
    ///   <para>rdfs:comment : A class defining the set of citation types having a neutral rhetorical function.</para>
    ///   <para>rdfs:label : neutral rhetorical function</para>
    ///   <a href="http://www.essepuntato.it/2013/03/cito-functions/NeutralRhetoricalFunction">citof:NeutralRhetoricalFunction</a>
    /// </summary>
    let NeutralRhetoricalFunction = _prefixId.prefix "NeutralRhetoricalFunction"
    /// <summary>
    ///   <para>rdfs:comment : A class defining the set of citation types having a positive rhetorical function.</para>
    ///   <para>rdfs:label : positive rhetorical function</para>
    ///   <a href="http://www.essepuntato.it/2013/03/cito-functions/PositiveRhetoricalFunction">citof:PositiveRhetoricalFunction</a>
    /// </summary>
    let PositiveRhetoricalFunction = _prefixId.prefix "PositiveRhetoricalFunction"
    /// <summary>
    ///   <para>rdfs:comment : A class defining the set of citation types having a particular rhetorical function.</para>
    ///   <para>rdfs:label : rhetorical function</para>
    ///   <a href="http://www.essepuntato.it/2013/03/cito-functions/RhetoricalFunction">citof:RhetoricalFunction</a>
    /// </summary>
    let RhetoricalFunction = _prefixId.prefix "RhetoricalFunction"
