namespace http.cookingbigdata.com.linkeddata.ccregions.hash

open DoxAletheia

module ccr =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccregions#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccregions#manuelparra"></see>
    /// </summary>
    let manuelparra = _prefix "manuelparra"
    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccregions#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata = _prefix "cookingbigdata"
    /// <summary>
    /// Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#AvailabilityZone"></see></summary>
    let AvailabilityZone = _prefix "AvailabilityZone"
    /// <summary>
    /// Geographical Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#GeographicalZone"></see></summary>
    let GeographicalZone = _prefix "GeographicalZone"
    /// <summary>
    /// Location
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Region
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// Name of the Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_name"></see></summary>
    let availabilityzone_name = _prefix "availabilityzone_name"
    /// <summary>
    /// Status of the Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_status"></see></summary>
    let availabilityzone_status = _prefix "availabilityzone_status"
    /// <summary>
    /// Administrative Geographical area.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#geographical_zone"></see></summary>
    let geographical_zone = _prefix "geographical_zone"
    /// <summary>
    /// Each Zone has almost one Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#hasAvailabilityZone"></see></summary>
    let hasAvailabilityZone = _prefix "hasAvailabilityZone"
    /// <summary>
    /// Each Region is hosted in a Geographical Area or Division
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#hasGeographicalZone"></see></summary>
    let hasGeographicalZone = _prefix "hasGeographicalZone"
    /// <summary>
    /// Short Code of the region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_code"></see></summary>
    let region_code = _prefix "region_code"
    /// <summary>
    /// Compilance with geographical boundaries.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_compilance"></see></summary>
    let region_compilance = _prefix "region_compilance"
    /// <summary>
    /// Region Data residency / Sovereignty Location.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_dataresidency"></see></summary>
    let region_dataresidency = _prefix "region_dataresidency"
    /// <summary>
    /// Region Endpoint is the URI of the main resource at the region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_endpoint"></see></summary>
    let region_endpoint = _prefix "region_endpoint"
    /// <summary>
    /// Physical Location for a region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_location"></see></summary>
    let region_location = _prefix "region_location"
    /// <summary>
    /// Name of the region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_name"></see></summary>
    let region_name = _prefix "region_name"
