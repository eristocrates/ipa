namespace http.data.ign.fr.def.geofla.hash

open DoxAletheia.Rdf_Vocabulary

module geofla =
    let _namespace_name = "http://data.ign.fr/def/geofla#"

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Arrondissement"></see>
    /// </summary>
    let Arrondissement =
        Namespaced_IRI.parse _namespace_name "Arrondissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#UniteAdministrative"></see>
    /// </summary>
    let UniteAdministrative =
        Namespaced_IRI.parse _namespace_name "UniteAdministrative" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Canton"></see>
    /// </summary>
    let Canton = Namespaced_IRI.parse _namespace_name "Canton" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Commune"></see>
    /// </summary>
    let Commune = Namespaced_IRI.parse _namespace_name "Commune" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Departement"></see>
    /// </summary>
    let Departement =
        Namespaced_IRI.parse _namespace_name "Departement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#TypeDeCommune"></see>
    /// </summary>
    let TypeDeCommune =
        Namespaced_IRI.parse _namespace_name "TypeDeCommune" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#arr"></see>
    /// </summary>
    let arr = Namespaced_IRI.parse _namespace_name "arr" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#cant"></see>
    /// </summary>
    let cant = Namespaced_IRI.parse _namespace_name "cant" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#chefLieu"></see>
    /// </summary>
    let chefLieu = Namespaced_IRI.parse _namespace_name "chefLieu" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeArr"></see>
    /// </summary>
    let codeArr = Namespaced_IRI.parse _namespace_name "codeArr" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeCant"></see>
    /// </summary>
    let codeCant = Namespaced_IRI.parse _namespace_name "codeCant" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeComm"></see>
    /// </summary>
    let codeComm = Namespaced_IRI.parse _namespace_name "codeComm" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeDpt"></see>
    /// </summary>
    let codeDpt = Namespaced_IRI.parse _namespace_name "codeDpt" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#codeReg"></see>
    /// </summary>
    let codeReg = Namespaced_IRI.parse _namespace_name "codeReg" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#dpt"></see>
    /// </summary>
    let dpt = Namespaced_IRI.parse _namespace_name "dpt" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#numInsee"></see>
    /// </summary>
    let numInsee = Namespaced_IRI.parse _namespace_name "numInsee" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#population"></see>
    /// </summary>
    let population = Namespaced_IRI.parse _namespace_name "population" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#region"></see>
    /// </summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#siegeDuChefLieu"></see>
    /// </summary>
    let siegeDuChefLieu =
        Namespaced_IRI.parse _namespace_name "siegeDuChefLieu" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#statut"></see>
    /// </summary>
    let statut = Namespaced_IRI.parse _namespace_name "statut" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#superficieHa"></see>
    /// </summary>
    let superficieHa =
        Namespaced_IRI.parse _namespace_name "superficieHa" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#zMoyen"></see>
    /// </summary>
    let zMoyen = Namespaced_IRI.parse _namespace_name "zMoyen" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geofla#ArrondissementMunicipal"></see>
    /// </summary>
    let ArrondissementMunicipal =
        Namespaced_IRI.parse _namespace_name "ArrondissementMunicipal" |> NamespacedName
