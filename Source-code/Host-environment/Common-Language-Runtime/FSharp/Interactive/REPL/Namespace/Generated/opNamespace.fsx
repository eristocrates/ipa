#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module op =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://environment.data.gov.au/def/op#" "op"

    let CAS_number = _prefixId.prefix "CAS-number"
    /// <summary>
    ///   <para>rdfs:label : Property kind</para>
    ///   <para>rdfs:comment : Superclass of qudt:QuantityKind
    /// This class accommodates all kinds of properties, including those (qualities) that are not described by quantities (numeric values).
    /// May carry constraints, such as substance, objectOfInterest, featureOfInterest, matrix, hostOrganism, to refine the definition of a generalization. property is associated
    /// e.g. tree-height, nitrogen-concentration, concentration-of-zinc-in-the-liver-of-a-specific-fish-taxon-only-males-larger-than-20cm^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#PropertyKind">op:PropertyKind</a>
    /// </summary>
    let PropertyKind = _prefixId.prefix "PropertyKind"
    /// <summary>
    ///   <para>rdfs:label : Quality Kind</para>
    ///   <para>rdfs:comment : non-numeric PropertyKind^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#QualityKind">op:QualityKind</a>
    /// </summary>
    let QualityKind = _prefixId.prefix "QualityKind"
    /// <summary>
    ///   <para>rdfs:label : Scaled Quantity Kind</para>
    ///   <para>rdfs:comment : Scaled quantity kind has one or more unit properties, which indicate valid units of measure for this quantity kind.
    ///
    /// It is likely that this class is equivalent to qudt:QuantityKind, but has been declared independently for governance of the attached qudt:unit property^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#ScaledQuantityKind">op:ScaledQuantityKind</a>
    /// </summary>
    let ScaledQuantityKind = _prefixId.prefix "ScaledQuantityKind"
    /// <summary>
    ///   <para>skos:prefLabel : Substance</para>
    ///   <para>rdfs:label : Substance^^xsd:string</para>
    ///   <para>rdfs:comment : type of material
    ///
    /// Typically a chemical substance, with a formal designator from CAS or ChEBI or similar, but may include less formal grouplings or union types when needed^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#Substance">op:Substance</a>
    /// </summary>
    let Substance = _prefixId.prefix "Substance"
    /// <summary>
    ///   <para>skos:prefLabel : Substance or Taxon</para>
    ///   <para>skos:altLabel : Species</para>
    ///   <para>rdfs:label : Substance or Taxon</para>
    ///   <para>rdfs:comment : Class of stuff and things, individuals of which identify a class of stuff and things that make observed properties concrete.^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#SubstanceOrTaxon">op:SubstanceOrTaxon</a>
    /// </summary>
    let SubstanceOrTaxon = _prefixId.prefix "SubstanceOrTaxon"
    /// <summary>
    ///   <para>skos:prefLabel : taxon</para>
    ///   <para>rdfs:label : taxon^^xsd:string</para>
    ///   <para>rdfs:comment : type of organism, any rank
    ///
    /// Preferably with a formally recognised designiation such as a latin binomial, or LSID, but may be a less formal grouping when needed.^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#Taxon">op:Taxon</a>
    /// </summary>
    let Taxon = _prefixId.prefix "Taxon"
    /// <summary>
    ///   <para>rdfs:label : applicable vocabulary</para>
    ///   <para>rdfs:comment : In an observable property definition, the applicable vocabulary is the set of terms or concepts from which a nominal value must be drawn.
    ///
    /// Compare with QUDT2 'applicable unit'^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#applicableVocabulary">op:applicableVocabulary</a>
    /// </summary>
    let applicableVocabulary = _prefixId.prefix "applicableVocabulary"
    /// <summary>
    ///   <para>rdfs:label : CAS Number^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#cas-number">op:cas-number</a>
    /// </summary>
    let cas_number = _prefixId.prefix "cas-number"
    /// <summary>
    ///   <para>rdfs:label : constraint</para>
    ///   <para>rdfs:comment : Constraint that refines the definition of an observable property definition. This may include concerns such as realm of application, substance or taxon involved, host organism, matrix, applicable units or vocabulary. ^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#constraint">op:constraint</a>
    /// </summary>
    let constraint_ = _prefixId.prefix "constraint"
    /// <summary>
    ///   <para>rdfs:label : feature of interest</para>
    ///   <para>rdfs:comment : In an observable property definition, the feature-of-interest constrains the feature realm that the property is associated with.^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#featureOfInterest">op:featureOfInterest</a>
    /// </summary>
    let featureOfInterest = _prefixId.prefix "featureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : host organism</para>
    ///   <para>rdfs:comment : In an observable property definition, the host-organism indicates the host taxon, optionally constrained by sex, age, size etc, for an observable property.^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#hostOrganism">op:hostOrganism</a>
    /// </summary>
    let hostOrganism = _prefixId.prefix "hostOrganism"
    /// <summary>
    ///   <para>rdfs:label : matrix</para>
    ///   <para>rdfs:comment : In an observable property definition, the matrix is the material context (container feature or medium) for an observable property.^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#matrix">op:matrix</a>
    /// </summary>
    let matrix = _prefixId.prefix "matrix"
    /// <summary>
    ///   <para>rdfs:label : object of interest</para>
    ///   <para>rdfs:comment : In an observable property definition, this is the substance or taxon whose count, concentration, presence, or other similar property, is of interest. ^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#objectOfInterest">op:objectOfInterest</a>
    /// </summary>
    let objectOfInterest = _prefixId.prefix "objectOfInterest"
    /// <summary>
    ///   <para>rdfs:label : procedure</para>
    ///   <para>rdfs:comment : The procedure is a description of the procedure, algorithm, protocol or sensor system used in making observation or estimate of property value^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#procedure">op:procedure</a>
    /// </summary>
    let procedure = _prefixId.prefix "procedure"
    /// <summary>
    ///   <para>rdfs:label : property kind</para>
    ///   <a href="http://environment.data.gov.au/def/op#propertyKind">op:propertyKind</a>
    /// </summary>
    let propertyKind = _prefixId.prefix "propertyKind"
    /// <summary>
    ///   <para>rdfs:label : quality kind</para>
    ///   <a href="http://environment.data.gov.au/def/op#qualityKind">op:qualityKind</a>
    /// </summary>
    let qualityKind = _prefixId.prefix "qualityKind"
    /// <summary>
    ///   <para>rdfs:label : Statistical Measure^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#statisticalMeasure">op:statisticalMeasure</a>
    /// </summary>
    let statisticalMeasure = _prefixId.prefix "statisticalMeasure"
    /// <summary>
    ///   <para>rdfs:label : object of interest</para>
    ///   <para>rdfs:comment : In an observable property definition, this is the substance whose concentration, presence, or similar is of interest. ^^xsd:string</para>
    ///   <a href="http://environment.data.gov.au/def/op#substance">op:substance</a>
    /// </summary>
    let substance = _prefixId.prefix "substance"
