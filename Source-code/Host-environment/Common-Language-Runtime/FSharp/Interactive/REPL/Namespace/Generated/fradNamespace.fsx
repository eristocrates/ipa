#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module frad =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://iflastandards.info/ns/fr/frad/" "frad"

    let _namespaceIri = _prefixId.prefix ""
    let _1003 = _prefixId.prefix "1003"
    /// <summary>
    ///   <para>skos:scopeNote : Includes access points designated as authorized (or preferred) forms of names (i.e., authorized access points) as well as those designated as variant forms of name (i.e., variant access points). Includes access points based on personal, family, and corporate names. Includes access points based on titles (i.e., names) for works, expressions, manifestations, and items. Includes access points consisting of a combination of two access points, as in the case of a creator/title access point for a work which consists of an authorized access point for the name of the creator combined with an authorized access point for the name (i.e., the title) of the work. Includes access points based on names and terms for events, objects, concepts, and places. Includes access points based on identifiers, such as standard numbers, classification indicia. Elements added to the name per se (e.g., dates) form an integral part of the controlled access point.</para>
    ///   <para>skos:definition : A name, term, code, etc., under which a bibliographic or authority record or reference will be found.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ControlledAccessPoint</para>
    ///   <para>rdfs:label : Controlled Access Point</para>
    ///   <para>rdfs:comment : Description is modified from: Guidelines for authority records and references / revised by the Working Group on GARE Revision. Second edition.  München : K.G. Saur, 2001.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1001">frad:C1001</a>
    /// </summary>
    let C1001 = _prefixId.prefix "C1001"
    /// <summary>
    ///   <para>skos:scopeNote : Includes royal families, dynasties, houses of nobility, etc. Includes patriarchies and matriarchies. Includes groups of individuals sharing a common ancestral lineage. Includes family units (parents, children, grandchildren, etc.). Includes the successive holders of a title in a house of nobility, viewed collectively (e.g., Dukes of Norfolk).
    /// </para>
    ///   <para>skos:definition : Two or more persons related by birth, marriage, adoption, civil union, or similar legal status, or who otherwise present themselves as a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Family</para>
    ///   <para>rdfs:label : Familyrdfs:label : Familia</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1002">frad:C1002</a>
    /// </summary>
    let C1002 = _prefixId.prefix "C1002"
    /// <summary>
    ///   <para>skos:scopeNote : Includes occasional groups and groups that are constituted as meetings, conferences, congresses, expeditions, exhibitions, festivals, fairs, etc. Includes musical performing groups, groups of visual artists, and dance companies producing collective work. Includes organizations that act as territorial authorities, exercising or claiming to exercise government functions over a certain territory, such as a federation, a state, a region, a local municipality. Includes organizations and groups that are defunct as well as those that continue to operate. Includes fictitious organizations or groups of persons.
    /// </para>
    ///   <para>skos:definition : An organization or group of persons and/or organizations identified by a particular name acting as a unit.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : CorporateBody</para>
    ///   <para>rdfs:label : Corporate Body</para>
    ///   <para>rdfs:comment : Description is modified from that in Functional requirements for bibliographic records : final report, by the IFLA Study Group on the Functional Requirements for Bibliographic Records, published by K.G. Saur, 1998.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1003">frad:C1003</a>
    /// </summary>
    let C1003 = _prefixId.prefix "C1003"
    /// <summary>
    ///   <para>skos:scopeNote : Includes names by which persons, families, and corporate bodies are known. Includes titles by which works, expressions, and manifestations are known. Includes names and terms by which concepts, objects, events, and places are known. Includes real names, pseudonyms, religious names, initials, and separate letters, numerals, or symbols. Includes forenames (or given names), matronymics, patronymics, family names (or surnames), dynastic names, etc. Includes given names of sovereigns, popes, etc., with associated roman numerals. Includes names of families, clans, dynasties, houses of nobility, etc. Includes names representing the successive holders of a title in houses of nobility, etc., viewed collectively (e.g., Dukes of Norfolk). Includes names used by a corporate body at various periods in its history. Includes names of associations, institutions, business firms, not-for-profit enterprises, etc. Includes names of governments, government agencies, projects, programmes, government officials, delegations, legislative bodies, armed forces, etc. Includes names of religious bodies, local churches, etc., religious councils, religious officials, provinces, dioceses, synods, etc., papal diplomatic missions, etc. Includes names of conferences, congresses, meetings, etc. Includes names of exhibitions, athletic contests, expeditions, fairs, festivals, etc. Includes names of subordinate and related bodies. Includes numbers that form an integral part of the name of a corporate body or event. Includes trade names. Includes titles of content, parts of content, compilations of content, etc. Includes titles by which a work has become known. Includes the title proper of the original manifestation of a work. Includes titles by which a work is identified in reference sources. Includes titles under which a work has been published. Includes titles by which manifestations of an expression have become known. Includes the title proper of the original manifestation of an expression. Includes titles by which manifestations of an expression are identified in reference sources. Includes titles under which manifestations of an expression have been published. Includes the title proper of the original edition of a manifestation. Includes titles by which a manifestation is identified in reference sources. Includes variant titles appearing on or in a manifestation. Includes names and terms for events, objects, concepts, and places.</para>
    ///   <para>skos:definition : A character, word, or group of words and/or characters by which an entity is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Name</para>
    ///   <para>rdfs:label : Namerdfs:label : Nombre</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1006">frad:C1006</a>
    /// </summary>
    let C1006 = _prefixId.prefix "C1006"
    /// <summary>
    ///   <para>skos:scopeNote : Includes cataloguing rules and interpretations of those rules. Includes coding conventions.</para>
    ///   <para>skos:definition : A set of instructions relating to the formulation and/or recording of controlled access points (authorized forms, variant forms or references, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Rules</para>
    ///   <para>rdfs:label : Rulesrdfs:label : Reglas</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1007">frad:C1007</a>
    /// </summary>
    let C1007 = _prefixId.prefix "C1007"
    /// <summary>
    ///   <para>skos:scopeNote : Includes libraries, national bibliographic agencies, bibliographic utilities, consortia, museums, archives, rights management organizations, etc.</para>
    ///   <para>skos:definition : An organization responsible for creating or modifying a controlled access point. The agency is responsible for application and interpretation of the rules it creates and/or uses. The agency may also be responsible for the creation and maintenance of identifiers within its domain.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Agency</para>
    ///   <para>rdfs:label : Agencyrdfs:label : Agencia</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1008">frad:C1008</a>
    /// </summary>
    let C1008 = _prefixId.prefix "C1008"
    /// <summary>
    ///   <para>skos:scopeNote : Includes identifiers such as social insurance numbers assigned by a government authority. Includes personal identifiers assigned by other registration authorities. Includes business registration numbers, registration numbers for charitable organizations, etc., assigned by a government authority. Includes corporate body identifiers assigned by other registration authorities (e.g., ISBN publisher’s prefix).
    /// Includes standard identifiers assigned by registration authorities identifying content (e.g., ISRC, ISWC, ISAN). Includes standard identifiers assigned by registration authorities identifying manifestations (e.g., ISBN, ISSN). Includes thematic index numbers assigned to a musical work by the publisher, or a musicologist. Includes catalogue raisonné numbers. Includes identifiers for items assigned by repositories (e.g., shelf number). Includes classification numbers referencing specific entities (e.g., a classification number assigned to a particular painting). Includes registered trademarks.</para>
    ///   <para>skos:definition : A number, code, word, phrase, logo, device, etc., that is associated with an entity, and serves to differentiate that entity from other entities within the domain in which the identifier is assigned. An identifier can consist of an identifier string (i.e., a sequence of numeric and/or alphabetic characters assigned to an entity to serve as a unique identifier within the domain to which the identifier is assigned) and a prefix and/or suffix (a character or set of characters (numeric and/or alphabetic) appearing before or after an identifier string).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Identifier</para>
    ///   <para>rdfs:label : Identifierrdfs:label : Identificador</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1009">frad:C1009</a>
    /// </summary>
    let C1009 = _prefixId.prefix "C1009"
    /// <summary>
    ///   <para>skos:scopeNote : What is perceived as a specific instance of a particular entity type may vary from one set of rules to another.</para>
    ///   <para>skos:definition : An entity which reflects intellectual constructs or concepts that are integral to the rules used to create library catalogues.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : BibliographicEntity</para>
    ///   <para>rdfs:label : Bibliographic Entity</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1010">frad:C1010</a>
    /// </summary>
    let C1010 = _prefixId.prefix "C1010"
    /// <summary>
    ///   <para>skos:definition : A name which is the appellation of a corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : NameOfACorporateBody</para>
    ///   <para>rdfs:label : Name of a Corporate Body</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1011">frad:C1011</a>
    /// </summary>
    let C1011 = _prefixId.prefix "C1011"
    /// <summary>
    ///   <para>skos:definition : A name which is the appellation of a person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : NameOfAPerson</para>
    ///   <para>rdfs:label : Name of a Person</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1012">frad:C1012</a>
    /// </summary>
    let C1012 = _prefixId.prefix "C1012"
    /// <summary>
    ///   <para>skos:definition : A name which is the appellation of a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : NameOfAFamily</para>
    ///   <para>rdfs:label : Name of a Family</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1013">frad:C1013</a>
    /// </summary>
    let C1013 = _prefixId.prefix "C1013"
    /// <summary>
    ///   <para>skos:definition : A name which is the appellation of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : NameOfAWork</para>
    ///   <para>rdfs:label : Name of a Work</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/C1014">frad:C1014</a>
    /// </summary>
    let C1014 = _prefixId.prefix "C1014"
    /// <summary>
    ///   <para>skos:definition : Relates rules to an agency that applies them when creating or modifying a controlled access point.</para>
    ///   <para>rdfs:label : son aplicadas porrdfs:label : are applied by</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : areAppliedBy</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2001">frad:P2001</a>
    /// </summary>
    let P2001 = _prefixId.prefix "P2001"
    /// <summary>
    ///   <para>skos:definition : Relates an agency to rules that it applies when creating or modifying a controlled access point.</para>
    ///   <para>rdfs:label : appliesrdfs:label : aplica</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : applies</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2002">frad:P2002</a>
    /// </summary>
    let P2002 = _prefixId.prefix "P2002"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to the rules that govern it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isGovernedBy</para>
    ///   <para>rdfs:label : is governed byrdfs:label : es regulado por</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2003">frad:P2003</a>
    /// </summary>
    let P2003 = _prefixId.prefix "P2003"
    /// <summary>
    ///   <para>rdfs:label : governrdfs:label : regula</para>
    ///   <para>skos:definition : Relates rules to a controlled access point that they govern.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : govern</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2004">frad:P2004</a>
    /// </summary>
    let P2004 = _prefixId.prefix "P2004"
    /// <summary>
    ///   <para>rdfs:label : es creado porrdfs:label : is created by</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isCreatedBy</para>
    ///   <para>skos:definition : Relates a controlled access point to the agency that creates it.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2005">frad:P2005</a>
    /// </summary>
    let P2005 = _prefixId.prefix "P2005"
    /// <summary>
    ///   <para>skos:definition : Relates an agency to a controlled access point that is created by the agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : creates</para>
    ///   <para>rdfs:label : createsrdfs:label : crea</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2006">frad:P2006</a>
    /// </summary>
    let P2006 = _prefixId.prefix "P2006"
    /// <summary>
    ///   <para>rdfs:label : es modificado porrdfs:label : is modified by</para>
    ///   <para>skos:definition : Relates a controlled access point to the agency that modifies it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isModifiedBy</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2007">frad:P2007</a>
    /// </summary>
    let P2007 = _prefixId.prefix "P2007"
    /// <summary>
    ///   <para>skos:definition : Relates an agency to a controlled access point that is modified by the agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : modifies</para>
    ///   <para>rdfs:label : modifiesrdfs:label : modifica</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2008">frad:P2008</a>
    /// </summary>
    let P2008 = _prefixId.prefix "P2008"
    /// <summary>
    ///   <para>skos:definition : Relates a name to a controlled access point for which it is the basis.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isBasisNameFor</para>
    ///   <para>rdfs:label : is basis (name) for</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2009">frad:P2009</a>
    /// </summary>
    let P2009 = _prefixId.prefix "P2009"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to a name on which it is based.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isBasedOnName</para>
    ///   <para>rdfs:label : is based on (name)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2010">frad:P2010</a>
    /// </summary>
    let P2010 = _prefixId.prefix "P2010"
    /// <summary>
    ///   <para>rdfs:label : is basis (identifier) for</para>
    ///   <para>skos:definition : Relates an identifier to a controlled access point for which it is the basis.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isBasisIdentifierFor</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2011">frad:P2011</a>
    /// </summary>
    let P2011 = _prefixId.prefix "P2011"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to an identifier on which it is based. </para>
    ///   <para>rdfs:label : is based on (identifier)rdfs:label : está basado en (identificador)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isBasedOnIdentifier</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2012">frad:P2012</a>
    /// </summary>
    let P2012 = _prefixId.prefix "P2012"
    /// <summary>
    ///   <para>skos:definition : Relates a bibliographic entity to a name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAppellation</para>
    ///   <para>rdfs:label : has appellation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2013">frad:P2013</a>
    /// </summary>
    let P2013 = _prefixId.prefix "P2013"
    /// <summary>
    ///   <para>skos:definition : Relates a name to a bibliographic entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAppellationOf</para>
    ///   <para>rdfs:label : is appellation of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2014">frad:P2014</a>
    /// </summary>
    let P2014 = _prefixId.prefix "P2014"
    /// <summary>
    ///   <para>skos:definition : Relates a bibliographic entity to an identifier assigned to the entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAssigned</para>
    ///   <para>rdfs:label : is assigned</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2015">frad:P2015</a>
    /// </summary>
    let P2015 = _prefixId.prefix "P2015"
    /// <summary>
    ///   <para>skos:definition : Relates an identifier to a bibliographic entity to which it is assigned.</para>
    ///   <para>rdfs:label : is assigned to</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAssignedTo</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2016">frad:P2016</a>
    /// </summary>
    let P2016 = _prefixId.prefix "P2016"
    /// <summary>
    ///   <para>skos:definition : Relates a work to another work which is an adaptation or modification of the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDerivative</para>
    ///   <para>rdfs:label : tiene derivadardfs:label : has derivative</para>
    ///   <para>skos:scopeNote : Includes relationships between an original work and a broad range of modifications from the original, including variations or versions of that work, such as editions, revisions, translations, summaries, abstracts, and digests. Includes new works that are adaptations or modifications that become new works but are based on an earlier work (improvisations, etc.); new works that are changes of genre (transformations, dramatizations, novelizations, etc.); and, new works based on the style or thematic content of other works (free translations, paraphrases, imitations, parodies, etc.).</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2017">frad:P2017</a>
    /// </summary>
    let P2017 = _prefixId.prefix "P2017"
    /// <summary>
    ///   <para>skos:definition : Relates a work to another work of which it is an adaptation or modification.</para>
    ///   <para>skos:scopeNote : Includes relationships between an original work and a broad range of modifications from the original, including variations or versions of that work, such as editions, revisions, translations, summaries, abstracts, and digests. Includes new works that are adaptations or modifications that become new works but are based on an earlier work (improvisations, etc.); new works that are changes of genre (transformations, dramatizations, novelizations, etc.); and, new works based on the style or thematic content of other works (free translations, paraphrases, imitations, parodies, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isDerivativeOf</para>
    ///   <para>rdfs:label : is derivative ofrdfs:label : es derivativa de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2018">frad:P2018</a>
    /// </summary>
    let P2018 = _prefixId.prefix "P2018"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to another manifestation that embodies the same intellectual or artistic content (work or work-expression).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEquivalenceManifestationRelationship</para>
    ///   <para>rdfs:label : has equivalence (manifestation) relationship</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2019">frad:P2019</a>
    /// </summary>
    let P2019 = _prefixId.prefix "P2019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isCreatedByFamily</para>
    ///   <para>rdfs:label : es creada por (familia)rdfs:label : is created by (family)</para>
    ///   <para>skos:definition : Relates a work to a family which is responsible for the creation of the intellectual or artistic content of the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2020">frad:P2020</a>
    /// </summary>
    let P2020 = _prefixId.prefix "P2020"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a work of which it is responsible for the creation of the intellectual or artistic content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isCreatorFamilyOf</para>
    ///   <para>rdfs:label : is creator (family) ofrdfs:label : es creadora (familia) de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2021">frad:P2021</a>
    /// </summary>
    let P2021 = _prefixId.prefix "P2021"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a family that is the owner or custodian of the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOwnedByFamily</para>
    ///   <para>rdfs:label : is owned by (family)rdfs:label : es poseida por (familia)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2022">frad:P2022</a>
    /// </summary>
    let P2022 = _prefixId.prefix "P2022"
    /// <summary>
    ///   <para>skos:definition : Relates a family to an item of which it is the owner or custodian.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOwnerFamilyOf</para>
    ///   <para>rdfs:label : is owner (family) ofrdfs:label : es propietaria (familia) de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2023">frad:P2023</a>
    /// </summary>
    let P2023 = _prefixId.prefix "P2023"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a family that is responsible for publishing, distributing, fabricating or manufacturing the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isProducedByFamily</para>
    ///   <para>rdfs:label : is produced by (family)rdfs:label : es producida por (familia)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2024">frad:P2024</a>
    /// </summary>
    let P2024 = _prefixId.prefix "P2024"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a manifestation of which it is responsible for publishing, distributing, fabricating or manufacturing.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isProducerFamilyOf</para>
    ///   <para>rdfs:label : is producer (family) ofrdfs:label : es productora (familia) de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2025">frad:P2025</a>
    /// </summary>
    let P2025 = _prefixId.prefix "P2025"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a family that is responsible for the specifics of the intellectual or artistic realization or execution of the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizedByFamily</para>
    ///   <para>rdfs:label : is realized by (family)rdfs:label : es realizada por (familia)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2026">frad:P2026</a>
    /// </summary>
    let P2026 = _prefixId.prefix "P2026"
    /// <summary>
    ///   <para>skos:definition : Relates a family to an expression of which it is responsible for the specifics of the intellectual or artistic realization or execution.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizerFamilyOf</para>
    ///   <para>rdfs:label : is realizer (family) ofrdfs:label : es realizadora (familia) de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2027">frad:P2027</a>
    /// </summary>
    let P2027 = _prefixId.prefix "P2027"
    /// <summary>
    ///   <para>skos:definition : Relates a person, a family, or a corporate body to a work, expression, manifestation, or item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAssociatedWith</para>
    ///   <para>rdfs:label : is associated with</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2028">frad:P2028</a>
    /// </summary>
    let P2028 = _prefixId.prefix "P2028"
    /// <summary>
    ///   <para>skos:scopeNote : E.g. a sequel, a serial or series that has changed title. Excludes derivative works that modify the content of an earlier work.</para>
    ///   <para>skos:definition : Relates a work to another work of different content that is a successor or a predecessor of that work,</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSequentialRelationship</para>
    ///   <para>rdfs:label : has sequential relationship</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2029">frad:P2029</a>
    /// </summary>
    let P2029 = _prefixId.prefix "P2029"
    /// <summary>
    ///   <para>skos:definition : Relates a work to another work that is a supplement to that work (i.e., a work that is intended to be used in conjunction with or to augment the related work, such as a teacher’s guide or incidental music to a play; or intended to complement or be a companion to another work, such as a set of maps to a video travelogue, a computer disk to accompany a textbook, a set of coloured plates to accompany a text, the equal parts of a kit).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAccompanyingRelationship</para>
    ///   <para>rdfs:label : has accompanying relationship</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2030">frad:P2030</a>
    /// </summary>
    let P2030 = _prefixId.prefix "P2030"
    /// <summary>
    ///   <para>rdfs:label : has shared characteristic (work) relationshiprdfs:label : tiene relación de característica compartida (obra)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSharedCharacteristicWorkRelationship</para>
    ///   <para>skos:scopeNote : Excludes specific characteristics represented by other properties.</para>
    ///   <para>skos:definition : Relates two works that have some characteristic in common.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2031">frad:P2031</a>
    /// </summary>
    let P2031 = _prefixId.prefix "P2031"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSharedCharacteristicExpressionRelationship</para>
    ///   <para>rdfs:label : tiene relación de característica compartida (expresión)rdfs:label : has shared characteristic (expression) relationship</para>
    ///   <para>skos:scopeNote : Excludes specific characteristics represented by other properties.</para>
    ///   <para>skos:definition : Relates two expressions that have some characteristic in common. </para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2032">frad:P2032</a>
    /// </summary>
    let P2032 = _prefixId.prefix "P2032"
    /// <summary>
    ///   <para>skos:scopeNote : Excludes specific characteristics represented by other properties. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSharedCharacteristicManifestationRelationship</para>
    ///   <para>rdfs:label : tiene relación de característica compartida (manifestación)rdfs:label : has shared characteristic (manifestation) relationship</para>
    ///   <para>skos:definition : Relates two manifestations that have some characteristic in common.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2033">frad:P2033</a>
    /// </summary>
    let P2033 = _prefixId.prefix "P2033"
    /// <summary>
    ///   <para>rdfs:label : has shared characteristic (item) relationshiprdfs:label : tiene relación de característica compartida (ejemplar)</para>
    ///   <para>skos:scopeNote : Excludes specific characteristics represented by other properties.</para>
    ///   <para>skos:definition : Relates two items that have some characteristic in common.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSharedCharacteristicItemRelationship </para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2034">frad:P2034</a>
    /// </summary>
    let P2034 = _prefixId.prefix "P2034"
    /// <summary>
    ///   <para>skos:scopeNote : Includes criticism, commentary, review, casebook, etc., and the object of that analysis (that is, the target work, expression, or manifestation).</para>
    ///   <para>skos:definition : Relates a target work or expression or manifestation or item and a new work that refers to that target as its subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDescriptiveWork</para>
    ///   <para>rdfs:label : has descriptive workrdfs:label : tiene obra descriptiva</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2035">frad:P2035</a>
    /// </summary>
    let P2035 = _prefixId.prefix "P2035"
    /// <summary>
    ///   <para>skos:scopeNote : Includes criticism, commentary, review, casebook, etc., and the object of that analysis (that is, the target work, expression, or manifestation). </para>
    ///   <para>skos:definition : Relates a new work to a target work or expression or manifestation or item that it refers to as its subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isDescriptiveWorkOf</para>
    ///   <para>rdfs:label : is descriptive work of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2036">frad:P2036</a>
    /// </summary>
    let P2036 = _prefixId.prefix "P2036"
    /// <summary>
    ///   <para>skos:definition : Relates an item to another item that exemplifies the same intellectual or artistic content (work or work-expression).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEquivalenceItemRelationship</para>
    ///   <para>rdfs:label : has equivalence (item) relationship</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P2037">frad:P2037</a>
    /// </summary>
    let P2037 = _prefixId.prefix "P2037"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a categorization or generic descriptor for the type of family.</para>
    ///   <para>skos:scopeNote : Includes categorizations, such as clan, dynasty, family unit, patriarchy, matriarchy, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTypeOfFamily</para>
    ///   <para>rdfs:label : has type of family</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3001">frad:P3001</a>
    /// </summary>
    let P3001 = _prefixId.prefix "P3001"
    /// <summary>
    ///   <para>rdfs:label : has dates of family</para>
    ///   <para>skos:definition : Relates a family to dates associated with the family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDatesOfFamily</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3002">frad:P3002</a>
    /// </summary>
    let P3002 = _prefixId.prefix "P3002"
    /// <summary>
    ///   <para>rdfs:label : has places associated with family</para>
    ///   <para>skos:definition : Relates a family to information pertaining to places where the family resides or resided or had some connection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlacesAssociatedWithFamily</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3003">frad:P3003</a>
    /// </summary>
    let P3003 = _prefixId.prefix "P3003"
    /// <summary>
    ///   <para>skos:definition : Relates a family to afield of endeavour, area of expertise, etc., in which the family is engaged or was engaged.</para>
    ///   <para>rdfs:label : has field of activity (family)rdfs:label : tiene campo de actividad (familia)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFieldOfActivityFamily</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3004">frad:P3004</a>
    /// </summary>
    let P3004 = _prefixId.prefix "P3004"
    /// <summary>
    ///   <para>rdfs:label : has history of family</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasHistoryOfFamily</para>
    ///   <para>skos:definition : Relates a family to information pertaining to the history of the family.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3005">frad:P3005</a>
    /// </summary>
    let P3005 = _prefixId.prefix "P3005"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTypeOfControlledAccessPoint</para>
    ///   <para>skos:scopeNote : Includes terms and/or codes designating the type of access point (e.g., personal name access point, family name access point, corporate name access point, meeting name access point, territorial name access point, title access point, collective title access point or access points consisting of a combination of names, such as creator/title access points).</para>
    ///   <para>skos:definition : Relates a controlled access point to a categorization or generic descriptor for the controlled access point.</para>
    ///   <para>rdfs:label : has type of controlled access point</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3006">frad:P3006</a>
    /// </summary>
    let P3006 = _prefixId.prefix "P3006"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to an indication of the level of establishment of the authorized access point for the entity (e.g., provisional).</para>
    ///   <para>rdfs:label : has status of controlled access point</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatusOfControlledAccessPoint</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3007">frad:P3007</a>
    /// </summary>
    let P3007 = _prefixId.prefix "P3007"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to an indication of whether the rules under which the controlled access point was constructed designate it as an authorized (or preferred) form (i.e., authorized access point) or as a variant (or non-preferred) form (i.e., variant access points).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDesignatedUsageOfControlledAccessPoint</para>
    ///   <para>rdfs:label : has designated usage of controlled access point</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3008">frad:P3008</a>
    /// </summary>
    let P3008 = _prefixId.prefix "P3008"
    /// <summary>
    ///   <para>rdfs:label : tiene punto de acceso no diferenciadordfs:label : has undifferentiated access point </para>
    ///   <para>skos:definition : Relates a controlled access point to an indication that the controlled access point for the authorized form of name (i.e., authorized access point) is insufficiently precise to differentiate between two or more entities identified by the same name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasUndifferentiatedAccessPoint </para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3009">frad:P3009</a>
    /// </summary>
    let P3009 = _prefixId.prefix "P3009"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to the language in which the base access point is recorded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLanguageOfBaseAccessPoint</para>
    ///   <para>rdfs:label : has language of base access point</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3010">frad:P3010</a>
    /// </summary>
    let P3010 = _prefixId.prefix "P3010"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to the language in which additions to the base access point are recorded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLanguageOfCataloguing</para>
    ///   <para>rdfs:label : has language of cataloguingrdfs:label : tiene lengua de catalogación</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3011">frad:P3011</a>
    /// </summary>
    let P3011 = _prefixId.prefix "P3011"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to the form of graphic characters in which the data in the base access point are recorded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasScriptOfBaseAccessPoint</para>
    ///   <para>rdfs:label : has script of base access point</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3012">frad:P3012</a>
    /// </summary>
    let P3012 = _prefixId.prefix "P3012"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to the form of graphic characters in which any additions to the base access point are recorded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasScriptOfCataloguing</para>
    ///   <para>rdfs:label : has script of cataloguing</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3013">frad:P3013</a>
    /// </summary>
    let P3013 = _prefixId.prefix "P3013"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to an indication of the scheme used in transliterating the base access point.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTransliterationSchemeOfBaseAccessPoint</para>
    ///   <para>rdfs:label : has transliteration scheme of base access point</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3014">frad:P3014</a>
    /// </summary>
    let P3014 = _prefixId.prefix "P3014"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to an indication of the scheme used in transliterating any additions to the base access point.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTransliterationSchemeOfCataloguing</para>
    ///   <para>rdfs:label : has transliteration scheme of cataloguing</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3015">frad:P3015</a>
    /// </summary>
    let P3015 = _prefixId.prefix "P3015"
    /// <summary>
    ///   <para>skos:scopeNote : Includes the title, publisher, date, etc., of the resource for which the controlled access point was originally created. Includes the title, edition, etc., of the reference source(s) used to establish the conventional name or title.</para>
    ///   <para>skos:definition : Relates a controlled access point to the publication or reference source used in establishing the form of name or title on which the controlled access point is based.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSourceOfControlledAccessPoint</para>
    ///   <para>rdfs:label : has source of controlled access point</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3016">frad:P3016</a>
    /// </summary>
    let P3016 = _prefixId.prefix "P3016"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point to all elements in a controlled access point that are integral to the name or identifier that forms the basis for the access point.</para>
    ///   <para>rdfs:label : has base access point</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasBaseAccessPoint</para>
    ///   <para>skos:scopeNote : Includes the name element in a controlled access point beginning with the name of a person, family, or corporate body. Includes the phrase element in a controlled access point beginning with a phrase associated with a person that is used in lieu of a name as such when the name of the person is unknown (e.g., A Physician, Author of Early Impressions). Includes the name element for a subordinate or related body in a controlled access point beginning with the name of a superior body. Includes the name element for a government agency, official, legislative body, court, etc., in a controlled access point beginning with the name for the territorial authority. Includes the name element for a religious council, official, province, synod, etc., in a controlled access point beginning with the name for the religious body. Includes the title element in a controlled access point for a work. Includes a term designating form at the beginning of the title element of a controlled access point for a musical work or expression (e.g., Symphony, Concerto). Includes conventional and collective titles at the beginning of the title element of a controlled access point for a work or expression (e.g., Treaties, Laws, Works, Selections, Piano music). Includes the additional  element(s) in a collective title controlled access point (i.e., a subsequent term or terms used to subdivide the collective uniform title)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3017">frad:P3017</a>
    /// </summary>
    let P3017 = _prefixId.prefix "P3017"
    /// <summary>
    ///   <para>skos:scopeNote : Includes the fuller form of name added to the base access point. Includes the title of nobility, title of royalty, or ecclesiastical title added to the base access point. Includes dates added to the base access point. Includes the place name associated with a corporate body added to the base access point. Includes a number associated with a corporate body or a musical work added to the base access point. Includes a title of an adaptation or version of a work added to the base access point. Includes the name and/or number of a section or part of a work added to the base access point. Includes a term designating the form of a work added to the base access point. Includes a term designating language of expression added to the base access point. Includes a term designating the key in which a musical work was originally composed added to the base access point. Includes a term designating the medium of performance for which a musical work was originally conceived added to the base access point. Includes other designations associated with persons and corporate bodies added to the base access point.</para>
    ///   <para>skos:definition : Relates a controlled access point to a name, title, date, place, number, or other designation added to the base access point.</para>
    ///   <para>rdfs:label : tiene adiciónrdfs:label : has addition</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAddition</para>
    ///   <para>rdfs:comment : Sometimes referred to as a "qualifier".</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3018">frad:P3018</a>
    /// </summary>
    let P3018 = _prefixId.prefix "P3018"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCitationForRules</para>
    ///   <para>rdfs:label : tiene cita de reglasrdfs:label : has citation for rules</para>
    ///   <para>skos:definition : Relates rules to a citation for the cataloguing code, set of rules, instructions, etc.</para>
    ///   <para>skos:scopeNote : Includes the title of the rules, etc., and, as necessary, the name of the body responsible for the rules, the edition designation, date, etc.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3019">frad:P3019</a>
    /// </summary>
    let P3019 = _prefixId.prefix "P3019"
    /// <summary>
    ///   <para>rdfs:label : has rules identifierrdfs:label : tiene identificador de reglas</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasRulesIdentifier</para>
    ///   <para>skos:definition : Relates rules to an acronym or initials or alphanumeric code identifying the rules.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3020">frad:P3020</a>
    /// </summary>
    let P3020 = _prefixId.prefix "P3020"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTypeOfIdentifier</para>
    ///   <para>rdfs:label : has type of identifierrdfs:label : tiene tipo de identificador</para>
    ///   <para>skos:scopeNote : Includes alphabetic strings identifying the numbering system (e.g., "ISBN", "ISSN", "ISRC"). Includes symbols designating the type of identifier (e.g., registered trademark symbol)
    /// </para>
    ///   <para>skos:definition : Relates an identifier to a code or other designation indicating the type of identifier (i.e., the domain in which the identifier is assigned).</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3021">frad:P3021</a>
    /// </summary>
    let P3021 = _prefixId.prefix "P3021"
    /// <summary>
    ///   <para>skos:scopeNote : Includes personal names, corporate names, names of families, trade names, and titles of works and manifestations. Includes names of concepts, objects, events, and places.</para>
    ///   <para>skos:definition : Relates a name to the category of a name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTypeOfName</para>
    ///   <para>rdfs:label : has type of namerdfs:label : tiene tipo de nombre</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3022">frad:P3022</a>
    /// </summary>
    let P3022 = _prefixId.prefix "P3022"
    /// <summary>
    ///   <para>skos:definition : Relates a name to a sequence of numeric and/or alphabetic characters or symbols that represents the name of an entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNameString</para>
    ///   <para>rdfs:label : has name stringrdfs:label : tiene cadena de caracteres</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3023">frad:P3023</a>
    /// </summary>
    let P3023 = _prefixId.prefix "P3023"
    /// <summary>
    ///   <para>skos:scopeNote : Includes forms, genres, etc., (e.g., literary works, critical works, works on mathematics, detective novels) associated with a name used by an author.</para>
    ///   <para>skos:definition : Relates a name to the form of work associated with a particular name for a persona.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasScopeOfUsage</para>
    ///   <para>rdfs:label : has scope of usagerdfs:label : tiene alcance de uso</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3024">frad:P3024</a>
    /// </summary>
    let P3024 = _prefixId.prefix "P3024"
    /// <summary>
    ///   <para>skos:definition : Relates a name to dates associated with the use of a particular name established by a person, corporate body, or family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDatesOfUsage</para>
    ///   <para>rdfs:label : has dates of usagerdfs:label : tiene fechas de uso</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3025">frad:P3025</a>
    /// </summary>
    let P3025 = _prefixId.prefix "P3025"
    /// <summary>
    ///   <para>skos:definition : Relates a name to the language in which the name is expressed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLanguageOfName</para>
    ///   <para>rdfs:label : has language of name</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3026">frad:P3026</a>
    /// </summary>
    let P3026 = _prefixId.prefix "P3026"
    /// <summary>
    ///   <para>skos:definition : Relates a name to the script in which the name is rendered</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasScriptOfName</para>
    ///   <para>rdfs:label : has script of name</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3027">frad:P3027</a>
    /// </summary>
    let P3027 = _prefixId.prefix "P3027"
    /// <summary>
    ///   <para>skos:definition : Relates a name to the scheme used to produce the transliterated form of the name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTransliterationSchemeOfName</para>
    ///   <para>rdfs:label : has transliteration scheme of namerdfs:label : tiene esquema de transliteración del nombre</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3028">frad:P3028</a>
    /// </summary>
    let P3028 = _prefixId.prefix "P3028"
    /// <summary>
    ///   <para>rdfs:label : has genderrdfs:label : tiene género</para>
    ///   <para>skos:scopeNote : E.g., male, female, unknown, other.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasGender</para>
    ///   <para>skos:definition : Relates a person to a gender by which the person is identified.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3029">frad:P3029</a>
    /// </summary>
    let P3029 = _prefixId.prefix "P3029"
    /// <summary>
    ///   <para>skos:definition : Relates a person to the town, city, province, state, and/or country in which the person was born.</para>
    ///   <para>rdfs:label : tiene lugar de nacimientordfs:label : has place of birth</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfBirth</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3030">frad:P3030</a>
    /// </summary>
    let P3030 = _prefixId.prefix "P3030"
    /// <summary>
    ///   <para>skos:definition : Relates a person to the town, city, province, state, and/or country in which the person died.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfDeath</para>
    ///   <para>rdfs:label : tiene lugar de fallecimientordfs:label : has place of death</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3031">frad:P3031</a>
    /// </summary>
    let P3031 = _prefixId.prefix "P3031"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a country with which the person is identified.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCountry</para>
    ///   <para>rdfs:label : has countryrdfs:label : tiene país</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3032">frad:P3032</a>
    /// </summary>
    let P3032 = _prefixId.prefix "P3032"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a country, state/province, city, etc., in which the person resides or has resided.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfResidence</para>
    ///   <para>rdfs:label : has place of residencerdfs:label : tiene lugar de residencia</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3033">frad:P3033</a>
    /// </summary>
    let P3033 = _prefixId.prefix "P3033"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a group with which the person is affiliated or has been affiliated through employment, membership, cultural identity, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAffiliation</para>
    ///   <para>rdfs:label : has affiliationrdfs:label : tiene afiliación</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3034">frad:P3034</a>
    /// </summary>
    let P3034 = _prefixId.prefix "P3034"
    /// <summary>
    ///   <para>skos:scopeNote : Includes street address, postal address, telephone number, e-mail address, etc. Includes the address of a World Wide Web site operated by the person, about the person or related to the person.</para>
    ///   <para>skos:definition : Relates a person to the current or former address of the person's place of residence, business, or employer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAddressPerson</para>
    ///   <para>rdfs:label : has address (person)rdfs:label : tiene dirección (persona)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3035">frad:P3035</a>
    /// </summary>
    let P3035 = _prefixId.prefix "P3035"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a language the person uses when creating an expression for publication, broadcasting, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLanguageOfPerson</para>
    ///   <para>rdfs:label : has language of person</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3036">frad:P3036</a>
    /// </summary>
    let P3036 = _prefixId.prefix "P3036"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a field of endeavour, area of expertise, etc., in which the person is engaged or was engaged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFieldOfActivityPerson</para>
    ///   <para>rdfs:label : has field of activity (person)rdfs:label : tiene campo de actividad (persona)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3037">frad:P3037</a>
    /// </summary>
    let P3037 = _prefixId.prefix "P3037"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a profession or occupation in which the person works or worked.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasProfessionOrOccupation</para>
    ///   <para>rdfs:label : has profession or occupation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3038">frad:P3038</a>
    /// </summary>
    let P3038 = _prefixId.prefix "P3038"
    /// <summary>
    ///   <para>skos:definition : Relates a person to information pertaining to the life or history of the person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasBiographyOrHistory</para>
    ///   <para>rdfs:label : has biography or historyrdfs:label : tiene biografía o historia</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3039">frad:P3039</a>
    /// </summary>
    let P3039 = _prefixId.prefix "P3039"
    /// <summary>
    ///   <para>rdfs:label : has language of the corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a language that the corporate body uses in its communications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLanguageOfTheCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3040">frad:P3040</a>
    /// </summary>
    let P3040 = _prefixId.prefix "P3040"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAddressCorporateBody</para>
    ///   <para>skos:scopeNote : Includes addresses for the corporate body's headquarters and/or other offices. Includes street address, postal address, telephone number, e-mail address, etc. Includes the address of a World Wide Web site operated by the corporate body, about the corporate body or related to the corporate body.</para>
    ///   <para>skos:definition : Relates a corporate body to the current or former address of the corporate body's office(s).</para>
    ///   <para>rdfs:label : has address (corporate body)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3041">frad:P3041</a>
    /// </summary>
    let P3041 = _prefixId.prefix "P3041"
    /// <summary>
    ///   <para>rdfs:label : has field of activity (corporate body)rdfs:label : tiene campo de actividad (entidad corporativa)</para>
    ///   <para>skos:definition : Relates a corporate body to a field of business in which the corporate body is engaged, its area of competence, responsibility, jurisdiction, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFieldOfActivityCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3042">frad:P3042</a>
    /// </summary>
    let P3042 = _prefixId.prefix "P3042"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to information pertaining to the history of the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasHistoryCorporateBody</para>
    ///   <para>rdfs:label : has history (corporate body)</para>
    ///   <para>skos:scopeNote : Includes historical information pertaining to an organization, institution, etc.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3043">frad:P3043</a>
    /// </summary>
    let P3043 = _prefixId.prefix "P3043"
    /// <summary>
    ///   <para>skos:scopeNote : Includes area of origin, etc.</para>
    ///   <para>skos:definition : Relates a work to the country or other territorial jurisdiction or cultural area from which the work originated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfOriginOfTheWork</para>
    ///   <para>rdfs:label : has place of origin of the workrdfs:label : tiene lugar de origen de la obra</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3045">frad:P3045</a>
    /// </summary>
    let P3045 = _prefixId.prefix "P3045"
    /// <summary>
    ///   <para>skos:scopeNote : Includes historical information pertaining to a work, including title changes for continuing resources.</para>
    ///   <para>skos:definition : Relates a work to information pertaining to the history of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasHistoryWork</para>
    ///   <para>rdfs:label : has history (work)rdfs:label : tiene historia (obra)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3046">frad:P3046</a>
    /// </summary>
    let P3046 = _prefixId.prefix "P3046"
    /// <summary>
    ///   <para>skos:scopeNote : E.g. Moir rare book collection, http://www.juilliardmanuscriptcollection.org/, Short loan collection (School of African and Oriental Studies, University of London), Library of Congress. Does not include collections where the item is originally published or manufactured as a component part.</para>
    ///   <para>skos:definition : Relates an item to the collection and/or institution in which the item is held, stored, or made available for access.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLocationOfItem</para>
    ///   <para>rdfs:label : has location of item</para>
    ///   <para>rdfs:comment : Scope note not present in original documentation; added to clarify semantic difference with "is part (item)" property (http://iflastandards.info/ns/fr/frbr/frbrer/P2092).</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3047">frad:P3047</a>
    /// </summary>
    let P3047 = _prefixId.prefix "P3047"
    /// <summary>
    ///   <para>skos:definition : Relates an item to the record of previous ownership of an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCustodialHistoryOfItem</para>
    ///   <para>rdfs:label : has custodial history of item</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3048">frad:P3048</a>
    /// </summary>
    let P3048 = _prefixId.prefix "P3048"
    /// <summary>
    ///   <para>skos:definition : Relates an item to the source from which an item was directly acquired and the circumstances under which it was acquired.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasImmediateSourceOfAcquisitionOfItem</para>
    ///   <para>rdfs:label : has immediate source of acquisition of item</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3049">frad:P3049</a>
    /// </summary>
    let P3049 = _prefixId.prefix "P3049"
    /// <summary>
    ///   <para>skos:scopeNote : Includes information about the subject of the work. Includes classification numbers.</para>
    ///   <para>skos:definition : Relates a work to the subject aspects of the work and its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSubjectOfTheWork</para>
    ///   <para>rdfs:label : has subject of the work</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3050">frad:P3050</a>
    /// </summary>
    let P3050 = _prefixId.prefix "P3050"
    /// <summary>
    ///   <para>skos:scopeNote : Includes serial numbers, opus numbers assigned by the composer of a musical work, etc.</para>
    ///   <para>skos:definition : Relates a work to a number assigned to it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumericDesignation</para>
    ///   <para>rdfs:label : has numeric designationrdfs:label : tiene designación numérica</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3051">frad:P3051</a>
    /// </summary>
    let P3051 = _prefixId.prefix "P3051"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a language associated with the family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLanguageOfFamily</para>
    ///   <para>rdfs:label : has language of family</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P3052">frad:P3052</a>
    /// </summary>
    let P3052 = _prefixId.prefix "P3052"
    /// <summary>
    ///   <para>skos:definition : Relates controlled access points that are established as parallel language forms of access point for the authorized forms of name for the same entity.</para>
    ///   <para>rdfs:label : has parallel language form</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParallelLanguageForm</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4001">frad:P4001</a>
    /// </summary>
    let P4001 = _prefixId.prefix "P4001"
    /// <summary>
    ///   <para>rdfs:label : has alternate script form</para>
    ///   <para>skos:definition : Relates controlled access points that are established as alternate script forms of the access point for the authorized forms of name for the same entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAlternateScriptForm</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4002">frad:P4002</a>
    /// </summary>
    let P4002 = _prefixId.prefix "P4002"
    /// <summary>
    ///   <para>skos:definition : Relates controlled access points for the authorized forms of name for the same entity that have been established according to different sets of rules.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDifferentRulesForm</para>
    ///   <para>rdfs:label : has different rules form</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4003">frad:P4003</a>
    /// </summary>
    let P4003 = _prefixId.prefix "P4003"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a person who is a member of the family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMemberFamily</para>
    ///   <para>rdfs:label : has member (family)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4004">frad:P4004</a>
    /// </summary>
    let P4004 = _prefixId.prefix "P4004"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a family of which the person is a member.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isMemberOfFamily</para>
    ///   <para>rdfs:label : is member of (family)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4005">frad:P4005</a>
    /// </summary>
    let P4005 = _prefixId.prefix "P4005"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a person who is a member of or affiliated with the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMemberCorporateBody</para>
    ///   <para>rdfs:label : has member (corporate body)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4006">frad:P4006</a>
    /// </summary>
    let P4006 = _prefixId.prefix "P4006"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a corporate body in which the person is a member or with which the person is affiliated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isMemberOfCorporateBody</para>
    ///   <para>rdfs:label : is member of (corporate body)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4007">frad:P4007</a>
    /// </summary>
    let P4007 = _prefixId.prefix "P4007"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDescendentGenealogicalRelationship</para>
    ///   <para>rdfs:label : has (descendent) genealogical relationship </para>
    ///   <para>skos:definition : Relates a family to another family that descended from the prior family.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4008">frad:P4008</a>
    /// </summary>
    let P4008 = _prefixId.prefix "P4008"
    /// <summary>
    ///   <para>skos:definition : Relates a family to another family which is the precursor of the prior family.</para>
    ///   <para>rdfs:label : has (predecessor) genealogical relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPredecessorGenealogicalRelationship</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4009">frad:P4009</a>
    /// </summary>
    let P4009 = _prefixId.prefix "P4009"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a corporate body which the family created.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isFounderOf</para>
    ///   <para>rdfs:label : es fundador derdfs:label : is founder of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4010">frad:P4010</a>
    /// </summary>
    let P4010 = _prefixId.prefix "P4010"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a family which created it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFounder</para>
    ///   <para>rdfs:label : has founder</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4011">frad:P4011</a>
    /// </summary>
    let P4011 = _prefixId.prefix "P4011"
    /// <summary>
    ///   <para>rdfs:label : es propietario derdfs:label : is owner of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOwnerOf</para>
    ///   <para>skos:definition : Related a family to a corporate body which the family owns.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4012">frad:P4012</a>
    /// </summary>
    let P4012 = _prefixId.prefix "P4012"
    /// <summary>
    ///   <para>rdfs:label : has ownerrdfs:label : tiene propietario</para>
    ///   <para>skos:definition : Relates a corporate body to a family which owns it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOwner</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4013">frad:P4013</a>
    /// </summary>
    let P4013 = _prefixId.prefix "P4013"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSubordinate</para>
    ///   <para>rdfs:label : has subordinaterdfs:label : tiene subordinado</para>
    ///   <para>skos:definition : Relates a corporate body to another corporate body which is subordinate to the prior corporate body.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4014">frad:P4014</a>
    /// </summary>
    let P4014 = _prefixId.prefix "P4014"
    /// <summary>
    ///   <para>rdfs:label : es subordinado derdfs:label : is subordinate of</para>
    ///   <para>skos:definition : Relates a corporate body to another corporate body to which it is subordinate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubordinateOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4015">frad:P4015</a>
    /// </summary>
    let P4015 = _prefixId.prefix "P4015"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to another corporate body of which it is a predecessor.</para>
    ///   <para>skos:scopeNote : Includes splits, mergers, subsequent meetings or conferences.</para>
    ///   <para>rdfs:label : es predecesora derdfs:label : is predecessor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isPredecessorOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4016">frad:P4016</a>
    /// </summary>
    let P4016 = _prefixId.prefix "P4016"
    /// <summary>
    ///   <para>rdfs:label : is successor ofrdfs:label : es sucesora de</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSuccessorOf</para>
    ///   <para>skos:definition : Relates a corporate body to another corporate body of which it is a successor.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4017">frad:P4017</a>
    /// </summary>
    let P4017 = _prefixId.prefix "P4017"
    /// <summary>
    ///   <para>skos:scopeNote : The subject term and the classification number may also be viewed as parallel names or identifiers for the name of the same entity.</para>
    ///   <para>rdfs:label : has corresponding subject term or classification number</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCorrespondingSubjectTermOrClassificationNumber</para>
    ///   <para>skos:definition : Relates a controlled access point for the name of a bibliographic entity and a subject term in a controlled vocabulary or a classification number for that entity.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4018">frad:P4018</a>
    /// </summary>
    let P4018 = _prefixId.prefix "P4018"
    /// <summary>
    ///   <para>skos:definition : Relates a controlled access point based on an authorized or variant form of name of a bibliographic entity to an identifier for the same bibliographic entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasRelatedIdentifier</para>
    ///   <para>rdfs:label : has related identifierrdfs:label : tiene identificador relacionado</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4019">frad:P4019</a>
    /// </summary>
    let P4019 = _prefixId.prefix "P4019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEarlierName</para>
    ///   <para>rdfs:label : tiene nombre anteriorrdfs:label : has earlier name</para>
    ///   <para>skos:definition : Relates a name of a person to a name that person used at an earlier stage in life.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4021">frad:P4021</a>
    /// </summary>
    let P4021 = _prefixId.prefix "P4021"
    /// <summary>
    ///   <para>rdfs:label : has later namerdfs:label : tiene nombre posterior</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLaterName</para>
    ///   <para>skos:definition : Relates a name of a person and a name that person used at a later stage in life.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4022">frad:P4022</a>
    /// </summary>
    let P4022 = _prefixId.prefix "P4022"
    /// <summary>
    ///   <para>skos:definition : Relates a name of a family and an alternative linguistic form of name by which that family is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAlternativeLinguisticFormFamily</para>
    ///   <para>rdfs:label : has alternative linguistic form (family) rdfs:label : tiene forma lingüística alternativa (familia)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4024">frad:P4024</a>
    /// </summary>
    let P4024 = _prefixId.prefix "P4024"
    /// <summary>
    ///   <para>rdfs:label : tiene forma lingüística alternativa (entidad corporativa)rdfs:label : has alternative linguistic form (corporate body) </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAlternativeLinguisticFormCorporateBody</para>
    ///   <para>skos:scopeNote : Includes translations of the name for the corporate body.</para>
    ///   <para>skos:definition : Relates a name of a corporate body and an alternative linguistic form of name by which that body is known.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4025">frad:P4025</a>
    /// </summary>
    let P4025 = _prefixId.prefix "P4025"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExpandedName</para>
    ///   <para>rdfs:label : tiene nombre extensordfs:label : has expanded name</para>
    ///   <para>skos:definition : Relates a name of a corporate body and the expanded form of name by which that body is known.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4026">frad:P4026</a>
    /// </summary>
    let P4026 = _prefixId.prefix "P4026"
    /// <summary>
    ///   <para>rdfs:label : tiene acrónimo o iniciales o abreviaturasrdfs:label : has acronym or initials or abbreviation</para>
    ///   <para>skos:definition : Relates a name of a corporate body and an acronym or initials or an abbreviation by which that body is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAcronymOrInitialsOrAbbreviation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4027">frad:P4027</a>
    /// </summary>
    let P4027 = _prefixId.prefix "P4027"
    /// <summary>
    ///   <para>skos:definition : Relates a name of a work and an alternative linguistic form of name by which that work is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAlternativeLinguisticFormWork </para>
    ///   <para>rdfs:label : has alternative linguistic form (work) rdfs:label : tiene forma lingüística alternativa (obra)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4028">frad:P4028</a>
    /// </summary>
    let P4028 = _prefixId.prefix "P4028"
    /// <summary>
    ///   <para>skos:definition : Relates a name of a work and a conventional name by which that work is known</para>
    ///   <para>rdfs:label : has conventional namerdfs:label : tiene nombre convencional</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasConventionalName</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4029">frad:P4029</a>
    /// </summary>
    let P4029 = _prefixId.prefix "P4029"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isConventionalNameOf</para>
    ///   <para>rdfs:label : is conventional name ofrdfs:label : es nombre convencional de</para>
    ///   <para>skos:definition : Relates a conventional name by which a work is known to a name of the same work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4030">frad:P4030</a>
    /// </summary>
    let P4030 = _prefixId.prefix "P4030"
    /// <summary>
    ///   <para>skos:scopeNote : Includes orthographic variant names (spelling variations, transliterations, punctuation variations, capitalization variations), word order variant names (inversions, permutations), alternative name/synonym variant names (bynames, nicknames, courtesy names). </para>
    ///   <para>skos:definition : Relates a name of a person and several other variations on a name (other than earlier name, later name, and alternative linguistic form).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherVariantNamePerson</para>
    ///   <para>rdfs:label : has other variant name (person)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4031">frad:P4031</a>
    /// </summary>
    let P4031 = _prefixId.prefix "P4031"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherVariantNameCorporateBody</para>
    ///   <para>skos:definition : Relates a name of a corporate body and a name by which that body is known (other than expanded name, acronym, initials, abbreviation, and alternative linguistic form).</para>
    ///   <para>skos:scopeNote : Includes orthographic variant names (spelling variations, transliterations, punctuation variations, capitalization variations), word order variant names (inversions, permutations).</para>
    ///   <para>rdfs:label : has other variant name (corporate body)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4032">frad:P4032</a>
    /// </summary>
    let P4032 = _prefixId.prefix "P4032"
    /// <summary>
    ///   <para>skos:scopeNote : Includes orthographic variant names(spelling variations, transliterations, punctuation variations, capitalization variations), word order variant names(inversions, permutations), variant title variant names (titles for the work based on titles found on manifestations or items, including cover title, spine title, caption title, container title, parallel title).</para>
    ///   <para>skos:definition : Relates a name of a work and a name by which that work is known (other than conventional name, and alternative linguistic form).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherVariantNameWork</para>
    ///   <para>rdfs:label : has other variant name (work)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4033">frad:P4033</a>
    /// </summary>
    let P4033 = _prefixId.prefix "P4033"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAlternativeLinguisticFormPerson</para>
    ///   <para>rdfs:label : tiene forma lingüística alternativa (persona)rdfs:label : has alternative linguistic form (person)</para>
    ///   <para>skos:definition : Relates a name of a person and an alternative linguistic form of name by which that person is known.</para>
    ///   <para>skos:scopeNote : Includes translations of a name into other languages.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4034">frad:P4034</a>
    /// </summary>
    let P4034 = _prefixId.prefix "P4034"
    /// <summary>
    ///   <para>skos:definition : Relates a "real" person (i.e., an individual) and a persona(ae) or identity adopted by that individual through the use of one or more pseudonyms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPseudonymousPersona</para>
    ///   <para>rdfs:label : has pseudonymous persona</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4035">frad:P4035</a>
    /// </summary>
    let P4035 = _prefixId.prefix "P4035"
    /// <summary>
    ///   <para>skos:definition : Relates a persona(ae) or identity adopted by an individual through the use of one or more pseudonyms and the "real" person (i.e., the individual).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isPseudonymousPersonaOf</para>
    ///   <para>rdfs:label : is pseudonymous persona of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4036">frad:P4036</a>
    /// </summary>
    let P4036 = _prefixId.prefix "P4036"
    /// <summary>
    ///   <para>rdfs:label : has secular identityrdfs:label : tiene identidad secular</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSecularIdentity</para>
    ///   <para>skos:definition : Relates a person and an identity that person assumes in a secular capacity.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4037">frad:P4037</a>
    /// </summary>
    let P4037 = _prefixId.prefix "P4037"
    /// <summary>
    ///   <para>skos:definition : Relates an identity a person assumes in a secular capacity and the person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSecularIdentityOf</para>
    ///   <para>rdfs:label : is secular identity of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4038">frad:P4038</a>
    /// </summary>
    let P4038 = _prefixId.prefix "P4038"
    /// <summary>
    ///   <para>skos:definition : Relates a person and an identity that person assumes in a religious capacity.</para>
    ///   <para>rdfs:label : tiene identidad religiosardfs:label : has religious identity</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasReligiousIdentity</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4039">frad:P4039</a>
    /// </summary>
    let P4039 = _prefixId.prefix "P4039"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isReligiousIdentityOf</para>
    ///   <para>skos:definition : Relates an identity a person assumes in a religious capacity and the person.</para>
    ///   <para>rdfs:label : is religious identity of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4040">frad:P4040</a>
    /// </summary>
    let P4040 = _prefixId.prefix "P4040"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOfficialIdentity</para>
    ///   <para>rdfs:label : tiene identidad oficialrdfs:label : has official identity</para>
    ///   <para>skos:definition : Relates a person and an identity that person assumes in an official capacity.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4041">frad:P4041</a>
    /// </summary>
    let P4041 = _prefixId.prefix "P4041"
    /// <summary>
    ///   <para>skos:definition : Relates an identity a person assumes in an official capacity and the person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOfficialIdentityOf</para>
    ///   <para>rdfs:label : is official identity of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4042">frad:P4042</a>
    /// </summary>
    let P4042 = _prefixId.prefix "P4042"
    /// <summary>
    ///   <para>skos:definition : Relates one person and another person (either a "real" individual or a persona) or identity to whom one or more works by the former have been attributed, either erroneously or falsely.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasWorksAttributedTo</para>
    ///   <para>rdfs:label : has works attributed to</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4043">frad:P4043</a>
    /// </summary>
    let P4043 = _prefixId.prefix "P4043"
    /// <summary>
    ///   <para>skos:definition : Relates a person (either a "real" individual or a persona) or identity to whom one or more works by another person have been attributed, either erroneously or falsely, and that other person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAttributedWorksFrom</para>
    ///   <para>rdfs:label : has attributed works from</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4044">frad:P4044</a>
    /// </summary>
    let P4044 = _prefixId.prefix "P4044"
    /// <summary>
    ///   <para>skos:definition : Relates two persons (i.e., individuals) who collaborate in intellectual or artistic endeavours</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCollaborativeRelationship</para>
    ///   <para>rdfs:label : has collaborative relationshiprdfs:label : tiene relación colaborativa con</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4045">frad:P4045</a>
    /// </summary>
    let P4045 = _prefixId.prefix "P4045"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a family that is the subject of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectFamily</para>
    ///   <para>rdfs:label : has as subject (family)rdfs:label : tiene como materia (familia)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4046">frad:P4046</a>
    /// </summary>
    let P4046 = _prefixId.prefix "P4046"
    /// <summary>
    ///   <para>skos:definition : Relates two persons who have the same “parent(s)” (in an actual family or within a group).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSibling</para>
    ///   <para>rdfs:label : has sibling</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4047">frad:P4047</a>
    /// </summary>
    let P4047 = _prefixId.prefix "P4047"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasParent</para>
    ///   <para>skos:definition : Relates a person to another person who is a “parent”  of that person.</para>
    ///   <para>rdfs:label : has parent</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4048">frad:P4048</a>
    /// </summary>
    let P4048 = _prefixId.prefix "P4048"
    /// <summary>
    ///   <para>skos:definition : Relates a person to another person who is a "child" of that person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasChild</para>
    ///   <para>rdfs:label : has child</para>
    ///   <a href="http://iflastandards.info/ns/fr/frad/P4049">frad:P4049</a>
    /// </summary>
    let P4049 = _prefixId.prefix "P4049"
