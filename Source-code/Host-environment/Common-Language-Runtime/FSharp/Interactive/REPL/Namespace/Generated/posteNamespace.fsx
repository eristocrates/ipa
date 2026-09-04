#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module poste =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/poste#" "poste"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Agence postale communale^^xsd:string</para>
    ///   <para>rdfs:comment : Site représentant une agence communale^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#AgencePostaleCommunale">poste:AgencePostaleCommunale</a>
    /// </summary>
    let AgencePostaleCommunale = _prefixId.prefix "AgencePostaleCommunale"
    /// <summary>
    ///   <para>rdfs:label : Bureau de poste^^xsd:string</para>
    ///   <para>rdfs:comment : Site représentant un bureau de poste^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#BureauPoste">poste:BureauPoste</a>
    /// </summary>
    let BureauPoste = _prefixId.prefix "BureauPoste"
    /// <summary>
    ///   <para>rdfs:label : Organisation de la poste^^xsd:string</para>
    ///   <para>rdfs:comment : Organisation de la poste en France^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#PosteOrganisation">poste:PosteOrganisation</a>
    /// </summary>
    let PosteOrganisation = _prefixId.prefix "PosteOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Relais commerçant^^xsd:string</para>
    ///   <para>rdfs:comment : Site représentant un relais poste commerçant^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#RelaisCommercant">poste:RelaisCommercant</a>
    /// </summary>
    let RelaisCommercant = _prefixId.prefix "RelaisCommercant"
    /// <summary>
    ///   <para>rdfs:label : Affranchissement libre service^^xsd:string</para>
    ///   <para>rdfs:comment : Présence ou non d'un automate d'affranchissement libre service.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#affranchissementLibreService">poste:affranchissementLibreService</a>
    /// </summary>
    let affranchissementLibreService = _prefixId.prefix "affranchissementLibreService"
    /// <summary>
    ///   <para>rdfs:label : changeur monnaie^^xsd:string</para>
    ///   <para>rdfs:comment : changeur de monnaie^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#changeurMonnaie">poste:changeurMonnaie</a>
    /// </summary>
    let changeurMonnaie = _prefixId.prefix "changeurMonnaie"
    /// <summary>
    ///   <para>rdfs:label : Code postal^^xsd:string</para>
    ///   <para>rdfs:comment : code postal du point de contact^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#codePostal">poste:codePostal</a>
    /// </summary>
    let codePostal = _prefixId.prefix "codePostal"
    /// <summary>
    ///   <para>rdfs:label : Complement Adresse^^xsd:string</para>
    ///   <para>rdfs:comment : Indication de precisant la structure d'accueil de l'agence, MAIRIE, HOTEL, TABAC^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#complementAdresse">poste:complementAdresse</a>
    /// </summary>
    let complementAdresse = _prefixId.prefix "complementAdresse"
    /// <summary>
    ///   <para>rdfs:label : Distributeur de billets automatique^^xsd:string</para>
    ///   <para>rdfs:comment : Présence ou non d'un distributeur automatique de billets (DAB).^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#distributeur">poste:distributeur</a>
    /// </summary>
    let distributeur = _prefixId.prefix "distributeur"
    let ghislain = _prefixId.prefix "ghislain"
    /// <summary>
    ///   <para>rdfs:label : Monnaie Paris^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#monnaieParis">poste:monnaieParis</a>
    /// </summary>
    let monnaieParis = _prefixId.prefix "monnaieParis"
    /// <summary>
    ///   <para>rdfs:label : Photocopieur^^xsd:string</para>
    ///   <para>rdfs:comment : Présence ou non d'un photocopieur accessible au public.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#photocopieur">poste:photocopieur</a>
    /// </summary>
    let photocopieur = _prefixId.prefix "photocopieur"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : Recharge moneo^^xsd:string</para>
    ///   <para>rdfs:comment : Présence ou non de chargeurs de monnaie. Ils permettent aux clients de s'approvisionner en monnaie.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/poste#rechargeMoneo">poste:rechargeMoneo</a>
    /// </summary>
    let rechargeMoneo = _prefixId.prefix "rechargeMoneo"
    let ttl = _prefixId.prefix "ttl"
