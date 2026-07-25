namespace http.purl.org.NET.scovo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module scovo =
    let _namespace_iri = Namespace_Iri scovo |> NamespaceIRI
    /// <summary>
    ///   <para>scovo:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>a dimension of a statistical data item</para>
    /// labels<para>Dimension</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#Dimension">http://purl.org/NET/scovo#Dimension</seealso>
    let Dimension = Prefixed_Name(scovo, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>scovo:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a dimension</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#dimension">http://purl.org/NET/scovo#dimension</seealso>
    let dimension = Prefixed_Name(scovo, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>scovo:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>belongs to dataset</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#dataset">http://purl.org/NET/scovo#dataset</seealso>
    let dataset = Prefixed_Name(scovo, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>scovo:datasetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is the dataset of</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#datasetOf">http://purl.org/NET/scovo#datasetOf</seealso>
    let datasetOf = Prefixed_Name(scovo, "datasetOf") |> PrefixedName
    /// <summary>
    ///   <para>scovo:max</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a maximum range value</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#max">http://purl.org/NET/scovo#max</seealso>
    let max = Prefixed_Name(scovo, "max") |> PrefixedName
    /// <summary>
    ///   <para>scovo:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>a statistical dataset</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#Dataset">http://purl.org/NET/scovo#Dataset</seealso>
    let Dataset = Prefixed_Name(scovo, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>scovo:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>a statistical data item</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#Item">http://purl.org/NET/scovo#Item</seealso>
    let Item = Prefixed_Name(scovo, "Item") |> PrefixedName
    /// <summary>
    ///   <para>scovo:min</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a minimum range value</para></remarks>
    /// <seealso href="http://purl.org/NET/scovo#min">http://purl.org/NET/scovo#min</seealso>
    let min = Prefixed_Name(scovo, "min") |> PrefixedName
