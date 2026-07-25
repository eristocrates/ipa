namespace http.environment.data.gov.au.def.op.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module op =
    let _namespace_iri = Namespace_Iri op |> NamespaceIRI
    /// <summary>
    ///   <para>op:CAS-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The identifier for a substance provided by the Chemical Abstracts Service</para>
    /// labels<para>CAS Number</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#CAS-number">http://environment.data.gov.au/def/op#CAS-number</seealso>
    let CAS_number = Prefixed_Name(op, "CAS-number") |> PrefixedName
    /// <summary>
    ///   <para>op:Substance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>type of material
    ///
    /// Typically a chemical substance, with a formal designator from CAS or ChEBI or similar, but may include less formal grouplings or union types when needed</para>
    /// labels<para>Substance</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#Substance">http://environment.data.gov.au/def/op#Substance</seealso>
    let Substance = Prefixed_Name(op, "Substance") |> PrefixedName
    /// <summary>
    ///   <para>op:applicableVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In an observable property definition, the applicable vocabulary is the set of terms or concepts from which a nominal value must be drawn.
    ///
    /// Compare with QUDT2 'applicable unit'</para>
    /// labels<para>applicable vocabulary</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#applicableVocabulary">http://environment.data.gov.au/def/op#applicableVocabulary</seealso>
    let applicableVocabulary = Prefixed_Name(op, "applicableVocabulary") |> PrefixedName
    /// <summary>
    ///   <para>op:cas-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>CAS Number</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#cas-number">http://environment.data.gov.au/def/op#cas-number</seealso>
    let cas_number = Prefixed_Name(op, "cas-number") |> PrefixedName
    /// <summary>
    ///   <para>op:constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Constraint that refines the definition of an observable property definition. This may include concerns such as realm of application, substance or taxon involved, host organism, matrix, applicable units or vocabulary. </para>
    /// labels<para>constraint</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#constraint">http://environment.data.gov.au/def/op#constraint</seealso>
    let constraint_ = Prefixed_Name(op, "constraint") |> PrefixedName
    /// <summary>
    ///   <para>op:matrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In an observable property definition, the matrix is the material context (container feature or medium) for an observable property.</para>
    /// labels<para>matrix</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#matrix">http://environment.data.gov.au/def/op#matrix</seealso>
    let matrix = Prefixed_Name(op, "matrix") |> PrefixedName
    /// <summary>
    ///   <para>op:procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The procedure is a description of the procedure, algorithm, protocol or sensor system used in making observation or estimate of property value</para>
    /// labels<para>procedure</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#procedure">http://environment.data.gov.au/def/op#procedure</seealso>
    let procedure = Prefixed_Name(op, "procedure") |> PrefixedName
    /// <summary>
    ///   <para>op:propertyKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>property kind</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#propertyKind">http://environment.data.gov.au/def/op#propertyKind</seealso>
    let propertyKind = Prefixed_Name(op, "propertyKind") |> PrefixedName
    /// <summary>
    ///   <para>op:statisticalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Statistical Measure</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#statisticalMeasure">http://environment.data.gov.au/def/op#statisticalMeasure</seealso>
    let statisticalMeasure = Prefixed_Name(op, "statisticalMeasure") |> PrefixedName
    /// <summary>
    ///   <para>op:QualityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>non-numeric PropertyKind</para>
    /// labels<para>Quality Kind</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#QualityKind">http://environment.data.gov.au/def/op#QualityKind</seealso>
    let QualityKind = Prefixed_Name(op, "QualityKind") |> PrefixedName
    /// <summary>
    ///   <para>op:PropertyKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Superclass of qudt:QuantityKind
    /// This class accommodates all kinds of properties, including those (qualities) that are not described by quantities (numeric values).
    /// May carry constraints, such as substance, objectOfInterest, featureOfInterest, matrix, hostOrganism, to refine the definition of a generalization. property is associated
    /// e.g. tree-height, nitrogen-concentration, concentration-of-zinc-in-the-liver-of-a-specific-fish-taxon-only-males-larger-than-20cm</para>
    /// labels<para>Property kind</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#PropertyKind">http://environment.data.gov.au/def/op#PropertyKind</seealso>
    let PropertyKind = Prefixed_Name(op, "PropertyKind") |> PrefixedName
    /// <summary>
    ///   <para>op:ScaledQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scaled quantity kind has one or more unit properties, which indicate valid units of measure for this quantity kind.
    ///
    /// It is likely that this class is equivalent to qudt:QuantityKind, but has been declared independently for governance of the attached qudt:unit property</para>
    /// labels<para>Scaled Quantity Kind</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#ScaledQuantityKind">http://environment.data.gov.au/def/op#ScaledQuantityKind</seealso>
    let ScaledQuantityKind = Prefixed_Name(op, "ScaledQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>op:SubstanceOrTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of stuff and things, individuals of which identify a class of stuff and things that make observed properties concrete.</para>
    /// labels<para>Substance or Taxon</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#SubstanceOrTaxon">http://environment.data.gov.au/def/op#SubstanceOrTaxon</seealso>
    let SubstanceOrTaxon = Prefixed_Name(op, "SubstanceOrTaxon") |> PrefixedName
    /// <summary>
    ///   <para>op:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>type of organism, any rank
    ///
    /// Preferably with a formally recognised designiation such as a latin binomial, or LSID, but may be a less formal grouping when needed.</para>
    /// labels<para>taxon</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#Taxon">http://environment.data.gov.au/def/op#Taxon</seealso>
    let Taxon = Prefixed_Name(op, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>op:featureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In an observable property definition, the feature-of-interest constrains the feature realm that the property is associated with.</para>
    /// labels<para>feature of interest</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#featureOfInterest">http://environment.data.gov.au/def/op#featureOfInterest</seealso>
    let featureOfInterest = Prefixed_Name(op, "featureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>op:objectOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In an observable property definition, this is the substance or taxon whose count, concentration, presence, or other similar property, is of interest. </para>
    /// labels<para>object of interest</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#objectOfInterest">http://environment.data.gov.au/def/op#objectOfInterest</seealso>
    let objectOfInterest = Prefixed_Name(op, "objectOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>op:hostOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In an observable property definition, the host-organism indicates the host taxon, optionally constrained by sex, age, size etc, for an observable property.</para>
    /// labels<para>host organism</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#hostOrganism">http://environment.data.gov.au/def/op#hostOrganism</seealso>
    let hostOrganism = Prefixed_Name(op, "hostOrganism") |> PrefixedName
    /// <summary>
    ///   <para>op:substance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In an observable property definition, this is the substance whose concentration, presence, or similar is of interest. </para>
    /// labels<para>object of interest</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#substance">http://environment.data.gov.au/def/op#substance</seealso>
    let substance = Prefixed_Name(op, "substance") |> PrefixedName
    /// <summary>
    ///   <para>op:qualityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>quality kind</para></remarks>
    /// <seealso href="http://environment.data.gov.au/def/op#qualityKind">http://environment.data.gov.au/def/op#qualityKind</seealso>
    let qualityKind = Prefixed_Name(op, "qualityKind") |> PrefixedName
