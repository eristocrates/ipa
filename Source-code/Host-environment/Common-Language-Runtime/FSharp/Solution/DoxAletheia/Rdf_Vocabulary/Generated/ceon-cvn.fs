namespace http.w3id.org.CEON.ontology.cvn.slash

open DoxAletheia

module ceon_cvn =
    let _namespace_name = "http://w3id.org/CEON/ontology/cvn/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/cvn/0.3/"></see>
    /// </summary>
    let ``_0.3/`` = _prefix "0.3/"
    /// <summary>
    /// A network of interlinked value chains and interested parties.
    /// <see href="http://w3id.org/CEON/ontology/cvn/CVN"></see></summary>
    let CVN = _prefix "CVN"
    /// <summary>
    /// A collaboration between a set of actors.
    /// <see href="http://w3id.org/CEON/ontology/cvn/Collaboration"></see></summary>
    let Collaboration = _prefix "Collaboration"
    /// <summary>
    /// A plan or a pattern of a CVN configuration that can then be filled with actual actors and processes. The blueprint can be used to capture a desired setup of a network, or for reusing patterns of CVNs.
    /// <see href="http://w3id.org/CEON/ontology/cvn/CVNBlueprint"></see></summary>
    let CVNBlueprint = _prefix "CVNBlueprint"
    /// <summary>
    /// A circular strategy, such as to reccycle, reuse or refurbish something.
    /// <see href="http://w3id.org/CEON/ontology/cvn/CircularStrategy"></see></summary>
    let CircularStrategy = _prefix "CircularStrategy"
    /// <summary>
    /// The value proposition that the planned abstract CVN configuration, or concrete network wants to achieve.
    /// <see href="http://w3id.org/CEON/ontology/cvn/aimsAtValue"></see></summary>
    let aimsAtValue = _prefix "aimsAtValue"
    /// <summary>
    /// Both a CVN and a process can be composed of other CVNs or processes.
    /// <see href="http://w3id.org/CEON/ontology/cvn/composedOf"></see></summary>
    let composedOf = _prefix "composedOf"
    /// <summary>
    /// Value creation can be captured at the actor level, i.e. value created by an actor's participation in a collaboration, or at the process or complete CVN level.
    /// <see href="http://w3id.org/CEON/ontology/cvn/createsValue"></see></summary>
    let createsValue = _prefix "createsValue"
    /// <summary>
    /// The blueprint (or plan) that this concrete CVN is an instance of.
    /// <see href="http://w3id.org/CEON/ontology/cvn/implementsBlueprint"></see></summary>
    let implementsBlueprint = _prefix "implementsBlueprint"
    /// <summary>
    /// A strategy that is implemented by this CVN or CVN blueprint.
    /// <see href="http://w3id.org/CEON/ontology/cvn/implementsStrategy"></see></summary>
    let implementsStrategy = _prefix "implementsStrategy"
    /// <summary>
    /// A strategy that is targeted by this CVN or CVN blueprint.
    /// <see href="http://w3id.org/CEON/ontology/cvn/relatedStrategy"></see></summary>
    let relatedStrategy = _prefix "relatedStrategy"
    /// <summary>
    /// A strategy that is planned to be implemented by this CVN or CVN blueprint.
    /// <see href="http://w3id.org/CEON/ontology/cvn/plansToImplementStrategy"></see></summary>
    let plansToImplementStrategy = _prefix "plansToImplementStrategy"
