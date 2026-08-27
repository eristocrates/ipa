namespace http.purl.org.NET.dady.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dady =
    let _namespace_iri = Namespace_Iri dady |> NamespaceIRI
    /// <summary>
    ///   <para>dady:AtomUpdateSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"an update source offering updates as Atom feeds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#AtomUpdateSource">http://purl.org/NET/dady#AtomUpdateSource</seealso>
    let AtomUpdateSource = Prefixed_Name(dady, "AtomUpdateSource") |> PrefixedName

    /// <summary>
    ///   <para>dady:ChangeSetUpdateSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"an update source offering updates as Talis' Changesets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#ChangeSetUpdateSource">http://purl.org/NET/dady#ChangeSetUpdateSource</seealso>
    let ChangeSetUpdateSource =
        Prefixed_Name(dady, "ChangeSetUpdateSource") |> PrefixedName

    /// <summary>
    ///   <para>dady:HighFrequentUpdates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"the dataset is updated high-frequently, i.e., once a day or more frequent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"high-frequent updates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#HighFrequentUpdates">http://purl.org/NET/dady#HighFrequentUpdates</seealso>
    let HighFrequentUpdates = Prefixed_Name(dady, "HighFrequentUpdates") |> PrefixedName
    /// <summary>
    ///   <para>dady:IrregularUpdates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"the dataset is updated in irregular, non-predictable time intervals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"irregular updates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#IrregularUpdates">http://purl.org/NET/dady#IrregularUpdates</seealso>
    let IrregularUpdates = Prefixed_Name(dady, "IrregularUpdates") |> PrefixedName
    /// <summary>
    ///   <para>dady:LowFrequentUpdates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"the dataset is updated low-frequently, i.e., once a year or less frequent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"low-frequent updates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#LowFrequentUpdates">http://purl.org/NET/dady#LowFrequentUpdates</seealso>
    let LowFrequentUpdates = Prefixed_Name(dady, "LowFrequentUpdates") |> PrefixedName
    /// <summary>
    ///   <para>dady:MidFrequentUpdates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"the dataset is updated mid-frequently, i.e., from once a week to a couple of months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mid-frequent updates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#MidFrequentUpdates">http://purl.org/NET/dady#MidFrequentUpdates</seealso>
    let MidFrequentUpdates = Prefixed_Name(dady, "MidFrequentUpdates") |> PrefixedName
    /// <summary>
    ///   <para>dady:NoUpdates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"the dataset is never updated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"no updates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#NoUpdates">http://purl.org/NET/dady#NoUpdates</seealso>
    let NoUpdates = Prefixed_Name(dady, "NoUpdates") |> PrefixedName
    /// <summary>
    ///   <para>dady:RegularUpdates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"the dataset is updated in regular time intervals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"regular updates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#RegularUpdates">http://purl.org/NET/dady#RegularUpdates</seealso>
    let RegularUpdates = Prefixed_Name(dady, "RegularUpdates") |> PrefixedName

    /// <summary>
    ///   <para>dady:TriplifyUpdateSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"an update source offering updates as Triplify's Updates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#TriplifyUpdateSource">http://purl.org/NET/dady#TriplifyUpdateSource</seealso>
    let TriplifyUpdateSource =
        Prefixed_Name(dady, "TriplifyUpdateSource") |> PrefixedName

    /// <summary>
    ///   <para>dady:UpdateDynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dataset update dynamics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#UpdateDynamics">http://purl.org/NET/dady#UpdateDynamics</seealso>
    let UpdateDynamics = Prefixed_Name(dady, "UpdateDynamics") |> PrefixedName
    /// <summary>
    ///   <para>dady:UpdateFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"update frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#UpdateFrequency">http://purl.org/NET/dady#UpdateFrequency</seealso>
    let UpdateFrequency = Prefixed_Name(dady, "UpdateFrequency") |> PrefixedName
    /// <summary>
    ///   <para>dady:UpdateRegularity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"update regularity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#UpdateRegularity">http://purl.org/NET/dady#UpdateRegularity</seealso>
    let UpdateRegularity = Prefixed_Name(dady, "UpdateRegularity") |> PrefixedName
    /// <summary>
    ///   <para>dady:UpdateSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"update source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#UpdateSource">http://purl.org/NET/dady#UpdateSource</seealso>
    let UpdateSource = Prefixed_Name(dady, "UpdateSource") |> PrefixedName
    /// <summary>
    ///   <para>dady:dynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dataset has update dynamics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#dynamics">http://purl.org/NET/dady#dynamics</seealso>
    let dynamics = Prefixed_Name(dady, "dynamics") |> PrefixedName
    /// <summary>
    ///   <para>dady:notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has update notification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#notification">http://purl.org/NET/dady#notification</seealso>
    let notification = Prefixed_Name(dady, "notification") |> PrefixedName
    /// <summary>
    ///   <para>dady:update</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"offers update source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/NET/dady#update">http://purl.org/NET/dady#update</seealso>
    let update = Prefixed_Name(dady, "update") |> PrefixedName
