namespace http.data.lirmm.fr.ontologies.poste.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module poste =
    let _namespace_iri = Namespace_Iri poste |> NamespaceIRI
    /// <summary>
    ///   <para>poste:ghislain</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#ghislain">http://data.lirmm.fr/ontologies/poste#ghislain</seealso>
    let ghislain = Prefixed_Name(poste, "ghislain") |> PrefixedName
    /// <summary>
    ///   <para>poste:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Vocabulaire décrivant la répartition des points de contact du réseau postal en France métropolitaine, Guadeloupe, Guyane, La Réunion, Martinique, Mayotte, Monaco, Monte-Carlo et Saint-Pierre et Miquelon</para>
    /// labels<para>Ontologie de la Poste</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#">http://data.lirmm.fr/ontologies/poste#</seealso>
    let _prefix_iri = Prefixed_Name(poste, "") |> PrefixedName
    /// <summary>
    ///   <para>poste:PosteOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Organisation de la poste en France</para>
    /// labels<para>Organisation de la poste</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#PosteOrganisation">http://data.lirmm.fr/ontologies/poste#PosteOrganisation</seealso>
    let PosteOrganisation = Prefixed_Name(poste, "PosteOrganisation") |> PrefixedName
    /// <summary>
    ///   <para>poste:BureauPoste</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Site représentant un bureau de poste</para>
    /// labels<para>Bureau de poste</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#BureauPoste">http://data.lirmm.fr/ontologies/poste#BureauPoste</seealso>
    let BureauPoste = Prefixed_Name(poste, "BureauPoste") |> PrefixedName

    /// <summary>
    ///   <para>poste:AgencePostaleCommunale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Site représentant une agence communale</para>
    /// labels<para>Agence postale communale</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#AgencePostaleCommunale">http://data.lirmm.fr/ontologies/poste#AgencePostaleCommunale</seealso>
    let AgencePostaleCommunale =
        Prefixed_Name(poste, "AgencePostaleCommunale") |> PrefixedName

    /// <summary>
    ///   <para>poste:RelaisCommercant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Site représentant un relais poste commerçant</para>
    /// labels<para>Relais commerçant</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#RelaisCommercant">http://data.lirmm.fr/ontologies/poste#RelaisCommercant</seealso>
    let RelaisCommercant = Prefixed_Name(poste, "RelaisCommercant") |> PrefixedName

    /// <summary>
    ///   <para>poste:affranchissementLibreService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Présence ou non d'un automate d'affranchissement libre service.</para>
    /// labels<para>Affranchissement libre service</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#affranchissementLibreService">http://data.lirmm.fr/ontologies/poste#affranchissementLibreService</seealso>
    let affranchissementLibreService =
        Prefixed_Name(poste, "affranchissementLibreService") |> PrefixedName

    /// <summary>
    ///   <para>poste:changeurMonnaie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>changeur de monnaie</para>
    /// labels<para>changeur monnaie</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#changeurMonnaie">http://data.lirmm.fr/ontologies/poste#changeurMonnaie</seealso>
    let changeurMonnaie = Prefixed_Name(poste, "changeurMonnaie") |> PrefixedName
    /// <summary>
    ///   <para>poste:codePostal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>code postal du point de contact</para>
    /// labels<para>Code postal</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#codePostal">http://data.lirmm.fr/ontologies/poste#codePostal</seealso>
    let codePostal = Prefixed_Name(poste, "codePostal") |> PrefixedName
    /// <summary>
    ///   <para>poste:monnaieParis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Monnaie Paris</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#monnaieParis">http://data.lirmm.fr/ontologies/poste#monnaieParis</seealso>
    let monnaieParis = Prefixed_Name(poste, "monnaieParis") |> PrefixedName
    /// <summary>
    ///   <para>poste:rechargeMoneo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Présence ou non de chargeurs de monnaie. Ils permettent aux clients de s'approvisionner en monnaie.</para>
    /// labels<para>Recharge moneo</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#rechargeMoneo">http://data.lirmm.fr/ontologies/poste#rechargeMoneo</seealso>
    let rechargeMoneo = Prefixed_Name(poste, "rechargeMoneo") |> PrefixedName
    /// <summary>
    ///   <para>poste:distributeur</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Présence ou non d'un distributeur automatique de billets (DAB).</para>
    /// labels<para>Distributeur de billets automatique</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#distributeur">http://data.lirmm.fr/ontologies/poste#distributeur</seealso>
    let distributeur = Prefixed_Name(poste, "distributeur") |> PrefixedName
    /// <summary>
    ///   <para>poste:photocopieur</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Présence ou non d'un photocopieur accessible au public.</para>
    /// labels<para>Photocopieur</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#photocopieur">http://data.lirmm.fr/ontologies/poste#photocopieur</seealso>
    let photocopieur = Prefixed_Name(poste, "photocopieur") |> PrefixedName
    /// <summary>
    ///   <para>poste:complementAdresse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indication de precisant la structure d'accueil de l'agence, MAIRIE, HOTEL, TABAC</para>
    /// labels<para>Complement Adresse</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#complementAdresse">http://data.lirmm.fr/ontologies/poste#complementAdresse</seealso>
    let complementAdresse = Prefixed_Name(poste, "complementAdresse") |> PrefixedName
    /// <summary>
    ///   <para>poste:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#rdf">http://data.lirmm.fr/ontologies/poste#rdf</seealso>
    let rdf = Prefixed_Name(poste, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>poste:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/poste#ttl">http://data.lirmm.fr/ontologies/poste#ttl</seealso>
    let ttl = Prefixed_Name(poste, "ttl") |> PrefixedName
