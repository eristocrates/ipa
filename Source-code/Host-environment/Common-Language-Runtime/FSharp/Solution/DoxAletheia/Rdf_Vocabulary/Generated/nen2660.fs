namespace https.w3id.org.nen2660.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nen2660 =
    let _namespace_iri = Namespace_Iri nen2660 |> NamespaceIRI

    /// <summary>
    ///   <para>nen2660:term#QuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#QuantityKind">https://w3id.org/nen2660/term#QuantityKind</seealso>
    let ``term#QuantityKind`` =
        Prefixed_Name(nen2660, "term#QuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Representation">https://w3id.org/nen2660/def#Representation</seealso>
    let ``def#Representation`` =
        Prefixed_Name(nen2660, "def#Representation") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Activity">https://w3id.org/nen2660/def#Activity</seealso>
    let ``def#Activity`` = Prefixed_Name(nen2660, "def#Activity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#GeometricEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#GeometricEntity">https://w3id.org/nen2660/def#GeometricEntity</seealso>
    let ``def#GeometricEntity`` =
        Prefixed_Name(nen2660, "def#GeometricEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#transforms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#transforms">https://w3id.org/nen2660/def#transforms</seealso>
    let ``def#transforms`` = Prefixed_Name(nen2660, "def#transforms") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#hasPeriod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasPeriod">https://w3id.org/nen2660/def#hasPeriod</seealso>
    let ``def#hasPeriod`` = Prefixed_Name(nen2660, "def#hasPeriod") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#consistsOf">https://w3id.org/nen2660/def#consistsOf</seealso>
    let ``def#consistsOf`` = Prefixed_Name(nen2660, "def#consistsOf") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Objectification</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Objectification">https://w3id.org/nen2660/term#Objectification</seealso>
    let ``term#Objectification`` =
        Prefixed_Name(nen2660, "term#Objectification") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#PhysicalObject">https://w3id.org/nen2660/term#PhysicalObject</seealso>
    let ``term#PhysicalObject`` =
        Prefixed_Name(nen2660, "term#PhysicalObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#isConnectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#isConnectedTo">https://w3id.org/nen2660/def#isConnectedTo</seealso>
    let ``def#isConnectedTo`` =
        Prefixed_Name(nen2660, "def#isConnectedTo") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#executes">https://w3id.org/nen2660/def#executes</seealso>
    let ``def#executes`` = Prefixed_Name(nen2660, "def#executes") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#isPlanFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#isPlanFor">https://w3id.org/nen2660/def#isPlanFor</seealso>
    let ``def#isPlanFor`` = Prefixed_Name(nen2660, "def#isPlanFor") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Plasma</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Plasma">https://w3id.org/nen2660/term#Plasma</seealso>
    let ``term#Plasma`` = Prefixed_Name(nen2660, "term#Plasma") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Port</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Port">https://w3id.org/nen2660/term#Port</seealso>
    let ``term#Port`` = Prefixed_Name(nen2660, "term#Port") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#PureSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#PureSubstance">https://w3id.org/nen2660/term#PureSubstance</seealso>
    let ``term#PureSubstance`` =
        Prefixed_Name(nen2660, "term#PureSubstance") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#QuantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#QuantityValue">https://w3id.org/nen2660/term#QuantityValue</seealso>
    let ``term#QuantityValue`` =
        Prefixed_Name(nen2660, "term#QuantityValue") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Unit">https://w3id.org/nen2660/term#Unit</seealso>
    let ``term#Unit`` = Prefixed_Name(nen2660, "term#Unit") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#AbstractConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#AbstractConcept">https://w3id.org/nen2660/term#AbstractConcept</seealso>
    let ``term#AbstractConcept`` =
        Prefixed_Name(nen2660, "term#AbstractConcept") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Activity">https://w3id.org/nen2660/term#Activity</seealso>
    let ``term#Activity`` = Prefixed_Name(nen2660, "term#Activity") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Object">https://w3id.org/nen2660/def#Object</seealso>
    let ``def#Object`` = Prefixed_Name(nen2660, "def#Object") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#overConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#overConnection">https://w3id.org/nen2660/def#overConnection</seealso>
    let ``def#overConnection`` =
        Prefixed_Name(nen2660, "def#overConnection") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#TemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#TemporalEntity">https://w3id.org/nen2660/term#TemporalEntity</seealso>
    let ``term#TemporalEntity`` =
        Prefixed_Name(nen2660, "term#TemporalEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasPart">https://w3id.org/nen2660/def#hasPart</seealso>
    let ``def#hasPart`` = Prefixed_Name(nen2660, "def#hasPart") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#QualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#QualityValue">https://w3id.org/nen2660/term#QualityValue</seealso>
    let ``term#QualityValue`` =
        Prefixed_Name(nen2660, "term#QualityValue") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#RealObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#RealObject">https://w3id.org/nen2660/term#RealObject</seealso>
    let ``term#RealObject`` = Prefixed_Name(nen2660, "term#RealObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#RealizedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#RealizedEntity">https://w3id.org/nen2660/term#RealizedEntity</seealso>
    let ``term#RealizedEntity`` =
        Prefixed_Name(nen2660, "term#RealizedEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#RelationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#RelationReference">https://w3id.org/nen2660/term#RelationReference</seealso>
    let ``term#RelationReference`` =
        Prefixed_Name(nen2660, "term#RelationReference") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Representation">https://w3id.org/nen2660/term#Representation</seealso>
    let ``term#Representation`` =
        Prefixed_Name(nen2660, "term#Representation") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Requirement">https://w3id.org/nen2660/term#Requirement</seealso>
    let ``term#Requirement`` =
        Prefixed_Name(nen2660, "term#Requirement") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#RequirementTopicType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:nen2660/def#EnumerationType</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#RequirementTopicType">https://w3id.org/nen2660/def#RequirementTopicType</seealso>
    let ``def#RequirementTopicType`` =
        Prefixed_Name(nen2660, "def#RequirementTopicType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#requirementSourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#requirementSourceType">https://w3id.org/nen2660/def#requirementSourceType</seealso>
    let ``def#requirementSourceType`` =
        Prefixed_Name(nen2660, "def#requirementSourceType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#RequirementSourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#RequirementSourceType">https://w3id.org/nen2660/term#RequirementSourceType</seealso>
    let ``term#RequirementSourceType`` =
        Prefixed_Name(nen2660, "term#RequirementSourceType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Solid</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Solid">https://w3id.org/nen2660/term#Solid</seealso>
    let ``term#Solid`` = Prefixed_Name(nen2660, "term#Solid") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#SpatialRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#SpatialRegion">https://w3id.org/nen2660/term#SpatialRegion</seealso>
    let ``term#SpatialRegion`` =
        Prefixed_Name(nen2660, "term#SpatialRegion") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#isBoundBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#isBoundBy">https://w3id.org/nen2660/def#isBoundBy</seealso>
    let ``def#isBoundBy`` = Prefixed_Name(nen2660, "def#isBoundBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#TechnicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#TechnicalEntity">https://w3id.org/nen2660/term#TechnicalEntity</seealso>
    let ``term#TechnicalEntity`` =
        Prefixed_Name(nen2660, "term#TechnicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#TopConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#TopConcept">https://w3id.org/nen2660/term#TopConcept</seealso>
    let ``term#TopConcept`` = Prefixed_Name(nen2660, "term#TopConcept") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#abbreviation">https://w3id.org/nen2660/def#abbreviation</seealso>
    let ``def#abbreviation`` =
        Prefixed_Name(nen2660, "def#abbreviation") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasRequirement">https://w3id.org/nen2660/def#hasRequirement</seealso>
    let ``def#hasRequirement`` =
        Prefixed_Name(nen2660, "def#hasRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Type">https://w3id.org/nen2660/term#Type</seealso>
    let ``term#Type`` = Prefixed_Name(nen2660, "term#Type") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#abbreviation">https://w3id.org/nen2660/term#abbreviation</seealso>
    let ``term#abbreviation`` =
        Prefixed_Name(nen2660, "term#abbreviation") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#aggregationStateType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#aggregationStateType">https://w3id.org/nen2660/term#aggregationStateType</seealso>
    let ``term#aggregationStateType`` =
        Prefixed_Name(nen2660, "term#aggregationStateType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#begins</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#begins">https://w3id.org/nen2660/term#begins</seealso>
    let ``term#begins`` = Prefixed_Name(nen2660, "term#begins") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#chemicalFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#chemicalFormula">https://w3id.org/nen2660/term#chemicalFormula</seealso>
    let ``term#chemicalFormula`` =
        Prefixed_Name(nen2660, "term#chemicalFormula") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#connectsPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#connectsPort">https://w3id.org/nen2660/term#connectsPort</seealso>
    let ``term#connectsPort`` =
        Prefixed_Name(nen2660, "term#connectsPort") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#consistsOf">https://w3id.org/nen2660/term#consistsOf</seealso>
    let ``term#consistsOf`` = Prefixed_Name(nen2660, "term#consistsOf") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#contains">https://w3id.org/nen2660/term#contains</seealso>
    let ``term#contains`` = Prefixed_Name(nen2660, "term#contains") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#ends">https://w3id.org/nen2660/term#ends</seealso>
    let ``term#ends`` = Prefixed_Name(nen2660, "term#ends") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#executes">https://w3id.org/nen2660/term#executes</seealso>
    let ``term#executes`` = Prefixed_Name(nen2660, "term#executes") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasFunctionalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasFunctionalPart">https://w3id.org/nen2660/term#hasFunctionalPart</seealso>
    let ``term#hasFunctionalPart`` =
        Prefixed_Name(nen2660, "term#hasFunctionalPart") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasInterior</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasInterior">https://w3id.org/nen2660/term#hasInterior</seealso>
    let ``term#hasInterior`` =
        Prefixed_Name(nen2660, "term#hasInterior") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasPart">https://w3id.org/nen2660/term#hasPart</seealso>
    let ``term#hasPart`` = Prefixed_Name(nen2660, "term#hasPart") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasQuantityKind">https://w3id.org/nen2660/def#hasQuantityKind</seealso>
    let ``def#hasQuantityKind`` =
        Prefixed_Name(nen2660, "def#hasQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasQuantityKind">https://w3id.org/nen2660/term#hasQuantityKind</seealso>
    let ``term#hasQuantityKind`` =
        Prefixed_Name(nen2660, "term#hasQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasQuantityKindShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasQuantityKindShape">https://w3id.org/nen2660/def#hasQuantityKindShape</seealso>
    let ``def#hasQuantityKindShape`` =
        Prefixed_Name(nen2660, "def#hasQuantityKindShape") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasRequirement">https://w3id.org/nen2660/term#hasRequirement</seealso>
    let ``term#hasRequirement`` =
        Prefixed_Name(nen2660, "term#hasRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasSolution">https://w3id.org/nen2660/term#hasSolution</seealso>
    let ``term#hasSolution`` =
        Prefixed_Name(nen2660, "term#hasSolution") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasState">https://w3id.org/nen2660/term#hasState</seealso>
    let ``term#hasState`` = Prefixed_Name(nen2660, "term#hasState") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasTechnicalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasTechnicalPart">https://w3id.org/nen2660/term#hasTechnicalPart</seealso>
    let ``term#hasTechnicalPart`` =
        Prefixed_Name(nen2660, "term#hasTechnicalPart") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasTemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasTemporalEntity">https://w3id.org/nen2660/term#hasTemporalEntity</seealso>
    let ``term#hasTemporalEntity`` =
        Prefixed_Name(nen2660, "term#hasTemporalEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasUnit">https://w3id.org/nen2660/term#hasUnit</seealso>
    let ``term#hasUnit`` = Prefixed_Name(nen2660, "term#hasUnit") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasUnitShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasUnitShape">https://w3id.org/nen2660/def#hasUnitShape</seealso>
    let ``def#hasUnitShape`` =
        Prefixed_Name(nen2660, "def#hasUnitShape") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#isBoundBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#isBoundBy">https://w3id.org/nen2660/term#isBoundBy</seealso>
    let ``term#isBoundBy`` = Prefixed_Name(nen2660, "term#isBoundBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#isConnectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#isConnectedTo">https://w3id.org/nen2660/term#isConnectedTo</seealso>
    let ``term#isConnectedTo`` =
        Prefixed_Name(nen2660, "term#isConnectedTo") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#isDescribedBy">https://w3id.org/nen2660/term#isDescribedBy</seealso>
    let ``term#isDescribedBy`` =
        Prefixed_Name(nen2660, "term#isDescribedBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#isImplementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#isImplementedBy">https://w3id.org/nen2660/def#isImplementedBy</seealso>
    let ``def#isImplementedBy`` =
        Prefixed_Name(nen2660, "def#isImplementedBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#isImplementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#isImplementedBy">https://w3id.org/nen2660/term#isImplementedBy</seealso>
    let ``term#isImplementedBy`` =
        Prefixed_Name(nen2660, "term#isImplementedBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#isPlanFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#isPlanFor">https://w3id.org/nen2660/term#isPlanFor</seealso>
    let ``term#isPlanFor`` = Prefixed_Name(nen2660, "term#isPlanFor") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#isRealizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#isRealizedBy">https://w3id.org/nen2660/def#isRealizedBy</seealso>
    let ``def#isRealizedBy`` =
        Prefixed_Name(nen2660, "def#isRealizedBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#isRealizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#isRealizedBy">https://w3id.org/nen2660/term#isRealizedBy</seealso>
    let ``term#isRealizedBy`` =
        Prefixed_Name(nen2660, "term#isRealizedBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#overConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#overConnection">https://w3id.org/nen2660/term#overConnection</seealso>
    let ``term#overConnection`` =
        Prefixed_Name(nen2660, "term#overConnection") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#overInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#overInterface">https://w3id.org/nen2660/term#overInterface</seealso>
    let ``term#overInterface`` =
        Prefixed_Name(nen2660, "term#overInterface") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#participatesIn">https://w3id.org/nen2660/term#participatesIn</seealso>
    let ``term#participatesIn`` =
        Prefixed_Name(nen2660, "term#participatesIn") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#requirementSeverityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#requirementSeverityType">https://w3id.org/nen2660/term#requirementSeverityType</seealso>
    let ``term#requirementSeverityType`` =
        Prefixed_Name(nen2660, "term#requirementSeverityType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#requirementSourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#requirementSourceType">https://w3id.org/nen2660/term#requirementSourceType</seealso>
    let ``term#requirementSourceType`` =
        Prefixed_Name(nen2660, "term#requirementSourceType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#requirementTopicType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#requirementTopicType">https://w3id.org/nen2660/term#requirementTopicType</seealso>
    let ``term#requirementTopicType`` =
        Prefixed_Name(nen2660, "term#requirementTopicType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#transferType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#transferType">https://w3id.org/nen2660/term#transferType</seealso>
    let ``term#transferType`` =
        Prefixed_Name(nen2660, "term#transferType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#transforms</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#transforms">https://w3id.org/nen2660/term#transforms</seealso>
    let ``term#transforms`` = Prefixed_Name(nen2660, "term#transforms") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#triggers</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#triggers">https://w3id.org/nen2660/term#triggers</seealso>
    let ``term#triggers`` = Prefixed_Name(nen2660, "term#triggers") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:rdfs/def</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/rdfs/def">https://w3id.org/nen2660/rdfs/def</seealso>
    let ``rdfs/def`` = Prefixed_Name(nen2660, "rdfs/def") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:skos/term</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/skos/term">https://w3id.org/nen2660/skos/term</seealso>
    let ``skos/term`` = Prefixed_Name(nen2660, "skos/term") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:shacl/def</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/shacl/def">https://w3id.org/nen2660/shacl/def</seealso>
    let ``shacl/def`` = Prefixed_Name(nen2660, "shacl/def") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Entity">https://w3id.org/nen2660/def#Entity</seealso>
    let ``def#Entity`` = Prefixed_Name(nen2660, "def#Entity") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#hasInterior</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasInterior">https://w3id.org/nen2660/def#hasInterior</seealso>
    let ``def#hasInterior`` = Prefixed_Name(nen2660, "def#hasInterior") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#hasBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasBoundary">https://w3id.org/nen2660/def#hasBoundary</seealso>
    let ``def#hasBoundary`` = Prefixed_Name(nen2660, "def#hasBoundary") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:owl/def</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/owl/def">https://w3id.org/nen2660/owl/def</seealso>
    let ``owl/def`` = Prefixed_Name(nen2660, "owl/def") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AggregationStateType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>w3id:nen2660/def#EnumerationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AggregationStateType">https://w3id.org/nen2660/def#AggregationStateType</seealso>
    let ``def#AggregationStateType`` =
        Prefixed_Name(nen2660, "def#AggregationStateType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Liquid</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#AggregationStateType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Liquid">https://w3id.org/nen2660/def#Liquid</seealso>
    let ``def#Liquid`` = Prefixed_Name(nen2660, "def#Liquid") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Objectification</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Objectification">https://w3id.org/nen2660/def#Objectification</seealso>
    let ``def#Objectification`` =
        Prefixed_Name(nen2660, "def#Objectification") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#isDescribedBy">https://w3id.org/nen2660/def#isDescribedBy</seealso>
    let ``def#isDescribedBy`` =
        Prefixed_Name(nen2660, "def#isDescribedBy") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#participatesIn">https://w3id.org/nen2660/def#participatesIn</seealso>
    let ``def#participatesIn`` =
        Prefixed_Name(nen2660, "def#participatesIn") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#AggregationStateType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#AggregationStateType">https://w3id.org/nen2660/term#AggregationStateType</seealso>
    let ``term#AggregationStateType`` =
        Prefixed_Name(nen2660, "term#AggregationStateType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#PlannedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#PlannedEntity">https://w3id.org/nen2660/term#PlannedEntity</seealso>
    let ``term#PlannedEntity`` =
        Prefixed_Name(nen2660, "term#PlannedEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#QualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#QualityValue">https://w3id.org/nen2660/def#QualityValue</seealso>
    let ``def#QualityValue`` =
        Prefixed_Name(nen2660, "def#QualityValue") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Solid</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#AggregationStateType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Solid">https://w3id.org/nen2660/def#Solid</seealso>
    let ``def#Solid`` = Prefixed_Name(nen2660, "def#Solid") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#Plasma</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#AggregationStateType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Plasma">https://w3id.org/nen2660/def#Plasma</seealso>
    let ``def#Plasma`` = Prefixed_Name(nen2660, "def#Plasma") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#RealObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#RealObject">https://w3id.org/nen2660/def#RealObject</seealso>
    let ``def#RealObject`` = Prefixed_Name(nen2660, "def#RealObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#FunctionalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#FunctionalEntity">https://w3id.org/nen2660/def#FunctionalEntity</seealso>
    let ``def#FunctionalEntity`` =
        Prefixed_Name(nen2660, "def#FunctionalEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#PlannedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#PlannedEntity">https://w3id.org/nen2660/def#PlannedEntity</seealso>
    let ``def#PlannedEntity`` =
        Prefixed_Name(nen2660, "def#PlannedEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#AggregationStateType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Gas">https://w3id.org/nen2660/def#Gas</seealso>
    let ``def#Gas`` = Prefixed_Name(nen2660, "def#Gas") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AllDisjointClassesShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AllDisjointClassesShape">https://w3id.org/nen2660/def#AllDisjointClassesShape</seealso>
    let ``def#AllDisjointClassesShape`` =
        Prefixed_Name(nen2660, "def#AllDisjointClassesShape") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#SpatialRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#SpatialRegion">https://w3id.org/nen2660/def#SpatialRegion</seealso>
    let ``def#SpatialRegion`` =
        Prefixed_Name(nen2660, "def#SpatialRegion") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Requirement">https://w3id.org/nen2660/def#Requirement</seealso>
    let ``def#Requirement`` = Prefixed_Name(nen2660, "def#Requirement") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#requirementSeverityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#requirementSeverityType">https://w3id.org/nen2660/def#requirementSeverityType</seealso>
    let ``def#requirementSeverityType`` =
        Prefixed_Name(nen2660, "def#requirementSeverityType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#requirementTopicType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#requirementTopicType">https://w3id.org/nen2660/def#requirementTopicType</seealso>
    let ``def#requirementTopicType`` =
        Prefixed_Name(nen2660, "def#requirementTopicType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#RequirementSourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:nen2660/def#EnumerationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#RequirementSourceType">https://w3id.org/nen2660/def#RequirementSourceType</seealso>
    let ``def#RequirementSourceType`` =
        Prefixed_Name(nen2660, "def#RequirementSourceType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#RequirementSeverityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#RequirementSeverityType">https://w3id.org/nen2660/term#RequirementSeverityType</seealso>
    let ``term#RequirementSeverityType`` =
        Prefixed_Name(nen2660, "term#RequirementSeverityType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#RequirementTopicType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#RequirementTopicType">https://w3id.org/nen2660/term#RequirementTopicType</seealso>
    let ``term#RequirementTopicType`` =
        Prefixed_Name(nen2660, "term#RequirementTopicType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#contains">https://w3id.org/nen2660/def#contains</seealso>
    let ``def#contains`` = Prefixed_Name(nen2660, "def#contains") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#State</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#State">https://w3id.org/nen2660/term#State</seealso>
    let ``term#State`` = Prefixed_Name(nen2660, "term#State") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasTechnicalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasTechnicalPart">https://w3id.org/nen2660/def#hasTechnicalPart</seealso>
    let ``def#hasTechnicalPart`` =
        Prefixed_Name(nen2660, "def#hasTechnicalPart") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#TransferType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#TransferType">https://w3id.org/nen2660/term#TransferType</seealso>
    let ``term#TransferType`` =
        Prefixed_Name(nen2660, "term#TransferType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#TechnicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#TechnicalEntity">https://w3id.org/nen2660/def#TechnicalEntity</seealso>
    let ``def#TechnicalEntity`` =
        Prefixed_Name(nen2660, "def#TechnicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#RealizedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#RealizedEntity">https://w3id.org/nen2660/def#RealizedEntity</seealso>
    let ``def#RealizedEntity`` =
        Prefixed_Name(nen2660, "def#RealizedEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#PhysicalObject">https://w3id.org/nen2660/def#PhysicalObject</seealso>
    let ``def#PhysicalObject`` =
        Prefixed_Name(nen2660, "def#PhysicalObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Event">https://w3id.org/nen2660/def#Event</seealso>
    let ``def#Event`` = Prefixed_Name(nen2660, "def#Event") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#RequirementSeverityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:nen2660/def#EnumerationType</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#RequirementSeverityType">https://w3id.org/nen2660/def#RequirementSeverityType</seealso>
    let ``def#RequirementSeverityType`` =
        Prefixed_Name(nen2660, "def#RequirementSeverityType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#InformationObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#InformationObject">https://w3id.org/nen2660/def#InformationObject</seealso>
    let ``def#InformationObject`` =
        Prefixed_Name(nen2660, "def#InformationObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#connectsObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#connectsObject">https://w3id.org/nen2660/term#connectsObject</seealso>
    let ``term#connectsObject`` =
        Prefixed_Name(nen2660, "term#connectsObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#State">https://w3id.org/nen2660/def#State</seealso>
    let ``def#State`` = Prefixed_Name(nen2660, "def#State") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AllDisjointClasses_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AllDisjointClasses</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AllDisjointClasses_1">https://w3id.org/nen2660/def#AllDisjointClasses_1</seealso>
    let ``def#AllDisjointClasses_1`` =
        Prefixed_Name(nen2660, "def#AllDisjointClasses_1") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AllDisjointClasses_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AllDisjointClasses</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AllDisjointClasses_3">https://w3id.org/nen2660/def#AllDisjointClasses_3</seealso>
    let ``def#AllDisjointClasses_3`` =
        Prefixed_Name(nen2660, "def#AllDisjointClasses_3") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AmountOfBulkMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AmountOfBulkMatter">https://w3id.org/nen2660/def#AmountOfBulkMatter</seealso>
    let ``def#AmountOfBulkMatter`` =
        Prefixed_Name(nen2660, "def#AmountOfBulkMatter") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#PureSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#PureSubstance">https://w3id.org/nen2660/def#PureSubstance</seealso>
    let ``def#PureSubstance`` =
        Prefixed_Name(nen2660, "def#PureSubstance") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#ConceptType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#ConceptType">https://w3id.org/nen2660/def#ConceptType</seealso>
    let ``def#ConceptType`` = Prefixed_Name(nen2660, "def#ConceptType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#ConceptType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#ConceptType">https://w3id.org/nen2660/term#ConceptType</seealso>
    let ``term#ConceptType`` =
        Prefixed_Name(nen2660, "term#ConceptType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasPartsGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasPartsGroup">https://w3id.org/nen2660/def#hasPartsGroup</seealso>
    let ``def#hasPartsGroup`` =
        Prefixed_Name(nen2660, "def#hasPartsGroup") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Connection">https://w3id.org/nen2660/term#Connection</seealso>
    let ``term#Connection`` = Prefixed_Name(nen2660, "term#Connection") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AllDisjointClasses_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AllDisjointClasses</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AllDisjointClasses_2">https://w3id.org/nen2660/def#AllDisjointClasses_2</seealso>
    let ``def#AllDisjointClasses_2`` =
        Prefixed_Name(nen2660, "def#AllDisjointClasses_2") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AllDisjointClasses_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AllDisjointClasses</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AllDisjointClasses_4">https://w3id.org/nen2660/def#AllDisjointClasses_4</seealso>
    let ``def#AllDisjointClasses_4`` =
        Prefixed_Name(nen2660, "def#AllDisjointClasses_4") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#AmountOfBulkMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#AmountOfBulkMatter">https://w3id.org/nen2660/term#AmountOfBulkMatter</seealso>
    let ``term#AmountOfBulkMatter`` =
        Prefixed_Name(nen2660, "term#AmountOfBulkMatter") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#ChemicalBonding</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/nen2660/term#ChemicalBonding">https://w3id.org/nen2660/term#ChemicalBonding</seealso>
    let ``term#ChemicalBonding`` =
        Prefixed_Name(nen2660, "term#ChemicalBonding") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#ChemicalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#ChemicalElement">https://w3id.org/nen2660/def#ChemicalElement</seealso>
    let ``def#ChemicalElement`` =
        Prefixed_Name(nen2660, "def#ChemicalElement") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Type">https://w3id.org/nen2660/def#Type</seealso>
    let ``def#Type`` = Prefixed_Name(nen2660, "def#Type") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#ConcreteConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#ConcreteConcept">https://w3id.org/nen2660/term#ConcreteConcept</seealso>
    let ``term#ConcreteConcept`` =
        Prefixed_Name(nen2660, "term#ConcreteConcept") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasTemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasTemporalEntity">https://w3id.org/nen2660/def#hasTemporalEntity</seealso>
    let ``def#hasTemporalEntity`` =
        Prefixed_Name(nen2660, "def#hasTemporalEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Connection">https://w3id.org/nen2660/def#Connection</seealso>
    let ``def#Connection`` = Prefixed_Name(nen2660, "def#Connection") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#connectsObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#connectsObject">https://w3id.org/nen2660/def#connectsObject</seealso>
    let ``def#connectsObject`` =
        Prefixed_Name(nen2660, "def#connectsObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#DiscreteObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#DiscreteObject">https://w3id.org/nen2660/def#DiscreteObject</seealso>
    let ``def#DiscreteObject`` =
        Prefixed_Name(nen2660, "def#DiscreteObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#DiscreteObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#DiscreteObject">https://w3id.org/nen2660/term#DiscreteObject</seealso>
    let ``term#DiscreteObject`` =
        Prefixed_Name(nen2660, "term#DiscreteObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#portion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#portion">https://w3id.org/nen2660/term#portion</seealso>
    let ``term#portion`` = Prefixed_Name(nen2660, "term#portion") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasBoundary">https://w3id.org/nen2660/term#hasBoundary</seealso>
    let ``term#hasBoundary`` =
        Prefixed_Name(nen2660, "term#hasBoundary") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#ChemicalCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#ChemicalCompound">https://w3id.org/nen2660/def#ChemicalCompound</seealso>
    let ``def#ChemicalCompound`` =
        Prefixed_Name(nen2660, "def#ChemicalCompound") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasUnit">https://w3id.org/nen2660/def#hasUnit</seealso>
    let ``def#hasUnit`` = Prefixed_Name(nen2660, "def#hasUnit") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#ChemicalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#ChemicalElement">https://w3id.org/nen2660/term#ChemicalElement</seealso>
    let ``term#ChemicalElement`` =
        Prefixed_Name(nen2660, "term#ChemicalElement") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#ConcreteConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#ConcreteConcept">https://w3id.org/nen2660/def#ConcreteConcept</seealso>
    let ``def#ConcreteConcept`` =
        Prefixed_Name(nen2660, "def#ConcreteConcept") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#connectsPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#connectsPort">https://w3id.org/nen2660/def#connectsPort</seealso>
    let ``def#connectsPort`` =
        Prefixed_Name(nen2660, "def#connectsPort") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#EnergyFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#TransferType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#EnergyFlow">https://w3id.org/nen2660/def#EnergyFlow</seealso>
    let ``def#EnergyFlow`` = Prefixed_Name(nen2660, "def#EnergyFlow") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#Port</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Port">https://w3id.org/nen2660/def#Port</seealso>
    let ``def#Port`` = Prefixed_Name(nen2660, "def#Port") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#EnergyFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#EnergyFlow">https://w3id.org/nen2660/term#EnergyFlow</seealso>
    let ``term#EnergyFlow`` = Prefixed_Name(nen2660, "term#EnergyFlow") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasState">https://w3id.org/nen2660/def#hasState</seealso>
    let ``def#hasState`` = Prefixed_Name(nen2660, "def#hasState") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#triggers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#triggers">https://w3id.org/nen2660/def#triggers</seealso>
    let ``def#triggers`` = Prefixed_Name(nen2660, "def#triggers") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Event">https://w3id.org/nen2660/term#Event</seealso>
    let ``term#Event`` = Prefixed_Name(nen2660, "term#Event") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#begins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#begins">https://w3id.org/nen2660/def#begins</seealso>
    let ``def#begins`` = Prefixed_Name(nen2660, "def#begins") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#Force</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#TransferType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Force">https://w3id.org/nen2660/def#Force</seealso>
    let ``def#Force`` = Prefixed_Name(nen2660, "def#Force") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#FunctionalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#FunctionalEntity">https://w3id.org/nen2660/term#FunctionalEntity</seealso>
    let ``term#FunctionalEntity`` =
        Prefixed_Name(nen2660, "term#FunctionalEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasSolution">https://w3id.org/nen2660/def#hasSolution</seealso>
    let ``def#hasSolution`` = Prefixed_Name(nen2660, "def#hasSolution") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#hasFunctionalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#hasFunctionalPart">https://w3id.org/nen2660/def#hasFunctionalPart</seealso>
    let ``def#hasFunctionalPart`` =
        Prefixed_Name(nen2660, "def#hasFunctionalPart") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#GeometricEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#GeometricEntity">https://w3id.org/nen2660/term#GeometricEntity</seealso>
    let ``term#GeometricEntity`` =
        Prefixed_Name(nen2660, "term#GeometricEntity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#HeterogeneousMixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#HeterogeneousMixture">https://w3id.org/nen2660/def#HeterogeneousMixture</seealso>
    let ``def#HeterogeneousMixture`` =
        Prefixed_Name(nen2660, "def#HeterogeneousMixture") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#InformationFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#TransferType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#InformationFlow">https://w3id.org/nen2660/def#InformationFlow</seealso>
    let ``def#InformationFlow`` =
        Prefixed_Name(nen2660, "def#InformationFlow") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#InformationFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#InformationFlow">https://w3id.org/nen2660/term#InformationFlow</seealso>
    let ``term#InformationFlow`` =
        Prefixed_Name(nen2660, "term#InformationFlow") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Interaction">https://w3id.org/nen2660/term#Interaction</seealso>
    let ``term#Interaction`` =
        Prefixed_Name(nen2660, "term#Interaction") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#transferType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#transferType">https://w3id.org/nen2660/def#transferType</seealso>
    let ``def#transferType`` =
        Prefixed_Name(nen2660, "def#transferType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#overInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#overInterface">https://w3id.org/nen2660/def#overInterface</seealso>
    let ``def#overInterface`` =
        Prefixed_Name(nen2660, "def#overInterface") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Interface</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Interface">https://w3id.org/nen2660/def#Interface</seealso>
    let ``def#Interface`` = Prefixed_Name(nen2660, "def#Interface") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Liquid</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Liquid">https://w3id.org/nen2660/term#Liquid</seealso>
    let ``term#Liquid`` = Prefixed_Name(nen2660, "term#Liquid") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#MaterialFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nen2660/def#TransferType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#MaterialFlow">https://w3id.org/nen2660/def#MaterialFlow</seealso>
    let ``def#MaterialFlow`` =
        Prefixed_Name(nen2660, "def#MaterialFlow") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#MaterialFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#MaterialFlow">https://w3id.org/nen2660/term#MaterialFlow</seealso>
    let ``term#MaterialFlow`` =
        Prefixed_Name(nen2660, "term#MaterialFlow") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#aggregationStateType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#aggregationStateType">https://w3id.org/nen2660/def#aggregationStateType</seealso>
    let ``def#aggregationStateType`` =
        Prefixed_Name(nen2660, "def#aggregationStateType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#chemicalFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#chemicalFormula">https://w3id.org/nen2660/def#chemicalFormula</seealso>
    let ``def#chemicalFormula`` =
        Prefixed_Name(nen2660, "def#chemicalFormula") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#RelationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#RelationReference">https://w3id.org/nen2660/def#RelationReference</seealso>
    let ``def#RelationReference`` =
        Prefixed_Name(nen2660, "def#RelationReference") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#QuantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#QuantityValue">https://w3id.org/nen2660/def#QuantityValue</seealso>
    let ``def#QuantityValue`` =
        Prefixed_Name(nen2660, "def#QuantityValue") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Mixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Mixture">https://w3id.org/nen2660/term#Mixture</seealso>
    let ``term#Mixture`` = Prefixed_Name(nen2660, "term#Mixture") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Object">https://w3id.org/nen2660/term#Object</seealso>
    let ``term#Object`` = Prefixed_Name(nen2660, "term#Object") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#hasPartsGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#hasPartsGroup">https://w3id.org/nen2660/term#hasPartsGroup</seealso>
    let ``term#hasPartsGroup`` =
        Prefixed_Name(nen2660, "term#hasPartsGroup") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#TransferType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>w3id:nen2660/def#EnumerationType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#TransferType">https://w3id.org/nen2660/def#TransferType</seealso>
    let ``def#TransferType`` =
        Prefixed_Name(nen2660, "def#TransferType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#ChemicalCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#ChemicalCompound">https://w3id.org/nen2660/term#ChemicalCompound</seealso>
    let ``term#ChemicalCompound`` =
        Prefixed_Name(nen2660, "term#ChemicalCompound") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Entity">https://w3id.org/nen2660/term#Entity</seealso>
    let ``term#Entity`` = Prefixed_Name(nen2660, "term#Entity") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#EnumerationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#EnumerationType">https://w3id.org/nen2660/term#EnumerationType</seealso>
    let ``term#EnumerationType`` =
        Prefixed_Name(nen2660, "term#EnumerationType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#ends">https://w3id.org/nen2660/def#ends</seealso>
    let ``def#ends`` = Prefixed_Name(nen2660, "def#ends") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Force</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Force">https://w3id.org/nen2660/term#Force</seealso>
    let ``term#Force`` = Prefixed_Name(nen2660, "term#Force") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Gas">https://w3id.org/nen2660/term#Gas</seealso>
    let ``term#Gas`` = Prefixed_Name(nen2660, "term#Gas") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#HomogeneousMixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#HomogeneousMixture">https://w3id.org/nen2660/def#HomogeneousMixture</seealso>
    let ``def#HomogeneousMixture`` =
        Prefixed_Name(nen2660, "def#HomogeneousMixture") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#HomogeneousMixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#HomogeneousMixture">https://w3id.org/nen2660/term#HomogeneousMixture</seealso>
    let ``term#HomogeneousMixture`` =
        Prefixed_Name(nen2660, "term#HomogeneousMixture") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#InformationObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#InformationObject">https://w3id.org/nen2660/term#InformationObject</seealso>
    let ``term#InformationObject`` =
        Prefixed_Name(nen2660, "term#InformationObject") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#EnumerationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#EnumerationType">https://w3id.org/nen2660/def#EnumerationType</seealso>
    let ``def#EnumerationType`` =
        Prefixed_Name(nen2660, "def#EnumerationType") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#AbstractConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#AbstractConcept">https://w3id.org/nen2660/def#AbstractConcept</seealso>
    let ``def#AbstractConcept`` =
        Prefixed_Name(nen2660, "def#AbstractConcept") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#TopConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#TopConcept">https://w3id.org/nen2660/def#TopConcept</seealso>
    let ``def#TopConcept`` = Prefixed_Name(nen2660, "def#TopConcept") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#HeterogeneousMixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#HeterogeneousMixture">https://w3id.org/nen2660/term#HeterogeneousMixture</seealso>
    let ``term#HeterogeneousMixture`` =
        Prefixed_Name(nen2660, "term#HeterogeneousMixture") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#Mixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Mixture">https://w3id.org/nen2660/def#Mixture</seealso>
    let ``def#Mixture`` = Prefixed_Name(nen2660, "def#Mixture") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Interaction">https://w3id.org/nen2660/def#Interaction</seealso>
    let ``def#Interaction`` = Prefixed_Name(nen2660, "def#Interaction") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Interface</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Interface">https://w3id.org/nen2660/term#Interface</seealso>
    let ``term#Interface`` = Prefixed_Name(nen2660, "term#Interface") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:def#Matter</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#Matter">https://w3id.org/nen2660/def#Matter</seealso>
    let ``def#Matter`` = Prefixed_Name(nen2660, "def#Matter") |> PrefixedName
    /// <summary>
    ///   <para>nen2660:term#Matter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#Matter">https://w3id.org/nen2660/term#Matter</seealso>
    let ``term#Matter`` = Prefixed_Name(nen2660, "term#Matter") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#MatterPortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#MatterPortion">https://w3id.org/nen2660/def#MatterPortion</seealso>
    let ``def#MatterPortion`` =
        Prefixed_Name(nen2660, "def#MatterPortion") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:term#MatterPortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/term#MatterPortion">https://w3id.org/nen2660/term#MatterPortion</seealso>
    let ``term#MatterPortion`` =
        Prefixed_Name(nen2660, "term#MatterPortion") |> PrefixedName

    /// <summary>
    ///   <para>nen2660:def#portion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nen2660/def#portion">https://w3id.org/nen2660/def#portion</seealso>
    let ``def#portion`` = Prefixed_Name(nen2660, "def#portion") |> PrefixedName
