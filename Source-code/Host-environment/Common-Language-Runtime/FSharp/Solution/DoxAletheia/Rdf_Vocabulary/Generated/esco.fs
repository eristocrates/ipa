namespace http.data.europa.eu.esco.model.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module esco =
    let _namespace_iri = Namespace_Iri esco |> NamespaceIRI
    /// <summary>
    ///   <para>esco:AwardingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of awarding bodies registered by ESCO.
    ///
    /// An ESCO registered awarding body is an official or otherwise recognized institution, organization or company that is issuing formal certificates of competence.  Some of these certificates are registered as ESCO qualifications (see http://data.europa.eu/esco/model#Qualification).  The relationship between an esco:Qualification and an esco:AwardingBody is given by http://data.europa.eu/esco/model#hasAwardingBody.
    ///
    /// The geo-location(s) of an awarding body is given by http://data.europa.eu/esco/model#location"</para>
    /// labels<para>"Awarding body"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#AwardingBody">http://data.europa.eu/esco/model#AwardingBody</seealso>
    let AwardingBody = Prefixed_Name(esco, "AwardingBody") |> PrefixedName
    /// <summary>
    ///   <para>esco:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of ESCO pillar concepts.
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
    /// - modified : last modification date (http://purl.org/dc/terms/modified) - required"</para>
    /// labels<para>"ESCO pillar Concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Concept">http://data.europa.eu/esco/model#Concept</seealso>
    let Concept = Prefixed_Name(esco, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>esco:ConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ESCO concept schemes (pillars)
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
    /// - modified : last modification date (http://purl.org/dc/terms/modified) - required"</para>
    /// labels<para>"Concept scheme (ESCO pillar)"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#ConceptScheme">http://data.europa.eu/esco/model#ConceptScheme</seealso>
    let ConceptScheme = Prefixed_Name(esco, "ConceptScheme") |> PrefixedName
    /// <summary>
    ///   <para>esco:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Relevant standards for country locations are documented under the super class: http://data.europa.eu/esco/model#Location"</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Country">http://data.europa.eu/esco/model#Country</seealso>
    let Country = Prefixed_Name(esco, "Country") |> PrefixedName
    /// <summary>
    ///   <para>esco:EQFLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The EQF levels have been published as recommendation by the EU Publication office under CELEX number 32008H0506(01)
    ///  See http://publications.europa.eu/resource/celex/32008H0506%2801%29"</para>
    /// labels<para>"Level (European Qualification Framework)"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#EQFLevel">http://data.europa.eu/esco/model#EQFLevel</seealso>
    let EQFLevel = Prefixed_Name(esco, "EQFLevel") |> PrefixedName
    /// <summary>
    ///   <para>esco:FacetConceptGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Facet concept group (i.e. an instance of the class esco:FacetConceptGroup) is a sub-set of concepts from a facet.
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
    /// The name of the facet group is given by skos:prefLabel"</para>
    /// labels<para>"Facet concept group"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#FacetConceptGroup">http://data.europa.eu/esco/model#FacetConceptGroup</seealso>
    let FacetConceptGroup = Prefixed_Name(esco, "FacetConceptGroup") |> PrefixedName
    /// <summary>
    ///   <para>esco:FacetedConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of compound ESCO pillar concepts.
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
    /// Further, inheritance rules apply as on ESCO concepts (see http://data.europa.eu/esco/model#Concept)."</para>
    /// labels<para>"Faceted ESCO concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#FacetedConcept">http://data.europa.eu/esco/model#FacetedConcept</seealso>
    let FacetedConcept = Prefixed_Name(esco, "FacetedConcept") |> PrefixedName
    /// <summary>
    ///   <para>esco:FoETCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of ISCED 2013/FoET classificaton code (International Standard Classification of Education: Fields of Education and Training 2013)
    ///
    /// The Fields of Education and Training have been submitted to the UNESCO Conference - session 37 - Paris.
    /// The version submitted for resolution is available from: http://unesdoc.unesco.org/images/0022/002218/221863e.pdf
    ///
    /// Other original source references:
    /// - http://www.uis.unesco.org/Education/Documents/isced-37c-fos-review-222729e.pdf
    /// - http://www.uis.unesco.org/EDUCATION/Pages/international-standard-classification-of-education.aspx"</para>
    /// labels<para>"FoET code"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#FoETCode">http://data.europa.eu/esco/model#FoETCode</seealso>
    let FoETCode = Prefixed_Name(esco, "FoETCode") |> PrefixedName
    /// <summary>
    ///   <para>esco:GroupConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concepts
    ///  of this type are aggregations.  The property http://data.europa.eu/esco/model#hasGroupMember gives the members concepts of the group.  The member concepts have type http://data.europa.eu/esco/model#MemberConcept.  These member concepts are skos:narrowerTransitive spcializations of the group concept.  Among GroupConcept, the skos:broader/skos:narrower is like a super-group/sub-group relation meaning that all members of the (narrower) sub-group also are members of the (broader) super-group.
    ///
    /// Typically these group concepts are NOT used in CV or job postings, but serve organization, reporting and statiscal purposes.
    /// The member concepts of group concepts are used for coding or annotating CV or job postings.
    ///
    /// A Group concept typically will be
    /// - in the upper levels of an ESCO pillar (or concept schema)
    /// - in an external concept schema (e.g. ISCO)"</para>
    /// labels<para>"Group concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#GroupConcept">http://data.europa.eu/esco/model#GroupConcept</seealso>
    let GroupConcept = Prefixed_Name(esco, "GroupConcept") |> PrefixedName
    /// <summary>
    ///   <para>esco:ISCO88Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The parent ISCO 88 codes of a specific occupation.
    /// The format is ''&lt;code&gt;[,&lt;code&gt;]*''^^xsd:string
    ///
    /// e.g ''3139,3131''^^xsd:string  means the occupation has 2 parent occupation groups in isco88. One with iscocode 3139 and one with iscocode 3131"</para>
    /// labels<para>"ISCO88 Code"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#ISCO88Code">http://data.europa.eu/esco/model#ISCO88Code</seealso>
    let ISCO88Code = Prefixed_Name(esco, "ISCO88Code") |> PrefixedName
    /// <summary>
    ///   <para>esco:Label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of labels used on esco pillar Concepts.
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
    /// - modified : last modification date (http://purl.org/dc/terms/modified) - required"</para>
    /// labels<para>"ESCO pillar concept Label"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Label">http://data.europa.eu/esco/model#Label</seealso>
    let Label = Prefixed_Name(esco, "Label") |> PrefixedName
    /// <summary>
    ///   <para>esco:LabelRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Allows to capture one or more particular characteristics of a name.
    ///
    /// Example usage: Gender related terms.
    /// - ESCO concepts may get a gender neutral term as preferred label.  The gender specific terms are provided as alternate labels.
    /// - Relevant use cases:
    ///   - concept look-up based on gender specific term
    ///   - Job posting generation with gender neutral terms
    ///   - CV generation with gender specific terms"</para>
    /// labels<para>"Label role"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#LabelRole">http://data.europa.eu/esco/model#LabelRole</seealso>
    let LabelRole = Prefixed_Name(esco, "LabelRole") |> PrefixedName
    /// <summary>
    ///   <para>esco:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of language concepts.
    /// Each language is
    /// - labeled using skos:prefLabel in all of the other languages and
    /// - identified using the ESCO esco:language property (value = ISO 2-char language code).
    ///
    /// The class provides the set of languages that can be in use in the thesaurus.
    /// Two ESCO concept schemes provide language concepts:
    /// - http://data.europa.eu/esco/ConceptScheme/ISO639/cs - all languages of ISO 639-1 and ISO 639-2
    /// - http://data.europa.eu/esco/ConceptScheme/ISO639-3/cs - all sign languages listed in ISO 639-3
    ///
    /// The esco:ConceptScheme identifies the languages actually used via its property esco:supportedLanguage."</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Language">http://data.europa.eu/esco/model#Language</seealso>
    let Language = Prefixed_Name(esco, "Language") |> PrefixedName
    /// <summary>
    ///   <para>esco:LeafGroupConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Group (or aggregation) concept, having no sub-groups anymore.
    ///
    /// Narrower concepts only can be members (or narrower instances) of the group concept.
    /// The specialization http://data.europa.eu/esco/model#narrowerInstance of skos:narrower is used to identify the top level members of the group."</para>
    /// labels<para>"Leaf-group concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#LeafGroupConcept">http://data.europa.eu/esco/model#LeafGroupConcept</seealso>
    let LeafGroupConcept = Prefixed_Name(esco, "LeafGroupConcept") |> PrefixedName
    /// <summary>
    ///   <para>esco:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A teritorial area like a federation, a country, a region, a jurisdiction area.
    ///
    /// Standards useful for locations and regions:
    /// - ISO 3166
    /// - NUTS - http://epp.eurostat.ec.europa.eu/portal/page/portal/nuts_nomenclature/introduction (extends ISO 3166 with sub-regions)
    /// - geonames - http://www.geonames.org/ (includes ISO 3166)
    /// - EU publication Office - http://publications.europa.eu/mdr/authority/country/index.html"</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Location">http://data.europa.eu/esco/model#Location</seealso>
    let Location = Prefixed_Name(esco, "Location") |> PrefixedName
    /// <summary>
    ///   <para>esco:MemberConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concepts of this class are specifically used to be referenced in CV or job postings.  Typically these concepts are at the more specialized levels of the hierarchy.
    /// Example: A particular occupation, not a group of occupations.
    /// These concepts in general have
    /// - (1) a http://data.europa.eu/esco/model#broaderInstance relationship to http://data.europa.eu/esco/model#LeafGroupConcept
    /// - (2) one or more http://data.europa.eu/esco/model#memberOfGroup relationships to http://data.europa.eu/esco/model#GroupConcept
    /// However, some Member concept may be specializations of other ones.  In general these specializations will not comply to (1). General group membership within ESCO pillars is provided by esco:memberOfGroup."</para>
    /// labels<para>"Member concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#MemberConcept">http://data.europa.eu/esco/model#MemberConcept</seealso>
    let MemberConcept = Prefixed_Name(esco, "MemberConcept") |> PrefixedName
    /// <summary>
    ///   <para>esco:NACECode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Industry sector code NACE rev2
    ///
    /// The NACE codes are published in http://epp.eurostat.ec.europa.eu/cache/ITY_OFFPUB/KS-RA-07-015/EN/KS-RA-07-015-EN.PDF
    /// The RDF version is available from: http://ec.europa.eu/eurostat/ramon/rdfdata/nace_r2.rdf - Note, this is not SKOS but can be made SKOS compliant.
    /// ESCO keeps a SKOS compliant copy of NACE codes. These are organized in the concept scheme http://data.europa.eu/esco/ConceptScheme/NACErev2/cs"</para>
    /// labels<para>"NACE code"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#NACECode">http://data.europa.eu/esco/model#NACECode</seealso>
    let NACECode = Prefixed_Name(esco, "NACECode") |> PrefixedName
    /// <summary>
    ///   <para>esco:Occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of ESCO Occupation concepts. An Occuaption is an ESCO pillar concept (see http://data.europa.eu/esco/model#Concept).
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
    /// ESCO Occupations are maintained in the ESCO concept scheme http://data.europa.eu/esco/ConceptScheme/ESCO_Occupations."</para>
    /// labels<para>"Occupation"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Occupation">http://data.europa.eu/esco/model#Occupation</seealso>
    let Occupation = Prefixed_Name(esco, "Occupation") |> PrefixedName

    /// <summary>
    ///   <para>esco:OverlappingSkillGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of collections of overlapping esco:Skill concepts. All skills within one collection of overlapping skills have overlapping semantics with each other.
    ///
    /// The collection has a name using http://www.w3.org/2004/02/skos/core#prefLabel .
    ///
    /// As clarifications about the overlapping emerge, a decision from ESCO editorial team may instruct to merge some or all of the member concepts of this collection or to relate its members in another way."</para>
    /// labels<para>"Group of overlapping skills"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#OverlappingSkillGroup">http://data.europa.eu/esco/model#OverlappingSkillGroup</seealso>
    let OverlappingSkillGroup =
        Prefixed_Name(esco, "OverlappingSkillGroup") |> PrefixedName

    /// <summary>
    ///   <para>esco:Qualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of ESCO qualifications.
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
    /// - The value 'true' of the boolean flag http://data.europa.eu/esco/model#isIndirect indicates the Qualifications is not managed by ESCO but represented by ESCO based on an external source (e.g. national qualifications)."</para>
    /// labels<para>"Qualification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Qualification">http://data.europa.eu/esco/model#Qualification</seealso>
    let Qualification = Prefixed_Name(esco, "Qualification") |> PrefixedName
    /// <summary>
    ///   <para>esco:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of directed relationships between two ESCO Pillar concepts (e.g. between an esco:Occupation and an esco:Qualification).
    ///
    /// The relationship:
    /// - starts from the ESCO concept identified by http://data.europa.eu/esco/model#isRelationshipFor.
    /// - is detailed using a descriptive text (http://purl.org/dc/terms/description).  This description may contain reference to external sources (see http://data.europa.eu/esco/model#relatedLegallyRequiredQualification)
    /// - ends in the ESCO concept identified by http://data.europa.eu/esco/model#refersConcept.
    /// - is typed by the tagging property http://data.europa.eu/esco/model#hasRelationshipType.
    /// A relationship may be industry sector or location specific. This can be acieved by tagging the relationship using esco:hasNACECode or esco:location respectively."</para>
    /// labels<para>"ESCO concepts Relationship"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Relationship">http://data.europa.eu/esco/model#Relationship</seealso>
    let Relationship = Prefixed_Name(esco, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>esco:RelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of the types of ESCO relations.
    /// The concepts having this type are managed in the small SKOS taxonomy (see http://data.europa.eu/esco/ConceptScheme/RelationshipType)."</para>
    /// labels<para>"ESCO relationship type"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#RelationshipType">http://data.europa.eu/esco/model#RelationshipType</seealso>
    let RelationshipType = Prefixed_Name(esco, "RelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>esco:SectorBreakDownConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sector breakdown concept can be used in the Occupation and in the Skill/Competences pillar to organize navigation.  As such, it may be related (or characterize) a group of occupations as well as a group of skills.
    /// It is not an industry sector, but it may be tagged with NACE codes.
    ///
    /// This notion is specifically used for organizing the ESCO thesaurus creation (cfr. ESCO v1 methdology and SREF groups)."</para>
    /// labels<para>"ESCO concept used for sector breakdown."</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#SectorBreakDownConcept">http://data.europa.eu/esco/model#SectorBreakDownConcept</seealso>
    let SectorBreakDownConcept =
        Prefixed_Name(esco, "SectorBreakDownConcept") |> PrefixedName

    /// <summary>
    ///   <para>esco:SimpleConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of simple ESCO concepts.
    ///
    /// A simple ESCO concept is not decomposed into components (for compound ESCO concepts see http://data.europa.eu/esco/model#FacetedConcept).
    /// A simple concept may be further specialized by faceted concepts.  The facets used for this specialization are represented by the property http://data.europa.eu/esco/model#facet."</para>
    /// labels<para>"Simple ESCO concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#SimpleConcept">http://data.europa.eu/esco/model#SimpleConcept</seealso>
    let SimpleConcept = Prefixed_Name(esco, "SimpleConcept") |> PrefixedName
    /// <summary>
    ///   <para>esco:Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of ESCO Skill concepts.
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
    /// The property http://data.europa.eu/esco/model#hasRelationship details the relationships (see http://data.europa.eu/esco/model#Relationship)"</para>
    /// labels<para>"Skill"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#Skill">http://data.europa.eu/esco/model#Skill</seealso>
    let Skill = Prefixed_Name(esco, "Skill") |> PrefixedName
    /// <summary>
    ///   <para>esco:SkillCompetenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sub-Typing of a Skill Concept:
    /// - Skill/Competence
    /// - Knowledge"</para>
    /// labels<para>"Competence sub-type"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#SkillCompetenceType">http://data.europa.eu/esco/model#SkillCompetenceType</seealso>
    let SkillCompetenceType = Prefixed_Name(esco, "SkillCompetenceType") |> PrefixedName
    /// <summary>
    ///   <para>esco:SkillReuseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Re-usability level of a Skill or competence.
    /// Details are provided by the ESCOpedia article on Cross-sector skills and competences (see https://ec.europa.eu/esco/escopedia/-/escopedia/Cross-sector_skills_and_competences?resetLanguage=true&amp;newLanguage=en")
    ///
    /// The concept hierarchy in the Skill Reuse Level concept scheme (http://data.europa.eu/esco/ConceptScheme/SkillReuseLevel) must detail the allowed skill hierarchy.
    /// A skill with re-use level A can only be a broader of a skill with reuse level B if either of the following holds:
    /// - reuse level A = reuse level B
    /// - reuse level A is a broader transitive of reuse level B.
    /// A skill can have at most one re-use level (see http://data.europa.eu/esco/model#Skill)."</para>
    /// labels<para>"Skill reuse level"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#SkillReuseLevel">http://data.europa.eu/esco/model#SkillReuseLevel</seealso>
    let SkillReuseLevel = Prefixed_Name(esco, "SkillReuseLevel") |> PrefixedName
    /// <summary>
    ///   <para>esco:WorkContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of work contexts registered by ESCO
    /// A work context iIdentifies types of business, environmental conditions, types of product, etc.
    /// ESCO manages and organizes work context in the concept scheme: http://data.europa.eu/esco/ConceptScheme/WorkContext/cs
    /// "</para>
    /// labels<para>"Work context"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#WorkContext">http://data.europa.eu/esco/model#WorkContext</seealso>
    let WorkContext = Prefixed_Name(esco, "WorkContext") |> PrefixedName

    /// <summary>
    ///   <para>esco:awardingBodyDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An awarding body provided using a descriptive text.
    /// A more precise definition of an awarding body known by ESCO can be given using http://data.europa.eu/esco/model#hasAwardingBody"</para>
    /// labels<para>"awarding body (descriptive)"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#awardingBodyDescription">http://data.europa.eu/esco/model#awardingBodyDescription</seealso>
    let awardingBodyDescription =
        Prefixed_Name(esco, "awardingBodyDescription") |> PrefixedName

    /// <summary>
    ///   <para>esco:broaderInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Leaf Group the (subject) ESCO member concept (Skill or Occupation or Qualification) belongs to.
    /// Only member properties having a Leaf Group type as broader concept must have this property,  Specializations of member concepts (like Faceted Concepts) do not have this property."</para>
    /// labels<para>"broader instance"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#broaderInstance">http://data.europa.eu/esco/model#broaderInstance</seealso>
    let broaderInstance = Prefixed_Name(esco, "broaderInstance") |> PrefixedName
    /// <summary>
    ///   <para>esco:constructedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The unique (simple) ESCO concept used to construct the (subject) faceted ESCO concept.
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
    /// - Each of these (more) specialized faceted concepts all have the (simple) ESCO occupation "Teacher" as value for esco:constructedFrom"</para>
    /// labels<para>"constructed from ESCO concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#constructedFrom">http://data.europa.eu/esco/model#constructedFrom</seealso>
    let constructedFrom = Prefixed_Name(esco, "constructedFrom") |> PrefixedName
    /// <summary>
    ///   <para>esco:editorialStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The business or editorial status of a concept or label"</para>
    /// labels<para>"editorial status"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#editorialStatus">http://data.europa.eu/esco/model#editorialStatus</seealso>
    let editorialStatus = Prefixed_Name(esco, "editorialStatus") |> PrefixedName

    /// <summary>
    ///   <para>esco:editorialStatusDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"list of status values used for managing ESCO vocabulary changes.
    /// The editorial status is only managed by a human with the role of taxonomy editor.
    ///
    /// On creation, the default status is "prepared".  The label or concept is considered not final.
    /// When finalizing the business releaavance and the related editorial review process, the status can be set to "proposed".
    /// After a formal validation process by the business, the status can be set to approved.
    /// When a review considers the label or concept not relevant any more, the publication status is (automatically) set to "obsolete" by the relevant deprecation action.
    /// "</para>
    /// labels<para>"thesaurus concept and label editorial status type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#editorialStatusDataType">http://data.europa.eu/esco/model#editorialStatusDataType</seealso>
    let editorialStatusDataType =
        Prefixed_Name(esco, "editorialStatusDataType") |> PrefixedName

    /// <summary>
    ///   <para>esco:expirationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"ESCO expiration note"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#expirationNote">http://data.europa.eu/esco/model#expirationNote</seealso>
    let expirationNote = Prefixed_Name(esco, "expirationNote") |> PrefixedName
    /// <summary>
    ///   <para>esco:expirationPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Period how long a qualification is valid.
    ///
    /// Example: a qualification for aircraft pilot may be subject to hours flight and/or testing within a specified period in order to pro-long the qualification."</para>
    /// labels<para>"qualification expiration period"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#expirationPeriod">http://data.europa.eu/esco/model#expirationPeriod</seealso>
    let expirationPeriod = Prefixed_Name(esco, "expirationPeriod") |> PrefixedName
    /// <summary>
    ///   <para>esco:facet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The facet concept group, a group of concepts used to expand:
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
    /// - - - ... (other facet group 2 members)"</para>
    /// labels<para>"specializing facet"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#facet">http://data.europa.eu/esco/model#facet</seealso>
    let facet = Prefixed_Name(esco, "facet") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasAwardingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The institutiution, organisation or company that issues the (subject) qualification (certification)."</para>
    /// labels<para>"has awarding body"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasAwardingBody">http://data.europa.eu/esco/model#hasAwardingBody</seealso>
    let hasAwardingBody = Prefixed_Name(esco, "hasAwardingBody") |> PrefixedName

    /// <summary>
    ///   <para>esco:hasDivisionCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO facet group the thesaurus array is being built from.
    ///
    /// When an ESCO concept is specialized by a facet group, the ESCO thesaurus introduces that set (or branch) of specializations with a Thesaurus.Array.
    ///
    /// Example: The occupation "Teacher" can be specialized by 'education level' or by 'education subject'.
    /// At concept development time this is typically specified with respective esco:facet properties, one identifying the facet-group for education level, anoher identifying the facet-group holding the instructed subject areas.
    /// At concept publication time, each specializing facet will be represented as an iso-thes:ThesaurusArray having as members the (compound) faceted concepts.
    /// For each ESCO thesaurus array this property (esco:hasDivisionCharacteristic) recalls the FacetGroup it was created for.
    ///
    /// Note: Complementary to esco:hasDivisionCharacteristic the iso-thes:superOrdinate identifies the ESCO member concept used to create the faceted concepts that are members of the thesaurus array."</para>
    /// labels<para>"division characteristic"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasDivisionCharacteristic">http://data.europa.eu/esco/model#hasDivisionCharacteristic</seealso>
    let hasDivisionCharacteristic =
        Prefixed_Name(esco, "hasDivisionCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>esco:hasEQFLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The level (as specified by the European Qualification Framework) applicable to the subject qualification."</para>
    /// labels<para>"has EQF Level"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasEQFLevel">http://data.europa.eu/esco/model#hasEQFLevel</seealso>
    let hasEQFLevel = Prefixed_Name(esco, "hasEQFLevel") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasFacet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A faceted ESCO concept (e.g.) is a compound concept constructed from an ESCO pillar concept and one or more facets.
    /// The typical example is the (foreign) language skills.
    /// - The ESCO concept is the skill: foreign language expertise.
    /// The facets are:
    ///   - the specific language of the expertise (en, fr, el, bg, nl ... )
    ///   - the skill levels defined by CEFR (writing, understanding interactively, ...)."</para>
    /// labels<para>"has facet"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasFacet">http://data.europa.eu/esco/model#hasFacet</seealso>
    let hasFacet = Prefixed_Name(esco, "hasFacet") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasFoETCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A tagging concept identifying the Field of Education Code as specified by the UNESCO Institute for Statistics (UIS)."</para>
    /// labels<para>"has FoET Code"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasFoETCode">http://data.europa.eu/esco/model#hasFoETCode</seealso>
    let hasFoETCode = Prefixed_Name(esco, "hasFoETCode") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasGroupMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the member Concept of the (subject) Group concept."</para>
    /// labels<para>"has group member"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasGroupMember">http://data.europa.eu/esco/model#hasGroupMember</seealso>
    let hasGroupMember = Prefixed_Name(esco, "hasGroupMember") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasLabelRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A tagging concept providing the gender specific typing of an ESCO label.
    /// Each ESCO label can have
    /// - at most 1 label that is standard male and zero or more labels that are male
    /// - at most 1 label that is standard female and zero or more labels that are female
    /// - any label that is not male or female is considered neutral
    /// - a male respectively female preferred label is the standard male respectively standard female label
    /// "</para>
    /// labels<para>"has label role"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasLabelRole">http://data.europa.eu/esco/model#hasLabelRole</seealso>
    let hasLabelRole = Prefixed_Name(esco, "hasLabelRole") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasNACECode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A tagging concept using the NACE codes to specify the industry sector of the tagged subject."</para>
    /// labels<para>"has NACE code"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasNACECode">http://data.europa.eu/esco/model#hasNACECode</seealso>
    let hasNACECode = Prefixed_Name(esco, "hasNACECode") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasPolyHierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"true: Indicates wether a ESCO thesaurus/taxonomy supports poly-hierarchy. Not present or false indicate mono-hierarchy."</para>
    /// labels<para>"has poly-hierarchy"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasPolyHierarchy">http://data.europa.eu/esco/model#hasPolyHierarchy</seealso>
    let hasPolyHierarchy = Prefixed_Name(esco, "hasPolyHierarchy") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The detailed (typed, annotated and documented) ESCO relationship (see http://data.europa.eu/esco/model#Relationship) for the subject ESCO concept.
    ///
    /// The relationship identifies a related ESCO concept.
    /// The relationship properties provide formal semantics to the ESCO concept relationship."</para>
    /// labels<para>"has ESCO relationship"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasRelationship">http://data.europa.eu/esco/model#hasRelationship</seealso>
    let hasRelationship = Prefixed_Name(esco, "hasRelationship") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasRelationshipList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The ordered set of relationships starting at the subject ESCO pillar concept.
    ///
    /// For any resource, every item in the list given as the value of the
    ///       esco:hasRelationshipList property is also a value of the esco:hasRelationship property."</para>
    /// labels<para>"has ESCO relationship list"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasRelationshipList">http://data.europa.eu/esco/model#hasRelationshipList</seealso>
    let hasRelationshipList = Prefixed_Name(esco, "hasRelationshipList") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasRelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A tagging concept detailing the type of the (subject) ESCO relationship"</para>
    /// labels<para>"has ESCO relationship type"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasRelationshipType">http://data.europa.eu/esco/model#hasRelationshipType</seealso>
    let hasRelationshipType = Prefixed_Name(esco, "hasRelationshipType") |> PrefixedName
    /// <summary>
    ///   <para>esco:hasWorkContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The possible working context of the (subject) occupation."</para>
    /// labels<para>"can have work context"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#hasWorkContext">http://data.europa.eu/esco/model#hasWorkContext</seealso>
    let hasWorkContext = Prefixed_Name(esco, "hasWorkContext") |> PrefixedName
    /// <summary>
    ///   <para>esco:isEssentialSkillFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inverse of esco:relatedEssentialSkill."</para>
    /// labels<para>"is essential skill for"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#isEssentialSkillFor">http://data.europa.eu/esco/model#isEssentialSkillFor</seealso>
    let isEssentialSkillFor = Prefixed_Name(esco, "isEssentialSkillFor") |> PrefixedName
    /// <summary>
    ///   <para>esco:isIndirect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"True: Indicates the subject concept (like a qualification) is not directly managed by ESCO. instead the concept is loaded into ESCO when it is provided by an external (typical national) body or agent.
    ///
    /// Could also be applied (if unambiguous) to skills and occupations.
    ///
    /// Assertion (to 'true') is required in case external contribution must be affirmed."</para>
    /// labels<para>"is indirectly included"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#isIndirect">http://data.europa.eu/esco/model#isIndirect</seealso>
    let isIndirect = Prefixed_Name(esco, "isIndirect") |> PrefixedName
    /// <summary>
    ///   <para>esco:isOptionalSkillFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inverse of esco:relatedOptionalSkill."</para>
    /// labels<para>"is optional skill for"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#isOptionalSkillFor">http://data.europa.eu/esco/model#isOptionalSkillFor</seealso>
    let isOptionalSkillFor = Prefixed_Name(esco, "isOptionalSkillFor") |> PrefixedName
    /// <summary>
    ///   <para>esco:isRelationshipFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"The ESCO concept the (subject) relationship starts from (see http://data.europa.eu/esco/model#Relationship)."</para>
    /// labels<para>"from ESCO concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#isRelationshipFor">http://data.europa.eu/esco/model#isRelationshipFor</seealso>
    let isRelationshipFor = Prefixed_Name(esco, "isRelationshipFor") |> PrefixedName
    /// <summary>
    ///   <para>esco:isTransversal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Typical to indicate that a concept (like a skill) is not job or sector specific.  It is cross sector.
    ///
    /// May also be applied (if unambiguous) to qualifications and occupations.
    ///
    /// Assertion (to 'true') is required in case transversality must be affirmed.
    ///
    /// Skill re-usability levels can be tagged in case the level implies transversal scope of the skills having the re-usability level."</para>
    /// labels<para>"is transversal"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#isTransversal">http://data.europa.eu/esco/model#isTransversal</seealso>
    let isTransversal = Prefixed_Name(esco, "isTransversal") |> PrefixedName
    /// <summary>
    ///   <para>esco:iscoLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The ISCO label of an occupation group.
    /// Provided in case the preferred label has been replaced by an esco specific one.
    ///
    /// Typically this can happen in order not to have duplicate preferred labels in the ESCO thesaurus."</para>
    /// labels<para>"isco label"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#iscoLabel">http://data.europa.eu/esco/model#iscoLabel</seealso>
    let iscoLabel = Prefixed_Name(esco, "iscoLabel") |> PrefixedName
    /// <summary>
    ///   <para>esco:isoCountryCodeA2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ISO 3166 country code - A2"</para>
    /// labels<para>"country code (A2)"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#isoCountryCodeA2">http://data.europa.eu/esco/model#isoCountryCodeA2</seealso>
    let isoCountryCodeA2 = Prefixed_Name(esco, "isoCountryCodeA2") |> PrefixedName
    /// <summary>
    ///   <para>esco:isoCountryCodeA3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ISO 3166 country code - A3"</para>
    /// labels<para>"country code (A3)"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#isoCountryCodeA3">http://data.europa.eu/esco/model#isoCountryCodeA3</seealso>
    let isoCountryCodeA3 = Prefixed_Name(esco, "isoCountryCodeA3") |> PrefixedName
    /// <summary>
    ///   <para>esco:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The language of the subject resource."</para>
    /// labels<para>"language"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#language">http://data.europa.eu/esco/model#language</seealso>
    let language = Prefixed_Name(esco, "language") |> PrefixedName
    /// <summary>
    ///   <para>esco:learningOutcomeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"a note documenting the learning outcomes."</para>
    /// labels<para>"editorial note"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#learningOutcomeNote">http://data.europa.eu/esco/model#learningOutcomeNote</seealso>
    let learningOutcomeNote = Prefixed_Name(esco, "learningOutcomeNote") |> PrefixedName
    /// <summary>
    ///   <para>esco:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Country or region the subject is associated with.
    /// Typically a tagging concept."</para>
    /// labels<para>"location"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#location">http://data.europa.eu/esco/model#location</seealso>
    let location = Prefixed_Name(esco, "location") |> PrefixedName
    /// <summary>
    ///   <para>esco:memberOfGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO Group (pillar) concept containing the subject ESCO concept as a member."</para>
    /// labels<para>"containing group"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#memberOfGroup">http://data.europa.eu/esco/model#memberOfGroup</seealso>
    let memberOfGroup = Prefixed_Name(esco, "memberOfGroup") |> PrefixedName
    /// <summary>
    ///   <para>esco:memberOfISCOGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The direct hierarchical broader ISCO concept of the (subject) ESCO occupation.
    /// The 'direct' (or one step) relationship is to be understood in terms of extending the ISCO taxonomy the (object) concept belongs to.
    ///
    /// The ISCO concept may be of any ISCO version.  The ISCO version can be determined by the inScheme property on the ISCO concept and the version information on the ISCO concept scheme (referenced by the object - i.e. by the ISCO concept)."</para>
    /// labels<para>"belongs to ISCO Group with code"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#memberOfISCOGroup">http://data.europa.eu/esco/model#memberOfISCOGroup</seealso>
    let memberOfISCOGroup = Prefixed_Name(esco, "memberOfISCOGroup") |> PrefixedName
    /// <summary>
    ///   <para>esco:narrowerInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO concepts (occupation, skill or qualification) that are immediate (one step) narrower concepts of the (subject) leaf group.  These narrower concepts are top level (member) concepts of the subject leaf concept group.
    ///
    /// The (subject) leaf group may have more members, not provided by its esco:narrowerInstance properties.  Typically, these other members are specializations (e.g. faceted concepts) of the top level members of the (subject) leaf concept group."</para>
    /// labels<para>"narrower instance"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#narrowerInstance">http://data.europa.eu/esco/model#narrowerInstance</seealso>
    let narrowerInstance = Prefixed_Name(esco, "narrowerInstance") |> PrefixedName
    /// <summary>
    ///   <para>esco:noteLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An xml literal taking a plain text or xhtml.body.type content type.
    ///
    /// The property typically allows to validate the content of a SKOS note (or any of its SKOS sub-properties).
    /// Notes are then provided as blank nodes with this property and with the ESCO language property.
    ///
    /// The motivations for this complex approach are:
    /// - Provides structure content (XML literal) according a format that can be validated.
    /// - xml:lang and rdf:parseType="Literal" can not be provided on the same property."</para>
    /// labels<para>"note text"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#noteLiteral">http://data.europa.eu/esco/model#noteLiteral</seealso>
    let noteLiteral = Prefixed_Name(esco, "noteLiteral") |> PrefixedName
    /// <summary>
    ///   <para>esco:originalLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The original label of a concept of a support taxonomy.
    /// Provided in case the preferred label has been replaced by an ESCO specific one.
    ///
    /// Typically used on arguable names for exceptional concepts like 'Country'"</para>
    /// labels<para>"original label"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#originalLabel">http://data.europa.eu/esco/model#originalLabel</seealso>
    let originalLabel = Prefixed_Name(esco, "originalLabel") |> PrefixedName
    /// <summary>
    ///   <para>esco:plusUF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A compound equivalence label for the subject concept.
    /// The subject concept is a Simple ESCO concept used as a component of a Faceted ESCO concept (i.e. a compound concept).
    /// The label of this faceted concept is a compound term (i.e. a split non preferred term) and the value of esco:plusUF (i.e. a UF++).
    /// There can be any number of compound terms per language and per faceted concept."</para>
    /// labels<para>"compound term"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#plusUF">http://data.europa.eu/esco/model#plusUF</seealso>
    let plusUF = Prefixed_Name(esco, "plusUF") |> PrefixedName
    /// <summary>
    ///   <para>esco:referenceLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Reference language for a concept.
    ///
    /// Typically set when the concept is first loaded with PT in (at least) 1 language.  (If multiple but not all languages are provided, the reference language must be uniquely set to one of the loaded languages.)
    ///
    /// In case the concept needs to be shown or translated in a new language (not having a PT yet), the label in the reference language is shown."</para>
    /// labels<para>"reference language"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#referenceLanguage">http://data.europa.eu/esco/model#referenceLanguage</seealso>
    let referenceLanguage = Prefixed_Name(esco, "referenceLanguage") |> PrefixedName
    /// <summary>
    ///   <para>esco:refersConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO concept referred by the (subject) ESCO relationship.
    /// The esco:Relationship gives a more elaborate semantic description of related ESCO concepts.  These related concepts are identied by the esco:Relationship propertief
    /// - esco:isRelationshipFor
    /// - esco:refersConcept
    /// Further semantics are provided by
    /// - a relationshipt type
    /// - a description
    /// - .. (other possible extensions)"</para>
    /// labels<para>"to ESCO concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#refersConcept">http://data.europa.eu/esco/model#refersConcept</seealso>
    let refersConcept = Prefixed_Name(esco, "refersConcept") |> PrefixedName

    /// <summary>
    ///   <para>esco:regulatedProfessionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The subject occupation is regulated according the description in the note.  The note typically contains a hyperlink."</para>
    /// labels<para>"regultated profession note"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#regulatedProfessionNote">http://data.europa.eu/esco/model#regulatedProfessionNote</seealso>
    let regulatedProfessionNote =
        Prefixed_Name(esco, "regulatedProfessionNote") |> PrefixedName

    /// <summary>
    ///   <para>esco:relatedCompetence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO skill/competence related to (or asserted by) the subject ESCO qualification.
    /// I.e. when asserted on a subject qualification, the related competence is a learning outcome of that qualification."</para>
    /// labels<para>"competence"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#relatedCompetence">http://data.europa.eu/esco/model#relatedCompetence</seealso>
    let relatedCompetence = Prefixed_Name(esco, "relatedCompetence") |> PrefixedName

    /// <summary>
    ///   <para>esco:relatedEssentialSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The ESCO skill or competence that is essential for the subject occupation or skill."</para>
    /// labels<para>"has essential skill"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#relatedEssentialSkill">http://data.europa.eu/esco/model#relatedEssentialSkill</seealso>
    let relatedEssentialSkill =
        Prefixed_Name(esco, "relatedEssentialSkill") |> PrefixedName

    /// <summary>
    ///   <para>esco:relatedLegallyRequiredQualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO qualification (certification) that is legally required for the subject occupation or skill.
    /// Details for the requirements must be given in the relationship description.
    ///
    /// Occasionally, such a description must hold a hyperlink to the relevant professions database (e.g. http://ec.europa.eu/internal_market/qualifications/regprof/index.cfm?action=profession&amp;id_profession=12142).
    /// In case the legal requirement is region specific, the relationship:
    /// - should detail the restriction in the relation description
    /// - could be tagged with a location or NUTS code (see http://data.europa.eu/esco/model#location)"</para>
    /// labels<para>"legally required qualification"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#relatedLegallyRequiredQualification">http://data.europa.eu/esco/model#relatedLegallyRequiredQualification</seealso>
    let relatedLegallyRequiredQualification =
        Prefixed_Name(esco, "relatedLegallyRequiredQualification") |> PrefixedName

    /// <summary>
    ///   <para>esco:relatedOptionalSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO skill or competence that is relevant (but optional) for the subject occuption."</para>
    /// labels<para>"has optional skill"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#relatedOptionalSkill">http://data.europa.eu/esco/model#relatedOptionalSkill</seealso>
    let relatedOptionalSkill =
        Prefixed_Name(esco, "relatedOptionalSkill") |> PrefixedName

    /// <summary>
    ///   <para>esco:relatedQualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ESCO qualification (certification) that is required for the subject occupation or skill."</para>
    /// labels<para>"qualification"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#relatedQualification">http://data.europa.eu/esco/model#relatedQualification</seealso>
    let relatedQualification =
        Prefixed_Name(esco, "relatedQualification") |> PrefixedName

    /// <summary>
    ///   <para>esco:relevantURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A web site that is relevant for the subject (any modelled class, including an ESCO concept or term).
    ///
    /// Such URL may be part literal content value of a description, a definition or a scope note.
    /// A relevant URI may be language specific (hence the range is literal)."</para>
    /// labels<para>"relevant URL"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#relevantURL">http://data.europa.eu/esco/model#relevantURL</seealso>
    let relevantURL = Prefixed_Name(esco, "relevantURL") |> PrefixedName
    /// <summary>
    ///   <para>esco:replacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Typical for a deprecated concept that has been replaced by one or more other concepts.
    ///
    /// Should be made a sub-property of, or be replaced by: http://purl.org/dc/terms/isReplacedBy"</para>
    /// labels<para>"replaced by"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#replacedBy">http://data.europa.eu/esco/model#replacedBy</seealso>
    let replacedBy = Prefixed_Name(esco, "replacedBy") |> PrefixedName

    /// <summary>
    ///   <para>esco:replacedByTransitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Typical for a chain of changes and deprecations of a concept over different versions."</para>
    /// labels<para>"transitive replaced by"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#replacedByTransitive">http://data.europa.eu/esco/model#replacedByTransitive</seealso>
    let replacedByTransitive =
        Prefixed_Name(esco, "replacedByTransitive") |> PrefixedName

    /// <summary>
    ///   <para>esco:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Typical for a deprecated concept that replaces one or more other concepts.
    ///
    /// Should be made a sub-property of, or be replaced by: http://purl.org/dc/terms/replaces"</para>
    /// labels<para>"replaces"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#replaces">http://data.europa.eu/esco/model#replaces</seealso>
    let replaces = Prefixed_Name(esco, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>esco:replacesTransitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Typical for a chain of deprecated concepts that replaces one or more other concepts over more than one version."</para>
    /// labels<para>"transitively replaces"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#replacesTransitive">http://data.europa.eu/esco/model#replacesTransitive</seealso>
    let replacesTransitive = Prefixed_Name(esco, "replacesTransitive") |> PrefixedName
    /// <summary>
    ///   <para>esco:rule</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#rule">http://data.europa.eu/esco/model#rule</seealso>
    let rule = Prefixed_Name(esco, "rule") |> PrefixedName
    /// <summary>
    ///   <para>esco:skillReuseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Reuseability level of a skill"</para>
    /// labels<para>"skill reuseability level"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#skillReuseLevel">http://data.europa.eu/esco/model#skillReuseLevel</seealso>
    let skillReuseLevel = Prefixed_Name(esco, "skillReuseLevel") |> PrefixedName
    /// <summary>
    ///   <para>esco:skillType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type of competence (a tagging concept)"</para>
    /// labels<para>"skill type"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#skillType">http://data.europa.eu/esco/model#skillType</seealso>
    let skillType = Prefixed_Name(esco, "skillType") |> PrefixedName
    /// <summary>
    ///   <para>esco:sortString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The formatted string used to establish sorting among concepts.
    /// Deprecated by use of skos:OrderedCollection and iso-thes:subordinateArray"</para>
    /// labels<para>"sorting string"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#sortString">http://data.europa.eu/esco/model#sortString</seealso>
    let sortString = Prefixed_Name(esco, "sortString") |> PrefixedName
    /// <summary>
    ///   <para>esco:statusDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"list of status values used for managing ESCO release status.
    /// On creation of a concept or label, the default state is "to be reviewed"
    /// On deprecation of a concept the concept state becomed "obsolete"
    /// When a wrongly deprecated concept is revived, the state becomes "to be reviewed"
    /// When the thesaurus is published, the statuss becomes "released"
    ///
    /// All state changes are system managed."</para>
    /// labels<para>"thesaurus concept and label publaction status type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#statusDataType">http://data.europa.eu/esco/model#statusDataType</seealso>
    let statusDataType = Prefixed_Name(esco, "statusDataType") |> PrefixedName
    /// <summary>
    ///   <para>esco:supportedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes a description of the languages supported by the (subject) concept scheme.
    /// Required for ESCO taxonomy or thesauri."</para>
    /// labels<para>"supported language"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#supportedLanguage">http://data.europa.eu/esco/model#supportedLanguage</seealso>
    let supportedLanguage = Prefixed_Name(esco, "supportedLanguage") |> PrefixedName
    /// <summary>
    ///   <para>esco:termStatusDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"list of status values used for managing ESCO ontology changes."</para>
    /// labels<para>"term status type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#termStatusDataType">http://data.europa.eu/esco/model#termStatusDataType</seealso>
    let termStatusDataType = Prefixed_Name(esco, "termStatusDataType") |> PrefixedName
    /// <summary>
    ///   <para>esco:topMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Typically specified in case the subject collection is a concept group having a hierarchical representation (hierarchy based on broader/narrower). The referenced concepts are the hierarchical entry points of the concept group hierarchy.
    /// The top may be concepts as well as collections."</para>
    /// labels<para>"has top member"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#topMember">http://data.europa.eu/esco/model#topMember</seealso>
    let topMember = Prefixed_Name(esco, "topMember") |> PrefixedName
    /// <summary>
    ///   <para>esco:undefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"undefined skill is a skill that has no optional, recommended or required property assigned to it."</para>
    /// labels<para>"undefined"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#undefined">http://data.europa.eu/esco/model#undefined</seealso>
    let undefined = Prefixed_Name(esco, "undefined") |> PrefixedName
    /// <summary>
    ///   <para>esco:undefinedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"undefined skill of"</para></remarks>
    /// <seealso href="http://data.europa.eu/esco/model#undefinedOf">http://data.europa.eu/esco/model#undefinedOf</seealso>
    let undefinedOf = Prefixed_Name(esco, "undefinedOf") |> PrefixedName
