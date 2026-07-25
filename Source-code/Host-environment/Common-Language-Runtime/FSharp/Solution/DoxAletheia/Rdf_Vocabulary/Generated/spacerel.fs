namespace http.data.ordnancesurvey.co.uk.ontology.spatialrelations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spacerel =
    let _namespace_iri = Namespace_Iri spacerel |> NamespaceIRI
    /// <summary>
    ///   <para>spacerel:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The interior of one object completely contains the interior of the other. Their boundaries may or may not intersect.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/contains">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/contains</seealso>
    let contains = Prefixed_Name(spacerel, "contains") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:equals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>The two objects have the same boundary and the same interior.</para>
    /// labels<para>equal</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/equals">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/equals</seealso>
    let equals = Prefixed_Name(spacerel, "equals") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:within</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>The interior of one object is completely within the interior of the other object. Their boundaries may or may not intersect.</para>
    /// labels<para>within</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/within">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/within</seealso>
    let within = Prefixed_Name(spacerel, "within") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>The boundaries and interiors of the two objects do not intersect, i.e. they have no points in common.</para>
    /// labels<para>disjoint</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/disjoint">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/disjoint</seealso>
    let disjoint = Prefixed_Name(spacerel, "disjoint") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:easting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Distance in metres east of National Grid origin.</para>
    /// labels<para>easting</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/easting">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/easting</seealso>
    let easting = Prefixed_Name(spacerel, "easting") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:northing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Distance in metres north of National Grid origin.</para>
    /// labels<para>northing</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/northing">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/northing</seealso>
    let northing = Prefixed_Name(spacerel, "northing") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:touches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>The boundaries of the two objects intersect but their interiors do not.</para>
    /// labels<para>touches</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/touches">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/touches</seealso>
    let touches = Prefixed_Name(spacerel, "touches") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:containedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/containedBy">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/containedBy</seealso>
    let containedBy = Prefixed_Name(spacerel, "containedBy") |> PrefixedName
    /// <summary>
    ///   <para>spacerel:partiallyOverlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>The boundaries and interiors of the two objects intersect.</para>
    /// labels<para>overlaps</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/partiallyOverlaps">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/partiallyOverlaps</seealso>
    let partiallyOverlaps = Prefixed_Name(spacerel, "partiallyOverlaps") |> PrefixedName

    /// <summary>
    ///   <para>spacerel:twentyKMGridReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The National Grid reference identifying the 20km square in which the name falls.</para>
    /// labels<para>20km Grid Reference</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/twentyKMGridReference">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/twentyKMGridReference</seealso>
    let twentyKMGridReference =
        Prefixed_Name(spacerel, "twentyKMGridReference") |> PrefixedName

    /// <summary>
    ///   <para>spacerel:oneKMGridReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The National Grid reference identifying the km square in which the name falls.</para>
    /// labels<para>1km Grid Reference</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/oneKMGridReference">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/oneKMGridReference</seealso>
    let oneKMGridReference =
        Prefixed_Name(spacerel, "oneKMGridReference") |> PrefixedName

    /// <summary>
    ///   <para>spacerel:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Spatial Relations Ontology</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/">http://data.ordnancesurvey.co.uk/ontology/spatialrelations/</seealso>
    let _prefix_iri = Prefixed_Name(spacerel, "") |> PrefixedName
