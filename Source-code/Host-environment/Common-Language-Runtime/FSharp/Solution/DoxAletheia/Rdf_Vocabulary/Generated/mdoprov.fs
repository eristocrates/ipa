namespace https.w3id.org.mdo.provenance.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mdoprov =
    let _namespace_iri = Namespace_Iri mdoprov |> NamespaceIRI
    /// <summary>
    ///   <para>mdoprov:ReferenceAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reference agent is the representation of the reference that the structure or property refer to.</para>
    /// labels<para>Reference Agent</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/ReferenceAgent">https://w3id.org/mdo/provenance/ReferenceAgent</seealso>
    let ReferenceAgent = Prefixed_Name(mdoprov, "ReferenceAgent") |> PrefixedName

    /// <summary>
    ///   <para>mdoprov:PublicationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>PublicationDateTime represents that a reference agent has the date time in a dateTime.</para>
    /// labels<para>publication dateTime</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/PublicationDateTime">https://w3id.org/mdo/provenance/PublicationDateTime</seealso>
    let PublicationDateTime =
        Prefixed_Name(mdoprov, "PublicationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>mdoprov:URL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL represents that a reference agent has the URL in a string.</para>
    /// labels<para>URL</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/URL">https://w3id.org/mdo/provenance/URL</seealso>
    let URL = Prefixed_Name(mdoprov, "URL") |> PrefixedName
    /// <summary>
    ///   <para>mdoprov:SoftwareName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>SoftwareName represents that a software agent has the name in a string.</para>
    /// labels<para>software name</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/SoftwareName">https://w3id.org/mdo/provenance/SoftwareName</seealso>
    let SoftwareName = Prefixed_Name(mdoprov, "SoftwareName") |> PrefixedName
    /// <summary>
    ///   <para>mdoprov:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This is the provenance module of Materials Design Ontology.</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/">https://w3id.org/mdo/provenance/</seealso>
    let _prefix_iri = Prefixed_Name(mdoprov, "") |> PrefixedName
    /// <summary>
    ///   <para>mdoprov:DatabaseName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>DatabaseName represents that a reference agent has the database's name in a string.</para>
    /// labels<para>database name</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/DatabaseName">https://w3id.org/mdo/provenance/DatabaseName</seealso>
    let DatabaseName = Prefixed_Name(mdoprov, "DatabaseName") |> PrefixedName
    /// <summary>
    ///   <para>mdoprov:PublicationTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>PublicationTitle represents that a reference agent has the publication's title in a string.</para>
    /// labels<para>publication title</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/PublicationTitle">https://w3id.org/mdo/provenance/PublicationTitle</seealso>
    let PublicationTitle = Prefixed_Name(mdoprov, "PublicationTitle") |> PrefixedName
    /// <summary>
    ///   <para>mdoprov:1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/1.0/">https://w3id.org/mdo/provenance/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(mdoprov, "1.0/") |> PrefixedName
    /// <summary>
    ///   <para>mdoprov:DOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>DOI represents that a reference agent has the DOI in a string.</para>
    /// labels<para>DOI</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/DOI">https://w3id.org/mdo/provenance/DOI</seealso>
    let DOI = Prefixed_Name(mdoprov, "DOI") |> PrefixedName
    /// <summary>
    ///   <para>mdoprov:AuthorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>AuthorName represents that a reference agent has the author's name in a string.</para>
    /// labels<para>author name</para></remarks>
    /// <seealso href="https://w3id.org/mdo/provenance/AuthorName">https://w3id.org/mdo/provenance/AuthorName</seealso>
    let AuthorName = Prefixed_Name(mdoprov, "AuthorName") |> PrefixedName
