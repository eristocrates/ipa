namespace http.www.w3.org._2003.g.data_view.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module grddl =
    let _namespace_iri = Namespace_Iri grddl |> NamespaceIRI
    /// <summary>
    ///   <para>grddl:RDFGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>a
    ///     set of RDF triples</para>
    /// labels<para>RDF graphs</para><para>RDFGraph</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#RDFGraph">http://www.w3.org/2003/g/data-view#RDFGraph</seealso>
    let RDFGraph = Prefixed_Name(grddl, "RDFGraph") |> PrefixedName
    /// <summary>
    ///   <para>grddl:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>an
    ///     RDF graph obtained from an information resource by directly
    ///     parsing a representation in the standard RDF/XML syntax or
    ///     indirectly by parsing some other dialect using a transformation
    ///     nominated by the document</para>
    /// labels<para>result</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#result">http://www.w3.org/2003/g/data-view#result</seealso>
    let result = Prefixed_Name(grddl, "result") |> PrefixedName
    /// <summary>
    ///   <para>grddl:grddl-wg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#grddl-wg">http://www.w3.org/2003/g/data-view#grddl-wg</seealso>
    let grddl_wg = Prefixed_Name(grddl, "grddl-wg") |> PrefixedName

    /// <summary>
    ///   <para>grddl:profileTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>relates a profile document to a
    ///     transformation for all documents bearing that profile</para>
    /// labels<para>profileTransformation</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#profileTransformation">http://www.w3.org/2003/g/data-view#profileTransformation</seealso>
    let profileTransformation =
        Prefixed_Name(grddl, "profileTransformation") |> PrefixedName

    /// <summary>
    ///   <para>grddl:InformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource which has the property that all of its essential characteristics can be conveyed in a message</para>
    /// labels<para>InformationResource</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#InformationResource">http://www.w3.org/2003/g/data-view#InformationResource</seealso>
    let InformationResource =
        Prefixed_Name(grddl, "InformationResource") |> PrefixedName

    /// <summary>
    ///   <para>grddl:transformationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>relates a transformation to the algorithm
    ///     specified by the property that computes an RDF graph from an XML
    ///     document node</para>
    /// labels<para>transformationProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#transformationProperty">http://www.w3.org/2003/g/data-view#transformationProperty</seealso>
    let transformationProperty =
        Prefixed_Name(grddl, "transformationProperty") |> PrefixedName

    /// <summary>
    ///   <para>grddl:danc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#danc">http://www.w3.org/2003/g/data-view#danc</seealso>
    let danc = Prefixed_Name(grddl, "danc") |> PrefixedName
    /// <summary>
    ///   <para>grddl:RootNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>the root of the tree in the XPath data
    ///     model</para>
    /// labels<para>XML document root nodes</para><para>RootNode</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#RootNode">http://www.w3.org/2003/g/data-view#RootNode</seealso>
    let RootNode = Prefixed_Name(grddl, "RootNode") |> PrefixedName

    /// <summary>
    ///   <para>grddl:TransformationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>a FunctionalProperty that relates
    ///     XML document root nodes to
    ///     RDF graphs</para>
    /// labels<para>TransformationProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#TransformationProperty">http://www.w3.org/2003/g/data-view#TransformationProperty</seealso>
    let TransformationProperty =
        Prefixed_Name(grddl, "TransformationProperty") |> PrefixedName

    /// <summary>
    ///   <para>grddl:grddlProject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#grddlProject">http://www.w3.org/2003/g/data-view#grddlProject</seealso>
    let grddlProject = Prefixed_Name(grddl, "grddlProject") |> PrefixedName

    /// <summary>
    ///   <para>grddl:namespaceTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>relates a namespace to a transformation for
    ///     all documents in that namespace</para>
    /// labels<para>namespaceTransformation</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#namespaceTransformation">http://www.w3.org/2003/g/data-view#namespaceTransformation</seealso>
    let namespaceTransformation =
        Prefixed_Name(grddl, "namespaceTransformation") |> PrefixedName

    /// <summary>
    ///   <para>grddl:transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>relates a source document to a
    ///     transformation, usually represented in XSLT, that relates the source document syntax
    ///     to the RDF graph syntax</para>
    /// labels<para>transformation</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#transformation">http://www.w3.org/2003/g/data-view#transformation</seealso>
    let transformation = Prefixed_Name(grddl, "transformation") |> PrefixedName
    /// <summary>
    ///   <para>grddl:Transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>an InformationResource that specifies
    ///     a transformation from a set of XML documents to RDF graphs</para>
    /// labels<para>Transformation</para></remarks>
    /// <seealso href="http://www.w3.org/2003/g/data-view#Transformation">http://www.w3.org/2003/g/data-view#Transformation</seealso>
    let Transformation = Prefixed_Name(grddl, "Transformation") |> PrefixedName
