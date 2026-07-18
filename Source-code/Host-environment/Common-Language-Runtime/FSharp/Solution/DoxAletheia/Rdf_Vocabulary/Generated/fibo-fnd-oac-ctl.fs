namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.Control.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_oac_ctl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/Control"></see>
    /// </summary>
    let Control = Namespaced_IRI.parse _namespace_name "Control" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasPartyInControl"></see>
    /// </summary>
    let hasPartyInControl =
        Namespaced_IRI.parse _namespace_name "hasPartyInControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControllingParty"></see>
    /// </summary>
    let ControllingParty =
        Namespaced_IRI.parse _namespace_name "ControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/involvesControlledThing"></see>
    /// </summary>
    let involvesControlledThing =
        Namespaced_IRI.parse _namespace_name "involvesControlledThing" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControlledThing"></see>
    /// </summary>
    let ControlledThing =
        Namespaced_IRI.parse _namespace_name "ControlledThing" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isInitiallyControlledOn"></see>
    /// </summary>
    let isInitiallyControlledOn =
        Namespaced_IRI.parse _namespace_name "isInitiallyControlledOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasControllingParty"></see>
    /// </summary>
    let hasControllingParty =
        Namespaced_IRI.parse _namespace_name "hasControllingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledThingIn"></see>
    /// </summary>
    let isControlledThingIn =
        Namespaced_IRI.parse _namespace_name "isControlledThingIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyIn"></see>
    /// </summary>
    let isControllingPartyIn =
        Namespaced_IRI.parse _namespace_name "isControllingPartyIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isPartyControlling"></see>
    /// </summary>
    let isPartyControlling =
        Namespaced_IRI.parse _namespace_name "isPartyControlling" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeFactoControl"></see>
    /// </summary>
    let DeFactoControl =
        Namespaced_IRI.parse _namespace_name "DeFactoControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeJureControl"></see>
    /// </summary>
    let DeJureControl =
        Namespaced_IRI.parse _namespace_name "DeJureControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledPartyOf"></see>
    /// </summary>
    let isControlledPartyOf =
        Namespaced_IRI.parse _namespace_name "isControlledPartyOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyOf"></see>
    /// </summary>
    let isControllingPartyOf =
        Namespaced_IRI.parse _namespace_name "isControllingPartyOf" |> NamespacedName
