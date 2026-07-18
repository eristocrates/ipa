namespace http.cookingbigdata.com.linkeddata.ccregions.hash

open DoxAletheia.Rdf_Vocabulary

module ccr =
    let _namespace_name = "http://cookingbigdata.com/linkeddata/ccregions#"

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccregions#manuelparra"></see>
    /// </summary>
    let manuelparra =
        Namespaced_IRI.parse _namespace_name "manuelparra" |> NamespacedName

    /// <summary>
    ///   <see href="http://cookingbigdata.com/linkeddata/ccregions#cookingbigdata"></see>
    /// </summary>
    let cookingbigdata =
        Namespaced_IRI.parse _namespace_name "cookingbigdata" |> NamespacedName

    /// <summary>
    /// Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#AvailabilityZone"></see></summary>
    let AvailabilityZone =
        Namespaced_IRI.parse _namespace_name "AvailabilityZone" |> NamespacedName

    /// <summary>
    /// Geographical Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#GeographicalZone"></see></summary>
    let GeographicalZone =
        Namespaced_IRI.parse _namespace_name "GeographicalZone" |> NamespacedName

    /// <summary>
    /// Location
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// Region
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    /// Name of the Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_name"></see></summary>
    let availabilityzone_name =
        Namespaced_IRI.parse _namespace_name "availabilityzone_name" |> NamespacedName

    /// <summary>
    /// Status of the Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#availabilityzone_status"></see></summary>
    let availabilityzone_status =
        Namespaced_IRI.parse _namespace_name "availabilityzone_status" |> NamespacedName

    /// <summary>
    /// Administrative Geographical area.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#geographical_zone"></see></summary>
    let geographical_zone =
        Namespaced_IRI.parse _namespace_name "geographical_zone" |> NamespacedName

    /// <summary>
    /// Each Zone has almost one Availability Zone
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#hasAvailabilityZone"></see></summary>
    let hasAvailabilityZone =
        Namespaced_IRI.parse _namespace_name "hasAvailabilityZone" |> NamespacedName

    /// <summary>
    /// Each Region is hosted in a Geographical Area or Division
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#hasGeographicalZone"></see></summary>
    let hasGeographicalZone =
        Namespaced_IRI.parse _namespace_name "hasGeographicalZone" |> NamespacedName

    /// <summary>
    /// Short Code of the region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_code"></see></summary>
    let region_code =
        Namespaced_IRI.parse _namespace_name "region_code" |> NamespacedName

    /// <summary>
    /// Compilance with geographical boundaries.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_compilance"></see></summary>
    let region_compilance =
        Namespaced_IRI.parse _namespace_name "region_compilance" |> NamespacedName

    /// <summary>
    /// Region Data residency / Sovereignty Location.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_dataresidency"></see></summary>
    let region_dataresidency =
        Namespaced_IRI.parse _namespace_name "region_dataresidency" |> NamespacedName

    /// <summary>
    /// Region Endpoint is the URI of the main resource at the region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_endpoint"></see></summary>
    let region_endpoint =
        Namespaced_IRI.parse _namespace_name "region_endpoint" |> NamespacedName

    /// <summary>
    /// Physical Location for a region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_location"></see></summary>
    let region_location =
        Namespaced_IRI.parse _namespace_name "region_location" |> NamespacedName

    /// <summary>
    /// Name of the region.
    /// <see href="http://cookingbigdata.com/linkeddata/ccregions#region_name"></see></summary>
    let region_name =
        Namespaced_IRI.parse _namespace_name "region_name" |> NamespacedName
