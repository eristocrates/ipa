#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module shoah =
    let _prefixId = PrefixId.fromNamespaceLabel "http://dati.cdec.it/lod/shoah/" "shoah"
    let _namespaceIri = _prefixId.prefix ""
    let ``_0.1`` = _prefixId.prefix "0.1"
    /// <summary>
    ///   <para>rdfs:label : Convoy</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/Convoy">shoah:Convoy</a>
    /// </summary>
    let Convoy = _prefixId.prefix "Convoy"
    /// <summary>
    ///   <para>rdfs:label : Detention Place</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/DetentionPlace">shoah:DetentionPlace</a>
    /// </summary>
    let DetentionPlace = _prefixId.prefix "DetentionPlace"
    /// <summary>
    ///   <para>rdfs:label : Detention Place Transfer</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/DetentionPlaceTransfer">shoah:DetentionPlaceTransfer</a>
    /// </summary>
    let DetentionPlaceTransfer = _prefixId.prefix "DetentionPlaceTransfer"
    /// <summary>
    ///   <para>rdfs:label : Liberation</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/Liberation">shoah:Liberation</a>
    /// </summary>
    let Liberation = _prefixId.prefix "Liberation"
    /// <summary>
    ///   <para>rdfs:label : Massacre</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/Massacre">shoah:Massacre</a>
    /// </summary>
    let Massacre = _prefixId.prefix "Massacre"
    /// <summary>
    ///   <para>rdfs:label : Nazi Camp</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/NaziCamp">shoah:NaziCamp</a>
    /// </summary>
    let NaziCamp = _prefixId.prefix "NaziCamp"
    /// <summary>
    ///   <para>rdfs:label : Nazi Camp Transfer</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/NaziCampTransfer">shoah:NaziCampTransfer</a>
    /// </summary>
    let NaziCampTransfer = _prefixId.prefix "NaziCampTransfer"
    /// <summary>
    ///   <para>rdfs:label : Persecution</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/Persecution">shoah:Persecution</a>
    /// </summary>
    let Persecution = _prefixId.prefix "Persecution"
    /// <summary>
    ///   <para>rdfs:label : Place</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/Place">shoah:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Arrest Date</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/arrestDate">shoah:arrestDate</a>
    /// </summary>
    let arrestDate = _prefixId.prefix "arrestDate"
    /// <summary>
    ///   <para>rdfs:label : Arrest Place</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/arrestPlace">shoah:arrestPlace</a>
    /// </summary>
    let arrestPlace = _prefixId.prefix "arrestPlace"
    /// <summary>
    ///   <para>rdfs:label : Arrested By</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/arrestedBy">shoah:arrestedBy</a>
    /// </summary>
    let arrestedBy = _prefixId.prefix "arrestedBy"
    /// <summary>
    ///   <para>rdfs:label : Arrival Date</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/arrivalDate">shoah:arrivalDate</a>
    /// </summary>
    let arrivalDate = _prefixId.prefix "arrivalDate"
    /// <summary>
    ///   <para>rdfs:label : Aunt of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/auntOf">shoah:auntOf</a>
    /// </summary>
    let auntOf = _prefixId.prefix "auntOf"
    /// <summary>
    ///   <para>rdfs:label : Brother of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/brotherOf">shoah:brotherOf</a>
    /// </summary>
    let brotherOf = _prefixId.prefix "brotherOf"
    /// <summary>
    ///   <para>rdfs:label : Camp Serial Number</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/campSerialNumber">shoah:campSerialNumber</a>
    /// </summary>
    let campSerialNumber = _prefixId.prefix "campSerialNumber"
    /// <summary>
    ///   <para>rdfs:label : Consort Family Name</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/consortFamilyName">shoah:consortFamilyName</a>
    /// </summary>
    let consortFamilyName = _prefixId.prefix "consortFamilyName"
    /// <summary>
    ///   <para>rdfs:label : Consort First Name</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/consortFirstName">shoah:consortFirstName</a>
    /// </summary>
    let consortFirstName = _prefixId.prefix "consortFirstName"
    /// <summary>
    ///   <para>rdfs:label : Consort of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/consortOf">shoah:consortOf</a>
    /// </summary>
    let consortOf = _prefixId.prefix "consortOf"
    /// <summary>
    ///   <para>rdfs:label : Consort Religion</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/consortReligion">shoah:consortReligion</a>
    /// </summary>
    let consortReligion = _prefixId.prefix "consortReligion"
    /// <summary>
    ///   <para>rdfs:label : Convoy</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/convoy">shoah:convoy</a>
    /// </summary>
    let convoy = _prefixId.prefix "convoy"
    /// <summary>
    ///   <para>rdfs:label : Last Place before Deportation</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/convoyDeparturePlace">shoah:convoyDeparturePlace</a>
    /// </summary>
    let convoyDeparturePlace = _prefixId.prefix "convoyDeparturePlace"
    /// <summary>
    ///   <para>rdfs:label : Convoy Number</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/convoyNumber">shoah:convoyNumber</a>
    /// </summary>
    let convoyNumber = _prefixId.prefix "convoyNumber"
    /// <summary>
    ///   <para>rdfs:label : Country</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/country">shoah:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : Date of Birth</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/dateOfBirth">shoah:dateOfBirth</a>
    /// </summary>
    let dateOfBirth = _prefixId.prefix "dateOfBirth"
    /// <summary>
    ///   <para>rdfs:label : Date of Death</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/dateOfDeath">shoah:dateOfDeath</a>
    /// </summary>
    let dateOfDeath = _prefixId.prefix "dateOfDeath"
    /// <summary>
    ///   <para>rdfs:label : Death Description</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/deathDescription">shoah:deathDescription</a>
    /// </summary>
    let deathDescription = _prefixId.prefix "deathDescription"
    /// <summary>
    ///   <para>rdfs:label : Death in Italy</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/deathInItaly">shoah:deathInItaly</a>
    /// </summary>
    let deathInItaly = _prefixId.prefix "deathInItaly"
    /// <summary>
    ///   <para>rdfs:label : Departure Date</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/departureDate">shoah:departureDate</a>
    /// </summary>
    let departureDate = _prefixId.prefix "departureDate"
    /// <summary>
    ///   <para>rdfs:label : Detention Place</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/detentionPlace">shoah:detentionPlace</a>
    /// </summary>
    let detentionPlace = _prefixId.prefix "detentionPlace"
    /// <summary>
    ///   <para>rdfs:label : Detention Place Transfer</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/detentionPlaceTransfer">shoah:detentionPlaceTransfer</a>
    /// </summary>
    let detentionPlaceTransfer = _prefixId.prefix "detentionPlaceTransfer"
    /// <summary>
    ///   <para>rdfs:label : District of Residence</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/districtOfResidence">shoah:districtOfResidence</a>
    /// </summary>
    let districtOfResidence = _prefixId.prefix "districtOfResidence"
    /// <summary>
    ///   <para>rdfs:label : Father Name</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/fatherName">shoah:fatherName</a>
    /// </summary>
    let fatherName = _prefixId.prefix "fatherName"
    /// <summary>
    ///   <para>rdfs:label : Father of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/fatherOf">shoah:fatherOf</a>
    /// </summary>
    let fatherOf = _prefixId.prefix "fatherOf"
    /// <summary>
    ///   <para>rdfs:label : from Camp</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/fromNaziCamp">shoah:fromNaziCamp</a>
    /// </summary>
    let fromNaziCamp = _prefixId.prefix "fromNaziCamp"
    /// <summary>
    ///   <para>rdfs:label : from Prison</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/fromPrison">shoah:fromPrison</a>
    /// </summary>
    let fromPrison = _prefixId.prefix "fromPrison"
    /// <summary>
    ///   <para>rdfs:label : Grandfather of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/grandfatherOf">shoah:grandfatherOf</a>
    /// </summary>
    let grandfatherOf = _prefixId.prefix "grandfatherOf"
    /// <summary>
    ///   <para>rdfs:label : Grandmother of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/grandmotherOf">shoah:grandmotherOf</a>
    /// </summary>
    let grandmotherOf = _prefixId.prefix "grandmotherOf"
    /// <summary>
    ///   <para>rdfs:label : Liberation</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/liberation">shoah:liberation</a>
    /// </summary>
    let liberation = _prefixId.prefix "liberation"
    /// <summary>
    ///   <para>rdfs:label : Liberation Date</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/liberationDate">shoah:liberationDate</a>
    /// </summary>
    let liberationDate = _prefixId.prefix "liberationDate"
    /// <summary>
    ///   <para>rdfs:label : Massacre in Italy</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/massacre">shoah:massacre</a>
    /// </summary>
    let massacre = _prefixId.prefix "massacre"
    /// <summary>
    ///   <para>rdfs:label : Mother Maiden Name</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/motherMaidenName">shoah:motherMaidenName</a>
    /// </summary>
    let motherMaidenName = _prefixId.prefix "motherMaidenName"
    /// <summary>
    ///   <para>rdfs:label : Mother Name</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/motherName">shoah:motherName</a>
    /// </summary>
    let motherName = _prefixId.prefix "motherName"
    /// <summary>
    ///   <para>rdfs:label : Mother of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/motherOf">shoah:motherOf</a>
    /// </summary>
    let motherOf = _prefixId.prefix "motherOf"
    /// <summary>
    ///   <para>rdfs:label : Nazi Camp Transfer</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/naziCampTransfer">shoah:naziCampTransfer</a>
    /// </summary>
    let naziCampTransfer = _prefixId.prefix "naziCampTransfer"
    /// <summary>
    ///   <para>rdfs:label : Parent Place</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/parentPlace">shoah:parentPlace</a>
    /// </summary>
    let parentPlace = _prefixId.prefix "parentPlace"
    /// <summary>
    ///   <para>rdfs:label : Parent Religion</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/parentReligion">shoah:parentReligion</a>
    /// </summary>
    let parentReligion = _prefixId.prefix "parentReligion"
    /// <summary>
    ///   <para>rdfs:label : Persecution</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/persecution">shoah:persecution</a>
    /// </summary>
    let persecution = _prefixId.prefix "persecution"
    /// <summary>
    ///   <para>rdfs:label : Reason of Deportation</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/persecutionCategory">shoah:persecutionCategory</a>
    /// </summary>
    let persecutionCategory = _prefixId.prefix "persecutionCategory"
    /// <summary>
    ///   <para>rdfs:label : Place of Birth</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/placeOfBirth">shoah:placeOfBirth</a>
    /// </summary>
    let placeOfBirth = _prefixId.prefix "placeOfBirth"
    /// <summary>
    ///   <para>rdfs:label : Place of Death</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/placeOfDeath">shoah:placeOfDeath</a>
    /// </summary>
    let placeOfDeath = _prefixId.prefix "placeOfDeath"
    /// <summary>
    ///   <para>rdfs:label : Return Date</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/returnDate">shoah:returnDate</a>
    /// </summary>
    let returnDate = _prefixId.prefix "returnDate"
    /// <summary>
    ///   <para>rdfs:label : Return Place</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/returnPlace">shoah:returnPlace</a>
    /// </summary>
    let returnPlace = _prefixId.prefix "returnPlace"
    /// <summary>
    ///   <para>rdfs:label : Shoah Survivor</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/shoahSurvivor">shoah:shoahSurvivor</a>
    /// </summary>
    let shoahSurvivor = _prefixId.prefix "shoahSurvivor"
    /// <summary>
    ///   <para>rdfs:label : Sister of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/sisterOf">shoah:sisterOf</a>
    /// </summary>
    let sisterOf = _prefixId.prefix "sisterOf"
    /// <summary>
    ///   <para>rdfs:label : Sub Camp of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/subCampOf">shoah:subCampOf</a>
    /// </summary>
    let subCampOf = _prefixId.prefix "subCampOf"
    /// <summary>
    ///   <para>rdfs:label : to Camp</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/toNaziCamp">shoah:toNaziCamp</a>
    /// </summary>
    let toNaziCamp = _prefixId.prefix "toNaziCamp"
    /// <summary>
    ///   <para>rdfs:label : to Prison</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/toPrison">shoah:toPrison</a>
    /// </summary>
    let toPrison = _prefixId.prefix "toPrison"
    /// <summary>
    ///   <para>rdfs:label : Transfer Date</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/transferDate">shoah:transferDate</a>
    /// </summary>
    let transferDate = _prefixId.prefix "transferDate"
    /// <summary>
    ///   <para>rdfs:label : Uncle of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/uncleOf">shoah:uncleOf</a>
    /// </summary>
    let uncleOf = _prefixId.prefix "uncleOf"
    /// <summary>
    ///   <para>rdfs:label : Widow of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/widowOf">shoah:widowOf</a>
    /// </summary>
    let widowOf = _prefixId.prefix "widowOf"
    /// <summary>
    ///   <para>rdfs:label : Widower of</para>
    ///   <a href="http://dati.cdec.it/lod/shoah/widowerOf">shoah:widowerOf</a>
    /// </summary>
    let widowerOf = _prefixId.prefix "widowerOf"
    let ``www.cdec.it`` = _prefixId.prefix "www.cdec.it"
    let ``www.regesta.com`` = _prefixId.prefix "www.regesta.com"
