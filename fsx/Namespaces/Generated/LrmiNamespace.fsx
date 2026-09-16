#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lrmi =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-terms/" "lrmi"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Alignment Object</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>rdfs:comment : An intangible item that describes an alignment between a learning resource and a node in an educational framework.</para>
    ///   <para>skos:scopeNote : This class should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource teaches or assesses a competency.^^xsd:string</para>
    ///   <para>skos:changeNote : 2020-11-12: Added scopeNote^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/AlignmentObject">lrmi:AlignmentObject</a>
    /// </summary>
    let AlignmentObject = _prefixId.prefix "AlignmentObject"
    /// <summary>
    ///   <para>rdfs:label : Educational Audience</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>rdfs:comment : An individual or group for whom the learning resource was created or useful.</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/EducationalAudience">lrmi:EducationalAudience</a>
    /// </summary>
    let EducationalAudience = _prefixId.prefix "EducationalAudience"
    /// <summary>
    ///   <para>rdfs:label : Learning Resource</para>
    ///   <para>dcterms:issued : 2020-11-12^^xsd:date</para>
    ///   <para>rdfs:comment : A persistent resource that has one or more physical or digital representations, and that explicitly involves, specifies or entails a learning activity or learning experience.</para>
    ///   <para>skos:scopeNote : LearningResource is expected to be used as an addition to a primary type such as http://purl.org/ontology/bibo/Book, https://schema.org/Video, http://purl.org/dc/terms/PhysicalResource etc.</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/LearningResource">lrmi:LearningResource</a>
    /// </summary>
    let LearningResource = _prefixId.prefix "LearningResource"
    /// <summary>
    ///   <para>rdfs:label : Alignment Type</para>
    ///   <para>rdfs:comment : A category of alignment between the learning resource and the framework node.</para>
    ///   <para>skos:scopeNote : Recommended values include: 'requires', 'textComplexity', 'readingLevel', and 'educationalSubject'. For 'assesses', 'teaches', and 'educationLevel' the specific properties with those names should be used.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2020-11-12: Added scopeNote; added skos:Concept to rangeIncludes.^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/alignmentType">lrmi:alignmentType</a>
    /// </summary>
    let alignmentType = _prefixId.prefix "alignmentType"
    /// <summary>
    ///   <para>rdfs:label : Assesses</para>
    ///   <para>rdfs:comment : The item being described is intended to assess the competency or learning outcome defined by the referenced term.</para>
    ///   <para>dcterms:issued : 2020-11-12^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/assesses">lrmi:assesses</a>
    /// </summary>
    let assesses = _prefixId.prefix "assesses"
    /// <summary>
    ///   <para>rdfs:label : Educational Alignment</para>
    ///   <para>rdfs:comment : An alignment to an established educational framework.</para>
    ///   <para>skos:scopeNote : This property should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource teaches or assesses a competency.^^xsd:string</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2020-11-12: added lrmi:LearningResource, schema:LearningResource to domain; added scopeNote^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/educationalAlignment">lrmi:educationalAlignment</a>
    /// </summary>
    let educationalAlignment = _prefixId.prefix "educationalAlignment"
    /// <summary>
    ///   <para>rdfs:label : Educational Framework</para>
    ///   <para>rdfs:comment : The framework to which the resource being described is aligned.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2023-07-31: fixed error in owl:equivalentProperty statement^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/educationalFramework">lrmi:educationalFramework</a>
    /// </summary>
    let educationalFramework = _prefixId.prefix "educationalFramework"
    /// <summary>
    ///   <para>rdfs:label : Educational Level</para>
    ///   <para>rdfs:comment : The level of a resource in terms of progression through an educational or training context.^^xsd:string</para>
    ///   <para>skos:scopeNote : Examples of educational levels include 'beginner', 'intermediate' or 'advanced', and formal sets of level indicators.</para>
    ///   <para>dcterms:issued : 2020-11-12^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/educationalLevel">lrmi:educationalLevel</a>
    /// </summary>
    let educationalLevel = _prefixId.prefix "educationalLevel"
    /// <summary>
    ///   <para>rdfs:label : Educational Role</para>
    ///   <para>rdfs:comment : The role that describes the target audience of the content.</para>
    ///   <para>skos:scopeNote : The educational function assumed or part played by the group for whom the resource is intended.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2020-11-12: Added skos:Concept to rangeIncludes^^xsd:stringskos:changeNote : 2022-06-14: Fixed error from adding skos:Concept to equivalent property instead of previous intended change^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/educationalRole">lrmi:educationalRole</a>
    /// </summary>
    let educationalRole = _prefixId.prefix "educationalRole"
    /// <summary>
    ///   <para>rdfs:label : Educational Use</para>
    ///   <para>rdfs:comment : The purpose of a work in the context of education.</para>
    ///   <para>skos:scopeNote : For example, 'assignment', 'group work'.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2020-11-12: added lrmi:LearningResource, schema:LearningResource to domain; added skos:Concept to rangeIncludes^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/educationalUse">lrmi:educationalUse</a>
    /// </summary>
    let educationalUse = _prefixId.prefix "educationalUse"
    /// <summary>
    ///   <para>rdfs:label : Interactivity Type</para>
    ///   <para>rdfs:comment : The predominant mode of learning supported by the learning resource.</para>
    ///   <para>skos:scopeNote : Acceptable values are 'active', 'expositive', or 'mixed'.skos:scopeNote : Based on, and mappable from, IEEE LOM 5.1: Interactivity Type.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2020-11-12: added lrmi:LearningResource, schema:LearningResource to domain; added skos:Concept to rangeIncludes^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/interactivityType">lrmi:interactivityType</a>
    /// </summary>
    let interactivityType = _prefixId.prefix "interactivityType"
    /// <summary>
    ///   <para>rdfs:label : Is Based On</para>
    ///   <para>rdfs:comment : A resource from which this work is derived or from which it is a modification or adaption.</para>
    ///   <para>skos:scopeNote : This term can be repeated for multiple sources.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/isBasedOnUrl">lrmi:isBasedOnUrl</a>
    /// </summary>
    let isBasedOnUrl = _prefixId.prefix "isBasedOnUrl"
    /// <summary>
    ///   <para>rdfs:label : Learning Resource Type</para>
    ///   <para>rdfs:comment : The predominant type or kind characterizing the learning resource.</para>
    ///   <para>skos:scopeNote : For example, 'presentation', 'handout'.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2020-11-12: added lrmi:LearningResource, schema:LearningResource to domain^^xsd:stringskos:changeNote : 2022-06-14: Added skos:Concept to rangeIncludes^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/learningResourceType">lrmi:learningResourceType</a>
    /// </summary>
    let learningResourceType = _prefixId.prefix "learningResourceType"
    /// <summary>
    ///   <para>rdfs:label : Target Description</para>
    ///   <para>rdfs:comment : The description of a node in an established educational framework.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/targetDescription">lrmi:targetDescription</a>
    /// </summary>
    let targetDescription = _prefixId.prefix "targetDescription"
    /// <summary>
    ///   <para>rdfs:label : Target Name</para>
    ///   <para>rdfs:comment : The name of a node in an established educational framework.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/targetName">lrmi:targetName</a>
    /// </summary>
    let targetName = _prefixId.prefix "targetName"
    /// <summary>
    ///   <para>rdfs:label : Target URL</para>
    ///   <para>rdfs:comment : The URL of a node in an established educational framework.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/targetUrl">lrmi:targetUrl</a>
    /// </summary>
    let targetUrl = _prefixId.prefix "targetUrl"
    /// <summary>
    ///   <para>rdfs:label : Teaches</para>
    ///   <para>rdfs:comment : The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.</para>
    ///   <para>dcterms:issued : 2020-11-12^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/teaches">lrmi:teaches</a>
    /// </summary>
    let teaches = _prefixId.prefix "teaches"
    /// <summary>
    ///   <para>rdfs:label : Time Required</para>
    ///   <para>rdfs:comment : Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.</para>
    ///   <para>skos:scopeNote : Based on, and mappable from, IEEE LOM 5.9: Typical Learning   Time.skos:scopeNote : For example, 'PT30M' and 'PT1H25M'</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <para>skos:changeNote : 2020-11-12: error in domain fixed, changed from lrmi:AlignmentObject to schema:CreativeWork^^xsd:string</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/timeRequired">lrmi:timeRequired</a>
    /// </summary>
    let timeRequired = _prefixId.prefix "timeRequired"
    /// <summary>
    ///   <para>rdfs:label : Typical Age Range</para>
    ///   <para>rdfs:comment : The typical expected age range.</para>
    ///   <para>skos:scopeNote : Based on, and mappable from, IEEE LOM 5.7: Typical Age Range.skos:scopeNote : For example, '7-9', '18-'.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/typicalAgeRange">lrmi:typicalAgeRange</a>
    /// </summary>
    let typicalAgeRange = _prefixId.prefix "typicalAgeRange"
    /// <summary>
    ///   <para>rdfs:label : Use Rights URL</para>
    ///   <para>rdfs:comment : The URL where the owner specifies permissions for using the   resource.</para>
    ///   <para>skos:scopeNote : For example: 'http://creativecommons.org/licenses/by/3.0/',
    ///    'http://publisher.com/content-use-description'.</para>
    ///   <para>dcterms:issued : 2015-02-09^^xsd:date</para>
    ///   <a href="http://purl.org/dcx/lrmi-terms/useRightsUrl">lrmi:useRightsUrl</a>
    /// </summary>
    let useRightsUrl = _prefixId.prefix "useRightsUrl"
