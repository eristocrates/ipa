namespace http.w3id.org.nfdi4ing.metadata4ing.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module m4i =
    let _namespace_iri = Namespace_Iri m4i |> NamespaceIRI
    /// <summary>
    ///   <para>m4i:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"
    /// Metadata4Ing defines classes and properties or reuses such classes and properties from other ontologies to describe research processes and research data management in NFDI4Ing.
    /// New concepts and properties are located in the namespace of Metadata4Ing.
    /// Metadata4Ing does not import complete ontologies for the sake of relevance, readability, understandability and usability by and for engineers.
    /// Instead, it tries to make re-use of existing identifiers for classes and properties by re-using all or a relevant subset of the axioms from the original ontology.
    /// These statements have been extracted in different ways, e.g. by using Protégé tools importing an ontology and copying axioms of relevant items to Metadata4Ing or by download from data services or raw files of ontologies and manual copypasting.
    /// In some cases there was a need to extend or modify the original set of statements about an entity, e.g. because labels and definitions were expressed with a different owl:AnnotationProperty than the rest of Metadata4Ing, or because a skos:preflabel or a skos:definition in any of the languages we would like to support was missing.
    /// Any editorial changes on elements from external ontologies are declared in Metadata4Ing by an annotation with skos:editorialNote at item-level.
    /// To get the original set of statements we encourage to visit the original namespace of the respective item.
    /// Metadata4Ing reuses elements from the following ontologies:
    /// - BIRO = Bibliographic Reference Ontology
    /// - CR = Croissant
    /// - DCAT = Data Catalog
    /// - DCC = Digital Calibration Certificate
    /// - DCTERMS = Dublin Core Terms
    /// - EMMO = European Materials and Modelling Ontology
    /// - FOAF = Friend of a Friend
    /// - OBO = Open Biological and Biomedical Ontologies:
    ///   - BFO = Basic Formal Ontology
    ///   - RO = Relation Ontology
    /// - OWL = Web Ontology Language
    /// - PIMS-II = PIMS Interoperability Infrastructure
    /// - PROV = Provenance Namespace
    /// - QUDT = Quantities, Units, Dimensions and Types
    /// - RDF = Resource Description Framework
    /// - RDFS = RDF Schema
    /// - SCHEMA = schema.org
    /// - D-SI = Digital System of Units
    /// - SIO = Semanticscience Integrated Ontology
    /// - SKOS = Simple Knowledge Organization System
    /// - SSN = Semantic Sensor Network Ontology
    /// - XSD = XML Schema Definition
    /// "</para>
    /// labels<para>"Metadata4Ing"</para></remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#">http://w3id.org/nfdi4ing/metadata4ing#</seealso>
    let _prefix_iri = Prefixed_Name(m4i, "") |> PrefixedName
    /// <summary>
    ///   <para>m4i:ContactPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#ContactPerson">http://w3id.org/nfdi4ing/metadata4ing#ContactPerson</seealso>
    let ContactPerson = Prefixed_Name(m4i, "ContactPerson") |> PrefixedName
    /// <summary>
    ///   <para>m4i:DataCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#DataCollector">http://w3id.org/nfdi4ing/metadata4ing#DataCollector</seealso>
    let DataCollector = Prefixed_Name(m4i, "DataCollector") |> PrefixedName
    /// <summary>
    ///   <para>m4i:DataCurator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#DataCurator">http://w3id.org/nfdi4ing/metadata4ing#DataCurator</seealso>
    let DataCurator = Prefixed_Name(m4i, "DataCurator") |> PrefixedName
    /// <summary>
    ///   <para>m4i:DataManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#DataManager">http://w3id.org/nfdi4ing/metadata4ing#DataManager</seealso>
    let DataManager = Prefixed_Name(m4i, "DataManager") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Distributor">http://w3id.org/nfdi4ing/metadata4ing#Distributor</seealso>
    let Distributor = Prefixed_Name(m4i, "Distributor") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Editor">http://w3id.org/nfdi4ing/metadata4ing#Editor</seealso>
    let Editor = Prefixed_Name(m4i, "Editor") |> PrefixedName
    /// <summary>
    ///   <para>m4i:HostingInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#HostingInstitution">http://w3id.org/nfdi4ing/metadata4ing#HostingInstitution</seealso>
    let HostingInstitution = Prefixed_Name(m4i, "HostingInstitution") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Method">http://w3id.org/nfdi4ing/metadata4ing#Method</seealso>
    let Method = Prefixed_Name(m4i, "Method") |> PrefixedName
    /// <summary>
    ///   <para>m4i:NumericalAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#NumericalAssignment">http://w3id.org/nfdi4ing/metadata4ing#NumericalAssignment</seealso>
    let NumericalAssignment = Prefixed_Name(m4i, "NumericalAssignment") |> PrefixedName
    /// <summary>
    ///   <para>m4i:NumericalVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#NumericalVariable">http://w3id.org/nfdi4ing/metadata4ing#NumericalVariable</seealso>
    let NumericalVariable = Prefixed_Name(m4i, "NumericalVariable") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Other</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Other">http://w3id.org/nfdi4ing/metadata4ing#Other</seealso>
    let Other = Prefixed_Name(m4i, "Other") |> PrefixedName
    /// <summary>
    ///   <para>m4i:ProcessingStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#ProcessingStep">http://w3id.org/nfdi4ing/metadata4ing#ProcessingStep</seealso>
    let ProcessingStep = Prefixed_Name(m4i, "ProcessingStep") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Producer">http://w3id.org/nfdi4ing/metadata4ing#Producer</seealso>
    let Producer = Prefixed_Name(m4i, "Producer") |> PrefixedName
    /// <summary>
    ///   <para>m4i:ProjectLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#ProjectLeader">http://w3id.org/nfdi4ing/metadata4ing#ProjectLeader</seealso>
    let ProjectLeader = Prefixed_Name(m4i, "ProjectLeader") |> PrefixedName
    /// <summary>
    ///   <para>m4i:ProjectManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#ProjectManager">http://w3id.org/nfdi4ing/metadata4ing#ProjectManager</seealso>
    let ProjectManager = Prefixed_Name(m4i, "ProjectManager") |> PrefixedName
    /// <summary>
    ///   <para>m4i:ProjectMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#ProjectMember">http://w3id.org/nfdi4ing/metadata4ing#ProjectMember</seealso>
    let ProjectMember = Prefixed_Name(m4i, "ProjectMember") |> PrefixedName
    /// <summary>
    ///   <para>m4i:RegistrationAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#RegistrationAgency">http://w3id.org/nfdi4ing/metadata4ing#RegistrationAgency</seealso>
    let RegistrationAgency = Prefixed_Name(m4i, "RegistrationAgency") |> PrefixedName

    /// <summary>
    ///   <para>m4i:RegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#RegistrationAuthority">http://w3id.org/nfdi4ing/metadata4ing#RegistrationAuthority</seealso>
    let RegistrationAuthority =
        Prefixed_Name(m4i, "RegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>m4i:RelatedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#RelatedPerson">http://w3id.org/nfdi4ing/metadata4ing#RelatedPerson</seealso>
    let RelatedPerson = Prefixed_Name(m4i, "RelatedPerson") |> PrefixedName
    /// <summary>
    ///   <para>m4i:ResearchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#ResearchGroup">http://w3id.org/nfdi4ing/metadata4ing#ResearchGroup</seealso>
    let ResearchGroup = Prefixed_Name(m4i, "ResearchGroup") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Researcher">http://w3id.org/nfdi4ing/metadata4ing#Researcher</seealso>
    let Researcher = Prefixed_Name(m4i, "Researcher") |> PrefixedName
    /// <summary>
    ///   <para>m4i:RightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#RightsHolder">http://w3id.org/nfdi4ing/metadata4ing#RightsHolder</seealso>
    let RightsHolder = Prefixed_Name(m4i, "RightsHolder") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Role</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Sponsor">http://w3id.org/nfdi4ing/metadata4ing#Sponsor</seealso>
    let Sponsor = Prefixed_Name(m4i, "Sponsor") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Supervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Supervisor">http://w3id.org/nfdi4ing/metadata4ing#Supervisor</seealso>
    let Supervisor = Prefixed_Name(m4i, "Supervisor") |> PrefixedName
    /// <summary>
    ///   <para>m4i:TextVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#TextVariable">http://w3id.org/nfdi4ing/metadata4ing#TextVariable</seealso>
    let TextVariable = Prefixed_Name(m4i, "TextVariable") |> PrefixedName
    /// <summary>
    ///   <para>m4i:Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#Tool">http://w3id.org/nfdi4ing/metadata4ing#Tool</seealso>
    let Tool = Prefixed_Name(m4i, "Tool") |> PrefixedName

    /// <summary>
    ///   <para>m4i:UncertaintyDeclaration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#UncertaintyDeclaration">http://w3id.org/nfdi4ing/metadata4ing#UncertaintyDeclaration</seealso>
    let UncertaintyDeclaration =
        Prefixed_Name(m4i, "UncertaintyDeclaration") |> PrefixedName

    /// <summary>
    ///   <para>m4i:UsageInstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#UsageInstruction">http://w3id.org/nfdi4ing/metadata4ing#UsageInstruction</seealso>
    let UsageInstruction = Prefixed_Name(m4i, "UsageInstruction") |> PrefixedName
    /// <summary>
    ///   <para>m4i:WorkPackageLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#WorkPackageLeader">http://w3id.org/nfdi4ing/metadata4ing#WorkPackageLeader</seealso>
    let WorkPackageLeader = Prefixed_Name(m4i, "WorkPackageLeader") |> PrefixedName
    /// <summary>
    ///   <para>m4i:endOfProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"project end date"</para></remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#endOfProject">http://w3id.org/nfdi4ing/metadata4ing#endOfProject</seealso>
    let endOfProject = Prefixed_Name(m4i, "endOfProject") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasAdmissibleUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"redundant information: applicable unit can be deduced from quantity kind. If one wants to enforce the use of a specific unit, use a SHACL constraint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleUnit">http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleUnit</seealso>
    let hasAdmissibleUnit = Prefixed_Name(m4i, "hasAdmissibleUnit") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasAdmissibleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleValue">http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleValue</seealso>
    let hasAdmissibleValue = Prefixed_Name(m4i, "hasAdmissibleValue") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasAssignedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignedValue">http://w3id.org/nfdi4ing/metadata4ing#hasAssignedValue</seealso>
    let hasAssignedValue = Prefixed_Name(m4i, "hasAssignedValue") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasAssignmentTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignmentTimestamp">http://w3id.org/nfdi4ing/metadata4ing#hasAssignmentTimestamp</seealso>
    let hasAssignmentTimestamp =
        Prefixed_Name(m4i, "hasAssignmentTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasCoverageInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasCoverageInterval">http://w3id.org/nfdi4ing/metadata4ing#hasCoverageInterval</seealso>
    let hasCoverageInterval = Prefixed_Name(m4i, "hasCoverageInterval") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasDateAssignmentCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentCreated">http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentCreated</seealso>
    let hasDateAssignmentCreated =
        Prefixed_Name(m4i, "hasDateAssignmentCreated") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasDateAssignmentDeleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentDeleted">http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentDeleted</seealso>
    let hasDateAssignmentDeleted =
        Prefixed_Name(m4i, "hasDateAssignmentDeleted") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasDateAssignmentModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentModified">http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentModified</seealso>
    let hasDateAssignmentModified =
        Prefixed_Name(m4i, "hasDateAssignmentModified") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasDateAssignmentValidFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidFrom">http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidFrom</seealso>
    let hasDateAssignmentValidFrom =
        Prefixed_Name(m4i, "hasDateAssignmentValidFrom") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasDateAssignmentValidUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidUntil">http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidUntil</seealso>
    let hasDateAssignmentValidUntil =
        Prefixed_Name(m4i, "hasDateAssignmentValidUntil") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasEmployedTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasEmployedTool">http://w3id.org/nfdi4ing/metadata4ing#hasEmployedTool</seealso>
    let hasEmployedTool = Prefixed_Name(m4i, "hasEmployedTool") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasExpandedUnc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasExpandedUnc">http://w3id.org/nfdi4ing/metadata4ing#hasExpandedUnc</seealso>
    let hasExpandedUnc = Prefixed_Name(m4i, "hasExpandedUnc") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasKindOfQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasKindOfQuantity">http://w3id.org/nfdi4ing/metadata4ing#hasKindOfQuantity</seealso>
    let hasKindOfQuantity = Prefixed_Name(m4i, "hasKindOfQuantity") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasMaximumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasMaximumValue">http://w3id.org/nfdi4ing/metadata4ing#hasMaximumValue</seealso>
    let hasMaximumValue = Prefixed_Name(m4i, "hasMaximumValue") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasMinimumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasMinimumValue">http://w3id.org/nfdi4ing/metadata4ing#hasMinimumValue</seealso>
    let hasMinimumValue = Prefixed_Name(m4i, "hasMinimumValue") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasNumericalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasNumericalValue">http://w3id.org/nfdi4ing/metadata4ing#hasNumericalValue</seealso>
    let hasNumericalValue = Prefixed_Name(m4i, "hasNumericalValue") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasParameter">http://w3id.org/nfdi4ing/metadata4ing#hasParameter</seealso>
    let hasParameter = Prefixed_Name(m4i, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasRorId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasRorId">http://w3id.org/nfdi4ing/metadata4ing#hasRorId</seealso>
    let hasRorId = Prefixed_Name(m4i, "hasRorId") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasRuntimeAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasRuntimeAssignment">http://w3id.org/nfdi4ing/metadata4ing#hasRuntimeAssignment</seealso>
    let hasRuntimeAssignment =
        Prefixed_Name(m4i, "hasRuntimeAssignment") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasStepSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasStepSize">http://w3id.org/nfdi4ing/metadata4ing#hasStepSize</seealso>
    let hasStepSize = Prefixed_Name(m4i, "hasStepSize") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasStringValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasStringValue">http://w3id.org/nfdi4ing/metadata4ing#hasStringValue</seealso>
    let hasStringValue = Prefixed_Name(m4i, "hasStringValue") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasSymbol">http://w3id.org/nfdi4ing/metadata4ing#hasSymbol</seealso>
    let hasSymbol = Prefixed_Name(m4i, "hasSymbol") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasUncertaintyDeclaration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasUncertaintyDeclaration">http://w3id.org/nfdi4ing/metadata4ing#hasUncertaintyDeclaration</seealso>
    let hasUncertaintyDeclaration =
        Prefixed_Name(m4i, "hasUncertaintyDeclaration") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasUnit">http://w3id.org/nfdi4ing/metadata4ing#hasUnit</seealso>
    let hasUnit = Prefixed_Name(m4i, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasValue">http://w3id.org/nfdi4ing/metadata4ing#hasValue</seealso>
    let hasValue = Prefixed_Name(m4i, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>m4i:hasVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasVariable">http://w3id.org/nfdi4ing/metadata4ing#hasVariable</seealso>
    let hasVariable = Prefixed_Name(m4i, "hasVariable") |> PrefixedName

    /// <summary>
    ///   <para>m4i:hasVariableDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#hasVariableDescription">http://w3id.org/nfdi4ing/metadata4ing#hasVariableDescription</seealso>
    let hasVariableDescription =
        Prefixed_Name(m4i, "hasVariableDescription") |> PrefixedName

    /// <summary>
    ///   <para>m4i:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#identifier">http://w3id.org/nfdi4ing/metadata4ing#identifier</seealso>
    let identifier = Prefixed_Name(m4i, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>m4i:implementedByTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#implementedByTool">http://w3id.org/nfdi4ing/metadata4ing#implementedByTool</seealso>
    let implementedByTool = Prefixed_Name(m4i, "implementedByTool") |> PrefixedName
    /// <summary>
    ///   <para>m4i:implementsMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#implementsMethod">http://w3id.org/nfdi4ing/metadata4ing#implementsMethod</seealso>
    let implementsMethod = Prefixed_Name(m4i, "implementsMethod") |> PrefixedName
    /// <summary>
    ///   <para>m4i:inProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"An object property comming from the Metadata4Ing ontology for describing the generation of research data, projects and scientific projects. The ontology was released recently on the 22.02.2022 and could be useful for future expansion of the hydrogen ontology."</para>
    ///   <para>"The inverse of m4i:projectParticipant"</para>
    /// labels<para>"associated to project"</para></remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#inProject">http://w3id.org/nfdi4ing/metadata4ing#inProject</seealso>
    let inProject = Prefixed_Name(m4i, "inProject") |> PrefixedName
    /// <summary>
    ///   <para>m4i:investigates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#investigates">http://w3id.org/nfdi4ing/metadata4ing#investigates</seealso>
    let investigates = Prefixed_Name(m4i, "investigates") |> PrefixedName

    /// <summary>
    ///   <para>m4i:investigatesProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#investigatesProperty">http://w3id.org/nfdi4ing/metadata4ing#investigatesProperty</seealso>
    let investigatesProperty =
        Prefixed_Name(m4i, "investigatesProperty") |> PrefixedName

    /// <summary>
    ///   <para>m4i:isEmployedToolIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#isEmployedToolIn">http://w3id.org/nfdi4ing/metadata4ing#isEmployedToolIn</seealso>
    let isEmployedToolIn = Prefixed_Name(m4i, "isEmployedToolIn") |> PrefixedName
    /// <summary>
    ///   <para>m4i:orcidId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#orcidId">http://w3id.org/nfdi4ing/metadata4ing#orcidId</seealso>
    let orcidId = Prefixed_Name(m4i, "orcidId") |> PrefixedName
    /// <summary>
    ///   <para>m4i:projectParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"An object property comming from the Metadata4Ing ontology for describing the generation of research data, projects and scientific projects. The ontology was released recently on the 22.02.2022 and could be useful for future expansion of the hydrogen ontology."</para>
    ///   <para>"The inverse of m4i:associatesToProject"</para>
    /// labels<para>"project participant"</para></remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#projectParticipant">http://w3id.org/nfdi4ing/metadata4ing#projectParticipant</seealso>
    let projectParticipant = Prefixed_Name(m4i, "projectParticipant") |> PrefixedName
    /// <summary>
    ///   <para>m4i:projectReferenceID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#projectReferenceID">http://w3id.org/nfdi4ing/metadata4ing#projectReferenceID</seealso>
    let projectReferenceID = Prefixed_Name(m4i, "projectReferenceID") |> PrefixedName
    /// <summary>
    ///   <para>m4i:realizesMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#realizesMethod">http://w3id.org/nfdi4ing/metadata4ing#realizesMethod</seealso>
    let realizesMethod = Prefixed_Name(m4i, "realizesMethod") |> PrefixedName
    /// <summary>
    ///   <para>m4i:representsVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#representsVariable">http://w3id.org/nfdi4ing/metadata4ing#representsVariable</seealso>
    let representsVariable = Prefixed_Name(m4i, "representsVariable") |> PrefixedName
    /// <summary>
    ///   <para>m4i:startOfProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"project start date"</para></remarks>
    /// <seealso href="http://w3id.org/nfdi4ing/metadata4ing#startOfProject">http://w3id.org/nfdi4ing/metadata4ing#startOfProject</seealso>
    let startOfProject = Prefixed_Name(m4i, "startOfProject") |> PrefixedName
