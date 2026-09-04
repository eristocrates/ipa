#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gdprov =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/GDPRov#" "gdprov"
    /// <summary>
    ///   <para>rdfs:label : Acquire Consent Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that acquires consent.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#AcquireConsentActivity">gdprov:AcquireConsentActivity</a>
    /// </summary>
    let AcquireConsentActivity = _prefixId.prefix "AcquireConsentActivity"
    /// <summary>
    ///   <para>rdfs:label : Anonymisation Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that anonymises data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#AnonymisationActivity">gdprov:AnonymisationActivity</a>
    /// </summary>
    let AnonymisationActivity = _prefixId.prefix "AnonymisationActivity"
    let Anonymised = _prefixId.prefix "Anonymised"
    /// <summary>
    ///   <para>rdfs:label : AnonymisedData^^xsd:string</para>
    ///   <para>rdfs:comment : Represents data that has been Anonymised at some level reflected by the hasAnonymityLevel object property^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#AnonymisedData">gdprov:AnonymisedData</a>
    /// </summary>
    let AnonymisedData = _prefixId.prefix "AnonymisedData"
    /// <summary>
    ///   <para>rdfs:label : Anonymised Data Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an entity where personal data has been anonymised to some extent.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#AnonymisedDataEntity">gdprov:AnonymisedDataEntity</a>
    /// </summary>
    let AnonymisedDataEntity = _prefixId.prefix "AnonymisedDataEntity"
    /// <summary>
    ///   <para>rdfs:label : AnonymityLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Provides a way to express the Anonymity Level of AnonymisedData objects through the object property hasAnonymityLevel^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#AnonymityLevel">gdprov:AnonymityLevel</a>
    /// </summary>
    let AnonymityLevel = _prefixId.prefix "AnonymityLevel"
    /// <summary>
    ///   <para>rdfs:label : Appoint Processor^^xsd:string</para>
    ///   <para>rdfs:comment : Reflects the process(es) used to appoint processors^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#AppointProcessor">gdprov:AppointProcessor</a>
    /// </summary>
    let AppointProcessor = _prefixId.prefix "AppointProcessor"
    /// <summary>
    ///   <para>rdfs:label : Archive Consent Activity^^xsd:string</para>
    ///   <para>rdfs:comment : An activity that archives given/acquired consent for storage.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ArchiveConsentActivity">gdprov:ArchiveConsentActivity</a>
    /// </summary>
    let ArchiveConsentActivity = _prefixId.prefix "ArchiveConsentActivity"
    /// <summary>
    ///   <para>rdfs:label : AutomatedStep^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#AutomatedStep">gdprov:AutomatedStep</a>
    /// </summary>
    let AutomatedStep = _prefixId.prefix "AutomatedStep"
    /// <summary>
    ///   <para>rdfs:label : Consent Acquisition Step</para>
    ///   <para>rdfs:comment : ConsentAcquisitionStep deals with acquiring consent from the user. It uses Terms and Conditions along with the appropriate Consent Model as the basis of obtaining consent from the user. The output of this step is the consent object agreed upon by the user.</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentAcquisitionStep">gdprov:ConsentAcquisitionStep</a>
    /// </summary>
    let ConsentAcquisitionStep = _prefixId.prefix "ConsentAcquisitionStep"
    /// <summary>
    ///   <para>rdfs:label : Consent Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity dealing with consent.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentActivity">gdprov:ConsentActivity</a>
    /// </summary>
    let ConsentActivity = _prefixId.prefix "ConsentActivity"
    /// <summary>
    ///   <para>rdfs:label : ConsentAgreement</para>
    ///   <para>rdfs:comment : ConsentAgreement reflects the consent provided by the user based on the provided Terms and Conditions and Consent Agreement Templates. It is the set of permissions the user has specifically provided or refused to provide. This consent is useful to provide justification of activities that use user data.</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentAgreement">gdprov:ConsentAgreement</a>
    /// </summary>
    let ConsentAgreement = _prefixId.prefix "ConsentAgreement"
    /// <summary>
    ///   <para>rdfs:comment : This is a template for consent requested from the user.</para>
    ///   <para>rdfs:label : ConsentAgreementTemplate</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentAgreementTemplate">gdprov:ConsentAgreementTemplate</a>
    /// </summary>
    let ConsentAgreementTemplate = _prefixId.prefix "ConsentAgreementTemplate"
    /// <summary>
    ///   <para>rdfs:label : Consent Archival Step</para>
    ///   <para>rdfs:comment : ConsentArchivalStep archives acquired consent to form a record of the consent given by the user.</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentArchivalStep">gdprov:ConsentArchivalStep</a>
    /// </summary>
    let ConsentArchivalStep = _prefixId.prefix "ConsentArchivalStep"
    /// <summary>
    ///   <para>rdfs:label : Consent Modification Step</para>
    ///   <para>rdfs:comment : ConsentModificationStep deals with modifications to the consent by the user. It invalidates the previous consent object and produces a new updated consent object that represents the modified consent.</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentModificationStep">gdprov:ConsentModificationStep</a>
    /// </summary>
    let ConsentModificationStep = _prefixId.prefix "ConsentModificationStep"
    /// <summary>
    ///   <para>rdfs:label : Consent Step</para>
    ///   <para>rdfs:comment : A ConsentStep acts/interacts with/uses Consent</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentStep">gdprov:ConsentStep</a>
    /// </summary>
    let ConsentStep = _prefixId.prefix "ConsentStep"
    /// <summary>
    ///   <para>rdfs:label : Consent Withdrawal Process</para>
    ///   <para>rdfs:comment : A ConsentWithdrawalProcess deals with the withdrawal of consent by the user and the corresponding activity carried out within the system</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentWithdrawalProcess">gdprov:ConsentWithdrawalProcess</a>
    /// </summary>
    let ConsentWithdrawalProcess = _prefixId.prefix "ConsentWithdrawalProcess"
    /// <summary>
    ///   <para>rdfs:label : Consent Withdrawal Step</para>
    ///   <para>rdfs:comment : ConsentWithdrawalStep deals with withdrawal of consent</para>
    ///   <a href="https://w3id.org/GDPRov#ConsentWithdrawalStep">gdprov:ConsentWithdrawalStep</a>
    /// </summary>
    let ConsentWithdrawalStep = _prefixId.prefix "ConsentWithdrawalStep"
    /// <summary>
    ///   <para>rdfs:label : Controller</para>
    ///   <para>rdfs:comment : A ThirdPartyDataController is a Third Party entity that acts as a Data Controller</para>
    ///   <a href="https://w3id.org/GDPRov#Controller">gdprov:Controller</a>
    /// </summary>
    let Controller = _prefixId.prefix "Controller"
    /// <summary>
    ///   <para>rdfs:label : Controller Representative^^xsd:string</para>
    ///   <para>rdfs:comment : A Representative of the Controller^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ControllerRepresentative">gdprov:ControllerRepresentative</a>
    /// </summary>
    let ControllerRepresentative = _prefixId.prefix "ControllerRepresentative"
    /// <summary>
    ///   <para>rdfs:label : Cross-border Data Transfer^^xsd:string</para>
    ///   <para>rdfs:comment : Reflects cross-border transfer of data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#CrossBorderDataTransfer">gdprov:CrossBorderDataTransfer</a>
    /// </summary>
    let CrossBorderDataTransfer = _prefixId.prefix "CrossBorderDataTransfer"
    /// <summary>
    ///   <para>rdfs:label : Cross Border Transfer Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that transfer data across borders (as defined in the GDPR).^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#CrossBorderTransferActivity">gdprov:CrossBorderTransferActivity</a>
    /// </summary>
    let CrossBorderTransferActivity = _prefixId.prefix "CrossBorderTransferActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Protection Officer (DPO)^^xsd:string</para>
    ///   <para>rdfs:comment : The Data Protection Officer appointed to an organisation.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DPO">gdprov:DPO</a>
    /// </summary>
    let DPO = _prefixId.prefix "DPO"
    /// <summary>
    ///   <para>rdfs:label : Data</para>
    ///   <para>rdfs:comment : Represents class of data collected or generated through various activities</para>
    ///   <a href="https://w3id.org/GDPRov#Data">gdprov:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:label : Data Access Process</para>
    ///   <para>rdfs:comment : A DataAccessProcess corresponds to the request made by an user for access to their data within the system. This process is responsible for handling the request process and providing the appropriate data to the end user.</para>
    ///   <a href="https://w3id.org/GDPRov#DataAccessProcess">gdprov:DataAccessProcess</a>
    /// </summary>
    let DataAccessProcess = _prefixId.prefix "DataAccessProcess"
    /// <summary>
    ///   <para>rdfs:label : Data Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity involving data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataActivity">gdprov:DataActivity</a>
    /// </summary>
    let DataActivity = _prefixId.prefix "DataActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Anonymisation Step</para>
    ///   <para>rdfs:comment : DataAnonymisationStep anonymises data by transforming it from one form to another along the anonymisation chain.
    /// Anonymisation can be represented as a spectrum going from raw user data to pseudo-anonymised data that can be de-anonymised by the same agent/organisation to pseudo-anonymous data that cannot be deanonymised internally, but may be done by external agents who have access to other data, and finally to completely anonymised data.</para>
    ///   <a href="https://w3id.org/GDPRov#DataAnonymisationStep">gdprov:DataAnonymisationStep</a>
    /// </summary>
    let DataAnonymisationStep = _prefixId.prefix "DataAnonymisationStep"
    /// <summary>
    ///   <para>rdfs:label : Data Archival Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that archives data. Archival is transformation of data into some form for storage.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataArchivalActivity">gdprov:DataArchivalActivity</a>
    /// </summary>
    let DataArchivalActivity = _prefixId.prefix "DataArchivalActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Archival Process</para>
    ///   <para>rdfs:comment : A DataArchivalProcess describes the process of data archival</para>
    ///   <a href="https://w3id.org/GDPRov#DataArchivalProcess">gdprov:DataArchivalProcess</a>
    /// </summary>
    let DataArchivalProcess = _prefixId.prefix "DataArchivalProcess"
    /// <summary>
    ///   <para>rdfs:label : Data Archival Step</para>
    ///   <para>rdfs:comment : DataArchivalStep archives data by transforming it and storing it</para>
    ///   <a href="https://w3id.org/GDPRov#DataArchivalStep">gdprov:DataArchivalStep</a>
    /// </summary>
    let DataArchivalStep = _prefixId.prefix "DataArchivalStep"
    /// <summary>
    ///   <para>rdfs:label : Data Breach Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity dealing with data breach.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataBreachActivity">gdprov:DataBreachActivity</a>
    /// </summary>
    let DataBreachActivity = _prefixId.prefix "DataBreachActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Breach Record^^xsd:string</para>
    ///   <para>rdfs:comment : A record of a data breach.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataBreachRecord">gdprov:DataBreachRecord</a>
    /// </summary>
    let DataBreachRecord = _prefixId.prefix "DataBreachRecord"
    /// <summary>
    ///   <para>rdfs:label : Data Breach Step^^xsd:string</para>
    ///   <para>rdfs:comment : Step representing an action associated with data breach.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataBreachStep">gdprov:DataBreachStep</a>
    /// </summary>
    let DataBreachStep = _prefixId.prefix "DataBreachStep"
    /// <summary>
    ///   <para>rdfs:label : Data Collection Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that collects or acquires data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataCollectionActivity">gdprov:DataCollectionActivity</a>
    /// </summary>
    let DataCollectionActivity = _prefixId.prefix "DataCollectionActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Collection Step</para>
    ///   <para>rdfs:comment : DataCollectionStep collects data from the user</para>
    ///   <a href="https://w3id.org/GDPRov#DataCollectionStep">gdprov:DataCollectionStep</a>
    /// </summary>
    let DataCollectionStep = _prefixId.prefix "DataCollectionStep"
    /// <summary>
    ///   <para>rdfs:label : Data Deanonymisation Step</para>
    ///   <para>rdfs:comment : DataDeanonymisationStep deanonymises data by transforming it from one form to another along the anonymisation chain.</para>
    ///   <a href="https://w3id.org/GDPRov#DataDeanonymisationStep">gdprov:DataDeanonymisationStep</a>
    /// </summary>
    let DataDeanonymisationStep = _prefixId.prefix "DataDeanonymisationStep"
    /// <summary>
    ///   <para>rdfs:label : Data Deletion Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that deletes or erases data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataDeletionActivity">gdprov:DataDeletionActivity</a>
    /// </summary>
    let DataDeletionActivity = _prefixId.prefix "DataDeletionActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Deletion Step</para>
    ///   <para>rdfs:comment : DataDeletionStep deletes data from within the system;
    /// The deletion is expressed as prov:invalidated over the dataset.</para>
    ///   <a href="https://w3id.org/GDPRov#DataDeletionStep">gdprov:DataDeletionStep</a>
    /// </summary>
    let DataDeletionStep = _prefixId.prefix "DataDeletionStep"
    /// <summary>
    ///   <para>rdfs:label : Data Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a data entity.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataEntity">gdprov:DataEntity</a>
    /// </summary>
    let DataEntity = _prefixId.prefix "DataEntity"
    /// <summary>
    ///   <para>rdfs:label : Data Erasure Process</para>
    ///   <para>rdfs:comment : A DataErasureProcess is responsible for handling the data erasure of a data subject.</para>
    ///   <a href="https://w3id.org/GDPRov#DataErasureProcess">gdprov:DataErasureProcess</a>
    /// </summary>
    let DataErasureProcess = _prefixId.prefix "DataErasureProcess"
    /// <summary>
    ///   <para>rdfs:label : Data Rectification Process</para>
    ///   <para>rdfs:comment : A DataRectificationProcess describes the process of data rectification, which is the correction of data already present within the system</para>
    ///   <a href="https://w3id.org/GDPRov#DataRectificationProcess">gdprov:DataRectificationProcess</a>
    /// </summary>
    let DataRectificationProcess = _prefixId.prefix "DataRectificationProcess"
    /// <summary>
    ///   <para>rdfs:label : Data Sharing Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that shares data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataSharingActivity">gdprov:DataSharingActivity</a>
    /// </summary>
    let DataSharingActivity = _prefixId.prefix "DataSharingActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Sharing Step</para>
    ///   <para>rdfs:comment : DataSharingStep shares data with another agent/organisation. These may be internal or external entities.</para>
    ///   <a href="https://w3id.org/GDPRov#DataSharingStep">gdprov:DataSharingStep</a>
    /// </summary>
    let DataSharingStep = _prefixId.prefix "DataSharingStep"
    /// <summary>
    ///   <para>rdfs:label : Data Step</para>
    ///   <para>rdfs:comment : A DataStep deals with data</para>
    ///   <a href="https://w3id.org/GDPRov#DataStep">gdprov:DataStep</a>
    /// </summary>
    let DataStep = _prefixId.prefix "DataStep"
    /// <summary>
    ///   <para>rdfs:label : Data Step without Provenance^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataStepWithoutProvenance">gdprov:DataStepWithoutProvenance</a>
    /// </summary>
    let DataStepWithoutProvenance = _prefixId.prefix "DataStepWithoutProvenance"
    /// <summary>
    ///   <para>rdfs:label : Data Storage Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that stores data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataStorageActivity">gdprov:DataStorageActivity</a>
    /// </summary>
    let DataStorageActivity = _prefixId.prefix "DataStorageActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Storage Step</para>
    ///   <para>rdfs:comment : DataStorageStep stores data within the system</para>
    ///   <a href="https://w3id.org/GDPRov#DataStorageStep">gdprov:DataStorageStep</a>
    /// </summary>
    let DataStorageStep = _prefixId.prefix "DataStorageStep"
    /// <summary>
    ///   <para>rdfs:label : Data Subject^^xsd:string</para>
    ///   <para>rdfs:comment : An individual or entity^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataSubject">gdprov:DataSubject</a>
    /// </summary>
    let DataSubject = _prefixId.prefix "DataSubject"
    /// <summary>
    ///   <para>rdfs:label : Data Transfer Activity^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataTransferActivity">gdprov:DataTransferActivity</a>
    /// </summary>
    let DataTransferActivity = _prefixId.prefix "DataTransferActivity"
    /// <summary>
    ///   <para>rdfs:label : DataTransferStep^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#DataTransferStep">gdprov:DataTransferStep</a>
    /// </summary>
    let DataTransferStep = _prefixId.prefix "DataTransferStep"
    /// <summary>
    ///   <para>rdfs:label : Data Transformation Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that transforms data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataTransformationActivity">gdprov:DataTransformationActivity</a>
    /// </summary>
    let DataTransformationActivity = _prefixId.prefix "DataTransformationActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Transformation Step</para>
    ///   <para>rdfs:comment : DataTransformationStep transforms data from one form into another.</para>
    ///   <a href="https://w3id.org/GDPRov#DataTransformationStep">gdprov:DataTransformationStep</a>
    /// </summary>
    let DataTransformationStep = _prefixId.prefix "DataTransformationStep"
    /// <summary>
    ///   <para>rdfs:label : Data Usage Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that uses data. Can also be termed as 'Processing' of data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DataUsageActivity">gdprov:DataUsageActivity</a>
    /// </summary>
    let DataUsageActivity = _prefixId.prefix "DataUsageActivity"
    /// <summary>
    ///   <para>rdfs:label : Data Usage Step</para>
    ///   <para>rdfs:comment : A DataUsageStep is a DataStep that uses existing data present within the system</para>
    ///   <a href="https://w3id.org/GDPRov#DataUsageStep">gdprov:DataUsageStep</a>
    /// </summary>
    let DataUsageStep = _prefixId.prefix "DataUsageStep"
    /// <summary>
    ///   <para>rdfs:label : DeAnonymisation Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that deanonymises data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DeAnonymisationActivity">gdprov:DeAnonymisationActivity</a>
    /// </summary>
    let DeAnonymisationActivity = _prefixId.prefix "DeAnonymisationActivity"
    let DeAnonymised = _prefixId.prefix "DeAnonymised"
    /// <summary>
    ///   <para>rdfs:label : Direct Marketing^^xsd:string</para>
    ///   <para>rdfs:comment : Direct Marketing where the marketing is done directly to the data subject.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#DirectMarketing">gdprov:DirectMarketing</a>
    /// </summary>
    let DirectMarketing = _prefixId.prefix "DirectMarketing"
    /// <summary>
    ///   <para>rdfs:label : Given Consent^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the given consent by the data subject.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#GivenConsent">gdprov:GivenConsent</a>
    /// </summary>
    let GivenConsent = _prefixId.prefix "GivenConsent"
    /// <summary>
    ///   <para>rdfs:label : Given Consent Template^^xsd:string</para>
    ///   <para>rdfs:comment : Is the template used to obtain the given consent.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#GivenConsentTemplate">gdprov:GivenConsentTemplate</a>
    /// </summary>
    let GivenConsentTemplate = _prefixId.prefix "GivenConsentTemplate"
    /// <summary>
    ///   <para>rdfs:label : HandleDataBreachProcess^^xsd:string</para>
    ///   <para>rdfs:comment : A process that defines the actions that should be undertaken in event of a data breach^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleDataBreachProcess">gdprov:HandleDataBreachProcess</a>
    /// </summary>
    let HandleDataBreachProcess = _prefixId.prefix "HandleDataBreachProcess"
    /// <summary>
    ///   <para>rdfs:label : Handle Right of Data Portability^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right of data portability.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightOfDataPortability">gdprov:HandleRightOfDataPortability</a>
    /// </summary>
    let HandleRightOfDataPortability = _prefixId.prefix "HandleRightOfDataPortability"
    /// <summary>
    ///   <para>rdfs:label : Handle Right of Erasure^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right of erasure.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightOfErasure">gdprov:HandleRightOfErasure</a>
    /// </summary>
    let HandleRightOfErasure = _prefixId.prefix "HandleRightOfErasure"

    /// <summary>
    ///   <para>rdfs:label : Handle Right to access Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to access personal data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToAccessPersonalData">gdprov:HandleRightToAccessPersonalData</a>
    /// </summary>
    let HandleRightToAccessPersonalData =
        _prefixId.prefix "HandleRightToAccessPersonalData"

    /// <summary>
    ///   <para>rdfs:label : Handle Right to basic information about Processing^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to basic information about processing.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToBasicInfoAboutProcessing">gdprov:HandleRightToBasicInfoAboutProcessing</a>
    /// </summary>
    let HandleRightToBasicInfoAboutProcessing =
        _prefixId.prefix "HandleRightToBasicInfoAboutProcessing"

    /// <summary>
    ///   <para>rdfs:label : Handle Right to not be evaluated through Automated Processing^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to not be processed automatically.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToNoAutomatedProcessing">gdprov:HandleRightToNoAutomatedProcessing</a>
    /// </summary>
    let HandleRightToNoAutomatedProcessing =
        _prefixId.prefix "HandleRightToNoAutomatedProcessing"

    /// <summary>
    ///   <para>rdfs:label : Handle Right to Object to Direct Marketing^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to object to direct marketing.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToObjectDirectMarketing">gdprov:HandleRightToObjectDirectMarketing</a>
    /// </summary>
    let HandleRightToObjectDirectMarketing =
        _prefixId.prefix "HandleRightToObjectDirectMarketing"

    /// <summary>
    ///   <para>rdfs:label : Handle Right to Object to Processing^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to object to processing.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToObjectProcessing">gdprov:HandleRightToObjectProcessing</a>
    /// </summary>
    let HandleRightToObjectProcessing = _prefixId.prefix "HandleRightToObjectProcessing"
    /// <summary>
    ///   <para>rdfs:label : Handle Right to Rectification^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to rectification of personal data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToRectification">gdprov:HandleRightToRectification</a>
    /// </summary>
    let HandleRightToRectification = _prefixId.prefix "HandleRightToRectification"

    /// <summary>
    ///   <para>rdfs:label : Handle Right to restrict Processing^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to restrict processing.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToRestrictProcessing">gdprov:HandleRightToRestrictProcessing</a>
    /// </summary>
    let HandleRightToRestrictProcessing =
        _prefixId.prefix "HandleRightToRestrictProcessing"

    /// <summary>
    ///   <para>rdfs:label : Handle Right to Transparency^^xsd:string</para>
    ///   <para>rdfs:comment : The process or series of steps that handle the right to transparency.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#HandleRightToTransparency">gdprov:HandleRightToTransparency</a>
    /// </summary>
    let HandleRightToTransparency = _prefixId.prefix "HandleRightToTransparency"
    /// <summary>
    ///   <para>rdfs:label : HandleSAR^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#HandleSAR">gdprov:HandleSAR</a>
    /// </summary>
    let HandleSAR = _prefixId.prefix "HandleSAR"
    /// <summary>
    ///   <para>rdfs:label : Impact Assessment^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the process or collection of steps representing the Impact Assessment.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ImpactAssessment">gdprov:ImpactAssessment</a>
    /// </summary>
    let ImpactAssessment = _prefixId.prefix "ImpactAssessment"
    /// <summary>
    ///   <para>rdfs:label : Joint Controller(s)^^xsd:string</para>
    ///   <para>rdfs:comment : A Joint Controller is where two or more controllers jointly determine the purposes and means of processing.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#JointController">gdprov:JointController</a>
    /// </summary>
    let JointController = _prefixId.prefix "JointController"
    /// <summary>
    ///   <para>rdfs:label : Marketing^^xsd:string</para>
    ///   <para>rdfs:comment : Marketing as a process or collection of steps.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#Marketing">gdprov:Marketing</a>
    /// </summary>
    let Marketing = _prefixId.prefix "Marketing"
    /// <summary>
    ///   <para>rdfs:label : Modify Consent Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that modifies given consent.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ModifyConsentActivity">gdprov:ModifyConsentActivity</a>
    /// </summary>
    let ModifyConsentActivity = _prefixId.prefix "ModifyConsentActivity"
    /// <summary>
    ///   <para>rdfs:label : Monitor Compliance^^xsd:string</para>
    ///   <para>rdfs:comment : The process of monitoring compliance as mandated by the GDPR.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#MonitorCompliance">gdprov:MonitorCompliance</a>
    /// </summary>
    let MonitorCompliance = _prefixId.prefix "MonitorCompliance"
    /// <summary>
    ///   <para>rdfs:label : Notify Controller^^xsd:string</para>
    ///   <para>rdfs:comment : Step that notifies the controller of data breach.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#NotifyController">gdprov:NotifyController</a>
    /// </summary>
    let NotifyController = _prefixId.prefix "NotifyController"
    /// <summary>
    ///   <para>rdfs:label : Notify Controller Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that notifies controller about data breach^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#NotifyControllerActivity">gdprov:NotifyControllerActivity</a>
    /// </summary>
    let NotifyControllerActivity = _prefixId.prefix "NotifyControllerActivity"
    /// <summary>
    ///   <para>rdfs:label : Notify Data Protection Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Step that notifies the Data Protection Authorities of a data breach.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#NotifyDPA">gdprov:NotifyDPA</a>
    /// </summary>
    let NotifyDPA = _prefixId.prefix "NotifyDPA"
    /// <summary>
    ///   <para>rdfs:label : Notify DPA Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that notifies data protection authorities about data breach^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#NotifyDPAActivity">gdprov:NotifyDPAActivity</a>
    /// </summary>
    let NotifyDPAActivity = _prefixId.prefix "NotifyDPAActivity"
    /// <summary>
    ///   <para>rdfs:label : Notify Data Subject^^xsd:string</para>
    ///   <para>rdfs:comment : Step that notifies the data subject of data breach.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#NotifyDataSubject">gdprov:NotifyDataSubject</a>
    /// </summary>
    let NotifyDataSubject = _prefixId.prefix "NotifyDataSubject"
    /// <summary>
    ///   <para>rdfs:label : Notify Data Subject Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that notifies data subjects about data breach^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#NotifyDataSubjectActivity">gdprov:NotifyDataSubjectActivity</a>
    /// </summary>
    let NotifyDataSubjectActivity = _prefixId.prefix "NotifyDataSubjectActivity"
    /// <summary>
    ///   <para>rdfs:label : PersonalData</para>
    ///   <para>rdfs:comment : PersonalData is any data pertaining to the user which can contain personally identifiable information or a data set generated by the system using personally identifiable information acquired through direct or indirect means</para>
    ///   <a href="https://w3id.org/GDPRov#PersonalData">gdprov:PersonalData</a>
    /// </summary>
    let PersonalData = _prefixId.prefix "PersonalData"
    /// <summary>
    ///   <para>rdfs:label : Personal Data Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a personal data entity.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#PersonalDataEntity">gdprov:PersonalDataEntity</a>
    /// </summary>
    let PersonalDataEntity = _prefixId.prefix "PersonalDataEntity"
    /// <summary>
    ///   <para>rdfs:label : Process</para>
    ///   <para>rdfs:comment : A Process describes a 'Plan' of action for carrying out a particular activity that uses or is related to Data or Consent</para>
    ///   <a href="https://w3id.org/GDPRov#Process">gdprov:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:label : Processor</para>
    ///   <para>rdfs:comment : A ThirdPartyDataProcessor is a Third Party entity that acts as a Data Processor</para>
    ///   <a href="https://w3id.org/GDPRov#Processor">gdprov:Processor</a>
    /// </summary>
    let Processor = _prefixId.prefix "Processor"
    /// <summary>
    ///   <para>rdfs:label : Processor Representative^^xsd:string</para>
    ///   <para>rdfs:comment : A representative of the Processor.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ProcessorRepresentative">gdprov:ProcessorRepresentative</a>
    /// </summary>
    let ProcessorRepresentative = _prefixId.prefix "ProcessorRepresentative"
    /// <summary>
    ///   <para>rdfs:label : Provide copy of Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : A step that provides the data subject with a copy of their personal data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ProvideCopyOfPersonalData">gdprov:ProvideCopyOfPersonalData</a>
    /// </summary>
    let ProvideCopyOfPersonalData = _prefixId.prefix "ProvideCopyOfPersonalData"
    let PseudoAnonymised = _prefixId.prefix "PseudoAnonymised"

    let PseudoOrganisationalAnonymised =
        _prefixId.prefix "PseudoOrganisationalAnonymised"

    /// <summary>
    ///   <para>rdfs:label : Rectify Data^^xsd:string</para>
    ///   <para>rdfs:comment : Rectifies existing data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#RectifyData">gdprov:RectifyData</a>
    /// </summary>
    let RectifyData = _prefixId.prefix "RectifyData"
    /// <summary>
    ///   <para>rdfs:label : Rectify Data Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that recitifies data.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#RectifyDataActivity">gdprov:RectifyDataActivity</a>
    /// </summary>
    let RectifyDataActivity = _prefixId.prefix "RectifyDataActivity"
    /// <summary>
    ///   <para>rdfs:label : Report Data Breach^^xsd:string</para>
    ///   <para>rdfs:comment : The process of reporting after a data breach has taken place.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#ReportDataBreach">gdprov:ReportDataBreach</a>
    /// </summary>
    let ReportDataBreach = _prefixId.prefix "ReportDataBreach"
    /// <summary>
    ///   <para>rdfs:label : Sensitive Personal Data^^xsd:string</para>
    ///   <para>rdfs:comment : Personal data revealing racial or ethnic origin, political opinions, religious or philosophical beliefs, or trade union membership, and the processing of genetic data, biometric data for the purpose of uniquely identifying a natural person, data concerning health or data concerning a natural person's sex life or sexual orientation.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#SensitiveData">gdprov:SensitiveData</a>
    /// </summary>
    let SensitiveData = _prefixId.prefix "SensitiveData"
    /// <summary>
    ///   <para>rdfs:label : Sensitive Data Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an entity containing sensitive personal information.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#SensitiveDataEntity">gdprov:SensitiveDataEntity</a>
    /// </summary>
    let SensitiveDataEntity = _prefixId.prefix "SensitiveDataEntity"
    /// <summary>
    ///   <para>rdfs:label : Sub-Processor^^xsd:string</para>
    ///   <para>rdfs:comment : A Processor appointed under or by another Processor is a Sub-Processor.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#SubProcessor">gdprov:SubProcessor</a>
    /// </summary>
    let SubProcessor = _prefixId.prefix "SubProcessor"
    /// <summary>
    ///   <para>rdfs:label : TermsAndConditions</para>
    ///   <para>rdfs:comment : Terms and Conditions of usage as provided to the user in agreement of provided service</para>
    ///   <a href="https://w3id.org/GDPRov#TermsAndConditions">gdprov:TermsAndConditions</a>
    /// </summary>
    let TermsAndConditions = _prefixId.prefix "TermsAndConditions"
    /// <summary>
    ///   <para>rdfs:label : Terms and Conditions Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the Terms and Conditions entity.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#TermsAndConditionsEntity">gdprov:TermsAndConditionsEntity</a>
    /// </summary>
    let TermsAndConditionsEntity = _prefixId.prefix "TermsAndConditionsEntity"
    /// <summary>
    ///   <para>rdfs:label : ThirdParty</para>
    ///   <para>rdfs:comment : A ThirdParty is any external entitiy associated with some internal activity</para>
    ///   <a href="https://w3id.org/GDPRov#ThirdParty">gdprov:ThirdParty</a>
    /// </summary>
    let ThirdParty = _prefixId.prefix "ThirdParty"
    /// <summary>
    ///   <para>rdfs:label : UserIdentifier</para>
    ///   <para>rdfs:comment : An UserIdentifier is a specific way to identify the user through a unique ID or a combination of other attributes</para>
    ///   <a href="https://w3id.org/GDPRov#UserIdentifier">gdprov:UserIdentifier</a>
    /// </summary>
    let UserIdentifier = _prefixId.prefix "UserIdentifier"
    /// <summary>
    ///   <para>rdfs:label : User Identifier Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an entity acting as the user identifier. Or contains an identifier.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#UserIdentifierEntity">gdprov:UserIdentifierEntity</a>
    /// </summary>
    let UserIdentifierEntity = _prefixId.prefix "UserIdentifierEntity"
    /// <summary>
    ///   <para>rdfs:label : User Input Step^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#UserInputStep">gdprov:UserInputStep</a>
    /// </summary>
    let UserInputStep = _prefixId.prefix "UserInputStep"
    /// <summary>
    ///   <para>rdfs:label : User Interaction Step^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#UserInteractionStep">gdprov:UserInteractionStep</a>
    /// </summary>
    let UserInteractionStep = _prefixId.prefix "UserInteractionStep"
    /// <summary>
    ///   <para>rdfs:label : User Output Step^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#UserOutputStep">gdprov:UserOutputStep</a>
    /// </summary>
    let UserOutputStep = _prefixId.prefix "UserOutputStep"
    /// <summary>
    ///   <para>rdfs:label : Withdraw Consent Activity^^xsd:string</para>
    ///   <para>rdfs:comment : Is an activity that withdraws given consent. Can also term it so as to depict withdrawal as a modification of consent.^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#WithdrawConsentActivity">gdprov:WithdrawConsentActivity</a>
    /// </summary>
    let WithdrawConsentActivity = _prefixId.prefix "WithdrawConsentActivity"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : anonymity level^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#anonymityLevel">gdprov:anonymityLevel</a>
    /// </summary>
    let anonymityLevel = _prefixId.prefix "anonymityLevel"
    /// <summary>
    ///   <para>rdfs:label : archives consent as^^xsd:string</para>
    ///   <para>rdfs:comment : Archives the consent into some entity^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#archivesConsentAs">gdprov:archivesConsentAs</a>
    /// </summary>
    let archivesConsentAs = _prefixId.prefix "archivesConsentAs"
    let collectedConsentFromAgent = _prefixId.prefix "collectedConsentFromAgent"
    let collectedDataFromAgent = _prefixId.prefix "collectedDataFromAgent"
    let collectsConsentFromAgent = _prefixId.prefix "collectsConsentFromAgent"
    /// <summary>
    ///   <para>rdfs:label : collectsData^^xsd:string</para>
    ///   <para>rdfs:comment : Links data obtained (collected) by the step/activity that acquired it^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#collectsData">gdprov:collectsData</a>
    /// </summary>
    let collectsData = _prefixId.prefix "collectsData"
    let collectsDataFromAgent = _prefixId.prefix "collectsDataFromAgent"
    /// <summary>
    ///   <para>rdfs:label : generatesAnonymisedData^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an DataAnonymisationStep transforms a Data object into AnonymisedData^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#generatesAnonymisedData">gdprov:generatesAnonymisedData</a>
    /// </summary>
    let generatesAnonymisedData = _prefixId.prefix "generatesAnonymisedData"
    /// <summary>
    ///   <para>rdfs:label : generatesConsentAgreement^^xsd:string</para>
    ///   <para>rdfs:comment : Generates ConsentAgreement which is a the consent granted by the user based on the ConsentAgreementTemplate through a ConsentAcquisitionStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#generatesConsentAgreement">gdprov:generatesConsentAgreement</a>
    /// </summary>
    let generatesConsentAgreement = _prefixId.prefix "generatesConsentAgreement"
    /// <summary>
    ///   <para>rdfs:label : generatesData^^xsd:string</para>
    ///   <para>rdfs:comment : produces data^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#generatesData">gdprov:generatesData</a>
    /// </summary>
    let generatesData = _prefixId.prefix "generatesData"
    /// <summary>
    ///   <para>rdfs:label : hasAnonymityLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the anonymity level of an AnonymisedData object using instances of the AnonymityLevel class^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#hasAnonymityLevel">gdprov:hasAnonymityLevel</a>
    /// </summary>
    let hasAnonymityLevel = _prefixId.prefix "hasAnonymityLevel"
    /// <summary>
    ///   <para>rdfs:label : hasLegalBasis^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#hasLegalBasis">gdprov:hasLegalBasis</a>
    /// </summary>
    let hasLegalBasis = _prefixId.prefix "hasLegalBasis"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : has legal justification^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#hasLegalJustification">gdprov:hasLegalJustification</a>
    /// </summary>
    let hasLegalJustification = _prefixId.prefix "hasLegalJustification"
    /// <summary>
    ///   <para>rdfs:label : hasSharedDataWith^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#hasSharedDataWith">gdprov:hasSharedDataWith</a>
    /// </summary>
    let hasSharedDataWith = _prefixId.prefix "hasSharedDataWith"
    let invalidatesData = _prefixId.prefix "invalidatesData"
    let involvesAgent = _prefixId.prefix "involvesAgent"
    /// <summary>
    ///   <para>rdfs:label : isAnonymisedByStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isAnonymisedByStep">gdprov:isAnonymisedByStep</a>
    /// </summary>
    let isAnonymisedByStep = _prefixId.prefix "isAnonymisedByStep"

    /// <summary>
    ///   <para>rdfs:label : isConsentAgreementTemplateForStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isConsentAgreementTemplateForStep">gdprov:isConsentAgreementTemplateForStep</a>
    /// </summary>
    let isConsentAgreementTemplateForStep =
        _prefixId.prefix "isConsentAgreementTemplateForStep"

    /// <summary>
    ///   <para>rdfs:label : isDataCollectedByStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isDataCollectedByStep">gdprov:isDataCollectedByStep</a>
    /// </summary>
    let isDataCollectedByStep = _prefixId.prefix "isDataCollectedByStep"
    /// <summary>
    ///   <para>rdfs:label : isDataGeneratedByStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isDataGeneratedBy">gdprov:isDataGeneratedBy</a>
    /// </summary>
    let isDataGeneratedBy = _prefixId.prefix "isDataGeneratedBy"
    /// <summary>
    ///   <para>rdfs:label : isGeneratedByStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isGeneratedByStep">gdprov:isGeneratedByStep</a>
    /// </summary>
    let isGeneratedByStep = _prefixId.prefix "isGeneratedByStep"
    /// <summary>
    ///   <para>rdfs:label : isJustificationForDataStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isJustificationForDataStep">gdprov:isJustificationForDataStep</a>
    /// </summary>
    let isJustificationForDataStep = _prefixId.prefix "isJustificationForDataStep"

    /// <summary>
    ///   <para>rdfs:label : isJustifiedUsingConsentAgreement^^xsd:string</para>
    ///   <para>rdfs:comment : justifies use of data by step through specified consent agreement^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isJustifiedUsingConsentAgreement">gdprov:isJustifiedUsingConsentAgreement</a>
    /// </summary>
    let isJustifiedUsingConsentAgreement =
        _prefixId.prefix "isJustifiedUsingConsentAgreement"

    /// <summary>
    ///   <para>rdfs:label : isPartOfProcess^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#isPartOfProcess">gdprov:isPartOfProcess</a>
    /// </summary>
    let isPartOfProcess = _prefixId.prefix "isPartOfProcess"
    /// <summary>
    ///   <para>rdfs:label : isTermsAndConditionsForStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isTermsAndConditionsForStep">gdprov:isTermsAndConditionsForStep</a>
    /// </summary>
    let isTermsAndConditionsForStep = _prefixId.prefix "isTermsAndConditionsForStep"
    /// <summary>
    ///   <para>rdfs:label : isUsedByStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#isUsedByStep">gdprov:isUsedByStep</a>
    /// </summary>
    let isUsedByStep = _prefixId.prefix "isUsedByStep"
    let refersToProcess = _prefixId.prefix "refersToProcess"
    /// <summary>
    ///   <para>rdfs:label : sharesData^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates sharing of Data through a DataStep^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#sharesData">gdprov:sharesData</a>
    /// </summary>
    let sharesData = _prefixId.prefix "sharesData"
    /// <summary>
    ///   <para>rdfs:label : sharesDataWith^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#sharesDataWith">gdprov:sharesDataWith</a>
    /// </summary>
    let sharesDataWith = _prefixId.prefix "sharesDataWith"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : sharesDataWithThirdParty^^xsd:string</para>
    ///   <para>rdfs:comment : Shares data with a third party^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#sharesDataWithThirdParty">gdprov:sharesDataWithThirdParty</a>
    /// </summary>
    let sharesDataWithThirdParty = _prefixId.prefix "sharesDataWithThirdParty"
    /// <summary>
    ///   <para>rdfs:label : transferredDataToRegion^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#transferredDataToRegion">gdprov:transferredDataToRegion</a>
    /// </summary>
    let transferredDataToRegion = _prefixId.prefix "transferredDataToRegion"
    /// <summary>
    ///   <para>rdfs:label : transfersDataToRegion^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/GDPRov#transfersDataToRegion">gdprov:transfersDataToRegion</a>
    /// </summary>
    let transfersDataToRegion = _prefixId.prefix "transfersDataToRegion"
    /// <summary>
    ///   <para>rdfs:label : uses Consent Agreement^^xsd:string</para>
    ///   <para>rdfs:comment : uses Consent Agreement entity^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#usesConsentAgreement">gdprov:usesConsentAgreement</a>
    /// </summary>
    let usesConsentAgreement = _prefixId.prefix "usesConsentAgreement"
    /// <summary>
    ///   <para>rdfs:label : usesConsentAgreementTemplate^^xsd:string</para>
    ///   <para>rdfs:comment : links a Consent Acquisition Step with the Consent Agreement Template used to acquire consent^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#usesConsentAgreementTemplate">gdprov:usesConsentAgreementTemplate</a>
    /// </summary>
    let usesConsentAgreementTemplate = _prefixId.prefix "usesConsentAgreementTemplate"
    /// <summary>
    ///   <para>rdfs:label : usesData^^xsd:string</para>
    ///   <para>rdfs:comment : links step with data used^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#usesData">gdprov:usesData</a>
    /// </summary>
    let usesData = _prefixId.prefix "usesData"
    /// <summary>
    ///   <para>rdfs:label : usesTermsAndConditions^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Consent Acquisition Step with the Terms and Conditions presented to the user when acquiring Consent^^xsd:string</para>
    ///   <a href="https://w3id.org/GDPRov#usesTermsAndConditions">gdprov:usesTermsAndConditions</a>
    /// </summary>
    let usesTermsAndConditions = _prefixId.prefix "usesTermsAndConditions"
    let wasSharedBy = _prefixId.prefix "wasSharedBy"
    let wasSharedWithThirdParty = _prefixId.prefix "wasSharedWithThirdParty"
