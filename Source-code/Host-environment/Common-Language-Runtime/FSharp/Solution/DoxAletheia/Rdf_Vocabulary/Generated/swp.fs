namespace http.www.w3.org._2004._03.trix.swp_1.slash

open DoxAletheia

module swp =
    let _namespace_name = "http://www.w3.org/2004/03/trix/swp-1/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    /// An authority, or origin, of a graph; such as a person or company.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/Authority"></see></summary>
    let Authority = _prefix "Authority"
    /// <summary>
    ///
    /// A method used to construct a signature used to authenticate a graph.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/SignatureMethod"></see></summary>
    let SignatureMethod = _prefix "SignatureMethod"
    /// <summary>
    ///
    /// A relationship between an authority and a graph, in which the authority is in
    /// some way an origin of that graph. Warrants may include a digital signature of
    /// the graph by the authority.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/Warrant"></see></summary>
    let Warrant = _prefix "Warrant"
    /// <summary>
    ///
    /// The subject graph originates from and is asserted by the authority specified
    /// for the object warrant. The statements expressed in the graph are taken to be
    /// claims made by that authority. This property has performative semantics.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/assertedBy"></see></summary>
    let assertedBy = _prefix "assertedBy"
    /// <summary>
    ///
    /// The object authority is the origin of the graph with which the subject warrant
    /// is associated.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/authority"></see></summary>
    let authority = _prefix "authority"
    /// <summary>
    ///
    /// The object is a certificate by which the authority specified for the warrant
    /// can be authenticated.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/certificate"></see></summary>
    let certificate = _prefix "certificate"
    /// <summary>
    ///
    /// The subject graph originates from the authority specified for the object warrant.
    /// The statements expressed in the graph are not taken to be claims made by that
    /// authority, insofar as any statement using this property is concerned.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/quotedBy"></see></summary>
    let quotedBy = _prefix "quotedBy"
    /// <summary>
    ///
    /// The object is the signature to be used to authenticate the graph with which the
    /// subject warrant is associated.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/signature"></see></summary>
    let signature = _prefix "signature"
    /// <summary>
    ///
    /// The object is the signature method by which  the signature specified for the
    /// warrant subject was constructed.
    ///
    /// <see href="http://www.w3.org/2004/03/trix/swp-1/signatureMethod"></see></summary>
    let signatureMethod = _prefix "signatureMethod"
