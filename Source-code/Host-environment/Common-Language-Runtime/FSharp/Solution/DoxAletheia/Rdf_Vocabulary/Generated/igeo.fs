namespace http.rdf.insee.fr.def.geo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module igeo =
    let _namespace_iri = Namespace_Iri igeo |> NamespaceIRI
    /// <summary>
    ///   <para>igeo:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#">http://rdf.insee.fr/def/geo#</seealso>
    let _prefix_iri = Prefixed_Name(igeo, "") |> PrefixedName
    /// <summary>
    ///   <para>igeo:AireUrbaine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Aire urbaine"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#AireUrbaine">http://rdf.insee.fr/def/geo#AireUrbaine</seealso>
    let AireUrbaine = Prefixed_Name(igeo, "AireUrbaine") |> PrefixedName
    /// <summary>
    ///   <para>igeo:Arrondissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Arrondissement"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#Arrondissement">http://rdf.insee.fr/def/geo#Arrondissement</seealso>
    let Arrondissement = Prefixed_Name(igeo, "Arrondissement") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ArrondissementMunicipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cette classe n'est utilisée que pour les arrondissements de Paris, Lyon et Marseille"</para>
    /// labels<para>"Arrondissement municipal"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ArrondissementMunicipal">http://rdf.insee.fr/def/geo#ArrondissementMunicipal</seealso>
    let ArrondissementMunicipal =
        Prefixed_Name(igeo, "ArrondissementMunicipal") |> PrefixedName

    /// <summary>
    ///   <para>igeo:Canton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Canton français, circonscription d'élection des conseillers généraux"</para>
    /// labels<para>"Canton"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#Canton">http://rdf.insee.fr/def/geo#Canton</seealso>
    let Canton = Prefixed_Name(igeo, "Canton") |> PrefixedName
    /// <summary>
    ///   <para>igeo:CantonOuVille</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dit aussi 'pseudo-canton', c'est un regroupement d'une ou plusieurs communes entières"</para>
    /// labels<para>"Canton-ou-ville"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#CantonOuVille">http://rdf.insee.fr/def/geo#CantonOuVille</seealso>
    let CantonOuVille = Prefixed_Name(igeo, "CantonOuVille") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ChangementDeDepartementOuArrondissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Changement de rattachement administratif d'une commune"</para>
    /// labels<para>"Changement de département ou d'arrondissement"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ChangementDeDepartementOuArrondissement">http://rdf.insee.fr/def/geo#ChangementDeDepartementOuArrondissement</seealso>
    let ChangementDeDepartementOuArrondissement =
        Prefixed_Name(igeo, "ChangementDeDepartementOuArrondissement") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ChangementDeNom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Changement de l'intitulé du territoire"</para>
    /// labels<para>"Changement de nom"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ChangementDeNom">http://rdf.insee.fr/def/geo#ChangementDeNom</seealso>
    let ChangementDeNom = Prefixed_Name(igeo, "ChangementDeNom") |> PrefixedName

    /// <summary>
    ///   <para>igeo:CollectiviteDOutreMer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#CollectiviteDOutreMer">http://rdf.insee.fr/def/geo#CollectiviteDOutreMer</seealso>
    let CollectiviteDOutreMer =
        Prefixed_Name(igeo, "CollectiviteDOutreMer") |> PrefixedName

    /// <summary>
    ///   <para>igeo:CollectiviteTerritoriale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collectivité territoriale d'outre-mer. Inclut les TOM et les territoires à statut particulier."</para>
    /// labels<para>"Collectivité territoriale"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#CollectiviteTerritoriale">http://rdf.insee.fr/def/geo#CollectiviteTerritoriale</seealso>
    let CollectiviteTerritoriale =
        Prefixed_Name(igeo, "CollectiviteTerritoriale") |> PrefixedName

    /// <summary>
    ///   <para>igeo:Commune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Commune"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#Commune">http://rdf.insee.fr/def/geo#Commune</seealso>
    let Commune = Prefixed_Name(igeo, "Commune") |> PrefixedName

    /// <summary>
    ///   <para>igeo:CreationOuRetablissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Création ou rétablissemnt d'un territoire"</para>
    /// labels<para>"Création ou rétablissement"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#CreationOuRetablissement">http://rdf.insee.fr/def/geo#CreationOuRetablissement</seealso>
    let CreationOuRetablissement =
        Prefixed_Name(igeo, "CreationOuRetablissement") |> PrefixedName

    /// <summary>
    ///   <para>igeo:Departement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Département"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#Departement">http://rdf.insee.fr/def/geo#Departement</seealso>
    let Departement = Prefixed_Name(igeo, "Departement") |> PrefixedName

    /// <summary>
    ///   <para>igeo:DeplacementDeLimitesDIRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Déplacement de limites d'IRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#DeplacementDeLimitesDIRIS">http://rdf.insee.fr/def/geo#DeplacementDeLimitesDIRIS</seealso>
    let DeplacementDeLimitesDIRIS =
        Prefixed_Name(igeo, "DeplacementDeLimitesDIRIS") |> PrefixedName

    /// <summary>
    ///   <para>igeo:EPCI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Établissement public de coopération intercommunale"</para>
    /// labels<para>"EPCI"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#EPCI">http://rdf.insee.fr/def/geo#EPCI</seealso>
    let EPCI = Prefixed_Name(igeo, "EPCI") |> PrefixedName
    /// <summary>
    ///   <para>igeo:EchangeDeParcelles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Échange de parcelles entre territoires"</para>
    /// labels<para>"Échange de parcelles"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#EchangeDeParcelles">http://rdf.insee.fr/def/geo#EchangeDeParcelles</seealso>
    let EchangeDeParcelles = Prefixed_Name(igeo, "EchangeDeParcelles") |> PrefixedName

    /// <summary>
    ///   <para>igeo:EchangeParcellesCommunesIrisees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Échange de parcelles entre communes irisées"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#EchangeParcellesCommunesIrisees">http://rdf.insee.fr/def/geo#EchangeParcellesCommunesIrisees</seealso>
    let EchangeParcellesCommunesIrisees =
        Prefixed_Name(igeo, "EchangeParcellesCommunesIrisees") |> PrefixedName

    /// <summary>
    ///   <para>igeo:EchangeParcellesHabiteesCommunesIriseesNonIrisees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Échange de parcelles habitées entre communes irisées et non irisées"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#EchangeParcellesHabiteesCommunesIriseesNonIrisees">http://rdf.insee.fr/def/geo#EchangeParcellesHabiteesCommunesIriseesNonIrisees</seealso>
    let EchangeParcellesHabiteesCommunesIriseesNonIrisees =
        Prefixed_Name(igeo, "EchangeParcellesHabiteesCommunesIriseesNonIrisees") |> PrefixedName

    /// <summary>
    ///   <para>igeo:EchangeParcellesInhabiteesCommunesIriseesNonIrisees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Échange de parcelles inhabitées entre communes irisées et non irisées"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#EchangeParcellesInhabiteesCommunesIriseesNonIrisees">http://rdf.insee.fr/def/geo#EchangeParcellesInhabiteesCommunesIriseesNonIrisees</seealso>
    let EchangeParcellesInhabiteesCommunesIriseesNonIrisees =
        Prefixed_Name(igeo, "EchangeParcellesInhabiteesCommunesIriseesNonIrisees") |> PrefixedName

    /// <summary>
    ///   <para>igeo:FusionDeCommunesIrisees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fusion de communes irisées"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#FusionDeCommunesIrisees">http://rdf.insee.fr/def/geo#FusionDeCommunesIrisees</seealso>
    let FusionDeCommunesIrisees =
        Prefixed_Name(igeo, "FusionDeCommunesIrisees") |> PrefixedName

    /// <summary>
    ///   <para>igeo:GrandQuartier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Grand Quartier"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#GrandQuartier">http://rdf.insee.fr/def/geo#GrandQuartier</seealso>
    let GrandQuartier = Prefixed_Name(igeo, "GrandQuartier") |> PrefixedName
    /// <summary>
    ///   <para>igeo:GroupementDePays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Exemples : Communauté Européenne, OCDE, OTAN, Pays arabes ..."</para>
    /// labels<para>"Groupement de pays"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#GroupementDePays">http://rdf.insee.fr/def/geo#GroupementDePays</seealso>
    let GroupementDePays = Prefixed_Name(igeo, "GroupementDePays") |> PrefixedName

    /// <summary>
    ///   <para>igeo:GroupementStatistiqueDeCommunes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Modélise des zonages divers d'intérêt statistique"</para>
    /// labels<para>"Groupement statistique de communes"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#GroupementStatistiqueDeCommunes">http://rdf.insee.fr/def/geo#GroupementStatistiqueDeCommunes</seealso>
    let GroupementStatistiqueDeCommunes =
        Prefixed_Name(igeo, "GroupementStatistiqueDeCommunes") |> PrefixedName

    /// <summary>
    ///   <para>igeo:IRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Îlot regroupé pour l'information statistique"</para>
    /// labels<para>"IRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#IRIS">http://rdf.insee.fr/def/geo#IRIS</seealso>
    let IRIS = Prefixed_Name(igeo, "IRIS") |> PrefixedName
    /// <summary>
    ///   <para>igeo:LAU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unité Administrative Locale"</para><para>"Local Administrative Unit"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#LAU">http://rdf.insee.fr/def/geo#LAU</seealso>
    let LAU = Prefixed_Name(igeo, "LAU") |> PrefixedName
    /// <summary>
    ///   <para>igeo:LAU1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LAU 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#LAU1">http://rdf.insee.fr/def/geo#LAU1</seealso>
    let LAU1 = Prefixed_Name(igeo, "LAU1") |> PrefixedName
    /// <summary>
    ///   <para>igeo:LAU2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LAU 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#LAU2">http://rdf.insee.fr/def/geo#LAU2</seealso>
    let LAU2 = Prefixed_Name(igeo, "LAU2") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ModificationCantonale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Modification de la structure d'un ou plusieurs cantons"</para>
    /// labels<para>"Modification cantonale"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ModificationCantonale">http://rdf.insee.fr/def/geo#ModificationCantonale</seealso>
    let ModificationCantonale =
        Prefixed_Name(igeo, "ModificationCantonale") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ModificationDIRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modification IRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ModificationDIRIS">http://rdf.insee.fr/def/geo#ModificationDIRIS</seealso>
    let ModificationDIRIS = Prefixed_Name(igeo, "ModificationDIRIS") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ModificationDeGroupement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modification de groupement"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ModificationDeGroupement">http://rdf.insee.fr/def/geo#ModificationDeGroupement</seealso>
    let ModificationDeGroupement =
        Prefixed_Name(igeo, "ModificationDeGroupement") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ModificationTerritoriale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Classe générique de tous les événements liés à la création ou à la modification de territoires"</para>
    /// labels<para>"Modification territoriale"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ModificationTerritoriale">http://rdf.insee.fr/def/geo#ModificationTerritoriale</seealso>
    let ModificationTerritoriale =
        Prefixed_Name(igeo, "ModificationTerritoriale") |> PrefixedName

    /// <summary>
    ///   <para>igeo:NUTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unité Territoriale Statistique"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#NUTS">http://rdf.insee.fr/def/geo#NUTS</seealso>
    let NUTS = Prefixed_Name(igeo, "NUTS") |> PrefixedName
    /// <summary>
    ///   <para>igeo:NUTS1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NUTS 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#NUTS1">http://rdf.insee.fr/def/geo#NUTS1</seealso>
    let NUTS1 = Prefixed_Name(igeo, "NUTS1") |> PrefixedName
    /// <summary>
    ///   <para>igeo:NUTS2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NUTS 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#NUTS2">http://rdf.insee.fr/def/geo#NUTS2</seealso>
    let NUTS2 = Prefixed_Name(igeo, "NUTS2") |> PrefixedName
    /// <summary>
    ///   <para>igeo:NUTS3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"NUTS 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#NUTS3">http://rdf.insee.fr/def/geo#NUTS3</seealso>
    let NUTS3 = Prefixed_Name(igeo, "NUTS3") |> PrefixedName
    /// <summary>
    ///   <para>igeo:Pays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pays"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#Pays">http://rdf.insee.fr/def/geo#Pays</seealso>
    let Pays = Prefixed_Name(igeo, "Pays") |> PrefixedName
    /// <summary>
    ///   <para>igeo:PaysOuTerritoire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pays ou subdivision géopolitique d'un pays"</para>
    /// labels<para>"Pays ou territoire"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#PaysOuTerritoire">http://rdf.insee.fr/def/geo#PaysOuTerritoire</seealso>
    let PaysOuTerritoire = Prefixed_Name(igeo, "PaysOuTerritoire") |> PrefixedName
    /// <summary>
    ///   <para>igeo:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Région française de métropole ou d'outre-mer"</para>
    /// labels<para>"Région"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#Region">http://rdf.insee.fr/def/geo#Region</seealso>
    let Region = Prefixed_Name(igeo, "Region") |> PrefixedName

    /// <summary>
    ///   <para>igeo:RetablissementCommunesIssuesDeCommuneIrisees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rétablissement de communes issues de communes irisées"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#RetablissementCommunesIssuesDeCommuneIrisees">http://rdf.insee.fr/def/geo#RetablissementCommunesIssuesDeCommuneIrisees</seealso>
    let RetablissementCommunesIssuesDeCommuneIrisees =
        Prefixed_Name(igeo, "RetablissementCommunesIssuesDeCommuneIrisees") |> PrefixedName

    /// <summary>
    ///   <para>igeo:ScissionDIRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Scission d'IRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ScissionDIRIS">http://rdf.insee.fr/def/geo#ScissionDIRIS</seealso>
    let ScissionDIRIS = Prefixed_Name(igeo, "ScissionDIRIS") |> PrefixedName
    /// <summary>
    ///   <para>igeo:SuppressionFusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Suppression ou fusion de territoires"</para>
    /// labels<para>"Suppression-fusion"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#SuppressionFusion">http://rdf.insee.fr/def/geo#SuppressionFusion</seealso>
    let SuppressionFusion = Prefixed_Name(igeo, "SuppressionFusion") |> PrefixedName
    /// <summary>
    ///   <para>igeo:TRIRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TRIRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#TRIRIS">http://rdf.insee.fr/def/geo#TRIRIS</seealso>
    let TRIRIS = Prefixed_Name(igeo, "TRIRIS") |> PrefixedName

    /// <summary>
    ///   <para>igeo:TerritoireAdministratif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Subdivision administrative du territoire français"</para>
    /// labels<para>"Territoire administratif"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#TerritoireAdministratif">http://rdf.insee.fr/def/geo#TerritoireAdministratif</seealso>
    let TerritoireAdministratif =
        Prefixed_Name(igeo, "TerritoireAdministratif") |> PrefixedName

    /// <summary>
    ///   <para>igeo:TerritoireFrancais</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Subdivision administrative ou statistique du territoire français"</para>
    /// labels<para>"Territoire français"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#TerritoireFrancais">http://rdf.insee.fr/def/geo#TerritoireFrancais</seealso>
    let TerritoireFrancais = Prefixed_Name(igeo, "TerritoireFrancais") |> PrefixedName

    /// <summary>
    ///   <para>igeo:TerritoireStatistique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Subdivision du territoire français utilisée pour la production de statistiques"</para>
    /// labels<para>"Territoire statistique"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#TerritoireStatistique">http://rdf.insee.fr/def/geo#TerritoireStatistique</seealso>
    let TerritoireStatistique =
        Prefixed_Name(igeo, "TerritoireStatistique") |> PrefixedName

    /// <summary>
    ///   <para>igeo:TransfertDeChefLieu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Changement de la commune chef-lieu d'un territoire"</para>
    /// labels<para>"Transfert de chef-lieu"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#TransfertDeChefLieu">http://rdf.insee.fr/def/geo#TransfertDeChefLieu</seealso>
    let TransfertDeChefLieu = Prefixed_Name(igeo, "TransfertDeChefLieu") |> PrefixedName
    /// <summary>
    ///   <para>igeo:TypeDEPCI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Type d'EPCI"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#TypeDEPCI">http://rdf.insee.fr/def/geo#TypeDEPCI</seealso>
    let TypeDEPCI = Prefixed_Name(igeo, "TypeDEPCI") |> PrefixedName
    /// <summary>
    ///   <para>igeo:TypeDIRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Type d'IRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#TypeDIRIS">http://rdf.insee.fr/def/geo#TypeDIRIS</seealso>
    let TypeDIRIS = Prefixed_Name(igeo, "TypeDIRIS") |> PrefixedName
    /// <summary>
    ///   <para>igeo:UniteUrbaine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unité urbaine"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#UniteUrbaine">http://rdf.insee.fr/def/geo#UniteUrbaine</seealso>
    let UniteUrbaine = Prefixed_Name(igeo, "UniteUrbaine") |> PrefixedName
    /// <summary>
    ///   <para>igeo:ZoneDEmploi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Zone d'emploi"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ZoneDEmploi">http://rdf.insee.fr/def/geo#ZoneDEmploi</seealso>
    let ZoneDEmploi = Prefixed_Name(igeo, "ZoneDEmploi") |> PrefixedName
    /// <summary>
    ///   <para>igeo:ancienChefLieu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ancien chef-lieu"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ancienChefLieu">http://rdf.insee.fr/def/geo#ancienChefLieu</seealso>
    let ancienChefLieu = Prefixed_Name(igeo, "ancienChefLieu") |> PrefixedName
    /// <summary>
    ///   <para>igeo:ancienNom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ancien nom"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#ancienNom">http://rdf.insee.fr/def/geo#ancienNom</seealso>
    let ancienNom = Prefixed_Name(igeo, "ancienNom") |> PrefixedName
    /// <summary>
    ///   <para>igeo:capitale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"capitale d'un pays ou d'un territoire"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#capitale">http://rdf.insee.fr/def/geo#capitale</seealso>
    let capitale = Prefixed_Name(igeo, "capitale") |> PrefixedName
    /// <summary>
    ///   <para>igeo:centroide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"centroïde"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#centroide">http://rdf.insee.fr/def/geo#centroide</seealso>
    let centroide = Prefixed_Name(igeo, "centroide") |> PrefixedName
    /// <summary>
    ///   <para>igeo:chefLieu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"La commune siège des institutions administratives du territoire"</para>
    /// labels<para>"chef-lieu"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#chefLieu">http://rdf.insee.fr/def/geo#chefLieu</seealso>
    let chefLieu = Prefixed_Name(igeo, "chefLieu") |> PrefixedName
    /// <summary>
    ///   <para>igeo:chefLieuDeCanton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"chef-lieu de canton"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#chefLieuDeCanton">http://rdf.insee.fr/def/geo#chefLieuDeCanton</seealso>
    let chefLieuDeCanton = Prefixed_Name(igeo, "chefLieuDeCanton") |> PrefixedName
    /// <summary>
    ///   <para>igeo:chefLieuDeCommune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Position géographique de la mairie"</para>
    /// labels<para>"chef-lieu de commune"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#chefLieuDeCommune">http://rdf.insee.fr/def/geo#chefLieuDeCommune</seealso>
    let chefLieuDeCommune = Prefixed_Name(igeo, "chefLieuDeCommune") |> PrefixedName

    /// <summary>
    ///   <para>igeo:codeAdministratifGeonames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"code administratif Geonames"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeAdministratifGeonames">http://rdf.insee.fr/def/geo#codeAdministratifGeonames</seealso>
    let codeAdministratifGeonames =
        Prefixed_Name(igeo, "codeAdministratifGeonames") |> PrefixedName

    /// <summary>
    ///   <para>igeo:codeArrondissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code arrondissement"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeArrondissement">http://rdf.insee.fr/def/geo#codeArrondissement</seealso>
    let codeArrondissement = Prefixed_Name(igeo, "codeArrondissement") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codeCanton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code canton"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeCanton">http://rdf.insee.fr/def/geo#codeCanton</seealso>
    let codeCanton = Prefixed_Name(igeo, "codeCanton") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codeCommune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code commune"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeCommune">http://rdf.insee.fr/def/geo#codeCommune</seealso>
    let codeCommune = Prefixed_Name(igeo, "codeCommune") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codeDepartement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code département"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeDepartement">http://rdf.insee.fr/def/geo#codeDepartement</seealso>
    let codeDepartement = Prefixed_Name(igeo, "codeDepartement") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codeINSEE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Propriété générique à utiliser pour les types de territoire pour lesquels un type de code plus spécifique n'est pas défini"</para>
    /// labels<para>"code INSEE"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeINSEE">http://rdf.insee.fr/def/geo#codeINSEE</seealso>
    let codeINSEE = Prefixed_Name(igeo, "codeINSEE") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codeIRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code IRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeIRIS">http://rdf.insee.fr/def/geo#codeIRIS</seealso>
    let codeIRIS = Prefixed_Name(igeo, "codeIRIS") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codeISO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Code conforme à la norme ISO 3166-1-alpha-2"</para>
    /// labels<para>"code de pays ISO"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeISO">http://rdf.insee.fr/def/geo#codeISO</seealso>
    let codeISO = Prefixed_Name(igeo, "codeISO") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codePays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code pays"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codePays">http://rdf.insee.fr/def/geo#codePays</seealso>
    let codePays = Prefixed_Name(igeo, "codePays") |> PrefixedName
    /// <summary>
    ///   <para>igeo:codeRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"code région"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#codeRegion">http://rdf.insee.fr/def/geo#codeRegion</seealso>
    let codeRegion = Prefixed_Name(igeo, "codeRegion") |> PrefixedName
    /// <summary>
    ///   <para>igeo:communeDeplacee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"commune déplacée"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#communeDeplacee">http://rdf.insee.fr/def/geo#communeDeplacee</seealso>
    let communeDeplacee = Prefixed_Name(igeo, "communeDeplacee") |> PrefixedName
    /// <summary>
    ///   <para>igeo:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date de la modification"</para>
    /// labels<para>"date"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#date">http://rdf.insee.fr/def/geo#date</seealso>
    let date = Prefixed_Name(igeo, "date") |> PrefixedName
    /// <summary>
    ///   <para>igeo:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Description de la modification"</para>
    /// labels<para>"description"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#description">http://rdf.insee.fr/def/geo#description</seealso>
    let description = Prefixed_Name(igeo, "description") |> PrefixedName
    /// <summary>
    ///   <para>igeo:fractionCantonale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indique une commune dont une fraction seulement est incluse dans le canton"</para>
    /// labels<para>"fraction cantonale"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#fractionCantonale">http://rdf.insee.fr/def/geo#fractionCantonale</seealso>
    let fractionCantonale = Prefixed_Name(igeo, "fractionCantonale") |> PrefixedName
    /// <summary>
    ///   <para>igeo:france</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#france">http://rdf.insee.fr/def/geo#france</seealso>
    let france = Prefixed_Name(igeo, "france") |> PrefixedName
    /// <summary>
    ///   <para>igeo:groupementModifie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"groupement modifié"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#groupementModifie">http://rdf.insee.fr/def/geo#groupementModifie</seealso>
    let groupementModifie = Prefixed_Name(igeo, "groupementModifie") |> PrefixedName
    /// <summary>
    ///   <para>igeo:membre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Le pays ou territoire objet de cette propriété appartient au groupement sujet"</para>
    /// labels<para>"membre"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#membre">http://rdf.insee.fr/def/geo#membre</seealso>
    let membre = Prefixed_Name(igeo, "membre") |> PrefixedName
    /// <summary>
    ///   <para>igeo:modification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Une modification intervenue pour ce territoire"</para>
    /// labels<para>"modification"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#modification">http://rdf.insee.fr/def/geo#modification</seealso>
    let modification = Prefixed_Name(igeo, "modification") |> PrefixedName
    /// <summary>
    ///   <para>igeo:modificationInduite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La modification objet de cette propriété est provoquée par la modification sujet"</para>
    /// labels<para>"modification induite"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#modificationInduite">http://rdf.insee.fr/def/geo#modificationInduite</seealso>
    let modificationInduite = Prefixed_Name(igeo, "modificationInduite") |> PrefixedName
    /// <summary>
    ///   <para>igeo:nom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"nom"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#nom">http://rdf.insee.fr/def/geo#nom</seealso>
    let nom = Prefixed_Name(igeo, "nom") |> PrefixedName
    /// <summary>
    ///   <para>igeo:nouveauChefLieu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"nouveau chef-lieu"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#nouveauChefLieu">http://rdf.insee.fr/def/geo#nouveauChefLieu</seealso>
    let nouveauChefLieu = Prefixed_Name(igeo, "nouveauChefLieu") |> PrefixedName
    /// <summary>
    ///   <para>igeo:nouveauNom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"nouveau nom"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#nouveauNom">http://rdf.insee.fr/def/geo#nouveauNom</seealso>
    let nouveauNom = Prefixed_Name(igeo, "nouveauNom") |> PrefixedName
    /// <summary>
    ///   <para>igeo:paysEntrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pays entrant"</para>
    /// labels<para>"pays entrant"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#paysEntrant">http://rdf.insee.fr/def/geo#paysEntrant</seealso>
    let paysEntrant = Prefixed_Name(igeo, "paysEntrant") |> PrefixedName
    /// <summary>
    ///   <para>igeo:paysSortant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pays sortant"</para>
    /// labels<para>"pays sortant"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#paysSortant">http://rdf.insee.fr/def/geo#paysSortant</seealso>
    let paysSortant = Prefixed_Name(igeo, "paysSortant") |> PrefixedName
    /// <summary>
    ///   <para>igeo:prefecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"préfecture de département"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#prefecture">http://rdf.insee.fr/def/geo#prefecture</seealso>
    let prefecture = Prefixed_Name(igeo, "prefecture") |> PrefixedName
    /// <summary>
    ///   <para>igeo:prefectureDeRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"préfecture de région"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#prefectureDeRegion">http://rdf.insee.fr/def/geo#prefectureDeRegion</seealso>
    let prefectureDeRegion = Prefixed_Name(igeo, "prefectureDeRegion") |> PrefixedName
    /// <summary>
    ///   <para>igeo:resultante</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"résultante"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#resultante">http://rdf.insee.fr/def/geo#resultante</seealso>
    let resultante = Prefixed_Name(igeo, "resultante") |> PrefixedName
    /// <summary>
    ///   <para>igeo:sousPrefecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sous-préfecture de département"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#sousPrefecture">http://rdf.insee.fr/def/geo#sousPrefecture</seealso>
    let sousPrefecture = Prefixed_Name(igeo, "sousPrefecture") |> PrefixedName
    /// <summary>
    ///   <para>igeo:subdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Une subdivision du territoire"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subdivision"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#subdivision">http://rdf.insee.fr/def/geo#subdivision</seealso>
    let subdivision = Prefixed_Name(igeo, "subdivision") |> PrefixedName
    /// <summary>
    ///   <para>igeo:subdivisionDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Un territoire dont le sujet est une subdivision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subdivision de"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#subdivisionDe">http://rdf.insee.fr/def/geo#subdivisionDe</seealso>
    let subdivisionDe = Prefixed_Name(igeo, "subdivisionDe") |> PrefixedName
    /// <summary>
    ///   <para>igeo:subdivisionDirecte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"L'objet de cette propriété est une subdivision administrative directe du sujet."</para>
    /// labels<para>"subdivision directe"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#subdivisionDirecte">http://rdf.insee.fr/def/geo#subdivisionDirecte</seealso>
    let subdivisionDirecte = Prefixed_Name(igeo, "subdivisionDirecte") |> PrefixedName
    /// <summary>
    ///   <para>igeo:territoireDOrigine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"territoire d'origine"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#territoireDOrigine">http://rdf.insee.fr/def/geo#territoireDOrigine</seealso>
    let territoireDOrigine = Prefixed_Name(igeo, "territoireDOrigine") |> PrefixedName

    /// <summary>
    ///   <para>igeo:territoireDeRattachement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"territoire de rattachement"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#territoireDeRattachement">http://rdf.insee.fr/def/geo#territoireDeRattachement</seealso>
    let territoireDeRattachement =
        Prefixed_Name(igeo, "territoireDeRattachement") |> PrefixedName

    /// <summary>
    ///   <para>igeo:territoireModifie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"territoire modifié"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#territoireModifie">http://rdf.insee.fr/def/geo#territoireModifie</seealso>
    let territoireModifie = Prefixed_Name(igeo, "territoireModifie") |> PrefixedName
    /// <summary>
    ///   <para>igeo:typeDEPCI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"type d'EPCI"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#typeDEPCI">http://rdf.insee.fr/def/geo#typeDEPCI</seealso>
    let typeDEPCI = Prefixed_Name(igeo, "typeDEPCI") |> PrefixedName
    /// <summary>
    ///   <para>igeo:typeDIRIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"type d'IRIS"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#typeDIRIS">http://rdf.insee.fr/def/geo#typeDIRIS</seealso>
    let typeDIRIS = Prefixed_Name(igeo, "typeDIRIS") |> PrefixedName
    /// <summary>
    ///   <para>igeo:vivant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"La valeur par défaut 'true' indique que le territoire existe actuellement. La valeur 'false' indique un territoire mort suite à un événement de modification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"vivant"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#vivant">http://rdf.insee.fr/def/geo#vivant</seealso>
    let vivant = Prefixed_Name(igeo, "vivant") |> PrefixedName
    /// <summary>
    ///   <para>igeo:voisin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Un territoire ayant une frontière commune"</para>
    /// labels<para>"voisin"</para></remarks>
    /// <seealso href="http://rdf.insee.fr/def/geo#voisin">http://rdf.insee.fr/def/geo#voisin</seealso>
    let voisin = Prefixed_Name(igeo, "voisin") |> PrefixedName
