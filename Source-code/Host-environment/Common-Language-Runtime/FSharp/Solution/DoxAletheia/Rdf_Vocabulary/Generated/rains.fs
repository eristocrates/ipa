namespace https.w3id.org.rains.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rains =
    let _namespace_iri = Namespace_Iri rains |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:rains#AI_System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The AI System for which the accountability plan is specified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AI System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#AI_System">https://w3id.org/rains#AI_System</seealso>
    let AI_System = Prefixed_Name(rains, "AI_System") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#ApprovalDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of a planned human decision representing approvals and sign offs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Approval Decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ApprovalDecision">https://w3id.org/rains#ApprovalDecision</seealso>
    let ApprovalDecision = Prefixed_Name(rains, "ApprovalDecision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#AutoConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned Constraint that describes a constraint which can be evaluated automatically against corresponding accountability trace. Such constraint would normally link to its implementation (e.g., a SHACL rule) using the  https://w3id.org/ep-plan#hasConstraintImplementation property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Auto Constraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#AutoConstraint">https://w3id.org/rains#AutoConstraint</seealso>
    let AutoConstraint = Prefixed_Name(rains, "AutoConstraint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Bias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :Risk  which records a specific piece of  information detailing a potential inclination or prejudice related to some aspects of :AI_Sytem (e.g., a training dataset containing more data about males when both genders will be considered by the ML model)
    ///
    /// If a mitigation strategy is used to abate the bias, then these can be indicated using the property :hasMitigationStrategy. It is advisable that information about the bias before and after mitigation is included."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bias"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Bias">https://w3id.org/rains#Bias</seealso>
    let Bias = Prefixed_Name(rains, "Bias") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformnationElement which records information describing a certificate (e.g. an ISO certificate) that is granted during the implementation (or deployment or use and maintenance) life cycle stages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Certificate">https://w3id.org/rains#Certificate</seealso>
    let Certificate = Prefixed_Name(rains, "Certificate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#CertificationDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of a planned human compliance assurance decision representing certification granting. This is usually done by third parties, but may also be done inhouse to prove that the AI System abides by internal policies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certification Decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#CertificationDecision">https://w3id.org/rains#CertificationDecision</seealso>
    let CertificationDecision =
        Prefixed_Name(rains, "CertificationDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ChangeJustification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformnationElement which records information describing the justification behind a deviation from the Design Specification. For example, the reason behind realizing a dataset other than the one indicated by the Dataset Design Specification was used, or why an evaluation measure was recorded which differed from the one indicated to be expected in an Evaluation Specification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Change Justification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ChangeJustification">https://w3id.org/rains#ChangeJustification</seealso>
    let ChangeJustification =
        Prefixed_Name(rains, "ChangeJustification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ChangeLog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned sao:AccountableResult that describes any change from a design specification or guideline. It is expected to be the result of any accountable action that has an input a design specification or a guideline.
    ///
    /// It is advisable that the information realization corresponding to the Evaluation contains the following information element ChangeJustification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Change Log"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ChangeLog">https://w3id.org/rains#ChangeLog</seealso>
    let ChangeLog = Prefixed_Name(rains, "ChangeLog") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ComplianceAssuranceDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of a planned human decision representing confirmation of compliance of some sao:AccountableResult (e.g., a model specification) with its compliance requirements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compliance Assurance Decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ComplianceAssuranceDecision">https://w3id.org/rains#ComplianceAssuranceDecision</seealso>
    let ComplianceAssuranceDecision =
        Prefixed_Name(rains, "ComplianceAssuranceDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ComplianceEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of sao:InformationElement which records a specific piece of  information about  a compliance requirement that is to be complied with as part of an information realization collection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compliance Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ComplianceEntity">https://w3id.org/rains#ComplianceEntity</seealso>
    let ComplianceEntity = Prefixed_Name(rains, "ComplianceEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ComplianceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of design specification  which represents the  description of a compliance requirement.
    ///
    /// It is advisable that the information realization corresponding to SystemPurposeSpecification contains the following information elements
    /// 1. HardLaw
    /// 2. SoftLaw"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compliance Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ComplianceSpecification">https://w3id.org/rains#ComplianceSpecification</seealso>
    let ComplianceSpecification =
        Prefixed_Name(rains, "ComplianceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DataCollectionProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of sao:InformationElement which records a specific piece of  information detailing how the data is collected. This includes the information about mechanism used for collecting data (e.g. hardware sensors, software program, or manually), the timeframe over which the data was collected, any consent reporting, etc.
    ///
    /// There is a separate concept that represents the data collection software see rainsDataCollectionSoftware."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Collection Procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DataCollectionProcedure">https://w3id.org/rains#DataCollectionProcedure</seealso>
    let DataCollectionProcedure =
        Prefixed_Name(rains, "DataCollectionProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DataCollectionSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software that was used to collect data that formed the dataset which was used to train the ML Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Collection Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DataCollectionSoftware">https://w3id.org/rains#DataCollectionSoftware</seealso>
    let DataCollectionSoftware =
        Prefixed_Name(rains, "DataCollectionSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DataPreprocessingProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of sao:InformationElement which records a specific piece of  information detailing how the data is preprocessed. This includes information on what is done to the data (e.g., cleaning, sampling, filtering, feature engineering, etc) and how it is done (e.g., manually, programmatically, or using feature engineering software).
    ///
    /// There is a separate concept that represents the data preprocessing software."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Preprocessing Procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DataPreprocessingProcedure">https://w3id.org/rains#DataPreprocessingProcedure</seealso>
    let DataPreprocessingProcedure =
        Prefixed_Name(rains, "DataPreprocessingProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DataPreprocessingSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software  that was used to preprocess the dataset using to train the ML Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Preprocessing Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DataPreprocessingSoftware">https://w3id.org/rains#DataPreprocessingSoftware</seealso>
    let DataPreprocessingSoftware =
        Prefixed_Name(rains, "DataPreprocessingSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DatasetComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned sao:AccountableResult  which represents the description of an realized dataset, including its characteristics, how it was collected, its risks, etc. The dataset component represents a collection of collected and pre-processed data. Once it is split, the subclasses TestingDataset, ValidationDataset, and EvaluationDataset can be used.
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
    /// 12. Algorithm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dataset Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DatasetComponent">https://w3id.org/rains#DatasetComponent</seealso>
    let DatasetComponent = Prefixed_Name(rains, "DatasetComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DatasetSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of design specification  which represents the description of planned requirements, characteristics, risks, etc. related to a dataset (e.g., a training dataset for ML model) expected to be used as part of the AI system life cycle.
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
    /// 12. Algorithm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dataset Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DatasetSpecification">https://w3id.org/rains#DatasetSpecification</seealso>
    let DatasetSpecification =
        Prefixed_Name(rains, "DatasetSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#Decide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step describing a decision to be taken by a human when incorporating accountability in AI Systems, e.g. approve the design of an ML Model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Decide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Decide">https://w3id.org/rains#Decide</seealso>
    let Decide = Prefixed_Name(rains, "Decide") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DesignSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned sao:AccountableResult which represents a high level reference to a specification  (e.g. a specification report) that is expected to be produced during the design stage in order to inform the future AI system lifecycle stages (e.g. implementation)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Design Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DesignSpecification">https://w3id.org/rains#DesignSpecification</seealso>
    let DesignSpecification =
        Prefixed_Name(rains, "DesignSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#DesignStageAccountabilityPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan that identifies sao:AccountableAction(s) and sao:AccountableResult(s) relevant to the design stage of an AI system and  which are required to be documented for accountability purposes. The Accountable Actions that can be done at this stage are: Produce Specification and Decide."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Design Stage Accountability Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#DesignStageAccountabilityPlan">https://w3id.org/rains#DesignStageAccountabilityPlan</seealso>
    let DesignStageAccountabilityPlan =
        Prefixed_Name(rains, "DesignStageAccountabilityPlan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#Evaluate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step describing an evaluation, i.e, testing  and producing evaluation metrics, that has some impact on the AI System, e.g. the evaluation of the ML model using a specified Dataset or the :AI_System undergoing a third party evaluation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Evaluate">https://w3id.org/rains#Evaluate</seealso>
    let Evaluate = Prefixed_Name(rains, "Evaluate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned sao:AccountableResult which represents a high level reference to testing at least one component and recording the results of the test(s) (e.g. testing the model with a specified dataset) that is expected to be produced during the implementation stage.
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
    /// 5. SystemUsageGuidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Evaluation">https://w3id.org/rains#Evaluation</seealso>
    let Evaluation = Prefixed_Name(rains, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#EvaluationDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to evaluate the ML Model. The other subsets are used to train and evaluate the model. This type can also represent a standalone dataset used to evaluate the model independent of the datasets used to train and validate it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluation Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#EvaluationDataset">https://w3id.org/rains#EvaluationDataset</seealso>
    let EvaluationDataset = Prefixed_Name(rains, "EvaluationDataset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#EvaluationMeassure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A  sao:InformationElement which records a specific piece of  information detailing some measure used as part of an evaluation process. This is broader than mls:EvaluationMeassure which describes a measure related to a model performance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluation Measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#EvaluationMeassure">https://w3id.org/rains#EvaluationMeassure</seealso>
    let EvaluationMeassure = Prefixed_Name(rains, "EvaluationMeassure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#EvaluationProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records a specific piece of  information detailing procedure by which some aspects of an :AI_Sytem were evaluated. This is broader than mls:EvaluationProcedure which relates to model evaluation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluation Procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#EvaluationProcedure">https://w3id.org/rains#EvaluationProcedure</seealso>
    let EvaluationProcedure =
        Prefixed_Name(rains, "EvaluationProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#EvaluationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A  sao:InformationElement which records a specific piece of  information detailing the result of an evaluation process. This is broader than mls:EvaluationMeassure which describes a result related to a specific model evaluation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluation Result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#EvaluationResult">https://w3id.org/rains#EvaluationResult</seealso>
    let EvaluationResult = Prefixed_Name(rains, "EvaluationResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#EvaluationSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of design specification which represents the description  of a planned evaluation process.
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
    /// 5. SystemUsageGuidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evaluation Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#EvaluationSpecification">https://w3id.org/rains#EvaluationSpecification</seealso>
    let EvaluationSpecification =
        Prefixed_Name(rains, "EvaluationSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ExcludedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement which records information detailing a piece of data, software or hardware that should have been realized but was not.
    ///
    /// For example, assume the dataset design specification specifies that dataset foorbar is to be realised (to be used to train the model), but the implementation team realises dataset xyzzy instead. In this case, the dataset foobar should be indicated by the implementation team as an Excluded Object - whereas the dataset xyzzy should be created as an instance of :RealizedObject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Excluded Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ExcludedObject">https://w3id.org/rains#ExcludedObject</seealso>
    let ExcludedObject = Prefixed_Name(rains, "ExcludedObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#FairnessOrBiasDetectionSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software that was used to detect bias or check for fairness in both the dataset which was used to train the ML Model as well as the ML model itself"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fairness Or Bias Detection Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#FairnessOrBiasDetectionSoftware">https://w3id.org/rains#FairnessOrBiasDetectionSoftware</seealso>
    let FairnessOrBiasDetectionSoftware =
        Prefixed_Name(rains, "FairnessOrBiasDetectionSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#FitnessConfirmationDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned human decision representing confirmation of fitness of some sao:AccountableResult t to its purpose."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fitness Confirmation Decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#FitnessConfirmationDecision">https://w3id.org/rains#FitnessConfirmationDecision</seealso>
    let FitnessConfirmationDecision =
        Prefixed_Name(rains, "FitnessConfirmationDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#Funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records a specific piece of  information detailing a funding source."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Funding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Funding">https://w3id.org/rains#Funding</seealso>
    let Funding = Prefixed_Name(rains, "Funding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#GenerateGuideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step describing the creation of a guideline that has some impact on the AI System, e.g. the production of the deployment guideline describing how the AI System is to be deployed on-site or the production of the maintenance guideline describing how the AI System is to be maintained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Generate Guideline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#GenerateGuideline">https://w3id.org/rains#GenerateGuideline</seealso>
    let GenerateGuideline = Prefixed_Name(rains, "GenerateGuideline") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#GrantCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step describing a certification granting decision to be taken by a human when incorporating accountability in AI Systems, e.g. grant an ISO certificate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Grant Certification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#GrantCertification">https://w3id.org/rains#GrantCertification</seealso>
    let GrantCertification = Prefixed_Name(rains, "GrantCertification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Guidance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records a specific piece of  information detailing instructions that should be followed during the deployment or operation stage of the :AI_System lifecycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Guidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Guidance">https://w3id.org/rains#Guidance</seealso>
    let Guidance = Prefixed_Name(rains, "Guidance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Guideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned sao:AccountableResult which represents a high level reference to a guideline (e.g. a guideline document) that is expected to be produced during the implementation in order to inform on the correct procedure for deploying, using and maintaining the system or any of its components."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Guideline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Guideline">https://w3id.org/rains#Guideline</seealso>
    let Guideline = Prefixed_Name(rains, "Guideline") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#HardLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of compliance entity which records a specific piece of  information about the laws and regulations that must be, or are, complied with as part of an information realization collection.
    ///
    /// When used as part of an information realization corresponding to a design specification, it describes the hard laws that must be complied with. When used as part of an information realization corresponding to an realized component, it describes the hard laws that the component complies with."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hard Law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#HardLaw">https://w3id.org/rains#HardLaw</seealso>
    let HardLaw = Prefixed_Name(rains, "HardLaw") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#HumanConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned ep-plan:Constraint that describes some constraint which cannot be evaluated automatically against the accountability trace. This can be, for example, because the constraint is too high level or difficult to express as a rule. Such constraint would be typically expected to be evaluated manually by a human."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Human Constraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#HumanConstraint">https://w3id.org/rains#HumanConstraint</seealso>
    let HumanConstraint = Prefixed_Name(rains, "HumanConstraint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#HumanDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of a planned sao:AccountableResult which represents a decision made by a human."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Human Decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#HumanDecision">https://w3id.org/rains#HumanDecision</seealso>
    let HumanDecision = Prefixed_Name(rains, "HumanDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ImplementationStageAccountabilityPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan that identifies sao:AccountableAction(s) and sao:AccountableResult(s) relevant to the implementation stage of an AI system and  which are required to be documented for accountability purposes. The Accountable Actions that can be done at this stage are: Realize Component, Merge and Split Dataset, Evaluate, Generate Guideline, Grant Certification, and Decide."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Implementation Stage Accountability Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ImplementationStageAccountabilityPlan">https://w3id.org/rains#ImplementationStageAccountabilityPlan</seealso>
    let ImplementationStageAccountabilityPlan =
        Prefixed_Name(rains, "ImplementationStageAccountabilityPlan") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#IncorrectUseCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :UseCase detailing a situation in which any component of :AI_System or the system as whole should not be used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Incorrect Use Case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#IncorrectUseCase">https://w3id.org/rains#IncorrectUseCase</seealso>
    let IncorrectUseCase = Prefixed_Name(rains, "IncorrectUseCase") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#IntendedUseCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :UseCase detailing a situation in which any component of :AI_System or the system as whole is expected to be used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Intended Use Case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#IntendedUseCase">https://w3id.org/rains#IntendedUseCase</seealso>
    let IntendedUseCase = Prefixed_Name(rains, "IntendedUseCase") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#IntendedUserGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records a specific piece of  information detailing the target user audience for the functionality of the overall :AI_System or the components used to develop such system (e.g., a reused public training dataset or a model would be associated with this information)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Intended User Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#IntendedUserGroup">https://w3id.org/rains#IntendedUserGroup</seealso>
    let IntendedUserGroup = Prefixed_Name(rains, "IntendedUserGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Limitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records a specific piece of  information detailing the limitations of any aspect related to an :AI_System including the system as whole, its components (e.g., ML model),  or associated processes (e.g., evaluation)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Limitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Limitation">https://w3id.org/rains#Limitation</seealso>
    let Limitation = Prefixed_Name(rains, "Limitation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#MergeAndSplitDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step that has some impact on the AI System where the dataset(s) used to produce the ML Model are merged and/or split. Merging takes place when there is more than one dataset in use. Typically, splitting results in three subsets: Training, Validation, and Testing. This step is typically part of the Implementation stage of an AI System's life cycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Merge and Split Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#MergeAndSplitDataset">https://w3id.org/rains#MergeAndSplitDataset</seealso>
    let MergeAndSplitDataset =
        Prefixed_Name(rains, "MergeAndSplitDataset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ModelComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned sao:AccountableResult which represents the description of a realized ML Model, including it characteristics, performance, etc.
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
    /// 9. SystemUsageGuidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Model Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ModelComponent">https://w3id.org/rains#ModelComponent</seealso>
    let ModelComponent = Prefixed_Name(rains, "ModelComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#ModelSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of design specification  which represents the description of planned requirements, characteristics, performance, etc. related to an AI model.
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
    /// 9. SystemUsageGuidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Model Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ModelSpecification">https://w3id.org/rains#ModelSpecification</seealso>
    let ModelSpecification = Prefixed_Name(rains, "ModelSpecification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A  sao:InformationElement which records a specific piece of  information describing a model's parameter. This is broader than mls:HyperParameter which describes only a hyperparameter of a model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Parameter">https://w3id.org/rains#Parameter</seealso>
    let Parameter = Prefixed_Name(rains, "Parameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ProduceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step describing the creation of a specification that has some impact on the AI System, e.g. the production of the design specification describing the training dataset to be used. This step is typically part of the Design stage of an AI System's life cycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Produce Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ProduceSpecification">https://w3id.org/rains#ProduceSpecification</seealso>
    let ProduceSpecification =
        Prefixed_Name(rains, "ProduceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#RealizableObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records  information detailing  a piece of data, software or hardware that may be realized during the Implementation stage. A reused object (e.g., public training datasets) is also considered as :RealizableObject during the Design stage as it is not yet implemented (i.e., physical copies have not yet been integrated withing the ML pipeline)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Realizable Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#RealizableObject">https://w3id.org/rains#RealizableObject</seealso>
    let RealizableObject = Prefixed_Name(rains, "RealizableObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#RealizableObjectCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records  information detailing  a specific quality of :RealizableObject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Realizable Object Characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#RealizableObjectCharacteristic">https://w3id.org/rains#RealizableObjectCharacteristic</seealso>
    let RealizableObjectCharacteristic =
        Prefixed_Name(rains, "RealizableObjectCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#RealizeComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planned step describing the realization of a component. This includes implementing a component or retrieving it from a different (or third party) source. The realization of the component has some impact on the AI System, e.g. the implementation of the ML model or importing a third party dataset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Realize Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#RealizeComponent">https://w3id.org/rains#RealizeComponent</seealso>
    let RealizeComponent = Prefixed_Name(rains, "RealizeComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#RealizededObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement which records information detailing a piece of data, software or hardware that was realized - whether or not it followed a design specification or a guideline.
    ///
    /// For example, assume the dataset design specification specifies that dataset foorbar is to be realised (to be used to train the model), but the implementation team realises dataset xyzzy. In this case, only dataset xyzzy is created as an instance of Realized Object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Realized Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#RealizededObject">https://w3id.org/rains#RealizededObject</seealso>
    let RealizededObject = Prefixed_Name(rains, "RealizededObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#Risk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records a specific piece of  information detailing possible undesired or dangerous outcomes caused by any aspects of :AI_Sytem.
    ///
    /// If a mitigation strategy is used to abate the risk, then these can be indicated using the property :hasMitigationStrategy. It is advisable that information about the risk before and after mitigation is included."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#Risk">https://w3id.org/rains#Risk</seealso>
    let Risk = Prefixed_Name(rains, "Risk") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#SoftLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of compliance entity which records a specific piece of  information about the procedures, standards, protocols, etc that complying with is desired or encouraged as part of an information realization collection.
    ///
    /// When used as part of an information realization corresponding to a design specification, it describes the soft laws that are to be complied with. When used as part of an information realization corresponding to an realized component, it describes the soft laws that the component complies with."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soft Law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SoftLaw">https://w3id.org/rains#SoftLaw</seealso>
    let SoftLaw = Prefixed_Name(rains, "SoftLaw") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SupportingInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :RealizableObject detailing the hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in :AI_System."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supporting Infrastructure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SupportingInfrastructure">https://w3id.org/rains#SupportingInfrastructure</seealso>
    let SupportingInfrastructure =
        Prefixed_Name(rains, "SupportingInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SupportingInfrastructureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of planned sao:AccountableResult which represents the characteristics, performance, etc. related to all the implemented hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in AI systems.
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
    /// 11. SoftLaw"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supporting Infrastructure Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SupportingInfrastructureComponent">https://w3id.org/rains#SupportingInfrastructureComponent</seealso>
    let SupportingInfrastructureComponent =
        Prefixed_Name(rains, "SupportingInfrastructureComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SupportingInfrastructureSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of design specification which represents the specification description of planned requirements, characteristics, performance, etc. related to all the hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in AI systems.
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
    /// 11. SoftLaw"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supporting Infrastructure Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SupportingInfrastructureSpecification">https://w3id.org/rains#SupportingInfrastructureSpecification</seealso>
    let SupportingInfrastructureSpecification =
        Prefixed_Name(rains, "SupportingInfrastructureSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemAuditMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :RealizableObjectCharacteristic detailing how :AI_System may be interrogated about its inner processes and outputs produced."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Audit Mechanism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemAuditMechanism">https://w3id.org/rains#SystemAuditMechanism</seealso>
    let SystemAuditMechanism =
        Prefixed_Name(rains, "SystemAuditMechanism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemDeploymentGuidance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be deployed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Deployment Guidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemDeploymentGuidance">https://w3id.org/rains#SystemDeploymentGuidance</seealso>
    let SystemDeploymentGuidance =
        Prefixed_Name(rains, "SystemDeploymentGuidance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemDeploymentGuideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Guideline which represents the description of guidelines for the Deployment stage of the AI System.
    ///
    /// It is advisable that the information realization corresponding to the System Deployment Guideline variable contains the following information elements:
    /// Guidance.
    /// 1. SystemIntegrationGuidance
    /// 2. SystemDeploymentGuidance
    /// 3. SystemDocumentationGuidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Deployment Guideline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemDeploymentGuideline">https://w3id.org/rains#SystemDeploymentGuideline</seealso>
    let SystemDeploymentGuideline =
        Prefixed_Name(rains, "SystemDeploymentGuideline") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemDocumentationGuidance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be documented."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Documentation Guidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemDocumentationGuidance">https://w3id.org/rains#SystemDocumentationGuidance</seealso>
    let SystemDocumentationGuidance =
        Prefixed_Name(rains, "SystemDocumentationGuidance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemExplanationMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :RealizableObjectCharacteristic detailing how :AI_System produces human readable clarifications and justifications of its inner processes and outputs produced."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Explanation Mechanism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemExplanationMechanism">https://w3id.org/rains#SystemExplanationMechanism</seealso>
    let SystemExplanationMechanism =
        Prefixed_Name(rains, "SystemExplanationMechanism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemHumanOversightMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :RealizableObjectCharacteristic detailing how :AI_System integrates human operators in its decision processes to offer them the opportunity to stop, review, or alter the outputs produced by the system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Human Oversight Mechanism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemHumanOversightMechanism">https://w3id.org/rains#SystemHumanOversightMechanism</seealso>
    let SystemHumanOversightMechanism =
        Prefixed_Name(rains, "SystemHumanOversightMechanism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemIntegrationGuidance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be integrated with other systems or services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Integration Guidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemIntegrationGuidance">https://w3id.org/rains#SystemIntegrationGuidance</seealso>
    let SystemIntegrationGuidance =
        Prefixed_Name(rains, "SystemIntegrationGuidance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemMaintenanceGuidance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be maintained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Maintenance Guidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemMaintenanceGuidance">https://w3id.org/rains#SystemMaintenanceGuidance</seealso>
    let SystemMaintenanceGuidance =
        Prefixed_Name(rains, "SystemMaintenanceGuidance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemOperationGuideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Guideline which represents the description of guidelines for the Operation stage of the AI System.
    ///
    /// It is advisable that the information realization corresponding to the System Operation  Guideline variable contains the following information elements:
    /// Guidance.
    /// 1. SystemIntegrationGuidance
    /// 2. SystemUsageGuidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Operation Guideline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemOperationGuideline">https://w3id.org/rains#SystemOperationGuideline</seealso>
    let SystemOperationGuideline =
        Prefixed_Name(rains, "SystemOperationGuideline") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemPurposeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of design specification which represents  the  description of the purpose(s) for which an AI system is designed and used for.
    ///
    /// It is advisable that the information realization corresponding to SystemPurposeSpecification contains the following information elements
    /// 1. IntendedUserGroup
    /// 2. IntendedUseCase
    /// 3. IncorrectUseCase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Purpose Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemPurposeSpecification">https://w3id.org/rains#SystemPurposeSpecification</seealso>
    let SystemPurposeSpecification =
        Prefixed_Name(rains, "SystemPurposeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemSecurityMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of :RealizableObjectCharacteristic detailing how :AI_System may be safeguarded against adversarial attacks or potential breaches of security."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Security Mechanism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemSecurityMechanism">https://w3id.org/rains#SystemSecurityMechanism</seealso>
    let SystemSecurityMechanism =
        Prefixed_Name(rains, "SystemSecurityMechanism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#SystemUsageGuidance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Usage Guidance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#SystemUsageGuidance">https://w3id.org/rains#SystemUsageGuidance</seealso>
    let SystemUsageGuidance =
        Prefixed_Name(rains, "SystemUsageGuidance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#ThirdPartyEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of :Evaluation which represents an evaluation performed by a third party independent of the developers of the AI System."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Third Party Evaluation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ThirdPartyEvaluation">https://w3id.org/rains#ThirdPartyEvaluation</seealso>
    let ThirdPartyEvaluation =
        Prefixed_Name(rains, "ThirdPartyEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#TradeOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement  which records a specific piece of  information detailing tradeoffs to mitigate possible undesired or dangerous outcomes caused by any aspects of :AI_Sytem."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TradeOff"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#TradeOff">https://w3id.org/rains#TradeOff</seealso>
    let TradeOff = Prefixed_Name(rains, "TradeOff") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#TrainingDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to train the ML Model. The other subsets are used to validate and evaluate the model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Training Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#TrainingDataset">https://w3id.org/rains#TrainingDataset</seealso>
    let TrainingDataset = Prefixed_Name(rains, "TrainingDataset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#UseCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sao:InformationElement which records a specific piece of information detailing a situation in which any component of :AI_System or the system as whole could potentially be used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Use Case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#UseCase">https://w3id.org/rains#UseCase</seealso>
    let UseCase = Prefixed_Name(rains, "UseCase") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#ValidationDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to validate the ML Model. The dataset is typically used repeatedly during the hyperparameter tuning process. The other subsets are used to train and evaluate the model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Validation Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#ValidationDataset">https://w3id.org/rains#ValidationDataset</seealso>
    let ValidationDataset = Prefixed_Name(rains, "ValidationDataset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#computedOnDecisionThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The decision threshold the metric that produced evaluation result was computed on. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"computedOnDecisionThreshold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#computedOnDecisionThreshold">https://w3id.org/rains#computedOnDecisionThreshold</seealso>
    let computedOnDecisionThreshold =
        Prefixed_Name(rains, "computedOnDecisionThreshold") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#computedOnSlice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The description of slice that the metric which  produced evaluation result was computed on. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"computedOnSlice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#computedOnSlice">https://w3id.org/rains#computedOnSlice</seealso>
    let computedOnSlice = Prefixed_Name(rains, "computedOnSlice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#hasBase64Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value indicating what an :InformationElement's base 64 image is in String format. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasBase64Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasBase64Image">https://w3id.org/rains#hasBase64Image</seealso>
    let hasBase64Image = Prefixed_Name(rains, "hasBase64Image") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasEvaluationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation that links some evaluation measure to one or more results produced for this measure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasEvaluationResult"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasEvaluationResult">https://w3id.org/rains#hasEvaluationResult</seealso>
    let hasEvaluationResult =
        Prefixed_Name(rains, "hasEvaluationResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasInputFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value describing the format of an input. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasInputFormat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasInputFormat">https://w3id.org/rains#hasInputFormat</seealso>
    let hasInputFormat = Prefixed_Name(rains, "hasInputFormat") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasMitigationStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value indicating what a :Risk's mitigation strategy is, expressed in String format. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMitigationStrategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasMitigationStrategy">https://w3id.org/rains#hasMitigationStrategy</seealso>
    let hasMitigationStrategy =
        Prefixed_Name(rains, "hasMitigationStrategy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasOutputFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value describing the format of an output. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasOutputFormat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasOutputFormat">https://w3id.org/rains#hasOutputFormat</seealso>
    let hasOutputFormat = Prefixed_Name(rains, "hasOutputFormat") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasRealizableObjectCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation that links a realizable object (e.g., model) to the information element describing its characteristic."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasRealizableObjectCharacteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasRealizableObjectCharacteristic">https://w3id.org/rains#hasRealizableObjectCharacteristic</seealso>
    let hasRealizableObjectCharacteristic =
        Prefixed_Name(rains, "hasRealizableObjectCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasResultLowerBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The lower bound of the confidence interval. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasResultLowerBound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasResultLowerBound">https://w3id.org/rains#hasResultLowerBound</seealso>
    let hasResultLowerBound =
        Prefixed_Name(rains, "hasResultLowerBound") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasResultUpperBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The upper bound of the confidence interval.
    ///
    /// Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasResultUpperBound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasResultUpperBound">https://w3id.org/rains#hasResultUpperBound</seealso>
    let hasResultUpperBound =
        Prefixed_Name(rains, "hasResultUpperBound") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#hasResultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The description of the result value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasResultValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#hasResultValue">https://w3id.org/rains#hasResultValue</seealso>
    let hasResultValue = Prefixed_Name(rains, "hasResultValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#isCharacteristicOfRealizableObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of hasRealizableObjectCharacteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isCharacteristicOfRealizableObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#isCharacteristicOfRealizableObject">https://w3id.org/rains#isCharacteristicOfRealizableObject</seealso>
    let isCharacteristicOfRealizableObject =
        Prefixed_Name(rains, "isCharacteristicOfRealizableObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#isEvaluationResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation that links a result to some evaluation measure for which the result was produced."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isEvaluationResultOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#isEvaluationResultOf">https://w3id.org/rains#isEvaluationResultOf</seealso>
    let isEvaluationResultOf =
        Prefixed_Name(rains, "isEvaluationResultOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:rains#isReusedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A value indicating whether the :RealizableObject is a third party resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isReusedObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#isReusedObject">https://w3id.org/rains#isReusedObject</seealso>
    let isReusedObject = Prefixed_Name(rains, "isReusedObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A value indicating what a :RealizableObject's version is. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#version">https://w3id.org/rains#version</seealso>
    let version = Prefixed_Name(rains, "version") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#versionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value indicating what the version date of a :RealizableObject's is. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"versionDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#versionDate">https://w3id.org/rains#versionDate</seealso>
    let versionDate = Prefixed_Name(rains, "versionDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:rains#versionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value describing a note about the version date of a :RealizableObject. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"versionNote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/rains#versionNote">https://w3id.org/rains#versionNote</seealso>
    let versionNote = Prefixed_Name(rains, "versionNote") |> PrefixedName
