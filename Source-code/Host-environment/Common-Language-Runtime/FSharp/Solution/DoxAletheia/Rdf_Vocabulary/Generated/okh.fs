namespace https.w3id.org.oseg.ont.okh.hash

open DoxAletheia.Rdf_Vocabulary

module okh =
    let _namespace_name = "https://w3id.org/oseg/ont/okh#"

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#AuxiliaryFile"></see>
    /// </summary>
    let AuxiliaryFile =
        Namespaced_IRI.parse _namespace_name "AuxiliaryFile" |> NamespacedName

    /// <summary>
    /// A file that forms part of the project, specified/located either by a URL (okh:url) or a repo-/project-relative path (okh:relativePath).
    /// <see href="https://w3id.org/oseg/ont/okh#File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#BoM"></see>
    /// </summary>
    let BoM = Namespaced_IRI.parse _namespace_name "BoM" |> NamespacedName
    /// <summary>
    /// Either a module (MOSH) or Part (POSH); more component types may be added in the future
    /// <see href="https://w3id.org/oseg/ont/okh#Component"></see></summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName

    /// <summary>
    ///
    ///     others shall be able to identify/procure this component only by the given reference(s),
    ///     MOSH → URL to corresponding release
    ///     POSH → URL to containing folder
    ///     STD  → standard designation (preferably naming the _latest_ standard)
    ///     BUY  → unambiguous reference
    /// <see href="https://w3id.org/oseg/ont/okh#ComponentReference"></see></summary>
    let ComponentReference =
        Namespaced_IRI.parse _namespace_name "ComponentReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#Reference"></see>
    /// </summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#ContributionGuide"></see>
    /// </summary>
    let ContributionGuide =
        Namespaced_IRI.parse _namespace_name "ContributionGuide" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#ExportFile"></see>
    /// </summary>
    let ExportFile = Namespaced_IRI.parse _namespace_name "ExportFile" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#FileUrl"></see>
    /// </summary>
    let FileUrl = Namespaced_IRI.parse _namespace_name "FileUrl" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// file holding the metadata
    /// <see href="https://w3id.org/oseg/ont/okh#ManifestFile"></see></summary>
    let ManifestFile =
        Namespaced_IRI.parse _namespace_name "ManifestFile" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#ManufacturingInstructions"></see>
    /// </summary>
    let ManufacturingInstructions =
        Namespaced_IRI.parse _namespace_name "ManufacturingInstructions" |> NamespacedName

    /// <summary>
    /// …of a module or a part
    /// <see href="https://w3id.org/oseg/ont/okh#Mass"></see></summary>
    let Mass = Namespaced_IRI.parse _namespace_name "Mass" |> NamespacedName
    /// <summary>
    /// Module of Open Source Hardware (MOSH)
    /// <see href="https://w3id.org/oseg/ont/okh#Module"></see></summary>
    let Module = Namespaced_IRI.parse _namespace_name "Module" |> NamespacedName

    /// <summary>
    /// …of a module or a part
    /// <see href="https://w3id.org/oseg/ont/okh#OuterDimensions"></see></summary>
    let OuterDimensions =
        Namespaced_IRI.parse _namespace_name "OuterDimensions" |> NamespacedName

    /// <summary>
    /// Piece of Open Source Hardware (POSH)
    /// <see href="https://w3id.org/oseg/ont/okh#Part"></see></summary>
    let Part = Namespaced_IRI.parse _namespace_name "Part" |> NamespacedName

    /// <summary>
    /// _scientific_ (that is: peer reviewed) publication that _contains_ the design files
    /// <see href="https://w3id.org/oseg/ont/okh#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#Readme"></see>
    /// </summary>
    let Readme = Namespaced_IRI.parse _namespace_name "Readme" |> NamespacedName
    /// <summary>
    /// Software (including firmware) needed to run &amp; use the OSH
    /// <see href="https://w3id.org/oseg/ont/okh#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#SourceFile"></see>
    /// </summary>
    let SourceFile = Namespaced_IRI.parse _namespace_name "SourceFile" |> NamespacedName
    /// <summary>
    /// official standard used in the _design_ (not e.g. DIN SPEC 3105-1)
    /// <see href="https://w3id.org/oseg/ont/okh#Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#UserManual"></see>
    /// </summary>
    let UserManual = Namespaced_IRI.parse _namespace_name "UserManual" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#WebsiteUrl"></see>
    /// </summary>
    let WebsiteUrl = Namespaced_IRI.parse _namespace_name "WebsiteUrl" |> NamespacedName

    /// <summary>
    /// URL to legal code of a license without SPDX identifier, hence OSHWA-compliance is to be checked manually
    /// <see href="https://w3id.org/oseg/ont/okh#alternativeLicense"></see></summary>
    let alternativeLicense =
        Namespaced_IRI.parse _namespace_name "alternativeLicense" |> NamespacedName

    /// <summary>
    /// permanent URL to evidence of compliance (OSHWA, FSF, DIN SPEC 3105)
    /// <see href="https://w3id.org/oseg/ont/okh#attestation"></see></summary>
    let attestation =
        Namespaced_IRI.parse _namespace_name "attestation" |> NamespacedName

    /// <summary>
    /// reference to an auxiliary file
    /// <see href="https://w3id.org/oseg/ont/okh#auxiliary"></see></summary>
    let auxiliary = Namespaced_IRI.parse _namespace_name "auxiliary" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#compliesWith"></see>
    /// </summary>
    let compliesWith =
        Namespaced_IRI.parse _namespace_name "compliesWith" |> NamespacedName

    /// <summary>
    /// International Patent Classification (IPC)
    /// <see href="https://w3id.org/oseg/ont/okh#cpcPatentClass"></see></summary>
    let cpcPatentClass =
        Namespaced_IRI.parse _namespace_name "cpcPatentClass" |> NamespacedName

    /// <summary>
    /// platform, where the crawler found the metadata (e.g. GitHub, Wikifactory)
    /// <see href="https://w3id.org/oseg/ont/okh#dataSource"></see></summary>
    let dataSource = Namespaced_IRI.parse _namespace_name "dataSource" |> NamespacedName

    /// <summary>
    ///
    ///    IETF language tag
    ///    following the BCP 47 standard e.g. en-GB
    ///    denotes the language of the documentation for the component subject
    /// <see href="https://w3id.org/oseg/ont/okh#documentationLanguage"></see></summary>
    let documentationLanguage =
        Namespaced_IRI.parse _namespace_name "documentationLanguage" |> NamespacedName

    /// <summary>
    /// …using the ODRL definitions
    /// <see href="https://w3id.org/oseg/ont/okh#documentationReadinessLevel"></see></summary>
    let documentationReadinessLevel =
        Namespaced_IRI.parse _namespace_name "documentationReadinessLevel" |> NamespacedName

    /// <summary>
    /// this publication has a digital object identifier (DOI)
    /// <see href="https://w3id.org/oseg/ont/okh#doi"></see></summary>
    let doi = Namespaced_IRI.parse _namespace_name "doi" |> NamespacedName
    /// <summary>
    /// URL to a (generated) exported source file
    /// <see href="https://w3id.org/oseg/ont/okh#export"></see></summary>
    let export = Namespaced_IRI.parse _namespace_name "export" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#fileFormat"></see>
    /// </summary>
    let fileFormat = Namespaced_IRI.parse _namespace_name "fileFormat" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#fileUrl"></see>
    /// </summary>
    let fileUrl = Namespaced_IRI.parse _namespace_name "fileUrl" |> NamespacedName
    /// <summary>
    /// Global file locator, using either the HTTP or the HTTPS protocol.
    /// <see href="https://w3id.org/oseg/ont/okh#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#forkOf"></see>
    /// </summary>
    let forkOf = Namespaced_IRI.parse _namespace_name "forkOf" |> NamespacedName
    /// <summary>
    ///
    ///     functional description, e.g. what it actually does, what problem it solves, for whom, under which conditions etc.
    ///     so if you wish that someone finds &amp; uses your okh specifically e.g. for COVID-19-crisis response, include relevant keywords in this field
    ///     optional: description of input, output and interfaces
    /// <see href="https://w3id.org/oseg/ont/okh#function"></see></summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName

    /// <summary>
    /// Metadata addressing functionality, such as dimensions, material, weight, RPM,… (not standardized)
    /// <see href="https://w3id.org/oseg/ont/okh#functionalMetadata"></see></summary>
    let functionalMetadata =
        Namespaced_IRI.parse _namespace_name "functionalMetadata" |> NamespacedName

    /// <summary>
    /// links to the corresponding Bill of Materials
    /// <see href="https://w3id.org/oseg/ont/okh#hasBoM"></see></summary>
    let hasBoM = Namespaced_IRI.parse _namespace_name "hasBoM" |> NamespacedName

    /// <summary>
    /// Links to sub-components of the Module. In the case of that sub-component being an external Module, it has to refer to a snapshot of the RDF object representing that OKH Module. Each sub-component should also appear in the BoM.
    /// <see href="https://w3id.org/oseg/ont/okh#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// links to the corresponding Contribution Guide
    /// <see href="https://w3id.org/oseg/ont/okh#hasContributionGuide"></see></summary>
    let hasContributionGuide =
        Namespaced_IRI.parse _namespace_name "hasContributionGuide" |> NamespacedName

    /// <summary>
    /// links to the corresponding Image
    /// <see href="https://w3id.org/oseg/ont/okh#hasImage"></see></summary>
    let hasImage = Namespaced_IRI.parse _namespace_name "hasImage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasManifestFile"></see>
    /// </summary>
    let hasManifestFile =
        Namespaced_IRI.parse _namespace_name "hasManifestFile" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasManufacturingInstructions"></see>
    /// </summary>
    let hasManufacturingInstructions =
        Namespaced_IRI.parse _namespace_name "hasManufacturingInstructions" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasMass"></see>
    /// </summary>
    let hasMass = Namespaced_IRI.parse _namespace_name "hasMass" |> NamespacedName

    /// <summary>
    /// production-relevant metadata, such as material, manufacturing technology, outer dimensions, smallest tolerance, finest surface roughness
    /// <see href="https://w3id.org/oseg/ont/okh#productionMetadata"></see></summary>
    let productionMetadata =
        Namespaced_IRI.parse _namespace_name "productionMetadata" |> NamespacedName

    /// <summary>
    /// https://en.wikibooks.org/wiki/OpenSCAD_User_Manual/Primitive_Solids
    /// <see href="https://w3id.org/oseg/ont/okh#hasOuterDimensions"></see></summary>
    let hasOuterDimensions =
        Namespaced_IRI.parse _namespace_name "hasOuterDimensions" |> NamespacedName

    /// <summary>
    /// design files of this OSH modules have been peer reviewed in a scientific publication
    /// <see href="https://w3id.org/oseg/ont/okh#hasPublication"></see></summary>
    let hasPublication =
        Namespaced_IRI.parse _namespace_name "hasPublication" |> NamespacedName

    /// <summary>
    /// links to the corresponding Readme
    /// <see href="https://w3id.org/oseg/ont/okh#hasReadme"></see></summary>
    let hasReadme = Namespaced_IRI.parse _namespace_name "hasReadme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasSoftware"></see>
    /// </summary>
    let hasSoftware =
        Namespaced_IRI.parse _namespace_name "hasSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#hasUserManual"></see>
    /// </summary>
    let hasUserManual =
        Namespaced_IRI.parse _namespace_name "hasUserManual" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#installationGuide"></see>
    /// </summary>
    let installationGuide =
        Namespaced_IRI.parse _namespace_name "installationGuide" |> NamespacedName

    /// <summary>
    /// organization/individual behind the hardware design (holder of intellectual property)
    /// <see href="https://w3id.org/oseg/ont/okh#licensor"></see></summary>
    let licensor = Namespaced_IRI.parse _namespace_name "licensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#manufacturingProcess"></see>
    /// </summary>
    let manufacturingProcess =
        Namespaced_IRI.parse _namespace_name "manufacturingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#material"></see>
    /// </summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName
    /// <summary>
    /// version of OKH specification the metadata is following (different version → different data fields)
    /// <see href="https://w3id.org/oseg/ont/okh#okhv"></see></summary>
    let okhv = Namespaced_IRI.parse _namespace_name "okhv" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#openSCAD"></see>
    /// </summary>
    let openSCAD = Namespaced_IRI.parse _namespace_name "openSCAD" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#openScad"></see>
    /// </summary>
    let openScad = Namespaced_IRI.parse _namespace_name "openScad" |> NamespacedName

    /// <summary>
    /// organization representing (most) contributors of this project
    /// <see href="https://w3id.org/oseg/ont/okh#organization"></see></summary>
    let organization =
        Namespaced_IRI.parse _namespace_name "organization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#permaURL"></see>
    /// </summary>
    let permaURL = Namespaced_IRI.parse _namespace_name "permaURL" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#relatedTsdc"></see>
    /// </summary>
    let relatedTsdc =
        Namespaced_IRI.parse _namespace_name "relatedTsdc" |> NamespacedName

    /// <summary>
    /// Applicable Technology-specific Documentation Criteria, according to DIN SPEC 3105-1, e.g. `tsdc:3DP`
    /// <see href="https://w3id.org/oseg/ont/okh#tsdc"></see></summary>
    let tsdc = Namespaced_IRI.parse _namespace_name "tsdc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#relativePath"></see>
    /// </summary>
    let relativePath =
        Namespaced_IRI.parse _namespace_name "relativePath" |> NamespacedName

    /// <summary>
    /// URL to release
    /// <see href="https://w3id.org/oseg/ont/okh#release"></see></summary>
    let release = Namespaced_IRI.parse _namespace_name "release" |> NamespacedName
    /// <summary>
    ///
    ///     URL to the place where development happens (typically the repository)" ;
    ///     following this link people shall be able to contribute to the development
    ///     (reporting issues, suggesting changes, connecting to the team etc.)"
    /// <see href="https://w3id.org/oseg/ont/okh#repo"></see></summary>
    let repo = Namespaced_IRI.parse _namespace_name "repo" |> NamespacedName
    /// <summary>
    /// platform where the OSH documentation is located (e.g. GitLab, Wikifactory or any self-hosted website or wiki)
    /// <see href="https://w3id.org/oseg/ont/okh#repoHost"></see></summary>
    let repoHost = Namespaced_IRI.parse _namespace_name "repoHost" |> NamespacedName

    /// <summary>
    /// Repoistory snapshot (=specific version) URL
    /// <see href="https://w3id.org/oseg/ont/okh#repoSnapshot"></see></summary>
    let repoSnapshot =
        Namespaced_IRI.parse _namespace_name "repoSnapshot" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#smallestToleranceClass"></see>
    /// </summary>
    let smallestToleranceClass =
        Namespaced_IRI.parse _namespace_name "smallestToleranceClass" |> NamespacedName

    /// <summary>
    /// relative link to a source file
    /// <see href="https://w3id.org/oseg/ont/okh#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    /// view complete list under https://spdx.org/licenses/
    /// <see href="https://w3id.org/oseg/ont/okh#spdxLicense"></see></summary>
    let spdxLicense =
        Namespaced_IRI.parse _namespace_name "spdxLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#standardID"></see>
    /// </summary>
    let standardID = Namespaced_IRI.parse _namespace_name "standardID" |> NamespacedName

    /// <summary>
    /// …using the OTRL definitions
    /// <see href="https://w3id.org/oseg/ont/okh#technologyReadinessLevel"></see></summary>
    let technologyReadinessLevel =
        Namespaced_IRI.parse _namespace_name "technologyReadinessLevel" |> NamespacedName

    /// <summary>
    /// following ISO 8601; see: &lt;https://www.w3.org/TR/xmlschema11-2/#dateTimeStamp&gt;
    /// <see href="https://w3id.org/oseg/ont/okh#timestamp"></see></summary>
    let timestamp = Namespaced_IRI.parse _namespace_name "timestamp" |> NamespacedName
    /// <summary>
    /// mm, cm, m, g, kg
    /// <see href="https://w3id.org/oseg/ont/okh#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName

    /// <summary>
    /// e.g. auto (fully integrated platforms) or manifest file (for connected platforms)
    /// <see href="https://w3id.org/oseg/ont/okh#uploadMethod"></see></summary>
    let uploadMethod =
        Namespaced_IRI.parse _namespace_name "uploadMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/oseg/ont/okh#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// version of this Component, preferably in the semantic versioning scheme (semver.org)
    /// <see href="https://w3id.org/oseg/ont/okh#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    /// connects specific versions of Modules with their versionless superclass
    /// <see href="https://w3id.org/oseg/ont/okh#versionOf"></see></summary>
    let versionOf = Namespaced_IRI.parse _namespace_name "versionOf" |> NamespacedName
