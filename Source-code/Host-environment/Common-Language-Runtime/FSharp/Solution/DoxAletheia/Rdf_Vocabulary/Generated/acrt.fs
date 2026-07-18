namespace http.privatealpha.com.ontology.certification._1.hash

open DoxAletheia.Rdf_Vocabulary

module acrt =
    let _namespace_name = "http://privatealpha.com/ontology/certification/1#"

    /// <summary>
    /// This class represents the abstract notion of certification, of an agent, by another agent, that the first agent possesses some property or set of properties implied by the certification, potentially within some spatiotemporal scope, and which may or may not be designated by some identifier.
    /// <see href="http://privatealpha.com/ontology/certification/1#Certification"></see></summary>
    let Certification =
        Namespaced_IRI.parse _namespace_name "Certification" |> NamespacedName

    /// <summary>
    /// This property specifies who (or what) is doing the certifying.
    /// <see href="http://privatealpha.com/ontology/certification/1#authority"></see></summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName
    /// <summary>
    /// This property specifies that its subject, an agent, has issued a certification.
    /// <see href="http://privatealpha.com/ontology/certification/1#certifies"></see></summary>
    let certifies = Namespaced_IRI.parse _namespace_name "certifies" |> NamespacedName

    /// <summary>
    /// This property specifies that an agent possesses a given certification.
    /// <see href="http://privatealpha.com/ontology/certification/1#has-certification"></see></summary>
    let ``has-certification`` =
        Namespaced_IRI.parse _namespace_name "has-certification" |> NamespacedName

    /// <summary>
    /// This property specifies who or what agent is being certified.
    /// <see href="http://privatealpha.com/ontology/certification/1#principal"></see></summary>
    let principal = Namespaced_IRI.parse _namespace_name "principal" |> NamespacedName
    /// <summary>
    /// This property points to some proof of the certification, like a scan of an official document or a page on the issuing authority's website that corroborates the certification.
    /// <see href="http://privatealpha.com/ontology/certification/1#proof"></see></summary>
    let proof = Namespaced_IRI.parse _namespace_name "proof" |> NamespacedName
    /// <summary>
    /// This property asserts that its subject is somehow proof of a given certification.
    /// <see href="http://privatealpha.com/ontology/certification/1#proves"></see></summary>
    let proves = Namespaced_IRI.parse _namespace_name "proves" |> NamespacedName

    /// <summary>
    /// This property specifies what achievement, skill, or fact is being certified.
    /// <see href="http://privatealpha.com/ontology/certification/1#qualification"></see></summary>
    let qualification =
        Namespaced_IRI.parse _namespace_name "qualification" |> NamespacedName
