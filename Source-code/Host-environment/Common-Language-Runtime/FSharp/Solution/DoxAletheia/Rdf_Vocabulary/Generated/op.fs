namespace http.environment.data.gov.au.def.op.hash

open DoxAletheia

module op =
    let _namespace_name = "http://environment.data.gov.au/def/op#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The identifier for a substance provided by the Chemical Abstracts Service
    /// <see href="http://environment.data.gov.au/def/op#CAS-number"></see></summary>
    let ``CAS-number`` = _prefix "CAS-number"
    /// <summary>
    /// Superclass of qudt:QuantityKind
    /// This class accommodates all kinds of properties, including those (qualities) that are not described by quantities (numeric values).
    /// May carry constraints, such as substance, objectOfInterest, featureOfInterest, matrix, hostOrganism, to refine the definition of a generalization. property is associated
    /// e.g. tree-height, nitrogen-concentration, concentration-of-zinc-in-the-liver-of-a-specific-fish-taxon-only-males-larger-than-20cm
    /// <see href="http://environment.data.gov.au/def/op#PropertyKind"></see></summary>
    let PropertyKind = _prefix "PropertyKind"
    /// <summary>
    /// non-numeric PropertyKind
    /// <see href="http://environment.data.gov.au/def/op#QualityKind"></see></summary>
    let QualityKind = _prefix "QualityKind"
    /// <summary>
    /// Scaled quantity kind has one or more unit properties, which indicate valid units of measure for this quantity kind.
    ///
    /// It is likely that this class is equivalent to qudt:QuantityKind, but has been declared independently for governance of the attached qudt:unit property
    /// <see href="http://environment.data.gov.au/def/op#ScaledQuantityKind"></see></summary>
    let ScaledQuantityKind = _prefix "ScaledQuantityKind"
    /// <summary>
    /// type of material
    ///
    /// Typically a chemical substance, with a formal designator from CAS or ChEBI or similar, but may include less formal grouplings or union types when needed
    /// <see href="http://environment.data.gov.au/def/op#Substance"></see></summary>
    let Substance = _prefix "Substance"
    /// <summary>
    /// Class of stuff and things, individuals of which identify a class of stuff and things that make observed properties concrete.
    /// <see href="http://environment.data.gov.au/def/op#SubstanceOrTaxon"></see></summary>
    let SubstanceOrTaxon = _prefix "SubstanceOrTaxon"
    /// <summary>
    /// type of organism, any rank
    ///
    /// Preferably with a formally recognised designiation such as a latin binomial, or LSID, but may be a less formal grouping when needed.
    /// <see href="http://environment.data.gov.au/def/op#Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    /// In an observable property definition, the applicable vocabulary is the set of terms or concepts from which a nominal value must be drawn.
    ///
    /// Compare with QUDT2 'applicable unit'
    /// <see href="http://environment.data.gov.au/def/op#applicableVocabulary"></see></summary>
    let applicableVocabulary = _prefix "applicableVocabulary"
    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#cas-number"></see>
    /// </summary>
    let ``cas-number`` = _prefix "cas-number"
    /// <summary>
    /// Constraint that refines the definition of an observable property definition. This may include concerns such as realm of application, substance or taxon involved, host organism, matrix, applicable units or vocabulary.
    /// <see href="http://environment.data.gov.au/def/op#constraint"></see></summary>
    let constraint_ = _prefix "constraint"
    /// <summary>
    /// In an observable property definition, the feature-of-interest constrains the feature realm that the property is associated with.
    /// <see href="http://environment.data.gov.au/def/op#featureOfInterest"></see></summary>
    let featureOfInterest = _prefix "featureOfInterest"
    /// <summary>
    /// In an observable property definition, the host-organism indicates the host taxon, optionally constrained by sex, age, size etc, for an observable property.
    /// <see href="http://environment.data.gov.au/def/op#hostOrganism"></see></summary>
    let hostOrganism = _prefix "hostOrganism"
    /// <summary>
    /// In an observable property definition, the matrix is the material context (container feature or medium) for an observable property.
    /// <see href="http://environment.data.gov.au/def/op#matrix"></see></summary>
    let matrix = _prefix "matrix"
    /// <summary>
    /// In an observable property definition, this is the substance or taxon whose count, concentration, presence, or other similar property, is of interest.
    /// <see href="http://environment.data.gov.au/def/op#objectOfInterest"></see></summary>
    let objectOfInterest = _prefix "objectOfInterest"
    /// <summary>
    /// In an observable property definition, this is the substance whose concentration, presence, or similar is of interest.
    /// <see href="http://environment.data.gov.au/def/op#substance"></see></summary>
    let substance = _prefix "substance"
    /// <summary>
    /// The procedure is a description of the procedure, algorithm, protocol or sensor system used in making observation or estimate of property value
    /// <see href="http://environment.data.gov.au/def/op#procedure"></see></summary>
    let procedure = _prefix "procedure"
    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#propertyKind"></see>
    /// </summary>
    let propertyKind = _prefix "propertyKind"
    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#qualityKind"></see>
    /// </summary>
    let qualityKind = _prefix "qualityKind"
    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#statisticalMeasure"></see>
    /// </summary>
    let statisticalMeasure = _prefix "statisticalMeasure"
