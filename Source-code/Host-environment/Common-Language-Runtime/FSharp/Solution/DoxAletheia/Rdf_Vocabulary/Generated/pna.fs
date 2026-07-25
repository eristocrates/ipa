namespace http.data.press.net.ontology.asset.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pna =
    let _namespace_iri = Namespace_Iri pna |> NamespaceIRI
    /// <summary>
    ///   <para>pna:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic News Asset Class</para>
    /// labels<para>Generic Asset Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/Asset">http://data.press.net/ontology/asset/Asset</seealso>
    let Asset = Prefixed_Name(pna, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>pna:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Image Asset Class</para>
    /// labels<para>Image Asset Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/Image">http://data.press.net/ontology/asset/Image</seealso>
    let Image = Prefixed_Name(pna, "Image") |> PrefixedName
    /// <summary>
    ///   <para>pna:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Text Asset Class</para>
    /// labels<para>Text Asset Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/Text">http://data.press.net/ontology/asset/Text</seealso>
    let Text = Prefixed_Name(pna, "Text") |> PrefixedName
    /// <summary>
    ///   <para>pna:associatedAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates one asset with another asset</para>
    /// labels<para>Property that associates one asset with another asset</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/associatedAsset">http://data.press.net/ontology/asset/associatedAsset</seealso>
    let associatedAsset = Prefixed_Name(pna, "associatedAsset") |> PrefixedName
    /// <summary>
    ///   <para>pna:hasThumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates a thumbnail image with an asset</para>
    /// labels<para>Property that associates a thumbnail image with an asset</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/hasThumbnail">http://data.press.net/ontology/asset/hasThumbnail</seealso>
    let hasThumbnail = Prefixed_Name(pna, "hasThumbnail") |> PrefixedName
    /// <summary>
    ///   <para>pna:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time a news Asset was published</para>
    /// labels<para>Asset published dateTime</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/published">http://data.press.net/ontology/asset/published</seealso>
    let published = Prefixed_Name(pna, "published") |> PrefixedName
    /// <summary>
    ///   <para>pna:embargoedUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time a news Asset is embargoedUntil</para>
    /// labels<para>Asset embargoed until dateTime</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/embargoedUntil">http://data.press.net/ontology/asset/embargoedUntil</seealso>
    let embargoedUntil = Prefixed_Name(pna, "embargoedUntil") |> PrefixedName
    /// <summary>
    ///   <para>pna:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time a news Asset was modified</para>
    /// labels<para>Asset modified dateTime</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/modified">http://data.press.net/ontology/asset/modified</seealso>
    let modified = Prefixed_Name(pna, "modified") |> PrefixedName
    /// <summary>
    ///   <para>pna:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The Asset Ontology describes news assets (text, images, video, data, etc), the relationships between them and how assets can be classified and semantically annotated.</para>
    /// </remarks>
    /// <seealso href="http://data.press.net/ontology/asset/">http://data.press.net/ontology/asset/</seealso>
    let _prefix_iri = Prefixed_Name(pna, "") |> PrefixedName
    /// <summary>
    ///   <para>pna:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Video Asset Class</para>
    /// labels<para>Video Asset Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/Video">http://data.press.net/ontology/asset/Video</seealso>
    let Video = Prefixed_Name(pna, "Video") |> PrefixedName
    /// <summary>
    ///   <para>pna:byline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The byline of a news Asset</para>
    /// labels<para>Asset byline</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/byline">http://data.press.net/ontology/asset/byline</seealso>
    let byline = Prefixed_Name(pna, "byline") |> PrefixedName
    /// <summary>
    ///   <para>pna:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time a news Asset was created</para>
    /// labels<para>Asset created dateTime</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/created">http://data.press.net/ontology/asset/created</seealso>
    let created = Prefixed_Name(pna, "created") |> PrefixedName
    /// <summary>
    ///   <para>pna:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an asset to an asset that it is derived from</para>
    /// labels<para>Relates an asset to an asset that it is derived from</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/derivedFrom">http://data.press.net/ontology/asset/derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(pna, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>pna:hasTranscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates a Text transcript with a Video</para>
    /// labels<para>The text transcript of a Video</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/hasTranscript">http://data.press.net/ontology/asset/hasTranscript</seealso>
    let hasTranscript = Prefixed_Name(pna, "hasTranscript") |> PrefixedName
    /// <summary>
    ///   <para>pna:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The summary text of a news Asset</para>
    /// labels<para>Asset summary</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/summary">http://data.press.net/ontology/asset/summary</seealso>
    let summary = Prefixed_Name(pna, "summary") |> PrefixedName
    /// <summary>
    ///   <para>pna:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of a news Asset</para>
    /// labels<para>Asset title</para></remarks>
    /// <seealso href="http://data.press.net/ontology/asset/title">http://data.press.net/ontology/asset/title</seealso>
    let title = Prefixed_Name(pna, "title") |> PrefixedName
