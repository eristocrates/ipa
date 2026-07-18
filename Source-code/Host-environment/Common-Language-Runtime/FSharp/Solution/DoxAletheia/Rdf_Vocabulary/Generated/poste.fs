namespace http.data.lirmm.fr.ontologies.poste.hash

open DoxAletheia.Rdf_Vocabulary

module poste =
    let _namespace_name = "http://data.lirmm.fr/ontologies/poste#"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#ghislain"></see>
    /// </summary>
    let ghislain = Namespaced_IRI.parse _namespace_name "ghislain" |> NamespacedName

    /// <summary>
    /// Site représentant une agence communale
    /// <see href="http://data.lirmm.fr/ontologies/poste#AgencePostaleCommunale"></see></summary>
    let AgencePostaleCommunale =
        Namespaced_IRI.parse _namespace_name "AgencePostaleCommunale" |> NamespacedName

    /// <summary>
    /// Organisation de la poste en France
    /// <see href="http://data.lirmm.fr/ontologies/poste#PosteOrganisation"></see></summary>
    let PosteOrganisation =
        Namespaced_IRI.parse _namespace_name "PosteOrganisation" |> NamespacedName

    /// <summary>
    /// Site représentant un bureau de poste
    /// <see href="http://data.lirmm.fr/ontologies/poste#BureauPoste"></see></summary>
    let BureauPoste =
        Namespaced_IRI.parse _namespace_name "BureauPoste" |> NamespacedName

    /// <summary>
    /// Site représentant un relais poste commerçant
    /// <see href="http://data.lirmm.fr/ontologies/poste#RelaisCommercant"></see></summary>
    let RelaisCommercant =
        Namespaced_IRI.parse _namespace_name "RelaisCommercant" |> NamespacedName

    /// <summary>
    /// Présence ou non d'un automate d'affranchissement libre service.
    /// <see href="http://data.lirmm.fr/ontologies/poste#affranchissementLibreService"></see></summary>
    let affranchissementLibreService =
        Namespaced_IRI.parse _namespace_name "affranchissementLibreService" |> NamespacedName

    /// <summary>
    /// changeur de monnaie
    /// <see href="http://data.lirmm.fr/ontologies/poste#changeurMonnaie"></see></summary>
    let changeurMonnaie =
        Namespaced_IRI.parse _namespace_name "changeurMonnaie" |> NamespacedName

    /// <summary>
    /// code postal du point de contact
    /// <see href="http://data.lirmm.fr/ontologies/poste#codePostal"></see></summary>
    let codePostal = Namespaced_IRI.parse _namespace_name "codePostal" |> NamespacedName

    /// <summary>
    /// Indication de precisant la structure d'accueil de l'agence, MAIRIE, HOTEL, TABAC
    /// <see href="http://data.lirmm.fr/ontologies/poste#complementAdresse"></see></summary>
    let complementAdresse =
        Namespaced_IRI.parse _namespace_name "complementAdresse" |> NamespacedName

    /// <summary>
    /// Présence ou non d'un distributeur automatique de billets (DAB).
    /// <see href="http://data.lirmm.fr/ontologies/poste#distributeur"></see></summary>
    let distributeur =
        Namespaced_IRI.parse _namespace_name "distributeur" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#monnaieParis"></see>
    /// </summary>
    let monnaieParis =
        Namespaced_IRI.parse _namespace_name "monnaieParis" |> NamespacedName

    /// <summary>
    /// Présence ou non d'un photocopieur accessible au public.
    /// <see href="http://data.lirmm.fr/ontologies/poste#photocopieur"></see></summary>
    let photocopieur =
        Namespaced_IRI.parse _namespace_name "photocopieur" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName

    /// <summary>
    /// Présence ou non de chargeurs de monnaie. Ils permettent aux clients de s'approvisionner en monnaie.
    /// <see href="http://data.lirmm.fr/ontologies/poste#rechargeMoneo"></see></summary>
    let rechargeMoneo =
        Namespaced_IRI.parse _namespace_name "rechargeMoneo" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/poste#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
