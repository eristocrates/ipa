namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.Control.slash

open DoxAletheia

module fibo_fnd_oac_ctl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/Control"></see>
    /// </summary>
    let Control = _prefix "Control"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasPartyInControl"></see>
    /// </summary>
    let hasPartyInControl = _prefix "hasPartyInControl"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControllingParty"></see>
    /// </summary>
    let ControllingParty = _prefix "ControllingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/involvesControlledThing"></see>
    /// </summary>
    let involvesControlledThing = _prefix "involvesControlledThing"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControlledThing"></see>
    /// </summary>
    let ControlledThing = _prefix "ControlledThing"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isInitiallyControlledOn"></see>
    /// </summary>
    let isInitiallyControlledOn = _prefix "isInitiallyControlledOn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasControllingParty"></see>
    /// </summary>
    let hasControllingParty = _prefix "hasControllingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledThingIn"></see>
    /// </summary>
    let isControlledThingIn = _prefix "isControlledThingIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyIn"></see>
    /// </summary>
    let isControllingPartyIn = _prefix "isControllingPartyIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isPartyControlling"></see>
    /// </summary>
    let isPartyControlling = _prefix "isPartyControlling"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeFactoControl"></see>
    /// </summary>
    let DeFactoControl = _prefix "DeFactoControl"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeJureControl"></see>
    /// </summary>
    let DeJureControl = _prefix "DeJureControl"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledPartyOf"></see>
    /// </summary>
    let isControlledPartyOf = _prefix "isControlledPartyOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyOf"></see>
    /// </summary>
    let isControllingPartyOf = _prefix "isControllingPartyOf"
