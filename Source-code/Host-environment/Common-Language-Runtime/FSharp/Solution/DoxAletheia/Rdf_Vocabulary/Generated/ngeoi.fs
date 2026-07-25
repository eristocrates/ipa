namespace http.vocab.lenka.no.geo_deling.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ngeoi =
    let _namespace_iri = Namespace_Iri ngeoi |> NamespaceIRI
    /// <summary>
    ///   <para>ngeoi:Fylke</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Et fylke er et område som utgjør en førsteordens politisk og administrativ enhet.</para>
    /// labels<para>Fylke</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#Fylke">http://vocab.lenka.no/geo-deling#Fylke</seealso>
    let Fylke = Prefixed_Name(ngeoi, "Fylke") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:Grunneiendom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Grunneiendom er en geografisk del av landet som har et eget eierforhold.</para>
    /// labels<para>Grunneiendom</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#Grunneiendom">http://vocab.lenka.no/geo-deling#Grunneiendom</seealso>
    let Grunneiendom = Prefixed_Name(ngeoi, "Grunneiendom") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:Kommune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>En kommune er et område som utgjør en andreordens politisk og administrativ enhet.</para>
    /// labels<para>Kommune</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#Kommune">http://vocab.lenka.no/geo-deling#Kommune</seealso>
    let Kommune = Prefixed_Name(ngeoi, "Kommune") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:Sted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Et sted er et avgrenset område.</para>
    /// labels<para>Sted</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#Sted">http://vocab.lenka.no/geo-deling#Sted</seealso>
    let Sted = Prefixed_Name(ngeoi, "Sted") |> PrefixedName

    /// <summary>
    ///   <para>ngeoi:Universitetet%20i%20Oslo</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#Universitetet%20i%20Oslo">http://vocab.lenka.no/geo-deling#Universitetet%20i%20Oslo</seealso>
    let ``Universitetet%20i%20Oslo`` =
        Prefixed_Name(ngeoi, "Universitetet%20i%20Oslo") |> PrefixedName

    /// <summary>
    ///   <para>ngeoi:eid-av</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indikerer at en grunneiendom er eid av en agent.</para>
    /// labels<para>Eid av</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#eid-av">http://vocab.lenka.no/geo-deling#eid-av</seealso>
    let eid_av = Prefixed_Name(ngeoi, "eid-av") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:eier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indikerer et eierforhold mellom en agent og en grunneiendom.</para>
    /// labels<para>Eier</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#eier">http://vocab.lenka.no/geo-deling#eier</seealso>
    let eier = Prefixed_Name(ngeoi, "eier") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:fylkenr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Fylkenummer er et tosifret nummer (eks.: 01) som er unikt for hvert fylke i Norge. </para>
    /// labels<para>Fylkenummer</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#fylkenr">http://vocab.lenka.no/geo-deling#fylkenr</seealso>
    let fylkenr = Prefixed_Name(ngeoi, "fylkenr") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:fnr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Festenummeret er et nummer på et leid grunneiendom i matrikkelen.</para>
    /// labels<para>Festenummer</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#fnr">http://vocab.lenka.no/geo-deling#fnr</seealso>
    let fnr = Prefixed_Name(ngeoi, "fnr") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:Kommunesenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Et kommunesenter er et sted som tjener som administrativt senter for en kommune.</para>
    /// labels<para>Kommunesenter</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#Kommunesenter">http://vocab.lenka.no/geo-deling#Kommunesenter</seealso>
    let Kommunesenter = Prefixed_Name(ngeoi, "Kommunesenter") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:bnr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Et bruksnummer er en del av en enhet i det norske eiendomsregisteret, matrikkelen.</para>
    /// labels<para>Bruksnummer</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#bnr">http://vocab.lenka.no/geo-deling#bnr</seealso>
    let bnr = Prefixed_Name(ngeoi, "bnr") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:gnr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Gårdsnummer er nummeret på en gårdsenhet i matrikkelen og er unikt innenfor hver kommune. </para>
    /// labels<para>Gårdsnummer</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#gnr">http://vocab.lenka.no/geo-deling#gnr</seealso>
    let gnr = Prefixed_Name(ngeoi, "gnr") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:kommunenr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Kommunenummer er et firesifret nummer (eks.: 0101) som er unikt for hver kommune i Norge. </para>
    /// labels<para>Kommunenummer </para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#kommunenr">http://vocab.lenka.no/geo-deling#kommunenr</seealso>
    let kommunenr = Prefixed_Name(ngeoi, "kommunenr") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:snr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Et seksjonsnummer er et nummer i matrikkelen som benyttes der en eiendom består av flere selvstendige eierenheter som skal selges og pantsettes hver for seg.</para>
    /// labels<para>Seksjonsnummer</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#snr">http://vocab.lenka.no/geo-deling#snr</seealso>
    let snr = Prefixed_Name(ngeoi, "snr") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#rdf">http://vocab.lenka.no/geo-deling#rdf</seealso>
    let rdf = Prefixed_Name(ngeoi, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:senter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For å linke en kommune med stedet som er kommunens senter.</para>
    /// labels<para>Senter</para></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#senter">http://vocab.lenka.no/geo-deling#senter</seealso>
    let senter = Prefixed_Name(ngeoi, "senter") |> PrefixedName
    /// <summary>
    ///   <para>ngeoi:ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#ttl">http://vocab.lenka.no/geo-deling#ttl</seealso>
    let ttl = Prefixed_Name(ngeoi, "ttl") |> PrefixedName

    /// <summary>
    ///   <para>ngeoi:Kjetil%20Kjernsmo</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.lenka.no/geo-deling#Kjetil%20Kjernsmo">http://vocab.lenka.no/geo-deling#Kjetil%20Kjernsmo</seealso>
    let ``Kjetil%20Kjernsmo`` =
        Prefixed_Name(ngeoi, "Kjetil%20Kjernsmo") |> PrefixedName
