namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.LegalPersons.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_le_lp =
    let _namespace_iri = Namespace_Iri fibo_be_le_lp |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-le-lp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Legal Persons Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_le_lp, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-le-lp:BusinessEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessEntity">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessEntity</seealso>
    let BusinessEntity = Prefixed_Name(fibo_be_le_lp, "BusinessEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:BusinessLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessLicense">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessLicense</seealso>
    let BusinessLicense =
        Prefixed_Name(fibo_be_le_lp, "BusinessLicense") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:CharteredLegalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chartered legal person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/CharteredLegalPerson">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/CharteredLegalPerson</seealso>
    let CharteredLegalPerson =
        Prefixed_Name(fibo_be_le_lp, "CharteredLegalPerson") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:LegallyCompetentNaturalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legally competent natural person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/LegallyCompetentNaturalPerson">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/LegallyCompetentNaturalPerson</seealso>
    let LegallyCompetentNaturalPerson =
        Prefixed_Name(fibo_be_le_lp, "LegallyCompetentNaturalPerson") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:NotForProfitObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"not for profit objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/NotForProfitObjective">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/NotForProfitObjective</seealso>
    let NotForProfitObjective =
        Prefixed_Name(fibo_be_le_lp, "NotForProfitObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:PowerOfAttorney</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"power of attorney"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PowerOfAttorney">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PowerOfAttorney</seealso>
    let PowerOfAttorney =
        Prefixed_Name(fibo_be_le_lp, "PowerOfAttorney") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:ProfitObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"profit objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ProfitObjective">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ProfitObjective</seealso>
    let ProfitObjective =
        Prefixed_Name(fibo_be_le_lp, "ProfitObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:PublicPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"public purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PublicPurpose">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PublicPurpose</seealso>
    let PublicPurpose = Prefixed_Name(fibo_be_le_lp, "PublicPurpose") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:ReligiousObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"religious objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ReligiousObjective">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ReligiousObjective</seealso>
    let ReligiousObjective =
        Prefixed_Name(fibo_be_le_lp, "ReligiousObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:SpecialPurposeVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fonds commun de placement"</para><para>"special purpose vehicle"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/SpecialPurposeVehicle">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/SpecialPurposeVehicle</seealso>
    let SpecialPurposeVehicle =
        Prefixed_Name(fibo_be_le_lp, "SpecialPurposeVehicle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:StatutoryBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statutory body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/StatutoryBody">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/StatutoryBody</seealso>
    let StatutoryBody = Prefixed_Name(fibo_be_le_lp, "StatutoryBody") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:VariableInterestEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variable interest entity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/VariableInterestEntity">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/VariableInterestEntity</seealso>
    let VariableInterestEntity =
        Prefixed_Name(fibo_be_le_lp, "VariableInterestEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:hasIntendedLiquidationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has intended liquidation date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/hasIntendedLiquidationDate">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/hasIntendedLiquidationDate</seealso>
    let hasIntendedLiquidationDate =
        Prefixed_Name(fibo_be_le_lp, "hasIntendedLiquidationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-lp:hasLegalEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/hasLegalEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/hasLegalEntityIdentifier</seealso>
    let hasLegalEntityIdentifier =
        Prefixed_Name(fibo_be_le_lp, "hasLegalEntityIdentifier") |> PrefixedName
