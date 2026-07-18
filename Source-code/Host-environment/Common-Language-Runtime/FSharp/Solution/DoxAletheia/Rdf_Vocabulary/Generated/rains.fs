namespace https.w3id.org.rains.hash

open DoxAletheia.Rdf_Vocabulary

module rains =
    let _namespace_name = "https://w3id.org/rains#"

    /// <summary>
    /// A specific type of a planned human decision representing approvals and sign offs.
    /// <see href="https://w3id.org/rains#ApprovalDecision"></see></summary>
    let ApprovalDecision =
        Namespaced_IRI.parse _namespace_name "ApprovalDecision" |> NamespacedName

    /// <summary>
    /// A specific type of a planned human decision representing confirmation of compliance of some sao:AccountableResult (e.g., a model specification) with its compliance requirements.
    /// <see href="https://w3id.org/rains#ComplianceAssuranceDecision"></see></summary>
    let ComplianceAssuranceDecision =
        Namespaced_IRI.parse _namespace_name "ComplianceAssuranceDecision" |> NamespacedName

    /// <summary>
    /// A specific type of planned human decision representing confirmation of fitness of some sao:AccountableResult t to its purpose.
    /// <see href="https://w3id.org/rains#FitnessConfirmationDecision"></see></summary>
    let FitnessConfirmationDecision =
        Namespaced_IRI.parse _namespace_name "FitnessConfirmationDecision" |> NamespacedName

    /// <summary>
    /// A type of :RealizableObjectCharacteristic detailing how :AI_System may be interrogated about its inner processes and outputs produced.
    /// <see href="https://w3id.org/rains#SystemAuditMechanism"></see></summary>
    let SystemAuditMechanism =
        Namespaced_IRI.parse _namespace_name "SystemAuditMechanism" |> NamespacedName

    /// <summary>
    /// A type of :RealizableObjectCharacteristic detailing how :AI_System produces human readable clarifications and justifications of its inner processes and outputs produced.
    /// <see href="https://w3id.org/rains#SystemExplanationMechanism"></see></summary>
    let SystemExplanationMechanism =
        Namespaced_IRI.parse _namespace_name "SystemExplanationMechanism" |> NamespacedName

    /// <summary>
    /// A type of :RealizableObjectCharacteristic detailing how :AI_System integrates human operators in its decision processes to offer them the opportunity to stop, review, or alter the outputs produced by the system.
    /// <see href="https://w3id.org/rains#SystemHumanOversightMechanism"></see></summary>
    let SystemHumanOversightMechanism =
        Namespaced_IRI.parse _namespace_name "SystemHumanOversightMechanism" |> NamespacedName

    /// <summary>
    /// A type of :RealizableObjectCharacteristic detailing how :AI_System may be safeguarded against adversarial attacks or potential breaches of security.
    /// <see href="https://w3id.org/rains#SystemSecurityMechanism"></see></summary>
    let SystemSecurityMechanism =
        Namespaced_IRI.parse _namespace_name "SystemSecurityMechanism" |> NamespacedName

    /// <summary>
    /// A type of :RealizableObject detailing the hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in :AI_System.
    /// <see href="https://w3id.org/rains#SupportingInfrastructure"></see></summary>
    let SupportingInfrastructure =
        Namespaced_IRI.parse _namespace_name "SupportingInfrastructure" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records  information detailing  a specific quality of :RealizableObject.
    /// <see href="https://w3id.org/rains#RealizableObjectCharacteristic"></see></summary>
    let RealizableObjectCharacteristic =
        Namespaced_IRI.parse _namespace_name "RealizableObjectCharacteristic" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement which records information detailing a piece of data, software or hardware that should have been realized but was not.
    ///
    /// For example, assume the dataset design specification specifies that dataset foorbar is to be realised (to be used to train the model), but the implementation team realises dataset xyzzy instead. In this case, the dataset foobar should be indicated by the implementation team as an Excluded Object - whereas the dataset xyzzy should be created as an instance of :RealizedObject.
    /// <see href="https://w3id.org/rains#ExcludedObject"></see></summary>
    let ExcludedObject =
        Namespaced_IRI.parse _namespace_name "ExcludedObject" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement which records information detailing a piece of data, software or hardware that was realized - whether or not it followed a design specification or a guideline.
    ///
    /// For example, assume the dataset design specification specifies that dataset foorbar is to be realised (to be used to train the model), but the implementation team realises dataset xyzzy. In this case, only dataset xyzzy is created as an instance of Realized Object.
    /// <see href="https://w3id.org/rains#RealizededObject"></see></summary>
    let RealizededObject =
        Namespaced_IRI.parse _namespace_name "RealizededObject" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records  information detailing  a piece of data, software or hardware that may be realized during the Implementation stage. A reused object (e.g., public training datasets) is also considered as :RealizableObject during the Design stage as it is not yet implemented (i.e., physical copies have not yet been integrated withing the ML pipeline)
    /// <see href="https://w3id.org/rains#RealizableObject"></see></summary>
    let RealizableObject =
        Namespaced_IRI.parse _namespace_name "RealizableObject" |> NamespacedName

    /// <summary>
    /// A  sao:InformationElement which records a specific piece of  information detailing some measure used as part of an evaluation process. This is broader than mls:EvaluationMeassure which describes a measure related to a model performance.
    /// <see href="https://w3id.org/rains#EvaluationMeassure"></see></summary>
    let EvaluationMeassure =
        Namespaced_IRI.parse _namespace_name "EvaluationMeassure" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records a specific piece of  information detailing procedure by which some aspects of an :AI_Sytem were evaluated. This is broader than mls:EvaluationProcedure which relates to model evaluation.
    /// <see href="https://w3id.org/rains#EvaluationProcedure"></see></summary>
    let EvaluationProcedure =
        Namespaced_IRI.parse _namespace_name "EvaluationProcedure" |> NamespacedName

    /// <summary>
    /// A  sao:InformationElement which records a specific piece of  information describing a model's parameter. This is broader than mls:HyperParameter which describes only a hyperparameter of a model.
    /// <see href="https://w3id.org/rains#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName

    /// <summary>
    /// A  sao:InformationElement which records a specific piece of  information detailing the result of an evaluation process. This is broader than mls:EvaluationMeassure which describes a result related to a specific model evaluation.
    /// <see href="https://w3id.org/rains#EvaluationResult"></see></summary>
    let EvaluationResult =
        Namespaced_IRI.parse _namespace_name "EvaluationResult" |> NamespacedName

    /// <summary>
    /// The AI System for which the accountability plan is specified.
    /// <see href="https://w3id.org/rains#AI_System"></see></summary>
    let AI_System = Namespaced_IRI.parse _namespace_name "AI_System" |> NamespacedName

    /// <summary>
    /// A plan that identifies sao:AccountableAction(s) and sao:AccountableResult(s) relevant to the design stage of an AI system and  which are required to be documented for accountability purposes. The Accountable Actions that can be done at this stage are: Produce Specification and Decide.
    /// <see href="https://w3id.org/rains#DesignStageAccountabilityPlan"></see></summary>
    let DesignStageAccountabilityPlan =
        Namespaced_IRI.parse _namespace_name "DesignStageAccountabilityPlan" |> NamespacedName

    /// <summary>
    /// A plan that identifies sao:AccountableAction(s) and sao:AccountableResult(s) relevant to the implementation stage of an AI system and  which are required to be documented for accountability purposes. The Accountable Actions that can be done at this stage are: Realize Component, Merge and Split Dataset, Evaluate, Generate Guideline, Grant Certification, and Decide.
    /// <see href="https://w3id.org/rains#ImplementationStageAccountabilityPlan"></see></summary>
    let ImplementationStageAccountabilityPlan =
        Namespaced_IRI.parse _namespace_name "ImplementationStageAccountabilityPlan" |> NamespacedName

    /// <summary>
    /// A planned step describing a decision to be taken by a human when incorporating accountability in AI Systems, e.g. approve the design of an ML Model.
    /// <see href="https://w3id.org/rains#Decide"></see></summary>
    let Decide = Namespaced_IRI.parse _namespace_name "Decide" |> NamespacedName

    /// <summary>
    /// A specific type of a planned sao:AccountableResult which represents a decision made by a human.
    /// <see href="https://w3id.org/rains#HumanDecision"></see></summary>
    let HumanDecision =
        Namespaced_IRI.parse _namespace_name "HumanDecision" |> NamespacedName

    /// <summary>
    /// A specific type of planned Constraint that describes a constraint which can be evaluated automatically against corresponding accountability trace. Such constraint would normally link to its implementation (e.g., a SHACL rule) using the  https://w3id.org/ep-plan#hasConstraintImplementation property.
    /// <see href="https://w3id.org/rains#AutoConstraint"></see></summary>
    let AutoConstraint =
        Namespaced_IRI.parse _namespace_name "AutoConstraint" |> NamespacedName

    /// <summary>
    /// A specific type of planned ep-plan:Constraint that describes some constraint which cannot be evaluated automatically against the accountability trace. This can be, for example, because the constraint is too high level or difficult to express as a rule. Such constraint would be typically expected to be evaluated manually by a human.
    /// <see href="https://w3id.org/rains#HumanConstraint"></see></summary>
    let HumanConstraint =
        Namespaced_IRI.parse _namespace_name "HumanConstraint" |> NamespacedName

    /// <summary>
    /// A type of :Risk  which records a specific piece of  information detailing a potential inclination or prejudice related to some aspects of :AI_Sytem (e.g., a training dataset containing more data about males when both genders will be considered by the ML model)
    ///
    /// If a mitigation strategy is used to abate the bias, then these can be indicated using the property :hasMitigationStrategy. It is advisable that information about the bias before and after mitigation is included.
    /// <see href="https://w3id.org/rains#Bias"></see></summary>
    let Bias = Namespaced_IRI.parse _namespace_name "Bias" |> NamespacedName
    /// <summary>
    /// A sao:InformationElement  which records a specific piece of  information detailing possible undesired or dangerous outcomes caused by any aspects of :AI_Sytem.
    ///
    /// If a mitigation strategy is used to abate the risk, then these can be indicated using the property :hasMitigationStrategy. It is advisable that information about the risk before and after mitigation is included.
    /// <see href="https://w3id.org/rains#Risk"></see></summary>
    let Risk = Namespaced_IRI.parse _namespace_name "Risk" |> NamespacedName

    /// <summary>
    /// A sao:InformnationElement which records information describing a certificate (e.g. an ISO certificate) that is granted during the implementation (or deployment or use and maintenance) life cycle stages.
    /// <see href="https://w3id.org/rains#Certificate"></see></summary>
    let Certificate =
        Namespaced_IRI.parse _namespace_name "Certificate" |> NamespacedName

    /// <summary>
    /// A specific type of a planned human compliance assurance decision representing certification granting. This is usually done by third parties, but may also be done inhouse to prove that the AI System abides by internal policies.
    /// <see href="https://w3id.org/rains#CertificationDecision"></see></summary>
    let CertificationDecision =
        Namespaced_IRI.parse _namespace_name "CertificationDecision" |> NamespacedName

    /// <summary>
    /// A sao:InformnationElement which records information describing the justification behind a deviation from the Design Specification. For example, the reason behind realizing a dataset other than the one indicated by the Dataset Design Specification was used, or why an evaluation measure was recorded which differed from the one indicated to be expected in an Evaluation Specification.
    /// <see href="https://w3id.org/rains#ChangeJustification"></see></summary>
    let ChangeJustification =
        Namespaced_IRI.parse _namespace_name "ChangeJustification" |> NamespacedName

    /// <summary>
    /// A specific type of planned sao:AccountableResult that describes any change from a design specification or guideline. It is expected to be the result of any accountable action that has an input a design specification or a guideline.
    ///
    /// It is advisable that the information realization corresponding to the Evaluation contains the following information element ChangeJustification.
    /// <see href="https://w3id.org/rains#ChangeLog"></see></summary>
    let ChangeLog = Namespaced_IRI.parse _namespace_name "ChangeLog" |> NamespacedName
    /// <summary>
    /// A planned step describing an evaluation, i.e, testing  and producing evaluation metrics, that has some impact on the AI System, e.g. the evaluation of the ML model using a specified Dataset or the :AI_System undergoing a third party evaluation.
    /// <see href="https://w3id.org/rains#Evaluate"></see></summary>
    let Evaluate = Namespaced_IRI.parse _namespace_name "Evaluate" |> NamespacedName

    /// <summary>
    /// A planned step that has some impact on the AI System where the dataset(s) used to produce the ML Model are merged and/or split. Merging takes place when there is more than one dataset in use. Typically, splitting results in three subsets: Training, Validation, and Testing. This step is typically part of the Implementation stage of an AI System's life cycle.
    /// <see href="https://w3id.org/rains#MergeAndSplitDataset"></see></summary>
    let MergeAndSplitDataset =
        Namespaced_IRI.parse _namespace_name "MergeAndSplitDataset" |> NamespacedName

    /// <summary>
    /// A planned step describing the realization of a component. This includes implementing a component or retrieving it from a different (or third party) source. The realization of the component has some impact on the AI System, e.g. the implementation of the ML model or importing a third party dataset.
    /// <see href="https://w3id.org/rains#RealizeComponent"></see></summary>
    let RealizeComponent =
        Namespaced_IRI.parse _namespace_name "RealizeComponent" |> NamespacedName

    /// <summary>
    /// A specific type of planned sao:AccountableResult which represents a high level reference to testing at least one component and recording the results of the test(s) (e.g. testing the model with a specified dataset) that is expected to be produced during the implementation stage.
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
    /// 5. SystemUsageGuidance
    /// <see href="https://w3id.org/rains#Evaluation"></see></summary>
    let Evaluation = Namespaced_IRI.parse _namespace_name "Evaluation" |> NamespacedName

    /// <summary>
    /// A specific type of planned sao:AccountableResult which represents the description of a realized ML Model, including it characteristics, performance, etc.
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
    /// 9. SystemUsageGuidance
    /// <see href="https://w3id.org/rains#ModelComponent"></see></summary>
    let ModelComponent =
        Namespaced_IRI.parse _namespace_name "ModelComponent" |> NamespacedName

    /// <summary>
    /// A specific type of planned sao:AccountableResult  which represents the description of an realized dataset, including its characteristics, how it was collected, its risks, etc. The dataset component represents a collection of collected and pre-processed data. Once it is split, the subclasses TestingDataset, ValidationDataset, and EvaluationDataset can be used.
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
    /// 12. Algorithm
    /// <see href="https://w3id.org/rains#DatasetComponent"></see></summary>
    let DatasetComponent =
        Namespaced_IRI.parse _namespace_name "DatasetComponent" |> NamespacedName

    /// <summary>
    /// A specific type of planned sao:AccountableResult which represents a high level reference to a specification  (e.g. a specification report) that is expected to be produced during the design stage in order to inform the future AI system lifecycle stages (e.g. implementation).
    /// <see href="https://w3id.org/rains#DesignSpecification"></see></summary>
    let DesignSpecification =
        Namespaced_IRI.parse _namespace_name "DesignSpecification" |> NamespacedName

    /// <summary>
    /// A specific type of planned sao:AccountableResult which represents a high level reference to a guideline (e.g. a guideline document) that is expected to be produced during the implementation in order to inform on the correct procedure for deploying, using and maintaining the system or any of its components.
    /// <see href="https://w3id.org/rains#Guideline"></see></summary>
    let Guideline = Namespaced_IRI.parse _namespace_name "Guideline" |> NamespacedName

    /// <summary>
    /// A specific type of planned sao:AccountableResult which represents the characteristics, performance, etc. related to all the implemented hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in AI systems.
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
    /// 11. SoftLaw
    /// <see href="https://w3id.org/rains#SupportingInfrastructureComponent"></see></summary>
    let SupportingInfrastructureComponent =
        Namespaced_IRI.parse _namespace_name "SupportingInfrastructureComponent" |> NamespacedName

    /// <summary>
    /// A specific type of sao:InformationElement which records a specific piece of  information about  a compliance requirement that is to be complied with as part of an information realization collection.
    /// <see href="https://w3id.org/rains#ComplianceEntity"></see></summary>
    let ComplianceEntity =
        Namespaced_IRI.parse _namespace_name "ComplianceEntity" |> NamespacedName

    /// <summary>
    /// A specific type of design specification  which represents the  description of a compliance requirement.
    ///
    /// It is advisable that the information realization corresponding to SystemPurposeSpecification contains the following information elements
    /// 1. HardLaw
    /// 2. SoftLaw
    /// <see href="https://w3id.org/rains#ComplianceSpecification"></see></summary>
    let ComplianceSpecification =
        Namespaced_IRI.parse _namespace_name "ComplianceSpecification" |> NamespacedName

    /// <summary>
    /// A planned step describing the creation of a specification that has some impact on the AI System, e.g. the production of the design specification describing the training dataset to be used. This step is typically part of the Design stage of an AI System's life cycle.
    /// <see href="https://w3id.org/rains#ProduceSpecification"></see></summary>
    let ProduceSpecification =
        Namespaced_IRI.parse _namespace_name "ProduceSpecification" |> NamespacedName

    /// <summary>
    /// A specific type of design specification which represents the description  of a planned evaluation process.
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
    /// 5. SystemUsageGuidance
    /// <see href="https://w3id.org/rains#EvaluationSpecification"></see></summary>
    let EvaluationSpecification =
        Namespaced_IRI.parse _namespace_name "EvaluationSpecification" |> NamespacedName

    /// <summary>
    /// A specific type of design specification which represents the specification description of planned requirements, characteristics, performance, etc. related to all the hardware and software 'plumbing' that is not generally considered part of the AI processes, however, may also be source of erroneous behaviour in AI systems.
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
    /// 11. SoftLaw
    /// <see href="https://w3id.org/rains#SupportingInfrastructureSpecification"></see></summary>
    let SupportingInfrastructureSpecification =
        Namespaced_IRI.parse _namespace_name "SupportingInfrastructureSpecification" |> NamespacedName

    /// <summary>
    /// A specific type of design specification which represents  the  description of the purpose(s) for which an AI system is designed and used for.
    ///
    /// It is advisable that the information realization corresponding to SystemPurposeSpecification contains the following information elements
    /// 1. IntendedUserGroup
    /// 2. IntendedUseCase
    /// 3. IncorrectUseCase
    /// <see href="https://w3id.org/rains#SystemPurposeSpecification"></see></summary>
    let SystemPurposeSpecification =
        Namespaced_IRI.parse _namespace_name "SystemPurposeSpecification" |> NamespacedName

    /// <summary>
    /// A specific type of design specification  which represents the description of planned requirements, characteristics, risks, etc. related to a dataset (e.g., a training dataset for ML model) expected to be used as part of the AI system life cycle.
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
    /// 12. Algorithm
    /// <see href="https://w3id.org/rains#DatasetSpecification"></see></summary>
    let DatasetSpecification =
        Namespaced_IRI.parse _namespace_name "DatasetSpecification" |> NamespacedName

    /// <summary>
    /// A specific type of design specification  which represents the description of planned requirements, characteristics, performance, etc. related to an AI model.
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
    /// 9. SystemUsageGuidance
    /// <see href="https://w3id.org/rains#ModelSpecification"></see></summary>
    let ModelSpecification =
        Namespaced_IRI.parse _namespace_name "ModelSpecification" |> NamespacedName

    /// <summary>
    /// A specific type of sao:InformationElement which records a specific piece of  information detailing how the data is collected. This includes the information about mechanism used for collecting data (e.g. hardware sensors, software program, or manually), the timeframe over which the data was collected, any consent reporting, etc.
    ///
    /// There is a separate concept that represents the data collection software see rainsDataCollectionSoftware.
    /// <see href="https://w3id.org/rains#DataCollectionProcedure"></see></summary>
    let DataCollectionProcedure =
        Namespaced_IRI.parse _namespace_name "DataCollectionProcedure" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software that was used to collect data that formed the dataset which was used to train the ML Model
    /// <see href="https://w3id.org/rains#DataCollectionSoftware"></see></summary>
    let DataCollectionSoftware =
        Namespaced_IRI.parse _namespace_name "DataCollectionSoftware" |> NamespacedName

    /// <summary>
    /// A specific type of sao:InformationElement which records a specific piece of  information detailing how the data is preprocessed. This includes information on what is done to the data (e.g., cleaning, sampling, filtering, feature engineering, etc) and how it is done (e.g., manually, programmatically, or using feature engineering software).
    ///
    /// There is a separate concept that represents the data preprocessing software.
    /// <see href="https://w3id.org/rains#DataPreprocessingProcedure"></see></summary>
    let DataPreprocessingProcedure =
        Namespaced_IRI.parse _namespace_name "DataPreprocessingProcedure" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software  that was used to preprocess the dataset using to train the ML Model
    /// <see href="https://w3id.org/rains#DataPreprocessingSoftware"></see></summary>
    let DataPreprocessingSoftware =
        Namespaced_IRI.parse _namespace_name "DataPreprocessingSoftware" |> NamespacedName

    /// <summary>
    /// A planned step describing the creation of a guideline that has some impact on the AI System, e.g. the production of the deployment guideline describing how the AI System is to be deployed on-site or the production of the maintenance guideline describing how the AI System is to be maintained.
    /// <see href="https://w3id.org/rains#GenerateGuideline"></see></summary>
    let GenerateGuideline =
        Namespaced_IRI.parse _namespace_name "GenerateGuideline" |> NamespacedName

    /// <summary>
    /// A planned step describing a certification granting decision to be taken by a human when incorporating accountability in AI Systems, e.g. grant an ISO certificate.
    /// <see href="https://w3id.org/rains#GrantCertification"></see></summary>
    let GrantCertification =
        Namespaced_IRI.parse _namespace_name "GrantCertification" |> NamespacedName

    /// <summary>
    /// A specific type of :Evaluation which represents an evaluation performed by a third party independent of the developers of the AI System.
    /// <see href="https://w3id.org/rains#ThirdPartyEvaluation"></see></summary>
    let ThirdPartyEvaluation =
        Namespaced_IRI.parse _namespace_name "ThirdPartyEvaluation" |> NamespacedName

    /// <summary>
    /// A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to evaluate the ML Model. The other subsets are used to train and evaluate the model. This type can also represent a standalone dataset used to evaluate the model independent of the datasets used to train and validate it.
    /// <see href="https://w3id.org/rains#EvaluationDataset"></see></summary>
    let EvaluationDataset =
        Namespaced_IRI.parse _namespace_name "EvaluationDataset" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement (which is also an osw:Software and a prov:SoftwareAgent)  which records  information detailing  a software that was used to detect bias or check for fairness in both the dataset which was used to train the ML Model as well as the ML model itself
    /// <see href="https://w3id.org/rains#FairnessOrBiasDetectionSoftware"></see></summary>
    let FairnessOrBiasDetectionSoftware =
        Namespaced_IRI.parse _namespace_name "FairnessOrBiasDetectionSoftware" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records a specific piece of  information detailing a funding source.
    /// <see href="https://w3id.org/rains#Funding"></see></summary>
    let Funding = Namespaced_IRI.parse _namespace_name "Funding" |> NamespacedName

    /// <summary>
    /// A specific type of :Guideline which represents the description of guidelines for the Deployment stage of the AI System.
    ///
    /// It is advisable that the information realization corresponding to the System Deployment Guideline variable contains the following information elements:
    /// Guidance.
    /// 1. SystemIntegrationGuidance
    /// 2. SystemDeploymentGuidance
    /// 3. SystemDocumentationGuidance
    /// <see href="https://w3id.org/rains#SystemDeploymentGuideline"></see></summary>
    let SystemDeploymentGuideline =
        Namespaced_IRI.parse _namespace_name "SystemDeploymentGuideline" |> NamespacedName

    /// <summary>
    /// A specific type of :Guideline which represents the description of guidelines for the Operation stage of the AI System.
    ///
    /// It is advisable that the information realization corresponding to the System Operation  Guideline variable contains the following information elements:
    /// Guidance.
    /// 1. SystemIntegrationGuidance
    /// 2. SystemUsageGuidance
    /// <see href="https://w3id.org/rains#SystemOperationGuideline"></see></summary>
    let SystemOperationGuideline =
        Namespaced_IRI.parse _namespace_name "SystemOperationGuideline" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records a specific piece of  information detailing instructions that should be followed during the deployment or operation stage of the :AI_System lifecycle.
    /// <see href="https://w3id.org/rains#Guidance"></see></summary>
    let Guidance = Namespaced_IRI.parse _namespace_name "Guidance" |> NamespacedName
    /// <summary>
    /// A specific type of compliance entity which records a specific piece of  information about the laws and regulations that must be, or are, complied with as part of an information realization collection.
    ///
    /// When used as part of an information realization corresponding to a design specification, it describes the hard laws that must be complied with. When used as part of an information realization corresponding to an realized component, it describes the hard laws that the component complies with.
    /// <see href="https://w3id.org/rains#HardLaw"></see></summary>
    let HardLaw = Namespaced_IRI.parse _namespace_name "HardLaw" |> NamespacedName
    /// <summary>
    /// A specific type of compliance entity which records a specific piece of  information about the procedures, standards, protocols, etc that complying with is desired or encouraged as part of an information realization collection.
    ///
    /// When used as part of an information realization corresponding to a design specification, it describes the soft laws that are to be complied with. When used as part of an information realization corresponding to an realized component, it describes the soft laws that the component complies with.
    /// <see href="https://w3id.org/rains#SoftLaw"></see></summary>
    let SoftLaw = Namespaced_IRI.parse _namespace_name "SoftLaw" |> NamespacedName

    /// <summary>
    /// A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to train the ML Model. The other subsets are used to validate and evaluate the model.
    /// <see href="https://w3id.org/rains#TrainingDataset"></see></summary>
    let TrainingDataset =
        Namespaced_IRI.parse _namespace_name "TrainingDataset" |> NamespacedName

    /// <summary>
    /// A specific type of a Dataset Component  which represents a subset of the whole collected and pre-processed datasets after they were merged then split to be fed into the ML Model. This specific type represents the data used to validate the ML Model. The dataset is typically used repeatedly during the hyperparameter tuning process. The other subsets are used to train and evaluate the model.
    /// <see href="https://w3id.org/rains#ValidationDataset"></see></summary>
    let ValidationDataset =
        Namespaced_IRI.parse _namespace_name "ValidationDataset" |> NamespacedName

    /// <summary>
    /// A type of :UseCase detailing a situation in which any component of :AI_System or the system as whole should not be used.
    /// <see href="https://w3id.org/rains#IncorrectUseCase"></see></summary>
    let IncorrectUseCase =
        Namespaced_IRI.parse _namespace_name "IncorrectUseCase" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement which records a specific piece of information detailing a situation in which any component of :AI_System or the system as whole could potentially be used.
    /// <see href="https://w3id.org/rains#UseCase"></see></summary>
    let UseCase = Namespaced_IRI.parse _namespace_name "UseCase" |> NamespacedName

    /// <summary>
    /// A type of :UseCase detailing a situation in which any component of :AI_System or the system as whole is expected to be used.
    /// <see href="https://w3id.org/rains#IntendedUseCase"></see></summary>
    let IntendedUseCase =
        Namespaced_IRI.parse _namespace_name "IntendedUseCase" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records a specific piece of  information detailing the target user audience for the functionality of the overall :AI_System or the components used to develop such system (e.g., a reused public training dataset or a model would be associated with this information).
    /// <see href="https://w3id.org/rains#IntendedUserGroup"></see></summary>
    let IntendedUserGroup =
        Namespaced_IRI.parse _namespace_name "IntendedUserGroup" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records a specific piece of  information detailing the limitations of any aspect related to an :AI_System including the system as whole, its components (e.g., ML model),  or associated processes (e.g., evaluation).
    /// <see href="https://w3id.org/rains#Limitation"></see></summary>
    let Limitation = Namespaced_IRI.parse _namespace_name "Limitation" |> NamespacedName

    /// <summary>
    /// A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be deployed.
    /// <see href="https://w3id.org/rains#SystemDeploymentGuidance"></see></summary>
    let SystemDeploymentGuidance =
        Namespaced_IRI.parse _namespace_name "SystemDeploymentGuidance" |> NamespacedName

    /// <summary>
    /// A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be documented.
    /// <see href="https://w3id.org/rains#SystemDocumentationGuidance"></see></summary>
    let SystemDocumentationGuidance =
        Namespaced_IRI.parse _namespace_name "SystemDocumentationGuidance" |> NamespacedName

    /// <summary>
    /// A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be integrated with other systems or services.
    /// <see href="https://w3id.org/rains#SystemIntegrationGuidance"></see></summary>
    let SystemIntegrationGuidance =
        Namespaced_IRI.parse _namespace_name "SystemIntegrationGuidance" |> NamespacedName

    /// <summary>
    /// A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be maintained.
    /// <see href="https://w3id.org/rains#SystemMaintenanceGuidance"></see></summary>
    let SystemMaintenanceGuidance =
        Namespaced_IRI.parse _namespace_name "SystemMaintenanceGuidance" |> NamespacedName

    /// <summary>
    /// A specific type of :Guidance which records a specific piece of information about the guidance to how the :AI_System should be used.
    /// <see href="https://w3id.org/rains#SystemUsageGuidance"></see></summary>
    let SystemUsageGuidance =
        Namespaced_IRI.parse _namespace_name "SystemUsageGuidance" |> NamespacedName

    /// <summary>
    /// A sao:InformationElement  which records a specific piece of  information detailing tradeoffs to mitigate possible undesired or dangerous outcomes caused by any aspects of :AI_Sytem.
    /// <see href="https://w3id.org/rains#TradeOff"></see></summary>
    let TradeOff = Namespaced_IRI.parse _namespace_name "TradeOff" |> NamespacedName

    /// <summary>
    /// The decision threshold the metric that produced evaluation result was computed on. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#computedOnDecisionThreshold"></see></summary>
    let computedOnDecisionThreshold =
        Namespaced_IRI.parse _namespace_name "computedOnDecisionThreshold" |> NamespacedName

    /// <summary>
    /// The description of slice that the metric which  produced evaluation result was computed on. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#computedOnSlice"></see></summary>
    let computedOnSlice =
        Namespaced_IRI.parse _namespace_name "computedOnSlice" |> NamespacedName

    /// <summary>
    /// A value indicating what an :InformationElement's base 64 image is in String format. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#hasBase64Image"></see></summary>
    let hasBase64Image =
        Namespaced_IRI.parse _namespace_name "hasBase64Image" |> NamespacedName

    /// <summary>
    /// A relation that links some evaluation measure to one or more results produced for this measure.
    /// <see href="https://w3id.org/rains#hasEvaluationResult"></see></summary>
    let hasEvaluationResult =
        Namespaced_IRI.parse _namespace_name "hasEvaluationResult" |> NamespacedName

    /// <summary>
    /// A relation that links a result to some evaluation measure for which the result was produced.
    /// <see href="https://w3id.org/rains#isEvaluationResultOf"></see></summary>
    let isEvaluationResultOf =
        Namespaced_IRI.parse _namespace_name "isEvaluationResultOf" |> NamespacedName

    /// <summary>
    /// A value describing the format of an input. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#hasInputFormat"></see></summary>
    let hasInputFormat =
        Namespaced_IRI.parse _namespace_name "hasInputFormat" |> NamespacedName

    /// <summary>
    /// A value indicating what a :Risk's mitigation strategy is, expressed in String format. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#hasMitigationStrategy"></see></summary>
    let hasMitigationStrategy =
        Namespaced_IRI.parse _namespace_name "hasMitigationStrategy" |> NamespacedName

    /// <summary>
    /// A value describing the format of an output. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#hasOutputFormat"></see></summary>
    let hasOutputFormat =
        Namespaced_IRI.parse _namespace_name "hasOutputFormat" |> NamespacedName

    /// <summary>
    /// A relation that links a realizable object (e.g., model) to the information element describing its characteristic.
    /// <see href="https://w3id.org/rains#hasRealizableObjectCharacteristic"></see></summary>
    let hasRealizableObjectCharacteristic =
        Namespaced_IRI.parse _namespace_name "hasRealizableObjectCharacteristic" |> NamespacedName

    /// <summary>
    /// Inverse of hasRealizableObjectCharacteristic
    /// <see href="https://w3id.org/rains#isCharacteristicOfRealizableObject"></see></summary>
    let isCharacteristicOfRealizableObject =
        Namespaced_IRI.parse _namespace_name "isCharacteristicOfRealizableObject" |> NamespacedName

    /// <summary>
    /// The lower bound of the confidence interval. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#hasResultLowerBound"></see></summary>
    let hasResultLowerBound =
        Namespaced_IRI.parse _namespace_name "hasResultLowerBound" |> NamespacedName

    /// <summary>
    /// The upper bound of the confidence interval.
    ///
    /// Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#hasResultUpperBound"></see></summary>
    let hasResultUpperBound =
        Namespaced_IRI.parse _namespace_name "hasResultUpperBound" |> NamespacedName

    /// <summary>
    /// The description of the result value.
    /// <see href="https://w3id.org/rains#hasResultValue"></see></summary>
    let hasResultValue =
        Namespaced_IRI.parse _namespace_name "hasResultValue" |> NamespacedName

    /// <summary>
    /// A value indicating whether the :RealizableObject is a third party resource.
    /// <see href="https://w3id.org/rains#isReusedObject"></see></summary>
    let isReusedObject =
        Namespaced_IRI.parse _namespace_name "isReusedObject" |> NamespacedName

    /// <summary>
    /// A value indicating what a :RealizableObject's version is. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    /// A value indicating what the version date of a :RealizableObject's is. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#versionDate"></see></summary>
    let versionDate =
        Namespaced_IRI.parse _namespace_name "versionDate" |> NamespacedName

    /// <summary>
    /// A value describing a note about the version date of a :RealizableObject. Inspired by the Model Card Toolkit schema https://github.com/tensorflow/model-card-toolkit/blob/master/model_card_toolkit/schema/v0.0.1/model_card.schema.json
    /// <see href="https://w3id.org/rains#versionNote"></see></summary>
    let versionNote =
        Namespaced_IRI.parse _namespace_name "versionNote" |> NamespacedName
