namespace http.purl.org.linked_data.sdmx.hash

open DoxAletheia.Rdf_Vocabulary

module sdmx =
    let _namespace_name = "http://purl.org/linked-data/sdmx#"

    /// <summary>
    /// The concept corresponding to the generic measure type dimension which indicates which measure is being denoted by the primary measure on an observation
    /// <see href="http://purl.org/linked-data/sdmx#measureTypeConcept"></see></summary>
    let measureTypeConcept =
        Namespaced_IRI.parse _namespace_name "measureTypeConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx#CodeList"></see>
    /// </summary>
    let CodeList = Namespaced_IRI.parse _namespace_name "CodeList" |> NamespacedName
    /// <summary>
    /// Denotes an SDMX concept, used in the particular SDMX terminological sense, which is in principle narrower than skos:Concept
    /// <see href="http://purl.org/linked-data/sdmx#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    /// Abstract superclass of classes denoting statistical roles which be played by concepts
    /// <see href="http://purl.org/linked-data/sdmx#ConceptRole"></see></summary>
    let ConceptRole =
        Namespaced_IRI.parse _namespace_name "ConceptRole" |> NamespacedName

    /// <summary>
    /// concept for a dimension or attribute that plays the role of an identifier where the identifier is taken from a known system of counts (e.g. the Nth current dataset update for a given day)
    /// <see href="http://purl.org/linked-data/sdmx#CountRole"></see></summary>
    let CountRole = Namespaced_IRI.parse _namespace_name "CountRole" |> NamespacedName

    /// <summary>
    /// A specialization of qb:DataStructureDefinition which additional constraints: if there are multiple measures then a MeasureDimensionProperty must be included in the DSD
    /// <see href="http://purl.org/linked-data/sdmx#DataStructureDefinition"></see></summary>
    let DataStructureDefinition =
        Namespaced_IRI.parse _namespace_name "DataStructureDefinition" |> NamespacedName

    /// <summary>
    /// concept for a dimension or attribute that plays the role of the DataAttribute subject to whom the data refers (e.g. the reporting agent for primary reporting, the country for secondary reporting)
    /// <see href="http://purl.org/linked-data/sdmx#EntityRole"></see></summary>
    let EntityRole = Namespaced_IRI.parse _namespace_name "EntityRole" |> NamespacedName

    /// <summary>
    /// concept for a dimension or attribute that plays the role of frequency
    /// <see href="http://purl.org/linked-data/sdmx#FrequencyRole"></see></summary>
    let FrequencyRole =
        Namespaced_IRI.parse _namespace_name "FrequencyRole" |> NamespacedName

    /// <summary>
    /// concept for a dimension or attribute that plays the role of an identifier which is taken from a known scheme of identifiers.
    /// <see href="http://purl.org/linked-data/sdmx#IdentityRole"></see></summary>
    let IdentityRole =
        Namespaced_IRI.parse _namespace_name "IdentityRole" |> NamespacedName

    /// <summary>
    /// concept for a dimension that plays the role of identifying a type of measure
    /// <see href="http://purl.org/linked-data/sdmx#MeasureTypeRole"></see></summary>
    let MeasureTypeRole =
        Namespaced_IRI.parse _namespace_name "MeasureTypeRole" |> NamespacedName

    /// <summary>
    /// concept for a dimension or attribute that plays the role of a date/time identifier in the KeyFamily which is not related to the time of the observation
    /// <see href="http://purl.org/linked-data/sdmx#NonObsTimeRole"></see></summary>
    let NonObsTimeRole =
        Namespaced_IRI.parse _namespace_name "NonObsTimeRole" |> NamespacedName

    /// <summary>
    /// concept for a measure that plays the role of the observation in a time series
    /// <see href="http://purl.org/linked-data/sdmx#PrimaryMeasureRole"></see></summary>
    let PrimaryMeasureRole =
        Namespaced_IRI.parse _namespace_name "PrimaryMeasureRole" |> NamespacedName

    /// <summary>
    /// concept for a dimension that specifies the time of the observation of the primaryMeasure
    /// <see href="http://purl.org/linked-data/sdmx#TimeRole"></see></summary>
    let TimeRole = Namespaced_IRI.parse _namespace_name "TimeRole" |> NamespacedName

    /// <summary>
    /// Indicates an additional component used as the primary measure within the SDMX data. In the case of multi-measure data sets the RDF representation uses the specific measure rather than a subsuming overall measure. This property records the subsuming primary measure (typically sdmx-measure:obsValue) to enable round tripping of this information.
    /// <see href="http://purl.org/linked-data/sdmx#primaryMeasure"></see></summary>
    let primaryMeasure =
        Namespaced_IRI.parse _namespace_name "primaryMeasure" |> NamespacedName
