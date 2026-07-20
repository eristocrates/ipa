namespace https.w3id.org.arco.ontology.context_description.slash

open DoxAletheia

module cdesc =
    let _namespace_name = "https://w3id.org/arco/ontology/context-description/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents an intervention on a cultural property, that is an activity carried out for its conservation or for other purposes: conservation interventions, reprocessing, restoring, etc.
    /// <see href="https://w3id.org/arco/ontology/context-description/Intervention"></see></summary>
    let Intervention = _prefix "Intervention"
    /// <summary>
    /// This class represents the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign). The research can be related to the observation survey on musical heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/Research"></see></summary>
    let Research = _prefix "Research"
    /// <summary>
    /// This class represents a survey carried out on a cultural property, that is an activity related to a cultural property and carried out for its identification, study or observation of its technical characteristics.
    /// <see href="https://w3id.org/arco/ontology/context-description/Survey"></see></summary>
    let Survey = _prefix "Survey"
    /// <summary>
    /// This class represents the type of acquisition (e.g. purchase, donation, etc.) of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/AcquisitionType"></see></summary>
    let AcquisitionType = _prefix "AcquisitionType"
    /// <summary>
    /// This class represents the type of alternative dating of a cultural property (different dating, obsolete dating, other method dating)
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeDatingType"></see></summary>
    let AlternativeDatingType = _prefix "AlternativeDatingType"
    /// <summary>
    /// This class represents the type of anomaly (line anomaly, point anomaly, polygon anomaly) observed during a photo interpretation or rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/AnomalyType"></see></summary>
    let AnomalyType = _prefix "AnomalyType"
    /// <summary>
    /// This class represents the type of archaeological property survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurveyType"></see></summary>
    let ArchaeologicalPropertySurveyType = _prefix "ArchaeologicalPropertySurveyType"
    /// <summary>
    /// This class represents the type of archaeometric and diagnostic survey (e.g. coring)
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurveyType"></see></summary>
    let ArchaeometricDiagnosticSurveyType = _prefix "ArchaeometricDiagnosticSurveyType"
    /// <summary>
    /// This class represents the type of bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/BibliographyType"></see></summary>
    let BibliographyType = _prefix "BibliographyType"
    /// <summary>
    /// This class represents the type of change of availability of a cultural property (e.g. theft, distruction)
    /// <see href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailabilityType"></see></summary>
    let ChangeOfAvailabilityType = _prefix "ChangeOfAvailabilityType"
    /// <summary>
    /// This class represents the circumstance type (e.g.: civil, religious)
    /// This class represents the type of circumstance (e.g. civil, religious)
    /// <see href="https://w3id.org/arco/ontology/context-description/CircumstanceType"></see></summary>
    let CircumstanceType = _prefix "CircumstanceType"
    /// <summary>
    /// This class represents the type of derivated work of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/DerivatedWorkType"></see></summary>
    let DerivatedWorkType = _prefix "DerivatedWorkType"
    /// <summary>
    /// This class represents the type of documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/DocumentationType"></see></summary>
    let DocumentationType = _prefix "DocumentationType"
    /// <summary>
    /// This class represents the type of export/import certification of a cultural property (e.g.: temporary movement certification, temporary export license, free movement certification, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/ExportImportCertificationType"></see></summary>
    let ExportImportCertificationType = _prefix "ExportImportCertificationType"
    /// <summary>
    /// This class represents the type of intervention on a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/InterventionType"></see></summary>
    let InterventionType = _prefix "InterventionType"
    /// <summary>
    /// This class represents the type of laboratory test (es.: chemical analysis)
    /// <see href="https://w3id.org/arco/ontology/context-description/LaboratoryTestType"></see></summary>
    let LaboratoryTestType = _prefix "LaboratoryTestType"
    /// <summary>
    /// This class represents the type of observation survey (in the context / out of the context).
    /// <see href="https://w3id.org/arco/ontology/context-description/ObservationSurveyType"></see></summary>
    let ObservationSurveyType = _prefix "ObservationSurveyType"
    /// <summary>
    /// This class represents the type of responsibility related to the production and dissemination of photographic heritage (e.g.: printer, editor)
    /// <see href="https://w3id.org/arco/ontology/context-description/ResponsibilityType"></see></summary>
    let ResponsibilityType = _prefix "ResponsibilityType"
    /// <summary>
    /// This class represents the type of image analysed during a photo interpretation or rendering survey (aerial photograph, satellite photograph).
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyImageType"></see></summary>
    let SurveyImageType = _prefix "SurveyImageType"
    /// <summary>
    /// This class represents the type of an object title (e.g. original, alternative)
    /// <see href="https://w3id.org/arco/ontology/context-description/TitleType"></see></summary>
    let TitleType = _prefix "TitleType"
    /// <summary>
    /// This class represents the type of use of a cultural property (current, previous, historical)
    /// <see href="https://w3id.org/arco/ontology/context-description/UseType"></see></summary>
    let UseType = _prefix "UseType"
    /// <summary>
    /// This class represents the specification of the type of use of a cultural property (e.g. building, ornamental, structural, instrumental)
    /// <see href="https://w3id.org/arco/ontology/context-description/UseTypeSpecification"></see></summary>
    let UseTypeSpecification = _prefix "UseTypeSpecification"
    /// <summary>
    /// This class represents the membership of a cultural property in an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSetMembership"></see></summary>
    let ArchivalRecordSetMembership = _prefix "ArchivalRecordSetMembership"
    /// <summary>
    /// This class represents the membership of a cultural property in a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/CollectionMembership"></see></summary>
    let CollectionMembership = _prefix "CollectionMembership"
    /// <summary>
    /// This class represents the membership of photographic heritage in a photographic series, as a unit.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicSeriesMembership"></see></summary>
    let PhotographicSeriesMembership = _prefix "PhotographicSeriesMembership"
    /// <summary>
    /// This class represents the documentation format (e.g. jpeg, pdf, MP4)
    /// <see href="https://w3id.org/arco/ontology/context-description/Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// This class represents the criterion that motivated an interpretation (e.g. inscription, bibliography, documentation).
    /// <see href="https://w3id.org/arco/ontology/context-description/InterpretationCriterion"></see></summary>
    let InterpretationCriterion = _prefix "InterpretationCriterion"
    /// <summary>
    /// This class represents the main motivation of a survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyMotivation"></see></summary>
    let SurveyMotivation = _prefix "SurveyMotivation"
    /// <summary>
    /// This class represents the use of a cultural property, that can change over time, depending on the circumstances and on which parts of the cultural property are used.
    /// <see href="https://w3id.org/arco/ontology/context-description/Use"></see></summary>
    let Use = _prefix "Use"
    /// <summary>
    /// This class represents the category associated to a bibliography (e.g. accompanying bibliography, comparative bibliography, specific bibliography).
    /// <see href="https://w3id.org/arco/ontology/context-description/BibliographyCategory"></see></summary>
    let BibliographyCategory = _prefix "BibliographyCategory"
    /// <summary>
    /// This class represents the category associated to a documentation (e.g. attached documentation, existing documentation).
    /// <see href="https://w3id.org/arco/ontology/context-description/DocumentationCategory"></see></summary>
    let DocumentationCategory = _prefix "DocumentationCategory"
    /// <summary>
    /// This class represents the patrimonial code of a cultural property, referring to the SEC classification 1995.
    /// <see href="https://w3id.org/arco/ontology/context-description/SECIdentifier"></see></summary>
    let SECIdentifier = _prefix "SECIdentifier"
    /// <summary>
    /// This class represents the social category of a user (e.g. of a cultural property)
    /// <see href="https://w3id.org/arco/ontology/context-description/UserSocialCategory"></see></summary>
    let UserSocialCategory = _prefix "UserSocialCategory"
    /// <summary>
    /// This class represents an archival fonds.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalFonds"></see></summary>
    let ArchivalFonds = _prefix "ArchivalFonds"
    /// <summary>
    /// This class represents an archival series.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalSeries"></see></summary>
    let ArchivalSeries = _prefix "ArchivalSeries"
    /// <summary>
    /// This class represents an archival subseries, that is component of an archival series.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalSubseries"></see></summary>
    let ArchivalSubseries = _prefix "ArchivalSubseries"
    /// <summary>
    /// This class represents a situation in which a cultural property is acquired, passing from an owner to another, and has a particular legal situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/Acquisition"></see></summary>
    let Acquisition = _prefix "Acquisition"
    /// <summary>
    /// This class represents an anomaly detected during a photo interpretation or rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/Anomaly"></see></summary>
    let Anomaly = _prefix "Anomaly"
    /// <summary>
    /// This class represents the change of availability of a cultural property (e.g.: theft, distruction, rescue, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailability"></see></summary>
    let ChangeOfAvailability = _prefix "ChangeOfAvailability"
    /// <summary>
    /// This class represents a circumstance that influenced a particular situation, e.g. the circumstance for which a cultural property was commissioned, tha circumstance in which a cultural property was used, etc.
    /// <see href="https://w3id.org/arco/ontology/context-description/Circumstance"></see></summary>
    let Circumstance = _prefix "Circumstance"
    /// <summary>
    /// This class represents the issuance of a coin, at a particular time and with different agents participanting to it (Mint, Issuing State, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/CoinIssuance"></see></summary>
    let CoinIssuance = _prefix "CoinIssuance"
    /// <summary>
    /// This class represents the export/import certification of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/ExportImportCertification"></see></summary>
    let ExportImportCertification = _prefix "ExportImportCertification"
    /// <summary>
    /// This class represents the legal situation of a cultural property, related to the owner.
    /// <see href="https://w3id.org/arco/ontology/context-description/LegalSituation"></see></summary>
    let LegalSituation = _prefix "LegalSituation"
    /// <summary>
    /// This class represents the concept of membership.
    /// <see href="https://w3id.org/arco/ontology/context-description/Membership"></see></summary>
    let Membership = _prefix "Membership"
    /// <summary>
    /// This class represents a situation in which a cultural property is related to another work, that could even be another cultural property. The cultural property stage is defined referring to this relationship with a related work, that can represent a preparatory, a final phase or a derivation of the cultural property. When the relationship is between two cultural properties, when possible, the nature of the relationship is specified (e.g.: finding location)
    /// <see href="https://w3id.org/arco/ontology/context-description/RelatedWorkSituation"></see></summary>
    let RelatedWorkSituation = _prefix "RelatedWorkSituation"
    /// <summary>
    /// This class represents one level of a biological taxon, the genus.
    /// <see href="https://w3id.org/arco/ontology/context-description/Genus"></see></summary>
    let Genus = _prefix "Genus"
    /// <summary>
    /// This class represents one level of a biological taxon, the species.
    /// <see href="https://w3id.org/arco/ontology/context-description/Species"></see></summary>
    let Species = _prefix "Species"
    /// <summary>
    /// This class represents one level of a biological taxon, the subspecies.
    /// <see href="https://w3id.org/arco/ontology/context-description/Subspecies"></see></summary>
    let Subspecies = _prefix "Subspecies"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an archaeological (stratigraphic) excavation.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalExcavation"></see></summary>
    let ArchaeologicalExcavation = _prefix "ArchaeologicalExcavation"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an archaeological field survey, limited to the surface.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalFieldSurvey"></see></summary>
    let ArchaeologicalFieldSurvey = _prefix "ArchaeologicalFieldSurvey"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is a survey on anthropological materials (e.g.: chemical analysis, histological analysis, CT scan, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurvey"></see></summary>
    let ArchaeologicalPropertySurvey = _prefix "ArchaeologicalPropertySurvey"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an archaeometric and diagnostic survey (coring, geophysical prospecting, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurvey"></see></summary>
    let ArchaeometricDiagnosticSurvey = _prefix "ArchaeometricDiagnosticSurvey"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an inspection carried out to verify the condition of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Inspection"></see></summary>
    let Inspection = _prefix "Inspection"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is a laboratory test.
    /// <see href="https://w3id.org/arco/ontology/context-description/LaboratoryTest"></see></summary>
    let LaboratoryTest = _prefix "LaboratoryTest"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is an observation survey: the observation of musical heritage or demoethnoanthropological heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/ObservationSurvey"></see></summary>
    let ObservationSurvey = _prefix "ObservationSurvey"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is a survey in which is possible to make a diagnosis of a paleopathology of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/context-description/PaleopathologySurvey"></see></summary>
    let PaleopathologySurvey = _prefix "PaleopathologySurvey"
    /// <summary>
    /// This class represents a particular type of survey on a cultural property, that is photo interpretation and rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotoInterpretationRendering"></see></summary>
    let PhotoInterpretationRendering = _prefix "PhotoInterpretationRendering"
    /// <summary>
    /// This class represents the patrimonial category of a cultural property, referring to the SEC classification 1995.
    /// <see href="https://w3id.org/arco/ontology/context-description/SECCategory"></see></summary>
    let SECCategory = _prefix "SECCategory"
    /// <summary>
    /// This class represents the archival record that is part of an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalRecord"></see></summary>
    let ArchivalRecord = _prefix "ArchivalRecord"
    /// <summary>
    /// This class represents the copyright of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Copyright"></see></summary>
    let Copyright = _prefix "Copyright"
    /// <summary>
    /// This class represents the reproduction of an image, that is, or was, part of a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/Reproduction"></see></summary>
    let Reproduction = _prefix "Reproduction"
    /// <summary>
    /// This class represents the representative scale of a graphic or cartographic documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/Scale"></see></summary>
    let Scale = _prefix "Scale"
    /// <summary>
    /// This class represents the title of an object, e.g. the title of the subject represented by a cultural property, or the title of a photographic series, etc.
    /// <see href="https://w3id.org/arco/ontology/context-description/Title"></see></summary>
    let Title = _prefix "Title"
    /// <summary>
    /// This class represents a tomb.
    /// <see href="https://w3id.org/arco/ontology/context-description/Tomb"></see></summary>
    let Tomb = _prefix "Tomb"
    /// <summary>
    /// This class represents the attribution of authorship or a responsibility for the creation of a cultural property, referring to the agents that played a role in the creation of the cultural property or to the reference cultural scope.
    /// <see href="https://w3id.org/arco/ontology/context-description/AuthorshipAttribution"></see></summary>
    let AuthorshipAttribution = _prefix "AuthorshipAttribution"
    /// <summary>
    /// This class represents the commission of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Commission"></see></summary>
    let Commission = _prefix "Commission"
    /// <summary>
    /// This class represents the dating of an entity, that is information about the chronology of the entity (e.g.: a cultural property), referring to a particular event (e.g.: the creation of the cultural property, its distruction, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Dating"></see></summary>
    let Dating = _prefix "Dating"
    /// <summary>
    /// This class represents the concept of estimate.
    /// <see href="https://w3id.org/arco/ontology/context-description/Estimate"></see></summary>
    let Estimate = _prefix "Estimate"
    /// <summary>
    /// This class represents a circumstance in which a garment, catalogued as a cultural property, was worn by one or more people.
    /// <see href="https://w3id.org/arco/ontology/context-description/Fruition"></see></summary>
    let Fruition = _prefix "Fruition"
    /// <summary>
    /// This class represents the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Responsibility"></see></summary>
    let Responsibility = _prefix "Responsibility"
    /// <summary>
    /// This individual represents the definition relative to the genre of bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/AccompanyingBibliography"></see></summary>
    let AccompanyingBibliography = _prefix "AccompanyingBibliography"
    /// <summary>
    /// This property relates an acquisition event to the cultural entity involved in the acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAcquisitionOf"></see></summary>
    let isAcquisitionOf = _prefix "isAcquisitionOf"
    /// <summary>
    /// This property relates the event of a cultural entity's acquisition to the agent which is the source of the acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPreviousOwner"></see></summary>
    let hasPreviousOwner = _prefix "hasPreviousOwner"
    /// <summary>
    /// This property represents the place where an acquisition event, generally expressed, based on the available data, took place, in the form: "Region / abbreviation province / full name of the Municipality / locality or toponym"
    /// <see href="https://w3id.org/arco/ontology/context-description/acquisitionLocation"></see></summary>
    let acquisitionLocation = _prefix "acquisitionLocation"
    /// <summary>
    /// This property relates a cultural entity's acquisition to its acquisition type (i.e. donation, seizure).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAcquisitionType"></see></summary>
    let hasAcquisitionType = _prefix "hasAcquisitionType"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/AerialPhotograph"></see>
    /// </summary>
    let AerialPhotograph = _prefix "AerialPhotograph"
    /// <summary>
    /// This class represents the interpretation of the age of death of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/context-description/AgeOfDeathInterpretation"></see></summary>
    let AgeOfDeathInterpretation = _prefix "AgeOfDeathInterpretation"
    /// <summary>
    /// This property represents an anthropological finding estimated age of death.
    /// <see href="https://w3id.org/arco/ontology/context-description/ageOfDeath"></see></summary>
    let ageOfDeath = _prefix "ageOfDeath"
    /// <summary>
    /// This property relates the age of death interpretation of an antropologic artifact to the its antropologic artifact.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAgeOfDeathInterpretationOf"></see></summary>
    let isAgeOfDeathInterpretationOf = _prefix "isAgeOfDeathInterpretationOf"
    /// <summary>
    /// This class represents a situation in which pieces of information related to an object (e.g.: a cultural property) are detected and recorded by an agent, based on a specific source or motivation (e.g.:ithe authorship attribution, commission, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Interpretation"></see></summary>
    let Interpretation = _prefix "Interpretation"
    /// <summary>
    /// This class represents an authorship attribution alternative to the preferred one.
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeAuthorshipAttribution"></see></summary>
    let AlternativeAuthorshipAttribution = _prefix "AlternativeAuthorshipAttribution"
    /// <summary>
    /// This property represents specifications relating to the intervention carried out by the author on the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/authorIntervention"></see></summary>
    let authorIntervention = _prefix "authorIntervention"
    /// <summary>
    /// This property relates a situation where an autorship is attributed to a cultural entity's author.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAttributedAuthor"></see></summary>
    let hasAttributedAuthor = _prefix "hasAttributedAuthor"
    /// <summary>
    /// This class represents an alternative dating of a cultural property (e.g.: an obsolete dating, a dating based on another method of dating).
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeDating"></see></summary>
    let AlternativeDating = _prefix "AlternativeDating"
    /// <summary>
    /// This property relates an alternative dating to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAlternativeDatingType"></see></summary>
    let hasAlternativeDatingType = _prefix "hasAlternativeDatingType"
    /// <summary>
    /// Represents subject's alternative title.
    /// <see href="https://w3id.org/arco/ontology/context-description/AlternativeTitle"></see></summary>
    let AlternativeTitle = _prefix "AlternativeTitle"
    /// <summary>
    /// This property relates an anomaly detected during a photo interpretation or rendering survey to the origin of the anomaly (e.g. natural, unsure).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAnomalyOrigin"></see></summary>
    let hasAnomalyOrigin = _prefix "hasAnomalyOrigin"
    /// <summary>
    /// This class represents the anomaly origin of the photo interpretation rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/AnomalyOrigin"></see></summary>
    let AnomalyOrigin = _prefix "AnomalyOrigin"
    /// <summary>
    /// This property relates an anomaly revealed by a photo interepretation rendering to the related survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAnomalyOf"></see></summary>
    let isAnomalyOf = _prefix "isAnomalyOf"
    /// <summary>
    /// This property relates an anomaly revealed by a photo interpretation rendering to its anomaly type (line, point, poligony anomaly).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAnomalyType"></see></summary>
    let hasAnomalyType = _prefix "hasAnomalyType"
    /// <summary>
    /// This class represents the stage of the catalogued cultural property related to the object which constitutes its preparatory or final stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalPropertyStage"></see></summary>
    let CulturalPropertyStage = _prefix "CulturalPropertyStage"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/AnthropicOrigin"></see>
    /// </summary>
    let AnthropicOrigin = _prefix "AnthropicOrigin"
    /// <summary>
    /// This property relates an activity to the institution or the survey's responsible entity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasActivityResponsible"></see></summary>
    let hasActivityResponsible = _prefix "hasActivityResponsible"

    /// <summary>
    /// This property represents the identification code, numeric or alphanumeric, which identifies the archaeological excavation unambiguously in the context of a local repertoire.
    /// Questa proprietà rappresenta il codice identificativo, numerico o alfanumerico, che individua lo scavo archeologico in modo univoco nell'ambito di un repertorio locale.
    /// <see href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationLocalIdentifier"></see></summary>
    let archaeologicalExcavationLocalIdentifier =
        _prefix "archaeologicalExcavationLocalIdentifier"

    /// <summary>
    /// This property relates a survey to its scientific director.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyScientificDirector"></see></summary>
    let hasSurveyScientificDirector = _prefix "hasSurveyScientificDirector"
    /// <summary>
    /// This property relates an archeological, archaeometric or diagnostic survey or a photo interpretation rendering to the the main motivation that led to it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyMotivation"></see></summary>
    let hasSurveyMotivation = _prefix "hasSurveyMotivation"
    /// <summary>
    /// This property relates a survey to the method adopted in the survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyMethod"></see></summary>
    let hasSurveyMethod = _prefix "hasSurveyMethod"
    /// <summary>
    /// This class represents the archeological survey method adopted.
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyMethod"></see></summary>
    let SurveyMethod = _prefix "SurveyMethod"
    /// <summary>
    /// This property relates an archaeological excavation to the tomb detected during the survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasTomb"></see></summary>
    let hasTomb = _prefix "hasTomb"

    /// <summary>
    /// This property represents the code, assigned by the ICCD, which identifies the archaeological excavation unequivocally at national level.
    /// <see href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationICCDIdentifier"></see></summary>
    let archaeologicalExcavationICCDIdentifier =
        _prefix "archaeologicalExcavationICCDIdentifier"

    /// <summary>
    /// This property relates an archeological excavation to the stratigraphic unit from which a cultural property has been found.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasStratigraphicUnit"></see></summary>
    let hasStratigraphicUnit = _prefix "hasStratigraphicUnit"
    /// <summary>
    /// This class represents a stratigraphic unit from which a cultural property may come from.
    /// <see href="https://w3id.org/arco/ontology/context-description/StratigraphicUnit"></see></summary>
    let StratigraphicUnit = _prefix "StratigraphicUnit"
    /// <summary>
    /// This property relates an archaeological excavation to the succession of the denominations, assigned in the excavation, to the sector (or
    /// the area), to the environment and to the square from which the good comes.
    /// <see href="https://w3id.org/arco/ontology/context-description/areaRoomSquare"></see></summary>
    let areaRoomSquare = _prefix "areaRoomSquare"

    /// <summary>
    /// This property represents the identification code, numeric or alphanumeric, which identifies the field survey unambiguously in the context of a local repertoire.
    /// <see href="https://w3id.org/arco/ontology/context-description/archeologicalFieldSurveyLocalIdentifier"></see></summary>
    let archeologicalFieldSurveyLocalIdentifier =
        _prefix "archeologicalFieldSurveyLocalIdentifier"

    /// <summary>
    /// This property represents the code, assigned by the ICCD, which identifies the field survey unequivocally at national level.
    /// <see href="https://w3id.org/arco/ontology/context-description/archaeologicalFieldSurveyICCDIdentifier"></see></summary>
    let archaeologicalFieldSurveyICCDIdentifier =
        _prefix "archaeologicalFieldSurveyICCDIdentifier"

    /// <summary>
    /// This property relates an archaeological survey to environmental situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/environmentalState"></see></summary>
    let environmentalState = _prefix "environmentalState"
    /// <summary>
    /// This property represents documentation relating to information collected during survey on anthropological evidence.
    /// <see href="https://w3id.org/arco/ontology/context-description/technicalDocumentation"></see></summary>
    let technicalDocumentation = _prefix "technicalDocumentation"

    /// <summary>
    /// This property relates a survey on an archaeological property to the type of survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchaeologicalPropertySurveyType"></see></summary>
    let hasArchaeologicalPropertySurveyType =
        _prefix "hasArchaeologicalPropertySurveyType"

    /// <summary>
    /// This property relates an arecheometric diagnostic survey to its type (i.e. thermal imaging, coring).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchaeometricDiagnosticSurveyType"></see></summary>
    let hasArchaeometricDiagnosticSurveyType =
        _prefix "hasArchaeometricDiagnosticSurveyType"

    /// <summary>
    /// This property relates an activity to the agent who performed the activity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasActivityOperator"></see></summary>
    let hasActivityOperator = _prefix "hasActivityOperator"
    /// <summary>
    /// This property represents the report of a anthropological finding's archaeometric and diagnostic investigation.
    /// ICCD Normativa Trasversale 4.00: RE/IND/INDT - ICCD Normativa AT 3.00: IN/INI/INIR
    /// <see href="https://w3id.org/arco/ontology/context-description/report"></see></summary>
    let report = _prefix "report"
    /// <summary>
    /// This property relates an activity to its investor. The investor may be an institution or an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasActivitySponsor"></see></summary>
    let hasActivitySponsor = _prefix "hasActivitySponsor"
    /// <summary>
    /// This class represents an archival record set (fonds, series, subseries) of which a cultural property can be member.
    /// <see href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSet"></see></summary>
    let ArchivalRecordSet = _prefix "ArchivalRecordSet"
    /// <summary>
    /// This property represents the identifier of an archival record.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordIdentifier"></see></summary>
    let archivalRecordIdentifier = _prefix "archivalRecordIdentifier"
    /// <summary>
    /// This property relates an object to its title.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasTitle"></see></summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    /// This property represents the identifier of an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordSetIdentifier"></see></summary>
    let archivalRecordSetIdentifier = _prefix "archivalRecordSetIdentifier"
    /// <summary>
    /// This property relates the membership of a cultural entity to an archival record set. It is the inverse property of "isMemberofArchivalRecordSet".
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMemberOfArchivalRecordSet"></see></summary>
    let hasMemberOfArchivalRecordSet = _prefix "hasMemberOfArchivalRecordSet"
    /// <summary>
    /// This property represents the location of a documentary unit within a complex archival unit.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordLocation"></see></summary>
    let archivalRecordLocation = _prefix "archivalRecordLocation"
    /// <summary>
    /// This property relates the relationship of an archival set and a one of its belonging cultural entities.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchivalRecordSet"></see></summary>
    let hasArchivalRecordSet = _prefix "hasArchivalRecordSet"
    /// <summary>
    /// This property represents the title of the archival record set in which a documentary unit is located.
    /// <see href="https://w3id.org/arco/ontology/context-description/archivalRecordSetTitle"></see></summary>
    let archivalRecordSetTitle = _prefix "archivalRecordSetTitle"
    /// <summary>
    /// This individual represents documenation definition included inside catalog.
    /// <see href="https://w3id.org/arco/ontology/context-description/AttachedDocumentation"></see></summary>
    let AttachedDocumentation = _prefix "AttachedDocumentation"
    /// <summary>
    /// Represents an attributed title of a photograph, that is a title taken from archival, bibliographic, oral or iconographic sources, or created based on picture contents.
    /// <see href="https://w3id.org/arco/ontology/context-description/AttributedTitle"></see></summary>
    let AttributedTitle = _prefix "AttributedTitle"
    /// <summary>
    /// This class represents the audio documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/AudioDocumentation"></see></summary>
    let AudioDocumentation = _prefix "AudioDocumentation"
    /// <summary>
    /// This class represents the documentation, with subclasses for each specific type of documentation (images, drawings, audio, video, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/Documentation"></see></summary>
    let Documentation = _prefix "Documentation"
    /// <summary>
    /// This property relates the documentation to its format.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFormat"></see></summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    /// Property that links an authorship attribution referred to a cultural entity to that cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAuthorshipAttributionOf"></see></summary>
    let isAuthorshipAttributionOf = _prefix "isAuthorshipAttributionOf"
    /// <summary>
    /// This property relates a situation, where a cultural scope is attributed to a cultural entity, to the cultural scope.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalScope"></see></summary>
    let hasCulturalScope = _prefix "hasCulturalScope"
    /// <summary>
    /// This class represents the cultural scope related to a cultural property (e.g.: neoclassical, Milanese manifacturing, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalScope"></see></summary>
    let CulturalScope = _prefix "CulturalScope"
    /// <summary>
    /// This property relates an entity described in a authority file to the file's cataloguing institution.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAuthorityFileCataloguingAgency"></see></summary>
    let hasAuthorityFileCataloguingAgency = _prefix "hasAuthorityFileCataloguingAgency"
    /// <summary>
    /// This property relates an authorship attribution to the agent's role.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInterventionRole"></see></summary>
    let hasInterventionRole = _prefix "hasInterventionRole"
    /// <summary>
    /// This class represents the bibliography of an entity, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Bibliography"></see></summary>
    let Bibliography = _prefix "Bibliography"
    /// <summary>
    /// This property represents the abbreviation that identifies the bibliographic reference.
    /// <see href="https://w3id.org/arco/ontology/context-description/abbreviation"></see></summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    /// This property relates a bibliography to the entity which is referred to.
    /// <see href="https://w3id.org/arco/ontology/context-description/isBibliographyOf"></see></summary>
    let isBibliographyOf = _prefix "isBibliographyOf"
    /// <summary>
    /// This property represents the complete bibliographic reference.
    /// <see href="https://w3id.org/arco/ontology/context-description/completeBibliographicReference"></see></summary>
    let completeBibliographicReference = _prefix "completeBibliographicReference"
    /// <summary>
    /// This property represents the code, assigned by the ICCD, which identifies the bibliographic reference uniquely at national level.
    /// <see href="https://w3id.org/arco/ontology/context-description/bibliographyICCDIdentifier"></see></summary>
    let bibliographyICCDIdentifier = _prefix "bibliographyICCDIdentifier"
    /// <summary>
    /// This property relates a bibliography to its bibliography type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasBibliographyType"></see></summary>
    let hasBibliographyType = _prefix "hasBibliographyType"
    /// <summary>
    /// This property relates an entity to its edition.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEdition"></see></summary>
    let hasEdition = _prefix "hasEdition"
    /// <summary>
    /// This class represents the edition of an entity (e.g. the print edition of a cultural property).
    /// <see href="https://w3id.org/arco/ontology/context-description/Edition"></see></summary>
    let Edition = _prefix "Edition"
    /// <summary>
    /// This class represents a biological taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/BiologicalTaxon"></see></summary>
    let BiologicalTaxon = _prefix "BiologicalTaxon"
    /// <summary>
    /// This property relates a biological taxon to the subspecies, that is one of the concept of the taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSpecies"></see></summary>
    let hasSpecies = _prefix "hasSpecies"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isBiologicalTaxonOf"></see>
    /// </summary>
    let isBiologicalTaxonOf = _prefix "isBiologicalTaxonOf"
    /// <summary>
    /// This property relates a biological taxon to the genus, that is one of the concept of the taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasGenus"></see></summary>
    let hasGenus = _prefix "hasGenus"
    /// <summary>
    /// This property relates a biological taxon to the subspecies, that is one of the concept of the taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSubspecies"></see></summary>
    let hasSubspecies = _prefix "hasSubspecies"
    /// <summary>
    /// This individual represents cultural entity  building use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/BuildingUse"></see></summary>
    let BuildingUse = _prefix "BuildingUse"
    /// <summary>
    /// This property relates a cultural entity's change of availability to the event type (i.e. theft, destruction, recovery).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailabilityType"></see></summary>
    let hasChangeOfAvailabilityType = _prefix "hasChangeOfAvailabilityType"
    /// <summary>
    /// This property relates a change of availability to a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityOf"></see></summary>
    let isChangeOfAvailabilityOf = _prefix "isChangeOfAvailabilityOf"
    /// <summary>
    /// This property relates the circumstance to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCircumstanceType"></see></summary>
    let hasCircumstanceType = _prefix "hasCircumstanceType"
    /// <summary>
    /// This property, inverse of 'has circumstance' relates the circumstance which led to a situation (e.g. a cultural entity committment, a cultural entity use, etc.) to the related situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCircumstanceOf"></see></summary>
    let isCircumstanceOf = _prefix "isCircumstanceOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/CivilCircumstance"></see>
    /// </summary>
    let CivilCircumstance = _prefix "CivilCircumstance"
    /// <summary>
    /// This property relates the coin issuance to the minter. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMinter"></see></summary>
    let hasMinter = _prefix "hasMinter"
    /// <summary>
    /// This property relates the coin issuance to the issuing State of that historic period. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIssuingState"></see></summary>
    let hasIssuingState = _prefix "hasIssuingState"
    /// <summary>
    /// This is the inverse property of "has coin issuance".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCoinIssuanceOf"></see></summary>
    let isCoinIssuanceOf = _prefix "isCoinIssuanceOf"
    /// <summary>
    /// This property relates the coin issuance to the Mint. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMint"></see></summary>
    let hasMint = _prefix "hasMint"
    /// <summary>
    /// This property relates to coin's issuance to the issuer agent. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIssuer"></see></summary>
    let hasIssuer = _prefix "hasIssuer"
    /// <summary>
    /// This property relates the membership of a movable cultural entity to a collection in a time interval. It is the inverse property of "isMemberofCollection".
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMemberOfCollection"></see></summary>
    let hasMemberOfCollection = _prefix "hasMemberOfCollection"
    /// <summary>
    /// This property represents the reason that led a cultural entity to the exit from a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/collectionLeavingReason"></see></summary>
    let collectionLeavingReason = _prefix "collectionLeavingReason"
    /// <summary>
    /// This property represents the inventory code assigned to the cultural entity inside a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/collectionUnitIdentifier"></see></summary>
    let collectionUnitIdentifier = _prefix "collectionUnitIdentifier"
    /// <summary>
    /// This property relates a cultural property to the collection to which it belongs in a time span.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCollection"></see></summary>
    let hasCollection = _prefix "hasCollection"
    /// <summary>
    /// This property represents cultural entity's economic value.. The value is preceded by the currency specification.
    /// <see href="https://w3id.org/arco/ontology/context-description/estimatedCulturalPropertyValue"></see></summary>
    let estimatedCulturalPropertyValue = _prefix "estimatedCulturalPropertyValue"
    /// <summary>
    /// This property relates a situation where it is indicated a cultural entity's commission to the investor agent or institution.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCommittent"></see></summary>
    let hasCommittent = _prefix "hasCommittent"
    /// <summary>
    /// This property relates a situation to the circumstance which led to the situation. For example it can connect a situation where is indicated a cultural entity's committment to its circumstance.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCircumstance"></see></summary>
    let hasCircumstance = _prefix "hasCircumstance"
    /// <summary>
    /// This property relates a commission to the cultural entity that was commissioned.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCommissionOf"></see></summary>
    let isCommissionOf = _prefix "isCommissionOf"
    /// <summary>
    /// This individual represents the definition relative to the kind of bibliography used for comparisons.
    /// <see href="https://w3id.org/arco/ontology/context-description/ComparativeBibliography"></see></summary>
    let ComparativeBibliography = _prefix "ComparativeBibliography"
    /// <summary>
    /// This class represents a conservation intervention on a cultural property (e.g.: microclimatic inspection, mechanical cleaning or with chemicals, pest control, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/ConservationIntervention"></see></summary>
    let ConservationIntervention = _prefix "ConservationIntervention"
    /// <summary>
    /// This property represents the framework in which the restoration is carried out.
    /// <see href="https://w3id.org/arco/ontology/context-description/framework"></see></summary>
    let framework = _prefix "framework"
    /// <summary>
    /// This class represents the copy of a cultural property, e.g. a copy of a photography or a print.
    /// <see href="https://w3id.org/arco/ontology/context-description/Copy"></see></summary>
    let Copy = _prefix "Copy"
    /// <summary>
    /// This class represents a derivated work of a cultural property (copy, reuse, facsimile, forgery), created by the same author or by another author.
    /// <see href="https://w3id.org/arco/ontology/context-description/DerivatedWork"></see></summary>
    let DerivatedWork = _prefix "DerivatedWork"
    /// <summary>
    /// This property relates an entity's copyright to its copyright holder. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCopyrightHolder"></see></summary>
    let hasCopyrightHolder = _prefix "hasCopyrightHolder"
    /// <summary>
    /// This property represents an expiration date.
    /// <see href="https://w3id.org/arco/ontology/context-description/expiryDate"></see></summary>
    let expiryDate = _prefix "expiryDate"
    /// <summary>
    /// This is the inverse property of "is copyright of".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCopyrightOf"></see></summary>
    let isCopyrightOf = _prefix "isCopyrightOf"
    /// <summary>
    /// This class represents the estimate of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalPropertyEstimate"></see></summary>
    let CulturalPropertyEstimate = _prefix "CulturalPropertyEstimate"
    /// <summary>
    /// This property relates a cultural property estimate to the estimated cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyEstimateOf"></see></summary>
    let isCulturalPropertyEstimateOf = _prefix "isCulturalPropertyEstimateOf"
    /// <summary>
    /// This cultural property relates the stage of a cultural property referring to another entity (preparatory or final work) to this relationship between the two entities.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyStageIn"></see></summary>
    let isCulturalPropertyStageIn = _prefix "isCulturalPropertyStageIn"
    /// <summary>
    /// This class represents the attribution of a cultural scope, to which the cultural property is related (e.g.: neoclassical, Milanese manifacturing, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/CulturalScopeAttribution"></see></summary>
    let CulturalScopeAttribution = _prefix "CulturalScopeAttribution"
    /// <summary>
    /// This property relates a cultural scope of a cultural entity to the situation where this cultural scope is attributed.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalScopeOf"></see></summary>
    let isCulturalScopeOf = _prefix "isCulturalScopeOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/CurrentInventory"></see>
    /// </summary>
    let CurrentInventory = _prefix "CurrentInventory"
    /// <summary>
    /// This property represents the code of the RCS causal (Central State Accounting Office) of increasing or decreasing property value.
    /// <see href="https://w3id.org/arco/ontology/context-description/RCSReason"></see></summary>
    let RCSReason = _prefix "RCSReason"
    /// <summary>
    /// This property relates a current inventory to the agent responsible for the cultural entity's inventory. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResponsibleForInsertion"></see></summary>
    let hasResponsibleForInsertion = _prefix "hasResponsibleForInsertion"
    /// <summary>
    /// This property represents how the cultural entity was inserted inside a collection.
    /// <see href="https://w3id.org/arco/ontology/context-description/methodOfInsertion"></see></summary>
    let methodOfInsertion = _prefix "methodOfInsertion"
    /// <summary>
    /// This class represents an inventory about a cultural property or about an entity or an activity related to the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/Inventory"></see></summary>
    let Inventory = _prefix "Inventory"
    /// <summary>
    /// This property relates the current inventory to the patrimonial code of a cultural property, referring to the SEC classification 1995.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSECIdentifier"></see></summary>
    let hasSECIdentifier = _prefix "hasSECIdentifier"
    /// <summary>
    /// This property represents origin of the cultural entity acquired in the heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/provenance"></see></summary>
    let provenance = _prefix "provenance"

    /// <summary>
    /// This property represents a cultural entity inventory description.
    /// <see href="https://w3id.org/arco/ontology/context-description/culturalPropertyInventoryDescription"></see></summary>
    let culturalPropertyInventoryDescription =
        _prefix "culturalPropertyInventoryDescription"

    /// <summary>
    /// This property relates a current inventory to the patrimonial category attributed to the cultural property based on the SEC classification.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSECCategory"></see></summary>
    let hasSECCategory = _prefix "hasSECCategory"
    /// <summary>
    /// This individual represents cultural entity current use.
    /// <see href="https://w3id.org/arco/ontology/context-description/CurrentUse"></see></summary>
    let CurrentUse = _prefix "CurrentUse"
    /// <summary>
    /// This property relates a dating to an entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDatingOf"></see></summary>
    let isDatingOf = _prefix "isDatingOf"
    /// <summary>
    /// This property relates a dating to an event involving the cultural property, which the dating is about.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDatingEvent"></see></summary>
    let hasDatingEvent = _prefix "hasDatingEvent"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/DecentReliability"></see>
    /// </summary>
    let DecentReliability = _prefix "DecentReliability"
    /// <summary>
    /// This class represents the reliability level of detected information relative to photo interpretation rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/Reliability"></see></summary>
    let Reliability = _prefix "Reliability"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/DeliveryConfirmationCertification"></see>
    /// </summary>
    let DeliveryConfirmationCertification = _prefix "DeliveryConfirmationCertification"
    /// <summary>
    /// This property relates a work derivated from a cultural entity to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDerivatedWorkType"></see></summary>
    let hasDerivatedWorkType = _prefix "hasDerivatedWorkType"
    /// <summary>
    /// This property relates an entity to its author.
    /// This property relates a entity (i.e. documentation, cultural entity, etc.) to its author.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAuthor"></see></summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    /// This property represents derivated work's geographical and specific location.
    /// <see href="https://w3id.org/arco/ontology/context-description/derivatedWorkLocation"></see></summary>
    let derivatedWorkLocation = _prefix "derivatedWorkLocation"
    /// <summary>
    /// This class represents the method of detection that allowed the detection of a cultural property and which is indicative of the type and consistency of some information in the catalogue record that describes it (e.g.: coring, archive data, oral sources).
    /// <see href="https://w3id.org/arco/ontology/context-description/DetectionMethod"></see></summary>
    let DetectionMethod = _prefix "DetectionMethod"
    /// <summary>
    /// This property relates the detection method of a cultural property to the cultural property itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDetectionMethodOf"></see></summary>
    let isDetectionMethodOf = _prefix "isDetectionMethodOf"
    /// <summary>
    /// This individual represents a different type of dating than the one present in cultural entity's chronological information.
    /// <see href="https://w3id.org/arco/ontology/context-description/DifferentDating"></see></summary>
    let DifferentDating = _prefix "DifferentDating"
    /// <summary>
    /// This property represents a numeric or alphanumeric sequence that identifies the record to which the document refers.
    /// <see href="https://w3id.org/arco/ontology/context-description/documentationIdentifier"></see></summary>
    let documentationIdentifier = _prefix "documentationIdentifier"
    /// <summary>
    /// This property represents the name of the digital file that reproduces the document.
    /// <see href="https://w3id.org/arco/ontology/context-description/digitalFilename"></see></summary>
    let digitalFilename = _prefix "digitalFilename"
    /// <summary>
    /// This property relates a documentation to its type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDocumentationType"></see></summary>
    let hasDocumentationType = _prefix "hasDocumentationType"
    /// <summary>
    /// This property relates a documentation to an entity. For example, it can relates a documentation concerning a cultural property described in a catalogue record to that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDocumentationOf"></see></summary>
    let isDocumentationOf = _prefix "isDocumentationOf"
    /// <summary>
    /// This property represents information on rights management.
    /// <see href="https://w3id.org/arco/ontology/context-description/rights"></see></summary>
    let rights = _prefix "rights"
    /// <summary>
    /// This property relates an edition to its editor.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEditor"></see></summary>
    let hasEditor = _prefix "hasEditor"
    /// <summary>
    /// This property relates an entity to its secondary authors. For example an author of a publication's contribution or section.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSecondaryAuthor"></see></summary>
    let hasSecondaryAuthor = _prefix "hasSecondaryAuthor"
    /// <summary>
    /// This property represents work's edition place.
    /// <see href="https://w3id.org/arco/ontology/context-description/editionLocation"></see></summary>
    let editionLocation = _prefix "editionLocation"
    /// <summary>
    /// This property relates an entity's edition to the entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isEditionOf"></see></summary>
    let isEditionOf = _prefix "isEditionOf"
    /// <summary>
    /// This class represents the intervention considered eligible by a specific urban planning instrument related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/EligibleIntervention"></see></summary>
    let EligibleIntervention = _prefix "EligibleIntervention"
    /// <summary>
    /// This property, inverse of "has eligible intervention", relates an intervention to the urban planning instrument that finds eligible that intervention.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterventionEligibleBy"></see></summary>
    let isInterventionEligibleBy = _prefix "isInterventionEligibleBy"
    /// <summary>
    /// This class represents a urban planning instrument, related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/UrbanPlanningInstrument"></see></summary>
    let UrbanPlanningInstrument = _prefix "UrbanPlanningInstrument"
    /// <summary>
    /// This individual represents cultural entity's epigraphic use.
    /// <see href="https://w3id.org/arco/ontology/context-description/EpigraphicUse"></see></summary>
    let EpigraphicUse = _prefix "EpigraphicUse"
    /// <summary>
    /// This property represents the value estimated in the context of an estimate process.
    /// <see href="https://w3id.org/arco/ontology/context-description/estimatedValue"></see></summary>
    let estimatedValue = _prefix "estimatedValue"
    /// <summary>
    /// This property relates an estimate of an entity to that entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isEstimateOf"></see></summary>
    let isEstimateOf = _prefix "isEstimateOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/ExcellentReliability"></see>
    /// </summary>
    let ExcellentReliability = _prefix "ExcellentReliability"
    /// <summary>
    /// This individual represents documentation definition that is only mentioned.
    /// <see href="https://w3id.org/arco/ontology/context-description/ExistingDocumentation"></see></summary>
    let ExistingDocumentation = _prefix "ExistingDocumentation"
    /// <summary>
    /// This class represents an expired copyright, related to an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/ExpiredCopyright"></see></summary>
    let ExpiredCopyright = _prefix "ExpiredCopyright"
    /// <summary>
    /// This property relates a import-export certification of a cultural entity to its type (i.e. delivery confirmation certification, free movement certification etc).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasExportImportCertificationType"></see></summary>
    let hasExportImportCertificationType = _prefix "hasExportImportCertificationType"
    /// <summary>
    /// This property relates an export import certification to a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationOf"></see></summary>
    let isExportImportCertificationOf = _prefix "isExportImportCertificationOf"
    /// <summary>
    /// This property relates an export/import certification to the certifying Export Department.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasExportOffice"></see></summary>
    let hasExportOffice = _prefix "hasExportOffice"
    /// <summary>
    /// This class represents a facsimile of a cultural property, and in particular of a photography, that has the same format and technique.
    /// <see href="https://w3id.org/arco/ontology/context-description/Facsimile"></see></summary>
    let Facsimile = _prefix "Facsimile"
    /// <summary>
    /// This class represents a circumstance related to fairs, markets, festivals.
    /// <see href="https://w3id.org/arco/ontology/context-description/FairMarketCircumstance"></see></summary>
    let FairMarketCircumstance = _prefix "FairMarketCircumstance"
    /// <summary>
    /// This class represents an indeterminate circumstance, when the cultural property is not related to a determinate circumstance, but takes place in an extemporaneous and contingent way (e.g.: a musical performance, a narration, a game).
    /// <see href="https://w3id.org/arco/ontology/context-description/IndeterminateCircumstance"></see></summary>
    let IndeterminateCircumstance = _prefix "IndeterminateCircumstance"
    /// <summary>
    /// This class represents the film documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/FilmDocumentation"></see></summary>
    let FilmDocumentation = _prefix "FilmDocumentation"
    /// <summary>
    /// This class represents an entity related to a cultural property, as its final stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/FinalWork"></see></summary>
    let FinalWork = _prefix "FinalWork"
    /// <summary>
    /// This class represents an entity related to a cultural property, that is its preparatory or final stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreparatoryOrFinalWork"></see></summary>
    let PreparatoryOrFinalWork = _prefix "PreparatoryOrFinalWork"
    /// <summary>
    /// This class represents an entity related to a cultural property, as its preparatory stage.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreparatoryWork"></see></summary>
    let PreparatoryWork = _prefix "PreparatoryWork"
    /// <summary>
    /// This class represents the context (type of context, associated objects) in which a cultural property (in particular, an anthropological material) is found.
    /// <see href="https://w3id.org/arco/ontology/context-description/FindingContext"></see></summary>
    let FindingContext = _prefix "FindingContext"
    /// <summary>
    /// This property relates a finding context of a cultural property (in particular, an anthropological material) to an object associated to the cultural property (e.g: earrings, shield, cloth, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAssociatedObject"></see></summary>
    let hasAssociatedObject = _prefix "hasAssociatedObject"
    /// <summary>
    /// This property relates the finding context of a cultural property, and in particular an anthropological material, to the related cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFindingContextOf"></see></summary>
    let isFindingContextOf = _prefix "isFindingContextOf"
    /// <summary>
    /// This class represents the type of finding context of a cultural property, and in particular of an anthropological material (e.g.: individual burial, common burial, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/FindingContextType"></see></summary>
    let FindingContextType = _prefix "FindingContextType"
    /// <summary>
    /// This property relates a cultural property (anthropological material) finding context to the type of context.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFindingContextType"></see></summary>
    let hasFindingContextType = _prefix "hasFindingContextType"
    /// <summary>
    /// This class represents a forgery of a cultural property, that is a copy of a cultural property for which the author doesn't declare the original author.
    /// <see href="https://w3id.org/arco/ontology/context-description/Forgery"></see></summary>
    let Forgery = _prefix "Forgery"
    /// <summary>
    /// This property relates the format to the related documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFormatOf"></see></summary>
    let isFormatOf = _prefix "isFormatOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/FreeMovementCertification"></see>
    /// </summary>
    let FreeMovementCertification = _prefix "FreeMovementCertification"
    /// <summary>
    /// This property relates an entity to the user, intended as the agent who employed the entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUser"></see></summary>
    let hasUser = _prefix "hasUser"
    /// <summary>
    /// This property relates the fruition of a garment to that garment.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFruitionOf"></see></summary>
    let isFruitionOf = _prefix "isFruitionOf"
    /// <summary>
    /// This property relates a genus to the biological taxon in which it is classified.
    /// <see href="https://w3id.org/arco/ontology/context-description/isGenusIn"></see></summary>
    let isGenusIn = _prefix "isGenusIn"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/GoodReliability"></see>
    /// </summary>
    let GoodReliability = _prefix "GoodReliability"

    /// <summary>
    /// This class represents the graphic or cartographic documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/GraphicOrCartographicDocumentation"></see></summary>
    let GraphicOrCartographicDocumentation =
        _prefix "GraphicOrCartographicDocumentation"

    /// <summary>
    /// This property relates the graphic or cartographic documentation to its representation scale.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasScale"></see></summary>
    let hasScale = _prefix "hasScale"
    /// <summary>
    /// This individual represents cultural enity's historical use.
    /// <see href="https://w3id.org/arco/ontology/context-description/HistoricalUse"></see></summary>
    let HistoricalUse = _prefix "HistoricalUse"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/HistoricizedTitle"></see>
    /// </summary>
    let HistoricizedTitle = _prefix "HistoricizedTitle"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/ImportConfirmationCertification"></see>
    /// </summary>
    let ImportConfirmationCertification = _prefix "ImportConfirmationCertification"
    /// <summary>
    /// This class represents a circumstance related to production cycles (sericulture, cereal crop, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/ProductionCycleCircumstance"></see></summary>
    let ProductionCycleCircumstance = _prefix "ProductionCycleCircumstance"
    /// <summary>
    /// This class represents a circumstance related to life cycles (ceremonies, custom, celebration)
    /// <see href="https://w3id.org/arco/ontology/context-description/LifeCycleCircumstance"></see></summary>
    let LifeCycleCircumstance = _prefix "LifeCycleCircumstance"
    /// <summary>
    /// This class represents a circumstance related to social interaction (dances, pubs, wakes)
    /// <see href="https://w3id.org/arco/ontology/context-description/SocialInteractionCircumstance"></see></summary>
    let SocialInteractionCircumstance = _prefix "SocialInteractionCircumstance"
    /// <summary>
    /// This class represents a circumstance related to work (e.g.: agriculture, bakery)
    /// <see href="https://w3id.org/arco/ontology/context-description/WorkCircumstance"></see></summary>
    let WorkCircumstance = _prefix "WorkCircumstance"
    /// <summary>
    /// This class represents a circumstance related to year cycles (e.g.: autumnal equinox, New Year's Eve, Lent, Ramadan, carnival, etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/YearCycleCircumstance"></see></summary>
    let YearCycleCircumstance = _prefix "YearCycleCircumstance"
    /// <summary>
    /// This class represents a circumstance related to seasonal cycles, referred to: subject of popular belief, myth, science; poetry, prose, songs, art, ritual; practical activities, behaviour, phenomena connected to specific cycles, days, months, seasons; fortunate or unfortunate days and periods.
    /// <see href="https://w3id.org/arco/ontology/context-description/SeasonCycleCircumstance"></see></summary>
    let SeasonCycleCircumstance = _prefix "SeasonCycleCircumstance"
    /// <summary>
    /// This individual represents cultural entity instrumental use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/InstrumentalUse"></see></summary>
    let InstrumentalUse = _prefix "InstrumentalUse"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/InsufficientReliability"></see>
    /// </summary>
    let InsufficientReliability = _prefix "InsufficientReliability"
    /// <summary>
    /// This property relates an authorship, dating, commission, or other interpretation situations, to the reason or criterion which led to that interpretation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInterpretationCriterion"></see></summary>
    let hasInterpretationCriterion = _prefix "hasInterpretationCriterion"
    /// <summary>
    /// This property relates an interpretation criterion to the interpretation that was based on that criterion.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterpretationCriterionOf"></see></summary>
    let isInterpretationCriterionOf = _prefix "isInterpretationCriterionOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isInterventionOn"></see>
    /// </summary>
    let isInterventionOn = _prefix "isInterventionOn"
    /// <summary>
    /// This property relates an intervention on a cultural property (i.e. conservation, interventions, reprocessing, restoring, etc.) to its intervention type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInterventionType"></see></summary>
    let hasInterventionType = _prefix "hasInterventionType"
    /// <summary>
    /// This property relates an inventory to the juridical container responsible for the inventory identifier of the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInventoryIdentifierResponsible"></see></summary>
    let hasInventoryIdentifierResponsible = _prefix "hasInventoryIdentifierResponsible"
    /// <summary>
    /// This property represents the location of the inventory about a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/inventoryLocation"></see></summary>
    let inventoryLocation = _prefix "inventoryLocation"
    /// <summary>
    /// This property relates an inventory to a cultural property or an entity or an activity related to it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInventoryOf"></see></summary>
    let isInventoryOf = _prefix "isInventoryOf"
    /// <summary>
    /// This property represents the inventory identifier attributed by a juridical container to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/inventoryIdentifier"></see></summary>
    let inventoryIdentifier = _prefix "inventoryIdentifier"
    /// <summary>
    /// This property represents specifications on any significant components for the study of the entity, in case of analysis on clay findings.
    /// <see href="https://w3id.org/arco/ontology/context-description/claySpecifications"></see></summary>
    let claySpecifications = _prefix "claySpecifications"
    /// <summary>
    /// This property relates a laboratory test to its test type (i.e. chemical or metallurgical analysis).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasLaboratoryTestType"></see></summary>
    let hasLaboratoryTestType = _prefix "hasLaboratoryTestType"
    /// <summary>
    /// This property relates a legal situation to an entity that is in that situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLegalSituationOf"></see></summary>
    let isLegalSituationOf = _prefix "isLegalSituationOf"
    /// <summary>
    /// This property relates a legal situation to the owner of the object that is in that legal situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasOwner"></see></summary>
    let hasOwner = _prefix "hasOwner"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/LineAnomaly"></see>
    /// </summary>
    let LineAnomaly = _prefix "LineAnomaly"
    /// <summary>
    /// This individual represents publication main title.
    /// <see href="https://w3id.org/arco/ontology/context-description/MainTitle"></see></summary>
    let MainTitle = _prefix "MainTitle"
    /// <summary>
    /// This class represents the multimedia documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/MultimediaDocumentation"></see></summary>
    let MultimediaDocumentation = _prefix "MultimediaDocumentation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/NaturalOrigin"></see>
    /// </summary>
    let NaturalOrigin = _prefix "NaturalOrigin"
    /// <summary>
    /// This class represents a print that is no longer was a part of a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/NoLongerInPublication"></see></summary>
    let NoLongerInPublication = _prefix "NoLongerInPublication"
    /// <summary>
    /// This class represents the series which a particular coin is part of.
    /// <see href="https://w3id.org/arco/ontology/context-description/NumismaticSeries"></see></summary>
    let NumismaticSeries = _prefix "NumismaticSeries"
    /// <summary>
    /// This property relates a numismatic series to a coin that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCoinMember"></see></summary>
    let hasCoinMember = _prefix "hasCoinMember"
    /// <summary>
    /// This class relates an observation survey of musical or demoetnoanthropological heritage to the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign)
    /// <see href="https://w3id.org/arco/ontology/context-description/isRelatedToResearch"></see></summary>
    let isRelatedToResearch = _prefix "isRelatedToResearch"
    /// <summary>
    /// This property relates an observation survey of a demo-etno-antropologic entity to the professional photographer who took the shot. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyPhotographer"></see></summary>
    let hasSurveyPhotographer = _prefix "hasSurveyPhotographer"
    /// <summary>
    /// This property relates an observation survey to the type of observation survey (in the context, out of context).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasObservationSurveyType"></see></summary>
    let hasObservationSurveyType = _prefix "hasObservationSurveyType"
    /// <summary>
    /// This property relates an observation survey of a demo-etno-antropologic entity to the sound engineer who recorded it. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveySoundEngineer"></see></summary>
    let hasSurveySoundEngineer = _prefix "hasSurveySoundEngineer"
    /// <summary>
    /// This individual represents an obsolete dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/ObsoleteDating"></see></summary>
    let ObsoleteDating = _prefix "ObsoleteDating"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/OriginalTitle"></see>
    /// </summary>
    let OriginalTitle = _prefix "OriginalTitle"
    /// <summary>
    /// This individual represents cultural entity's ornamental use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/OrnamentalUse"></see></summary>
    let OrnamentalUse = _prefix "OrnamentalUse"
    /// <summary>
    /// This individual represents a different type of dating method than the one present in cultural entity's chronological information.
    /// <see href="https://w3id.org/arco/ontology/context-description/OtherMethodOfDating"></see></summary>
    let OtherMethodOfDating = _prefix "OtherMethodOfDating"
    /// <summary>
    /// This property represents the diagnosis of an anthropological finding paleopathology.
    /// <see href="https://w3id.org/arco/ontology/context-description/diagnosis"></see></summary>
    let diagnosis = _prefix "diagnosis"
    /// <summary>
    /// This property represents other investigations referred to in a survey aimed at developing a diagnosis of a paleopathology found in an anthropological finding.
    /// <see href="https://w3id.org/arco/ontology/context-description/refersToSurveys"></see></summary>
    let refersToSurveys = _prefix "refersToSurveys"
    /// <summary>
    /// I represents a parallel title, that is main title translated into other languages and presented as equivalent.
    /// <see href="https://w3id.org/arco/ontology/context-description/ParallelTitle"></see></summary>
    let ParallelTitle = _prefix "ParallelTitle"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/PermanentExportLicense"></see>
    /// </summary>
    let PermanentExportLicense = _prefix "PermanentExportLicense"
    /// <summary>
    /// This property relates a photo interepretation rendering to an anomaly revealed by a survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAnomaly"></see></summary>
    let hasAnomaly = _prefix "hasAnomaly"
    /// <summary>
    /// This property relates a photo interpretation rendering survey to the reliability of the information collected during the survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReliability"></see></summary>
    let hasReliability = _prefix "hasReliability"
    /// <summary>
    /// This property relates a photo interpretation rendering to the survey image.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyImage"></see></summary>
    let hasSurveyImage = _prefix "hasSurveyImage"
    /// <summary>
    /// This class represents the image analysed during a photo interpretation or rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/SurveyImage"></see></summary>
    let SurveyImage = _prefix "SurveyImage"
    /// <summary>
    /// This property represents specifications to make overlaps with other documents useful for reading and interpreting image analyzed during a photointerpretation or photo-repayment.
    /// <see href="https://w3id.org/arco/ontology/context-description/overlapSpecifications"></see></summary>
    let overlapSpecifications = _prefix "overlapSpecifications"
    /// <summary>
    /// This class represents the photographic documentation of an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicDocumentation"></see></summary>
    let PhotographicDocumentation = _prefix "PhotographicDocumentation"
    /// <summary>
    /// This property represents a synthetic caption, useful for understanding what is documented.
    /// <see href="https://w3id.org/arco/ontology/context-description/caption"></see></summary>
    let caption = _prefix "caption"
    /// <summary>
    /// This property represents aerial photos information about run and frame.
    /// <see href="https://w3id.org/arco/ontology/context-description/stripRunAndFrameNumber"></see></summary>
    let stripRunAndFrameNumber = _prefix "stripRunAndFrameNumber"
    /// <summary>
    /// This class represents a photographic series, that is a set of photographs created or published as a unit, from a library sciences point of view.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicSeries"></see></summary>
    let PhotographicSeries = _prefix "PhotographicSeries"
    /// <summary>
    /// This class represents a photographic subseries, that is a component of a photographic series.
    /// <see href="https://w3id.org/arco/ontology/context-description/PhotographicSubseries"></see></summary>
    let PhotographicSubseries = _prefix "PhotographicSubseries"
    /// <summary>
    /// This property relates a photographic series to the class that represents the membership relation between this photographic series and a cultural property that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isPhotographicSeriesIn"></see></summary>
    let isPhotographicSeriesIn = _prefix "isPhotographicSeriesIn"
    /// <summary>
    /// This property represents numbering of the photograph within editorial photographic series.
    /// <see href="https://w3id.org/arco/ontology/context-description/photographicSeriesItemNumber"></see></summary>
    let photographicSeriesItemNumber = _prefix "photographicSeriesItemNumber"
    /// <summary>
    /// This property relates the membership of a cultural entity (e.g. photographic heritage) to its photographic series. It is the inverse property of "isMemberPhotographicSeries".
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMemberOfPhotographicSeries"></see></summary>
    let hasMemberOfPhotographicSeries = _prefix "hasMemberOfPhotographicSeries"
    /// <summary>
    /// This property relates a photographic series a the cultural entity which belongs to it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPhotographicSeries"></see></summary>
    let hasPhotographicSeries = _prefix "hasPhotographicSeries"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/PointAnomaly"></see>
    /// </summary>
    let PointAnomaly = _prefix "PointAnomaly"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/PolygonAnomaly"></see>
    /// </summary>
    let PolygonAnomaly = _prefix "PolygonAnomaly"
    /// <summary>
    /// This class represents the preferred authorship attribution, most accredited or convincing.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreferredAuthorshipAttribution"></see></summary>
    let PreferredAuthorshipAttribution = _prefix "PreferredAuthorshipAttribution"
    /// <summary>
    /// This property represents geographical location and specific location of the work derived from the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkLocation"></see></summary>
    let preparatoryOrFinalWorkLocation = _prefix "preparatoryOrFinalWorkLocation"

    /// <summary>
    /// This property represents information relating to ancient or previous location of the work from which the matrix or print is ​​drawn.
    /// <see href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkPreviousLocation"></see></summary>
    let preparatoryOrFinalWorkPreviousLocation =
        _prefix "preparatoryOrFinalWorkPreviousLocation"

    /// <summary>
    /// This property represents the code which identifies the record relating to the final or preparatory work in relation with the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkRecordIdentifier"></see></summary>
    let preparatoryOrFinalWorkRecordIdentifier =
        _prefix "preparatoryOrFinalWorkRecordIdentifier"

    /// <summary>
    /// This property relates a cultural property or an entity or an activity related to it to an inventory.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasInventory"></see></summary>
    let hasInventory = _prefix "hasInventory"
    /// <summary>
    /// This property relates an entity to its dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDating"></see></summary>
    let hasDating = _prefix "hasDating"
    /// <summary>
    /// This individual represents cultural enity's previous use.
    /// <see href="https://w3id.org/arco/ontology/context-description/PreviousUse"></see></summary>
    let PreviousUse = _prefix "PreviousUse"
    /// <summary>
    /// This class represents a publication of which a print is, or was, part.
    /// <see href="https://w3id.org/arco/ontology/context-description/PrintInPublication"></see></summary>
    let PrintInPublication = _prefix "PrintInPublication"
    /// <summary>
    /// This class represents the role of a cultural entity's user.
    /// <see href="https://w3id.org/arco/ontology/context-description/Profession"></see></summary>
    let Profession = _prefix "Profession"
    /// <summary>
    /// This class represents the use function of an object.
    /// <see href="https://w3id.org/arco/ontology/context-description/UseFunction"></see></summary>
    let UseFunction = _prefix "UseFunction"
    /// <summary>
    /// It represents the title proper to subject of a print, an engraved matrix or a photograph.
    /// <see href="https://w3id.org/arco/ontology/context-description/ProperTitle"></see></summary>
    let ProperTitle = _prefix "ProperTitle"
    /// <summary>
    /// This class represents the protective measure, national or international, related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/ProtectiveMeasure"></see></summary>
    let ProtectiveMeasure = _prefix "ProtectiveMeasure"
    /// <summary>
    /// This property represents the date of notification of the administrative provision to the owner.
    /// <see href="https://w3id.org/arco/ontology/context-description/noticeDate"></see></summary>
    let noticeDate = _prefix "noticeDate"
    /// <summary>
    /// This property relates an international or national protective measure to the cultural enitity to which it is applied.
    /// <see href="https://w3id.org/arco/ontology/context-description/isProtectiveMeasureOf"></see></summary>
    let isProtectiveMeasureOf = _prefix "isProtectiveMeasureOf"
    /// <summary>
    /// This property relates an entity (e.g a cultural entity or a cultual entity's protective measure) to the proposing institution. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasProponentAgency"></see></summary>
    let hasProponentAgency = _prefix "hasProponentAgency"
    /// <summary>
    /// This property represents the date of the registration or the number of the Official Journal on which the decree was published.
    /// <see href="https://w3id.org/arco/ontology/context-description/registrationDateOrGU"></see></summary>
    let registrationDateOrGU = _prefix "registrationDateOrGU"
    /// <summary>
    /// This property represents issue date of an administrative provision or a certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/issueDate"></see></summary>
    let issueDate = _prefix "issueDate"
    /// <summary>
    /// This property represents date of interest declaration communication to the owner or holder.
    /// <see href="https://w3id.org/arco/ontology/context-description/openingNoticeDate"></see></summary>
    let openingNoticeDate = _prefix "openingNoticeDate"
    /// <summary>
    /// This class represents the reference catalogue that cites the copy of a print.
    /// <see href="https://w3id.org/arco/ontology/context-description/ReferenceCatalogue"></see></summary>
    let ReferenceCatalogue = _prefix "ReferenceCatalogue"
    /// <summary>
    /// This is the inverse property of "has reference catalogue".
    /// <see href="https://w3id.org/arco/ontology/context-description/isReferenceCatalogueOf"></see></summary>
    let isReferenceCatalogueOf = _prefix "isReferenceCatalogueOf"
    /// <summary>
    /// This property relates the situation in which a cultural property is related to another work with the related work itself (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.).
    /// <see href="https://w3id.org/arco/ontology/context-description/involvesRelatedWork"></see></summary>
    let involvesRelatedWork = _prefix "involvesRelatedWork"
    /// <summary>
    /// This property relates the relatioship between a cultural property and a related work (preparatory or final work) to the stage of the cultural property referring to this related work.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyStage"></see></summary>
    let hasCulturalPropertyStage = _prefix "hasCulturalPropertyStage"
    /// <summary>
    /// This property, inverse of 'has related work situation', relates a situation in which a cultural property is related to another work, that could even be another cultural property, to the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isRelatedWorkSituationOf"></see></summary>
    let isRelatedWorkSituationOf = _prefix "isRelatedWorkSituationOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/ReligiousCircumstance"></see>
    /// </summary>
    let ReligiousCircumstance = _prefix "ReligiousCircumstance"
    /// <summary>
    /// This property relates the print reproduction in a publication to the position in the publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReproductionPosition"></see></summary>
    let hasReproductionPosition = _prefix "hasReproductionPosition"
    /// <summary>
    /// This class represents the phisical position of a printed reproduction in a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/ReproductionPosition"></see></summary>
    let ReproductionPosition = _prefix "ReproductionPosition"
    /// <summary>
    /// This is the inverse property of "has reproduction".
    /// <see href="https://w3id.org/arco/ontology/context-description/isReproductionOf"></see></summary>
    let isReproductionOf = _prefix "isReproductionOf"
    /// <summary>
    /// This property relates the position of the print reproduction in a publication to the print reproduction itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReproductionPositionOf"></see></summary>
    let isReproductionPositionOf = _prefix "isReproductionPositionOf"
    /// <summary>
    /// This property represents information about page number or table number of publication in which the print appears.
    /// <see href="https://w3id.org/arco/ontology/context-description/pageOrTableNumber"></see></summary>
    let pageOrTableNumber = _prefix "pageOrTableNumber"
    /// <summary>
    /// This property relates a research to the research's scientific responsible. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResearchScientificDirector"></see></summary>
    let hasResearchScientificDirector = _prefix "hasResearchScientificDirector"
    /// <summary>
    /// This property relates the responsibility's identification to the agent which has that specific responsibility, focusing on the production process and dissemination of the photographic heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAgentWithResponsibility"></see></summary>
    let hasAgentWithResponsibility = _prefix "hasAgentWithResponsibility"
    /// <summary>
    /// This property relates a resposibility relative to some production or disclosure process which characterise photographic artefacts, to its responsibility type (i.e. printers, retouchers).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResponsibilityType"></see></summary>
    let hasResponsibilityType = _prefix "hasResponsibilityType"
    /// <summary>
    /// This property relates the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.) to photographic heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResponsibilityFor"></see></summary>
    let isResponsibilityFor = _prefix "isResponsibilityFor"
    /// <summary>
    /// This class represents the reuse of a cultural property or of one of its parts.
    /// This class represents cultural entity's reuse.
    /// <see href="https://w3id.org/arco/ontology/context-description/Reuse"></see></summary>
    let Reuse = _prefix "Reuse"
    /// <summary>
    /// This class represents a copy of a cultural property created by the same author of the original cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/SameAuthorCopy"></see></summary>
    let SameAuthorCopy = _prefix "SameAuthorCopy"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/SatellitePhotograph"></see>
    /// </summary>
    let SatellitePhotograph = _prefix "SatellitePhotograph"
    /// <summary>
    /// This property relates the representation scale to its graphic or cartographic representation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isScaleOf"></see></summary>
    let isScaleOf = _prefix "isScaleOf"
    /// <summary>
    /// This individual represents publication's secondary title.
    /// <see href="https://w3id.org/arco/ontology/context-description/SecondaryTitle"></see></summary>
    let SecondaryTitle = _prefix "SecondaryTitle"
    /// <summary>
    /// This class represents the interpretation of the sex of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/context-description/SexInterpretation"></see></summary>
    let SexInterpretation = _prefix "SexInterpretation"
    /// <summary>
    /// This property represents anthropological finding estimated sex.
    /// <see href="https://w3id.org/arco/ontology/context-description/sex"></see></summary>
    let sex = _prefix "sex"
    /// <summary>
    /// This property relates the sex estimate of an antropologic artifact to the related artifact.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSexInterpretationOf"></see></summary>
    let isSexInterpretationOf = _prefix "isSexInterpretationOf"
    /// <summary>
    /// This class represents source and document related to an object, e.g. a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/SourceAndDocument"></see></summary>
    let SourceAndDocument = _prefix "SourceAndDocument"
    /// <summary>
    /// This property represent document's folio number.
    /// <see href="https://w3id.org/arco/ontology/context-description/folio"></see></summary>
    let folio = _prefix "folio"
    /// <summary>
    /// This property relates a species to the biological taxon in which it is classified.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSpeciesIn"></see></summary>
    let isSpeciesIn = _prefix "isSpeciesIn"
    /// <summary>
    /// This individual represents the definition related to the kind of bibliography that specifically concerns the subject under examination.
    /// <see href="https://w3id.org/arco/ontology/context-description/SpecificBibliography"></see></summary>
    let SpecificBibliography = _prefix "SpecificBibliography"
    /// <summary>
    /// This property relates the stratigraphic unit from which a cultural property has been found to the related archeological excavation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isStratigraphicUnitOf"></see></summary>
    let isStratigraphicUnitOf = _prefix "isStratigraphicUnitOf"
    /// <summary>
    /// This individual represents cultural entity's structural use specifications.
    /// <see href="https://w3id.org/arco/ontology/context-description/StructuralUse"></see></summary>
    let StructuralUse = _prefix "StructuralUse"
    /// <summary>
    /// This class represents the subject of a cultural property, or its ornamental motif.
    /// <see href="https://w3id.org/arco/ontology/context-description/Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    /// This property relates a subject or ornamental motif to the cultural property or to the final or preparatory work of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSubjectOf"></see></summary>
    let isSubjectOf = _prefix "isSubjectOf"
    /// <summary>
    /// This property relates a subspecies to the biological taxon in which it is classified.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSubspeciesIn"></see></summary>
    let isSubspeciesIn = _prefix "isSubspeciesIn"
    /// <summary>
    /// This property relates a cultural entity's survey to the cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyOn"></see></summary>
    let isSurveyOn = _prefix "isSurveyOn"
    /// <summary>
    /// This is the inverse property of "has survey image".
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyImageOf"></see></summary>
    let isSurveyImageOf = _prefix "isSurveyImageOf"
    /// <summary>
    /// This property relates a survey image to its type (i.e. aerial photograph, Satellite photograph).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurveyImageType"></see></summary>
    let hasSurveyImageType = _prefix "hasSurveyImageType"
    /// <summary>
    /// This property represents the identification code that identifies the image examined during a photo-interpretation or photo-restoration investigation.
    /// <see href="https://w3id.org/arco/ontology/context-description/surveyImageIdentifier"></see></summary>
    let surveyImageIdentifier = _prefix "surveyImageIdentifier"
    /// <summary>
    /// This property relates the method adopted in a survey to the survey itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyMethodOf"></see></summary>
    let isSurveyMethodOf = _prefix "isSurveyMethodOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isSurveyMotivationOf"></see>
    /// </summary>
    let isSurveyMotivationOf = _prefix "isSurveyMotivationOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/TemporaryExportLicense"></see>
    /// </summary>
    let TemporaryExportLicense = _prefix "TemporaryExportLicense"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/TemporaryMovementCertification"></see>
    /// </summary>
    let TemporaryMovementCertification = _prefix "TemporaryMovementCertification"
    /// <summary>
    /// This property relates a cultural entity's title to its title type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasTitleType"></see></summary>
    let hasTitleType = _prefix "hasTitleType"
    /// <summary>
    /// This property relates a title to the entity to which it is referred.
    /// <see href="https://w3id.org/arco/ontology/context-description/isTitleOf"></see></summary>
    let isTitleOf = _prefix "isTitleOf"
    /// <summary>
    /// This is the inverse property of "has tomb".
    /// <see href="https://w3id.org/arco/ontology/context-description/isTombOf"></see></summary>
    let isTombOf = _prefix "isTombOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/UncertainOrigin"></see>
    /// </summary>
    let UncertainOrigin = _prefix "UncertainOrigin"
    /// <summary>
    /// This property relates an urban-planning instrument to the institution which issued the provision.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIssuingAgency"></see></summary>
    let hasIssuingAgency = _prefix "hasIssuingAgency"
    /// <summary>
    /// This property relates a urban planning instrument to the eligible intervention (e.g.: conservation intervention/ exceptional maintenance).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEligibleIntervention"></see></summary>
    let hasEligibleIntervention = _prefix "hasEligibleIntervention"
    /// <summary>
    /// This class relates a urban planning instrument to the related cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUrbanPlanningInstrumentOf"></see></summary>
    let isUrbanPlanningInstrumentOf = _prefix "isUrbanPlanningInstrumentOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/useConditions"></see>
    /// </summary>
    let useConditions = _prefix "useConditions"
    /// <summary>
    /// This property relates the use of a cultural entity to the related cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseOf"></see></summary>
    let isUseOf = _prefix "isUseOf"
    /// <summary>
    /// This property relates a cultural entity's use to its use type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUseType"></see></summary>
    let hasUseType = _prefix "hasUseType"
    /// <summary>
    /// This property represents object function.
    /// <see href="https://w3id.org/arco/ontology/context-description/useFunction"></see></summary>
    let useFunction = _prefix "useFunction"
    /// <summary>
    /// This property relates the use of a cultural property to the specification of the type of use.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUseTypeSpecification"></see></summary>
    let hasUseTypeSpecification = _prefix "hasUseTypeSpecification"
    /// <summary>
    /// This property relates an entity to its use function.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUseFunction"></see></summary>
    let hasUseFunction = _prefix "hasUseFunction"
    /// <summary>
    /// This individual represents the lack of available data regarding the type of use of a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/UseTypeUnavailable"></see></summary>
    let UseTypeUnavailable = _prefix "UseTypeUnavailable"
    /// <summary>
    /// This property represents a specific type of contact at which the agent is available.
    /// <see href="https://w3id.org/arco/ontology/context-description/address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// This property represents contacts of an agent (i.e. email, telephone number...)
    /// <see href="https://w3id.org/arco/ontology/context-description/contacts"></see></summary>
    let contacts = _prefix "contacts"
    /// <summary>
    /// This property allows you to associate generic chronological indications to an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/agentDate"></see></summary>
    let agentDate = _prefix "agentDate"
    /// <summary>
    /// This property represents the identification code, which identifies the author's reference unambiguously in the context of a local repertoire, of an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/agentLocalIdentifier"></see></summary>
    let agentLocalIdentifier = _prefix "agentLocalIdentifier"
    /// <summary>
    /// This property represents an entity's alternative title.
    /// <see href="https://w3id.org/arco/ontology/context-description/alternativeTitle"></see></summary>
    let alternativeTitle = _prefix "alternativeTitle"
    /// <summary>
    /// This property represents the title of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// This property represents an attributed title of a photograph, that is a title taken from archival, bibliographic, oral or iconographic sources, or created based on picture contents.
    /// <see href="https://w3id.org/arco/ontology/context-description/attributedTitle"></see></summary>
    let attributedTitle = _prefix "attributedTitle"
    /// <summary>
    /// This property allows you to associate the unique ICCD code with an author.
    /// <see href="https://w3id.org/arco/ontology/context-description/authorICCDIdentifier"></see></summary>
    let authorICCDIdentifier = _prefix "authorICCDIdentifier"
    /// <summary>
    /// This property represents a numerical or alphanumeric sequence that uniquely identifies the bibliographic reference within a local repertoire.
    /// <see href="https://w3id.org/arco/ontology/context-description/bibliographyLocalIdentifier"></see></summary>
    let bibliographyLocalIdentifier = _prefix "bibliographyLocalIdentifier"
    /// <summary>
    /// This property represents the collection identifier.
    /// <see href="https://w3id.org/arco/ontology/context-description/collectionIdentifier"></see></summary>
    let collectionIdentifier = _prefix "collectionIdentifier"
    /// <summary>
    /// This property represents document location, which can also be expressed by inventory location or identifier.
    /// <see href="https://w3id.org/arco/ontology/context-description/documentationLocation"></see></summary>
    let documentationLocation = _prefix "documentationLocation"
    /// <summary>
    /// This property represents document title or denomination.
    /// <see href="https://w3id.org/arco/ontology/context-description/documentationTitle"></see></summary>
    let documentationTitle = _prefix "documentationTitle"
    /// <summary>
    /// This property represents a cultural asset interpretation.
    /// <see href="https://w3id.org/arco/ontology/context-description/explanationNote"></see></summary>
    let explanationNote = _prefix "explanationNote"
    /// <summary>
    /// This property represents notes relating to methods for identifying and finding the cultural property in question.
    /// <see href="https://w3id.org/arco/ontology/context-description/findingNote"></see></summary>
    let findingNote = _prefix "findingNote"
    /// <summary>
    /// This property relates a cultual property involved in an acquisition event to the actual acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAcquisition"></see></summary>
    let hasAcquisition = _prefix "hasAcquisition"
    /// <summary>
    /// This property relates a cultural entity's acquisition type (i.e. donation, seizure) to its acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAcquisitionTypeOf"></see></summary>
    let isAcquisitionTypeOf = _prefix "isAcquisitionTypeOf"
    /// <summary>
    /// This property is used to associate an entity of any kind to an agent related to that entity in some way. It is used when it is not possible to express the relation in a more specific way.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasRelatedAgent"></see></summary>
    let hasRelatedAgent = _prefix "hasRelatedAgent"
    /// <summary>
    /// This is the inverse property of "has activity operator".
    /// <see href="https://w3id.org/arco/ontology/context-description/isActivityOperatorOf"></see></summary>
    let isActivityOperatorOf = _prefix "isActivityOperatorOf"
    /// <summary>
    /// This is the inverse property of "has activity responsible".
    /// <see href="https://w3id.org/arco/ontology/context-description/isActivityResponsibleOf"></see></summary>
    let isActivityResponsibleOf = _prefix "isActivityResponsibleOf"
    /// <summary>
    /// This is the inverse property of "has activity sponsor".
    /// <see href="https://w3id.org/arco/ontology/context-description/isActivitySponsorOf"></see></summary>
    let isActivitySponsorOf = _prefix "isActivitySponsorOf"
    /// <summary>
    /// This property relates an antropologic artifact to the interpretation of its age of death.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAgeOfDeathInterpretation"></see></summary>
    let hasAgeOfDeathInterpretation = _prefix "hasAgeOfDeathInterpretation"
    /// <summary>
    /// This is the inverse property of "has agent with responsibility".
    /// <see href="https://w3id.org/arco/ontology/context-description/isAgentWithResponsibilityIn"></see></summary>
    let isAgentWithResponsibilityIn = _prefix "isAgentWithResponsibilityIn"
    /// <summary>
    /// This property relates the type of an alternative dating to the related dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAlternativeDatingTypeOf"></see></summary>
    let isAlternativeDatingTypeOf = _prefix "isAlternativeDatingTypeOf"
    /// <summary>
    /// This property relates the origin of the anomaly (e.g. natural, unsure) to an anomaly detected during a photo interpretation or rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAnomalyOriginOf"></see></summary>
    let isAnomalyOriginOf = _prefix "isAnomalyOriginOf"
    /// <summary>
    /// This property relates the anomaly type (line, point, poligony anomaly) to an anomaly revealed by a photo interpretation rendering.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAnomalyTypeOf"></see></summary>
    let isAnomalyTypeOf = _prefix "isAnomalyTypeOf"

    /// <summary>
    /// This property relates the type of a survey to the related survey on an archaeological property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchaeologicalPropertySurveyTypeOf"></see></summary>
    let isArchaeologicalPropertySurveyTypeOf =
        _prefix "isArchaeologicalPropertySurveyTypeOf"

    /// <summary>
    /// This property relates the type of an arecheometric diagnostic survey (i.e. thermal imaging, coring) to the survey itself .
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchaeometricDiagnosticSurveyTypeOf"></see></summary>
    let isArchaeometricDiagnosticSurveyTypeOf =
        _prefix "isArchaeometricDiagnosticSurveyTypeOf"

    /// <summary>
    /// This property relates an archival record set to the relationship (membership) between the set itself and a cultural property that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchivalRecordSetIn"></see></summary>
    let isArchivalRecordSetIn = _prefix "isArchivalRecordSetIn"
    /// <summary>
    /// This property relates the documentation made of sources and documents to the archive or conservative institution.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasArchive"></see></summary>
    let hasArchive = _prefix "hasArchive"
    /// <summary>
    /// This property relates the archive or conservative institution to the documentation made of sources and documents.
    /// <see href="https://w3id.org/arco/ontology/context-description/isArchivedIn"></see></summary>
    let isArchivedIn = _prefix "isArchivedIn"
    /// <summary>
    /// This is the inverse property of "has associated object".
    /// <see href="https://w3id.org/arco/ontology/context-description/isObjectAssociatedTo"></see></summary>
    let isObjectAssociatedTo = _prefix "isObjectAssociatedTo"
    /// <summary>
    /// This is the inverse property of "has attributed author".
    /// <see href="https://w3id.org/arco/ontology/context-description/isAttributedAuthorIn"></see></summary>
    let isAttributedAuthorIn = _prefix "isAttributedAuthorIn"
    /// <summary>
    /// This property relates an agent to an entity the agent is author of.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAuthorOf"></see></summary>
    let isAuthorOf = _prefix "isAuthorOf"
    /// <summary>
    /// This property relates a cultural entity to an authorship or resposibility attribution of the entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasAuthorshipAttribution"></see></summary>
    let hasAuthorshipAttribution = _prefix "hasAuthorshipAttribution"

    /// <summary>
    /// This property relates the file's cataloguing institution to an entity described in a authority file.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAuthorityFileCataloguingAgencyOf"></see></summary>
    let isAuthorityFileCataloguingAgencyOf =
        _prefix "isAuthorityFileCataloguingAgencyOf"

    /// <summary>
    /// This property relates an entity to its bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasBibliography"></see></summary>
    let hasBibliography = _prefix "hasBibliography"
    /// <summary>
    /// This property relates the bibliography type to its bibliography.
    /// <see href="https://w3id.org/arco/ontology/context-description/isBibliographyTypeOf"></see></summary>
    let isBibliographyTypeOf = _prefix "isBibliographyTypeOf"
    /// <summary>
    /// This property relates a biological entity to a taxon.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasBiologicalTaxon"></see></summary>
    let hasBiologicalTaxon = _prefix "hasBiologicalTaxon"
    /// <summary>
    /// This property relates a cultural enity involved in a change of availability event (i.e. theft, destruction, recovery) to the event.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailability"></see></summary>
    let hasChangeOfAvailability = _prefix "hasChangeOfAvailability"
    /// <summary>
    /// This property relates the event type (i.e. theft, destruction, recovery) of a cultural entity change of availability to the change itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityTypeOf"></see></summary>
    let isChangeOfAvailabilityTypeOf = _prefix "isChangeOfAvailabilityTypeOf"
    /// <summary>
    /// This property relates the type of circumstance to the related circumstance.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCircumstanceTypeOf"></see></summary>
    let isCircumstanceTypeOf = _prefix "isCircumstanceTypeOf"
    /// <summary>
    /// This property relates a numismatic entity to its issuance.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCoinIssuance"></see></summary>
    let hasCoinIssuance = _prefix "hasCoinIssuance"
    /// <summary>
    /// This property relates a coin to a numismatic series which is member of.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCoinMemberOf"></see></summary>
    let isCoinMemberOf = _prefix "isCoinMemberOf"
    /// <summary>
    /// This property relates a collection to the relationship (membership) between the collection itself and a cultural property that is member of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCollectionIn"></see></summary>
    let isCollectionIn = _prefix "isCollectionIn"
    /// <summary>
    /// This property relates a collection of cultural properties to its collector.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCollector"></see></summary>
    let hasCollector = _prefix "hasCollector"
    /// <summary>
    /// This property relates a collector to its collection of cultural properties.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCollectorOf"></see></summary>
    let isCollectorOf = _prefix "isCollectorOf"
    /// <summary>
    /// This property relates a cultural entity to its commission.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCommission"></see></summary>
    let hasCommission = _prefix "hasCommission"
    /// <summary>
    /// This property relates an agent that is committent of a cultural property to the identification of the commission of that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCommittentIn"></see></summary>
    let isCommittentIn = _prefix "isCommittentIn"
    /// <summary>
    /// This property relates an entity to copiright held by an agent or its "public domain" condition, if it is out of copyright.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCopyright"></see></summary>
    let hasCopyright = _prefix "hasCopyright"
    /// <summary>
    /// This is the inverse property of "has copyright holder".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCopyrightHolderIn"></see></summary>
    let isCopyrightHolderIn = _prefix "isCopyrightHolderIn"
    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes its production site.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCreationLocation"></see></summary>
    let hasCreationLocation = _prefix "hasCreationLocation"
    /// <summary>
    /// This property relates a cultural property to a related work (e.g. copy, preparatory work).
    /// <see href="https://w3id.org/arco/ontology/context-description/hasRelatedWork"></see></summary>
    let hasRelatedWork = _prefix "hasRelatedWork"
    /// <summary>
    /// This is the inverse property of "has creation location".
    /// <see href="https://w3id.org/arco/ontology/context-description/isCreationLocationOf"></see></summary>
    let isCreationLocationOf = _prefix "isCreationLocationOf"
    /// <summary>
    /// This property relates a cultural entity's use to its cultural geographical area.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalGeographicArea"></see></summary>
    let hasCulturalGeographicArea = _prefix "hasCulturalGeographicArea"
    /// <summary>
    /// This property relates a cultural geographical area to the use of the cultural property which is present.
    /// <see href="https://w3id.org/arco/ontology/context-description/isCulturalGeographicAreaOf"></see></summary>
    let isCulturalGeographicAreaOf = _prefix "isCulturalGeographicAreaOf"
    /// <summary>
    /// This property relates a cultural property to the estimate of that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyEstimate"></see></summary>
    let hasCulturalPropertyEstimate = _prefix "hasCulturalPropertyEstimate"
    /// <summary>
    /// This property relates an entity to its estimate.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasEstimate"></see></summary>
    let hasEstimate = _prefix "hasEstimate"
    /// <summary>
    /// This property relates an event involving the cultural property, which the dating is about, to a dating.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDatingEventOf"></see></summary>
    let isDatingEventOf = _prefix "isDatingEventOf"
    /// <summary>
    /// This property relates the type of a work derivated from a cultural entity to its work derivated.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDerivatedWorkTypeOf"></see></summary>
    let isDerivatedWorkTypeOf = _prefix "isDerivatedWorkTypeOf"
    /// <summary>
    /// This property relates a cultural property to the detection method that allowed the detection of the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDetectionMethod"></see></summary>
    let hasDetectionMethod = _prefix "hasDetectionMethod"
    /// <summary>
    /// This property relates a cultural entity to the documentation related to the cutultural entity described in a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasDocumentation"></see></summary>
    let hasDocumentation = _prefix "hasDocumentation"
    /// <summary>
    /// This property relates the type of documentation to its documentation.
    /// <see href="https://w3id.org/arco/ontology/context-description/isDocumentationTypeOf"></see></summary>
    let isDocumentationTypeOf = _prefix "isDocumentationTypeOf"
    /// <summary>
    /// This is the inverse property of "has editor".
    /// <see href="https://w3id.org/arco/ontology/context-description/isEditorOf"></see></summary>
    let isEditorOf = _prefix "isEditorOf"
    /// <summary>
    /// This property relates a cultural entity to its import-export certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasExportImportCertification"></see></summary>
    let hasExportImportCertification = _prefix "hasExportImportCertification"
    /// <summary>
    /// This property relates the type (i.e. delivery confirmation certification, free movement certification etc) of an import-export certification of a cultural entity to the rrelated certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationTypeOf"></see></summary>
    let isExportImportCertificationTypeOf = _prefix "isExportImportCertificationTypeOf"
    /// <summary>
    /// This property relates an export office to an export/import certification.
    /// <see href="https://w3id.org/arco/ontology/context-description/isExportOfficeOf"></see></summary>
    let isExportOfficeOf = _prefix "isExportOfficeOf"
    /// <summary>
    /// This property relates a cultural property, and in particular an anthropological material, to its finding context.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFindingContext"></see></summary>
    let hasFindingContext = _prefix "hasFindingContext"
    /// <summary>
    /// This property relates a type of cultural property (i.e. anthropological material) finding context to its context.
    /// <see href="https://w3id.org/arco/ontology/context-description/isFindingContextTypeOf"></see></summary>
    let isFindingContextTypeOf = _prefix "isFindingContextTypeOf"
    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes the site where it was rediscovered.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFindingLocation"></see></summary>
    let hasFindingLocation = _prefix "hasFindingLocation"
    /// <summary>
    /// This is the inverse property of "has finding location".
    /// <see href="https://w3id.org/arco/ontology/context-description/isFindingLocationOf"></see></summary>
    let isFindingLocationOf = _prefix "isFindingLocationOf"
    /// <summary>
    /// This property relates garment to the context in which it has been worn.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasFruition"></see></summary>
    let hasFruition = _prefix "hasFruition"
    /// <summary>
    /// This property relates a cultural entity to a intervention on it, for conservational or other purposes.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasIntervention"></see></summary>
    let hasIntervention = _prefix "hasIntervention"
    /// <summary>
    /// This is the inverse property of "has intervention role".
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterventionRoleIn"></see></summary>
    let isInterventionRoleIn = _prefix "isInterventionRoleIn"
    /// <summary>
    /// This property relates the type of intervention on a cultural property to the related intervention.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInterventionTypeOf"></see></summary>
    let isInterventionTypeOf = _prefix "isInterventionTypeOf"

    /// <summary>
    /// This property relates the juridical container responsible for the inventory identifier of the cultural property to the inventory itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isInventoryIdentifierResponsibleOf"></see></summary>
    let isInventoryIdentifierResponsibleOf =
        _prefix "isInventoryIdentifierResponsibleOf"

    /// <summary>
    /// This is the inverse property of "has issuer".
    /// <see href="https://w3id.org/arco/ontology/context-description/isIssuerIn"></see></summary>
    let isIssuerIn = _prefix "isIssuerIn"
    /// <summary>
    /// This is the inverse property of "has issuing agency".
    /// <see href="https://w3id.org/arco/ontology/context-description/isIssuingAgencyOf"></see></summary>
    let isIssuingAgencyOf = _prefix "isIssuingAgencyOf"
    /// <summary>
    /// This is the inverse property of "has issuing state".
    /// <see href="https://w3id.org/arco/ontology/context-description/isIssuingStateIn"></see></summary>
    let isIssuingStateIn = _prefix "isIssuingStateIn"
    /// <summary>
    /// This property relates the laboratory test type (i.e. chemical or metallurgical analysis) to the related laboratory test.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLaboratoryTestTypeOf"></see></summary>
    let isLaboratoryTestTypeOf = _prefix "isLaboratoryTestTypeOf"
    /// <summary>
    /// This property relates an entity, for example a cultural entity, to its legal situation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasLegalSituation"></see></summary>
    let hasLegalSituation = _prefix "hasLegalSituation"
    /// <summary>
    /// This property relates a cultural property to the class that represents the membership relation between this cultural property and an archival record set.
    /// <see href="https://w3id.org/arco/ontology/context-description/isMemberOfArchivalRecordSetOf"></see></summary>
    let isMemberOfArchivalRecordSetOf = _prefix "isMemberOfArchivalRecordSetOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isMemberOfCollectionOf"></see>
    /// </summary>
    let isMemberOfCollectionOf = _prefix "isMemberOfCollectionOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/isMemberOfPhotographicSeriesIn"></see>
    /// </summary>
    let isMemberOfPhotographicSeriesIn = _prefix "isMemberOfPhotographicSeriesIn"
    /// <summary>
    /// This is the inverse property of "has mint".
    /// <see href="https://w3id.org/arco/ontology/context-description/isMintIn"></see></summary>
    let isMintIn = _prefix "isMintIn"
    /// <summary>
    /// This is the inverse property of "has minter".
    /// <see href="https://w3id.org/arco/ontology/context-description/isMinterIn"></see></summary>
    let isMinterIn = _prefix "isMinterIn"
    /// <summary>
    /// This property relates an musical instrument to the musical ensamble where the instument is (or were) played. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMusicalEnsemble"></see></summary>
    let hasMusicalEnsemble = _prefix "hasMusicalEnsemble"
    /// <summary>
    /// This property relates the musical ensamble where an instument is (or were) played to the related musical instrument.
    /// <see href="https://w3id.org/arco/ontology/context-description/isMusicalEnsembleOf"></see></summary>
    let isMusicalEnsembleOf = _prefix "isMusicalEnsembleOf"
    /// <summary>
    /// This property relates a musical instrument to the person who plays (in the present or past) a certain role as the instrument's exectutor. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasMusician"></see></summary>
    let hasMusician = _prefix "hasMusician"
    /// <summary>
    /// This property relates the person who plays (in the present or past) a certain role as a musical instrument's exectutor to the related instrument.
    /// <see href="https://w3id.org/arco/ontology/context-description/isMusicianOf"></see></summary>
    let isMusicianOf = _prefix "isMusicianOf"
    /// <summary>
    /// This property relates the type of observation survey (in the context, out of context) to the related observation survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isObservationSurveyTypeOf"></see></summary>
    let isObservationSurveyTypeOf = _prefix "isObservationSurveyTypeOf"
    /// <summary>
    /// This class relates an agent, that is the owner of a cultural property, to the legal situation of that cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/isOwnerIn"></see></summary>
    let isOwnerIn = _prefix "isOwnerIn"

    /// <summary>
    /// This property relates a cultural entity to another cultural entity, in an planning environmental relation.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPlanningEnvironmentalRelationWith"></see></summary>
    let hasPlanningEnvironmentalRelationWith =
        _prefix "hasPlanningEnvironmentalRelationWith"

    /// <summary>
    /// This is the inverse property of "has related work".
    /// <see href="https://w3id.org/arco/ontology/context-description/isWorkRelatedTo"></see></summary>
    let isWorkRelatedTo = _prefix "isWorkRelatedTo"
    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes its provenance location before its current position.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPreviousLocation"></see></summary>
    let hasPreviousLocation = _prefix "hasPreviousLocation"
    /// <summary>
    /// This is the inverse property of "has previous location".
    /// <see href="https://w3id.org/arco/ontology/context-description/isPreviousLocationOf"></see></summary>
    let isPreviousLocationOf = _prefix "isPreviousLocationOf"
    /// <summary>
    /// This property relates the previous owner of a cultural property to the acquisition by a new owner.
    /// <see href="https://w3id.org/arco/ontology/context-description/isPreviousOwnerOf"></see></summary>
    let isPreviousOwnerOf = _prefix "isPreviousOwnerOf"
    /// <summary>
    /// This property relates an intangible demoethnoanthropological property to its primary documentation, that is the documentation more representative of the intangible heritage.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasPrimaryDocumentation"></see></summary>
    let hasPrimaryDocumentation = _prefix "hasPrimaryDocumentation"
    /// <summary>
    /// This is the inverse property of "has primary documentation".
    /// <see href="https://w3id.org/arco/ontology/context-description/isPrimaryDocumentationOf"></see></summary>
    let isPrimaryDocumentationOf = _prefix "isPrimaryDocumentationOf"
    /// <summary>
    /// This property relates an agent to its job. For example the agent responsible of the production of a cultual entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasProfession"></see></summary>
    let hasProfession = _prefix "hasProfession"
    /// <summary>
    /// This is the inverse property of "has profession".
    /// <see href="https://w3id.org/arco/ontology/context-description/isProfessionOf"></see></summary>
    let isProfessionOf = _prefix "isProfessionOf"
    /// <summary>
    /// This property relates an agent that is a proponent agency of a protective measure of a cultural property to the protective measure or to the cultural entity itself. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/context-description/isProponentAgencyOf"></see></summary>
    let isProponentAgencyOf = _prefix "isProponentAgencyOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/hasProtectiveMeasure"></see>
    /// </summary>
    let hasProtectiveMeasure = _prefix "hasProtectiveMeasure"
    /// <summary>
    /// This property relates a print's copy to its reference catalogue.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReferenceCatalogue"></see></summary>
    let hasReferenceCatalogue = _prefix "hasReferenceCatalogue"
    /// <summary>
    /// This property is used to associate an agent related in some way to an entity of any kind to that entity. It is used when it is not possible to express the relation in a more specific way.
    /// <see href="https://w3id.org/arco/ontology/context-description/isAgentRelatedTo"></see></summary>
    let isAgentRelatedTo = _prefix "isAgentRelatedTo"
    /// <summary>
    /// This property relates a cultural property to a situation in which this cultural property is related to another work, that could even be another cultural property, as its preparatory or final phase.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasRelatedWorkSituation"></see></summary>
    let hasRelatedWorkSituation = _prefix "hasRelatedWorkSituation"
    /// <summary>
    /// This property relates the reliability of the information collected during the survey to a photo interpretation rendering survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReliabilityOf"></see></summary>
    let isReliabilityOf = _prefix "isReliabilityOf"
    /// <summary>
    /// This property relates a publication to the print reproduction which is or was part of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasReproduction"></see></summary>
    let hasReproduction = _prefix "hasReproduction"
    /// <summary>
    /// This property relates a culural entity to the research, which is the context where the enity's cataloguing record has been produced.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResearch"></see></summary>
    let hasResearch = _prefix "hasResearch"
    /// <summary>
    /// This property relates a research from which has been produced a cultural entity's catalogue record, to the cultural entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResearchOn"></see></summary>
    let isResearchOn = _prefix "isResearchOn"
    /// <summary>
    /// This property relates the research's scientific responsible to its research.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResearchScientificDirectorOf"></see></summary>
    let isResearchScientificDirectorOf = _prefix "isResearchScientificDirectorOf"
    /// <summary>
    /// This property relates a photographic cultural entity (photography or photographic fond) to the responsibility attribution of an agent. The agent is in charge of the production or disclosure process which characterises photographic heritage (i.e. printers, editors, distributors, sposors, collection responsibles etc.)
    /// <see href="https://w3id.org/arco/ontology/context-description/hasResponsibility"></see></summary>
    let hasResponsibility = _prefix "hasResponsibility"
    /// <summary>
    /// This property relates the esponsibility type (i.e. printers, retouchers) to the related resposibility relative to some production or disclosure process which characterise photographic artefacts.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResponsibilityTypeOf"></see></summary>
    let isResponsibilityTypeOf = _prefix "isResponsibilityTypeOf"
    /// <summary>
    /// This property relates the agent responsible for the cultural entity's inventory to the current inventory.
    /// <see href="https://w3id.org/arco/ontology/context-description/isResponsibleForInsertionOf"></see></summary>
    let isResponsibleForInsertionOf = _prefix "isResponsibleForInsertionOf"
    /// <summary>
    /// This property relates the secondary authors of an entity (i.e. a publication's contribution or section) to the related entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSecondaryAuthorOf"></see></summary>
    let isSecondaryAuthorOf = _prefix "isSecondaryAuthorOf"
    /// <summary>
    /// This property relates an antropologic artifact to its sex estimate.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSexInterpretation"></see></summary>
    let hasSexInterpretation = _prefix "hasSexInterpretation"
    /// <summary>
    /// This property relates a cultural property or a preparatory or final work of a cultural property to ist subject or ornamental motif.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSubject"></see></summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    /// This property relates a cultural entity's acquisition to its acquisition type.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasSurvey"></see></summary>
    let hasSurvey = _prefix "hasSurvey"
    /// <summary>
    /// This property relates the type of a survey image (i.e. aerial photograph, Satellite photograph) to the related survey image.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyImageTypeOf"></see></summary>
    let isSurveyImageTypeOf = _prefix "isSurveyImageTypeOf"
    /// <summary>
    /// This property relates the professional photographer who took the shot to the observation survey of a demo-etno-antropologic entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyPhotographerOf"></see></summary>
    let isSurveyPhotographerOf = _prefix "isSurveyPhotographerOf"
    /// <summary>
    /// This property relates the scientific director of a survey to the related survey.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveyScientificDirectorOf"></see></summary>
    let isSurveyScientificDirectorOf = _prefix "isSurveyScientificDirectorOf"
    /// <summary>
    /// This property relates the sound engineer who recorded an observation survey to the related observation survey of a demo-etno-antropologic entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isSurveySoundEngineerOf"></see></summary>
    let isSurveySoundEngineerOf = _prefix "isSurveySoundEngineerOf"
    /// <summary>
    /// This property relates the type of a cultural entity title to its title.
    /// <see href="https://w3id.org/arco/ontology/context-description/isTitleTypeOf"></see></summary>
    let isTitleTypeOf = _prefix "isTitleTypeOf"
    /// <summary>
    /// This class relates a cultural property to the related urban planning instrument.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUrbanPlanningInstrument"></see></summary>
    let hasUrbanPlanningInstrument = _prefix "hasUrbanPlanningInstrument"
    /// <summary>
    /// This property relates a cultural entity to its use.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUse"></see></summary>
    let hasUse = _prefix "hasUse"
    /// <summary>
    /// This property relates the use function of an entity to the related entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseFunctionOf"></see></summary>
    let isUseFunctionOf = _prefix "isUseFunctionOf"
    /// <summary>
    /// This property relates the type of a cultural entity use to its use.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseTypeOf"></see></summary>
    let isUseTypeOf = _prefix "isUseTypeOf"
    /// <summary>
    /// This property relates the specification of the type of a cultural property use to the related use.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUseTypeSpecificationOf"></see></summary>
    let isUseTypeSpecificationOf = _prefix "isUseTypeSpecificationOf"
    /// <summary>
    /// This property relates the user, intended as the agent who employed an entity, to the related entity.
    /// <see href="https://w3id.org/arco/ontology/context-description/isUserOf"></see></summary>
    let isUserOf = _prefix "isUserOf"
    /// <summary>
    /// This property relates the user of a cultural property to its social category.
    /// <see href="https://w3id.org/arco/ontology/context-description/hasUserSocialCategory"></see></summary>
    let hasUserSocialCategory = _prefix "hasUserSocialCategory"
    /// <summary>
    /// This property represents historical biographical information about an agent.
    /// <see href="https://w3id.org/arco/ontology/context-description/historicalBiographicalInformation"></see></summary>
    let historicalBiographicalInformation = _prefix "historicalBiographicalInformation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/context-description/historicalInformation"></see>
    /// </summary>
    let historicalInformation = _prefix "historicalInformation"
    /// <summary>
    /// This property represents the Iconclass code, for describing the subject or ornamental motif represented by the cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/iconclassCode"></see></summary>
    let iconclassCode = _prefix "iconclassCode"
    /// <summary>
    /// This property represents information collected on the place where the cultural entity is located or on the place where it was detected.
    /// <see href="https://w3id.org/arco/ontology/context-description/informationGatheredOnSite"></see></summary>
    let informationGatheredOnSite = _prefix "informationGatheredOnSite"
    /// <summary>
    /// This is the inverse property of 'is involved in', which relates a cultural entity to another involved cultural entity (e.g. immaterial).
    /// <see href="https://w3id.org/arco/ontology/context-description/involves"></see></summary>
    let involves = _prefix "involves"
    /// <summary>
    /// This property relates a cultural entity to another involved  cultural entity (e.g. immaterial).
    /// <see href="https://w3id.org/arco/ontology/context-description/isInvolvedIn"></see></summary>
    let isInvolvedIn = _prefix "isInvolvedIn"
    /// <summary>
    /// This property relates a work related to a cultural property (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.) to the situation in which that work is related to the cultural property itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/isRelatedWorkInvolvedIn"></see></summary>
    let isRelatedWorkInvolvedIn = _prefix "isRelatedWorkInvolvedIn"
    /// <summary>
    /// This property represents the location of the asset in its environment, i.e. the place where it is stored when not in use.
    /// <see href="https://w3id.org/arco/ontology/context-description/isKeptIn"></see></summary>
    let isKeptIn = _prefix "isKeptIn"
    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity which constitutes its location area.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLocatedIn"></see></summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    /// This property, inverse of 'is located in', relates a cultural entity to a connected cultural entity, which constitutes its location area.
    /// <see href="https://w3id.org/arco/ontology/context-description/isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
    /// <summary>
    /// This property relates a print to the reproduction of that print in a publication.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReproducedBy"></see></summary>
    let isReproducedBy = _prefix "isReproducedBy"
    /// <summary>
    /// This property relates the reproduction of an print in a publication to the print itself.
    /// <see href="https://w3id.org/arco/ontology/context-description/reproduces"></see></summary>
    let reproduces = _prefix "reproduces"
    /// <summary>
    /// This property relates a cultural entity to a connected cultural entity that reuse it or a part of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/isReusedBy"></see></summary>
    let isReusedBy = _prefix "isReusedBy"
    /// <summary>
    /// This is the invers property of 'is reused by', which relates a cultural entity to a connected cultural entity that reuse it or a part of it.
    /// <see href="https://w3id.org/arco/ontology/context-description/reuses"></see></summary>
    let reuses = _prefix "reuses"
    /// <summary>
    /// This property represents photograph copies numbering.
    /// <see href="https://w3id.org/arco/ontology/context-description/numberInCirculation"></see></summary>
    let numberInCirculation = _prefix "numberInCirculation"
    /// <summary>
    /// This property represents the parallel title of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/parallelTitle"></see></summary>
    let parallelTitle = _prefix "parallelTitle"
    /// <summary>
    /// This property represents numbering of the photograph within the editorial photographic subseries.
    /// <see href="https://w3id.org/arco/ontology/context-description/photographicSubseriesItemNumber"></see></summary>
    let photographicSubseriesItemNumber = _prefix "photographicSubseriesItemNumber"
    /// <summary>
    /// This property represents the proper title of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/context-description/properTitle"></see></summary>
    let properTitle = _prefix "properTitle"
    /// <summary>
    /// This property represents general notes on the relationships established between the property in question and other works.
    /// <see href="https://w3id.org/arco/ontology/context-description/relatedWorkNote"></see></summary>
    let relatedWorkNote = _prefix "relatedWorkNote"
    /// <summary>
    /// This property represents any references to documents that affect cultural entity acquisition.
    /// <see href="https://w3id.org/arco/ontology/context-description/relevantLegalAct"></see></summary>
    let relevantLegalAct = _prefix "relevantLegalAct"
    /// <summary>
    /// This property relates the event (creation, distruction) to which a dating of a cultural property is related to the "specific time", as the dating expressed in year or as a date yyyy/mm/dd.
    /// <see href="https://w3id.org/arco/ontology/context-description/specificTime"></see></summary>
    let specificTime = _prefix "specificTime"
    /// <summary>
    /// This property relates the "specific time", as the dating expressed in year or as a date yyyy/mm/dd, with the event (creation, distruction) to which a dating of a cultural property is related to.
    /// <see href="https://w3id.org/arco/ontology/context-description/specificTimeOf"></see></summary>
    let specificTimeOf = _prefix "specificTimeOf"
    /// <summary>
    /// This property represents the subject of a cultural property, or its ornamental motif.
    /// <see href="https://w3id.org/arco/ontology/context-description/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// This property represents the author that described the species and the date of description.
    /// <see href="https://w3id.org/arco/ontology/context-description/taxonAuthorAndDate"></see></summary>
    let taxonAuthorAndDate = _prefix "taxonAuthorAndDate"
