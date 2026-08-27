namespace http.lod.xdams.org.reload.oad.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module reload =
    let _namespace_iri = Namespace_Iri reload |> NamespaceIRI
    /// <summary>
    ///   <para>reload:accruals</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/accruals">http://lod.xdams.org/reload/oad/accruals</seealso>
    let accruals = Prefixed_Name(reload, "accruals") |> PrefixedName

    /// <summary>
    ///   <para>reload:administrativeBiographicalHistory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/administrativeBiographicalHistory">http://lod.xdams.org/reload/oad/administrativeBiographicalHistory</seealso>
    let administrativeBiographicalHistory =
        Prefixed_Name(reload, "administrativeBiographicalHistory") |> PrefixedName

    /// <summary>
    ///   <para>reload:appraisalDestructionAndSchedulingInformation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/appraisalDestructionAndSchedulingInformation">http://lod.xdams.org/reload/oad/appraisalDestructionAndSchedulingInformation</seealso>
    let appraisalDestructionAndSchedulingInformation =
        Prefixed_Name(reload, "appraisalDestructionAndSchedulingInformation") |> PrefixedName

    /// <summary>
    ///   <para>reload:archivalHistory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/archivalHistory">http://lod.xdams.org/reload/oad/archivalHistory</seealso>
    let archivalHistory = Prefixed_Name(reload, "archivalHistory") |> PrefixedName
    /// <summary>
    ///   <para>reload:archivistsNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/archivistsNote">http://lod.xdams.org/reload/oad/archivistsNote</seealso>
    let archivistsNote = Prefixed_Name(reload, "archivistsNote") |> PrefixedName

    /// <summary>
    ///   <para>reload:conditionsGoverningAccess</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/conditionsGoverningAccess">http://lod.xdams.org/reload/oad/conditionsGoverningAccess</seealso>
    let conditionsGoverningAccess =
        Prefixed_Name(reload, "conditionsGoverningAccess") |> PrefixedName

    /// <summary>
    ///   <para>reload:conditionsGoverningReproduction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/conditionsGoverningReproduction">http://lod.xdams.org/reload/oad/conditionsGoverningReproduction</seealso>
    let conditionsGoverningReproduction =
        Prefixed_Name(reload, "conditionsGoverningReproduction") |> PrefixedName

    /// <summary>
    ///   <para>reload:custody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/custody">http://lod.xdams.org/reload/oad/custody</seealso>
    let custody = Prefixed_Name(reload, "custody") |> PrefixedName
    /// <summary>
    ///   <para>reload:date</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/date">http://lod.xdams.org/reload/oad/date</seealso>
    let date = Prefixed_Name(reload, "date") |> PrefixedName
    /// <summary>
    ///   <para>reload:eadElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/eadElement">http://lod.xdams.org/reload/oad/eadElement</seealso>
    let eadElement = Prefixed_Name(reload, "eadElement") |> PrefixedName

    /// <summary>
    ///   <para>reload:existenceAndLocationOfCopies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/existenceAndLocationOfCopies">http://lod.xdams.org/reload/oad/existenceAndLocationOfCopies</seealso>
    let existenceAndLocationOfCopies =
        Prefixed_Name(reload, "existenceAndLocationOfCopies") |> PrefixedName

    /// <summary>
    ///   <para>reload:existenceAndLocationOfOriginals</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/existenceAndLocationOfOriginals">http://lod.xdams.org/reload/oad/existenceAndLocationOfOriginals</seealso>
    let existenceAndLocationOfOriginals =
        Prefixed_Name(reload, "existenceAndLocationOfOriginals") |> PrefixedName

    /// <summary>
    ///   <para>reload:extentAndMedium</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/extentAndMedium">http://lod.xdams.org/reload/oad/extentAndMedium</seealso>
    let extentAndMedium = Prefixed_Name(reload, "extentAndMedium") |> PrefixedName
    /// <summary>
    ///   <para>reload:findingAid</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/findingAid">http://lod.xdams.org/reload/oad/findingAid</seealso>
    let findingAid = Prefixed_Name(reload, "findingAid") |> PrefixedName
    /// <summary>
    ///   <para>reload:has_accessPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_accessPoint">http://lod.xdams.org/reload/oad/has_accessPoint</seealso>
    let has_accessPoint = Prefixed_Name(reload, "has_accessPoint") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_accessPointCorporateBody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_accessPointCorporateBody">http://lod.xdams.org/reload/oad/has_accessPointCorporateBody</seealso>
    let has_accessPointCorporateBody =
        Prefixed_Name(reload, "has_accessPointCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_accessPointFamily</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_accessPointFamily">http://lod.xdams.org/reload/oad/has_accessPointFamily</seealso>
    let has_accessPointFamily =
        Prefixed_Name(reload, "has_accessPointFamily") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_accessPointPerson</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_accessPointPerson">http://lod.xdams.org/reload/oad/has_accessPointPerson</seealso>
    let has_accessPointPerson =
        Prefixed_Name(reload, "has_accessPointPerson") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_accessPointPlace</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_accessPointPlace">http://lod.xdams.org/reload/oad/has_accessPointPlace</seealso>
    let has_accessPointPlace =
        Prefixed_Name(reload, "has_accessPointPlace") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_administrativeBiographicalHistory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_administrativeBiographicalHistory">http://lod.xdams.org/reload/oad/has_administrativeBiographicalHistory</seealso>
    let has_administrativeBiographicalHistory =
        Prefixed_Name(reload, "has_administrativeBiographicalHistory") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_custody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_custody">http://lod.xdams.org/reload/oad/has_custody</seealso>
    let has_custody = Prefixed_Name(reload, "has_custody") |> PrefixedName
    /// <summary>
    ///   <para>reload:has_entity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_entity">http://lod.xdams.org/reload/oad/has_entity</seealso>
    let has_entity = Prefixed_Name(reload, "has_entity") |> PrefixedName
    /// <summary>
    ///   <para>reload:has_filePlan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_filePlan">http://lod.xdams.org/reload/oad/has_filePlan</seealso>
    let has_filePlan = Prefixed_Name(reload, "has_filePlan") |> PrefixedName
    /// <summary>
    ///   <para>reload:has_findingAid</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_findingAid">http://lod.xdams.org/reload/oad/has_findingAid</seealso>
    let has_findingAid = Prefixed_Name(reload, "has_findingAid") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_languageScriptsOfMaterial</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_languageScriptsOfMaterial">http://lod.xdams.org/reload/oad/has_languageScriptsOfMaterial</seealso>
    let has_languageScriptsOfMaterial =
        Prefixed_Name(reload, "has_languageScriptsOfMaterial") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_level</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_level">http://lod.xdams.org/reload/oad/has_level</seealso>
    let has_level = Prefixed_Name(reload, "has_level") |> PrefixedName
    /// <summary>
    ///   <para>reload:has_nameOfCreator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_nameOfCreator">http://lod.xdams.org/reload/oad/has_nameOfCreator</seealso>
    let has_nameOfCreator = Prefixed_Name(reload, "has_nameOfCreator") |> PrefixedName
    /// <summary>
    ///   <para>reload:has_production</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_production">http://lod.xdams.org/reload/oad/has_production</seealso>
    let has_production = Prefixed_Name(reload, "has_production") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_publicationNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_publicationNote">http://lod.xdams.org/reload/oad/has_publicationNote</seealso>
    let has_publicationNote =
        Prefixed_Name(reload, "has_publicationNote") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_relatedUnitsOfDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_relatedUnitsOfDescription">http://lod.xdams.org/reload/oad/has_relatedUnitsOfDescription</seealso>
    let has_relatedUnitsOfDescription =
        Prefixed_Name(reload, "has_relatedUnitsOfDescription") |> PrefixedName

    /// <summary>
    ///   <para>reload:has_repository</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/has_repository">http://lod.xdams.org/reload/oad/has_repository</seealso>
    let has_repository = Prefixed_Name(reload, "has_repository") |> PrefixedName

    /// <summary>
    ///   <para>reload:immediateSourceOfAcquisitionOrTransfer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/immediateSourceOfAcquisitionOrTransfer">http://lod.xdams.org/reload/oad/immediateSourceOfAcquisitionOrTransfer</seealso>
    let immediateSourceOfAcquisitionOrTransfer =
        Prefixed_Name(reload, "immediateSourceOfAcquisitionOrTransfer") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.1.1_reference_codes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.1_reference_codes">http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.1_reference_codes</seealso>
    let ``isadOntology/isad_3.1.1_reference_codes`` =
        Prefixed_Name(reload, "isadOntology/isad_3.1.1_reference_codes") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.1.2_title</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.2_title">http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.2_title</seealso>
    let ``isadOntology/isad_3.1.2_title`` =
        Prefixed_Name(reload, "isadOntology/isad_3.1.2_title") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.1.3_dates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.3_dates">http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.3_dates</seealso>
    let ``isadOntology/isad_3.1.3_dates`` =
        Prefixed_Name(reload, "isadOntology/isad_3.1.3_dates") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.1.4_level_of_description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.4_level_of_description">http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.4_level_of_description</seealso>
    let ``isadOntology/isad_3.1.4_level_of_description`` =
        Prefixed_Name(reload, "isadOntology/isad_3.1.4_level_of_description") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.1.5_extent_and_medium_of_the_unit_of_description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.5_extent_and_medium_of_the_unit_of_description">http://lod.xdams.org/reload/oad/isadOntology/isad_3.1.5_extent_and_medium_of_the_unit_of_description</seealso>
    let ``isadOntology/isad_3.1.5_extent_and_medium_of_the_unit_of_description`` =
        Prefixed_Name(reload, "isadOntology/isad_3.1.5_extent_and_medium_of_the_unit_of_description") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.2.1_name_of_creators</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.1_name_of_creators">http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.1_name_of_creators</seealso>
    let ``isadOntology/isad_3.2.1_name_of_creators`` =
        Prefixed_Name(reload, "isadOntology/isad_3.2.1_name_of_creators") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.2.2_administrative_biographical_history</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.2_administrative_biographical_history">http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.2_administrative_biographical_history</seealso>
    let ``isadOntology/isad_3.2.2_administrative_biographical_history`` =
        Prefixed_Name(reload, "isadOntology/isad_3.2.2_administrative_biographical_history") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.2.3_archival_history</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.3_archival_history">http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.3_archival_history</seealso>
    let ``isadOntology/isad_3.2.3_archival_history`` =
        Prefixed_Name(reload, "isadOntology/isad_3.2.3_archival_history") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.2.4_immediate_source_of_acquisition_or_transfer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.4_immediate_source_of_acquisition_or_transfer">http://lod.xdams.org/reload/oad/isadOntology/isad_3.2.4_immediate_source_of_acquisition_or_transfer</seealso>
    let ``isadOntology/isad_3.2.4_immediate_source_of_acquisition_or_transfer`` =
        Prefixed_Name(reload, "isadOntology/isad_3.2.4_immediate_source_of_acquisition_or_transfer") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.3.1_scope_and_content</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.1_scope_and_content">http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.1_scope_and_content</seealso>
    let ``isadOntology/isad_3.3.1_scope_and_content`` =
        Prefixed_Name(reload, "isadOntology/isad_3.3.1_scope_and_content") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.3.2_appraisal_destruction_and_scheduling_information</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.2_appraisal_destruction_and_scheduling_information">http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.2_appraisal_destruction_and_scheduling_information</seealso>
    let ``isadOntology/isad_3.3.2_appraisal_destruction_and_scheduling_information`` =
        Prefixed_Name(reload, "isadOntology/isad_3.3.2_appraisal_destruction_and_scheduling_information") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.3.3_accruals</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.3_accruals">http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.3_accruals</seealso>
    let ``isadOntology/isad_3.3.3_accruals`` =
        Prefixed_Name(reload, "isadOntology/isad_3.3.3_accruals") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.3.4_system_of_arrangement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.4_system_of_arrangement">http://lod.xdams.org/reload/oad/isadOntology/isad_3.3.4_system_of_arrangement</seealso>
    let ``isadOntology/isad_3.3.4_system_of_arrangement`` =
        Prefixed_Name(reload, "isadOntology/isad_3.3.4_system_of_arrangement") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.4.1_conditions_governing_access</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.1_conditions_governing_access">http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.1_conditions_governing_access</seealso>
    let ``isadOntology/isad_3.4.1_conditions_governing_access`` =
        Prefixed_Name(reload, "isadOntology/isad_3.4.1_conditions_governing_access") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.4.2_conditions_governing_reproduction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.2_conditions_governing_reproduction">http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.2_conditions_governing_reproduction</seealso>
    let ``isadOntology/isad_3.4.2_conditions_governing_reproduction`` =
        Prefixed_Name(reload, "isadOntology/isad_3.4.2_conditions_governing_reproduction") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.4.3_language_scripts_of_material</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.3_language_scripts_of_material">http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.3_language_scripts_of_material</seealso>
    let ``isadOntology/isad_3.4.3_language_scripts_of_material`` =
        Prefixed_Name(reload, "isadOntology/isad_3.4.3_language_scripts_of_material") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.4.4_physical_characteristics_and_technical_requirements</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.4_physical_characteristics_and_technical_requirements">http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.4_physical_characteristics_and_technical_requirements</seealso>
    let ``isadOntology/isad_3.4.4_physical_characteristics_and_technical_requirements`` =
        Prefixed_Name(reload, "isadOntology/isad_3.4.4_physical_characteristics_and_technical_requirements") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.4.5_finding_aids</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.5_finding_aids">http://lod.xdams.org/reload/oad/isadOntology/isad_3.4.5_finding_aids</seealso>
    let ``isadOntology/isad_3.4.5_finding_aids`` =
        Prefixed_Name(reload, "isadOntology/isad_3.4.5_finding_aids") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.5.1_existence_and_location_of_originals</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.1_existence_and_location_of_originals">http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.1_existence_and_location_of_originals</seealso>
    let ``isadOntology/isad_3.5.1_existence_and_location_of_originals`` =
        Prefixed_Name(reload, "isadOntology/isad_3.5.1_existence_and_location_of_originals") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.5.2_existence_and_location_of_copies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.2_existence_and_location_of_copies">http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.2_existence_and_location_of_copies</seealso>
    let ``isadOntology/isad_3.5.2_existence_and_location_of_copies`` =
        Prefixed_Name(reload, "isadOntology/isad_3.5.2_existence_and_location_of_copies") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.5.3_related_units_of_description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.3_related_units_of_description">http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.3_related_units_of_description</seealso>
    let ``isadOntology/isad_3.5.3_related_units_of_description`` =
        Prefixed_Name(reload, "isadOntology/isad_3.5.3_related_units_of_description") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.5.4_publication_note</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.4_publication_note">http://lod.xdams.org/reload/oad/isadOntology/isad_3.5.4_publication_note</seealso>
    let ``isadOntology/isad_3.5.4_publication_note`` =
        Prefixed_Name(reload, "isadOntology/isad_3.5.4_publication_note") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.6.1_note</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.6.1_note">http://lod.xdams.org/reload/oad/isadOntology/isad_3.6.1_note</seealso>
    let ``isadOntology/isad_3.6.1_note`` =
        Prefixed_Name(reload, "isadOntology/isad_3.6.1_note") |> PrefixedName

    /// <summary>
    ///   <para>reload:isadOntology/isad_3.7.1_archivist_s_note</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/isadOntology/isad_3.7.1_archivist_s_note">http://lod.xdams.org/reload/oad/isadOntology/isad_3.7.1_archivist_s_note</seealso>
    let ``isadOntology/isad_3.7.1_archivist_s_note`` =
        Prefixed_Name(reload, "isadOntology/isad_3.7.1_archivist_s_note") |> PrefixedName

    /// <summary>
    ///   <para>reload:levelOfDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/levelOfDescription">http://lod.xdams.org/reload/oad/levelOfDescription</seealso>
    let levelOfDescription = Prefixed_Name(reload, "levelOfDescription") |> PrefixedName
    /// <summary>
    ///   <para>reload:note</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/note">http://lod.xdams.org/reload/oad/note</seealso>
    let note = Prefixed_Name(reload, "note") |> PrefixedName
    /// <summary>
    ///   <para>reload:otherlevel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/otherlevel">http://lod.xdams.org/reload/oad/otherlevel</seealso>
    let otherlevel = Prefixed_Name(reload, "otherlevel") |> PrefixedName

    /// <summary>
    ///   <para>reload:physicalCharacteristicsAndTechnicalRequirements</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/physicalCharacteristicsAndTechnicalRequirements">http://lod.xdams.org/reload/oad/physicalCharacteristicsAndTechnicalRequirements</seealso>
    let physicalCharacteristicsAndTechnicalRequirements =
        Prefixed_Name(reload, "physicalCharacteristicsAndTechnicalRequirements") |> PrefixedName

    /// <summary>
    ///   <para>reload:place</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/place">http://lod.xdams.org/reload/oad/place</seealso>
    let place = Prefixed_Name(reload, "place") |> PrefixedName
    /// <summary>
    ///   <para>reload:production</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/production">http://lod.xdams.org/reload/oad/production</seealso>
    let production = Prefixed_Name(reload, "production") |> PrefixedName
    /// <summary>
    ///   <para>reload:publicationNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/publicationNote">http://lod.xdams.org/reload/oad/publicationNote</seealso>
    let publicationNote = Prefixed_Name(reload, "publicationNote") |> PrefixedName
    /// <summary>
    ///   <para>reload:referenceCode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/referenceCode">http://lod.xdams.org/reload/oad/referenceCode</seealso>
    let referenceCode = Prefixed_Name(reload, "referenceCode") |> PrefixedName
    /// <summary>
    ///   <para>reload:scopeAndContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/scopeAndContent">http://lod.xdams.org/reload/oad/scopeAndContent</seealso>
    let scopeAndContent = Prefixed_Name(reload, "scopeAndContent") |> PrefixedName

    /// <summary>
    ///   <para>reload:systemOfArrangement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/systemOfArrangement">http://lod.xdams.org/reload/oad/systemOfArrangement</seealso>
    let systemOfArrangement =
        Prefixed_Name(reload, "systemOfArrangement") |> PrefixedName

    /// <summary>
    ///   <para>reload:title</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/title">http://lod.xdams.org/reload/oad/title</seealso>
    let title = Prefixed_Name(reload, "title") |> PrefixedName
    /// <summary>
    ///   <para>reload:uod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/uod">http://lod.xdams.org/reload/oad/uod</seealso>
    let uod = Prefixed_Name(reload, "uod") |> PrefixedName
    /// <summary>
    ///   <para>reload:use_eadElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lod.xdams.org/reload/oad/use_eadElement">http://lod.xdams.org/reload/oad/use_eadElement</seealso>
    let use_eadElement = Prefixed_Name(reload, "use_eadElement") |> PrefixedName
