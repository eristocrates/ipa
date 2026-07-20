namespace http.dati.cdec.it.lod.shoah.slash

open DoxAletheia

module shoah =
    let _namespace_name = "http://dati.cdec.it/lod/shoah/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/www.cdec.it"></see>
    /// </summary>
    let ``www.cdec.it`` = _prefix "www.cdec.it"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/www.regesta.com"></see>
    /// </summary>
    let ``www.regesta.com`` = _prefix "www.regesta.com"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/0.1"></see>
    /// </summary>
    let ``_0.1`` = _prefix "0.1"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Convoy"></see>
    /// </summary>
    let Convoy = _prefix "Convoy"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/DetentionPlace"></see>
    /// </summary>
    let DetentionPlace = _prefix "DetentionPlace"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/DetentionPlaceTransfer"></see>
    /// </summary>
    let DetentionPlaceTransfer = _prefix "DetentionPlaceTransfer"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Liberation"></see>
    /// </summary>
    let Liberation = _prefix "Liberation"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Massacre"></see>
    /// </summary>
    let Massacre = _prefix "Massacre"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/NaziCamp"></see>
    /// </summary>
    let NaziCamp = _prefix "NaziCamp"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/NaziCampTransfer"></see>
    /// </summary>
    let NaziCampTransfer = _prefix "NaziCampTransfer"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Persecution"></see>
    /// </summary>
    let Persecution = _prefix "Persecution"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrestDate"></see>
    /// </summary>
    let arrestDate = _prefix "arrestDate"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrestPlace"></see>
    /// </summary>
    let arrestPlace = _prefix "arrestPlace"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrestedBy"></see>
    /// </summary>
    let arrestedBy = _prefix "arrestedBy"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/arrivalDate"></see>
    /// </summary>
    let arrivalDate = _prefix "arrivalDate"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/auntOf"></see>
    /// </summary>
    let auntOf = _prefix "auntOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/brotherOf"></see>
    /// </summary>
    let brotherOf = _prefix "brotherOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/campSerialNumber"></see>
    /// </summary>
    let campSerialNumber = _prefix "campSerialNumber"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortFamilyName"></see>
    /// </summary>
    let consortFamilyName = _prefix "consortFamilyName"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortFirstName"></see>
    /// </summary>
    let consortFirstName = _prefix "consortFirstName"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortOf"></see>
    /// </summary>
    let consortOf = _prefix "consortOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/consortReligion"></see>
    /// </summary>
    let consortReligion = _prefix "consortReligion"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/convoy"></see>
    /// </summary>
    let convoy = _prefix "convoy"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/convoyDeparturePlace"></see>
    /// </summary>
    let convoyDeparturePlace = _prefix "convoyDeparturePlace"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/convoyNumber"></see>
    /// </summary>
    let convoyNumber = _prefix "convoyNumber"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/country"></see>
    /// </summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/dateOfBirth"></see>
    /// </summary>
    let dateOfBirth = _prefix "dateOfBirth"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/dateOfDeath"></see>
    /// </summary>
    let dateOfDeath = _prefix "dateOfDeath"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/deathDescription"></see>
    /// </summary>
    let deathDescription = _prefix "deathDescription"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/deathInItaly"></see>
    /// </summary>
    let deathInItaly = _prefix "deathInItaly"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/departureDate"></see>
    /// </summary>
    let departureDate = _prefix "departureDate"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/detentionPlace"></see>
    /// </summary>
    let detentionPlace = _prefix "detentionPlace"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/detentionPlaceTransfer"></see>
    /// </summary>
    let detentionPlaceTransfer = _prefix "detentionPlaceTransfer"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/districtOfResidence"></see>
    /// </summary>
    let districtOfResidence = _prefix "districtOfResidence"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fatherName"></see>
    /// </summary>
    let fatherName = _prefix "fatherName"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fatherOf"></see>
    /// </summary>
    let fatherOf = _prefix "fatherOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fromNaziCamp"></see>
    /// </summary>
    let fromNaziCamp = _prefix "fromNaziCamp"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/fromPrison"></see>
    /// </summary>
    let fromPrison = _prefix "fromPrison"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/grandfatherOf"></see>
    /// </summary>
    let grandfatherOf = _prefix "grandfatherOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/grandmotherOf"></see>
    /// </summary>
    let grandmotherOf = _prefix "grandmotherOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/liberation"></see>
    /// </summary>
    let liberation = _prefix "liberation"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/liberationDate"></see>
    /// </summary>
    let liberationDate = _prefix "liberationDate"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/massacre"></see>
    /// </summary>
    let massacre = _prefix "massacre"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/motherMaidenName"></see>
    /// </summary>
    let motherMaidenName = _prefix "motherMaidenName"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/motherName"></see>
    /// </summary>
    let motherName = _prefix "motherName"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/motherOf"></see>
    /// </summary>
    let motherOf = _prefix "motherOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/naziCampTransfer"></see>
    /// </summary>
    let naziCampTransfer = _prefix "naziCampTransfer"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/parentPlace"></see>
    /// </summary>
    let parentPlace = _prefix "parentPlace"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/parentReligion"></see>
    /// </summary>
    let parentReligion = _prefix "parentReligion"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/persecution"></see>
    /// </summary>
    let persecution = _prefix "persecution"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/persecutionCategory"></see>
    /// </summary>
    let persecutionCategory = _prefix "persecutionCategory"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/placeOfBirth"></see>
    /// </summary>
    let placeOfBirth = _prefix "placeOfBirth"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/placeOfDeath"></see>
    /// </summary>
    let placeOfDeath = _prefix "placeOfDeath"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/returnDate"></see>
    /// </summary>
    let returnDate = _prefix "returnDate"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/returnPlace"></see>
    /// </summary>
    let returnPlace = _prefix "returnPlace"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/shoahSurvivor"></see>
    /// </summary>
    let shoahSurvivor = _prefix "shoahSurvivor"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/sisterOf"></see>
    /// </summary>
    let sisterOf = _prefix "sisterOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/subCampOf"></see>
    /// </summary>
    let subCampOf = _prefix "subCampOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/toNaziCamp"></see>
    /// </summary>
    let toNaziCamp = _prefix "toNaziCamp"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/toPrison"></see>
    /// </summary>
    let toPrison = _prefix "toPrison"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/transferDate"></see>
    /// </summary>
    let transferDate = _prefix "transferDate"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/uncleOf"></see>
    /// </summary>
    let uncleOf = _prefix "uncleOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/widowOf"></see>
    /// </summary>
    let widowOf = _prefix "widowOf"
    /// <summary>
    ///   <see href="http://dati.cdec.it/lod/shoah/widowerOf"></see>
    /// </summary>
    let widowerOf = _prefix "widowerOf"
