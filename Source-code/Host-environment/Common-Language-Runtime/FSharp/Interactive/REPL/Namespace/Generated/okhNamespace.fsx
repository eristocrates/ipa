#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module okh =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/oseg/ont/okh#" "okh"
    /// <summary>
    ///   <para>rdfs:label : auxiliary file (neither source nor export)^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#AuxiliaryFile">okh:AuxiliaryFile</a>
    /// </summary>
    let AuxiliaryFile = _prefixId.prefix "AuxiliaryFile"
    /// <summary>
    ///   <para>rdfs:label : Bill of Materials^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#BoM">okh:BoM</a>
    /// </summary>
    let BoM = _prefixId.prefix "BoM"
    /// <summary>
    ///   <para>rdfs:comment : Either a module (MOSH) or Part (POSH); more component types may be added in the future</para>
    ///   <para>rdfs:label : Component</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Component">okh:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>cc:deprecatedOn : 2023-08-19^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///     others shall be able to identify/procure this component only by the given reference(s),
    ///     MOSH → URL to corresponding release
    ///     POSH → URL to containing folder
    ///     STD  → standard designation (preferably naming the _latest_ standard)
    ///     BUY  → unambiguous reference</para>
    ///   <para>rdfs:label : Component Reference^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#ComponentReference">okh:ComponentReference</a>
    /// </summary>
    let ComponentReference = _prefixId.prefix "ComponentReference"
    /// <summary>
    ///   <para>rdfs:label : Contribution Guide^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#ContributionGuide">okh:ContributionGuide</a>
    /// </summary>
    let ContributionGuide = _prefixId.prefix "ContributionGuide"
    /// <summary>
    ///   <para>rdfs:label : exported source file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#ExportFile">okh:ExportFile</a>
    /// </summary>
    let ExportFile = _prefixId.prefix "ExportFile"
    /// <summary>
    ///   <para>rdfs:comment : A file that forms part of the project, specified/located either by a URL (okh:url) or a repo-/project-relative path (okh:relativePath).^^xsd:string</para>
    ///   <para>rdfs:label : File^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#File">okh:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"
    /// <summary>
    ///   <para>cc:deprecatedOn : 2023-07-11^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : permanent URL to file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#FileUrl">okh:FileUrl</a>
    /// </summary>
    let FileUrl = _prefixId.prefix "FileUrl"
    /// <summary>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Image">okh:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : file holding the metadata^^xsd:string</para>
    ///   <para>rdfs:label : manifest file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#ManifestFile">okh:ManifestFile</a>
    /// </summary>
    let ManifestFile = _prefixId.prefix "ManifestFile"
    /// <summary>
    ///   <para>rdfs:label : Manufacturing Instructions^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#ManufacturingInstructions">okh:ManufacturingInstructions</a>
    /// </summary>
    let ManufacturingInstructions = _prefixId.prefix "ManufacturingInstructions"
    /// <summary>
    ///   <para>rdfs:comment : …of a module or a part</para>
    ///   <para>rdfs:label : mass</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Mass">okh:Mass</a>
    /// </summary>
    let Mass = _prefixId.prefix "Mass"
    /// <summary>
    ///   <para>rdfs:comment : Module of Open Source Hardware (MOSH)</para>
    ///   <para>rdfs:label : Module</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Module">okh:Module</a>
    /// </summary>
    let Module = _prefixId.prefix "Module"
    /// <summary>
    ///   <para>rdfs:comment : …of a module or a part</para>
    ///   <para>rdfs:label : outer dimensions</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#OuterDimensions">okh:OuterDimensions</a>
    /// </summary>
    let OuterDimensions = _prefixId.prefix "OuterDimensions"
    /// <summary>
    ///   <para>rdfs:comment : Piece of Open Source Hardware (POSH)</para>
    ///   <para>rdfs:label : Part</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Part">okh:Part</a>
    /// </summary>
    let Part = _prefixId.prefix "Part"
    /// <summary>
    ///   <para>rdfs:comment : _scientific_ (that is: peer reviewed) publication that _contains_ the design files^^xsd:string</para>
    ///   <para>rdfs:label : Scientific Publication^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Publication">okh:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Readme^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Readme">okh:Readme</a>
    /// </summary>
    let Readme = _prefixId.prefix "Readme"
    /// <summary>
    ///   <para>rdfs:label : unambiguous reference^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Reference">okh:Reference</a>
    /// </summary>
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:comment : Software (including firmware) needed to run &amp; use the OSH^^xsd:string</para>
    ///   <para>rdfs:label : Software</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Software">okh:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : source file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#SourceFile">okh:SourceFile</a>
    /// </summary>
    let SourceFile = _prefixId.prefix "SourceFile"
    /// <summary>
    ///   <para>rdfs:comment : official standard used in the _design_ (not e.g. DIN SPEC 3105-1)^^xsd:string</para>
    ///   <para>rdfs:label : Technical Standard</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#Standard">okh:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>rdfs:label : User Manual^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#UserManual">okh:UserManual</a>
    /// </summary>
    let UserManual = _prefixId.prefix "UserManual"
    /// <summary>
    ///   <para>rdfs:label : Website URL^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#WebsiteUrl">okh:WebsiteUrl</a>
    /// </summary>
    let WebsiteUrl = _prefixId.prefix "WebsiteUrl"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : URL to legal code of a license without SPDX identifier, hence OSHWA-compliance is to be checked manually^^xsd:string</para>
    ///   <para>rdfs:label : non-SPDX license^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#alternativeLicense">okh:alternativeLicense</a>
    /// </summary>
    let alternativeLicense = _prefixId.prefix "alternativeLicense"
    /// <summary>
    ///   <para>rdfs:comment : permanent URL to evidence of compliance (OSHWA, FSF, DIN SPEC 3105)^^xsd:string</para>
    ///   <para>rdfs:label : attestation^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#attestation">okh:attestation</a>
    /// </summary>
    let attestation = _prefixId.prefix "attestation"
    /// <summary>
    ///   <para>rdfs:comment : reference to an auxiliary file^^xsd:string</para>
    ///   <para>rdfs:label : has auxiliary file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#auxiliary">okh:auxiliary</a>
    /// </summary>
    let auxiliary = _prefixId.prefix "auxiliary"
    /// <summary>
    ///   <para>rdfs:label : complies with a technical standard^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#compliesWith">okh:compliesWith</a>
    /// </summary>
    let compliesWith = _prefixId.prefix "compliesWith"
    /// <summary>
    ///   <para>rdfs:comment : International Patent Classification (IPC)^^xsd:string</para>
    ///   <para>rdfs:label : Patent Class^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#cpcPatentClass">okh:cpcPatentClass</a>
    /// </summary>
    let cpcPatentClass = _prefixId.prefix "cpcPatentClass"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : platform, where the crawler found the metadata (e.g. GitHub, Wikifactory)</para>
    ///   <para>rdfs:label : Metadata Source^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#dataSource">okh:dataSource</a>
    /// </summary>
    let dataSource = _prefixId.prefix "dataSource"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment :
    ///    IETF language tag
    ///    following the BCP 47 standard e.g. en-GB
    ///    denotes the language of the documentation for the component subject </para>
    ///   <para>rdfs:label : documentation language^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#documentationLanguage">okh:documentationLanguage</a>
    /// </summary>
    let documentationLanguage = _prefixId.prefix "documentationLanguage"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : …using the ODRL definitions^^xsd:string</para>
    ///   <para>rdfs:label : Documentation Readiness Level (DLR)^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#documentationReadinessLevel">okh:documentationReadinessLevel</a>
    /// </summary>
    let documentationReadinessLevel = _prefixId.prefix "documentationReadinessLevel"
    /// <summary>
    ///   <para>rdfs:comment : this publication has a digital object identifier (DOI)</para>
    ///   <para>rdfs:label : DOI</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#doi">okh:doi</a>
    /// </summary>
    let doi = _prefixId.prefix "doi"
    /// <summary>
    ///   <para>rdfs:comment : URL to a (generated) exported source file^^xsd:string</para>
    ///   <para>rdfs:label : exported source file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#export">okh:export</a>
    /// </summary>
    let export = _prefixId.prefix "export"
    /// <summary>
    ///   <para>rdfs:label : file format^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#fileFormat">okh:fileFormat</a>
    /// </summary>
    let fileFormat = _prefixId.prefix "fileFormat"
    /// <summary>
    ///   <para>cc:deprecatedOn : 2023-07-11^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : file URL^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#fileUrl">okh:fileUrl</a>
    /// </summary>
    let fileUrl = _prefixId.prefix "fileUrl"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fork of^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#forkOf">okh:forkOf</a>
    /// </summary>
    let forkOf = _prefixId.prefix "forkOf"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment :
    ///     functional description, e.g. what it actually does, what problem it solves, for whom, under which conditions etc.
    ///     so if you wish that someone finds &amp; uses your okh specifically e.g. for COVID-19-crisis response, include relevant keywords in this field
    ///     optional: description of input, output and interfaces</para>
    ///   <para>rdfs:label : functional description^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#function">okh:function</a>
    /// </summary>
    let function_ = _prefixId.prefix "function"
    /// <summary>
    ///   <para>rdfs:comment : Metadata addressing functionality, such as dimensions, material, weight, RPM,… (not standardized)^^xsd:string</para>
    ///   <para>rdfs:label : functionality metadata^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#functionalMetadata">okh:functionalMetadata</a>
    /// </summary>
    let functionalMetadata = _prefixId.prefix "functionalMetadata"
    /// <summary>
    ///   <para>rdfs:comment : links to the corresponding Bill of Materials^^xsd:string</para>
    ///   <para>rdfs:label : has Bill of Materials^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasBoM">okh:hasBoM</a>
    /// </summary>
    let hasBoM = _prefixId.prefix "hasBoM"
    /// <summary>
    ///   <para>rdfs:comment : Links to sub-components of the Module. In the case of that sub-component being an external Module, it has to refer to a snapshot of the RDF object representing that OKH Module. Each sub-component should also appear in the BoM.^^xsd:string</para>
    ///   <para>rdfs:label : has Component^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasComponent">okh:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:comment : links to the corresponding Contribution Guide^^xsd:string</para>
    ///   <para>rdfs:label : has Contribution Guide^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasContributionGuide">okh:hasContributionGuide</a>
    /// </summary>
    let hasContributionGuide = _prefixId.prefix "hasContributionGuide"
    /// <summary>
    ///   <para>rdfs:comment : links to the corresponding Image^^xsd:string</para>
    ///   <para>rdfs:label : has image^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasImage">okh:hasImage</a>
    /// </summary>
    let hasImage = _prefixId.prefix "hasImage"
    /// <summary>
    ///   <para>rdfs:label : has manifest file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasManifestFile">okh:hasManifestFile</a>
    /// </summary>
    let hasManifestFile = _prefixId.prefix "hasManifestFile"
    /// <summary>
    ///   <para>rdfs:label : has Manufacturing Instructions^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasManufacturingInstructions">okh:hasManufacturingInstructions</a>
    /// </summary>
    let hasManufacturingInstructions = _prefixId.prefix "hasManufacturingInstructions"
    /// <summary>
    ///   <para>rdfs:label : mass of the component^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasMass">okh:hasMass</a>
    /// </summary>
    let hasMass = _prefixId.prefix "hasMass"
    /// <summary>
    ///   <para>rdfs:comment : https://en.wikibooks.org/wiki/OpenSCAD_User_Manual/Primitive_Solids^^xsd:string</para>
    ///   <para>rdfs:label : outer dimensions using OpenSCAD primitives^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasOuterDimensions">okh:hasOuterDimensions</a>
    /// </summary>
    let hasOuterDimensions = _prefixId.prefix "hasOuterDimensions"
    /// <summary>
    ///   <para>rdfs:comment : design files of this OSH modules have been peer reviewed in a scientific publication^^xsd:string</para>
    ///   <para>rdfs:label : has Publication^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasPublication">okh:hasPublication</a>
    /// </summary>
    let hasPublication = _prefixId.prefix "hasPublication"
    /// <summary>
    ///   <para>rdfs:comment : links to the corresponding Readme^^xsd:string</para>
    ///   <para>rdfs:label : has Readme^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasReadme">okh:hasReadme</a>
    /// </summary>
    let hasReadme = _prefixId.prefix "hasReadme"
    /// <summary>
    ///   <para>rdfs:label : has Software^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasSoftware">okh:hasSoftware</a>
    /// </summary>
    let hasSoftware = _prefixId.prefix "hasSoftware"
    /// <summary>
    ///   <para>rdfs:label : has User Manual^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#hasUserManual">okh:hasUserManual</a>
    /// </summary>
    let hasUserManual = _prefixId.prefix "hasUserManual"
    /// <summary>
    ///   <para>rdfs:label : Installation Guide^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#installationGuide">okh:installationGuide</a>
    /// </summary>
    let installationGuide = _prefixId.prefix "installationGuide"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : organization/individual behind the hardware design (holder of intellectual property)^^xsd:string</para>
    ///   <para>rdfs:label : licensor^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#licensor">okh:licensor</a>
    /// </summary>
    let licensor = _prefixId.prefix "licensor"
    /// <summary>
    ///   <para>rdfs:label : manufacturing process^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#manufacturingProcess">okh:manufacturingProcess</a>
    /// </summary>
    let manufacturingProcess = _prefixId.prefix "manufacturingProcess"
    /// <summary>
    ///   <para>rdfs:label : material^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#material">okh:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : version of OKH specification the metadata is following (different version → different data fields)^^xsd:string</para>
    ///   <para>rdfs:label : OKH version^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#okhv">okh:okhv</a>
    /// </summary>
    let okhv = _prefixId.prefix "okhv"
    /// <summary>
    ///   <para>rdfs:label : OpenSCAD code defining a shape^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#openSCAD">okh:openSCAD</a>
    /// </summary>
    let openSCAD = _prefixId.prefix "openSCAD"
    let openScad = _prefixId.prefix "openScad"
    /// <summary>
    ///   <para>rdfs:comment : organization representing (most) contributors of this project^^xsd:string</para>
    ///   <para>rdfs:label : organization^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#organization">okh:organization</a>
    /// </summary>
    let organization = _prefixId.prefix "organization"
    /// <summary>
    ///   <para>cc:deprecatedOn : 2023-07-11^^xsd:date</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : Permanent file URL - It was not 'permanent', but rather 'frozen in time', and it was alsoThis was used in the karwler, but badly. Things simply should not be done that way, but rather with a separate manifest file, where either everything is frozen, or nothing is, and the manifest file (internally) itsself being marked accordingly.^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#permaURL">okh:permaURL</a>
    /// </summary>
    let permaURL = _prefixId.prefix "permaURL"
    /// <summary>
    ///   <para>rdfs:comment : production-relevant metadata, such as material, manufacturing technology, outer dimensions, smallest tolerance, finest surface roughness^^xsd:string</para>
    ///   <para>rdfs:label : production metadata^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#productionMetadata">okh:productionMetadata</a>
    /// </summary>
    let productionMetadata = _prefixId.prefix "productionMetadata"
    let relatedTsdc = _prefixId.prefix "relatedTsdc"
    /// <summary>
    ///   <para>rdfs:label : Project-/Repo-relative file path, directly starting with the first path element, *NOT* with '/' or './'^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#relativePath">okh:relativePath</a>
    /// </summary>
    let relativePath = _prefixId.prefix "relativePath"
    /// <summary>
    ///   <para>rdfs:comment : URL to release^^xsd:string</para>
    ///   <para>rdfs:label : release^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#release">okh:release</a>
    /// </summary>
    let release = _prefixId.prefix "release"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment :
    ///     URL to the place where development happens (typically the repository)" ;
    ///     following this link people shall be able to contribute to the development
    ///     (reporting issues, suggesting changes, connecting to the team etc.)" </para>
    ///   <para>rdfs:label : repository^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#repo">okh:repo</a>
    /// </summary>
    let repo = _prefixId.prefix "repo"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : platform where the OSH documentation is located (e.g. GitLab, Wikifactory or any self-hosted website or wiki)</para>
    ///   <para>rdfs:label : Repository Host^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#repoHost">okh:repoHost</a>
    /// </summary>
    let repoHost = _prefixId.prefix "repoHost"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : Repoistory snapshot (=specific version) URL^^xsd:string</para>
    ///   <para>rdfs:label : respository snapshot^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#repoSnapshot">okh:repoSnapshot</a>
    /// </summary>
    let repoSnapshot = _prefixId.prefix "repoSnapshot"
    /// <summary>
    ///   <para>rdfs:label : smallest tolerance class (following ISO 286)^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#smallestToleranceClass">okh:smallestToleranceClass</a>
    /// </summary>
    let smallestToleranceClass = _prefixId.prefix "smallestToleranceClass"
    /// <summary>
    ///   <para>rdfs:comment : relative link to a source file^^xsd:string</para>
    ///   <para>rdfs:label : source file^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#source">okh:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : view complete list under https://spdx.org/licenses/^^xsd:string</para>
    ///   <para>rdfs:label : SPDX license identifier^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#spdxLicense">okh:spdxLicense</a>
    /// </summary>
    let spdxLicense = _prefixId.prefix "spdxLicense"
    /// <summary>
    ///   <para>rdfs:label : Document identifier for the technical standard^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#standardID">okh:standardID</a>
    /// </summary>
    let standardID = _prefixId.prefix "standardID"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : …using the OTRL definitions^^xsd:string</para>
    ///   <para>rdfs:label : Technology Readiness Level (TRL)^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#technologyReadinessLevel">okh:technologyReadinessLevel</a>
    /// </summary>
    let technologyReadinessLevel = _prefixId.prefix "technologyReadinessLevel"
    /// <summary>
    ///   <para>rdfs:comment : following ISO 8601; see: &lt;https://www.w3.org/TR/xmlschema11-2/#dateTimeStamp&gt;^^xsd:string</para>
    ///   <para>rdfs:label : timestamp^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#timestamp">okh:timestamp</a>
    /// </summary>
    let timestamp = _prefixId.prefix "timestamp"
    /// <summary>
    ///   <para>rdfs:comment : Applicable Technology-specific Documentation Criteria, according to DIN SPEC 3105-1, e.g. `tsdc:3DP`^^xsd:string</para>
    ///   <para>rdfs:label : TsDC^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#tsdc">okh:tsdc</a>
    /// </summary>
    let tsdc = _prefixId.prefix "tsdc"
    /// <summary>
    ///   <para>rdfs:comment : mm, cm, m, g, kg^^xsd:string</para>
    ///   <para>rdfs:label : unit^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#unit">okh:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : e.g. auto (fully integrated platforms) or manifest file (for connected platforms)</para>
    ///   <para>rdfs:label : Upload Method^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#uploadMethod">okh:uploadMethod</a>
    /// </summary>
    let uploadMethod = _prefixId.prefix "uploadMethod"
    /// <summary>
    ///   <para>rdfs:comment : Global file locator, using either the HTTP or the HTTPS protocol.</para>
    ///   <para>rdfs:label : file URL</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#url">okh:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#value">okh:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:comment : version of this Component, preferably in the semantic versioning scheme (semver.org)^^xsd:string</para>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#version">okh:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>rdfs:comment : connects specific versions of Modules with their versionless superclass^^xsd:string</para>
    ///   <para>rdfs:label : version of^^xsd:string</para>
    ///   <a href="https://w3id.org/oseg/ont/okh#versionOf">okh:versionOf</a>
    /// </summary>
    let versionOf = _prefixId.prefix "versionOf"
