namespace http.rdaregistry.info.Elements.a.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdaa =
    let _namespace_iri = Namespace_Iri rdaa |> NamespaceIRI
    /// <summary>
    ///   <para>rdaa:P50001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is respondent of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50001">http://rdaregistry.info/Elements/a/P50001</seealso>
    let P50001 = Prefixed_Name(rdaa, "P50001") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:appelleeCorporateBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/appelleeCorporateBodyOf.en">http://rdaregistry.info/Elements/a/appelleeCorporateBodyOf.en</seealso>
    let ``appelleeCorporateBodyOf.en`` =
        Prefixed_Name(rdaa, "appelleeCorporateBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appellee of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50087">http://rdaregistry.info/Elements/a/P50087</seealso>
    let P50087 = Prefixed_Name(rdaa, "P50087") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:hostInstitutionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/hostInstitutionOf.en">http://rdaregistry.info/Elements/a/hostInstitutionOf.en</seealso>
    let ``hostInstitutionOf.en`` =
        Prefixed_Name(rdaa, "hostInstitutionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is production company of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50005">http://rdaregistry.info/Elements/a/P50005</seealso>
    let P50005 = Prefixed_Name(rdaa, "P50005") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:productionCompanyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/productionCompanyOf.en">http://rdaregistry.info/Elements/a/productionCompanyOf.en</seealso>
    let ``productionCompanyOf.en`` =
        Prefixed_Name(rdaa, "productionCompanyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:foundingCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/foundingCorporateBody.en">http://rdaregistry.info/Elements/a/foundingCorporateBody.en</seealso>
    let ``foundingCorporateBody.en`` =
        Prefixed_Name(rdaa, "foundingCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has hierarchical superior</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50008">http://rdaregistry.info/Elements/a/P50008</seealso>
    let P50008 = Prefixed_Name(rdaa, "P50008") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:hierarchicalSuperior.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/hierarchicalSuperior.en">http://rdaregistry.info/Elements/a/hierarchicalSuperior.en</seealso>
    let ``hierarchicalSuperior.en`` =
        Prefixed_Name(rdaa, "hierarchicalSuperior.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has variant name for the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50025">http://rdaregistry.info/Elements/a/P50025</seealso>
    let P50025 = Prefixed_Name(rdaa, "P50025") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:variantNameForTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/variantNameForTheCorporateBody.en">http://rdaregistry.info/Elements/a/variantNameForTheCorporateBody.en</seealso>
    let ``variantNameForTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "variantNameForTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:courtGovernedOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/courtGovernedOf.en">http://rdaregistry.info/Elements/a/courtGovernedOf.en</seealso>
    let ``courtGovernedOf.en`` =
        Prefixed_Name(rdaa, "courtGovernedOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is depositor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50047">http://rdaregistry.info/Elements/a/P50047</seealso>
    let P50047 = Prefixed_Name(rdaa, "P50047") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:depositorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/depositorOf.en">http://rdaregistry.info/Elements/a/depositorOf.en</seealso>
    let ``depositorOf.en`` = Prefixed_Name(rdaa, "depositorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50162</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is current owner of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50162">http://rdaregistry.info/Elements/a/P50162</seealso>
    let P50162 = Prefixed_Name(rdaa, "P50162") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is film director of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50048">http://rdaregistry.info/Elements/a/P50048</seealso>
    let P50048 = Prefixed_Name(rdaa, "P50048") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is narrator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50081">http://rdaregistry.info/Elements/a/P50081</seealso>
    let P50081 = Prefixed_Name(rdaa, "P50081") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:narratorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/narratorOf.en">http://rdaregistry.info/Elements/a/narratorOf.en</seealso>
    let ``narratorOf.en`` = Prefixed_Name(rdaa, "narratorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:storytellerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/storytellerOf.en">http://rdaregistry.info/Elements/a/storytellerOf.en</seealso>
    let ``storytellerOf.en`` = Prefixed_Name(rdaa, "storytellerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50083</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is speaker of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50083">http://rdaregistry.info/Elements/a/P50083</seealso>
    let P50083 = Prefixed_Name(rdaa, "P50083") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50084</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is singer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50084">http://rdaregistry.info/Elements/a/P50084</seealso>
    let P50084 = Prefixed_Name(rdaa, "P50084") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:singerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/singerOf.en">http://rdaregistry.info/Elements/a/singerOf.en</seealso>
    let ``singerOf.en`` = Prefixed_Name(rdaa, "singerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is medium of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50086">http://rdaregistry.info/Elements/a/P50086</seealso>
    let P50086 = Prefixed_Name(rdaa, "P50086") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:mediumOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/mediumOf.en">http://rdaregistry.info/Elements/a/mediumOf.en</seealso>
    let ``mediumOf.en`` = Prefixed_Name(rdaa, "mediumOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50122</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appellant person of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50122">http://rdaregistry.info/Elements/a/P50122</seealso>
    let P50122 = Prefixed_Name(rdaa, "P50122") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:appellantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/appellantOf.en">http://rdaregistry.info/Elements/a/appellantOf.en</seealso>
    let ``appellantOf.en`` = Prefixed_Name(rdaa, "appellantOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50124</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is plaintiff person of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50124">http://rdaregistry.info/Elements/a/P50124</seealso>
    let P50124 = Prefixed_Name(rdaa, "P50124") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is defendant of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50090">http://rdaregistry.info/Elements/a/P50090</seealso>
    let P50090 = Prefixed_Name(rdaa, "P50090") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50259</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is defendant person of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50259">http://rdaregistry.info/Elements/a/P50259</seealso>
    let P50259 = Prefixed_Name(rdaa, "P50259") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50258</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is defendant corporate body of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50258">http://rdaregistry.info/Elements/a/P50258</seealso>
    let P50258 = Prefixed_Name(rdaa, "P50258") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:defendantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/defendantOf.en">http://rdaregistry.info/Elements/a/defendantOf.en</seealso>
    let ``defendantOf.en`` = Prefixed_Name(rdaa, "defendantOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:illuminatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/illuminatorOf.en">http://rdaregistry.info/Elements/a/illuminatorOf.en</seealso>
    let ``illuminatorOf.en`` = Prefixed_Name(rdaa, "illuminatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50182</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is other person, family, or corporate body associated with an item of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50182">http://rdaregistry.info/Elements/a/P50182</seealso>
    let P50182 = Prefixed_Name(rdaa, "P50182") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has undifferentiated name indicator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50093">http://rdaregistry.info/Elements/a/P50093</seealso>
    let P50093 = Prefixed_Name(rdaa, "P50093") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:groupMemberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/groupMemberOf.en">http://rdaregistry.info/Elements/a/groupMemberOf.en</seealso>
    let ``groupMemberOf.en`` = Prefixed_Name(rdaa, "groupMemberOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:employer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/employer.en">http://rdaregistry.info/Elements/a/employer.en</seealso>
    let ``employer.en`` = Prefixed_Name(rdaa, "employer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has country associated with the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50097">http://rdaregistry.info/Elements/a/P50097</seealso>
    let P50097 = Prefixed_Name(rdaa, "P50097") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:countryAssociatedWithThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/countryAssociatedWithThePerson.en">http://rdaregistry.info/Elements/a/countryAssociatedWithThePerson.en</seealso>
    let ``countryAssociatedWithThePerson.en`` =
        Prefixed_Name(rdaa, "countryAssociatedWithThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has period of activity of the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50098">http://rdaregistry.info/Elements/a/P50098</seealso>
    let P50098 = Prefixed_Name(rdaa, "P50098") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:periodOfActivityOfThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/periodOfActivityOfThePerson.en">http://rdaregistry.info/Elements/a/periodOfActivityOfThePerson.en</seealso>
    let ``periodOfActivityOfThePerson.en`` =
        Prefixed_Name(rdaa, "periodOfActivityOfThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:fieldOfActivityOfThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/fieldOfActivityOfThePerson.en">http://rdaregistry.info/Elements/a/fieldOfActivityOfThePerson.en</seealso>
    let ``fieldOfActivityOfThePerson.en`` =
        Prefixed_Name(rdaa, "fieldOfActivityOfThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has affiliation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50101">http://rdaregistry.info/Elements/a/P50101</seealso>
    let P50101 = Prefixed_Name(rdaa, "P50101") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:affiliation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/affiliation.en">http://rdaregistry.info/Elements/a/affiliation.en</seealso>
    let ``affiliation.en`` = Prefixed_Name(rdaa, "affiliation.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50102</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50102">http://rdaregistry.info/Elements/a/P50102</seealso>
    let P50102 = Prefixed_Name(rdaa, "P50102") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50104</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has profession or occupation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50104">http://rdaregistry.info/Elements/a/P50104</seealso>
    let P50104 = Prefixed_Name(rdaa, "P50104") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:professionOrOccupation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/professionOrOccupation.en">http://rdaregistry.info/Elements/a/professionOrOccupation.en</seealso>
    let ``professionOrOccupation.en`` =
        Prefixed_Name(rdaa, "professionOrOccupation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50105</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has alternate identity</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50105">http://rdaregistry.info/Elements/a/P50105</seealso>
    let P50105 = Prefixed_Name(rdaa, "P50105") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:alternateIdentity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/alternateIdentity.en">http://rdaregistry.info/Elements/a/alternateIdentity.en</seealso>
    let ``alternateIdentity.en`` =
        Prefixed_Name(rdaa, "alternateIdentity.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50108</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other designation associated with the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50108">http://rdaregistry.info/Elements/a/P50108</seealso>
    let P50108 = Prefixed_Name(rdaa, "P50108") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:otherDesignationAssociatedWithThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/otherDesignationAssociatedWithThePerson.en">http://rdaregistry.info/Elements/a/otherDesignationAssociatedWithThePerson.en</seealso>
    let ``otherDesignationAssociatedWithThePerson.en`` =
        Prefixed_Name(rdaa, "otherDesignationAssociatedWithThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50109</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of residence, etc.</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50109">http://rdaregistry.info/Elements/a/P50109</seealso>
    let P50109 = Prefixed_Name(rdaa, "P50109") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:placeOfResidenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/placeOfResidenceEtc.en">http://rdaregistry.info/Elements/a/placeOfResidenceEtc.en</seealso>
    let ``placeOfResidenceEtc.en`` =
        Prefixed_Name(rdaa, "placeOfResidenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:foundedCorporateBodyOfPerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/foundedCorporateBodyOfPerson.en">http://rdaregistry.info/Elements/a/foundedCorporateBodyOfPerson.en</seealso>
    let ``foundedCorporateBodyOfPerson.en`` =
        Prefixed_Name(rdaa, "foundedCorporateBodyOfPerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50113</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has biographical information</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50113">http://rdaregistry.info/Elements/a/P50113</seealso>
    let P50113 = Prefixed_Name(rdaa, "P50113") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:biographicalInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/biographicalInformation.en">http://rdaregistry.info/Elements/a/biographicalInformation.en</seealso>
    let ``biographicalInformation.en`` =
        Prefixed_Name(rdaa, "biographicalInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50114</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has address of the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50114">http://rdaregistry.info/Elements/a/P50114</seealso>
    let P50114 = Prefixed_Name(rdaa, "P50114") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:addressOfThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/addressOfThePerson.en">http://rdaregistry.info/Elements/a/addressOfThePerson.en</seealso>
    let ``addressOfThePerson.en`` =
        Prefixed_Name(rdaa, "addressOfThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50115</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has fuller form of name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50115">http://rdaregistry.info/Elements/a/P50115</seealso>
    let P50115 = Prefixed_Name(rdaa, "P50115") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:fullerFormOfName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/fullerFormOfName.en">http://rdaregistry.info/Elements/a/fullerFormOfName.en</seealso>
    let ``fullerFormOfName.en`` =
        Prefixed_Name(rdaa, "fullerFormOfName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:cartographerExpressionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/cartographerExpressionOf.en">http://rdaregistry.info/Elements/a/cartographerExpressionOf.en</seealso>
    let ``cartographerExpressionOf.en`` =
        Prefixed_Name(rdaa, "cartographerExpressionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50151</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choreographer (expression) of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50151">http://rdaregistry.info/Elements/a/P50151</seealso>
    let P50151 = Prefixed_Name(rdaa, "P50151") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:choreographerExpressionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/choreographerExpressionOf.en">http://rdaregistry.info/Elements/a/choreographerExpressionOf.en</seealso>
    let ``choreographerExpressionOf.en`` =
        Prefixed_Name(rdaa, "choreographerExpressionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50152</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of added commentary of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50152">http://rdaregistry.info/Elements/a/P50152</seealso>
    let P50152 = Prefixed_Name(rdaa, "P50152") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfAddedCommentaryOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfAddedCommentaryOf.en">http://rdaregistry.info/Elements/a/writerOfAddedCommentaryOf.en</seealso>
    let ``writerOfAddedCommentaryOf.en`` =
        Prefixed_Name(rdaa, "writerOfAddedCommentaryOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:presenterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/presenterOf.en">http://rdaregistry.info/Elements/a/presenterOf.en</seealso>
    let ``presenterOf.en`` = Prefixed_Name(rdaa, "presenterOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50181</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is other person, family, or corporate body associated with a manifestation of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50181">http://rdaregistry.info/Elements/a/P50181</seealso>
    let P50181 = Prefixed_Name(rdaa, "P50181") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:otherPFCManifestationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/otherPFCManifestationOf.en">http://rdaregistry.info/Elements/a/otherPFCManifestationOf.en</seealso>
    let ``otherPFCManifestationOf.en`` =
        Prefixed_Name(rdaa, "otherPFCManifestationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50210</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dedicatee (item) of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50210">http://rdaregistry.info/Elements/a/P50210</seealso>
    let P50210 = Prefixed_Name(rdaa, "P50210") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50206</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is restorationist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50206">http://rdaregistry.info/Elements/a/P50206</seealso>
    let P50206 = Prefixed_Name(rdaa, "P50206") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:otherPFCItemOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/otherPFCItemOf.en">http://rdaregistry.info/Elements/a/otherPFCItemOf.en</seealso>
    let ``otherPFCItemOf.en`` = Prefixed_Name(rdaa, "otherPFCItemOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:editorOfMovingImageWorkOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/editorOfMovingImageWorkOf.en">http://rdaregistry.info/Elements/a/editorOfMovingImageWorkOf.en</seealso>
    let ``editorOfMovingImageWorkOf.en`` =
        Prefixed_Name(rdaa, "editorOfMovingImageWorkOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50184</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is programmer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50184">http://rdaregistry.info/Elements/a/P50184</seealso>
    let P50184 = Prefixed_Name(rdaa, "P50184") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:cartographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/cartographerOf.en">http://rdaregistry.info/Elements/a/cartographerOf.en</seealso>
    let ``cartographerOf.en`` = Prefixed_Name(rdaa, "cartographerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50187</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is composer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50187">http://rdaregistry.info/Elements/a/P50187</seealso>
    let P50187 = Prefixed_Name(rdaa, "P50187") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:composerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/composerOf.en">http://rdaregistry.info/Elements/a/composerOf.en</seealso>
    let ``composerOf.en`` = Prefixed_Name(rdaa, "composerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50188</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is inventor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50188">http://rdaregistry.info/Elements/a/P50188</seealso>
    let P50188 = Prefixed_Name(rdaa, "P50188") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:inventorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/inventorOf.en">http://rdaregistry.info/Elements/a/inventorOf.en</seealso>
    let ``inventorOf.en`` = Prefixed_Name(rdaa, "inventorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50189</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is compiler of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50189">http://rdaregistry.info/Elements/a/P50189</seealso>
    let P50189 = Prefixed_Name(rdaa, "P50189") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:compilerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/compilerOf.en">http://rdaregistry.info/Elements/a/compilerOf.en</seealso>
    let ``compilerOf.en`` = Prefixed_Name(rdaa, "compilerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50190</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is photographer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50190">http://rdaregistry.info/Elements/a/P50190</seealso>
    let P50190 = Prefixed_Name(rdaa, "P50190") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:photographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/photographerOf.en">http://rdaregistry.info/Elements/a/photographerOf.en</seealso>
    let ``photographerOf.en`` = Prefixed_Name(rdaa, "photographerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfPostfaceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfPostfaceOf.en">http://rdaregistry.info/Elements/a/writerOfPostfaceOf.en</seealso>
    let ``writerOfPostfaceOf.en`` =
        Prefixed_Name(rdaa, "writerOfPostfaceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:predecessorOfSplit.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/predecessorOfSplit.en">http://rdaregistry.info/Elements/a/predecessorOfSplit.en</seealso>
    let ``predecessorOfSplit.en`` =
        Prefixed_Name(rdaa, "predecessorOfSplit.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50230</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has membership corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50230">http://rdaregistry.info/Elements/a/P50230</seealso>
    let P50230 = Prefixed_Name(rdaa, "P50230") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:membershipCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/membershipCorporateBody.en">http://rdaregistry.info/Elements/a/membershipCorporateBody.en</seealso>
    let ``membershipCorporateBody.en`` =
        Prefixed_Name(rdaa, "membershipCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50231</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has corporate member</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50231">http://rdaregistry.info/Elements/a/P50231</seealso>
    let P50231 = Prefixed_Name(rdaa, "P50231") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:corporateMember.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/corporateMember.en">http://rdaregistry.info/Elements/a/corporateMember.en</seealso>
    let ``corporateMember.en`` =
        Prefixed_Name(rdaa, "corporateMember.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:componentOfMerger.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/componentOfMerger.en">http://rdaregistry.info/Elements/a/componentOfMerger.en</seealso>
    let ``componentOfMerger.en`` =
        Prefixed_Name(rdaa, "componentOfMerger.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:respondentOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/respondentOf.en">http://rdaregistry.info/Elements/a/respondentOf.en</seealso>
    let ``respondentOf.en`` = Prefixed_Name(rdaa, "respondentOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is host institution of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50004">http://rdaregistry.info/Elements/a/P50004</seealso>
    let P50004 = Prefixed_Name(rdaa, "P50004") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:annotatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/annotatorOf.en">http://rdaregistry.info/Elements/a/annotatorOf.en</seealso>
    let ``annotatorOf.en`` = Prefixed_Name(rdaa, "annotatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50144</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is costume designer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50144">http://rdaregistry.info/Elements/a/P50144</seealso>
    let P50144 = Prefixed_Name(rdaa, "P50144") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:costumeDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/costumeDesignerOf.en">http://rdaregistry.info/Elements/a/costumeDesignerOf.en</seealso>
    let ``costumeDesignerOf.en`` =
        Prefixed_Name(rdaa, "costumeDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50191</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is interviewer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50191">http://rdaregistry.info/Elements/a/P50191</seealso>
    let P50191 = Prefixed_Name(rdaa, "P50191") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:interviewerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/interviewerOf.en">http://rdaregistry.info/Elements/a/interviewerOf.en</seealso>
    let ``interviewerOf.en`` = Prefixed_Name(rdaa, "interviewerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50204</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is creator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50204">http://rdaregistry.info/Elements/a/P50204</seealso>
    let P50204 = Prefixed_Name(rdaa, "P50204") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sponsoring corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50015">http://rdaregistry.info/Elements/a/P50015</seealso>
    let P50015 = Prefixed_Name(rdaa, "P50015") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has mergee</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50011">http://rdaregistry.info/Elements/a/P50011</seealso>
    let P50011 = Prefixed_Name(rdaa, "P50011") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has predecessor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50012">http://rdaregistry.info/Elements/a/P50012</seealso>
    let P50012 = Prefixed_Name(rdaa, "P50012") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has successor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50016">http://rdaregistry.info/Elements/a/P50016</seealso>
    let P50016 = Prefixed_Name(rdaa, "P50016") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50232</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has component of merger</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50232">http://rdaregistry.info/Elements/a/P50232</seealso>
    let P50232 = Prefixed_Name(rdaa, "P50232") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has product of split</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50014">http://rdaregistry.info/Elements/a/P50014</seealso>
    let P50014 = Prefixed_Name(rdaa, "P50014") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50229</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has predecessor of split</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50229">http://rdaregistry.info/Elements/a/P50229</seealso>
    let P50229 = Prefixed_Name(rdaa, "P50229") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:sponsoringCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sponsoringCorporateBody.en">http://rdaregistry.info/Elements/a/sponsoringCorporateBody.en</seealso>
    let ``sponsoringCorporateBody.en`` =
        Prefixed_Name(rdaa, "sponsoringCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50018">http://rdaregistry.info/Elements/a/P50018</seealso>
    let P50018 = Prefixed_Name(rdaa, "P50018") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has number of a conference, etc.</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50019">http://rdaregistry.info/Elements/a/P50019</seealso>
    let P50019 = Prefixed_Name(rdaa, "P50019") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has founding family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50020">http://rdaregistry.info/Elements/a/P50020</seealso>
    let P50020 = Prefixed_Name(rdaa, "P50020") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sponsoring family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50021">http://rdaregistry.info/Elements/a/P50021</seealso>
    let P50021 = Prefixed_Name(rdaa, "P50021") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:sponsoringFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sponsoringFamily.en">http://rdaregistry.info/Elements/a/sponsoringFamily.en</seealso>
    let ``sponsoringFamily.en`` =
        Prefixed_Name(rdaa, "sponsoringFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sponsored corporate body of family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50063">http://rdaregistry.info/Elements/a/P50063</seealso>
    let P50063 = Prefixed_Name(rdaa, "P50063") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has field of activity of the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50022">http://rdaregistry.info/Elements/a/P50022</seealso>
    let P50022 = Prefixed_Name(rdaa, "P50022") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:fieldOfActivityOfTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/fieldOfActivityOfTheCorporateBody.en">http://rdaregistry.info/Elements/a/fieldOfActivityOfTheCorporateBody.en</seealso>
    let ``fieldOfActivityOfTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "fieldOfActivityOfTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:locationOfConferenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/locationOfConferenceEtc.en">http://rdaregistry.info/Elements/a/locationOfConferenceEtc.en</seealso>
    let ``locationOfConferenceEtc.en`` =
        Prefixed_Name(rdaa, "locationOfConferenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place associated with the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50031">http://rdaregistry.info/Elements/a/P50031</seealso>
    let P50031 = Prefixed_Name(rdaa, "P50031") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has name of the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50032">http://rdaregistry.info/Elements/a/P50032</seealso>
    let P50032 = Prefixed_Name(rdaa, "P50032") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has employee</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50026">http://rdaregistry.info/Elements/a/P50026</seealso>
    let P50026 = Prefixed_Name(rdaa, "P50026") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:employee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/employee.en">http://rdaregistry.info/Elements/a/employee.en</seealso>
    let ``employee.en`` = Prefixed_Name(rdaa, "employee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:incumbent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/incumbent.en">http://rdaregistry.info/Elements/a/incumbent.en</seealso>
    let ``incumbent.en`` = Prefixed_Name(rdaa, "incumbent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50234</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has officiated corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50234">http://rdaregistry.info/Elements/a/P50234</seealso>
    let P50234 = Prefixed_Name(rdaa, "P50234") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sponsor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50028">http://rdaregistry.info/Elements/a/P50028</seealso>
    let P50028 = Prefixed_Name(rdaa, "P50028") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has founder</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50029">http://rdaregistry.info/Elements/a/P50029</seealso>
    let P50029 = Prefixed_Name(rdaa, "P50029") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:founder.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/founder.en">http://rdaregistry.info/Elements/a/founder.en</seealso>
    let ``founder.en`` = Prefixed_Name(rdaa, "founder.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50112</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has founded corporate body of person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50112">http://rdaregistry.info/Elements/a/P50112</seealso>
    let P50112 = Prefixed_Name(rdaa, "P50112") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has group member</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50030">http://rdaregistry.info/Elements/a/P50030</seealso>
    let P50030 = Prefixed_Name(rdaa, "P50030") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has preferred name for the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50041">http://rdaregistry.info/Elements/a/P50041</seealso>
    let P50041 = Prefixed_Name(rdaa, "P50041") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:otherDesignationAssociatedWithTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/otherDesignationAssociatedWithTheCorporateBody.en">http://rdaregistry.info/Elements/a/otherDesignationAssociatedWithTheCorporateBody.en</seealso>
    let ``otherDesignationAssociatedWithTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "otherDesignationAssociatedWithTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has associated institution</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50034">http://rdaregistry.info/Elements/a/P50034</seealso>
    let P50034 = Prefixed_Name(rdaa, "P50034") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has corporate history</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50035">http://rdaregistry.info/Elements/a/P50035</seealso>
    let P50035 = Prefixed_Name(rdaa, "P50035") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:corporateHistory.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/corporateHistory.en">http://rdaregistry.info/Elements/a/corporateHistory.en</seealso>
    let ``corporateHistory.en`` =
        Prefixed_Name(rdaa, "corporateHistory.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of establishment</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50037">http://rdaregistry.info/Elements/a/P50037</seealso>
    let P50037 = Prefixed_Name(rdaa, "P50037") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateOfEstablishment.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateOfEstablishment.en">http://rdaregistry.info/Elements/a/dateOfEstablishment.en</seealso>
    let ``dateOfEstablishment.en`` =
        Prefixed_Name(rdaa, "dateOfEstablishment.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date associated with the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50040">http://rdaregistry.info/Elements/a/P50040</seealso>
    let P50040 = Prefixed_Name(rdaa, "P50040") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of termination</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50038">http://rdaregistry.info/Elements/a/P50038</seealso>
    let P50038 = Prefixed_Name(rdaa, "P50038") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateOfTermination.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateOfTermination.en">http://rdaregistry.info/Elements/a/dateOfTermination.en</seealso>
    let ``dateOfTermination.en`` =
        Prefixed_Name(rdaa, "dateOfTermination.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50236</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has period of activity of the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50236">http://rdaregistry.info/Elements/a/P50236</seealso>
    let P50236 = Prefixed_Name(rdaa, "P50236") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateAssociatedWithTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateAssociatedWithTheCorporateBody.en">http://rdaregistry.info/Elements/a/dateAssociatedWithTheCorporateBody.en</seealso>
    let ``dateAssociatedWithTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "dateAssociatedWithTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appellant corporate body of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50042">http://rdaregistry.info/Elements/a/P50042</seealso>
    let P50042 = Prefixed_Name(rdaa, "P50042") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:appellantCorporateBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/appellantCorporateBodyOf.en">http://rdaregistry.info/Elements/a/appellantCorporateBodyOf.en</seealso>
    let ``appellantCorporateBodyOf.en`` =
        Prefixed_Name(rdaa, "appellantCorporateBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50088</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appellant of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50088">http://rdaregistry.info/Elements/a/P50088</seealso>
    let P50088 = Prefixed_Name(rdaa, "P50088") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is plaintiff corporate body of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50043">http://rdaregistry.info/Elements/a/P50043</seealso>
    let P50043 = Prefixed_Name(rdaa, "P50043") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:plaintiffCorporateBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/plaintiffCorporateBodyOf.en">http://rdaregistry.info/Elements/a/plaintiffCorporateBodyOf.en</seealso>
    let ``plaintiffCorporateBodyOf.en`` =
        Prefixed_Name(rdaa, "plaintiffCorporateBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is collector of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50045">http://rdaregistry.info/Elements/a/P50045</seealso>
    let P50045 = Prefixed_Name(rdaa, "P50045") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:collectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/collectorOf.en">http://rdaregistry.info/Elements/a/collectorOf.en</seealso>
    let ``collectorOf.en`` = Prefixed_Name(rdaa, "collectorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50133</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is curator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50133">http://rdaregistry.info/Elements/a/P50133</seealso>
    let P50133 = Prefixed_Name(rdaa, "P50133") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is collection registrar of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50046">http://rdaregistry.info/Elements/a/P50046</seealso>
    let P50046 = Prefixed_Name(rdaa, "P50046") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:collectionRegistrarOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/collectionRegistrarOf.en">http://rdaregistry.info/Elements/a/collectionRegistrarOf.en</seealso>
    let ``collectionRegistrarOf.en`` =
        Prefixed_Name(rdaa, "collectionRegistrarOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:filmDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/filmDirectorOf.en">http://rdaregistry.info/Elements/a/filmDirectorOf.en</seealso>
    let ``filmDirectorOf.en`` = Prefixed_Name(rdaa, "filmDirectorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50205</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is director of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50205">http://rdaregistry.info/Elements/a/P50205</seealso>
    let P50205 = Prefixed_Name(rdaa, "P50205") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio director of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50049">http://rdaregistry.info/Elements/a/P50049</seealso>
    let P50049 = Prefixed_Name(rdaa, "P50049") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:radioDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/radioDirectorOf.en">http://rdaregistry.info/Elements/a/radioDirectorOf.en</seealso>
    let ``radioDirectorOf.en`` =
        Prefixed_Name(rdaa, "radioDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television director of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50050">http://rdaregistry.info/Elements/a/P50050</seealso>
    let P50050 = Prefixed_Name(rdaa, "P50050") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has type of family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50051">http://rdaregistry.info/Elements/a/P50051</seealso>
    let P50051 = Prefixed_Name(rdaa, "P50051") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:typeOfFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/typeOfFamily.en">http://rdaregistry.info/Elements/a/typeOfFamily.en</seealso>
    let ``typeOfFamily.en`` = Prefixed_Name(rdaa, "typeOfFamily.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has identifier for the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50052">http://rdaregistry.info/Elements/a/P50052</seealso>
    let P50052 = Prefixed_Name(rdaa, "P50052") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:identifierForTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/identifierForTheFamily.en">http://rdaregistry.info/Elements/a/identifierForTheFamily.en</seealso>
    let ``identifierForTheFamily.en`` =
        Prefixed_Name(rdaa, "identifierForTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has variant name for the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50054">http://rdaregistry.info/Elements/a/P50054</seealso>
    let P50054 = Prefixed_Name(rdaa, "P50054") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:variantNameForTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/variantNameForTheFamily.en">http://rdaregistry.info/Elements/a/variantNameForTheFamily.en</seealso>
    let ``variantNameForTheFamily.en`` =
        Prefixed_Name(rdaa, "variantNameForTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has name of the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50061">http://rdaregistry.info/Elements/a/P50061</seealso>
    let P50061 = Prefixed_Name(rdaa, "P50061") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has progenitor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50055">http://rdaregistry.info/Elements/a/P50055</seealso>
    let P50055 = Prefixed_Name(rdaa, "P50055") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:progenitor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/progenitor.en">http://rdaregistry.info/Elements/a/progenitor.en</seealso>
    let ``progenitor.en`` = Prefixed_Name(rdaa, "progenitor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has family member</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50056">http://rdaregistry.info/Elements/a/P50056</seealso>
    let P50056 = Prefixed_Name(rdaa, "P50056") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50233</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50233">http://rdaregistry.info/Elements/a/P50233</seealso>
    let P50233 = Prefixed_Name(rdaa, "P50233") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place associated with the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50057">http://rdaregistry.info/Elements/a/P50057</seealso>
    let P50057 = Prefixed_Name(rdaa, "P50057") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:placeAssociatedWithTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/placeAssociatedWithTheFamily.en">http://rdaregistry.info/Elements/a/placeAssociatedWithTheFamily.en</seealso>
    let ``placeAssociatedWithTheFamily.en`` =
        Prefixed_Name(rdaa, "placeAssociatedWithTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date associated with the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50058">http://rdaregistry.info/Elements/a/P50058</seealso>
    let P50058 = Prefixed_Name(rdaa, "P50058") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateAssociatedWithTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateAssociatedWithTheFamily.en">http://rdaregistry.info/Elements/a/dateAssociatedWithTheFamily.en</seealso>
    let ``dateAssociatedWithTheFamily.en`` =
        Prefixed_Name(rdaa, "dateAssociatedWithTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has prominent member of the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50060">http://rdaregistry.info/Elements/a/P50060</seealso>
    let P50060 = Prefixed_Name(rdaa, "P50060") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:prominentMemberOfTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/prominentMemberOfTheFamily.en">http://rdaregistry.info/Elements/a/prominentMemberOfTheFamily.en</seealso>
    let ``prominentMemberOfTheFamily.en`` =
        Prefixed_Name(rdaa, "prominentMemberOfTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has preferred name for the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50065">http://rdaregistry.info/Elements/a/P50065</seealso>
    let P50065 = Prefixed_Name(rdaa, "P50065") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:nameOfTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/nameOfTheFamily.en">http://rdaregistry.info/Elements/a/nameOfTheFamily.en</seealso>
    let ``nameOfTheFamily.en`` =
        Prefixed_Name(rdaa, "nameOfTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:foundedCorporateBodyOfFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/foundedCorporateBodyOfFamily.en">http://rdaregistry.info/Elements/a/foundedCorporateBodyOfFamily.en</seealso>
    let ``foundedCorporateBodyOfFamily.en`` =
        Prefixed_Name(rdaa, "foundedCorporateBodyOfFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:sponsoredCorporateBodyOfFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sponsoredCorporateBodyOfFamily.en">http://rdaregistry.info/Elements/a/sponsoredCorporateBodyOfFamily.en</seealso>
    let ``sponsoredCorporateBodyOfFamily.en`` =
        Prefixed_Name(rdaa, "sponsoredCorporateBodyOfFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:preferredNameForTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/preferredNameForTheFamily.en">http://rdaregistry.info/Elements/a/preferredNameForTheFamily.en</seealso>
    let ``preferredNameForTheFamily.en`` =
        Prefixed_Name(rdaa, "preferredNameForTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is donor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50066">http://rdaregistry.info/Elements/a/P50066</seealso>
    let P50066 = Prefixed_Name(rdaa, "P50066") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:donorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/donorOf.en">http://rdaregistry.info/Elements/a/donorOf.en</seealso>
    let ``donorOf.en`` = Prefixed_Name(rdaa, "donorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50163</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is former owner of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50163">http://rdaregistry.info/Elements/a/P50163</seealso>
    let P50163 = Prefixed_Name(rdaa, "P50163") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is seller of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50067">http://rdaregistry.info/Elements/a/P50067</seealso>
    let P50067 = Prefixed_Name(rdaa, "P50067") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:sellerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sellerOf.en">http://rdaregistry.info/Elements/a/sellerOf.en</seealso>
    let ``sellerOf.en`` = Prefixed_Name(rdaa, "sellerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is enacting jurisdiction of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50068">http://rdaregistry.info/Elements/a/P50068</seealso>
    let P50068 = Prefixed_Name(rdaa, "P50068") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:enactingJurisdictionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/enactingJurisdictionOf.en">http://rdaregistry.info/Elements/a/enactingJurisdictionOf.en</seealso>
    let ``enactingJurisdictionOf.en`` =
        Prefixed_Name(rdaa, "enactingJurisdictionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50070</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is conductor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50070">http://rdaregistry.info/Elements/a/P50070</seealso>
    let P50070 = Prefixed_Name(rdaa, "P50070") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50269</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is instrumental conductor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50269">http://rdaregistry.info/Elements/a/P50269</seealso>
    let P50269 = Prefixed_Name(rdaa, "P50269") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50268</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choral conductor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50268">http://rdaregistry.info/Elements/a/P50268</seealso>
    let P50268 = Prefixed_Name(rdaa, "P50268") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:conductorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/conductorOf.en">http://rdaregistry.info/Elements/a/conductorOf.en</seealso>
    let ``conductorOf.en`` = Prefixed_Name(rdaa, "conductorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50147</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is performer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50147">http://rdaregistry.info/Elements/a/P50147</seealso>
    let P50147 = Prefixed_Name(rdaa, "P50147") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50071</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is actor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50071">http://rdaregistry.info/Elements/a/P50071</seealso>
    let P50071 = Prefixed_Name(rdaa, "P50071") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50217</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is voice actor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50217">http://rdaregistry.info/Elements/a/P50217</seealso>
    let P50217 = Prefixed_Name(rdaa, "P50217") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:actorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/actorOf.en">http://rdaregistry.info/Elements/a/actorOf.en</seealso>
    let ``actorOf.en`` = Prefixed_Name(rdaa, "actorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50072</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is on-screen presenter of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50072">http://rdaregistry.info/Elements/a/P50072</seealso>
    let P50072 = Prefixed_Name(rdaa, "P50072") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:onScreenPresenterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/onScreenPresenterOf.en">http://rdaregistry.info/Elements/a/onScreenPresenterOf.en</seealso>
    let ``onScreenPresenterOf.en`` =
        Prefixed_Name(rdaa, "onScreenPresenterOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50073</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dancer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50073">http://rdaregistry.info/Elements/a/P50073</seealso>
    let P50073 = Prefixed_Name(rdaa, "P50073") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:dancerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dancerOf.en">http://rdaregistry.info/Elements/a/dancerOf.en</seealso>
    let ``dancerOf.en`` = Prefixed_Name(rdaa, "dancerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is moderator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50076">http://rdaregistry.info/Elements/a/P50076</seealso>
    let P50076 = Prefixed_Name(rdaa, "P50076") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:moderatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/moderatorOf.en">http://rdaregistry.info/Elements/a/moderatorOf.en</seealso>
    let ``moderatorOf.en`` = Prefixed_Name(rdaa, "moderatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is puppeteer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50077">http://rdaregistry.info/Elements/a/P50077</seealso>
    let P50077 = Prefixed_Name(rdaa, "P50077") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:puppeteerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/puppeteerOf.en">http://rdaregistry.info/Elements/a/puppeteerOf.en</seealso>
    let ``puppeteerOf.en`` = Prefixed_Name(rdaa, "puppeteerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is panelist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50078">http://rdaregistry.info/Elements/a/P50078</seealso>
    let P50078 = Prefixed_Name(rdaa, "P50078") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:panelistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/panelistOf.en">http://rdaregistry.info/Elements/a/panelistOf.en</seealso>
    let ``panelistOf.en`` = Prefixed_Name(rdaa, "panelistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is instrumentalist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50079">http://rdaregistry.info/Elements/a/P50079</seealso>
    let P50079 = Prefixed_Name(rdaa, "P50079") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:instrumentalistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/instrumentalistOf.en">http://rdaregistry.info/Elements/a/instrumentalistOf.en</seealso>
    let ``instrumentalistOf.en`` =
        Prefixed_Name(rdaa, "instrumentalistOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50080</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50080">http://rdaregistry.info/Elements/a/P50080</seealso>
    let P50080 = Prefixed_Name(rdaa, "P50080") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:commentatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/commentatorOf.en">http://rdaregistry.info/Elements/a/commentatorOf.en</seealso>
    let ``commentatorOf.en`` = Prefixed_Name(rdaa, "commentatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50116</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has gender</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50116">http://rdaregistry.info/Elements/a/P50116</seealso>
    let P50116 = Prefixed_Name(rdaa, "P50116") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:gender.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/gender.en">http://rdaregistry.info/Elements/a/gender.en</seealso>
    let ``gender.en`` = Prefixed_Name(rdaa, "gender.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:preferredNameForThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/preferredNameForThePerson.en">http://rdaregistry.info/Elements/a/preferredNameForThePerson.en</seealso>
    let ``preferredNameForThePerson.en`` =
        Prefixed_Name(rdaa, "preferredNameForThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50118</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of death</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50118">http://rdaregistry.info/Elements/a/P50118</seealso>
    let P50118 = Prefixed_Name(rdaa, "P50118") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:placeOfDeath.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/placeOfDeath.en">http://rdaregistry.info/Elements/a/placeOfDeath.en</seealso>
    let ``placeOfDeath.en`` = Prefixed_Name(rdaa, "placeOfDeath.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50119</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of birth</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50119">http://rdaregistry.info/Elements/a/P50119</seealso>
    let P50119 = Prefixed_Name(rdaa, "P50119") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:placeOfBirth.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/placeOfBirth.en">http://rdaregistry.info/Elements/a/placeOfBirth.en</seealso>
    let ``placeOfBirth.en`` = Prefixed_Name(rdaa, "placeOfBirth.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:curatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/curatorOf.en">http://rdaregistry.info/Elements/a/curatorOf.en</seealso>
    let ``curatorOf.en`` = Prefixed_Name(rdaa, "curatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50134</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is composer (expression) of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50134">http://rdaregistry.info/Elements/a/P50134</seealso>
    let P50134 = Prefixed_Name(rdaa, "P50134") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:composerExpressionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/composerExpressionOf.en">http://rdaregistry.info/Elements/a/composerExpressionOf.en</seealso>
    let ``composerExpressionOf.en`` =
        Prefixed_Name(rdaa, "composerExpressionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50161</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is contributor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50161">http://rdaregistry.info/Elements/a/P50161</seealso>
    let P50161 = Prefixed_Name(rdaa, "P50161") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50135</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is surveyor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50135">http://rdaregistry.info/Elements/a/P50135</seealso>
    let P50135 = Prefixed_Name(rdaa, "P50135") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:surveyorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/surveyorOf.en">http://rdaregistry.info/Elements/a/surveyorOf.en</seealso>
    let ``surveyorOf.en`` = Prefixed_Name(rdaa, "surveyorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50136</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is animator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50136">http://rdaregistry.info/Elements/a/P50136</seealso>
    let P50136 = Prefixed_Name(rdaa, "P50136") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:animatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/animatorOf.en">http://rdaregistry.info/Elements/a/animatorOf.en</seealso>
    let ``animatorOf.en`` = Prefixed_Name(rdaa, "animatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50137</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is arranger of music of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50137">http://rdaregistry.info/Elements/a/P50137</seealso>
    let P50137 = Prefixed_Name(rdaa, "P50137") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:arrangerOfMusicOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/arrangerOfMusicOf.en">http://rdaregistry.info/Elements/a/arrangerOfMusicOf.en</seealso>
    let ``arrangerOfMusicOf.en`` =
        Prefixed_Name(rdaa, "arrangerOfMusicOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50139</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is stage director of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50139">http://rdaregistry.info/Elements/a/P50139</seealso>
    let P50139 = Prefixed_Name(rdaa, "P50139") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:stageDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/stageDirectorOf.en">http://rdaregistry.info/Elements/a/stageDirectorOf.en</seealso>
    let ``stageDirectorOf.en`` =
        Prefixed_Name(rdaa, "stageDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50140</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is interviewer (expression) of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50140">http://rdaregistry.info/Elements/a/P50140</seealso>
    let P50140 = Prefixed_Name(rdaa, "P50140") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:interviewerExpressionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/interviewerExpressionOf.en">http://rdaregistry.info/Elements/a/interviewerExpressionOf.en</seealso>
    let ``interviewerExpressionOf.en`` =
        Prefixed_Name(rdaa, "interviewerExpressionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50141</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is draftsman of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50141">http://rdaregistry.info/Elements/a/P50141</seealso>
    let P50141 = Prefixed_Name(rdaa, "P50141") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:draftsmanOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/draftsmanOf.en">http://rdaregistry.info/Elements/a/draftsmanOf.en</seealso>
    let ``draftsmanOf.en`` = Prefixed_Name(rdaa, "draftsmanOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50142</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is transcriber of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50142">http://rdaregistry.info/Elements/a/P50142</seealso>
    let P50142 = Prefixed_Name(rdaa, "P50142") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:transcriberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/transcriberOf.en">http://rdaregistry.info/Elements/a/transcriberOf.en</seealso>
    let ``transcriberOf.en`` = Prefixed_Name(rdaa, "transcriberOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50143</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical director of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50143">http://rdaregistry.info/Elements/a/P50143</seealso>
    let P50143 = Prefixed_Name(rdaa, "P50143") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:musicalDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/musicalDirectorOf.en">http://rdaregistry.info/Elements/a/musicalDirectorOf.en</seealso>
    let ``musicalDirectorOf.en`` =
        Prefixed_Name(rdaa, "musicalDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50146</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is art director of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50146">http://rdaregistry.info/Elements/a/P50146</seealso>
    let P50146 = Prefixed_Name(rdaa, "P50146") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:artDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/artDirectorOf.en">http://rdaregistry.info/Elements/a/artDirectorOf.en</seealso>
    let ``artDirectorOf.en`` = Prefixed_Name(rdaa, "artDirectorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:performerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/performerOf.en">http://rdaregistry.info/Elements/a/performerOf.en</seealso>
    let ``performerOf.en`` = Prefixed_Name(rdaa, "performerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50148</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is court reporter of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50148">http://rdaregistry.info/Elements/a/P50148</seealso>
    let P50148 = Prefixed_Name(rdaa, "P50148") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:courtReporterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/courtReporterOf.en">http://rdaregistry.info/Elements/a/courtReporterOf.en</seealso>
    let ``courtReporterOf.en`` =
        Prefixed_Name(rdaa, "courtReporterOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50149</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of preface of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50149">http://rdaregistry.info/Elements/a/P50149</seealso>
    let P50149 = Prefixed_Name(rdaa, "P50149") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfPrefaceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfPrefaceOf.en">http://rdaregistry.info/Elements/a/writerOfPrefaceOf.en</seealso>
    let ``writerOfPrefaceOf.en`` =
        Prefixed_Name(rdaa, "writerOfPrefaceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50150</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is cartographer (expression) of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50150">http://rdaregistry.info/Elements/a/P50150</seealso>
    let P50150 = Prefixed_Name(rdaa, "P50150") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50153</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of introduction of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50153">http://rdaregistry.info/Elements/a/P50153</seealso>
    let P50153 = Prefixed_Name(rdaa, "P50153") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfIntroductionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfIntroductionOf.en">http://rdaregistry.info/Elements/a/writerOfIntroductionOf.en</seealso>
    let ``writerOfIntroductionOf.en`` =
        Prefixed_Name(rdaa, "writerOfIntroductionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50254</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of foreword of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50254">http://rdaregistry.info/Elements/a/P50254</seealso>
    let P50254 = Prefixed_Name(rdaa, "P50254") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfSupplementaryTextualContentOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfSupplementaryTextualContentOf.en">http://rdaregistry.info/Elements/a/writerOfSupplementaryTextualContentOf.en</seealso>
    let ``writerOfSupplementaryTextualContentOf.en`` =
        Prefixed_Name(rdaa, "writerOfSupplementaryTextualContentOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50155</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is interviewee (expression) of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50155">http://rdaregistry.info/Elements/a/P50155</seealso>
    let P50155 = Prefixed_Name(rdaa, "P50155") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:intervieweeExpressionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/intervieweeExpressionOf.en">http://rdaregistry.info/Elements/a/intervieweeExpressionOf.en</seealso>
    let ``intervieweeExpressionOf.en`` =
        Prefixed_Name(rdaa, "intervieweeExpressionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50156</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is editor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50156">http://rdaregistry.info/Elements/a/P50156</seealso>
    let P50156 = Prefixed_Name(rdaa, "P50156") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:editorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/editorOf.en">http://rdaregistry.info/Elements/a/editorOf.en</seealso>
    let ``editorOf.en`` = Prefixed_Name(rdaa, "editorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50157</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abridger of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50157">http://rdaregistry.info/Elements/a/P50157</seealso>
    let P50157 = Prefixed_Name(rdaa, "P50157") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:abridgerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/abridgerOf.en">http://rdaregistry.info/Elements/a/abridgerOf.en</seealso>
    let ``abridgerOf.en`` = Prefixed_Name(rdaa, "abridgerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50158</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is recording engineer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50158">http://rdaregistry.info/Elements/a/P50158</seealso>
    let P50158 = Prefixed_Name(rdaa, "P50158") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:recordingEngineerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/recordingEngineerOf.en">http://rdaregistry.info/Elements/a/recordingEngineerOf.en</seealso>
    let ``recordingEngineerOf.en`` =
        Prefixed_Name(rdaa, "recordingEngineerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50159</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is illustrator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50159">http://rdaregistry.info/Elements/a/P50159</seealso>
    let P50159 = Prefixed_Name(rdaa, "P50159") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50245</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is letterer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50245">http://rdaregistry.info/Elements/a/P50245</seealso>
    let P50245 = Prefixed_Name(rdaa, "P50245") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:illustratorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/illustratorOf.en">http://rdaregistry.info/Elements/a/illustratorOf.en</seealso>
    let ``illustratorOf.en`` = Prefixed_Name(rdaa, "illustratorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50160</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is recordist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50160">http://rdaregistry.info/Elements/a/P50160</seealso>
    let P50160 = Prefixed_Name(rdaa, "P50160") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:recordistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/recordistOf.en">http://rdaregistry.info/Elements/a/recordistOf.en</seealso>
    let ``recordistOf.en`` = Prefixed_Name(rdaa, "recordistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50198</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is production designer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50198">http://rdaregistry.info/Elements/a/P50198</seealso>
    let P50198 = Prefixed_Name(rdaa, "P50198") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50212</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is minute taker of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50212">http://rdaregistry.info/Elements/a/P50212</seealso>
    let P50212 = Prefixed_Name(rdaa, "P50212") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50263</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is software developer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50263">http://rdaregistry.info/Elements/a/P50263</seealso>
    let P50263 = Prefixed_Name(rdaa, "P50263") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50256</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is lighting designer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50256">http://rdaregistry.info/Elements/a/P50256</seealso>
    let P50256 = Prefixed_Name(rdaa, "P50256") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:ownerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/ownerOf.en">http://rdaregistry.info/Elements/a/ownerOf.en</seealso>
    let ``ownerOf.en`` = Prefixed_Name(rdaa, "ownerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:honoureeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/honoureeOf.en">http://rdaregistry.info/Elements/a/honoureeOf.en</seealso>
    let ``honoureeOf.en`` = Prefixed_Name(rdaa, "honoureeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50167</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is honouree (item) of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50167">http://rdaregistry.info/Elements/a/P50167</seealso>
    let P50167 = Prefixed_Name(rdaa, "P50167") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:honoureeOfItemOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/honoureeOfItemOf.en">http://rdaregistry.info/Elements/a/honoureeOfItemOf.en</seealso>
    let ``honoureeOfItemOf.en`` =
        Prefixed_Name(rdaa, "honoureeOfItemOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50168</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is broadcaster of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50168">http://rdaregistry.info/Elements/a/P50168</seealso>
    let P50168 = Prefixed_Name(rdaa, "P50168") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:broadcasterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/broadcasterOf.en">http://rdaregistry.info/Elements/a/broadcasterOf.en</seealso>
    let ``broadcasterOf.en`` = Prefixed_Name(rdaa, "broadcasterOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50203</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is publisher of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50203">http://rdaregistry.info/Elements/a/P50203</seealso>
    let P50203 = Prefixed_Name(rdaa, "P50203") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50169</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is film distributor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50169">http://rdaregistry.info/Elements/a/P50169</seealso>
    let P50169 = Prefixed_Name(rdaa, "P50169") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:filmDistributorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/filmDistributorOf.en">http://rdaregistry.info/Elements/a/filmDistributorOf.en</seealso>
    let ``filmDistributorOf.en`` =
        Prefixed_Name(rdaa, "filmDistributorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50199</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is distributor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50199">http://rdaregistry.info/Elements/a/P50199</seealso>
    let P50199 = Prefixed_Name(rdaa, "P50199") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50170</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is book designer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50170">http://rdaregistry.info/Elements/a/P50170</seealso>
    let P50170 = Prefixed_Name(rdaa, "P50170") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:bookDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/bookDesignerOf.en">http://rdaregistry.info/Elements/a/bookDesignerOf.en</seealso>
    let ``bookDesignerOf.en`` = Prefixed_Name(rdaa, "bookDesignerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50202</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is manufacturer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50202">http://rdaregistry.info/Elements/a/P50202</seealso>
    let P50202 = Prefixed_Name(rdaa, "P50202") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50171</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is engraver of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50171">http://rdaregistry.info/Elements/a/P50171</seealso>
    let P50171 = Prefixed_Name(rdaa, "P50171") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:engraverOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/engraverOf.en">http://rdaregistry.info/Elements/a/engraverOf.en</seealso>
    let ``engraverOf.en`` = Prefixed_Name(rdaa, "engraverOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50172</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is braille embosser of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50172">http://rdaregistry.info/Elements/a/P50172</seealso>
    let P50172 = Prefixed_Name(rdaa, "P50172") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:brailleEmbosserOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/brailleEmbosserOf.en">http://rdaregistry.info/Elements/a/brailleEmbosserOf.en</seealso>
    let ``brailleEmbosserOf.en`` =
        Prefixed_Name(rdaa, "brailleEmbosserOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50173</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is printmaker of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50173">http://rdaregistry.info/Elements/a/P50173</seealso>
    let P50173 = Prefixed_Name(rdaa, "P50173") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:printmakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/printmakerOf.en">http://rdaregistry.info/Elements/a/printmakerOf.en</seealso>
    let ``printmakerOf.en`` = Prefixed_Name(rdaa, "printmakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50194</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choreographer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50194">http://rdaregistry.info/Elements/a/P50194</seealso>
    let P50194 = Prefixed_Name(rdaa, "P50194") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:choreographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/choreographerOf.en">http://rdaregistry.info/Elements/a/choreographerOf.en</seealso>
    let ``choreographerOf.en`` =
        Prefixed_Name(rdaa, "choreographerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50195</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is author of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50195">http://rdaregistry.info/Elements/a/P50195</seealso>
    let P50195 = Prefixed_Name(rdaa, "P50195") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50223</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenwriter of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50223">http://rdaregistry.info/Elements/a/P50223</seealso>
    let P50223 = Prefixed_Name(rdaa, "P50223") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50224</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is lyricist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50224">http://rdaregistry.info/Elements/a/P50224</seealso>
    let P50224 = Prefixed_Name(rdaa, "P50224") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50225</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is librettist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50225">http://rdaregistry.info/Elements/a/P50225</seealso>
    let P50225 = Prefixed_Name(rdaa, "P50225") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50248</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is rapporteur of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50248">http://rdaregistry.info/Elements/a/P50248</seealso>
    let P50248 = Prefixed_Name(rdaa, "P50248") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:authorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/authorOf.en">http://rdaregistry.info/Elements/a/authorOf.en</seealso>
    let ``authorOf.en`` = Prefixed_Name(rdaa, "authorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50196</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is architect of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50196">http://rdaregistry.info/Elements/a/P50196</seealso>
    let P50196 = Prefixed_Name(rdaa, "P50196") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50221</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is landscape architect of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50221">http://rdaregistry.info/Elements/a/P50221</seealso>
    let P50221 = Prefixed_Name(rdaa, "P50221") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:architectOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/architectOf.en">http://rdaregistry.info/Elements/a/architectOf.en</seealso>
    let ``architectOf.en`` = Prefixed_Name(rdaa, "architectOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50197</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is filmmaker of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50197">http://rdaregistry.info/Elements/a/P50197</seealso>
    let P50197 = Prefixed_Name(rdaa, "P50197") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:filmmakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/filmmakerOf.en">http://rdaregistry.info/Elements/a/filmmakerOf.en</seealso>
    let ``filmmakerOf.en`` = Prefixed_Name(rdaa, "filmmakerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:productionDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/productionDesignerOf.en">http://rdaregistry.info/Elements/a/productionDesignerOf.en</seealso>
    let ``productionDesignerOf.en`` =
        Prefixed_Name(rdaa, "productionDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:distributorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/distributorOf.en">http://rdaregistry.info/Elements/a/distributorOf.en</seealso>
    let ``distributorOf.en`` = Prefixed_Name(rdaa, "distributorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50200</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is producer of an unpublished resource of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50200">http://rdaregistry.info/Elements/a/P50200</seealso>
    let P50200 = Prefixed_Name(rdaa, "P50200") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:producerOfAnUnpublishedResourceOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/producerOfAnUnpublishedResourceOf.en">http://rdaregistry.info/Elements/a/producerOfAnUnpublishedResourceOf.en</seealso>
    let ``producerOfAnUnpublishedResourceOf.en`` =
        Prefixed_Name(rdaa, "producerOfAnUnpublishedResourceOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50213</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is film producer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50213">http://rdaregistry.info/Elements/a/P50213</seealso>
    let P50213 = Prefixed_Name(rdaa, "P50213") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50214</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio producer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50214">http://rdaregistry.info/Elements/a/P50214</seealso>
    let P50214 = Prefixed_Name(rdaa, "P50214") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50215</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television producer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50215">http://rdaregistry.info/Elements/a/P50215</seealso>
    let P50215 = Prefixed_Name(rdaa, "P50215") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:producerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/producerOf.en">http://rdaregistry.info/Elements/a/producerOf.en</seealso>
    let ``producerOf.en`` = Prefixed_Name(rdaa, "producerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:restorationistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/restorationistOf.en">http://rdaregistry.info/Elements/a/restorationistOf.en</seealso>
    let ``restorationistOf.en`` =
        Prefixed_Name(rdaa, "restorationistOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:directorOfPhotographyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/directorOfPhotographyOf.en">http://rdaregistry.info/Elements/a/directorOfPhotographyOf.en</seealso>
    let ``directorOfPhotographyOf.en`` =
        Prefixed_Name(rdaa, "directorOfPhotographyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dedicateeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dedicateeOf.en">http://rdaregistry.info/Elements/a/dedicateeOf.en</seealso>
    let ``dedicateeOf.en`` = Prefixed_Name(rdaa, "dedicateeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:addresseeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/addresseeOf.en">http://rdaregistry.info/Elements/a/addresseeOf.en</seealso>
    let ``addresseeOf.en`` = Prefixed_Name(rdaa, "addresseeOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dedicateeOfItemOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dedicateeOfItemOf.en">http://rdaregistry.info/Elements/a/dedicateeOfItemOf.en</seealso>
    let ``dedicateeOfItemOf.en`` =
        Prefixed_Name(rdaa, "dedicateeOfItemOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:consultantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/consultantOf.en">http://rdaregistry.info/Elements/a/consultantOf.en</seealso>
    let ``consultantOf.en`` = Prefixed_Name(rdaa, "consultantOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:minuteTakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/minuteTakerOf.en">http://rdaregistry.info/Elements/a/minuteTakerOf.en</seealso>
    let ``minuteTakerOf.en`` = Prefixed_Name(rdaa, "minuteTakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:filmProducerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/filmProducerOf.en">http://rdaregistry.info/Elements/a/filmProducerOf.en</seealso>
    let ``filmProducerOf.en`` = Prefixed_Name(rdaa, "filmProducerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:radioProducerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/radioProducerOf.en">http://rdaregistry.info/Elements/a/radioProducerOf.en</seealso>
    let ``radioProducerOf.en`` =
        Prefixed_Name(rdaa, "radioProducerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:televisionProducerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/televisionProducerOf.en">http://rdaregistry.info/Elements/a/televisionProducerOf.en</seealso>
    let ``televisionProducerOf.en`` =
        Prefixed_Name(rdaa, "televisionProducerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfAddedLyricsOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfAddedLyricsOf.en">http://rdaregistry.info/Elements/a/writerOfAddedLyricsOf.en</seealso>
    let ``writerOfAddedLyricsOf.en`` =
        Prefixed_Name(rdaa, "writerOfAddedLyricsOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50219</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50219">http://rdaregistry.info/Elements/a/P50219</seealso>
    let P50219 = Prefixed_Name(rdaa, "P50219") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:relatedFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/relatedFamily.en">http://rdaregistry.info/Elements/a/relatedFamily.en</seealso>
    let ``relatedFamily.en`` = Prefixed_Name(rdaa, "relatedFamily.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50220</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50220">http://rdaregistry.info/Elements/a/P50220</seealso>
    let P50220 = Prefixed_Name(rdaa, "P50220") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:relatedPerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/relatedPerson.en">http://rdaregistry.info/Elements/a/relatedPerson.en</seealso>
    let ``relatedPerson.en`` = Prefixed_Name(rdaa, "relatedPerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:landscapeArchitectOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/landscapeArchitectOf.en">http://rdaregistry.info/Elements/a/landscapeArchitectOf.en</seealso>
    let ``landscapeArchitectOf.en`` =
        Prefixed_Name(rdaa, "landscapeArchitectOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:sculptorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sculptorOf.en">http://rdaregistry.info/Elements/a/sculptorOf.en</seealso>
    let ``sculptorOf.en`` = Prefixed_Name(rdaa, "sculptorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:screenwriterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/screenwriterOf.en">http://rdaregistry.info/Elements/a/screenwriterOf.en</seealso>
    let ``screenwriterOf.en`` = Prefixed_Name(rdaa, "screenwriterOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:lyricistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/lyricistOf.en">http://rdaregistry.info/Elements/a/lyricistOf.en</seealso>
    let ``lyricistOf.en`` = Prefixed_Name(rdaa, "lyricistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:librettistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/librettistOf.en">http://rdaregistry.info/Elements/a/librettistOf.en</seealso>
    let ``librettistOf.en`` = Prefixed_Name(rdaa, "librettistOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:sponsoringBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sponsoringBodyOf.en">http://rdaregistry.info/Elements/a/sponsoringBodyOf.en</seealso>
    let ``sponsoringBodyOf.en`` =
        Prefixed_Name(rdaa, "sponsoringBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50227</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of afterword of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50227">http://rdaregistry.info/Elements/a/P50227</seealso>
    let P50227 = Prefixed_Name(rdaa, "P50227") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfAfterwordOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfAfterwordOf.en">http://rdaregistry.info/Elements/a/writerOfAfterwordOf.en</seealso>
    let ``writerOfAfterwordOf.en`` =
        Prefixed_Name(rdaa, "writerOfAfterwordOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50228</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of postface of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50228">http://rdaregistry.info/Elements/a/P50228</seealso>
    let P50228 = Prefixed_Name(rdaa, "P50228") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:family.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/family.en">http://rdaregistry.info/Elements/a/family.en</seealso>
    let ``family.en`` = Prefixed_Name(rdaa, "family.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:officiatedCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/officiatedCorporateBody.en">http://rdaregistry.info/Elements/a/officiatedCorporateBody.en</seealso>
    let ``officiatedCorporateBody.en`` =
        Prefixed_Name(rdaa, "officiatedCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50235</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of the family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50235">http://rdaregistry.info/Elements/a/P50235</seealso>
    let P50235 = Prefixed_Name(rdaa, "P50235") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:languageOfTheFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/languageOfTheFamily.en">http://rdaregistry.info/Elements/a/languageOfTheFamily.en</seealso>
    let ``languageOfTheFamily.en`` =
        Prefixed_Name(rdaa, "languageOfTheFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:periodOfActivityOfTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/periodOfActivityOfTheCorporateBody.en">http://rdaregistry.info/Elements/a/periodOfActivityOfTheCorporateBody.en</seealso>
    let ``periodOfActivityOfTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "periodOfActivityOfTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50237</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has type of corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50237">http://rdaregistry.info/Elements/a/P50237</seealso>
    let P50237 = Prefixed_Name(rdaa, "P50237") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:typeOfCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/typeOfCorporateBody.en">http://rdaregistry.info/Elements/a/typeOfCorporateBody.en</seealso>
    let ``typeOfCorporateBody.en`` =
        Prefixed_Name(rdaa, "typeOfCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50238</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has type of jurisdiction</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50238">http://rdaregistry.info/Elements/a/P50238</seealso>
    let P50238 = Prefixed_Name(rdaa, "P50238") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:typeOfJurisdiction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/typeOfJurisdiction.en">http://rdaregistry.info/Elements/a/typeOfJurisdiction.en</seealso>
    let ``typeOfJurisdiction.en`` =
        Prefixed_Name(rdaa, "typeOfJurisdiction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50239</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other designation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50239">http://rdaregistry.info/Elements/a/P50239</seealso>
    let P50239 = Prefixed_Name(rdaa, "P50239") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:otherDesignation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/otherDesignation.en">http://rdaregistry.info/Elements/a/otherDesignation.en</seealso>
    let ``otherDesignation.en`` =
        Prefixed_Name(rdaa, "otherDesignation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50240</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has broader affiliated body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50240">http://rdaregistry.info/Elements/a/P50240</seealso>
    let P50240 = Prefixed_Name(rdaa, "P50240") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:broaderAffiliatedBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/broaderAffiliatedBody.en">http://rdaregistry.info/Elements/a/broaderAffiliatedBody.en</seealso>
    let ``broaderAffiliatedBody.en`` =
        Prefixed_Name(rdaa, "broaderAffiliatedBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50241</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has local affiliate</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50241">http://rdaregistry.info/Elements/a/P50241</seealso>
    let P50241 = Prefixed_Name(rdaa, "P50241") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:localAffiliate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/localAffiliate.en">http://rdaregistry.info/Elements/a/localAffiliate.en</seealso>
    let ``localAffiliate.en`` = Prefixed_Name(rdaa, "localAffiliate.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:calligrapherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/calligrapherOf.en">http://rdaregistry.info/Elements/a/calligrapherOf.en</seealso>
    let ``calligrapherOf.en`` = Prefixed_Name(rdaa, "calligrapherOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:bookArtistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/bookArtistOf.en">http://rdaregistry.info/Elements/a/bookArtistOf.en</seealso>
    let ``bookArtistOf.en`` = Prefixed_Name(rdaa, "bookArtistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:rapporteurOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/rapporteurOf.en">http://rdaregistry.info/Elements/a/rapporteurOf.en</seealso>
    let ``rapporteurOf.en`` = Prefixed_Name(rdaa, "rapporteurOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50249</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject of (person)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50249">http://rdaregistry.info/Elements/a/P50249</seealso>
    let P50249 = Prefixed_Name(rdaa, "P50249") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:subjectOfPerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/subjectOfPerson.en">http://rdaregistry.info/Elements/a/subjectOfPerson.en</seealso>
    let ``subjectOfPerson.en`` =
        Prefixed_Name(rdaa, "subjectOfPerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50250</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject of (family)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50250">http://rdaregistry.info/Elements/a/P50250</seealso>
    let P50250 = Prefixed_Name(rdaa, "P50250") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:subjectOfFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/subjectOfFamily.en">http://rdaregistry.info/Elements/a/subjectOfFamily.en</seealso>
    let ``subjectOfFamily.en`` =
        Prefixed_Name(rdaa, "subjectOfFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50251</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject of (corporate body)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50251">http://rdaregistry.info/Elements/a/P50251</seealso>
    let P50251 = Prefixed_Name(rdaa, "P50251") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:subjectOfCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/subjectOfCorporateBody.en">http://rdaregistry.info/Elements/a/subjectOfCorporateBody.en</seealso>
    let ``subjectOfCorporateBody.en`` =
        Prefixed_Name(rdaa, "subjectOfCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50252</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has graduate</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50252">http://rdaregistry.info/Elements/a/P50252</seealso>
    let P50252 = Prefixed_Name(rdaa, "P50252") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:graduate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/graduate.en">http://rdaregistry.info/Elements/a/graduate.en</seealso>
    let ``graduate.en`` = Prefixed_Name(rdaa, "graduate.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50253</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is graduate of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50253">http://rdaregistry.info/Elements/a/P50253</seealso>
    let P50253 = Prefixed_Name(rdaa, "P50253") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:graduateOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/graduateOf.en">http://rdaregistry.info/Elements/a/graduateOf.en</seealso>
    let ``graduateOf.en`` = Prefixed_Name(rdaa, "graduateOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfForewordOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfForewordOf.en">http://rdaregistry.info/Elements/a/writerOfForewordOf.en</seealso>
    let ``writerOfForewordOf.en`` =
        Prefixed_Name(rdaa, "writerOfForewordOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:soundDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/soundDesignerOf.en">http://rdaregistry.info/Elements/a/soundDesignerOf.en</seealso>
    let ``soundDesignerOf.en`` =
        Prefixed_Name(rdaa, "soundDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has incumbent</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50027">http://rdaregistry.info/Elements/a/P50027</seealso>
    let P50027 = Prefixed_Name(rdaa, "P50027") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has group member of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50095">http://rdaregistry.info/Elements/a/P50095</seealso>
    let P50095 = Prefixed_Name(rdaa, "P50095") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:nameOfTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/nameOfTheCorporateBody.en">http://rdaregistry.info/Elements/a/nameOfTheCorporateBody.en</seealso>
    let ``nameOfTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "nameOfTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:televisionDirectorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/televisionDirectorOf.en">http://rdaregistry.info/Elements/a/televisionDirectorOf.en</seealso>
    let ``televisionDirectorOf.en`` =
        Prefixed_Name(rdaa, "televisionDirectorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50069</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is jurisdiction governed of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50069">http://rdaregistry.info/Elements/a/P50069</seealso>
    let P50069 = Prefixed_Name(rdaa, "P50069") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:jurisdictionGovernedOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/jurisdictionGovernedOf.en">http://rdaregistry.info/Elements/a/jurisdictionGovernedOf.en</seealso>
    let ``jurisdictionGovernedOf.en`` =
        Prefixed_Name(rdaa, "jurisdictionGovernedOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50092</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is illuminator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50092">http://rdaregistry.info/Elements/a/P50092</seealso>
    let P50092 = Prefixed_Name(rdaa, "P50092") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50094</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has identifier for the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50094">http://rdaregistry.info/Elements/a/P50094</seealso>
    let P50094 = Prefixed_Name(rdaa, "P50094") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:identifierForThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/identifierForThePerson.en">http://rdaregistry.info/Elements/a/identifierForThePerson.en</seealso>
    let ``identifierForThePerson.en`` =
        Prefixed_Name(rdaa, "identifierForThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50125</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is inscriber of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50125">http://rdaregistry.info/Elements/a/P50125</seealso>
    let P50125 = Prefixed_Name(rdaa, "P50125") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:writerOfAddedTextOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/writerOfAddedTextOf.en">http://rdaregistry.info/Elements/a/writerOfAddedTextOf.en</seealso>
    let ``writerOfAddedTextOf.en`` =
        Prefixed_Name(rdaa, "writerOfAddedTextOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:currentOwnerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/currentOwnerOf.en">http://rdaregistry.info/Elements/a/currentOwnerOf.en</seealso>
    let ``currentOwnerOf.en`` = Prefixed_Name(rdaa, "currentOwnerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50165</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is owner of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50165">http://rdaregistry.info/Elements/a/P50165</seealso>
    let P50165 = Prefixed_Name(rdaa, "P50165") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50186</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is cartographer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50186">http://rdaregistry.info/Elements/a/P50186</seealso>
    let P50186 = Prefixed_Name(rdaa, "P50186") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50218</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50218">http://rdaregistry.info/Elements/a/P50218</seealso>
    let P50218 = Prefixed_Name(rdaa, "P50218") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:relatedCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/relatedCorporateBody.en">http://rdaregistry.info/Elements/a/relatedCorporateBody.en</seealso>
    let ``relatedCorporateBody.en`` =
        Prefixed_Name(rdaa, "relatedCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:degreeCommitteeMemberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/degreeCommitteeMemberOf.en">http://rdaregistry.info/Elements/a/degreeCommitteeMemberOf.en</seealso>
    let ``degreeCommitteeMemberOf.en`` =
        Prefixed_Name(rdaa, "degreeCommitteeMemberOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50260</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other place associated with the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50260">http://rdaregistry.info/Elements/a/P50260</seealso>
    let P50260 = Prefixed_Name(rdaa, "P50260") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:otherPlaceAssociatedWithTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/otherPlaceAssociatedWithTheCorporateBody.en">http://rdaregistry.info/Elements/a/otherPlaceAssociatedWithTheCorporateBody.en</seealso>
    let ``otherPlaceAssociatedWithTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "otherPlaceAssociatedWithTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:commissioningBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/commissioningBodyOf.en">http://rdaregistry.info/Elements/a/commissioningBodyOf.en</seealso>
    let ``commissioningBodyOf.en`` =
        Prefixed_Name(rdaa, "commissioningBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:softwareDeveloperOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/softwareDeveloperOf.en">http://rdaregistry.info/Elements/a/softwareDeveloperOf.en</seealso>
    let ``softwareDeveloperOf.en`` =
        Prefixed_Name(rdaa, "softwareDeveloperOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:researcherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/researcherOf.en">http://rdaregistry.info/Elements/a/researcherOf.en</seealso>
    let ``researcherOf.en`` = Prefixed_Name(rdaa, "researcherOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:choralConductorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/choralConductorOf.en">http://rdaregistry.info/Elements/a/choralConductorOf.en</seealso>
    let ``choralConductorOf.en`` =
        Prefixed_Name(rdaa, "choralConductorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:organizerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/organizerOf.en">http://rdaregistry.info/Elements/a/organizerOf.en</seealso>
    let ``organizerOf.en`` = Prefixed_Name(rdaa, "organizerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:productOfASplit.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/productOfASplit.en">http://rdaregistry.info/Elements/a/productOfASplit.en</seealso>
    let ``productOfASplit.en`` =
        Prefixed_Name(rdaa, "productOfASplit.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateOfDeath.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateOfDeath.en">http://rdaregistry.info/Elements/a/dateOfDeath.en</seealso>
    let ``dateOfDeath.en`` = Prefixed_Name(rdaa, "dateOfDeath.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50138</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of added text of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50138">http://rdaregistry.info/Elements/a/P50138</seealso>
    let P50138 = Prefixed_Name(rdaa, "P50138") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50216</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of added lyrics of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50216">http://rdaregistry.info/Elements/a/P50216</seealso>
    let P50216 = Prefixed_Name(rdaa, "P50216") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50154</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is writer of supplementary textual content of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50154">http://rdaregistry.info/Elements/a/P50154</seealso>
    let P50154 = Prefixed_Name(rdaa, "P50154") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:programmerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/programmerOf.en">http://rdaregistry.info/Elements/a/programmerOf.en</seealso>
    let ``programmerOf.en`` = Prefixed_Name(rdaa, "programmerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50185</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is designer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50185">http://rdaregistry.info/Elements/a/P50185</seealso>
    let P50185 = Prefixed_Name(rdaa, "P50185") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:designerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/designerOf.en">http://rdaregistry.info/Elements/a/designerOf.en</seealso>
    let ``designerOf.en`` = Prefixed_Name(rdaa, "designerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:voiceActorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/voiceActorOf.en">http://rdaregistry.info/Elements/a/voiceActorOf.en</seealso>
    let ``voiceActorOf.en`` = Prefixed_Name(rdaa, "voiceActorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:lightingDesignerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/lightingDesignerOf.en">http://rdaregistry.info/Elements/a/lightingDesignerOf.en</seealso>
    let ``lightingDesignerOf.en`` =
        Prefixed_Name(rdaa, "lightingDesignerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:defendantCorporateBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/defendantCorporateBodyOf.en">http://rdaregistry.info/Elements/a/defendantCorporateBodyOf.en</seealso>
    let ``defendantCorporateBodyOf.en`` =
        Prefixed_Name(rdaa, "defendantCorporateBodyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:defendantPersonOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/defendantPersonOf.en">http://rdaregistry.info/Elements/a/defendantPersonOf.en</seealso>
    let ``defendantPersonOf.en`` =
        Prefixed_Name(rdaa, "defendantPersonOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:onScreenParticipantOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/onScreenParticipantOf.en">http://rdaregistry.info/Elements/a/onScreenParticipantOf.en</seealso>
    let ``onScreenParticipantOf.en`` =
        Prefixed_Name(rdaa, "onScreenParticipantOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:participantInATreatyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/participantInATreatyOf.en">http://rdaregistry.info/Elements/a/participantInATreatyOf.en</seealso>
    let ``participantInATreatyOf.en`` =
        Prefixed_Name(rdaa, "participantInATreatyOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:colouristOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/colouristOf.en">http://rdaregistry.info/Elements/a/colouristOf.en</seealso>
    let ``colouristOf.en`` = Prefixed_Name(rdaa, "colouristOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:makeUpArtistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/makeUpArtistOf.en">http://rdaregistry.info/Elements/a/makeUpArtistOf.en</seealso>
    let ``makeUpArtistOf.en`` = Prefixed_Name(rdaa, "makeUpArtistOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:instrumentalConductorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/instrumentalConductorOf.en">http://rdaregistry.info/Elements/a/instrumentalConductorOf.en</seealso>
    let ``instrumentalConductorOf.en`` =
        Prefixed_Name(rdaa, "instrumentalConductorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:degreeGrantingInstitutionOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/degreeGrantingInstitutionOf.en">http://rdaregistry.info/Elements/a/degreeGrantingInstitutionOf.en</seealso>
    let ``degreeGrantingInstitutionOf.en`` =
        Prefixed_Name(rdaa, "degreeGrantingInstitutionOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:successor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/successor.en">http://rdaregistry.info/Elements/a/successor.en</seealso>
    let ``successor.en`` = Prefixed_Name(rdaa, "successor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:foundedCorporateBodyOfCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/foundedCorporateBodyOfCorporateBody.en">http://rdaregistry.info/Elements/a/foundedCorporateBodyOfCorporateBody.en</seealso>
    let ``foundedCorporateBodyOfCorporateBody.en`` =
        Prefixed_Name(rdaa, "foundedCorporateBodyOfCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:numberOfAConferenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/numberOfAConferenceEtc.en">http://rdaregistry.info/Elements/a/numberOfAConferenceEtc.en</seealso>
    let ``numberOfAConferenceEtc.en`` =
        Prefixed_Name(rdaa, "numberOfAConferenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:foundingFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/foundingFamily.en">http://rdaregistry.info/Elements/a/foundingFamily.en</seealso>
    let ``foundingFamily.en`` = Prefixed_Name(rdaa, "foundingFamily.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has founded corporate body of family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50062">http://rdaregistry.info/Elements/a/P50062</seealso>
    let P50062 = Prefixed_Name(rdaa, "P50062") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has language of the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50023">http://rdaregistry.info/Elements/a/P50023</seealso>
    let P50023 = Prefixed_Name(rdaa, "P50023") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has location of conference, etc.</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50024">http://rdaregistry.info/Elements/a/P50024</seealso>
    let P50024 = Prefixed_Name(rdaa, "P50024") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:preferredNameForTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/preferredNameForTheCorporateBody.en">http://rdaregistry.info/Elements/a/preferredNameForTheCorporateBody.en</seealso>
    let ``preferredNameForTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "preferredNameForTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50089</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is plaintiff of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50089">http://rdaregistry.info/Elements/a/P50089</seealso>
    let P50089 = Prefixed_Name(rdaa, "P50089") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is court governed of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50044">http://rdaregistry.info/Elements/a/P50044</seealso>
    let P50044 = Prefixed_Name(rdaa, "P50044") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50074</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is teacher of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50074">http://rdaregistry.info/Elements/a/P50074</seealso>
    let P50074 = Prefixed_Name(rdaa, "P50074") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:hostOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/hostOf.en">http://rdaregistry.info/Elements/a/hostOf.en</seealso>
    let ``hostOf.en`` = Prefixed_Name(rdaa, "hostOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50265</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is researcher of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50265">http://rdaregistry.info/Elements/a/P50265</seealso>
    let P50265 = Prefixed_Name(rdaa, "P50265") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50262</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commissioning body of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50262">http://rdaregistry.info/Elements/a/P50262</seealso>
    let P50262 = Prefixed_Name(rdaa, "P50262") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:dedicatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dedicatorOf.en">http://rdaregistry.info/Elements/a/dedicatorOf.en</seealso>
    let ``dedicatorOf.en`` = Prefixed_Name(rdaa, "dedicatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50176</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is platemaker of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50176">http://rdaregistry.info/Elements/a/P50176</seealso>
    let P50176 = Prefixed_Name(rdaa, "P50176") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:platemakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/platemakerOf.en">http://rdaregistry.info/Elements/a/platemakerOf.en</seealso>
    let ``platemakerOf.en`` = Prefixed_Name(rdaa, "platemakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50177</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is etcher of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50177">http://rdaregistry.info/Elements/a/P50177</seealso>
    let P50177 = Prefixed_Name(rdaa, "P50177") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50242</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is papermaker of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50242">http://rdaregistry.info/Elements/a/P50242</seealso>
    let P50242 = Prefixed_Name(rdaa, "P50242") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:manufacturerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/manufacturerOf.en">http://rdaregistry.info/Elements/a/manufacturerOf.en</seealso>
    let ``manufacturerOf.en`` = Prefixed_Name(rdaa, "manufacturerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:papermakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/papermakerOf.en">http://rdaregistry.info/Elements/a/papermakerOf.en</seealso>
    let ``papermakerOf.en`` = Prefixed_Name(rdaa, "papermakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is degree granting institution of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50003">http://rdaregistry.info/Elements/a/P50003</seealso>
    let P50003 = Prefixed_Name(rdaa, "P50003") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50131</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is other person, family, or corporate body associated with a work of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50131">http://rdaregistry.info/Elements/a/P50131</seealso>
    let P50131 = Prefixed_Name(rdaa, "P50131") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has identifier for the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50006">http://rdaregistry.info/Elements/a/P50006</seealso>
    let P50006 = Prefixed_Name(rdaa, "P50006") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has founding corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50007">http://rdaregistry.info/Elements/a/P50007</seealso>
    let P50007 = Prefixed_Name(rdaa, "P50007") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has founded corporate body of corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50017">http://rdaregistry.info/Elements/a/P50017</seealso>
    let P50017 = Prefixed_Name(rdaa, "P50017") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has hierarchical subordinate</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50010">http://rdaregistry.info/Elements/a/P50010</seealso>
    let P50010 = Prefixed_Name(rdaa, "P50010") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sponsored corporate body of corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50009">http://rdaregistry.info/Elements/a/P50009</seealso>
    let P50009 = Prefixed_Name(rdaa, "P50009") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:sponsoredCorporateBodyOfCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sponsoredCorporateBodyOfCorporateBody.en">http://rdaregistry.info/Elements/a/sponsoredCorporateBodyOfCorporateBody.en</seealso>
    let ``sponsoredCorporateBodyOfCorporateBody.en`` =
        Prefixed_Name(rdaa, "sponsoredCorporateBodyOfCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:hierarchicalSubordinate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/hierarchicalSubordinate.en">http://rdaregistry.info/Elements/a/hierarchicalSubordinate.en</seealso>
    let ``hierarchicalSubordinate.en`` =
        Prefixed_Name(rdaa, "hierarchicalSubordinate.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:mergee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/mergee.en">http://rdaregistry.info/Elements/a/mergee.en</seealso>
    let ``mergee.en`` = Prefixed_Name(rdaa, "mergee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:predecessor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/predecessor.en">http://rdaregistry.info/Elements/a/predecessor.en</seealso>
    let ``predecessor.en`` = Prefixed_Name(rdaa, "predecessor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has product of merger</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50013">http://rdaregistry.info/Elements/a/P50013</seealso>
    let P50013 = Prefixed_Name(rdaa, "P50013") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:productOfAMerger.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/productOfAMerger.en">http://rdaregistry.info/Elements/a/productOfAMerger.en</seealso>
    let ``productOfAMerger.en`` =
        Prefixed_Name(rdaa, "productOfAMerger.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:placeAssociatedWithTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/placeAssociatedWithTheCorporateBody.en">http://rdaregistry.info/Elements/a/placeAssociatedWithTheCorporateBody.en</seealso>
    let ``placeAssociatedWithTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "placeAssociatedWithTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other designation associated with the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50033">http://rdaregistry.info/Elements/a/P50033</seealso>
    let P50033 = Prefixed_Name(rdaa, "P50033") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:associatedInstitution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/associatedInstitution.en">http://rdaregistry.info/Elements/a/associatedInstitution.en</seealso>
    let ``associatedInstitution.en`` =
        Prefixed_Name(rdaa, "associatedInstitution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has address of the corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50036">http://rdaregistry.info/Elements/a/P50036</seealso>
    let P50036 = Prefixed_Name(rdaa, "P50036") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:addressOfTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/addressOfTheCorporateBody.en">http://rdaregistry.info/Elements/a/addressOfTheCorporateBody.en</seealso>
    let ``addressOfTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "addressOfTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of conference, etc.</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50039">http://rdaregistry.info/Elements/a/P50039</seealso>
    let P50039 = Prefixed_Name(rdaa, "P50039") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateOfConferenceEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateOfConferenceEtc.en">http://rdaregistry.info/Elements/a/dateOfConferenceEtc.en</seealso>
    let ``dateOfConferenceEtc.en`` =
        Prefixed_Name(rdaa, "dateOfConferenceEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has descendant family</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50053">http://rdaregistry.info/Elements/a/P50053</seealso>
    let P50053 = Prefixed_Name(rdaa, "P50053") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:descendantFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/descendantFamily.en">http://rdaregistry.info/Elements/a/descendantFamily.en</seealso>
    let ``descendantFamily.en`` =
        Prefixed_Name(rdaa, "descendantFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has descendants</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50099">http://rdaregistry.info/Elements/a/P50099</seealso>
    let P50099 = Prefixed_Name(rdaa, "P50099") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:familyMember.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/familyMember.en">http://rdaregistry.info/Elements/a/familyMember.en</seealso>
    let ``familyMember.en`` = Prefixed_Name(rdaa, "familyMember.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has hereditary title</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50059">http://rdaregistry.info/Elements/a/P50059</seealso>
    let P50059 = Prefixed_Name(rdaa, "P50059") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:hereditaryTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/hereditaryTitle.en">http://rdaregistry.info/Elements/a/hereditaryTitle.en</seealso>
    let ``hereditaryTitle.en`` =
        Prefixed_Name(rdaa, "hereditaryTitle.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:teacherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/teacherOf.en">http://rdaregistry.info/Elements/a/teacherOf.en</seealso>
    let ``teacherOf.en`` = Prefixed_Name(rdaa, "teacherOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is host of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50075">http://rdaregistry.info/Elements/a/P50075</seealso>
    let P50075 = Prefixed_Name(rdaa, "P50075") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50107</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date associated with the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50107">http://rdaregistry.info/Elements/a/P50107</seealso>
    let P50107 = Prefixed_Name(rdaa, "P50107") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:descendants.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/descendants.en">http://rdaregistry.info/Elements/a/descendants.en</seealso>
    let ``descendants.en`` = Prefixed_Name(rdaa, "descendants.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has field of activity of the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50100">http://rdaregistry.info/Elements/a/P50100</seealso>
    let P50100 = Prefixed_Name(rdaa, "P50100") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:languageOfThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/languageOfThePerson.en">http://rdaregistry.info/Elements/a/languageOfThePerson.en</seealso>
    let ``languageOfThePerson.en`` =
        Prefixed_Name(rdaa, "languageOfThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50103</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has variant name for the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50103">http://rdaregistry.info/Elements/a/P50103</seealso>
    let P50103 = Prefixed_Name(rdaa, "P50103") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:variantNameForThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/variantNameForThePerson.en">http://rdaregistry.info/Elements/a/variantNameForThePerson.en</seealso>
    let ``variantNameForThePerson.en`` =
        Prefixed_Name(rdaa, "variantNameForThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50111</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has name of the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50111">http://rdaregistry.info/Elements/a/P50111</seealso>
    let P50111 = Prefixed_Name(rdaa, "P50111") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50106</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has real identity</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50106">http://rdaregistry.info/Elements/a/P50106</seealso>
    let P50106 = Prefixed_Name(rdaa, "P50106") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:realIdentity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/realIdentity.en">http://rdaregistry.info/Elements/a/realIdentity.en</seealso>
    let ``realIdentity.en`` = Prefixed_Name(rdaa, "realIdentity.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50121</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of birth</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50121">http://rdaregistry.info/Elements/a/P50121</seealso>
    let P50121 = Prefixed_Name(rdaa, "P50121") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50120</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of death</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50120">http://rdaregistry.info/Elements/a/P50120</seealso>
    let P50120 = Prefixed_Name(rdaa, "P50120") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateAssociatedWithThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateAssociatedWithThePerson.en">http://rdaregistry.info/Elements/a/dateAssociatedWithThePerson.en</seealso>
    let ``dateAssociatedWithThePerson.en`` =
        Prefixed_Name(rdaa, "dateAssociatedWithThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50110</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has title of the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50110">http://rdaregistry.info/Elements/a/P50110</seealso>
    let P50110 = Prefixed_Name(rdaa, "P50110") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:titleOfThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/titleOfThePerson.en">http://rdaregistry.info/Elements/a/titleOfThePerson.en</seealso>
    let ``titleOfThePerson.en`` =
        Prefixed_Name(rdaa, "titleOfThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50117</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has preferred name for the person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50117">http://rdaregistry.info/Elements/a/P50117</seealso>
    let P50117 = Prefixed_Name(rdaa, "P50117") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:nameOfThePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/nameOfThePerson.en">http://rdaregistry.info/Elements/a/nameOfThePerson.en</seealso>
    let ``nameOfThePerson.en`` =
        Prefixed_Name(rdaa, "nameOfThePerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50129</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is autographer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50129">http://rdaregistry.info/Elements/a/P50129</seealso>
    let P50129 = Prefixed_Name(rdaa, "P50129") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:autographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/autographerOf.en">http://rdaregistry.info/Elements/a/autographerOf.en</seealso>
    let ``autographerOf.en`` = Prefixed_Name(rdaa, "autographerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50130</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is issuing body of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50130">http://rdaregistry.info/Elements/a/P50130</seealso>
    let P50130 = Prefixed_Name(rdaa, "P50130") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:issuingBodyOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/issuingBodyOf.en">http://rdaregistry.info/Elements/a/issuingBodyOf.en</seealso>
    let ``issuingBodyOf.en`` = Prefixed_Name(rdaa, "issuingBodyOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50132</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dedicator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50132">http://rdaregistry.info/Elements/a/P50132</seealso>
    let P50132 = Prefixed_Name(rdaa, "P50132") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50211</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is consultant of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50211">http://rdaregistry.info/Elements/a/P50211</seealso>
    let P50211 = Prefixed_Name(rdaa, "P50211") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50270</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is organizer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50270">http://rdaregistry.info/Elements/a/P50270</seealso>
    let P50270 = Prefixed_Name(rdaa, "P50270") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50257</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is degree committee member of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50257">http://rdaregistry.info/Elements/a/P50257</seealso>
    let P50257 = Prefixed_Name(rdaa, "P50257") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50208</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dedicatee of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50208">http://rdaregistry.info/Elements/a/P50208</seealso>
    let P50208 = Prefixed_Name(rdaa, "P50208") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50264</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is participant in a treaty of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50264">http://rdaregistry.info/Elements/a/P50264</seealso>
    let P50264 = Prefixed_Name(rdaa, "P50264") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50166</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is honouree of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50166">http://rdaregistry.info/Elements/a/P50166</seealso>
    let P50166 = Prefixed_Name(rdaa, "P50166") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50226</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is sponsoring body of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50226">http://rdaregistry.info/Elements/a/P50226</seealso>
    let P50226 = Prefixed_Name(rdaa, "P50226") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50209</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is addressee of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50209">http://rdaregistry.info/Elements/a/P50209</seealso>
    let P50209 = Prefixed_Name(rdaa, "P50209") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50207</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is director of photography of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50207">http://rdaregistry.info/Elements/a/P50207</seealso>
    let P50207 = Prefixed_Name(rdaa, "P50207") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50201</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is producer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50201">http://rdaregistry.info/Elements/a/P50201</seealso>
    let P50201 = Prefixed_Name(rdaa, "P50201") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:otherPFCWorkOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/otherPFCWorkOf.en">http://rdaregistry.info/Elements/a/otherPFCWorkOf.en</seealso>
    let ``otherPFCWorkOf.en`` = Prefixed_Name(rdaa, "otherPFCWorkOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50183</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is editor of moving image work of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50183">http://rdaregistry.info/Elements/a/P50183</seealso>
    let P50183 = Prefixed_Name(rdaa, "P50183") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50266</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is colourist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50266">http://rdaregistry.info/Elements/a/P50266</seealso>
    let P50266 = Prefixed_Name(rdaa, "P50266") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50243</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is visual effects provider of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50243">http://rdaregistry.info/Elements/a/P50243</seealso>
    let P50243 = Prefixed_Name(rdaa, "P50243") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50255</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is sound designer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50255">http://rdaregistry.info/Elements/a/P50255</seealso>
    let P50255 = Prefixed_Name(rdaa, "P50255") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50180</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is presenter of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50180">http://rdaregistry.info/Elements/a/P50180</seealso>
    let P50180 = Prefixed_Name(rdaa, "P50180") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50244</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is special effects provider of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50244">http://rdaregistry.info/Elements/a/P50244</seealso>
    let P50244 = Prefixed_Name(rdaa, "P50244") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50261</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is on-screen participant of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50261">http://rdaregistry.info/Elements/a/P50261</seealso>
    let P50261 = Prefixed_Name(rdaa, "P50261") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50267</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is make-up artist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50267">http://rdaregistry.info/Elements/a/P50267</seealso>
    let P50267 = Prefixed_Name(rdaa, "P50267") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:contributorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/contributorOf.en">http://rdaregistry.info/Elements/a/contributorOf.en</seealso>
    let ``contributorOf.en`` = Prefixed_Name(rdaa, "contributorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:formerOwnerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/formerOwnerOf.en">http://rdaregistry.info/Elements/a/formerOwnerOf.en</seealso>
    let ``formerOwnerOf.en`` = Prefixed_Name(rdaa, "formerOwnerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50164</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is custodian of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50164">http://rdaregistry.info/Elements/a/P50164</seealso>
    let P50164 = Prefixed_Name(rdaa, "P50164") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:custodianOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/custodianOf.en">http://rdaregistry.info/Elements/a/custodianOf.en</seealso>
    let ``custodianOf.en`` = Prefixed_Name(rdaa, "custodianOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50192</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is artist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50192">http://rdaregistry.info/Elements/a/P50192</seealso>
    let P50192 = Prefixed_Name(rdaa, "P50192") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50247</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is book artist of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50247">http://rdaregistry.info/Elements/a/P50247</seealso>
    let P50247 = Prefixed_Name(rdaa, "P50247") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50246</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is calligrapher of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50246">http://rdaregistry.info/Elements/a/P50246</seealso>
    let P50246 = Prefixed_Name(rdaa, "P50246") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50222</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is sculptor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50222">http://rdaregistry.info/Elements/a/P50222</seealso>
    let P50222 = Prefixed_Name(rdaa, "P50222") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:artistOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/artistOf.en">http://rdaregistry.info/Elements/a/artistOf.en</seealso>
    let ``artistOf.en`` = Prefixed_Name(rdaa, "artistOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50193</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is interviewee of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50193">http://rdaregistry.info/Elements/a/P50193</seealso>
    let P50193 = Prefixed_Name(rdaa, "P50193") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:intervieweeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/intervieweeOf.en">http://rdaregistry.info/Elements/a/intervieweeOf.en</seealso>
    let ``intervieweeOf.en`` = Prefixed_Name(rdaa, "intervieweeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/">http://rdaregistry.info/Elements/a/</seealso>
    let _prefix_iri = Prefixed_Name(rdaa, "") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appellee corporate body of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50002">http://rdaregistry.info/Elements/a/P50002</seealso>
    let P50002 = Prefixed_Name(rdaa, "P50002") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:identifierForTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/identifierForTheCorporateBody.en">http://rdaregistry.info/Elements/a/identifierForTheCorporateBody.en</seealso>
    let ``identifierForTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "identifierForTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:languageOfTheCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/languageOfTheCorporateBody.en">http://rdaregistry.info/Elements/a/languageOfTheCorporateBody.en</seealso>
    let ``languageOfTheCorporateBody.en`` =
        Prefixed_Name(rdaa, "languageOfTheCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has employer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50096">http://rdaregistry.info/Elements/a/P50096</seealso>
    let P50096 = Prefixed_Name(rdaa, "P50096") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:sponsor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/sponsor.en">http://rdaregistry.info/Elements/a/sponsor.en</seealso>
    let ``sponsor.en`` = Prefixed_Name(rdaa, "sponsor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:groupMember.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/groupMember.en">http://rdaregistry.info/Elements/a/groupMember.en</seealso>
    let ``groupMember.en`` = Prefixed_Name(rdaa, "groupMember.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has family history</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50064">http://rdaregistry.info/Elements/a/P50064</seealso>
    let P50064 = Prefixed_Name(rdaa, "P50064") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:familyHistory.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/familyHistory.en">http://rdaregistry.info/Elements/a/familyHistory.en</seealso>
    let ``familyHistory.en`` = Prefixed_Name(rdaa, "familyHistory.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50082</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is storyteller of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50082">http://rdaregistry.info/Elements/a/P50082</seealso>
    let P50082 = Prefixed_Name(rdaa, "P50082") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:speakerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/speakerOf.en">http://rdaregistry.info/Elements/a/speakerOf.en</seealso>
    let ``speakerOf.en`` = Prefixed_Name(rdaa, "speakerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50085</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appellee person of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50085">http://rdaregistry.info/Elements/a/P50085</seealso>
    let P50085 = Prefixed_Name(rdaa, "P50085") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:appelleePersonOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/appelleePersonOf.en">http://rdaregistry.info/Elements/a/appelleePersonOf.en</seealso>
    let ``appelleePersonOf.en`` =
        Prefixed_Name(rdaa, "appelleePersonOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:appelleeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/appelleeOf.en">http://rdaregistry.info/Elements/a/appelleeOf.en</seealso>
    let ``appelleeOf.en`` = Prefixed_Name(rdaa, "appelleeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:plaintiffOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/plaintiffOf.en">http://rdaregistry.info/Elements/a/plaintiffOf.en</seealso>
    let ``plaintiffOf.en`` = Prefixed_Name(rdaa, "plaintiffOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50091</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is degree supervisor of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50091">http://rdaregistry.info/Elements/a/P50091</seealso>
    let P50091 = Prefixed_Name(rdaa, "P50091") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:degreeSupervisorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/degreeSupervisorOf.en">http://rdaregistry.info/Elements/a/degreeSupervisorOf.en</seealso>
    let ``degreeSupervisorOf.en`` =
        Prefixed_Name(rdaa, "degreeSupervisorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:undifferentiatedNameIndicator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/undifferentiatedNameIndicator.en">http://rdaregistry.info/Elements/a/undifferentiatedNameIndicator.en</seealso>
    let ``undifferentiatedNameIndicator.en`` =
        Prefixed_Name(rdaa, "undifferentiatedNameIndicator.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:dateOfBirth.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/dateOfBirth.en">http://rdaregistry.info/Elements/a/dateOfBirth.en</seealso>
    let ``dateOfBirth.en`` = Prefixed_Name(rdaa, "dateOfBirth.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:appellantPersonOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/appellantPersonOf.en">http://rdaregistry.info/Elements/a/appellantPersonOf.en</seealso>
    let ``appellantPersonOf.en`` =
        Prefixed_Name(rdaa, "appellantPersonOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:P50123</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is binder of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50123">http://rdaregistry.info/Elements/a/P50123</seealso>
    let P50123 = Prefixed_Name(rdaa, "P50123") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:binderOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/binderOf.en">http://rdaregistry.info/Elements/a/binderOf.en</seealso>
    let ``binderOf.en`` = Prefixed_Name(rdaa, "binderOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:plaintiffPersonOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/plaintiffPersonOf.en">http://rdaregistry.info/Elements/a/plaintiffPersonOf.en</seealso>
    let ``plaintiffPersonOf.en`` =
        Prefixed_Name(rdaa, "plaintiffPersonOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:inscriberOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/inscriberOf.en">http://rdaregistry.info/Elements/a/inscriberOf.en</seealso>
    let ``inscriberOf.en`` = Prefixed_Name(rdaa, "inscriberOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50126</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is judge of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50126">http://rdaregistry.info/Elements/a/P50126</seealso>
    let P50126 = Prefixed_Name(rdaa, "P50126") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:judgeOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/judgeOf.en">http://rdaregistry.info/Elements/a/judgeOf.en</seealso>
    let ``judgeOf.en`` = Prefixed_Name(rdaa, "judgeOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50127</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is praeses of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50127">http://rdaregistry.info/Elements/a/P50127</seealso>
    let P50127 = Prefixed_Name(rdaa, "P50127") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:praesesOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/praesesOf.en">http://rdaregistry.info/Elements/a/praesesOf.en</seealso>
    let ``praesesOf.en`` = Prefixed_Name(rdaa, "praesesOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50128</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is annotator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50128">http://rdaregistry.info/Elements/a/P50128</seealso>
    let P50128 = Prefixed_Name(rdaa, "P50128") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50145</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is translator of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50145">http://rdaregistry.info/Elements/a/P50145</seealso>
    let P50145 = Prefixed_Name(rdaa, "P50145") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:translatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/translatorOf.en">http://rdaregistry.info/Elements/a/translatorOf.en</seealso>
    let ``translatorOf.en`` = Prefixed_Name(rdaa, "translatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50174</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is caster of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50174">http://rdaregistry.info/Elements/a/P50174</seealso>
    let P50174 = Prefixed_Name(rdaa, "P50174") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:casterOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/casterOf.en">http://rdaregistry.info/Elements/a/casterOf.en</seealso>
    let ``casterOf.en`` = Prefixed_Name(rdaa, "casterOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50175</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is lithographer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50175">http://rdaregistry.info/Elements/a/P50175</seealso>
    let P50175 = Prefixed_Name(rdaa, "P50175") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:lithographerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/lithographerOf.en">http://rdaregistry.info/Elements/a/lithographerOf.en</seealso>
    let ``lithographerOf.en`` = Prefixed_Name(rdaa, "lithographerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:etcherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/etcherOf.en">http://rdaregistry.info/Elements/a/etcherOf.en</seealso>
    let ``etcherOf.en`` = Prefixed_Name(rdaa, "etcherOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50178</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is collotyper of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50178">http://rdaregistry.info/Elements/a/P50178</seealso>
    let P50178 = Prefixed_Name(rdaa, "P50178") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:collotyperOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/collotyperOf.en">http://rdaregistry.info/Elements/a/collotyperOf.en</seealso>
    let ``collotyperOf.en`` = Prefixed_Name(rdaa, "collotyperOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:P50179</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is printer of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/P50179">http://rdaregistry.info/Elements/a/P50179</seealso>
    let P50179 = Prefixed_Name(rdaa, "P50179") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:printerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/printerOf.en">http://rdaregistry.info/Elements/a/printerOf.en</seealso>
    let ``printerOf.en`` = Prefixed_Name(rdaa, "printerOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:publisherOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/publisherOf.en">http://rdaregistry.info/Elements/a/publisherOf.en</seealso>
    let ``publisherOf.en`` = Prefixed_Name(rdaa, "publisherOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:creatorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/creatorOf.en">http://rdaregistry.info/Elements/a/creatorOf.en</seealso>
    let ``creatorOf.en`` = Prefixed_Name(rdaa, "creatorOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaa:directorOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/directorOf.en">http://rdaregistry.info/Elements/a/directorOf.en</seealso>
    let ``directorOf.en`` = Prefixed_Name(rdaa, "directorOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:visualEffectsProviderOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/visualEffectsProviderOf.en">http://rdaregistry.info/Elements/a/visualEffectsProviderOf.en</seealso>
    let ``visualEffectsProviderOf.en`` =
        Prefixed_Name(rdaa, "visualEffectsProviderOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:specialEffectsProviderOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/specialEffectsProviderOf.en">http://rdaregistry.info/Elements/a/specialEffectsProviderOf.en</seealso>
    let ``specialEffectsProviderOf.en`` =
        Prefixed_Name(rdaa, "specialEffectsProviderOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaa:lettererOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/a/lettererOf.en">http://rdaregistry.info/Elements/a/lettererOf.en</seealso>
    let ``lettererOf.en`` = Prefixed_Name(rdaa, "lettererOf.en") |> PrefixedName
