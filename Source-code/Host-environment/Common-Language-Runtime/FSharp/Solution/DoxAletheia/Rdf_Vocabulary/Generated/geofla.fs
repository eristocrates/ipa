namespace http.data.ign.fr.def.geofla.hash

open DoxAletheia

module geofla =
    let _namespace_name = "http://data.ign.fr/def/geofla#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Arrondissement"></see>
    /// </summary>
    let Arrondissement = _prefix "Arrondissement"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#UniteAdministrative"></see>
    /// </summary>
    let UniteAdministrative = _prefix "UniteAdministrative"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Canton"></see>
    /// </summary>
    let Canton = _prefix "Canton"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Commune"></see>
    /// </summary>
    let Commune = _prefix "Commune"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Departement"></see>
    /// </summary>
    let Departement = _prefix "Departement"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#TypeDeCommune"></see>
    /// </summary>
    let TypeDeCommune = _prefix "TypeDeCommune"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#arr"></see>
    /// </summary>
    let arr = _prefix "arr"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#cant"></see>
    /// </summary>
    let cant = _prefix "cant"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#chefLieu"></see>
    /// </summary>
    let chefLieu = _prefix "chefLieu"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeArr"></see>
    /// </summary>
    let codeArr = _prefix "codeArr"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeCant"></see>
    /// </summary>
    let codeCant = _prefix "codeCant"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeComm"></see>
    /// </summary>
    let codeComm = _prefix "codeComm"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeDpt"></see>
    /// </summary>
    let codeDpt = _prefix "codeDpt"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeReg"></see>
    /// </summary>
    let codeReg = _prefix "codeReg"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#dpt"></see>
    /// </summary>
    let dpt = _prefix "dpt"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#numInsee"></see>
    /// </summary>
    let numInsee = _prefix "numInsee"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#population"></see>
    /// </summary>
    let population = _prefix "population"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#region"></see>
    /// </summary>
    let region = _prefix "region"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#siegeDuChefLieu"></see>
    /// </summary>
    let siegeDuChefLieu = _prefix "siegeDuChefLieu"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#statut"></see>
    /// </summary>
    let statut = _prefix "statut"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#superficieHa"></see>
    /// </summary>
    let superficieHa = _prefix "superficieHa"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#zMoyen"></see>
    /// </summary>
    let zMoyen = _prefix "zMoyen"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#ArrondissementMunicipal"></see>
    /// </summary>
    let ArrondissementMunicipal = _prefix "ArrondissementMunicipal"
