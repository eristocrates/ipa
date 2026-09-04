#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ccr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccregions#" "ccr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:description : Each region has multiple isolated locations known as Availability Zones.</para>
    ///   <para>rdfs:label : Availability Zone</para>
    ///   <para>rdfs:comment : Availability Zone</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#AvailabilityZone">ccr:AvailabilityZone</a>
    /// </summary>
    let AvailabilityZone = _prefixId.prefix "AvailabilityZone"
    /// <summary>
    ///   <para>dcterms:description : Each Region is hosted in a Geographical Area or Division.</para>
    ///   <para>rdfs:label : Geographical Zone</para>
    ///   <para>rdfs:comment : Geographical Zone</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#GeographicalZone">ccr:GeographicalZone</a>
    /// </summary>
    let GeographicalZone = _prefixId.prefix "GeographicalZone"
    /// <summary>
    ///   <para>dcterms:description : Physical location</para>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : Location</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#Location">ccr:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>dcterms:description : A region is a physical location of a computer center where instances, servers, clusters, etc. are stored. A region is a separate geographic area</para>
    ///   <para>rdfs:label : Region</para>
    ///   <para>rdfs:comment : Region</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#Region">ccr:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : AZ Name</para>
    ///   <para>rdfs:comment : Name of the Availability Zone</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_name">ccr:availabilityzone_name</a>
    /// </summary>
    let availabilityzone_name = _prefixId.prefix "availabilityzone_name"
    /// <summary>
    ///   <para>rdfs:label : AZ Status</para>
    ///   <para>rdfs:comment : Status of the Availability Zone</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_status">ccr:availabilityzone_status</a>
    /// </summary>
    let availabilityzone_status = _prefixId.prefix "availabilityzone_status"
    let cookingbigdata = _prefixId.prefix "cookingbigdata"
    /// <summary>
    ///   <para>rdfs:label : Geo Name</para>
    ///   <para>rdfs:comment : Administrative Geographical area.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#geographical_zone">ccr:geographical_zone</a>
    /// </summary>
    let geographical_zone = _prefixId.prefix "geographical_zone"
    /// <summary>
    ///   <para>rdfs:label : has Availability Zone</para>
    ///   <para>rdfs:comment : Each Zone has almost one Availability Zone</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#hasAvailabilityZone">ccr:hasAvailabilityZone</a>
    /// </summary>
    let hasAvailabilityZone = _prefixId.prefix "hasAvailabilityZone"
    /// <summary>
    ///   <para>rdfs:label : has geographical zone</para>
    ///   <para>rdfs:comment : Each Region is hosted in a Geographical Area or Division</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#hasGeographicalZone">ccr:hasGeographicalZone</a>
    /// </summary>
    let hasGeographicalZone = _prefixId.prefix "hasGeographicalZone"
    let manuelparra = _prefixId.prefix "manuelparra"
    /// <summary>
    ///   <para>rdfs:label : Region code</para>
    ///   <para>rdfs:comment : Short Code of the region.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#region_code">ccr:region_code</a>
    /// </summary>
    let region_code = _prefixId.prefix "region_code"
    /// <summary>
    ///   <para>rdfs:label : Geo Compilance</para>
    ///   <para>rdfs:comment : Compilance with geographical boundaries.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#region_compilance">ccr:region_compilance</a>
    /// </summary>
    let region_compilance = _prefixId.prefix "region_compilance"
    /// <summary>
    ///   <para>rdfs:label : Sovereignty Location</para>
    ///   <para>rdfs:comment : Region Data residency / Sovereignty Location.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#region_dataresidency">ccr:region_dataresidency</a>
    /// </summary>
    let region_dataresidency = _prefixId.prefix "region_dataresidency"
    /// <summary>
    ///   <para>rdfs:label : Region Endpoint</para>
    ///   <para>rdfs:comment : Region Endpoint is the URI of the main resource at the region.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#region_endpoint">ccr:region_endpoint</a>
    /// </summary>
    let region_endpoint = _prefixId.prefix "region_endpoint"
    /// <summary>
    ///   <para>rdfs:label : Region Location</para>
    ///   <para>rdfs:comment : Physical Location for a region.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#region_location">ccr:region_location</a>
    /// </summary>
    let region_location = _prefixId.prefix "region_location"
    /// <summary>
    ///   <para>rdfs:label : Region name</para>
    ///   <para>rdfs:comment : Name of the region.</para>
    ///   <a href="http://cookingbigdata.com/linkeddata/ccregions#region_name">ccr:region_name</a>
    /// </summary>
    let region_name = _prefixId.prefix "region_name"
