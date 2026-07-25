namespace http.cookingbigdata.com.linkeddata.ccregions.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ccr =
    let _namespace_iri = Namespace_Iri ccr |> NamespaceIRI
    /// <summary>
    ///   <para>ccr:manuelparra</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#manuelparra">http://cookingbigdata.com/linkeddata/ccregions#manuelparra</seealso>
    let manuelparra = Prefixed_Name(ccr, "manuelparra") |> PrefixedName
    /// <summary>
    ///   <para>ccr:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Location</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#Location">http://cookingbigdata.com/linkeddata/ccregions#Location</seealso>
    let Location = Prefixed_Name(ccr, "Location") |> PrefixedName
    /// <summary>
    ///   <para>ccr:AvailabilityZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Availability Zone</para>
    /// labels<para>Availability Zone</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#AvailabilityZone">http://cookingbigdata.com/linkeddata/ccregions#AvailabilityZone</seealso>
    let AvailabilityZone = Prefixed_Name(ccr, "AvailabilityZone") |> PrefixedName
    /// <summary>
    ///   <para>ccr:region_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name of the region.</para>
    /// labels<para>Region name</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#region_name">http://cookingbigdata.com/linkeddata/ccregions#region_name</seealso>
    let region_name = Prefixed_Name(ccr, "region_name") |> PrefixedName
    /// <summary>
    ///   <para>ccr:GeographicalZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Geographical Zone</para>
    /// labels<para>Geographical Zone</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#GeographicalZone">http://cookingbigdata.com/linkeddata/ccregions#GeographicalZone</seealso>
    let GeographicalZone = Prefixed_Name(ccr, "GeographicalZone") |> PrefixedName
    /// <summary>
    ///   <para>ccr:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Region</para>
    /// labels<para>Region</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#Region">http://cookingbigdata.com/linkeddata/ccregions#Region</seealso>
    let Region = Prefixed_Name(ccr, "Region") |> PrefixedName
    /// <summary>
    ///   <para>ccr:geographical_zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Administrative Geographical area.</para>
    /// labels<para>Geo Name</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#geographical_zone">http://cookingbigdata.com/linkeddata/ccregions#geographical_zone</seealso>
    let geographical_zone = Prefixed_Name(ccr, "geographical_zone") |> PrefixedName
    /// <summary>
    ///   <para>ccr:hasAvailabilityZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Each Zone has almost one Availability Zone</para>
    /// labels<para>has Availability Zone</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#hasAvailabilityZone">http://cookingbigdata.com/linkeddata/ccregions#hasAvailabilityZone</seealso>
    let hasAvailabilityZone = Prefixed_Name(ccr, "hasAvailabilityZone") |> PrefixedName
    /// <summary>
    ///   <para>ccr:region_compilance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Compilance with geographical boundaries.</para>
    /// labels<para>Geo Compilance</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#region_compilance">http://cookingbigdata.com/linkeddata/ccregions#region_compilance</seealso>
    let region_compilance = Prefixed_Name(ccr, "region_compilance") |> PrefixedName
    /// <summary>
    ///   <para>ccr:region_code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Short Code of the region.</para>
    /// labels<para>Region code</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#region_code">http://cookingbigdata.com/linkeddata/ccregions#region_code</seealso>
    let region_code = Prefixed_Name(ccr, "region_code") |> PrefixedName

    /// <summary>
    ///   <para>ccr:region_dataresidency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Region Data residency / Sovereignty Location.</para>
    /// labels<para>Sovereignty Location</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#region_dataresidency">http://cookingbigdata.com/linkeddata/ccregions#region_dataresidency</seealso>
    let region_dataresidency =
        Prefixed_Name(ccr, "region_dataresidency") |> PrefixedName

    /// <summary>
    ///   <para>ccr:region_endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Region Endpoint is the URI of the main resource at the region.</para>
    /// labels<para>Region Endpoint</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#region_endpoint">http://cookingbigdata.com/linkeddata/ccregions#region_endpoint</seealso>
    let region_endpoint = Prefixed_Name(ccr, "region_endpoint") |> PrefixedName
    /// <summary>
    ///   <para>ccr:region_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Physical Location for a region.</para>
    /// labels<para>Region Location</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#region_location">http://cookingbigdata.com/linkeddata/ccregions#region_location</seealso>
    let region_location = Prefixed_Name(ccr, "region_location") |> PrefixedName
    /// <summary>
    ///   <para>ccr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Cloud Computing regions and availability zones</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#">http://cookingbigdata.com/linkeddata/ccregions#</seealso>
    let _prefix_iri = Prefixed_Name(ccr, "") |> PrefixedName
    /// <summary>
    ///   <para>ccr:cookingbigdata</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#cookingbigdata">http://cookingbigdata.com/linkeddata/ccregions#cookingbigdata</seealso>
    let cookingbigdata = Prefixed_Name(ccr, "cookingbigdata") |> PrefixedName

    /// <summary>
    ///   <para>ccr:availabilityzone_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name of the Availability Zone</para>
    /// labels<para>AZ Name</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_name">http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_name</seealso>
    let availabilityzone_name =
        Prefixed_Name(ccr, "availabilityzone_name") |> PrefixedName

    /// <summary>
    ///   <para>ccr:availabilityzone_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Status of the Availability Zone</para>
    /// labels<para>AZ Status</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_status">http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_status</seealso>
    let availabilityzone_status =
        Prefixed_Name(ccr, "availabilityzone_status") |> PrefixedName

    /// <summary>
    ///   <para>ccr:hasGeographicalZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Each Region is hosted in a Geographical Area or Division</para>
    /// labels<para>has geographical zone</para></remarks>
    /// <seealso href="http://cookingbigdata.com/linkeddata/ccregions#hasGeographicalZone">http://cookingbigdata.com/linkeddata/ccregions#hasGeographicalZone</seealso>
    let hasGeographicalZone = Prefixed_Name(ccr, "hasGeographicalZone") |> PrefixedName
