namespace https.w3id.org.ontouml_models.vocabulary.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ocmv =
    let _namespace_iri = Namespace_Iri ocmv |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Identifies an ontology that specializes a domain ontology where there could be no consensus or knowledge sharing. It represents the particular model of a domain according to a single viewpoint of a user or a developer."</para>
    /// labels<para>"Application Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Application">https://w3id.org/ontouml-models/vocabulary#Application</seealso>
    let Application = Prefixed_Name(ocmv, "Application") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Classroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyDevelopmentContext</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Determines that the artefact was developed within the context of a course on conceptual modeling, most likely as a course assignment."</para>
    /// labels<para>"Classroom Context"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Classroom">https://w3id.org/ontouml-models/vocabulary#Classroom</seealso>
    let Classroom = Prefixed_Name(ocmv, "Classroom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#ConceptualClarification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Determines that the artefact was created as the result of an ontological analysis of a concept, language, or domain of interest that sought to conceptually clarify and untangle complex notions and relations."</para>
    /// labels<para>"Conceptual Clarification Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#ConceptualClarification">https://w3id.org/ontouml-models/vocabulary#ConceptualClarification</seealso>
    let ConceptualClarification =
        Prefixed_Name(ocmv, "ConceptualClarification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyType</para>
    ///   <para>"Identifies an ontology that grasps the central concepts and relations of a given domain, possibly integrating several domain ontologies and being applicable in multiple scenarios. E.g., UFO-S, a commitment-based ontology of services, can be considered a core ontology because it applies to services in multiple domains, such as medical, financial, and legal services."</para>
    /// labels<para>"Core Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Core">https://w3id.org/ontouml-models/vocabulary#Core</seealso>
    let Core = Prefixed_Name(ocmv, "Core") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#DataPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Determines that the artefact was created to support the publication of some datasets. For instance, a conceptual model used to generate an OWL vocabulary to publish tabular data as linked open data on the web."</para>
    /// labels<para>"Data Publication Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#DataPublication">https://w3id.org/ontouml-models/vocabulary#DataPublication</seealso>
    let DataPublication = Prefixed_Name(ocmv, "DataPublication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#DecisionSupportSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>"Determines that the artefact was created during the development of a decision support system."</para>
    /// labels<para>"Decision Support System Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#DecisionSupportSystem">https://w3id.org/ontouml-models/vocabulary#DecisionSupportSystem</seealso>
    let DecisionSupportSystem =
        Prefixed_Name(ocmv, "DecisionSupportSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyType</para>
    ///   <para>"Identifies an ontology that describes how a community conceptualizes a phenomenon of interest. In general, a domain ontology formally characterizes a much narrower domain than a core ontology does. E.g., OntoBio is a domain ontology of biodiversity."</para>
    /// labels<para>"Domain Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Domain">https://w3id.org/ontouml-models/vocabulary#Domain</seealso>
    let Domain = Prefixed_Name(ocmv, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>"Determines that the artefact was created to demonstrate how OntoUML can be used to solve a certain modeling challenge, to support an experiment involving OntoUML, or to exemplify how a generic model can be reused in more concrete scenarios."</para>
    /// labels<para>"Example Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Example">https://w3id.org/ontouml-models/vocabulary#Example</seealso>
    let Example = Prefixed_Name(ocmv, "Example") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Industry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyDevelopmentContext</para>
    ///   <para>"Determines that the artefact was developed for a public or private organization."</para>
    /// labels<para>"Industry Context"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Industry">https://w3id.org/ontouml-models/vocabulary#Industry</seealso>
    let Industry = Prefixed_Name(ocmv, "Industry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#InformationRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>"Determines that the artefact was created to support the design of an information retrieval system."</para>
    /// labels<para>"Information Retrieval Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#InformationRetrieval">https://w3id.org/ontouml-models/vocabulary#InformationRetrieval</seealso>
    let InformationRetrieval =
        Prefixed_Name(ocmv, "InformationRetrieval") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Interoperability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>"Determines that the artefact was created to support data integration, vocabulary alignment, or the interoperability of software systems."</para>
    /// labels<para>"Interoperability Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Interoperability">https://w3id.org/ontouml-models/vocabulary#Interoperability</seealso>
    let Interoperability = Prefixed_Name(ocmv, "Interoperability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#LanguageEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Determines that the artefact was created for the design of a domain-specific modeling language."</para>
    /// labels<para>"Language Engineering Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#LanguageEngineering">https://w3id.org/ontouml-models/vocabulary#LanguageEngineering</seealso>
    let LanguageEngineering = Prefixed_Name(ocmv, "LanguageEngineering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Learning</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Determines that the artefact was created so that its authors could learn UFO and OntoUML. This usually applies to models developed by students as part of their course assignments."</para>
    /// labels<para>"Learning Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Learning">https://w3id.org/ontouml-models/vocabulary#Learning</seealso>
    let Learning = Prefixed_Name(ocmv, "Learning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#MetadataElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An element used in the metadata description of OntoUML models."</para>
    /// labels<para>"Metadata Element"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#MetadataElement">https://w3id.org/ontouml-models/vocabulary#MetadataElement</seealso>
    let MetadataElement = Prefixed_Name(ocmv, "MetadataElement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#OntologicalAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>"Determines if the artefact was created as the result of an ontological analysis of a concept, language, or domain of interest that sought to conceptually clarify and untangle complex notions and relations."</para>
    /// labels<para>"Ontological Analysis Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#OntologicalAnalysis">https://w3id.org/ontouml-models/vocabulary#OntologicalAnalysis</seealso>
    let OntologicalAnalysis = Prefixed_Name(ocmv, "OntologicalAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyDevelopmentContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Determines what is the context in which the artifact was developed."</para>
    /// labels<para>"Ontology Development Context"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#OntologyDevelopmentContext">https://w3id.org/ontouml-models/vocabulary#OntologyDevelopmentContext</seealso>
    let OntologyDevelopmentContext =
        Prefixed_Name(ocmv, "OntologyDevelopmentContext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Determines what is the main purpose of the artifact (e.g., conceptual clarification or data integration)."</para>
    /// labels<para>"Ontology Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#OntologyPurpose">https://w3id.org/ontouml-models/vocabulary#OntologyPurpose</seealso>
    let OntologyPurpose = Prefixed_Name(ocmv, "OntologyPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyRepresentationStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Representation styles adopted for modeling the artefact."</para>
    /// labels<para>"Ontology Representation Style"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#OntologyRepresentationStyle">https://w3id.org/ontouml-models/vocabulary#OntologyRepresentationStyle</seealso>
    let OntologyRepresentationStyle =
        Prefixed_Name(ocmv, "OntologyRepresentationStyle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies the categorization of the artifacts according to their scopes."</para>
    /// labels<para>"Ontology Type"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#OntologyType">https://w3id.org/ontouml-models/vocabulary#OntologyType</seealso>
    let OntologyType = Prefixed_Name(ocmv, "OntologyType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#OntoumlStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyRepresentationStyle</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Characterizes a model that contains at least one class, relation, or property using a valid OntoUML stereotype."</para>
    /// labels<para>"OntoUML Style"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#OntoumlStyle">https://w3id.org/ontouml-models/vocabulary#OntoumlStyle</seealso>
    let OntoumlStyle = Prefixed_Name(ocmv, "OntoumlStyle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#Research</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyDevelopmentContext</para>
    ///   <para>"Determines that the artefact was developed as part of a research project. This usually implies that the artefact was featured in a scientific publication."</para>
    /// labels<para>"Research Context"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#Research">https://w3id.org/ontouml-models/vocabulary#Research</seealso>
    let Research = Prefixed_Name(ocmv, "Research") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#SoftwareEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyPurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Determines that the artefact was created during the development of an information system. For instance, a conceptual model that is used to generate a relational database."</para>
    /// labels<para>"Software Engineering Purpose"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#SoftwareEngineering">https://w3id.org/ontouml-models/vocabulary#SoftwareEngineering</seealso>
    let SoftwareEngineering = Prefixed_Name(ocmv, "SoftwareEngineering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#UfoStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ontouml-models/vocabulary#OntologyRepresentationStyle</para>
    ///   <para>"Characterizes a model that contains at least one class or relation from UFO without an OntoUML stereotype."</para>
    /// labels<para>"UFO Style"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#UfoStyle">https://w3id.org/ontouml-models/vocabulary#UfoStyle</seealso>
    let UfoStyle = Prefixed_Name(ocmv, "UfoStyle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#conformsToSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a schema upon which the distribution can be validated against. E.g., a JSON Schema document, a SHACL shape, and an XML Schema document."</para>
    /// labels<para>"conforms to schema"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#conformsToSchema">https://w3id.org/ontouml-models/vocabulary#conformsToSchema</seealso>
    let conformsToSchema = Prefixed_Name(ocmv, "conformsToSchema") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies an ocmv:Context in which the artefact was developed."</para>
    /// labels<para>"context"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#context">https://w3id.org/ontouml-models/vocabulary#context</seealso>
    let context = Prefixed_Name(ocmv, "context") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#isComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines if a distribution contains all the data from the dcat:Dataset it materializes. In the catalog, the distributions of models in VPP, JSON, and Turtle are complete, while those in image format are not."</para>
    /// labels<para>"is complete"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#isComplete">https://w3id.org/ontouml-models/vocabulary#isComplete</seealso>
    let isComplete = Prefixed_Name(ocmv, "isComplete") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#ontologyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies an ocmv:OntologyRepresentationStyle representation styles adopted in the artefact."</para>
    /// labels<para>"ontology type"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#ontologyType">https://w3id.org/ontouml-models/vocabulary#ontologyType</seealso>
    let ontologyType = Prefixed_Name(ocmv, "ontologyType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#representationStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies an ocmv:OntologyRepresentationStyle representation adopted in the artefact."</para>
    /// labels<para>"representation style"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#representationStyle">https://w3id.org/ontouml-models/vocabulary#representationStyle</seealso>
    let representationStyle = Prefixed_Name(ocmv, "representationStyle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:ontouml-models/vocabulary#storageUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines a URL of a service in which the data and metadata of the dataset are stored. Accepts values in xsd:anyURI."</para>
    /// labels<para>"storage URL"</para></remarks>
    /// <seealso href="https://w3id.org/ontouml-models/vocabulary#storageUrl">https://w3id.org/ontouml-models/vocabulary#storageUrl</seealso>
    let storageUrl = Prefixed_Name(ocmv, "storageUrl") |> PrefixedName
