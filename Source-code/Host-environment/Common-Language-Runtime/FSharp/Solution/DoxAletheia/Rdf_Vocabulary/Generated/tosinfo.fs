namespace http.tracker.api.gnome.org.ontology.v3.osinfo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tosinfo =
    let _namespace_iri = Namespace_Iri tosinfo |> NamespaceIRI
    /// <summary>
    ///   <para>tosinfo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Ontology</para>
    ///   <para>tnrl:Namespace</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/osinfo#">http://tracker.api.gnome.org/ontology/v3/osinfo#</seealso>
    let _prefix_iri = Prefixed_Name(tosinfo, "") |> PrefixedName
    /// <summary>
    ///   <para>tosinfo:Installer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An operating system installer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating System Installer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/osinfo#Installer">http://tracker.api.gnome.org/ontology/v3/osinfo#Installer</seealso>
    let Installer = Prefixed_Name(tosinfo, "Installer") |> PrefixedName
    /// <summary>
    ///   <para>tosinfo:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/osinfo#id">http://tracker.api.gnome.org/ontology/v3/osinfo#id</seealso>
    let id = Prefixed_Name(tosinfo, "id") |> PrefixedName
    /// <summary>
    ///   <para>tosinfo:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Languages supported by installer/live media."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/osinfo#language">http://tracker.api.gnome.org/ontology/v3/osinfo#language</seealso>
    let language = Prefixed_Name(tosinfo, "language") |> PrefixedName
    /// <summary>
    ///   <para>tosinfo:mediaId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/osinfo#mediaId">http://tracker.api.gnome.org/ontology/v3/osinfo#mediaId</seealso>
    let mediaId = Prefixed_Name(tosinfo, "mediaId") |> PrefixedName
