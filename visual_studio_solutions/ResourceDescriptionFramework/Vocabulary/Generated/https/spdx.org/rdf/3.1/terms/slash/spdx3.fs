namespace Spdx3.Namespace
module spdx3 =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3") None
    module AI_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/AI/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.AI") None 
        let AIPackage = {_prefixID with _localName = "AIPackage"}
        let EnergyConsumption = {_prefixID with _localName = "EnergyConsumption"}
        let EnergyConsumptionDescription = {_prefixID with _localName = "EnergyConsumptionDescription"}
        let EnergyUnitType = {_prefixID with _localName = "EnergyUnitType"}
        let SafetyRiskAssessmentType = {_prefixID with _localName = "SafetyRiskAssessmentType"}
        let autonomyType = {_prefixID with _localName = "autonomyType"}
        let domain = {_prefixID with _localName = "domain"}
        let energyConsumption = {_prefixID with _localName = "energyConsumption"}
        let energyQuantity = {_prefixID with _localName = "energyQuantity"}
        let energyUnit = {_prefixID with _localName = "energyUnit"}
        let finetuningEnergyConsumption = {_prefixID with _localName = "finetuningEnergyConsumption"}
        let hyperparameter = {_prefixID with _localName = "hyperparameter"}
        let inferenceEnergyConsumption = {_prefixID with _localName = "inferenceEnergyConsumption"}
        let informationAboutApplication = {_prefixID with _localName = "informationAboutApplication"}
        let informationAboutTraining = {_prefixID with _localName = "informationAboutTraining"}
        let limitation = {_prefixID with _localName = "limitation"}
        let metric = {_prefixID with _localName = "metric"}
        let metricDecisionThreshold = {_prefixID with _localName = "metricDecisionThreshold"}
        let modelDataPreprocessing = {_prefixID with _localName = "modelDataPreprocessing"}
        let modelExplainability = {_prefixID with _localName = "modelExplainability"}
        let safetyRiskAssessment = {_prefixID with _localName = "safetyRiskAssessment"}
        let standardCompliance = {_prefixID with _localName = "standardCompliance"}
        let trainingEnergyConsumption = {_prefixID with _localName = "trainingEnergyConsumption"}
        let typeOfModel = {_prefixID with _localName = "typeOfModel"}
        let useSensitivePersonalInformation = {_prefixID with _localName = "useSensitivePersonalInformation"}
        module EnergyUnitType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.AI.EnergyUnitType") None 
            let kilowattHour = {_prefixID with _localName = "kilowattHour"}
            let megajoule = {_prefixID with _localName = "megajoule"}
            let other = {_prefixID with _localName = "other"}


        module SafetyRiskAssessmentType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.AI.SafetyRiskAssessmentType") None 
            let high = {_prefixID with _localName = "high"}
            let low = {_prefixID with _localName = "low"}
            let medium = {_prefixID with _localName = "medium"}
            let serious = {_prefixID with _localName = "serious"}




    module Build_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Build/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Build") None 
        let Build = {_prefixID with _localName = "Build"}
        let buildEndTime = {_prefixID with _localName = "buildEndTime"}
        let buildId = {_prefixID with _localName = "buildId"}
        let buildStartTime = {_prefixID with _localName = "buildStartTime"}
        let buildType = {_prefixID with _localName = "buildType"}
        let configSourceDigest = {_prefixID with _localName = "configSourceDigest"}
        let configSourceEntrypoint = {_prefixID with _localName = "configSourceEntrypoint"}
        let configSourceUri = {_prefixID with _localName = "configSourceUri"}
        let environment = {_prefixID with _localName = "environment"}
        let parameter = {_prefixID with _localName = "parameter"}


    module Core_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core") None 
        let Action = {_prefixID with _localName = "Action"}
        let Agent = {_prefixID with _localName = "Agent"}
        let Annotation = {_prefixID with _localName = "Annotation"}
        let AnnotationType = {_prefixID with _localName = "AnnotationType"}
        let Artifact = {_prefixID with _localName = "Artifact"}
        let Bom = {_prefixID with _localName = "Bom"}
        let Bundle = {_prefixID with _localName = "Bundle"}
        let ContactPointRelationship = {_prefixID with _localName = "ContactPointRelationship"}
        let ContactPointRelationshipType = {_prefixID with _localName = "ContactPointRelationshipType"}
        let CreationInfo = {_prefixID with _localName = "CreationInfo"}
        let DefinedProcess = {_prefixID with _localName = "DefinedProcess"}
        let DefinedType = {_prefixID with _localName = "DefinedType"}
        let DictionaryEntry = {_prefixID with _localName = "DictionaryEntry"}
        let Element = {_prefixID with _localName = "Element"}
        let ElementCollection = {_prefixID with _localName = "ElementCollection"}
        let ElementMap = {_prefixID with _localName = "ElementMap"}
        let ExternalIdentifier = {_prefixID with _localName = "ExternalIdentifier"}
        let ExternalIdentifierType = {_prefixID with _localName = "ExternalIdentifierType"}
        let ExternalMap = {_prefixID with _localName = "ExternalMap"}
        let ExternalRef = {_prefixID with _localName = "ExternalRef"}
        let ExternalRefType = {_prefixID with _localName = "ExternalRefType"}
        let Hash = {_prefixID with _localName = "Hash"}
        let HashAlgorithm = {_prefixID with _localName = "HashAlgorithm"}
        let IndividualElement = {_prefixID with _localName = "IndividualElement"}
        let IntegrityMethod = {_prefixID with _localName = "IntegrityMethod"}
        let IsoAutomationLevel = {_prefixID with _localName = "IsoAutomationLevel"}
        let LifecycleScopeType = {_prefixID with _localName = "LifecycleScopeType"}
        let LifecycleScopedRelationship = {_prefixID with _localName = "LifecycleScopedRelationship"}
        let Location = {_prefixID with _localName = "Location"}
        let MeasureOfLength = {_prefixID with _localName = "MeasureOfLength"}
        let MeasureOfMass = {_prefixID with _localName = "MeasureOfMass"}
        let NamespaceMap = {_prefixID with _localName = "NamespaceMap"}
        let NoAssertionElement = {_prefixID with _localName = "NoAssertionElement"}
        let NoneElement = {_prefixID with _localName = "NoneElement"}
        let Organization = {_prefixID with _localName = "Organization"}
        let PackageVerificationCode = {_prefixID with _localName = "PackageVerificationCode"}
        let Person = {_prefixID with _localName = "Person"}
        let PhysicalLocation = {_prefixID with _localName = "PhysicalLocation"}
        let PositiveIntegerRange = {_prefixID with _localName = "PositiveIntegerRange"}
        let PresenceType = {_prefixID with _localName = "PresenceType"}
        let ProcessReadinessType = {_prefixID with _localName = "ProcessReadinessType"}
        let ProfileIdentifierType = {_prefixID with _localName = "ProfileIdentifierType"}
        let Regulation = {_prefixID with _localName = "Regulation"}
        let Relationship = {_prefixID with _localName = "Relationship"}
        let RelationshipCompleteness = {_prefixID with _localName = "RelationshipCompleteness"}
        let RelationshipType = {_prefixID with _localName = "RelationshipType"}
        let Requirement = {_prefixID with _localName = "Requirement"}
        let SoftwareAgent = {_prefixID with _localName = "SoftwareAgent"}
        let SpdxDocument = {_prefixID with _localName = "SpdxDocument"}
        let SpdxOrganization = {_prefixID with _localName = "SpdxOrganization"}
        let Specification = {_prefixID with _localName = "Specification"}
        let SpecificationType = {_prefixID with _localName = "SpecificationType"}
        let SupportRelationship = {_prefixID with _localName = "SupportRelationship"}
        let SupportType = {_prefixID with _localName = "SupportType"}
        let Tool = {_prefixID with _localName = "Tool"}
        let UnitOfMeasure = {_prefixID with _localName = "UnitOfMeasure"}
        let actionEndTime = {_prefixID with _localName = "actionEndTime"}
        let actionLocation = {_prefixID with _localName = "actionLocation"}
        let actionStartTime = {_prefixID with _localName = "actionStartTime"}
        let additionalInformation = {_prefixID with _localName = "additionalInformation"}
        let algorithm = {_prefixID with _localName = "algorithm"}
        let annotationType = {_prefixID with _localName = "annotationType"}
        let beginIntegerRange = {_prefixID with _localName = "beginIntegerRange"}
        let builtTime = {_prefixID with _localName = "builtTime"}
        let city = {_prefixID with _localName = "city"}
        let comment = {_prefixID with _localName = "comment"}
        let completeness = {_prefixID with _localName = "completeness"}
        let contactType = {_prefixID with _localName = "contactType"}
        let contentType = {_prefixID with _localName = "contentType"}
        let context = {_prefixID with _localName = "context"}
        let country = {_prefixID with _localName = "country"}
        let countyCode = {_prefixID with _localName = "countyCode"}
        let created = {_prefixID with _localName = "created"}
        let createdBy = {_prefixID with _localName = "createdBy"}
        let createdUsing = {_prefixID with _localName = "createdUsing"}
        let creationInfo = {_prefixID with _localName = "creationInfo"}
        let dataLicense = {_prefixID with _localName = "dataLicense"}
        let definingArtifact = {_prefixID with _localName = "definingArtifact"}
        let definitionSource = {_prefixID with _localName = "definitionSource"}
        let description = {_prefixID with _localName = "description"}
        let devLifecycleStage = {_prefixID with _localName = "devLifecycleStage"}
        let element = {_prefixID with _localName = "element"}
        let elementValue = {_prefixID with _localName = "elementValue"}
        let endIntegerRange = {_prefixID with _localName = "endIntegerRange"}
        let endTime = {_prefixID with _localName = "endTime"}
        let extension = {_prefixID with _localName = "extension"}
        let externalIdentifier = {_prefixID with _localName = "externalIdentifier"}
        let externalIdentifierType = {_prefixID with _localName = "externalIdentifierType"}
        let externalRef = {_prefixID with _localName = "externalRef"}
        let externalRefType = {_prefixID with _localName = "externalRefType"}
        let externalSpdxId = {_prefixID with _localName = "externalSpdxId"}
        let from = {_prefixID with _localName = "from"}
        let geographicPointLocation = {_prefixID with _localName = "geographicPointLocation"}
        let hashValue = {_prefixID with _localName = "hashValue"}
        let headquartersLocation = {_prefixID with _localName = "headquartersLocation"}
        let identifier = {_prefixID with _localName = "identifier"}
        let identifierLocator = {_prefixID with _localName = "identifierLocator"}
        let import = {_prefixID with _localName = "import"}
        let inLanguage = {_prefixID with _localName = "inLanguage"}
        let intendedUse = {_prefixID with _localName = "intendedUse"}
        let isoAutomationLevel = {_prefixID with _localName = "isoAutomationLevel"}
        let issuingAuthority = {_prefixID with _localName = "issuingAuthority"}
        let key = {_prefixID with _localName = "key"}
        let locationHint = {_prefixID with _localName = "locationHint"}
        let locationTime = {_prefixID with _localName = "locationTime"}
        let locator = {_prefixID with _localName = "locator"}
        let name = {_prefixID with _localName = "name"}
        let ``namespace`` = {_prefixID with _localName = "namespace"}
        let namespaceMap = {_prefixID with _localName = "namespaceMap"}
        let originatedBy = {_prefixID with _localName = "originatedBy"}
        let packageVerificationCodeExcludedFile = {_prefixID with _localName = "packageVerificationCodeExcludedFile"}
        let postOfficeBoxNumber = {_prefixID with _localName = "postOfficeBoxNumber"}
        let postalCode = {_prefixID with _localName = "postalCode"}
        let postalName = {_prefixID with _localName = "postalName"}
        let prefix = {_prefixID with _localName = "prefix"}
        let processRationale = {_prefixID with _localName = "processRationale"}
        let processReadiness = {_prefixID with _localName = "processReadiness"}
        let processVersion = {_prefixID with _localName = "processVersion"}
        let profileConformance = {_prefixID with _localName = "profileConformance"}
        let provinceStateCode = {_prefixID with _localName = "provinceStateCode"}
        let quantity = {_prefixID with _localName = "quantity"}
        let relationshipType = {_prefixID with _localName = "relationshipType"}
        let releaseTime = {_prefixID with _localName = "releaseTime"}
        let requirementRationale = {_prefixID with _localName = "requirementRationale"}
        let requirementStatement = {_prefixID with _localName = "requirementStatement"}
        let requirementUUID = {_prefixID with _localName = "requirementUUID"}
        let rootElement = {_prefixID with _localName = "rootElement"}
        let scope = {_prefixID with _localName = "scope"}
        let specType = {_prefixID with _localName = "specType"}
        let specVersion = {_prefixID with _localName = "specVersion"}
        let standardName = {_prefixID with _localName = "standardName"}
        let startTime = {_prefixID with _localName = "startTime"}
        let statement = {_prefixID with _localName = "statement"}
        let streetAddress = {_prefixID with _localName = "streetAddress"}
        let subject = {_prefixID with _localName = "subject"}
        let summary = {_prefixID with _localName = "summary"}
        let suppliedBy = {_prefixID with _localName = "suppliedBy"}
        let supportLevel = {_prefixID with _localName = "supportLevel"}
        let ``to`` = {_prefixID with _localName = "to"}
        let typeFromSource = {_prefixID with _localName = "typeFromSource"}
        let unitQUDT = {_prefixID with _localName = "unitQUDT"}
        let validUntilTime = {_prefixID with _localName = "validUntilTime"}
        let value = {_prefixID with _localName = "value"}
        let verifiedUsing = {_prefixID with _localName = "verifiedUsing"}
        module AnnotationType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/AnnotationType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.AnnotationType") None 
            let other = {_prefixID with _localName = "other"}
            let review = {_prefixID with _localName = "review"}


        module ContactPointRelationshipType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.ContactPointRelationshipType") None 
            let compliance = {_prefixID with _localName = "compliance"}
            let other = {_prefixID with _localName = "other"}
            let securityVulnerability = {_prefixID with _localName = "securityVulnerability"}
            let support = {_prefixID with _localName = "support"}


        module ExternalIdentifierType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.ExternalIdentifierType") None 
            let cpe22 = {_prefixID with _localName = "cpe22"}
            let cpe23 = {_prefixID with _localName = "cpe23"}
            let cve = {_prefixID with _localName = "cve"}
            let duns = {_prefixID with _localName = "duns"}
            let email = {_prefixID with _localName = "email"}
            let evidenceUUID = {_prefixID with _localName = "evidenceUUID"}
            let gitoid = {_prefixID with _localName = "gitoid"}
            let gln = {_prefixID with _localName = "gln"}
            let glue = {_prefixID with _localName = "glue"}
            let gtin = {_prefixID with _localName = "gtin"}
            let hsCodes = {_prefixID with _localName = "hsCodes"}
            let lei = {_prefixID with _localName = "lei"}
            let other = {_prefixID with _localName = "other"}
            let packageUrl = {_prefixID with _localName = "packageUrl"}
            let phoneNumber = {_prefixID with _localName = "phoneNumber"}
            let requirementUUID = {_prefixID with _localName = "requirementUUID"}
            let securityOther = {_prefixID with _localName = "securityOther"}
            let swhid = {_prefixID with _localName = "swhid"}
            let swid = {_prefixID with _localName = "swid"}
            let urlScheme = {_prefixID with _localName = "urlScheme"}
            let verificationUUID = {_prefixID with _localName = "verificationUUID"}
            let webpage = {_prefixID with _localName = "webpage"}


        module ExternalRefType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.ExternalRefType") None 
            let altDownloadLocation = {_prefixID with _localName = "altDownloadLocation"}
            let altWebPage = {_prefixID with _localName = "altWebPage"}
            let binaryArtifact = {_prefixID with _localName = "binaryArtifact"}
            let bower = {_prefixID with _localName = "bower"}
            let buildMeta = {_prefixID with _localName = "buildMeta"}
            let buildSystem = {_prefixID with _localName = "buildSystem"}
            let certificationReport = {_prefixID with _localName = "certificationReport"}
            let chat = {_prefixID with _localName = "chat"}
            let componentAnalysisReport = {_prefixID with _localName = "componentAnalysisReport"}
            let cwe = {_prefixID with _localName = "cwe"}
            let documentation = {_prefixID with _localName = "documentation"}
            let dynamicAnalysisReport = {_prefixID with _localName = "dynamicAnalysisReport"}
            let eolNotice = {_prefixID with _localName = "eolNotice"}
            let exportControlAssessment = {_prefixID with _localName = "exportControlAssessment"}
            let funding = {_prefixID with _localName = "funding"}
            let issueTracker = {_prefixID with _localName = "issueTracker"}
            let license = {_prefixID with _localName = "license"}
            let mailingList = {_prefixID with _localName = "mailingList"}
            let mavenCentral = {_prefixID with _localName = "mavenCentral"}
            let metrics = {_prefixID with _localName = "metrics"}
            let npm = {_prefixID with _localName = "npm"}
            let nuget = {_prefixID with _localName = "nuget"}
            let other = {_prefixID with _localName = "other"}
            let privacyAssessment = {_prefixID with _localName = "privacyAssessment"}
            let productMetadata = {_prefixID with _localName = "productMetadata"}
            let purchaseOrder = {_prefixID with _localName = "purchaseOrder"}
            let qualityAssessmentReport = {_prefixID with _localName = "qualityAssessmentReport"}
            let releaseHistory = {_prefixID with _localName = "releaseHistory"}
            let releaseNotes = {_prefixID with _localName = "releaseNotes"}
            let riskAssessment = {_prefixID with _localName = "riskAssessment"}
            let runtimeAnalysisReport = {_prefixID with _localName = "runtimeAnalysisReport"}
            let secureSoftwareAttestation = {_prefixID with _localName = "secureSoftwareAttestation"}
            let securityAdversaryModel = {_prefixID with _localName = "securityAdversaryModel"}
            let securityAdvisory = {_prefixID with _localName = "securityAdvisory"}
            let securityFix = {_prefixID with _localName = "securityFix"}
            let securityOther = {_prefixID with _localName = "securityOther"}
            let securityPenTestReport = {_prefixID with _localName = "securityPenTestReport"}
            let securityPolicy = {_prefixID with _localName = "securityPolicy"}
            let securityThreatModel = {_prefixID with _localName = "securityThreatModel"}
            let socialMedia = {_prefixID with _localName = "socialMedia"}
            let sourceArtifact = {_prefixID with _localName = "sourceArtifact"}
            let staticAnalysisReport = {_prefixID with _localName = "staticAnalysisReport"}
            let support = {_prefixID with _localName = "support"}
            let vcs = {_prefixID with _localName = "vcs"}
            let vulnerabilityDisclosureReport = {_prefixID with _localName = "vulnerabilityDisclosureReport"}
            let vulnerabilityExploitabilityAssessment = {_prefixID with _localName = "vulnerabilityExploitabilityAssessment"}
            let x509Cert = {_prefixID with _localName = "x509Cert"}


        module HashAlgorithm_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.HashAlgorithm") None 
            let adler32 = {_prefixID with _localName = "adler32"}
            let blake2b256 = {_prefixID with _localName = "blake2b256"}
            let blake2b384 = {_prefixID with _localName = "blake2b384"}
            let blake2b512 = {_prefixID with _localName = "blake2b512"}
            let blake3 = {_prefixID with _localName = "blake3"}
            let crystalsDilithium = {_prefixID with _localName = "crystalsDilithium"}
            let crystalsKyber = {_prefixID with _localName = "crystalsKyber"}
            let falcon = {_prefixID with _localName = "falcon"}
            let md2 = {_prefixID with _localName = "md2"}
            let md4 = {_prefixID with _localName = "md4"}
            let md5 = {_prefixID with _localName = "md5"}
            let md6 = {_prefixID with _localName = "md6"}
            let other = {_prefixID with _localName = "other"}
            let sha1 = {_prefixID with _localName = "sha1"}
            let sha224 = {_prefixID with _localName = "sha224"}
            let sha256 = {_prefixID with _localName = "sha256"}
            let sha384 = {_prefixID with _localName = "sha384"}
            let sha3_224 = {_prefixID with _localName = "sha3_224"}
            let sha3_256 = {_prefixID with _localName = "sha3_256"}
            let sha3_384 = {_prefixID with _localName = "sha3_384"}
            let sha3_512 = {_prefixID with _localName = "sha3_512"}
            let sha512 = {_prefixID with _localName = "sha512"}


        module IsoAutomationLevel_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.IsoAutomationLevel") None 
            let assistiveAutomation = {_prefixID with _localName = "assistiveAutomation"}
            let autonomous = {_prefixID with _localName = "autonomous"}
            let conditionalAutomation = {_prefixID with _localName = "conditionalAutomation"}
            let fullAutomation = {_prefixID with _localName = "fullAutomation"}
            let highAutomation = {_prefixID with _localName = "highAutomation"}
            let notAutomated = {_prefixID with _localName = "notAutomated"}
            let partialAutomation = {_prefixID with _localName = "partialAutomation"}


        module LifecycleScopeType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.LifecycleScopeType") None 
            let build = {_prefixID with _localName = "build"}
            let decommission = {_prefixID with _localName = "decommission"}
            let design = {_prefixID with _localName = "design"}
            let development = {_prefixID with _localName = "development"}
            let other = {_prefixID with _localName = "other"}
            let runtime = {_prefixID with _localName = "runtime"}
            let test = {_prefixID with _localName = "test"}
            let update = {_prefixID with _localName = "update"}


        module PresenceType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/PresenceType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.PresenceType") None 
            let no = {_prefixID with _localName = "no"}
            let noAssertion = {_prefixID with _localName = "noAssertion"}
            let yes = {_prefixID with _localName = "yes"}


        module ProcessReadinessType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.ProcessReadinessType") None 
            let active = {_prefixID with _localName = "active"}
            let draft = {_prefixID with _localName = "draft"}
            let obsolete = {_prefixID with _localName = "obsolete"}
            let other = {_prefixID with _localName = "other"}


        module ProfileIdentifierType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.ProfileIdentifierType") None 
            let ai = {_prefixID with _localName = "ai"}
            let build = {_prefixID with _localName = "build"}
            let core = {_prefixID with _localName = "core"}
            let dataset = {_prefixID with _localName = "dataset"}
            let expandedLicensing = {_prefixID with _localName = "expandedLicensing"}
            let extension = {_prefixID with _localName = "extension"}
            let hardware = {_prefixID with _localName = "hardware"}
            let lite = {_prefixID with _localName = "lite"}
            let security = {_prefixID with _localName = "security"}
            let simpleLicensing = {_prefixID with _localName = "simpleLicensing"}
            let software = {_prefixID with _localName = "software"}
            let supplyChain = {_prefixID with _localName = "supplyChain"}


        module RelationshipCompleteness_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.RelationshipCompleteness") None 
            let complete = {_prefixID with _localName = "complete"}
            let incomplete = {_prefixID with _localName = "incomplete"}
            let noAssertion = {_prefixID with _localName = "noAssertion"}


        module RelationshipType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/RelationshipType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.RelationshipType") None 
            let affects = {_prefixID with _localName = "affects"}
            let amendedBy = {_prefixID with _localName = "amendedBy"}
            let ancestorOf = {_prefixID with _localName = "ancestorOf"}
            let availableFrom = {_prefixID with _localName = "availableFrom"}
            let configures = {_prefixID with _localName = "configures"}
            let conformsTo = {_prefixID with _localName = "conformsTo"}
            let contains = {_prefixID with _localName = "contains"}
            let coordinatedBy = {_prefixID with _localName = "coordinatedBy"}
            let copiedTo = {_prefixID with _localName = "copiedTo"}
            let createdBy = {_prefixID with _localName = "createdBy"}
            let delegatedTo = {_prefixID with _localName = "delegatedTo"}
            let dependsOn = {_prefixID with _localName = "dependsOn"}
            let descendantOf = {_prefixID with _localName = "descendantOf"}
            let describes = {_prefixID with _localName = "describes"}
            let doesNotAffect = {_prefixID with _localName = "doesNotAffect"}
            let evaluatedOn = {_prefixID with _localName = "evaluatedOn"}
            let expandsTo = {_prefixID with _localName = "expandsTo"}
            let exploitCreatedBy = {_prefixID with _localName = "exploitCreatedBy"}
            let finetunedOn = {_prefixID with _localName = "finetunedOn"}
            let fixedBy = {_prefixID with _localName = "fixedBy"}
            let fixedIn = {_prefixID with _localName = "fixedIn"}
            let follows = {_prefixID with _localName = "follows"}
            let foundBy = {_prefixID with _localName = "foundBy"}
            let generates = {_prefixID with _localName = "generates"}
            let hasAddedFile = {_prefixID with _localName = "hasAddedFile"}
            let hasAssessmentFor = {_prefixID with _localName = "hasAssessmentFor"}
            let hasAssociatedVulnerability = {_prefixID with _localName = "hasAssociatedVulnerability"}
            let hasConcludedLicense = {_prefixID with _localName = "hasConcludedLicense"}
            let hasContactPoint = {_prefixID with _localName = "hasContactPoint"}
            let hasDataFile = {_prefixID with _localName = "hasDataFile"}
            let hasDeclaredLicense = {_prefixID with _localName = "hasDeclaredLicense"}
            let hasDeletedFile = {_prefixID with _localName = "hasDeletedFile"}
            let hasDependencyManifest = {_prefixID with _localName = "hasDependencyManifest"}
            let hasDistributionArtifact = {_prefixID with _localName = "hasDistributionArtifact"}
            let hasDocumentation = {_prefixID with _localName = "hasDocumentation"}
            let hasDynamicLink = {_prefixID with _localName = "hasDynamicLink"}
            let hasEvidence = {_prefixID with _localName = "hasEvidence"}
            let hasExample = {_prefixID with _localName = "hasExample"}
            let hasHost = {_prefixID with _localName = "hasHost"}
            let hasInput = {_prefixID with _localName = "hasInput"}
            let hasMetadata = {_prefixID with _localName = "hasMetadata"}
            let hasOptionalComponent = {_prefixID with _localName = "hasOptionalComponent"}
            let hasOptionalDependency = {_prefixID with _localName = "hasOptionalDependency"}
            let hasOutput = {_prefixID with _localName = "hasOutput"}
            let hasPrerequisite = {_prefixID with _localName = "hasPrerequisite"}
            let hasProvidedDependency = {_prefixID with _localName = "hasProvidedDependency"}
            let hasRequirement = {_prefixID with _localName = "hasRequirement"}
            let hasResolution = {_prefixID with _localName = "hasResolution"}
            let hasSpecification = {_prefixID with _localName = "hasSpecification"}
            let hasStaticLink = {_prefixID with _localName = "hasStaticLink"}
            let hasTest = {_prefixID with _localName = "hasTest"}
            let hasTestCase = {_prefixID with _localName = "hasTestCase"}
            let hasVariant = {_prefixID with _localName = "hasVariant"}
            let implementedBy = {_prefixID with _localName = "implementedBy"}
            let invokedBy = {_prefixID with _localName = "invokedBy"}
            let locatedAt = {_prefixID with _localName = "locatedAt"}
            let modifiedBy = {_prefixID with _localName = "modifiedBy"}
            let other = {_prefixID with _localName = "other"}
            let packagedBy = {_prefixID with _localName = "packagedBy"}
            let patchedBy = {_prefixID with _localName = "patchedBy"}
            let performedBy = {_prefixID with _localName = "performedBy"}
            let pretrainedOn = {_prefixID with _localName = "pretrainedOn"}
            let providesSupportFor = {_prefixID with _localName = "providesSupportFor"}
            let publishedBy = {_prefixID with _localName = "publishedBy"}
            let reportedBy = {_prefixID with _localName = "reportedBy"}
            let republishedBy = {_prefixID with _localName = "republishedBy"}
            let resolved = {_prefixID with _localName = "resolved"}
            let runsOn = {_prefixID with _localName = "runsOn"}
            let serializedInArtifact = {_prefixID with _localName = "serializedInArtifact"}
            let testedOn = {_prefixID with _localName = "testedOn"}
            let tracedToDetail = {_prefixID with _localName = "tracedToDetail"}
            let trainedOn = {_prefixID with _localName = "trainedOn"}
            let underInvestigationFor = {_prefixID with _localName = "underInvestigationFor"}
            let usesTool = {_prefixID with _localName = "usesTool"}
            let validatedOn = {_prefixID with _localName = "validatedOn"}
            let verifiedBy = {_prefixID with _localName = "verifiedBy"}


        module SpecificationType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/SpecificationType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.SpecificationType") None 
            let formalStandard = {_prefixID with _localName = "formalStandard"}
            let other = {_prefixID with _localName = "other"}
            let regulation = {_prefixID with _localName = "regulation"}
            let specification = {_prefixID with _localName = "specification"}


        module SupportType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Core/SupportType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Core.SupportType") None 
            let deployed = {_prefixID with _localName = "deployed"}
            let development = {_prefixID with _localName = "development"}
            let endOfSupport = {_prefixID with _localName = "endOfSupport"}
            let limitedSupport = {_prefixID with _localName = "limitedSupport"}
            let noAssertion = {_prefixID with _localName = "noAssertion"}
            let noSupport = {_prefixID with _localName = "noSupport"}
            let support = {_prefixID with _localName = "support"}




    module Dataset_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Dataset/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Dataset") None 
        let ConfidentialityLevelType = {_prefixID with _localName = "ConfidentialityLevelType"}
        let DatasetAvailabilityType = {_prefixID with _localName = "DatasetAvailabilityType"}
        let DatasetPackage = {_prefixID with _localName = "DatasetPackage"}
        let DatasetType = {_prefixID with _localName = "DatasetType"}
        let anonymizationMethodUsed = {_prefixID with _localName = "anonymizationMethodUsed"}
        let confidentialityLevel = {_prefixID with _localName = "confidentialityLevel"}
        let dataCollectionProcess = {_prefixID with _localName = "dataCollectionProcess"}
        let dataPreprocessing = {_prefixID with _localName = "dataPreprocessing"}
        let datasetAvailability = {_prefixID with _localName = "datasetAvailability"}
        let datasetNoise = {_prefixID with _localName = "datasetNoise"}
        let datasetSize = {_prefixID with _localName = "datasetSize"}
        let datasetType = {_prefixID with _localName = "datasetType"}
        let datasetUpdateMechanism = {_prefixID with _localName = "datasetUpdateMechanism"}
        let hasSensitivePersonalInformation = {_prefixID with _localName = "hasSensitivePersonalInformation"}
        let intendedUse = {_prefixID with _localName = "intendedUse"}
        let knownBias = {_prefixID with _localName = "knownBias"}
        let sensor = {_prefixID with _localName = "sensor"}
        module ConfidentialityLevelType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Dataset.ConfidentialityLevelType") None 
            let amber = {_prefixID with _localName = "amber"}
            let clear = {_prefixID with _localName = "clear"}
            let green = {_prefixID with _localName = "green"}
            let red = {_prefixID with _localName = "red"}


        module DatasetAvailabilityType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Dataset.DatasetAvailabilityType") None 
            let clickthrough = {_prefixID with _localName = "clickthrough"}
            let directDownload = {_prefixID with _localName = "directDownload"}
            let query = {_prefixID with _localName = "query"}
            let registration = {_prefixID with _localName = "registration"}
            let scrapingScript = {_prefixID with _localName = "scrapingScript"}


        module DatasetType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Dataset.DatasetType") None 
            let audio = {_prefixID with _localName = "audio"}
            let categorical = {_prefixID with _localName = "categorical"}
            let graph = {_prefixID with _localName = "graph"}
            let image = {_prefixID with _localName = "image"}
            let noAssertion = {_prefixID with _localName = "noAssertion"}
            let numeric = {_prefixID with _localName = "numeric"}
            let other = {_prefixID with _localName = "other"}
            let sensor = {_prefixID with _localName = "sensor"}
            let structured = {_prefixID with _localName = "structured"}
            let syntactic = {_prefixID with _localName = "syntactic"}
            let text = {_prefixID with _localName = "text"}
            let timeseries = {_prefixID with _localName = "timeseries"}
            let timestamp = {_prefixID with _localName = "timestamp"}
            let video = {_prefixID with _localName = "video"}




    module ExpandedLicensing_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/ExpandedLicensing/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.ExpandedLicensing") None 
        let ConjunctiveLicenseSet = {_prefixID with _localName = "ConjunctiveLicenseSet"}
        let CustomLicense = {_prefixID with _localName = "CustomLicense"}
        let CustomLicenseAddition = {_prefixID with _localName = "CustomLicenseAddition"}
        let DisjunctiveLicenseSet = {_prefixID with _localName = "DisjunctiveLicenseSet"}
        let ExtendableLicense = {_prefixID with _localName = "ExtendableLicense"}
        let IndividualLicensingInfo = {_prefixID with _localName = "IndividualLicensingInfo"}
        let License = {_prefixID with _localName = "License"}
        let LicenseAddition = {_prefixID with _localName = "LicenseAddition"}
        let ListedLicense = {_prefixID with _localName = "ListedLicense"}
        let ListedLicenseException = {_prefixID with _localName = "ListedLicenseException"}
        let NoAssertionLicense = {_prefixID with _localName = "NoAssertionLicense"}
        let NoneLicense = {_prefixID with _localName = "NoneLicense"}
        let OrLaterOperator = {_prefixID with _localName = "OrLaterOperator"}
        let WithAdditionOperator = {_prefixID with _localName = "WithAdditionOperator"}
        let additionText = {_prefixID with _localName = "additionText"}
        let deprecatedVersion = {_prefixID with _localName = "deprecatedVersion"}
        let isDeprecatedAdditionId = {_prefixID with _localName = "isDeprecatedAdditionId"}
        let isDeprecatedLicenseId = {_prefixID with _localName = "isDeprecatedLicenseId"}
        let isFsfLibre = {_prefixID with _localName = "isFsfLibre"}
        let isOsiApproved = {_prefixID with _localName = "isOsiApproved"}
        let licenseXml = {_prefixID with _localName = "licenseXml"}
        let listVersionAdded = {_prefixID with _localName = "listVersionAdded"}
        let ``member`` = {_prefixID with _localName = "member"}
        let obsoletedBy = {_prefixID with _localName = "obsoletedBy"}
        let seeAlso = {_prefixID with _localName = "seeAlso"}
        let standardAdditionTemplate = {_prefixID with _localName = "standardAdditionTemplate"}
        let standardLicenseHeader = {_prefixID with _localName = "standardLicenseHeader"}
        let standardLicenseTemplate = {_prefixID with _localName = "standardLicenseTemplate"}
        let subjectAddition = {_prefixID with _localName = "subjectAddition"}
        let subjectExtendableLicense = {_prefixID with _localName = "subjectExtendableLicense"}
        let subjectLicense = {_prefixID with _localName = "subjectLicense"}


    module Extension_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Extension/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Extension") None 
        let CdxPropertiesExtension = {_prefixID with _localName = "CdxPropertiesExtension"}
        let CdxPropertyEntry = {_prefixID with _localName = "CdxPropertyEntry"}
        let Extension = {_prefixID with _localName = "Extension"}
        let cdxPropName = {_prefixID with _localName = "cdxPropName"}
        let cdxPropValue = {_prefixID with _localName = "cdxPropValue"}
        let cdxProperty = {_prefixID with _localName = "cdxProperty"}


    module FunctionalSafety_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/FunctionalSafety/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.FunctionalSafety") None 
        let EvaluationResult = {_prefixID with _localName = "EvaluationResult"}
        let EvaluationResultType = {_prefixID with _localName = "EvaluationResultType"}
        let EvidenceRelationship = {_prefixID with _localName = "EvidenceRelationship"}
        let EvidenceType = {_prefixID with _localName = "EvidenceType"}
        let RequirementVerification = {_prefixID with _localName = "RequirementVerification"}
        let VerificationType = {_prefixID with _localName = "VerificationType"}
        let evaluation = {_prefixID with _localName = "evaluation"}
        let evaluationBasedOn = {_prefixID with _localName = "evaluationBasedOn"}
        let evaluationRationale = {_prefixID with _localName = "evaluationRationale"}
        let evidenceCategory = {_prefixID with _localName = "evidenceCategory"}
        let evidenceUUID = {_prefixID with _localName = "evidenceUUID"}
        let verificationMethod = {_prefixID with _localName = "verificationMethod"}
        let verificationPostcondition = {_prefixID with _localName = "verificationPostcondition"}
        let verificationPrecondition = {_prefixID with _localName = "verificationPrecondition"}
        let verificationRationale = {_prefixID with _localName = "verificationRationale"}
        let verificationUUID = {_prefixID with _localName = "verificationUUID"}
        module EvaluationResultType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.FunctionalSafety.EvaluationResultType") None 
            let fail = {_prefixID with _localName = "fail"}
            let inconclusive = {_prefixID with _localName = "inconclusive"}
            let pass = {_prefixID with _localName = "pass"}


        module EvidenceType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.FunctionalSafety.EvidenceType") None 
            let log = {_prefixID with _localName = "log"}
            let observation = {_prefixID with _localName = "observation"}
            let other = {_prefixID with _localName = "other"}
            let recording = {_prefixID with _localName = "recording"}
            let report = {_prefixID with _localName = "report"}


        module VerificationType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.FunctionalSafety.VerificationType") None 
            let analysis = {_prefixID with _localName = "analysis"}
            let assessment = {_prefixID with _localName = "assessment"}
            let audit = {_prefixID with _localName = "audit"}
            let demonstration = {_prefixID with _localName = "demonstration"}
            let inspection = {_prefixID with _localName = "inspection"}
            let other = {_prefixID with _localName = "other"}
            let review = {_prefixID with _localName = "review"}
            let test = {_prefixID with _localName = "test"}




    module Hardware_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Hardware/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Hardware") None 
        let BulkHardware = {_prefixID with _localName = "BulkHardware"}
        let Dimensions = {_prefixID with _localName = "Dimensions"}
        let Hardware = {_prefixID with _localName = "Hardware"}
        let PhysicalHardware = {_prefixID with _localName = "PhysicalHardware"}
        let ProductSpecification = {_prefixID with _localName = "ProductSpecification"}
        let VirtualHardware = {_prefixID with _localName = "VirtualHardware"}
        let VirtualHardwareModelType = {_prefixID with _localName = "VirtualHardwareModelType"}
        let additionalInformation = {_prefixID with _localName = "additionalInformation"}
        let additionalInformationSpecification = {_prefixID with _localName = "additionalInformationSpecification"}
        let batchNumber = {_prefixID with _localName = "batchNumber"}
        let bulkQuantity = {_prefixID with _localName = "bulkQuantity"}
        let category = {_prefixID with _localName = "category"}
        let centerOfMass = {_prefixID with _localName = "centerOfMass"}
        let dimensions = {_prefixID with _localName = "dimensions"}
        let hardwareVersion = {_prefixID with _localName = "hardwareVersion"}
        let hazard = {_prefixID with _localName = "hazard"}
        let itemVersion = {_prefixID with _localName = "itemVersion"}
        let mass = {_prefixID with _localName = "mass"}
        let massOfHardware = {_prefixID with _localName = "massOfHardware"}
        let partNumber = {_prefixID with _localName = "partNumber"}
        let productAgent = {_prefixID with _localName = "productAgent"}
        let releaseDate = {_prefixID with _localName = "releaseDate"}
        let serialNumber = {_prefixID with _localName = "serialNumber"}
        let virtualHardwareModel = {_prefixID with _localName = "virtualHardwareModel"}
        let xAxisLength = {_prefixID with _localName = "xAxisLength"}
        let yAxisLength = {_prefixID with _localName = "yAxisLength"}
        let zAxisLength = {_prefixID with _localName = "zAxisLength"}
        module VirtualHardwareModelType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Hardware.VirtualHardwareModelType") None 
            let cycle = {_prefixID with _localName = "cycle"}
            let ``function`` = {_prefixID with _localName = "function"}
            let other = {_prefixID with _localName = "other"}




    module Licensing_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Licensing/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Licensing") None 
        let NoAssertion = {_prefixID with _localName = "NoAssertion"}
        let None = {_prefixID with _localName = "None"}


    module Operations_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Operations/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Operations") None 
        let ExportControlClassification = {_prefixID with _localName = "ExportControlClassification"}
        let ExportControlClassificationAssessment = {_prefixID with _localName = "ExportControlClassificationAssessment"}
        let Project = {_prefixID with _localName = "Project"}
        let assessedElement = {_prefixID with _localName = "assessedElement"}
        let assessmentContext = {_prefixID with _localName = "assessmentContext"}
        let assessmentResult = {_prefixID with _localName = "assessmentResult"}
        let assessmentTimestamp = {_prefixID with _localName = "assessmentTimestamp"}
        let assessor = {_prefixID with _localName = "assessor"}
        let exportClassification = {_prefixID with _localName = "exportClassification"}
        let exportControlClassificationResult = {_prefixID with _localName = "exportControlClassificationResult"}
        let exportControlSpecification = {_prefixID with _localName = "exportControlSpecification"}
        let exportingCountry = {_prefixID with _localName = "exportingCountry"}
        let projectContract = {_prefixID with _localName = "projectContract"}
        let projectEndTime = {_prefixID with _localName = "projectEndTime"}
        let projectOwner = {_prefixID with _localName = "projectOwner"}
        let projectSponsor = {_prefixID with _localName = "projectSponsor"}
        let projectStartTime = {_prefixID with _localName = "projectStartTime"}
        let projectTitle = {_prefixID with _localName = "projectTitle"}
        let weight = {_prefixID with _localName = "weight"}


    module Security_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Security/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Security") None 
        let CvssSeverityType = {_prefixID with _localName = "CvssSeverityType"}
        let CvssV2VulnAssessmentRelationship = {_prefixID with _localName = "CvssV2VulnAssessmentRelationship"}
        let CvssV3VulnAssessmentRelationship = {_prefixID with _localName = "CvssV3VulnAssessmentRelationship"}
        let CvssV4VulnAssessmentRelationship = {_prefixID with _localName = "CvssV4VulnAssessmentRelationship"}
        let EpssVulnAssessmentRelationship = {_prefixID with _localName = "EpssVulnAssessmentRelationship"}
        let ExploitCatalogType = {_prefixID with _localName = "ExploitCatalogType"}
        let ExploitCatalogVulnAssessmentRelationship = {_prefixID with _localName = "ExploitCatalogVulnAssessmentRelationship"}
        let SsvcDecisionType = {_prefixID with _localName = "SsvcDecisionType"}
        let SsvcVulnAssessmentRelationship = {_prefixID with _localName = "SsvcVulnAssessmentRelationship"}
        let VexAffectedVulnAssessmentRelationship = {_prefixID with _localName = "VexAffectedVulnAssessmentRelationship"}
        let VexFixedVulnAssessmentRelationship = {_prefixID with _localName = "VexFixedVulnAssessmentRelationship"}
        let VexJustificationType = {_prefixID with _localName = "VexJustificationType"}
        let VexNotAffectedVulnAssessmentRelationship = {_prefixID with _localName = "VexNotAffectedVulnAssessmentRelationship"}
        let VexUnderInvestigationVulnAssessmentRelationship = {_prefixID with _localName = "VexUnderInvestigationVulnAssessmentRelationship"}
        let VexVulnAssessmentRelationship = {_prefixID with _localName = "VexVulnAssessmentRelationship"}
        let VulnAssessmentRelationship = {_prefixID with _localName = "VulnAssessmentRelationship"}
        let Vulnerability = {_prefixID with _localName = "Vulnerability"}
        let actionStatement = {_prefixID with _localName = "actionStatement"}
        let actionStatementTime = {_prefixID with _localName = "actionStatementTime"}
        let assessedElement = {_prefixID with _localName = "assessedElement"}
        let catalogType = {_prefixID with _localName = "catalogType"}
        let decisionType = {_prefixID with _localName = "decisionType"}
        let exploited = {_prefixID with _localName = "exploited"}
        let impactStatement = {_prefixID with _localName = "impactStatement"}
        let impactStatementTime = {_prefixID with _localName = "impactStatementTime"}
        let justificationType = {_prefixID with _localName = "justificationType"}
        let locator = {_prefixID with _localName = "locator"}
        let modifiedTime = {_prefixID with _localName = "modifiedTime"}
        let percentile = {_prefixID with _localName = "percentile"}
        let probability = {_prefixID with _localName = "probability"}
        let publishedTime = {_prefixID with _localName = "publishedTime"}
        let score = {_prefixID with _localName = "score"}
        let severity = {_prefixID with _localName = "severity"}
        let statusNotes = {_prefixID with _localName = "statusNotes"}
        let vectorString = {_prefixID with _localName = "vectorString"}
        let vexVersion = {_prefixID with _localName = "vexVersion"}
        let withdrawnTime = {_prefixID with _localName = "withdrawnTime"}
        module CvssSeverityType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Security.CvssSeverityType") None 
            let critical = {_prefixID with _localName = "critical"}
            let high = {_prefixID with _localName = "high"}
            let low = {_prefixID with _localName = "low"}
            let medium = {_prefixID with _localName = "medium"}
            let none = {_prefixID with _localName = "none"}


        module ExploitCatalogType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Security.ExploitCatalogType") None 
            let kev = {_prefixID with _localName = "kev"}
            let other = {_prefixID with _localName = "other"}


        module SsvcDecisionType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Security.SsvcDecisionType") None 
            let act = {_prefixID with _localName = "act"}
            let attend = {_prefixID with _localName = "attend"}
            let track = {_prefixID with _localName = "track"}
            let trackStar = {_prefixID with _localName = "trackStar"}


        module VexJustificationType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Security.VexJustificationType") None 
            let componentNotPresent = {_prefixID with _localName = "componentNotPresent"}
            let inlineMitigationsAlreadyExist = {_prefixID with _localName = "inlineMitigationsAlreadyExist"}
            let vulnerableCodeCannotBeControlledByAdversary = {_prefixID with _localName = "vulnerableCodeCannotBeControlledByAdversary"}
            let vulnerableCodeNotInExecutePath = {_prefixID with _localName = "vulnerableCodeNotInExecutePath"}
            let vulnerableCodeNotPresent = {_prefixID with _localName = "vulnerableCodeNotPresent"}




    module Service_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Service/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Service") None 
        let AuthenticationProtocolType = {_prefixID with _localName = "AuthenticationProtocolType"}
        let SoftwareService = {_prefixID with _localName = "SoftwareService"}
        let provider = {_prefixID with _localName = "provider"}
        let serverAuthenticationProtocol = {_prefixID with _localName = "serverAuthenticationProtocol"}
        let serviceHostingCountry = {_prefixID with _localName = "serviceHostingCountry"}
        module AuthenticationProtocolType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Service.AuthenticationProtocolType") None 
            let crl = {_prefixID with _localName = "crl"}
            let ocsp = {_prefixID with _localName = "ocsp"}
            let other = {_prefixID with _localName = "other"}
            let tls = {_prefixID with _localName = "tls"}




    module SimpleLicensing_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/SimpleLicensing/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.SimpleLicensing") None 
        let AnyLicenseInfo = {_prefixID with _localName = "AnyLicenseInfo"}
        let LicenseExpression = {_prefixID with _localName = "LicenseExpression"}
        let SimpleLicensingText = {_prefixID with _localName = "SimpleLicensingText"}
        let customIdToLicense = {_prefixID with _localName = "customIdToLicense"}
        let customIdToUri = {_prefixID with _localName = "customIdToUri"}
        let licenseExpression = {_prefixID with _localName = "licenseExpression"}
        let licenseListVersion = {_prefixID with _localName = "licenseListVersion"}
        let licenseText = {_prefixID with _localName = "licenseText"}


    module Software_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Software/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Software") None 
        let ContentIdentifier = {_prefixID with _localName = "ContentIdentifier"}
        let ContentIdentifierType = {_prefixID with _localName = "ContentIdentifierType"}
        let File = {_prefixID with _localName = "File"}
        let FileKindType = {_prefixID with _localName = "FileKindType"}
        let Package = {_prefixID with _localName = "Package"}
        let Sbom = {_prefixID with _localName = "Sbom"}
        let SbomType = {_prefixID with _localName = "SbomType"}
        let Snippet = {_prefixID with _localName = "Snippet"}
        let SoftwareArtifact = {_prefixID with _localName = "SoftwareArtifact"}
        let SoftwarePurpose = {_prefixID with _localName = "SoftwarePurpose"}
        let additionalPurpose = {_prefixID with _localName = "additionalPurpose"}
        let artifactSize = {_prefixID with _localName = "artifactSize"}
        let attributionText = {_prefixID with _localName = "attributionText"}
        let byteRange = {_prefixID with _localName = "byteRange"}
        let contentIdentifier = {_prefixID with _localName = "contentIdentifier"}
        let contentIdentifierType = {_prefixID with _localName = "contentIdentifierType"}
        let contentIdentifierValue = {_prefixID with _localName = "contentIdentifierValue"}
        let copyrightText = {_prefixID with _localName = "copyrightText"}
        let downloadLocation = {_prefixID with _localName = "downloadLocation"}
        let fileKind = {_prefixID with _localName = "fileKind"}
        let homePage = {_prefixID with _localName = "homePage"}
        let lineRange = {_prefixID with _localName = "lineRange"}
        let packageUrl = {_prefixID with _localName = "packageUrl"}
        let packageVersion = {_prefixID with _localName = "packageVersion"}
        let primaryPurpose = {_prefixID with _localName = "primaryPurpose"}
        let sbomType = {_prefixID with _localName = "sbomType"}
        let snippetFromFile = {_prefixID with _localName = "snippetFromFile"}
        let sourceInfo = {_prefixID with _localName = "sourceInfo"}
        module ContentIdentifierType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Software.ContentIdentifierType") None 
            let gitoid = {_prefixID with _localName = "gitoid"}
            let swhid = {_prefixID with _localName = "swhid"}


        module FileKindType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Software/FileKindType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Software.FileKindType") None 
            let directory = {_prefixID with _localName = "directory"}
            let file = {_prefixID with _localName = "file"}


        module SbomType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Software/SbomType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Software.SbomType") None 
            let analyzed = {_prefixID with _localName = "analyzed"}
            let build = {_prefixID with _localName = "build"}
            let deployed = {_prefixID with _localName = "deployed"}
            let design = {_prefixID with _localName = "design"}
            let runtime = {_prefixID with _localName = "runtime"}
            let source = {_prefixID with _localName = "source"}


        module SoftwarePurpose_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.Software.SoftwarePurpose") None 
            let application = {_prefixID with _localName = "application"}
            let archive = {_prefixID with _localName = "archive"}
            let bom = {_prefixID with _localName = "bom"}
            let configuration = {_prefixID with _localName = "configuration"}
            let container = {_prefixID with _localName = "container"}
            let data = {_prefixID with _localName = "data"}
            let device = {_prefixID with _localName = "device"}
            let deviceDriver = {_prefixID with _localName = "deviceDriver"}
            let diskImage = {_prefixID with _localName = "diskImage"}
            let documentation = {_prefixID with _localName = "documentation"}
            let evidence = {_prefixID with _localName = "evidence"}
            let executable = {_prefixID with _localName = "executable"}
            let file = {_prefixID with _localName = "file"}
            let filesystemImage = {_prefixID with _localName = "filesystemImage"}
            let firmware = {_prefixID with _localName = "firmware"}
            let framework = {_prefixID with _localName = "framework"}
            let install = {_prefixID with _localName = "install"}
            let library = {_prefixID with _localName = "library"}
            let manifest = {_prefixID with _localName = "manifest"}
            let model = {_prefixID with _localName = "model"}
            let ``module`` = {_prefixID with _localName = "module"}
            let operatingSystem = {_prefixID with _localName = "operatingSystem"}
            let other = {_prefixID with _localName = "other"}
            let patch = {_prefixID with _localName = "patch"}
            let platform = {_prefixID with _localName = "platform"}
            let requirement = {_prefixID with _localName = "requirement"}
            let source = {_prefixID with _localName = "source"}
            let specification = {_prefixID with _localName = "specification"}
            let test = {_prefixID with _localName = "test"}




    module SupplyChain_ =
        let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/SupplyChain/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.SupplyChain") None 
        let AssemblyAction = {_prefixID with _localName = "AssemblyAction"}
        let AssemblyProcess = {_prefixID with _localName = "AssemblyProcess"}
        let BoundaryCrossingAction = {_prefixID with _localName = "BoundaryCrossingAction"}
        let BoundaryDefinitionAction = {_prefixID with _localName = "BoundaryDefinitionAction"}
        let BoundaryDefinitionProcess = {_prefixID with _localName = "BoundaryDefinitionProcess"}
        let ChangeAction = {_prefixID with _localName = "ChangeAction"}
        let ChangeProcess = {_prefixID with _localName = "ChangeProcess"}
        let CreateAction = {_prefixID with _localName = "CreateAction"}
        let CreateProcess = {_prefixID with _localName = "CreateProcess"}
        let DefinedStateProcess = {_prefixID with _localName = "DefinedStateProcess"}
        let DestroyAction = {_prefixID with _localName = "DestroyAction"}
        let DestroyProcess = {_prefixID with _localName = "DestroyProcess"}
        let HarvestAction = {_prefixID with _localName = "HarvestAction"}
        let HarvestProcess = {_prefixID with _localName = "HarvestProcess"}
        let InspectionAction = {_prefixID with _localName = "InspectionAction"}
        let InspectionProcess = {_prefixID with _localName = "InspectionProcess"}
        let InstantiateVirtualHardwareProcess = {_prefixID with _localName = "InstantiateVirtualHardwareProcess"}
        let ManufactureAction = {_prefixID with _localName = "ManufactureAction"}
        let ManufactureProcess = {_prefixID with _localName = "ManufactureProcess"}
        let ModifyAction = {_prefixID with _localName = "ModifyAction"}
        let ModifyProcess = {_prefixID with _localName = "ModifyProcess"}
        let OutOfSpecAction = {_prefixID with _localName = "OutOfSpecAction"}
        let PlanAction = {_prefixID with _localName = "PlanAction"}
        let PlanProcess = {_prefixID with _localName = "PlanProcess"}
        let ReproduceAction = {_prefixID with _localName = "ReproduceAction"}
        let ReproduceProcess = {_prefixID with _localName = "ReproduceProcess"}
        let ResolutionAction = {_prefixID with _localName = "ResolutionAction"}
        let ResponsibilityChangeAction = {_prefixID with _localName = "ResponsibilityChangeAction"}
        let ResponsibilityChangeProcess = {_prefixID with _localName = "ResponsibilityChangeProcess"}
        let ResponsibilityType = {_prefixID with _localName = "ResponsibilityType"}
        let State = {_prefixID with _localName = "State"}
        let StateAction = {_prefixID with _localName = "StateAction"}
        let StorageAction = {_prefixID with _localName = "StorageAction"}
        let StorageProcess = {_prefixID with _localName = "StorageProcess"}
        let TestAction = {_prefixID with _localName = "TestAction"}
        let TestProcess = {_prefixID with _localName = "TestProcess"}
        let TransportAction = {_prefixID with _localName = "TransportAction"}
        let TransportProcess = {_prefixID with _localName = "TransportProcess"}
        let UseAction = {_prefixID with _localName = "UseAction"}
        let UseProcess = {_prefixID with _localName = "UseProcess"}
        let boundaryParameter = {_prefixID with _localName = "boundaryParameter"}
        let current = {_prefixID with _localName = "current"}
        let currentState = {_prefixID with _localName = "currentState"}
        let decisionProcess = {_prefixID with _localName = "decisionProcess"}
        let destructionPerformedBy = {_prefixID with _localName = "destructionPerformedBy"}
        let dropoffLocation = {_prefixID with _localName = "dropoffLocation"}
        let forDropoffLocation = {_prefixID with _localName = "forDropoffLocation"}
        let forPickupLocation = {_prefixID with _localName = "forPickupLocation"}
        let pickupLocation = {_prefixID with _localName = "pickupLocation"}
        let plannedCurrent = {_prefixID with _localName = "plannedCurrent"}
        let plannedInspectionLocation = {_prefixID with _localName = "plannedInspectionLocation"}
        let plannedPrevious = {_prefixID with _localName = "plannedPrevious"}
        let plannedProductOfResponsibilityChange = {_prefixID with _localName = "plannedProductOfResponsibilityChange"}
        let plannedStorageLocation = {_prefixID with _localName = "plannedStorageLocation"}
        let plannedTransportRoutes = {_prefixID with _localName = "plannedTransportRoutes"}
        let previous = {_prefixID with _localName = "previous"}
        let responsibilityCategory = {_prefixID with _localName = "responsibilityCategory"}
        let responsibilityChangedOn = {_prefixID with _localName = "responsibilityChangedOn"}
        let transportRoute = {_prefixID with _localName = "transportRoute"}
        let validState = {_prefixID with _localName = "validState"}
        module ResponsibilityType_ =
            let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/" (Some "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl") (Some "spdx3.SupplyChain.ResponsibilityType") None 
            let custody = {_prefixID with _localName = "custody"}
            let ownership = {_prefixID with _localName = "ownership"}