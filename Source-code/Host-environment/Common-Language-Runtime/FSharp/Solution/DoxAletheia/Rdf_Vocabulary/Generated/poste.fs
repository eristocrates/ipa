namespace http.data.lirmm.fr.ontologies.poste.hash

open DoxAletheia

module poste =
    let _namespace_name = "http://data.lirmm.fr/ontologies/poste#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#ghislain"></see>
    /// </summary>
    let ghislain = _prefix "ghislain"
    /// <summary>
    /// Site représentant une agence communale
    /// <see href="http://data.lirmm.fr/ontologies/poste#AgencePostaleCommunale"></see></summary>
    let AgencePostaleCommunale = _prefix "AgencePostaleCommunale"
    /// <summary>
    /// Organisation de la poste en France
    /// <see href="http://data.lirmm.fr/ontologies/poste#PosteOrganisation"></see></summary>
    let PosteOrganisation = _prefix "PosteOrganisation"
    /// <summary>
    /// Site représentant un bureau de poste
    /// <see href="http://data.lirmm.fr/ontologies/poste#BureauPoste"></see></summary>
    let BureauPoste = _prefix "BureauPoste"
    /// <summary>
    /// Site représentant un relais poste commerçant
    /// <see href="http://data.lirmm.fr/ontologies/poste#RelaisCommercant"></see></summary>
    let RelaisCommercant = _prefix "RelaisCommercant"
    /// <summary>
    /// Présence ou non d'un automate d'affranchissement libre service.
    /// <see href="http://data.lirmm.fr/ontologies/poste#affranchissementLibreService"></see></summary>
    let affranchissementLibreService = _prefix "affranchissementLibreService"
    /// <summary>
    /// changeur de monnaie
    /// <see href="http://data.lirmm.fr/ontologies/poste#changeurMonnaie"></see></summary>
    let changeurMonnaie = _prefix "changeurMonnaie"
    /// <summary>
    /// code postal du point de contact
    /// <see href="http://data.lirmm.fr/ontologies/poste#codePostal"></see></summary>
    let codePostal = _prefix "codePostal"
    /// <summary>
    /// Indication de precisant la structure d'accueil de l'agence, MAIRIE, HOTEL, TABAC
    /// <see href="http://data.lirmm.fr/ontologies/poste#complementAdresse"></see></summary>
    let complementAdresse = _prefix "complementAdresse"
    /// <summary>
    /// Présence ou non d'un distributeur automatique de billets (DAB).
    /// <see href="http://data.lirmm.fr/ontologies/poste#distributeur"></see></summary>
    let distributeur = _prefix "distributeur"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#monnaieParis"></see>
    /// </summary>
    let monnaieParis = _prefix "monnaieParis"
    /// <summary>
    /// Présence ou non d'un photocopieur accessible au public.
    /// <see href="http://data.lirmm.fr/ontologies/poste#photocopieur"></see></summary>
    let photocopieur = _prefix "photocopieur"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    /// Présence ou non de chargeurs de monnaie. Ils permettent aux clients de s'approvisionner en monnaie.
    /// <see href="http://data.lirmm.fr/ontologies/poste#rechargeMoneo"></see></summary>
    let rechargeMoneo = _prefix "rechargeMoneo"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
