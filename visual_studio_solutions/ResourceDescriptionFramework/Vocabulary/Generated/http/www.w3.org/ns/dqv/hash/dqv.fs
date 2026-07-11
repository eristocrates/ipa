namespace Dqv.Namespace

module dqv =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://www.w3.org/ns/dqv#"
            (Some @"https://www.w3.org/ns/dqv.ttl")
            (Some @"dqv")
            None

    let Category = { _prefixID with _localName = "Category" }
    let Dimension = { _prefixID with _localName = "Dimension" }
    let Metric = { _prefixID with _localName = "Metric" }
    let QualityAnnotation = { _prefixID with _localName = "QualityAnnotation" }
    let QualityCertificate = { _prefixID with _localName = "QualityCertificate" }
    let QualityMeasurement = { _prefixID with _localName = "QualityMeasurement" }

    let QualityMeasurementDataset =
        { _prefixID with _localName = "QualityMeasurementDataset" }

    let QualityMetadata = { _prefixID with _localName = "QualityMetadata" }
    let QualityPolicy = { _prefixID with _localName = "QualityPolicy" }
    let UserQualityFeedback = { _prefixID with _localName = "UserQualityFeedback" }
    let computedOn = { _prefixID with _localName = "computedOn" }
    let expectedDataType = { _prefixID with _localName = "expectedDataType" }
    let hasQualityAnnotation = { _prefixID with _localName = "hasQualityAnnotation" }
    let hasQualityMeasurement = { _prefixID with _localName = "hasQualityMeasurement" }
    let hasQualityMetadata = { _prefixID with _localName = "hasQualityMetadata" }
    let inCategory = { _prefixID with _localName = "inCategory" }
    let inDimension = { _prefixID with _localName = "inDimension" }
    let isMeasurementOf = { _prefixID with _localName = "isMeasurementOf" }
    let precision = { _prefixID with _localName = "precision" }
    let qualityAssessment = { _prefixID with _localName = "qualityAssessment" }
    let value = { _prefixID with _localName = "value" }
