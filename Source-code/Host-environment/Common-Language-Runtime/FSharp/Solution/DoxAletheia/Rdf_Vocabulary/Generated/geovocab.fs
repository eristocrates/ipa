namespace http.geovocab.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geovocab =
    let _namespace_iri = Namespace_Iri geovocab |> NamespaceIRI
    /// <summary>
    ///   <para>geovocab:geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A vocabulary for describing geographical regions in RDF. $Id: geometry# 81 2012-02-05 11:06:49Z non88sense@gmail.com $"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NeoGeo Geometry Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry">http://geovocab.org/geometry</seealso>
    let geometry = Prefixed_Name(geovocab, "geometry") |> PrefixedName

    /// <summary>
    ///   <para>geovocab:mappings/geometry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://geovocab.org/mappings/geometry">http://geovocab.org/mappings/geometry</seealso>
    let ``mappings/geometry`` =
        Prefixed_Name(geovocab, "mappings/geometry") |> PrefixedName

    /// <summary>
    ///   <para>geovocab:mappings/spatial</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://geovocab.org/mappings/spatial">http://geovocab.org/mappings/spatial</seealso>
    let ``mappings/spatial`` =
        Prefixed_Name(geovocab, "mappings/spatial") |> PrefixedName

    /// <summary>
    ///   <para>geovocab:spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A vocabulary for describing topological relations between features. $Id: spatial# 81 2012-02-05 11:06:49Z non88sense@gmail.com $"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NeoGeo Spatial Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/spatial">http://geovocab.org/spatial</seealso>
    let spatial = Prefixed_Name(geovocab, "spatial") |> PrefixedName
