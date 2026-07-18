namespace https.w3id.org.arco.ontology.context_description.slash

open DoxAletheia.Rdf_Vocabulary

module cdesc =
    let _namespace_name = "https://w3id.org/arco/ontology/context-description/"

    /// <summary>
    /// This class represents an intervention on a cultural property, that is an activity carried out for its conservation or for other purposes: conservation interventions, reprocessing, restoring, etc.
    /// <see href="https://w3id.org/arco/ontology/context-description/Intervention"></see></summary>
    let Intervention =
        Namespaced_IRI.parse _namespace_name "Intervention" |> NamespacedName

    /// <summary>
    /// This class represents the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign). The research can be related to the observation survey on musical heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/Research"></see></summary>
    let Research = Namespaced_IRI.parse _namespace_name "Research" |> NamespacedName
    /// <summary>
    /// This class represents a survey carried out on a cultural property, that is an activity related to a cultural property and carried out for its identification, study or observation of its technical characteristics.
    /// <see href="https://w3id.org/arco/ontology/context-description/Survey"></see></summary>
    let Survey = Namespaced_IRI.parse _namespace_name "Survey" |> NamespacedName

    /// <summary>
    /// This class represents the type of acquisition (e.g. purchase, donation, etc.) of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/AcquisitionType"></see></summary>
    let AcquisitionType =
        Namespaced_IRI.parse _namespace_name "AcquisitionType" |> NamespacedName

    /// <summary>
    /// This class represents the type of alternative dating of a cultural property (different dating, obsolete dating, other method dating)
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeDatingType"></see></summary>
    let AlternativeDatingType =
        Namespaced_IRI.parse _namespace_name "AlternativeDatingType" |> NamespacedName

    /// <summary>
    /// This class represents the type of anomaly (line anomaly, point anomaly, polygon anomaly) observed during a photo interpretation or rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/AnomalyType"></see></summary>
    let AnomalyType =
        Namespaced_IRI.parse _namespace_name "AnomalyType" |> NamespacedName

    /// <summary>
    /// This class represents the type of archaeological property survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurveyType"></see></summary>
    let ArchaeologicalPropertySurveyType =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalPropertySurveyType" |> NamespacedName

    /// <summary>
    /// This class represents the type of archaeometric and diagnostic survey (e.g. coring)
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurveyType"></see></summary>
    let ArchaeometricDiagnosticSurveyType =
        Namespaced_IRI.parse _namespace_name "ArchaeometricDiagnosticSurveyType" |> NamespacedName

    /// <summary>
    /// This class represents the type of bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/BibliographyType"></see></summary>
    let BibliographyType =
        Namespaced_IRI.parse _namespace_name "BibliographyType" |> NamespacedName

    /// <summary>
    /// This class represents the type of change of availability of a cultural property (e.g. theft, distruction)
    /// <see href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailabilityType"></see></summary>
    let ChangeOfAvailabilityType =
        Namespaced_IRI.parse _namespace_name "ChangeOfAvailabilityType" |> NamespacedName

    /// <summary>
    /// This class represents the circumstance type (e.g.: civil, religious)
    /// This class represents the type of circumstance (e.g. civil, religious)
    /// <see href="https://w3id.org/arco/ontology/context-description/CircumstanceType"></see></summary>
    let CircumstanceType =
        Namespaced_IRI.parse _namespace_name "CircumstanceType" |> NamespacedName

    /// <summary>
    /// This class represents the type of derivated work of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/DerivatedWorkType"></see></summary>
    let DerivatedWorkType =
        Namespaced_IRI.parse _namespace_name "DerivatedWorkType" |> NamespacedName

    /// <summary>
    /// This class represents the type of documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/DocumentationType"></see></summary>
    let DocumentationType =
        Namespaced_IRI.parse _namespace_name "DocumentationType" |> NamespacedName

    /// <summary>
    /// This class represents the type of export/import certification of a cultural property (e.g.: temporary movement certification, temporary export license, free movement certification, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/ExportImportCertificationType"></see></summary>
    let ExportImportCertificationType =
        Namespaced_IRI.parse _namespace_name "ExportImportCertificationType" |> NamespacedName

    /// <summary>
    /// This class represents the type of intervention on a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/InterventionType"></see></summary>
    let InterventionType =
        Namespaced_IRI.parse _namespace_name "InterventionType" |> NamespacedName

    /// <summary>
    /// This class represents the type of laboratory test (es.: chemical analysis)
    /// <see href="https://w3id.org/arco/ontology/context-description/LaboratoryTestType"></see></summary>
    let LaboratoryTestType =
        Namespaced_IRI.parse _namespace_name "LaboratoryTestType" |> NamespacedName

    /// <summary>
    /// This class represents the type of observation survey (in the context / out of the context).
    /// <see href="https://w3id.org/arco/ontology/context-description/ObservationSurveyType"></see></summary>
    let ObservationSurveyType =
        Namespaced_IRI.parse _namespace_name "ObservationSurveyType" |> NamespacedName

    /// <summary>
    /// This class represents the type of responsibility related to the production and dissemination of photographic heritage (e.g.: printer, editor)
    /// <see href="https://w3id.org/arco/ontology/context-description/ResponsibilityType"></see></summary>
    let ResponsibilityType =
        Namespaced_IRI.parse _namespace_name "ResponsibilityType" |> NamespacedName

    /// <summary>
    /// This class represents the type of image analysed during a photo interpretation or rendering survey (aerial photograph, satellite photograph).
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyImageType"></see></summary>
    let SurveyImageType =
        Namespaced_IRI.parse _namespace_name "SurveyImageType" |> NamespacedName

    /// <summary>
    /// This class represents the type of an object title (e.g. original, alternative)
    /// <see href="https://w3id.org/arco/ontology/context-description/TitleType"></see></summary>
    let TitleType = Namespaced_IRI.parse _namespace_name "TitleType" |> NamespacedName
    /// <summary>
    /// This class represents the type of use of a cultural property (current, previous, historical)
    /// <see href="https://w3id.org/arco/ontology/context-description/UseType"></see></summary>
    let UseType = Namespaced_IRI.parse _namespace_name "UseType" |> NamespacedName

    /// <summary>
    /// This class represents the specification of the type of use of a cultural property (e.g. building, ornamental, structural, instrumental)
    /// <see href="https://w3id.org/arco/ontology/context-description/UseTypeSpecification"></see></summary>
    let UseTypeSpecification =
        Namespaced_IRI.parse _namespace_name "UseTypeSpecification" |> NamespacedName

    /// <summary>
    /// This class represents the membership of a cultural property in an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSetMembership"></see></summary>
    let ArchivalRecordSetMembership =
        Namespaced_IRI.parse _namespace_name "ArchivalRecordSetMembership" |> NamespacedName

    /// <summary>
    /// This class represents the membership of a cultural property in a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/CollectionMembership"></see></summary>
    let CollectionMembership =
        Namespaced_IRI.parse _namespace_name "CollectionMembership" |> NamespacedName

    /// <summary>
    /// This class represents the membership of photographic heritage in a photographic series, as a unit.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicSeriesMembership"></see></summary>
    let PhotographicSeriesMembership =
        Namespaced_IRI.parse _namespace_name "PhotographicSeriesMembership" |> NamespacedName

    /// <summary>
    /// This class represents the documentation format (e.g. jpeg, pdf, MP4)
    /// <see href="https://w3id.org/arco/ontology/context-description/Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName

    /// <summary>
    /// This class represents the criterion that motivated an interpretation (e.g. inscription, bibliography, documentation).
    /// <see href="https://w3id.org/arco/ontology/context-description/InterpretationCriterion"></see></summary>
    let InterpretationCriterion =
        Namespaced_IRI.parse _namespace_name "InterpretationCriterion" |> NamespacedName

    /// <summary>
    /// This class represents the main motivation of a survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyMotivation"></see></summary>
    let SurveyMotivation =
        Namespaced_IRI.parse _namespace_name "SurveyMotivation" |> NamespacedName

    /// <summary>
    /// This class represents the use of a cultural property, that can change over time, depending on the circumstances and on which parts of the cultural property are used.
    /// <see href="https://w3id.org/arco/ontology/context-description/Use"></see></summary>
    let Use = Namespaced_IRI.parse _namespace_name "Use" |> NamespacedName

    /// <summary>
    /// This class represents the category associated to a bibliography (e.g. accompanying bibliography, comparative bibliography, specific bibliography).
    /// <see href="https://w3id.org/arco/ontology/context-description/BibliographyCategory"></see></summary>
    let BibliographyCategory =
        Namespaced_IRI.parse _namespace_name "BibliographyCategory" |> NamespacedName

    /// <summary>
    /// This class represents the category associated to a documentation (e.g. attached documentation, existing documentation).
    /// <see href="https://w3id.org/arco/ontology/context-description/DocumentationCategory"></see></summary>
    let DocumentationCategory =
        Namespaced_IRI.parse _namespace_name "DocumentationCategory" |> NamespacedName

    /// <summary>
    /// This class represents the patrimonial code of a cultural property, referring to the SEC classification 1995.
    /// <see href="https://w3id.org/arco/ontology/context-description/SECIdentifier"></see></summary>
    let SECIdentifier =
        Namespaced_IRI.parse _namespace_name "SECIdentifier" |> NamespacedName

    /// <summary>
    /// This class represents the social category of a user (e.g. of a cultural property)
    /// <see href="https://w3id.org/arco/ontology/context-description/UserSocialCategory"></see></summary>
    let UserSocialCategory =
        Namespaced_IRI.parse _namespace_name "UserSocialCategory" |> NamespacedName

    /// <summary>
    /// This class represents an archival fonds.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalFonds"></see></summary>
    let ArchivalFonds =
        Namespaced_IRI.parse _namespace_name "ArchivalFonds" |> NamespacedName

    /// <summary>
    /// This class represents an archival series.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalSeries"></see></summary>
    let ArchivalSeries =
        Namespaced_IRI.parse _namespace_name "ArchivalSeries" |> NamespacedName

    /// <summary>
    /// This class represents an archival subseries, that is component of an archival series.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalSubseries"></see></summary>
    let ArchivalSubseries =
        Namespaced_IRI.parse _namespace_name "ArchivalSubseries" |> NamespacedName

    /// <summary>
    /// This class represents a situation in which a cultural property is acquired, passing from an owner to another, and has a particular legal situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/Acquisition"></see></summary>
    let Acquisition =
        Namespaced_IRI.parse _namespace_name "Acquisition" |> NamespacedName

    /// <summary>
    /// This class represents an anomaly detected during a photo interpretation or rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/Anomaly"></see></summary>
    let Anomaly = Namespaced_IRI.parse _namespace_name "Anomaly" |> NamespacedName

    /// <summary>
    /// This class represents the change of availability of a cultural property (e.g.: theft, distruction, rescue, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailability"></see></summary>
    let ChangeOfAvailability =
        Namespaced_IRI.parse _namespace_name "ChangeOfAvailability" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance that influenced a particular situation, e.g. the circumstance for which a cultural property was commissioned, tha circumstance in which a cultural property was used, etc.
    /// <see href="https://w3id.org/arco/ontology/context-description/Circumstance"></see></summary>
    let Circumstance =
        Namespaced_IRI.parse _namespace_name "Circumstance" |> NamespacedName

    /// <summary>
    /// This class represents the issuance of a coin, at a particular time and with different agents participanting to it (Mint, Issuing State, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/CoinIssuance"></see></summary>
    let CoinIssuance =
        Namespaced_IRI.parse _namespace_name "CoinIssuance" |> NamespacedName

    /// <summary>
    /// This class represents the export/import certification of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/ExportImportCertification"></see></summary>
    let ExportImportCertification =
        Namespaced_IRI.parse _namespace_name "ExportImportCertification" |> NamespacedName

    /// <summary>
    /// This class represents the legal situation of a cultural property, related to the owner.
    /// <see href="https://w3id.org/arco/ontology/context-description/LegalSituation"></see></summary>
    let LegalSituation =
        Namespaced_IRI.parse _namespace_name "LegalSituation" |> NamespacedName

    /// <summary>
    /// This class represents the concept of membership.
    /// <see href="https://w3id.org/arco/ontology/context-description/Membership"></see></summary>
    let Membership = Namespaced_IRI.parse _namespace_name "Membership" |> NamespacedName

    /// <summary>
    /// This class represents a situation in which a cultural property is related to another work, that could even be another cultural property. The cultural property stage is defined referring to this relationship with a related work, that can represent a preparatory, a final phase or a derivation of the cultural property. When the relationship is between two cultural properties, when possible, the nature of the relationship is specified (e.g.: finding location)
    /// <see href="https://w3id.org/arco/ontology/context-description/RelatedWorkSituation"></see></summary>
    let RelatedWorkSituation =
        Namespaced_IRI.parse _namespace_name "RelatedWorkSituation" |> NamespacedName

    /// <summary>
    /// This class represents one level of a biological taxon, the genus.
    /// <see href="https://w3id.org/arco/ontology/context-description/Genus"></see></summary>
    let Genus = Namespaced_IRI.parse _namespace_name "Genus" |> NamespacedName
    /// <summary>
    /// This class represents one level of a biological taxon, the species.
    /// <see href="https://w3id.org/arco/ontology/context-description/Species"></see></summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName
    /// <summary>
    /// This class represents one level of a biological taxon, the subspecies.
    /// <see href="https://w3id.org/arco/ontology/context-description/Subspecies"></see></summary>
    let Subspecies = Namespaced_IRI.parse _namespace_name "Subspecies" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an archaeological (stratigraphic) excavation.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalExcavation"></see></summary>
    let ArchaeologicalExcavation =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalExcavation" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an archaeological field survey, limited to the surface.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalFieldSurvey"></see></summary>
    let ArchaeologicalFieldSurvey =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalFieldSurvey" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is a survey on anthropological materials (e.g.: chemical analysis, histological analysis, CT scan, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurvey"></see></summary>
    let ArchaeologicalPropertySurvey =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalPropertySurvey" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an archaeometric and diagnostic survey (coring, geophysical prospecting, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurvey"></see></summary>
    let ArchaeometricDiagnosticSurvey =
        Namespaced_IRI.parse _namespace_name "ArchaeometricDiagnosticSurvey" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an inspection carried out to verify the condition of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Inspection"></see></summary>
    let Inspection = Namespaced_IRI.parse _namespace_name "Inspection" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is a laboratory test.
    /// <see href="https://w3id.org/arco/ontology/context-description/LaboratoryTest"></see></summary>
    let LaboratoryTest =
        Namespaced_IRI.parse _namespace_name "LaboratoryTest" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an observation survey: the observation of musical heritage or demoethnoanthropological heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/ObservationSurvey"></see></summary>
    let ObservationSurvey =
        Namespaced_IRI.parse _namespace_name "ObservationSurvey" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is a survey in which is possible to make a diagnosis of a paleopathology of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/context-description/PaleopathologySurvey"></see></summary>
    let PaleopathologySurvey =
        Namespaced_IRI.parse _namespace_name "PaleopathologySurvey" |> NamespacedName

    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is photo interpretation and rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotoInterpretationRendering"></see></summary>
    let PhotoInterpretationRendering =
        Namespaced_IRI.parse _namespace_name "PhotoInterpretationRendering" |> NamespacedName

    /// <summary>
    /// This class represents the patrimonial category of a cultural property, referring to the SEC classification 1995.
    /// <see href="https://w3id.org/arco/ontology/context-description/SECCategory"></see></summary>
    let SECCategory =
        Namespaced_IRI.parse _namespace_name "SECCategory" |> NamespacedName

    /// <summary>
    /// This class represents the archival record that is part of an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalRecord"></see></summary>
    let ArchivalRecord =
        Namespaced_IRI.parse _namespace_name "ArchivalRecord" |> NamespacedName

    /// <summary>
    /// This class represents the copyright of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Copyright"></see></summary>
    let Copyright = Namespaced_IRI.parse _namespace_name "Copyright" |> NamespacedName

    /// <summary>
    /// This class represents the reproduction of an image, that is, or was, part of a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/Reproduction"></see></summary>
    let Reproduction =
        Namespaced_IRI.parse _namespace_name "Reproduction" |> NamespacedName

    /// <summary>
    /// This class represents the representative scale of a graphic or cartographic documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/Scale"></see></summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName
    /// <summary>
    /// This class represents the title of an object, e.g. the title of the subject represented by a cultural property, or the title of a photographic series, etc.
    /// <see href="https://w3id.org/arco/ontology/context-description/Title"></see></summary>
    let Title = Namespaced_IRI.parse _namespace_name "Title" |> NamespacedName
    /// <summary>
    /// This class represents a tomb.
    /// <see href="https://w3id.org/arco/ontology/context-description/Tomb"></see></summary>
    let Tomb = Namespaced_IRI.parse _namespace_name "Tomb" |> NamespacedName

    /// <summary>
    /// This class represents the attribution of authorship or a responsibility for the creation of a cultural property, referring to the agents that played a role in the creation of the cultural property or to the reference cultural scope.
    /// <see href="https://w3id.org/arco/ontology/context-description/AuthorshipAttribution"></see></summary>
    let AuthorshipAttribution =
        Namespaced_IRI.parse _namespace_name "AuthorshipAttribution" |> NamespacedName

    /// <summary>
    /// This class represents the commission of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Commission"></see></summary>
    let Commission = Namespaced_IRI.parse _namespace_name "Commission" |> NamespacedName
    /// <summary>
    /// This class represents the dating of an entity, that is information about the chronology of the entity (e.g.: a cultural property), referring to a particular event (e.g.: the creation of the cultural property, its distruction, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Dating"></see></summary>
    let Dating = Namespaced_IRI.parse _namespace_name "Dating" |> NamespacedName
    /// <summary>
    /// This class represents the concept of estimate.
    /// <see href="https://w3id.org/arco/ontology/context-description/Estimate"></see></summary>
    let Estimate = Namespaced_IRI.parse _namespace_name "Estimate" |> NamespacedName
    /// <summary>
    /// This class represents a circumstance in which a garment, catalogued as a cultural property, was worn by one or more people.
    /// <see href="https://w3id.org/arco/ontology/context-description/Fruition"></see></summary>
    let Fruition = Namespaced_IRI.parse _namespace_name "Fruition" |> NamespacedName

    /// <summary>
    /// This class represents the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Responsibility"></see></summary>
    let Responsibility =
        Namespaced_IRI.parse _namespace_name "Responsibility" |> NamespacedName

    /// <summary>
    /// This individual represents the definition relative to the genre of bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/AccompanyingBibliography"></see></summary>
    let AccompanyingBibliography =
        Namespaced_IRI.parse _namespace_name "AccompanyingBibliography" |> NamespacedName

    /// <summary>
    /// This property relates an acquisition event to the cultural entity involved in the acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAcquisitionOf"></see></summary>
    let isAcquisitionOf =
        Namespaced_IRI.parse _namespace_name "isAcquisitionOf" |> NamespacedName

    /// <summary>
    /// This property relates the event of a cultural entity's acquisition to the agent which is the source of the acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPreviousOwner"></see></summary>
    let hasPreviousOwner =
        Namespaced_IRI.parse _namespace_name "hasPreviousOwner" |> NamespacedName

    /// <summary>
    /// This property represents the place where an acquisition event, generally expressed, based on the available data, took place, in the form: "Region / abbreviation province / full name of the Municipality / locality or toponym"
    /// <see href="https://w3id.org/arco/ontology/context-description/acquisitionLocation"></see></summary>
    let acquisitionLocation =
        Namespaced_IRI.parse _namespace_name "acquisitionLocation" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's acquisition to its acquisition type (i.e. donation, seizure).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAcquisitionType"></see></summary>
    let hasAcquisitionType =
        Namespaced_IRI.parse _namespace_name "hasAcquisitionType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/AerialPhotograph"></see>
    /// </summary>
    let AerialPhotograph =
        Namespaced_IRI.parse _namespace_name "AerialPhotograph" |> NamespacedName

    /// <summary>
    /// This class represents the interpretation of the age of death of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/context-description/AgeOfDeathInterpretation"></see></summary>
    let AgeOfDeathInterpretation =
        Namespaced_IRI.parse _namespace_name "AgeOfDeathInterpretation" |> NamespacedName

    /// <summary>
    /// This property represents an anthropological finding estimated age of death.
    /// <see href="https://w3id.org/arco/ontology/context-description/ageOfDeath"></see></summary>
    let ageOfDeath = Namespaced_IRI.parse _namespace_name "ageOfDeath" |> NamespacedName

    /// <summary>
    /// This property relates the age of death interpretation of an antropologic artifact to the its antropologic artifact.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAgeOfDeathInterpretationOf"></see></summary>
    let isAgeOfDeathInterpretationOf =
        Namespaced_IRI.parse _namespace_name "isAgeOfDeathInterpretationOf" |> NamespacedName

    /// <summary>
    /// This class represents a situation in which pieces of information related to an object (e.g.: a cultural property) are detected and recorded by an agent, based on a specific source or motivation (e.g.:ithe authorship attribution, commission, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Interpretation"></see></summary>
    let Interpretation =
        Namespaced_IRI.parse _namespace_name "Interpretation" |> NamespacedName

    /// <summary>
    /// This class represents an authorship attribution alternative to the preferred one.
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeAuthorshipAttribution"></see></summary>
    let AlternativeAuthorshipAttribution =
        Namespaced_IRI.parse _namespace_name "AlternativeAuthorshipAttribution" |> NamespacedName

    /// <summary>
    /// This property represents specifications relating to the intervention carried out by the author on the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/authorIntervention"></see></summary>
    let authorIntervention =
        Namespaced_IRI.parse _namespace_name "authorIntervention" |> NamespacedName

    /// <summary>
    /// This property relates a situation where an autorship is attributed to a cultural entity's author.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAttributedAuthor"></see></summary>
    let hasAttributedAuthor =
        Namespaced_IRI.parse _namespace_name "hasAttributedAuthor" |> NamespacedName

    /// <summary>
    /// This class represents an alternative dating of a cultural property (e.g.: an obsolete dating, a dating based on another method of dating).
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeDating"></see></summary>
    let AlternativeDating =
        Namespaced_IRI.parse _namespace_name "AlternativeDating" |> NamespacedName

    /// <summary>
    /// This property relates an alternative dating to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAlternativeDatingType"></see></summary>
    let hasAlternativeDatingType =
        Namespaced_IRI.parse _namespace_name "hasAlternativeDatingType" |> NamespacedName

    /// <summary>
    /// Represents subject's alternative title.
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeTitle"></see></summary>
    let AlternativeTitle =
        Namespaced_IRI.parse _namespace_name "AlternativeTitle" |> NamespacedName

    /// <summary>
    /// This property relates an anomaly detected during a photo interpretation or rendering survey to the origin of the anomaly (e.g. natural, unsure).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAnomalyOrigin"></see></summary>
    let hasAnomalyOrigin =
        Namespaced_IRI.parse _namespace_name "hasAnomalyOrigin" |> NamespacedName

    /// <summary>
    /// This class represents the anomaly origin of the photo interpretation rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/AnomalyOrigin"></see></summary>
    let AnomalyOrigin =
        Namespaced_IRI.parse _namespace_name "AnomalyOrigin" |> NamespacedName

    /// <summary>
    /// This property relates an anomaly revealed by a photo interepretation rendering to the related survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAnomalyOf"></see></summary>
    let isAnomalyOf =
        Namespaced_IRI.parse _namespace_name "isAnomalyOf" |> NamespacedName

    /// <summary>
    /// This property relates an anomaly revealed by a photo interpretation rendering to its anomaly type (line, point, poligony anomaly).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAnomalyType"></see></summary>
    let hasAnomalyType =
        Namespaced_IRI.parse _namespace_name "hasAnomalyType" |> NamespacedName

    /// <summary>
    /// This class represents the stage of the catalogued cultural property related to the object which constitutes its preparatory or final stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalPropertyStage"></see></summary>
    let CulturalPropertyStage =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/AnthropicOrigin"></see>
    /// </summary>
    let AnthropicOrigin =
        Namespaced_IRI.parse _namespace_name "AnthropicOrigin" |> NamespacedName

    /// <summary>
    /// This property relates an activity to the institution or the survey's responsible entity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasActivityResponsible"></see></summary>
    let hasActivityResponsible =
        Namespaced_IRI.parse _namespace_name "hasActivityResponsible" |> NamespacedName

    /// <summary>
    /// This property represents the identification code, numeric or alphanumeric, which identifies the archaeological excavation unambiguously in the context of a local repertoire.
    /// Questa proprietà rappresenta il codice identificativo, numerico o alfanumerico, che individua lo scavo archeologico in modo univoco nell'ambito di un repertorio locale.
    /// <see href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationLocalIdentifier"></see></summary>
    let archaeologicalExcavationLocalIdentifier =
        Namespaced_IRI.parse _namespace_name "archaeologicalExcavationLocalIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates a survey to its scientific director.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyScientificDirector"></see></summary>
    let hasSurveyScientificDirector =
        Namespaced_IRI.parse _namespace_name "hasSurveyScientificDirector" |> NamespacedName

    /// <summary>
    /// This property relates an archeological, archaeometric or diagnostic survey or a photo interpretation rendering to the the main motivation that led to it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyMotivation"></see></summary>
    let hasSurveyMotivation =
        Namespaced_IRI.parse _namespace_name "hasSurveyMotivation" |> NamespacedName

    /// <summary>
    /// This property relates a survey to the method adopted in the survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyMethod"></see></summary>
    let hasSurveyMethod =
        Namespaced_IRI.parse _namespace_name "hasSurveyMethod" |> NamespacedName

    /// <summary>
    /// This class represents the archeological survey method adopted.
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyMethod"></see></summary>
    let SurveyMethod =
        Namespaced_IRI.parse _namespace_name "SurveyMethod" |> NamespacedName

    /// <summary>
    /// This property relates an archaeological excavation to the tomb detected during the survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasTomb"></see></summary>
    let hasTomb = Namespaced_IRI.parse _namespace_name "hasTomb" |> NamespacedName

    /// <summary>
    /// This property represents the code, assigned by the ICCD, which identifies the archaeological excavation unequivocally at national level.
    /// <see href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationICCDIdentifier"></see></summary>
    let archaeologicalExcavationICCDIdentifier =
        Namespaced_IRI.parse _namespace_name "archaeologicalExcavationICCDIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates an archeological excavation to the stratigraphic unit from which a cultural property has been found.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasStratigraphicUnit"></see></summary>
    let hasStratigraphicUnit =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicUnit" |> NamespacedName

    /// <summary>
    /// This class represents a stratigraphic unit from which a cultural property may come from.
    /// <see href="https://w3id.org/arco/ontology/context-description/StratigraphicUnit"></see></summary>
    let StratigraphicUnit =
        Namespaced_IRI.parse _namespace_name "StratigraphicUnit" |> NamespacedName

    /// <summary>
    /// This property relates an archaeological excavation to the succession of the denominations, assigned in the excavation, to the sector (or
    /// the area), to the environment and to the square from which the good comes.
    /// <see href="https://w3id.org/arco/ontology/context-description/areaRoomSquare"></see></summary>
    let areaRoomSquare =
        Namespaced_IRI.parse _namespace_name "areaRoomSquare" |> NamespacedName

    /// <summary>
    /// This property represents the identification code, numeric or alphanumeric, which identifies the field survey unambiguously in the context of a local repertoire.
    /// <see href="https://w3id.org/arco/ontology/context-description/archeologicalFieldSurveyLocalIdentifier"></see></summary>
    let archeologicalFieldSurveyLocalIdentifier =
        Namespaced_IRI.parse _namespace_name "archeologicalFieldSurveyLocalIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents the code, assigned by the ICCD, which identifies the field survey unequivocally at national level.
    /// <see href="https://w3id.org/arco/ontology/context-description/archaeologicalFieldSurveyICCDIdentifier"></see></summary>
    let archaeologicalFieldSurveyICCDIdentifier =
        Namespaced_IRI.parse _namespace_name "archaeologicalFieldSurveyICCDIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates an archaeological survey to environmental situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/environmentalState"></see></summary>
    let environmentalState =
        Namespaced_IRI.parse _namespace_name "environmentalState" |> NamespacedName

    /// <summary>
    /// This property represents documentation relating to information collected during survey on anthropological evidence.
    /// <see href="https://w3id.org/arco/ontology/context-description/technicalDocumentation"></see></summary>
    let technicalDocumentation =
        Namespaced_IRI.parse _namespace_name "technicalDocumentation" |> NamespacedName

    /// <summary>
    /// This property relates a survey on an archaeological property to the type of survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchaeologicalPropertySurveyType"></see></summary>
    let hasArchaeologicalPropertySurveyType =
        Namespaced_IRI.parse _namespace_name "hasArchaeologicalPropertySurveyType" |> NamespacedName

    /// <summary>
    /// This property relates an arecheometric diagnostic survey to its type (i.e. thermal imaging, coring).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchaeometricDiagnosticSurveyType"></see></summary>
    let hasArchaeometricDiagnosticSurveyType =
        Namespaced_IRI.parse _namespace_name "hasArchaeometricDiagnosticSurveyType" |> NamespacedName

    /// <summary>
    /// This property relates an activity to the agent who performed the activity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasActivityOperator"></see></summary>
    let hasActivityOperator =
        Namespaced_IRI.parse _namespace_name "hasActivityOperator" |> NamespacedName

    /// <summary>
    /// This property represents the report of a anthropological finding's archaeometric and diagnostic investigation.
    /// ICCD Normativa Trasversale 4.00: RE/IND/INDT - ICCD Normativa AT 3.00: IN/INI/INIR
    /// <see href="https://w3id.org/arco/ontology/context-description/report"></see></summary>
    let report = Namespaced_IRI.parse _namespace_name "report" |> NamespacedName

    /// <summary>
    /// This property relates an activity to its investor. The investor may be an institution or an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasActivitySponsor"></see></summary>
    let hasActivitySponsor =
        Namespaced_IRI.parse _namespace_name "hasActivitySponsor" |> NamespacedName

    /// <summary>
    /// This class represents an archival record set (fonds, series, subseries) of which a cultural property can be member.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSet"></see></summary>
    let ArchivalRecordSet =
        Namespaced_IRI.parse _namespace_name "ArchivalRecordSet" |> NamespacedName

    /// <summary>
    /// This property represents the identifier of an archival record.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordIdentifier"></see></summary>
    let archivalRecordIdentifier =
        Namespaced_IRI.parse _namespace_name "archivalRecordIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates an object to its title.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasTitle"></see></summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName

    /// <summary>
    /// This property represents the identifier of an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordSetIdentifier"></see></summary>
    let archivalRecordSetIdentifier =
        Namespaced_IRI.parse _namespace_name "archivalRecordSetIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates the membership of a cultural entity to an archival record set. It is the inverse property of "isMemberofArchivalRecordSet".
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMemberOfArchivalRecordSet"></see></summary>
    let hasMemberOfArchivalRecordSet =
        Namespaced_IRI.parse _namespace_name "hasMemberOfArchivalRecordSet" |> NamespacedName

    /// <summary>
    /// This property represents the location of a documentary unit within a complex archival unit.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordLocation"></see></summary>
    let archivalRecordLocation =
        Namespaced_IRI.parse _namespace_name "archivalRecordLocation" |> NamespacedName

    /// <summary>
    /// This property relates the relationship of an archival set and a one of its belonging cultural entities.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchivalRecordSet"></see></summary>
    let hasArchivalRecordSet =
        Namespaced_IRI.parse _namespace_name "hasArchivalRecordSet" |> NamespacedName

    /// <summary>
    /// This property represents the title of the archival record set in which a documentary unit is located.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordSetTitle"></see></summary>
    let archivalRecordSetTitle =
        Namespaced_IRI.parse _namespace_name "archivalRecordSetTitle" |> NamespacedName

    /// <summary>
    /// This individual represents documenation definition included inside catalog.
    /// <see href="https://w3id.org/arco/ontology/context-description/AttachedDocumentation"></see></summary>
    let AttachedDocumentation =
        Namespaced_IRI.parse _namespace_name "AttachedDocumentation" |> NamespacedName

    /// <summary>
    /// Represents an attributed title of a photograph, that is a title taken from archival, bibliographic, oral or iconographic sources, or created based on picture contents.
    /// <see href="https://w3id.org/arco/ontology/context-description/AttributedTitle"></see></summary>
    let AttributedTitle =
        Namespaced_IRI.parse _namespace_name "AttributedTitle" |> NamespacedName

    /// <summary>
    /// This class represents the audio documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/AudioDocumentation"></see></summary>
    let AudioDocumentation =
        Namespaced_IRI.parse _namespace_name "AudioDocumentation" |> NamespacedName

    /// <summary>
    /// This class represents the documentation, with subclasses for each specific type of documentation (images, drawings, audio, video, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Documentation"></see></summary>
    let Documentation =
        Namespaced_IRI.parse _namespace_name "Documentation" |> NamespacedName

    /// <summary>
    /// This property relates the documentation to its format.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName

    /// <summary>
    /// Property that links an authorship attribution referred to a cultural entity to that cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAuthorshipAttributionOf"></see></summary>
    let isAuthorshipAttributionOf =
        Namespaced_IRI.parse _namespace_name "isAuthorshipAttributionOf" |> NamespacedName

    /// <summary>
    /// This property relates a situation, where a cultural scope is attributed to a cultural entity, to the cultural scope.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalScope"></see></summary>
    let hasCulturalScope =
        Namespaced_IRI.parse _namespace_name "hasCulturalScope" |> NamespacedName

    /// <summary>
    /// This class represents the cultural scope related to a cultural property (e.g.: neoclassical, Milanese manifacturing, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalScope"></see></summary>
    let CulturalScope =
        Namespaced_IRI.parse _namespace_name "CulturalScope" |> NamespacedName

    /// <summary>
    /// This property relates an entity described in a authority file to the file's cataloguing institution.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAuthorityFileCataloguingAgency"></see></summary>
    let hasAuthorityFileCataloguingAgency =
        Namespaced_IRI.parse _namespace_name "hasAuthorityFileCataloguingAgency" |> NamespacedName

    /// <summary>
    /// This property relates an authorship attribution to the agent's role.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInterventionRole"></see></summary>
    let hasInterventionRole =
        Namespaced_IRI.parse _namespace_name "hasInterventionRole" |> NamespacedName

    /// <summary>
    /// This class represents the bibliography of an entity, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Bibliography"></see></summary>
    let Bibliography =
        Namespaced_IRI.parse _namespace_name "Bibliography" |> NamespacedName

    /// <summary>
    /// This property represents the abbreviation that identifies the bibliographic reference.
    /// <see href="https://w3id.org/arco/ontology/context-description/abbreviation"></see></summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    /// This property relates a bibliography to the entity which is referred to.
    /// <see href="https://w3id.org/arco/ontology/context-description/isBibliographyOf"></see></summary>
    let isBibliographyOf =
        Namespaced_IRI.parse _namespace_name "isBibliographyOf" |> NamespacedName

    /// <summary>
    /// This property represents the complete bibliographic reference.
    /// <see href="https://w3id.org/arco/ontology/context-description/completeBibliographicReference"></see></summary>
    let completeBibliographicReference =
        Namespaced_IRI.parse _namespace_name "completeBibliographicReference" |> NamespacedName

    /// <summary>
    /// This property represents the code, assigned by the ICCD, which identifies the bibliographic reference uniquely at national level.
    /// <see href="https://w3id.org/arco/ontology/context-description/bibliographyICCDIdentifier"></see></summary>
    let bibliographyICCDIdentifier =
        Namespaced_IRI.parse _namespace_name "bibliographyICCDIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates a bibliography to its bibliography type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasBibliographyType"></see></summary>
    let hasBibliographyType =
        Namespaced_IRI.parse _namespace_name "hasBibliographyType" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its edition.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEdition"></see></summary>
    let hasEdition = Namespaced_IRI.parse _namespace_name "hasEdition" |> NamespacedName
    /// <summary>
    /// This class represents the edition of an entity (e.g. the print edition of a cultural property).
    /// <see href="https://w3id.org/arco/ontology/context-description/Edition"></see></summary>
    let Edition = Namespaced_IRI.parse _namespace_name "Edition" |> NamespacedName

    /// <summary>
    /// This class represents a biological taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/BiologicalTaxon"></see></summary>
    let BiologicalTaxon =
        Namespaced_IRI.parse _namespace_name "BiologicalTaxon" |> NamespacedName

    /// <summary>
    /// This property relates a biological taxon to the subspecies, that is one of the concept of the taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSpecies"></see></summary>
    let hasSpecies = Namespaced_IRI.parse _namespace_name "hasSpecies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isBiologicalTaxonOf"></see>
    /// </summary>
    let isBiologicalTaxonOf =
        Namespaced_IRI.parse _namespace_name "isBiologicalTaxonOf" |> NamespacedName

    /// <summary>
    /// This property relates a biological taxon to the genus, that is one of the concept of the taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasGenus"></see></summary>
    let hasGenus = Namespaced_IRI.parse _namespace_name "hasGenus" |> NamespacedName

    /// <summary>
    /// This property relates a biological taxon to the subspecies, that is one of the concept of the taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSubspecies"></see></summary>
    let hasSubspecies =
        Namespaced_IRI.parse _namespace_name "hasSubspecies" |> NamespacedName

    /// <summary>
    /// This individual represents cultural entity  building use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/BuildingUse"></see></summary>
    let BuildingUse =
        Namespaced_IRI.parse _namespace_name "BuildingUse" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's change of availability to the event type (i.e. theft, destruction, recovery).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailabilityType"></see></summary>
    let hasChangeOfAvailabilityType =
        Namespaced_IRI.parse _namespace_name "hasChangeOfAvailabilityType" |> NamespacedName

    /// <summary>
    /// This property relates a change of availability to a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityOf"></see></summary>
    let isChangeOfAvailabilityOf =
        Namespaced_IRI.parse _namespace_name "isChangeOfAvailabilityOf" |> NamespacedName

    /// <summary>
    /// This property relates the circumstance to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCircumstanceType"></see></summary>
    let hasCircumstanceType =
        Namespaced_IRI.parse _namespace_name "hasCircumstanceType" |> NamespacedName

    /// <summary>
    /// This property, inverse of 'has circumstance' relates the circumstance which led to a situation (e.g. a cultural entity committment, a cultural entity use, etc.) to the related situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCircumstanceOf"></see></summary>
    let isCircumstanceOf =
        Namespaced_IRI.parse _namespace_name "isCircumstanceOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/CivilCircumstance"></see>
    /// </summary>
    let CivilCircumstance =
        Namespaced_IRI.parse _namespace_name "CivilCircumstance" |> NamespacedName

    /// <summary>
    /// This property relates the coin issuance to the minter. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMinter"></see></summary>
    let hasMinter = Namespaced_IRI.parse _namespace_name "hasMinter" |> NamespacedName

    /// <summary>
    /// This property relates the coin issuance to the issuing State of that historic period. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIssuingState"></see></summary>
    let hasIssuingState =
        Namespaced_IRI.parse _namespace_name "hasIssuingState" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has coin issuance".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCoinIssuanceOf"></see></summary>
    let isCoinIssuanceOf =
        Namespaced_IRI.parse _namespace_name "isCoinIssuanceOf" |> NamespacedName

    /// <summary>
    /// This property relates the coin issuance to the Mint. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMint"></see></summary>
    let hasMint = Namespaced_IRI.parse _namespace_name "hasMint" |> NamespacedName
    /// <summary>
    /// This property relates to coin's issuance to the issuer agent. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIssuer"></see></summary>
    let hasIssuer = Namespaced_IRI.parse _namespace_name "hasIssuer" |> NamespacedName

    /// <summary>
    /// This property relates the membership of a movable cultural entity to a collection in a time interval. It is the inverse property of "isMemberofCollection".
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMemberOfCollection"></see></summary>
    let hasMemberOfCollection =
        Namespaced_IRI.parse _namespace_name "hasMemberOfCollection" |> NamespacedName

    /// <summary>
    /// This property represents the reason that led a cultural entity to the exit from a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/collectionLeavingReason"></see></summary>
    let collectionLeavingReason =
        Namespaced_IRI.parse _namespace_name "collectionLeavingReason" |> NamespacedName

    /// <summary>
    /// This property represents the inventory code assigned to the cultural entity inside a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/collectionUnitIdentifier"></see></summary>
    let collectionUnitIdentifier =
        Namespaced_IRI.parse _namespace_name "collectionUnitIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to the collection to which it belongs in a time span.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCollection"></see></summary>
    let hasCollection =
        Namespaced_IRI.parse _namespace_name "hasCollection" |> NamespacedName

    /// <summary>
    /// This property represents cultural entity's economic value.. The value is preceded by the currency specification.
    /// <see href="https://w3id.org/arco/ontology/context-description/estimatedCulturalPropertyValue"></see></summary>
    let estimatedCulturalPropertyValue =
        Namespaced_IRI.parse _namespace_name "estimatedCulturalPropertyValue" |> NamespacedName

    /// <summary>
    /// This property relates a situation where it is indicated a cultural entity's commission to the investor agent or institution.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCommittent"></see></summary>
    let hasCommittent =
        Namespaced_IRI.parse _namespace_name "hasCommittent" |> NamespacedName

    /// <summary>
    /// This property relates a situation to the circumstance which led to the situation. For example it can connect a situation where is indicated a cultural entity's committment to its circumstance.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCircumstance"></see></summary>
    let hasCircumstance =
        Namespaced_IRI.parse _namespace_name "hasCircumstance" |> NamespacedName

    /// <summary>
    /// This property relates a commission to the cultural entity that was commissioned.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCommissionOf"></see></summary>
    let isCommissionOf =
        Namespaced_IRI.parse _namespace_name "isCommissionOf" |> NamespacedName

    /// <summary>
    /// This individual represents the definition relative to the kind of bibliography used for comparisons.
    /// <see href="https://w3id.org/arco/ontology/context-description/ComparativeBibliography"></see></summary>
    let ComparativeBibliography =
        Namespaced_IRI.parse _namespace_name "ComparativeBibliography" |> NamespacedName

    /// <summary>
    /// This class represents a conservation intervention on a cultural property (e.g.: microclimatic inspection, mechanical cleaning or with chemicals, pest control, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/ConservationIntervention"></see></summary>
    let ConservationIntervention =
        Namespaced_IRI.parse _namespace_name "ConservationIntervention" |> NamespacedName

    /// <summary>
    /// This property represents the framework in which the restoration is carried out.
    /// <see href="https://w3id.org/arco/ontology/context-description/framework"></see></summary>
    let framework = Namespaced_IRI.parse _namespace_name "framework" |> NamespacedName
    /// <summary>
    /// This class represents the copy of a cultural property, e.g. a copy of a photography or a print.
    /// <see href="https://w3id.org/arco/ontology/context-description/Copy"></see></summary>
    let Copy = Namespaced_IRI.parse _namespace_name "Copy" |> NamespacedName

    /// <summary>
    /// This class represents a derivated work of a cultural property (copy, reuse, facsimile, forgery), created by the same author or by another author.
    /// <see href="https://w3id.org/arco/ontology/context-description/DerivatedWork"></see></summary>
    let DerivatedWork =
        Namespaced_IRI.parse _namespace_name "DerivatedWork" |> NamespacedName

    /// <summary>
    /// This property relates an entity's copyright to its copyright holder. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCopyrightHolder"></see></summary>
    let hasCopyrightHolder =
        Namespaced_IRI.parse _namespace_name "hasCopyrightHolder" |> NamespacedName

    /// <summary>
    /// This property represents an expiration date.
    /// <see href="https://w3id.org/arco/ontology/context-description/expiryDate"></see></summary>
    let expiryDate = Namespaced_IRI.parse _namespace_name "expiryDate" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "is copyright of".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCopyrightOf"></see></summary>
    let isCopyrightOf =
        Namespaced_IRI.parse _namespace_name "isCopyrightOf" |> NamespacedName

    /// <summary>
    /// This class represents the estimate of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalPropertyEstimate"></see></summary>
    let CulturalPropertyEstimate =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyEstimate" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property estimate to the estimated cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyEstimateOf"></see></summary>
    let isCulturalPropertyEstimateOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyEstimateOf" |> NamespacedName

    /// <summary>
    /// This cultural property relates the stage of a cultural property referring to another entity (preparatory or final work) to this relationship between the two entities.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyStageIn"></see></summary>
    let isCulturalPropertyStageIn =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyStageIn" |> NamespacedName

    /// <summary>
    /// This class represents the attribution of a cultural scope, to which the cultural property is related (e.g.: neoclassical, Milanese manifacturing, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalScopeAttribution"></see></summary>
    let CulturalScopeAttribution =
        Namespaced_IRI.parse _namespace_name "CulturalScopeAttribution" |> NamespacedName

    /// <summary>
    /// This property relates a cultural scope of a cultural entity to the situation where this cultural scope is attributed.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalScopeOf"></see></summary>
    let isCulturalScopeOf =
        Namespaced_IRI.parse _namespace_name "isCulturalScopeOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/CurrentInventory"></see>
    /// </summary>
    let CurrentInventory =
        Namespaced_IRI.parse _namespace_name "CurrentInventory" |> NamespacedName

    /// <summary>
    /// This property represents the code of the RCS causal (Central State Accounting Office) of increasing or decreasing property value.
    /// <see href="https://w3id.org/arco/ontology/context-description/RCSReason"></see></summary>
    let RCSReason = Namespaced_IRI.parse _namespace_name "RCSReason" |> NamespacedName

    /// <summary>
    /// This property relates a current inventory to the agent responsible for the cultural entity's inventory. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResponsibleForInsertion"></see></summary>
    let hasResponsibleForInsertion =
        Namespaced_IRI.parse _namespace_name "hasResponsibleForInsertion" |> NamespacedName

    /// <summary>
    /// This property represents how the cultural entity was inserted inside a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/methodOfInsertion"></see></summary>
    let methodOfInsertion =
        Namespaced_IRI.parse _namespace_name "methodOfInsertion" |> NamespacedName

    /// <summary>
    /// This class represents an inventory about a cultural property or about an entity or an activity related to the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Inventory"></see></summary>
    let Inventory = Namespaced_IRI.parse _namespace_name "Inventory" |> NamespacedName

    /// <summary>
    /// This property relates the current inventory to the patrimonial code of a cultural property, referring to the SEC classification 1995.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSECIdentifier"></see></summary>
    let hasSECIdentifier =
        Namespaced_IRI.parse _namespace_name "hasSECIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents origin of the cultural entity acquired in the heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/provenance"></see></summary>
    let provenance = Namespaced_IRI.parse _namespace_name "provenance" |> NamespacedName

    /// <summary>
    /// This property represents a cultural entity inventory description.
    /// <see href="https://w3id.org/arco/ontology/context-description/culturalPropertyInventoryDescription"></see></summary>
    let culturalPropertyInventoryDescription =
        Namespaced_IRI.parse _namespace_name "culturalPropertyInventoryDescription" |> NamespacedName

    /// <summary>
    /// This property relates a current inventory to the patrimonial category attributed to the cultural property based on the SEC classification.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSECCategory"></see></summary>
    let hasSECCategory =
        Namespaced_IRI.parse _namespace_name "hasSECCategory" |> NamespacedName

    /// <summary>
    /// This individual represents cultural entity current use.
    /// <see href="https://w3id.org/arco/ontology/context-description/CurrentUse"></see></summary>
    let CurrentUse = Namespaced_IRI.parse _namespace_name "CurrentUse" |> NamespacedName
    /// <summary>
    /// This property relates a dating to an entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDatingOf"></see></summary>
    let isDatingOf = Namespaced_IRI.parse _namespace_name "isDatingOf" |> NamespacedName

    /// <summary>
    /// This property relates a dating to an event involving the cultural property, which the dating is about.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDatingEvent"></see></summary>
    let hasDatingEvent =
        Namespaced_IRI.parse _namespace_name "hasDatingEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/DecentReliability"></see>
    /// </summary>
    let DecentReliability =
        Namespaced_IRI.parse _namespace_name "DecentReliability" |> NamespacedName

    /// <summary>
    /// This class represents the reliability level of detected information relative to photo interpretation rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/Reliability"></see></summary>
    let Reliability =
        Namespaced_IRI.parse _namespace_name "Reliability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/DeliveryConfirmationCertification"></see>
    /// </summary>
    let DeliveryConfirmationCertification =
        Namespaced_IRI.parse _namespace_name "DeliveryConfirmationCertification" |> NamespacedName

    /// <summary>
    /// This property relates a work derivated from a cultural entity to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDerivatedWorkType"></see></summary>
    let hasDerivatedWorkType =
        Namespaced_IRI.parse _namespace_name "hasDerivatedWorkType" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its author.
    /// This property relates a entity (i.e. documentation, cultural entity, etc.) to its author.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAuthor"></see></summary>
    let hasAuthor = Namespaced_IRI.parse _namespace_name "hasAuthor" |> NamespacedName

    /// <summary>
    /// This property represents derivated work's geographical and specific location.
    /// <see href="https://w3id.org/arco/ontology/context-description/derivatedWorkLocation"></see></summary>
    let derivatedWorkLocation =
        Namespaced_IRI.parse _namespace_name "derivatedWorkLocation" |> NamespacedName

    /// <summary>
    /// This class represents the method of detection that allowed the detection of a cultural property and which is indicative of the type and consistency of some information in the catalogue record that describes it (e.g.: coring, archive data, oral sources).
    /// <see href="https://w3id.org/arco/ontology/context-description/DetectionMethod"></see></summary>
    let DetectionMethod =
        Namespaced_IRI.parse _namespace_name "DetectionMethod" |> NamespacedName

    /// <summary>
    /// This property relates the detection method of a cultural property to the cultural property itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDetectionMethodOf"></see></summary>
    let isDetectionMethodOf =
        Namespaced_IRI.parse _namespace_name "isDetectionMethodOf" |> NamespacedName

    /// <summary>
    /// This individual represents a different type of dating than the one present in cultural entity's chronological information.
    /// <see href="https://w3id.org/arco/ontology/context-description/DifferentDating"></see></summary>
    let DifferentDating =
        Namespaced_IRI.parse _namespace_name "DifferentDating" |> NamespacedName

    /// <summary>
    /// This property represents a numeric or alphanumeric sequence that identifies the record to which the document refers.
    /// <see href="https://w3id.org/arco/ontology/context-description/documentationIdentifier"></see></summary>
    let documentationIdentifier =
        Namespaced_IRI.parse _namespace_name "documentationIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents the name of the digital file that reproduces the document.
    /// <see href="https://w3id.org/arco/ontology/context-description/digitalFilename"></see></summary>
    let digitalFilename =
        Namespaced_IRI.parse _namespace_name "digitalFilename" |> NamespacedName

    /// <summary>
    /// This property relates a documentation to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDocumentationType"></see></summary>
    let hasDocumentationType =
        Namespaced_IRI.parse _namespace_name "hasDocumentationType" |> NamespacedName

    /// <summary>
    /// This property relates a documentation to an entity. For example, it can relates a documentation concerning a cultural property described in a catalogue record to that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDocumentationOf"></see></summary>
    let isDocumentationOf =
        Namespaced_IRI.parse _namespace_name "isDocumentationOf" |> NamespacedName

    /// <summary>
    /// This property represents information on rights management.
    /// <see href="https://w3id.org/arco/ontology/context-description/rights"></see></summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName
    /// <summary>
    /// This property relates an edition to its editor.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEditor"></see></summary>
    let hasEditor = Namespaced_IRI.parse _namespace_name "hasEditor" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its secondary authors. For example an author of a publication's contribution or section.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSecondaryAuthor"></see></summary>
    let hasSecondaryAuthor =
        Namespaced_IRI.parse _namespace_name "hasSecondaryAuthor" |> NamespacedName

    /// <summary>
    /// This property represents work's edition place.
    /// <see href="https://w3id.org/arco/ontology/context-description/editionLocation"></see></summary>
    let editionLocation =
        Namespaced_IRI.parse _namespace_name "editionLocation" |> NamespacedName

    /// <summary>
    /// This property relates an entity's edition to the entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isEditionOf"></see></summary>
    let isEditionOf =
        Namespaced_IRI.parse _namespace_name "isEditionOf" |> NamespacedName

    /// <summary>
    /// This class represents the intervention considered eligible by a specific urban planning instrument related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/EligibleIntervention"></see></summary>
    let EligibleIntervention =
        Namespaced_IRI.parse _namespace_name "EligibleIntervention" |> NamespacedName

    /// <summary>
    /// This property, inverse of "has eligible intervention", relates an intervention to the urban planning instrument that finds eligible that intervention.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterventionEligibleBy"></see></summary>
    let isInterventionEligibleBy =
        Namespaced_IRI.parse _namespace_name "isInterventionEligibleBy" |> NamespacedName

    /// <summary>
    /// This class represents a urban planning instrument, related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/UrbanPlanningInstrument"></see></summary>
    let UrbanPlanningInstrument =
        Namespaced_IRI.parse _namespace_name "UrbanPlanningInstrument" |> NamespacedName

    /// <summary>
    /// This individual represents cultural entity's epigraphic use.
    /// <see href="https://w3id.org/arco/ontology/context-description/EpigraphicUse"></see></summary>
    let EpigraphicUse =
        Namespaced_IRI.parse _namespace_name "EpigraphicUse" |> NamespacedName

    /// <summary>
    /// This property represents the value estimated in the context of an estimate process.
    /// <see href="https://w3id.org/arco/ontology/context-description/estimatedValue"></see></summary>
    let estimatedValue =
        Namespaced_IRI.parse _namespace_name "estimatedValue" |> NamespacedName

    /// <summary>
    /// This property relates an estimate of an entity to that entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isEstimateOf"></see></summary>
    let isEstimateOf =
        Namespaced_IRI.parse _namespace_name "isEstimateOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/ExcellentReliability"></see>
    /// </summary>
    let ExcellentReliability =
        Namespaced_IRI.parse _namespace_name "ExcellentReliability" |> NamespacedName

    /// <summary>
    /// This individual represents documentation definition that is only mentioned.
    /// <see href="https://w3id.org/arco/ontology/context-description/ExistingDocumentation"></see></summary>
    let ExistingDocumentation =
        Namespaced_IRI.parse _namespace_name "ExistingDocumentation" |> NamespacedName

    /// <summary>
    /// This class represents an expired copyright, related to an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/ExpiredCopyright"></see></summary>
    let ExpiredCopyright =
        Namespaced_IRI.parse _namespace_name "ExpiredCopyright" |> NamespacedName

    /// <summary>
    /// This property relates a import-export certification of a cultural entity to its type (i.e. delivery confirmation certification, free movement certification etc).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasExportImportCertificationType"></see></summary>
    let hasExportImportCertificationType =
        Namespaced_IRI.parse _namespace_name "hasExportImportCertificationType" |> NamespacedName

    /// <summary>
    /// This property relates an export import certification to a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationOf"></see></summary>
    let isExportImportCertificationOf =
        Namespaced_IRI.parse _namespace_name "isExportImportCertificationOf" |> NamespacedName

    /// <summary>
    /// This property relates an export/import certification to the certifying Export Department.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasExportOffice"></see></summary>
    let hasExportOffice =
        Namespaced_IRI.parse _namespace_name "hasExportOffice" |> NamespacedName

    /// <summary>
    /// This class represents a facsimile of a cultural property, and in particular of a photography, that has the same format and technique.
    /// <see href="https://w3id.org/arco/ontology/context-description/Facsimile"></see></summary>
    let Facsimile = Namespaced_IRI.parse _namespace_name "Facsimile" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance related to fairs, markets, festivals.
    /// <see href="https://w3id.org/arco/ontology/context-description/FairMarketCircumstance"></see></summary>
    let FairMarketCircumstance =
        Namespaced_IRI.parse _namespace_name "FairMarketCircumstance" |> NamespacedName

    /// <summary>
    /// This class represents an indeterminate circumstance, when the cultural property is not related to a determinate circumstance, but takes place in an extemporaneous and contingent way (e.g.: a musical performance, a narration, a game).
    /// <see href="https://w3id.org/arco/ontology/context-description/IndeterminateCircumstance"></see></summary>
    let IndeterminateCircumstance =
        Namespaced_IRI.parse _namespace_name "IndeterminateCircumstance" |> NamespacedName

    /// <summary>
    /// This class represents the film documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/FilmDocumentation"></see></summary>
    let FilmDocumentation =
        Namespaced_IRI.parse _namespace_name "FilmDocumentation" |> NamespacedName

    /// <summary>
    /// This class represents an entity related to a cultural property, as its final stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/FinalWork"></see></summary>
    let FinalWork = Namespaced_IRI.parse _namespace_name "FinalWork" |> NamespacedName

    /// <summary>
    /// This class represents an entity related to a cultural property, that is its preparatory or final stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreparatoryOrFinalWork"></see></summary>
    let PreparatoryOrFinalWork =
        Namespaced_IRI.parse _namespace_name "PreparatoryOrFinalWork" |> NamespacedName

    /// <summary>
    /// This class represents an entity related to a cultural property, as its preparatory stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreparatoryWork"></see></summary>
    let PreparatoryWork =
        Namespaced_IRI.parse _namespace_name "PreparatoryWork" |> NamespacedName

    /// <summary>
    /// This class represents the context (type of context, associated objects) in which a cultural property (in particular, an anthropological material) is found.
    /// <see href="https://w3id.org/arco/ontology/context-description/FindingContext"></see></summary>
    let FindingContext =
        Namespaced_IRI.parse _namespace_name "FindingContext" |> NamespacedName

    /// <summary>
    /// This property relates a finding context of a cultural property (in particular, an anthropological material) to an object associated to the cultural property (e.g: earrings, shield, cloth, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAssociatedObject"></see></summary>
    let hasAssociatedObject =
        Namespaced_IRI.parse _namespace_name "hasAssociatedObject" |> NamespacedName

    /// <summary>
    /// This property relates the finding context of a cultural property, and in particular an anthropological material, to the related cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFindingContextOf"></see></summary>
    let isFindingContextOf =
        Namespaced_IRI.parse _namespace_name "isFindingContextOf" |> NamespacedName

    /// <summary>
    /// This class represents the type of finding context of a cultural property, and in particular of an anthropological material (e.g.: individual burial, common burial, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/FindingContextType"></see></summary>
    let FindingContextType =
        Namespaced_IRI.parse _namespace_name "FindingContextType" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property (anthropological material) finding context to the type of context.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFindingContextType"></see></summary>
    let hasFindingContextType =
        Namespaced_IRI.parse _namespace_name "hasFindingContextType" |> NamespacedName

    /// <summary>
    /// This class represents a forgery of a cultural property, that is a copy of a cultural property for which the author doesn't declare the original author.
    /// <see href="https://w3id.org/arco/ontology/context-description/Forgery"></see></summary>
    let Forgery = Namespaced_IRI.parse _namespace_name "Forgery" |> NamespacedName
    /// <summary>
    /// This property relates the format to the related documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFormatOf"></see></summary>
    let isFormatOf = Namespaced_IRI.parse _namespace_name "isFormatOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/FreeMovementCertification"></see>
    /// </summary>
    let FreeMovementCertification =
        Namespaced_IRI.parse _namespace_name "FreeMovementCertification" |> NamespacedName

    /// <summary>
    /// This property relates an entity to the user, intended as the agent who employed the entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUser"></see></summary>
    let hasUser = Namespaced_IRI.parse _namespace_name "hasUser" |> NamespacedName

    /// <summary>
    /// This property relates the fruition of a garment to that garment.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFruitionOf"></see></summary>
    let isFruitionOf =
        Namespaced_IRI.parse _namespace_name "isFruitionOf" |> NamespacedName

    /// <summary>
    /// This property relates a genus to the biological taxon in which it is classified.
    /// <see href="https://w3id.org/arco/ontology/context-description/isGenusIn"></see></summary>
    let isGenusIn = Namespaced_IRI.parse _namespace_name "isGenusIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/GoodReliability"></see>
    /// </summary>
    let GoodReliability =
        Namespaced_IRI.parse _namespace_name "GoodReliability" |> NamespacedName

    /// <summary>
    /// This class represents the graphic or cartographic documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/GraphicOrCartographicDocumentation"></see></summary>
    let GraphicOrCartographicDocumentation =
        Namespaced_IRI.parse _namespace_name "GraphicOrCartographicDocumentation" |> NamespacedName

    /// <summary>
    /// This property relates the graphic or cartographic documentation to its representation scale.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasScale"></see></summary>
    let hasScale = Namespaced_IRI.parse _namespace_name "hasScale" |> NamespacedName

    /// <summary>
    /// This individual represents cultural enity's historical use.
    /// <see href="https://w3id.org/arco/ontology/context-description/HistoricalUse"></see></summary>
    let HistoricalUse =
        Namespaced_IRI.parse _namespace_name "HistoricalUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/HistoricizedTitle"></see>
    /// </summary>
    let HistoricizedTitle =
        Namespaced_IRI.parse _namespace_name "HistoricizedTitle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/ImportConfirmationCertification"></see>
    /// </summary>
    let ImportConfirmationCertification =
        Namespaced_IRI.parse _namespace_name "ImportConfirmationCertification" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance related to production cycles (sericulture, cereal crop, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/ProductionCycleCircumstance"></see></summary>
    let ProductionCycleCircumstance =
        Namespaced_IRI.parse _namespace_name "ProductionCycleCircumstance" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance related to life cycles (ceremonies, custom, celebration)
    /// <see href="https://w3id.org/arco/ontology/context-description/LifeCycleCircumstance"></see></summary>
    let LifeCycleCircumstance =
        Namespaced_IRI.parse _namespace_name "LifeCycleCircumstance" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance related to social interaction (dances, pubs, wakes)
    /// <see href="https://w3id.org/arco/ontology/context-description/SocialInteractionCircumstance"></see></summary>
    let SocialInteractionCircumstance =
        Namespaced_IRI.parse _namespace_name "SocialInteractionCircumstance" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance related to work (e.g.: agriculture, bakery)
    /// <see href="https://w3id.org/arco/ontology/context-description/WorkCircumstance"></see></summary>
    let WorkCircumstance =
        Namespaced_IRI.parse _namespace_name "WorkCircumstance" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance related to year cycles (e.g.: autumnal equinox, New Year's Eve, Lent, Ramadan, carnival, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/YearCycleCircumstance"></see></summary>
    let YearCycleCircumstance =
        Namespaced_IRI.parse _namespace_name "YearCycleCircumstance" |> NamespacedName

    /// <summary>
    /// This class represents a circumstance related to seasonal cycles, referred to: subject of popular belief, myth, science; poetry, prose, songs, art, ritual; practical activities, behaviour, phenomena connected to specific cycles, days, months, seasons; fortunate or unfortunate days and periods.
    /// <see href="https://w3id.org/arco/ontology/context-description/SeasonCycleCircumstance"></see></summary>
    let SeasonCycleCircumstance =
        Namespaced_IRI.parse _namespace_name "SeasonCycleCircumstance" |> NamespacedName

    /// <summary>
    /// This individual represents cultural entity instrumental use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/InstrumentalUse"></see></summary>
    let InstrumentalUse =
        Namespaced_IRI.parse _namespace_name "InstrumentalUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/InsufficientReliability"></see>
    /// </summary>
    let InsufficientReliability =
        Namespaced_IRI.parse _namespace_name "InsufficientReliability" |> NamespacedName

    /// <summary>
    /// This property relates an authorship, dating, commission, or other interpretation situations, to the reason or criterion which led to that interpretation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInterpretationCriterion"></see></summary>
    let hasInterpretationCriterion =
        Namespaced_IRI.parse _namespace_name "hasInterpretationCriterion" |> NamespacedName

    /// <summary>
    /// This property relates an interpretation criterion to the interpretation that was based on that criterion.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterpretationCriterionOf"></see></summary>
    let isInterpretationCriterionOf =
        Namespaced_IRI.parse _namespace_name "isInterpretationCriterionOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isInterventionOn"></see>
    /// </summary>
    let isInterventionOn =
        Namespaced_IRI.parse _namespace_name "isInterventionOn" |> NamespacedName

    /// <summary>
    /// This property relates an intervention on a cultural property (i.e. conservation, interventions, reprocessing, restoring, etc.) to its intervention type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInterventionType"></see></summary>
    let hasInterventionType =
        Namespaced_IRI.parse _namespace_name "hasInterventionType" |> NamespacedName

    /// <summary>
    /// This property relates an inventory to the juridical container responsible for the inventory identifier of the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInventoryIdentifierResponsible"></see></summary>
    let hasInventoryIdentifierResponsible =
        Namespaced_IRI.parse _namespace_name "hasInventoryIdentifierResponsible" |> NamespacedName

    /// <summary>
    /// This property represents the location of the inventory about a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/inventoryLocation"></see></summary>
    let inventoryLocation =
        Namespaced_IRI.parse _namespace_name "inventoryLocation" |> NamespacedName

    /// <summary>
    /// This property relates an inventory to a cultural property or an entity or an activity related to it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInventoryOf"></see></summary>
    let isInventoryOf =
        Namespaced_IRI.parse _namespace_name "isInventoryOf" |> NamespacedName

    /// <summary>
    /// This property represents the inventory identifier attributed by a juridical container to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/inventoryIdentifier"></see></summary>
    let inventoryIdentifier =
        Namespaced_IRI.parse _namespace_name "inventoryIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents specifications on any significant components for the study of the entity, in case of analysis on clay findings.
    /// <see href="https://w3id.org/arco/ontology/context-description/claySpecifications"></see></summary>
    let claySpecifications =
        Namespaced_IRI.parse _namespace_name "claySpecifications" |> NamespacedName

    /// <summary>
    /// This property relates a laboratory test to its test type (i.e. chemical or metallurgical analysis).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasLaboratoryTestType"></see></summary>
    let hasLaboratoryTestType =
        Namespaced_IRI.parse _namespace_name "hasLaboratoryTestType" |> NamespacedName

    /// <summary>
    /// This property relates a legal situation to an entity that is in that situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLegalSituationOf"></see></summary>
    let isLegalSituationOf =
        Namespaced_IRI.parse _namespace_name "isLegalSituationOf" |> NamespacedName

    /// <summary>
    /// This property relates a legal situation to the owner of the object that is in that legal situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasOwner"></see></summary>
    let hasOwner = Namespaced_IRI.parse _namespace_name "hasOwner" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/LineAnomaly"></see>
    /// </summary>
    let LineAnomaly =
        Namespaced_IRI.parse _namespace_name "LineAnomaly" |> NamespacedName

    /// <summary>
    /// This individual represents publication main title.
    /// <see href="https://w3id.org/arco/ontology/context-description/MainTitle"></see></summary>
    let MainTitle = Namespaced_IRI.parse _namespace_name "MainTitle" |> NamespacedName

    /// <summary>
    /// This class represents the multimedia documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/MultimediaDocumentation"></see></summary>
    let MultimediaDocumentation =
        Namespaced_IRI.parse _namespace_name "MultimediaDocumentation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/NaturalOrigin"></see>
    /// </summary>
    let NaturalOrigin =
        Namespaced_IRI.parse _namespace_name "NaturalOrigin" |> NamespacedName

    /// <summary>
    /// This class represents a print that is no longer was a part of a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/NoLongerInPublication"></see></summary>
    let NoLongerInPublication =
        Namespaced_IRI.parse _namespace_name "NoLongerInPublication" |> NamespacedName

    /// <summary>
    /// This class represents the series which a particular coin is part of.
    /// <see href="https://w3id.org/arco/ontology/context-description/NumismaticSeries"></see></summary>
    let NumismaticSeries =
        Namespaced_IRI.parse _namespace_name "NumismaticSeries" |> NamespacedName

    /// <summary>
    /// This property relates a numismatic series to a coin that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCoinMember"></see></summary>
    let hasCoinMember =
        Namespaced_IRI.parse _namespace_name "hasCoinMember" |> NamespacedName

    /// <summary>
    /// This class relates an observation survey of musical or demoetnoanthropological heritage to the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign)
    /// <see href="https://w3id.org/arco/ontology/context-description/isRelatedToResearch"></see></summary>
    let isRelatedToResearch =
        Namespaced_IRI.parse _namespace_name "isRelatedToResearch" |> NamespacedName

    /// <summary>
    /// This property relates an observation survey of a demo-etno-antropologic entity to the professional photographer who took the shot. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyPhotographer"></see></summary>
    let hasSurveyPhotographer =
        Namespaced_IRI.parse _namespace_name "hasSurveyPhotographer" |> NamespacedName

    /// <summary>
    /// This property relates an observation survey to the type of observation survey (in the context, out of context).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasObservationSurveyType"></see></summary>
    let hasObservationSurveyType =
        Namespaced_IRI.parse _namespace_name "hasObservationSurveyType" |> NamespacedName

    /// <summary>
    /// This property relates an observation survey of a demo-etno-antropologic entity to the sound engineer who recorded it. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveySoundEngineer"></see></summary>
    let hasSurveySoundEngineer =
        Namespaced_IRI.parse _namespace_name "hasSurveySoundEngineer" |> NamespacedName

    /// <summary>
    /// This individual represents an obsolete dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/ObsoleteDating"></see></summary>
    let ObsoleteDating =
        Namespaced_IRI.parse _namespace_name "ObsoleteDating" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/OriginalTitle"></see>
    /// </summary>
    let OriginalTitle =
        Namespaced_IRI.parse _namespace_name "OriginalTitle" |> NamespacedName

    /// <summary>
    /// This individual represents cultural entity's ornamental use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/OrnamentalUse"></see></summary>
    let OrnamentalUse =
        Namespaced_IRI.parse _namespace_name "OrnamentalUse" |> NamespacedName

    /// <summary>
    /// This individual represents a different type of dating method than the one present in cultural entity's chronological information.
    /// <see href="https://w3id.org/arco/ontology/context-description/OtherMethodOfDating"></see></summary>
    let OtherMethodOfDating =
        Namespaced_IRI.parse _namespace_name "OtherMethodOfDating" |> NamespacedName

    /// <summary>
    /// This property represents the diagnosis of an anthropological finding paleopathology.
    /// <see href="https://w3id.org/arco/ontology/context-description/diagnosis"></see></summary>
    let diagnosis = Namespaced_IRI.parse _namespace_name "diagnosis" |> NamespacedName

    /// <summary>
    /// This property represents other investigations referred to in a survey aimed at developing a diagnosis of a paleopathology found in an anthropological finding.
    /// <see href="https://w3id.org/arco/ontology/context-description/refersToSurveys"></see></summary>
    let refersToSurveys =
        Namespaced_IRI.parse _namespace_name "refersToSurveys" |> NamespacedName

    /// <summary>
    /// I represents a parallel title, that is main title translated into other languages and presented as equivalent.
    /// <see href="https://w3id.org/arco/ontology/context-description/ParallelTitle"></see></summary>
    let ParallelTitle =
        Namespaced_IRI.parse _namespace_name "ParallelTitle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/PermanentExportLicense"></see>
    /// </summary>
    let PermanentExportLicense =
        Namespaced_IRI.parse _namespace_name "PermanentExportLicense" |> NamespacedName

    /// <summary>
    /// This property relates a photo interepretation rendering to an anomaly revealed by a survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAnomaly"></see></summary>
    let hasAnomaly = Namespaced_IRI.parse _namespace_name "hasAnomaly" |> NamespacedName

    /// <summary>
    /// This property relates a photo interpretation rendering survey to the reliability of the information collected during the survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReliability"></see></summary>
    let hasReliability =
        Namespaced_IRI.parse _namespace_name "hasReliability" |> NamespacedName

    /// <summary>
    /// This property relates a photo interpretation rendering to the survey image.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyImage"></see></summary>
    let hasSurveyImage =
        Namespaced_IRI.parse _namespace_name "hasSurveyImage" |> NamespacedName

    /// <summary>
    /// This class represents the image analysed during a photo interpretation or rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyImage"></see></summary>
    let SurveyImage =
        Namespaced_IRI.parse _namespace_name "SurveyImage" |> NamespacedName

    /// <summary>
    /// This property represents specifications to make overlaps with other documents useful for reading and interpreting image analyzed during a photointerpretation or photo-repayment.
    /// <see href="https://w3id.org/arco/ontology/context-description/overlapSpecifications"></see></summary>
    let overlapSpecifications =
        Namespaced_IRI.parse _namespace_name "overlapSpecifications" |> NamespacedName

    /// <summary>
    /// This class represents the photographic documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicDocumentation"></see></summary>
    let PhotographicDocumentation =
        Namespaced_IRI.parse _namespace_name "PhotographicDocumentation" |> NamespacedName

    /// <summary>
    /// This property represents a synthetic caption, useful for understanding what is documented.
    /// <see href="https://w3id.org/arco/ontology/context-description/caption"></see></summary>
    let caption = Namespaced_IRI.parse _namespace_name "caption" |> NamespacedName

    /// <summary>
    /// This property represents aerial photos information about run and frame.
    /// <see href="https://w3id.org/arco/ontology/context-description/stripRunAndFrameNumber"></see></summary>
    let stripRunAndFrameNumber =
        Namespaced_IRI.parse _namespace_name "stripRunAndFrameNumber" |> NamespacedName

    /// <summary>
    /// This class represents a photographic series, that is a set of photographs created or published as a unit, from a library sciences point of view.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicSeries"></see></summary>
    let PhotographicSeries =
        Namespaced_IRI.parse _namespace_name "PhotographicSeries" |> NamespacedName

    /// <summary>
    /// This class represents a photographic subseries, that is a component of a photographic series.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicSubseries"></see></summary>
    let PhotographicSubseries =
        Namespaced_IRI.parse _namespace_name "PhotographicSubseries" |> NamespacedName

    /// <summary>
    /// This property relates a photographic series to the class that represents the membership relation between this photographic series and a cultural property that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isPhotographicSeriesIn"></see></summary>
    let isPhotographicSeriesIn =
        Namespaced_IRI.parse _namespace_name "isPhotographicSeriesIn" |> NamespacedName

    /// <summary>
    /// This property represents numbering of the photograph within editorial photographic series.
    /// <see href="https://w3id.org/arco/ontology/context-description/photographicSeriesItemNumber"></see></summary>
    let photographicSeriesItemNumber =
        Namespaced_IRI.parse _namespace_name "photographicSeriesItemNumber" |> NamespacedName

    /// <summary>
    /// This property relates the membership of a cultural entity (e.g. photographic heritage) to its photographic series. It is the inverse property of "isMemberPhotographicSeries".
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMemberOfPhotographicSeries"></see></summary>
    let hasMemberOfPhotographicSeries =
        Namespaced_IRI.parse _namespace_name "hasMemberOfPhotographicSeries" |> NamespacedName

    /// <summary>
    /// This property relates a photographic series a the cultural entity which belongs to it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPhotographicSeries"></see></summary>
    let hasPhotographicSeries =
        Namespaced_IRI.parse _namespace_name "hasPhotographicSeries" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/PointAnomaly"></see>
    /// </summary>
    let PointAnomaly =
        Namespaced_IRI.parse _namespace_name "PointAnomaly" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/PolygonAnomaly"></see>
    /// </summary>
    let PolygonAnomaly =
        Namespaced_IRI.parse _namespace_name "PolygonAnomaly" |> NamespacedName

    /// <summary>
    /// This class represents the preferred authorship attribution, most accredited or convincing.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreferredAuthorshipAttribution"></see></summary>
    let PreferredAuthorshipAttribution =
        Namespaced_IRI.parse _namespace_name "PreferredAuthorshipAttribution" |> NamespacedName

    /// <summary>
    /// This property represents geographical location and specific location of the work derived from the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkLocation"></see></summary>
    let preparatoryOrFinalWorkLocation =
        Namespaced_IRI.parse _namespace_name "preparatoryOrFinalWorkLocation" |> NamespacedName

    /// <summary>
    /// This property represents information relating to ancient or previous location of the work from which the matrix or print is ​​drawn.
    /// <see href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkPreviousLocation"></see></summary>
    let preparatoryOrFinalWorkPreviousLocation =
        Namespaced_IRI.parse _namespace_name "preparatoryOrFinalWorkPreviousLocation" |> NamespacedName

    /// <summary>
    /// This property represents the code which identifies the record relating to the final or preparatory work in relation with the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkRecordIdentifier"></see></summary>
    let preparatoryOrFinalWorkRecordIdentifier =
        Namespaced_IRI.parse _namespace_name "preparatoryOrFinalWorkRecordIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property or an entity or an activity related to it to an inventory.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInventory"></see></summary>
    let hasInventory =
        Namespaced_IRI.parse _namespace_name "hasInventory" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDating"></see></summary>
    let hasDating = Namespaced_IRI.parse _namespace_name "hasDating" |> NamespacedName

    /// <summary>
    /// This individual represents cultural enity's previous use.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreviousUse"></see></summary>
    let PreviousUse =
        Namespaced_IRI.parse _namespace_name "PreviousUse" |> NamespacedName

    /// <summary>
    /// This class represents a publication of which a print is, or was, part.
    /// <see href="https://w3id.org/arco/ontology/context-description/PrintInPublication"></see></summary>
    let PrintInPublication =
        Namespaced_IRI.parse _namespace_name "PrintInPublication" |> NamespacedName

    /// <summary>
    /// This class represents the role of a cultural entity's user.
    /// <see href="https://w3id.org/arco/ontology/context-description/Profession"></see></summary>
    let Profession = Namespaced_IRI.parse _namespace_name "Profession" |> NamespacedName

    /// <summary>
    /// This class represents the use function of an object.
    /// <see href="https://w3id.org/arco/ontology/context-description/UseFunction"></see></summary>
    let UseFunction =
        Namespaced_IRI.parse _namespace_name "UseFunction" |> NamespacedName

    /// <summary>
    /// It represents the title proper to subject of a print, an engraved matrix or a photograph.
    /// <see href="https://w3id.org/arco/ontology/context-description/ProperTitle"></see></summary>
    let ProperTitle =
        Namespaced_IRI.parse _namespace_name "ProperTitle" |> NamespacedName

    /// <summary>
    /// This class represents the protective measure, national or international, related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/ProtectiveMeasure"></see></summary>
    let ProtectiveMeasure =
        Namespaced_IRI.parse _namespace_name "ProtectiveMeasure" |> NamespacedName

    /// <summary>
    /// This property represents the date of notification of the administrative provision to the owner.
    /// <see href="https://w3id.org/arco/ontology/context-description/noticeDate"></see></summary>
    let noticeDate = Namespaced_IRI.parse _namespace_name "noticeDate" |> NamespacedName

    /// <summary>
    /// This property relates an international or national protective measure to the cultural enitity to which it is applied.
    /// <see href="https://w3id.org/arco/ontology/context-description/isProtectiveMeasureOf"></see></summary>
    let isProtectiveMeasureOf =
        Namespaced_IRI.parse _namespace_name "isProtectiveMeasureOf" |> NamespacedName

    /// <summary>
    /// This property relates an entity (e.g a cultural entity or a cultual entity's protective measure) to the proposing institution. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasProponentAgency"></see></summary>
    let hasProponentAgency =
        Namespaced_IRI.parse _namespace_name "hasProponentAgency" |> NamespacedName

    /// <summary>
    /// This property represents the date of the registration or the number of the Official Journal on which the decree was published.
    /// <see href="https://w3id.org/arco/ontology/context-description/registrationDateOrGU"></see></summary>
    let registrationDateOrGU =
        Namespaced_IRI.parse _namespace_name "registrationDateOrGU" |> NamespacedName

    /// <summary>
    /// This property represents issue date of an administrative provision or a certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/issueDate"></see></summary>
    let issueDate = Namespaced_IRI.parse _namespace_name "issueDate" |> NamespacedName

    /// <summary>
    /// This property represents date of interest declaration communication to the owner or holder.
    /// <see href="https://w3id.org/arco/ontology/context-description/openingNoticeDate"></see></summary>
    let openingNoticeDate =
        Namespaced_IRI.parse _namespace_name "openingNoticeDate" |> NamespacedName

    /// <summary>
    /// This class represents the reference catalogue that cites the copy of a print.
    /// <see href="https://w3id.org/arco/ontology/context-description/ReferenceCatalogue"></see></summary>
    let ReferenceCatalogue =
        Namespaced_IRI.parse _namespace_name "ReferenceCatalogue" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has reference catalogue".
    /// <see href="https://w3id.org/arco/ontology/context-description/isReferenceCatalogueOf"></see></summary>
    let isReferenceCatalogueOf =
        Namespaced_IRI.parse _namespace_name "isReferenceCatalogueOf" |> NamespacedName

    /// <summary>
    /// This property relates the situation in which a cultural property is related to another work with the related work itself (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/involvesRelatedWork"></see></summary>
    let involvesRelatedWork =
        Namespaced_IRI.parse _namespace_name "involvesRelatedWork" |> NamespacedName

    /// <summary>
    /// This property relates the relatioship between a cultural property and a related work (preparatory or final work) to the stage of the cultural property referring to this related work.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyStage"></see></summary>
    let hasCulturalPropertyStage =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyStage" |> NamespacedName

    /// <summary>
    /// This property, inverse of 'has related work situation', relates a situation in which a cultural property is related to another work, that could even be another cultural property, to the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isRelatedWorkSituationOf"></see></summary>
    let isRelatedWorkSituationOf =
        Namespaced_IRI.parse _namespace_name "isRelatedWorkSituationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/ReligiousCircumstance"></see>
    /// </summary>
    let ReligiousCircumstance =
        Namespaced_IRI.parse _namespace_name "ReligiousCircumstance" |> NamespacedName

    /// <summary>
    /// This property relates the print reproduction in a publication to the position in the publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReproductionPosition"></see></summary>
    let hasReproductionPosition =
        Namespaced_IRI.parse _namespace_name "hasReproductionPosition" |> NamespacedName

    /// <summary>
    /// This class represents the phisical position of a printed reproduction in a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/ReproductionPosition"></see></summary>
    let ReproductionPosition =
        Namespaced_IRI.parse _namespace_name "ReproductionPosition" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has reproduction".
    /// <see href="https://w3id.org/arco/ontology/context-description/isReproductionOf"></see></summary>
    let isReproductionOf =
        Namespaced_IRI.parse _namespace_name "isReproductionOf" |> NamespacedName

    /// <summary>
    /// This property relates the position of the print reproduction in a publication to the print reproduction itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReproductionPositionOf"></see></summary>
    let isReproductionPositionOf =
        Namespaced_IRI.parse _namespace_name "isReproductionPositionOf" |> NamespacedName

    /// <summary>
    /// This property represents information about page number or table number of publication in which the print appears.
    /// <see href="https://w3id.org/arco/ontology/context-description/pageOrTableNumber"></see></summary>
    let pageOrTableNumber =
        Namespaced_IRI.parse _namespace_name "pageOrTableNumber" |> NamespacedName

    /// <summary>
    /// This property relates a research to the research's scientific responsible. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResearchScientificDirector"></see></summary>
    let hasResearchScientificDirector =
        Namespaced_IRI.parse _namespace_name "hasResearchScientificDirector" |> NamespacedName

    /// <summary>
    /// This property relates the responsibility's identification to the agent which has that specific responsibility, focusing on the production process and dissemination of the photographic heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAgentWithResponsibility"></see></summary>
    let hasAgentWithResponsibility =
        Namespaced_IRI.parse _namespace_name "hasAgentWithResponsibility" |> NamespacedName

    /// <summary>
    /// This property relates a resposibility relative to some production or disclosure process which characterise photographic artefacts, to its responsibility type (i.e. printers, retouchers).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResponsibilityType"></see></summary>
    let hasResponsibilityType =
        Namespaced_IRI.parse _namespace_name "hasResponsibilityType" |> NamespacedName

    /// <summary>
    /// This property relates the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.) to photographic heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResponsibilityFor"></see></summary>
    let isResponsibilityFor =
        Namespaced_IRI.parse _namespace_name "isResponsibilityFor" |> NamespacedName

    /// <summary>
    /// This class represents the reuse of a cultural property or of one of its parts.
    /// This class represents cultural entity's reuse.
    /// <see href="https://w3id.org/arco/ontology/context-description/Reuse"></see></summary>
    let Reuse = Namespaced_IRI.parse _namespace_name "Reuse" |> NamespacedName

    /// <summary>
    /// This class represents a copy of a cultural property created by the same author of the original cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/SameAuthorCopy"></see></summary>
    let SameAuthorCopy =
        Namespaced_IRI.parse _namespace_name "SameAuthorCopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/SatellitePhotograph"></see>
    /// </summary>
    let SatellitePhotograph =
        Namespaced_IRI.parse _namespace_name "SatellitePhotograph" |> NamespacedName

    /// <summary>
    /// This property relates the representation scale to its graphic or cartographic representation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isScaleOf"></see></summary>
    let isScaleOf = Namespaced_IRI.parse _namespace_name "isScaleOf" |> NamespacedName

    /// <summary>
    /// This individual represents publication's secondary title.
    /// <see href="https://w3id.org/arco/ontology/context-description/SecondaryTitle"></see></summary>
    let SecondaryTitle =
        Namespaced_IRI.parse _namespace_name "SecondaryTitle" |> NamespacedName

    /// <summary>
    /// This class represents the interpretation of the sex of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/context-description/SexInterpretation"></see></summary>
    let SexInterpretation =
        Namespaced_IRI.parse _namespace_name "SexInterpretation" |> NamespacedName

    /// <summary>
    /// This property represents anthropological finding estimated sex.
    /// <see href="https://w3id.org/arco/ontology/context-description/sex"></see></summary>
    let sex = Namespaced_IRI.parse _namespace_name "sex" |> NamespacedName

    /// <summary>
    /// This property relates the sex estimate of an antropologic artifact to the related artifact.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSexInterpretationOf"></see></summary>
    let isSexInterpretationOf =
        Namespaced_IRI.parse _namespace_name "isSexInterpretationOf" |> NamespacedName

    /// <summary>
    /// This class represents source and document related to an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/SourceAndDocument"></see></summary>
    let SourceAndDocument =
        Namespaced_IRI.parse _namespace_name "SourceAndDocument" |> NamespacedName

    /// <summary>
    /// This property represent document's folio number.
    /// <see href="https://w3id.org/arco/ontology/context-description/folio"></see></summary>
    let folio = Namespaced_IRI.parse _namespace_name "folio" |> NamespacedName

    /// <summary>
    /// This property relates a species to the biological taxon in which it is classified.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSpeciesIn"></see></summary>
    let isSpeciesIn =
        Namespaced_IRI.parse _namespace_name "isSpeciesIn" |> NamespacedName

    /// <summary>
    /// This individual represents the definition related to the kind of bibliography that specifically concerns the subject under examination.
    /// <see href="https://w3id.org/arco/ontology/context-description/SpecificBibliography"></see></summary>
    let SpecificBibliography =
        Namespaced_IRI.parse _namespace_name "SpecificBibliography" |> NamespacedName

    /// <summary>
    /// This property relates the stratigraphic unit from which a cultural property has been found to the related archeological excavation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isStratigraphicUnitOf"></see></summary>
    let isStratigraphicUnitOf =
        Namespaced_IRI.parse _namespace_name "isStratigraphicUnitOf" |> NamespacedName

    /// <summary>
    /// This individual represents cultural entity's structural use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/StructuralUse"></see></summary>
    let StructuralUse =
        Namespaced_IRI.parse _namespace_name "StructuralUse" |> NamespacedName

    /// <summary>
    /// This class represents the subject of a cultural property, or its ornamental motif.
    /// <see href="https://w3id.org/arco/ontology/context-description/Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName

    /// <summary>
    /// This property relates a subject or ornamental motif to the cultural property or to the final or preparatory work of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSubjectOf"></see></summary>
    let isSubjectOf =
        Namespaced_IRI.parse _namespace_name "isSubjectOf" |> NamespacedName

    /// <summary>
    /// This property relates a subspecies to the biological taxon in which it is classified.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSubspeciesIn"></see></summary>
    let isSubspeciesIn =
        Namespaced_IRI.parse _namespace_name "isSubspeciesIn" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's survey to the cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyOn"></see></summary>
    let isSurveyOn = Namespaced_IRI.parse _namespace_name "isSurveyOn" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has survey image".
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyImageOf"></see></summary>
    let isSurveyImageOf =
        Namespaced_IRI.parse _namespace_name "isSurveyImageOf" |> NamespacedName

    /// <summary>
    /// This property relates a survey image to its type (i.e. aerial photograph, Satellite photograph).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyImageType"></see></summary>
    let hasSurveyImageType =
        Namespaced_IRI.parse _namespace_name "hasSurveyImageType" |> NamespacedName

    /// <summary>
    /// This property represents the identification code that identifies the image examined during a photo-interpretation or photo-restoration investigation.
    /// <see href="https://w3id.org/arco/ontology/context-description/surveyImageIdentifier"></see></summary>
    let surveyImageIdentifier =
        Namespaced_IRI.parse _namespace_name "surveyImageIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates the method adopted in a survey to the survey itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyMethodOf"></see></summary>
    let isSurveyMethodOf =
        Namespaced_IRI.parse _namespace_name "isSurveyMethodOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isSurveyMotivationOf"></see>
    /// </summary>
    let isSurveyMotivationOf =
        Namespaced_IRI.parse _namespace_name "isSurveyMotivationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/TemporaryExportLicense"></see>
    /// </summary>
    let TemporaryExportLicense =
        Namespaced_IRI.parse _namespace_name "TemporaryExportLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/TemporaryMovementCertification"></see>
    /// </summary>
    let TemporaryMovementCertification =
        Namespaced_IRI.parse _namespace_name "TemporaryMovementCertification" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's title to its title type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasTitleType"></see></summary>
    let hasTitleType =
        Namespaced_IRI.parse _namespace_name "hasTitleType" |> NamespacedName

    /// <summary>
    /// This property relates a title to the entity to which it is referred.
    /// <see href="https://w3id.org/arco/ontology/context-description/isTitleOf"></see></summary>
    let isTitleOf = Namespaced_IRI.parse _namespace_name "isTitleOf" |> NamespacedName
    /// <summary>
    /// This is the inverse property of "has tomb".
    /// <see href="https://w3id.org/arco/ontology/context-description/isTombOf"></see></summary>
    let isTombOf = Namespaced_IRI.parse _namespace_name "isTombOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/UncertainOrigin"></see>
    /// </summary>
    let UncertainOrigin =
        Namespaced_IRI.parse _namespace_name "UncertainOrigin" |> NamespacedName

    /// <summary>
    /// This property relates an urban-planning instrument to the institution which issued the provision.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIssuingAgency"></see></summary>
    let hasIssuingAgency =
        Namespaced_IRI.parse _namespace_name "hasIssuingAgency" |> NamespacedName

    /// <summary>
    /// This property relates a urban planning instrument to the eligible intervention (e.g.: conservation intervention/ exceptional maintenance).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEligibleIntervention"></see></summary>
    let hasEligibleIntervention =
        Namespaced_IRI.parse _namespace_name "hasEligibleIntervention" |> NamespacedName

    /// <summary>
    /// This class relates a urban planning instrument to the related cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUrbanPlanningInstrumentOf"></see></summary>
    let isUrbanPlanningInstrumentOf =
        Namespaced_IRI.parse _namespace_name "isUrbanPlanningInstrumentOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/useConditions"></see>
    /// </summary>
    let useConditions =
        Namespaced_IRI.parse _namespace_name "useConditions" |> NamespacedName

    /// <summary>
    /// This property relates the use of a cultural entity to the related cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseOf"></see></summary>
    let isUseOf = Namespaced_IRI.parse _namespace_name "isUseOf" |> NamespacedName
    /// <summary>
    /// This property relates a cultural entity's use to its use type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUseType"></see></summary>
    let hasUseType = Namespaced_IRI.parse _namespace_name "hasUseType" |> NamespacedName

    /// <summary>
    /// This property represents object function.
    /// <see href="https://w3id.org/arco/ontology/context-description/useFunction"></see></summary>
    let useFunction =
        Namespaced_IRI.parse _namespace_name "useFunction" |> NamespacedName

    /// <summary>
    /// This property relates the use of a cultural property to the specification of the type of use.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUseTypeSpecification"></see></summary>
    let hasUseTypeSpecification =
        Namespaced_IRI.parse _namespace_name "hasUseTypeSpecification" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its use function.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUseFunction"></see></summary>
    let hasUseFunction =
        Namespaced_IRI.parse _namespace_name "hasUseFunction" |> NamespacedName

    /// <summary>
    /// This individual represents the lack of available data regarding the type of use of a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/UseTypeUnavailable"></see></summary>
    let UseTypeUnavailable =
        Namespaced_IRI.parse _namespace_name "UseTypeUnavailable" |> NamespacedName

    /// <summary>
    /// This property represents a specific type of contact at which the agent is available.
    /// <see href="https://w3id.org/arco/ontology/context-description/address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName
    /// <summary>
    /// This property represents contacts of an agent (i.e. email, telephone number...)
    /// <see href="https://w3id.org/arco/ontology/context-description/contacts"></see></summary>
    let contacts = Namespaced_IRI.parse _namespace_name "contacts" |> NamespacedName
    /// <summary>
    /// This property allows you to associate generic chronological indications to an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/agentDate"></see></summary>
    let agentDate = Namespaced_IRI.parse _namespace_name "agentDate" |> NamespacedName

    /// <summary>
    /// This property represents the identification code, which identifies the author's reference unambiguously in the context of a local repertoire, of an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/agentLocalIdentifier"></see></summary>
    let agentLocalIdentifier =
        Namespaced_IRI.parse _namespace_name "agentLocalIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents an entity's alternative title.
    /// <see href="https://w3id.org/arco/ontology/context-description/alternativeTitle"></see></summary>
    let alternativeTitle =
        Namespaced_IRI.parse _namespace_name "alternativeTitle" |> NamespacedName

    /// <summary>
    /// This property represents the title of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    /// This property represents an attributed title of a photograph, that is a title taken from archival, bibliographic, oral or iconographic sources, or created based on picture contents.
    /// <see href="https://w3id.org/arco/ontology/context-description/attributedTitle"></see></summary>
    let attributedTitle =
        Namespaced_IRI.parse _namespace_name "attributedTitle" |> NamespacedName

    /// <summary>
    /// This property allows you to associate the unique ICCD code with an author.
    /// <see href="https://w3id.org/arco/ontology/context-description/authorICCDIdentifier"></see></summary>
    let authorICCDIdentifier =
        Namespaced_IRI.parse _namespace_name "authorICCDIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents a numerical or alphanumeric sequence that uniquely identifies the bibliographic reference within a local repertoire.
    /// <see href="https://w3id.org/arco/ontology/context-description/bibliographyLocalIdentifier"></see></summary>
    let bibliographyLocalIdentifier =
        Namespaced_IRI.parse _namespace_name "bibliographyLocalIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents the collection identifier.
    /// <see href="https://w3id.org/arco/ontology/context-description/collectionIdentifier"></see></summary>
    let collectionIdentifier =
        Namespaced_IRI.parse _namespace_name "collectionIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents document location, which can also be expressed by inventory location or identifier.
    /// <see href="https://w3id.org/arco/ontology/context-description/documentationLocation"></see></summary>
    let documentationLocation =
        Namespaced_IRI.parse _namespace_name "documentationLocation" |> NamespacedName

    /// <summary>
    /// This property represents document title or denomination.
    /// <see href="https://w3id.org/arco/ontology/context-description/documentationTitle"></see></summary>
    let documentationTitle =
        Namespaced_IRI.parse _namespace_name "documentationTitle" |> NamespacedName

    /// <summary>
    /// This property represents a cultural asset interpretation.
    /// <see href="https://w3id.org/arco/ontology/context-description/explanationNote"></see></summary>
    let explanationNote =
        Namespaced_IRI.parse _namespace_name "explanationNote" |> NamespacedName

    /// <summary>
    /// This property represents notes relating to methods for identifying and finding the cultural property in question.
    /// <see href="https://w3id.org/arco/ontology/context-description/findingNote"></see></summary>
    let findingNote =
        Namespaced_IRI.parse _namespace_name "findingNote" |> NamespacedName

    /// <summary>
    /// This property relates a cultual property involved in an acquisition event to the actual acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAcquisition"></see></summary>
    let hasAcquisition =
        Namespaced_IRI.parse _namespace_name "hasAcquisition" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's acquisition type (i.e. donation, seizure) to its acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAcquisitionTypeOf"></see></summary>
    let isAcquisitionTypeOf =
        Namespaced_IRI.parse _namespace_name "isAcquisitionTypeOf" |> NamespacedName

    /// <summary>
    /// This property is used to associate an entity of any kind to an agent related to that entity in some way. It is used when it is not possible to express the relation in a more specific way.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasRelatedAgent"></see></summary>
    let hasRelatedAgent =
        Namespaced_IRI.parse _namespace_name "hasRelatedAgent" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has activity operator".
    /// <see href="https://w3id.org/arco/ontology/context-description/isActivityOperatorOf"></see></summary>
    let isActivityOperatorOf =
        Namespaced_IRI.parse _namespace_name "isActivityOperatorOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has activity responsible".
    /// <see href="https://w3id.org/arco/ontology/context-description/isActivityResponsibleOf"></see></summary>
    let isActivityResponsibleOf =
        Namespaced_IRI.parse _namespace_name "isActivityResponsibleOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has activity sponsor".
    /// <see href="https://w3id.org/arco/ontology/context-description/isActivitySponsorOf"></see></summary>
    let isActivitySponsorOf =
        Namespaced_IRI.parse _namespace_name "isActivitySponsorOf" |> NamespacedName

    /// <summary>
    /// This property relates an antropologic artifact to the interpretation of its age of death.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAgeOfDeathInterpretation"></see></summary>
    let hasAgeOfDeathInterpretation =
        Namespaced_IRI.parse _namespace_name "hasAgeOfDeathInterpretation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has agent with responsibility".
    /// <see href="https://w3id.org/arco/ontology/context-description/isAgentWithResponsibilityIn"></see></summary>
    let isAgentWithResponsibilityIn =
        Namespaced_IRI.parse _namespace_name "isAgentWithResponsibilityIn" |> NamespacedName

    /// <summary>
    /// This property relates the type of an alternative dating to the related dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAlternativeDatingTypeOf"></see></summary>
    let isAlternativeDatingTypeOf =
        Namespaced_IRI.parse _namespace_name "isAlternativeDatingTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the origin of the anomaly (e.g. natural, unsure) to an anomaly detected during a photo interpretation or rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAnomalyOriginOf"></see></summary>
    let isAnomalyOriginOf =
        Namespaced_IRI.parse _namespace_name "isAnomalyOriginOf" |> NamespacedName

    /// <summary>
    /// This property relates the anomaly type (line, point, poligony anomaly) to an anomaly revealed by a photo interpretation rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAnomalyTypeOf"></see></summary>
    let isAnomalyTypeOf =
        Namespaced_IRI.parse _namespace_name "isAnomalyTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the type of a survey to the related survey on an archaeological property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchaeologicalPropertySurveyTypeOf"></see></summary>
    let isArchaeologicalPropertySurveyTypeOf =
        Namespaced_IRI.parse _namespace_name "isArchaeologicalPropertySurveyTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the type of an arecheometric diagnostic survey (i.e. thermal imaging, coring) to the survey itself .
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchaeometricDiagnosticSurveyTypeOf"></see></summary>
    let isArchaeometricDiagnosticSurveyTypeOf =
        Namespaced_IRI.parse _namespace_name "isArchaeometricDiagnosticSurveyTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates an archival record set to the relationship (membership) between the set itself and a cultural property that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchivalRecordSetIn"></see></summary>
    let isArchivalRecordSetIn =
        Namespaced_IRI.parse _namespace_name "isArchivalRecordSetIn" |> NamespacedName

    /// <summary>
    /// This property relates the documentation made of sources and documents to the archive or conservative institution.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchive"></see></summary>
    let hasArchive = Namespaced_IRI.parse _namespace_name "hasArchive" |> NamespacedName

    /// <summary>
    /// This property relates the archive or conservative institution to the documentation made of sources and documents.
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchivedIn"></see></summary>
    let isArchivedIn =
        Namespaced_IRI.parse _namespace_name "isArchivedIn" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has associated object".
    /// <see href="https://w3id.org/arco/ontology/context-description/isObjectAssociatedTo"></see></summary>
    let isObjectAssociatedTo =
        Namespaced_IRI.parse _namespace_name "isObjectAssociatedTo" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has attributed author".
    /// <see href="https://w3id.org/arco/ontology/context-description/isAttributedAuthorIn"></see></summary>
    let isAttributedAuthorIn =
        Namespaced_IRI.parse _namespace_name "isAttributedAuthorIn" |> NamespacedName

    /// <summary>
    /// This property relates an agent to an entity the agent is author of.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAuthorOf"></see></summary>
    let isAuthorOf = Namespaced_IRI.parse _namespace_name "isAuthorOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to an authorship or resposibility attribution of the entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAuthorshipAttribution"></see></summary>
    let hasAuthorshipAttribution =
        Namespaced_IRI.parse _namespace_name "hasAuthorshipAttribution" |> NamespacedName

    /// <summary>
    /// This property relates the file's cataloguing institution to an entity described in a authority file.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAuthorityFileCataloguingAgencyOf"></see></summary>
    let isAuthorityFileCataloguingAgencyOf =
        Namespaced_IRI.parse _namespace_name "isAuthorityFileCataloguingAgencyOf" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasBibliography"></see></summary>
    let hasBibliography =
        Namespaced_IRI.parse _namespace_name "hasBibliography" |> NamespacedName

    /// <summary>
    /// This property relates the bibliography type to its bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/isBibliographyTypeOf"></see></summary>
    let isBibliographyTypeOf =
        Namespaced_IRI.parse _namespace_name "isBibliographyTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates a biological entity to a taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasBiologicalTaxon"></see></summary>
    let hasBiologicalTaxon =
        Namespaced_IRI.parse _namespace_name "hasBiologicalTaxon" |> NamespacedName

    /// <summary>
    /// This property relates a cultural enity involved in a change of availability event (i.e. theft, destruction, recovery) to the event.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailability"></see></summary>
    let hasChangeOfAvailability =
        Namespaced_IRI.parse _namespace_name "hasChangeOfAvailability" |> NamespacedName

    /// <summary>
    /// This property relates the event type (i.e. theft, destruction, recovery) of a cultural entity change of availability to the change itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityTypeOf"></see></summary>
    let isChangeOfAvailabilityTypeOf =
        Namespaced_IRI.parse _namespace_name "isChangeOfAvailabilityTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the type of circumstance to the related circumstance.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCircumstanceTypeOf"></see></summary>
    let isCircumstanceTypeOf =
        Namespaced_IRI.parse _namespace_name "isCircumstanceTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates a numismatic entity to its issuance.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCoinIssuance"></see></summary>
    let hasCoinIssuance =
        Namespaced_IRI.parse _namespace_name "hasCoinIssuance" |> NamespacedName

    /// <summary>
    /// This property relates a coin to a numismatic series which is member of.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCoinMemberOf"></see></summary>
    let isCoinMemberOf =
        Namespaced_IRI.parse _namespace_name "isCoinMemberOf" |> NamespacedName

    /// <summary>
    /// This property relates a collection to the relationship (membership) between the collection itself and a cultural property that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCollectionIn"></see></summary>
    let isCollectionIn =
        Namespaced_IRI.parse _namespace_name "isCollectionIn" |> NamespacedName

    /// <summary>
    /// This property relates a collection of cultural properties to its collector.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCollector"></see></summary>
    let hasCollector =
        Namespaced_IRI.parse _namespace_name "hasCollector" |> NamespacedName

    /// <summary>
    /// This property relates a collector to its collection of cultural properties.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCollectorOf"></see></summary>
    let isCollectorOf =
        Namespaced_IRI.parse _namespace_name "isCollectorOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to its commission.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCommission"></see></summary>
    let hasCommission =
        Namespaced_IRI.parse _namespace_name "hasCommission" |> NamespacedName

    /// <summary>
    /// This property relates an agent that is committent of a cultural property to the identification of the commission of that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCommittentIn"></see></summary>
    let isCommittentIn =
        Namespaced_IRI.parse _namespace_name "isCommittentIn" |> NamespacedName

    /// <summary>
    /// This property relates an entity to copiright held by an agent or its "public domain" condition, if it is out of copyright.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCopyright"></see></summary>
    let hasCopyright =
        Namespaced_IRI.parse _namespace_name "hasCopyright" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has copyright holder".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCopyrightHolderIn"></see></summary>
    let isCopyrightHolderIn =
        Namespaced_IRI.parse _namespace_name "isCopyrightHolderIn" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes its production site.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCreationLocation"></see></summary>
    let hasCreationLocation =
        Namespaced_IRI.parse _namespace_name "hasCreationLocation" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to a related work (e.g. copy, preparatory work).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasRelatedWork"></see></summary>
    let hasRelatedWork =
        Namespaced_IRI.parse _namespace_name "hasRelatedWork" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has creation location".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCreationLocationOf"></see></summary>
    let isCreationLocationOf =
        Namespaced_IRI.parse _namespace_name "isCreationLocationOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's use to its cultural geographical area.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalGeographicArea"></see></summary>
    let hasCulturalGeographicArea =
        Namespaced_IRI.parse _namespace_name "hasCulturalGeographicArea" |> NamespacedName

    /// <summary>
    /// This property relates a cultural geographical area to the use of the cultural property which is present.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalGeographicAreaOf"></see></summary>
    let isCulturalGeographicAreaOf =
        Namespaced_IRI.parse _namespace_name "isCulturalGeographicAreaOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to the estimate of that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyEstimate"></see></summary>
    let hasCulturalPropertyEstimate =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyEstimate" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its estimate.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEstimate"></see></summary>
    let hasEstimate =
        Namespaced_IRI.parse _namespace_name "hasEstimate" |> NamespacedName

    /// <summary>
    /// This property relates an event involving the cultural property, which the dating is about, to a dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDatingEventOf"></see></summary>
    let isDatingEventOf =
        Namespaced_IRI.parse _namespace_name "isDatingEventOf" |> NamespacedName

    /// <summary>
    /// This property relates the type of a work derivated from a cultural entity to its work derivated.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDerivatedWorkTypeOf"></see></summary>
    let isDerivatedWorkTypeOf =
        Namespaced_IRI.parse _namespace_name "isDerivatedWorkTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to the detection method that allowed the detection of the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDetectionMethod"></see></summary>
    let hasDetectionMethod =
        Namespaced_IRI.parse _namespace_name "hasDetectionMethod" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to the documentation related to the cutultural entity described in a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDocumentation"></see></summary>
    let hasDocumentation =
        Namespaced_IRI.parse _namespace_name "hasDocumentation" |> NamespacedName

    /// <summary>
    /// This property relates the type of documentation to its documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDocumentationTypeOf"></see></summary>
    let isDocumentationTypeOf =
        Namespaced_IRI.parse _namespace_name "isDocumentationTypeOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has editor".
    /// <see href="https://w3id.org/arco/ontology/context-description/isEditorOf"></see></summary>
    let isEditorOf = Namespaced_IRI.parse _namespace_name "isEditorOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to its import-export certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasExportImportCertification"></see></summary>
    let hasExportImportCertification =
        Namespaced_IRI.parse _namespace_name "hasExportImportCertification" |> NamespacedName

    /// <summary>
    /// This property relates the type (i.e. delivery confirmation certification, free movement certification etc) of an import-export certification of a cultural entity to the rrelated certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationTypeOf"></see></summary>
    let isExportImportCertificationTypeOf =
        Namespaced_IRI.parse _namespace_name "isExportImportCertificationTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates an export office to an export/import certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/isExportOfficeOf"></see></summary>
    let isExportOfficeOf =
        Namespaced_IRI.parse _namespace_name "isExportOfficeOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property, and in particular an anthropological material, to its finding context.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFindingContext"></see></summary>
    let hasFindingContext =
        Namespaced_IRI.parse _namespace_name "hasFindingContext" |> NamespacedName

    /// <summary>
    /// This property relates a type of cultural property (i.e. anthropological material) finding context to its context.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFindingContextTypeOf"></see></summary>
    let isFindingContextTypeOf =
        Namespaced_IRI.parse _namespace_name "isFindingContextTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes the site where it was rediscovered.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFindingLocation"></see></summary>
    let hasFindingLocation =
        Namespaced_IRI.parse _namespace_name "hasFindingLocation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has finding location".
    /// <see href="https://w3id.org/arco/ontology/context-description/isFindingLocationOf"></see></summary>
    let isFindingLocationOf =
        Namespaced_IRI.parse _namespace_name "isFindingLocationOf" |> NamespacedName

    /// <summary>
    /// This property relates garment to the context in which it has been worn.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFruition"></see></summary>
    let hasFruition =
        Namespaced_IRI.parse _namespace_name "hasFruition" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to a intervention on it, for conservational or other purposes.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIntervention"></see></summary>
    let hasIntervention =
        Namespaced_IRI.parse _namespace_name "hasIntervention" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has intervention role".
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterventionRoleIn"></see></summary>
    let isInterventionRoleIn =
        Namespaced_IRI.parse _namespace_name "isInterventionRoleIn" |> NamespacedName

    /// <summary>
    /// This property relates the type of intervention on a cultural property to the related intervention.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterventionTypeOf"></see></summary>
    let isInterventionTypeOf =
        Namespaced_IRI.parse _namespace_name "isInterventionTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the juridical container responsible for the inventory identifier of the cultural property to the inventory itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInventoryIdentifierResponsibleOf"></see></summary>
    let isInventoryIdentifierResponsibleOf =
        Namespaced_IRI.parse _namespace_name "isInventoryIdentifierResponsibleOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has issuer".
    /// <see href="https://w3id.org/arco/ontology/context-description/isIssuerIn"></see></summary>
    let isIssuerIn = Namespaced_IRI.parse _namespace_name "isIssuerIn" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has issuing agency".
    /// <see href="https://w3id.org/arco/ontology/context-description/isIssuingAgencyOf"></see></summary>
    let isIssuingAgencyOf =
        Namespaced_IRI.parse _namespace_name "isIssuingAgencyOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has issuing state".
    /// <see href="https://w3id.org/arco/ontology/context-description/isIssuingStateIn"></see></summary>
    let isIssuingStateIn =
        Namespaced_IRI.parse _namespace_name "isIssuingStateIn" |> NamespacedName

    /// <summary>
    /// This property relates the laboratory test type (i.e. chemical or metallurgical analysis) to the related laboratory test.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLaboratoryTestTypeOf"></see></summary>
    let isLaboratoryTestTypeOf =
        Namespaced_IRI.parse _namespace_name "isLaboratoryTestTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates an entity, for example a cultural entity, to its legal situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasLegalSituation"></see></summary>
    let hasLegalSituation =
        Namespaced_IRI.parse _namespace_name "hasLegalSituation" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to the class that represents the membership relation between this cultural property and an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/isMemberOfArchivalRecordSetOf"></see></summary>
    let isMemberOfArchivalRecordSetOf =
        Namespaced_IRI.parse _namespace_name "isMemberOfArchivalRecordSetOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isMemberOfCollectionOf"></see>
    /// </summary>
    let isMemberOfCollectionOf =
        Namespaced_IRI.parse _namespace_name "isMemberOfCollectionOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isMemberOfPhotographicSeriesIn"></see>
    /// </summary>
    let isMemberOfPhotographicSeriesIn =
        Namespaced_IRI.parse _namespace_name "isMemberOfPhotographicSeriesIn" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has mint".
    /// <see href="https://w3id.org/arco/ontology/context-description/isMintIn"></see></summary>
    let isMintIn = Namespaced_IRI.parse _namespace_name "isMintIn" |> NamespacedName
    /// <summary>
    /// This is the inverse property of "has minter".
    /// <see href="https://w3id.org/arco/ontology/context-description/isMinterIn"></see></summary>
    let isMinterIn = Namespaced_IRI.parse _namespace_name "isMinterIn" |> NamespacedName

    /// <summary>
    /// This property relates an musical instrument to the musical ensamble where the instument is (or were) played. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMusicalEnsemble"></see></summary>
    let hasMusicalEnsemble =
        Namespaced_IRI.parse _namespace_name "hasMusicalEnsemble" |> NamespacedName

    /// <summary>
    /// This property relates the musical ensamble where an instument is (or were) played to the related musical instrument.
    /// <see href="https://w3id.org/arco/ontology/context-description/isMusicalEnsembleOf"></see></summary>
    let isMusicalEnsembleOf =
        Namespaced_IRI.parse _namespace_name "isMusicalEnsembleOf" |> NamespacedName

    /// <summary>
    /// This property relates a musical instrument to the person who plays (in the present or past) a certain role as the instrument's exectutor. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMusician"></see></summary>
    let hasMusician =
        Namespaced_IRI.parse _namespace_name "hasMusician" |> NamespacedName

    /// <summary>
    /// This property relates the person who plays (in the present or past) a certain role as a musical instrument's exectutor to the related instrument.
    /// <see href="https://w3id.org/arco/ontology/context-description/isMusicianOf"></see></summary>
    let isMusicianOf =
        Namespaced_IRI.parse _namespace_name "isMusicianOf" |> NamespacedName

    /// <summary>
    /// This property relates the type of observation survey (in the context, out of context) to the related observation survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isObservationSurveyTypeOf"></see></summary>
    let isObservationSurveyTypeOf =
        Namespaced_IRI.parse _namespace_name "isObservationSurveyTypeOf" |> NamespacedName

    /// <summary>
    /// This class relates an agent, that is the owner of a cultural property, to the legal situation of that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isOwnerIn"></see></summary>
    let isOwnerIn = Namespaced_IRI.parse _namespace_name "isOwnerIn" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to another cultural entity, in an planning environmental relation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPlanningEnvironmentalRelationWith"></see></summary>
    let hasPlanningEnvironmentalRelationWith =
        Namespaced_IRI.parse _namespace_name "hasPlanningEnvironmentalRelationWith" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has related work".
    /// <see href="https://w3id.org/arco/ontology/context-description/isWorkRelatedTo"></see></summary>
    let isWorkRelatedTo =
        Namespaced_IRI.parse _namespace_name "isWorkRelatedTo" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes its provenance location before its current position.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPreviousLocation"></see></summary>
    let hasPreviousLocation =
        Namespaced_IRI.parse _namespace_name "hasPreviousLocation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has previous location".
    /// <see href="https://w3id.org/arco/ontology/context-description/isPreviousLocationOf"></see></summary>
    let isPreviousLocationOf =
        Namespaced_IRI.parse _namespace_name "isPreviousLocationOf" |> NamespacedName

    /// <summary>
    /// This property relates the previous owner of a cultural property to the acquisition by a new owner.
    /// <see href="https://w3id.org/arco/ontology/context-description/isPreviousOwnerOf"></see></summary>
    let isPreviousOwnerOf =
        Namespaced_IRI.parse _namespace_name "isPreviousOwnerOf" |> NamespacedName

    /// <summary>
    /// This property relates an intangible demoethnoanthropological property to its primary documentation, that is the documentation more representative of the intangible heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPrimaryDocumentation"></see></summary>
    let hasPrimaryDocumentation =
        Namespaced_IRI.parse _namespace_name "hasPrimaryDocumentation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has primary documentation".
    /// <see href="https://w3id.org/arco/ontology/context-description/isPrimaryDocumentationOf"></see></summary>
    let isPrimaryDocumentationOf =
        Namespaced_IRI.parse _namespace_name "isPrimaryDocumentationOf" |> NamespacedName

    /// <summary>
    /// This property relates an agent to its job. For example the agent responsible of the production of a cultual entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasProfession"></see></summary>
    let hasProfession =
        Namespaced_IRI.parse _namespace_name "hasProfession" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has profession".
    /// <see href="https://w3id.org/arco/ontology/context-description/isProfessionOf"></see></summary>
    let isProfessionOf =
        Namespaced_IRI.parse _namespace_name "isProfessionOf" |> NamespacedName

    /// <summary>
    /// This property relates an agent that is a proponent agency of a protective measure of a cultural property to the protective measure or to the cultural entity itself. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/context-description/isProponentAgencyOf"></see></summary>
    let isProponentAgencyOf =
        Namespaced_IRI.parse _namespace_name "isProponentAgencyOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/hasProtectiveMeasure"></see>
    /// </summary>
    let hasProtectiveMeasure =
        Namespaced_IRI.parse _namespace_name "hasProtectiveMeasure" |> NamespacedName

    /// <summary>
    /// This property relates a print's copy to its reference catalogue.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReferenceCatalogue"></see></summary>
    let hasReferenceCatalogue =
        Namespaced_IRI.parse _namespace_name "hasReferenceCatalogue" |> NamespacedName

    /// <summary>
    /// This property is used to associate an agent related in some way to an entity of any kind to that entity. It is used when it is not possible to express the relation in a more specific way.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAgentRelatedTo"></see></summary>
    let isAgentRelatedTo =
        Namespaced_IRI.parse _namespace_name "isAgentRelatedTo" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to a situation in which this cultural property is related to another work, that could even be another cultural property, as its preparatory or final phase.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasRelatedWorkSituation"></see></summary>
    let hasRelatedWorkSituation =
        Namespaced_IRI.parse _namespace_name "hasRelatedWorkSituation" |> NamespacedName

    /// <summary>
    /// This property relates the reliability of the information collected during the survey to a photo interpretation rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReliabilityOf"></see></summary>
    let isReliabilityOf =
        Namespaced_IRI.parse _namespace_name "isReliabilityOf" |> NamespacedName

    /// <summary>
    /// This property relates a publication to the print reproduction which is or was part of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReproduction"></see></summary>
    let hasReproduction =
        Namespaced_IRI.parse _namespace_name "hasReproduction" |> NamespacedName

    /// <summary>
    /// This property relates a culural entity to the research, which is the context where the enity's cataloguing record has been produced.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResearch"></see></summary>
    let hasResearch =
        Namespaced_IRI.parse _namespace_name "hasResearch" |> NamespacedName

    /// <summary>
    /// This property relates a research from which has been produced a cultural entity's catalogue record, to the cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResearchOn"></see></summary>
    let isResearchOn =
        Namespaced_IRI.parse _namespace_name "isResearchOn" |> NamespacedName

    /// <summary>
    /// This property relates the research's scientific responsible to its research.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResearchScientificDirectorOf"></see></summary>
    let isResearchScientificDirectorOf =
        Namespaced_IRI.parse _namespace_name "isResearchScientificDirectorOf" |> NamespacedName

    /// <summary>
    /// This property relates a photographic cultural entity (photography or photographic fond) to the responsibility attribution of an agent. The agent is in charge of the production or disclosure process which characterises photographic heritage (i.e. printers, editors, distributors, sposors, collection responsibles etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResponsibility"></see></summary>
    let hasResponsibility =
        Namespaced_IRI.parse _namespace_name "hasResponsibility" |> NamespacedName

    /// <summary>
    /// This property relates the esponsibility type (i.e. printers, retouchers) to the related resposibility relative to some production or disclosure process which characterise photographic artefacts.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResponsibilityTypeOf"></see></summary>
    let isResponsibilityTypeOf =
        Namespaced_IRI.parse _namespace_name "isResponsibilityTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the agent responsible for the cultural entity's inventory to the current inventory.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResponsibleForInsertionOf"></see></summary>
    let isResponsibleForInsertionOf =
        Namespaced_IRI.parse _namespace_name "isResponsibleForInsertionOf" |> NamespacedName

    /// <summary>
    /// This property relates the secondary authors of an entity (i.e. a publication's contribution or section) to the related entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSecondaryAuthorOf"></see></summary>
    let isSecondaryAuthorOf =
        Namespaced_IRI.parse _namespace_name "isSecondaryAuthorOf" |> NamespacedName

    /// <summary>
    /// This property relates an antropologic artifact to its sex estimate.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSexInterpretation"></see></summary>
    let hasSexInterpretation =
        Namespaced_IRI.parse _namespace_name "hasSexInterpretation" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property or a preparatory or final work of a cultural property to ist subject or ornamental motif.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSubject"></see></summary>
    let hasSubject = Namespaced_IRI.parse _namespace_name "hasSubject" |> NamespacedName
    /// <summary>
    /// This property relates a cultural entity's acquisition to its acquisition type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurvey"></see></summary>
    let hasSurvey = Namespaced_IRI.parse _namespace_name "hasSurvey" |> NamespacedName

    /// <summary>
    /// This property relates the type of a survey image (i.e. aerial photograph, Satellite photograph) to the related survey image.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyImageTypeOf"></see></summary>
    let isSurveyImageTypeOf =
        Namespaced_IRI.parse _namespace_name "isSurveyImageTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the professional photographer who took the shot to the observation survey of a demo-etno-antropologic entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyPhotographerOf"></see></summary>
    let isSurveyPhotographerOf =
        Namespaced_IRI.parse _namespace_name "isSurveyPhotographerOf" |> NamespacedName

    /// <summary>
    /// This property relates the scientific director of a survey to the related survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyScientificDirectorOf"></see></summary>
    let isSurveyScientificDirectorOf =
        Namespaced_IRI.parse _namespace_name "isSurveyScientificDirectorOf" |> NamespacedName

    /// <summary>
    /// This property relates the sound engineer who recorded an observation survey to the related observation survey of a demo-etno-antropologic entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveySoundEngineerOf"></see></summary>
    let isSurveySoundEngineerOf =
        Namespaced_IRI.parse _namespace_name "isSurveySoundEngineerOf" |> NamespacedName

    /// <summary>
    /// This property relates the type of a cultural entity title to its title.
    /// <see href="https://w3id.org/arco/ontology/context-description/isTitleTypeOf"></see></summary>
    let isTitleTypeOf =
        Namespaced_IRI.parse _namespace_name "isTitleTypeOf" |> NamespacedName

    /// <summary>
    /// This class relates a cultural property to the related urban planning instrument.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUrbanPlanningInstrument"></see></summary>
    let hasUrbanPlanningInstrument =
        Namespaced_IRI.parse _namespace_name "hasUrbanPlanningInstrument" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to its use.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUse"></see></summary>
    let hasUse = Namespaced_IRI.parse _namespace_name "hasUse" |> NamespacedName

    /// <summary>
    /// This property relates the use function of an entity to the related entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseFunctionOf"></see></summary>
    let isUseFunctionOf =
        Namespaced_IRI.parse _namespace_name "isUseFunctionOf" |> NamespacedName

    /// <summary>
    /// This property relates the type of a cultural entity use to its use.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseTypeOf"></see></summary>
    let isUseTypeOf =
        Namespaced_IRI.parse _namespace_name "isUseTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates the specification of the type of a cultural property use to the related use.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseTypeSpecificationOf"></see></summary>
    let isUseTypeSpecificationOf =
        Namespaced_IRI.parse _namespace_name "isUseTypeSpecificationOf" |> NamespacedName

    /// <summary>
    /// This property relates the user, intended as the agent who employed an entity, to the related entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUserOf"></see></summary>
    let isUserOf = Namespaced_IRI.parse _namespace_name "isUserOf" |> NamespacedName

    /// <summary>
    /// This property relates the user of a cultural property to its social category.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUserSocialCategory"></see></summary>
    let hasUserSocialCategory =
        Namespaced_IRI.parse _namespace_name "hasUserSocialCategory" |> NamespacedName

    /// <summary>
    /// This property represents historical biographical information about an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/historicalBiographicalInformation"></see></summary>
    let historicalBiographicalInformation =
        Namespaced_IRI.parse _namespace_name "historicalBiographicalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/historicalInformation"></see>
    /// </summary>
    let historicalInformation =
        Namespaced_IRI.parse _namespace_name "historicalInformation" |> NamespacedName

    /// <summary>
    /// This property represents the Iconclass code, for describing the subject or ornamental motif represented by the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/iconclassCode"></see></summary>
    let iconclassCode =
        Namespaced_IRI.parse _namespace_name "iconclassCode" |> NamespacedName

    /// <summary>
    /// This property represents information collected on the place where the cultural entity is located or on the place where it was detected.
    /// <see href="https://w3id.org/arco/ontology/context-description/informationGatheredOnSite"></see></summary>
    let informationGatheredOnSite =
        Namespaced_IRI.parse _namespace_name "informationGatheredOnSite" |> NamespacedName

    /// <summary>
    /// This is the inverse property of 'is involved in', which relates a cultural entity to another involved cultural entity (e.g. immaterial).
    /// <see href="https://w3id.org/arco/ontology/context-description/involves"></see></summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to another involved  cultural entity (e.g. immaterial).
    /// <see href="https://w3id.org/arco/ontology/context-description/isInvolvedIn"></see></summary>
    let isInvolvedIn =
        Namespaced_IRI.parse _namespace_name "isInvolvedIn" |> NamespacedName

    /// <summary>
    /// This property relates a work related to a cultural property (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.) to the situation in which that work is related to the cultural property itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isRelatedWorkInvolvedIn"></see></summary>
    let isRelatedWorkInvolvedIn =
        Namespaced_IRI.parse _namespace_name "isRelatedWorkInvolvedIn" |> NamespacedName

    /// <summary>
    /// This property represents the location of the asset in its environment, i.e. the place where it is stored when not in use.
    /// <see href="https://w3id.org/arco/ontology/context-description/isKeptIn"></see></summary>
    let isKeptIn = Namespaced_IRI.parse _namespace_name "isKeptIn" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes its location area.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLocatedIn"></see></summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    /// This property, inverse of 'is located in', relates a cultural entity to a connected cultural entity, which constitutes its location area.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLocationOf"></see></summary>
    let isLocationOf =
        Namespaced_IRI.parse _namespace_name "isLocationOf" |> NamespacedName

    /// <summary>
    /// This property relates a print to the reproduction of that print in a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReproducedBy"></see></summary>
    let isReproducedBy =
        Namespaced_IRI.parse _namespace_name "isReproducedBy" |> NamespacedName

    /// <summary>
    /// This property relates the reproduction of an print in a publication to the print itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/reproduces"></see></summary>
    let reproduces = Namespaced_IRI.parse _namespace_name "reproduces" |> NamespacedName
    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity that reuse it or a part of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReusedBy"></see></summary>
    let isReusedBy = Namespaced_IRI.parse _namespace_name "isReusedBy" |> NamespacedName
    /// <summary>
    /// This is the invers property of 'is reused by', which relates a cultural entity to a connected cultural entity that reuse it or a part of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/reuses"></see></summary>
    let reuses = Namespaced_IRI.parse _namespace_name "reuses" |> NamespacedName

    /// <summary>
    /// This property represents photograph copies numbering.
    /// <see href="https://w3id.org/arco/ontology/context-description/numberInCirculation"></see></summary>
    let numberInCirculation =
        Namespaced_IRI.parse _namespace_name "numberInCirculation" |> NamespacedName

    /// <summary>
    /// This property represents the parallel title of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/parallelTitle"></see></summary>
    let parallelTitle =
        Namespaced_IRI.parse _namespace_name "parallelTitle" |> NamespacedName

    /// <summary>
    /// This property represents numbering of the photograph within the editorial photographic subseries.
    /// <see href="https://w3id.org/arco/ontology/context-description/photographicSubseriesItemNumber"></see></summary>
    let photographicSubseriesItemNumber =
        Namespaced_IRI.parse _namespace_name "photographicSubseriesItemNumber" |> NamespacedName

    /// <summary>
    /// This property represents the proper title of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/properTitle"></see></summary>
    let properTitle =
        Namespaced_IRI.parse _namespace_name "properTitle" |> NamespacedName

    /// <summary>
    /// This property represents general notes on the relationships established between the property in question and other works.
    /// <see href="https://w3id.org/arco/ontology/context-description/relatedWorkNote"></see></summary>
    let relatedWorkNote =
        Namespaced_IRI.parse _namespace_name "relatedWorkNote" |> NamespacedName

    /// <summary>
    /// This property represents any references to documents that affect cultural entity acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/relevantLegalAct"></see></summary>
    let relevantLegalAct =
        Namespaced_IRI.parse _namespace_name "relevantLegalAct" |> NamespacedName

    /// <summary>
    /// This property relates the event (creation, distruction) to which a dating of a cultural property is related to the "specific time", as the dating expressed in year or as a date yyyy/mm/dd.
    /// <see href="https://w3id.org/arco/ontology/context-description/specificTime"></see></summary>
    let specificTime =
        Namespaced_IRI.parse _namespace_name "specificTime" |> NamespacedName

    /// <summary>
    /// This property relates the "specific time", as the dating expressed in year or as a date yyyy/mm/dd, with the event (creation, distruction) to which a dating of a cultural property is related to.
    /// <see href="https://w3id.org/arco/ontology/context-description/specificTimeOf"></see></summary>
    let specificTimeOf =
        Namespaced_IRI.parse _namespace_name "specificTimeOf" |> NamespacedName

    /// <summary>
    /// This property represents the subject of a cultural property, or its ornamental motif.
    /// <see href="https://w3id.org/arco/ontology/context-description/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName

    /// <summary>
    /// This property represents the author that described the species and the date of description.
    /// <see href="https://w3id.org/arco/ontology/context-description/taxonAuthorAndDate"></see></summary>
    let taxonAuthorAndDate =
        Namespaced_IRI.parse _namespace_name "taxonAuthorAndDate" |> NamespacedName
