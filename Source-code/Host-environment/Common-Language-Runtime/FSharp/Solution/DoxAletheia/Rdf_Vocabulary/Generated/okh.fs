namespace https.w3id.org.oseg.ont.okh.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module okh =
    let _namespace_iri = Namespace_Iri okh |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#AuxiliaryFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"auxiliary file (neither source nor export)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#AuxiliaryFile">https://w3id.org/oseg/ont/okh#AuxiliaryFile</seealso>
    let AuxiliaryFile = Prefixed_Name(okh, "AuxiliaryFile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#BoM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bill of Materials"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#BoM">https://w3id.org/oseg/ont/okh#BoM</seealso>
    let BoM = Prefixed_Name(okh, "BoM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Either a module (MOSH) or Part (POSH); more component types may be added in the future"</para>
    /// labels<para>"Component"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Component">https://w3id.org/oseg/ont/okh#Component</seealso>
    let Component = Prefixed_Name(okh, "Component") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#ComponentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///     others shall be able to identify/procure this component only by the given reference(s),
    ///     MOSH → URL to corresponding release
    ///     POSH → URL to containing folder
    ///     STD  → standard designation (preferably naming the _latest_ standard)
    ///     BUY  → unambiguous reference"</para>
    /// labels<para>"Component Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#ComponentReference">https://w3id.org/oseg/ont/okh#ComponentReference</seealso>
    let ComponentReference = Prefixed_Name(okh, "ComponentReference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#ContributionGuide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contribution Guide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#ContributionGuide">https://w3id.org/oseg/ont/okh#ContributionGuide</seealso>
    let ContributionGuide = Prefixed_Name(okh, "ContributionGuide") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#ExportFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exported source file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#ExportFile">https://w3id.org/oseg/ont/okh#ExportFile</seealso>
    let ExportFile = Prefixed_Name(okh, "ExportFile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A file that forms part of the project, specified/located either by a URL (okh:url) or a repo-/project-relative path (okh:relativePath)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"File"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#File">https://w3id.org/oseg/ont/okh#File</seealso>
    let File = Prefixed_Name(okh, "File") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#FileUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"permanent URL to file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#FileUrl">https://w3id.org/oseg/ont/okh#FileUrl</seealso>
    let FileUrl = Prefixed_Name(okh, "FileUrl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Image">https://w3id.org/oseg/ont/okh#Image</seealso>
    let Image = Prefixed_Name(okh, "Image") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#ManifestFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"file holding the metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"manifest file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#ManifestFile">https://w3id.org/oseg/ont/okh#ManifestFile</seealso>
    let ManifestFile = Prefixed_Name(okh, "ManifestFile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#ManufacturingInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Manufacturing Instructions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#ManufacturingInstructions">https://w3id.org/oseg/ont/okh#ManufacturingInstructions</seealso>
    let ManufacturingInstructions =
        Prefixed_Name(okh, "ManufacturingInstructions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"…of a module or a part"</para>
    /// labels<para>"mass"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Mass">https://w3id.org/oseg/ont/okh#Mass</seealso>
    let Mass = Prefixed_Name(okh, "Mass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Module</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Module of Open Source Hardware (MOSH)"</para>
    /// labels<para>"Module"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Module">https://w3id.org/oseg/ont/okh#Module</seealso>
    let Module = Prefixed_Name(okh, "Module") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#OuterDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"…of a module or a part"</para>
    /// labels<para>"outer dimensions"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#OuterDimensions">https://w3id.org/oseg/ont/okh#OuterDimensions</seealso>
    let OuterDimensions = Prefixed_Name(okh, "OuterDimensions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Piece of Open Source Hardware (POSH)"</para>
    /// labels<para>"Part"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Part">https://w3id.org/oseg/ont/okh#Part</seealso>
    let Part = Prefixed_Name(okh, "Part") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"_scientific_ (that is: peer reviewed) publication that _contains_ the design files"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scientific Publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Publication">https://w3id.org/oseg/ont/okh#Publication</seealso>
    let Publication = Prefixed_Name(okh, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Readme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Readme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Readme">https://w3id.org/oseg/ont/okh#Readme</seealso>
    let Readme = Prefixed_Name(okh, "Readme") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unambiguous reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Reference">https://w3id.org/oseg/ont/okh#Reference</seealso>
    let Reference = Prefixed_Name(okh, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Software (including firmware) needed to run &amp; use the OSH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Software">https://w3id.org/oseg/ont/okh#Software</seealso>
    let Software = Prefixed_Name(okh, "Software") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#SourceFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"source file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#SourceFile">https://w3id.org/oseg/ont/okh#SourceFile</seealso>
    let SourceFile = Prefixed_Name(okh, "SourceFile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"official standard used in the _design_ (not e.g. DIN SPEC 3105-1)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Technical Standard"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#Standard">https://w3id.org/oseg/ont/okh#Standard</seealso>
    let Standard = Prefixed_Name(okh, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#UserManual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"User Manual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#UserManual">https://w3id.org/oseg/ont/okh#UserManual</seealso>
    let UserManual = Prefixed_Name(okh, "UserManual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#WebsiteUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Website URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#WebsiteUrl">https://w3id.org/oseg/ont/okh#WebsiteUrl</seealso>
    let WebsiteUrl = Prefixed_Name(okh, "WebsiteUrl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#alternativeLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"URL to legal code of a license without SPDX identifier, hence OSHWA-compliance is to be checked manually"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"non-SPDX license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#alternativeLicense">https://w3id.org/oseg/ont/okh#alternativeLicense</seealso>
    let alternativeLicense = Prefixed_Name(okh, "alternativeLicense") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#attestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"permanent URL to evidence of compliance (OSHWA, FSF, DIN SPEC 3105)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attestation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#attestation">https://w3id.org/oseg/ont/okh#attestation</seealso>
    let attestation = Prefixed_Name(okh, "attestation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#auxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"reference to an auxiliary file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has auxiliary file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#auxiliary">https://w3id.org/oseg/ont/okh#auxiliary</seealso>
    let auxiliary = Prefixed_Name(okh, "auxiliary") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#compliesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"complies with a technical standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#compliesWith">https://w3id.org/oseg/ont/okh#compliesWith</seealso>
    let compliesWith = Prefixed_Name(okh, "compliesWith") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#cpcPatentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"International Patent Classification (IPC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Patent Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#cpcPatentClass">https://w3id.org/oseg/ont/okh#cpcPatentClass</seealso>
    let cpcPatentClass = Prefixed_Name(okh, "cpcPatentClass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#dataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"platform, where the crawler found the metadata (e.g. GitHub, Wikifactory)"</para>
    /// labels<para>"Metadata Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#dataSource">https://w3id.org/oseg/ont/okh#dataSource</seealso>
    let dataSource = Prefixed_Name(okh, "dataSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#documentationLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///    IETF language tag
    ///    following the BCP 47 standard e.g. en-GB
    ///    denotes the language of the documentation for the component subject "</para>
    /// labels<para>"documentation language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#documentationLanguage">https://w3id.org/oseg/ont/okh#documentationLanguage</seealso>
    let documentationLanguage =
        Prefixed_Name(okh, "documentationLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#documentationReadinessLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"…using the ODRL definitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Documentation Readiness Level (DLR)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#documentationReadinessLevel">https://w3id.org/oseg/ont/okh#documentationReadinessLevel</seealso>
    let documentationReadinessLevel =
        Prefixed_Name(okh, "documentationReadinessLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#doi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"this publication has a digital object identifier (DOI)"</para>
    /// labels<para>"DOI"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#doi">https://w3id.org/oseg/ont/okh#doi</seealso>
    let doi = Prefixed_Name(okh, "doi") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#export</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"URL to a (generated) exported source file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exported source file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#export">https://w3id.org/oseg/ont/okh#export</seealso>
    let export = Prefixed_Name(okh, "export") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#fileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"file format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#fileFormat">https://w3id.org/oseg/ont/okh#fileFormat</seealso>
    let fileFormat = Prefixed_Name(okh, "fileFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#fileUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"file URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#fileUrl">https://w3id.org/oseg/ont/okh#fileUrl</seealso>
    let fileUrl = Prefixed_Name(okh, "fileUrl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#forkOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"fork of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#forkOf">https://w3id.org/oseg/ont/okh#forkOf</seealso>
    let forkOf = Prefixed_Name(okh, "forkOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///     functional description, e.g. what it actually does, what problem it solves, for whom, under which conditions etc.
    ///     so if you wish that someone finds &amp; uses your okh specifically e.g. for COVID-19-crisis response, include relevant keywords in this field
    ///     optional: description of input, output and interfaces"</para>
    /// labels<para>"functional description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#function">https://w3id.org/oseg/ont/okh#function</seealso>
    let function_ = Prefixed_Name(okh, "function") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#functionalMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Metadata addressing functionality, such as dimensions, material, weight, RPM,… (not standardized)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"functionality metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#functionalMetadata">https://w3id.org/oseg/ont/okh#functionalMetadata</seealso>
    let functionalMetadata = Prefixed_Name(okh, "functionalMetadata") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasBoM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links to the corresponding Bill of Materials"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Bill of Materials"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasBoM">https://w3id.org/oseg/ont/okh#hasBoM</seealso>
    let hasBoM = Prefixed_Name(okh, "hasBoM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links to sub-components of the Module. In the case of that sub-component being an external Module, it has to refer to a snapshot of the RDF object representing that OKH Module. Each sub-component should also appear in the BoM."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasComponent">https://w3id.org/oseg/ont/okh#hasComponent</seealso>
    let hasComponent = Prefixed_Name(okh, "hasComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasContributionGuide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links to the corresponding Contribution Guide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Contribution Guide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasContributionGuide">https://w3id.org/oseg/ont/okh#hasContributionGuide</seealso>
    let hasContributionGuide =
        Prefixed_Name(okh, "hasContributionGuide") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links to the corresponding Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasImage">https://w3id.org/oseg/ont/okh#hasImage</seealso>
    let hasImage = Prefixed_Name(okh, "hasImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasManifestFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has manifest file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasManifestFile">https://w3id.org/oseg/ont/okh#hasManifestFile</seealso>
    let hasManifestFile = Prefixed_Name(okh, "hasManifestFile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasManufacturingInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has Manufacturing Instructions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasManufacturingInstructions">https://w3id.org/oseg/ont/okh#hasManufacturingInstructions</seealso>
    let hasManufacturingInstructions =
        Prefixed_Name(okh, "hasManufacturingInstructions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mass of the component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasMass">https://w3id.org/oseg/ont/okh#hasMass</seealso>
    let hasMass = Prefixed_Name(okh, "hasMass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasOuterDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"https://en.wikibooks.org/wiki/OpenSCAD_User_Manual/Primitive_Solids"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"outer dimensions using OpenSCAD primitives"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasOuterDimensions">https://w3id.org/oseg/ont/okh#hasOuterDimensions</seealso>
    let hasOuterDimensions = Prefixed_Name(okh, "hasOuterDimensions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"design files of this OSH modules have been peer reviewed in a scientific publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasPublication">https://w3id.org/oseg/ont/okh#hasPublication</seealso>
    let hasPublication = Prefixed_Name(okh, "hasPublication") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasReadme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links to the corresponding Readme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Readme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasReadme">https://w3id.org/oseg/ont/okh#hasReadme</seealso>
    let hasReadme = Prefixed_Name(okh, "hasReadme") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasSoftware">https://w3id.org/oseg/ont/okh#hasSoftware</seealso>
    let hasSoftware = Prefixed_Name(okh, "hasSoftware") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#hasUserManual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has User Manual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#hasUserManual">https://w3id.org/oseg/ont/okh#hasUserManual</seealso>
    let hasUserManual = Prefixed_Name(okh, "hasUserManual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#installationGuide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Installation Guide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#installationGuide">https://w3id.org/oseg/ont/okh#installationGuide</seealso>
    let installationGuide = Prefixed_Name(okh, "installationGuide") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#licensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"organization/individual behind the hardware design (holder of intellectual property)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"licensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#licensor">https://w3id.org/oseg/ont/okh#licensor</seealso>
    let licensor = Prefixed_Name(okh, "licensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#manufacturingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"manufacturing process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#manufacturingProcess">https://w3id.org/oseg/ont/okh#manufacturingProcess</seealso>
    let manufacturingProcess =
        Prefixed_Name(okh, "manufacturingProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"material"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#material">https://w3id.org/oseg/ont/okh#material</seealso>
    let material = Prefixed_Name(okh, "material") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#okhv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"version of OKH specification the metadata is following (different version → different data fields)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OKH version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#okhv">https://w3id.org/oseg/ont/okh#okhv</seealso>
    let okhv = Prefixed_Name(okh, "okhv") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#openSCAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"OpenSCAD code defining a shape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#openSCAD">https://w3id.org/oseg/ont/okh#openSCAD</seealso>
    let openSCAD = Prefixed_Name(okh, "openSCAD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#openScad</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#openScad">https://w3id.org/oseg/ont/okh#openScad</seealso>
    let openScad = Prefixed_Name(okh, "openScad") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"organization representing (most) contributors of this project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#organization">https://w3id.org/oseg/ont/okh#organization</seealso>
    let organization = Prefixed_Name(okh, "organization") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#permaURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Permanent file URL - It was not 'permanent', but rather 'frozen in time', and it was alsoThis was used in the karwler, but badly. Things simply should not be done that way, but rather with a separate manifest file, where either everything is frozen, or nothing is, and the manifest file (internally) itsself being marked accordingly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#permaURL">https://w3id.org/oseg/ont/okh#permaURL</seealso>
    let permaURL = Prefixed_Name(okh, "permaURL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#productionMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"production-relevant metadata, such as material, manufacturing technology, outer dimensions, smallest tolerance, finest surface roughness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"production metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#productionMetadata">https://w3id.org/oseg/ont/okh#productionMetadata</seealso>
    let productionMetadata = Prefixed_Name(okh, "productionMetadata") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#relatedTsdc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#relatedTsdc">https://w3id.org/oseg/ont/okh#relatedTsdc</seealso>
    let relatedTsdc = Prefixed_Name(okh, "relatedTsdc") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#relativePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Project-/Repo-relative file path, directly starting with the first path element, *NOT* with '/' or './'"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#relativePath">https://w3id.org/oseg/ont/okh#relativePath</seealso>
    let relativePath = Prefixed_Name(okh, "relativePath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#release</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URL to release"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"release"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#release">https://w3id.org/oseg/ont/okh#release</seealso>
    let release = Prefixed_Name(okh, "release") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#repo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     URL to the place where development happens (typically the repository)" ;
    ///     following this link people shall be able to contribute to the development
    ///     (reporting issues, suggesting changes, connecting to the team etc.)" "</para>
    /// labels<para>"repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#repo">https://w3id.org/oseg/ont/okh#repo</seealso>
    let repo = Prefixed_Name(okh, "repo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#repoHost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"platform where the OSH documentation is located (e.g. GitLab, Wikifactory or any self-hosted website or wiki)"</para>
    /// labels<para>"Repository Host"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#repoHost">https://w3id.org/oseg/ont/okh#repoHost</seealso>
    let repoHost = Prefixed_Name(okh, "repoHost") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#repoSnapshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Repoistory snapshot (=specific version) URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"respository snapshot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#repoSnapshot">https://w3id.org/oseg/ont/okh#repoSnapshot</seealso>
    let repoSnapshot = Prefixed_Name(okh, "repoSnapshot") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#smallestToleranceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"smallest tolerance class (following ISO 286)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#smallestToleranceClass">https://w3id.org/oseg/ont/okh#smallestToleranceClass</seealso>
    let smallestToleranceClass =
        Prefixed_Name(okh, "smallestToleranceClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relative link to a source file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#source">https://w3id.org/oseg/ont/okh#source</seealso>
    let source = Prefixed_Name(okh, "source") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#spdxLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"view complete list under https://spdx.org/licenses/"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SPDX license identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#spdxLicense">https://w3id.org/oseg/ont/okh#spdxLicense</seealso>
    let spdxLicense = Prefixed_Name(okh, "spdxLicense") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#standardID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Document identifier for the technical standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#standardID">https://w3id.org/oseg/ont/okh#standardID</seealso>
    let standardID = Prefixed_Name(okh, "standardID") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#technologyReadinessLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"…using the OTRL definitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Technology Readiness Level (TRL)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#technologyReadinessLevel">https://w3id.org/oseg/ont/okh#technologyReadinessLevel</seealso>
    let technologyReadinessLevel =
        Prefixed_Name(okh, "technologyReadinessLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:oseg/ont/okh#timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"following ISO 8601; see: &lt;https://www.w3.org/TR/xmlschema11-2/#dateTimeStamp&gt;"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#timestamp">https://w3id.org/oseg/ont/okh#timestamp</seealso>
    let timestamp = Prefixed_Name(okh, "timestamp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#tsdc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Applicable Technology-specific Documentation Criteria, according to DIN SPEC 3105-1, e.g. `tsdc:3DP`"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TsDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#tsdc">https://w3id.org/oseg/ont/okh#tsdc</seealso>
    let tsdc = Prefixed_Name(okh, "tsdc") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"mm, cm, m, g, kg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#unit">https://w3id.org/oseg/ont/okh#unit</seealso>
    let unit = Prefixed_Name(okh, "unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#uploadMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"e.g. auto (fully integrated platforms) or manifest file (for connected platforms)"</para>
    /// labels<para>"Upload Method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#uploadMethod">https://w3id.org/oseg/ont/okh#uploadMethod</seealso>
    let uploadMethod = Prefixed_Name(okh, "uploadMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Global file locator, using either the HTTP or the HTTPS protocol."</para>
    /// labels<para>"file URL"</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#url">https://w3id.org/oseg/ont/okh#url</seealso>
    let url = Prefixed_Name(okh, "url") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#value">https://w3id.org/oseg/ont/okh#value</seealso>
    let value = Prefixed_Name(okh, "value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"version of this Component, preferably in the semantic versioning scheme (semver.org)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#version">https://w3id.org/oseg/ont/okh#version</seealso>
    let version = Prefixed_Name(okh, "version") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/okh#versionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"connects specific versions of Modules with their versionless superclass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/okh#versionOf">https://w3id.org/oseg/ont/okh#versionOf</seealso>
    let versionOf = Prefixed_Name(okh, "versionOf") |> PrefixedName
