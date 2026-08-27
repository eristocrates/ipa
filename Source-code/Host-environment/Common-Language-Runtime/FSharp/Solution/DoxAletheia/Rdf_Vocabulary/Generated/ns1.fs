namespace https.spdx.org.rdf._3._1.terms.Core.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns1 =
    let _namespace_iri = Namespace_Iri ns1 |> NamespaceIRI
    /// <summary>
    ///   <para>spdx:Core/Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Class that describes an action that has occurred."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Action">https://spdx.org/rdf/3.1/terms/Core/Action</seealso>
    let Action = Prefixed_Name(ns1, "Action") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agent represents anything with the potential to act on a system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Agent">https://spdx.org/rdf/3.1/terms/Core/Agent</seealso>
    let Agent = Prefixed_Name(ns1, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"An assertion made in relation to one or more elements."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Annotation">https://spdx.org/rdf/3.1/terms/Core/Annotation</seealso>
    let Annotation = Prefixed_Name(ns1, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/AnnotationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the type of an annotation."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType">https://spdx.org/rdf/3.1/terms/Core/AnnotationType</seealso>
    let AnnotationType = Prefixed_Name(ns1, "AnnotationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/AnnotationType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/AnnotationType</para>
    ///   <para>"Used to store extra information about an Element which is not part of a review (e.g. extra information provided during the creation of the Element)."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/other">https://spdx.org/rdf/3.1/terms/Core/AnnotationType/other</seealso>
    let ``AnnotationType/other`` =
        Prefixed_Name(ns1, "AnnotationType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/AnnotationType/review</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/AnnotationType</para>
    ///   <para>"Used when someone reviews the Element."</para>
    /// labels<para>"review"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/review">https://spdx.org/rdf/3.1/terms/Core/AnnotationType/review</seealso>
    let ``AnnotationType/review`` =
        Prefixed_Name(ns1, "AnnotationType/review") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A distinct article or unit within the domain."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Artifact">https://spdx.org/rdf/3.1/terms/Core/Artifact</seealso>
    let Artifact = Prefixed_Name(ns1, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Bom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A container for a grouping of SPDX 3 content characterizing details
    /// (provenance, composition, licensing, etc.) about a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Bom">https://spdx.org/rdf/3.1/terms/Core/Bom</seealso>
    let Bom = Prefixed_Name(ns1, "Bom") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Bundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of Elements that have a shared context."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Bundle">https://spdx.org/rdf/3.1/terms/Core/Bundle</seealso>
    let Bundle = Prefixed_Name(ns1, "Bundle") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A contact point from an Artifact to an Agent."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationship">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationship</seealso>
    let ContactPointRelationship =
        Prefixed_Name(ns1, "ContactPointRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information about the type of contact point for `ContactPointRelationship`s."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType</seealso>
    let ContactPointRelationshipType =
        Prefixed_Name(ns1, "ContactPointRelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/compliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A contact point for compliance (i.e. export control, licensing)."</para>
    /// labels<para>"compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/compliance">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/compliance</seealso>
    let ``ContactPointRelationshipType/compliance`` =
        Prefixed_Name(ns1, "ContactPointRelationshipType/compliance") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>"A generic contact point to be used when the contact type does not match any of the other options."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/other">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/other</seealso>
    let ``ContactPointRelationshipType/other`` =
        Prefixed_Name(ns1, "ContactPointRelationshipType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/securityVulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>"A contact for reporting security vulnerabilities."</para>
    /// labels<para>"securityVulnerability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/securityVulnerability">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/securityVulnerability</seealso>
    let ``ContactPointRelationshipType/securityVulnerability`` =
        Prefixed_Name(ns1, "ContactPointRelationshipType/securityVulnerability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>"A contact point for support."</para>
    /// labels<para>"support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/support">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/support</seealso>
    let ``ContactPointRelationshipType/support`` =
        Prefixed_Name(ns1, "ContactPointRelationshipType/support") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/CreationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Provides information about the creation of the Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/CreationInfo">https://spdx.org/rdf/3.1/terms/Core/CreationInfo</seealso>
    let CreationInfo = Prefixed_Name(ns1, "CreationInfo") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/DefinedProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Class that describes a process."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/DefinedProcess">https://spdx.org/rdf/3.1/terms/Core/DefinedProcess</seealso>
    let DefinedProcess = Prefixed_Name(ns1, "DefinedProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/DefinedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"The DefinedType class associates a specific type with its defined source."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/DefinedType">https://spdx.org/rdf/3.1/terms/Core/DefinedType</seealso>
    let DefinedType = Prefixed_Name(ns1, "DefinedType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/DictionaryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A key with an associated value."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/DictionaryEntry">https://spdx.org/rdf/3.1/terms/Core/DictionaryEntry</seealso>
    let DictionaryEntry = Prefixed_Name(ns1, "DictionaryEntry") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Base domain class from which all other SPDX 3 domain classes derive."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Element">https://spdx.org/rdf/3.1/terms/Core/Element</seealso>
    let Element = Prefixed_Name(ns1, "Element") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/ElementCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of Elements, not necessarily with unifying context."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ElementCollection">https://spdx.org/rdf/3.1/terms/Core/ElementCollection</seealso>
    let ElementCollection = Prefixed_Name(ns1, "ElementCollection") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/ElementMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A key with an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ElementMap">https://spdx.org/rdf/3.1/terms/Core/ElementMap</seealso>
    let ElementMap = Prefixed_Name(ns1, "ElementMap") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A reference to a resource identifier defined outside the scope of SPDX 3 content that uniquely identifies an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifier">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifier</seealso>
    let ExternalIdentifier = Prefixed_Name(ns1, "ExternalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the type of an external identifier."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType</seealso>
    let ExternalIdentifierType =
        Prefixed_Name(ns1, "ExternalIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/cpe22</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"[Common Platform Enumeration Specification 2.2](https://cpe.mitre.org/files/cpe-specification_2.2.pdf)."</para>
    /// labels<para>"cpe22"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe22">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe22</seealso>
    let ``ExternalIdentifierType/cpe22`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/cpe22") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/cpe23</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"[Common Platform Enumeration: Naming Specification Version 2.3](https://csrc.nist.gov/publications/detail/nistir/7695/final)."</para>
    /// labels<para>"cpe23"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe23">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe23</seealso>
    let ``ExternalIdentifierType/cpe23`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/cpe23") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/cve</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Common Vulnerabilities and Exposures identifiers, an identifier for a specific software flaw defined within the official CVE Dictionary and that conforms to the [CVE specification](https://csrc.nist.gov/glossary/term/cve_id)."</para>
    /// labels<para>"cve"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cve">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cve</seealso>
    let ``ExternalIdentifierType/cve`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/cve") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/duns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"[Data Universal Numbering System (D-U-N-S) Number](https://www.dnb.com/en-us/smb/duns.html) is a unique nine-digit identifier, issued by Dun &amp; Bradstreet, that identifies a business entity, often on a location-specific basis."</para>
    /// labels<para>"duns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/duns">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/duns</seealso>
    let ``ExternalIdentifierType/duns`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/duns") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/email</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Email address, as defined in [RFC 3696](https://datatracker.ietf.org/doc/rfc3696/) Section 3."</para>
    /// labels<para>"email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/email">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/email</seealso>
    let ``ExternalIdentifierType/email`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/email") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/evidenceUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"The UUID used by a reporting management system or any other lifecycle management tool to uniquely identify an evidence relationship item. UUID, or universally unique ID, is a standard term to refer to evidence items."</para>
    /// labels<para>"evidenceUUID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/evidenceUUID">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/evidenceUUID</seealso>
    let ``ExternalIdentifierType/evidenceUUID`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/evidenceUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/gitoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"[Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg)."</para>
    /// labels<para>"gitoid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gitoid">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gitoid</seealso>
    let ``ExternalIdentifierType/gitoid`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/gitoid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/gln</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"[Global Location Number (GLN)](https://www.gs1.org/standards/id-keys/gln) is a 13-digit number, assigned by GS1, that uniquely identifies a legal entity (e.g., a company or customer), a function within a legal entity, a physical location (e.g., a warehouse or a specific shelf in a store), or a digital location (e.g., an Electronic Data Interchange (EDI) gateway)."</para>
    /// labels<para>"gln"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gln">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gln</seealso>
    let ``ExternalIdentifierType/gln`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/gln") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/glue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"[GLobal Unique Enterprise (GLUE) Identifiers](https://datatracker.ietf.org/doc/draft-ietf-spice-glue-id/), as defined by the IETF Internet-Draft, is expressed as a GLUE URI, a Uniform Resource Identifier that standardizes the representation of existing organizational entity identifiers."</para>
    /// labels<para>"glue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/glue">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/glue</seealso>
    let ``ExternalIdentifierType/glue`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/glue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/gtin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"[Global Trade Item Number (GTIN)](https://www.gs1.org/standards/id-keys/gtin) is a number, assigned by GS1, that uniquely identifies a trade item (product or service)."</para>
    /// labels<para>"gtin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gtin">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gtin</seealso>
    let ``ExternalIdentifierType/gtin`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/gtin") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/hsCodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The [Harmonized System (HS)](https://www.wcoomd.org/en/topics/nomenclature/overview/what-is-the-harmonized-system.aspx) of tariff nomenclature is an internationally standardized system of names and numbers, defined by the World Customs Organization, used to classify traded products."</para>
    /// labels<para>"hsCodes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/hsCodes">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/hsCodes</seealso>
    let ``ExternalIdentifierType/hsCodes`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/hsCodes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/lei</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"The [Legal Entity Identifier (LEI)](https://www.gleif.org/en/organizational-identity/introducing-the-legal-entity-identifier-lei) is a 20-character, alphanumeric code based on the [ISO 17442](https://www.iso.org/standard/78829.html) standard developed by the International Organization for Standardization."</para>
    /// labels<para>"lei"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/lei">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/lei</seealso>
    let ``ExternalIdentifierType/lei`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/lei") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"Used when the type does not match any of the other options."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/other">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/other</seealso>
    let ``ExternalIdentifierType/other`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/packageUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"Package URL, as defined in the corresponding [Annex](../../../annexes/pkg-url-specification.md) of this document."</para>
    /// labels<para>"packageUrl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/packageUrl">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/packageUrl</seealso>
    let ``ExternalIdentifierType/packageUrl`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/packageUrl") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Phone number; A string of decimal digits that uniquely indicates the network termination point defined in [RFC 3966](https://datatracker.ietf.org/doc/rfc3966/) Section 5."</para>
    /// labels<para>"phoneNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/phoneNumber">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/phoneNumber</seealso>
    let ``ExternalIdentifierType/phoneNumber`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/phoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/requirementUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"The UUID used by a requirements management or any other lifecycle management tool to uniquely identify a requirement item. UUID, or universally unique ID, is a standard term in requirements engineering."</para>
    /// labels<para>"requirementUUID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/requirementUUID">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/requirementUUID</seealso>
    let ``ExternalIdentifierType/requirementUUID`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/requirementUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/securityOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"Used when there is a security related identifier of unspecified type."</para>
    /// labels<para>"securityOther"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/securityOther">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/securityOther</seealso>
    let ``ExternalIdentifierType/securityOther`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/securityOther") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/swhid</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`."</para>
    /// labels<para>"swhid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swhid">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swhid</seealso>
    let ``ExternalIdentifierType/swhid`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/swhid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/swid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"Concise Software Identification (CoSWID) tag, as defined in [RFC 9393](https://datatracker.ietf.org/doc/rfc9393/) Section 2.3."</para>
    /// labels<para>"swid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swid">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swid</seealso>
    let ``ExternalIdentifierType/swid`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/swid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/urlScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"[Uniform Resource Identifier (URI) Schemes](https://www.iana.org/assignments/uri-schemes/uri-schemes.xhtml). The scheme used in order to locate a resource."</para>
    /// labels<para>"urlScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/urlScheme">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/urlScheme</seealso>
    let ``ExternalIdentifierType/urlScheme`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/urlScheme") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/verificationUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"The UUID used by a verification management system or any other lifecycle management tool to uniquely identify a verification item. UUID, or universally unique ID, is a standard term to refer to verification items."</para>
    /// labels<para>"verificationUUID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/verificationUUID">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/verificationUUID</seealso>
    let ``ExternalIdentifierType/verificationUUID`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/verificationUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/webpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>"Absolute URL that can be used to locate a resource, as defined in [RFC 7230](https://datatracker.ietf.org/doc/rfc7230/) Section 2.7.1 or Section 2.7.2."</para>
    /// labels<para>"webpage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/webpage">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/webpage</seealso>
    let ``ExternalIdentifierType/webpage`` =
        Prefixed_Name(ns1, "ExternalIdentifierType/webpage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A map of Element identifiers that are used within an SpdxDocument but defined
    /// external to that SpdxDocument."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalMap">https://spdx.org/rdf/3.1/terms/Core/ExternalMap</seealso>
    let ExternalMap = Prefixed_Name(ns1, "ExternalMap") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/ExternalRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A reference to a resource outside the scope of SPDX 3 content related to an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRef">https://spdx.org/rdf/3.1/terms/Core/ExternalRef</seealso>
    let ExternalRef = Prefixed_Name(ns1, "ExternalRef") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/ExternalRefType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the type of an external reference."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType</seealso>
    let ExternalRefType = Prefixed_Name(ns1, "ExternalRefType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/altDownloadLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to an alternative download location."</para>
    /// labels<para>"altDownloadLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altDownloadLocation">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altDownloadLocation</seealso>
    let ``ExternalRefType/altDownloadLocation`` =
        Prefixed_Name(ns1, "ExternalRefType/altDownloadLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/altWebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to an alternative web page."</para>
    /// labels<para>"altWebPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altWebPage">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altWebPage</seealso>
    let ``ExternalRefType/altWebPage`` =
        Prefixed_Name(ns1, "ExternalRefType/altWebPage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/binaryArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to binary artifacts related to a package."</para>
    /// labels<para>"binaryArtifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/binaryArtifact">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/binaryArtifact</seealso>
    let ``ExternalRefType/binaryArtifact`` =
        Prefixed_Name(ns1, "ExternalRefType/binaryArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/bower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a Bower package. The package locator format, looks like `package#version`, is defined in the "install" section of [Bower API documentation](https://bower.io/docs/api/#install)."</para>
    /// labels<para>"bower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/bower">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/bower</seealso>
    let ``ExternalRefType/bower`` =
        Prefixed_Name(ns1, "ExternalRefType/bower") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/buildMeta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference build metadata related to a published package."</para>
    /// labels<para>"buildMeta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildMeta">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildMeta</seealso>
    let ``ExternalRefType/buildMeta`` =
        Prefixed_Name(ns1, "ExternalRefType/buildMeta") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/buildSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference build system used to create or publish the package."</para>
    /// labels<para>"buildSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildSystem">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildSystem</seealso>
    let ``ExternalRefType/buildSystem`` =
        Prefixed_Name(ns1, "ExternalRefType/buildSystem") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/certificationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a certification report for a package from an accredited/independent body."</para>
    /// labels<para>"certificationReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/certificationReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/certificationReport</seealso>
    let ``ExternalRefType/certificationReport`` =
        Prefixed_Name(ns1, "ExternalRefType/certificationReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/chat</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to the instant messaging system used by the maintainer for a package."</para>
    /// labels<para>"chat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/chat">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/chat</seealso>
    let ``ExternalRefType/chat`` =
        Prefixed_Name(ns1, "ExternalRefType/chat") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/componentAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a Software Composition Analysis (SCA) report."</para>
    /// labels<para>"componentAnalysisReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/componentAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/componentAnalysisReport</seealso>
    let ``ExternalRefType/componentAnalysisReport`` =
        Prefixed_Name(ns1, "ExternalRefType/componentAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/cwe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"[Common Weakness Enumeration](https://csrc.nist.gov/glossary/term/common_weakness_enumeration). A reference to a source of software flaw defined within the official [CWE List](https://cwe.mitre.org/data/) that conforms to the [CWE specification](https://cwe.mitre.org/)."</para>
    /// labels<para>"cwe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/cwe">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/cwe</seealso>
    let ``ExternalRefType/cwe`` =
        Prefixed_Name(ns1, "ExternalRefType/cwe") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to the documentation for a package."</para>
    /// labels<para>"documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/documentation">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/documentation</seealso>
    let ``ExternalRefType/documentation`` =
        Prefixed_Name(ns1, "ExternalRefType/documentation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/dynamicAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a dynamic analysis report for a package."</para>
    /// labels<para>"dynamicAnalysisReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/dynamicAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/dynamicAnalysisReport</seealso>
    let ``ExternalRefType/dynamicAnalysisReport`` =
        Prefixed_Name(ns1, "ExternalRefType/dynamicAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/eolNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to the End Of Sale (EOS) and/or End Of Life (EOL) information related to a package."</para>
    /// labels<para>"eolNotice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/eolNotice">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/eolNotice</seealso>
    let ``ExternalRefType/eolNotice`` =
        Prefixed_Name(ns1, "ExternalRefType/eolNotice") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/exportControlAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to an export control assessment for a package."</para>
    /// labels<para>"exportControlAssessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/exportControlAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/exportControlAssessment</seealso>
    let ``ExternalRefType/exportControlAssessment`` =
        Prefixed_Name(ns1, "ExternalRefType/exportControlAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to funding information related to a package."</para>
    /// labels<para>"funding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/funding">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/funding</seealso>
    let ``ExternalRefType/funding`` =
        Prefixed_Name(ns1, "ExternalRefType/funding") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/issueTracker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to the issue tracker for a package."</para>
    /// labels<para>"issueTracker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/issueTracker">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/issueTracker</seealso>
    let ``ExternalRefType/issueTracker`` =
        Prefixed_Name(ns1, "ExternalRefType/issueTracker") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/license</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to additional license information related to an artifact."</para>
    /// labels<para>"license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/license">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/license</seealso>
    let ``ExternalRefType/license`` =
        Prefixed_Name(ns1, "ExternalRefType/license") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/mailingList</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to the mailing list used by the maintainer for a package."</para>
    /// labels<para>"mailingList"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mailingList">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mailingList</seealso>
    let ``ExternalRefType/mailingList`` =
        Prefixed_Name(ns1, "ExternalRefType/mailingList") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/mavenCentral</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a Maven repository artifact. The artifact locator format is defined in the [Maven documentation](https://maven.apache.org/guides/mini/guide-naming-conventions.html) and looks like `groupId:artifactId[:version]`."</para>
    /// labels<para>"mavenCentral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mavenCentral">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mavenCentral</seealso>
    let ``ExternalRefType/mavenCentral`` =
        Prefixed_Name(ns1, "ExternalRefType/mavenCentral") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to metrics related to package such as OpenSSF scorecards."</para>
    /// labels<para>"metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/metrics">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/metrics</seealso>
    let ``ExternalRefType/metrics`` =
        Prefixed_Name(ns1, "ExternalRefType/metrics") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/npm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to an npm package. The package locator format is defined in the [npm documentation](https://docs.npmjs.com/cli/v10/configuring-npm/package-json) and looks like `package@version`."</para>
    /// labels<para>"npm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/npm">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/npm</seealso>
    let ``ExternalRefType/npm`` =
        Prefixed_Name(ns1, "ExternalRefType/npm") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/nuget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a NuGet package. The package locator format is defined in the [NuGet documentation](https://docs.nuget.org) and looks like `package/version`."</para>
    /// labels<para>"nuget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/nuget">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/nuget</seealso>
    let ``ExternalRefType/nuget`` =
        Prefixed_Name(ns1, "ExternalRefType/nuget") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Used when the type does not match any of the other options."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/other">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/other</seealso>
    let ``ExternalRefType/other`` =
        Prefixed_Name(ns1, "ExternalRefType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/privacyAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a privacy assessment for a package."</para>
    /// labels<para>"privacyAssessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/privacyAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/privacyAssessment</seealso>
    let ``ExternalRefType/privacyAssessment`` =
        Prefixed_Name(ns1, "ExternalRefType/privacyAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/productMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to additional product metadata such as reference within organization's product catalog."</para>
    /// labels<para>"productMetadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/productMetadata">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/productMetadata</seealso>
    let ``ExternalRefType/productMetadata`` =
        Prefixed_Name(ns1, "ExternalRefType/productMetadata") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/purchaseOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a purchase order for a package."</para>
    /// labels<para>"purchaseOrder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/purchaseOrder">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/purchaseOrder</seealso>
    let ``ExternalRefType/purchaseOrder`` =
        Prefixed_Name(ns1, "ExternalRefType/purchaseOrder") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/qualityAssessmentReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a quality assessment for a package."</para>
    /// labels<para>"qualityAssessmentReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/qualityAssessmentReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/qualityAssessmentReport</seealso>
    let ``ExternalRefType/qualityAssessmentReport`` =
        Prefixed_Name(ns1, "ExternalRefType/qualityAssessmentReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/releaseHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a published list of releases for a package."</para>
    /// labels<para>"releaseHistory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseHistory">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseHistory</seealso>
    let ``ExternalRefType/releaseHistory`` =
        Prefixed_Name(ns1, "ExternalRefType/releaseHistory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/releaseNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to the release notes for a package."</para>
    /// labels<para>"releaseNotes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseNotes">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseNotes</seealso>
    let ``ExternalRefType/releaseNotes`` =
        Prefixed_Name(ns1, "ExternalRefType/releaseNotes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/riskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a risk assessment for a package."</para>
    /// labels<para>"riskAssessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/riskAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/riskAssessment</seealso>
    let ``ExternalRefType/riskAssessment`` =
        Prefixed_Name(ns1, "ExternalRefType/riskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/runtimeAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a runtime analysis report for a package."</para>
    /// labels<para>"runtimeAnalysisReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/runtimeAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/runtimeAnalysisReport</seealso>
    let ``ExternalRefType/runtimeAnalysisReport`` =
        Prefixed_Name(ns1, "ExternalRefType/runtimeAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/secureSoftwareAttestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to information assuring that the software is developed using security practices as defined by [NIST SP 800-218 Secure Software Development Framework (SSDF) Version 1.1](https://csrc.nist.gov/pubs/sp/800/218/final) or [CISA Secure Software Development Attestation Form](https://www.cisa.gov/resources-tools/resources/secure-software-development-attestation-form)."</para>
    /// labels<para>"secureSoftwareAttestation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/secureSoftwareAttestation">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/secureSoftwareAttestation</seealso>
    let ``ExternalRefType/secureSoftwareAttestation`` =
        Prefixed_Name(ns1, "ExternalRefType/secureSoftwareAttestation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityAdversaryModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to the security adversary model for a package."</para>
    /// labels<para>"securityAdversaryModel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdversaryModel">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdversaryModel</seealso>
    let ``ExternalRefType/securityAdversaryModel`` =
        Prefixed_Name(ns1, "ExternalRefType/securityAdversaryModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityAdvisory</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a published security advisory (where advisory as defined per [ISO 29147:2018](https://www.iso.org/standard/72311.html)) that may affect one or more elements, e.g., vendor advisories or specific NVD entries."</para>
    /// labels<para>"securityAdvisory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdvisory">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdvisory</seealso>
    let ``ExternalRefType/securityAdvisory`` =
        Prefixed_Name(ns1, "ExternalRefType/securityAdvisory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to the patch or source code that fixes a vulnerability."</para>
    /// labels<para>"securityFix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityFix">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityFix</seealso>
    let ``ExternalRefType/securityFix`` =
        Prefixed_Name(ns1, "ExternalRefType/securityFix") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to related security information of unspecified type."</para>
    /// labels<para>"securityOther"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityOther">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityOther</seealso>
    let ``ExternalRefType/securityOther`` =
        Prefixed_Name(ns1, "ExternalRefType/securityOther") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityPenTestReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a [penetration test](https://en.wikipedia.org/wiki/Penetration_test) report for a package."</para>
    /// labels<para>"securityPenTestReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPenTestReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPenTestReport</seealso>
    let ``ExternalRefType/securityPenTestReport`` =
        Prefixed_Name(ns1, "ExternalRefType/securityPenTestReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to instructions for reporting newly discovered security vulnerabilities for a package."</para>
    /// labels<para>"securityPolicy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPolicy">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPolicy</seealso>
    let ``ExternalRefType/securityPolicy`` =
        Prefixed_Name(ns1, "ExternalRefType/securityPolicy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityThreatModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference the [security threat model](https://en.wikipedia.org/wiki/Threat_model) for a package."</para>
    /// labels<para>"securityThreatModel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityThreatModel">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityThreatModel</seealso>
    let ``ExternalRefType/securityThreatModel`` =
        Prefixed_Name(ns1, "ExternalRefType/securityThreatModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/socialMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a social media channel for a package."</para>
    /// labels<para>"socialMedia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/socialMedia">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/socialMedia</seealso>
    let ``ExternalRefType/socialMedia`` =
        Prefixed_Name(ns1, "ExternalRefType/socialMedia") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/sourceArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to an artifact containing the sources for a package."</para>
    /// labels<para>"sourceArtifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/sourceArtifact">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/sourceArtifact</seealso>
    let ``ExternalRefType/sourceArtifact`` =
        Prefixed_Name(ns1, "ExternalRefType/sourceArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/staticAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a static analysis report for a package."</para>
    /// labels<para>"staticAnalysisReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/staticAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/staticAnalysisReport</seealso>
    let ``ExternalRefType/staticAnalysisReport`` =
        Prefixed_Name(ns1, "ExternalRefType/staticAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/support</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to the software support channel or other support information for a package."</para>
    /// labels<para>"support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/support">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/support</seealso>
    let ``ExternalRefType/support`` =
        Prefixed_Name(ns1, "ExternalRefType/support") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/vcs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to a version control system related to a software artifact."</para>
    /// labels<para>"vcs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vcs">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vcs</seealso>
    let ``ExternalRefType/vcs`` =
        Prefixed_Name(ns1, "ExternalRefType/vcs") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/vulnerabilityDisclosureReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a Vulnerability Disclosure Report (VDR) which provides the software supplier's analysis and findings describing the impact (or lack of impact) that reported vulnerabilities have on packages or products in the supplier's SBOM as defined in [NIST SP 800-161 Cybersecurity Supply Chain Risk Management Practices for Systems and Organizations](https://csrc.nist.gov/pubs/sp/800/161/r1/final)."</para>
    /// labels<para>"vulnerabilityDisclosureReport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityDisclosureReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityDisclosureReport</seealso>
    let ``ExternalRefType/vulnerabilityDisclosureReport`` =
        Prefixed_Name(ns1, "ExternalRefType/vulnerabilityDisclosureReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/vulnerabilityExploitabilityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A reference to a Vulnerability Exploitability eXchange (VEX) statement which provides information on whether a product is impacted by a specific vulnerability in an included package and, if affected, whether there are actions recommended to remediate. See also [NTIA VEX one-page summary](https://ntia.gov/files/ntia/publications/vex_one-page_summary.pdf)."</para>
    /// labels<para>"vulnerabilityExploitabilityAssessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityExploitabilityAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityExploitabilityAssessment</seealso>
    let ``ExternalRefType/vulnerabilityExploitabilityAssessment`` =
        Prefixed_Name(ns1, "ExternalRefType/vulnerabilityExploitabilityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/x509Cert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>"A reference to an X.509 certificate as defined in [RFC 1422](https://datatracker.ietf.org/doc/rfc1422/). The media type shall be one of application/x-x509-ca-cert or application/x-x509-user-cert."</para>
    /// labels<para>"x509Cert"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/x509Cert">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/x509Cert</seealso>
    let ``ExternalRefType/x509Cert`` =
        Prefixed_Name(ns1, "ExternalRefType/x509Cert") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Hash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A mathematically calculated representation of a grouping of data."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Hash">https://spdx.org/rdf/3.1/terms/Core/Hash</seealso>
    let Hash = Prefixed_Name(ns1, "Hash") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mathematical algorithm that maps data of arbitrary size to a bit string."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm</seealso>
    let HashAlgorithm = Prefixed_Name(ns1, "HashAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/adler32</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Adler-32 checksum is part of the widely used zlib compression library as defined in [RFC 1950](https://datatracker.ietf.org/doc/rfc1950/) Section 2.3."</para>
    /// labels<para>"adler32"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/adler32">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/adler32</seealso>
    let ``HashAlgorithm/adler32`` =
        Prefixed_Name(ns1, "HashAlgorithm/adler32") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake2b256</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"BLAKE2b algorithm with a digest size of 256, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4."</para>
    /// labels<para>"blake2b256"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b256">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b256</seealso>
    let ``HashAlgorithm/blake2b256`` =
        Prefixed_Name(ns1, "HashAlgorithm/blake2b256") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake2b384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"BLAKE2b algorithm with a digest size of 384, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4."</para>
    /// labels<para>"blake2b384"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b384">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b384</seealso>
    let ``HashAlgorithm/blake2b384`` =
        Prefixed_Name(ns1, "HashAlgorithm/blake2b384") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake2b512</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"BLAKE2b algorithm with a digest size of 512, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4."</para>
    /// labels<para>"blake2b512"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b512">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b512</seealso>
    let ``HashAlgorithm/blake2b512`` =
        Prefixed_Name(ns1, "HashAlgorithm/blake2b512") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"[BLAKE3](https://github.com/BLAKE3-team/BLAKE3-specs/blob/master/blake3.pdf)"</para>
    /// labels<para>"blake3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake3">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake3</seealso>
    let ``HashAlgorithm/blake3`` =
        Prefixed_Name(ns1, "HashAlgorithm/blake3") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/crystalsDilithium</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"[Dilithium](https://pq-crystals.org/dilithium/)"</para>
    /// labels<para>"crystalsDilithium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsDilithium">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsDilithium</seealso>
    let ``HashAlgorithm/crystalsDilithium`` =
        Prefixed_Name(ns1, "HashAlgorithm/crystalsDilithium") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/crystalsKyber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"[Kyber](https://pq-crystals.org/kyber/)"</para>
    /// labels<para>"crystalsKyber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsKyber">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsKyber</seealso>
    let ``HashAlgorithm/crystalsKyber`` =
        Prefixed_Name(ns1, "HashAlgorithm/crystalsKyber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/falcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"[FALCON](https://falcon-sign.info/falcon.pdf)"</para>
    /// labels<para>"falcon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/falcon">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/falcon</seealso>
    let ``HashAlgorithm/falcon`` =
        Prefixed_Name(ns1, "HashAlgorithm/falcon") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"MD2 message-digest algorithm, as defined in [RFC 1319](https://datatracker.ietf.org/doc/rfc1319/)."</para>
    /// labels<para>"md2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md2">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md2</seealso>
    let ``HashAlgorithm/md2`` = Prefixed_Name(ns1, "HashAlgorithm/md2") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"MD4 message-digest algorithm, as defined in [RFC 1186](https://datatracker.ietf.org/doc/rfc1186/)."</para>
    /// labels<para>"md4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md4">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md4</seealso>
    let ``HashAlgorithm/md4`` = Prefixed_Name(ns1, "HashAlgorithm/md4") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"MD5 message-digest algorithm, as defined in [RFC 1321](https://datatracker.ietf.org/doc/rfc1321/)."</para>
    /// labels<para>"md5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md5">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md5</seealso>
    let ``HashAlgorithm/md5`` = Prefixed_Name(ns1, "HashAlgorithm/md5") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"[MD6 hash function](https://people.csail.mit.edu/rivest/pubs/RABCx08.pdf)"</para>
    /// labels<para>"md6"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md6">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md6</seealso>
    let ``HashAlgorithm/md6`` = Prefixed_Name(ns1, "HashAlgorithm/md6") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"any hashing algorithm that does not exist in this list of entries"</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/other">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/other</seealso>
    let ``HashAlgorithm/other`` =
        Prefixed_Name(ns1, "HashAlgorithm/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha1</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SHA-1, a secure hashing algorithm, as defined in [RFC 3174](https://datatracker.ietf.org/doc/rfc3174/)."</para>
    /// labels<para>"sha1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha1">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha1</seealso>
    let ``HashAlgorithm/sha1`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha1") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha224</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SHA-2 with a digest length of 224, as defined in [RFC 3874](https://datatracker.ietf.org/doc/rfc3874/)."</para>
    /// labels<para>"sha224"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha224">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha224</seealso>
    let ``HashAlgorithm/sha224`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha224") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"SHA-2 with a digest length of 256, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/)."</para>
    /// labels<para>"sha256"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha256">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha256</seealso>
    let ``HashAlgorithm/sha256`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha256") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"SHA-2 with a digest length of 384, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/)."</para>
    /// labels<para>"sha384"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha384">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha384</seealso>
    let ``HashAlgorithm/sha384`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha384") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"SHA-3 with a digest length of 224, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final)."</para>
    /// labels<para>"sha3_224"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_224">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_224</seealso>
    let ``HashAlgorithm/sha3_224`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha3_224") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_256</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SHA-3 with a digest length of 256, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final)."</para>
    /// labels<para>"sha3_256"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_256">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_256</seealso>
    let ``HashAlgorithm/sha3_256`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha3_256") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>"SHA-3 with a digest length of 384, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final)."</para>
    /// labels<para>"sha3_384"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_384">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_384</seealso>
    let ``HashAlgorithm/sha3_384`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha3_384") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_512</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SHA-3 with a digest length of 512, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final)."</para>
    /// labels<para>"sha3_512"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_512">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_512</seealso>
    let ``HashAlgorithm/sha3_512`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha3_512") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha512</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SHA-2 with a digest length of 512, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/)."</para>
    /// labels<para>"sha512"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha512">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha512</seealso>
    let ``HashAlgorithm/sha512`` =
        Prefixed_Name(ns1, "HashAlgorithm/sha512") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IndividualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concrete subclass of Element used by Individuals in the
    /// Core profile."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IndividualElement">https://spdx.org/rdf/3.1/terms/Core/IndividualElement</seealso>
    let IndividualElement = Prefixed_Name(ns1, "IndividualElement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/IntegrityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Provides an independently reproducible mechanism that permits verification of a specific Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IntegrityMethod">https://spdx.org/rdf/3.1/terms/Core/IntegrityMethod</seealso>
    let IntegrityMethod = Prefixed_Name(ns1, "IntegrityMethod") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines the level of automation a system possesses."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel</seealso>
    let IsoAutomationLevel = Prefixed_Name(ns1, "IsoAutomationLevel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/assistiveAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Level 1 - Assistive automation. The system assists an operator."</para>
    /// labels<para>"assistiveAutomation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/assistiveAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/assistiveAutomation</seealso>
    let ``IsoAutomationLevel/assistiveAutomation`` =
        Prefixed_Name(ns1, "IsoAutomationLevel/assistiveAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/autonomous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>"Level 6 - Autonomous. The system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight."</para>
    /// labels<para>"autonomous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/autonomous">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/autonomous</seealso>
    let ``IsoAutomationLevel/autonomous`` =
        Prefixed_Name(ns1, "IsoAutomationLevel/autonomous") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/conditionalAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Level 3 - Conditional automation. The system can propose strategies and then automatically execute the approved plan, with an external agent being ready to take over when necessary."</para>
    /// labels<para>"conditionalAutomation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/conditionalAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/conditionalAutomation</seealso>
    let ``IsoAutomationLevel/conditionalAutomation`` =
        Prefixed_Name(ns1, "IsoAutomationLevel/conditionalAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/fullAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>"Level 5 - Full automation. The system is capable of performing its entire mission without external intervention."</para>
    /// labels<para>"fullAutomation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/fullAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/fullAutomation</seealso>
    let ``IsoAutomationLevel/fullAutomation`` =
        Prefixed_Name(ns1, "IsoAutomationLevel/fullAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/highAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Level 4 - High automation. The system performs parts of its mission without external intervention."</para>
    /// labels<para>"highAutomation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/highAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/highAutomation</seealso>
    let ``IsoAutomationLevel/highAutomation`` =
        Prefixed_Name(ns1, "IsoAutomationLevel/highAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/notAutomated</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Level 0 - Not automated. No automation. The operator fully controls the system."</para>
    /// labels<para>"notAutomated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/notAutomated">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/notAutomated</seealso>
    let ``IsoAutomationLevel/notAutomated`` =
        Prefixed_Name(ns1, "IsoAutomationLevel/notAutomated") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/partialAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Level 2 - Partial automation or task automation. Some sub-functions of the system are fully automated while the system remain under control of an external agent. The system can perform actions for an approved task without requiring the agent's continuous direct control."</para>
    /// labels<para>"partialAutomation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/partialAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/partialAutomation</seealso>
    let ``IsoAutomationLevel/partialAutomation`` =
        Prefixed_Name(ns1, "IsoAutomationLevel/partialAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Provide an enumerated set of lifecycle phases that can provide context to relationships."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType</seealso>
    let LifecycleScopeType = Prefixed_Name(ns1, "LifecycleScopeType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/build</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A relationship has specific context implications during an element's build phase, during development."</para>
    /// labels<para>"build"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/build">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/build</seealso>
    let ``LifecycleScopeType/build`` =
        Prefixed_Name(ns1, "LifecycleScopeType/build") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/decommission</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A relationship has specific context implications for a product's retirement and/or decommissioning."</para>
    /// labels<para>"decommission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/decommission">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/decommission</seealso>
    let ``LifecycleScopeType/decommission`` =
        Prefixed_Name(ns1, "LifecycleScopeType/decommission") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>"A relationship has specific context implications during an element's design."</para>
    /// labels<para>"design"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/design">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/design</seealso>
    let ``LifecycleScopeType/design`` =
        Prefixed_Name(ns1, "LifecycleScopeType/design") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/development</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A relationship has specific context implications during development phase of an element."</para>
    /// labels<para>"development"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/development">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/development</seealso>
    let ``LifecycleScopeType/development`` =
        Prefixed_Name(ns1, "LifecycleScopeType/development") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A relationship has other specific context information necessary to capture that the above set of enumerations does not handle."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/other">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/other</seealso>
    let ``LifecycleScopeType/other`` =
        Prefixed_Name(ns1, "LifecycleScopeType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/runtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A relationship has specific context implications during the execution phase of an element."</para>
    /// labels<para>"runtime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/runtime">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/runtime</seealso>
    let ``LifecycleScopeType/runtime`` =
        Prefixed_Name(ns1, "LifecycleScopeType/runtime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>"A relationship has specific context implications during an element's testing phase, during development."</para>
    /// labels<para>"test"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/test">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/test</seealso>
    let ``LifecycleScopeType/test`` =
        Prefixed_Name(ns1, "LifecycleScopeType/test") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/update</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A relationship has specific context implications for a product update."</para>
    /// labels<para>"update"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/update">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/update</seealso>
    let ``LifecycleScopeType/update`` =
        Prefixed_Name(ns1, "LifecycleScopeType/update") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Provide context for a relationship that occurs in the lifecycle."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopedRelationship">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopedRelationship</seealso>
    let LifecycleScopedRelationship =
        Prefixed_Name(ns1, "LifecycleScopedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Location is used to define the location, address or coordinates of a place."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Location">https://spdx.org/rdf/3.1/terms/Core/Location</seealso>
    let Location = Prefixed_Name(ns1, "Location") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/MeasureOfLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measure of length refers to the dimension of an object or space that describes how long it is, typically expressed in various units depending on the system of measurement being used."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfLength">https://spdx.org/rdf/3.1/terms/Core/MeasureOfLength</seealso>
    let MeasureOfLength = Prefixed_Name(ns1, "MeasureOfLength") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/MeasureOfMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measure of mass refers to the quantity of matter in an object or substance."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfMass">https://spdx.org/rdf/3.1/terms/Core/MeasureOfMass</seealso>
    let MeasureOfMass = Prefixed_Name(ns1, "MeasureOfMass") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/NamespaceMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A mapping between prefixes and namespace partial URIs."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/NamespaceMap">https://spdx.org/rdf/3.1/terms/Core/NamespaceMap</seealso>
    let NamespaceMap = Prefixed_Name(ns1, "NamespaceMap") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/NoAssertionElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IndividualElement</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An Individual Value for Element representing a set of Elements of unknown
    /// identity or cardinality (number)."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/NoAssertionElement">https://spdx.org/rdf/3.1/terms/Core/NoAssertionElement</seealso>
    let NoAssertionElement = Prefixed_Name(ns1, "NoAssertionElement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/NoneElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IndividualElement</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An Individual Value for Element representing a set of Elements with
    /// cardinality (number/count) of zero."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/NoneElement">https://spdx.org/rdf/3.1/terms/Core/NoneElement</seealso>
    let NoneElement = Prefixed_Name(ns1, "NoneElement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A group of people who work together in an organized way for a shared purpose."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Organization">https://spdx.org/rdf/3.1/terms/Core/Organization</seealso>
    let Organization = Prefixed_Name(ns1, "Organization") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PackageVerificationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"An SPDX version 2.X compatible verification method for software packages."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PackageVerificationCode">https://spdx.org/rdf/3.1/terms/Core/PackageVerificationCode</seealso>
    let PackageVerificationCode =
        Prefixed_Name(ns1, "PackageVerificationCode") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual human being."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Person">https://spdx.org/rdf/3.1/terms/Core/Person</seealso>
    let Person = Prefixed_Name(ns1, "Person") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/PhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A physical location is a tangible, geographically identifiable place where objects, people, or assets exist or operate."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PhysicalLocation">https://spdx.org/rdf/3.1/terms/Core/PhysicalLocation</seealso>
    let PhysicalLocation = Prefixed_Name(ns1, "PhysicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PositiveIntegerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A tuple of two positive integers that define a range."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PositiveIntegerRange">https://spdx.org/rdf/3.1/terms/Core/PositiveIntegerRange</seealso>
    let PositiveIntegerRange =
        Prefixed_Name(ns1, "PositiveIntegerRange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PresenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Categories of presence or absence."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType">https://spdx.org/rdf/3.1/terms/Core/PresenceType</seealso>
    let PresenceType = Prefixed_Name(ns1, "PresenceType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/PresenceType/no</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/PresenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates absence of the field."</para>
    /// labels<para>"no"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/no">https://spdx.org/rdf/3.1/terms/Core/PresenceType/no</seealso>
    let ``PresenceType/no`` = Prefixed_Name(ns1, "PresenceType/no") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PresenceType/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/PresenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Makes no assertion about the field."</para>
    /// labels<para>"noAssertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/noAssertion">https://spdx.org/rdf/3.1/terms/Core/PresenceType/noAssertion</seealso>
    let ``PresenceType/noAssertion`` =
        Prefixed_Name(ns1, "PresenceType/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PresenceType/yes</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/PresenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates presence of the field."</para>
    /// labels<para>"yes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/yes">https://spdx.org/rdf/3.1/terms/Core/PresenceType/yes</seealso>
    let ``PresenceType/yes`` = Prefixed_Name(ns1, "PresenceType/yes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ProcessReadinessType is defined by the enumeration."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType</seealso>
    let ProcessReadinessType =
        Prefixed_Name(ns1, "ProcessReadinessType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/active</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"in use"</para>
    /// labels<para>"active"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/active">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/active</seealso>
    let ``ProcessReadinessType/active`` =
        Prefixed_Name(ns1, "ProcessReadinessType/active") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"in production"</para>
    /// labels<para>"draft"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/draft">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/draft</seealso>
    let ``ProcessReadinessType/draft`` =
        Prefixed_Name(ns1, "ProcessReadinessType/draft") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/obsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>"superseded or not valid at present"</para>
    /// labels<para>"obsolete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/obsolete">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/obsolete</seealso>
    let ``ProcessReadinessType/obsolete`` =
        Prefixed_Name(ns1, "ProcessReadinessType/obsolete") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"other"</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/other">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/other</seealso>
    let ``ProcessReadinessType/other`` =
        Prefixed_Name(ns1, "ProcessReadinessType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enumeration of the valid profiles."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType</seealso>
    let ProfileIdentifierType =
        Prefixed_Name(ns1, "ProfileIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/ai</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>"The element follows the AI profile specification."</para>
    /// labels<para>"ai"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/ai">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/ai</seealso>
    let ``ProfileIdentifierType/ai`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/ai") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/build</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The element follows the Build profile specification."</para>
    /// labels<para>"build"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/build">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/build</seealso>
    let ``ProfileIdentifierType/build`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/build") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>"The element follows the Core profile specification."</para>
    /// labels<para>"core"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/core">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/core</seealso>
    let ``ProfileIdentifierType/core`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/core") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The element follows the Dataset profile specification."</para>
    /// labels<para>"dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/dataset">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/dataset</seealso>
    let ``ProfileIdentifierType/dataset`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/dataset") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/expandedLicensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The element follows the ExpandedLicensing profile specification."</para>
    /// labels<para>"expandedLicensing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/expandedLicensing">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/expandedLicensing</seealso>
    let ``ProfileIdentifierType/expandedLicensing`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/expandedLicensing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>"The element follows the Extension profile specification."</para>
    /// labels<para>"extension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/extension">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/extension</seealso>
    let ``ProfileIdentifierType/extension`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/extension") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The element follows the Hardware profile specification."</para>
    /// labels<para>"hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/hardware">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/hardware</seealso>
    let ``ProfileIdentifierType/hardware`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/hardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/lite</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The element follows the Lite profile specification."</para>
    /// labels<para>"lite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/lite">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/lite</seealso>
    let ``ProfileIdentifierType/lite`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/lite") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/security</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The element follows the Security profile specification."</para>
    /// labels<para>"security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/security">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/security</seealso>
    let ``ProfileIdentifierType/security`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/security") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/simpleLicensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>"The element follows the SimpleLicensing profile specification."</para>
    /// labels<para>"simpleLicensing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/simpleLicensing">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/simpleLicensing</seealso>
    let ``ProfileIdentifierType/simpleLicensing`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/simpleLicensing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/software</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The element follows the Software profile specification."</para>
    /// labels<para>"software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/software">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/software</seealso>
    let ``ProfileIdentifierType/software`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/software") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/supplyChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>"The element follows the SupplyChain profile specification."</para>
    /// labels<para>"supplyChain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/supplyChain">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/supplyChain</seealso>
    let ``ProfileIdentifierType/supplyChain`` =
        Prefixed_Name(ns1, "ProfileIdentifierType/supplyChain") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regulation represents a rule or directive maintained by an authority."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Regulation">https://spdx.org/rdf/3.1/terms/Core/Regulation</seealso>
    let Regulation = Prefixed_Name(ns1, "Regulation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a relationship between one or more elements."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Relationship">https://spdx.org/rdf/3.1/terms/Core/Relationship</seealso>
    let Relationship = Prefixed_Name(ns1, "Relationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates whether a relationship is known to be complete, incomplete, or if no assertion is made with respect to relationship completeness."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness</seealso>
    let RelationshipCompleteness =
        Prefixed_Name(ns1, "RelationshipCompleteness") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness/complete</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The relationship is known to be exhaustive."</para>
    /// labels<para>"complete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/complete">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/complete</seealso>
    let ``RelationshipCompleteness/complete`` =
        Prefixed_Name(ns1, "RelationshipCompleteness/complete") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness/incomplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    ///   <para>"The relationship is known not to be exhaustive."</para>
    /// labels<para>"incomplete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/incomplete">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/incomplete</seealso>
    let ``RelationshipCompleteness/incomplete`` =
        Prefixed_Name(ns1, "RelationshipCompleteness/incomplete") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    ///   <para>"No assertion can be made about the completeness of the relationship."</para>
    /// labels<para>"noAssertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/noAssertion">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/noAssertion</seealso>
    let ``RelationshipCompleteness/noAssertion`` =
        Prefixed_Name(ns1, "RelationshipCompleteness/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information about the relationship between two Elements."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType">https://spdx.org/rdf/3.1/terms/Core/RelationshipType</seealso>
    let RelationshipType = Prefixed_Name(ns1, "RelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Vulnerability, Action or DefinedProcess affects each `to` Element."</para>
    /// labels<para>"affects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/affects">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/affects</seealso>
    let ``RelationshipType/affects`` =
        Prefixed_Name(ns1, "RelationshipType/affects") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/amendedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element is amended by each `to` Element."</para>
    /// labels<para>"amendedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/amendedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/amendedBy</seealso>
    let ``RelationshipType/amendedBy`` =
        Prefixed_Name(ns1, "RelationshipType/amendedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/ancestorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element is an ancestor of each `to` Element."</para>
    /// labels<para>"ancestorOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/ancestorOf">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/ancestorOf</seealso>
    let ``RelationshipType/ancestorOf`` =
        Prefixed_Name(ns1, "RelationshipType/ancestorOf") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/availableFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element is available from the additional supplier described by each `to` Element."</para>
    /// labels<para>"availableFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/availableFrom">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/availableFrom</seealso>
    let ``RelationshipType/availableFrom`` =
        Prefixed_Name(ns1, "RelationshipType/availableFrom") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/configures</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element is a configuration applied to each `to` Element, during a LifecycleScopeType period."</para>
    /// labels<para>"configures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/configures">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/configures</seealso>
    let ``RelationshipType/configures`` =
        Prefixed_Name(ns1, "RelationshipType/configures") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/conformsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element conforms to each `to` Specification."</para>
    /// labels<para>"conformsTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/conformsTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/conformsTo</seealso>
    let ``RelationshipType/conformsTo`` =
        Prefixed_Name(ns1, "RelationshipType/conformsTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element contains each `to` Element."</para>
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/contains">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/contains</seealso>
    let ``RelationshipType/contains`` =
        Prefixed_Name(ns1, "RelationshipType/contains") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/coordinatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Vulnerability is coordinatedBy the `to` Agent(s) (vendor, researcher, or consumer agent)."</para>
    /// labels<para>"coordinatedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/coordinatedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/coordinatedBy</seealso>
    let ``RelationshipType/coordinatedBy`` =
        Prefixed_Name(ns1, "RelationshipType/coordinatedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/copiedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has been copied to each `to` Element."</para>
    /// labels<para>"copiedTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/copiedTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/copiedTo</seealso>
    let ``RelationshipType/copiedTo`` =
        Prefixed_Name(ns1, "RelationshipType/copiedTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element's Action or DefinedProcess is createdBy `to` Agent(s)."</para>
    /// labels<para>"createdBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/createdBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/createdBy</seealso>
    let ``RelationshipType/createdBy`` =
        Prefixed_Name(ns1, "RelationshipType/createdBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/delegatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Agent is delegating an action to the Agent of the `to` Relationship (which shall be of type invokedBy), during a LifecycleScopeType (e.g. the `to` invokedBy Relationship is being done on behalf of `from`)."</para>
    /// labels<para>"delegatedTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/delegatedTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/delegatedTo</seealso>
    let ``RelationshipType/delegatedTo`` =
        Prefixed_Name(ns1, "RelationshipType/delegatedTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element depends on each `to` Element, during a LifecycleScopeType period."</para>
    /// labels<para>"dependsOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/dependsOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/dependsOn</seealso>
    let ``RelationshipType/dependsOn`` =
        Prefixed_Name(ns1, "RelationshipType/dependsOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/descendantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element is a descendant of each `to` Element."</para>
    /// labels<para>"descendantOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/descendantOf">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/descendantOf</seealso>
    let ``RelationshipType/descendantOf`` =
        Prefixed_Name(ns1, "RelationshipType/descendantOf") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element describes each `to` Element. To denote the root(s) of a tree of elements in a collection, the rootElement property shall be used."</para>
    /// labels<para>"describes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/describes">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/describes</seealso>
    let ``RelationshipType/describes`` =
        Prefixed_Name(ns1, "RelationshipType/describes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/doesNotAffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Vulnerability has no impact on each `to` Element. The use of the `doesNotAffect` is constrained to `VexNotAffectedVulnAssessmentRelationship` classed relationships."</para>
    /// labels<para>"doesNotAffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/doesNotAffect">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/doesNotAffect</seealso>
    let ``RelationshipType/doesNotAffect`` =
        Prefixed_Name(ns1, "RelationshipType/doesNotAffect") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/evaluatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has been evaluated on the `to` Element(s)."</para>
    /// labels<para>"evaluatedOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/evaluatedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/evaluatedOn</seealso>
    let ``RelationshipType/evaluatedOn`` =
        Prefixed_Name(ns1, "RelationshipType/evaluatedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/expandsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element expands out as an artifact described by each `to` Element."</para>
    /// labels<para>"expandsTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/expandsTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/expandsTo</seealso>
    let ``RelationshipType/expandsTo`` =
        Prefixed_Name(ns1, "RelationshipType/expandsTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/exploitCreatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Vulnerability has had an exploit created against it by each `to` Agent."</para>
    /// labels<para>"exploitCreatedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/exploitCreatedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/exploitCreatedBy</seealso>
    let ``RelationshipType/exploitCreatedBy`` =
        Prefixed_Name(ns1, "RelationshipType/exploitCreatedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/finetunedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has been finetuned on the `to` Element(s)."</para>
    /// labels<para>"finetunedOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/finetunedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/finetunedOn</seealso>
    let ``RelationshipType/finetunedOn`` =
        Prefixed_Name(ns1, "RelationshipType/finetunedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/fixedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Designates a `from` Vulnerability has been fixed by the `to` Agent(s)."</para>
    /// labels<para>"fixedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedBy</seealso>
    let ``RelationshipType/fixedBy`` =
        Prefixed_Name(ns1, "RelationshipType/fixedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/fixedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A `from` Vulnerability has been fixed in each `to` Element. The use of the `fixedIn` type is constrained to `VexFixedVulnAssessmentRelationship` classed relationships."</para>
    /// labels<para>"fixedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedIn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedIn</seealso>
    let ``RelationshipType/fixedIn`` =
        Prefixed_Name(ns1, "RelationshipType/fixedIn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `to` Element succeeds the `from` Element, establishing a unidirectional sequence. This succession is defined as chronological, procedural, or logical. It is used to represent either a temporal order (e.g., in a workflow) or a logical order for processing and traversal (e.g., in an ordered list)."</para>
    /// labels<para>"follows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/follows">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/follows</seealso>
    let ``RelationshipType/follows`` =
        Prefixed_Name(ns1, "RelationshipType/follows") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/foundBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Designates a `from` Vulnerability was originally discovered by the `to` Agent(s)."</para>
    /// labels<para>"foundBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/foundBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/foundBy</seealso>
    let ``RelationshipType/foundBy`` =
        Prefixed_Name(ns1, "RelationshipType/foundBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/generates</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element generates each `to` Element."</para>
    /// labels<para>"generates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/generates">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/generates</seealso>
    let ``RelationshipType/generates`` =
        Prefixed_Name(ns1, "RelationshipType/generates") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasAddedFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is a file added to the `from` Element (`from` hasAddedFile `to`)."</para>
    /// labels<para>"hasAddedFile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAddedFile">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAddedFile</seealso>
    let ``RelationshipType/hasAddedFile`` =
        Prefixed_Name(ns1, "RelationshipType/hasAddedFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasAssessmentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Relates a `from` Vulnerability and each `to` Element with a security assessment. To be used with `VulnAssessmentRelationship` types."</para>
    /// labels<para>"hasAssessmentFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssessmentFor">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssessmentFor</seealso>
    let ``RelationshipType/hasAssessmentFor`` =
        Prefixed_Name(ns1, "RelationshipType/hasAssessmentFor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasAssociatedVulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Used to associate a `from` Artifact with each `to` Vulnerability."</para>
    /// labels<para>"hasAssociatedVulnerability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssociatedVulnerability">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssociatedVulnerability</seealso>
    let ``RelationshipType/hasAssociatedVulnerability`` =
        Prefixed_Name(ns1, "RelationshipType/hasAssociatedVulnerability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasConcludedLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` SoftwareArtifact is concluded by the SPDX data creator to be governed by each `to` AnyLicenseInfo."</para>
    /// labels<para>"hasConcludedLicense"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasConcludedLicense">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasConcludedLicense</seealso>
    let ``RelationshipType/hasConcludedLicense`` =
        Prefixed_Name(ns1, "RelationshipType/hasConcludedLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Artifact has each `to` Agent as a contact point. The use of `hasContactPoint` type is constrained to `ContactPointRelationship` typed relationships. The type of contact (i.e. security) may be specified using a `ContactPointRelationship` element."</para>
    /// labels<para>"hasContactPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasContactPoint">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasContactPoint</seealso>
    let ``RelationshipType/hasContactPoint`` =
        Prefixed_Name(ns1, "RelationshipType/hasContactPoint") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDataFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element treats each `to` Element as a data file. A data file is an artifact that stores data required or optional for the `from` Element's functionality. A data file can be a database file, an index file, a log file, an AI model file, a calibration data file, a temporary file, a backup file, and more. For AI training dataset, test dataset, test artifact, configuration data, build input data, and build output data, please consider using the more specific relationship types: `trainedOn`, `testedOn`, `hasTest`, `configures`, `hasInput`, and `hasOutput`, respectively. This relationship does not imply dependency."</para>
    /// labels<para>"hasDataFile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDataFile">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDataFile</seealso>
    let ``RelationshipType/hasDataFile`` =
        Prefixed_Name(ns1, "RelationshipType/hasDataFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDeclaredLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` SoftwareArtifact was discovered to actually contain each `to` AnyLicenseInfo (for example, as detected by automated tooling)."</para>
    /// labels<para>"hasDeclaredLicense"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeclaredLicense">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeclaredLicense</seealso>
    let ``RelationshipType/hasDeclaredLicense`` =
        Prefixed_Name(ns1, "RelationshipType/hasDeclaredLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDeletedFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Every `to` Element is a file deleted from the `from` Element (`from` hasDeletedFile `to`)."</para>
    /// labels<para>"hasDeletedFile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeletedFile">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeletedFile</seealso>
    let ``RelationshipType/hasDeletedFile`` =
        Prefixed_Name(ns1, "RelationshipType/hasDeletedFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDependencyManifest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has manifest files that contain dependency information in each `to` Element."</para>
    /// labels<para>"hasDependencyManifest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDependencyManifest">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDependencyManifest</seealso>
    let ``RelationshipType/hasDependencyManifest`` =
        Prefixed_Name(ns1, "RelationshipType/hasDependencyManifest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDistributionArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element is distributed as an artifact in each `to` Element (e.g. an RPM or archive file)."</para>
    /// labels<para>"hasDistributionArtifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDistributionArtifact">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDistributionArtifact</seealso>
    let ``RelationshipType/hasDistributionArtifact`` =
        Prefixed_Name(ns1, "RelationshipType/hasDistributionArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element is documented by each `to` Element."</para>
    /// labels<para>"hasDocumentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDocumentation">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDocumentation</seealso>
    let ``RelationshipType/hasDocumentation`` =
        Prefixed_Name(ns1, "RelationshipType/hasDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDynamicLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element dynamically links in each `to` Element, during a LifecycleScopeType period."</para>
    /// labels<para>"hasDynamicLink"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDynamicLink">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDynamicLink</seealso>
    let ``RelationshipType/hasDynamicLink`` =
        Prefixed_Name(ns1, "RelationshipType/hasDynamicLink") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Every `to` Element is considered as evidence for the `from` Element (`from` hasEvidence `to`)."</para>
    /// labels<para>"hasEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasEvidence">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasEvidence</seealso>
    let ``RelationshipType/hasEvidence`` =
        Prefixed_Name(ns1, "RelationshipType/hasEvidence") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Every `to` Element is an example for the `from` Element (`from` hasExample `to`)."</para>
    /// labels<para>"hasExample"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasExample">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasExample</seealso>
    let ``RelationshipType/hasExample`` =
        Prefixed_Name(ns1, "RelationshipType/hasExample") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasHost</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Build was run on the `to` Element during a LifecycleScopeType period (e.g. the host that the build runs on)."</para>
    /// labels<para>"hasHost"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasHost">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasHost</seealso>
    let ``RelationshipType/hasHost`` =
        Prefixed_Name(ns1, "RelationshipType/hasHost") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Build, DefinedProcess or Action element has each `to` Element as an input."</para>
    /// labels<para>"hasInput"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasInput">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasInput</seealso>
    let ``RelationshipType/hasInput`` =
        Prefixed_Name(ns1, "RelationshipType/hasInput") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Every `to` Element is metadata about the `from` Element (`from` hasMetadata `to`)."</para>
    /// labels<para>"hasMetadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasMetadata">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasMetadata</seealso>
    let ``RelationshipType/hasMetadata`` =
        Prefixed_Name(ns1, "RelationshipType/hasMetadata") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasOptionalComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is an optional component of the `from` Element (`from` hasOptionalComponent `to`)."</para>
    /// labels<para>"hasOptionalComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalComponent">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalComponent</seealso>
    let ``RelationshipType/hasOptionalComponent`` =
        Prefixed_Name(ns1, "RelationshipType/hasOptionalComponent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasOptionalDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element optionally depends on each `to` Element, during a LifecycleScopeType period."</para>
    /// labels<para>"hasOptionalDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalDependency">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalDependency</seealso>
    let ``RelationshipType/hasOptionalDependency`` =
        Prefixed_Name(ns1, "RelationshipType/hasOptionalDependency") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Build, DefinedProcess or Action element generates each `to` Element as an output."</para>
    /// labels<para>"hasOutput"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOutput">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOutput</seealso>
    let ``RelationshipType/hasOutput`` =
        Prefixed_Name(ns1, "RelationshipType/hasOutput") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasPrerequisite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has a prerequisite on each `to` Element, during a LifecycleScopeType period."</para>
    /// labels<para>"hasPrerequisite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasPrerequisite">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasPrerequisite</seealso>
    let ``RelationshipType/hasPrerequisite`` =
        Prefixed_Name(ns1, "RelationshipType/hasPrerequisite") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasProvidedDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element has a dependency on each `to` Element, dependency is not in the distributed artifact, but assumed to be provided, during a LifecycleScopeType period."</para>
    /// labels<para>"hasProvidedDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasProvidedDependency">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasProvidedDependency</seealso>
    let ``RelationshipType/hasProvidedDependency`` =
        Prefixed_Name(ns1, "RelationshipType/hasProvidedDependency") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element has a requirement on each `to` Element, during a LifecycleScopeType period."</para>
    /// labels<para>"hasRequirement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasRequirement">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasRequirement</seealso>
    let ``RelationshipType/hasRequirement`` =
        Prefixed_Name(ns1, "RelationshipType/hasRequirement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` ResolutionAction point to the `to` OutOfSpecAction that is addressed."</para>
    /// labels<para>"hasResolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasResolution">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasResolution</seealso>
    let ``RelationshipType/hasResolution`` =
        Prefixed_Name(ns1, "RelationshipType/hasResolution") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is a specification for the `from` Element (`from` hasSpecification `to`), during a LifecycleScopeType period."</para>
    /// labels<para>"hasSpecification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasSpecification">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasSpecification</seealso>
    let ``RelationshipType/hasSpecification`` =
        Prefixed_Name(ns1, "RelationshipType/hasSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasStaticLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element statically links in each `to` Element, during a LifecycleScopeType period."</para>
    /// labels<para>"hasStaticLink"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasStaticLink">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasStaticLink</seealso>
    let ``RelationshipType/hasStaticLink`` =
        Prefixed_Name(ns1, "RelationshipType/hasStaticLink") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Every `to` Element is a test artifact for the `from` Element (`from` hasTest `to`), during a LifecycleScopeType period."</para>
    /// labels<para>"hasTest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTest">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTest</seealso>
    let ``RelationshipType/hasTest`` =
        Prefixed_Name(ns1, "RelationshipType/hasTest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is a test case for the `from` Element (`from` hasTestCase `to`)."</para>
    /// labels<para>"hasTestCase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTestCase">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTestCase</seealso>
    let ``RelationshipType/hasTestCase`` =
        Prefixed_Name(ns1, "RelationshipType/hasTestCase") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is a variant the `from` Element (`from` hasVariant `to`)."</para>
    /// labels<para>"hasVariant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasVariant">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasVariant</seealso>
    let ``RelationshipType/hasVariant`` =
        Prefixed_Name(ns1, "RelationshipType/hasVariant") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/implementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Requirement is implemented in the `to` Element(s)."</para>
    /// labels<para>"implementedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/implementedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/implementedBy</seealso>
    let ``RelationshipType/implementedBy`` =
        Prefixed_Name(ns1, "RelationshipType/implementedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/invokedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element was invoked by the `to` Agent, during a LifecycleScopeType period (for example, a Build element that describes a build step)."</para>
    /// labels<para>"invokedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/invokedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/invokedBy</seealso>
    let ``RelationshipType/invokedBy`` =
        Prefixed_Name(ns1, "RelationshipType/invokedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/locatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"`from` element located at a specific `to` location. A time period is optional."</para>
    /// labels<para>"locatedAt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/locatedAt">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/locatedAt</seealso>
    let ``RelationshipType/locatedAt`` =
        Prefixed_Name(ns1, "RelationshipType/locatedAt") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/modifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element is modified by each `to` Element."</para>
    /// labels<para>"modifiedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/modifiedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/modifiedBy</seealso>
    let ``RelationshipType/modifiedBy`` =
        Prefixed_Name(ns1, "RelationshipType/modifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is related to the `from` Element where the relationship type is not described by any of the SPDX relationship types (this relationship is directionless)."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/other">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/other</seealso>
    let ``RelationshipType/other`` =
        Prefixed_Name(ns1, "RelationshipType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/packagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is a packaged instance of the `from` Element (`from` packagedBy `to`)."</para>
    /// labels<para>"packagedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/packagedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/packagedBy</seealso>
    let ``RelationshipType/packagedBy`` =
        Prefixed_Name(ns1, "RelationshipType/packagedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/patchedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Every `to` Element is a patch for the `from` Element (`from` patchedBy `to`)."</para>
    /// labels<para>"patchedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/patchedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/patchedBy</seealso>
    let ``RelationshipType/patchedBy`` =
        Prefixed_Name(ns1, "RelationshipType/patchedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/performedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Every `from` action is performedBy `to` Agent."</para>
    /// labels<para>"performedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/performedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/performedBy</seealso>
    let ``RelationshipType/performedBy`` =
        Prefixed_Name(ns1, "RelationshipType/performedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/pretrainedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has been pretrained on the `to` Element(s)."</para>
    /// labels<para>"pretrainedOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/pretrainedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/pretrainedOn</seealso>
    let ``RelationshipType/pretrainedOn`` =
        Prefixed_Name(ns1, "RelationshipType/pretrainedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/providesSupportFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Agent provides support for each `to` Artifact. Shall be a `SupportRelationship` type."</para>
    /// labels<para>"providesSupportFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/providesSupportFor">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/providesSupportFor</seealso>
    let ``RelationshipType/providesSupportFor`` =
        Prefixed_Name(ns1, "RelationshipType/providesSupportFor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/publishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Designates a `from` Vulnerability was made available for public use or reference by each `to` Agent."</para>
    /// labels<para>"publishedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/publishedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/publishedBy</seealso>
    let ``RelationshipType/publishedBy`` =
        Prefixed_Name(ns1, "RelationshipType/publishedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/reportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Designates a `from` Vulnerability was first reported to a project, vendor, or tracking database for formal identification by each `to` Agent."</para>
    /// labels<para>"reportedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/reportedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/reportedBy</seealso>
    let ``RelationshipType/reportedBy`` =
        Prefixed_Name(ns1, "RelationshipType/reportedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/republishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"Designates a `from` Vulnerability's details were tracked, aggregated, and/or enriched to improve context (i.e. NVD) by each `to` Agent."</para>
    /// labels<para>"republishedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/republishedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/republishedBy</seealso>
    let ``RelationshipType/republishedBy`` =
        Prefixed_Name(ns1, "RelationshipType/republishedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/resolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `to` OutOfSpecAction is resolved in the `from` ResolutionAction."</para>
    /// labels<para>"resolved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/resolved">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/resolved</seealso>
    let ``RelationshipType/resolved`` =
        Prefixed_Name(ns1, "RelationshipType/resolved") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/runsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element (the instructions) of runs on each `to` Hardware (processing element), during a LifecycleScopeType period."</para>
    /// labels<para>"runsOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/runsOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/runsOn</seealso>
    let ``RelationshipType/runsOn`` =
        Prefixed_Name(ns1, "RelationshipType/runsOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/serializedInArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` SpdxDocument can be found in a serialized form in each `to` Artifact."</para>
    /// labels<para>"serializedInArtifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/serializedInArtifact">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/serializedInArtifact</seealso>
    let ``RelationshipType/serializedInArtifact`` =
        Prefixed_Name(ns1, "RelationshipType/serializedInArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/testedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has been tested on the `to` Element(s)."</para>
    /// labels<para>"testedOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/testedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/testedOn</seealso>
    let ``RelationshipType/testedOn`` =
        Prefixed_Name(ns1, "RelationshipType/testedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/tracedToDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"the `from` Requirement is refined and further elaborated by each `to` Requirement, which contains more detailed implementation information."</para>
    /// labels<para>"tracedToDetail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/tracedToDetail">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/tracedToDetail</seealso>
    let ``RelationshipType/tracedToDetail`` =
        Prefixed_Name(ns1, "RelationshipType/tracedToDetail") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/trainedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Element has been trained on the `to` Element(s)."</para>
    /// labels<para>"trainedOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/trainedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/trainedOn</seealso>
    let ``RelationshipType/trainedOn`` =
        Prefixed_Name(ns1, "RelationshipType/trainedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/underInvestigationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>"The `from` Vulnerability impact is being investigated for each `to` Element. The use of the `underInvestigationFor` type is constrained to `VexUnderInvestigationVulnAssessmentRelationship` classed relationships."</para>
    /// labels<para>"underInvestigationFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/underInvestigationFor">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/underInvestigationFor</seealso>
    let ``RelationshipType/underInvestigationFor`` =
        Prefixed_Name(ns1, "RelationshipType/underInvestigationFor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/usesTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element uses each `to` Element as a tool, during a LifecycleScopeType period."</para>
    /// labels<para>"usesTool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/usesTool">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/usesTool</seealso>
    let ``RelationshipType/usesTool`` =
        Prefixed_Name(ns1, "RelationshipType/usesTool") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/validatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Element has been validated on the `to` Element(s)."</para>
    /// labels<para>"validatedOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/validatedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/validatedOn</seealso>
    let ``RelationshipType/validatedOn`` =
        Prefixed_Name(ns1, "RelationshipType/validatedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/verifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `from` Requirement that has verification (test, review, analysis etc.) details defined in the `to` RequirementVerification."</para>
    /// labels<para>"verifiedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/verifiedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/verifiedBy</seealso>
    let ``RelationshipType/verifiedBy`` =
        Prefixed_Name(ns1, "RelationshipType/verifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A distinct unit representing a requirement, as used in systems, software, and hardware engineering."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Requirement">https://spdx.org/rdf/3.1/terms/Core/Requirement</seealso>
    let Requirement = Prefixed_Name(ns1, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/SoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software agent."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SoftwareAgent">https://spdx.org/rdf/3.1/terms/Core/SoftwareAgent</seealso>
    let SoftwareAgent = Prefixed_Name(ns1, "SoftwareAgent") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/SpdxDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of SPDX Elements that could potentially be serialized."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpdxDocument">https://spdx.org/rdf/3.1/terms/Core/SpdxDocument</seealso>
    let SpdxDocument = Prefixed_Name(ns1, "SpdxDocument") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/SpdxOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An Organization representing the SPDX Project."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpdxOrganization">https://spdx.org/rdf/3.1/terms/Core/SpdxOrganization</seealso>
    let SpdxOrganization = Prefixed_Name(ns1, "SpdxOrganization") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A specification is a detailed description of the design, requirements,
    /// or features of a product, process, or system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Specification">https://spdx.org/rdf/3.1/terms/Core/Specification</seealso>
    let Specification = Prefixed_Name(ns1, "Specification") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/SpecificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specification type defines the nature of a specification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType">https://spdx.org/rdf/3.1/terms/Core/SpecificationType</seealso>
    let SpecificationType = Prefixed_Name(ns1, "SpecificationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/formalStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>"A formal standard is a standard ratified by a recognized standards-development organization and published as a normative reference."</para>
    /// labels<para>"formalStandard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/formalStandard">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/formalStandard</seealso>
    let ``SpecificationType/formalStandard`` =
        Prefixed_Name(ns1, "SpecificationType/formalStandard") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>"Any specification that does not fall under any of the other entries."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/other">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/other</seealso>
    let ``SpecificationType/other`` =
        Prefixed_Name(ns1, "SpecificationType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A mandatory legal specification issued by a governmental or regulatory authority. Compliance is enforceable by law."</para>
    /// labels<para>"regulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/regulation">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/regulation</seealso>
    let ``SpecificationType/regulation`` =
        Prefixed_Name(ns1, "SpecificationType/regulation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>"A specification is a detailed document (or set of documents) that describes the requirements, design, behavior, or other characteristics of a system, component, or process so that all stakeholders have a clear, unambiguous reference."</para>
    /// labels<para>"specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/specification">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/specification</seealso>
    let ``SpecificationType/specification`` =
        Prefixed_Name(ns1, "SpecificationType/specification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Describes how an Agent provides support for an Artifact."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportRelationship">https://spdx.org/rdf/3.1/terms/Core/SupportRelationship</seealso>
    let SupportRelationship = Prefixed_Name(ns1, "SupportRelationship") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/SupportType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of support that is associated with an artifact."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType">https://spdx.org/rdf/3.1/terms/Core/SupportType</seealso>
    let SupportType = Prefixed_Name(ns1, "SupportType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/deployed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>"In addition to being supported by the supplier, the software is known to have been deployed and is in use. For a software as a service provider, this implies the software is now available as a service."</para>
    /// labels<para>"deployed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/deployed">https://spdx.org/rdf/3.1/terms/Core/SupportType/deployed</seealso>
    let ``SupportType/deployed`` =
        Prefixed_Name(ns1, "SupportType/deployed") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/development</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>"The artifact is in active development and is not considered ready for formal support from the supplier."</para>
    /// labels<para>"development"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/development">https://spdx.org/rdf/3.1/terms/Core/SupportType/development</seealso>
    let ``SupportType/development`` =
        Prefixed_Name(ns1, "SupportType/development") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/endOfSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>"There is a defined end of support for the artifact from the supplier. This may also be referred to as end of life. There is a validUntilDate that can be used to signal when support ends for the artifact."</para>
    /// labels<para>"endOfSupport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/endOfSupport">https://spdx.org/rdf/3.1/terms/Core/SupportType/endOfSupport</seealso>
    let ``SupportType/endOfSupport`` =
        Prefixed_Name(ns1, "SupportType/endOfSupport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/limitedSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The artifact has been released, and there is limited support available from the supplier. There is a validUntilDate that can provide additional information about the duration of support."</para>
    /// labels<para>"limitedSupport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/limitedSupport">https://spdx.org/rdf/3.1/terms/Core/SupportType/limitedSupport</seealso>
    let ``SupportType/limitedSupport`` =
        Prefixed_Name(ns1, "SupportType/limitedSupport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>"No assertion about the type of support is made. This is considered the default if no other support type is used."</para>
    /// labels<para>"noAssertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noAssertion">https://spdx.org/rdf/3.1/terms/Core/SupportType/noAssertion</seealso>
    let ``SupportType/noAssertion`` =
        Prefixed_Name(ns1, "SupportType/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/noSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"There is no support for the artifact from the supplier, consumer assumes any support obligations."</para>
    /// labels<para>"noSupport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noSupport">https://spdx.org/rdf/3.1/terms/Core/SupportType/noSupport</seealso>
    let ``SupportType/noSupport`` =
        Prefixed_Name(ns1, "SupportType/noSupport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>"The artifact has been released, and is supported from the supplier. There is a validUntilDate that can provide additional information about the duration of support."</para>
    /// labels<para>"support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/support">https://spdx.org/rdf/3.1/terms/Core/SupportType/support</seealso>
    let ``SupportType/support`` =
        Prefixed_Name(ns1, "SupportType/support") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An element of hardware and/or software utilized to carry out a particular function."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Tool">https://spdx.org/rdf/3.1/terms/Core/Tool</seealso>
    let Tool = Prefixed_Name(ns1, "Tool") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"UnitofMeasure specify information structures through industry standards for Units of Measure, Quantity Kinds, Dimensions and Data Types."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/UnitOfMeasure">https://spdx.org/rdf/3.1/terms/Core/UnitOfMeasure</seealso>
    let UnitOfMeasure = Prefixed_Name(ns1, "UnitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/actionEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that describes the time at which an action stops."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/actionEndTime">https://spdx.org/rdf/3.1/terms/Core/actionEndTime</seealso>
    let actionEndTime = Prefixed_Name(ns1, "actionEndTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/actionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Location of a specific action."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/actionLocation">https://spdx.org/rdf/3.1/terms/Core/actionLocation</seealso>
    let actionLocation = Prefixed_Name(ns1, "actionLocation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/actionStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property describing the start time of an action."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/actionStartTime">https://spdx.org/rdf/3.1/terms/Core/actionStartTime</seealso>
    let actionStartTime = Prefixed_Name(ns1, "actionStartTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/additionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Additional relevance information."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/additionalInformation">https://spdx.org/rdf/3.1/terms/Core/additionalInformation</seealso>
    let additionalInformation =
        Prefixed_Name(ns1, "additionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the algorithm used for calculating the hash value."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/algorithm">https://spdx.org/rdf/3.1/terms/Core/algorithm</seealso>
    let algorithm = Prefixed_Name(ns1, "algorithm") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/annotationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the type of annotation."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/annotationType">https://spdx.org/rdf/3.1/terms/Core/annotationType</seealso>
    let annotationType = Prefixed_Name(ns1, "annotationType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/beginIntegerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the beginning of a range."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/beginIntegerRange">https://spdx.org/rdf/3.1/terms/Core/beginIntegerRange</seealso>
    let beginIntegerRange = Prefixed_Name(ns1, "beginIntegerRange") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/builtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the time an artifact was built."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/builtTime">https://spdx.org/rdf/3.1/terms/Core/builtTime</seealso>
    let builtTime = Prefixed_Name(ns1, "builtTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/city</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"City is a specific name used to define a locality."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/city">https://spdx.org/rdf/3.1/terms/Core/city</seealso>
    let city = Prefixed_Name(ns1, "city") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provide consumers with comments by the creator of the Element about the
    /// Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/comment">https://spdx.org/rdf/3.1/terms/Core/comment</seealso>
    let comment = Prefixed_Name(ns1, "comment") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/completeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides information about the completeness of relationships."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/completeness">https://spdx.org/rdf/3.1/terms/Core/completeness</seealso>
    let completeness = Prefixed_Name(ns1, "completeness") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/contactType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the nature of the contactPointRelationship."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/contactType">https://spdx.org/rdf/3.1/terms/Core/contactType</seealso>
    let contactType = Prefixed_Name(ns1, "contactType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides information about the content type of an Element or a property."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/contentType">https://spdx.org/rdf/3.1/terms/Core/contentType</seealso>
    let contentType = Prefixed_Name(ns1, "contentType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Gives information about the circumstances or unifying properties
    /// that Elements of the bundle have been assembled under."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/context">https://spdx.org/rdf/3.1/terms/Core/context</seealso>
    let context = Prefixed_Name(ns1, "context") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies a country code of the location."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/country">https://spdx.org/rdf/3.1/terms/Core/country</seealso>
    let country = Prefixed_Name(ns1, "country") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/countyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A code that identifies a county."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/countyCode">https://spdx.org/rdf/3.1/terms/Core/countyCode</seealso>
    let countyCode = Prefixed_Name(ns1, "countyCode") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies when the Element was originally created."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/created">https://spdx.org/rdf/3.1/terms/Core/created</seealso>
    let created = Prefixed_Name(ns1, "created") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies who or what created the Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/createdBy">https://spdx.org/rdf/3.1/terms/Core/createdBy</seealso>
    let createdBy = Prefixed_Name(ns1, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/createdUsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the tooling that was used during the creation of the Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/createdUsing">https://spdx.org/rdf/3.1/terms/Core/createdUsing</seealso>
    let createdUsing = Prefixed_Name(ns1, "createdUsing") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/creationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides information about the creation of the Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/creationInfo">https://spdx.org/rdf/3.1/terms/Core/creationInfo</seealso>
    let creationInfo = Prefixed_Name(ns1, "creationInfo") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/dataLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides the license under which the SPDX documentation of the Element can be
    /// used."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/dataLicense">https://spdx.org/rdf/3.1/terms/Core/dataLicense</seealso>
    let dataLicense = Prefixed_Name(ns1, "dataLicense") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/definingArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Artifact representing a serialization instance of SPDX data containing the
    /// definition of a particular Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/definingArtifact">https://spdx.org/rdf/3.1/terms/Core/definingArtifact</seealso>
    let definingArtifact = Prefixed_Name(ns1, "definingArtifact") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/definitionSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of a type, ensuring accuracy, context, and standardization."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/definitionSource">https://spdx.org/rdf/3.1/terms/Core/definitionSource</seealso>
    let definitionSource = Prefixed_Name(ns1, "definitionSource") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a detailed description of the Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/description">https://spdx.org/rdf/3.1/terms/Core/description</seealso>
    let description = Prefixed_Name(ns1, "description") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/devLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The product lifecycle phase, the requirement is applicable for."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/devLifecycleStage">https://spdx.org/rdf/3.1/terms/Core/devLifecycleStage</seealso>
    let devLifecycleStage = Prefixed_Name(ns1, "devLifecycleStage") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to one or more Elements that are part of an ElementCollection."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/element">https://spdx.org/rdf/3.1/terms/Core/element</seealso>
    let element = Prefixed_Name(ns1, "element") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/elementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value used in a key-value pair with a generic key that refers to an Element"</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/elementValue">https://spdx.org/rdf/3.1/terms/Core/elementValue</seealso>
    let elementValue = Prefixed_Name(ns1, "elementValue") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/endIntegerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the end of a range."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/endIntegerRange">https://spdx.org/rdf/3.1/terms/Core/endIntegerRange</seealso>
    let endIntegerRange = Prefixed_Name(ns1, "endIntegerRange") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the time from which an element is no longer applicable / valid."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/endTime">https://spdx.org/rdf/3.1/terms/Core/endTime</seealso>
    let endTime = Prefixed_Name(ns1, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies an Extension characterization of some aspect of an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/extension">https://spdx.org/rdf/3.1/terms/Core/extension</seealso>
    let extension = Prefixed_Name(ns1, "extension") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/externalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides a reference to a resource outside the scope of SPDX 3 content
    /// that uniquely identifies an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifier">https://spdx.org/rdf/3.1/terms/Core/externalIdentifier</seealso>
    let externalIdentifier = Prefixed_Name(ns1, "externalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/externalIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the type of the external identifier."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifierType">https://spdx.org/rdf/3.1/terms/Core/externalIdentifierType</seealso>
    let externalIdentifierType =
        Prefixed_Name(ns1, "externalIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/externalRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Points to a resource outside the scope of the SPDX 3 content
    /// that provides additional characteristics of an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalRef">https://spdx.org/rdf/3.1/terms/Core/externalRef</seealso>
    let externalRef = Prefixed_Name(ns1, "externalRef") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/externalRefType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the type of the external reference."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalRefType">https://spdx.org/rdf/3.1/terms/Core/externalRefType</seealso>
    let externalRefType = Prefixed_Name(ns1, "externalRefType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/externalSpdxId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies an external Element used within an SpdxDocument but defined
    /// external to that SpdxDocument."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalSpdxId">https://spdx.org/rdf/3.1/terms/Core/externalSpdxId</seealso>
    let externalSpdxId = Prefixed_Name(ns1, "externalSpdxId") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References the Element on the left-hand side of a relationship."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/from">https://spdx.org/rdf/3.1/terms/Core/from</seealso>
    let from = Prefixed_Name(ns1, "from") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/geographicPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This is a set of point coordinates as defined in by the GPS standard."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/geographicPointLocation">https://spdx.org/rdf/3.1/terms/Core/geographicPointLocation</seealso>
    let geographicPointLocation =
        Prefixed_Name(ns1, "geographicPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/hashValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The result of applying a hash algorithm to an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/hashValue">https://spdx.org/rdf/3.1/terms/Core/hashValue</seealso>
    let hashValue = Prefixed_Name(ns1, "hashValue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/headquartersLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The headquartersLocation defines the location of the organization's headquarters."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/headquartersLocation">https://spdx.org/rdf/3.1/terms/Core/headquartersLocation</seealso>
    let headquartersLocation =
        Prefixed_Name(ns1, "headquartersLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Uniquely identifies an external element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/identifier">https://spdx.org/rdf/3.1/terms/Core/identifier</seealso>
    let identifier = Prefixed_Name(ns1, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/identifierLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides the location for more information regarding an external identifier."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/identifierLocator">https://spdx.org/rdf/3.1/terms/Core/identifierLocator</seealso>
    let identifierLocator = Prefixed_Name(ns1, "identifierLocator") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/import</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides an ExternalMap of Element identifiers."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/import">https://spdx.org/rdf/3.1/terms/Core/import</seealso>
    let import = Prefixed_Name(ns1, "import") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/inLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies a human language used within the content of an Element or a property."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/inLanguage">https://spdx.org/rdf/3.1/terms/Core/inLanguage</seealso>
    let inLanguage = Prefixed_Name(ns1, "inLanguage") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/intendedUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The intendedUse property is designed to capture a summary of how or for what item or artifact is meant to be used for."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/intendedUse">https://spdx.org/rdf/3.1/terms/Core/intendedUse</seealso>
    let intendedUse = Prefixed_Name(ns1, "intendedUse") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/isoAutomationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ISO level of automation."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/isoAutomationLevel">https://spdx.org/rdf/3.1/terms/Core/isoAutomationLevel</seealso>
    let isoAutomationLevel = Prefixed_Name(ns1, "isoAutomationLevel") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/issuingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An entity that is authorized to issue identification credentials."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/issuingAuthority">https://spdx.org/rdf/3.1/terms/Core/issuingAuthority</seealso>
    let issuingAuthority = Prefixed_Name(ns1, "issuingAuthority") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A key used in a generic key-value pair."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/key">https://spdx.org/rdf/3.1/terms/Core/key</seealso>
    let key = Prefixed_Name(ns1, "key") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/locationHint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides an indication of where to retrieve an external Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/locationHint">https://spdx.org/rdf/3.1/terms/Core/locationHint</seealso>
    let locationHint = Prefixed_Name(ns1, "locationHint") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/locationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A known location is specified at this time."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/locationTime">https://spdx.org/rdf/3.1/terms/Core/locationTime</seealso>
    let locationTime = Prefixed_Name(ns1, "locationTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides the location of an external reference."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/locator">https://spdx.org/rdf/3.1/terms/Core/locator</seealso>
    let locator = Prefixed_Name(ns1, "locator") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the name of an Element as designated by the creator."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/name">https://spdx.org/rdf/3.1/terms/Core/name</seealso>
    let name = Prefixed_Name(ns1, "name") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides an unambiguous mechanism for conveying a URI fragment portion of an
    /// Element ID."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/namespace">https://spdx.org/rdf/3.1/terms/Core/namespace</seealso>
    let namespace_ = Prefixed_Name(ns1, "namespace") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/namespaceMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides a NamespaceMap of prefixes and associated namespace partial URIs applicable to an SpdxDocument and independent of any specific serialization format or instance."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/namespaceMap">https://spdx.org/rdf/3.1/terms/Core/namespaceMap</seealso>
    let namespaceMap = Prefixed_Name(ns1, "namespaceMap") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/originatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies from where or whom the Element originally came."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/originatedBy">https://spdx.org/rdf/3.1/terms/Core/originatedBy</seealso>
    let originatedBy = Prefixed_Name(ns1, "originatedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/packageVerificationCodeExcludedFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The relative file name of a file to be excluded from the
    /// `PackageVerificationCode`."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/packageVerificationCodeExcludedFile">https://spdx.org/rdf/3.1/terms/Core/packageVerificationCodeExcludedFile</seealso>
    let packageVerificationCodeExcludedFile =
        Prefixed_Name(ns1, "packageVerificationCodeExcludedFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/postOfficeBoxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number that identifies a PO box. A PO box is a box in a post office or other postal service location assigned to an organization where postal items may be kept."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/postOfficeBoxNumber">https://spdx.org/rdf/3.1/terms/Core/postOfficeBoxNumber</seealso>
    let postOfficeBoxNumber = Prefixed_Name(ns1, "postOfficeBoxNumber") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Text specifying the postal code for an address."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/postalCode">https://spdx.org/rdf/3.1/terms/Core/postalCode</seealso>
    let postalCode = Prefixed_Name(ns1, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/postalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of the recipient expressed in text."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/postalName">https://spdx.org/rdf/3.1/terms/Core/postalName</seealso>
    let postalName = Prefixed_Name(ns1, "postalName") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A substitute for a URI."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/prefix">https://spdx.org/rdf/3.1/terms/Core/prefix</seealso>
    let prefix = Prefixed_Name(ns1, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/processRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The reason a process exists."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/processRationale">https://spdx.org/rdf/3.1/terms/Core/processRationale</seealso>
    let processRationale = Prefixed_Name(ns1, "processRationale") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/processReadiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"processReadiness describes the readiness of a process."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/processReadiness">https://spdx.org/rdf/3.1/terms/Core/processReadiness</seealso>
    let processReadiness = Prefixed_Name(ns1, "processReadiness") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/processVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the version of a specific process."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/processVersion">https://spdx.org/rdf/3.1/terms/Core/processVersion</seealso>
    let processVersion = Prefixed_Name(ns1, "processVersion") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/profileConformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes one a profile which the creator of this ElementCollection intends to
    /// conform to."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/profileConformance">https://spdx.org/rdf/3.1/terms/Core/profileConformance</seealso>
    let profileConformance = Prefixed_Name(ns1, "profileConformance") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/provinceStateCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Text specifying a province or state."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/provinceStateCode">https://spdx.org/rdf/3.1/terms/Core/provinceStateCode</seealso>
    let provinceStateCode = Prefixed_Name(ns1, "provinceStateCode") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Quantity is the amount in the selected QUDT unit."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/quantity">https://spdx.org/rdf/3.1/terms/Core/quantity</seealso>
    let quantity = Prefixed_Name(ns1, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/relationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information about the relationship between two Elements."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/relationshipType">https://spdx.org/rdf/3.1/terms/Core/relationshipType</seealso>
    let relationshipType = Prefixed_Name(ns1, "relationshipType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/releaseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the time an artifact was released."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/releaseTime">https://spdx.org/rdf/3.1/terms/Core/releaseTime</seealso>
    let releaseTime = Prefixed_Name(ns1, "releaseTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/requirementRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Text used to define the rationale or additional information."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/requirementRationale">https://spdx.org/rdf/3.1/terms/Core/requirementRationale</seealso>
    let requirementRationale =
        Prefixed_Name(ns1, "requirementRationale") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/requirementStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A text describing the actual need defined by the requirement."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/requirementStatement">https://spdx.org/rdf/3.1/terms/Core/requirementStatement</seealso>
    let requirementStatement =
        Prefixed_Name(ns1, "requirementStatement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/requirementUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a universally unique Requirement ID."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/requirementUUID">https://spdx.org/rdf/3.1/terms/Core/requirementUUID</seealso>
    let requirementUUID = Prefixed_Name(ns1, "requirementUUID") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/rootElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to denote the root Element(s) of a tree of elements contained in a BOM."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/rootElement">https://spdx.org/rdf/3.1/terms/Core/rootElement</seealso>
    let rootElement = Prefixed_Name(ns1, "rootElement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Capture the scope of information about a specific relationship between elements."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/scope">https://spdx.org/rdf/3.1/terms/Core/scope</seealso>
    let scope = Prefixed_Name(ns1, "scope") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/specType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A specification type defines the nature of a specification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/specType">https://spdx.org/rdf/3.1/terms/Core/specType</seealso>
    let specType = Prefixed_Name(ns1, "specType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/specVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a reference number that can be used to understand how to parse and
    /// interpret an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/specVersion">https://spdx.org/rdf/3.1/terms/Core/specVersion</seealso>
    let specVersion = Prefixed_Name(ns1, "specVersion") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/standardName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a relevant standard that may apply to an artifact."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/standardName">https://spdx.org/rdf/3.1/terms/Core/standardName</seealso>
    let standardName = Prefixed_Name(ns1, "standardName") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the time from which an element is applicable / valid."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/startTime">https://spdx.org/rdf/3.1/terms/Core/startTime</seealso>
    let startTime = Prefixed_Name(ns1, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Commentary on an assertion that an annotator has made."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/statement">https://spdx.org/rdf/3.1/terms/Core/statement</seealso>
    let statement = Prefixed_Name(ns1, "statement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Street address includes a street number, name and unit ID to identify a specific street."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/streetAddress">https://spdx.org/rdf/3.1/terms/Core/streetAddress</seealso>
    let streetAddress = Prefixed_Name(ns1, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Element an annotator has made an assertion about."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/subject">https://spdx.org/rdf/3.1/terms/Core/subject</seealso>
    let subject = Prefixed_Name(ns1, "subject") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short description of an Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/summary">https://spdx.org/rdf/3.1/terms/Core/summary</seealso>
    let summary = Prefixed_Name(ns1, "summary") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/suppliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies who or what supplied the artifact or VulnAssessmentRelationship
    /// referenced by the Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/suppliedBy">https://spdx.org/rdf/3.1/terms/Core/suppliedBy</seealso>
    let suppliedBy = Prefixed_Name(ns1, "suppliedBy") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/supportLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the level of support associated with an artifact."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/supportLevel">https://spdx.org/rdf/3.1/terms/Core/supportLevel</seealso>
    let supportLevel = Prefixed_Name(ns1, "supportLevel") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References an Element on the right-hand side of a relationship."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/to">https://spdx.org/rdf/3.1/terms/Core/to</seealso>
    let to_ = Prefixed_Name(ns1, "to") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/typeFromSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"typeFromSource is a value used to define an item within the definitionSource."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/typeFromSource">https://spdx.org/rdf/3.1/terms/Core/typeFromSource</seealso>
    let typeFromSource = Prefixed_Name(ns1, "typeFromSource") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/unitQUDT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"QUDT unit is used for measurement criteria based on product type, region and use."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/unitQUDT">https://spdx.org/rdf/3.1/terms/Core/unitQUDT</seealso>
    let unitQUDT = Prefixed_Name(ns1, "unitQUDT") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/validUntilTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies until when the artifact can be used before its usage needs to be
    /// reassessed."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/validUntilTime">https://spdx.org/rdf/3.1/terms/Core/validUntilTime</seealso>
    let validUntilTime = Prefixed_Name(ns1, "validUntilTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value used in a generic key-value pair."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/value">https://spdx.org/rdf/3.1/terms/Core/value</seealso>
    let value = Prefixed_Name(ns1, "value") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/verifiedUsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides an IntegrityMethod with which the integrity of an Element can be
    /// asserted."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/verifiedUsing">https://spdx.org/rdf/3.1/terms/Core/verifiedUsing</seealso>
    let verifiedUsing = Prefixed_Name(ns1, "verifiedUsing") |> PrefixedName
