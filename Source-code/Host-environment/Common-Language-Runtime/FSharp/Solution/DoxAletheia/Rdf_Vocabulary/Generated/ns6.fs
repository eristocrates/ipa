namespace https.spdx.org.rdf._3._1.terms.Software.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns6 =
    let _namespace_iri = Namespace_Iri ns6 |> NamespaceIRI
    /// <summary>
    ///   <para>spdx:Software/ContentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A canonical, unique, immutable identifier."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifier">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifier</seealso>
    let ContentIdentifier = Prefixed_Name(ns6, "ContentIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/ContentIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the type of a content identifier."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType</seealso>
    let ContentIdentifierType =
        Prefixed_Name(ns6, "ContentIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/ContentIdentifierType/gitoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/ContentIdentifierType</para>
    ///   <para>"[Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg)."</para>
    /// labels<para>"gitoid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/gitoid">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/gitoid</seealso>
    let ``ContentIdentifierType/gitoid`` =
        Prefixed_Name(ns6, "ContentIdentifierType/gitoid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/ContentIdentifierType/swhid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/ContentIdentifierType</para>
    ///   <para>"SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`."</para>
    /// labels<para>"swhid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/swhid">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/swhid</seealso>
    let ``ContentIdentifierType/swhid`` =
        Prefixed_Name(ns6, "ContentIdentifierType/swhid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Refers to any object that stores content on a computer."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/File">https://spdx.org/rdf/3.1/terms/Software/File</seealso>
    let File = Prefixed_Name(ns6, "File") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/FileKindType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enumeration of the different kinds of SPDX file."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/FileKindType">https://spdx.org/rdf/3.1/terms/Software/FileKindType</seealso>
    let FileKindType = Prefixed_Name(ns6, "FileKindType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/FileKindType/directory</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/FileKindType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The file represents a directory and all content stored in that directory."</para>
    /// labels<para>"directory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/directory">https://spdx.org/rdf/3.1/terms/Software/FileKindType/directory</seealso>
    let ``FileKindType/directory`` =
        Prefixed_Name(ns6, "FileKindType/directory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/FileKindType/file</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/FileKindType</para>
    ///   <para>"The file represents a single file (default)."</para>
    /// labels<para>"file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/file">https://spdx.org/rdf/3.1/terms/Software/FileKindType/file</seealso>
    let ``FileKindType/file`` = Prefixed_Name(ns6, "FileKindType/file") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Refers to any unit of content that can be associated with a distribution of
    /// software."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/Package">https://spdx.org/rdf/3.1/terms/Software/Package</seealso>
    let Package = Prefixed_Name(ns6, "Package") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/Sbom</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of SPDX Elements describing a single package."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/Sbom">https://spdx.org/rdf/3.1/terms/Software/Sbom</seealso>
    let Sbom = Prefixed_Name(ns6, "Sbom") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SbomType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Provides a set of values to be used to describe the common types of SBOMs that
    /// tools may create."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType">https://spdx.org/rdf/3.1/terms/Software/SbomType</seealso>
    let SbomType = Prefixed_Name(ns6, "SbomType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SbomType/analyzed</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SBOM generated through analysis of artifacts (e.g., executables, packages, containers, and virtual machine images) after its build. Such analysis generally requires a variety of heuristics. In some contexts, this may also be referred to as a "3rd party" SBOM."</para>
    /// labels<para>"analyzed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/analyzed">https://spdx.org/rdf/3.1/terms/Software/SbomType/analyzed</seealso>
    let ``SbomType/analyzed`` = Prefixed_Name(ns6, "SbomType/analyzed") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SbomType/build</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SBOM generated as part of the process of building the software to create a releasable artifact (e.g., executable or package) from data such as source files, dependencies, built components, build process ephemeral data, and other SBOMs."</para>
    /// labels<para>"build"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/build">https://spdx.org/rdf/3.1/terms/Software/SbomType/build</seealso>
    let ``SbomType/build`` = Prefixed_Name(ns6, "SbomType/build") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SbomType/deployed</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SBOM provides an inventory of software that is present on a system. This may be an assembly of other SBOMs that combines analysis of configuration options, and examination of execution behavior in a (potentially simulated) deployment environment."</para>
    /// labels<para>"deployed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/deployed">https://spdx.org/rdf/3.1/terms/Software/SbomType/deployed</seealso>
    let ``SbomType/deployed`` = Prefixed_Name(ns6, "SbomType/deployed") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SbomType/design</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SBOM of intended, planned software project or product with included components (some of which may not yet exist) for a new software artifact."</para>
    /// labels<para>"design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/design">https://spdx.org/rdf/3.1/terms/Software/SbomType/design</seealso>
    let ``SbomType/design`` = Prefixed_Name(ns6, "SbomType/design") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SbomType/runtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SBOM generated through instrumenting the system running the software, to capture only components present in the system, as well as external call-outs or dynamically loaded components. In some contexts, this may also be referred to as an "Instrumented" or "Dynamic" SBOM."</para>
    /// labels<para>"runtime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/runtime">https://spdx.org/rdf/3.1/terms/Software/SbomType/runtime</seealso>
    let ``SbomType/runtime`` = Prefixed_Name(ns6, "SbomType/runtime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SbomType/source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>"SBOM created directly from the development environment, source files, and included dependencies used to build a product artifact."</para>
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/source">https://spdx.org/rdf/3.1/terms/Software/SbomType/source</seealso>
    let ``SbomType/source`` = Prefixed_Name(ns6, "SbomType/source") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/Snippet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Describes a certain part of a file."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/Snippet">https://spdx.org/rdf/3.1/terms/Software/Snippet</seealso>
    let Snippet = Prefixed_Name(ns6, "Snippet") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SoftwareArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A distinct article or unit related to Software."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwareArtifact">https://spdx.org/rdf/3.1/terms/Software/SoftwareArtifact</seealso>
    let SoftwareArtifact = Prefixed_Name(ns6, "SoftwareArtifact") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Provides information about the primary purpose of an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose</seealso>
    let SoftwarePurpose = Prefixed_Name(ns6, "SoftwarePurpose") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is a software application."</para>
    /// labels<para>"application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/application">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/application</seealso>
    let ``SoftwarePurpose/application`` =
        Prefixed_Name(ns6, "SoftwarePurpose/application") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is an archived collection of one or more files (.tar, .zip, etc.)."</para>
    /// labels<para>"archive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/archive">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/archive</seealso>
    let ``SoftwarePurpose/archive`` =
        Prefixed_Name(ns6, "SoftwarePurpose/archive") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/bom</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a bill of materials."</para>
    /// labels<para>"bom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/bom">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/bom</seealso>
    let ``SoftwarePurpose/bom`` =
        Prefixed_Name(ns6, "SoftwarePurpose/bom") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is configuration data."</para>
    /// labels<para>"configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/configuration">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/configuration</seealso>
    let ``SoftwarePurpose/configuration`` =
        Prefixed_Name(ns6, "SoftwarePurpose/configuration") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is a container image which can be used by a container runtime application."</para>
    /// labels<para>"container"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/container">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/container</seealso>
    let ``SoftwarePurpose/container`` =
        Prefixed_Name(ns6, "SoftwarePurpose/container") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/data</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is data."</para>
    /// labels<para>"data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/data">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/data</seealso>
    let ``SoftwarePurpose/data`` =
        Prefixed_Name(ns6, "SoftwarePurpose/data") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/device</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element refers to a chipset, processor, or electronic board."</para>
    /// labels<para>"device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/device">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/device</seealso>
    let ``SoftwarePurpose/device`` =
        Prefixed_Name(ns6, "SoftwarePurpose/device") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/deviceDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element represents software that controls hardware devices."</para>
    /// labels<para>"deviceDriver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/deviceDriver">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/deviceDriver</seealso>
    let ``SoftwarePurpose/deviceDriver`` =
        Prefixed_Name(ns6, "SoftwarePurpose/deviceDriver") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/diskImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element refers to a disk image that can be written to a disk, booted in a VM, etc. A disk image typically contains most or all of the components necessary to boot, such as bootloaders, kernels, firmware, userspace, etc."</para>
    /// labels<para>"diskImage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/diskImage">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/diskImage</seealso>
    let ``SoftwarePurpose/diskImage`` =
        Prefixed_Name(ns6, "SoftwarePurpose/diskImage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is documentation."</para>
    /// labels<para>"documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/documentation">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/documentation</seealso>
    let ``SoftwarePurpose/documentation`` =
        Prefixed_Name(ns6, "SoftwarePurpose/documentation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is the evidence that a specification or requirement has been fulfilled."</para>
    /// labels<para>"evidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/evidence">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/evidence</seealso>
    let ``SoftwarePurpose/evidence`` =
        Prefixed_Name(ns6, "SoftwarePurpose/evidence") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/executable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is an Artifact that can be run on a computer."</para>
    /// labels<para>"executable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/executable">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/executable</seealso>
    let ``SoftwarePurpose/executable`` =
        Prefixed_Name(ns6, "SoftwarePurpose/executable") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/file</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a single file which can be independently distributed (configuration file, statically linked binary, Kubernetes deployment, etc.)."</para>
    /// labels<para>"file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/file">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/file</seealso>
    let ``SoftwarePurpose/file`` =
        Prefixed_Name(ns6, "SoftwarePurpose/file") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/filesystemImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a file system image that can be written to a disk (or virtual) partition."</para>
    /// labels<para>"filesystemImage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/filesystemImage">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/filesystemImage</seealso>
    let ``SoftwarePurpose/filesystemImage`` =
        Prefixed_Name(ns6, "SoftwarePurpose/filesystemImage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/firmware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element provides low level control over a device's hardware."</para>
    /// labels<para>"firmware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/firmware">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/firmware</seealso>
    let ``SoftwarePurpose/firmware`` =
        Prefixed_Name(ns6, "SoftwarePurpose/firmware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/framework</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a software framework."</para>
    /// labels<para>"framework"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/framework">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/framework</seealso>
    let ``SoftwarePurpose/framework`` =
        Prefixed_Name(ns6, "SoftwarePurpose/framework") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/install</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is used to install software on disk."</para>
    /// labels<para>"install"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/install">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/install</seealso>
    let ``SoftwarePurpose/install`` =
        Prefixed_Name(ns6, "SoftwarePurpose/install") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is a software library."</para>
    /// labels<para>"library"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/library">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/library</seealso>
    let ``SoftwarePurpose/library`` =
        Prefixed_Name(ns6, "SoftwarePurpose/library") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/manifest</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a software manifest."</para>
    /// labels<para>"manifest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/manifest">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/manifest</seealso>
    let ``SoftwarePurpose/manifest`` =
        Prefixed_Name(ns6, "SoftwarePurpose/manifest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/model</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a machine learning or artificial intelligence model."</para>
    /// labels<para>"model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/model">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/model</seealso>
    let ``SoftwarePurpose/model`` =
        Prefixed_Name(ns6, "SoftwarePurpose/model") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/module</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is a module of a piece of software."</para>
    /// labels<para>"module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/module">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/module</seealso>
    let ``SoftwarePurpose/module`` =
        Prefixed_Name(ns6, "SoftwarePurpose/module") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/operatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is an operating system."</para>
    /// labels<para>"operatingSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/operatingSystem">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/operatingSystem</seealso>
    let ``SoftwarePurpose/operatingSystem`` =
        Prefixed_Name(ns6, "SoftwarePurpose/operatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element doesn't fit into any of the other categories."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/other">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/other</seealso>
    let ``SoftwarePurpose/other`` =
        Prefixed_Name(ns6, "SoftwarePurpose/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/patch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element contains a set of changes to update, fix, or improve another Element."</para>
    /// labels<para>"patch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/patch">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/patch</seealso>
    let ``SoftwarePurpose/patch`` =
        Prefixed_Name(ns6, "SoftwarePurpose/patch") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element represents a runtime environment."</para>
    /// labels<para>"platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/platform">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/platform</seealso>
    let ``SoftwarePurpose/platform`` =
        Prefixed_Name(ns6, "SoftwarePurpose/platform") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element provides a requirement needed as input for another Element."</para>
    /// labels<para>"requirement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/requirement">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/requirement</seealso>
    let ``SoftwarePurpose/requirement`` =
        Prefixed_Name(ns6, "SoftwarePurpose/requirement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/source</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a single or a collection of source files."</para>
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/source">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/source</seealso>
    let ``SoftwarePurpose/source`` =
        Prefixed_Name(ns6, "SoftwarePurpose/source") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Element is a plan, guideline or strategy how to create, perform or analyze an application."</para>
    /// labels<para>"specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/specification">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/specification</seealso>
    let ``SoftwarePurpose/specification`` =
        Prefixed_Name(ns6, "SoftwarePurpose/specification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>"The Element is a test used to verify functionality on a software element."</para>
    /// labels<para>"test"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/test">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/test</seealso>
    let ``SoftwarePurpose/test`` =
        Prefixed_Name(ns6, "SoftwarePurpose/test") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/additionalPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides additional purpose information of the software artifact."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/additionalPurpose">https://spdx.org/rdf/3.1/terms/Software/additionalPurpose</seealso>
    let additionalPurpose = Prefixed_Name(ns6, "additionalPurpose") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/artifactSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the size of a software Artifact, in bytes."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/artifactSize">https://spdx.org/rdf/3.1/terms/Software/artifactSize</seealso>
    let artifactSize = Prefixed_Name(ns6, "artifactSize") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/attributionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a place for the SPDX data creator to record acknowledgement text for
    /// a software Package, File or Snippet."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/attributionText">https://spdx.org/rdf/3.1/terms/Software/attributionText</seealso>
    let attributionText = Prefixed_Name(ns6, "attributionText") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/byteRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the byte range in the original host file that the snippet information
    /// applies to."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/byteRange">https://spdx.org/rdf/3.1/terms/Software/byteRange</seealso>
    let byteRange = Prefixed_Name(ns6, "byteRange") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/contentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A canonical, unique, immutable identifier of the artifact content, that may be
    /// used for verifying its identity and/or integrity."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifier">https://spdx.org/rdf/3.1/terms/Software/contentIdentifier</seealso>
    let contentIdentifier = Prefixed_Name(ns6, "contentIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/contentIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the type of the content identifier."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierType">https://spdx.org/rdf/3.1/terms/Software/contentIdentifierType</seealso>
    let contentIdentifierType =
        Prefixed_Name(ns6, "contentIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/contentIdentifierValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the value of the content identifier."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierValue">https://spdx.org/rdf/3.1/terms/Software/contentIdentifierValue</seealso>
    let contentIdentifierValue =
        Prefixed_Name(ns6, "contentIdentifierValue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/copyrightText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the text of one or more copyright notices for a software Package,
    /// File or Snippet, if any."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/copyrightText">https://spdx.org/rdf/3.1/terms/Software/copyrightText</seealso>
    let copyrightText = Prefixed_Name(ns6, "copyrightText") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/downloadLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the download Uniform Resource Identifier for the package at the time
    /// that the document was created."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/downloadLocation">https://spdx.org/rdf/3.1/terms/Software/downloadLocation</seealso>
    let downloadLocation = Prefixed_Name(ns6, "downloadLocation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/fileKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes if a given file is a directory or non-directory kind of file."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/fileKind">https://spdx.org/rdf/3.1/terms/Software/fileKind</seealso>
    let fileKind = Prefixed_Name(ns6, "fileKind") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/homePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A place for the SPDX document creator to record a website that serves as the
    /// package's home page."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/homePage">https://spdx.org/rdf/3.1/terms/Software/homePage</seealso>
    let homePage = Prefixed_Name(ns6, "homePage") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/lineRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the line range in the original host file that the snippet information
    /// applies to."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/lineRange">https://spdx.org/rdf/3.1/terms/Software/lineRange</seealso>
    let lineRange = Prefixed_Name(ns6, "lineRange") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/packageUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a place for the SPDX data creator to record the package URL string
    /// (in accordance with the Package URL specification) for a software Package."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/packageUrl">https://spdx.org/rdf/3.1/terms/Software/packageUrl</seealso>
    let packageUrl = Prefixed_Name(ns6, "packageUrl") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/packageVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identify the version of a package."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/packageVersion">https://spdx.org/rdf/3.1/terms/Software/packageVersion</seealso>
    let packageVersion = Prefixed_Name(ns6, "packageVersion") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/primaryPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides information about the primary purpose of the software artifact."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/primaryPurpose">https://spdx.org/rdf/3.1/terms/Software/primaryPurpose</seealso>
    let primaryPurpose = Prefixed_Name(ns6, "primaryPurpose") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/sbomType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides information about the type of an SBOM."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/sbomType">https://spdx.org/rdf/3.1/terms/Software/sbomType</seealso>
    let sbomType = Prefixed_Name(ns6, "sbomType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/snippetFromFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the original host file that the snippet information applies to."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/snippetFromFile">https://spdx.org/rdf/3.1/terms/Software/snippetFromFile</seealso>
    let snippetFromFile = Prefixed_Name(ns6, "snippetFromFile") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/sourceInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Records any relevant background information or additional comments
    /// about the origin of the package."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/sourceInfo">https://spdx.org/rdf/3.1/terms/Software/sourceInfo</seealso>
    let sourceInfo = Prefixed_Name(ns6, "sourceInfo") |> PrefixedName
