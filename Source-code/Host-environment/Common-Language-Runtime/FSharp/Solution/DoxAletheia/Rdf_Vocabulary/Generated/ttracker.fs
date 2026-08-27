namespace http.tracker.api.gnome.org.ontology.v3.tracker.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ttracker =
    let _namespace_iri = Namespace_Iri ttracker |> NamespaceIRI
    /// <summary>
    ///   <para>ttracker:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#">http://tracker.api.gnome.org/ontology/v3/tracker#</seealso>
    let _prefix_iri = Prefixed_Name(ttracker, "") |> PrefixedName
    /// <summary>
    ///   <para>ttracker:ExternalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"External reference to online services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"External reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#ExternalReference">http://tracker.api.gnome.org/ontology/v3/tracker#ExternalReference</seealso>
    let ExternalReference = Prefixed_Name(ttracker, "ExternalReference") |> PrefixedName
    /// <summary>
    ///   <para>ttracker:IndexedFolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Indexed Folder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#IndexedFolder">http://tracker.api.gnome.org/ontology/v3/tracker#IndexedFolder</seealso>
    let IndexedFolder = Prefixed_Name(ttracker, "IndexedFolder") |> PrefixedName
    /// <summary>
    ///   <para>ttracker:available</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#available">http://tracker.api.gnome.org/ontology/v3/tracker#available</seealso>
    let available = Prefixed_Name(ttracker, "available") |> PrefixedName

    /// <summary>
    ///   <para>ttracker:extractor-data-source</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnie:DataSource</para>
    ///
    /// labels<para>"Tracker extractor data source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#extractor-data-source">http://tracker.api.gnome.org/ontology/v3/tracker#extractor-data-source</seealso>
    let extractor_data_source =
        Prefixed_Name(ttracker, "extractor-data-source") |> PrefixedName

    /// <summary>
    ///   <para>ttracker:extractorHash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Hash identifying the extractor of the metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Extractor hash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#extractorHash">http://tracker.api.gnome.org/ontology/v3/tracker#extractorHash</seealso>
    let extractorHash = Prefixed_Name(ttracker, "extractorHash") |> PrefixedName

    /// <summary>
    ///   <para>ttracker:hasExternalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links the information element with the external reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"External reference link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#hasExternalReference">http://tracker.api.gnome.org/ontology/v3/tracker#hasExternalReference</seealso>
    let hasExternalReference =
        Prefixed_Name(ttracker, "hasExternalReference") |> PrefixedName

    /// <summary>
    ///   <para>ttracker:isDefaultTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#isDefaultTag">http://tracker.api.gnome.org/ontology/v3/tracker#isDefaultTag</seealso>
    let isDefaultTag = Prefixed_Name(ttracker, "isDefaultTag") |> PrefixedName
    /// <summary>
    ///   <para>ttracker:isOptical</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#isOptical">http://tracker.api.gnome.org/ontology/v3/tracker#isOptical</seealso>
    let isOptical = Prefixed_Name(ttracker, "isOptical") |> PrefixedName
    /// <summary>
    ///   <para>ttracker:isRemovable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#isRemovable">http://tracker.api.gnome.org/ontology/v3/tracker#isRemovable</seealso>
    let isRemovable = Prefixed_Name(ttracker, "isRemovable") |> PrefixedName

    /// <summary>
    ///   <para>ttracker:referenceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifier of the external reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#referenceIdentifier">http://tracker.api.gnome.org/ontology/v3/tracker#referenceIdentifier</seealso>
    let referenceIdentifier =
        Prefixed_Name(ttracker, "referenceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>ttracker:referenceSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Source of the external reference (eg. 'Musicbrainz')"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#referenceSource">http://tracker.api.gnome.org/ontology/v3/tracker#referenceSource</seealso>
    let referenceSource = Prefixed_Name(ttracker, "referenceSource") |> PrefixedName
    /// <summary>
    ///   <para>ttracker:tagRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#tagRelatedTo">http://tracker.api.gnome.org/ontology/v3/tracker#tagRelatedTo</seealso>
    let tagRelatedTo = Prefixed_Name(ttracker, "tagRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ttracker:unmountDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/tracker#unmountDate">http://tracker.api.gnome.org/ontology/v3/tracker#unmountDate</seealso>
    let unmountDate = Prefixed_Name(ttracker, "unmountDate") |> PrefixedName
