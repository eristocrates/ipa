namespace http.dati.cdec.it.lod.shoah.slash

open DoxAletheia.Rdf_Vocabulary

module shoah =
    let _namespace_name = "http://dati.cdec.it/lod/shoah/"

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/www.cdec.it"></see>
    /// </summary>
    let ``www.cdec.it`` =
        Namespaced_IRI.parse _namespace_name "www.cdec.it" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/www.regesta.com"></see>
    /// </summary>
    let ``www.regesta.com`` =
        Namespaced_IRI.parse _namespace_name "www.regesta.com" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/0.1"></see>
    /// </summary>
    let ``_0.1`` = Namespaced_IRI.parse _namespace_name "0.1" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Convoy"></see>
    /// </summary>
    let Convoy = Namespaced_IRI.parse _namespace_name "Convoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/DetentionPlace"></see>
    /// </summary>
    let DetentionPlace =
        Namespaced_IRI.parse _namespace_name "DetentionPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/DetentionPlaceTransfer"></see>
    /// </summary>
    let DetentionPlaceTransfer =
        Namespaced_IRI.parse _namespace_name "DetentionPlaceTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Liberation"></see>
    /// </summary>
    let Liberation = Namespaced_IRI.parse _namespace_name "Liberation" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Massacre"></see>
    /// </summary>
    let Massacre = Namespaced_IRI.parse _namespace_name "Massacre" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/NaziCamp"></see>
    /// </summary>
    let NaziCamp = Namespaced_IRI.parse _namespace_name "NaziCamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/NaziCampTransfer"></see>
    /// </summary>
    let NaziCampTransfer =
        Namespaced_IRI.parse _namespace_name "NaziCampTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Persecution"></see>
    /// </summary>
    let Persecution =
        Namespaced_IRI.parse _namespace_name "Persecution" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrestDate"></see>
    /// </summary>
    let arrestDate = Namespaced_IRI.parse _namespace_name "arrestDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrestPlace"></see>
    /// </summary>
    let arrestPlace =
        Namespaced_IRI.parse _namespace_name "arrestPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrestedBy"></see>
    /// </summary>
    let arrestedBy = Namespaced_IRI.parse _namespace_name "arrestedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrivalDate"></see>
    /// </summary>
    let arrivalDate =
        Namespaced_IRI.parse _namespace_name "arrivalDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/auntOf"></see>
    /// </summary>
    let auntOf = Namespaced_IRI.parse _namespace_name "auntOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/brotherOf"></see>
    /// </summary>
    let brotherOf = Namespaced_IRI.parse _namespace_name "brotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/campSerialNumber"></see>
    /// </summary>
    let campSerialNumber =
        Namespaced_IRI.parse _namespace_name "campSerialNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortFamilyName"></see>
    /// </summary>
    let consortFamilyName =
        Namespaced_IRI.parse _namespace_name "consortFamilyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortFirstName"></see>
    /// </summary>
    let consortFirstName =
        Namespaced_IRI.parse _namespace_name "consortFirstName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortOf"></see>
    /// </summary>
    let consortOf = Namespaced_IRI.parse _namespace_name "consortOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortReligion"></see>
    /// </summary>
    let consortReligion =
        Namespaced_IRI.parse _namespace_name "consortReligion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/convoy"></see>
    /// </summary>
    let convoy = Namespaced_IRI.parse _namespace_name "convoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/convoyDeparturePlace"></see>
    /// </summary>
    let convoyDeparturePlace =
        Namespaced_IRI.parse _namespace_name "convoyDeparturePlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/convoyNumber"></see>
    /// </summary>
    let convoyNumber =
        Namespaced_IRI.parse _namespace_name "convoyNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/dateOfBirth"></see>
    /// </summary>
    let dateOfBirth =
        Namespaced_IRI.parse _namespace_name "dateOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/dateOfDeath"></see>
    /// </summary>
    let dateOfDeath =
        Namespaced_IRI.parse _namespace_name "dateOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/deathDescription"></see>
    /// </summary>
    let deathDescription =
        Namespaced_IRI.parse _namespace_name "deathDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/deathInItaly"></see>
    /// </summary>
    let deathInItaly =
        Namespaced_IRI.parse _namespace_name "deathInItaly" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/departureDate"></see>
    /// </summary>
    let departureDate =
        Namespaced_IRI.parse _namespace_name "departureDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/detentionPlace"></see>
    /// </summary>
    let detentionPlace =
        Namespaced_IRI.parse _namespace_name "detentionPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/detentionPlaceTransfer"></see>
    /// </summary>
    let detentionPlaceTransfer =
        Namespaced_IRI.parse _namespace_name "detentionPlaceTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/districtOfResidence"></see>
    /// </summary>
    let districtOfResidence =
        Namespaced_IRI.parse _namespace_name "districtOfResidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fatherName"></see>
    /// </summary>
    let fatherName = Namespaced_IRI.parse _namespace_name "fatherName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fatherOf"></see>
    /// </summary>
    let fatherOf = Namespaced_IRI.parse _namespace_name "fatherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fromNaziCamp"></see>
    /// </summary>
    let fromNaziCamp =
        Namespaced_IRI.parse _namespace_name "fromNaziCamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fromPrison"></see>
    /// </summary>
    let fromPrison = Namespaced_IRI.parse _namespace_name "fromPrison" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/grandfatherOf"></see>
    /// </summary>
    let grandfatherOf =
        Namespaced_IRI.parse _namespace_name "grandfatherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/grandmotherOf"></see>
    /// </summary>
    let grandmotherOf =
        Namespaced_IRI.parse _namespace_name "grandmotherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/liberation"></see>
    /// </summary>
    let liberation = Namespaced_IRI.parse _namespace_name "liberation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/liberationDate"></see>
    /// </summary>
    let liberationDate =
        Namespaced_IRI.parse _namespace_name "liberationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/massacre"></see>
    /// </summary>
    let massacre = Namespaced_IRI.parse _namespace_name "massacre" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/motherMaidenName"></see>
    /// </summary>
    let motherMaidenName =
        Namespaced_IRI.parse _namespace_name "motherMaidenName" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/motherName"></see>
    /// </summary>
    let motherName = Namespaced_IRI.parse _namespace_name "motherName" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/motherOf"></see>
    /// </summary>
    let motherOf = Namespaced_IRI.parse _namespace_name "motherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/naziCampTransfer"></see>
    /// </summary>
    let naziCampTransfer =
        Namespaced_IRI.parse _namespace_name "naziCampTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/parentPlace"></see>
    /// </summary>
    let parentPlace =
        Namespaced_IRI.parse _namespace_name "parentPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/parentReligion"></see>
    /// </summary>
    let parentReligion =
        Namespaced_IRI.parse _namespace_name "parentReligion" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/persecution"></see>
    /// </summary>
    let persecution =
        Namespaced_IRI.parse _namespace_name "persecution" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/persecutionCategory"></see>
    /// </summary>
    let persecutionCategory =
        Namespaced_IRI.parse _namespace_name "persecutionCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/placeOfBirth"></see>
    /// </summary>
    let placeOfBirth =
        Namespaced_IRI.parse _namespace_name "placeOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/placeOfDeath"></see>
    /// </summary>
    let placeOfDeath =
        Namespaced_IRI.parse _namespace_name "placeOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/returnDate"></see>
    /// </summary>
    let returnDate = Namespaced_IRI.parse _namespace_name "returnDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/returnPlace"></see>
    /// </summary>
    let returnPlace =
        Namespaced_IRI.parse _namespace_name "returnPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/shoahSurvivor"></see>
    /// </summary>
    let shoahSurvivor =
        Namespaced_IRI.parse _namespace_name "shoahSurvivor" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/sisterOf"></see>
    /// </summary>
    let sisterOf = Namespaced_IRI.parse _namespace_name "sisterOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/subCampOf"></see>
    /// </summary>
    let subCampOf = Namespaced_IRI.parse _namespace_name "subCampOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/toNaziCamp"></see>
    /// </summary>
    let toNaziCamp = Namespaced_IRI.parse _namespace_name "toNaziCamp" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/toPrison"></see>
    /// </summary>
    let toPrison = Namespaced_IRI.parse _namespace_name "toPrison" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/transferDate"></see>
    /// </summary>
    let transferDate =
        Namespaced_IRI.parse _namespace_name "transferDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/uncleOf"></see>
    /// </summary>
    let uncleOf = Namespaced_IRI.parse _namespace_name "uncleOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/widowOf"></see>
    /// </summary>
    let widowOf = Namespaced_IRI.parse _namespace_name "widowOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/widowerOf"></see>
    /// </summary>
    let widowerOf = Namespaced_IRI.parse _namespace_name "widowerOf" |> NamespacedName
