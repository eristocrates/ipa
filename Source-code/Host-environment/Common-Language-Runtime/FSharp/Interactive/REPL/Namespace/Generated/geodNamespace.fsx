#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module geod =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://vocab.lenka.no/geo-deling#" "geod"

    /// <summary>
    ///   <para>rdfs:label : Fylke^^xsd:string</para>
    ///   <para>rdfs:comment : Et fylke er et område som utgjør en førsteordens politisk og administrativ enhet.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#Fylke">geod:Fylke</a>
    /// </summary>
    let Fylke = _prefixId.prefix "Fylke"
    /// <summary>
    ///   <para>rdfs:label : Grunneiendom^^xsd:string</para>
    ///   <para>rdfs:comment : Grunneiendom er en geografisk del av landet som har et eget eierforhold.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#Grunneiendom">geod:Grunneiendom</a>
    /// </summary>
    let Grunneiendom = _prefixId.prefix "Grunneiendom"
    let ``Kjetil%20Kjernsmo`` = _prefixId.prefix "Kjetil%20Kjernsmo"
    /// <summary>
    ///   <para>rdfs:label : Kommune^^xsd:string</para>
    ///   <para>rdfs:comment : En kommune er et område som utgjør en andreordens politisk og administrativ enhet.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#Kommune">geod:Kommune</a>
    /// </summary>
    let Kommune = _prefixId.prefix "Kommune"
    /// <summary>
    ///   <para>rdfs:label : Kommunesenter^^xsd:string</para>
    ///   <para>rdfs:comment : Et kommunesenter er et sted som tjener som administrativt senter for en kommune.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#Kommunesenter">geod:Kommunesenter</a>
    /// </summary>
    let Kommunesenter = _prefixId.prefix "Kommunesenter"
    /// <summary>
    ///   <para>rdfs:label : Sted^^xsd:string</para>
    ///   <para>rdfs:comment : Et sted er et avgrenset område.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#Sted">geod:Sted</a>
    /// </summary>
    let Sted = _prefixId.prefix "Sted"
    let ``Universitetet%20i%20Oslo`` = _prefixId.prefix "Universitetet%20i%20Oslo"
    /// <summary>
    ///   <para>rdfs:label : Bruksnummer^^xsd:string</para>
    ///   <para>rdfs:comment : Et bruksnummer er en del av en enhet i det norske eiendomsregisteret, matrikkelen.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#bnr">geod:bnr</a>
    /// </summary>
    let bnr = _prefixId.prefix "bnr"
    /// <summary>
    ///   <para>rdfs:label : Eid av^^xsd:string</para>
    ///   <para>rdfs:comment : Indikerer at en grunneiendom er eid av en agent.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#eid-av">geod:eid-av</a>
    /// </summary>
    let eid_av = _prefixId.prefix "eid-av"
    /// <summary>
    ///   <para>rdfs:label : Eier^^xsd:string</para>
    ///   <para>rdfs:comment : Indikerer et eierforhold mellom en agent og en grunneiendom.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#eier">geod:eier</a>
    /// </summary>
    let eier = _prefixId.prefix "eier"
    /// <summary>
    ///   <para>rdfs:label : Festenummer^^xsd:string</para>
    ///   <para>rdfs:comment : Festenummeret er et nummer på et leid grunneiendom i matrikkelen.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#fnr">geod:fnr</a>
    /// </summary>
    let fnr = _prefixId.prefix "fnr"
    /// <summary>
    ///   <para>rdfs:label : Fylkenummer^^xsd:string</para>
    ///   <para>rdfs:comment : Fylkenummer er et tosifret nummer (eks.: 01) som er unikt for hvert fylke i Norge. ^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#fylkenr">geod:fylkenr</a>
    /// </summary>
    let fylkenr = _prefixId.prefix "fylkenr"
    /// <summary>
    ///   <para>rdfs:label : Gårdsnummer^^xsd:string</para>
    ///   <para>rdfs:comment : Gårdsnummer er nummeret på en gårdsenhet i matrikkelen og er unikt innenfor hver kommune. ^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#gnr">geod:gnr</a>
    /// </summary>
    let gnr = _prefixId.prefix "gnr"
    /// <summary>
    ///   <para>rdfs:label : Kommunenummer ^^xsd:string</para>
    ///   <para>rdfs:comment : Kommunenummer er et firesifret nummer (eks.: 0101) som er unikt for hver kommune i Norge. ^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#kommunenr">geod:kommunenr</a>
    /// </summary>
    let kommunenr = _prefixId.prefix "kommunenr"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : Senter^^xsd:string</para>
    ///   <para>rdfs:comment : For å linke en kommune med stedet som er kommunens senter.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#senter">geod:senter</a>
    /// </summary>
    let senter = _prefixId.prefix "senter"
    /// <summary>
    ///   <para>rdfs:label : Seksjonsnummer^^xsd:string</para>
    ///   <para>rdfs:comment : Et seksjonsnummer er et nummer i matrikkelen som benyttes der en eiendom består av flere selvstendige eierenheter som skal selges og pantsettes hver for seg.^^xsd:string</para>
    ///   <a href="http://vocab.lenka.no/geo-deling#snr">geod:snr</a>
    /// </summary>
    let snr = _prefixId.prefix "snr"
    let ttl = _prefixId.prefix "ttl"
