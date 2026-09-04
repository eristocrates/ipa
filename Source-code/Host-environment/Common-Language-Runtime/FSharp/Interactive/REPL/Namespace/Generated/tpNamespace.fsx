#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://tour-pedia.org/download/tp.owl#" "tp"

    let Accommodation = _prefixId.prefix "Accommodation"
    let Attraction = _prefixId.prefix "Attraction"
    let POI = _prefixId.prefix "POI"
    /// <summary>
    ///   <para>rdfs:comment : The generic class for a touristic place.^^xsd:string</para>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <a href="http://tour-pedia.org/download/tp.owl#Place">tp:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    let Restaurant = _prefixId.prefix "Restaurant"
