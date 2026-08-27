namespace http.purl.org.NET.cidoc_crm.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cidoccrm =
    let _namespace_iri = Namespace_Iri cidoccrm |> NamespaceIRI

    /// <summary>
    ///   <para>cidoccrm:E2_Temporal_Entity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/NET/cidoc-crm/core#E2_Temporal_Entity">http://purl.org/NET/cidoc-crm/core#E2_Temporal_Entity</seealso>
    let E2_Temporal_Entity =
        Prefixed_Name(cidoccrm, "E2_Temporal_Entity") |> PrefixedName

    /// <summary>
    ///   <para>cidoccrm:E7_Activity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/NET/cidoc-crm/core#E7_Activity">http://purl.org/NET/cidoc-crm/core#E7_Activity</seealso>
    let E7_Activity = Prefixed_Name(cidoccrm, "E7_Activity") |> PrefixedName

    /// <summary>
    ///   <para>cidoccrm:P11_had_participant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/NET/cidoc-crm/core#P11_had_participant">http://purl.org/NET/cidoc-crm/core#P11_had_participant</seealso>
    let P11_had_participant =
        Prefixed_Name(cidoccrm, "P11_had_participant") |> PrefixedName

    /// <summary>
    ///   <para>cidoccrm:P12_occurred_in_the_presence_of</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/NET/cidoc-crm/core#P12_occurred_in_the_presence_of">http://purl.org/NET/cidoc-crm/core#P12_occurred_in_the_presence_of</seealso>
    let P12_occurred_in_the_presence_of =
        Prefixed_Name(cidoccrm, "P12_occurred_in_the_presence_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoccrm:P4_has_time-span</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/NET/cidoc-crm/core#P4_has_time-span">http://purl.org/NET/cidoc-crm/core#P4_has_time-span</seealso>
    let P4_has_time_span = Prefixed_Name(cidoccrm, "P4_has_time-span") |> PrefixedName
    /// <summary>
    ///   <para>cidoccrm:P7_took_place_at</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/NET/cidoc-crm/core#P7_took_place_at">http://purl.org/NET/cidoc-crm/core#P7_took_place_at</seealso>
    let P7_took_place_at = Prefixed_Name(cidoccrm, "P7_took_place_at") |> PrefixedName
