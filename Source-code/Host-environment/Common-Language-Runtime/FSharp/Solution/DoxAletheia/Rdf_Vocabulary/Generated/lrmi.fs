namespace http.purl.org.dcx.lrmi_terms.slash

open DoxAletheia

module lrmi =
    let _namespace_name = "http://purl.org/dcx/lrmi-terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-terms/1.1/"></see>
    /// </summary>
    let ``_1.1/`` = _prefix "1.1/"
    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/AlignmentObject"></see></summary>
    let AlignmentObject = _prefix "AlignmentObject"
    /// <summary>
    /// An individual or group for whom the learning resource was created or useful.
    /// <see href="http://purl.org/dcx/lrmi-terms/EducationalAudience"></see></summary>
    let EducationalAudience = _prefix "EducationalAudience"
    /// <summary>
    /// A persistent resource that has one or more physical or digital representations, and that explicitly involves, specifies or entails a learning activity or learning experience.
    /// <see href="http://purl.org/dcx/lrmi-terms/LearningResource"></see></summary>
    let LearningResource = _prefix "LearningResource"
    /// <summary>
    /// A category of alignment between the learning resource and the framework node.
    /// <see href="http://purl.org/dcx/lrmi-terms/alignmentType"></see></summary>
    let alignmentType = _prefix "alignmentType"
    /// <summary>
    /// The item being described is intended to assess the competency or learning outcome defined by the referenced term.
    /// <see href="http://purl.org/dcx/lrmi-terms/assesses"></see></summary>
    let assesses = _prefix "assesses"
    /// <summary>
    /// An alignment to an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalAlignment"></see></summary>
    let educationalAlignment = _prefix "educationalAlignment"
    /// <summary>
    /// The framework to which the resource being described is aligned.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalFramework"></see></summary>
    let educationalFramework = _prefix "educationalFramework"
    /// <summary>
    /// The level of a resource in terms of progression through an educational or training context.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalLevel"></see></summary>
    let educationalLevel = _prefix "educationalLevel"
    /// <summary>
    /// The role that describes the target audience of the content.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalRole"></see></summary>
    let educationalRole = _prefix "educationalRole"
    /// <summary>
    /// The purpose of a work in the context of education.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalUse"></see></summary>
    let educationalUse = _prefix "educationalUse"
    /// <summary>
    /// The predominant mode of learning supported by the learning resource.
    /// <see href="http://purl.org/dcx/lrmi-terms/interactivityType"></see></summary>
    let interactivityType = _prefix "interactivityType"
    /// <summary>
    /// A resource from which this work is derived or from which it is a modification or adaption.
    /// <see href="http://purl.org/dcx/lrmi-terms/isBasedOnUrl"></see></summary>
    let isBasedOnUrl = _prefix "isBasedOnUrl"
    /// <summary>
    /// The predominant type or kind characterizing the learning resource.
    /// <see href="http://purl.org/dcx/lrmi-terms/learningResourceType"></see></summary>
    let learningResourceType = _prefix "learningResourceType"
    /// <summary>
    /// The description of a node in an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/targetDescription"></see></summary>
    let targetDescription = _prefix "targetDescription"
    /// <summary>
    /// The name of a node in an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/targetName"></see></summary>
    let targetName = _prefix "targetName"
    /// <summary>
    /// The URL of a node in an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/targetUrl"></see></summary>
    let targetUrl = _prefix "targetUrl"
    /// <summary>
    /// The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.
    /// <see href="http://purl.org/dcx/lrmi-terms/teaches"></see></summary>
    let teaches = _prefix "teaches"
    /// <summary>
    /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
    /// <see href="http://purl.org/dcx/lrmi-terms/timeRequired"></see></summary>
    let timeRequired = _prefix "timeRequired"
    /// <summary>
    /// The typical expected age range.
    /// <see href="http://purl.org/dcx/lrmi-terms/typicalAgeRange"></see></summary>
    let typicalAgeRange = _prefix "typicalAgeRange"
    /// <summary>
    /// The URL where the owner specifies permissions for using the   resource.
    /// <see href="http://purl.org/dcx/lrmi-terms/useRightsUrl"></see></summary>
    let useRightsUrl = _prefix "useRightsUrl"
