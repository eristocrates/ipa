namespace https.spec.edmcouncil.org.fibo.ontology.FND.Parties.Parties.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_pty_pty =
    let _namespace_iri = Namespace_Iri fibo_fnd_pty_pty |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-pty-pty:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Parties Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_pty_pty, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pty-pty:PartyInRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyInRole">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyInRole</seealso>
    let PartyInRole = Prefixed_Name(fibo_fnd_pty_pty, "PartyInRole") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pty-pty:PartyRoleIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"party role identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentificationScheme</seealso>
    let PartyRoleIdentificationScheme =
        Prefixed_Name(fibo_fnd_pty_pty, "PartyRoleIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pty-pty:PartyRoleIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"party role identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentifier</seealso>
    let PartyRoleIdentifier =
        Prefixed_Name(fibo_fnd_pty_pty, "PartyRoleIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pty-pty:TaxIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tax identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentificationScheme</seealso>
    let TaxIdentificationScheme =
        Prefixed_Name(fibo_fnd_pty_pty, "TaxIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pty-pty:TaxIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tax identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentifier</seealso>
    let TaxIdentifier = Prefixed_Name(fibo_fnd_pty_pty, "TaxIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pty-pty:hasMailingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has mailing address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasMailingAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasMailingAddress</seealso>
    let hasMailingAddress =
        Prefixed_Name(fibo_fnd_pty_pty, "hasMailingAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pty-pty:hasPartyInRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasPartyInRole">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasPartyInRole</seealso>
    let hasPartyInRole =
        Prefixed_Name(fibo_fnd_pty_pty, "hasPartyInRole") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pty-pty:hasTaxIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasTaxIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasTaxIdentifier</seealso>
    let hasTaxIdentifier =
        Prefixed_Name(fibo_fnd_pty_pty, "hasTaxIdentifier") |> PrefixedName
