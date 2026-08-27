namespace http.purl.org.dcx.lrmi_terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcxlrmi =
    let _namespace_iri = Namespace_Iri dcxlrmi |> NamespaceIRI
    /// <summary>
    ///   <para>dcxlrmi:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/">http://purl.org/dcx/lrmi-terms/</seealso>
    let _prefix_iri = Prefixed_Name(dcxlrmi, "") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:1.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/1.1/">http://purl.org/dcx/lrmi-terms/1.1/</seealso>
    let ``_1.1/`` = Prefixed_Name(dcxlrmi, "1.1/") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:AlignmentObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An intangible item that describes an alignment between a learning resource and a node in an educational framework."</para>
    /// labels<para>"Alignment Object"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/AlignmentObject">http://purl.org/dcx/lrmi-terms/AlignmentObject</seealso>
    let AlignmentObject = Prefixed_Name(dcxlrmi, "AlignmentObject") |> PrefixedName

    /// <summary>
    ///   <para>dcxlrmi:EducationalAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An individual or group for whom the learning resource was created or useful."</para>
    /// labels<para>"Educational Audience"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/EducationalAudience">http://purl.org/dcx/lrmi-terms/EducationalAudience</seealso>
    let EducationalAudience =
        Prefixed_Name(dcxlrmi, "EducationalAudience") |> PrefixedName

    /// <summary>
    ///   <para>dcxlrmi:LearningResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A persistent resource that has one or more physical or digital representations, and that explicitly involves, specifies or entails a learning activity or learning experience."</para>
    /// labels<para>"Learning Resource"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/LearningResource">http://purl.org/dcx/lrmi-terms/LearningResource</seealso>
    let LearningResource = Prefixed_Name(dcxlrmi, "LearningResource") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:alignmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A category of alignment between the learning resource and the framework node."</para>
    /// labels<para>"Alignment Type"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/alignmentType">http://purl.org/dcx/lrmi-terms/alignmentType</seealso>
    let alignmentType = Prefixed_Name(dcxlrmi, "alignmentType") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:assesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The item being described is intended to assess the competency or learning outcome defined by the referenced term."</para>
    /// labels<para>"Assesses"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/assesses">http://purl.org/dcx/lrmi-terms/assesses</seealso>
    let assesses = Prefixed_Name(dcxlrmi, "assesses") |> PrefixedName

    /// <summary>
    ///   <para>dcxlrmi:educationalAlignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An alignment to an established educational framework."</para>
    /// labels<para>"Educational Alignment"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/educationalAlignment">http://purl.org/dcx/lrmi-terms/educationalAlignment</seealso>
    let educationalAlignment =
        Prefixed_Name(dcxlrmi, "educationalAlignment") |> PrefixedName

    /// <summary>
    ///   <para>dcxlrmi:educationalFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The framework to which the resource being described is aligned."</para>
    /// labels<para>"Educational Framework"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/educationalFramework">http://purl.org/dcx/lrmi-terms/educationalFramework</seealso>
    let educationalFramework =
        Prefixed_Name(dcxlrmi, "educationalFramework") |> PrefixedName

    /// <summary>
    ///   <para>dcxlrmi:educationalLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The level of a resource in terms of progression through an educational or training context."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Educational Level"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/educationalLevel">http://purl.org/dcx/lrmi-terms/educationalLevel</seealso>
    let educationalLevel = Prefixed_Name(dcxlrmi, "educationalLevel") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:educationalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The role that describes the target audience of the content."</para>
    /// labels<para>"Educational Role"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/educationalRole">http://purl.org/dcx/lrmi-terms/educationalRole</seealso>
    let educationalRole = Prefixed_Name(dcxlrmi, "educationalRole") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:educationalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The purpose of a work in the context of education."</para>
    /// labels<para>"Educational Use"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/educationalUse">http://purl.org/dcx/lrmi-terms/educationalUse</seealso>
    let educationalUse = Prefixed_Name(dcxlrmi, "educationalUse") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:interactivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The predominant mode of learning supported by the learning resource."</para>
    /// labels<para>"Interactivity Type"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/interactivityType">http://purl.org/dcx/lrmi-terms/interactivityType</seealso>
    let interactivityType = Prefixed_Name(dcxlrmi, "interactivityType") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:isBasedOnUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A resource from which this work is derived or from which it is a modification or adaption."</para>
    /// labels<para>"Is Based On"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/isBasedOnUrl">http://purl.org/dcx/lrmi-terms/isBasedOnUrl</seealso>
    let isBasedOnUrl = Prefixed_Name(dcxlrmi, "isBasedOnUrl") |> PrefixedName

    /// <summary>
    ///   <para>dcxlrmi:learningResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The predominant type or kind characterizing the learning resource."</para>
    /// labels<para>"Learning Resource Type"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/learningResourceType">http://purl.org/dcx/lrmi-terms/learningResourceType</seealso>
    let learningResourceType =
        Prefixed_Name(dcxlrmi, "learningResourceType") |> PrefixedName

    /// <summary>
    ///   <para>dcxlrmi:targetDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The description of a node in an established educational framework."</para>
    /// labels<para>"Target Description"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/targetDescription">http://purl.org/dcx/lrmi-terms/targetDescription</seealso>
    let targetDescription = Prefixed_Name(dcxlrmi, "targetDescription") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:targetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of a node in an established educational framework."</para>
    /// labels<para>"Target Name"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/targetName">http://purl.org/dcx/lrmi-terms/targetName</seealso>
    let targetName = Prefixed_Name(dcxlrmi, "targetName") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:targetUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URL of a node in an established educational framework."</para>
    /// labels<para>"Target URL"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/targetUrl">http://purl.org/dcx/lrmi-terms/targetUrl</seealso>
    let targetUrl = Prefixed_Name(dcxlrmi, "targetUrl") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:teaches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term."</para>
    /// labels<para>"Teaches"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/teaches">http://purl.org/dcx/lrmi-terms/teaches</seealso>
    let teaches = Prefixed_Name(dcxlrmi, "teaches") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:timeRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience."</para>
    /// labels<para>"Time Required"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/timeRequired">http://purl.org/dcx/lrmi-terms/timeRequired</seealso>
    let timeRequired = Prefixed_Name(dcxlrmi, "timeRequired") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:typicalAgeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The typical expected age range."</para>
    /// labels<para>"Typical Age Range"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/typicalAgeRange">http://purl.org/dcx/lrmi-terms/typicalAgeRange</seealso>
    let typicalAgeRange = Prefixed_Name(dcxlrmi, "typicalAgeRange") |> PrefixedName
    /// <summary>
    ///   <para>dcxlrmi:useRightsUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URL where the owner specifies permissions for using the   resource."</para>
    /// labels<para>"Use Rights URL"</para></remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-terms/useRightsUrl">http://purl.org/dcx/lrmi-terms/useRightsUrl</seealso>
    let useRightsUrl = Prefixed_Name(dcxlrmi, "useRightsUrl") |> PrefixedName
