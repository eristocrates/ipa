#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module osspr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/spatialrelations/" "osspr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/containedBy">osspr:containedBy</a>
    /// </summary>
    let containedBy = _prefixId.prefix "containedBy"
    /// <summary>
    ///   <para>rdfs:comment : The interior of one object completely contains the interior of the other. Their boundaries may or may not intersect.^^xsd:string</para>
    ///   <para>rdfs:label : contains</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/contains">osspr:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : disjoint</para>
    ///   <para>rdfs:comment : The boundaries and interiors of the two objects do not intersect, i.e. they have no points in common.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/disjoint">osspr:disjoint</a>
    /// </summary>
    let disjoint = _prefixId.prefix "disjoint"
    /// <summary>
    ///   <para>rdfs:comment : Distance in metres east of National Grid origin.^^xsd:string</para>
    ///   <para>rdfs:label : easting^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/easting">osspr:easting</a>
    /// </summary>
    let easting = _prefixId.prefix "easting"
    /// <summary>
    ///   <para>rdfs:label : equal</para>
    ///   <para>rdfs:comment : The two objects have the same boundary and the same interior.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/equals">osspr:equals</a>
    /// </summary>
    let equals = _prefixId.prefix "equals"
    /// <summary>
    ///   <para>rdfs:comment : Distance in metres north of National Grid origin.^^xsd:string</para>
    ///   <para>rdfs:label : northing^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/northing">osspr:northing</a>
    /// </summary>
    let northing = _prefixId.prefix "northing"
    /// <summary>
    ///   <para>rdfs:comment : The National Grid reference identifying the km square in which the name falls.^^xsd:string</para>
    ///   <para>rdfs:label : 1km Grid Reference^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/oneKMGridReference">osspr:oneKMGridReference</a>
    /// </summary>
    let oneKMGridReference = _prefixId.prefix "oneKMGridReference"
    /// <summary>
    ///   <para>rdfs:label : overlaps</para>
    ///   <para>rdfs:comment : The boundaries and interiors of the two objects intersect.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/partiallyOverlaps">osspr:partiallyOverlaps</a>
    /// </summary>
    let partiallyOverlaps = _prefixId.prefix "partiallyOverlaps"
    /// <summary>
    ///   <para>rdfs:comment : The boundaries of the two objects intersect but their interiors do not.^^xsd:string</para>
    ///   <para>rdfs:label : touches</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/touches">osspr:touches</a>
    /// </summary>
    let touches = _prefixId.prefix "touches"
    /// <summary>
    ///   <para>rdfs:comment : The National Grid reference identifying the 20km square in which the name falls.^^xsd:string</para>
    ///   <para>rdfs:label : 20km Grid Reference^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/twentyKMGridReference">osspr:twentyKMGridReference</a>
    /// </summary>
    let twentyKMGridReference = _prefixId.prefix "twentyKMGridReference"
    /// <summary>
    ///   <para>rdfs:comment : The interior of one object is completely within the interior of the other object. Their boundaries may or may not intersect.^^xsd:string</para>
    ///   <para>rdfs:label : within</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/spatialrelations/within">osspr:within</a>
    /// </summary>
    let within = _prefixId.prefix "within"
