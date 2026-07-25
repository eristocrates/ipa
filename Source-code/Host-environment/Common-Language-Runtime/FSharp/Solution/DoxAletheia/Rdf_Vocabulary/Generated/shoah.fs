namespace http.dati.cdec.it.lod.shoah.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module shoah =
    let _namespace_iri = Namespace_Iri shoah |> NamespaceIRI
    /// <summary>
    ///   <para>shoah:www.cdec.it</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/www.cdec.it">http://dati.cdec.it/lod/shoah/www.cdec.it</seealso>
    let ``www.cdec.it`` = Prefixed_Name(shoah, "www.cdec.it") |> PrefixedName
    /// <summary>
    ///   <para>shoah:www.regesta.com</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/www.regesta.com">http://dati.cdec.it/lod/shoah/www.regesta.com</seealso>
    let ``www.regesta.com`` = Prefixed_Name(shoah, "www.regesta.com") |> PrefixedName
    /// <summary>
    ///   <para>shoah:DetentionPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Detention Place</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/DetentionPlace">http://dati.cdec.it/lod/shoah/DetentionPlace</seealso>
    let DetentionPlace = Prefixed_Name(shoah, "DetentionPlace") |> PrefixedName
    /// <summary>
    ///   <para>shoah:Liberation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Liberation</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/Liberation">http://dati.cdec.it/lod/shoah/Liberation</seealso>
    let Liberation = Prefixed_Name(shoah, "Liberation") |> PrefixedName
    /// <summary>
    ///   <para>shoah:returnPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Return Place</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/returnPlace">http://dati.cdec.it/lod/shoah/returnPlace</seealso>
    let returnPlace = Prefixed_Name(shoah, "returnPlace") |> PrefixedName
    /// <summary>
    ///   <para>shoah:transferDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Transfer Date</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/transferDate">http://dati.cdec.it/lod/shoah/transferDate</seealso>
    let transferDate = Prefixed_Name(shoah, "transferDate") |> PrefixedName
    /// <summary>
    ///   <para>shoah:uncleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Uncle of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/uncleOf">http://dati.cdec.it/lod/shoah/uncleOf</seealso>
    let uncleOf = Prefixed_Name(shoah, "uncleOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/0.1">http://dati.cdec.it/lod/shoah/0.1</seealso>
    let ``_0.1`` = Prefixed_Name(shoah, "0.1") |> PrefixedName
    /// <summary>
    ///   <para>shoah:NaziCamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Nazi Camp</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/NaziCamp">http://dati.cdec.it/lod/shoah/NaziCamp</seealso>
    let NaziCamp = Prefixed_Name(shoah, "NaziCamp") |> PrefixedName
    /// <summary>
    ///   <para>shoah:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Place</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/Place">http://dati.cdec.it/lod/shoah/Place</seealso>
    let Place = Prefixed_Name(shoah, "Place") |> PrefixedName
    /// <summary>
    ///   <para>shoah:arrestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Arrested By</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/arrestedBy">http://dati.cdec.it/lod/shoah/arrestedBy</seealso>
    let arrestedBy = Prefixed_Name(shoah, "arrestedBy") |> PrefixedName
    /// <summary>
    ///   <para>shoah:consortReligion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Consort Religion</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/consortReligion">http://dati.cdec.it/lod/shoah/consortReligion</seealso>
    let consortReligion = Prefixed_Name(shoah, "consortReligion") |> PrefixedName
    /// <summary>
    ///   <para>shoah:deathDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Death Description</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/deathDescription">http://dati.cdec.it/lod/shoah/deathDescription</seealso>
    let deathDescription = Prefixed_Name(shoah, "deathDescription") |> PrefixedName
    /// <summary>
    ///   <para>shoah:departureDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Departure Date</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/departureDate">http://dati.cdec.it/lod/shoah/departureDate</seealso>
    let departureDate = Prefixed_Name(shoah, "departureDate") |> PrefixedName

    /// <summary>
    ///   <para>shoah:districtOfResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>District of Residence</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/districtOfResidence">http://dati.cdec.it/lod/shoah/districtOfResidence</seealso>
    let districtOfResidence =
        Prefixed_Name(shoah, "districtOfResidence") |> PrefixedName

    /// <summary>
    ///   <para>shoah:DetentionPlaceTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Detention Place Transfer</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/DetentionPlaceTransfer">http://dati.cdec.it/lod/shoah/DetentionPlaceTransfer</seealso>
    let DetentionPlaceTransfer =
        Prefixed_Name(shoah, "DetentionPlaceTransfer") |> PrefixedName

    /// <summary>
    ///   <para>shoah:Persecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Persecution</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/Persecution">http://dati.cdec.it/lod/shoah/Persecution</seealso>
    let Persecution = Prefixed_Name(shoah, "Persecution") |> PrefixedName
    /// <summary>
    ///   <para>shoah:massacre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Massacre in Italy</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/massacre">http://dati.cdec.it/lod/shoah/massacre</seealso>
    let massacre = Prefixed_Name(shoah, "massacre") |> PrefixedName
    /// <summary>
    ///   <para>shoah:motherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Mother of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/motherOf">http://dati.cdec.it/lod/shoah/motherOf</seealso>
    let motherOf = Prefixed_Name(shoah, "motherOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:parentReligion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Parent Religion</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/parentReligion">http://dati.cdec.it/lod/shoah/parentReligion</seealso>
    let parentReligion = Prefixed_Name(shoah, "parentReligion") |> PrefixedName
    /// <summary>
    ///   <para>shoah:placeOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Place of Death</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/placeOfDeath">http://dati.cdec.it/lod/shoah/placeOfDeath</seealso>
    let placeOfDeath = Prefixed_Name(shoah, "placeOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>shoah:arrestDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Arrest Date</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/arrestDate">http://dati.cdec.it/lod/shoah/arrestDate</seealso>
    let arrestDate = Prefixed_Name(shoah, "arrestDate") |> PrefixedName
    /// <summary>
    ///   <para>shoah:auntOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Aunt of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/auntOf">http://dati.cdec.it/lod/shoah/auntOf</seealso>
    let auntOf = Prefixed_Name(shoah, "auntOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:brotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Brother of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/brotherOf">http://dati.cdec.it/lod/shoah/brotherOf</seealso>
    let brotherOf = Prefixed_Name(shoah, "brotherOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:consortFamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Consort Family Name</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/consortFamilyName">http://dati.cdec.it/lod/shoah/consortFamilyName</seealso>
    let consortFamilyName = Prefixed_Name(shoah, "consortFamilyName") |> PrefixedName
    /// <summary>
    ///   <para>shoah:consortOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Consort of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/consortOf">http://dati.cdec.it/lod/shoah/consortOf</seealso>
    let consortOf = Prefixed_Name(shoah, "consortOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:convoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Convoy</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/convoy">http://dati.cdec.it/lod/shoah/convoy</seealso>
    let convoy = Prefixed_Name(shoah, "convoy") |> PrefixedName

    /// <summary>
    ///   <para>shoah:convoyDeparturePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Last Place before Deportation</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/convoyDeparturePlace">http://dati.cdec.it/lod/shoah/convoyDeparturePlace</seealso>
    let convoyDeparturePlace =
        Prefixed_Name(shoah, "convoyDeparturePlace") |> PrefixedName

    /// <summary>
    ///   <para>shoah:dateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Date of Birth</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/dateOfBirth">http://dati.cdec.it/lod/shoah/dateOfBirth</seealso>
    let dateOfBirth = Prefixed_Name(shoah, "dateOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>shoah:deathInItaly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Death in Italy</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/deathInItaly">http://dati.cdec.it/lod/shoah/deathInItaly</seealso>
    let deathInItaly = Prefixed_Name(shoah, "deathInItaly") |> PrefixedName
    /// <summary>
    ///   <para>shoah:campSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Camp Serial Number</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/campSerialNumber">http://dati.cdec.it/lod/shoah/campSerialNumber</seealso>
    let campSerialNumber = Prefixed_Name(shoah, "campSerialNumber") |> PrefixedName
    /// <summary>
    ///   <para>shoah:consortFirstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Consort First Name</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/consortFirstName">http://dati.cdec.it/lod/shoah/consortFirstName</seealso>
    let consortFirstName = Prefixed_Name(shoah, "consortFirstName") |> PrefixedName
    /// <summary>
    ///   <para>shoah:convoyNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Convoy Number</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/convoyNumber">http://dati.cdec.it/lod/shoah/convoyNumber</seealso>
    let convoyNumber = Prefixed_Name(shoah, "convoyNumber") |> PrefixedName
    /// <summary>
    ///   <para>shoah:dateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Date of Death</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/dateOfDeath">http://dati.cdec.it/lod/shoah/dateOfDeath</seealso>
    let dateOfDeath = Prefixed_Name(shoah, "dateOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>shoah:detentionPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Detention Place</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/detentionPlace">http://dati.cdec.it/lod/shoah/detentionPlace</seealso>
    let detentionPlace = Prefixed_Name(shoah, "detentionPlace") |> PrefixedName
    /// <summary>
    ///   <para>shoah:fatherName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Father Name</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/fatherName">http://dati.cdec.it/lod/shoah/fatherName</seealso>
    let fatherName = Prefixed_Name(shoah, "fatherName") |> PrefixedName
    /// <summary>
    ///   <para>shoah:fromNaziCamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>from Camp</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/fromNaziCamp">http://dati.cdec.it/lod/shoah/fromNaziCamp</seealso>
    let fromNaziCamp = Prefixed_Name(shoah, "fromNaziCamp") |> PrefixedName
    /// <summary>
    ///   <para>shoah:grandfatherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Grandfather of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/grandfatherOf">http://dati.cdec.it/lod/shoah/grandfatherOf</seealso>
    let grandfatherOf = Prefixed_Name(shoah, "grandfatherOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:grandmotherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Grandmother of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/grandmotherOf">http://dati.cdec.it/lod/shoah/grandmotherOf</seealso>
    let grandmotherOf = Prefixed_Name(shoah, "grandmotherOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:liberationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Liberation Date</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/liberationDate">http://dati.cdec.it/lod/shoah/liberationDate</seealso>
    let liberationDate = Prefixed_Name(shoah, "liberationDate") |> PrefixedName
    /// <summary>
    ///   <para>shoah:motherName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Mother Name</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/motherName">http://dati.cdec.it/lod/shoah/motherName</seealso>
    let motherName = Prefixed_Name(shoah, "motherName") |> PrefixedName
    /// <summary>
    ///   <para>shoah:naziCampTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Nazi Camp Transfer</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/naziCampTransfer">http://dati.cdec.it/lod/shoah/naziCampTransfer</seealso>
    let naziCampTransfer = Prefixed_Name(shoah, "naziCampTransfer") |> PrefixedName
    /// <summary>
    ///   <para>shoah:persecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Persecution</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/persecution">http://dati.cdec.it/lod/shoah/persecution</seealso>
    let persecution = Prefixed_Name(shoah, "persecution") |> PrefixedName

    /// <summary>
    ///   <para>shoah:persecutionCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Reason of Deportation</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/persecutionCategory">http://dati.cdec.it/lod/shoah/persecutionCategory</seealso>
    let persecutionCategory =
        Prefixed_Name(shoah, "persecutionCategory") |> PrefixedName

    /// <summary>
    ///   <para>shoah:sisterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Sister of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/sisterOf">http://dati.cdec.it/lod/shoah/sisterOf</seealso>
    let sisterOf = Prefixed_Name(shoah, "sisterOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:toPrison</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>to Prison</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/toPrison">http://dati.cdec.it/lod/shoah/toPrison</seealso>
    let toPrison = Prefixed_Name(shoah, "toPrison") |> PrefixedName
    /// <summary>
    ///   <para>shoah:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/country">http://dati.cdec.it/lod/shoah/country</seealso>
    let country = Prefixed_Name(shoah, "country") |> PrefixedName

    /// <summary>
    ///   <para>shoah:detentionPlaceTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Detention Place Transfer</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/detentionPlaceTransfer">http://dati.cdec.it/lod/shoah/detentionPlaceTransfer</seealso>
    let detentionPlaceTransfer =
        Prefixed_Name(shoah, "detentionPlaceTransfer") |> PrefixedName

    /// <summary>
    ///   <para>shoah:fatherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Father of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/fatherOf">http://dati.cdec.it/lod/shoah/fatherOf</seealso>
    let fatherOf = Prefixed_Name(shoah, "fatherOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:fromPrison</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>from Prison</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/fromPrison">http://dati.cdec.it/lod/shoah/fromPrison</seealso>
    let fromPrison = Prefixed_Name(shoah, "fromPrison") |> PrefixedName
    /// <summary>
    ///   <para>shoah:liberation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Liberation</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/liberation">http://dati.cdec.it/lod/shoah/liberation</seealso>
    let liberation = Prefixed_Name(shoah, "liberation") |> PrefixedName
    /// <summary>
    ///   <para>shoah:motherMaidenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Mother Maiden Name</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/motherMaidenName">http://dati.cdec.it/lod/shoah/motherMaidenName</seealso>
    let motherMaidenName = Prefixed_Name(shoah, "motherMaidenName") |> PrefixedName
    /// <summary>
    ///   <para>shoah:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/">http://dati.cdec.it/lod/shoah/</seealso>
    let _prefix_iri = Prefixed_Name(shoah, "") |> PrefixedName
    /// <summary>
    ///   <para>shoah:Convoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Convoy</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/Convoy">http://dati.cdec.it/lod/shoah/Convoy</seealso>
    let Convoy = Prefixed_Name(shoah, "Convoy") |> PrefixedName
    /// <summary>
    ///   <para>shoah:Massacre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Massacre</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/Massacre">http://dati.cdec.it/lod/shoah/Massacre</seealso>
    let Massacre = Prefixed_Name(shoah, "Massacre") |> PrefixedName
    /// <summary>
    ///   <para>shoah:NaziCampTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Nazi Camp Transfer</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/NaziCampTransfer">http://dati.cdec.it/lod/shoah/NaziCampTransfer</seealso>
    let NaziCampTransfer = Prefixed_Name(shoah, "NaziCampTransfer") |> PrefixedName
    /// <summary>
    ///   <para>shoah:arrestPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Arrest Place</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/arrestPlace">http://dati.cdec.it/lod/shoah/arrestPlace</seealso>
    let arrestPlace = Prefixed_Name(shoah, "arrestPlace") |> PrefixedName
    /// <summary>
    ///   <para>shoah:arrivalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Arrival Date</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/arrivalDate">http://dati.cdec.it/lod/shoah/arrivalDate</seealso>
    let arrivalDate = Prefixed_Name(shoah, "arrivalDate") |> PrefixedName
    /// <summary>
    ///   <para>shoah:parentPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Parent Place</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/parentPlace">http://dati.cdec.it/lod/shoah/parentPlace</seealso>
    let parentPlace = Prefixed_Name(shoah, "parentPlace") |> PrefixedName
    /// <summary>
    ///   <para>shoah:placeOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Place of Birth</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/placeOfBirth">http://dati.cdec.it/lod/shoah/placeOfBirth</seealso>
    let placeOfBirth = Prefixed_Name(shoah, "placeOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>shoah:returnDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Return Date</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/returnDate">http://dati.cdec.it/lod/shoah/returnDate</seealso>
    let returnDate = Prefixed_Name(shoah, "returnDate") |> PrefixedName
    /// <summary>
    ///   <para>shoah:shoahSurvivor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Shoah Survivor</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/shoahSurvivor">http://dati.cdec.it/lod/shoah/shoahSurvivor</seealso>
    let shoahSurvivor = Prefixed_Name(shoah, "shoahSurvivor") |> PrefixedName
    /// <summary>
    ///   <para>shoah:subCampOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Sub Camp of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/subCampOf">http://dati.cdec.it/lod/shoah/subCampOf</seealso>
    let subCampOf = Prefixed_Name(shoah, "subCampOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:toNaziCamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>to Camp</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/toNaziCamp">http://dati.cdec.it/lod/shoah/toNaziCamp</seealso>
    let toNaziCamp = Prefixed_Name(shoah, "toNaziCamp") |> PrefixedName
    /// <summary>
    ///   <para>shoah:widowOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Widow of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/widowOf">http://dati.cdec.it/lod/shoah/widowOf</seealso>
    let widowOf = Prefixed_Name(shoah, "widowOf") |> PrefixedName
    /// <summary>
    ///   <para>shoah:widowerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Widower of</para></remarks>
    /// <seealso href="http://dati.cdec.it/lod/shoah/widowerOf">http://dati.cdec.it/lod/shoah/widowerOf</seealso>
    let widowerOf = Prefixed_Name(shoah, "widowerOf") |> PrefixedName
