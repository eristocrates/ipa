namespace http.data.ordnancesurvey.co.uk.ontology.spatialrelations.slash

open DoxAletheia

module spacerel =
    let _namespace_name = "http://data.ordnancesurvey.co.uk/ontology/spatialrelations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/containedBy"></see>
    /// </summary>
    let containedBy = _prefix "containedBy"
    /// <summary>
    /// The interior of one object is completely within the interior of the other object. Their boundaries may or may not intersect.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/within"></see></summary>
    let within = _prefix "within"
    /// <summary>
    /// The interior of one object completely contains the interior of the other. Their boundaries may or may not intersect.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// The two objects have the same boundary and the same interior.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/equals"></see></summary>
    let equals = _prefix "equals"
    /// <summary>
    /// The boundaries and interiors of the two objects do not intersect, i.e. they have no points in common.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/disjoint"></see></summary>
    let disjoint = _prefix "disjoint"
    /// <summary>
    /// Distance in metres east of National Grid origin.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/easting"></see></summary>
    let easting = _prefix "easting"
    /// <summary>
    /// Distance in metres north of National Grid origin.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/northing"></see></summary>
    let northing = _prefix "northing"
    /// <summary>
    /// The National Grid reference identifying the km square in which the name falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/oneKMGridReference"></see></summary>
    let oneKMGridReference = _prefix "oneKMGridReference"
    /// <summary>
    /// The boundaries and interiors of the two objects intersect.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/partiallyOverlaps"></see></summary>
    let partiallyOverlaps = _prefix "partiallyOverlaps"
    /// <summary>
    /// The boundaries of the two objects intersect but their interiors do not.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/touches"></see></summary>
    let touches = _prefix "touches"
    /// <summary>
    /// The National Grid reference identifying the 20km square in which the name falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/twentyKMGridReference"></see></summary>
    let twentyKMGridReference = _prefix "twentyKMGridReference"
