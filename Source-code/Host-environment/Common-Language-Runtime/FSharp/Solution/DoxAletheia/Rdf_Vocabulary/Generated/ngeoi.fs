namespace http.vocab.lenka.no.geo_deling.hash

open DoxAletheia.Rdf_Vocabulary

module ngeoi =
    let _namespace_name = "http://vocab.lenka.no/geo-deling#"

    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#Kjetil%20Kjernsmo"></see>
    /// </summary>
    let ``Kjetil%20Kjernsmo`` =
        Namespaced_IRI.parse _namespace_name "Kjetil%20Kjernsmo" |> NamespacedName

    /// <summary>
    /// Et fylke er et område som utgjør en førsteordens politisk og administrativ enhet.
    /// <see href="http://vocab.lenka.no/geo-deling#Fylke"></see></summary>
    let Fylke = Namespaced_IRI.parse _namespace_name "Fylke" |> NamespacedName

    /// <summary>
    /// Grunneiendom er en geografisk del av landet som har et eget eierforhold.
    /// <see href="http://vocab.lenka.no/geo-deling#Grunneiendom"></see></summary>
    let Grunneiendom =
        Namespaced_IRI.parse _namespace_name "Grunneiendom" |> NamespacedName

    /// <summary>
    /// En kommune er et område som utgjør en andreordens politisk og administrativ enhet.
    /// <see href="http://vocab.lenka.no/geo-deling#Kommune"></see></summary>
    let Kommune = Namespaced_IRI.parse _namespace_name "Kommune" |> NamespacedName

    /// <summary>
    /// Et kommunesenter er et sted som tjener som administrativt senter for en kommune.
    /// <see href="http://vocab.lenka.no/geo-deling#Kommunesenter"></see></summary>
    let Kommunesenter =
        Namespaced_IRI.parse _namespace_name "Kommunesenter" |> NamespacedName

    /// <summary>
    /// Et sted er et avgrenset område.
    /// <see href="http://vocab.lenka.no/geo-deling#Sted"></see></summary>
    let Sted = Namespaced_IRI.parse _namespace_name "Sted" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#Universitetet%20i%20Oslo"></see>
    /// </summary>
    let ``Universitetet%20i%20Oslo`` =
        Namespaced_IRI.parse _namespace_name "Universitetet%20i%20Oslo" |> NamespacedName

    /// <summary>
    /// Et bruksnummer er en del av en enhet i det norske eiendomsregisteret, matrikkelen.
    /// <see href="http://vocab.lenka.no/geo-deling#bnr"></see></summary>
    let bnr = Namespaced_IRI.parse _namespace_name "bnr" |> NamespacedName
    /// <summary>
    /// Indikerer at en grunneiendom er eid av en agent.
    /// <see href="http://vocab.lenka.no/geo-deling#eid-av"></see></summary>
    let ``eid-av`` = Namespaced_IRI.parse _namespace_name "eid-av" |> NamespacedName
    /// <summary>
    /// Indikerer et eierforhold mellom en agent og en grunneiendom.
    /// <see href="http://vocab.lenka.no/geo-deling#eier"></see></summary>
    let eier = Namespaced_IRI.parse _namespace_name "eier" |> NamespacedName
    /// <summary>
    /// Festenummeret er et nummer på et leid grunneiendom i matrikkelen.
    /// <see href="http://vocab.lenka.no/geo-deling#fnr"></see></summary>
    let fnr = Namespaced_IRI.parse _namespace_name "fnr" |> NamespacedName
    /// <summary>
    /// Fylkenummer er et tosifret nummer (eks.: 01) som er unikt for hvert fylke i Norge.
    /// <see href="http://vocab.lenka.no/geo-deling#fylkenr"></see></summary>
    let fylkenr = Namespaced_IRI.parse _namespace_name "fylkenr" |> NamespacedName
    /// <summary>
    /// Gårdsnummer er nummeret på en gårdsenhet i matrikkelen og er unikt innenfor hver kommune.
    /// <see href="http://vocab.lenka.no/geo-deling#gnr"></see></summary>
    let gnr = Namespaced_IRI.parse _namespace_name "gnr" |> NamespacedName
    /// <summary>
    /// Kommunenummer er et firesifret nummer (eks.: 0101) som er unikt for hver kommune i Norge.
    /// <see href="http://vocab.lenka.no/geo-deling#kommunenr"></see></summary>
    let kommunenr = Namespaced_IRI.parse _namespace_name "kommunenr" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    /// For å linke en kommune med stedet som er kommunens senter.
    /// <see href="http://vocab.lenka.no/geo-deling#senter"></see></summary>
    let senter = Namespaced_IRI.parse _namespace_name "senter" |> NamespacedName
    /// <summary>
    /// Et seksjonsnummer er et nummer i matrikkelen som benyttes der en eiendom består av flere selvstendige eierenheter som skal selges og pantsettes hver for seg.
    /// <see href="http://vocab.lenka.no/geo-deling#snr"></see></summary>
    let snr = Namespaced_IRI.parse _namespace_name "snr" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
