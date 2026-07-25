namespace http.www.w3.org._2004._03.trix.swp_1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swp =
    let _namespace_iri = Namespace_Iri swp |> NamespaceIRI
    /// <summary>
    ///   <para>swp:SignatureMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>
    /// A method used to construct a signature used to authenticate a graph.
    ///       </para>
    /// labels<para>Signature Method</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/SignatureMethod">http://www.w3.org/2004/03/trix/swp-1/SignatureMethod</seealso>
    let SignatureMethod = Prefixed_Name(swp, "SignatureMethod") |> PrefixedName
    /// <summary>
    ///   <para>swp:signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The object is the signature to be used to authenticate the graph with which the
    /// subject warrant is associated.
    ///       </para>
    /// labels<para>signature</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/signature">http://www.w3.org/2004/03/trix/swp-1/signature</seealso>
    let signature = Prefixed_Name(swp, "signature") |> PrefixedName
    /// <summary>
    ///   <para>swp:assertedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The subject graph originates from and is asserted by the authority specified
    /// for the object warrant. The statements expressed in the graph are taken to be
    /// claims made by that authority. This property has performative semantics.
    ///       </para>
    /// labels<para>asserted by</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/assertedBy">http://www.w3.org/2004/03/trix/swp-1/assertedBy</seealso>
    let assertedBy = Prefixed_Name(swp, "assertedBy") |> PrefixedName
    /// <summary>
    ///   <para>swp:certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The object is a certificate by which the authority specified for the warrant
    /// can be authenticated.
    ///       </para>
    /// labels<para>certificate</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/certificate">http://www.w3.org/2004/03/trix/swp-1/certificate</seealso>
    let certificate = Prefixed_Name(swp, "certificate") |> PrefixedName
    /// <summary>
    ///   <para>swp:Authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>
    /// An authority, or origin, of a graph; such as a person or company.
    ///       </para>
    /// labels<para>Authority</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/Authority">http://www.w3.org/2004/03/trix/swp-1/Authority</seealso>
    let Authority = Prefixed_Name(swp, "Authority") |> PrefixedName
    /// <summary>
    ///   <para>swp:Warrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>
    /// A relationship between an authority and a graph, in which the authority is in
    /// some way an origin of that graph. Warrants may include a digital signature of
    /// the graph by the authority.
    ///       </para>
    /// labels<para>Warrant</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/Warrant">http://www.w3.org/2004/03/trix/swp-1/Warrant</seealso>
    let Warrant = Prefixed_Name(swp, "Warrant") |> PrefixedName
    /// <summary>
    ///   <para>swp:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The object authority is the origin of the graph with which the subject warrant
    /// is associated.
    ///       </para>
    /// labels<para>authority</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/authority">http://www.w3.org/2004/03/trix/swp-1/authority</seealso>
    let authority = Prefixed_Name(swp, "authority") |> PrefixedName
    /// <summary>
    ///   <para>swp:quotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The subject graph originates from the authority specified for the object warrant.
    /// The statements expressed in the graph are not taken to be claims made by that
    /// authority, insofar as any statement using this property is concerned.
    ///       </para>
    /// labels<para>quoted by</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/quotedBy">http://www.w3.org/2004/03/trix/swp-1/quotedBy</seealso>
    let quotedBy = Prefixed_Name(swp, "quotedBy") |> PrefixedName
    /// <summary>
    ///   <para>swp:signatureMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The object is the signature method by which  the signature specified for the
    /// warrant subject was constructed.
    ///       </para>
    /// labels<para>signature method</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/swp-1/signatureMethod">http://www.w3.org/2004/03/trix/swp-1/signatureMethod</seealso>
    let signatureMethod = Prefixed_Name(swp, "signatureMethod") |> PrefixedName
