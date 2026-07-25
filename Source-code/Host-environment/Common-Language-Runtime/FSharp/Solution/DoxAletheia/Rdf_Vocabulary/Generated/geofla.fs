namespace http.data.ign.fr.def.geofla.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geofla =
    let _namespace_iri = Namespace_Iri geofla |> NamespaceIRI
    /// <summary>
    ///   <para>geofla:Arrondissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cette classe contient l'ensemble des arrondissements (ce sont les arrondissements au sens INSEE, et non les arrondissements municipaux).</para>
    /// labels<para>Arrondissement</para><para>Arrondissement</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#Arrondissement">http://data.ign.fr/def/geofla#Arrondissement</seealso>
    let Arrondissement = Prefixed_Name(geofla, "Arrondissement") |> PrefixedName
    /// <summary>
    ///   <para>geofla:Departement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cette classe contient l'ensemble des départements.</para>
    /// labels<para>Département</para><para>Department</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#Departement">http://data.ign.fr/def/geofla#Departement</seealso>
    let Departement = Prefixed_Name(geofla, "Departement") |> PrefixedName
    /// <summary>
    ///   <para>geofla:Commune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cette classe contient l'ensemble des communes métropolitaines, des 5 départements d'outre-mer (Guadeloupe, Martinique, Guyane, La Réunion et Mayotte).</para>
    /// labels<para>Commune</para><para>Commune</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#Commune">http://data.ign.fr/def/geofla#Commune</seealso>
    let Commune = Prefixed_Name(geofla, "Commune") |> PrefixedName
    /// <summary>
    ///   <para>geofla:TypeDeCommune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Type of commune</para><para>Type de commune</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#TypeDeCommune">http://data.ign.fr/def/geofla#TypeDeCommune</seealso>
    let TypeDeCommune = Prefixed_Name(geofla, "TypeDeCommune") |> PrefixedName
    /// <summary>
    ///   <para>geofla:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cette classe contient l'ensemble des régions.</para>
    /// labels<para>Region</para><para>Région</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#Region">http://data.ign.fr/def/geofla#Region</seealso>
    let Region = Prefixed_Name(geofla, "Region") |> PrefixedName
    /// <summary>
    ///   <para>geofla:arr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Arrondissement auquel appartient l'unité administrative.</para>
    /// labels<para>appartient à l'arrondisssement</para><para>belongs to arrondisssement</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#arr">http://data.ign.fr/def/geofla#arr</seealso>
    let arr = Prefixed_Name(geofla, "arr") |> PrefixedName
    /// <summary>
    ///   <para>geofla:chefLieu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Chef-lieu de l'unité administrative lorsqu'il existe (un canton ne possède pas toujours de chef-lieu. Cela arrive dans le cas de cantons situés à la périphérie d'une ville importante constituant à elle seule un canton non précisé.)</para>
    /// labels<para>capital of the administrative subdivision</para><para>chef-lieu de l'unité administrative</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#chefLieu">http://data.ign.fr/def/geofla#chefLieu</seealso>
    let chefLieu = Prefixed_Name(geofla, "chefLieu") |> PrefixedName
    /// <summary>
    ///   <para>geofla:cant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Canton auquel appartient l'unité administrative.</para>
    /// labels<para>appartient au canton</para><para>belongs to canton</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#cant">http://data.ign.fr/def/geofla#cant</seealso>
    let cant = Prefixed_Name(geofla, "cant") |> PrefixedName
    /// <summary>
    ///   <para>geofla:codeArr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code géographique de l'arrondissement (texte d'un caractère).</para>
    /// labels<para>code géographique de l'arrondissement</para><para>geographic code of the arrondissement</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#codeArr">http://data.ign.fr/def/geofla#codeArr</seealso>
    let codeArr = Prefixed_Name(geofla, "codeArr") |> PrefixedName
    /// <summary>
    ///   <para>geofla:codeDpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code géographique du département (texte de deux caractères).</para>
    /// labels<para>geographic code of the department</para><para>code géographique du département</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#codeDpt">http://data.ign.fr/def/geofla#codeDpt</seealso>
    let codeDpt = Prefixed_Name(geofla, "codeDpt") |> PrefixedName
    /// <summary>
    ///   <para>geofla:codeCant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Il s'agit du code géographique permettant d'identifier le canton dans son département d'appartenance (texte de deux caractères).</para>
    /// labels<para>geographic code of the canton</para><para>code géographique du canton</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#codeCant">http://data.ign.fr/def/geofla#codeCant</seealso>
    let codeCant = Prefixed_Name(geofla, "codeCant") |> PrefixedName
    /// <summary>
    ///   <para>geofla:codeComm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Il s'agit du code géographique permettant d'identifier la commune dans son département d'appartenance (texte de trois caractères).</para>
    /// labels<para>code géographique de la commune</para><para>geographic code of the commune</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#codeComm">http://data.ign.fr/def/geofla#codeComm</seealso>
    let codeComm = Prefixed_Name(geofla, "codeComm") |> PrefixedName
    /// <summary>
    ///   <para>geofla:dpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Département auquel appartient l'unité administrative</para>
    /// labels<para>appartient au département</para><para>belongs to department</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#dpt">http://data.ign.fr/def/geofla#dpt</seealso>
    let dpt = Prefixed_Name(geofla, "dpt") |> PrefixedName
    /// <summary>
    ///   <para>geofla:numInsee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Il s'agit d'un numéro de 5 caractères : le code du département suivi du code géographique de la commune. Pour les DOM, le 3ème caractère est commun au numéro de département et au numéro de commune.</para>
    /// labels<para>insee identifier of the commune</para><para>numéro insee de la commune</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#numInsee">http://data.ign.fr/def/geofla#numInsee</seealso>
    let numInsee = Prefixed_Name(geofla, "numInsee") |> PrefixedName
    /// <summary>
    ///   <para>geofla:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Région à laquelle appartient l'unité administrative.</para>
    /// labels<para>appartient à la région</para><para>belongs to region</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#region">http://data.ign.fr/def/geofla#region</seealso>
    let region = Prefixed_Name(geofla, "region") |> PrefixedName
    /// <summary>
    ///   <para>geofla:codeReg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code géographique de la région (texte de deux caractères).</para>
    /// labels<para>code géographique de la région</para><para>geographic code of the region</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#codeReg">http://data.ign.fr/def/geofla#codeReg</seealso>
    let codeReg = Prefixed_Name(geofla, "codeReg") |> PrefixedName
    /// <summary>
    ///   <para>geofla:population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Chiffre de population sans doubles comptes au dernier recensement, en milliers d'habitants, à une décimale. </para>
    /// labels<para>population</para><para>population</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#population">http://data.ign.fr/def/geofla#population</seealso>
    let population = Prefixed_Name(geofla, "population") |> PrefixedName
    /// <summary>
    ///   <para>geofla:siegeDuChefLieu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Point qui représente la localisation du siège du chef-lieu de l'unité administrative.</para>
    /// labels<para>head office of the capital</para><para>siège du chef-lieu</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#siegeDuChefLieu">http://data.ign.fr/def/geofla#siegeDuChefLieu</seealso>
    let siegeDuChefLieu = Prefixed_Name(geofla, "siegeDuChefLieu") |> PrefixedName
    /// <summary>
    ///   <para>geofla:statut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>status</para><para>statut</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#statut">http://data.ign.fr/def/geofla#statut</seealso>
    let statut = Prefixed_Name(geofla, "statut") |> PrefixedName
    /// <summary>
    ///   <para>geofla:zMoyen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Altitude moyenne de la commune en mètres.</para>
    /// labels<para>altitude moyenne</para><para>mean altitude</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#zMoyen">http://data.ign.fr/def/geofla#zMoyen</seealso>
    let zMoyen = Prefixed_Name(geofla, "zMoyen") |> PrefixedName

    /// <summary>
    ///   <para>geofla:ArrondissementMunicipal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#ArrondissementMunicipal">http://data.ign.fr/def/geofla#ArrondissementMunicipal</seealso>
    let ArrondissementMunicipal =
        Prefixed_Name(geofla, "ArrondissementMunicipal") |> PrefixedName

    /// <summary>
    ///   <para>geofla:superficieHa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Superficie de la commune en hectares.</para>
    /// labels<para>superficie en hectares</para><para>area in hectares</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#superficieHa">http://data.ign.fr/def/geofla#superficieHa</seealso>
    let superficieHa = Prefixed_Name(geofla, "superficieHa") |> PrefixedName
    /// <summary>
    ///   <para>geofla:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#">http://data.ign.fr/def/geofla#</seealso>
    let _prefix_iri = Prefixed_Name(geofla, "") |> PrefixedName

    /// <summary>
    ///   <para>geofla:UniteAdministrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Objet géographique résultant du découpage administratif du territoire français.</para>
    /// labels<para>Administrative subdivision</para><para>Unité administrative</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#UniteAdministrative">http://data.ign.fr/def/geofla#UniteAdministrative</seealso>
    let UniteAdministrative =
        Prefixed_Name(geofla, "UniteAdministrative") |> PrefixedName

    /// <summary>
    ///   <para>geofla:Canton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Les cantons contenus dans les différentes bases de données de l'IGN sont des cantons au sens INSEE du terme, appelés pseudo-cantons. Un pseudo-canton, quant à lui, est un regroupement d'une ou plusieurs communes entières.</para>
    /// labels<para>Canton</para><para>Canton</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geofla#Canton">http://data.ign.fr/def/geofla#Canton</seealso>
    let Canton = Prefixed_Name(geofla, "Canton") |> PrefixedName
