namespace http.semanticturkey.uniroma2.it.ns.mdr.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mdr =
    let _namespace_iri = Namespace_Iri mdr |> NamespaceIRI

    /// <summary>
    ///   <para>mdr:DereferenciationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a method to dereference the identifiers defined by some dataset"</para>
    /// labels<para>"dereferenciation system"</para></remarks>
    /// <seealso href="http://semanticturkey.uniroma2.it/ns/mdr#DereferenciationSystem">http://semanticturkey.uniroma2.it/ns/mdr#DereferenciationSystem</seealso>
    let DereferenciationSystem =
        Prefixed_Name(mdr, "DereferenciationSystem") |> PrefixedName

    /// <summary>
    ///   <para>mdr:SparqlEndpointLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a limitation of some SPARQL endpoint. This class is an extension point for recording and subsequently reacting in an application-specific manner to any perceived limitation of an endpoint. The focus is on limitations that cannot objectively be defined a-priori, as they rather depend on a number of boundary conditions, such as the task, the underlying access technology and even the specific queries run to perform the task. Such limitations can then be defined in application-specific ontologies reusing this vocabulary"</para>
    /// labels<para>"sparql endpoint limitation"</para></remarks>
    /// <seealso href="http://semanticturkey.uniroma2.it/ns/mdr#SparqlEndpointLimitation">http://semanticturkey.uniroma2.it/ns/mdr#SparqlEndpointLimitation</seealso>
    let SparqlEndpointLimitation =
        Prefixed_Name(mdr, "SparqlEndpointLimitation") |> PrefixedName

    /// <summary>
    ///   <para>mdr:dereferenciationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates a void:Dataset to a resource describing a method to dereference the identifiers defined by that dataset. Currently only two instances: :standardDereferenciation and :noDereferenciation are available, however this will be extended soon to account for versioning and other URI-transformation needs"</para>
    /// labels<para>"dereferenciation system"</para></remarks>
    /// <seealso href="http://semanticturkey.uniroma2.it/ns/mdr#dereferenciationSystem">http://semanticturkey.uniroma2.it/ns/mdr#dereferenciationSystem</seealso>
    let dereferenciationSystem =
        Prefixed_Name(mdr, "dereferenciationSystem") |> PrefixedName

    /// <summary>
    ///   <para>mdr:noDereferenciation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mdr:DereferenciationSystem</para>
    ///   <para>"missing support for any dereferenciation method"</para>
    /// labels<para>"no dereferenciation"</para></remarks>
    /// <seealso href="http://semanticturkey.uniroma2.it/ns/mdr#noDereferenciation">http://semanticturkey.uniroma2.it/ns/mdr#noDereferenciation</seealso>
    let noDereferenciation = Prefixed_Name(mdr, "noDereferenciation") |> PrefixedName

    /// <summary>
    ///   <para>mdr:sparqlEndpointLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates a SPARQL endpoint to a resource describing some limitation of that endpoint"</para>
    /// labels<para>"sparql endpoint limitation"</para></remarks>
    /// <seealso href="http://semanticturkey.uniroma2.it/ns/mdr#sparqlEndpointLimitation">http://semanticturkey.uniroma2.it/ns/mdr#sparqlEndpointLimitation</seealso>
    let sparqlEndpointLimitation =
        Prefixed_Name(mdr, "sparqlEndpointLimitation") |> PrefixedName

    /// <summary>
    ///   <para>mdr:standardDereferenciation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mdr:DereferenciationSystem</para>
    ///   <para>"the method to dereference identifiers by means of HTTP resolution"</para>
    /// labels<para>"standard dereferenciation"</para></remarks>
    /// <seealso href="http://semanticturkey.uniroma2.it/ns/mdr#standardDereferenciation">http://semanticturkey.uniroma2.it/ns/mdr#standardDereferenciation</seealso>
    let standardDereferenciation =
        Prefixed_Name(mdr, "standardDereferenciation") |> PrefixedName
