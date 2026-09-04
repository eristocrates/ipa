#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module geofla =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.ign.fr/def/geofla#" "geofla"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Arrondissementrdfs:label : Arrondissement</para>
    ///   <para>rdfs:comment : Cette classe contient l'ensemble des arrondissements (ce sont les arrondissements au sens INSEE, et non les arrondissements municipaux).</para>
    ///   <a href="http://data.ign.fr/def/geofla#Arrondissement">geofla:Arrondissement</a>
    /// </summary>
    let Arrondissement = _prefixId.prefix "Arrondissement"
    let ArrondissementMunicipal = _prefixId.prefix "ArrondissementMunicipal"
    /// <summary>
    ///   <para>rdfs:label : Cantonrdfs:label : Canton</para>
    ///   <para>rdfs:comment : Les cantons contenus dans les différentes bases de données de l'IGN sont des cantons au sens INSEE du terme, appelés pseudo-cantons. Un pseudo-canton, quant à lui, est un regroupement d'une ou plusieurs communes entières.</para>
    ///   <a href="http://data.ign.fr/def/geofla#Canton">geofla:Canton</a>
    /// </summary>
    let Canton = _prefixId.prefix "Canton"
    /// <summary>
    ///   <para>rdfs:label : Communerdfs:label : Commune</para>
    ///   <para>rdfs:comment : Cette classe contient l'ensemble des communes métropolitaines, des 5 départements d'outre-mer (Guadeloupe, Martinique, Guyane, La Réunion et Mayotte).</para>
    ///   <a href="http://data.ign.fr/def/geofla#Commune">geofla:Commune</a>
    /// </summary>
    let Commune = _prefixId.prefix "Commune"
    /// <summary>
    ///   <para>rdfs:label : Départementrdfs:label : Department</para>
    ///   <para>rdfs:comment : Cette classe contient l'ensemble des départements.</para>
    ///   <a href="http://data.ign.fr/def/geofla#Departement">geofla:Departement</a>
    /// </summary>
    let Departement = _prefixId.prefix "Departement"
    /// <summary>
    ///   <para>rdfs:label : Regionrdfs:label : Région</para>
    ///   <para>rdfs:comment : Cette classe contient l'ensemble des régions.</para>
    ///   <a href="http://data.ign.fr/def/geofla#Region">geofla:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : Type de communerdfs:label : Type of commune</para>
    ///   <a href="http://data.ign.fr/def/geofla#TypeDeCommune">geofla:TypeDeCommune</a>
    /// </summary>
    let TypeDeCommune = _prefixId.prefix "TypeDeCommune"
    /// <summary>
    ///   <para>rdfs:label : Administrative subdivisionrdfs:label : Unité administrative</para>
    ///   <para>rdfs:comment : Objet géographique résultant du découpage administratif du territoire français.</para>
    ///   <a href="http://data.ign.fr/def/geofla#UniteAdministrative">geofla:UniteAdministrative</a>
    /// </summary>
    let UniteAdministrative = _prefixId.prefix "UniteAdministrative"
    /// <summary>
    ///   <para>rdfs:label : appartient à l'arrondisssementrdfs:label : belongs to arrondisssement</para>
    ///   <para>rdfs:comment : Arrondissement auquel appartient l'unité administrative.</para>
    ///   <a href="http://data.ign.fr/def/geofla#arr">geofla:arr</a>
    /// </summary>
    let arr = _prefixId.prefix "arr"
    /// <summary>
    ///   <para>rdfs:label : appartient au cantonrdfs:label : belongs to canton</para>
    ///   <para>rdfs:comment : Canton auquel appartient l'unité administrative.</para>
    ///   <a href="http://data.ign.fr/def/geofla#cant">geofla:cant</a>
    /// </summary>
    let cant = _prefixId.prefix "cant"
    /// <summary>
    ///   <para>rdfs:label : chef-lieu de l'unité administrativerdfs:label : capital of the administrative subdivision</para>
    ///   <para>rdfs:comment : Chef-lieu de l'unité administrative lorsqu'il existe (un canton ne possède pas toujours de chef-lieu. Cela arrive dans le cas de cantons situés à la périphérie d'une ville importante constituant à elle seule un canton non précisé.)</para>
    ///   <a href="http://data.ign.fr/def/geofla#chefLieu">geofla:chefLieu</a>
    /// </summary>
    let chefLieu = _prefixId.prefix "chefLieu"
    /// <summary>
    ///   <para>rdfs:label : geographic code of the arrondissementrdfs:label : code géographique de l'arrondissement</para>
    ///   <para>rdfs:comment : Code géographique de l'arrondissement (texte d'un caractère).</para>
    ///   <a href="http://data.ign.fr/def/geofla#codeArr">geofla:codeArr</a>
    /// </summary>
    let codeArr = _prefixId.prefix "codeArr"
    /// <summary>
    ///   <para>rdfs:label : code géographique du cantonrdfs:label : geographic code of the canton</para>
    ///   <para>rdfs:comment : Il s'agit du code géographique permettant d'identifier le canton dans son département d'appartenance (texte de deux caractères).</para>
    ///   <a href="http://data.ign.fr/def/geofla#codeCant">geofla:codeCant</a>
    /// </summary>
    let codeCant = _prefixId.prefix "codeCant"
    /// <summary>
    ///   <para>rdfs:label : code géographique de la communerdfs:label : geographic code of the commune</para>
    ///   <para>rdfs:comment : Il s'agit du code géographique permettant d'identifier la commune dans son département d'appartenance (texte de trois caractères).</para>
    ///   <a href="http://data.ign.fr/def/geofla#codeComm">geofla:codeComm</a>
    /// </summary>
    let codeComm = _prefixId.prefix "codeComm"
    /// <summary>
    ///   <para>rdfs:label : code géographique du départementrdfs:label : geographic code of the department</para>
    ///   <para>rdfs:comment : Code géographique du département (texte de deux caractères).</para>
    ///   <a href="http://data.ign.fr/def/geofla#codeDpt">geofla:codeDpt</a>
    /// </summary>
    let codeDpt = _prefixId.prefix "codeDpt"
    /// <summary>
    ///   <para>rdfs:label : code géographique de la régionrdfs:label : geographic code of the region</para>
    ///   <para>rdfs:comment : Code géographique de la région (texte de deux caractères).</para>
    ///   <a href="http://data.ign.fr/def/geofla#codeReg">geofla:codeReg</a>
    /// </summary>
    let codeReg = _prefixId.prefix "codeReg"
    /// <summary>
    ///   <para>rdfs:label : appartient au départementrdfs:label : belongs to department</para>
    ///   <para>rdfs:comment : Département auquel appartient l'unité administrative</para>
    ///   <a href="http://data.ign.fr/def/geofla#dpt">geofla:dpt</a>
    /// </summary>
    let dpt = _prefixId.prefix "dpt"
    /// <summary>
    ///   <para>rdfs:label : numéro insee de la communerdfs:label : insee identifier of the commune</para>
    ///   <para>rdfs:comment : Il s'agit d'un numéro de 5 caractères : le code du département suivi du code géographique de la commune. Pour les DOM, le 3ème caractère est commun au numéro de département et au numéro de commune.</para>
    ///   <a href="http://data.ign.fr/def/geofla#numInsee">geofla:numInsee</a>
    /// </summary>
    let numInsee = _prefixId.prefix "numInsee"
    /// <summary>
    ///   <para>rdfs:label : populationrdfs:label : population</para>
    ///   <para>rdfs:comment : Chiffre de population sans doubles comptes au dernier recensement, en milliers d'habitants, à une décimale. </para>
    ///   <a href="http://data.ign.fr/def/geofla#population">geofla:population</a>
    /// </summary>
    let population = _prefixId.prefix "population"
    /// <summary>
    ///   <para>rdfs:label : appartient à la régionrdfs:label : belongs to region</para>
    ///   <para>rdfs:comment : Région à laquelle appartient l'unité administrative.</para>
    ///   <a href="http://data.ign.fr/def/geofla#region">geofla:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : siège du chef-lieurdfs:label : head office of the capital</para>
    ///   <para>rdfs:comment : Point qui représente la localisation du siège du chef-lieu de l'unité administrative.</para>
    ///   <a href="http://data.ign.fr/def/geofla#siegeDuChefLieu">geofla:siegeDuChefLieu</a>
    /// </summary>
    let siegeDuChefLieu = _prefixId.prefix "siegeDuChefLieu"
    /// <summary>
    ///   <para>rdfs:label : statutrdfs:label : status</para>
    ///   <a href="http://data.ign.fr/def/geofla#statut">geofla:statut</a>
    /// </summary>
    let statut = _prefixId.prefix "statut"
    /// <summary>
    ///   <para>rdfs:label : superficie en hectaresrdfs:label : area in hectares</para>
    ///   <para>rdfs:comment : Superficie de la commune en hectares.</para>
    ///   <a href="http://data.ign.fr/def/geofla#superficieHa">geofla:superficieHa</a>
    /// </summary>
    let superficieHa = _prefixId.prefix "superficieHa"
    /// <summary>
    ///   <para>rdfs:label : altitude moyennerdfs:label : mean altitude</para>
    ///   <para>rdfs:comment : Altitude moyenne de la commune en mètres.</para>
    ///   <a href="http://data.ign.fr/def/geofla#zMoyen">geofla:zMoyen</a>
    /// </summary>
    let zMoyen = _prefixId.prefix "zMoyen"
