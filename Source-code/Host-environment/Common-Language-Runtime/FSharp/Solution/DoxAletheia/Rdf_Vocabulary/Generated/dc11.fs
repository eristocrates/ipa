namespace http.purl.org.dc.elements._1._1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dc11 =
    let _namespace_iri = Namespace_Iri dc11 |> NamespaceIRI
    /// <summary>
    ///   <para>dc11:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/">http://purl.org/dc/elements/1.1/</seealso>
    let _prefix_iri = Prefixed_Name(dc11, "") |> PrefixedName
    /// <summary>
    ///   <para>dc11:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity responsible for making contributions to the resource.</para>
    /// labels<para>Contributor</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/contributor">http://purl.org/dc/elements/1.1/contributor</seealso>
    let contributor = Prefixed_Name(dc11, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>dc11:coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.</para>
    /// labels<para>Coverage</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/coverage">http://purl.org/dc/elements/1.1/coverage</seealso>
    let coverage = Prefixed_Name(dc11, "coverage") |> PrefixedName
    /// <summary>
    ///   <para>dc11:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity primarily responsible for making the resource.</para>
    /// labels<para>Creator</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/creator">http://purl.org/dc/elements/1.1/creator</seealso>
    let creator = Prefixed_Name(dc11, "creator") |> PrefixedName
    /// <summary>
    ///   <para>dc11:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A point or period of time associated with an event in the lifecycle of the resource.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/date">http://purl.org/dc/elements/1.1/date</seealso>
    let date = Prefixed_Name(dc11, "date") |> PrefixedName
    /// <summary>
    ///   <para>dc11:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An account of the resource.</para>
    /// labels<para>Description</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/description">http://purl.org/dc/elements/1.1/description</seealso>
    let description = Prefixed_Name(dc11, "description") |> PrefixedName
    /// <summary>
    ///   <para>dc11:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The file format, physical medium, or dimensions of the resource.</para>
    /// labels<para>Format</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/format">http://purl.org/dc/elements/1.1/format</seealso>
    let format = Prefixed_Name(dc11, "format") |> PrefixedName
    /// <summary>
    ///   <para>dc11:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An unambiguous reference to the resource within a given context.</para>
    /// labels<para>Identifier</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/identifier">http://purl.org/dc/elements/1.1/identifier</seealso>
    let identifier = Prefixed_Name(dc11, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>dc11:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A language of the resource.</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/language">http://purl.org/dc/elements/1.1/language</seealso>
    let language = Prefixed_Name(dc11, "language") |> PrefixedName
    /// <summary>
    ///   <para>dc11:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity responsible for making the resource available.</para>
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/publisher">http://purl.org/dc/elements/1.1/publisher</seealso>
    let publisher = Prefixed_Name(dc11, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>dc11:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource.</para>
    /// labels<para>Relation</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/relation">http://purl.org/dc/elements/1.1/relation</seealso>
    let relation = Prefixed_Name(dc11, "relation") |> PrefixedName
    /// <summary>
    ///   <para>dc11:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information about rights held in and over the resource.</para>
    /// labels<para>Rights</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/rights">http://purl.org/dc/elements/1.1/rights</seealso>
    let rights = Prefixed_Name(dc11, "rights") |> PrefixedName
    /// <summary>
    ///   <para>dc11:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource from which the described resource is derived.</para>
    /// labels<para>Source</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/source">http://purl.org/dc/elements/1.1/source</seealso>
    let source = Prefixed_Name(dc11, "source") |> PrefixedName
    /// <summary>
    ///   <para>dc11:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The topic of the resource.</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/subject">http://purl.org/dc/elements/1.1/subject</seealso>
    let subject = Prefixed_Name(dc11, "subject") |> PrefixedName
    /// <summary>
    ///   <para>dc11:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A name given to the resource.</para>
    /// labels<para>Title</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/title">http://purl.org/dc/elements/1.1/title</seealso>
    let title = Prefixed_Name(dc11, "title") |> PrefixedName
    /// <summary>
    ///   <para>dc11:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The nature or genre of the resource.</para>
    /// labels<para>Type</para></remarks>
    /// <seealso href="http://purl.org/dc/elements/1.1/type">http://purl.org/dc/elements/1.1/type</seealso>
    let type_ = Prefixed_Name(dc11, "type") |> PrefixedName
