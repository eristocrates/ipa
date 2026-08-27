namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.OwnershipParties.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_oac_opty =
    let _namespace_iri = Namespace_Iri fibo_be_oac_opty |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-oac-opty:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Ownership Parties Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_oac_opty, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:ConstitutionalOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"constitutional owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ConstitutionalOwner">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ConstitutionalOwner</seealso>
    let ConstitutionalOwner =
        Prefixed_Name(fibo_be_oac_opty, "ConstitutionalOwner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:ControllingEquity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlling equity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ControllingEquity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ControllingEquity</seealso>
    let ControllingEquity =
        Prefixed_Name(fibo_be_oac_opty, "ControllingEquity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"direct consolidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/DirectConsolidation">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/DirectConsolidation</seealso>
    let DirectConsolidation =
        Prefixed_Name(fibo_be_oac_opty, "DirectConsolidation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:EntityOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwner">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwner</seealso>
    let EntityOwner = Prefixed_Name(fibo_be_oac_opty, "EntityOwner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:EntityOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwnership">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwnership</seealso>
    let EntityOwnership =
        Prefixed_Name(fibo_be_oac_opty, "EntityOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:ForeignBranchOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"foreign branch ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ForeignBranchOwnership">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ForeignBranchOwnership</seealso>
    let ForeignBranchOwnership =
        Prefixed_Name(fibo_be_oac_opty, "ForeignBranchOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:InvestmentEquity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment equity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestmentEquity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestmentEquity</seealso>
    let InvestmentEquity =
        Prefixed_Name(fibo_be_oac_opty, "InvestmentEquity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:Investor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/Investor">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/Investor</seealso>
    let Investor = Prefixed_Name(fibo_be_oac_opty, "Investor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:InvestorContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investor contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestorContract">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestorContract</seealso>
    let InvestorContract =
        Prefixed_Name(fibo_be_oac_opty, "InvestorContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:UltimateConsolidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ultimate ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/UltimateConsolidation">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/UltimateConsolidation</seealso>
    let UltimateConsolidation =
        Prefixed_Name(fibo_be_oac_opty, "UltimateConsolidation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:guarantees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"guarantees"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/guarantees">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/guarantees</seealso>
    let guarantees = Prefixed_Name(fibo_be_oac_opty, "guarantees") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:hasDirectOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has direct ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwnership">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwnership</seealso>
    let hasDirectOwnership =
        Prefixed_Name(fibo_be_oac_opty, "hasDirectOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:hasDirectOwningEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has direct owning entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwningEntity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwningEntity</seealso>
    let hasDirectOwningEntity =
        Prefixed_Name(fibo_be_oac_opty, "hasDirectOwningEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:hasInvestmentEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has investment entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentEntity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentEntity</seealso>
    let hasInvestmentEntity =
        Prefixed_Name(fibo_be_oac_opty, "hasInvestmentEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:hasInvestmentOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has investment ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentOwnership">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentOwnership</seealso>
    let hasInvestmentOwnership =
        Prefixed_Name(fibo_be_oac_opty, "hasInvestmentOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:hasOwnedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has owned entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwnedEntity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwnedEntity</seealso>
    let hasOwnedEntity =
        Prefixed_Name(fibo_be_oac_opty, "hasOwnedEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-opty:hasOwningEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has owning entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwningEntity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwningEntity</seealso>
    let hasOwningEntity =
        Prefixed_Name(fibo_be_oac_opty, "hasOwningEntity") |> PrefixedName
