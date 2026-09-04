#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module swp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2004/03/trix/swp-1/" "swp"

    /// <summary>
    ///   <para>rdfs:label : Authority^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// An authority, or origin, of a graph; such as a person or company.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/Authority">swp:Authority</a>
    /// </summary>
    let Authority = _prefixId.prefix "Authority"
    /// <summary>
    ///   <para>rdfs:label : Signature Method^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// A method used to construct a signature used to authenticate a graph.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/SignatureMethod">swp:SignatureMethod</a>
    /// </summary>
    let SignatureMethod = _prefixId.prefix "SignatureMethod"
    /// <summary>
    ///   <para>rdfs:label : Warrant^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// A relationship between an authority and a graph, in which the authority is in
    /// some way an origin of that graph. Warrants may include a digital signature of
    /// the graph by the authority.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/Warrant">swp:Warrant</a>
    /// </summary>
    let Warrant = _prefixId.prefix "Warrant"
    /// <summary>
    ///   <para>rdfs:label : asserted by^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The subject graph originates from and is asserted by the authority specified
    /// for the object warrant. The statements expressed in the graph are taken to be
    /// claims made by that authority. This property has performative semantics.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/assertedBy">swp:assertedBy</a>
    /// </summary>
    let assertedBy = _prefixId.prefix "assertedBy"
    /// <summary>
    ///   <para>rdfs:label : authority^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The object authority is the origin of the graph with which the subject warrant
    /// is associated.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/authority">swp:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>rdfs:label : certificate^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The object is a certificate by which the authority specified for the warrant
    /// can be authenticated.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/certificate">swp:certificate</a>
    /// </summary>
    let certificate = _prefixId.prefix "certificate"
    /// <summary>
    ///   <para>rdfs:label : quoted by^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The subject graph originates from the authority specified for the object warrant.
    /// The statements expressed in the graph are not taken to be claims made by that
    /// authority, insofar as any statement using this property is concerned.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/quotedBy">swp:quotedBy</a>
    /// </summary>
    let quotedBy = _prefixId.prefix "quotedBy"
    /// <summary>
    ///   <para>rdfs:label : signature^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The object is the signature to be used to authenticate the graph with which the
    /// subject warrant is associated.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/signature">swp:signature</a>
    /// </summary>
    let signature = _prefixId.prefix "signature"
    /// <summary>
    ///   <para>rdfs:label : signature method^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The object is the signature method by which  the signature specified for the
    /// warrant subject was constructed.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/swp-1/signatureMethod">swp:signatureMethod</a>
    /// </summary>
    let signatureMethod = _prefixId.prefix "signatureMethod"
