#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-doc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Documents/" "cmns-doc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : certificate^^xsd:string</para>
    ///   <para>skos:definition : document attesting to the truth of some fact or set of facts^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 5127 - Information and documentation - Foundation and vocabulary, Second edition, 2017-05, clause 3.1.1.38^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A certificate may or may not also be a legal document, depending on the issuing authority and how it can be used.^^xsd:stringcmns-av:explanatoryNote : Certificates, such as electronic certificates, including public keys, may be issued by some certificate authority.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/Certificate">cmns-doc:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    /// <summary>
    ///   <para>rdfs:label : document^^xsd:string</para>
    ///   <para>skos:definition : unitary expression of some realization of an intellectual or artistic work^^xsd:string</para>
    ///   <para>skos:note : See also ISO 25964–1:2011, definition 2.15; ISO 11005:2010, definition 3.1; ISO 15489–1:2016, definition 3.10; IEC 82045–1:2001, definition 3.2.3; ISO 9000:2015, definition 3.7.2^^xsd:stringskos:note : The definition of document provided herein roughly corresponds to the concept of an expression in FRBR. A document is a realization of something that typically takes the form of alpha-numeric, musical, or choreographic notation, sound, image, etc., or any combination of such forms. A manifestation of the document must be inscribed, encoded, engraved, recorded, or otherwise imprinted in some medium. The concept of a manifestation of an expression corresponds to the ISO 5127 notion of a document. Documents can differ extensively in form and characteristics.^^xsd:stringskos:note : The manifestation of a document (FRBR expression) refers not only to written and printed materials in paper or microform versions (for example, conventional books, journals, diagrams, maps), but also to non-printed media such as machine-readable and digitized records, Internet and intranet resources, films, sound recordings, buildings, sites, monuments, three-dimensional objects or realia [when used to carry some sort of engraving]; and to collections of such items or parts of such items. (Note taken from ISO 25964–1:2011, definition 2.15.) Also, software, since recorded, can be considered a document.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 'Functional Requirements for Bibliographic Records', Final Report, IFLA (International Federation of Library Associations and Institutions) Study Group on the Functional Requirements for Bibliographic Records, September 1997 - see https://repository.ifla.org/bitstream/123456789/811/2/ifla-functional-requirements-for-bibliographic-records-frbr.pdf^^xsd:stringcmns-av:adaptedFrom : ISO 5127 - Information and documentation - Foundation and vocabulary, Second edition, 2017-05, clause 3.1.1.38^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A document, especially a legal document, may serve to establish one or several facts, and can be relied upon as a proof thereof.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This definition of document corresponds to a subclass of expression in FRBR. The notion of being a unitary expression is the differentiator between an FRBR expression and document in this sense.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/Document">cmns-doc:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : document part^^xsd:string</para>
    ///   <para>skos:definition : structurally distinct subdivision of a document^^xsd:string</para>
    ///   <para>skos:note : Parts of documents are typically identified separately based on the function they serve in conveying, organizing, or supporting the content.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/DocumentPart">cmns-doc:DocumentPart</a>
    /// </summary>
    let DocumentPart = _prefixId.prefix "DocumentPart"
    /// <summary>
    ///   <para>rdfs:label : legal document^^xsd:string</para>
    ///   <para>skos:definition : document specifying the terms of, or provides evidence for, an agreement, attestation, certification, conditions, permissions, and/or decisions of legal persons, government entities, or courts of law, drawn up in accordance with certain rules that apply in the relevant jurisdiction(s)^^xsd:string</para>
    ///   <para>skos:example : Examples include some certificates, deeds, bonds, business documents (such as articles of incorporation, bylaws, partnership agreements), contracts, certain identity documents, wills, trusts, legislative acts, notarial acts, court writs or processes (such as related complaints and pleadings in the context of litigation as well as other documents relevant to some legal issue), and any law passed by a competent legislative body in municipal (domestic) or international law.^^xsd:string</para>
    ///   <para>skos:note : A legal document bears the original, official, or legal form of something, that can be fully attributed to its author(s), that records and formally expresses a legally enforceable act, process, or contractual duty, obligation, or right and that can be used to furnish decisive evidence for that act, process, or agreement.^^xsd:stringskos:note : Many legal documents only become 'legal' once they are signed and dated, and possibly notarized.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 5127 - Information and documentation - Foundation and vocabulary, Second edition, 2017-05, clause 3.4.6.02^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/LegalDocument">cmns-doc:LegalDocument</a>
    /// </summary>
    let LegalDocument = _prefixId.prefix "LegalDocument"
    /// <summary>
    ///   <para>rdfs:label : notice^^xsd:string</para>
    ///   <para>skos:definition : announcement, communication, intimation, or advance warning of something, usually, but not necessarily, to allow preparations to be made^^xsd:string</para>
    ///   <para>skos:example : registered trademark notice, disclaimer, copyright notice, overdue notice, recall notice^^xsd:string</para>
    ///   <para>skos:note : Although many notices are delivered electronically, certain legal notices must be given given in writing, often by regular mail or hand delivery, with the sender retaining sufficient proof of having given such notice (e.g., through a certificate of service).^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 5127 - Information and documentation - Foundation and vocabulary, Second edition, 2017-05^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/Notice">cmns-doc:Notice</a>
    /// </summary>
    let Notice = _prefixId.prefix "Notice"
    /// <summary>
    ///   <para>rdfs:label : record^^xsd:string</para>
    ///   <para>skos:definition : memorialization and objective evidence of activities performed, events occurred, results achieved, or statements made, regardless of its characteristics, media, physical form, or the manner in which it is recorded or stored^^xsd:string</para>
    ///   <para>skos:note : Records are created or received by an organization in routine transaction of its business or in pursuance of its legal obligations.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/Record">cmns-doc:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    /// <summary>
    ///   <para>rdfs:label : reference^^xsd:string</para>
    ///   <para>skos:definition : source that may be used to ascertain, interpret, or understand something^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In linguistics, a reference characterizes, provides context for, or specifies the relationship of one linguistic expression to another, i.e., provides the information necessary to interpret the dependent expression.^^xsd:stringcmns-av:explanatoryNote : References may be rendered in the form of a document, but may also take other forms, such as reference materials, scientific equations, and constants, including in some cases physical things, used as the basis for units of measure.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/Reference">cmns-doc:Reference</a>
    /// </summary>
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:label : reference document^^xsd:string</para>
    ///   <para>skos:definition : document that is used as a reference for something^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A reference document is typically one that provides pertinent details for consultation about a subject.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/ReferenceDocument">cmns-doc:ReferenceDocument</a>
    /// </summary>
    let ReferenceDocument = _prefixId.prefix "ReferenceDocument"
    /// <summary>
    ///   <para>rdfs:label : specification^^xsd:string</para>
    ///   <para>skos:definition : explicit requirement or set of requirements to be satisfied by something, such as a product, material, model, process or system^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : spec</para>
    ///   <para>cmns-av:adaptedFrom : ISO 6707-2:2017 Buildings and civil engineering works - Vocabulary - Part 2: Contract and communication terms, clause 3.2.22^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/Specification">cmns-doc:Specification</a>
    /// </summary>
    let Specification = _prefixId.prefix "Specification"

    /// <summary>
    ///   <para>rdfs:label : technical specification document^^xsd:string</para>
    ///   <para>skos:definition : document that sets out detailed requirements to be satisfied by a product, material, process or system and the procedures for checking conformity to these requirements^^xsd:string</para>
    ///   <para>skos:note : Technical specifications may evolve from a functional specification and define the technical requirements for the selected solution as part of a business agreement.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10795:2019 Space systems - Programme management and quality - Vocabulary, clause 3.238^^xsd:stringcmns-av:adaptedFrom : ISO 6707-2:2017 Buildings and civil engineering works - Vocabulary - Part 2: Contract and communication terms, clause 3.2.22^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A technical specification is a specification expressing technical requirements, such as one for designing and developing a solution to be implemented.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/TechnicalSpecificationDocument">cmns-doc:TechnicalSpecificationDocument</a>
    /// </summary>
    let TechnicalSpecificationDocument =
        _prefixId.prefix "TechnicalSpecificationDocument"

    /// <summary>
    ///   <para>rdfs:label : has data source^^xsd:string</para>
    ///   <para>skos:definition : relates something, such as an agreement, contract, document, record, report, or process, to a source of data used to analyze, develop, explain, produce, or otherwise create it^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Although in many cases an annotation property, such as dct:source, is sufficient for this purpose, there are occasions when a more complete description of a source is required, such as to meet data lineage requirements, for which this property may be used.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/hasDataSource">cmns-doc:hasDataSource</a>
    /// </summary>
    let hasDataSource = _prefixId.prefix "hasDataSource"
    /// <summary>
    ///   <para>rdfs:label : is about^^xsd:string</para>
    ///   <para>skos:definition : indicates the subject or topic of something, such as a document^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/isAbout">cmns-doc:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : is referred to by^^xsd:string</para>
    ///   <para>skos:definition : indicates something that is referenced as a source for information or explanation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/isReferredToBy">cmns-doc:isReferredToBy</a>
    /// </summary>
    let isReferredToBy = _prefixId.prefix "isReferredToBy"
    /// <summary>
    ///   <para>rdfs:label : is specified in^^xsd:string</para>
    ///   <para>skos:definition : indicates the explicit source for some requirement, fact, or set of facts^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/isSpecifiedIn">cmns-doc:isSpecifiedIn</a>
    /// </summary>
    let isSpecifiedIn = _prefixId.prefix "isSpecifiedIn"
    /// <summary>
    ///   <para>rdfs:label : records^^xsd:string</para>
    ///   <para>skos:definition : documents for later reference^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/records">cmns-doc:records</a>
    /// </summary>
    let records = _prefixId.prefix "records"
    /// <summary>
    ///   <para>rdfs:label : refers to^^xsd:string</para>
    ///   <para>skos:definition : makes reference to as a source for information or explanation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/refersTo">cmns-doc:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:label : specifies^^xsd:string</para>
    ///   <para>skos:definition : mentions, names or states something clearly and definitively^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Specifies may be used to refer to a requirement, fact, or set of facts.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Documents/specifies">cmns-doc:specifies</a>
    /// </summary>
    let specifies = _prefixId.prefix "specifies"
