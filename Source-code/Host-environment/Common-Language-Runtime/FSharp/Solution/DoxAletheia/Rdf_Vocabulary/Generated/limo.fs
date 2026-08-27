namespace http.purl.org.LiMo._0._1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module LiMo =
    let _namespace_iri = Namespace_Iri LiMo |> NamespaceIRI
    /// <summary>
    ///   <para>LiMo:;CC-BY-NC-ND</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>foaf:organization</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/;CC-BY-NC-ND">http://purl.org/LiMo/0.1/;CC-BY-NC-ND</seealso>
    let ``_;CC_BY_NC_ND`` = Prefixed_Name(LiMo, ";CC-BY-NC-ND") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:;Dataset</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/;Dataset">http://purl.org/LiMo/0.1/;Dataset</seealso>
    let ``_;Dataset`` = Prefixed_Name(LiMo, ";Dataset") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:;DistributionConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/;DistributionConditions">http://purl.org/LiMo/0.1/;DistributionConditions</seealso>
    let ``_;DistributionConditions`` =
        Prefixed_Name(LiMo, ";DistributionConditions") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:;LicenseModel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/;LicenseModel">http://purl.org/LiMo/0.1/;LicenseModel</seealso>
    let ``_;LicenseModel`` = Prefixed_Name(LiMo, ";LicenseModel") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:;Rights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/;Rights">http://purl.org/LiMo/0.1/;Rights</seealso>
    let ``_;Rights`` = Prefixed_Name(LiMo, ";Rights") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:;UseConditions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/;UseConditions">http://purl.org/LiMo/0.1/;UseConditions</seealso>
    let ``_;UseConditions`` = Prefixed_Name(LiMo, ";UseConditions") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:CC-BY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>foaf:organization</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/CC-BY">http://purl.org/LiMo/0.1/CC-BY</seealso>
    let CC_BY = Prefixed_Name(LiMo, "CC-BY") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:CC-BY-NC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/CC-BY-NC">http://purl.org/LiMo/0.1/CC-BY-NC</seealso>
    let CC_BY_NC = Prefixed_Name(LiMo, "CC-BY-NC") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:CC-BY-NC-SA</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>LiMo:LicenseModel</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/CC-BY-NC-SA">http://purl.org/LiMo/0.1/CC-BY-NC-SA</seealso>
    let CC_BY_NC_SA = Prefixed_Name(LiMo, "CC-BY-NC-SA") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:CC-BY-ND</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/CC-BY-ND">http://purl.org/LiMo/0.1/CC-BY-ND</seealso>
    let CC_BY_ND = Prefixed_Name(LiMo, "CC-BY-ND") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:CC-BY-SA</para>
    /// </summary>
    /// <remarks>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>foaf:organization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/CC-BY-SA">http://purl.org/LiMo/0.1/CC-BY-SA</seealso>
    let CC_BY_SA = Prefixed_Name(LiMo, "CC-BY-SA") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:CC0</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/CC0">http://purl.org/LiMo/0.1/CC0</seealso>
    let CC0 = Prefixed_Name(LiMo, "CC0") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dataset"</para></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/Dataset">http://purl.org/LiMo/0.1/Dataset</seealso>
    let Dataset = Prefixed_Name(LiMo, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:DistributionConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Condizioni legali di distribuzione"</para></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/DistributionConditions">http://purl.org/LiMo/0.1/DistributionConditions</seealso>
    let DistributionConditions =
        Prefixed_Name(LiMo, "DistributionConditions") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:IODL1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/IODL1_0">http://purl.org/LiMo/0.1/IODL1_0</seealso>
    let IODL1_0 = Prefixed_Name(LiMo, "IODL1_0") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:IODL2_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/IODL2_0">http://purl.org/LiMo/0.1/IODL2_0</seealso>
    let IODL2_0 = Prefixed_Name(LiMo, "IODL2_0") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:LegalTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Termini legali di applicazione della licenza"</para></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/LegalTerms">http://purl.org/LiMo/0.1/LegalTerms</seealso>
    let LegalTerms = Prefixed_Name(LiMo, "LegalTerms") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:LicenseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modello di Licenza"</para></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/LicenseModel">http://purl.org/LiMo/0.1/LicenseModel</seealso>
    let LicenseModel = Prefixed_Name(LiMo, "LicenseModel") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:ODBL1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sono i tipi di licenza da utilizzare nella pubblicazione dei dataset e di database opendata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/ODBL1_0">http://purl.org/LiMo/0.1/ODBL1_0</seealso>
    let ODBL1_0 = Prefixed_Name(LiMo, "ODBL1_0") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:ODC-BY</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sono i tipi di licenza da utilizzare nella pubblicazione dei dataset e di database opendata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/ODC-BY">http://purl.org/LiMo/0.1/ODC-BY</seealso>
    let ODC_BY = Prefixed_Name(LiMo, "ODC-BY") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:PDDL1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:organization</para>
    ///   <para>LiMo:LicenseModel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo tipo di licenza colloca il database nel pubblico dominio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/PDDL1_0">http://purl.org/LiMo/0.1/PDDL1_0</seealso>
    let PDDL1_0 = Prefixed_Name(LiMo, "PDDL1_0") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:Rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Diritti concessi dai termini legali"</para></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/Rights">http://purl.org/LiMo/0.1/Rights</seealso>
    let Rights = Prefixed_Name(LiMo, "Rights") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:URL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/URL">http://purl.org/LiMo/0.1/URL</seealso>
    let URL = Prefixed_Name(LiMo, "URL") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:UseConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Condizioni legali d'uso"</para></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/UseConditions">http://purl.org/LiMo/0.1/UseConditions</seealso>
    let UseConditions = Prefixed_Name(LiMo, "UseConditions") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:areDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/areDefinedBy">http://purl.org/LiMo/0.1/areDefinedBy</seealso>
    let areDefinedBy = Prefixed_Name(LiMo, "areDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:areGuaranteedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/areGuaranteedBy">http://purl.org/LiMo/0.1/areGuaranteedBy</seealso>
    let areGuaranteedBy = Prefixed_Name(LiMo, "areGuaranteedBy") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:areImposedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/areImposedBy">http://purl.org/LiMo/0.1/areImposedBy</seealso>
    let areImposedBy = Prefixed_Name(LiMo, "areImposedBy") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:attributionCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/attributionCondition">http://purl.org/LiMo/0.1/attributionCondition</seealso>
    let attributionCondition =
        Prefixed_Name(LiMo, "attributionCondition") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:compatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/compatibleWith">http://purl.org/LiMo/0.1/compatibleWith</seealso>
    let compatibleWith = Prefixed_Name(LiMo, "compatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:coverDatasets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/coverDatasets">http://purl.org/LiMo/0.1/coverDatasets</seealso>
    let coverDatasets = Prefixed_Name(LiMo, "coverDatasets") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:createCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/createCondition">http://purl.org/LiMo/0.1/createCondition</seealso>
    let createCondition = Prefixed_Name(LiMo, "createCondition") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/creator">http://purl.org/LiMo/0.1/creator</seealso>
    let creator = Prefixed_Name(LiMo, "creator") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:define</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/define">http://purl.org/LiMo/0.1/define</seealso>
    let define = Prefixed_Name(LiMo, "define") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:guarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/guarantee">http://purl.org/LiMo/0.1/guarantee</seealso>
    let guarantee = Prefixed_Name(LiMo, "guarantee") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:hasLicenseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/hasLicenseModel">http://purl.org/LiMo/0.1/hasLicenseModel</seealso>
    let hasLicenseModel = Prefixed_Name(LiMo, "hasLicenseModel") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/icon">http://purl.org/LiMo/0.1/icon</seealso>
    let icon = Prefixed_Name(LiMo, "icon") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:impose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/impose">http://purl.org/LiMo/0.1/impose</seealso>
    let impose = Prefixed_Name(LiMo, "impose") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:licenseModel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel">http://purl.org/LiMo/0.1/licenseModel</seealso>
    let licenseModel = Prefixed_Name(LiMo, "licenseModel") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/CC-BY</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/CC-BY">http://purl.org/LiMo/0.1/licenseModel/CC-BY</seealso>
    let ``licenseModel/CC_BY`` =
        Prefixed_Name(LiMo, "licenseModel/CC-BY") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/CC-BY-SA</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/CC-BY-SA">http://purl.org/LiMo/0.1/licenseModel/CC-BY-SA</seealso>
    let ``licenseModel/CC_BY_SA`` =
        Prefixed_Name(LiMo, "licenseModel/CC-BY-SA") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/CC0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/CC0">http://purl.org/LiMo/0.1/licenseModel/CC0</seealso>
    let ``licenseModel/CC0`` = Prefixed_Name(LiMo, "licenseModel/CC0") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/IODL1_0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/IODL1_0">http://purl.org/LiMo/0.1/licenseModel/IODL1_0</seealso>
    let ``licenseModel/IODL1_0`` =
        Prefixed_Name(LiMo, "licenseModel/IODL1_0") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/IODL2_0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/IODL2_0">http://purl.org/LiMo/0.1/licenseModel/IODL2_0</seealso>
    let ``licenseModel/IODL2_0`` =
        Prefixed_Name(LiMo, "licenseModel/IODL2_0") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/ODC-BY</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/ODC-BY">http://purl.org/LiMo/0.1/licenseModel/ODC-BY</seealso>
    let ``licenseModel/ODC-BY`` =
        Prefixed_Name(LiMo, "licenseModel/ODC-BY") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/ODC_BY</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/ODC_BY">http://purl.org/LiMo/0.1/licenseModel/ODC_BY</seealso>
    let ``licenseModel/ODC_BY`` =
        Prefixed_Name(LiMo, "licenseModel/ODC_BY") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/ODbL1_0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/ODbL1_0">http://purl.org/LiMo/0.1/licenseModel/ODbL1_0</seealso>
    let ``licenseModel/ODbL1_0`` =
        Prefixed_Name(LiMo, "licenseModel/ODbL1_0") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:licenseModel/PDDL1_0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/licenseModel/PDDL1_0">http://purl.org/LiMo/0.1/licenseModel/PDDL1_0</seealso>
    let ``licenseModel/PDDL1_0`` =
        Prefixed_Name(LiMo, "licenseModel/PDDL1_0") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:noCopyrightCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/noCopyrightCondition">http://purl.org/LiMo/0.1/noCopyrightCondition</seealso>
    let noCopyrightCondition =
        Prefixed_Name(LiMo, "noCopyrightCondition") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:nonCommercialCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/nonCommercialCondition">http://purl.org/LiMo/0.1/nonCommercialCondition</seealso>
    let nonCommercialCondition =
        Prefixed_Name(LiMo, "nonCommercialCondition") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:nonDerivativeWorksCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/nonDerivativeWorksCondition">http://purl.org/LiMo/0.1/nonDerivativeWorksCondition</seealso>
    let nonDerivativeWorksCondition =
        Prefixed_Name(LiMo, "nonDerivativeWorksCondition") |> PrefixedName

    /// <summary>
    ///   <para>LiMo:remixCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/remixCondition">http://purl.org/LiMo/0.1/remixCondition</seealso>
    let remixCondition = Prefixed_Name(LiMo, "remixCondition") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:shareAlikeCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/shareAlikeCondition">http://purl.org/LiMo/0.1/shareAlikeCondition</seealso>
    let shareAlikeCondition = Prefixed_Name(LiMo, "shareAlikeCondition") |> PrefixedName
    /// <summary>
    ///   <para>LiMo:shareCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/LiMo/0.1/shareCondition">http://purl.org/LiMo/0.1/shareCondition</seealso>
    let shareCondition = Prefixed_Name(LiMo, "shareCondition") |> PrefixedName
