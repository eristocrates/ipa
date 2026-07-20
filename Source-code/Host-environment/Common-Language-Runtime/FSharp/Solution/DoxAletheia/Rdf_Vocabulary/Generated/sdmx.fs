namespace http.purl.org.linked_data.sdmx.hash

open DoxAletheia

module sdmx =
    let _namespace_name = "http://purl.org/linked-data/sdmx#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The concept corresponding to the generic measure type dimension which indicates which measure is being denoted by the primary measure on an observation
    /// <see href="http://purl.org/linked-data/sdmx#measureTypeConcept"></see></summary>
    let measureTypeConcept = _prefix "measureTypeConcept"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx#CodeList"></see>
    /// </summary>
    let CodeList = _prefix "CodeList"
    /// <summary>
    /// Denotes an SDMX concept, used in the particular SDMX terminological sense, which is in principle narrower than skos:Concept
    /// <see href="http://purl.org/linked-data/sdmx#Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// Abstract superclass of classes denoting statistical roles which be played by concepts
    /// <see href="http://purl.org/linked-data/sdmx#ConceptRole"></see></summary>
    let ConceptRole = _prefix "ConceptRole"
    /// <summary>
    /// concept for a dimension or attribute that plays the role of an identifier where the identifier is taken from a known system of counts (e.g. the Nth current dataset update for a given day)
    /// <see href="http://purl.org/linked-data/sdmx#CountRole"></see></summary>
    let CountRole = _prefix "CountRole"
    /// <summary>
    /// A specialization of qb:DataStructureDefinition which additional constraints: if there are multiple measures then a MeasureDimensionProperty must be included in the DSD
    /// <see href="http://purl.org/linked-data/sdmx#DataStructureDefinition"></see></summary>
    let DataStructureDefinition = _prefix "DataStructureDefinition"
    /// <summary>
    /// concept for a dimension or attribute that plays the role of the DataAttribute subject to whom the data refers (e.g. the reporting agent for primary reporting, the country for secondary reporting)
    /// <see href="http://purl.org/linked-data/sdmx#EntityRole"></see></summary>
    let EntityRole = _prefix "EntityRole"
    /// <summary>
    /// concept for a dimension or attribute that plays the role of frequency
    /// <see href="http://purl.org/linked-data/sdmx#FrequencyRole"></see></summary>
    let FrequencyRole = _prefix "FrequencyRole"
    /// <summary>
    /// concept for a dimension or attribute that plays the role of an identifier which is taken from a known scheme of identifiers.
    /// <see href="http://purl.org/linked-data/sdmx#IdentityRole"></see></summary>
    let IdentityRole = _prefix "IdentityRole"
    /// <summary>
    /// concept for a dimension that plays the role of identifying a type of measure
    /// <see href="http://purl.org/linked-data/sdmx#MeasureTypeRole"></see></summary>
    let MeasureTypeRole = _prefix "MeasureTypeRole"
    /// <summary>
    /// concept for a dimension or attribute that plays the role of a date/time identifier in the KeyFamily which is not related to the time of the observation
    /// <see href="http://purl.org/linked-data/sdmx#NonObsTimeRole"></see></summary>
    let NonObsTimeRole = _prefix "NonObsTimeRole"
    /// <summary>
    /// concept for a measure that plays the role of the observation in a time series
    /// <see href="http://purl.org/linked-data/sdmx#PrimaryMeasureRole"></see></summary>
    let PrimaryMeasureRole = _prefix "PrimaryMeasureRole"
    /// <summary>
    /// concept for a dimension that specifies the time of the observation of the primaryMeasure
    /// <see href="http://purl.org/linked-data/sdmx#TimeRole"></see></summary>
    let TimeRole = _prefix "TimeRole"
    /// <summary>
    /// Indicates an additional component used as the primary measure within the SDMX data. In the case of multi-measure data sets the RDF representation uses the specific measure rather than a subsuming overall measure. This property records the subsuming primary measure (typically sdmx-measure:obsValue) to enable round tripping of this information.
    /// <see href="http://purl.org/linked-data/sdmx#primaryMeasure"></see></summary>
    let primaryMeasure = _prefix "primaryMeasure"
