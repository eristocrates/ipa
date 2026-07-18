namespace http.environment.data.gov.au.def.op.hash

open DoxAletheia.Rdf_Vocabulary

module op =
    let _namespace_name = "http://environment.data.gov.au/def/op#"

    /// <summary>
    /// The identifier for a substance provided by the Chemical Abstracts Service
    /// <see href="http://environment.data.gov.au/def/op#CAS-number"></see></summary>
    let ``CAS-number`` =
        Namespaced_IRI.parse _namespace_name "CAS-number" |> NamespacedName

    /// <summary>
    /// Superclass of qudt:QuantityKind
    /// This class accommodates all kinds of properties, including those (qualities) that are not described by quantities (numeric values).
    /// May carry constraints, such as substance, objectOfInterest, featureOfInterest, matrix, hostOrganism, to refine the definition of a generalization. property is associated
    /// e.g. tree-height, nitrogen-concentration, concentration-of-zinc-in-the-liver-of-a-specific-fish-taxon-only-males-larger-than-20cm
    /// <see href="http://environment.data.gov.au/def/op#PropertyKind"></see></summary>
    let PropertyKind =
        Namespaced_IRI.parse _namespace_name "PropertyKind" |> NamespacedName

    /// <summary>
    /// non-numeric PropertyKind
    /// <see href="http://environment.data.gov.au/def/op#QualityKind"></see></summary>
    let QualityKind =
        Namespaced_IRI.parse _namespace_name "QualityKind" |> NamespacedName

    /// <summary>
    /// Scaled quantity kind has one or more unit properties, which indicate valid units of measure for this quantity kind.
    ///
    /// It is likely that this class is equivalent to qudt:QuantityKind, but has been declared independently for governance of the attached qudt:unit property
    /// <see href="http://environment.data.gov.au/def/op#ScaledQuantityKind"></see></summary>
    let ScaledQuantityKind =
        Namespaced_IRI.parse _namespace_name "ScaledQuantityKind" |> NamespacedName

    /// <summary>
    /// type of material
    ///
    /// Typically a chemical substance, with a formal designator from CAS or ChEBI or similar, but may include less formal grouplings or union types when needed
    /// <see href="http://environment.data.gov.au/def/op#Substance"></see></summary>
    let Substance = Namespaced_IRI.parse _namespace_name "Substance" |> NamespacedName

    /// <summary>
    /// Class of stuff and things, individuals of which identify a class of stuff and things that make observed properties concrete.
    /// <see href="http://environment.data.gov.au/def/op#SubstanceOrTaxon"></see></summary>
    let SubstanceOrTaxon =
        Namespaced_IRI.parse _namespace_name "SubstanceOrTaxon" |> NamespacedName

    /// <summary>
    /// type of organism, any rank
    ///
    /// Preferably with a formally recognised designiation such as a latin binomial, or LSID, but may be a less formal grouping when needed.
    /// <see href="http://environment.data.gov.au/def/op#Taxon"></see></summary>
    let Taxon = Namespaced_IRI.parse _namespace_name "Taxon" |> NamespacedName

    /// <summary>
    /// In an observable property definition, the applicable vocabulary is the set of terms or concepts from which a nominal value must be drawn.
    ///
    /// Compare with QUDT2 'applicable unit'
    /// <see href="http://environment.data.gov.au/def/op#applicableVocabulary"></see></summary>
    let applicableVocabulary =
        Namespaced_IRI.parse _namespace_name "applicableVocabulary" |> NamespacedName

    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#cas-number"></see>
    /// </summary>
    let ``cas-number`` =
        Namespaced_IRI.parse _namespace_name "cas-number" |> NamespacedName

    /// <summary>
    /// Constraint that refines the definition of an observable property definition. This may include concerns such as realm of application, substance or taxon involved, host organism, matrix, applicable units or vocabulary.
    /// <see href="http://environment.data.gov.au/def/op#constraint"></see></summary>
    let constraint_ =
        Namespaced_IRI.parse _namespace_name "constraint" |> NamespacedName

    /// <summary>
    /// In an observable property definition, the feature-of-interest constrains the feature realm that the property is associated with.
    /// <see href="http://environment.data.gov.au/def/op#featureOfInterest"></see></summary>
    let featureOfInterest =
        Namespaced_IRI.parse _namespace_name "featureOfInterest" |> NamespacedName

    /// <summary>
    /// In an observable property definition, the host-organism indicates the host taxon, optionally constrained by sex, age, size etc, for an observable property.
    /// <see href="http://environment.data.gov.au/def/op#hostOrganism"></see></summary>
    let hostOrganism =
        Namespaced_IRI.parse _namespace_name "hostOrganism" |> NamespacedName

    /// <summary>
    /// In an observable property definition, the matrix is the material context (container feature or medium) for an observable property.
    /// <see href="http://environment.data.gov.au/def/op#matrix"></see></summary>
    let matrix = Namespaced_IRI.parse _namespace_name "matrix" |> NamespacedName

    /// <summary>
    /// In an observable property definition, this is the substance or taxon whose count, concentration, presence, or other similar property, is of interest.
    /// <see href="http://environment.data.gov.au/def/op#objectOfInterest"></see></summary>
    let objectOfInterest =
        Namespaced_IRI.parse _namespace_name "objectOfInterest" |> NamespacedName

    /// <summary>
    /// In an observable property definition, this is the substance whose concentration, presence, or similar is of interest.
    /// <see href="http://environment.data.gov.au/def/op#substance"></see></summary>
    let substance = Namespaced_IRI.parse _namespace_name "substance" |> NamespacedName
    /// <summary>
    /// The procedure is a description of the procedure, algorithm, protocol or sensor system used in making observation or estimate of property value
    /// <see href="http://environment.data.gov.au/def/op#procedure"></see></summary>
    let procedure = Namespaced_IRI.parse _namespace_name "procedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#propertyKind"></see>
    /// </summary>
    let propertyKind =
        Namespaced_IRI.parse _namespace_name "propertyKind" |> NamespacedName

    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#qualityKind"></see>
    /// </summary>
    let qualityKind =
        Namespaced_IRI.parse _namespace_name "qualityKind" |> NamespacedName

    /// <summary>
    ///   <see href="http://environment.data.gov.au/def/op#statisticalMeasure"></see>
    /// </summary>
    let statisticalMeasure =
        Namespaced_IRI.parse _namespace_name "statisticalMeasure" |> NamespacedName
