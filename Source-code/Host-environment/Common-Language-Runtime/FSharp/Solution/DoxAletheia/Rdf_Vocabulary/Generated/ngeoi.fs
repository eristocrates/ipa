namespace http.vocab.lenka.no.geo_deling.hash

open DoxAletheia

module ngeoi =
    let _namespace_name = "http://vocab.lenka.no/geo-deling#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#Kjetil%20Kjernsmo"></see>
    /// </summary>
    let ``Kjetil%20Kjernsmo`` = _prefix "Kjetil%20Kjernsmo"
    /// <summary>
    /// Et fylke er et område som utgjør en førsteordens politisk og administrativ enhet.
    /// <see href="http://vocab.lenka.no/geo-deling#Fylke"></see></summary>
    let Fylke = _prefix "Fylke"
    /// <summary>
    /// Grunneiendom er en geografisk del av landet som har et eget eierforhold.
    /// <see href="http://vocab.lenka.no/geo-deling#Grunneiendom"></see></summary>
    let Grunneiendom = _prefix "Grunneiendom"
    /// <summary>
    /// En kommune er et område som utgjør en andreordens politisk og administrativ enhet.
    /// <see href="http://vocab.lenka.no/geo-deling#Kommune"></see></summary>
    let Kommune = _prefix "Kommune"
    /// <summary>
    /// Et kommunesenter er et sted som tjener som administrativt senter for en kommune.
    /// <see href="http://vocab.lenka.no/geo-deling#Kommunesenter"></see></summary>
    let Kommunesenter = _prefix "Kommunesenter"
    /// <summary>
    /// Et sted er et avgrenset område.
    /// <see href="http://vocab.lenka.no/geo-deling#Sted"></see></summary>
    let Sted = _prefix "Sted"
    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#Universitetet%20i%20Oslo"></see>
    /// </summary>
    let ``Universitetet%20i%20Oslo`` = _prefix "Universitetet%20i%20Oslo"
    /// <summary>
    /// Et bruksnummer er en del av en enhet i det norske eiendomsregisteret, matrikkelen.
    /// <see href="http://vocab.lenka.no/geo-deling#bnr"></see></summary>
    let bnr = _prefix "bnr"
    /// <summary>
    /// Indikerer at en grunneiendom er eid av en agent.
    /// <see href="http://vocab.lenka.no/geo-deling#eid-av"></see></summary>
    let ``eid-av`` = _prefix "eid-av"
    /// <summary>
    /// Indikerer et eierforhold mellom en agent og en grunneiendom.
    /// <see href="http://vocab.lenka.no/geo-deling#eier"></see></summary>
    let eier = _prefix "eier"
    /// <summary>
    /// Festenummeret er et nummer på et leid grunneiendom i matrikkelen.
    /// <see href="http://vocab.lenka.no/geo-deling#fnr"></see></summary>
    let fnr = _prefix "fnr"
    /// <summary>
    /// Fylkenummer er et tosifret nummer (eks.: 01) som er unikt for hvert fylke i Norge.
    /// <see href="http://vocab.lenka.no/geo-deling#fylkenr"></see></summary>
    let fylkenr = _prefix "fylkenr"
    /// <summary>
    /// Gårdsnummer er nummeret på en gårdsenhet i matrikkelen og er unikt innenfor hver kommune.
    /// <see href="http://vocab.lenka.no/geo-deling#gnr"></see></summary>
    let gnr = _prefix "gnr"
    /// <summary>
    /// Kommunenummer er et firesifret nummer (eks.: 0101) som er unikt for hver kommune i Norge.
    /// <see href="http://vocab.lenka.no/geo-deling#kommunenr"></see></summary>
    let kommunenr = _prefix "kommunenr"
    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    /// For å linke en kommune med stedet som er kommunens senter.
    /// <see href="http://vocab.lenka.no/geo-deling#senter"></see></summary>
    let senter = _prefix "senter"
    /// <summary>
    /// Et seksjonsnummer er et nummer i matrikkelen som benyttes der en eiendom består av flere selvstendige eierenheter som skal selges og pantsettes hver for seg.
    /// <see href="http://vocab.lenka.no/geo-deling#snr"></see></summary>
    let snr = _prefix "snr"
    /// <summary>
    ///   <see href="http://vocab.lenka.no/geo-deling#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
