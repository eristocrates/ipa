namespace http.data.europa.eu.esco.model.hash

open DoxAletheia.Rdf_Vocabulary

module esco =
    let _namespace_name = "http://data.europa.eu/esco/model#"

    /// <summary>
    /// The class of awarding bodies registered by ESCO.
    ///
    /// An ESCO registered awarding body is an official or otherwise recognized institution, organization or company that is issuing formal certificates of competence.  Some of these certificates are registered as ESCO qualifications (see http://data.europa.eu/esco/model#Qualification).  The relationship between an esco:Qualification and an esco:AwardingBody is given by http://data.europa.eu/esco/model#hasAwardingBody.
    ///
    /// The geo-location(s) of an awarding body is given by http://data.europa.eu/esco/model#location
    /// <see href="http://data.europa.eu/esco/model#AwardingBody"></see></summary>
    let AwardingBody =
        Namespaced_IRI.parse _namespace_name "AwardingBody" |> NamespacedName

    /// <summary>
    /// The class of ESCO qualifications.
    /// An ESCO qualification is an ESCO concepts of the ESCO qualification pillar.
    ///
    /// A qualification is an official or formal certificaton of one or more aquired skills or competences (i.e the learning outcomes - see http://data.europa.eu/esco/model#relatedCompetence).
    ///
    /// An qualification may be related to
    /// - esco:Skill (see http://data.europa.eu/esco/model#relatedEssentialSkill and http://data.europa.eu/esco/model#relatedOptionalSkill)
    /// - esco:Occupation (see http://data.europa.eu/esco/model#relatedQualification and http://data.europa.eu/esco/model#relatedLegallyRequiredQualification)
    /// The property http://data.europa.eu/esco/model#hasRelationship details the relationships (see http://data.europa.eu/esco/model#Relationship)
    ///
    /// Characteristics of a qualification
    /// - The certificate is issued by an awarding body (see http://data.europa.eu/esco/model#hasAwardingBody).
    /// - The level of the qualification may be expressed according the European Qualification Framework (see http://data.europa.eu/esco/model#hasEQFLevel).
    /// - The subject area of the qualification may be expressed according the UNESCO Institute of Statistics standard for the Fields of Education and Training (FoET - ISCED, see http://data.europa.eu/esco/model#hasFoETCode)
    /// - The property http://data.europa.eu/esco/model#expirationPeriod indicates the qualification is limited for a period of time.  Such a limitation may be provided in a descriptive way using the qualification description (see http://www.w3.org/2004/02/skos/core#definition)
    /// - The value 'true' of the boolean flag http://data.europa.eu/esco/model#isIndirect indicates the Qualifications is not managed by ESCO but represented by ESCO based on an external source (e.g. national qualifications).
    /// <see href="http://data.europa.eu/esco/model#Qualification"></see></summary>
    let Qualification =
        Namespaced_IRI.parse _namespace_name "Qualification" |> NamespacedName

    /// <summary>
    /// The class of ESCO pillar concepts.
    ///
    /// ESCO pillar concepts are divided in tree semantic classes: esco:Occupation, esco:Skill and esco:Qualification, each organized in a dedicated ConceptScheme.
    ///
    /// All concepts are specializations of skos:Concept and are structured using the skos semantic relationships.
    /// - skos:mappingRelation is used to relate ESCO concepts to similar concepts in other concept schemes (e.g. ISCO-08 or ROME). The mapping to ISCO has particular business relevance and uses a special mapping sub-property (see http://data.europa.eu/esco/model#Occupation and  http://data.europa.eu/esco/model#memberOfISCOGroup).
    /// - sub-properties of skos:related are used to express special relations among ESCO pillar concepts. (e.g. http://data.europa.eu/esco/model#isEssentialSkillFor)
    /// - sub-properties of the DCMI dcterms:subject capture codified characteristics of ESCO concepts (e.g. http://data.europa.eu/esco/model#hasNACECode, http://data.europa.eu/esco/model#skillType).
    ///
    /// The skos:broader and skos:narrower concepts are the prime concepts organizing hierarchy among ESCO pillar concepts.
    /// The hierarchical structure is modelled according three classes
    /// - esco:GroupConcept (see http://data.europa.eu/esco/model#GroupConcept) - the top level concepts, only used for strucutring. These concepts typically are not relevant for annotating CV or job postings.
    /// - esco:LeafGroupConcept (see http://data.europa.eu/esco/model#LeafGroupConcept) - the lowest top level concept, a special esco:GroupConcept.
    /// - esco:MemberConccept (see http://data.europa.eu/esco/model#MemberConcept) - the concepts used for coding or annotating CV and Job Postings.
    ///
    /// The ESCO concepts are also divided according their analytical structure.  There are two sub-classes:
    /// - simple concepts (see http://data.europa.eu/esco/model#SimpleConcept) and
    /// - compound concepts (see http://data.europa.eu/esco/model#FacetedConcept).
    ///
    /// A concept specialized by faceted concepts holds the labels of each of the faceted concepts in the property http://data.europa.eu/esco/model#plusUF.  These labels are not synonyms or alternate labels.
    ///
    /// Among hierarchical related ESCO pillar concepts the following inheritance rules apply
    /// - the ESCO relationships from any broader transitive concept are inherited with the following restrictions
    ///   in case a relationship with the same skill is typed as well essential as optional, only the essential skill relationship is inherited
    ///   in case a relationship with the same qualification is typed as well required as legally required, only the legally required qualification relationship is inherited
    /// - the occasional tagging of the faceted concept (with NUTS, NACE, FoET, ISCO, SkillType, SkillReuseLevel ... codes) must be equal or more specific (specialized) than the code of any of its broader transitive ESCO concepts.
    ///
    /// The ESCO concepts are specializations of skos:Concepts and use skos:note specializations (see http://www.w3.org/2004/02/skos/core#note).
    /// - the skos:definition gives the full description of the ESCO concept.
    /// - the skos:scopeNote is the practical instruction for when to apply the ESCO concept.
    /// - the skos:historyNote gives a system log of significant versioned changes to the ESCO concept.
    /// - the skos:changeNote gives the human provided documentation for ESCO concept version modifications.
    ///
    /// Characteristics:
    /// - At the time of publication, the ESCO concepts are available in Icelandic and the official languages of the European Union, except Irish.  Per release, actual languages covered are provided by esco:supportedLanguage.  Some concepts are originally developped in a reference language.  This particular language is indicated by http://data.europa.eu/esco/model#referenceLanguage,
    /// - Any ESCO concept may refer relevant hyperlinked sources of reference or of information. See http://data.europa.eu/esco/model#relevantURL.
    ///
    /// Each ESCO pillar concept may hold provenance and audit metadata:
    /// - rightsHolder: the owner (http://purl.org/dc/terms/rightsHolder) - optional
    /// - editorial status (http://data.europa.eu/esco/model#editorialStatus) - required
    /// - publishing status (http://purl.org/iso25964/skos-thes#status) - required
    /// - creator : the author (http://purl.org/dc/terms/creator) - optional
    /// - contributor : modifier (http://purl.org/dc/terms/contributor) - required
    /// - modified : last modification date (http://purl.org/dc/terms/modified) - required
    /// <see href="http://data.europa.eu/esco/model#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    /// The business or editorial status of a concept or label
    /// <see href="http://data.europa.eu/esco/model#editorialStatus"></see></summary>
    let editorialStatus =
        Namespaced_IRI.parse _namespace_name "editorialStatus" |> NamespacedName

    /// <summary>
    /// Concepts of this class are specifically used to be referenced in CV or job postings.  Typically these concepts are at the more specialized levels of the hierarchy.
    /// Example: A particular occupation, not a group of occupations.
    /// These concepts in general have
    /// - (1) a http://data.europa.eu/esco/model#broaderInstance relationship to http://data.europa.eu/esco/model#LeafGroupConcept
    /// - (2) one or more http://data.europa.eu/esco/model#memberOfGroup relationships to http://data.europa.eu/esco/model#GroupConcept
    /// However, some Member concept may be specializations of other ones.  In general these specializations will not comply to (1). General group membership within ESCO pillars is provided by esco:memberOfGroup.
    /// <see href="http://data.europa.eu/esco/model#MemberConcept"></see></summary>
    let MemberConcept =
        Namespaced_IRI.parse _namespace_name "MemberConcept" |> NamespacedName

    /// <summary>
    /// A compound equivalence label for the subject concept.
    /// The subject concept is a Simple ESCO concept used as a component of a Faceted ESCO concept (i.e. a compound concept).
    /// The label of this faceted concept is a compound term (i.e. a split non preferred term) and the value of esco:plusUF (i.e. a UF++).
    /// There can be any number of compound terms per language and per faceted concept.
    /// <see href="http://data.europa.eu/esco/model#plusUF"></see></summary>
    let plusUF = Namespaced_IRI.parse _namespace_name "plusUF" |> NamespacedName

    /// <summary>
    /// The class of simple ESCO concepts.
    ///
    /// A simple ESCO concept is not decomposed into components (for compound ESCO concepts see http://data.europa.eu/esco/model#FacetedConcept).
    /// A simple concept may be further specialized by faceted concepts.  The facets used for this specialization are represented by the property http://data.europa.eu/esco/model#facet.
    /// <see href="http://data.europa.eu/esco/model#SimpleConcept"></see></summary>
    let SimpleConcept =
        Namespaced_IRI.parse _namespace_name "SimpleConcept" |> NamespacedName

    /// <summary>
    /// Concepts
    ///  of this type are aggregations.  The property http://data.europa.eu/esco/model#hasGroupMember gives the members concepts of the group.  The member concepts have type http://data.europa.eu/esco/model#MemberConcept.  These member concepts are skos:narrowerTransitive spcializations of the group concept.  Among GroupConcept, the skos:broader/skos:narrower is like a super-group/sub-group relation meaning that all members of the (narrower) sub-group also are members of the (broader) super-group.
    ///
    /// Typically these group concepts are NOT used in CV or job postings, but serve organization, reporting and statiscal purposes.
    /// The member concepts of group concepts are used for coding or annotating CV or job postings.
    ///
    /// A Group concept typically will be
    /// - in the upper levels of an ESCO pillar (or concept schema)
    /// - in an external concept schema (e.g. ISCO)
    /// <see href="http://data.europa.eu/esco/model#GroupConcept"></see></summary>
    let GroupConcept =
        Namespaced_IRI.parse _namespace_name "GroupConcept" |> NamespacedName

    /// <summary>
    /// The class of compound ESCO pillar concepts.
    /// A compound concept is a concept that is broken down in a set of mare basic component concepts  (e.g. a pianist is a 'musician' performing on a 'piano')
    ///
    /// An ESCO concept is either a faceted concept or a simple concept (see http://data.europa.eu/esco/model#SimpleConcept).
    ///
    /// An ESCO faceted (or compound) concept is the specialization of an ESCO concept that identifies one or more specialization facets (see http://data.europa.eu/esco/model#facet).
    /// A specializing facet is a group of concepts with a common characteristic (e.g. the group of music instruments).
    /// The specialization makes a compound of the ESCO concept and of one concept of each of its related specializing  facets.
    ///
    /// - During the editorial phase, one or more faceted concepts may be created ad hoc by the ESCO taxonomists.
    /// - During the ESCO publishing phase all possible faceted concepts are generated by the publication process.  The process adds the possible compound conepts that were not created by the (human) taxonomist.
    /// - Each faceted concept is the specialization (i.e. the skos:narrowerTransitive) of an ESCO simple concept (see http://data.europa.eu/esco/model#constructedFrom)
    /// - All facet componets (i.e. the facet values) of the faceted conept are given by the property http://data.europa.eu/esco/model#hasFacet
    ///
    /// Uniqueness rule:
    /// Two instances of esco:FacetedConcept are the same if and only if both instances
    /// - refer the same simple ESCO concept using http://data.europa.eu/esco/model#constructedFrom
    /// - refer the same set of components (facet values) using http://data.europa.eu/esco/model#hasFacet
    ///
    /// The faceted concept inherits certain characteristics from the Simple Concept it is constructed from:
    /// - the ESCO pillar type (Occupation, Skill or Qualification) of its simple concept it is constructed from (see esco:constructedFrom).
    /// - the memberOfISCOGroup of the occasional Occupation it is constructed from
    /// - the skillType and the skillReuseLevel of the occasional Skill it is constructed from
    /// Further, inheritance rules apply as on ESCO concepts (see http://data.europa.eu/esco/model#Concept).
    /// <see href="http://data.europa.eu/esco/model#FacetedConcept"></see></summary>
    let FacetedConcept =
        Namespaced_IRI.parse _namespace_name "FacetedConcept" |> NamespacedName

    /// <summary>
    /// A Group (or aggregation) concept, having no sub-groups anymore.
    ///
    /// Narrower concepts only can be members (or narrower instances) of the group concept.
    /// The specialization http://data.europa.eu/esco/model#narrowerInstance of skos:narrower is used to identify the top level members of the group.
    /// <see href="http://data.europa.eu/esco/model#LeafGroupConcept"></see></summary>
    let LeafGroupConcept =
        Namespaced_IRI.parse _namespace_name "LeafGroupConcept" |> NamespacedName

    /// <summary>
    /// The class of ESCO Occupation concepts. An Occuaption is an ESCO pillar concept (see http://data.europa.eu/esco/model#Concept).
    /// Occupation have an broader match relation to an ISCO level 4 code (see http://data.europa.eu/esco/model#memberOfISCOGroup).
    ///
    /// Characteristics of an Occupation:
    /// - The relevant industry sector for an occupation is given by the Eurostat NACE codes (see http://data.europa.eu/esco/model#hasNACECode)
    /// - The different Work context applicable for an occupation (see http://data.europa.eu/esco/model#hasWorkContext).
    ///
    /// An occupation may be related to
    /// - esco:Skill (see http://data.europa.eu/esco/model#relatedEssentialSkill and http://data.europa.eu/esco/model#relatedOptionalSkill)
    /// - esco:Qualification (see http://data.europa.eu/esco/model#relatedQualification and http://data.europa.eu/esco/model#relatedLegallyRequiredQualification)
    ///
    /// Occupations having a legal or other regulations in a specific region
    /// - must identify these regulations in the occupation definition (and refer the professional DB stating that regulation - e.g. http://ec.europa.eu/internal_market/qualifications/regprof/index.cfm?action=profession&amp;id_profession=12142)
    /// - could identify such a region with the location property (see http://data.europa.eu/esco/model#location)
    ///
    /// ESCO Occupations are maintained in the ESCO concept scheme http://data.europa.eu/esco/ConceptScheme/ESCO_Occupations.
    /// <see href="http://data.europa.eu/esco/model#Occupation"></see></summary>
    let Occupation = Namespaced_IRI.parse _namespace_name "Occupation" |> NamespacedName
    /// <summary>
    /// The class of ESCO Skill concepts.
    ///
    /// ESCO skills are sub-typed (e.g. to differentiate between knowledge and competence).
    /// This sub-typing is modelled using the concept scheme http://data.europa.eu/esco/ConceptScheme/SkillCompetenceType and its concept class http://data.europa.eu/esco/model#SkillCompetenceType
    ///
    /// ESCO skills are organized in accordance with their applicable re-use (potential) across the sectoral breakdown of occupations.
    /// Details are provided by https://ec.europa.eu/esco/escopedia/-/escopedia/Cross-sector_skills_and_competences?resetLanguage=true&amp;newLanguage=en.
    /// This organization is modelled using the concept scheme http://data.europa.eu/esco/ConceptScheme/SkillReuseLevel and its concept class http://data.europa.eu/esco/model#SkillReuseLevel
    /// ESCO skills with a different re-use applicability across sectors can be put in a hierarchical relation (skos:broader and skos:narrower) in acordance with the rules detailed by http://data.europa.eu/esco/model#SkillReuseLevel.
    ///
    /// Characteristics
    /// - An ESCO skill sub-type is given by http://data.europa.eu/esco/model#skillType
    /// - An ESCO skill re-use level is given by http://data.europa.eu/esco/model#skillReuseLevel
    ///
    /// An ESCO Skill may be related to other ESCO concepts.
    /// - Essential related concepts of class esco:Skills are indicated by http://data.europa.eu/esco/model#isEssentialSkillFor and http://data.europa.eu/esco/model#relatedEssentialSkill
    /// - Optional related concepts of class esco:Skills are indicated http://data.europa.eu/esco/model#isOptionalSkillFor and http://data.europa.eu/esco/model#relatedOptionalSkill
    /// - Related qualifications are given by http://data.europa.eu/esco/model#relatedQualification
    /// - Occupations a skill is essential for are concepts of type esco:Occupation indicated by http://data.europa.eu/esco/model#isEssentialSkillFor
    /// - Occupations a skill is optional for are concepts of type esco:Occupation indicated by http://data.europa.eu/esco/model#isEssentialSkillFor
    /// The property http://data.europa.eu/esco/model#hasRelationship details the relationships (see http://data.europa.eu/esco/model#Relationship)
    /// <see href="http://data.europa.eu/esco/model#Skill"></see></summary>
    let Skill = Namespaced_IRI.parse _namespace_name "Skill" |> NamespacedName
    /// <summary>
    /// A teritorial area like a federation, a country, a region, a jurisdiction area.
    ///
    /// Standards useful for locations and regions:
    /// - ISO 3166
    /// - NUTS - http://epp.eurostat.ec.europa.eu/portal/page/portal/nuts_nomenclature/introduction (extends ISO 3166 with sub-regions)
    /// - geonames - http://www.geonames.org/ (includes ISO 3166)
    /// - EU publication Office - http://publications.europa.eu/mdr/authority/country/index.html
    /// <see href="http://data.europa.eu/esco/model#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// Industry sector code NACE rev2
    ///
    /// The NACE codes are published in http://epp.eurostat.ec.europa.eu/cache/ITY_OFFPUB/KS-RA-07-015/EN/KS-RA-07-015-EN.PDF
    /// The RDF version is available from: http://ec.europa.eu/eurostat/ramon/rdfdata/nace_r2.rdf - Note, this is not SKOS but can be made SKOS compliant.
    /// ESCO keeps a SKOS compliant copy of NACE codes. These are organized in the concept scheme http://data.europa.eu/esco/ConceptScheme/NACErev2/cs
    /// <see href="http://data.europa.eu/esco/model#NACECode"></see></summary>
    let NACECode = Namespaced_IRI.parse _namespace_name "NACECode" |> NamespacedName
    /// <summary>
    /// The class of language concepts.
    /// Each language is
    /// - labeled using skos:prefLabel in all of the other languages and
    /// - identified using the ESCO esco:language property (value = ISO 2-char language code).
    ///
    /// The class provides the set of languages that can be in use in the thesaurus.
    /// Two ESCO concept schemes provide language concepts:
    /// - http://data.europa.eu/esco/ConceptScheme/ISO639/cs - all languages of ISO 639-1 and ISO 639-2
    /// - http://data.europa.eu/esco/ConceptScheme/ISO639-3/cs - all sign languages listed in ISO 639-3
    ///
    /// The esco:ConceptScheme identifies the languages actually used via its property esco:supportedLanguage.
    /// <see href="http://data.europa.eu/esco/model#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName
    /// <summary>
    /// The class of ISCED 2013/FoET classificaton code (International Standard Classification of Education: Fields of Education and Training 2013)
    ///
    /// The Fields of Education and Training have been submitted to the UNESCO Conference - session 37 - Paris.
    /// The version submitted for resolution is available from: http://unesdoc.unesco.org/images/0022/002218/221863e.pdf
    ///
    /// Other original source references:
    /// - http://www.uis.unesco.org/Education/Documents/isced-37c-fos-review-222729e.pdf
    /// - http://www.uis.unesco.org/EDUCATION/Pages/international-standard-classification-of-education.aspx
    /// <see href="http://data.europa.eu/esco/model#FoETCode"></see></summary>
    let FoETCode = Namespaced_IRI.parse _namespace_name "FoETCode" |> NamespacedName
    /// <summary>
    /// The EQF levels have been published as recommendation by the EU Publication office under CELEX number 32008H0506(01)
    ///  See http://publications.europa.eu/resource/celex/32008H0506%2801%29
    /// <see href="http://data.europa.eu/esco/model#EQFLevel"></see></summary>
    let EQFLevel = Namespaced_IRI.parse _namespace_name "EQFLevel" |> NamespacedName

    /// <summary>
    /// The ESCO concept schemes (pillars)
    ///
    /// The "current" ESCO scheme and historic versions of the ESCO scheme will be instances of this class.  Typically, these support poly-hierarchy.
    ///
    /// The ISCO representations that are the backbone of at least one ESCO version (v0) also will be represented by this concept scheme.  Typically these do not have poly-hierarchy.
    /// As of ESCO v1 though, ISCO is not a part anymore of the ESCO hierarchy.  However, the ESCO v0 part corresponding to ISCO08 will be maintained a a separate versioned taxonomy.
    /// ESCO v1 occupations will be mapped (see http://data.europa.eu/esco/model#memberOfISCOGroup a sub-property of http://www.w3.org/2004/02/skos/core#broadMatch) to ISCO (level 4) concepts.
    ///
    /// Provenance information that may be added:
    /// - rightsHolder: the owner (http://purl.org/dc/terms/rightsHolder) - required
    /// - publishing status: (http://purl.org/iso25964/skos-thes#status) - required
    /// - creator : the author (http://purl.org/dc/terms/creator) - required
    /// - contributor : modifier (http://purl.org/dc/terms/contributor) - required
    /// - modified : last modification date (http://purl.org/dc/terms/modified) - required
    /// <see href="http://data.europa.eu/esco/model#ConceptScheme"></see></summary>
    let ConceptScheme =
        Namespaced_IRI.parse _namespace_name "ConceptScheme" |> NamespacedName

    /// <summary>
    /// Relevant standards for country locations are documented under the super class: http://data.europa.eu/esco/model#Location
    /// <see href="http://data.europa.eu/esco/model#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    /// A Facet concept group (i.e. an instance of the class esco:FacetConceptGroup) is a sub-set of concepts from a facet.
    /// A facet is a supporting taxonomy for ESCO.  Examples are:
    /// - Languages
    /// - Species
    /// - Tools
    ///
    /// An (instance of the) esco:FacetConceptGroup is a sub-set of concepts from a facet.
    /// Each esco:FacetConceptGroup is defined by the ESCO concept scheme http://data.europa.eu/esco/ConceptScheme/FacetConceptGroups.
    /// The typical use of an esco:FacetConceptGroup is to specialize one or more ESCO pillar concepts. (see http://data.europa.eu/esco/model#facet).
    /// The specialization creates narrower (or transitive narrower) concepts of the specialized ESCO pillar concept.
    /// Each specialization is a Faceted (or compound) concept (with type http://data.europa.eu/esco/model#FacetedConcept) having as component concepts:
    /// - the ESCO pillar object being specialized and
    /// - one member concept from the facet group.
    ///
    /// An ESCO pillar concept is either an esco:SimpleConcept or an esco:FacetedConcept
    ///
    /// An ESCO concept can be specialized in different ways using different Facet concept groups
    ///
    /// The Facet concept group may be structured:
    /// - members of an esco:FacetConceptGroup can have hierarchical relationships (skos:broader and skos:narrower) among its member concepts.
    ///   If this is the case, the hierarchical structure among the specialized concepts constructed with this facet group will mirror the hierarchy of the facet group.
    ///   See also skos:topMember.
    /// - an esco:FacetConceptGroup can be an oredered collection.
    ///   In this case, the order among the spicialized concepts constructed with this facet group will mirror the order of the facet group.
    /// - an esco:FacetConceptGroup can have different sub-collections (i.e. have skos:member that are a skos:Collection and an iso-thes:ThesaurusArray).
    ///   Collections only serve to organize the constructed faceted concepts such that the faceted concepts
    ///   that are specializations based on the structured Facet concept group are organized by thesaurus arrays
    ///   that each mirror an original thesaurus array of the Facet concept group.
    ///
    /// Example: the language FacetConceptGroup can have as members
    /// - the (possibly ordered) collection of spoken languages
    ///   having as members the language concepts
    /// - the (possibly ordered) collection of sign languages
    ///   having as members the sign language concepts
    ///
    /// The name of the facet group is given by skos:prefLabel
    /// <see href="http://data.europa.eu/esco/model#FacetConceptGroup"></see></summary>
    let FacetConceptGroup =
        Namespaced_IRI.parse _namespace_name "FacetConceptGroup" |> NamespacedName

    /// <summary>
    /// The facet concept group, a group of concepts used to expand:
    /// - the subject (ESCO) concept
    ///   or
    /// - all the members concepts of the subject Collection
    /// to build ESCO (compound) faceted concepts.
    ///
    /// An ESCO concept may have different aspects or facets that can specialize the ESCO concept.
    /// A well known example is the (foreign) language skills.
    /// - the main aspect of the (foreign) language skill is the identification of the foreign language
    ///   The specialized concepts thus constructed are:
    ///    - (foreign) language skill Albanian,
    ///    - (foreign) labguage skill Bulgarian,
    ///    - ...
    /// - the (main) facet (e.g. a set of languages) occasional is extended by (sub-) facets that can be added. E.g. a (sub-) facet of language (skill) are the specialized levels defined by CEFR writing, understanding interactively, ...)
    ///
    /// The relationship between facet groups (in the example above "language" and "CEFR language skill level" can be made 2-way (from "language" to "language skill level" and the inverse). In addition, the "(foreign) language skill" can have as facet (i.e. be specialized) by as well "language" as by "CEFR language skill level".  As a result, the ESCO concept "(foreign) language skill" can be specialized in two different ways:
    /// - first by language then by language skill level
    ///   or
    /// - first by language skill level then by language
    /// Both navigation hierarchies ultimatly hold the same set of (compound) faceted concepts (e.g. "(foreign) language skill" "writing" "Bulgarian".
    /// In general:
    /// - concept
    /// - - &amp;lt;concept by facet group 1&amp;gt;
    /// - - - [concept + facet group 1 member]
    /// - - - - &amp;lt;[concept + facet group 1 member] by facet group 2&amp;gt;
    /// - - - - - [concept + facet group 1 member + facet group 2 member]
    /// - - - - - ... (other facet group 2 members)
    /// - - - ... (other facet group 1 members)
    /// - - &amp;lt;concept by facet group 2&amp;gt;
    /// - - - [concept + facet group 2 member]
    /// - - - - &amp;lt;[concept + facet group 2 member] by facet group 1&amp;gt;
    /// - - - - - [concept + facet group 2 member + facet group 1 member]
    /// - - - - - ... (other facet group 1 members)
    /// - - - ... (other facet group 2 members)
    /// <see href="http://data.europa.eu/esco/model#facet"></see></summary>
    let facet = Namespaced_IRI.parse _namespace_name "facet" |> NamespacedName
    /// <summary>
    /// A faceted ESCO concept (e.g.) is a compound concept constructed from an ESCO pillar concept and one or more facets.
    /// The typical example is the (foreign) language skills.
    /// - The ESCO concept is the skill: foreign language expertise.
    /// The facets are:
    ///   - the specific language of the expertise (en, fr, el, bg, nl ... )
    ///   - the skill levels defined by CEFR (writing, understanding interactively, ...).
    /// <see href="http://data.europa.eu/esco/model#hasFacet"></see></summary>
    let hasFacet = Namespaced_IRI.parse _namespace_name "hasFacet" |> NamespacedName

    /// <summary>
    /// The unique (simple) ESCO concept used to construct the (subject) faceted ESCO concept.
    ///
    /// Example (started): Simple concept Teacher is specialized to identify teacher at different education levels.
    /// - The simple (member) occupation is: "Teacher"
    /// - Assume we have a classification of the levels of education (e.g. "primary school", "high school", "university")
    /// - The constructed faceted (member) concepts that will be:
    ///   "primary school teacher", "high school teacher" and "university teacher" (this last one occasionally re-labeled as "university professor")
    /// - Each of the constructed faceted (member) concepts will indicate the "teacher" also as a skos:broader concept.
    /// - Each of the constructed faceted (member) concepts will indicate the "teacher" as the esco:constructedFrom concept.
    ///
    /// Example (completed): Nesting facets - Teacher of a subject at a school level
    /// - Assume we have a classification of subjects of education (e.g. "mother tongue", "mathematics", "theorethical quantum mechanics").
    ///   Two facet groups are created for this facet (education subject):
    ///   1) Facet Group: Basic Education Subjects (with "mother tongue", "mathematics")
    ///   2) Facet Group: Advanced Education Subjects (with "mother tongue", "mathematics", "theorethical quantum mechanics")
    /// - The faceted concepts of the 'started' part of the example ("primary school teacher", "high school teacher", "university teacher")
    ///    can be further specialized with the 'Basic Education Subjects' or 'Advanced Education Subjects'.
    /// - The resulting constructed facets can be "high school teacher mathematics", "university teacher mathematics", "university teacher theorethical quantum mechanics", ...
    /// - The skos:broader for the new faceted concepts are:
    ///   1) for "university teacher mathematics" and for "university teacher theorethical quantum mechanics" : "university teacher"
    ///   2) for "high school teacher mathematics" : "high school teacher"
    ///   3) ...
    /// - Each of these (more) specialized faceted concepts all have the (simple) ESCO occupation "Teacher" as value for esco:constructedFrom
    /// <see href="http://data.europa.eu/esco/model#constructedFrom"></see></summary>
    let constructedFrom =
        Namespaced_IRI.parse _namespace_name "constructedFrom" |> NamespacedName

    /// <summary>
    /// The parent ISCO 88 codes of a specific occupation.
    /// The format is ''&lt;code&gt;[,&lt;code&gt;]*''^^xsd:string
    ///
    /// e.g ''3139,3131''^^xsd:string  means the occupation has 2 parent occupation groups in isco88. One with iscocode 3139 and one with iscocode 3131
    /// <see href="http://data.europa.eu/esco/model#ISCO88Code"></see></summary>
    let ISCO88Code = Namespaced_IRI.parse _namespace_name "ISCO88Code" |> NamespacedName

    /// <summary>
    /// The direct hierarchical broader ISCO concept of the (subject) ESCO occupation.
    /// The 'direct' (or one step) relationship is to be understood in terms of extending the ISCO taxonomy the (object) concept belongs to.
    ///
    /// The ISCO concept may be of any ISCO version.  The ISCO version can be determined by the inScheme property on the ISCO concept and the version information on the ISCO concept scheme (referenced by the object - i.e. by the ISCO concept).
    /// <see href="http://data.europa.eu/esco/model#memberOfISCOGroup"></see></summary>
    let memberOfISCOGroup =
        Namespaced_IRI.parse _namespace_name "memberOfISCOGroup" |> NamespacedName

    /// <summary>
    /// The class of labels used on esco pillar Concepts.
    ///
    /// Characteristics
    /// - An ESCO label may be motivated by relevant original sources.  These sources are referenced uising http://data.europa.eu/esco/model#relevantURL
    /// - An ESCO label typically gets label roles detailing the gender specific characteristics of the label (see http://data.europa.eu/esco/model#hasLabelRole)
    ///
    /// Provenance information that may be added:
    /// - rightsHolder: the owner (http://purl.org/dc/terms/rightsHolder) - optional
    /// - editorial status (http://data.europa.eu/esco/model#editorialStatus) - optional
    /// - workflow status (http://data.europa.eu/esco/flow#status) - required
    /// - creator : the author (http://purl.org/dc/terms/creator) - optional
    /// - contributor : modifier (http://purl.org/dc/terms/contributor) - required
    /// - modified : last modification date (http://purl.org/dc/terms/modified) - required
    /// <see href="http://data.europa.eu/esco/model#Label"></see></summary>
    let Label = Namespaced_IRI.parse _namespace_name "Label" |> NamespacedName

    /// <summary>
    /// A tagging concept providing the gender specific typing of an ESCO label.
    /// Each ESCO label can have
    /// - at most 1 label that is standard male and zero or more labels that are male
    /// - at most 1 label that is standard female and zero or more labels that are female
    /// - any label that is not male or female is considered neutral
    /// - a male respectively female preferred label is the standard male respectively standard female label
    ///
    /// <see href="http://data.europa.eu/esco/model#hasLabelRole"></see></summary>
    let hasLabelRole =
        Namespaced_IRI.parse _namespace_name "hasLabelRole" |> NamespacedName

    /// <summary>
    /// Allows to capture one or more particular characteristics of a name.
    ///
    /// Example usage: Gender related terms.
    /// - ESCO concepts may get a gender neutral term as preferred label.  The gender specific terms are provided as alternate labels.
    /// - Relevant use cases:
    ///   - concept look-up based on gender specific term
    ///   - Job posting generation with gender neutral terms
    ///   - CV generation with gender specific terms
    /// <see href="http://data.europa.eu/esco/model#LabelRole"></see></summary>
    let LabelRole = Namespaced_IRI.parse _namespace_name "LabelRole" |> NamespacedName
    /// <summary>
    /// The language of the subject resource.
    /// <see href="http://data.europa.eu/esco/model#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    /// The detailed (typed, annotated and documented) ESCO relationship (see http://data.europa.eu/esco/model#Relationship) for the subject ESCO concept.
    ///
    /// The relationship identifies a related ESCO concept.
    /// The relationship properties provide formal semantics to the ESCO concept relationship.
    /// <see href="http://data.europa.eu/esco/model#hasRelationship"></see></summary>
    let hasRelationship =
        Namespaced_IRI.parse _namespace_name "hasRelationship" |> NamespacedName

    /// <summary>
    /// The Country or region the subject is associated with.
    /// Typically a tagging concept.
    /// <see href="http://data.europa.eu/esco/model#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// A tagging concept using the NACE codes to specify the industry sector of the tagged subject.
    /// <see href="http://data.europa.eu/esco/model#hasNACECode"></see></summary>
    let hasNACECode =
        Namespaced_IRI.parse _namespace_name "hasNACECode" |> NamespacedName

    /// <summary>
    /// The class of collections of overlapping esco:Skill concepts. All skills within one collection of overlapping skills have overlapping semantics with each other.
    ///
    /// The collection has a name using http://www.w3.org/2004/02/skos/core#prefLabel .
    ///
    /// As clarifications about the overlapping emerge, a decision from ESCO editorial team may instruct to merge some or all of the member concepts of this collection or to relate its members in another way.
    /// <see href="http://data.europa.eu/esco/model#OverlappingSkillGroup"></see></summary>
    let OverlappingSkillGroup =
        Namespaced_IRI.parse _namespace_name "OverlappingSkillGroup" |> NamespacedName

    /// <summary>
    /// Period how long a qualification is valid.
    ///
    /// Example: a qualification for aircraft pilot may be subject to hours flight and/or testing within a specified period in order to pro-long the qualification.
    /// <see href="http://data.europa.eu/esco/model#expirationPeriod"></see></summary>
    let expirationPeriod =
        Namespaced_IRI.parse _namespace_name "expirationPeriod" |> NamespacedName

    /// <summary>
    /// The class of directed relationships between two ESCO Pillar concepts (e.g. between an esco:Occupation and an esco:Qualification).
    ///
    /// The relationship:
    /// - starts from the ESCO concept identified by http://data.europa.eu/esco/model#isRelationshipFor.
    /// - is detailed using a descriptive text (http://purl.org/dc/terms/description).  This description may contain reference to external sources (see http://data.europa.eu/esco/model#relatedLegallyRequiredQualification)
    /// - ends in the ESCO concept identified by http://data.europa.eu/esco/model#refersConcept.
    /// - is typed by the tagging property http://data.europa.eu/esco/model#hasRelationshipType.
    /// A relationship may be industry sector or location specific. This can be acieved by tagging the relationship using esco:hasNACECode or esco:location respectively.
    /// <see href="http://data.europa.eu/esco/model#Relationship"></see></summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// The ESCO concept referred by the (subject) ESCO relationship.
    /// The esco:Relationship gives a more elaborate semantic description of related ESCO concepts.  These related concepts are identied by the esco:Relationship propertief
    /// - esco:isRelationshipFor
    /// - esco:refersConcept
    /// Further semantics are provided by
    /// - a relationshipt type
    /// - a description
    /// - .. (other possible extensions)
    /// <see href="http://data.europa.eu/esco/model#refersConcept"></see></summary>
    let refersConcept =
        Namespaced_IRI.parse _namespace_name "refersConcept" |> NamespacedName

    /// <summary>
    /// The ESCO concept the (subject) relationship starts from (see http://data.europa.eu/esco/model#Relationship).
    /// <see href="http://data.europa.eu/esco/model#isRelationshipFor"></see></summary>
    let isRelationshipFor =
        Namespaced_IRI.parse _namespace_name "isRelationshipFor" |> NamespacedName

    /// <summary>
    /// A tagging concept detailing the type of the (subject) ESCO relationship
    /// <see href="http://data.europa.eu/esco/model#hasRelationshipType"></see></summary>
    let hasRelationshipType =
        Namespaced_IRI.parse _namespace_name "hasRelationshipType" |> NamespacedName

    /// <summary>
    /// The ESCO qualification (certification) that is legally required for the subject occupation or skill.
    /// Details for the requirements must be given in the relationship description.
    ///
    /// Occasionally, such a description must hold a hyperlink to the relevant professions database (e.g. http://ec.europa.eu/internal_market/qualifications/regprof/index.cfm?action=profession&amp;id_profession=12142).
    /// In case the legal requirement is region specific, the relationship:
    /// - should detail the restriction in the relation description
    /// - could be tagged with a location or NUTS code (see http://data.europa.eu/esco/model#location)
    /// <see href="http://data.europa.eu/esco/model#relatedLegallyRequiredQualification"></see></summary>
    let relatedLegallyRequiredQualification =
        Namespaced_IRI.parse _namespace_name "relatedLegallyRequiredQualification" |> NamespacedName

    /// <summary>
    /// The class of the types of ESCO relations.
    /// The concepts having this type are managed in the small SKOS taxonomy (see http://data.europa.eu/esco/ConceptScheme/RelationshipType).
    /// <see href="http://data.europa.eu/esco/model#RelationshipType"></see></summary>
    let RelationshipType =
        Namespaced_IRI.parse _namespace_name "RelationshipType" |> NamespacedName

    /// <summary>
    /// A sector breakdown concept can be used in the Occupation and in the Skill/Competences pillar to organize navigation.  As such, it may be related (or characterize) a group of occupations as well as a group of skills.
    /// It is not an industry sector, but it may be tagged with NACE codes.
    ///
    /// This notion is specifically used for organizing the ESCO thesaurus creation (cfr. ESCO v1 methdology and SREF groups).
    /// <see href="http://data.europa.eu/esco/model#SectorBreakDownConcept"></see></summary>
    let SectorBreakDownConcept =
        Namespaced_IRI.parse _namespace_name "SectorBreakDownConcept" |> NamespacedName

    /// <summary>
    /// Re-usability level of a Skill or competence.
    /// Details are provided by the ESCOpedia article on Cross-sector skills and competences (see https://ec.europa.eu/esco/escopedia/-/escopedia/Cross-sector_skills_and_competences?resetLanguage=true&amp;newLanguage=en")
    ///
    /// The concept hierarchy in the Skill Reuse Level concept scheme (http://data.europa.eu/esco/ConceptScheme/SkillReuseLevel) must detail the allowed skill hierarchy.
    /// A skill with re-use level A can only be a broader of a skill with reuse level B if either of the following holds:
    /// - reuse level A = reuse level B
    /// - reuse level A is a broader transitive of reuse level B.
    /// A skill can have at most one re-use level (see http://data.europa.eu/esco/model#Skill).
    /// <see href="http://data.europa.eu/esco/model#SkillReuseLevel"></see></summary>
    let SkillReuseLevel =
        Namespaced_IRI.parse _namespace_name "SkillReuseLevel" |> NamespacedName

    /// <summary>
    /// Type of competence (a tagging concept)
    /// <see href="http://data.europa.eu/esco/model#skillType"></see></summary>
    let skillType = Namespaced_IRI.parse _namespace_name "skillType" |> NamespacedName

    /// <summary>
    /// Reuseability level of a skill
    /// <see href="http://data.europa.eu/esco/model#skillReuseLevel"></see></summary>
    let skillReuseLevel =
        Namespaced_IRI.parse _namespace_name "skillReuseLevel" |> NamespacedName

    /// <summary>
    /// Sub-Typing of a Skill Concept:
    /// - Skill/Competence
    /// - Knowledge
    /// <see href="http://data.europa.eu/esco/model#SkillCompetenceType"></see></summary>
    let SkillCompetenceType =
        Namespaced_IRI.parse _namespace_name "SkillCompetenceType" |> NamespacedName

    /// <summary>
    /// The class of work contexts registered by ESCO
    /// A work context iIdentifies types of business, environmental conditions, types of product, etc.
    /// ESCO manages and organizes work context in the concept scheme: http://data.europa.eu/esco/ConceptScheme/WorkContext/cs
    ///
    /// <see href="http://data.europa.eu/esco/model#WorkContext"></see></summary>
    let WorkContext =
        Namespaced_IRI.parse _namespace_name "WorkContext" |> NamespacedName

    /// <summary>
    /// An awarding body provided using a descriptive text.
    /// A more precise definition of an awarding body known by ESCO can be given using http://data.europa.eu/esco/model#hasAwardingBody
    /// <see href="http://data.europa.eu/esco/model#awardingBodyDescription"></see></summary>
    let awardingBodyDescription =
        Namespaced_IRI.parse _namespace_name "awardingBodyDescription" |> NamespacedName

    /// <summary>
    /// The Leaf Group the (subject) ESCO member concept (Skill or Occupation or Qualification) belongs to.
    /// Only member properties having a Leaf Group type as broader concept must have this property,  Specializations of member concepts (like Faceted Concepts) do not have this property.
    /// <see href="http://data.europa.eu/esco/model#broaderInstance"></see></summary>
    let broaderInstance =
        Namespaced_IRI.parse _namespace_name "broaderInstance" |> NamespacedName

    /// <summary>
    /// The ESCO Group (pillar) concept containing the subject ESCO concept as a member.
    /// <see href="http://data.europa.eu/esco/model#memberOfGroup"></see></summary>
    let memberOfGroup =
        Namespaced_IRI.parse _namespace_name "memberOfGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/esco/model#rule"></see>
    /// </summary>
    let rule = Namespaced_IRI.parse _namespace_name "rule" |> NamespacedName

    /// <summary>
    /// list of status values used for managing ESCO vocabulary changes.
    /// The editorial status is only managed by a human with the role of taxonomy editor.
    ///
    /// On creation, the default status is "prepared".  The label or concept is considered not final.
    /// When finalizing the business releaavance and the related editorial review process, the status can be set to "proposed".
    /// After a formal validation process by the business, the status can be set to approved.
    /// When a review considers the label or concept not relevant any more, the publication status is (automatically) set to "obsolete" by the relevant deprecation action.
    ///
    /// <see href="http://data.europa.eu/esco/model#editorialStatusDataType"></see></summary>
    let editorialStatusDataType =
        Namespaced_IRI.parse _namespace_name "editorialStatusDataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/esco/model#expirationNote"></see>
    /// </summary>
    let expirationNote =
        Namespaced_IRI.parse _namespace_name "expirationNote" |> NamespacedName

    /// <summary>
    /// The institutiution, organisation or company that issues the (subject) qualification (certification).
    /// <see href="http://data.europa.eu/esco/model#hasAwardingBody"></see></summary>
    let hasAwardingBody =
        Namespaced_IRI.parse _namespace_name "hasAwardingBody" |> NamespacedName

    /// <summary>
    /// The ESCO facet group the thesaurus array is being built from.
    ///
    /// When an ESCO concept is specialized by a facet group, the ESCO thesaurus introduces that set (or branch) of specializations with a Thesaurus.Array.
    ///
    /// Example: The occupation "Teacher" can be specialized by 'education level' or by 'education subject'.
    /// At concept development time this is typically specified with respective esco:facet properties, one identifying the facet-group for education level, anoher identifying the facet-group holding the instructed subject areas.
    /// At concept publication time, each specializing facet will be represented as an iso-thes:ThesaurusArray having as members the (compound) faceted concepts.
    /// For each ESCO thesaurus array this property (esco:hasDivisionCharacteristic) recalls the FacetGroup it was created for.
    ///
    /// Note: Complementary to esco:hasDivisionCharacteristic the iso-thes:superOrdinate identifies the ESCO member concept used to create the faceted concepts that are members of the thesaurus array.
    /// <see href="http://data.europa.eu/esco/model#hasDivisionCharacteristic"></see></summary>
    let hasDivisionCharacteristic =
        Namespaced_IRI.parse _namespace_name "hasDivisionCharacteristic" |> NamespacedName

    /// <summary>
    /// The level (as specified by the European Qualification Framework) applicable to the subject qualification.
    /// <see href="http://data.europa.eu/esco/model#hasEQFLevel"></see></summary>
    let hasEQFLevel =
        Namespaced_IRI.parse _namespace_name "hasEQFLevel" |> NamespacedName

    /// <summary>
    /// A tagging concept identifying the Field of Education Code as specified by the UNESCO Institute for Statistics (UIS).
    /// <see href="http://data.europa.eu/esco/model#hasFoETCode"></see></summary>
    let hasFoETCode =
        Namespaced_IRI.parse _namespace_name "hasFoETCode" |> NamespacedName

    /// <summary>
    /// Identifies the member Concept of the (subject) Group concept.
    /// <see href="http://data.europa.eu/esco/model#hasGroupMember"></see></summary>
    let hasGroupMember =
        Namespaced_IRI.parse _namespace_name "hasGroupMember" |> NamespacedName

    /// <summary>
    /// true: Indicates wether a ESCO thesaurus/taxonomy supports poly-hierarchy. Not present or false indicate mono-hierarchy.
    /// <see href="http://data.europa.eu/esco/model#hasPolyHierarchy"></see></summary>
    let hasPolyHierarchy =
        Namespaced_IRI.parse _namespace_name "hasPolyHierarchy" |> NamespacedName

    /// <summary>
    /// The ordered set of relationships starting at the subject ESCO pillar concept.
    ///
    /// For any resource, every item in the list given as the value of the
    ///       esco:hasRelationshipList property is also a value of the esco:hasRelationship property.
    /// <see href="http://data.europa.eu/esco/model#hasRelationshipList"></see></summary>
    let hasRelationshipList =
        Namespaced_IRI.parse _namespace_name "hasRelationshipList" |> NamespacedName

    /// <summary>
    /// The possible working context of the (subject) occupation.
    /// <see href="http://data.europa.eu/esco/model#hasWorkContext"></see></summary>
    let hasWorkContext =
        Namespaced_IRI.parse _namespace_name "hasWorkContext" |> NamespacedName

    /// <summary>
    /// The inverse of esco:relatedEssentialSkill.
    /// <see href="http://data.europa.eu/esco/model#isEssentialSkillFor"></see></summary>
    let isEssentialSkillFor =
        Namespaced_IRI.parse _namespace_name "isEssentialSkillFor" |> NamespacedName

    /// <summary>
    /// The ESCO skill or competence that is essential for the subject occupation or skill.
    /// <see href="http://data.europa.eu/esco/model#relatedEssentialSkill"></see></summary>
    let relatedEssentialSkill =
        Namespaced_IRI.parse _namespace_name "relatedEssentialSkill" |> NamespacedName

    /// <summary>
    /// True: Indicates the subject concept (like a qualification) is not directly managed by ESCO. instead the concept is loaded into ESCO when it is provided by an external (typical national) body or agent.
    ///
    /// Could also be applied (if unambiguous) to skills and occupations.
    ///
    /// Assertion (to 'true') is required in case external contribution must be affirmed.
    /// <see href="http://data.europa.eu/esco/model#isIndirect"></see></summary>
    let isIndirect = Namespaced_IRI.parse _namespace_name "isIndirect" |> NamespacedName

    /// <summary>
    /// The inverse of esco:relatedOptionalSkill.
    /// <see href="http://data.europa.eu/esco/model#isOptionalSkillFor"></see></summary>
    let isOptionalSkillFor =
        Namespaced_IRI.parse _namespace_name "isOptionalSkillFor" |> NamespacedName

    /// <summary>
    /// The ESCO skill or competence that is relevant (but optional) for the subject occuption.
    /// <see href="http://data.europa.eu/esco/model#relatedOptionalSkill"></see></summary>
    let relatedOptionalSkill =
        Namespaced_IRI.parse _namespace_name "relatedOptionalSkill" |> NamespacedName

    /// <summary>
    /// Typical to indicate that a concept (like a skill) is not job or sector specific.  It is cross sector.
    ///
    /// May also be applied (if unambiguous) to qualifications and occupations.
    ///
    /// Assertion (to 'true') is required in case transversality must be affirmed.
    ///
    /// Skill re-usability levels can be tagged in case the level implies transversal scope of the skills having the re-usability level.
    /// <see href="http://data.europa.eu/esco/model#isTransversal"></see></summary>
    let isTransversal =
        Namespaced_IRI.parse _namespace_name "isTransversal" |> NamespacedName

    /// <summary>
    /// The ISCO label of an occupation group.
    /// Provided in case the preferred label has been replaced by an esco specific one.
    ///
    /// Typically this can happen in order not to have duplicate preferred labels in the ESCO thesaurus.
    /// <see href="http://data.europa.eu/esco/model#iscoLabel"></see></summary>
    let iscoLabel = Namespaced_IRI.parse _namespace_name "iscoLabel" |> NamespacedName

    /// <summary>
    /// The original label of a concept of a support taxonomy.
    /// Provided in case the preferred label has been replaced by an ESCO specific one.
    ///
    /// Typically used on arguable names for exceptional concepts like 'Country'
    /// <see href="http://data.europa.eu/esco/model#originalLabel"></see></summary>
    let originalLabel =
        Namespaced_IRI.parse _namespace_name "originalLabel" |> NamespacedName

    /// <summary>
    /// ISO 3166 country code - A2
    /// <see href="http://data.europa.eu/esco/model#isoCountryCodeA2"></see></summary>
    let isoCountryCodeA2 =
        Namespaced_IRI.parse _namespace_name "isoCountryCodeA2" |> NamespacedName

    /// <summary>
    /// ISO 3166 country code - A3
    /// <see href="http://data.europa.eu/esco/model#isoCountryCodeA3"></see></summary>
    let isoCountryCodeA3 =
        Namespaced_IRI.parse _namespace_name "isoCountryCodeA3" |> NamespacedName

    /// <summary>
    /// a note documenting the learning outcomes.
    /// <see href="http://data.europa.eu/esco/model#learningOutcomeNote"></see></summary>
    let learningOutcomeNote =
        Namespaced_IRI.parse _namespace_name "learningOutcomeNote" |> NamespacedName

    /// <summary>
    /// The ESCO concepts (occupation, skill or qualification) that are immediate (one step) narrower concepts of the (subject) leaf group.  These narrower concepts are top level (member) concepts of the subject leaf concept group.
    ///
    /// The (subject) leaf group may have more members, not provided by its esco:narrowerInstance properties.  Typically, these other members are specializations (e.g. faceted concepts) of the top level members of the (subject) leaf concept group.
    /// <see href="http://data.europa.eu/esco/model#narrowerInstance"></see></summary>
    let narrowerInstance =
        Namespaced_IRI.parse _namespace_name "narrowerInstance" |> NamespacedName

    /// <summary>
    /// An xml literal taking a plain text or xhtml.body.type content type.
    ///
    /// The property typically allows to validate the content of a SKOS note (or any of its SKOS sub-properties).
    /// Notes are then provided as blank nodes with this property and with the ESCO language property.
    ///
    /// The motivations for this complex approach are:
    /// - Provides structure content (XML literal) according a format that can be validated.
    /// - xml:lang and rdf:parseType="Literal" can not be provided on the same property.
    /// <see href="http://data.europa.eu/esco/model#noteLiteral"></see></summary>
    let noteLiteral =
        Namespaced_IRI.parse _namespace_name "noteLiteral" |> NamespacedName

    /// <summary>
    /// Reference language for a concept.
    ///
    /// Typically set when the concept is first loaded with PT in (at least) 1 language.  (If multiple but not all languages are provided, the reference language must be uniquely set to one of the loaded languages.)
    ///
    /// In case the concept needs to be shown or translated in a new language (not having a PT yet), the label in the reference language is shown.
    /// <see href="http://data.europa.eu/esco/model#referenceLanguage"></see></summary>
    let referenceLanguage =
        Namespaced_IRI.parse _namespace_name "referenceLanguage" |> NamespacedName

    /// <summary>
    /// The subject occupation is regulated according the description in the note.  The note typically contains a hyperlink.
    /// <see href="http://data.europa.eu/esco/model#regulatedProfessionNote"></see></summary>
    let regulatedProfessionNote =
        Namespaced_IRI.parse _namespace_name "regulatedProfessionNote" |> NamespacedName

    /// <summary>
    /// The ESCO skill/competence related to (or asserted by) the subject ESCO qualification.
    /// I.e. when asserted on a subject qualification, the related competence is a learning outcome of that qualification.
    /// <see href="http://data.europa.eu/esco/model#relatedCompetence"></see></summary>
    let relatedCompetence =
        Namespaced_IRI.parse _namespace_name "relatedCompetence" |> NamespacedName

    /// <summary>
    /// The ESCO qualification (certification) that is required for the subject occupation or skill.
    /// <see href="http://data.europa.eu/esco/model#relatedQualification"></see></summary>
    let relatedQualification =
        Namespaced_IRI.parse _namespace_name "relatedQualification" |> NamespacedName

    /// <summary>
    /// A web site that is relevant for the subject (any modelled class, including an ESCO concept or term).
    ///
    /// Such URL may be part literal content value of a description, a definition or a scope note.
    /// A relevant URI may be language specific (hence the range is literal).
    /// <see href="http://data.europa.eu/esco/model#relevantURL"></see></summary>
    let relevantURL =
        Namespaced_IRI.parse _namespace_name "relevantURL" |> NamespacedName

    /// <summary>
    /// Typical for a deprecated concept that has been replaced by one or more other concepts.
    ///
    /// Should be made a sub-property of, or be replaced by: http://purl.org/dc/terms/isReplacedBy
    /// <see href="http://data.europa.eu/esco/model#replacedBy"></see></summary>
    let replacedBy = Namespaced_IRI.parse _namespace_name "replacedBy" |> NamespacedName

    /// <summary>
    /// Typical for a chain of changes and deprecations of a concept over different versions.
    /// <see href="http://data.europa.eu/esco/model#replacedByTransitive"></see></summary>
    let replacedByTransitive =
        Namespaced_IRI.parse _namespace_name "replacedByTransitive" |> NamespacedName

    /// <summary>
    /// Typical for a deprecated concept that replaces one or more other concepts.
    ///
    /// Should be made a sub-property of, or be replaced by: http://purl.org/dc/terms/replaces
    /// <see href="http://data.europa.eu/esco/model#replaces"></see></summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName

    /// <summary>
    /// Typical for a chain of deprecated concepts that replaces one or more other concepts over more than one version.
    /// <see href="http://data.europa.eu/esco/model#replacesTransitive"></see></summary>
    let replacesTransitive =
        Namespaced_IRI.parse _namespace_name "replacesTransitive" |> NamespacedName

    /// <summary>
    /// The formatted string used to establish sorting among concepts.
    /// Deprecated by use of skos:OrderedCollection and iso-thes:subordinateArray
    /// <see href="http://data.europa.eu/esco/model#sortString"></see></summary>
    let sortString = Namespaced_IRI.parse _namespace_name "sortString" |> NamespacedName

    /// <summary>
    /// list of status values used for managing ESCO release status.
    /// On creation of a concept or label, the default state is "to be reviewed"
    /// On deprecation of a concept the concept state becomed "obsolete"
    /// When a wrongly deprecated concept is revived, the state becomes "to be reviewed"
    /// When the thesaurus is published, the statuss becomes "released"
    ///
    /// All state changes are system managed.
    /// <see href="http://data.europa.eu/esco/model#statusDataType"></see></summary>
    let statusDataType =
        Namespaced_IRI.parse _namespace_name "statusDataType" |> NamespacedName

    /// <summary>
    /// Denotes a description of the languages supported by the (subject) concept scheme.
    /// Required for ESCO taxonomy or thesauri.
    /// <see href="http://data.europa.eu/esco/model#supportedLanguage"></see></summary>
    let supportedLanguage =
        Namespaced_IRI.parse _namespace_name "supportedLanguage" |> NamespacedName

    /// <summary>
    /// list of status values used for managing ESCO ontology changes.
    /// <see href="http://data.europa.eu/esco/model#termStatusDataType"></see></summary>
    let termStatusDataType =
        Namespaced_IRI.parse _namespace_name "termStatusDataType" |> NamespacedName

    /// <summary>
    /// Typically specified in case the subject collection is a concept group having a hierarchical representation (hierarchy based on broader/narrower). The referenced concepts are the hierarchical entry points of the concept group hierarchy.
    /// The top may be concepts as well as collections.
    /// <see href="http://data.europa.eu/esco/model#topMember"></see></summary>
    let topMember = Namespaced_IRI.parse _namespace_name "topMember" |> NamespacedName
    /// <summary>
    /// undefined skill is a skill that has no optional, recommended or required property assigned to it.
    /// <see href="http://data.europa.eu/esco/model#undefined"></see></summary>
    let undefined = Namespaced_IRI.parse _namespace_name "undefined" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.europa.eu/esco/model#undefinedOf"></see>
    /// </summary>
    let undefinedOf =
        Namespaced_IRI.parse _namespace_name "undefinedOf" |> NamespacedName
