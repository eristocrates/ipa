#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module m4i =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/nfdi4ing/metadata4ing#" "m4i"

    let _namespaceIri = _prefixId.prefix ""
    let ContactPerson = _prefixId.prefix "ContactPerson"
    let DataCollector = _prefixId.prefix "DataCollector"
    let DataCurator = _prefixId.prefix "DataCurator"
    let DataManager = _prefixId.prefix "DataManager"
    let Distributor = _prefixId.prefix "Distributor"
    let Editor = _prefixId.prefix "Editor"
    let HostingInstitution = _prefixId.prefix "HostingInstitution"
    /// <summary>
    ///   <para>skos:prefLabel : methodskos:prefLabel : Methode</para>
    ///   <para>skos:definition : Abstract description of a method for analysis, generation and transformation of data and material objects like, e.g., 'Fourier Transform Infrared Spectroscopy' or 'Molecular Dynamics Simulation'. Note that while values for relevant parameters should be provided, m4i:Method does not refer to the actual execution of the process that is described (use m4i:ProcessingStep for that), but rather a description of the underlying principle.</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#Method">m4i:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>skos:prefLabel : numerische Zuweisungskos:prefLabel : numerical assignment</para>
    ///   <para>skos:definition : Assignment by which a variable (e.g., a physical property) is assigned an si:Real quantity value (scalar x measurement unit) in some context (e.g., applied to some object of research)</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#NumericalAssignment">m4i:NumericalAssignment</a>
    /// </summary>
    let NumericalAssignment = _prefixId.prefix "NumericalAssignment"
    /// <summary>
    ///   <para>skos:prefLabel : numerische Variableskos:prefLabel : numerical variable</para>
    ///   <para>skos:definition : Eine Variable, die eine Zahl als Wert erwartetskos:definition : A variable that expects a float or integer as a value</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#NumericalVariable">m4i:NumericalVariable</a>
    /// </summary>
    let NumericalVariable = _prefixId.prefix "NumericalVariable"
    let Other = _prefixId.prefix "Other"
    /// <summary>
    ///   <para>skos:prefLabel : processing stepskos:prefLabel : Arbeitsschritt</para>
    ///   <para>skos:definition : Specific action undertaken during research</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#ProcessingStep">m4i:ProcessingStep</a>
    /// </summary>
    let ProcessingStep = _prefixId.prefix "ProcessingStep"
    let Producer = _prefixId.prefix "Producer"
    let ProjectLeader = _prefixId.prefix "ProjectLeader"
    let ProjectManager = _prefixId.prefix "ProjectManager"
    let ProjectMember = _prefixId.prefix "ProjectMember"
    let RegistrationAgency = _prefixId.prefix "RegistrationAgency"
    let RegistrationAuthority = _prefixId.prefix "RegistrationAuthority"
    let RelatedPerson = _prefixId.prefix "RelatedPerson"
    let ResearchGroup = _prefixId.prefix "ResearchGroup"
    let Researcher = _prefixId.prefix "Researcher"
    let RightsHolder = _prefixId.prefix "RightsHolder"
    let Sponsor = _prefixId.prefix "Sponsor"
    let Supervisor = _prefixId.prefix "Supervisor"
    /// <summary>
    ///   <para>skos:prefLabel : textbasierte Variableskos:prefLabel : text variable</para>
    ///   <para>skos:definition : Eine Variable, die eine Zeichenkette als Wert erwartetskos:definition : A variable that expects a string of characters as a value</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#TextVariable">m4i:TextVariable</a>
    /// </summary>
    let TextVariable = _prefixId.prefix "TextVariable"
    /// <summary>
    ///   <para>skos:prefLabel : toolskos:prefLabel : Werkzeug</para>
    ///   <para>skos:definition : Object that helps an agent perform an action (e.g., John wrote a book with a pen), i.e., an object of the relation schema:instrument or m4i:hasTool</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#Tool">m4i:Tool</a>
    /// </summary>
    let Tool = _prefixId.prefix "Tool"
    /// <summary>
    ///   <para>skos:prefLabel : uncertainty declarationskos:prefLabel : Unsicherheitsdeklaration</para>
    ///   <para>skos:definition : Declaration that can be applied to an si:Real quantity value to give an assessment of uncertainty</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#UncertaintyDeclaration">m4i:UncertaintyDeclaration</a>
    /// </summary>
    let UncertaintyDeclaration = _prefixId.prefix "UncertaintyDeclaration"
    /// <summary>
    ///   <para>skos:prefLabel : usage instructionskos:prefLabel : Verwendungshinweis</para>
    ///   <para>skos:definition : Textuelle Beschreibung eines Verarbeitungsschritts innerhalb eines Forschungsprozesses, um dessen Reproduzierbarkeit zu erleichtern oder zu ermöglichenskos:definition : Textual description of a processing step within a research process to enable or facilitate its reproducibility</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#UsageInstruction">m4i:UsageInstruction</a>
    /// </summary>
    let UsageInstruction = _prefixId.prefix "UsageInstruction"
    let WorkPackageLeader = _prefixId.prefix "WorkPackageLeader"
    /// <summary>
    ///   <para>skos:prefLabel : project end dateskos:prefLabel : Projektenddatum</para>
    ///   <para>skos:definition : end date of a projectskos:definition : Projektenddatum</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#endOfProject">m4i:endOfProject</a>
    /// </summary>
    let endOfProject = _prefixId.prefix "endOfProject"
    /// <summary>
    ///   <para>skos:prefLabel : hat als zulässige Einheitskos:prefLabel : has admissible unit</para>
    ///   <para>skos:definition : DEPRECATED (x hasAdmissibleUnit y) means that y is a unit that can be associated with the variable x</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : redundant information: applicable unit can be deduced from quantity kind. If one wants to enforce the use of a specific unit, use a SHACL constraint.^^xsd:string</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleUnit">m4i:hasAdmissibleUnit</a>
    /// </summary>
    let hasAdmissibleUnit = _prefixId.prefix "hasAdmissibleUnit"
    /// <summary>
    ///   <para>skos:prefLabel : hat als zulässigen Wertskos:prefLabel : has admissible value</para>
    ///   <para>skos:definition : (x hasAdmissibleValue y) means that y is a value that can be assigned to the variable x</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasAdmissibleValue">m4i:hasAdmissibleValue</a>
    /// </summary>
    let hasAdmissibleValue = _prefixId.prefix "hasAdmissibleValue"
    /// <summary>
    ///   <para>skos:prefLabel : hat zugewiesenen Wertskos:prefLabel : has assigned value</para>
    ///   <para>skos:definition : (a hasAssignedValue y) means that a: x = y is an assignment where the value y is assigned to a variable x</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignedValue">m4i:hasAssignedValue</a>
    /// </summary>
    let hasAssignedValue = _prefixId.prefix "hasAssignedValue"
    /// <summary>
    ///   <para>skos:prefLabel : hat Zuweisungszeitstempelskos:prefLabel : has assignment timestamp</para>
    ///   <para>skos:definition : Points to a timestamp associated with an assignment; there are multiple kinds of timestamp datatype properties, which are included here from schema.org</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasAssignmentTimestamp">m4i:hasAssignmentTimestamp</a>
    /// </summary>
    let hasAssignmentTimestamp = _prefixId.prefix "hasAssignmentTimestamp"
    /// <summary>
    ///   <para>skos:prefLabel : hat Überdeckungsintervallskos:prefLabel : has coverage interval</para>
    ///   <para>skos:definition : Associates an si:Real quantity value with an si:CoverageInterval</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasCoverageInterval">m4i:hasCoverageInterval</a>
    /// </summary>
    let hasCoverageInterval = _prefixId.prefix "hasCoverageInterval"
    /// <summary>
    ///   <para>skos:prefLabel : hat Datumszuweisung erzeugtskos:prefLabel : has date assignment created</para>
    ///   <para>skos:definition : Points to a date(time) of creation of an assignment</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentCreated">m4i:hasDateAssignmentCreated</a>
    /// </summary>
    let hasDateAssignmentCreated = _prefixId.prefix "hasDateAssignmentCreated"
    /// <summary>
    ///   <para>skos:prefLabel : hat Datumszuweisung gelöschtskos:prefLabel : has date assignment deleted</para>
    ///   <para>skos:definition : Points to a date(time) of deletion of an assignment</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentDeleted">m4i:hasDateAssignmentDeleted</a>
    /// </summary>
    let hasDateAssignmentDeleted = _prefixId.prefix "hasDateAssignmentDeleted"
    /// <summary>
    ///   <para>skos:prefLabel : hat Datumszuweisung bearbeitetskos:prefLabel : has date assignment modified</para>
    ///   <para>skos:definition : Points to a date(time) of modification of an assignment</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentModified">m4i:hasDateAssignmentModified</a>
    /// </summary>
    let hasDateAssignmentModified = _prefixId.prefix "hasDateAssignmentModified"
    /// <summary>
    ///   <para>skos:prefLabel : hat Datumszuweisung gültig abskos:prefLabel : has date assignment valid from</para>
    ///   <para>skos:definition : Points to a date(time) at which the validity of an assignment begins</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidFrom">m4i:hasDateAssignmentValidFrom</a>
    /// </summary>
    let hasDateAssignmentValidFrom = _prefixId.prefix "hasDateAssignmentValidFrom"
    /// <summary>
    ///   <para>skos:prefLabel : hat Datumszuweisung gültig bisskos:prefLabel : has date assignment valid until</para>
    ///   <para>skos:definition : Points to a date(time) at which the validity of an assignment ends</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasDateAssignmentValidUntil">m4i:hasDateAssignmentValidUntil</a>
    /// </summary>
    let hasDateAssignmentValidUntil = _prefixId.prefix "hasDateAssignmentValidUntil"
    /// <summary>
    ///   <para>skos:prefLabel : hat eingesetztes Werkzeugskos:prefLabel : has employed tool</para>
    ///   <para>skos:definition : verweist auf ein Werkzeug, das in einem Arbeitsschritt verwendet wurdeskos:definition : Points to a tool that is used within a given processing step</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasEmployedTool">m4i:hasEmployedTool</a>
    /// </summary>
    let hasEmployedTool = _prefixId.prefix "hasEmployedTool"
    /// <summary>
    ///   <para>skos:prefLabel : hat erweiterte Unsicherheitskos:prefLabel : has expanded uncertainty</para>
    ///   <para>skos:definition : Relates an si:Real to its expanded uncertainty</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasExpandedUnc">m4i:hasExpandedUnc</a>
    /// </summary>
    let hasExpandedUnc = _prefixId.prefix "hasExpandedUnc"
    /// <summary>
    ///   <para>skos:prefLabel : hat Größenartskos:prefLabel : has kind of quantity</para>
    ///   <para>skos:note : we recommend using a persistent identifier resolving to a persistent URL</para>
    ///   <para>skos:definition : Points to the property characterization (i.e., to the kind of quantity) from a controlled vocabulary</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasKindOfQuantity">m4i:hasKindOfQuantity</a>
    /// </summary>
    let hasKindOfQuantity = _prefixId.prefix "hasKindOfQuantity"
    /// <summary>
    ///   <para>skos:prefLabel : hat Maximalwertskos:prefLabel : has maximum value</para>
    ///   <para>skos:definition : Represents the highest value of a multi-valued variable</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasMaximumValue">m4i:hasMaximumValue</a>
    /// </summary>
    let hasMaximumValue = _prefixId.prefix "hasMaximumValue"
    /// <summary>
    ///   <para>skos:prefLabel : hat Minimalwertskos:prefLabel : has minimum value</para>
    ///   <para>skos:definition : Represents the lowest value of a multi-valued variable</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasMinimumValue">m4i:hasMinimumValue</a>
    /// </summary>
    let hasMinimumValue = _prefixId.prefix "hasMinimumValue"
    /// <summary>
    ///   <para>skos:definition : Represents the numerical value of a real</para>
    ///   <para>skos:prefLabel : has numerical valueskos:prefLabel : hat Zahlenwert</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasNumericalValue">m4i:hasNumericalValue</a>
    /// </summary>
    let hasNumericalValue = _prefixId.prefix "hasNumericalValue"
    /// <summary>
    ///   <para>skos:prefLabel : hat Parameterskos:prefLabel : has parameter</para>
    ///   <para>skos:definition : Points to a parameter of a given method or tool.</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasParameter">m4i:hasParameter</a>
    /// </summary>
    let hasParameter = _prefixId.prefix "hasParameter"
    /// <summary>
    ///   <para>skos:altLabel : has research organization registry idskos:altLabel : hat Forschungsorganisationsid</para>
    ///   <para>skos:prefLabel : hat ROR IDskos:prefLabel : has ROR ID</para>
    ///   <para>skos:definition : A Research Organization Registry identifier that persistently and uniquely identifies a research organizationskos:definition : Ein persistenter Identifikator für Organisationen, vergeben durch die Research Organization Registry, der eine Forschungseinrichtung eindeutig identifiziert.</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasRorId">m4i:hasRorId</a>
    /// </summary>
    let hasRorId = _prefixId.prefix "hasRorId"
    /// <summary>
    ///   <para>skos:prefLabel : hat Laufzeitzuweisungskos:prefLabel : has runtime assignment</para>
    ///   <para>skos:definition : Points to an assignment that is neither input nor output</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasRuntimeAssignment">m4i:hasRuntimeAssignment</a>
    /// </summary>
    let hasRuntimeAssignment = _prefixId.prefix "hasRuntimeAssignment"
    /// <summary>
    ///   <para>skos:definition : Describes the spacing of a multi-valued variable</para>
    ///   <para>skos:prefLabel : has step sizeskos:prefLabel : hat Schrittweite</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasStepSize">m4i:hasStepSize</a>
    /// </summary>
    let hasStepSize = _prefixId.prefix "hasStepSize"
    /// <summary>
    ///   <para>skos:prefLabel : hat Zeichenwertskos:prefLabel : has string value</para>
    ///   <para>skos:definition : Eine Zeichenkette (Text) beliebiger Länge.skos:definition : A character string of any length</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasStringValue">m4i:hasStringValue</a>
    /// </summary>
    let hasStringValue = _prefixId.prefix "hasStringValue"
    /// <summary>
    ///   <para>skos:prefLabel : hat Symbolskos:prefLabel : has symbol</para>
    ///   <para>skos:definition : Letter or string that denotes a variableskos:definition : Buchstabe oder Zeichenkette, die eine Variable repräsentiert</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasSymbol">m4i:hasSymbol</a>
    /// </summary>
    let hasSymbol = _prefixId.prefix "hasSymbol"
    /// <summary>
    ///   <para>skos:prefLabel : hat Unsicherheitsdeklarationskos:prefLabel : has uncertainty declaration</para>
    ///   <para>skos:definition : Associates an si:Real quantity value with its mandatory uncertainty declaration (i.e., with an expanded uncertainty or a coverage interval)</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasUncertaintyDeclaration">m4i:hasUncertaintyDeclaration</a>
    /// </summary>
    let hasUncertaintyDeclaration = _prefixId.prefix "hasUncertaintyDeclaration"
    /// <summary>
    ///   <para>skos:note : Kardinalität dieser Property bei der Beschreibung eines si:Real: 0-1skos:note : We recommend using a resolvable PID from a controlled vocabulary, such as ISO 80000, IEC or QUDTskos:note : cardinality of this property for the description of a si:Real: 0-1skos:note : obligation of this property for the description of a si:Real: recommendedskos:note : Obligation dieser Property bei der Beschreibung eines si:Real: recommended</para>
    ///   <para>skos:definition : Represents the unit of a numerical (real) valueskos:definition : Repräsentiert die Einheit eines numerischen (reelen) Wertes</para>
    ///   <para>skos:prefLabel : hat Einheitskos:prefLabel : has unit</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasUnit">m4i:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>skos:prefLabel : hat Wertskos:prefLabel : has value</para>
    ///   <para>skos:definition : Ein beliebiger Wertskos:definition : A value of any type</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasValue">m4i:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>skos:prefLabel : hat Variableskos:prefLabel : has variable</para>
    ///   <para>skos:definition : ( a hasVariable x ) means that a: x = y is an assignment where the value y is assigned to a variable xskos:definition : ( a hasVariable x ) bedeutet, dass a: x = y eine Variablenzuordnung ist, in der der Variablen x ein Wert zugeordnet wird.</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasVariable">m4i:hasVariable</a>
    /// </summary>
    let hasVariable = _prefixId.prefix "hasVariable"
    /// <summary>
    ///   <para>skos:prefLabel : hat Variablenbeschreibungskos:prefLabel : has variable description</para>
    ///   <para>skos:definition : Textuelle und menschenlesbare Beschreibung einer Variablen im Forschungskontextskos:definition : Textual and human readable description of a variable in a research context</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#hasVariableDescription">m4i:hasVariableDescription</a>
    /// </summary>
    let hasVariableDescription = _prefixId.prefix "hasVariableDescription"
    /// <summary>
    ///   <para>skos:prefLabel : has identifierskos:prefLabel : hat Identifikator</para>
    ///   <para>skos:definition : A systematically built alphanumeric string that identifies a unique object (e.g. a person, a publication, an organisation, a research activity, a sample, etc.) or a unique class of objects.</para>
    ///   <para>skos:altLabel : besitzt eindeutigen Identifikatorskos:altLabel : wird durch Identifikator repräsentiertskos:altLabel : has unique identifierskos:altLabel : is represented through identifier</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#identifier">m4i:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>skos:prefLabel : wird implementiert durchskos:prefLabel : implemented by</para>
    ///   <para>skos:definition : Points to a tool that implements a given method</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#implementedByTool">m4i:implementedByTool</a>
    /// </summary>
    let implementedByTool = _prefixId.prefix "implementedByTool"
    /// <summary>
    ///   <para>skos:prefLabel : implementsskos:prefLabel : implementiert</para>
    ///   <para>skos:definition : Points to a method that is implemented by a given tool</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#implementsMethod">m4i:implementsMethod</a>
    /// </summary>
    let implementsMethod = _prefixId.prefix "implementsMethod"
    /// <summary>
    ///   <para>skos:prefLabel : gehört zu Projektskos:prefLabel : associated to project</para>
    ///   <para>skos:definition : A property that connects a person or an organization with a project.</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#inProject">m4i:inProject</a>
    /// </summary>
    let inProject = _prefixId.prefix "inProject"
    /// <summary>
    ///   <para>skos:prefLabel : untersuchtskos:prefLabel : investigates</para>
    ///   <para>skos:definition : (x investigates y) means that x is about y, in the context of scientific research and development</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#investigates">m4i:investigates</a>
    /// </summary>
    let investigates = _prefixId.prefix "investigates"
    /// <summary>
    ///   <para>skos:prefLabel : untersucht Eigenschaftskos:prefLabel : investigates property</para>
    ///   <para>skos:definition : (x investigatesProperty y) means that x is about target property y, in the context of scientific research and development</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#investigatesProperty">m4i:investigatesProperty</a>
    /// </summary>
    let investigatesProperty = _prefixId.prefix "investigatesProperty"
    /// <summary>
    ///   <para>skos:prefLabel : ist eingesetztes Werkzeugskos:prefLabel : is employed tool</para>
    ///   <para>skos:definition : verweist auf einen Arbeitsschritt, in dem das Werkzeug eingesetzt wurdeskos:definition : Points to a processing step the tool has been used in</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#isEmployedToolIn">m4i:isEmployedToolIn</a>
    /// </summary>
    let isEmployedToolIn = _prefixId.prefix "isEmployedToolIn"
    /// <summary>
    ///   <para>skos:prefLabel : hat ORCID IDskos:prefLabel : has ORCID ID</para>
    ///   <para>skos:definition : Open Researcher and Contributor ID: ein persistenter Identifikator, der eine in der Forschung tätige Person eindeutig identifiziert.skos:definition : Open Researcher and Contributor ID: an identifier, that allows unique identification of a person, usually active in research.</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#orcidId">m4i:orcidId</a>
    /// </summary>
    let orcidId = _prefixId.prefix "orcidId"
    /// <summary>
    ///   <para>skos:prefLabel : project participantskos:prefLabel : hat Projektmitglied</para>
    ///   <para>skos:definition : A property that connects a project with a person or an organisation.</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#projectParticipant">m4i:projectParticipant</a>
    /// </summary>
    let projectParticipant = _prefixId.prefix "projectParticipant"
    /// <summary>
    ///   <para>skos:prefLabel : hat Projekt-IDskos:prefLabel : has project ID</para>
    ///   <para>skos:definition : Eine alphanumerische ID zur Referenzierung eines Projekts. Wir empfehlen die Nutzung einer auch außerhalb der teilnehmenden Institutionen verständlichen ID, am besten persistent und mit einem Resolving-System verknüpft, wie bspw. die [Research Activity Identifier (RAiD)](https://raid.org/) oder eine von einem Förderer zugewiesene ID (siehe bspw. die [DFG-Projektendatenbank](https://gepris.dfg.de/gepris/OCTOPUS) oder die [EU-Projektendatenbank](https://ec.europa.eu/info/funding-tenders/opportunities/portal/screen/opportunities/projects-results)).skos:definition : An alphanumeric identifier for a project. We recommend using an identifier which is understandable outside the involved institutions and possibly resolvable and persistent, such as the [Research Activity Identifier (RAiD)](https://raid.org/) or a funder-given ID (see for example the [DFG project database](https://gepris.dfg.de/gepris/OCTOPUS) or the [EU project database](https://ec.europa.eu/info/funding-tenders/opportunities/portal/screen/opportunities/projects-results)).</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#projectReferenceID">m4i:projectReferenceID</a>
    /// </summary>
    let projectReferenceID = _prefixId.prefix "projectReferenceID"
    /// <summary>
    ///   <para>skos:prefLabel : realizes methodskos:prefLabel : realisiert Methode</para>
    ///   <para>skos:definition : Points to a method that is used within a given processing step</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#realizesMethod">m4i:realizesMethod</a>
    /// </summary>
    let realizesMethod = _prefixId.prefix "realizesMethod"
    /// <summary>
    ///   <para>skos:prefLabel : repräsentiert Variableskos:prefLabel : represents variable</para>
    ///   <para>skos:definition : Points to a variable that is represented through a field within a recordset</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#representsVariable">m4i:representsVariable</a>
    /// </summary>
    let representsVariable = _prefixId.prefix "representsVariable"
    /// <summary>
    ///   <para>skos:prefLabel : project start dateskos:prefLabel : Projektstartdatum</para>
    ///   <para>skos:definition : start date of a projectskos:definition : Startdatum eines Projekts</para>
    ///   <a href="http://w3id.org/nfdi4ing/metadata4ing#startOfProject">m4i:startOfProject</a>
    /// </summary>
    let startOfProject = _prefixId.prefix "startOfProject"
