namespace http.rdvocab.info.Elements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdagr1 =
    let _namespace_iri = Namespace_Iri rdagr1 |> NamespaceIRI

    /// <summary>
    ///   <para>rdagr1:DistributionStatementEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Distribution Statement Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/DistributionStatementEncodingScheme">http://rdvocab.info/Elements/DistributionStatementEncodingScheme</seealso>
    let DistributionStatementEncodingScheme =
        Prefixed_Name(rdagr1, "DistributionStatementEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:configurationOfPlaybackChannels</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Configuration of playback channels</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/configurationOfPlaybackChannels">http://rdvocab.info/Elements/configurationOfPlaybackChannels</seealso>
    let configurationOfPlaybackChannels =
        Prefixed_Name(rdagr1, "configurationOfPlaybackChannels") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:configurationOfPlaybackChannelsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Configuration of playback channels (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/configurationOfPlaybackChannelsManifestation">http://rdvocab.info/Elements/configurationOfPlaybackChannelsManifestation</seealso>
    let configurationOfPlaybackChannelsManifestation =
        Prefixed_Name(rdagr1, "configurationOfPlaybackChannelsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:soundCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sound characteristic</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/soundCharacteristic">http://rdvocab.info/Elements/soundCharacteristic</seealso>
    let soundCharacteristic =
        Prefixed_Name(rdagr1, "soundCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:contactInformationItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contact information (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/contactInformationItem">http://rdvocab.info/Elements/contactInformationItem</seealso>
    let contactInformationItem =
        Prefixed_Name(rdagr1, "contactInformationItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:contentTypeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Content type (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/contentTypeExpression">http://rdvocab.info/Elements/contentTypeExpression</seealso>
    let contentTypeExpression =
        Prefixed_Name(rdagr1, "contentTypeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:natureOfTheContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nature of the content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/natureOfTheContent">http://rdvocab.info/Elements/natureOfTheContent</seealso>
    let natureOfTheContent = Prefixed_Name(rdagr1, "natureOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:natureOfTheContentWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nature of the content (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/natureOfTheContentWork">http://rdvocab.info/Elements/natureOfTheContentWork</seealso>
    let natureOfTheContentWork =
        Prefixed_Name(rdagr1, "natureOfTheContentWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:specialPlaybackCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Special playback characteristic</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/specialPlaybackCharacteristic">http://rdvocab.info/Elements/specialPlaybackCharacteristic</seealso>
    let specialPlaybackCharacteristic =
        Prefixed_Name(rdagr1, "specialPlaybackCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:trackConfigurationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Track configuration (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/trackConfigurationManifestation">http://rdvocab.info/Elements/trackConfigurationManifestation</seealso>
    let trackConfigurationManifestation =
        Prefixed_Name(rdagr1, "trackConfigurationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:soundContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sound content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/soundContent">http://rdvocab.info/Elements/soundContent</seealso>
    let soundContent = Prefixed_Name(rdagr1, "soundContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:soundContentManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sound content (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/soundContentManifestation">http://rdvocab.info/Elements/soundContentManifestation</seealso>
    let soundContentManifestation =
        Prefixed_Name(rdagr1, "soundContentManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:soundContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sound content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/soundContentExpression">http://rdvocab.info/Elements/soundContentExpression</seealso>
    let soundContentExpression =
        Prefixed_Name(rdagr1, "soundContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:sourceConsulted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Source consulted</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/sourceConsulted">http://rdvocab.info/Elements/sourceConsulted</seealso>
    let sourceConsulted = Prefixed_Name(rdagr1, "sourceConsulted") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to a named revision of an edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToANamedRevisionOfAnEdition">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToANamedRevisionOfAnEdition</seealso>
    let statementOfResponsibilityRelatingToANamedRevisionOfAnEdition =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToANamedRevisionOfAnEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to a named revision of an edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion</seealso>
    let statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSeries">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSeries</seealso>
    let statementOfResponsibilityRelatingToSeries =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSeriesManifestation">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSeriesManifestation</seealso>
    let statementOfResponsibilityRelatingToSeriesManifestation =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:StatementOfResponsibilityRelatingToTheEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to the edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/StatementOfResponsibilityRelatingToTheEdition">http://rdvocab.info/Elements/StatementOfResponsibilityRelatingToTheEdition</seealso>
    let StatementOfResponsibilityRelatingToTheEdition =
        Prefixed_Name(rdagr1, "StatementOfResponsibilityRelatingToTheEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:abbreviatedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abbreviated title</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/abbreviatedTitle">http://rdvocab.info/Elements/abbreviatedTitle</seealso>
    let abbreviatedTitle = Prefixed_Name(rdagr1, "abbreviatedTitle") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherDetailsOfCartographicContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other details of cartographic content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherDetailsOfCartographicContentExpression">http://rdvocab.info/Elements/otherDetailsOfCartographicContentExpression</seealso>
    let otherDetailsOfCartographicContentExpression =
        Prefixed_Name(rdagr1, "otherDetailsOfCartographicContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherDistinguishingCharacteristicOfTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other distinguishing characteristic of the work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherDistinguishingCharacteristicOfTheWork">http://rdvocab.info/Elements/otherDistinguishingCharacteristicOfTheWork</seealso>
    let otherDistinguishingCharacteristicOfTheWork =
        Prefixed_Name(rdagr1, "otherDistinguishingCharacteristicOfTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherTitleInformationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other title information (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherTitleInformationManifestation">http://rdvocab.info/Elements/otherTitleInformationManifestation</seealso>
    let otherTitleInformationManifestation =
        Prefixed_Name(rdagr1, "otherTitleInformationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:projectionSpeedManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Projection speed (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/projectionSpeedManifestation">http://rdvocab.info/Elements/projectionSpeedManifestation</seealso>
    let projectionSpeedManifestation =
        Prefixed_Name(rdagr1, "projectionSpeedManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:frequencyManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Frequency (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/frequencyManifestation">http://rdvocab.info/Elements/frequencyManifestation</seealso>
    let frequencyManifestation =
        Prefixed_Name(rdagr1, "frequencyManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationManifestation">http://rdvocab.info/Elements/generationManifestation</seealso>
    let generationManifestation =
        Prefixed_Name(rdagr1, "generationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfMicroform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of microform</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfMicroform">http://rdvocab.info/Elements/generationOfMicroform</seealso>
    let generationOfMicroform =
        Prefixed_Name(rdagr1, "generationOfMicroform") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfDigitalResourceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of digital resource (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfDigitalResourceManifestation">http://rdvocab.info/Elements/generationOfDigitalResourceManifestation</seealso>
    let generationOfDigitalResourceManifestation =
        Prefixed_Name(rdagr1, "generationOfDigitalResourceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:grantingInstitutionOrFaculty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Granting institution or faculty</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/grantingInstitutionOrFaculty">http://rdvocab.info/Elements/grantingInstitutionOrFaculty</seealso>
    let grantingInstitutionOrFaculty =
        Prefixed_Name(rdagr1, "grantingInstitutionOrFaculty") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:grantingInstitutionOrFacultyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Granting institution or faculty (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/grantingInstitutionOrFacultyWork">http://rdvocab.info/Elements/grantingInstitutionOrFacultyWork</seealso>
    let grantingInstitutionOrFacultyWork =
        Prefixed_Name(rdagr1, "grantingInstitutionOrFacultyWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:grooveCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Groove characteristic</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/grooveCharacteristic">http://rdvocab.info/Elements/grooveCharacteristic</seealso>
    let grooveCharacteristic =
        Prefixed_Name(rdagr1, "grooveCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:grooveCharacteristicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Groove characteristic (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/grooveCharacteristicManifestation">http://rdvocab.info/Elements/grooveCharacteristicManifestation</seealso>
    let grooveCharacteristicManifestation =
        Prefixed_Name(rdagr1, "grooveCharacteristicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:historyOfTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>History of the work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/historyOfTheWork">http://rdvocab.info/Elements/historyOfTheWork</seealso>
    let historyOfTheWork = Prefixed_Name(rdagr1, "historyOfTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:horizontalScaleOfCartographicContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Horizontal scale of cartographic content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/horizontalScaleOfCartographicContent">http://rdvocab.info/Elements/horizontalScaleOfCartographicContent</seealso>
    let horizontalScaleOfCartographicContent =
        Prefixed_Name(rdagr1, "horizontalScaleOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:horizontalScaleOfCartographicContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Horizontal scale of cartographic content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/horizontalScaleOfCartographicContentExpression">http://rdvocab.info/Elements/horizontalScaleOfCartographicContentExpression</seealso>
    let horizontalScaleOfCartographicContentExpression =
        Prefixed_Name(rdagr1, "horizontalScaleOfCartographicContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:identifierForTheItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier for the item</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/identifierForTheItem">http://rdvocab.info/Elements/identifierForTheItem</seealso>
    let identifierForTheItem =
        Prefixed_Name(rdagr1, "identifierForTheItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:plateNumberForMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>See also Publisher's number for music.</para>
    /// labels<para>Plate number for music</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/plateNumberForMusic">http://rdvocab.info/Elements/plateNumberForMusic</seealso>
    let plateNumberForMusic =
        Prefixed_Name(rdagr1, "plateNumberForMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:publishersNumberForMusicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Publisher's number for music (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/publishersNumberForMusicManifestation">http://rdvocab.info/Elements/publishersNumberForMusicManifestation</seealso>
    let publishersNumberForMusicManifestation =
        Prefixed_Name(rdagr1, "publishersNumberForMusicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:identifierForTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier for the work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/identifierForTheWork">http://rdvocab.info/Elements/identifierForTheWork</seealso>
    let identifierForTheWork =
        Prefixed_Name(rdagr1, "identifierForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:immediateSourceOfAcquisitionOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Immediate source of acquisition of item</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/immediateSourceOfAcquisitionOfItem">http://rdvocab.info/Elements/immediateSourceOfAcquisitionOfItem</seealso>
    let immediateSourceOfAcquisitionOfItem =
        Prefixed_Name(rdagr1, "immediateSourceOfAcquisitionOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:intendedAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Intended audience</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/intendedAudience">http://rdvocab.info/Elements/intendedAudience</seealso>
    let intendedAudience = Prefixed_Name(rdagr1, "intendedAudience") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:issnOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ISSN of series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/issnOfSeries">http://rdvocab.info/Elements/issnOfSeries</seealso>
    let issnOfSeries = Prefixed_Name(rdagr1, "issnOfSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:issnOfSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ISSN of series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/issnOfSeriesManifestation">http://rdvocab.info/Elements/issnOfSeriesManifestation</seealso>
    let issnOfSeriesManifestation =
        Prefixed_Name(rdagr1, "issnOfSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelDesignationOfEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel designation of edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelDesignationOfEdition">http://rdvocab.info/Elements/parallelDesignationOfEdition</seealso>
    let parallelDesignationOfEdition =
        Prefixed_Name(rdagr1, "parallelDesignationOfEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelDesignationOfEditionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel designation of edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelDesignationOfEditionManifestation">http://rdvocab.info/Elements/parallelDesignationOfEditionManifestation</seealso>
    let parallelDesignationOfEditionManifestation =
        Prefixed_Name(rdagr1, "parallelDesignationOfEditionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelDistributorsName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel distributor's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelDistributorsName">http://rdvocab.info/Elements/parallelDistributorsName</seealso>
    let parallelDistributorsName =
        Prefixed_Name(rdagr1, "parallelDistributorsName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelManufacturersName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel manufacturer's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelManufacturersName">http://rdvocab.info/Elements/parallelManufacturersName</seealso>
    let parallelManufacturersName =
        Prefixed_Name(rdagr1, "parallelManufacturersName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelManufacturersNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel manufacturer's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelManufacturersNameManifestation">http://rdvocab.info/Elements/parallelManufacturersNameManifestation</seealso>
    let parallelManufacturersNameManifestation =
        Prefixed_Name(rdagr1, "parallelManufacturersNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelOtherTitleInformationOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel other title information of series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSeries">http://rdvocab.info/Elements/parallelOtherTitleInformationOfSeries</seealso>
    let parallelOtherTitleInformationOfSeries =
        Prefixed_Name(rdagr1, "parallelOtherTitleInformationOfSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelOtherTitleInformationOfSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel other title information of series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSeriesManifestation">http://rdvocab.info/Elements/parallelOtherTitleInformationOfSeriesManifestation</seealso>
    let parallelOtherTitleInformationOfSeriesManifestation =
        Prefixed_Name(rdagr1, "parallelOtherTitleInformationOfSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelOtherTitleInformationOfSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel other title information of subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSubseries">http://rdvocab.info/Elements/parallelOtherTitleInformationOfSubseries</seealso>
    let parallelOtherTitleInformationOfSubseries =
        Prefixed_Name(rdagr1, "parallelOtherTitleInformationOfSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelOtherTitleInformationOfSubseriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel other title information of subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSubseriesManifestation">http://rdvocab.info/Elements/parallelOtherTitleInformationOfSubseriesManifestation</seealso>
    let parallelOtherTitleInformationOfSubseriesManifestation =
        Prefixed_Name(rdagr1, "parallelOtherTitleInformationOfSubseriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of distribution</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfDistribution">http://rdvocab.info/Elements/parallelPlaceOfDistribution</seealso>
    let parallelPlaceOfDistribution =
        Prefixed_Name(rdagr1, "parallelPlaceOfDistribution") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfDistributionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of distribution (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfDistributionManifestation">http://rdvocab.info/Elements/parallelPlaceOfDistributionManifestation</seealso>
    let parallelPlaceOfDistributionManifestation =
        Prefixed_Name(rdagr1, "parallelPlaceOfDistributionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Duration</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/duration">http://rdvocab.info/Elements/duration</seealso>
    let duration = Prefixed_Name(rdagr1, "duration") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:earlierTitleProper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Earlier title proper</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/earlierTitleProper">http://rdvocab.info/Elements/earlierTitleProper</seealso>
    let earlierTitleProper = Prefixed_Name(rdagr1, "earlierTitleProper") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:intendedAudienceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Intended audience (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/intendedAudienceWork">http://rdvocab.info/Elements/intendedAudienceWork</seealso>
    let intendedAudienceWork =
        Prefixed_Name(rdagr1, "intendedAudienceWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:issnOfSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ISSN of subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/issnOfSubseries">http://rdvocab.info/Elements/issnOfSubseries</seealso>
    let issnOfSubseries = Prefixed_Name(rdagr1, "issnOfSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:issnOfSubseriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ISSN of subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/issnOfSubseriesManifestation">http://rdvocab.info/Elements/issnOfSubseriesManifestation</seealso>
    let issnOfSubseriesManifestation =
        Prefixed_Name(rdagr1, "issnOfSubseriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:item-specificCarrierCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Item-specific carrier characteristic</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/item-specificCarrierCharacteristic">http://rdvocab.info/Elements/item-specificCarrierCharacteristic</seealso>
    let item_specificCarrierCharacteristic =
        Prefixed_Name(rdagr1, "item-specificCarrierCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:item-specificCarrierCharacteristicOfEarlyPrintedResources</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Includes rubrication, illumination, and other hand colouring, manuscript additions, and binding.</para>
    /// labels<para>Item-specific carrier characteristic of early printed resources</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/item-specificCarrierCharacteristicOfEarlyPrintedResources">http://rdvocab.info/Elements/item-specificCarrierCharacteristicOfEarlyPrintedResources</seealso>
    let item_specificCarrierCharacteristicOfEarlyPrintedResources =
        Prefixed_Name(rdagr1, "item-specificCarrierCharacteristicOfEarlyPrintedResources") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelDistributorsNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel distributor's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelDistributorsNameManifestation">http://rdvocab.info/Elements/parallelDistributorsNameManifestation</seealso>
    let parallelDistributorsNameManifestation =
        Prefixed_Name(rdagr1, "parallelDistributorsNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelOtherTitleInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel other title information</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelOtherTitleInformation">http://rdvocab.info/Elements/parallelOtherTitleInformation</seealso>
    let parallelOtherTitleInformation =
        Prefixed_Name(rdagr1, "parallelOtherTitleInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelOtherTitleInformationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel other title information (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelOtherTitleInformationManifestation">http://rdvocab.info/Elements/parallelOtherTitleInformationManifestation</seealso>
    let parallelOtherTitleInformationManifestation =
        Prefixed_Name(rdagr1, "parallelOtherTitleInformationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:restrictionsOnAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Restrictions on access</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/restrictionsOnAccess">http://rdvocab.info/Elements/restrictionsOnAccess</seealso>
    let restrictionsOnAccess =
        Prefixed_Name(rdagr1, "restrictionsOnAccess") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:restrictionsOnAccessManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Restrictions on access (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/restrictionsOnAccessManifestation">http://rdvocab.info/Elements/restrictionsOnAccessManifestation</seealso>
    let restrictionsOnAccessManifestation =
        Prefixed_Name(rdagr1, "restrictionsOnAccessManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:restrictionsOnUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Restrictions on use</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/restrictionsOnUse">http://rdvocab.info/Elements/restrictionsOnUse</seealso>
    let restrictionsOnUse = Prefixed_Name(rdagr1, "restrictionsOnUse") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:restrictionsOnUseManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Restrictions on use (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/restrictionsOnUseManifestation">http://rdvocab.info/Elements/restrictionsOnUseManifestation</seealso>
    let restrictionsOnUseManifestation =
        Prefixed_Name(rdagr1, "restrictionsOnUseManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:verticalScaleCartographicContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Vertical scale of cartographic content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/verticalScaleCartographicContent">http://rdvocab.info/Elements/verticalScaleCartographicContent</seealso>
    let verticalScaleCartographicContent =
        Prefixed_Name(rdagr1, "verticalScaleCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:scaleOfStillImageOrThree-dimensionalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Scale of still image or three-dimensional form</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/scaleOfStillImageOrThree-dimensionalForm">http://rdvocab.info/Elements/scaleOfStillImageOrThree-dimensionalForm</seealso>
    let scaleOfStillImageOrThree_dimensionalForm =
        Prefixed_Name(rdagr1, "scaleOfStillImageOrThree-dimensionalForm") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:verticalScaleCartographicContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Vertical scale of cartographic content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/verticalScaleCartographicContentExpression">http://rdvocab.info/Elements/verticalScaleCartographicContentExpression</seealso>
    let verticalScaleCartographicContentExpression =
        Prefixed_Name(rdagr1, "verticalScaleCartographicContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:scaleOfStillImageOrThreeDimensionalFormExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Scale of still image or three-dimensional form (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/scaleOfStillImageOrThreeDimensionalFormExpression">http://rdvocab.info/Elements/scaleOfStillImageOrThreeDimensionalFormExpression</seealso>
    let scaleOfStillImageOrThreeDimensionalFormExpression =
        Prefixed_Name(rdagr1, "scaleOfStillImageOrThreeDimensionalFormExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:RDASyntaxEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>RDA Syntax Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/RDASyntaxEncodingScheme">http://rdvocab.info/Elements/RDASyntaxEncodingScheme</seealso>
    let RDASyntaxEncodingScheme =
        Prefixed_Name(rdagr1, "RDASyntaxEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:ManufactureStatementEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Manufacture Statement Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/ManufactureStatementEncodingScheme">http://rdvocab.info/Elements/ManufactureStatementEncodingScheme</seealso>
    let ManufactureStatementEncodingScheme =
        Prefixed_Name(rdagr1, "ManufactureStatementEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:ProductionStatementEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Production Statement Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/ProductionStatementEncodingScheme">http://rdvocab.info/Elements/ProductionStatementEncodingScheme</seealso>
    let ProductionStatementEncodingScheme =
        Prefixed_Name(rdagr1, "ProductionStatementEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:PublicationStatementEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Publication Statement Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/PublicationStatementEncodingScheme">http://rdvocab.info/Elements/PublicationStatementEncodingScheme</seealso>
    let PublicationStatementEncodingScheme =
        Prefixed_Name(rdagr1, "PublicationStatementEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:emulsionOnMicrofilmAndMicrofiche</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Emulsion on microfilm and microfiche</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/emulsionOnMicrofilmAndMicrofiche">http://rdvocab.info/Elements/emulsionOnMicrofilmAndMicrofiche</seealso>
    let emulsionOnMicrofilmAndMicrofiche =
        Prefixed_Name(rdagr1, "emulsionOnMicrofilmAndMicrofiche") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:appliedMaterialManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Applied material (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/appliedMaterialManifestation">http://rdvocab.info/Elements/appliedMaterialManifestation</seealso>
    let appliedMaterialManifestation =
        Prefixed_Name(rdagr1, "appliedMaterialManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:fileType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>File type</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/fileType">http://rdvocab.info/Elements/fileType</seealso>
    let fileType = Prefixed_Name(rdagr1, "fileType") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Resolution</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/resolution">http://rdvocab.info/Elements/resolution</seealso>
    let resolution = Prefixed_Name(rdagr1, "resolution") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:transmissionSpeedManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Transmission speed (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/transmissionSpeedManifestation">http://rdvocab.info/Elements/transmissionSpeedManifestation</seealso>
    let transmissionSpeedManifestation =
        Prefixed_Name(rdagr1, "transmissionSpeedManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:fileTypeManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>File type (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/fileTypeManifestation">http://rdvocab.info/Elements/fileTypeManifestation</seealso>
    let fileTypeManifestation =
        Prefixed_Name(rdagr1, "fileTypeManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensions">http://rdvocab.info/Elements/dimensions</seealso>
    let dimensions = Prefixed_Name(rdagr1, "dimensions") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:dimensionsOfMapEtc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions of map, etc.</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsOfMapEtc">http://rdvocab.info/Elements/dimensionsOfMapEtc</seealso>
    let dimensionsOfMapEtc = Prefixed_Name(rdagr1, "dimensionsOfMapEtc") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensionsOfStillImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions of still image</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsOfStillImage">http://rdvocab.info/Elements/dimensionsOfStillImage</seealso>
    let dimensionsOfStillImage =
        Prefixed_Name(rdagr1, "dimensionsOfStillImage") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensionsOfMapEtcItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions of map, etc. (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsOfMapEtcItem">http://rdvocab.info/Elements/dimensionsOfMapEtcItem</seealso>
    let dimensionsOfMapEtcItem =
        Prefixed_Name(rdagr1, "dimensionsOfMapEtcItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensionsOfStillImageItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions of still image (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsOfStillImageItem">http://rdvocab.info/Elements/dimensionsOfStillImageItem</seealso>
    let dimensionsOfStillImageItem =
        Prefixed_Name(rdagr1, "dimensionsOfStillImageItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensionsOfStillImageManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions of still image (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsOfStillImageManifestation">http://rdvocab.info/Elements/dimensionsOfStillImageManifestation</seealso>
    let dimensionsOfStillImageManifestation =
        Prefixed_Name(rdagr1, "dimensionsOfStillImageManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dissertationOrThesisInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dissertation or thesis information</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dissertationOrThesisInformation">http://rdvocab.info/Elements/dissertationOrThesisInformation</seealso>
    let dissertationOrThesisInformation =
        Prefixed_Name(rdagr1, "dissertationOrThesisInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:distributionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Distribution statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/distributionStatement">http://rdvocab.info/Elements/distributionStatement</seealso>
    let distributionStatement =
        Prefixed_Name(rdagr1, "distributionStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:distributionStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Distribution statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/distributionStatementManifestation">http://rdvocab.info/Elements/distributionStatementManifestation</seealso>
    let distributionStatementManifestation =
        Prefixed_Name(rdagr1, "distributionStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:EditionStatementEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Edition Statement Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/EditionStatementEncodingScheme">http://rdvocab.info/Elements/EditionStatementEncodingScheme</seealso>
    let EditionStatementEncodingScheme =
        Prefixed_Name(rdagr1, "EditionStatementEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:PlaceAndDateOfCaptureEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Place And Date of Capture Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/PlaceAndDateOfCaptureEncodingScheme">http://rdvocab.info/Elements/PlaceAndDateOfCaptureEncodingScheme</seealso>
    let PlaceAndDateOfCaptureEncodingScheme =
        Prefixed_Name(rdagr1, "PlaceAndDateOfCaptureEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:SyntaxEncodingScheme</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/Elements/SyntaxEncodingScheme">http://rdvocab.info/Elements/SyntaxEncodingScheme</seealso>
    let SyntaxEncodingScheme =
        Prefixed_Name(rdagr1, "SyntaxEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Numeric and/or Alphabetic Designation of Last Issue or Part of Sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</seealso>
    let alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:designationOfANamedRevisionOfAnEditionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Designation of a named revision of an edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/designationOfANamedRevisionOfAnEditionManifestation">http://rdvocab.info/Elements/designationOfANamedRevisionOfAnEditionManifestation</seealso>
    let designationOfANamedRevisionOfAnEditionManifestation =
        Prefixed_Name(rdagr1, "designationOfANamedRevisionOfAnEditionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToTitleProperManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to title proper (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToTitleProperManifestation">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToTitleProperManifestation</seealso>
    let statementOfResponsibilityRelatingToTitleProperManifestation =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToTitleProperManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statusOfIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Status of identification</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statusOfIdentification">http://rdvocab.info/Elements/statusOfIdentification</seealso>
    let statusOfIdentification =
        Prefixed_Name(rdagr1, "statusOfIdentification") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:summarizationOfTheContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summarization of the content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/summarizationOfTheContent">http://rdvocab.info/Elements/summarizationOfTheContent</seealso>
    let summarizationOfTheContent =
        Prefixed_Name(rdagr1, "summarizationOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:summarizationOfTheContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summarization of the content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/summarizationOfTheContentExpression">http://rdvocab.info/Elements/summarizationOfTheContentExpression</seealso>
    let summarizationOfTheContentExpression =
        Prefixed_Name(rdagr1, "summarizationOfTheContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numberingOfSerialsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering of serials (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numberingOfSerialsManifestation">http://rdvocab.info/Elements/numberingOfSerialsManifestation</seealso>
    let numberingOfSerialsManifestation =
        Prefixed_Name(rdagr1, "numberingOfSerialsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Chronological Designation of Last Issue or Part of Sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation</seealso>
    let alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Numeric and/or Alphabetic Designation of First Issue or Part of Sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence">http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</seealso>
    let alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfCaptureExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of capture (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfCaptureExpression">http://rdvocab.info/Elements/dateOfCaptureExpression</seealso>
    let dateOfCaptureExpression =
        Prefixed_Name(rdagr1, "dateOfCaptureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfProductionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of production (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfProductionManifestation">http://rdvocab.info/Elements/dateOfProductionManifestation</seealso>
    let dateOfProductionManifestation =
        Prefixed_Name(rdagr1, "dateOfProductionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfPublicationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of publication (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfPublicationManifestation">http://rdvocab.info/Elements/dateOfPublicationManifestation</seealso>
    let dateOfPublicationManifestation =
        Prefixed_Name(rdagr1, "dateOfPublicationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:designationOfANamedRevisionOfAnEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Designation of a named revision of an edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/designationOfANamedRevisionOfAnEdition">http://rdvocab.info/Elements/designationOfANamedRevisionOfAnEdition</seealso>
    let designationOfANamedRevisionOfAnEdition =
        Prefixed_Name(rdagr1, "designationOfANamedRevisionOfAnEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:designationOfEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Designation of edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/designationOfEdition">http://rdvocab.info/Elements/designationOfEdition</seealso>
    let designationOfEdition =
        Prefixed_Name(rdagr1, "designationOfEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:designationOfEditionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Designation of edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/designationOfEditionManifestation">http://rdvocab.info/Elements/designationOfEditionManifestation</seealso>
    let designationOfEditionManifestation =
        Prefixed_Name(rdagr1, "designationOfEditionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:digitalFileCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital file characteristic</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/digitalFileCharacteristic">http://rdvocab.info/Elements/digitalFileCharacteristic</seealso>
    let digitalFileCharacteristic =
        Prefixed_Name(rdagr1, "digitalFileCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:digitalRepresentationOfCartographicContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital representation of cartographic content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/digitalRepresentationOfCartographicContent">http://rdvocab.info/Elements/digitalRepresentationOfCartographicContent</seealso>
    let digitalRepresentationOfCartographicContent =
        Prefixed_Name(rdagr1, "digitalRepresentationOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:encodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Encoding format</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/encodingFormat">http://rdvocab.info/Elements/encodingFormat</seealso>
    let encodingFormat = Prefixed_Name(rdagr1, "encodingFormat") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:transmissionSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Transmission speed</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/transmissionSpeed">http://rdvocab.info/Elements/transmissionSpeed</seealso>
    let transmissionSpeed = Prefixed_Name(rdagr1, "transmissionSpeed") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:digitalFileCharacteristicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital file characteristic (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/digitalFileCharacteristicManifestation">http://rdvocab.info/Elements/digitalFileCharacteristicManifestation</seealso>
    let digitalFileCharacteristicManifestation =
        Prefixed_Name(rdagr1, "digitalFileCharacteristicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:fileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>File size</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/fileSize">http://rdvocab.info/Elements/fileSize</seealso>
    let fileSize = Prefixed_Name(rdagr1, "fileSize") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:encodingFormatManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Encoding format (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/encodingFormatManifestation">http://rdvocab.info/Elements/encodingFormatManifestation</seealso>
    let encodingFormatManifestation =
        Prefixed_Name(rdagr1, "encodingFormatManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:resolutionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Resolution (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/resolutionManifestation">http://rdvocab.info/Elements/resolutionManifestation</seealso>
    let resolutionManifestation =
        Prefixed_Name(rdagr1, "resolutionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:regionalEncodingManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Regional encoding (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/regionalEncodingManifestation">http://rdvocab.info/Elements/regionalEncodingManifestation</seealso>
    let regionalEncodingManifestation =
        Prefixed_Name(rdagr1, "regionalEncodingManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:digitalRepresentationOfCartographicContentManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital representation of cartographic content (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/digitalRepresentationOfCartographicContentManifestation">http://rdvocab.info/Elements/digitalRepresentationOfCartographicContentManifestation</seealso>
    let digitalRepresentationOfCartographicContentManifestation =
        Prefixed_Name(rdagr1, "digitalRepresentationOfCartographicContentManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layoutOfCartographicImages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Layout of cartographic images</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layoutOfCartographicImages">http://rdvocab.info/Elements/layoutOfCartographicImages</seealso>
    let layoutOfCartographicImages =
        Prefixed_Name(rdagr1, "layoutOfCartographicImages") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layoutOfTactileTextManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Layout of tactile text (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layoutOfTactileTextManifestation">http://rdvocab.info/Elements/layoutOfTactileTextManifestation</seealso>
    let layoutOfTactileTextManifestation =
        Prefixed_Name(rdagr1, "layoutOfTactileTextManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layoutOfCartographicImagesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Layout of cartographic images (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layoutOfCartographicImagesManifestation">http://rdvocab.info/Elements/layoutOfCartographicImagesManifestation</seealso>
    let layoutOfCartographicImagesManifestation =
        Prefixed_Name(rdagr1, "layoutOfCartographicImagesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfManufactureManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of manufacture (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfManufactureManifestation">http://rdvocab.info/Elements/parallelPlaceOfManufactureManifestation</seealso>
    let parallelPlaceOfManufactureManifestation =
        Prefixed_Name(rdagr1, "parallelPlaceOfManufactureManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of production</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfProduction">http://rdvocab.info/Elements/parallelPlaceOfProduction</seealso>
    let parallelPlaceOfProduction =
        Prefixed_Name(rdagr1, "parallelPlaceOfProduction") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:signatoryToATreatyEtc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Signatory to a treaty, etc.</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/signatoryToATreatyEtc">http://rdvocab.info/Elements/signatoryToATreatyEtc</seealso>
    let signatoryToATreatyEtc =
        Prefixed_Name(rdagr1, "signatoryToATreatyEtc") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:signatoryToATreatyEtcWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Signatory to a treaty, etc. (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/signatoryToATreatyEtcWork">http://rdvocab.info/Elements/signatoryToATreatyEtcWork</seealso>
    let signatoryToATreatyEtcWork =
        Prefixed_Name(rdagr1, "signatoryToATreatyEtcWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:tapeConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Tape configuration</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/tapeConfiguration">http://rdvocab.info/Elements/tapeConfiguration</seealso>
    let tapeConfiguration = Prefixed_Name(rdagr1, "tapeConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:typeOfRecordingAnalogDigital</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Type of recording</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/typeOfRecordingAnalogDigital">http://rdvocab.info/Elements/typeOfRecordingAnalogDigital</seealso>
    let typeOfRecordingAnalogDigital =
        Prefixed_Name(rdagr1, "typeOfRecordingAnalogDigital") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:trackConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Track configuration</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/trackConfiguration">http://rdvocab.info/Elements/trackConfiguration</seealso>
    let trackConfiguration = Prefixed_Name(rdagr1, "trackConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:tapeConfigurationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Tape configuration (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/tapeConfigurationManifestation">http://rdvocab.info/Elements/tapeConfigurationManifestation</seealso>
    let tapeConfigurationManifestation =
        Prefixed_Name(rdagr1, "tapeConfigurationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:specialPlaybackCharacteristicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Special playback characteristic (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/specialPlaybackCharacteristicManifestation">http://rdvocab.info/Elements/specialPlaybackCharacteristicManifestation</seealso>
    let specialPlaybackCharacteristicManifestation =
        Prefixed_Name(rdagr1, "specialPlaybackCharacteristicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:typeOfRecordingManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Type of recording (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/typeOfRecordingManifestation">http://rdvocab.info/Elements/typeOfRecordingManifestation</seealso>
    let typeOfRecordingManifestation =
        Prefixed_Name(rdagr1, "typeOfRecordingManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:coverageOfTheContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Coverage of the content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/coverageOfTheContent">http://rdvocab.info/Elements/coverageOfTheContent</seealso>
    let coverageOfTheContent =
        Prefixed_Name(rdagr1, "coverageOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnExtentOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on extent of manifestation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnExtentOfManifestation">http://rdvocab.info/Elements/noteOnExtentOfManifestation</seealso>
    let noteOnExtentOfManifestation =
        Prefixed_Name(rdagr1, "noteOnExtentOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:RepresentationOfCartographicImagesClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Representation of Cartographic Images Class</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/RepresentationOfCartographicImagesClass">http://rdvocab.info/Elements/RepresentationOfCartographicImagesClass</seealso>
    let RepresentationOfCartographicImagesClass =
        Prefixed_Name(rdagr1, "RepresentationOfCartographicImagesClass") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:StatementOfResponsibilityRelatingToEditionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to the edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/StatementOfResponsibilityRelatingToEditionManifestation">http://rdvocab.info/Elements/StatementOfResponsibilityRelatingToEditionManifestation</seealso>
    let StatementOfResponsibilityRelatingToEditionManifestation =
        Prefixed_Name(rdagr1, "StatementOfResponsibilityRelatingToEditionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:bookFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Book format</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/bookFormat">http://rdvocab.info/Elements/bookFormat</seealso>
    let bookFormat = Prefixed_Name(rdagr1, "bookFormat") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:bookFormatManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Book format (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/bookFormatManifestation">http://rdvocab.info/Elements/bookFormatManifestation</seealso>
    let bookFormatManifestation =
        Prefixed_Name(rdagr1, "bookFormatManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:distributorsName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Distributor's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/distributorsName">http://rdvocab.info/Elements/distributorsName</seealso>
    let distributorsName = Prefixed_Name(rdagr1, "distributorsName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:distributorsNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Distributor's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/distributorsNameManifestation">http://rdvocab.info/Elements/distributorsNameManifestation</seealso>
    let distributorsNameManifestation =
        Prefixed_Name(rdagr1, "distributorsNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:identifierForTheExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier for the expression</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/identifierForTheExpression">http://rdvocab.info/Elements/identifierForTheExpression</seealso>
    let identifierForTheExpression =
        Prefixed_Name(rdagr1, "identifierForTheExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:identifierForTheManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier for the manifestation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/identifierForTheManifestation">http://rdvocab.info/Elements/identifierForTheManifestation</seealso>
    let identifierForTheManifestation =
        Prefixed_Name(rdagr1, "identifierForTheManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:plateNumberForMusicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Plate number for music (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/plateNumberForMusicManifestation">http://rdvocab.info/Elements/plateNumberForMusicManifestation</seealso>
    let plateNumberForMusicManifestation =
        Prefixed_Name(rdagr1, "plateNumberForMusicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:publishersNumberForMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>See also Plate number for music.</para>
    /// labels<para>Publisher's number for music</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/publishersNumberForMusic">http://rdvocab.info/Elements/publishersNumberForMusic</seealso>
    let publishersNumberForMusic =
        Prefixed_Name(rdagr1, "publishersNumberForMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:illustrativeContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrative content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/illustrativeContentExpression">http://rdvocab.info/Elements/illustrativeContentExpression</seealso>
    let illustrativeContentExpression =
        Prefixed_Name(rdagr1, "illustrativeContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherTitleInformationOfSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other title information of subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherTitleInformationOfSubseries">http://rdvocab.info/Elements/otherTitleInformationOfSubseries</seealso>
    let otherTitleInformationOfSubseries =
        Prefixed_Name(rdagr1, "otherTitleInformationOfSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherTitleInformationOfSubseriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other title information of subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherTitleInformationOfSubseriesManifestation">http://rdvocab.info/Elements/otherTitleInformationOfSubseriesManifestation</seealso>
    let otherTitleInformationOfSubseriesManifestation =
        Prefixed_Name(rdagr1, "otherTitleInformationOfSubseriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelDesignationOfANamedRevisionOfAnEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel designation of a named revision of an edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelDesignationOfANamedRevisionOfAnEdition">http://rdvocab.info/Elements/parallelDesignationOfANamedRevisionOfAnEdition</seealso>
    let parallelDesignationOfANamedRevisionOfAnEdition =
        Prefixed_Name(rdagr1, "parallelDesignationOfANamedRevisionOfAnEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelDesignationOfANamedRevisionOfAnEditionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel designation of a named revision of an edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelDesignationOfANamedRevisionOfAnEditionManifestation">http://rdvocab.info/Elements/parallelDesignationOfANamedRevisionOfAnEditionManifestation</seealso>
    let parallelDesignationOfANamedRevisionOfAnEditionManifestation =
        Prefixed_Name(rdagr1, "parallelDesignationOfANamedRevisionOfAnEditionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:reductionRatioManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reduction ration (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/reductionRatioManifestation">http://rdvocab.info/Elements/reductionRatioManifestation</seealso>
    let reductionRatioManifestation =
        Prefixed_Name(rdagr1, "reductionRatioManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:regionalEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Regional encoding</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/regionalEncoding">http://rdvocab.info/Elements/regionalEncoding</seealso>
    let regionalEncoding = Prefixed_Name(rdagr1, "regionalEncoding") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:SeriesStatementEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Series Statement Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/SeriesStatementEncodingScheme">http://rdvocab.info/Elements/SeriesStatementEncodingScheme</seealso>
    let SeriesStatementEncodingScheme =
        Prefixed_Name(rdagr1, "SeriesStatementEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:artisticAndOrTechnicalCreditExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Artistic and/or technical credit (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/artisticAndOrTechnicalCreditExpression">http://rdvocab.info/Elements/artisticAndOrTechnicalCreditExpression</seealso>
    let artisticAndOrTechnicalCreditExpression =
        Prefixed_Name(rdagr1, "artisticAndOrTechnicalCreditExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:fileSizeManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>File size (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/fileSizeManifestation">http://rdvocab.info/Elements/fileSizeManifestation</seealso>
    let fileSizeManifestation =
        Prefixed_Name(rdagr1, "fileSizeManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/frequency">http://rdvocab.info/Elements/frequency</seealso>
    let frequency = Prefixed_Name(rdagr1, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:generation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generation">http://rdvocab.info/Elements/generation</seealso>
    let generation = Prefixed_Name(rdagr1, "generation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfAudioRecording</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of audio recording</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfAudioRecording">http://rdvocab.info/Elements/generationOfAudioRecording</seealso>
    let generationOfAudioRecording =
        Prefixed_Name(rdagr1, "generationOfAudioRecording") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfMotionPictureFilm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of motion picture film</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfMotionPictureFilm">http://rdvocab.info/Elements/generationOfMotionPictureFilm</seealso>
    let generationOfMotionPictureFilm =
        Prefixed_Name(rdagr1, "generationOfMotionPictureFilm") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfVideotapeManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of videotape (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfVideotapeManifestation">http://rdvocab.info/Elements/generationOfVideotapeManifestation</seealso>
    let generationOfVideotapeManifestation =
        Prefixed_Name(rdagr1, "generationOfVideotapeManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfAudioRecordingManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of audio recording (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfAudioRecordingManifestation">http://rdvocab.info/Elements/generationOfAudioRecordingManifestation</seealso>
    let generationOfAudioRecordingManifestation =
        Prefixed_Name(rdagr1, "generationOfAudioRecordingManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfMotionPictureFilmManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of motion picture film (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfMotionPictureFilmManifestation">http://rdvocab.info/Elements/generationOfMotionPictureFilmManifestation</seealso>
    let generationOfMotionPictureFilmManifestation =
        Prefixed_Name(rdagr1, "generationOfMotionPictureFilmManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfMicroformManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of microform (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfMicroformManifestation">http://rdvocab.info/Elements/generationOfMicroformManifestation</seealso>
    let generationOfMicroformManifestation =
        Prefixed_Name(rdagr1, "generationOfMicroformManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:artisticAndOrTechnicalCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Artistic and/or technical credit</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/artisticAndOrTechnicalCredit">http://rdvocab.info/Elements/artisticAndOrTechnicalCredit</seealso>
    let artisticAndOrTechnicalCredit =
        Prefixed_Name(rdagr1, "artisticAndOrTechnicalCredit") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:aspectRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Aspect ratio</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/aspectRatio">http://rdvocab.info/Elements/aspectRatio</seealso>
    let aspectRatio = Prefixed_Name(rdagr1, "aspectRatio") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:aspectRatioExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Aspect ratio (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/aspectRatioExpression">http://rdvocab.info/Elements/aspectRatioExpression</seealso>
    let aspectRatioExpression =
        Prefixed_Name(rdagr1, "aspectRatioExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensionsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsManifestation">http://rdvocab.info/Elements/dimensionsManifestation</seealso>
    let dimensionsManifestation =
        Prefixed_Name(rdagr1, "dimensionsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensionsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsItem">http://rdvocab.info/Elements/dimensionsItem</seealso>
    let dimensionsItem = Prefixed_Name(rdagr1, "dimensionsItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dimensionsOfMapEtcManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dimensions of map, etc. (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dimensionsOfMapEtcManifestation">http://rdvocab.info/Elements/dimensionsOfMapEtcManifestation</seealso>
    let dimensionsOfMapEtcManifestation =
        Prefixed_Name(rdagr1, "dimensionsOfMapEtcManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:award</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Award</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/award">http://rdvocab.info/Elements/award</seealso>
    let award = Prefixed_Name(rdagr1, "award") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:awardExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Award (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/awardExpression">http://rdvocab.info/Elements/awardExpression</seealso>
    let awardExpression = Prefixed_Name(rdagr1, "awardExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:baseMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Base material</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/baseMaterial">http://rdvocab.info/Elements/baseMaterial</seealso>
    let baseMaterial = Prefixed_Name(rdagr1, "baseMaterial") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Base material for microfilm, microfiche, photographic film, and motion picture film</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm">http://rdvocab.info/Elements/baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm</seealso>
    let baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm =
        Prefixed_Name(rdagr1, "baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:baseMaterialManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Base material (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/baseMaterialManifestation">http://rdvocab.info/Elements/baseMaterialManifestation</seealso>
    let baseMaterialManifestation =
        Prefixed_Name(rdagr1, "baseMaterialManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Base material for microfilm, microfiche, photographic film, and motion picture film (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation">http://rdvocab.info/Elements/baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation</seealso>
    let baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation =
        Prefixed_Name(rdagr1, "baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherDetailsOfCartographicContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other details of cartographic content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherDetailsOfCartographicContent">http://rdvocab.info/Elements/otherDetailsOfCartographicContent</seealso>
    let otherDetailsOfCartographicContent =
        Prefixed_Name(rdagr1, "otherDetailsOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherDistinguishingCharacteristicOfTheExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other distinguishing characteristic of the expression</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherDistinguishingCharacteristicOfTheExpression">http://rdvocab.info/Elements/otherDistinguishingCharacteristicOfTheExpression</seealso>
    let otherDistinguishingCharacteristicOfTheExpression =
        Prefixed_Name(rdagr1, "otherDistinguishingCharacteristicOfTheExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherTitleInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other title information</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherTitleInformation">http://rdvocab.info/Elements/otherTitleInformation</seealso>
    let otherTitleInformation =
        Prefixed_Name(rdagr1, "otherTitleInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherTitleInformationOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other title information of series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherTitleInformationOfSeries">http://rdvocab.info/Elements/otherTitleInformationOfSeries</seealso>
    let otherTitleInformationOfSeries =
        Prefixed_Name(rdagr1, "otherTitleInformationOfSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:otherTitleInformationOfSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other title information of series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/otherTitleInformationOfSeriesManifestation">http://rdvocab.info/Elements/otherTitleInformationOfSeriesManifestation</seealso>
    let otherTitleInformationOfSeriesManifestation =
        Prefixed_Name(rdagr1, "otherTitleInformationOfSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfVideotape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of videotape</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfVideotape">http://rdvocab.info/Elements/generationOfVideotape</seealso>
    let generationOfVideotape =
        Prefixed_Name(rdagr1, "generationOfVideotape") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:generationOfDigitalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Generation of digital resource</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/generationOfDigitalResource">http://rdvocab.info/Elements/generationOfDigitalResource</seealso>
    let generationOfDigitalResource =
        Prefixed_Name(rdagr1, "generationOfDigitalResource") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numberingWithinSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering within series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numberingWithinSeriesManifestation">http://rdvocab.info/Elements/numberingWithinSeriesManifestation</seealso>
    let numberingWithinSeriesManifestation =
        Prefixed_Name(rdagr1, "numberingWithinSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numberingWithinSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering within subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numberingWithinSubseries">http://rdvocab.info/Elements/numberingWithinSubseries</seealso>
    let numberingWithinSubseries =
        Prefixed_Name(rdagr1, "numberingWithinSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numberingWithinSubseriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering within subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numberingWithinSubseriesManifestation">http://rdvocab.info/Elements/numberingWithinSubseriesManifestation</seealso>
    let numberingWithinSubseriesManifestation =
        Prefixed_Name(rdagr1, "numberingWithinSubseriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numericDesignationOfAMusicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numeric designation of a musical work </para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numericDesignationOfAMusicalWork">http://rdvocab.info/Elements/numericDesignationOfAMusicalWork</seealso>
    let numericDesignationOfAMusicalWork =
        Prefixed_Name(rdagr1, "numericDesignationOfAMusicalWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:projectionCharacteristicOfMotionPictureFilmManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Projection characteristic of motion picture film (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/projectionCharacteristicOfMotionPictureFilmManifestation">http://rdvocab.info/Elements/projectionCharacteristicOfMotionPictureFilmManifestation</seealso>
    let projectionCharacteristicOfMotionPictureFilmManifestation =
        Prefixed_Name(rdagr1, "projectionCharacteristicOfMotionPictureFilmManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:producersName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Producer's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/producersName">http://rdvocab.info/Elements/producersName</seealso>
    let producersName = Prefixed_Name(rdagr1, "producersName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:producersNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Producer's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/producersNameManifestation">http://rdvocab.info/Elements/producersNameManifestation</seealso>
    let producersNameManifestation =
        Prefixed_Name(rdagr1, "producersNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionMethodForTactileResourceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production method for tactile resource (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionMethodForTactileResourceManifestation">http://rdvocab.info/Elements/productionMethodForTactileResourceManifestation</seealso>
    let productionMethodForTactileResourceManifestation =
        Prefixed_Name(rdagr1, "productionMethodForTactileResourceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:abbreviatedTitleManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abbreviated title (Manifestatiion)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/abbreviatedTitleManifestation">http://rdvocab.info/Elements/abbreviatedTitleManifestation</seealso>
    let abbreviatedTitleManifestation =
        Prefixed_Name(rdagr1, "abbreviatedTitleManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:broadcastStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Broadcast standard</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/broadcastStandard">http://rdvocab.info/Elements/broadcastStandard</seealso>
    let broadcastStandard = Prefixed_Name(rdagr1, "broadcastStandard") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:broadcastStandardManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Broadcast standard (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/broadcastStandardManifestation">http://rdvocab.info/Elements/broadcastStandardManifestation</seealso>
    let broadcastStandardManifestation =
        Prefixed_Name(rdagr1, "broadcastStandardManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:videoCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video characteristic</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/videoCharacteristic">http://rdvocab.info/Elements/videoCharacteristic</seealso>
    let videoCharacteristic =
        Prefixed_Name(rdagr1, "videoCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:videoCharacteristicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video characteristic (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/videoCharacteristicManifestation">http://rdvocab.info/Elements/videoCharacteristicManifestation</seealso>
    let videoCharacteristicManifestation =
        Prefixed_Name(rdagr1, "videoCharacteristicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:carrierTypeManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Carrier type (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/carrierTypeManifestation">http://rdvocab.info/Elements/carrierTypeManifestation</seealso>
    let carrierTypeManifestation =
        Prefixed_Name(rdagr1, "carrierTypeManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:cataloguersNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cataloguer's note</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/cataloguersNote">http://rdvocab.info/Elements/cataloguersNote</seealso>
    let cataloguersNote = Prefixed_Name(rdagr1, "cataloguersNote") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:chronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Chronological designation of first issue or part of sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/chronologicalDesignationOfFirstIssueOrPartOfSequence">http://rdvocab.info/Elements/chronologicalDesignationOfFirstIssueOrPartOfSequence</seealso>
    let chronologicalDesignationOfFirstIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "chronologicalDesignationOfFirstIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:chronologicalDesignationOfLastIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Chronological designation of last issue or part of sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/chronologicalDesignationOfLastIssueOrPartOfSequence">http://rdvocab.info/Elements/chronologicalDesignationOfLastIssueOrPartOfSequence</seealso>
    let chronologicalDesignationOfLastIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "chronologicalDesignationOfLastIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Chronological designation of last issue or part of sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation</seealso>
    let chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourContent">http://rdvocab.info/Elements/colourContent</seealso>
    let colourContent = Prefixed_Name(rdagr1, "colourContent") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:colourOfStillImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour of still image</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourOfStillImage">http://rdvocab.info/Elements/colourOfStillImage</seealso>
    let colourOfStillImage = Prefixed_Name(rdagr1, "colourOfStillImage") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourOfThree-dimensionalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour of three-dimensional form</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourOfThree-dimensionalForm">http://rdvocab.info/Elements/colourOfThree-dimensionalForm</seealso>
    let colourOfThree_dimensionalForm =
        Prefixed_Name(rdagr1, "colourOfThree-dimensionalForm") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourOfMovingImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour of moving images</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourOfMovingImage">http://rdvocab.info/Elements/colourOfMovingImage</seealso>
    let colourOfMovingImage =
        Prefixed_Name(rdagr1, "colourOfMovingImage") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourOfMovingImagesExpressions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour of moving images (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourOfMovingImagesExpressions">http://rdvocab.info/Elements/colourOfMovingImagesExpressions</seealso>
    let colourOfMovingImagesExpressions =
        Prefixed_Name(rdagr1, "colourOfMovingImagesExpressions") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour content of resource designed for persons with visual impairments (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression">http://rdvocab.info/Elements/colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression</seealso>
    let colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression =
        Prefixed_Name(rdagr1, "colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourOfThree-dimensionalFormExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour of three-dimensional form (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourOfThree-dimensionalFormExpression">http://rdvocab.info/Elements/colourOfThree-dimensionalFormExpression</seealso>
    let colourOfThree_dimensionalFormExpression =
        Prefixed_Name(rdagr1, "colourOfThree-dimensionalFormExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourOfStillImageExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour of still image (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourOfStillImageExpression">http://rdvocab.info/Elements/colourOfStillImageExpression</seealso>
    let colourOfStillImageExpression =
        Prefixed_Name(rdagr1, "colourOfStillImageExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of text</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfText">http://rdvocab.info/Elements/extentOfText</seealso>
    let extentOfText = Prefixed_Name(rdagr1, "extentOfText") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentManifestation">http://rdvocab.info/Elements/extentManifestation</seealso>
    let extentManifestation =
        Prefixed_Name(rdagr1, "extentManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfNotatedMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of notated music</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfNotatedMusic">http://rdvocab.info/Elements/extentOfNotatedMusic</seealso>
    let extentOfNotatedMusic =
        Prefixed_Name(rdagr1, "extentOfNotatedMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfThreeDimensionalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of three-dimensional form</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfThreeDimensionalForm">http://rdvocab.info/Elements/extentOfThreeDimensionalForm</seealso>
    let extentOfThreeDimensionalForm =
        Prefixed_Name(rdagr1, "extentOfThreeDimensionalForm") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfTextItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of text (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfTextItem">http://rdvocab.info/Elements/extentOfTextItem</seealso>
    let extentOfTextItem = Prefixed_Name(rdagr1, "extentOfTextItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfCartographicResourceItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of cartographic resource (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfCartographicResourceItem">http://rdvocab.info/Elements/extentOfCartographicResourceItem</seealso>
    let extentOfCartographicResourceItem =
        Prefixed_Name(rdagr1, "extentOfCartographicResourceItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfStillImageItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of still image (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfStillImageItem">http://rdvocab.info/Elements/extentOfStillImageItem</seealso>
    let extentOfStillImageItem =
        Prefixed_Name(rdagr1, "extentOfStillImageItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfThreeDimensionalFormItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of three-dimensional form (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfThreeDimensionalFormItem">http://rdvocab.info/Elements/extentOfThreeDimensionalFormItem</seealso>
    let extentOfThreeDimensionalFormItem =
        Prefixed_Name(rdagr1, "extentOfThreeDimensionalFormItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelProducersName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel producer's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelProducersName">http://rdvocab.info/Elements/parallelProducersName</seealso>
    let parallelProducersName =
        Prefixed_Name(rdagr1, "parallelProducersName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelProducersNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel producer's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelProducersNameManifestation">http://rdvocab.info/Elements/parallelProducersNameManifestation</seealso>
    let parallelProducersNameManifestation =
        Prefixed_Name(rdagr1, "parallelProducersNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to a named revision of an edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition</seealso>
    let parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to a named revision of an edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation</seealso>
    let parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSeries">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSeries</seealso>
    let parallelStatementOfResponsibilityRelatingToSeries =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSeriesManifestation">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSeriesManifestation</seealso>
    let parallelStatementOfResponsibilityRelatingToSeriesManifestation =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:seriesStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Series statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/seriesStatement">http://rdvocab.info/Elements/seriesStatement</seealso>
    let seriesStatement = Prefixed_Name(rdagr1, "seriesStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:seriesStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Series statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/seriesStatementManifestation">http://rdvocab.info/Elements/seriesStatementManifestation</seealso>
    let seriesStatementManifestation =
        Prefixed_Name(rdagr1, "seriesStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToTheEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to the edition</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTheEdition">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTheEdition</seealso>
    let parallelStatementOfResponsibilityRelatingToTheEdition =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToTheEdition") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibility">http://rdvocab.info/Elements/statementOfResponsibility</seealso>
    let statementOfResponsibility =
        Prefixed_Name(rdagr1, "statementOfResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityManifestation">http://rdvocab.info/Elements/statementOfResponsibilityManifestation</seealso>
    let statementOfResponsibilityManifestation =
        Prefixed_Name(rdagr1, "statementOfResponsibilityManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelTitleProper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel title proper</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelTitleProper">http://rdvocab.info/Elements/parallelTitleProper</seealso>
    let parallelTitleProper =
        Prefixed_Name(rdagr1, "parallelTitleProper") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelTitleProperOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel title proper of series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelTitleProperOfSeries">http://rdvocab.info/Elements/parallelTitleProperOfSeries</seealso>
    let parallelTitleProperOfSeries =
        Prefixed_Name(rdagr1, "parallelTitleProperOfSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelTitleProperOfSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel title proper of series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelTitleProperOfSeriesManifestation">http://rdvocab.info/Elements/parallelTitleProperOfSeriesManifestation</seealso>
    let parallelTitleProperOfSeriesManifestation =
        Prefixed_Name(rdagr1, "parallelTitleProperOfSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelTitleProperOfSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel title proper of subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelTitleProperOfSubseries">http://rdvocab.info/Elements/parallelTitleProperOfSubseries</seealso>
    let parallelTitleProperOfSubseries =
        Prefixed_Name(rdagr1, "parallelTitleProperOfSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelTitleProperOfSubseriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel title proper of subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelTitleProperOfSubseriesManifestation">http://rdvocab.info/Elements/parallelTitleProperOfSubseriesManifestation</seealso>
    let parallelTitleProperOfSubseriesManifestation =
        Prefixed_Name(rdagr1, "parallelTitleProperOfSubseriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:performerNarratorAndOrPresenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Performer, narrator, and/or presenter</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/performerNarratorAndOrPresenter">http://rdvocab.info/Elements/performerNarratorAndOrPresenter</seealso>
    let performerNarratorAndOrPresenter =
        Prefixed_Name(rdagr1, "performerNarratorAndOrPresenter") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:performerNarratorAndOrPresenterExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Performer, narrator, and/or presenter (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/performerNarratorAndOrPresenterExpression">http://rdvocab.info/Elements/performerNarratorAndOrPresenterExpression</seealso>
    let performerNarratorAndOrPresenterExpression =
        Prefixed_Name(rdagr1, "performerNarratorAndOrPresenterExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeAndDateOfCapture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place and date of capture</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeAndDateOfCapture">http://rdvocab.info/Elements/placeAndDateOfCapture</seealso>
    let placeAndDateOfCapture =
        Prefixed_Name(rdagr1, "placeAndDateOfCapture") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfCapture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of capture</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfCapture">http://rdvocab.info/Elements/placeOfCapture</seealso>
    let placeOfCapture = Prefixed_Name(rdagr1, "placeOfCapture") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfCaptureExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of capture (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfCaptureExpression">http://rdvocab.info/Elements/placeOfCaptureExpression</seealso>
    let placeOfCaptureExpression =
        Prefixed_Name(rdagr1, "placeOfCaptureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of distribution</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfDistribution">http://rdvocab.info/Elements/placeOfDistribution</seealso>
    let placeOfDistribution =
        Prefixed_Name(rdagr1, "placeOfDistribution") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfDistributionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of distribution (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfDistributionManifestation">http://rdvocab.info/Elements/placeOfDistributionManifestation</seealso>
    let placeOfDistributionManifestation =
        Prefixed_Name(rdagr1, "placeOfDistributionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfManufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of manufacture</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfManufacture">http://rdvocab.info/Elements/placeOfManufacture</seealso>
    let placeOfManufacture = Prefixed_Name(rdagr1, "placeOfManufacture") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfManufactureManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of manufacture (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfManufactureManifestation">http://rdvocab.info/Elements/placeOfManufactureManifestation</seealso>
    let placeOfManufactureManifestation =
        Prefixed_Name(rdagr1, "placeOfManufactureManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfOriginOfTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of origin of the work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfOriginOfTheWork">http://rdvocab.info/Elements/placeOfOriginOfTheWork</seealso>
    let placeOfOriginOfTheWork =
        Prefixed_Name(rdagr1, "placeOfOriginOfTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of production</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfProduction">http://rdvocab.info/Elements/placeOfProduction</seealso>
    let placeOfProduction = Prefixed_Name(rdagr1, "placeOfProduction") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfProductionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of production (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfProductionManifestation">http://rdvocab.info/Elements/placeOfProductionManifestation</seealso>
    let placeOfProductionManifestation =
        Prefixed_Name(rdagr1, "placeOfProductionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:playingSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Playing speed</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/playingSpeed">http://rdvocab.info/Elements/playingSpeed</seealso>
    let playingSpeed = Prefixed_Name(rdagr1, "playingSpeed") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:playingSpeedManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Playing speed (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/playingSpeedManifestation">http://rdvocab.info/Elements/playingSpeedManifestation</seealso>
    let playingSpeedManifestation =
        Prefixed_Name(rdagr1, "playingSpeedManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:polarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Associated with the FRBR Manifestation entity.</para>
    /// labels<para>Polarity</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/polarity">http://rdvocab.info/Elements/polarity</seealso>
    let polarity = Prefixed_Name(rdagr1, "polarity") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:polarityManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Polarity (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/polarityManifestation">http://rdvocab.info/Elements/polarityManifestation</seealso>
    let polarityManifestation =
        Prefixed_Name(rdagr1, "polarityManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:preferredCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred citation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/preferredCitation">http://rdvocab.info/Elements/preferredCitation</seealso>
    let preferredCitation = Prefixed_Name(rdagr1, "preferredCitation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:preferredCitationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred citation (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/preferredCitationManifestation">http://rdvocab.info/Elements/preferredCitationManifestation</seealso>
    let preferredCitationManifestation =
        Prefixed_Name(rdagr1, "preferredCitationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:preferredCitationItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred citation (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/preferredCitationItem">http://rdvocab.info/Elements/preferredCitationItem</seealso>
    let preferredCitationItem =
        Prefixed_Name(rdagr1, "preferredCitationItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:preferredTitleForTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred title for the work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/preferredTitleForTheWork">http://rdvocab.info/Elements/preferredTitleForTheWork</seealso>
    let preferredTitleForTheWork =
        Prefixed_Name(rdagr1, "preferredTitleForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleOfTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title of the work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleOfTheWork">http://rdvocab.info/Elements/titleOfTheWork</seealso>
    let titleOfTheWork = Prefixed_Name(rdagr1, "titleOfTheWork") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:presentationFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Presentation format</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/presentationFormat">http://rdvocab.info/Elements/presentationFormat</seealso>
    let presentationFormat = Prefixed_Name(rdagr1, "presentationFormat") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:presentationFormatManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Presentation format (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/presentationFormatManifestation">http://rdvocab.info/Elements/presentationFormatManifestation</seealso>
    let presentationFormatManifestation =
        Prefixed_Name(rdagr1, "presentationFormatManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:projectionCharacteristicOfMotionPictureFilm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Projection characteristic of motion picture film</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/projectionCharacteristicOfMotionPictureFilm">http://rdvocab.info/Elements/projectionCharacteristicOfMotionPictureFilm</seealso>
    let projectionCharacteristicOfMotionPictureFilm =
        Prefixed_Name(rdagr1, "projectionCharacteristicOfMotionPictureFilm") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production method</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionMethod">http://rdvocab.info/Elements/productionMethod</seealso>
    let productionMethod = Prefixed_Name(rdagr1, "productionMethod") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionMethodManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production method (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionMethodManifestation">http://rdvocab.info/Elements/productionMethodManifestation</seealso>
    let productionMethodManifestation =
        Prefixed_Name(rdagr1, "productionMethodManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionMethodForManuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production method for manuscript</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionMethodForManuscript">http://rdvocab.info/Elements/productionMethodForManuscript</seealso>
    let productionMethodForManuscript =
        Prefixed_Name(rdagr1, "productionMethodForManuscript") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionMethodForTactileResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production method for tactile resource</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionMethodForTactileResource">http://rdvocab.info/Elements/productionMethodForTactileResource</seealso>
    let productionMethodForTactileResource =
        Prefixed_Name(rdagr1, "productionMethodForTactileResource") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionMethodForManuscriptManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production method for manuscript (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionMethodForManuscriptManifestation">http://rdvocab.info/Elements/productionMethodForManuscriptManifestation</seealso>
    let productionMethodForManuscriptManifestation =
        Prefixed_Name(rdagr1, "productionMethodForManuscriptManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionMethodForTactileResources</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionMethodForTactileResources">http://rdvocab.info/Elements/productionMethodForTactileResources</seealso>
    let productionMethodForTactileResources =
        Prefixed_Name(rdagr1, "productionMethodForTactileResources") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionStatement">http://rdvocab.info/Elements/productionStatement</seealso>
    let productionStatement =
        Prefixed_Name(rdagr1, "productionStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:productionStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Production statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/productionStatementManifestation">http://rdvocab.info/Elements/productionStatementManifestation</seealso>
    let productionStatementManifestation =
        Prefixed_Name(rdagr1, "productionStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:projectionSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Projection speed</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/projectionSpeed">http://rdvocab.info/Elements/projectionSpeed</seealso>
    let projectionSpeed = Prefixed_Name(rdagr1, "projectionSpeed") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:projectionCharacteristicsOfMotionPictureFilm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/Elements/projectionCharacteristicsOfMotionPictureFilm">http://rdvocab.info/Elements/projectionCharacteristicsOfMotionPictureFilm</seealso>
    let projectionCharacteristicsOfMotionPictureFilm =
        Prefixed_Name(rdagr1, "projectionCharacteristicsOfMotionPictureFilm") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:projectionOfCartographicContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Projection of cartographic content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/projectionOfCartographicContent">http://rdvocab.info/Elements/projectionOfCartographicContent</seealso>
    let projectionOfCartographicContent =
        Prefixed_Name(rdagr1, "projectionOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:projectionOfCartographicContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Projection of cartographic content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/projectionOfCartographicContentExpression">http://rdvocab.info/Elements/projectionOfCartographicContentExpression</seealso>
    let projectionOfCartographicContentExpression =
        Prefixed_Name(rdagr1, "projectionOfCartographicContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:publicationStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Publication statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/publicationStatement">http://rdvocab.info/Elements/publicationStatement</seealso>
    let publicationStatement =
        Prefixed_Name(rdagr1, "publicationStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:publicationStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Publication statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/publicationStatementManifestation">http://rdvocab.info/Elements/publicationStatementManifestation</seealso>
    let publicationStatementManifestation =
        Prefixed_Name(rdagr1, "publicationStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/title">http://rdvocab.info/Elements/title</seealso>
    let title = Prefixed_Name(rdagr1, "title") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:titleManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleManifestation">http://rdvocab.info/Elements/titleManifestation</seealso>
    let titleManifestation = Prefixed_Name(rdagr1, "titleManifestation") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:academicDegreeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Academic degree (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/academicDegreeWork">http://rdvocab.info/Elements/academicDegreeWork</seealso>
    let academicDegreeWork = Prefixed_Name(rdagr1, "academicDegreeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dissertationOrThesesInformationWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dissertationOrThesesInformationWork">http://rdvocab.info/Elements/dissertationOrThesesInformationWork</seealso>
    let dissertationOrThesesInformationWork =
        Prefixed_Name(rdagr1, "dissertationOrThesesInformationWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dissertationOrThesisInformationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dissertation or thesis information (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dissertationOrThesisInformationWork">http://rdvocab.info/Elements/dissertationOrThesisInformationWork</seealso>
    let dissertationOrThesisInformationWork =
        Prefixed_Name(rdagr1, "dissertationOrThesisInformationWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:accessibilityContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Accessibility content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/accessibilityContent">http://rdvocab.info/Elements/accessibilityContent</seealso>
    let accessibilityContent =
        Prefixed_Name(rdagr1, "accessibilityContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourContentExpression">http://rdvocab.info/Elements/colourContentExpression</seealso>
    let colourContentExpression =
        Prefixed_Name(rdagr1, "colourContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:colourContentOfResourceDesignedForPersonsWithVisualImpairments</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Colour content of resource designed for persons with visual impairments</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/colourContentOfResourceDesignedForPersonsWithVisualImpairments">http://rdvocab.info/Elements/colourContentOfResourceDesignedForPersonsWithVisualImpairments</seealso>
    let colourContentOfResourceDesignedForPersonsWithVisualImpairments =
        Prefixed_Name(rdagr1, "colourContentOfResourceDesignedForPersonsWithVisualImpairments") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:equipmentOrSystemRequirementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Equipment or system requirement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/equipmentOrSystemRequirementManifestation">http://rdvocab.info/Elements/equipmentOrSystemRequirementManifestation</seealso>
    let equipmentOrSystemRequirementManifestation =
        Prefixed_Name(rdagr1, "equipmentOrSystemRequirementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:languageOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Language of expression</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/languageOfExpression">http://rdvocab.info/Elements/languageOfExpression</seealso>
    let languageOfExpression =
        Prefixed_Name(rdagr1, "languageOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:laterTitleProper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Later title proper</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/laterTitleProper">http://rdvocab.info/Elements/laterTitleProper</seealso>
    let laterTitleProper = Prefixed_Name(rdagr1, "laterTitleProper") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfManufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of manufacture</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfManufacture">http://rdvocab.info/Elements/parallelPlaceOfManufacture</seealso>
    let parallelPlaceOfManufacture =
        Prefixed_Name(rdagr1, "parallelPlaceOfManufacture") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfProductionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of production (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfProductionManifestation">http://rdvocab.info/Elements/parallelPlaceOfProductionManifestation</seealso>
    let parallelPlaceOfProductionManifestation =
        Prefixed_Name(rdagr1, "parallelPlaceOfProductionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of publication</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfPublication">http://rdvocab.info/Elements/parallelPlaceOfPublication</seealso>
    let parallelPlaceOfPublication =
        Prefixed_Name(rdagr1, "parallelPlaceOfPublication") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPlaceOfPublicationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel place of publication (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPlaceOfPublicationManifestation">http://rdvocab.info/Elements/parallelPlaceOfPublicationManifestation</seealso>
    let parallelPlaceOfPublicationManifestation =
        Prefixed_Name(rdagr1, "parallelPlaceOfPublicationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:academicDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Academic degree</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/academicDegree">http://rdvocab.info/Elements/academicDegree</seealso>
    let academicDegree = Prefixed_Name(rdagr1, "academicDegree") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:accessibilityContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Accessibility content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/accessibilityContentExpression">http://rdvocab.info/Elements/accessibilityContentExpression</seealso>
    let accessibilityContentExpression =
        Prefixed_Name(rdagr1, "accessibilityContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:equinoxWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Equinox (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/equinoxWork">http://rdvocab.info/Elements/equinoxWork</seealso>
    let equinoxWork = Prefixed_Name(rdagr1, "equinoxWork") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extent">http://rdvocab.info/Elements/extent</seealso>
    let extent = Prefixed_Name(rdagr1, "extent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfCartographicResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of cartographic resource</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfCartographicResource">http://rdvocab.info/Elements/extentOfCartographicResource</seealso>
    let extentOfCartographicResource =
        Prefixed_Name(rdagr1, "extentOfCartographicResource") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentItem">http://rdvocab.info/Elements/extentItem</seealso>
    let extentItem = Prefixed_Name(rdagr1, "extentItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfThreeDimensionalFormManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of three-dimensional form (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfThreeDimensionalFormManifestation">http://rdvocab.info/Elements/extentOfThreeDimensionalFormManifestation</seealso>
    let extentOfThreeDimensionalFormManifestation =
        Prefixed_Name(rdagr1, "extentOfThreeDimensionalFormManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfCartographicResourceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of cartographic resource (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfCartographicResourceManifestation">http://rdvocab.info/Elements/extentOfCartographicResourceManifestation</seealso>
    let extentOfCartographicResourceManifestation =
        Prefixed_Name(rdagr1, "extentOfCartographicResourceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfStillImageManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of still image (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfStillImageManifestation">http://rdvocab.info/Elements/extentOfStillImageManifestation</seealso>
    let extentOfStillImageManifestation =
        Prefixed_Name(rdagr1, "extentOfStillImageManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPublishersName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel publisher's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPublishersName">http://rdvocab.info/Elements/parallelPublishersName</seealso>
    let parallelPublishersName =
        Prefixed_Name(rdagr1, "parallelPublishersName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelPublishersNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel publisher's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelPublishersNameManifestation">http://rdvocab.info/Elements/parallelPublishersNameManifestation</seealso>
    let parallelPublishersNameManifestation =
        Prefixed_Name(rdagr1, "parallelPublishersNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:carrierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Carrier type</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/carrierType">http://rdvocab.info/Elements/carrierType</seealso>
    let carrierType = Prefixed_Name(rdagr1, "carrierType") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:durationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Duration (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/durationExpression">http://rdvocab.info/Elements/durationExpression</seealso>
    let durationExpression = Prefixed_Name(rdagr1, "durationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:illustrativeContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrative content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/illustrativeContent">http://rdvocab.info/Elements/illustrativeContent</seealso>
    let illustrativeContent =
        Prefixed_Name(rdagr1, "illustrativeContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:publishersName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Publisher's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/publishersName">http://rdvocab.info/Elements/publishersName</seealso>
    let publishersName = Prefixed_Name(rdagr1, "publishersName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:publishersNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Publisher's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/publishersNameManifestation">http://rdvocab.info/Elements/publishersNameManifestation</seealso>
    let publishersNameManifestation =
        Prefixed_Name(rdagr1, "publishersNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:recordingMediumManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Recording medium (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/recordingMediumManifestation">http://rdvocab.info/Elements/recordingMediumManifestation</seealso>
    let recordingMediumManifestation =
        Prefixed_Name(rdagr1, "recordingMediumManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Key</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/key">http://rdvocab.info/Elements/key</seealso>
    let key = Prefixed_Name(rdagr1, "key") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:keyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Key (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/keyWork">http://rdvocab.info/Elements/keyWork</seealso>
    let keyWork = Prefixed_Name(rdagr1, "keyWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:restrictionsOnAccessItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Restrictions on access (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/restrictionsOnAccessItem">http://rdvocab.info/Elements/restrictionsOnAccessItem</seealso>
    let restrictionsOnAccessItem =
        Prefixed_Name(rdagr1, "restrictionsOnAccessItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:restrictionsOnUseItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Restrictions on use (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/restrictionsOnUseItem">http://rdvocab.info/Elements/restrictionsOnUseItem</seealso>
    let restrictionsOnUseItem =
        Prefixed_Name(rdagr1, "restrictionsOnUseItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Chronological designation of first issue or part of sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</seealso>
    let chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:recordingMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Recording medium</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/recordingMedium">http://rdvocab.info/Elements/recordingMedium</seealso>
    let recordingMedium = Prefixed_Name(rdagr1, "recordingMedium") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:reductionRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reduction ratio</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/reductionRatio">http://rdvocab.info/Elements/reductionRatio</seealso>
    let reductionRatio = Prefixed_Name(rdagr1, "reductionRatio") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:additionalScaleInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Additional scale information</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/additionalScaleInformation">http://rdvocab.info/Elements/additionalScaleInformation</seealso>
    let additionalScaleInformation =
        Prefixed_Name(rdagr1, "additionalScaleInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:scaleExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Scale (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/scaleExpression">http://rdvocab.info/Elements/scaleExpression</seealso>
    let scaleExpression = Prefixed_Name(rdagr1, "scaleExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Chronological Designation of First Issue or Part of Sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</seealso>
    let alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:soundCharacteristicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sound characteristic (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/soundCharacteristicManifestation">http://rdvocab.info/Elements/soundCharacteristicManifestation</seealso>
    let soundCharacteristicManifestation =
        Prefixed_Name(rdagr1, "soundCharacteristicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:contactInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contact information</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/contactInformation">http://rdvocab.info/Elements/contactInformation</seealso>
    let contactInformation = Prefixed_Name(rdagr1, "contactInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfTextManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of text (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfTextManifestation">http://rdvocab.info/Elements/extentOfTextManifestation</seealso>
    let extentOfTextManifestation =
        Prefixed_Name(rdagr1, "extentOfTextManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfNotatedMusicManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of notated music (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfNotatedMusicManifestation">http://rdvocab.info/Elements/extentOfNotatedMusicManifestation</seealso>
    let extentOfNotatedMusicManifestation =
        Prefixed_Name(rdagr1, "extentOfNotatedMusicManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfNotatedMusicItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of notated music (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfNotatedMusicItem">http://rdvocab.info/Elements/extentOfNotatedMusicItem</seealso>
    let extentOfNotatedMusicItem =
        Prefixed_Name(rdagr1, "extentOfNotatedMusicItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:mediumOfPerformanceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Medium of performance (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/mediumOfPerformanceWork">http://rdvocab.info/Elements/mediumOfPerformanceWork</seealso>
    let mediumOfPerformanceWork =
        Prefixed_Name(rdagr1, "mediumOfPerformanceWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSubseries">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSubseries</seealso>
    let parallelStatementOfResponsibilityRelatingToSubseries =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToSubseriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSubseriesManifestation">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSubseriesManifestation</seealso>
    let parallelStatementOfResponsibilityRelatingToSubseriesManifestation =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToSubseriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToTheEditionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to the edition (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTheEditionManifestation">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTheEditionManifestation</seealso>
    let parallelStatementOfResponsibilityRelatingToTheEditionManifestation =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToTheEditionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToTitleProper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to title proper</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTitleProper">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTitleProper</seealso>
    let parallelStatementOfResponsibilityRelatingToTitleProper =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToTitleProper") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelStatementOfResponsibilityRelatingToTitleProperManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel statement of responsibility relating to title proper (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTitleProperManifestation">http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTitleProperManifestation</seealso>
    let parallelStatementOfResponsibilityRelatingToTitleProperManifestation =
        Prefixed_Name(rdagr1, "parallelStatementOfResponsibilityRelatingToTitleProperManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Scale</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/scale">http://rdvocab.info/Elements/scale</seealso>
    let scale = Prefixed_Name(rdagr1, "scale") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Chronological Designation of First Issue or Part of Sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence">http://rdvocab.info/Elements/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence</seealso>
    let alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numberingOfSerials</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering of serials</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numberingOfSerials">http://rdvocab.info/Elements/numberingOfSerials</seealso>
    let numberingOfSerials = Prefixed_Name(rdagr1, "numberingOfSerials") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:contactInformationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contact information (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/contactInformationManifestation">http://rdvocab.info/Elements/contactInformationManifestation</seealso>
    let contactInformationManifestation =
        Prefixed_Name(rdagr1, "contactInformationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Content type </para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/contentType">http://rdvocab.info/Elements/contentType</seealso>
    let contentType = Prefixed_Name(rdagr1, "contentType") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:coordinatesOfCartographicContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Coordinates of cartographic content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/coordinatesOfCartographicContent">http://rdvocab.info/Elements/coordinatesOfCartographicContent</seealso>
    let coordinatesOfCartographicContent =
        Prefixed_Name(rdagr1, "coordinatesOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:rightAscensionAndDeclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Right ascension and declination</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/rightAscensionAndDeclination">http://rdvocab.info/Elements/rightAscensionAndDeclination</seealso>
    let rightAscensionAndDeclination =
        Prefixed_Name(rdagr1, "rightAscensionAndDeclination") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:longitudeAndLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Longitude and latitude</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/longitudeAndLatitude">http://rdvocab.info/Elements/longitudeAndLatitude</seealso>
    let longitudeAndLatitude =
        Prefixed_Name(rdagr1, "longitudeAndLatitude") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:stringsOfCoordinatePairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Strings of coordinate pairs</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/stringsOfCoordinatePairs">http://rdvocab.info/Elements/stringsOfCoordinatePairs</seealso>
    let stringsOfCoordinatePairs =
        Prefixed_Name(rdagr1, "stringsOfCoordinatePairs") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:stringsOfCoordinatePairsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Strings of coordinate pairs (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/stringsOfCoordinatePairsWork">http://rdvocab.info/Elements/stringsOfCoordinatePairsWork</seealso>
    let stringsOfCoordinatePairsWork =
        Prefixed_Name(rdagr1, "stringsOfCoordinatePairsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:longitudeAndLatitudeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Longitude and latitude (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/longitudeAndLatitudeWork">http://rdvocab.info/Elements/longitudeAndLatitudeWork</seealso>
    let longitudeAndLatitudeWork =
        Prefixed_Name(rdagr1, "longitudeAndLatitudeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:copyrightDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Copyright date</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/copyrightDate">http://rdvocab.info/Elements/copyrightDate</seealso>
    let copyrightDate = Prefixed_Name(rdagr1, "copyrightDate") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:copyrightDateManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Copyright date (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/copyrightDateManifestation">http://rdvocab.info/Elements/copyrightDateManifestation</seealso>
    let copyrightDateManifestation =
        Prefixed_Name(rdagr1, "copyrightDateManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:coverageOfTheContentWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Coverage of the content (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/coverageOfTheContentWork">http://rdvocab.info/Elements/coverageOfTheContentWork</seealso>
    let coverageOfTheContentWork =
        Prefixed_Name(rdagr1, "coverageOfTheContentWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:fontSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Font size</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/fontSize">http://rdvocab.info/Elements/fontSize</seealso>
    let fontSize = Prefixed_Name(rdagr1, "fontSize") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:fontSizeManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Font size (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/fontSizeManifestation">http://rdvocab.info/Elements/fontSizeManifestation</seealso>
    let fontSizeManifestation =
        Prefixed_Name(rdagr1, "fontSizeManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfMusicalNotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of musical notation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfMusicalNotation">http://rdvocab.info/Elements/formOfMusicalNotation</seealso>
    let formOfMusicalNotation =
        Prefixed_Name(rdagr1, "formOfMusicalNotation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfNotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of notation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfNotation">http://rdvocab.info/Elements/formOfNotation</seealso>
    let formOfNotation = Prefixed_Name(rdagr1, "formOfNotation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfNotationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of notation (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfNotationExpression">http://rdvocab.info/Elements/formOfNotationExpression</seealso>
    let formOfNotationExpression =
        Prefixed_Name(rdagr1, "formOfNotationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfNotatedMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of notated movement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfNotatedMovement">http://rdvocab.info/Elements/formOfNotatedMovement</seealso>
    let formOfNotatedMovement =
        Prefixed_Name(rdagr1, "formOfNotatedMovement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfTactileNotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of tactile notation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfTactileNotation">http://rdvocab.info/Elements/formOfTactileNotation</seealso>
    let formOfTactileNotation =
        Prefixed_Name(rdagr1, "formOfTactileNotation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:script</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Script</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/script">http://rdvocab.info/Elements/script</seealso>
    let script = Prefixed_Name(rdagr1, "script") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfTactileNotationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of tactile notation (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfTactileNotationExpression">http://rdvocab.info/Elements/formOfTactileNotationExpression</seealso>
    let formOfTactileNotationExpression =
        Prefixed_Name(rdagr1, "formOfTactileNotationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:scriptExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Script (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/scriptExpression">http://rdvocab.info/Elements/scriptExpression</seealso>
    let scriptExpression = Prefixed_Name(rdagr1, "scriptExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:formOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfWork">http://rdvocab.info/Elements/formOfWork</seealso>
    let formOfWork = Prefixed_Name(rdagr1, "formOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formatOfNotatedMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Format of notated music</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formatOfNotatedMusic">http://rdvocab.info/Elements/formatOfNotatedMusic</seealso>
    let formatOfNotatedMusic =
        Prefixed_Name(rdagr1, "formatOfNotatedMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formatOfNotatedMusicExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Format of notated music (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formatOfNotatedMusicExpression">http://rdvocab.info/Elements/formatOfNotatedMusicExpression</seealso>
    let formatOfNotatedMusicExpression =
        Prefixed_Name(rdagr1, "formatOfNotatedMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of publication</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfPublication">http://rdvocab.info/Elements/placeOfPublication</seealso>
    let placeOfPublication = Prefixed_Name(rdagr1, "placeOfPublication") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeOfPublicationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of publication (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeOfPublicationManifestation">http://rdvocab.info/Elements/placeOfPublicationManifestation</seealso>
    let placeOfPublicationManifestation =
        Prefixed_Name(rdagr1, "placeOfPublicationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:additionalScaleInformationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Additional scale information (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/additionalScaleInformationExpression">http://rdvocab.info/Elements/additionalScaleInformationExpression</seealso>
    let additionalScaleInformationExpression =
        Prefixed_Name(rdagr1, "additionalScaleInformationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:extentOfStillImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extent of still image</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/extentOfStillImage">http://rdvocab.info/Elements/extentOfStillImage</seealso>
    let extentOfStillImage = Prefixed_Name(rdagr1, "extentOfStillImage") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Media type</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/mediaType">http://rdvocab.info/Elements/mediaType</seealso>
    let mediaType = Prefixed_Name(rdagr1, "mediaType") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeChronologicalDesignationOfLastIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Chronological Designation of Last Issue or Part of Sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfLastIssueOrPartOfSequence">http://rdvocab.info/Elements/alternativeChronologicalDesignationOfLastIssueOrPartOfSequence</seealso>
    let alternativeChronologicalDesignationOfLastIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "alternativeChronologicalDesignationOfLastIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Numeric and/or Alphabetic Designation of First Issue or Part of Sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</seealso>
    let alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSubseries">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSubseries</seealso>
    let statementOfResponsibilityRelatingToSubseries =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToSubseriesManifestatiion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSubseriesManifestatiion">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSubseriesManifestatiion</seealso>
    let statementOfResponsibilityRelatingToSubseriesManifestatiion =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToSubseriesManifestatiion") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:statementOfResponsibilityRelatingToTitleProper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Statement of responsibility relating to title proper</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToTitleProper">http://rdvocab.info/Elements/statementOfResponsibilityRelatingToTitleProper</seealso>
    let statementOfResponsibilityRelatingToTitleProper =
        Prefixed_Name(rdagr1, "statementOfResponsibilityRelatingToTitleProper") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:coordinatesOfCartographicContentWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Coordinates of cartographic content (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/coordinatesOfCartographicContentWork">http://rdvocab.info/Elements/coordinatesOfCartographicContentWork</seealso>
    let coordinatesOfCartographicContentWork =
        Prefixed_Name(rdagr1, "coordinatesOfCartographicContentWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:rightAscensionAndDeclinationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Right ascension and declination (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/rightAscensionAndDeclinationWork">http://rdvocab.info/Elements/rightAscensionAndDeclinationWork</seealso>
    let rightAscensionAndDeclinationWork =
        Prefixed_Name(rdagr1, "rightAscensionAndDeclinationWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnDistributionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on distribution statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnDistributionStatement">http://rdvocab.info/Elements/noteOnDistributionStatement</seealso>
    let noteOnDistributionStatement =
        Prefixed_Name(rdagr1, "noteOnDistributionStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on issue, part, or iteration used as the basis for identification of the resource</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource">http://rdvocab.info/Elements/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource</seealso>
    let noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource =
        Prefixed_Name(rdagr1, "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnStatementOfResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on statement of responsibility</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnStatementOfResponsibility">http://rdvocab.info/Elements/noteOnStatementOfResponsibility</seealso>
    let noteOnStatementOfResponsibility =
        Prefixed_Name(rdagr1, "noteOnStatementOfResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnChangesInCarrierCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on changes in carrier characteristics</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnChangesInCarrierCharacteristics">http://rdvocab.info/Elements/noteOnChangesInCarrierCharacteristics</seealso>
    let noteOnChangesInCarrierCharacteristics =
        Prefixed_Name(rdagr1, "noteOnChangesInCarrierCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:parallelTitleProperManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parallel title proper (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/parallelTitleProperManifestation">http://rdvocab.info/Elements/parallelTitleProperManifestation</seealso>
    let parallelTitleProperManifestation =
        Prefixed_Name(rdagr1, "parallelTitleProperManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:custodialHistoryOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Custodial history of item</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/custodialHistoryOfItem">http://rdvocab.info/Elements/custodialHistoryOfItem</seealso>
    let custodialHistoryOfItem =
        Prefixed_Name(rdagr1, "custodialHistoryOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfCapture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of capture</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfCapture">http://rdvocab.info/Elements/dateOfCapture</seealso>
    let dateOfCapture = Prefixed_Name(rdagr1, "dateOfCapture") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:dateOfDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of distribution</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfDistribution">http://rdvocab.info/Elements/dateOfDistribution</seealso>
    let dateOfDistribution = Prefixed_Name(rdagr1, "dateOfDistribution") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfDistributionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of distribution (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfDistributionManifestation">http://rdvocab.info/Elements/dateOfDistributionManifestation</seealso>
    let dateOfDistributionManifestation =
        Prefixed_Name(rdagr1, "dateOfDistributionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of expression</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfExpression">http://rdvocab.info/Elements/dateOfExpression</seealso>
    let dateOfExpression = Prefixed_Name(rdagr1, "dateOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:dateOfManufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of manufacture</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfManufacture">http://rdvocab.info/Elements/dateOfManufacture</seealso>
    let dateOfManufacture = Prefixed_Name(rdagr1, "dateOfManufacture") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfManufactureManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of manufacture (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfManufactureManifestation">http://rdvocab.info/Elements/dateOfManufactureManifestation</seealso>
    let dateOfManufactureManifestation =
        Prefixed_Name(rdagr1, "dateOfManufactureManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of production</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfProduction">http://rdvocab.info/Elements/dateOfProduction</seealso>
    let dateOfProduction = Prefixed_Name(rdagr1, "dateOfProduction") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnProductionStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on production statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnProductionStatementManifestation">http://rdvocab.info/Elements/noteOnProductionStatementManifestation</seealso>
    let noteOnProductionStatementManifestation =
        Prefixed_Name(rdagr1, "noteOnProductionStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnCopyrightDateManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on copyright date (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnCopyrightDateManifestation">http://rdvocab.info/Elements/noteOnCopyrightDateManifestation</seealso>
    let noteOnCopyrightDateManifestation =
        Prefixed_Name(rdagr1, "noteOnCopyrightDateManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on issue, part, or iteration used as the basis for identification of the resource (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation">http://rdvocab.info/Elements/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation</seealso>
    let noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation =
        Prefixed_Name(rdagr1, "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnSeriesStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on series statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnSeriesStatementManifestation">http://rdvocab.info/Elements/noteOnSeriesStatementManifestation</seealso>
    let noteOnSeriesStatementManifestation =
        Prefixed_Name(rdagr1, "noteOnSeriesStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:supplementaryContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplementary content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/supplementaryContent">http://rdvocab.info/Elements/supplementaryContent</seealso>
    let supplementaryContent =
        Prefixed_Name(rdagr1, "supplementaryContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:supplementaryContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplementary content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/supplementaryContentExpression">http://rdvocab.info/Elements/supplementaryContentExpression</seealso>
    let supplementaryContentExpression =
        Prefixed_Name(rdagr1, "supplementaryContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:systemOfOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>System of organization</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/systemOfOrganization">http://rdvocab.info/Elements/systemOfOrganization</seealso>
    let systemOfOrganization =
        Prefixed_Name(rdagr1, "systemOfOrganization") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:termsOfAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Terms of availability</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/termsOfAvailability">http://rdvocab.info/Elements/termsOfAvailability</seealso>
    let termsOfAvailability =
        Prefixed_Name(rdagr1, "termsOfAvailability") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:termsOfAvailabilityManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Terms of availability (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/termsOfAvailabilityManifestation">http://rdvocab.info/Elements/termsOfAvailabilityManifestation</seealso>
    let termsOfAvailabilityManifestation =
        Prefixed_Name(rdagr1, "termsOfAvailabilityManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:dateOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of publication</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfPublication">http://rdvocab.info/Elements/dateOfPublication</seealso>
    let dateOfPublication = Prefixed_Name(rdagr1, "dateOfPublication") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:dateOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/dateOfWork">http://rdvocab.info/Elements/dateOfWork</seealso>
    let dateOfWork = Prefixed_Name(rdagr1, "dateOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfMusicalNotationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of musical notation (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfMusicalNotationExpression">http://rdvocab.info/Elements/formOfMusicalNotationExpression</seealso>
    let formOfMusicalNotationExpression =
        Prefixed_Name(rdagr1, "formOfMusicalNotationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:formOfNotatedMovementExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form of notated movement (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/formOfNotatedMovementExpression">http://rdvocab.info/Elements/formOfNotatedMovementExpression</seealso>
    let formOfNotatedMovementExpression =
        Prefixed_Name(rdagr1, "formOfNotatedMovementExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:placeAndDateOfCaptureExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place and date of capture (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/placeAndDateOfCaptureExpression">http://rdvocab.info/Elements/placeAndDateOfCaptureExpression</seealso>
    let placeAndDateOfCaptureExpression =
        Prefixed_Name(rdagr1, "placeAndDateOfCaptureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Alternative Numeric and/or Alphabetic Designation of Last Issue or Part of Sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence">http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</seealso>
    let alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:appliedMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Applied material</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/appliedMaterial">http://rdvocab.info/Elements/appliedMaterial</seealso>
    let appliedMaterial = Prefixed_Name(rdagr1, "appliedMaterial") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:emulsionOnMicrofilmAndMicroficheManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Emulsion on microfilm and microfiche (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/emulsionOnMicrofilmAndMicroficheManifestation">http://rdvocab.info/Elements/emulsionOnMicrofilmAndMicroficheManifestation</seealso>
    let emulsionOnMicrofilmAndMicroficheManifestation =
        Prefixed_Name(rdagr1, "emulsionOnMicrofilmAndMicroficheManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:systemOfOrganizationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>System of organization (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/systemOfOrganizationWork">http://rdvocab.info/Elements/systemOfOrganizationWork</seealso>
    let systemOfOrganizationWork =
        Prefixed_Name(rdagr1, "systemOfOrganizationWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:DissertationOrThesisInformationEncodingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dissertation Or Thesis Information Encoding Scheme</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/DissertationOrThesisInformationEncodingScheme">http://rdvocab.info/Elements/DissertationOrThesisInformationEncodingScheme</seealso>
    let DissertationOrThesisInformationEncodingScheme =
        Prefixed_Name(rdagr1, "DissertationOrThesisInformationEncodingScheme") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:earlierTitleProperManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Earlier title proper (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/earlierTitleProperManifestation">http://rdvocab.info/Elements/earlierTitleProperManifestation</seealso>
    let earlierTitleProperManifestation =
        Prefixed_Name(rdagr1, "earlierTitleProperManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:editionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Edition statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/editionStatement">http://rdvocab.info/Elements/editionStatement</seealso>
    let editionStatement = Prefixed_Name(rdagr1, "editionStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:editionStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Edition statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/editionStatementManifestation">http://rdvocab.info/Elements/editionStatementManifestation</seealso>
    let editionStatementManifestation =
        Prefixed_Name(rdagr1, "editionStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:epoch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Epoch</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/epoch">http://rdvocab.info/Elements/epoch</seealso>
    let epoch = Prefixed_Name(rdagr1, "epoch") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:epochWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Epoch (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/epochWork">http://rdvocab.info/Elements/epochWork</seealso>
    let epochWork = Prefixed_Name(rdagr1, "epochWork") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:equinox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Equinox</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/equinox">http://rdvocab.info/Elements/equinox</seealso>
    let equinox = Prefixed_Name(rdagr1, "equinox") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:equipmentOrSystemRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Equipment or system requirement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/equipmentOrSystemRequirement">http://rdvocab.info/Elements/equipmentOrSystemRequirement</seealso>
    let equipmentOrSystemRequirement =
        Prefixed_Name(rdagr1, "equipmentOrSystemRequirement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:keyTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Key title</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/keyTitle">http://rdvocab.info/Elements/keyTitle</seealso>
    let keyTitle = Prefixed_Name(rdagr1, "keyTitle") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:keyTitleManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Key title (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/keyTitleManifestation">http://rdvocab.info/Elements/keyTitleManifestation</seealso>
    let keyTitleManifestation =
        Prefixed_Name(rdagr1, "keyTitleManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:languageOfTheContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Language of the content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/languageOfTheContent">http://rdvocab.info/Elements/languageOfTheContent</seealso>
    let languageOfTheContent =
        Prefixed_Name(rdagr1, "languageOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:languageOfTheContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Language of the content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/languageOfTheContentExpression">http://rdvocab.info/Elements/languageOfTheContentExpression</seealso>
    let languageOfTheContentExpression =
        Prefixed_Name(rdagr1, "languageOfTheContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:laterTitleProperManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Later title proper (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/laterTitleProperManifestation">http://rdvocab.info/Elements/laterTitleProperManifestation</seealso>
    let laterTitleProperManifestation =
        Prefixed_Name(rdagr1, "laterTitleProperManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layout</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Associated with the FRBR Manifestation entity.</para>
    /// labels<para>Layout</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layout">http://rdvocab.info/Elements/layout</seealso>
    let layout = Prefixed_Name(rdagr1, "layout") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layoutOfTactileText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Layout of tactile text</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layoutOfTactileText">http://rdvocab.info/Elements/layoutOfTactileText</seealso>
    let layoutOfTactileText =
        Prefixed_Name(rdagr1, "layoutOfTactileText") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layoutManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Layout (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layoutManifestation">http://rdvocab.info/Elements/layoutManifestation</seealso>
    let layoutManifestation =
        Prefixed_Name(rdagr1, "layoutManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layoutOfTactileMusicalNotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Layout of tactile musical notation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layoutOfTactileMusicalNotation">http://rdvocab.info/Elements/layoutOfTactileMusicalNotation</seealso>
    let layoutOfTactileMusicalNotation =
        Prefixed_Name(rdagr1, "layoutOfTactileMusicalNotation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:layoutOfTactileMusicalNotationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Layout of tactile musical notation (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/layoutOfTactileMusicalNotationManifestation">http://rdvocab.info/Elements/layoutOfTactileMusicalNotationManifestation</seealso>
    let layoutOfTactileMusicalNotationManifestation =
        Prefixed_Name(rdagr1, "layoutOfTactileMusicalNotationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:manufactureStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Manufacture statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/manufactureStatement">http://rdvocab.info/Elements/manufactureStatement</seealso>
    let manufactureStatement =
        Prefixed_Name(rdagr1, "manufactureStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:manufactureStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Manufacture statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/manufactureStatementManifestation">http://rdvocab.info/Elements/manufactureStatementManifestation</seealso>
    let manufactureStatementManifestation =
        Prefixed_Name(rdagr1, "manufactureStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:manufacturersName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Manufacturer's name</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/manufacturersName">http://rdvocab.info/Elements/manufacturersName</seealso>
    let manufacturersName = Prefixed_Name(rdagr1, "manufacturersName") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:manufacturersNameManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Manufacturer's name (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/manufacturersNameManifestation">http://rdvocab.info/Elements/manufacturersNameManifestation</seealso>
    let manufacturersNameManifestation =
        Prefixed_Name(rdagr1, "manufacturersNameManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:mediaTypeManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Media type (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/mediaTypeManifestation">http://rdvocab.info/Elements/mediaTypeManifestation</seealso>
    let mediaTypeManifestation =
        Prefixed_Name(rdagr1, "mediaTypeManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:mediumOfPerformanceOfMusicalContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Medium of performance of musical content</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/mediumOfPerformanceOfMusicalContent">http://rdvocab.info/Elements/mediumOfPerformanceOfMusicalContent</seealso>
    let mediumOfPerformanceOfMusicalContent =
        Prefixed_Name(rdagr1, "mediumOfPerformanceOfMusicalContent") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:mediumOfPerformanceOfMusicalContentExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Medium of performance of musical content (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/mediumOfPerformanceOfMusicalContentExpression">http://rdvocab.info/Elements/mediumOfPerformanceOfMusicalContentExpression</seealso>
    let mediumOfPerformanceOfMusicalContentExpression =
        Prefixed_Name(rdagr1, "mediumOfPerformanceOfMusicalContentExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:modeOfIssuance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Mode of issuance</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/modeOfIssuance">http://rdvocab.info/Elements/modeOfIssuance</seealso>
    let modeOfIssuance = Prefixed_Name(rdagr1, "modeOfIssuance") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:modeOfIssuanceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Mode of issuance (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/modeOfIssuanceManifestation">http://rdvocab.info/Elements/modeOfIssuanceManifestation</seealso>
    let modeOfIssuanceManifestation =
        Prefixed_Name(rdagr1, "modeOfIssuanceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:mount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Associated with the FRBR Manifestation entity.</para>
    /// labels<para>Mount</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/mount">http://rdvocab.info/Elements/mount</seealso>
    let mount = Prefixed_Name(rdagr1, "mount") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:mountManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Mount (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/mountManifestation">http://rdvocab.info/Elements/mountManifestation</seealso>
    let mountManifestation = Prefixed_Name(rdagr1, "mountManifestation") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/note">http://rdvocab.info/Elements/note</seealso>
    let note = Prefixed_Name(rdagr1, "note") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnDimensionsOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on dimensions of item</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnDimensionsOfItem">http://rdvocab.info/Elements/noteOnDimensionsOfItem</seealso>
    let noteOnDimensionsOfItem =
        Prefixed_Name(rdagr1, "noteOnDimensionsOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on manifestation or item (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteManifestation">http://rdvocab.info/Elements/noteManifestation</seealso>
    let noteManifestation = Prefixed_Name(rdagr1, "noteManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteonChangesinContentCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on changes in content characteristics</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteonChangesinContentCharacteristics">http://rdvocab.info/Elements/noteonChangesinContentCharacteristics</seealso>
    let noteonChangesinContentCharacteristics =
        Prefixed_Name(rdagr1, "noteonChangesinContentCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnExtentOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on extent of item </para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnExtentOfItem">http://rdvocab.info/Elements/noteOnExtentOfItem</seealso>
    let noteOnExtentOfItem = Prefixed_Name(rdagr1, "noteOnExtentOfItem") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:noteItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on manifestation or item (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteItem">http://rdvocab.info/Elements/noteItem</seealso>
    let noteItem = Prefixed_Name(rdagr1, "noteItem") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:noteOnTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on title</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnTitle">http://rdvocab.info/Elements/noteOnTitle</seealso>
    let noteOnTitle = Prefixed_Name(rdagr1, "noteOnTitle") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnPublicationStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on publication statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnPublicationStatement">http://rdvocab.info/Elements/noteOnPublicationStatement</seealso>
    let noteOnPublicationStatement =
        Prefixed_Name(rdagr1, "noteOnPublicationStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on expression (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteExpression">http://rdvocab.info/Elements/noteExpression</seealso>
    let noteExpression = Prefixed_Name(rdagr1, "noteExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnDimensionsOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on dimensions of manifestation</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnDimensionsOfManifestation">http://rdvocab.info/Elements/noteOnDimensionsOfManifestation</seealso>
    let noteOnDimensionsOfManifestation =
        Prefixed_Name(rdagr1, "noteOnDimensionsOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnSeriesStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on series statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnSeriesStatement">http://rdvocab.info/Elements/noteOnSeriesStatement</seealso>
    let noteOnSeriesStatement =
        Prefixed_Name(rdagr1, "noteOnSeriesStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnCopyrightDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on copyright date</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnCopyrightDate">http://rdvocab.info/Elements/noteOnCopyrightDate</seealso>
    let noteOnCopyrightDate =
        Prefixed_Name(rdagr1, "noteOnCopyrightDate") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnManufactureStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on manufacture statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnManufactureStatement">http://rdvocab.info/Elements/noteOnManufactureStatement</seealso>
    let noteOnManufactureStatement =
        Prefixed_Name(rdagr1, "noteOnManufactureStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnProductionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on production statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnProductionStatement">http://rdvocab.info/Elements/noteOnProductionStatement</seealso>
    let noteOnProductionStatement =
        Prefixed_Name(rdagr1, "noteOnProductionStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on frequency</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnFrequency">http://rdvocab.info/Elements/noteOnFrequency</seealso>
    let noteOnFrequency = Prefixed_Name(rdagr1, "noteOnFrequency") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnNumberingOfSerials</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on numbering of serials</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnNumberingOfSerials">http://rdvocab.info/Elements/noteOnNumberingOfSerials</seealso>
    let noteOnNumberingOfSerials =
        Prefixed_Name(rdagr1, "noteOnNumberingOfSerials") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnEditionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on edition statement</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnEditionStatement">http://rdvocab.info/Elements/noteOnEditionStatement</seealso>
    let noteOnEditionStatement =
        Prefixed_Name(rdagr1, "noteOnEditionStatement") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnPublicationStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on publication statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnPublicationStatementManifestation">http://rdvocab.info/Elements/noteOnPublicationStatementManifestation</seealso>
    let noteOnPublicationStatementManifestation =
        Prefixed_Name(rdagr1, "noteOnPublicationStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnDistributionStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on distribution statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnDistributionStatementManifestation">http://rdvocab.info/Elements/noteOnDistributionStatementManifestation</seealso>
    let noteOnDistributionStatementManifestation =
        Prefixed_Name(rdagr1, "noteOnDistributionStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnFrequencyManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on frequency (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnFrequencyManifestation">http://rdvocab.info/Elements/noteOnFrequencyManifestation</seealso>
    let noteOnFrequencyManifestation =
        Prefixed_Name(rdagr1, "noteOnFrequencyManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnChangesInCarrierCharacteristicsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on changes in carrier characteristics (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnChangesInCarrierCharacteristicsManifestation">http://rdvocab.info/Elements/noteOnChangesInCarrierCharacteristicsManifestation</seealso>
    let noteOnChangesInCarrierCharacteristicsManifestation =
        Prefixed_Name(rdagr1, "noteOnChangesInCarrierCharacteristicsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnEditionStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on edition statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnEditionStatementManifestation">http://rdvocab.info/Elements/noteOnEditionStatementManifestation</seealso>
    let noteOnEditionStatementManifestation =
        Prefixed_Name(rdagr1, "noteOnEditionStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnTitleManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on title (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnTitleManifestation">http://rdvocab.info/Elements/noteOnTitleManifestation</seealso>
    let noteOnTitleManifestation =
        Prefixed_Name(rdagr1, "noteOnTitleManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnStatementOfResponsibilityManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on statement of responsibility (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnStatementOfResponsibilityManifestation">http://rdvocab.info/Elements/noteOnStatementOfResponsibilityManifestation</seealso>
    let noteOnStatementOfResponsibilityManifestation =
        Prefixed_Name(rdagr1, "noteOnStatementOfResponsibilityManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnManufactureStatementManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on manufacture statement (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnManufactureStatementManifestation">http://rdvocab.info/Elements/noteOnManufactureStatementManifestation</seealso>
    let noteOnManufactureStatementManifestation =
        Prefixed_Name(rdagr1, "noteOnManufactureStatementManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteOnNumberingOfSerialsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on numbering of serials (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteOnNumberingOfSerialsManifestation">http://rdvocab.info/Elements/noteOnNumberingOfSerialsManifestation</seealso>
    let noteOnNumberingOfSerialsManifestation =
        Prefixed_Name(rdagr1, "noteOnNumberingOfSerialsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:noteonChangesinContentCharacteristicsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note on changes in content characteristics (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/noteonChangesinContentCharacteristicsExpression">http://rdvocab.info/Elements/noteonChangesinContentCharacteristicsExpression</seealso>
    let noteonChangesinContentCharacteristicsExpression =
        Prefixed_Name(rdagr1, "noteonChangesinContentCharacteristicsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numeric and/or alphabetic designation of first issue or part of sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence">http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</seealso>
    let numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numeric and/or alphabetic designation of last issue or part of sequence</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence">http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</seealso>
    let numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence =
        Prefixed_Name(rdagr1, "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numeric and/or alphabetic designation of first issue or part of sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</seealso>
    let numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numeric and/or alphabetic designation of last issue or part of sequence (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation">http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</seealso>
    let numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation =
        Prefixed_Name(rdagr1, "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:numberingWithinSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering within series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/numberingWithinSeries">http://rdvocab.info/Elements/numberingWithinSeries</seealso>
    let numberingWithinSeries =
        Prefixed_Name(rdagr1, "numberingWithinSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleProper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title proper</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleProper">http://rdvocab.info/Elements/titleProper</seealso>
    let titleProper = Prefixed_Name(rdagr1, "titleProper") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:variantTitleForTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant title for the work</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/variantTitleForTheWork">http://rdvocab.info/Elements/variantTitleForTheWork</seealso>
    let variantTitleForTheWork =
        Prefixed_Name(rdagr1, "variantTitleForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:variantTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant title</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/variantTitle">http://rdvocab.info/Elements/variantTitle</seealso>
    let variantTitle = Prefixed_Name(rdagr1, "variantTitle") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleProperManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title proper (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleProperManifestation">http://rdvocab.info/Elements/titleProperManifestation</seealso>
    let titleProperManifestation =
        Prefixed_Name(rdagr1, "titleProperManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:variantTitleManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant title (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/variantTitleManifestation">http://rdvocab.info/Elements/variantTitleManifestation</seealso>
    let variantTitleManifestation =
        Prefixed_Name(rdagr1, "variantTitleManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleProperOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title proper of series</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleProperOfSeries">http://rdvocab.info/Elements/titleProperOfSeries</seealso>
    let titleProperOfSeries =
        Prefixed_Name(rdagr1, "titleProperOfSeries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleProperOfSeriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title proper of series (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleProperOfSeriesManifestation">http://rdvocab.info/Elements/titleProperOfSeriesManifestation</seealso>
    let titleProperOfSeriesManifestation =
        Prefixed_Name(rdagr1, "titleProperOfSeriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleProperOfSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title proper of subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleProperOfSubseries">http://rdvocab.info/Elements/titleProperOfSubseries</seealso>
    let titleProperOfSubseries =
        Prefixed_Name(rdagr1, "titleProperOfSubseries") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleProperOfSubseriesManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title proper of subseries (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleProperOfSubseriesManifestation">http://rdvocab.info/Elements/titleProperOfSubseriesManifestation</seealso>
    let titleProperOfSubseriesManifestation =
        Prefixed_Name(rdagr1, "titleProperOfSubseriesManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:uniformResourceLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Uniform resource locator</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/uniformResourceLocator">http://rdvocab.info/Elements/uniformResourceLocator</seealso>
    let uniformResourceLocator =
        Prefixed_Name(rdagr1, "uniformResourceLocator") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:uniformResourceLocatorManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Uniform resource locator (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/uniformResourceLocatorManifestation">http://rdvocab.info/Elements/uniformResourceLocatorManifestation</seealso>
    let uniformResourceLocatorManifestation =
        Prefixed_Name(rdagr1, "uniformResourceLocatorManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:uniformResourceLocatorItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Uniform resource locator (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/uniformResourceLocatorItem">http://rdvocab.info/Elements/uniformResourceLocatorItem</seealso>
    let uniformResourceLocatorItem =
        Prefixed_Name(rdagr1, "uniformResourceLocatorItem") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:titleOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/Elements/titleOfWork">http://rdvocab.info/Elements/titleOfWork</seealso>
    let titleOfWork = Prefixed_Name(rdagr1, "titleOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdagr1:videoFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video format</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/videoFormat">http://rdvocab.info/Elements/videoFormat</seealso>
    let videoFormat = Prefixed_Name(rdagr1, "videoFormat") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:videoFormatManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video format (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/videoFormatManifestation">http://rdvocab.info/Elements/videoFormatManifestation</seealso>
    let videoFormatManifestation =
        Prefixed_Name(rdagr1, "videoFormatManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:yearDegreeGranted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Year degree granted</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/yearDegreeGranted">http://rdvocab.info/Elements/yearDegreeGranted</seealso>
    let yearDegreeGranted = Prefixed_Name(rdagr1, "yearDegreeGranted") |> PrefixedName

    /// <summary>
    ///   <para>rdagr1:yearDegreeGrantedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Year degree granted (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/Elements/yearDegreeGrantedWork">http://rdvocab.info/Elements/yearDegreeGrantedWork</seealso>
    let yearDegreeGrantedWork =
        Prefixed_Name(rdagr1, "yearDegreeGrantedWork") |> PrefixedName
