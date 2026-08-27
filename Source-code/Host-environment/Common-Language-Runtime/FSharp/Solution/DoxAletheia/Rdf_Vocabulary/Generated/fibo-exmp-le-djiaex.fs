namespace https.spec.edmcouncil.org.fibo.ontology.EXMP.LegalEntities.DowJonesIndustrialAverageExecutives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_exmp_le_djiaex =
    let _namespace_iri = Namespace_Iri fibo_exmp_le_djiaex |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"US Example Executives"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_exmp_le_djiaex, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:AppleIncAsControlledParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-cpty:ControlledParty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Apple Inc. as controlled party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/AppleIncAsControlledParty">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/AppleIncAsControlledParty</seealso>
    let AppleIncAsControlledParty =
        Prefixed_Name(fibo_exmp_le_djiaex, "AppleIncAsControlledParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:AppleIncAsEmployer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-org-fm:Employer</para>
    ///
    /// labels<para>"Apple Inc. as employer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/AppleIncAsEmployer">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/AppleIncAsEmployer</seealso>
    let AppleIncAsEmployer =
        Prefixed_Name(fibo_exmp_le_djiaex, "AppleIncAsEmployer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:EmploymentOfKatherineAdamsAtAppleInc</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-org-fm:Employment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Employment of Katherine Adams at Apple Inc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/EmploymentOfKatherineAdamsAtAppleInc">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/EmploymentOfKatherineAdamsAtAppleInc</seealso>
    let EmploymentOfKatherineAdamsAtAppleInc =
        Prefixed_Name(fibo_exmp_le_djiaex, "EmploymentOfKatherineAdamsAtAppleInc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:EmploymentOfTimCookAtAppleInc</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-org-fm:Employment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Employment of Tim Cook at Apple Inc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/EmploymentOfTimCookAtAppleInc">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/EmploymentOfTimCookAtAppleInc</seealso>
    let EmploymentOfTimCookAtAppleInc =
        Prefixed_Name(fibo_exmp_le_djiaex, "EmploymentOfTimCookAtAppleInc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:KatherineAdams</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-aap-ppl:Person</para>
    ///
    /// labels<para>"Katherine Adams"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdams">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdams</seealso>
    let KatherineAdams =
        Prefixed_Name(fibo_exmp_le_djiaex, "KatherineAdams") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:KatherineAdamsAsEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-org-fm:Employee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Katherine Adams as employee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsAsEmployee">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsAsEmployee</seealso>
    let KatherineAdamsAsEmployee =
        Prefixed_Name(fibo_exmp_le_djiaex, "KatherineAdamsAsEmployee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:KatherineAdamsAsSeniorVicePresidentOfGovernmentAffairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-exec:CorporateOfficer</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Katherine Adams as senior vice president of Government Affairs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsAsSeniorVicePresidentOfGovernmentAffairs">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsAsSeniorVicePresidentOfGovernmentAffairs</seealso>
    let KatherineAdamsAsSeniorVicePresidentOfGovernmentAffairs =
        Prefixed_Name(fibo_exmp_le_djiaex, "KatherineAdamsAsSeniorVicePresidentOfGovernmentAffairs") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:KatherineAdamsDateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-aap-ppl:DateOfBirth</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Katherine Adams date of birth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsDateOfBirth">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsDateOfBirth</seealso>
    let KatherineAdamsDateOfBirth =
        Prefixed_Name(fibo_exmp_le_djiaex, "KatherineAdamsDateOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:KatherineAdamsFullLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-aap-ppl:PersonName</para>
    ///
    /// labels<para>"Katherine Adams full legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsFullLegalName">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/KatherineAdamsFullLegalName</seealso>
    let KatherineAdamsFullLegalName =
        Prefixed_Name(fibo_exmp_le_djiaex, "KatherineAdamsFullLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-aap-ppl:Person</para>
    ///
    /// labels<para>"Tim Cook"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCook">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCook</seealso>
    let TimCook = Prefixed_Name(fibo_exmp_le_djiaex, "TimCook") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCookAsChiefExecutiveOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-exec:ChiefExecutiveOfficer</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tim Cook as Chief Executive Officer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookAsChiefExecutiveOfficer">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookAsChiefExecutiveOfficer</seealso>
    let TimCookAsChiefExecutiveOfficer =
        Prefixed_Name(fibo_exmp_le_djiaex, "TimCookAsChiefExecutiveOfficer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCookAsEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-org-fm:Employee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tim Cook as employee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookAsEmployee">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookAsEmployee</seealso>
    let TimCookAsEmployee =
        Prefixed_Name(fibo_exmp_le_djiaex, "TimCookAsEmployee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCookDateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-aap-ppl:DateOfBirth</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tim Cook date of birth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookDateOfBirth">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookDateOfBirth</seealso>
    let TimCookDateOfBirth =
        Prefixed_Name(fibo_exmp_le_djiaex, "TimCookDateOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCookFullLegalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-aap-ppl:PersonName</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tim Cook full legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookFullLegalName">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookFullLegalName</seealso>
    let TimCookFullLegalName =
        Prefixed_Name(fibo_exmp_le_djiaex, "TimCookFullLegalName") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCookHireDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Tim Cook hire date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookHireDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookHireDate</seealso>
    let TimCookHireDate =
        Prefixed_Name(fibo_exmp_le_djiaex, "TimCookHireDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCookPeriodOfEmployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:DatePeriod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tim Cook period of employment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookPeriodOfEmployment">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookPeriodOfEmployment</seealso>
    let TimCookPeriodOfEmployment =
        Prefixed_Name(fibo_exmp_le_djiaex, "TimCookPeriodOfEmployment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-djiaex:TimCookRetirementDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Tim Cook retirement date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookRetirementDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/TimCookRetirementDate</seealso>
    let TimCookRetirementDate =
        Prefixed_Name(fibo_exmp_le_djiaex, "TimCookRetirementDate") |> PrefixedName
