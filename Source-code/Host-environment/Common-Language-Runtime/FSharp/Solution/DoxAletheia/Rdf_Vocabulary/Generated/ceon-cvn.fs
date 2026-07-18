namespace http.w3id.org.CEON.ontology.cvn.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_cvn =
    let _namespace_name = "http://w3id.org/CEON/ontology/cvn/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/cvn/0.3/"></see>
    /// </summary>
    let ``_0.3/`` = Namespaced_IRI.parse _namespace_name "0.3/" |> NamespacedName
    /// <summary>
    /// A network of interlinked value chains and interested parties.
    /// <see href="http://w3id.org/CEON/ontology/cvn/CVN"></see></summary>
    let CVN = Namespaced_IRI.parse _namespace_name "CVN" |> NamespacedName

    /// <summary>
    /// A collaboration between a set of actors.
    /// <see href="http://w3id.org/CEON/ontology/cvn/Collaboration"></see></summary>
    let Collaboration =
        Namespaced_IRI.parse _namespace_name "Collaboration" |> NamespacedName

    /// <summary>
    /// A plan or a pattern of a CVN configuration that can then be filled with actual actors and processes. The blueprint can be used to capture a desired setup of a network, or for reusing patterns of CVNs.
    /// <see href="http://w3id.org/CEON/ontology/cvn/CVNBlueprint"></see></summary>
    let CVNBlueprint =
        Namespaced_IRI.parse _namespace_name "CVNBlueprint" |> NamespacedName

    /// <summary>
    /// A circular strategy, such as to reccycle, reuse or refurbish something.
    /// <see href="http://w3id.org/CEON/ontology/cvn/CircularStrategy"></see></summary>
    let CircularStrategy =
        Namespaced_IRI.parse _namespace_name "CircularStrategy" |> NamespacedName

    /// <summary>
    /// The value proposition that the planned abstract CVN configuration, or concrete network wants to achieve.
    /// <see href="http://w3id.org/CEON/ontology/cvn/aimsAtValue"></see></summary>
    let aimsAtValue =
        Namespaced_IRI.parse _namespace_name "aimsAtValue" |> NamespacedName

    /// <summary>
    /// Both a CVN and a process can be composed of other CVNs or processes.
    /// <see href="http://w3id.org/CEON/ontology/cvn/composedOf"></see></summary>
    let composedOf = Namespaced_IRI.parse _namespace_name "composedOf" |> NamespacedName

    /// <summary>
    /// Value creation can be captured at the actor level, i.e. value created by an actor's participation in a collaboration, or at the process or complete CVN level.
    /// <see href="http://w3id.org/CEON/ontology/cvn/createsValue"></see></summary>
    let createsValue =
        Namespaced_IRI.parse _namespace_name "createsValue" |> NamespacedName

    /// <summary>
    /// The blueprint (or plan) that this concrete CVN is an instance of.
    /// <see href="http://w3id.org/CEON/ontology/cvn/implementsBlueprint"></see></summary>
    let implementsBlueprint =
        Namespaced_IRI.parse _namespace_name "implementsBlueprint" |> NamespacedName

    /// <summary>
    /// A strategy that is implemented by this CVN or CVN blueprint.
    /// <see href="http://w3id.org/CEON/ontology/cvn/implementsStrategy"></see></summary>
    let implementsStrategy =
        Namespaced_IRI.parse _namespace_name "implementsStrategy" |> NamespacedName

    /// <summary>
    /// A strategy that is targeted by this CVN or CVN blueprint.
    /// <see href="http://w3id.org/CEON/ontology/cvn/relatedStrategy"></see></summary>
    let relatedStrategy =
        Namespaced_IRI.parse _namespace_name "relatedStrategy" |> NamespacedName

    /// <summary>
    /// A strategy that is planned to be implemented by this CVN or CVN blueprint.
    /// <see href="http://w3id.org/CEON/ontology/cvn/plansToImplementStrategy"></see></summary>
    let plansToImplementStrategy =
        Namespaced_IRI.parse _namespace_name "plansToImplementStrategy" |> NamespacedName
