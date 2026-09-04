#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rains =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/rains#" "rains"
    /// <summary>
    ///   <para>rdfs:label : AI System^^xsd:string</para>
    ///   <para>rdfs:comment : The AI System for which the accountability plan is specified.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#AI_System">rains:AI_System</a>
    /// </summary>
    let AI_System = _prefixId.prefix "AI_System"
    /// <summary>
    ///   <para>rdfs:label : Approval Decision^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of a planned human decision representing approvals and sign offs.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ApprovalDecision">rains:ApprovalDecision</a>
    /// </summary>
    let ApprovalDecision = _prefixId.prefix "ApprovalDecision"
    /// <summary>
    ///   <para>rdfs:label : Auto Constraint^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned Constraint that describes a constraint which can be evaluated automatically against corresponding accountability trace. Such constraint would normally link to its implementation (e.g., a SHACL rule) using the  https://w3id.org/ep-plan#hasConstraintImplementation property.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#AutoConstraint">rains:AutoConstraint</a>
    /// </summary>
    let AutoConstraint = _prefixId.prefix "AutoConstraint"
    /// <summary>
    ///   <para>rdfs:label : Bias^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :Risk  which records a specific piece of  information detailing a potential inclination or prejudice related to some aspects of :AI_Sytem (e.g., a training dataset containing more data about males when both genders will be considered by the ML model)
    ///
    /// If a mitigation strategy is used to abate the bias, then these can be indicated using the property :hasMitigationStrategy. It is advisable that information about the bias before and after mitigation is included.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Bias">rains:Bias</a>
    /// </summary>
    let Bias = _prefixId.prefix "Bias"
    /// <summary>
    ///   <para>rdfs:label : Certificate^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformnationElement which records information describing a certificate (e.g. an ISO certificate) that is granted during the implementation (or deployment or use and maintenance) life cycle stages.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Certificate">rains:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    /// <summary>
    ///   <para>rdfs:label : Certification Decision^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of a planned human compliance assurance decision representing certification granting. This is usually done by third parties, but may also be done inhouse to prove that the AI System abides by internal policies.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#CertificationDecision">rains:CertificationDecision</a>
    /// </summary>
    let CertificationDecision = _prefixId.prefix "CertificationDecision"
    /// <summary>
    ///   <para>rdfs:label : Change Justification^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformnationElement which records information describing the justification behind a deviation from the Design Specification. For example, the reason behind realizing a dataset other than the one indicated by the Dataset Design Specification was used, or why an evaluation measure was recorded which differed from the one indicated to be expected in an Evaluation Specification.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ChangeJustification">rains:ChangeJustification</a>
    /// </summary>
    let ChangeJustification = _prefixId.prefix "ChangeJustification"
    /// <summary>
    ///   <para>rdfs:label : Change Log^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned sao:AccountableResult that describes any change from a design specification or guideline. It is expected to be the result of any accountable action that has an input a design specification or a guideline.
    ///
    /// It is advisable that the information realization corresponding to the Evaluation contains the following information element ChangeJustification.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ChangeLog">rains:ChangeLog</a>
    /// </summary>
    let ChangeLog = _prefixId.prefix "ChangeLog"
    /// <summary>
    ///   <para>rdfs:label : Compliance Assurance Decision^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of a planned human decision representing confirmation of compliance of some sao:AccountableResult (e.g., a model specification) with its compliance requirements.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ComplianceAssuranceDecision">rains:ComplianceAssuranceDecision</a>
    /// </summary>
    let ComplianceAssuranceDecision = _prefixId.prefix "ComplianceAssuranceDecision"
    /// <summary>
    ///   <para>rdfs:label : Compliance Entity^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of sao:InformationElement which records a specific piece of  information about  a compliance requirement that is to be complied with as part of an information realization collection.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ComplianceEntity">rains:ComplianceEntity</a>
    /// </summary>
    let ComplianceEntity = _prefixId.prefix "ComplianceEntity"
    /// <summary>
    ///   <para>rdfs:comment : A specific type of design specification  which represents the  description of a compliance requirement.
    ///
    /// It is advisable that the information realization corresponding to SystemPurposeSpecification contains the following information elements
    /// 1. HardLaw
    /// 2. SoftLaw^^xsd:string</para>
    ///   <para>rdfs:label : Compliance Specification^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ComplianceSpecification">rains:ComplianceSpecification</a>
    /// </summary>
    let ComplianceSpecification = _prefixId.prefix "ComplianceSpecification"
    /// <summary>
    ///   <para>rdfs:label : Data Collection Procedure^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of sao:InformationElement which records a specific piece of  information detailing how the data is collected. This includes the information about mechanism used for collecting data (e.g. hardware sensors, software program, or manually), the timeframe over which the data was collected, any consent reporting, etc.
    ///
    /// There is a separate concept that represents the data collection software see rainsDataCollectionSoftware.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DataCollectionProcedure">rains:DataCollectionProcedure</a>
    /// </summary>
    let DataCollectionProcedure = _prefixId.prefix "DataCollectionProcedure"
    /// <summary>
    ///   <para>rdfs:label : Data Collection Software^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software that was used to collect data that formed the dataset which was used to train the ML Model^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DataCollectionSoftware">rains:DataCollectionSoftware</a>
    /// </summary>
    let DataCollectionSoftware = _prefixId.prefix "DataCollectionSoftware"
    /// <summary>
    ///   <para>rdfs:label : Data Preprocessing Procedure^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of sao:InformationElement which records a specific piece of  information detailing how the data is preprocessed. This includes information on what is done to the data (e.g., cleaning, sampling, filtering, feature engineering, etc) and how it is done (e.g., manually, programmatically, or using feature engineering software).
    ///
    /// There is a separate concept that represents the data preprocessing software.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DataPreprocessingProcedure">rains:DataPreprocessingProcedure</a>
    /// </summary>
    let DataPreprocessingProcedure = _prefixId.prefix "DataPreprocessingProcedure"
    /// <summary>
    ///   <para>rdfs:label : Data Preprocessing Software^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software  that was used to preprocess the dataset using to train the ML Model^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DataPreprocessingSoftware">rains:DataPreprocessingSoftware</a>
    /// </summary>
    let DataPreprocessingSoftware = _prefixId.prefix "DataPreprocessingSoftware"
    /// <summary>
    ///   <para>rdfs:label : Dataset Component^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned sao:AccountableResult  which represents the description of an realized dataset, including its characteristics, how it was collected, its risks, etc. The dataset component represents a collection of collected and pre-processed data. Once it is split, the subclasses TestingDataset, ValidationDataset, and EvaluationDataset can be used.
    ///
    /// It is advisable that the information realization corresponding to the DatasetComponent variable contains the following information elements:
    /// 1. Dataset, the realized dataset should be an instance of RealizedObject. If the implementation deviates from the design, then an additional dataset should be indicated as an instance of ExcludedObject.
    /// 2. DatasetCharacteristic
    /// 3. DataCollectionProcedure
    /// 4. DataPreprocesingProcedure
    /// 5. IntendedUseCase
    /// 6. Limitation
    /// 7. Risk
    /// 8. Bias
    /// 9. Tradeoff
    /// 10. IncorrectUseCase
    /// 11. IntendedUserGroup
    /// 12. HardLaw
    /// 13. SoftLaw
    ///
    /// It is discouraged that the information realization corresponding to the DtasetComponent variable contains the following information elements:
    /// 1. SystemAuditMechanism
    /// 2. SystemExplanationMechanims
    /// 3. SystemHumanOversightMechanism
    /// 4. SystemSecurityMechanism
    /// 5. SystemIntegrationGuidance
    /// 6. SystemDeploymentGuidance
    /// 7. SystemDocumentationGuidance
    /// 8. SystemIntegrationGuidance
    /// 9. SystemUsageGuidance
    /// 10. Model
    /// 11. ModelCharacteristic
    /// 12. Algorithm^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DatasetComponent">rains:DatasetComponent</a>
    /// </summary>
    let DatasetComponent = _prefixId.prefix "DatasetComponent"
    /// <summary>
    ///   <para>rdfs:label : Dataset Specification^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of design specification  which represents the description of planned requirements, characteristics, risks, etc. related to a dataset (e.g., a training dataset for ML model) expected to be used as part of the AI system life cycle.
    ///
    /// It is advisable that the information realization corresponding to DatasetSpecification contains the following information elements
    /// 1. Dataset
    /// 2. DatasetCharacteristic
    /// 3. DataCollectionProcedure
    /// 4. DataPreprocesingProcedure
    /// 5. IntendedUseCase
    /// 6. Limitation
    /// 7. Risk
    /// 8. Bias
    /// 9. Tradeoff
    /// 10. IntendedUserGroup
    /// 11. IncorrectUseCase
    /// 12. HardLaw
    /// 13. SoftLaw
    ///
    /// It is discouraged that the information realization corresponding to the Dataset Specification contains the following information elements:
    /// 1. SystemAuditMechanism
    /// 2. SystemExplanationMechanims
    /// 3. SystemHumanOversightMechanism
    /// 4. SystemSecurityMechanism
    /// 5. SystemIntegrationGuidance
    /// 6. SystemDeploymentGuidance
    /// 7. SystemDocumentationGuidance
    /// 8. SystemIntegrationGuidance
    /// 9. SystemUsageGuidance
    /// 10. Model
    /// 11. ModelCharacteristic
    /// 12. Algorithm^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DatasetSpecification">rains:DatasetSpecification</a>
    /// </summary>
    let DatasetSpecification = _prefixId.prefix "DatasetSpecification"
    /// <summary>
    ///   <para>rdfs:comment : A planned step describing a decision to be taken by a human when incorporating accountability in AI Systems, e.g. approve the design of an ML Model.^^xsd:string</para>
    ///   <para>rdfs:label : Decide^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Decide">rains:Decide</a>
    /// </summary>
    let Decide = _prefixId.prefix "Decide"
    /// <summary>
    ///   <para>rdfs:label : Design Specification^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned sao:AccountableResult which represents a high level reference to a specification  (e.g. a specification report) that is expected to be produced during the design stage in order to inform the future AI system lifecycle stages (e.g. implementation).^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DesignSpecification">rains:DesignSpecification</a>
    /// </summary>
    let DesignSpecification = _prefixId.prefix "DesignSpecification"
    /// <summary>
    ///   <para>rdfs:label : Design Stage Accountability Plan^^xsd:string</para>
    ///   <para>rdfs:comment : A plan that identifies sao:AccountableAction(s) and sao:AccountableResult(s) relevant to the design stage of an AI system and  which are required to be documented for accountability purposes. The Accountable Actions that can be done at this stage are: Produce Specification and Decide.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#DesignStageAccountabilityPlan">rains:DesignStageAccountabilityPlan</a>
    /// </summary>
    let DesignStageAccountabilityPlan = _prefixId.prefix "DesignStageAccountabilityPlan"
    /// <summary>
    ///   <para>rdfs:comment : A planned step describing an evaluation, i.e, testing  and producing evaluation metrics, that has some impact on the AI System, e.g. the evaluation of the ML model using a specified Dataset or the :AI_System undergoing a third party evaluation.^^xsd:string</para>
    ///   <para>rdfs:label : Evaluate^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Evaluate">rains:Evaluate</a>
    /// </summary>
    let Evaluate = _prefixId.prefix "Evaluate"
    /// <summary>
    ///   <para>rdfs:label : Evaluation^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned sao:AccountableResult which represents a high level reference to testing at least one component and recording the results of the test(s) (e.g. testing the model with a specified dataset) that is expected to be produced during the implementation stage.
    ///
    /// It is advisable that the information realization corresponding to the Evaluation variable contains the following information elements:
    /// 1. Either an instance of mls:EvaluationProcedure (if it is the model being evaluated) or EvaluationProcedure (if it is not the ML model being evaluated). Either should also be an instance of RealizedObject. If the evaluation deviates from the design, then an additional instance of mls:EvaluationProcedure or EvaluationProcedure should be indicated as an instance of ExcludedObject.
    /// 2. Either an instance of mls:EvaluationMeasure (if it is the model being evaluated) or EvaluationMeasure(if it is not the ML model being evaluated). If the evaluation deviates from the design, then an additional instance of mls:EvaluationMeasure or EvaluationMeasure should be indicated as an instance of ExcludedObject.
    /// 3. Either an instance of mls:ModelEvaluation (if it is the model being evaluated) or EvaluationResult (if it is not the ML model being evaluated). If the evaluation deviates from the design, then an additional instance of mls:ModelEvaluation or EvaluationResult should be indicated as an instance of ExcludedObject.
    /// 4. HardLaw
    /// 5. SoftLaw
    ///
    /// It is discouraged that the information realization corresponding to the Evaluation variable contains the following information elements:
    /// 1. SystemIntegrationGuidance
    /// 2. SystemDeploymentGuidance
    /// 3. SystemDocumentationGuidance
    /// 4. SystemIntegrationGuidance
    /// 5. SystemUsageGuidance^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Evaluation">rains:Evaluation</a>
    /// </summary>
    let Evaluation = _prefixId.prefix "Evaluation"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to evaluate the ML Model. The other subsets are used to train and evaluate the model. This type can also represent a standalone dataset used to evaluate the model independent of the datasets used to train and validate it.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#EvaluationDataset">rains:EvaluationDataset</a>
    /// </summary>
    let EvaluationDataset = _prefixId.prefix "EvaluationDataset"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Measure^^xsd:string</para>
    ///   <para>rdfs:comment : A  sao:InformationElement which records a specific piece of  information detailing some measure used as part of an evaluation process. This is broader than mls:EvaluationMeassure which describes a measure related to a model performance.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#EvaluationMeassure">rains:EvaluationMeassure</a>
    /// </summary>
    let EvaluationMeassure = _prefixId.prefix "EvaluationMeassure"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Procedure^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records a specific piece of  information detailing procedure by which some aspects of an :AI_Sytem were evaluated. This is broader than mls:EvaluationProcedure which relates to model evaluation.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#EvaluationProcedure">rains:EvaluationProcedure</a>
    /// </summary>
    let EvaluationProcedure = _prefixId.prefix "EvaluationProcedure"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Result^^xsd:string</para>
    ///   <para>rdfs:comment : A  sao:InformationElement which records a specific piece of  information detailing the result of an evaluation process. This is broader than mls:EvaluationMeassure which describes a result related to a specific model evaluation.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#EvaluationResult">rains:EvaluationResult</a>
    /// </summary>
    let EvaluationResult = _prefixId.prefix "EvaluationResult"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Specification^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of design specification which represents the description  of a planned evaluation process.
    ///
    /// It is advisable that the information realization corresponding to EvaluationSpecification contains the following information elements:
    /// 1. Either an instance of mls:EvaluationProcedure (if it is the model being evaluated) or EvaluationProcedure (if it is not the ML model being evaluated).
    /// 2. Either an instance of mls: EvaluationMeasure (if it is the model being evaluated) or EvaluationMeasure (if it is not the ML model being evaluated).
    /// 3. If available: Either an instance of mls:ModelEvaluation (if it is the model being evaluated) or EvaluationResult (if it is not the ML model being evaluated).
    /// 4. HardLaw
    /// 5. SoftLaw
    ///
    /// It is discouraged that the information realization corresponding to the Evaluation Specification contains the following information elements:
    /// 1. SystemIntegrationGuidance
    /// 2. SystemDeploymentGuidance
    /// 3. SystemDocumentationGuidance
    /// 4. SystemIntegrationGuidance
    /// 5. SystemUsageGuidance^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#EvaluationSpecification">rains:EvaluationSpecification</a>
    /// </summary>
    let EvaluationSpecification = _prefixId.prefix "EvaluationSpecification"
    /// <summary>
    ///   <para>rdfs:label : Excluded Object^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement which records information detailing a piece of data, software or hardware that should have been realized but was not.
    ///
    /// For example, assume the dataset design specification specifies that dataset foorbar is to be realised (to be used to train the model), but the implementation team realises dataset xyzzy instead. In this case, the dataset foobar should be indicated by the implementation team as an Excluded Object - whereas the dataset xyzzy should be created as an instance of :RealizedObject.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ExcludedObject">rains:ExcludedObject</a>
    /// </summary>
    let ExcludedObject = _prefixId.prefix "ExcludedObject"

    /// <summary>
    ///   <para>rdfs:label : Fairness Or Bias Detection Software^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software that was used to detect bias or check for fairness in both the dataset which was used to train the ML Model as well as the ML model itself^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#FairnessOrBiasDetectionSoftware">rains:FairnessOrBiasDetectionSoftware</a>
    /// </summary>
    let FairnessOrBiasDetectionSoftware =
        _prefixId.prefix "FairnessOrBiasDetectionSoftware"

    /// <summary>
    ///   <para>rdfs:label : Fitness Confirmation Decision^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned human decision representing confirmation of fitness of some sao:AccountableResult t to its purpose.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#FitnessConfirmationDecision">rains:FitnessConfirmationDecision</a>
    /// </summary>
    let FitnessConfirmationDecision = _prefixId.prefix "FitnessConfirmationDecision"
    /// <summary>
    ///   <para>rdfs:label : Funding^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records a specific piece of  information detailing a funding source.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Funding">rains:Funding</a>
    /// </summary>
    let Funding = _prefixId.prefix "Funding"
    /// <summary>
    ///   <para>rdfs:comment : A planned step describing the creation of a guideline that has some impact on the AI System, e.g. the production of the deployment guideline describing how the AI System is to be deployed on-site or the production of the maintenance guideline describing how the AI System is to be maintained.^^xsd:string</para>
    ///   <para>rdfs:label : Generate Guideline^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#GenerateGuideline">rains:GenerateGuideline</a>
    /// </summary>
    let GenerateGuideline = _prefixId.prefix "GenerateGuideline"
    /// <summary>
    ///   <para>rdfs:label : Grant Certification^^xsd:string</para>
    ///   <para>rdfs:comment : A planned step describing a certification granting decision to be taken by a human when incorporating accountability in AI Systems, e.g. grant an ISO certificate.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#GrantCertification">rains:GrantCertification</a>
    /// </summary>
    let GrantCertification = _prefixId.prefix "GrantCertification"
    /// <summary>
    ///   <para>rdfs:label : Guidance^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records a specific piece of  information detailing instructions that should be followed during the deployment or operation stage of the :AI_System lifecycle.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Guidance">rains:Guidance</a>
    /// </summary>
    let Guidance = _prefixId.prefix "Guidance"
    /// <summary>
    ///   <para>rdfs:label : Guideline^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned sao:AccountableResult which represents a high level reference to a guideline (e.g. a guideline document) that is expected to be produced during the implementation in order to inform on the correct procedure for deploying, using and maintaining the system or any of its components.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Guideline">rains:Guideline</a>
    /// </summary>
    let Guideline = _prefixId.prefix "Guideline"
    /// <summary>
    ///   <para>rdfs:label : Hard Law^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of compliance entity which records a specific piece of  information about the laws and regulations that must be, or are, complied with as part of an information realization collection.
    ///
    /// When used as part of an information realization corresponding to a design specification, it describes the hard laws that must be complied with. When used as part of an information realization corresponding to an realized component, it describes the hard laws that the component complies with.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#HardLaw">rains:HardLaw</a>
    /// </summary>
    let HardLaw = _prefixId.prefix "HardLaw"
    /// <summary>
    ///   <para>rdfs:label : Human Constraint^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned ep-plan:Constraint that describes some constraint which cannot be evaluated automatically against the accountability trace. This can be, for example, because the constraint is too high level or difficult to express as a rule. Such constraint would be typically expected to be evaluated manually by a human.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#HumanConstraint">rains:HumanConstraint</a>
    /// </summary>
    let HumanConstraint = _prefixId.prefix "HumanConstraint"
    /// <summary>
    ///   <para>rdfs:label : Human Decision^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of a planned sao:AccountableResult which represents a decision made by a human.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#HumanDecision">rains:HumanDecision</a>
    /// </summary>
    let HumanDecision = _prefixId.prefix "HumanDecision"

    /// <summary>
    ///   <para>rdfs:label : Implementation Stage Accountability Plan^^xsd:string</para>
    ///   <para>rdfs:comment : A plan that identifies sao:AccountableAction(s) and sao:AccountableResult(s) relevant to the implementation stage of an AI system and  which are required to be documented for accountability purposes. The Accountable Actions that can be done at this stage are: Realize Component, Merge and Split Dataset, Evaluate, Generate Guideline, Grant Certification, and Decide.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ImplementationStageAccountabilityPlan">rains:ImplementationStageAccountabilityPlan</a>
    /// </summary>
    let ImplementationStageAccountabilityPlan =
        _prefixId.prefix "ImplementationStageAccountabilityPlan"

    /// <summary>
    ///   <para>rdfs:label : Incorrect Use Case^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :UseCase detailing a situation in which any component of :AI_System or the system as whole should not be used.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#IncorrectUseCase">rains:IncorrectUseCase</a>
    /// </summary>
    let IncorrectUseCase = _prefixId.prefix "IncorrectUseCase"
    /// <summary>
    ///   <para>rdfs:label : Intended Use Case^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :UseCase detailing a situation in which any component of :AI_System or the system as whole is expected to be used.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#IntendedUseCase">rains:IntendedUseCase</a>
    /// </summary>
    let IntendedUseCase = _prefixId.prefix "IntendedUseCase"
    /// <summary>
    ///   <para>rdfs:label : Intended User Group^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records a specific piece of  information detailing the target user audience for the functionality of the overall :AI_System or the components used to develop such system (e.g., a reused public training dataset or a model would be associated with this information).^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#IntendedUserGroup">rains:IntendedUserGroup</a>
    /// </summary>
    let IntendedUserGroup = _prefixId.prefix "IntendedUserGroup"
    /// <summary>
    ///   <para>rdfs:label : Limitation^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records a specific piece of  information detailing the limitations of any aspect related to an :AI_System including the system as whole, its components (e.g., ML model),  or associated processes (e.g., evaluation).^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Limitation">rains:Limitation</a>
    /// </summary>
    let Limitation = _prefixId.prefix "Limitation"
    /// <summary>
    ///   <para>rdfs:label : Merge and Split Dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A planned step that has some impact on the AI System where the dataset(s) used to produce the ML Model are merged and/or split. Merging takes place when there is more than one dataset in use. Typically, splitting results in three subsets: Training, Validation, and Testing. This step is typically part of the Implementation stage of an AI System's life cycle.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#MergeAndSplitDataset">rains:MergeAndSplitDataset</a>
    /// </summary>
    let MergeAndSplitDataset = _prefixId.prefix "MergeAndSplitDataset"
    /// <summary>
    ///   <para>rdfs:label : Model Component^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned sao:AccountableResult which represents the description of a realized ML Model, including it characteristics, performance, etc.
    ///
    /// It is advisable that the information realization corresponding to the ModelComponent variable contains the following information elements:
    /// 1. Model: the realized model should be an instance of RealizedObject. If the implementation deviates from the design, then an additional model should be indicated as an instance of ExcludedObject.
    /// 2. ModelCharacteristic
    /// 3. Algorithm
    /// 4. Parameter
    /// 5. IntendedUseCase
    /// 6. Limitation
    /// 7. Risk
    /// 8. Bias
    /// 9. Tradeoff
    /// 10. IncorrectUseCase
    /// 11. IntendedUserGroup
    /// 12. HardLaw
    /// 13. SoftLaw
    ///
    /// It is discouraged that the information realization corresponding to the ModelComponent variable contains the following information elements:
    /// 1. SystemAuditMechanism
    /// 2. SystemExplanationMechanims
    /// 3. SystemHumanOversightMechanism
    /// 4. SystemSecurityMechanism
    /// 5. SystemIntegrationGuidance
    /// 6. SystemDeploymentGuidance
    /// 7. SystemDocumentationGuidance
    /// 8. SystemIntegrationGuidance
    /// 9. SystemUsageGuidance^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ModelComponent">rains:ModelComponent</a>
    /// </summary>
    let ModelComponent = _prefixId.prefix "ModelComponent"
    /// <summary>
    ///   <para>rdfs:label : Model Specification^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of design specification  which represents the description of planned requirements, characteristics, performance, etc. related to an AI model.
    ///
    /// It is advisable that the information realization corresponding to ModelSpecification contains the following information elements:
    /// 1. Model
    /// 2. ModelCharacteristic
    /// 3. Algorithm
    /// 4. IntendedUseCase
    /// 5. Limitation
    /// 6. Risk
    /// 7. Bias
    /// 8. Tradeoff
    /// 9. IntendedUserGroup
    /// 10. Parameter
    /// 11. Hyperparameter
    /// 12. IncorrectUseCase
    /// 13. HardLaw
    /// 14. SoftLaw
    ///
    /// It is discouraged that the information realization corresponding to the ModelSpecification contains the following information elements:
    /// 1. SystemAuditMechanism
    /// 2. SystemExplanationMechanims
    /// 3. SystemHumanOversightMechanism
    /// 4. SystemSecurityMechanism
    /// 5. SystemIntegrationGuidance
    /// 6. SystemDeploymentGuidance
    /// 7. SystemDocumentationGuidance
    /// 8. SystemIntegrationGuidance
    /// 9. SystemUsageGuidance^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ModelSpecification">rains:ModelSpecification</a>
    /// </summary>
    let ModelSpecification = _prefixId.prefix "ModelSpecification"
    /// <summary>
    ///   <para>rdfs:label : Parameter^^xsd:string</para>
    ///   <para>rdfs:comment : A  sao:InformationElement which records a specific piece of  information describing a model's parameter. This is broader than mls:HyperParameter which describes only a hyperparameter of a model.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Parameter">rains:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:label : Produce Specification^^xsd:string</para>
    ///   <para>rdfs:comment : A planned step describing the creation of a specification that has some impact on the AI System, e.g. the production of the design specification describing the training dataset to be used. This step is typically part of the Design stage of an AI System's life cycle.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ProduceSpecification">rains:ProduceSpecification</a>
    /// </summary>
    let ProduceSpecification = _prefixId.prefix "ProduceSpecification"
    /// <summary>
    ///   <para>rdfs:label : Realizable Object^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records  information detailing  a piece of data, software or hardware that may be realized during the Implementation stage. A reused object (e.g., public training datasets) is also considered as :RealizableObject during the Design stage as it is not yet implemented (i.e., physical copies have not yet been integrated withing the ML pipeline)^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#RealizableObject">rains:RealizableObject</a>
    /// </summary>
    let RealizableObject = _prefixId.prefix "RealizableObject"

    /// <summary>
    ///   <para>rdfs:label : Realizable Object Characteristic^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records  information detailing  a specific quality of :RealizableObject.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#RealizableObjectCharacteristic">rains:RealizableObjectCharacteristic</a>
    /// </summary>
    let RealizableObjectCharacteristic =
        _prefixId.prefix "RealizableObjectCharacteristic"

    /// <summary>
    ///   <para>rdfs:label : Realize Component^^xsd:string</para>
    ///   <para>rdfs:comment : A planned step describing the realization of a component. This includes implementing a component or retrieving it from a different (or third party) source. The realization of the component has some impact on the AI System, e.g. the implementation of the ML model or importing a third party dataset.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#RealizeComponent">rains:RealizeComponent</a>
    /// </summary>
    let RealizeComponent = _prefixId.prefix "RealizeComponent"
    /// <summary>
    ///   <para>rdfs:label : Realized Object^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement which records information detailing a piece of data, software or hardware that was realized - whether or not it followed a design specification or a guideline.
    ///
    /// For example, assume the dataset design specification specifies that dataset foorbar is to be realised (to be used to train the model), but the implementation team realises dataset xyzzy. In this case, only dataset xyzzy is created as an instance of Realized Object.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#RealizededObject">rains:RealizededObject</a>
    /// </summary>
    let RealizededObject = _prefixId.prefix "RealizededObject"
    /// <summary>
    ///   <para>rdfs:label : Risk^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records a specific piece of  information detailing possible undesired or dangerous outcomes caused by any aspects of :AI_Sytem.
    ///
    /// If a mitigation strategy is used to abate the risk, then these can be indicated using the property :hasMitigationStrategy. It is advisable that information about the risk before and after mitigation is included.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#Risk">rains:Risk</a>
    /// </summary>
    let Risk = _prefixId.prefix "Risk"
    /// <summary>
    ///   <para>rdfs:label : Soft Law^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of compliance entity which records a specific piece of  information about the procedures, standards, protocols, etc that complying with is desired or encouraged as part of an information realization collection.
    ///
    /// When used as part of an information realization corresponding to a design specification, it describes the soft laws that are to be complied with. When used as part of an information realization corresponding to an realized component, it describes the soft laws that the component complies with.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SoftLaw">rains:SoftLaw</a>
    /// </summary>
    let SoftLaw = _prefixId.prefix "SoftLaw"
    /// <summary>
    ///   <para>rdfs:label : Supporting Infrastructure^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :RealizableObject detailing the hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in :AI_System.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SupportingInfrastructure">rains:SupportingInfrastructure</a>
    /// </summary>
    let SupportingInfrastructure = _prefixId.prefix "SupportingInfrastructure"

    /// <summary>
    ///   <para>rdfs:label : Supporting Infrastructure Component^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of planned sao:AccountableResult which represents the characteristics, performance, etc. related to all the implemented hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in AI systems.
    ///
    /// It is advisable that the information realization corresponding to the SupportingInfrastructureComponent variable contains the following information elements:
    /// 1. SupportingInfrastructure, the realized supporting infrastructure should be an instance of RealizedObject. If the implementation deviates from the design, then an additional upporting infrastructure should be indicated as an instance of ExcludedObject.
    /// 2. Limitation
    /// 3. Risk
    /// 4. Bias
    /// 5. Tradeoff
    /// 6. SystemAuditMechanism
    /// 7. SystemExplanationMechanims
    /// 8. SystemHumanOversightMechanism
    /// 9. SystemSecurityMechanism
    /// 10. HardLaw
    /// 11. SoftLaw^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SupportingInfrastructureComponent">rains:SupportingInfrastructureComponent</a>
    /// </summary>
    let SupportingInfrastructureComponent =
        _prefixId.prefix "SupportingInfrastructureComponent"

    /// <summary>
    ///   <para>rdfs:label : Supporting Infrastructure Specification^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of design specification which represents the specification description of planned requirements, characteristics, performance, etc. related to all the hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in AI systems.
    ///
    /// It is advisable that the information realization corresponding to SupportingInfrastructureSpecification contains the following information elements:
    /// 1. SupportingInfrastructure
    /// 2. SystemAuditMechanism
    /// 3. SystemExplanationMechanims
    /// 4. SystemHumanOversightMechanism
    /// 5. SystemSecurityMechanism
    /// 6. Limitation
    /// 7. Risk
    /// 8. Bias
    /// 9. Tradeoff
    /// 10. HardLaw
    /// 11. SoftLaw^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SupportingInfrastructureSpecification">rains:SupportingInfrastructureSpecification</a>
    /// </summary>
    let SupportingInfrastructureSpecification =
        _prefixId.prefix "SupportingInfrastructureSpecification"

    /// <summary>
    ///   <para>rdfs:label : System Audit Mechanism^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :RealizableObjectCharacteristic detailing how :AI_System may be interrogated about its inner processes and outputs produced.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemAuditMechanism">rains:SystemAuditMechanism</a>
    /// </summary>
    let SystemAuditMechanism = _prefixId.prefix "SystemAuditMechanism"
    /// <summary>
    ///   <para>rdfs:label : System Deployment Guidance^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be deployed.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemDeploymentGuidance">rains:SystemDeploymentGuidance</a>
    /// </summary>
    let SystemDeploymentGuidance = _prefixId.prefix "SystemDeploymentGuidance"
    /// <summary>
    ///   <para>rdfs:label : System Deployment Guideline^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Guideline which represents the description of guidelines for the Deployment stage of the AI System.
    ///
    /// It is advisable that the information realization corresponding to the System Deployment Guideline variable contains the following information elements:
    /// Guidance.
    /// 1. SystemIntegrationGuidance
    /// 2. SystemDeploymentGuidance
    /// 3. SystemDocumentationGuidance^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemDeploymentGuideline">rains:SystemDeploymentGuideline</a>
    /// </summary>
    let SystemDeploymentGuideline = _prefixId.prefix "SystemDeploymentGuideline"
    /// <summary>
    ///   <para>rdfs:label : System Documentation Guidance^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be documented.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemDocumentationGuidance">rains:SystemDocumentationGuidance</a>
    /// </summary>
    let SystemDocumentationGuidance = _prefixId.prefix "SystemDocumentationGuidance"
    /// <summary>
    ///   <para>rdfs:label : System Explanation Mechanism^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :RealizableObjectCharacteristic detailing how :AI_System produces human readable clarifications and justifications of its inner processes and outputs produced.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemExplanationMechanism">rains:SystemExplanationMechanism</a>
    /// </summary>
    let SystemExplanationMechanism = _prefixId.prefix "SystemExplanationMechanism"
    /// <summary>
    ///   <para>rdfs:label : System Human Oversight Mechanism^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :RealizableObjectCharacteristic detailing how :AI_System integrates human operators in its decision processes to offer them the opportunity to stop, review, or alter the outputs produced by the system.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemHumanOversightMechanism">rains:SystemHumanOversightMechanism</a>
    /// </summary>
    let SystemHumanOversightMechanism = _prefixId.prefix "SystemHumanOversightMechanism"
    /// <summary>
    ///   <para>rdfs:label : System Integration Guidance^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be integrated with other systems or services.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemIntegrationGuidance">rains:SystemIntegrationGuidance</a>
    /// </summary>
    let SystemIntegrationGuidance = _prefixId.prefix "SystemIntegrationGuidance"
    /// <summary>
    ///   <para>rdfs:label : System Maintenance Guidance^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be maintained.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemMaintenanceGuidance">rains:SystemMaintenanceGuidance</a>
    /// </summary>
    let SystemMaintenanceGuidance = _prefixId.prefix "SystemMaintenanceGuidance"
    /// <summary>
    ///   <para>rdfs:label : System Operation Guideline^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Guideline which represents the description of guidelines for the Operation stage of the AI System.
    ///
    /// It is advisable that the information realization corresponding to the System Operation  Guideline variable contains the following information elements:
    /// Guidance.
    /// 1. SystemIntegrationGuidance
    /// 2. SystemUsageGuidance^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemOperationGuideline">rains:SystemOperationGuideline</a>
    /// </summary>
    let SystemOperationGuideline = _prefixId.prefix "SystemOperationGuideline"
    /// <summary>
    ///   <para>rdfs:label : System Purpose Specification^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of design specification which represents  the  description of the purpose(s) for which an AI system is designed and used for.
    ///
    /// It is advisable that the information realization corresponding to SystemPurposeSpecification contains the following information elements
    /// 1. IntendedUserGroup
    /// 2. IntendedUseCase
    /// 3. IncorrectUseCase^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemPurposeSpecification">rains:SystemPurposeSpecification</a>
    /// </summary>
    let SystemPurposeSpecification = _prefixId.prefix "SystemPurposeSpecification"
    /// <summary>
    ///   <para>rdfs:label : System Security Mechanism^^xsd:string</para>
    ///   <para>rdfs:comment : A type of :RealizableObjectCharacteristic detailing how :AI_System may be safeguarded against adversarial attacks or potential breaches of security.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemSecurityMechanism">rains:SystemSecurityMechanism</a>
    /// </summary>
    let SystemSecurityMechanism = _prefixId.prefix "SystemSecurityMechanism"
    /// <summary>
    ///   <para>rdfs:label : System Usage Guidance^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be used.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#SystemUsageGuidance">rains:SystemUsageGuidance</a>
    /// </summary>
    let SystemUsageGuidance = _prefixId.prefix "SystemUsageGuidance"
    /// <summary>
    ///   <para>rdfs:label : Third Party Evaluation^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of :Evaluation which represents an evaluation performed by a third party independent of the developers of the AI System.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ThirdPartyEvaluation">rains:ThirdPartyEvaluation</a>
    /// </summary>
    let ThirdPartyEvaluation = _prefixId.prefix "ThirdPartyEvaluation"
    /// <summary>
    ///   <para>rdfs:label : TradeOff^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement  which records a specific piece of  information detailing tradeoffs to mitigate possible undesired or dangerous outcomes caused by any aspects of :AI_Sytem.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#TradeOff">rains:TradeOff</a>
    /// </summary>
    let TradeOff = _prefixId.prefix "TradeOff"
    /// <summary>
    ///   <para>rdfs:label : Training Dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to train the ML Model. The other subsets are used to validate and evaluate the model.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#TrainingDataset">rains:TrainingDataset</a>
    /// </summary>
    let TrainingDataset = _prefixId.prefix "TrainingDataset"
    /// <summary>
    ///   <para>rdfs:label : Use Case^^xsd:string</para>
    ///   <para>rdfs:comment : A sao:InformationElement which records a specific piece of information detailing a situation in which any component of :AI_System or the system as whole could potentially be used.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#UseCase">rains:UseCase</a>
    /// </summary>
    let UseCase = _prefixId.prefix "UseCase"
    /// <summary>
    ///   <para>rdfs:label : Validation Dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to validate the ML Model. The dataset is typically used repeatedly during the hyperparameter tuning process. The other subsets are used to train and evaluate the model.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#ValidationDataset">rains:ValidationDataset</a>
    /// </summary>
    let ValidationDataset = _prefixId.prefix "ValidationDataset"
    /// <summary>
    ///   <para>rdfs:label : computedOnDecisionThreshold^^xsd:string</para>
    ///   <para>rdfs:comment : The decision threshold the metric that produced evaluation result was computed on. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#computedOnDecisionThreshold">rains:computedOnDecisionThreshold</a>
    /// </summary>
    let computedOnDecisionThreshold = _prefixId.prefix "computedOnDecisionThreshold"
    /// <summary>
    ///   <para>rdfs:label : computedOnSlice^^xsd:string</para>
    ///   <para>rdfs:comment : The description of slice that the metric which  produced evaluation result was computed on. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#computedOnSlice">rains:computedOnSlice</a>
    /// </summary>
    let computedOnSlice = _prefixId.prefix "computedOnSlice"
    /// <summary>
    ///   <para>rdfs:label : hasBase64Image^^xsd:string</para>
    ///   <para>rdfs:comment : A value indicating what an :InformationElement's base 64 image is in String format. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasBase64Image">rains:hasBase64Image</a>
    /// </summary>
    let hasBase64Image = _prefixId.prefix "hasBase64Image"
    /// <summary>
    ///   <para>rdfs:label : hasEvaluationResult^^xsd:string</para>
    ///   <para>rdfs:comment : A relation that links some evaluation measure to one or more results produced for this measure.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasEvaluationResult">rains:hasEvaluationResult</a>
    /// </summary>
    let hasEvaluationResult = _prefixId.prefix "hasEvaluationResult"
    /// <summary>
    ///   <para>rdfs:label : hasInputFormat^^xsd:string</para>
    ///   <para>rdfs:comment : A value describing the format of an input. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasInputFormat">rains:hasInputFormat</a>
    /// </summary>
    let hasInputFormat = _prefixId.prefix "hasInputFormat"
    /// <summary>
    ///   <para>rdfs:label : hasMitigationStrategy^^xsd:string</para>
    ///   <para>rdfs:comment : A value indicating what a :Risk's mitigation strategy is, expressed in String format. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasMitigationStrategy">rains:hasMitigationStrategy</a>
    /// </summary>
    let hasMitigationStrategy = _prefixId.prefix "hasMitigationStrategy"
    /// <summary>
    ///   <para>rdfs:label : hasOutputFormat^^xsd:string</para>
    ///   <para>rdfs:comment : A value describing the format of an output. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasOutputFormat">rains:hasOutputFormat</a>
    /// </summary>
    let hasOutputFormat = _prefixId.prefix "hasOutputFormat"

    /// <summary>
    ///   <para>rdfs:label : hasRealizableObjectCharacteristic^^xsd:string</para>
    ///   <para>rdfs:comment : A relation that links a realizable object (e.g., model) to the information element describing its characteristic.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasRealizableObjectCharacteristic">rains:hasRealizableObjectCharacteristic</a>
    /// </summary>
    let hasRealizableObjectCharacteristic =
        _prefixId.prefix "hasRealizableObjectCharacteristic"

    /// <summary>
    ///   <para>rdfs:label : hasResultLowerBound^^xsd:string</para>
    ///   <para>rdfs:comment : The lower bound of the confidence interval. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasResultLowerBound">rains:hasResultLowerBound</a>
    /// </summary>
    let hasResultLowerBound = _prefixId.prefix "hasResultLowerBound"
    /// <summary>
    ///   <para>rdfs:label : hasResultUpperBound^^xsd:string</para>
    ///   <para>rdfs:comment : The upper bound of the confidence interval.
    ///
    /// Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasResultUpperBound">rains:hasResultUpperBound</a>
    /// </summary>
    let hasResultUpperBound = _prefixId.prefix "hasResultUpperBound"
    /// <summary>
    ///   <para>rdfs:label : hasResultValue^^xsd:string</para>
    ///   <para>rdfs:comment : The description of the result value.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#hasResultValue">rains:hasResultValue</a>
    /// </summary>
    let hasResultValue = _prefixId.prefix "hasResultValue"

    /// <summary>
    ///   <para>rdfs:label : isCharacteristicOfRealizableObject^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of hasRealizableObjectCharacteristic^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#isCharacteristicOfRealizableObject">rains:isCharacteristicOfRealizableObject</a>
    /// </summary>
    let isCharacteristicOfRealizableObject =
        _prefixId.prefix "isCharacteristicOfRealizableObject"

    /// <summary>
    ///   <para>rdfs:label : isEvaluationResultOf^^xsd:string</para>
    ///   <para>rdfs:comment : A relation that links a result to some evaluation measure for which the result was produced.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#isEvaluationResultOf">rains:isEvaluationResultOf</a>
    /// </summary>
    let isEvaluationResultOf = _prefixId.prefix "isEvaluationResultOf"
    /// <summary>
    ///   <para>rdfs:label : isReusedObject^^xsd:string</para>
    ///   <para>rdfs:comment : A value indicating whether the :RealizableObject is a third party resource.^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#isReusedObject">rains:isReusedObject</a>
    /// </summary>
    let isReusedObject = _prefixId.prefix "isReusedObject"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment : A value indicating what a :RealizableObject's version is. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#version">rains:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>rdfs:label : versionDate^^xsd:string</para>
    ///   <para>rdfs:comment : A value indicating what the version date of a :RealizableObject's is. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#versionDate">rains:versionDate</a>
    /// </summary>
    let versionDate = _prefixId.prefix "versionDate"
    /// <summary>
    ///   <para>rdfs:label : versionNote^^xsd:string</para>
    ///   <para>rdfs:comment : A value describing a note about the version date of a :RealizableObject. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json^^xsd:string</para>
    ///   <a href="https://w3id.org/rains#versionNote">rains:versionNote</a>
    /// </summary>
    let versionNote = _prefixId.prefix "versionNote"
