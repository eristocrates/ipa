namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.Control.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_oac_ctl =
    let _namespace_iri = Namespace_Iri fibo_fnd_oac_ctl |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Control Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_oac_ctl, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/Control">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/Control</seealso>
    let Control = Prefixed_Name(fibo_fnd_oac_ctl, "Control") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:ControlledThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlled thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControlledThing">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControlledThing</seealso>
    let ControlledThing =
        Prefixed_Name(fibo_fnd_oac_ctl, "ControlledThing") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:ControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControllingParty">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/ControllingParty</seealso>
    let ControllingParty =
        Prefixed_Name(fibo_fnd_oac_ctl, "ControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:DeFactoControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"de facto control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeFactoControl">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeFactoControl</seealso>
    let DeFactoControl =
        Prefixed_Name(fibo_fnd_oac_ctl, "DeFactoControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:DeJureControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"de jure control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeJureControl">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/DeJureControl</seealso>
    let DeJureControl = Prefixed_Name(fibo_fnd_oac_ctl, "DeJureControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:hasControllingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has controlling party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasControllingParty">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasControllingParty</seealso>
    let hasControllingParty =
        Prefixed_Name(fibo_fnd_oac_ctl, "hasControllingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:hasPartyInControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has party in control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasPartyInControl">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/hasPartyInControl</seealso>
    let hasPartyInControl =
        Prefixed_Name(fibo_fnd_oac_ctl, "hasPartyInControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:involvesControlledThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"involves controlled thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/involvesControlledThing">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/involvesControlledThing</seealso>
    let involvesControlledThing =
        Prefixed_Name(fibo_fnd_oac_ctl, "involvesControlledThing") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:isControlledPartyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is controlled party of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledPartyOf">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledPartyOf</seealso>
    let isControlledPartyOf =
        Prefixed_Name(fibo_fnd_oac_ctl, "isControlledPartyOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:isControlledThingIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is controlled thing in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledThingIn">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControlledThingIn</seealso>
    let isControlledThingIn =
        Prefixed_Name(fibo_fnd_oac_ctl, "isControlledThingIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:isControllingPartyIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is controlling party in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyIn">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyIn</seealso>
    let isControllingPartyIn =
        Prefixed_Name(fibo_fnd_oac_ctl, "isControllingPartyIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:isControllingPartyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is controlling party of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyOf">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isControllingPartyOf</seealso>
    let isControllingPartyOf =
        Prefixed_Name(fibo_fnd_oac_ctl, "isControllingPartyOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:isInitiallyControlledOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is initially controlled on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isInitiallyControlledOn">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isInitiallyControlledOn</seealso>
    let isInitiallyControlledOn =
        Prefixed_Name(fibo_fnd_oac_ctl, "isInitiallyControlledOn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-ctl:isPartyControlling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is party controlling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isPartyControlling">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/isPartyControlling</seealso>
    let isPartyControlling =
        Prefixed_Name(fibo_fnd_oac_ctl, "isPartyControlling") |> PrefixedName
