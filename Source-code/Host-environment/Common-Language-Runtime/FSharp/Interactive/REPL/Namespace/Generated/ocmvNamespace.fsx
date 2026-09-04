#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ocmv =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/ontouml-models/vocabulary#" "ocmv"

    let Application = _prefixId.prefix "Application"
    let Classroom = _prefixId.prefix "Classroom"
    let ConceptualClarification = _prefixId.prefix "ConceptualClarification"
    let Core = _prefixId.prefix "Core"
    let DataPublication = _prefixId.prefix "DataPublication"
    let DecisionSupportSystem = _prefixId.prefix "DecisionSupportSystem"
    let Domain = _prefixId.prefix "Domain"
    let Example = _prefixId.prefix "Example"
    let Industry = _prefixId.prefix "Industry"
    let InformationRetrieval = _prefixId.prefix "InformationRetrieval"
    let Interoperability = _prefixId.prefix "Interoperability"
    let LanguageEngineering = _prefixId.prefix "LanguageEngineering"
    let Learning = _prefixId.prefix "Learning"
    /// <summary>
    ///   <para>rdfs:label : Metadata Element</para>
    ///   <para>rdfs:comment : An element used in the metadata description of OntoUML models.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#MetadataElement">ocmv:MetadataElement</a>
    /// </summary>
    let MetadataElement = _prefixId.prefix "MetadataElement"
    let OntologicalAnalysis = _prefixId.prefix "OntologicalAnalysis"
    /// <summary>
    ///   <para>rdfs:label : Ontology Development Context</para>
    ///   <para>rdfs:comment : Determines what is the context in which the artifact was developed.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#OntologyDevelopmentContext">ocmv:OntologyDevelopmentContext</a>
    /// </summary>
    let OntologyDevelopmentContext = _prefixId.prefix "OntologyDevelopmentContext"
    /// <summary>
    ///   <para>rdfs:label : Ontology Purpose</para>
    ///   <para>rdfs:comment : Determines what is the main purpose of the artifact (e.g., conceptual clarification or data integration).</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#OntologyPurpose">ocmv:OntologyPurpose</a>
    /// </summary>
    let OntologyPurpose = _prefixId.prefix "OntologyPurpose"
    /// <summary>
    ///   <para>rdfs:label : Ontology Representation Style</para>
    ///   <para>rdfs:comment : Representation styles adopted for modeling the artefact.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#OntologyRepresentationStyle">ocmv:OntologyRepresentationStyle</a>
    /// </summary>
    let OntologyRepresentationStyle = _prefixId.prefix "OntologyRepresentationStyle"
    /// <summary>
    ///   <para>rdfs:label : Ontology Type</para>
    ///   <para>rdfs:comment : Identifies the categorization of the artifacts according to their scopes.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#OntologyType">ocmv:OntologyType</a>
    /// </summary>
    let OntologyType = _prefixId.prefix "OntologyType"
    let OntoumlStyle = _prefixId.prefix "OntoumlStyle"
    let Research = _prefixId.prefix "Research"
    let SoftwareEngineering = _prefixId.prefix "SoftwareEngineering"
    let UfoStyle = _prefixId.prefix "UfoStyle"
    /// <summary>
    ///   <para>rdfs:label : conforms to schema</para>
    ///   <para>skos:scopeNote : The identified schema should be compatible with the media type of the distribution. That is, if a distribution is in JSON, the schema cannot be an XML Schema.</para>
    ///   <para>rdfs:comment : Identifies a schema upon which the distribution can be validated against. E.g., a JSON Schema document, a SHACL shape, and an XML Schema document.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#conformsToSchema">ocmv:conformsToSchema</a>
    /// </summary>
    let conformsToSchema = _prefixId.prefix "conformsToSchema"
    /// <summary>
    ///   <para>rdfs:label : context</para>
    ///   <para>rdfs:comment : Identifies an ocmv:Context in which the artefact was developed.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#context">ocmv:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>rdfs:label : is complete</para>
    ///   <para>rdfs:comment : Determines if a distribution contains all the data from the dcat:Dataset it materializes. In the catalog, the distributions of models in VPP, JSON, and Turtle are complete, while those in image format are not.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#isComplete">ocmv:isComplete</a>
    /// </summary>
    let isComplete = _prefixId.prefix "isComplete"
    /// <summary>
    ///   <para>rdfs:label : ontology type</para>
    ///   <para>rdfs:comment : Identifies an ocmv:OntologyRepresentationStyle representation styles adopted in the artefact.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#ontologyType">ocmv:ontologyType</a>
    /// </summary>
    let ontologyType = _prefixId.prefix "ontologyType"
    /// <summary>
    ///   <para>rdfs:label : representation style</para>
    ///   <para>rdfs:comment : Identifies an ocmv:OntologyRepresentationStyle representation adopted in the artefact.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#representationStyle">ocmv:representationStyle</a>
    /// </summary>
    let representationStyle = _prefixId.prefix "representationStyle"
    /// <summary>
    ///   <para>rdfs:label : storage URL</para>
    ///   <para>rdfs:comment : Determines a URL of a service in which the data and metadata of the dataset are stored. Accepts values in xsd:anyURI.</para>
    ///   <a href="https://w3id.org/ontouml-models/vocabulary#storageUrl">ocmv:storageUrl</a>
    /// </summary>
    let storageUrl = _prefixId.prefix "storageUrl"
