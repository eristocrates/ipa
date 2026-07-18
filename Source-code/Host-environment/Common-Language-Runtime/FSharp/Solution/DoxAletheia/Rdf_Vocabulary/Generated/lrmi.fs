namespace http.purl.org.dcx.lrmi_terms.slash

open DoxAletheia.Rdf_Vocabulary

module lrmi =
    let _namespace_name = "http://purl.org/dcx/lrmi-terms/"
    /// <summary>
    ///   <see href="http://purl.org/dcx/lrmi-terms/1.1/"></see>
    /// </summary>
    let ``_1.1/`` = Namespaced_IRI.parse _namespace_name "1.1/" |> NamespacedName

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/AlignmentObject"></see></summary>
    let AlignmentObject =
        Namespaced_IRI.parse _namespace_name "AlignmentObject" |> NamespacedName

    /// <summary>
    /// An individual or group for whom the learning resource was created or useful.
    /// <see href="http://purl.org/dcx/lrmi-terms/EducationalAudience"></see></summary>
    let EducationalAudience =
        Namespaced_IRI.parse _namespace_name "EducationalAudience" |> NamespacedName

    /// <summary>
    /// A persistent resource that has one or more physical or digital representations, and that explicitly involves, specifies or entails a learning activity or learning experience.
    /// <see href="http://purl.org/dcx/lrmi-terms/LearningResource"></see></summary>
    let LearningResource =
        Namespaced_IRI.parse _namespace_name "LearningResource" |> NamespacedName

    /// <summary>
    /// A category of alignment between the learning resource and the framework node.
    /// <see href="http://purl.org/dcx/lrmi-terms/alignmentType"></see></summary>
    let alignmentType =
        Namespaced_IRI.parse _namespace_name "alignmentType" |> NamespacedName

    /// <summary>
    /// The item being described is intended to assess the competency or learning outcome defined by the referenced term.
    /// <see href="http://purl.org/dcx/lrmi-terms/assesses"></see></summary>
    let assesses = Namespaced_IRI.parse _namespace_name "assesses" |> NamespacedName

    /// <summary>
    /// An alignment to an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalAlignment"></see></summary>
    let educationalAlignment =
        Namespaced_IRI.parse _namespace_name "educationalAlignment" |> NamespacedName

    /// <summary>
    /// The framework to which the resource being described is aligned.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalFramework"></see></summary>
    let educationalFramework =
        Namespaced_IRI.parse _namespace_name "educationalFramework" |> NamespacedName

    /// <summary>
    /// The level of a resource in terms of progression through an educational or training context.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalLevel"></see></summary>
    let educationalLevel =
        Namespaced_IRI.parse _namespace_name "educationalLevel" |> NamespacedName

    /// <summary>
    /// The role that describes the target audience of the content.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalRole"></see></summary>
    let educationalRole =
        Namespaced_IRI.parse _namespace_name "educationalRole" |> NamespacedName

    /// <summary>
    /// The purpose of a work in the context of education.
    /// <see href="http://purl.org/dcx/lrmi-terms/educationalUse"></see></summary>
    let educationalUse =
        Namespaced_IRI.parse _namespace_name "educationalUse" |> NamespacedName

    /// <summary>
    /// The predominant mode of learning supported by the learning resource.
    /// <see href="http://purl.org/dcx/lrmi-terms/interactivityType"></see></summary>
    let interactivityType =
        Namespaced_IRI.parse _namespace_name "interactivityType" |> NamespacedName

    /// <summary>
    /// A resource from which this work is derived or from which it is a modification or adaption.
    /// <see href="http://purl.org/dcx/lrmi-terms/isBasedOnUrl"></see></summary>
    let isBasedOnUrl =
        Namespaced_IRI.parse _namespace_name "isBasedOnUrl" |> NamespacedName

    /// <summary>
    /// The predominant type or kind characterizing the learning resource.
    /// <see href="http://purl.org/dcx/lrmi-terms/learningResourceType"></see></summary>
    let learningResourceType =
        Namespaced_IRI.parse _namespace_name "learningResourceType" |> NamespacedName

    /// <summary>
    /// The description of a node in an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/targetDescription"></see></summary>
    let targetDescription =
        Namespaced_IRI.parse _namespace_name "targetDescription" |> NamespacedName

    /// <summary>
    /// The name of a node in an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/targetName"></see></summary>
    let targetName = Namespaced_IRI.parse _namespace_name "targetName" |> NamespacedName
    /// <summary>
    /// The URL of a node in an established educational framework.
    /// <see href="http://purl.org/dcx/lrmi-terms/targetUrl"></see></summary>
    let targetUrl = Namespaced_IRI.parse _namespace_name "targetUrl" |> NamespacedName
    /// <summary>
    /// The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.
    /// <see href="http://purl.org/dcx/lrmi-terms/teaches"></see></summary>
    let teaches = Namespaced_IRI.parse _namespace_name "teaches" |> NamespacedName

    /// <summary>
    /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
    /// <see href="http://purl.org/dcx/lrmi-terms/timeRequired"></see></summary>
    let timeRequired =
        Namespaced_IRI.parse _namespace_name "timeRequired" |> NamespacedName

    /// <summary>
    /// The typical expected age range.
    /// <see href="http://purl.org/dcx/lrmi-terms/typicalAgeRange"></see></summary>
    let typicalAgeRange =
        Namespaced_IRI.parse _namespace_name "typicalAgeRange" |> NamespacedName

    /// <summary>
    /// The URL where the owner specifies permissions for using the   resource.
    /// <see href="http://purl.org/dcx/lrmi-terms/useRightsUrl"></see></summary>
    let useRightsUrl =
        Namespaced_IRI.parse _namespace_name "useRightsUrl" |> NamespacedName
