namespace https.w3id.org.oseg.ont.okh.hash

open DoxAletheia

module okh =
    let _namespace_name = "https://w3id.org/oseg/ont/okh#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#AuxiliaryFile"></see>
    /// </summary>
    let AuxiliaryFile = _prefix "AuxiliaryFile"
    /// <summary>
    /// A file that forms part of the project, specified/located either by a URL (okh:url) or a repo-/project-relative path (okh:relativePath).
    /// <see href="https://w3id.org/oseg/ont/okh#File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#BoM"></see>
    /// </summary>
    let BoM = _prefix "BoM"
    /// <summary>
    /// Either a module (MOSH) or Part (POSH); more component types may be added in the future
    /// <see href="https://w3id.org/oseg/ont/okh#Component"></see></summary>
    let Component = _prefix "Component"
    /// <summary>
    ///
    ///     others shall be able to identify/procure this component only by the given reference(s),
    ///     MOSH → URL to corresponding release
    ///     POSH → URL to containing folder
    ///     STD  → standard designation (preferably naming the _latest_ standard)
    ///     BUY  → unambiguous reference
    /// <see href="https://w3id.org/oseg/ont/okh#ComponentReference"></see></summary>
    let ComponentReference = _prefix "ComponentReference"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#Reference"></see>
    /// </summary>
    let Reference = _prefix "Reference"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#ContributionGuide"></see>
    /// </summary>
    let ContributionGuide = _prefix "ContributionGuide"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#ExportFile"></see>
    /// </summary>
    let ExportFile = _prefix "ExportFile"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#FileUrl"></see>
    /// </summary>
    let FileUrl = _prefix "FileUrl"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    /// file holding the metadata
    /// <see href="https://w3id.org/oseg/ont/okh#ManifestFile"></see></summary>
    let ManifestFile = _prefix "ManifestFile"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#ManufacturingInstructions"></see>
    /// </summary>
    let ManufacturingInstructions = _prefix "ManufacturingInstructions"
    /// <summary>
    /// …of a module or a part
    /// <see href="https://w3id.org/oseg/ont/okh#Mass"></see></summary>
    let Mass = _prefix "Mass"
    /// <summary>
    /// Module of Open Source Hardware (MOSH)
    /// <see href="https://w3id.org/oseg/ont/okh#Module"></see></summary>
    let Module = _prefix "Module"
    /// <summary>
    /// …of a module or a part
    /// <see href="https://w3id.org/oseg/ont/okh#OuterDimensions"></see></summary>
    let OuterDimensions = _prefix "OuterDimensions"
    /// <summary>
    /// Piece of Open Source Hardware (POSH)
    /// <see href="https://w3id.org/oseg/ont/okh#Part"></see></summary>
    let Part = _prefix "Part"
    /// <summary>
    /// _scientific_ (that is: peer reviewed) publication that _contains_ the design files
    /// <see href="https://w3id.org/oseg/ont/okh#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#Readme"></see>
    /// </summary>
    let Readme = _prefix "Readme"
    /// <summary>
    /// Software (including firmware) needed to run &amp; use the OSH
    /// <see href="https://w3id.org/oseg/ont/okh#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#SourceFile"></see>
    /// </summary>
    let SourceFile = _prefix "SourceFile"
    /// <summary>
    /// official standard used in the _design_ (not e.g. DIN SPEC 3105-1)
    /// <see href="https://w3id.org/oseg/ont/okh#Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#UserManual"></see>
    /// </summary>
    let UserManual = _prefix "UserManual"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#WebsiteUrl"></see>
    /// </summary>
    let WebsiteUrl = _prefix "WebsiteUrl"
    /// <summary>
    /// URL to legal code of a license without SPDX identifier, hence OSHWA-compliance is to be checked manually
    /// <see href="https://w3id.org/oseg/ont/okh#alternativeLicense"></see></summary>
    let alternativeLicense = _prefix "alternativeLicense"
    /// <summary>
    /// permanent URL to evidence of compliance (OSHWA, FSF, DIN SPEC 3105)
    /// <see href="https://w3id.org/oseg/ont/okh#attestation"></see></summary>
    let attestation = _prefix "attestation"
    /// <summary>
    /// reference to an auxiliary file
    /// <see href="https://w3id.org/oseg/ont/okh#auxiliary"></see></summary>
    let auxiliary = _prefix "auxiliary"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#compliesWith"></see>
    /// </summary>
    let compliesWith = _prefix "compliesWith"
    /// <summary>
    /// International Patent Classification (IPC)
    /// <see href="https://w3id.org/oseg/ont/okh#cpcPatentClass"></see></summary>
    let cpcPatentClass = _prefix "cpcPatentClass"
    /// <summary>
    /// platform, where the crawler found the metadata (e.g. GitHub, Wikifactory)
    /// <see href="https://w3id.org/oseg/ont/okh#dataSource"></see></summary>
    let dataSource = _prefix "dataSource"
    /// <summary>
    ///
    ///    IETF language tag
    ///    following the BCP 47 standard e.g. en-GB
    ///    denotes the language of the documentation for the component subject
    /// <see href="https://w3id.org/oseg/ont/okh#documentationLanguage"></see></summary>
    let documentationLanguage = _prefix "documentationLanguage"
    /// <summary>
    /// …using the ODRL definitions
    /// <see href="https://w3id.org/oseg/ont/okh#documentationReadinessLevel"></see></summary>
    let documentationReadinessLevel = _prefix "documentationReadinessLevel"
    /// <summary>
    /// this publication has a digital object identifier (DOI)
    /// <see href="https://w3id.org/oseg/ont/okh#doi"></see></summary>
    let doi = _prefix "doi"
    /// <summary>
    /// URL to a (generated) exported source file
    /// <see href="https://w3id.org/oseg/ont/okh#export"></see></summary>
    let export = _prefix "export"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#fileFormat"></see>
    /// </summary>
    let fileFormat = _prefix "fileFormat"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#fileUrl"></see>
    /// </summary>
    let fileUrl = _prefix "fileUrl"
    /// <summary>
    /// Global file locator, using either the HTTP or the HTTPS protocol.
    /// <see href="https://w3id.org/oseg/ont/okh#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#forkOf"></see>
    /// </summary>
    let forkOf = _prefix "forkOf"
    /// <summary>
    ///
    ///     functional description, e.g. what it actually does, what problem it solves, for whom, under which conditions etc.
    ///     so if you wish that someone finds &amp; uses your okh specifically e.g. for COVID-19-crisis response, include relevant keywords in this field
    ///     optional: description of input, output and interfaces
    /// <see href="https://w3id.org/oseg/ont/okh#function"></see></summary>
    let function_ = _prefix "function"
    /// <summary>
    /// Metadata addressing functionality, such as dimensions, material, weight, RPM,… (not standardized)
    /// <see href="https://w3id.org/oseg/ont/okh#functionalMetadata"></see></summary>
    let functionalMetadata = _prefix "functionalMetadata"
    /// <summary>
    /// links to the corresponding Bill of Materials
    /// <see href="https://w3id.org/oseg/ont/okh#hasBoM"></see></summary>
    let hasBoM = _prefix "hasBoM"
    /// <summary>
    /// Links to sub-components of the Module. In the case of that sub-component being an external Module, it has to refer to a snapshot of the RDF object representing that OKH Module. Each sub-component should also appear in the BoM.
    /// <see href="https://w3id.org/oseg/ont/okh#hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// links to the corresponding Contribution Guide
    /// <see href="https://w3id.org/oseg/ont/okh#hasContributionGuide"></see></summary>
    let hasContributionGuide = _prefix "hasContributionGuide"
    /// <summary>
    /// links to the corresponding Image
    /// <see href="https://w3id.org/oseg/ont/okh#hasImage"></see></summary>
    let hasImage = _prefix "hasImage"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasManifestFile"></see>
    /// </summary>
    let hasManifestFile = _prefix "hasManifestFile"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasManufacturingInstructions"></see>
    /// </summary>
    let hasManufacturingInstructions = _prefix "hasManufacturingInstructions"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasMass"></see>
    /// </summary>
    let hasMass = _prefix "hasMass"
    /// <summary>
    /// production-relevant metadata, such as material, manufacturing technology, outer dimensions, smallest tolerance, finest surface roughness
    /// <see href="https://w3id.org/oseg/ont/okh#productionMetadata"></see></summary>
    let productionMetadata = _prefix "productionMetadata"
    /// <summary>
    /// https://en.wikibooks.org/wiki/OpenSCAD_User_Manual/Primitive_Solids
    /// <see href="https://w3id.org/oseg/ont/okh#hasOuterDimensions"></see></summary>
    let hasOuterDimensions = _prefix "hasOuterDimensions"
    /// <summary>
    /// design files of this OSH modules have been peer reviewed in a scientific publication
    /// <see href="https://w3id.org/oseg/ont/okh#hasPublication"></see></summary>
    let hasPublication = _prefix "hasPublication"
    /// <summary>
    /// links to the corresponding Readme
    /// <see href="https://w3id.org/oseg/ont/okh#hasReadme"></see></summary>
    let hasReadme = _prefix "hasReadme"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasSoftware"></see>
    /// </summary>
    let hasSoftware = _prefix "hasSoftware"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasUserManual"></see>
    /// </summary>
    let hasUserManual = _prefix "hasUserManual"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#installationGuide"></see>
    /// </summary>
    let installationGuide = _prefix "installationGuide"
    /// <summary>
    /// organization/individual behind the hardware design (holder of intellectual property)
    /// <see href="https://w3id.org/oseg/ont/okh#licensor"></see></summary>
    let licensor = _prefix "licensor"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#manufacturingProcess"></see>
    /// </summary>
    let manufacturingProcess = _prefix "manufacturingProcess"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#material"></see>
    /// </summary>
    let material = _prefix "material"
    /// <summary>
    /// version of OKH specification the metadata is following (different version → different data fields)
    /// <see href="https://w3id.org/oseg/ont/okh#okhv"></see></summary>
    let okhv = _prefix "okhv"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#openSCAD"></see>
    /// </summary>
    let openSCAD = _prefix "openSCAD"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#openScad"></see>
    /// </summary>
    let openScad = _prefix "openScad"
    /// <summary>
    /// organization representing (most) contributors of this project
    /// <see href="https://w3id.org/oseg/ont/okh#organization"></see></summary>
    let organization = _prefix "organization"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#permaURL"></see>
    /// </summary>
    let permaURL = _prefix "permaURL"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#relatedTsdc"></see>
    /// </summary>
    let relatedTsdc = _prefix "relatedTsdc"
    /// <summary>
    /// Applicable Technology-specific Documentation Criteria, according to DIN SPEC 3105-1, e.g. `tsdc:3DP`
    /// <see href="https://w3id.org/oseg/ont/okh#tsdc"></see></summary>
    let tsdc = _prefix "tsdc"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#relativePath"></see>
    /// </summary>
    let relativePath = _prefix "relativePath"
    /// <summary>
    /// URL to release
    /// <see href="https://w3id.org/oseg/ont/okh#release"></see></summary>
    let release = _prefix "release"
    /// <summary>
    ///
    ///     URL to the place where development happens (typically the repository)" ;
    ///     following this link people shall be able to contribute to the development
    ///     (reporting issues, suggesting changes, connecting to the team etc.)"
    /// <see href="https://w3id.org/oseg/ont/okh#repo"></see></summary>
    let repo = _prefix "repo"
    /// <summary>
    /// platform where the OSH documentation is located (e.g. GitLab, Wikifactory or any self-hosted website or wiki)
    /// <see href="https://w3id.org/oseg/ont/okh#repoHost"></see></summary>
    let repoHost = _prefix "repoHost"
    /// <summary>
    /// Repoistory snapshot (=specific version) URL
    /// <see href="https://w3id.org/oseg/ont/okh#repoSnapshot"></see></summary>
    let repoSnapshot = _prefix "repoSnapshot"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#smallestToleranceClass"></see>
    /// </summary>
    let smallestToleranceClass = _prefix "smallestToleranceClass"
    /// <summary>
    /// relative link to a source file
    /// <see href="https://w3id.org/oseg/ont/okh#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// view complete list under https://spdx.org/licenses/
    /// <see href="https://w3id.org/oseg/ont/okh#spdxLicense"></see></summary>
    let spdxLicense = _prefix "spdxLicense"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#standardID"></see>
    /// </summary>
    let standardID = _prefix "standardID"
    /// <summary>
    /// …using the OTRL definitions
    /// <see href="https://w3id.org/oseg/ont/okh#technologyReadinessLevel"></see></summary>
    let technologyReadinessLevel = _prefix "technologyReadinessLevel"
    /// <summary>
    /// following ISO 8601; see: &lt;https://www.w3.org/TR/xmlschema11-2/#dateTimeStamp&gt;
    /// <see href="https://w3id.org/oseg/ont/okh#timestamp"></see></summary>
    let timestamp = _prefix "timestamp"
    /// <summary>
    /// mm, cm, m, g, kg
    /// <see href="https://w3id.org/oseg/ont/okh#unit"></see></summary>
    let unit = _prefix "unit"
    /// <summary>
    /// e.g. auto (fully integrated platforms) or manifest file (for connected platforms)
    /// <see href="https://w3id.org/oseg/ont/okh#uploadMethod"></see></summary>
    let uploadMethod = _prefix "uploadMethod"
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    /// version of this Component, preferably in the semantic versioning scheme (semver.org)
    /// <see href="https://w3id.org/oseg/ont/okh#version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// connects specific versions of Modules with their versionless superclass
    /// <see href="https://w3id.org/oseg/ont/okh#versionOf"></see></summary>
    let versionOf = _prefix "versionOf"
