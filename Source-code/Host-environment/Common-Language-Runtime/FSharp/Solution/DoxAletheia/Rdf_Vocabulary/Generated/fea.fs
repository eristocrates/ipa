namespace http.vocab.data.gov.def.fea.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fea =
    let _namespace_iri = Namespace_Iri fea |> NamespaceIRI
    /// <summary>
    ///   <para>fea:</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#">http://vocab.data.gov/def/fea#</seealso>
    let _prefix_iri = Prefixed_Name(fea, "") |> PrefixedName
    /// <summary>
    ///   <para>fea:Agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An agency of the US government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Agency">http://vocab.data.gov/def/fea#Agency</seealso>
    let Agency = Prefixed_Name(fea, "Agency") |> PrefixedName
    /// <summary>
    ///   <para>fea:Board</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"US government board"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Board"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Board">http://vocab.data.gov/def/fea#Board</seealso>
    let Board = Prefixed_Name(fea, "Board") |> PrefixedName
    /// <summary>
    ///   <para>fea:Budget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Budget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Budget">http://vocab.data.gov/def/fea#Budget</seealso>
    let Budget = Prefixed_Name(fea, "Budget") |> PrefixedName
    /// <summary>
    ///   <para>fea:Citizen</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Citizen of the United States of Americe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Citizen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Citizen">http://vocab.data.gov/def/fea#Citizen</seealso>
    let Citizen = Prefixed_Name(fea, "Citizen") |> PrefixedName
    /// <summary>
    ///   <para>fea:CivilServant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An employee of the US Government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Civil Servant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#CivilServant">http://vocab.data.gov/def/fea#CivilServant</seealso>
    let CivilServant = Prefixed_Name(fea, "CivilServant") |> PrefixedName
    /// <summary>
    ///   <para>fea:Commission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Us government commission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Commission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Commission">http://vocab.data.gov/def/fea#Commission</seealso>
    let Commission = Prefixed_Name(fea, "Commission") |> PrefixedName
    /// <summary>
    ///   <para>fea:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A commercial organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Company">http://vocab.data.gov/def/fea#Company</seealso>
    let Company = Prefixed_Name(fea, "Company") |> PrefixedName
    /// <summary>
    ///   <para>fea:Council</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"US Government council"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Council"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Council">http://vocab.data.gov/def/fea#Council</seealso>
    let Council = Prefixed_Name(fea, "Council") |> PrefixedName
    /// <summary>
    ///   <para>fea:Customer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The diverse nature of federal programs means that there are many customers spanning the citizen, business, other government, and internal categories.  Some customers
    /// receive direct government services, such as veterans receiving health care from the Veterans Health Administration. Other â€œcustomersâ€ are those subject to regulatory activities, such as large businesses conforming to safety regulations administered by the Occupational Safety and Health Administration. Importantly, the citizen is generally considered to be the ultimate â€œcustomerâ€ of government activities regardless of the nature of the customer relationship.
    /// PRM volume 1, p.14"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Customer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Customer">http://vocab.data.gov/def/fea#Customer</seealso>
    let Customer = Prefixed_Name(fea, "Customer") |> PrefixedName
    /// <summary>
    ///   <para>fea:ExecutiveAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Executive Agency of the US government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Executive Agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#ExecutiveAgency">http://vocab.data.gov/def/fea#ExecutiveAgency</seealso>
    let ExecutiveAgency = Prefixed_Name(fea, "ExecutiveAgency") |> PrefixedName

    /// <summary>
    ///   <para>fea:FEA_ArchitectureConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FEA Architecture Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#FEA_ArchitectureConcept">http://vocab.data.gov/def/fea#FEA_ArchitectureConcept</seealso>
    let FEA_ArchitectureConcept =
        Prefixed_Name(fea, "FEA_ArchitectureConcept") |> PrefixedName

    /// <summary>
    ///   <para>fea:FEA_Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"FEA Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#FEA_Concept">http://vocab.data.gov/def/fea#FEA_Concept</seealso>
    let FEA_Concept = Prefixed_Name(fea, "FEA_Concept") |> PrefixedName

    /// <summary>
    ///   <para>fea:FEA_EnterpriseConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FEA Enterprise Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#FEA_EnterpriseConcept">http://vocab.data.gov/def/fea#FEA_EnterpriseConcept</seealso>
    let FEA_EnterpriseConcept =
        Prefixed_Name(fea, "FEA_EnterpriseConcept") |> PrefixedName

    /// <summary>
    ///   <para>fea:FEA_Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"1, the FEA is being constructed through a collection of interrelated
    /// â€œreference modelsâ€ designed to facilitate cross-agency analysis and the identification of duplicative investments, gaps, and opportunities for collaboration within and across Federal Agencies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FEA Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#FEA_Model">http://vocab.data.gov/def/fea#FEA_Model</seealso>
    let FEA_Model = Prefixed_Name(fea, "FEA_Model") |> PrefixedName

    /// <summary>
    ///   <para>fea:FEA_TechnologyConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FEA Technology Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#FEA_TechnologyConcept">http://vocab.data.gov/def/fea#FEA_TechnologyConcept</seealso>
    let FEA_TechnologyConcept =
        Prefixed_Name(fea, "FEA_TechnologyConcept") |> PrefixedName

    /// <summary>
    ///   <para>fea:FederalEnterpriseArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"To facilitate efforts to transform the Federal Government to one that is citizen-centered, results-oriented, and market-based, the Office of Management and Budget (OMB) is developing the Federal Enterprise Architecture (FEA), a business-based framework for Governmentwide improvement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Federal Enterprise Architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#FederalEnterpriseArchitecture">http://vocab.data.gov/def/fea#FederalEnterpriseArchitecture</seealso>
    let FederalEnterpriseArchitecture =
        Prefixed_Name(fea, "FederalEnterpriseArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>fea:GovernmentBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Any US government organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Government Body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#GovernmentBody">http://vocab.data.gov/def/fea#GovernmentBody</seealso>
    let GovernmentBody = Prefixed_Name(fea, "GovernmentBody") |> PrefixedName
    /// <summary>
    ///   <para>fea:HumanResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class refers to the workforce"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Human Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#HumanResource">http://vocab.data.gov/def/fea#HumanResource</seealso>
    let HumanResource = Prefixed_Name(fea, "HumanResource") |> PrefixedName
    /// <summary>
    ///   <para>fea:IT_Initiative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A program of work that implements information technology based capabilities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IT Initiative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#IT_Initiative">http://vocab.data.gov/def/fea#IT_Initiative</seealso>
    let IT_Initiative = Prefixed_Name(fea, "IT_Initiative") |> PrefixedName
    /// <summary>
    ///   <para>fea:IndependentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Independent Agency of the US government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Independent Agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#IndependentAgency">http://vocab.data.gov/def/fea#IndependentAgency</seealso>
    let IndependentAgency = Prefixed_Name(fea, "IndependentAgency") |> PrefixedName
    /// <summary>
    ///   <para>fea:IndustryBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Any non government organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Industry Body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#IndustryBody">http://vocab.data.gov/def/fea#IndustryBody</seealso>
    let IndustryBody = Prefixed_Name(fea, "IndustryBody") |> PrefixedName
    /// <summary>
    ///   <para>fea:Mission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Missions are carried out by the organizational entities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Mission">http://vocab.data.gov/def/fea#Mission</seealso>
    let Mission = Prefixed_Name(fea, "Mission") |> PrefixedName
    /// <summary>
    ///   <para>fea:Office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"US government office"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Office"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Office">http://vocab.data.gov/def/fea#Office</seealso>
    let Office = Prefixed_Name(fea, "Office") |> PrefixedName
    /// <summary>
    ///   <para>fea:OrganizationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#OrganizationEntity">http://vocab.data.gov/def/fea#OrganizationEntity</seealso>
    let OrganizationEntity = Prefixed_Name(fea, "OrganizationEntity") |> PrefixedName
    /// <summary>
    ///   <para>fea:OtherFixedAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This class includes any fixed assets such as vehicle fleets, facilities and other equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Other Fixed Asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#OtherFixedAsset">http://vocab.data.gov/def/fea#OtherFixedAsset</seealso>
    let OtherFixedAsset = Prefixed_Name(fea, "OtherFixedAsset") |> PrefixedName
    /// <summary>
    ///   <para>fea:Partition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Each reference model has an extensional  property based on partitioning. This reveals implicit semantics in each reference model.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Partition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Partition">http://vocab.data.gov/def/fea#Partition</seealso>
    let Partition = Prefixed_Name(fea, "Partition") |> PrefixedName
    /// <summary>
    ///   <para>fea:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Party">http://vocab.data.gov/def/fea#Party</seealso>
    let Party = Prefixed_Name(fea, "Party") |> PrefixedName
    /// <summary>
    ///   <para>fea:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The BRM includes a Mode of Delivery Business Area that is designed to identify at a very high level the process that is being used to achieve an intended purpose.
    /// PRM volume 1, p.16"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Process">http://vocab.data.gov/def/fea#Process</seealso>
    let Process = Prefixed_Name(fea, "Process") |> PrefixedName
    /// <summary>
    ///   <para>fea:QuasiOfficialAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Quasi Official Agency of the US government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quasi Official Agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#QuasiOfficialAgency">http://vocab.data.gov/def/fea#QuasiOfficialAgency</seealso>
    let QuasiOfficialAgency = Prefixed_Name(fea, "QuasiOfficialAgency") |> PrefixedName
    /// <summary>
    ///   <para>fea:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Resource">http://vocab.data.gov/def/fea#Resource</seealso>
    let Resource = Prefixed_Name(fea, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>fea:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Technology standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Standard">http://vocab.data.gov/def/fea#Standard</seealso>
    let Standard = Prefixed_Name(fea, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>fea:StrategicOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Strategic Outcomes represent broad, policy priorities that drive the direction of government (such as to Secure the Homeland or Expand E-Government).
    /// PRM volume 1, p.13"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Strategic Outcome"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#StrategicOutcome">http://vocab.data.gov/def/fea#StrategicOutcome</seealso>
    let StrategicOutcome = Prefixed_Name(fea, "StrategicOutcome") |> PrefixedName
    /// <summary>
    ///   <para>fea:Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Technology means Information Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#Technology">http://vocab.data.gov/def/fea#Technology</seealso>
    let Technology = Prefixed_Name(fea, "Technology") |> PrefixedName
    /// <summary>
    ///   <para>fea:ValuePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The point at which value is measured."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ValuePoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#ValuePoint">http://vocab.data.gov/def/fea#ValuePoint</seealso>
    let ValuePoint = Prefixed_Name(fea, "ValuePoint") |> PrefixedName
    /// <summary>
    ///   <para>fea:allignedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"allignedWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#allignedWith">http://vocab.data.gov/def/fea#allignedWith</seealso>
    let allignedWith = Prefixed_Name(fea, "allignedWith") |> PrefixedName
    /// <summary>
    ///   <para>fea:buildsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"buildsOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#buildsOn">http://vocab.data.gov/def/fea#buildsOn</seealso>
    let buildsOn = Prefixed_Name(fea, "buildsOn") |> PrefixedName
    /// <summary>
    ///   <para>fea:comprises</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"comprises"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#comprises">http://vocab.data.gov/def/fea#comprises</seealso>
    let comprises = Prefixed_Name(fea, "comprises") |> PrefixedName
    /// <summary>
    ///   <para>fea:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#date">http://vocab.data.gov/def/fea#date</seealso>
    let date = Prefixed_Name(fea, "date") |> PrefixedName
    /// <summary>
    ///   <para>fea:dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dependsOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#dependsOn">http://vocab.data.gov/def/fea#dependsOn</seealso>
    let dependsOn = Prefixed_Name(fea, "dependsOn") |> PrefixedName
    /// <summary>
    ///   <para>fea:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#description">http://vocab.data.gov/def/fea#description</seealso>
    let description = Prefixed_Name(fea, "description") |> PrefixedName
    /// <summary>
    ///   <para>fea:drawsUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"drawsUpon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#drawsUpon">http://vocab.data.gov/def/fea#drawsUpon</seealso>
    let drawsUpon = Prefixed_Name(fea, "drawsUpon") |> PrefixedName
    /// <summary>
    ///   <para>fea:hasIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasIntent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#hasIntent">http://vocab.data.gov/def/fea#hasIntent</seealso>
    let hasIntent = Prefixed_Name(fea, "hasIntent") |> PrefixedName
    /// <summary>
    ///   <para>fea:intentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"intentOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#intentOf">http://vocab.data.gov/def/fea#intentOf</seealso>
    let intentOf = Prefixed_Name(fea, "intentOf") |> PrefixedName
    /// <summary>
    ///   <para>fea:isComprisedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"isComprisedOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#isComprisedOf">http://vocab.data.gov/def/fea#isComprisedOf</seealso>
    let isComprisedOf = Prefixed_Name(fea, "isComprisedOf") |> PrefixedName
    /// <summary>
    ///   <para>fea:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"used to describe part of relationships, such as, for example, the fact that one organization is part of another (departmental hierarchy)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#isPartOf">http://vocab.data.gov/def/fea#isPartOf</seealso>
    let isPartOf = Prefixed_Name(fea, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>fea:mnemonic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"mnemonic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#mnemonic">http://vocab.data.gov/def/fea#mnemonic</seealso>
    let mnemonic = Prefixed_Name(fea, "mnemonic") |> PrefixedName
    /// <summary>
    ///   <para>fea:supportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"supportedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#supportedBy">http://vocab.data.gov/def/fea#supportedBy</seealso>
    let supportedBy = Prefixed_Name(fea, "supportedBy") |> PrefixedName
    /// <summary>
    ///   <para>fea:undertakenBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"undertakenBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#undertakenBy">http://vocab.data.gov/def/fea#undertakenBy</seealso>
    let undertakenBy = Prefixed_Name(fea, "undertakenBy") |> PrefixedName
    /// <summary>
    ///   <para>fea:undertakes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"undertakes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.data.gov/def/fea#undertakes">http://vocab.data.gov/def/fea#undertakes</seealso>
    let undertakes = Prefixed_Name(fea, "undertakes") |> PrefixedName
