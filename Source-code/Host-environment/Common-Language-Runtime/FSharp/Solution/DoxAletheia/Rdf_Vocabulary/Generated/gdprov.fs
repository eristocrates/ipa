namespace https.w3id.org.GDPRov.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gdprov =
    let _namespace_iri = Namespace_Iri gdprov |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:GDPRov#AcquireConsentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that acquires consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acquire Consent Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#AcquireConsentActivity">https://w3id.org/GDPRov#AcquireConsentActivity</seealso>
    let AcquireConsentActivity =
        Prefixed_Name(gdprov, "AcquireConsentActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#AnonymisationActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that anonymises data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anonymisation Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#AnonymisationActivity">https://w3id.org/GDPRov#AnonymisationActivity</seealso>
    let AnonymisationActivity =
        Prefixed_Name(gdprov, "AnonymisationActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#Anonymised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Anonymised represents the Anonymisation level where the data cannot be de-anonymised to retrieve personally identifiable information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anonymised"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#Anonymised">https://w3id.org/GDPRov#Anonymised</seealso>
    let Anonymised = Prefixed_Name(gdprov, "Anonymised") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#AnonymisedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents data that has been Anonymised at some level reflected by the hasAnonymityLevel object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AnonymisedData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#AnonymisedData">https://w3id.org/GDPRov#AnonymisedData</seealso>
    let AnonymisedData = Prefixed_Name(gdprov, "AnonymisedData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#AnonymisedDataEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an entity where personal data has been anonymised to some extent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anonymised Data Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#AnonymisedDataEntity">https://w3id.org/GDPRov#AnonymisedDataEntity</seealso>
    let AnonymisedDataEntity =
        Prefixed_Name(gdprov, "AnonymisedDataEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#AnonymityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Provides a way to express the Anonymity Level of AnonymisedData objects through the object property hasAnonymityLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AnonymityLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#AnonymityLevel">https://w3id.org/GDPRov#AnonymityLevel</seealso>
    let AnonymityLevel = Prefixed_Name(gdprov, "AnonymityLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#AppointProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reflects the process(es) used to appoint processors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Appoint Processor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#AppointProcessor">https://w3id.org/GDPRov#AppointProcessor</seealso>
    let AppointProcessor = Prefixed_Name(gdprov, "AppointProcessor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ArchiveConsentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity that archives given/acquired consent for storage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Archive Consent Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ArchiveConsentActivity">https://w3id.org/GDPRov#ArchiveConsentActivity</seealso>
    let ArchiveConsentActivity =
        Prefixed_Name(gdprov, "ArchiveConsentActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#AutomatedStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AutomatedStep"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#AutomatedStep">https://w3id.org/GDPRov#AutomatedStep</seealso>
    let AutomatedStep = Prefixed_Name(gdprov, "AutomatedStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentAcquisitionStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ConsentAcquisitionStep deals with acquiring consent from the user. It uses Terms and Conditions along with the appropriate Consent Model as the basis of obtaining consent from the user. The output of this step is the consent object agreed upon by the user."</para>
    /// labels<para>"Consent Acquisition Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentAcquisitionStep">https://w3id.org/GDPRov#ConsentAcquisitionStep</seealso>
    let ConsentAcquisitionStep =
        Prefixed_Name(gdprov, "ConsentAcquisitionStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity dealing with consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Consent Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentActivity">https://w3id.org/GDPRov#ConsentActivity</seealso>
    let ConsentActivity = Prefixed_Name(gdprov, "ConsentActivity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#ConsentAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ConsentAgreement reflects the consent provided by the user based on the provided Terms and Conditions and Consent Agreement Templates. It is the set of permissions the user has specifically provided or refused to provide. This consent is useful to provide justification of activities that use user data."</para>
    /// labels<para>"ConsentAgreement"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentAgreement">https://w3id.org/GDPRov#ConsentAgreement</seealso>
    let ConsentAgreement = Prefixed_Name(gdprov, "ConsentAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentAgreementTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a template for consent requested from the user."</para>
    /// labels<para>"ConsentAgreementTemplate"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentAgreementTemplate">https://w3id.org/GDPRov#ConsentAgreementTemplate</seealso>
    let ConsentAgreementTemplate =
        Prefixed_Name(gdprov, "ConsentAgreementTemplate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentArchivalStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ConsentArchivalStep archives acquired consent to form a record of the consent given by the user."</para>
    /// labels<para>"Consent Archival Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentArchivalStep">https://w3id.org/GDPRov#ConsentArchivalStep</seealso>
    let ConsentArchivalStep =
        Prefixed_Name(gdprov, "ConsentArchivalStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentModificationStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ConsentModificationStep deals with modifications to the consent by the user. It invalidates the previous consent object and produces a new updated consent object that represents the modified consent."</para>
    /// labels<para>"Consent Modification Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentModificationStep">https://w3id.org/GDPRov#ConsentModificationStep</seealso>
    let ConsentModificationStep =
        Prefixed_Name(gdprov, "ConsentModificationStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ConsentStep acts/interacts with/uses Consent"</para>
    /// labels<para>"Consent Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentStep">https://w3id.org/GDPRov#ConsentStep</seealso>
    let ConsentStep = Prefixed_Name(gdprov, "ConsentStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentWithdrawalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ConsentWithdrawalProcess deals with the withdrawal of consent by the user and the corresponding activity carried out within the system"</para>
    /// labels<para>"Consent Withdrawal Process"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentWithdrawalProcess">https://w3id.org/GDPRov#ConsentWithdrawalProcess</seealso>
    let ConsentWithdrawalProcess =
        Prefixed_Name(gdprov, "ConsentWithdrawalProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ConsentWithdrawalStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ConsentWithdrawalStep deals with withdrawal of consent"</para>
    /// labels<para>"Consent Withdrawal Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ConsentWithdrawalStep">https://w3id.org/GDPRov#ConsentWithdrawalStep</seealso>
    let ConsentWithdrawalStep =
        Prefixed_Name(gdprov, "ConsentWithdrawalStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#Controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ThirdPartyDataController is a Third Party entity that acts as a Data Controller"</para>
    /// labels<para>"Controller"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#Controller">https://w3id.org/GDPRov#Controller</seealso>
    let Controller = Prefixed_Name(gdprov, "Controller") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ControllerRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Representative of the Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Controller Representative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ControllerRepresentative">https://w3id.org/GDPRov#ControllerRepresentative</seealso>
    let ControllerRepresentative =
        Prefixed_Name(gdprov, "ControllerRepresentative") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#CrossBorderDataTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reflects cross-border transfer of data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cross-border Data Transfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#CrossBorderDataTransfer">https://w3id.org/GDPRov#CrossBorderDataTransfer</seealso>
    let CrossBorderDataTransfer =
        Prefixed_Name(gdprov, "CrossBorderDataTransfer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#CrossBorderTransferActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that transfer data across borders (as defined in the GDPR)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cross Border Transfer Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#CrossBorderTransferActivity">https://w3id.org/GDPRov#CrossBorderTransferActivity</seealso>
    let CrossBorderTransferActivity =
        Prefixed_Name(gdprov, "CrossBorderTransferActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Data Protection Officer appointed to an organisation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Protection Officer (DPO)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DPO">https://w3id.org/GDPRov#DPO</seealso>
    let DPO = Prefixed_Name(gdprov, "DPO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents class of data collected or generated through various activities"</para>
    /// labels<para>"Data"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#Data">https://w3id.org/GDPRov#Data</seealso>
    let Data = Prefixed_Name(gdprov, "Data") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataAccessProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DataAccessProcess corresponds to the request made by an user for access to their data within the system. This process is responsible for handling the request process and providing the appropriate data to the end user."</para>
    /// labels<para>"Data Access Process"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataAccessProcess">https://w3id.org/GDPRov#DataAccessProcess</seealso>
    let DataAccessProcess = Prefixed_Name(gdprov, "DataAccessProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity involving data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataActivity">https://w3id.org/GDPRov#DataActivity</seealso>
    let DataActivity = Prefixed_Name(gdprov, "DataActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataAnonymisationStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataAnonymisationStep anonymises data by transforming it from one form to another along the anonymisation chain.
    /// Anonymisation can be represented as a spectrum going from raw user data to pseudo-anonymised data that can be de-anonymised by the same agent/organisation to pseudo-anonymous data that cannot be deanonymised internally, but may be done by external agents who have access to other data, and finally to completely anonymised data."</para>
    /// labels<para>"Data Anonymisation Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataAnonymisationStep">https://w3id.org/GDPRov#DataAnonymisationStep</seealso>
    let DataAnonymisationStep =
        Prefixed_Name(gdprov, "DataAnonymisationStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataArchivalActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that archives data. Archival is transformation of data into some form for storage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Archival Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataArchivalActivity">https://w3id.org/GDPRov#DataArchivalActivity</seealso>
    let DataArchivalActivity =
        Prefixed_Name(gdprov, "DataArchivalActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataArchivalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DataArchivalProcess describes the process of data archival"</para>
    /// labels<para>"Data Archival Process"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataArchivalProcess">https://w3id.org/GDPRov#DataArchivalProcess</seealso>
    let DataArchivalProcess =
        Prefixed_Name(gdprov, "DataArchivalProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataArchivalStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataArchivalStep archives data by transforming it and storing it"</para>
    /// labels<para>"Data Archival Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataArchivalStep">https://w3id.org/GDPRov#DataArchivalStep</seealso>
    let DataArchivalStep = Prefixed_Name(gdprov, "DataArchivalStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataBreachActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity dealing with data breach."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Breach Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataBreachActivity">https://w3id.org/GDPRov#DataBreachActivity</seealso>
    let DataBreachActivity = Prefixed_Name(gdprov, "DataBreachActivity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataBreachRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A record of a data breach."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Breach Record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataBreachRecord">https://w3id.org/GDPRov#DataBreachRecord</seealso>
    let DataBreachRecord = Prefixed_Name(gdprov, "DataBreachRecord") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataBreachStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Step representing an action associated with data breach."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Breach Step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataBreachStep">https://w3id.org/GDPRov#DataBreachStep</seealso>
    let DataBreachStep = Prefixed_Name(gdprov, "DataBreachStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataCollectionActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that collects or acquires data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Collection Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataCollectionActivity">https://w3id.org/GDPRov#DataCollectionActivity</seealso>
    let DataCollectionActivity =
        Prefixed_Name(gdprov, "DataCollectionActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataCollectionStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataCollectionStep collects data from the user"</para>
    /// labels<para>"Data Collection Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataCollectionStep">https://w3id.org/GDPRov#DataCollectionStep</seealso>
    let DataCollectionStep = Prefixed_Name(gdprov, "DataCollectionStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataDeanonymisationStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataDeanonymisationStep deanonymises data by transforming it from one form to another along the anonymisation chain."</para>
    /// labels<para>"Data Deanonymisation Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataDeanonymisationStep">https://w3id.org/GDPRov#DataDeanonymisationStep</seealso>
    let DataDeanonymisationStep =
        Prefixed_Name(gdprov, "DataDeanonymisationStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataDeletionActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that deletes or erases data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Deletion Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataDeletionActivity">https://w3id.org/GDPRov#DataDeletionActivity</seealso>
    let DataDeletionActivity =
        Prefixed_Name(gdprov, "DataDeletionActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataDeletionStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataDeletionStep deletes data from within the system;
    /// The deletion is expressed as prov:invalidated over the dataset."</para>
    /// labels<para>"Data Deletion Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataDeletionStep">https://w3id.org/GDPRov#DataDeletionStep</seealso>
    let DataDeletionStep = Prefixed_Name(gdprov, "DataDeletionStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a data entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataEntity">https://w3id.org/GDPRov#DataEntity</seealso>
    let DataEntity = Prefixed_Name(gdprov, "DataEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataErasureProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DataErasureProcess is responsible for handling the data erasure of a data subject."</para>
    /// labels<para>"Data Erasure Process"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataErasureProcess">https://w3id.org/GDPRov#DataErasureProcess</seealso>
    let DataErasureProcess = Prefixed_Name(gdprov, "DataErasureProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataRectificationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DataRectificationProcess describes the process of data rectification, which is the correction of data already present within the system"</para>
    /// labels<para>"Data Rectification Process"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataRectificationProcess">https://w3id.org/GDPRov#DataRectificationProcess</seealso>
    let DataRectificationProcess =
        Prefixed_Name(gdprov, "DataRectificationProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataSharingActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that shares data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Sharing Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataSharingActivity">https://w3id.org/GDPRov#DataSharingActivity</seealso>
    let DataSharingActivity =
        Prefixed_Name(gdprov, "DataSharingActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataSharingStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataSharingStep shares data with another agent/organisation. These may be internal or external entities."</para>
    /// labels<para>"Data Sharing Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataSharingStep">https://w3id.org/GDPRov#DataSharingStep</seealso>
    let DataSharingStep = Prefixed_Name(gdprov, "DataSharingStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DataStep deals with data"</para>
    /// labels<para>"Data Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataStep">https://w3id.org/GDPRov#DataStep</seealso>
    let DataStep = Prefixed_Name(gdprov, "DataStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataStepWithoutProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Step without Provenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataStepWithoutProvenance">https://w3id.org/GDPRov#DataStepWithoutProvenance</seealso>
    let DataStepWithoutProvenance =
        Prefixed_Name(gdprov, "DataStepWithoutProvenance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataStorageActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that stores data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Storage Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataStorageActivity">https://w3id.org/GDPRov#DataStorageActivity</seealso>
    let DataStorageActivity =
        Prefixed_Name(gdprov, "DataStorageActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataStorageStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataStorageStep stores data within the system"</para>
    /// labels<para>"Data Storage Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataStorageStep">https://w3id.org/GDPRov#DataStorageStep</seealso>
    let DataStorageStep = Prefixed_Name(gdprov, "DataStorageStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual or entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataSubject">https://w3id.org/GDPRov#DataSubject</seealso>
    let DataSubject = Prefixed_Name(gdprov, "DataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataTransferActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Transfer Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataTransferActivity">https://w3id.org/GDPRov#DataTransferActivity</seealso>
    let DataTransferActivity =
        Prefixed_Name(gdprov, "DataTransferActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataTransferStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DataTransferStep"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataTransferStep">https://w3id.org/GDPRov#DataTransferStep</seealso>
    let DataTransferStep = Prefixed_Name(gdprov, "DataTransferStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataTransformationActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that transforms data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Transformation Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataTransformationActivity">https://w3id.org/GDPRov#DataTransformationActivity</seealso>
    let DataTransformationActivity =
        Prefixed_Name(gdprov, "DataTransformationActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataTransformationStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataTransformationStep transforms data from one form into another."</para>
    /// labels<para>"Data Transformation Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataTransformationStep">https://w3id.org/GDPRov#DataTransformationStep</seealso>
    let DataTransformationStep =
        Prefixed_Name(gdprov, "DataTransformationStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DataUsageActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that uses data. Can also be termed as 'Processing' of data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Usage Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataUsageActivity">https://w3id.org/GDPRov#DataUsageActivity</seealso>
    let DataUsageActivity = Prefixed_Name(gdprov, "DataUsageActivity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DataUsageStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DataUsageStep is a DataStep that uses existing data present within the system"</para>
    /// labels<para>"Data Usage Step"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DataUsageStep">https://w3id.org/GDPRov#DataUsageStep</seealso>
    let DataUsageStep = Prefixed_Name(gdprov, "DataUsageStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DeAnonymisationActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that deanonymises data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeAnonymisation Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DeAnonymisationActivity">https://w3id.org/GDPRov#DeAnonymisationActivity</seealso>
    let DeAnonymisationActivity =
        Prefixed_Name(gdprov, "DeAnonymisationActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#DeAnonymised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"DeAnonymised represents the Anonymisation level where the data is completely de-anonymised and contains directly accessible personally identifiable information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeAnonymised"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DeAnonymised">https://w3id.org/GDPRov#DeAnonymised</seealso>
    let DeAnonymised = Prefixed_Name(gdprov, "DeAnonymised") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#DirectMarketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Direct Marketing where the marketing is done directly to the data subject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Direct Marketing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#DirectMarketing">https://w3id.org/GDPRov#DirectMarketing</seealso>
    let DirectMarketing = Prefixed_Name(gdprov, "DirectMarketing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#GivenConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the given consent by the data subject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Given Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#GivenConsent">https://w3id.org/GDPRov#GivenConsent</seealso>
    let GivenConsent = Prefixed_Name(gdprov, "GivenConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#GivenConsentTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is the template used to obtain the given consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Given Consent Template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#GivenConsentTemplate">https://w3id.org/GDPRov#GivenConsentTemplate</seealso>
    let GivenConsentTemplate =
        Prefixed_Name(gdprov, "GivenConsentTemplate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleDataBreachProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A process that defines the actions that should be undertaken in event of a data breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HandleDataBreachProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleDataBreachProcess">https://w3id.org/GDPRov#HandleDataBreachProcess</seealso>
    let HandleDataBreachProcess =
        Prefixed_Name(gdprov, "HandleDataBreachProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightOfDataPortability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right of data portability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right of Data Portability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightOfDataPortability">https://w3id.org/GDPRov#HandleRightOfDataPortability</seealso>
    let HandleRightOfDataPortability =
        Prefixed_Name(gdprov, "HandleRightOfDataPortability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightOfErasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right of erasure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right of Erasure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightOfErasure">https://w3id.org/GDPRov#HandleRightOfErasure</seealso>
    let HandleRightOfErasure =
        Prefixed_Name(gdprov, "HandleRightOfErasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToAccessPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to access personal data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to access Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToAccessPersonalData">https://w3id.org/GDPRov#HandleRightToAccessPersonalData</seealso>
    let HandleRightToAccessPersonalData =
        Prefixed_Name(gdprov, "HandleRightToAccessPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToBasicInfoAboutProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to basic information about processing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to basic information about Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToBasicInfoAboutProcessing">https://w3id.org/GDPRov#HandleRightToBasicInfoAboutProcessing</seealso>
    let HandleRightToBasicInfoAboutProcessing =
        Prefixed_Name(gdprov, "HandleRightToBasicInfoAboutProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToNoAutomatedProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to not be processed automatically."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to not be evaluated through Automated Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToNoAutomatedProcessing">https://w3id.org/GDPRov#HandleRightToNoAutomatedProcessing</seealso>
    let HandleRightToNoAutomatedProcessing =
        Prefixed_Name(gdprov, "HandleRightToNoAutomatedProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToObjectDirectMarketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to object to direct marketing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to Object to Direct Marketing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToObjectDirectMarketing">https://w3id.org/GDPRov#HandleRightToObjectDirectMarketing</seealso>
    let HandleRightToObjectDirectMarketing =
        Prefixed_Name(gdprov, "HandleRightToObjectDirectMarketing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToObjectProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to object to processing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to Object to Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToObjectProcessing">https://w3id.org/GDPRov#HandleRightToObjectProcessing</seealso>
    let HandleRightToObjectProcessing =
        Prefixed_Name(gdprov, "HandleRightToObjectProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToRectification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to rectification of personal data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to Rectification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToRectification">https://w3id.org/GDPRov#HandleRightToRectification</seealso>
    let HandleRightToRectification =
        Prefixed_Name(gdprov, "HandleRightToRectification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToRestrictProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to restrict processing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to restrict Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToRestrictProcessing">https://w3id.org/GDPRov#HandleRightToRestrictProcessing</seealso>
    let HandleRightToRestrictProcessing =
        Prefixed_Name(gdprov, "HandleRightToRestrictProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleRightToTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or series of steps that handle the right to transparency."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handle Right to Transparency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleRightToTransparency">https://w3id.org/GDPRov#HandleRightToTransparency</seealso>
    let HandleRightToTransparency =
        Prefixed_Name(gdprov, "HandleRightToTransparency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#HandleSAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HandleSAR"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#HandleSAR">https://w3id.org/GDPRov#HandleSAR</seealso>
    let HandleSAR = Prefixed_Name(gdprov, "HandleSAR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#ImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the process or collection of steps representing the Impact Assessment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Impact Assessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ImpactAssessment">https://w3id.org/GDPRov#ImpactAssessment</seealso>
    let ImpactAssessment = Prefixed_Name(gdprov, "ImpactAssessment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#JointController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Joint Controller is where two or more controllers jointly determine the purposes and means of processing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Joint Controller(s)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#JointController">https://w3id.org/GDPRov#JointController</seealso>
    let JointController = Prefixed_Name(gdprov, "JointController") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#Marketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Marketing as a process or collection of steps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Marketing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#Marketing">https://w3id.org/GDPRov#Marketing</seealso>
    let Marketing = Prefixed_Name(gdprov, "Marketing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ModifyConsentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that modifies given consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modify Consent Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ModifyConsentActivity">https://w3id.org/GDPRov#ModifyConsentActivity</seealso>
    let ModifyConsentActivity =
        Prefixed_Name(gdprov, "ModifyConsentActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#MonitorCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process of monitoring compliance as mandated by the GDPR."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Monitor Compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#MonitorCompliance">https://w3id.org/GDPRov#MonitorCompliance</seealso>
    let MonitorCompliance = Prefixed_Name(gdprov, "MonitorCompliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#NotifyController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Step that notifies the controller of data breach."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Notify Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#NotifyController">https://w3id.org/GDPRov#NotifyController</seealso>
    let NotifyController = Prefixed_Name(gdprov, "NotifyController") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#NotifyControllerActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that notifies controller about data breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Notify Controller Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#NotifyControllerActivity">https://w3id.org/GDPRov#NotifyControllerActivity</seealso>
    let NotifyControllerActivity =
        Prefixed_Name(gdprov, "NotifyControllerActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#NotifyDPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Step that notifies the Data Protection Authorities of a data breach."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Notify Data Protection Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#NotifyDPA">https://w3id.org/GDPRov#NotifyDPA</seealso>
    let NotifyDPA = Prefixed_Name(gdprov, "NotifyDPA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#NotifyDPAActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that notifies data protection authorities about data breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Notify DPA Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#NotifyDPAActivity">https://w3id.org/GDPRov#NotifyDPAActivity</seealso>
    let NotifyDPAActivity = Prefixed_Name(gdprov, "NotifyDPAActivity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#NotifyDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Step that notifies the data subject of data breach."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Notify Data Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#NotifyDataSubject">https://w3id.org/GDPRov#NotifyDataSubject</seealso>
    let NotifyDataSubject = Prefixed_Name(gdprov, "NotifyDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#NotifyDataSubjectActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that notifies data subjects about data breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Notify Data Subject Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#NotifyDataSubjectActivity">https://w3id.org/GDPRov#NotifyDataSubjectActivity</seealso>
    let NotifyDataSubjectActivity =
        Prefixed_Name(gdprov, "NotifyDataSubjectActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#PersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PersonalData is any data pertaining to the user which can contain personally identifiable information or a data set generated by the system using personally identifiable information acquired through direct or indirect means"</para>
    /// labels<para>"PersonalData"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#PersonalData">https://w3id.org/GDPRov#PersonalData</seealso>
    let PersonalData = Prefixed_Name(gdprov, "PersonalData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#PersonalDataEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a personal data entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personal Data Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#PersonalDataEntity">https://w3id.org/GDPRov#PersonalDataEntity</seealso>
    let PersonalDataEntity = Prefixed_Name(gdprov, "PersonalDataEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Process describes a 'Plan' of action for carrying out a particular activity that uses or is related to Data or Consent"</para>
    /// labels<para>"Process"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#Process">https://w3id.org/GDPRov#Process</seealso>
    let Process = Prefixed_Name(gdprov, "Process") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#Processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ThirdPartyDataProcessor is a Third Party entity that acts as a Data Processor"</para>
    /// labels<para>"Processor"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#Processor">https://w3id.org/GDPRov#Processor</seealso>
    let Processor = Prefixed_Name(gdprov, "Processor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ProcessorRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A representative of the Processor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Processor Representative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ProcessorRepresentative">https://w3id.org/GDPRov#ProcessorRepresentative</seealso>
    let ProcessorRepresentative =
        Prefixed_Name(gdprov, "ProcessorRepresentative") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ProvideCopyOfPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A step that provides the data subject with a copy of their personal data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Provide copy of Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ProvideCopyOfPersonalData">https://w3id.org/GDPRov#ProvideCopyOfPersonalData</seealso>
    let ProvideCopyOfPersonalData =
        Prefixed_Name(gdprov, "ProvideCopyOfPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#PseudoAnonymised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"PseudoAnonymised represents the Anonymisation level where the data is anonymised but cannot be de-anonymised without additional data which is NOT accessible to the data-holding organisation to retrieve personally identifiable information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PseudoAnonymised"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#PseudoAnonymised">https://w3id.org/GDPRov#PseudoAnonymised</seealso>
    let PseudoAnonymised = Prefixed_Name(gdprov, "PseudoAnonymised") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#PseudoOrganisationalAnonymised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"PseudoOrganisationalAnonymised represents the Anonymisation level where the data is anonymised but cannot be de-anonymised without additional data which is accessible to the data-holding organisation to recreate the de-anonymised information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PseudoOrganisationalOrganised"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#PseudoOrganisationalAnonymised">https://w3id.org/GDPRov#PseudoOrganisationalAnonymised</seealso>
    let PseudoOrganisationalAnonymised =
        Prefixed_Name(gdprov, "PseudoOrganisationalAnonymised") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#RectifyData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Rectifies existing data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rectify Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#RectifyData">https://w3id.org/GDPRov#RectifyData</seealso>
    let RectifyData = Prefixed_Name(gdprov, "RectifyData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#RectifyDataActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that recitifies data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rectify Data Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#RectifyDataActivity">https://w3id.org/GDPRov#RectifyDataActivity</seealso>
    let RectifyDataActivity =
        Prefixed_Name(gdprov, "RectifyDataActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ReportDataBreach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process of reporting after a data breach has taken place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Report Data Breach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ReportDataBreach">https://w3id.org/GDPRov#ReportDataBreach</seealso>
    let ReportDataBreach = Prefixed_Name(gdprov, "ReportDataBreach") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#SensitiveData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Personal data revealing racial or ethnic origin, political opinions, religious or philosophical beliefs, or trade union membership, and the processing of genetic data, biometric data for the purpose of uniquely identifying a natural person, data concerning health or data concerning a natural person's sex life or sexual orientation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensitive Personal Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#SensitiveData">https://w3id.org/GDPRov#SensitiveData</seealso>
    let SensitiveData = Prefixed_Name(gdprov, "SensitiveData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#SensitiveDataEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an entity containing sensitive personal information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensitive Data Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#SensitiveDataEntity">https://w3id.org/GDPRov#SensitiveDataEntity</seealso>
    let SensitiveDataEntity =
        Prefixed_Name(gdprov, "SensitiveDataEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#SubProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Processor appointed under or by another Processor is a Sub-Processor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub-Processor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#SubProcessor">https://w3id.org/GDPRov#SubProcessor</seealso>
    let SubProcessor = Prefixed_Name(gdprov, "SubProcessor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#TermsAndConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Terms and Conditions of usage as provided to the user in agreement of provided service"</para>
    /// labels<para>"TermsAndConditions"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#TermsAndConditions">https://w3id.org/GDPRov#TermsAndConditions</seealso>
    let TermsAndConditions = Prefixed_Name(gdprov, "TermsAndConditions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#TermsAndConditionsEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the Terms and Conditions entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Terms and Conditions Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#TermsAndConditionsEntity">https://w3id.org/GDPRov#TermsAndConditionsEntity</seealso>
    let TermsAndConditionsEntity =
        Prefixed_Name(gdprov, "TermsAndConditionsEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#ThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ThirdParty is any external entitiy associated with some internal activity"</para>
    /// labels<para>"ThirdParty"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#ThirdParty">https://w3id.org/GDPRov#ThirdParty</seealso>
    let ThirdParty = Prefixed_Name(gdprov, "ThirdParty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#UserIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An UserIdentifier is a specific way to identify the user through a unique ID or a combination of other attributes"</para>
    /// labels<para>"UserIdentifier"</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#UserIdentifier">https://w3id.org/GDPRov#UserIdentifier</seealso>
    let UserIdentifier = Prefixed_Name(gdprov, "UserIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#UserIdentifierEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an entity acting as the user identifier. Or contains an identifier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"User Identifier Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#UserIdentifierEntity">https://w3id.org/GDPRov#UserIdentifierEntity</seealso>
    let UserIdentifierEntity =
        Prefixed_Name(gdprov, "UserIdentifierEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#UserInputStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"User Input Step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#UserInputStep">https://w3id.org/GDPRov#UserInputStep</seealso>
    let UserInputStep = Prefixed_Name(gdprov, "UserInputStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#UserInteractionStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"User Interaction Step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#UserInteractionStep">https://w3id.org/GDPRov#UserInteractionStep</seealso>
    let UserInteractionStep =
        Prefixed_Name(gdprov, "UserInteractionStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#UserOutputStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"User Output Step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#UserOutputStep">https://w3id.org/GDPRov#UserOutputStep</seealso>
    let UserOutputStep = Prefixed_Name(gdprov, "UserOutputStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#WithdrawConsentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Is an activity that withdraws given consent. Can also term it so as to depict withdrawal as a modification of consent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Withdraw Consent Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#WithdrawConsentActivity">https://w3id.org/GDPRov#WithdrawConsentActivity</seealso>
    let WithdrawConsentActivity =
        Prefixed_Name(gdprov, "WithdrawConsentActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#anonymityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"anonymity level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#anonymityLevel">https://w3id.org/GDPRov#anonymityLevel</seealso>
    let anonymityLevel = Prefixed_Name(gdprov, "anonymityLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#archivesConsentAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Archives the consent into some entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"archives consent as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#archivesConsentAs">https://w3id.org/GDPRov#archivesConsentAs</seealso>
    let archivesConsentAs = Prefixed_Name(gdprov, "archivesConsentAs") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#collectedConsentFromAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#collectedConsentFromAgent">https://w3id.org/GDPRov#collectedConsentFromAgent</seealso>
    let collectedConsentFromAgent =
        Prefixed_Name(gdprov, "collectedConsentFromAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#collectedDataFromAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#collectedDataFromAgent">https://w3id.org/GDPRov#collectedDataFromAgent</seealso>
    let collectedDataFromAgent =
        Prefixed_Name(gdprov, "collectedDataFromAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#collectsConsentFromAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#collectsConsentFromAgent">https://w3id.org/GDPRov#collectsConsentFromAgent</seealso>
    let collectsConsentFromAgent =
        Prefixed_Name(gdprov, "collectsConsentFromAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#collectsData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links data obtained (collected) by the step/activity that acquired it"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"collectsData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#collectsData">https://w3id.org/GDPRov#collectsData</seealso>
    let collectsData = Prefixed_Name(gdprov, "collectsData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#collectsDataFromAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#collectsDataFromAgent">https://w3id.org/GDPRov#collectsDataFromAgent</seealso>
    let collectsDataFromAgent =
        Prefixed_Name(gdprov, "collectsDataFromAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#generatesAnonymisedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an DataAnonymisationStep transforms a Data object into AnonymisedData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"generatesAnonymisedData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#generatesAnonymisedData">https://w3id.org/GDPRov#generatesAnonymisedData</seealso>
    let generatesAnonymisedData =
        Prefixed_Name(gdprov, "generatesAnonymisedData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#generatesConsentAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Generates ConsentAgreement which is a the consent granted by the user based on the ConsentAgreementTemplate through a ConsentAcquisitionStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"generatesConsentAgreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#generatesConsentAgreement">https://w3id.org/GDPRov#generatesConsentAgreement</seealso>
    let generatesConsentAgreement =
        Prefixed_Name(gdprov, "generatesConsentAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#generatesData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"produces data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"generatesData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#generatesData">https://w3id.org/GDPRov#generatesData</seealso>
    let generatesData = Prefixed_Name(gdprov, "generatesData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#hasAnonymityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the anonymity level of an AnonymisedData object using instances of the AnonymityLevel class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAnonymityLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#hasAnonymityLevel">https://w3id.org/GDPRov#hasAnonymityLevel</seealso>
    let hasAnonymityLevel = Prefixed_Name(gdprov, "hasAnonymityLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#hasLegalBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLegalBasis"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#hasLegalBasis">https://w3id.org/GDPRov#hasLegalBasis</seealso>
    let hasLegalBasis = Prefixed_Name(gdprov, "hasLegalBasis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#hasLegalJustification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has legal justification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#hasLegalJustification">https://w3id.org/GDPRov#hasLegalJustification</seealso>
    let hasLegalJustification =
        Prefixed_Name(gdprov, "hasLegalJustification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#hasSharedDataWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSharedDataWith"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#hasSharedDataWith">https://w3id.org/GDPRov#hasSharedDataWith</seealso>
    let hasSharedDataWith = Prefixed_Name(gdprov, "hasSharedDataWith") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#invalidatesData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#invalidatesData">https://w3id.org/GDPRov#invalidatesData</seealso>
    let invalidatesData = Prefixed_Name(gdprov, "invalidatesData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#involvesAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#involvesAgent">https://w3id.org/GDPRov#involvesAgent</seealso>
    let involvesAgent = Prefixed_Name(gdprov, "involvesAgent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#isAnonymisedByStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isAnonymisedByStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isAnonymisedByStep">https://w3id.org/GDPRov#isAnonymisedByStep</seealso>
    let isAnonymisedByStep = Prefixed_Name(gdprov, "isAnonymisedByStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isConsentAgreementTemplateForStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isConsentAgreementTemplateForStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isConsentAgreementTemplateForStep">https://w3id.org/GDPRov#isConsentAgreementTemplateForStep</seealso>
    let isConsentAgreementTemplateForStep =
        Prefixed_Name(gdprov, "isConsentAgreementTemplateForStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isDataCollectedByStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDataCollectedByStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isDataCollectedByStep">https://w3id.org/GDPRov#isDataCollectedByStep</seealso>
    let isDataCollectedByStep =
        Prefixed_Name(gdprov, "isDataCollectedByStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isDataGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isDataGeneratedByStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isDataGeneratedBy">https://w3id.org/GDPRov#isDataGeneratedBy</seealso>
    let isDataGeneratedBy = Prefixed_Name(gdprov, "isDataGeneratedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#isGeneratedByStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isGeneratedByStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isGeneratedByStep">https://w3id.org/GDPRov#isGeneratedByStep</seealso>
    let isGeneratedByStep = Prefixed_Name(gdprov, "isGeneratedByStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isJustificationForDataStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isJustificationForDataStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isJustificationForDataStep">https://w3id.org/GDPRov#isJustificationForDataStep</seealso>
    let isJustificationForDataStep =
        Prefixed_Name(gdprov, "isJustificationForDataStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isJustifiedUsingConsentAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"justifies use of data by step through specified consent agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isJustifiedUsingConsentAgreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isJustifiedUsingConsentAgreement">https://w3id.org/GDPRov#isJustifiedUsingConsentAgreement</seealso>
    let isJustifiedUsingConsentAgreement =
        Prefixed_Name(gdprov, "isJustifiedUsingConsentAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isPartOfProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPartOfProcess"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isPartOfProcess">https://w3id.org/GDPRov#isPartOfProcess</seealso>
    let isPartOfProcess = Prefixed_Name(gdprov, "isPartOfProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isTermsAndConditionsForStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isTermsAndConditionsForStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isTermsAndConditionsForStep">https://w3id.org/GDPRov#isTermsAndConditionsForStep</seealso>
    let isTermsAndConditionsForStep =
        Prefixed_Name(gdprov, "isTermsAndConditionsForStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#isUsedByStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isUsedByStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#isUsedByStep">https://w3id.org/GDPRov#isUsedByStep</seealso>
    let isUsedByStep = Prefixed_Name(gdprov, "isUsedByStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#refersToProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#refersToProcess">https://w3id.org/GDPRov#refersToProcess</seealso>
    let refersToProcess = Prefixed_Name(gdprov, "refersToProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#sharesData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates sharing of Data through a DataStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sharesData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#sharesData">https://w3id.org/GDPRov#sharesData</seealso>
    let sharesData = Prefixed_Name(gdprov, "sharesData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:GDPRov#sharesDataWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sharesDataWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#sharesDataWith">https://w3id.org/GDPRov#sharesDataWith</seealso>
    let sharesDataWith = Prefixed_Name(gdprov, "sharesDataWith") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#sharesDataWithThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Shares data with a third party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sharesDataWithThirdParty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#sharesDataWithThirdParty">https://w3id.org/GDPRov#sharesDataWithThirdParty</seealso>
    let sharesDataWithThirdParty =
        Prefixed_Name(gdprov, "sharesDataWithThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#transferredDataToRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"transferredDataToRegion"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#transferredDataToRegion">https://w3id.org/GDPRov#transferredDataToRegion</seealso>
    let transferredDataToRegion =
        Prefixed_Name(gdprov, "transferredDataToRegion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#transfersDataToRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"transfersDataToRegion"^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#transfersDataToRegion">https://w3id.org/GDPRov#transfersDataToRegion</seealso>
    let transfersDataToRegion =
        Prefixed_Name(gdprov, "transfersDataToRegion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#usesConsentAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"uses Consent Agreement entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uses Consent Agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#usesConsentAgreement">https://w3id.org/GDPRov#usesConsentAgreement</seealso>
    let usesConsentAgreement =
        Prefixed_Name(gdprov, "usesConsentAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#usesConsentAgreementTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links a Consent Acquisition Step with the Consent Agreement Template used to acquire consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usesConsentAgreementTemplate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#usesConsentAgreementTemplate">https://w3id.org/GDPRov#usesConsentAgreementTemplate</seealso>
    let usesConsentAgreementTemplate =
        Prefixed_Name(gdprov, "usesConsentAgreementTemplate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#usesData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links step with data used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usesData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#usesData">https://w3id.org/GDPRov#usesData</seealso>
    let usesData = Prefixed_Name(gdprov, "usesData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#usesTermsAndConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Consent Acquisition Step with the Terms and Conditions presented to the user when acquiring Consent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"usesTermsAndConditions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/GDPRov#usesTermsAndConditions">https://w3id.org/GDPRov#usesTermsAndConditions</seealso>
    let usesTermsAndConditions =
        Prefixed_Name(gdprov, "usesTermsAndConditions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#wasSharedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#wasSharedBy">https://w3id.org/GDPRov#wasSharedBy</seealso>
    let wasSharedBy = Prefixed_Name(gdprov, "wasSharedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:GDPRov#wasSharedWithThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/GDPRov#wasSharedWithThirdParty">https://w3id.org/GDPRov#wasSharedWithThirdParty</seealso>
    let wasSharedWithThirdParty =
        Prefixed_Name(gdprov, "wasSharedWithThirdParty") |> PrefixedName
