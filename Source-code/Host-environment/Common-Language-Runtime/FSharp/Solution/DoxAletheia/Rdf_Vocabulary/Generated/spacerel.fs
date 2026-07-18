namespace http.data.ordnancesurvey.co.uk.ontology.spatialrelations.slash

open DoxAletheia.Rdf_Vocabulary

module spacerel =
    let _namespace_name = "http://data.ordnancesurvey.co.uk/ontology/spatialrelations/"

    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/containedBy"></see>
    /// </summary>
    let containedBy =
        Namespaced_IRI.parse _namespace_name "containedBy" |> NamespacedName

    /// <summary>
    /// The interior of one object is completely within the interior of the other object. Their boundaries may or may not intersect.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/within"></see></summary>
    let within = Namespaced_IRI.parse _namespace_name "within" |> NamespacedName
    /// <summary>
    /// The interior of one object completely contains the interior of the other. Their boundaries may or may not intersect.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// The two objects have the same boundary and the same interior.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/equals"></see></summary>
    let equals = Namespaced_IRI.parse _namespace_name "equals" |> NamespacedName
    /// <summary>
    /// The boundaries and interiors of the two objects do not intersect, i.e. they have no points in common.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/disjoint"></see></summary>
    let disjoint = Namespaced_IRI.parse _namespace_name "disjoint" |> NamespacedName
    /// <summary>
    /// Distance in metres east of National Grid origin.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/easting"></see></summary>
    let easting = Namespaced_IRI.parse _namespace_name "easting" |> NamespacedName
    /// <summary>
    /// Distance in metres north of National Grid origin.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/northing"></see></summary>
    let northing = Namespaced_IRI.parse _namespace_name "northing" |> NamespacedName

    /// <summary>
    /// The National Grid reference identifying the km square in which the name falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/oneKMGridReference"></see></summary>
    let oneKMGridReference =
        Namespaced_IRI.parse _namespace_name "oneKMGridReference" |> NamespacedName

    /// <summary>
    /// The boundaries and interiors of the two objects intersect.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/partiallyOverlaps"></see></summary>
    let partiallyOverlaps =
        Namespaced_IRI.parse _namespace_name "partiallyOverlaps" |> NamespacedName

    /// <summary>
    /// The boundaries of the two objects intersect but their interiors do not.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/touches"></see></summary>
    let touches = Namespaced_IRI.parse _namespace_name "touches" |> NamespacedName

    /// <summary>
    /// The National Grid reference identifying the 20km square in which the name falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/twentyKMGridReference"></see></summary>
    let twentyKMGridReference =
        Namespaced_IRI.parse _namespace_name "twentyKMGridReference" |> NamespacedName
