namespace https.w3id.org.ontouml_models.vocabulary.hash

open DoxAletheia.Rdf_Vocabulary

module ocmv =
    let _namespace_name = "https://w3id.org/ontouml-models/vocabulary#"

    /// <summary>
    /// Identifies an ontology that specializes a domain ontology where there could be no consensus or knowledge sharing. It represents the particular model of a domain according to a single viewpoint of a user or a developer.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// Identifies the categorization of the artifacts according to their scopes.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#OntologyType"></see></summary>
    let OntologyType =
        Namespaced_IRI.parse _namespace_name "OntologyType" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was developed within the context of a course on conceptual modeling, most likely as a course assignment.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Classroom"></see></summary>
    let Classroom = Namespaced_IRI.parse _namespace_name "Classroom" |> NamespacedName

    /// <summary>
    /// Determines what is the context in which the artifact was developed.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#OntologyDevelopmentContext"></see></summary>
    let OntologyDevelopmentContext =
        Namespaced_IRI.parse _namespace_name "OntologyDevelopmentContext" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created as the result of an ontological analysis of a concept, language, or domain of interest that sought to conceptually clarify and untangle complex notions and relations.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#ConceptualClarification"></see></summary>
    let ConceptualClarification =
        Namespaced_IRI.parse _namespace_name "ConceptualClarification" |> NamespacedName

    /// <summary>
    /// Determines what is the main purpose of the artifact (e.g., conceptual clarification or data integration).
    /// <see href="https://w3id.org/ontouml-models/vocabulary#OntologyPurpose"></see></summary>
    let OntologyPurpose =
        Namespaced_IRI.parse _namespace_name "OntologyPurpose" |> NamespacedName

    /// <summary>
    /// Identifies an ontology that grasps the central concepts and relations of a given domain, possibly integrating several domain ontologies and being applicable in multiple scenarios. E.g., UFO-S, a commitment-based ontology of services, can be considered a core ontology because it applies to services in multiple domains, such as medical, financial, and legal services.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Core"></see></summary>
    let Core = Namespaced_IRI.parse _namespace_name "Core" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created to support the publication of some datasets. For instance, a conceptual model used to generate an OWL vocabulary to publish tabular data as linked open data on the web.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#DataPublication"></see></summary>
    let DataPublication =
        Namespaced_IRI.parse _namespace_name "DataPublication" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created during the development of a decision support system.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#DecisionSupportSystem"></see></summary>
    let DecisionSupportSystem =
        Namespaced_IRI.parse _namespace_name "DecisionSupportSystem" |> NamespacedName

    /// <summary>
    /// Identifies an ontology that describes how a community conceptualizes a phenomenon of interest. In general, a domain ontology formally characterizes a much narrower domain than a core ontology does. E.g., OntoBio is a domain ontology of biodiversity.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Domain"></see></summary>
    let Domain = Namespaced_IRI.parse _namespace_name "Domain" |> NamespacedName
    /// <summary>
    /// Determines that the artefact was created to demonstrate how OntoUML can be used to solve a certain modeling challenge, to support an experiment involving OntoUML, or to exemplify how a generic model can be reused in more concrete scenarios.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Example"></see></summary>
    let Example = Namespaced_IRI.parse _namespace_name "Example" |> NamespacedName
    /// <summary>
    /// Determines that the artefact was developed for a public or private organization.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Industry"></see></summary>
    let Industry = Namespaced_IRI.parse _namespace_name "Industry" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created to support the design of an information retrieval system.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#InformationRetrieval"></see></summary>
    let InformationRetrieval =
        Namespaced_IRI.parse _namespace_name "InformationRetrieval" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created to support data integration, vocabulary alignment, or the interoperability of software systems.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Interoperability"></see></summary>
    let Interoperability =
        Namespaced_IRI.parse _namespace_name "Interoperability" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created for the design of a domain-specific modeling language.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#LanguageEngineering"></see></summary>
    let LanguageEngineering =
        Namespaced_IRI.parse _namespace_name "LanguageEngineering" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created so that its authors could learn UFO and OntoUML. This usually applies to models developed by students as part of their course assignments.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Learning"></see></summary>
    let Learning = Namespaced_IRI.parse _namespace_name "Learning" |> NamespacedName

    /// <summary>
    /// An element used in the metadata description of OntoUML models.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#MetadataElement"></see></summary>
    let MetadataElement =
        Namespaced_IRI.parse _namespace_name "MetadataElement" |> NamespacedName

    /// <summary>
    /// Determines if the artefact was created as the result of an ontological analysis of a concept, language, or domain of interest that sought to conceptually clarify and untangle complex notions and relations.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#OntologicalAnalysis"></see></summary>
    let OntologicalAnalysis =
        Namespaced_IRI.parse _namespace_name "OntologicalAnalysis" |> NamespacedName

    /// <summary>
    /// Representation styles adopted for modeling the artefact.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#OntologyRepresentationStyle"></see></summary>
    let OntologyRepresentationStyle =
        Namespaced_IRI.parse _namespace_name "OntologyRepresentationStyle" |> NamespacedName

    /// <summary>
    /// Characterizes a model that contains at least one class, relation, or property using a valid OntoUML stereotype.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#OntoumlStyle"></see></summary>
    let OntoumlStyle =
        Namespaced_IRI.parse _namespace_name "OntoumlStyle" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was developed as part of a research project. This usually implies that the artefact was featured in a scientific publication.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#Research"></see></summary>
    let Research = Namespaced_IRI.parse _namespace_name "Research" |> NamespacedName

    /// <summary>
    /// Determines that the artefact was created during the development of an information system. For instance, a conceptual model that is used to generate a relational database.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#SoftwareEngineering"></see></summary>
    let SoftwareEngineering =
        Namespaced_IRI.parse _namespace_name "SoftwareEngineering" |> NamespacedName

    /// <summary>
    /// Characterizes a model that contains at least one class or relation from UFO without an OntoUML stereotype.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#UfoStyle"></see></summary>
    let UfoStyle = Namespaced_IRI.parse _namespace_name "UfoStyle" |> NamespacedName

    /// <summary>
    /// Identifies a schema upon which the distribution can be validated against. E.g., a JSON Schema document, a SHACL shape, and an XML Schema document.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#conformsToSchema"></see></summary>
    let conformsToSchema =
        Namespaced_IRI.parse _namespace_name "conformsToSchema" |> NamespacedName

    /// <summary>
    /// Identifies an ocmv:Context in which the artefact was developed.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    /// Determines if a distribution contains all the data from the dcat:Dataset it materializes. In the catalog, the distributions of models in VPP, JSON, and Turtle are complete, while those in image format are not.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#isComplete"></see></summary>
    let isComplete = Namespaced_IRI.parse _namespace_name "isComplete" |> NamespacedName

    /// <summary>
    /// Identifies an ocmv:OntologyRepresentationStyle representation styles adopted in the artefact.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#ontologyType"></see></summary>
    let ontologyType =
        Namespaced_IRI.parse _namespace_name "ontologyType" |> NamespacedName

    /// <summary>
    /// Identifies an ocmv:OntologyRepresentationStyle representation adopted in the artefact.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#representationStyle"></see></summary>
    let representationStyle =
        Namespaced_IRI.parse _namespace_name "representationStyle" |> NamespacedName

    /// <summary>
    /// Determines a URL of a service in which the data and metadata of the dataset are stored. Accepts values in xsd:anyURI.
    /// <see href="https://w3id.org/ontouml-models/vocabulary#storageUrl"></see></summary>
    let storageUrl = Namespaced_IRI.parse _namespace_name "storageUrl" |> NamespacedName
