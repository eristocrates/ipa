namespace http.data.europa.eu.eli.ontology.hash

open DoxAletheia

module eli =
    let _namespace_name = "http://data.europa.eu/eli/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A distinct intellectual creation (i.e., the intellectual content). (definition adapted from RDA - Resource Description and Access, see http://www.rdaregistry.info/).
    /// For example, the abstract concept of the legal resource; e.g. "act 3 of 2005" (adapted from Akoma Ntoso)
    ///
    /// Legal resource can be linked together using properties defined in the model.
    /// A legal resource can represent a legal act or any component of a legal act, like an article.
    ///
    /// Note that ELI ontology accommodates different point of view on what should be considered a new legal resource, or a new legal expression of the same resource. Typically, a consolidated version can be viewed, in the context of ELI, either as separate legal resource (linked to original version and previous consolidated version using corresponding ELI relations), or as a different legal expression of the same legal resource.
    /// <see href="http://data.europa.eu/eli/ontology#LegalResource"></see></summary>
    let LegalResource = _prefix "LegalResource"
    /// <summary>
    /// Formally defined as the set of skos:Concept either in concept scheme eli:AdministrativeAreaTable or in concept scheme http://publications.europa.eu/mdr/authority/atu (Administrative Territorial Unit table published of the EU Publications Office).
    /// <see href="http://data.europa.eu/eli/ontology#AdministrativeArea"></see></summary>
    let AdministrativeArea = _prefix "AdministrativeArea"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#AdministrativeAreaTable"></see>
    /// </summary>
    let AdministrativeAreaTable = _prefix "AdministrativeAreaTable"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// The physical embodiment of a legal expression, either on paper or in any electronic format (definition adapted from RDA).
    /// For example, any electronic or physical format of the legal expression (XML, TIFF, PDF, etc.) ; e.g. PDF version of act 3 of 2005.  (adapted from Akoma Ntoso)
    /// <see href="http://data.europa.eu/eli/ontology#Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// The file format, physical medium, or dimensions of the resource (definition from Dublin Core).
    /// Possible URIs values should be taken from http://www.iana.org/assignments/media-types (e.g. http://www.iana.org/assignments/media-types/application/xml), and can serve as a basis for content negotiation for the server to return the appropriate file based on the client preference.
    /// <see href="http://data.europa.eu/eli/ontology#format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// Formally defined as the set of skos:Concept in concept scheme eli:InForceTable
    /// <see href="http://data.europa.eu/eli/ontology#InForce"></see></summary>
    let InForce = _prefix "InForce"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#InForceTable"></see>
    /// </summary>
    let InForceTable = _prefix "InForceTable"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#InForce-inForce"></see>
    /// </summary>
    let ``InForce-inForce`` = _prefix "InForce-inForce"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#InForce-notInForce"></see>
    /// </summary>
    let ``InForce-notInForce`` = _prefix "InForce-notInForce"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#InForce-partiallyInForce"></see>
    /// </summary>
    let ``InForce-partiallyInForce`` = _prefix "InForce-partiallyInForce"
    /// <summary>
    /// Formally defined as the set of skos:Concept in concept scheme http://data.europa.eu/eli/ontology#language
    /// <see href="http://data.europa.eu/eli/ontology#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// The intellectual realisation of a legal resource in the form of a "sequence of signs" (typically alpha-numeric characters in a legal context) (definition adapted from RDA)
    /// For example, any version of the legal resource whose content is specified and different from others for any reason: language, versions, etc.;
    ///
    /// Note that ELI ontology accommodates different point of view on what should be considered a new legal resource, or a new legal expression of the same resource. Typically, a consolidated version can be viewed, in the context of ELI, either as separate legal resource (linked to original version and previous consolidated version using corresponding ELI relations), or as a different legal expression of the same legal resource.
    /// <see href="http://data.europa.eu/eli/ontology#LegalExpression"></see></summary>
    let LegalExpression = _prefix "LegalExpression"
    /// <summary>
    /// A component of a legal act, at an arbitrary level of precision, like a chapter, an article, an alinea, a paragraph or an list item. A subdivision can be linked with its parent and children subdivision using the properties eli:has_part / eli:is_part_of.
    /// <see href="http://data.europa.eu/eli/ontology#LegalResourceSubdivision"></see></summary>
    let LegalResourceSubdivision = _prefix "LegalResourceSubdivision"
    /// <summary>
    /// Formally defined as the set of skos:Concept in concept scheme eli:LegalValueTable
    /// <see href="http://data.europa.eu/eli/ontology#LegalValue"></see></summary>
    let LegalValue = _prefix "LegalValue"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#LegalValueTable"></see>
    /// </summary>
    let LegalValueTable = _prefix "LegalValueTable"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#LegalValue-authoritative"></see>
    /// </summary>
    let ``LegalValue-authoritative`` = _prefix "LegalValue-authoritative"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#LegalValue-official"></see>
    /// </summary>
    let ``LegalValue-official`` = _prefix "LegalValue-official"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#LegalValue-definitive"></see>
    /// </summary>
    let ``LegalValue-definitive`` = _prefix "LegalValue-definitive"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#LegalValue-unofficial"></see>
    /// </summary>
    let ``LegalValue-unofficial`` = _prefix "LegalValue-unofficial"
    /// <summary>
    /// Formally defined as the set of skos:Concept in concept scheme eli:ResourceTypeTable
    /// <see href="http://data.europa.eu/eli/ontology#ResourceType"></see></summary>
    let ResourceType = _prefix "ResourceType"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#ResourceTypeTable"></see>
    /// </summary>
    let ResourceTypeTable = _prefix "ResourceTypeTable"
    /// <summary>
    /// Formally defined as the set of skos:Concept in concept scheme eli:VersionTable
    /// <see href="http://data.europa.eu/eli/ontology#Version"></see></summary>
    let Version = _prefix "Version"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#VersionTable"></see>
    /// </summary>
    let VersionTable = _prefix "VersionTable"
    /// <summary>
    /// Inverse of "amends". Indicates a resource that introduced legal changes in this resource. For modifications that don’t have a legal impact, use eli:corrected_by.
    /// <see href="http://data.europa.eu/eli/ontology#amended_by"></see></summary>
    let amended_by = _prefix "amended_by"
    /// <summary>
    /// Inverse of « changes ». Indicates that this legal resource or expression is being legally changed by another. This encompasses the notions of amendment, replacement, repeal, or other types of change.
    /// <see href="http://data.europa.eu/eli/ontology#changed_by"></see></summary>
    let changed_by = _prefix "changed_by"
    /// <summary>
    /// Indicates that this resource introduces legal changes in another resource. For modifications that don’t have a legal impact, use eli:corrects.
    /// <see href="http://data.europa.eu/eli/ontology#amends"></see></summary>
    let amends = _prefix "amends"
    /// <summary>
    /// Indicates that this legal resource or expression legally changes another. This encompasses the notions of amendment, replacement, repeal, or other types of change. This may be a direct change (textual or non-textual amendment) or a consequential or indirect change. Note, the property is to be used to express the existence of a change relationship between two acts rather than the existence of a consolidated version of the text that shows the result of the change. For consolidation relationships, use the "consolidates" and "consolidated_by" properties.
    /// <see href="http://data.europa.eu/eli/ontology#changes"></see></summary>
    let changes = _prefix "changes"
    /// <summary>
    /// Inverse of "applies".
    ///
    /// Note that this property is expressed on a legal resource, not on one of its language-specific legal expression.
    /// <see href="http://data.europa.eu/eli/ontology#applied_by"></see></summary>
    let applied_by = _prefix "applied_by"
    /// <summary>
    /// Indicates that a property is, in a generic sense, a more specific property of another one. This does not entail the same logical reasoning as rdfs:subPropertyOf.
    /// This is used to indicate the alignement to DublinCore properties, without redeclaring the DublinCore property in Protégé, and without commiting to choose that a DubinCore property is either a datatype or an object property.
    /// <see href="http://data.europa.eu/eli/ontology#specificPropertyOf"></see></summary>
    let specificPropertyOf = _prefix "specificPropertyOf"
    /// <summary>
    /// Inverse of "transposes".
    ///
    /// Note that this property is expressed on a legal resource, not on one of its language-specific legal expression.
    /// <see href="http://data.europa.eu/eli/ontology#transposed_by"></see></summary>
    let transposed_by = _prefix "transposed_by"
    /// <summary>
    /// This property is deprecated. Use "applied_by" instead.
    /// <see href="http://data.europa.eu/eli/ontology#implemented_by"></see></summary>
    let implemented_by = _prefix "implemented_by"
    /// <summary>
    /// Indicates that this legislation (or part of a legislation) somehow conforms with another legislation. This is an informative link, and it has no legal value. For legally-binding links of transposition, use the property transposes. This can be used for example :
    ///   - when a pre-existing law already conforms to a recent european directive (in that case it does not "transposes" it strictly speaking);
    ///   - when non-EU member states make sure their legislation is conformant with EU law without strictly speaking transposing it;
    ///   - when a legislation from a local authority conforms with a national legislation;
    ///
    /// Note that this should point to a LegalResource, not to a language-specific expression.
    /// <see href="http://data.europa.eu/eli/ontology#applies"></see></summary>
    let applies = _prefix "applies"
    /// <summary>
    /// Indicates that this legislation (or part of legislation) fulfills the objectives set by another legislation, by passing appropriate implementation measures. Typically, some legislations of European Union's member states or regions transpose European Directives. This indicates a legally binding link between the 2 legislations, at act or article level, from the original version of a national implementing measure to the legal resource Directive as published in the EU Official Journal. Can be used for transposition tables, once EU Publication Office has introduced ELI support down to the article level.
    ///
    /// Note that this should point to the legal resource of the Directive itself, not to one of its language-specific legal expression.
    /// <see href="http://data.europa.eu/eli/ontology#transposes"></see></summary>
    let transposes = _prefix "transposes"
    /// <summary>
    /// This property is deprecated. Use "applies" instead.
    /// <see href="http://data.europa.eu/eli/ontology#implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// Inverse of "basis_for". Indicates that this legal resource is empowered by another one, typically a constitution, a treaty or an enabling act.
    /// <see href="http://data.europa.eu/eli/ontology#based_on"></see></summary>
    let based_on = _prefix "based_on"
    /// <summary>
    /// Indicates that this legal resource or expression empowers another . Typically primary legislation is the basis for secondary legislation.
    /// <see href="http://data.europa.eu/eli/ontology#basis_for"></see></summary>
    let basis_for = _prefix "basis_for"
    /// <summary>
    /// Inverse of "cites"
    /// <see href="http://data.europa.eu/eli/ontology#cited_by"></see></summary>
    let cited_by = _prefix "cited_by"
    /// <summary>
    /// Citation in the text of the legislation. This may be at the legal resource or legal expression level, as required by the implementation context. This includes verbatim citation and citations in referrals.
    /// <see href="http://data.europa.eu/eli/ontology#cites"></see></summary>
    let cites = _prefix "cites"
    /// <summary>
    /// Inverse of "commences". Indicates that this legal resource was set in force by another legal resource.
    /// Situations where a resource enters into force because of more than one resource are explicitely allowed.
    /// <see href="http://data.europa.eu/eli/ontology#commenced_by"></see></summary>
    let commenced_by = _prefix "commenced_by"
    /// <summary>
    /// Indicates that this legal resource sets another legal resource into force.
    /// Note the the date of entry into force of the other resource should be modified accordingly.
    /// Note also that it is not possible to indicate when the entry into force should happen.
    /// <see href="http://data.europa.eu/eli/ontology#commences"></see></summary>
    let commences = _prefix "commences"
    /// <summary>
    /// Inverse of "consolidates". Indicates that this legal resource or expression is taken into account in a consolidated text (which is usually the product of an editorial process that revises the legislation).
    /// <see href="http://data.europa.eu/eli/ontology#consolidated_by"></see></summary>
    let consolidated_by = _prefix "consolidated_by"
    /// <summary>
    /// Indicates that this consolidated legal resource or expression (which is usually the product of an editorial process that revises the legislation) takes into account another one. This property should be used multiple times to refer to both the original version or the previous consolidated version, and to the legislations making the change.
    /// <see href="http://data.europa.eu/eli/ontology#consolidates"></see></summary>
    let consolidates = _prefix "consolidates"
    /// <summary>
    /// Inverse of "corrects". Indicates a resource that introduces textual modifications (like correction of spelling mistakes) with no legal change in this resource, expression or format; typically corrigenda in EU legislation. For modifications that have a legal impact, use eli:amended_by.
    /// <see href="http://data.europa.eu/eli/ontology#corrected_by"></see></summary>
    let corrected_by = _prefix "corrected_by"
    /// <summary>
    /// Indicates that this resource introduces textual modifications (like correction of spelling mistakes) with no legal change in another resource, expression or format; typically corrigenda in EU legislation. For modifications that have a legal impact, use eli:amends.
    /// <see href="http://data.europa.eu/eli/ontology#corrects"></see></summary>
    let corrects = _prefix "corrects"
    /// <summary>
    /// The date at which the legislation becomes applicable. This is distinct from the date of entry into force : a text may come in force today, and state it will become applicable in 3 months.
    ///
    /// The group notes that applicability dates can lead to complex situations, e.g. a text with different applicability dates for different jurisdictions; specific extensions to the model should be used for such situations.
    /// <see href="http://data.europa.eu/eli/ontology#date_applicability"></see></summary>
    let date_applicability = _prefix "date_applicability"
    /// <summary>
    /// Date of adoption or signature (of the form yyyy-mm-dd)
    /// <see href="http://data.europa.eu/eli/ontology#date_document"></see></summary>
    let date_document = _prefix "date_document"
    /// <summary>
    /// The last date any part of the legislation cease to be in force, if the date is known (can be seen as the end date of a dc:valid range for this resource).
    /// <see href="http://data.europa.eu/eli/ontology#date_no_longer_in_force"></see></summary>
    let date_no_longer_in_force = _prefix "date_no_longer_in_force"
    /// <summary>
    /// The first date any part of the legal resource or legal expression came into force (can be seen as the start date of a dc:valid range for this resource)
    /// <see href="http://data.europa.eu/eli/ontology#first_date_entry_in_force"></see></summary>
    let first_date_entry_in_force = _prefix "first_date_entry_in_force"
    /// <summary>
    /// Date of publication of the official version of the legislation, in hard copy or online, depending on what the official publication is, and when it was published. Publication dates at the level of legal expressions can be separately asserted, using standard Dublin Core properties.
    /// <see href="http://data.europa.eu/eli/ontology#date_publication"></see></summary>
    let date_publication = _prefix "date_publication"
    /// <summary>
    /// An account of the resource (definition from Dubin Core), e.g a summary.
    /// <see href="http://data.europa.eu/eli/ontology#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Relates a physical format to the legal expression embodied in that format (definition adapted from RDA). Inverse of "is_embodied_by".
    /// <see href="http://data.europa.eu/eli/ontology#embodies"></see></summary>
    let embodies = _prefix "embodies"
    /// <summary>
    /// Relates a legal expression to a physical format of that expression (definition adapted from RDA). Inverse of "embodies".
    /// <see href="http://data.europa.eu/eli/ontology#is_embodied_by"></see></summary>
    let is_embodied_by = _prefix "is_embodied_by"
    /// <summary>
    /// Inverse of "is_another_publication_of".
    /// <see href="http://data.europa.eu/eli/ontology#has_another_publication"></see></summary>
    let has_another_publication = _prefix "has_another_publication"
    /// <summary>
    /// Indicates that this resource is a new publication, in a different official journal, of another resource already published elsewhere, and cannot be considered to be the same resource (owl:sameAs cannot be used to avoid potential duplication of certain metadata, like the date of publication, or the publisher).
    ///
    /// Note that this is different from the exceptionnal cases of "republication", where the same resource is actually republished in the same official journal a few days after its initial publication, in case of errors.
    /// <see href="http://data.europa.eu/eli/ontology#is_another_publication_of"></see></summary>
    let is_another_publication_of = _prefix "is_another_publication_of"
    /// <summary>
    /// Indicates that this resource conceptually includes another one. For the notion of physical inclusion, use eli:has_part.
    /// <see href="http://data.europa.eu/eli/ontology#has_member"></see></summary>
    let has_member = _prefix "has_member"
    /// <summary>
    /// Indicates that this resource is conceptually included in another one. Typically the successive temporal versions of a given legislation are conceptually members of a single « abstract » resource. For the notion of physical inclusion, use eli:is_part_of.
    /// <see href="http://data.europa.eu/eli/ontology#is_member_of"></see></summary>
    let is_member_of = _prefix "is_member_of"
    /// <summary>
    /// inverse of "is_part_of"
    /// <see href="http://data.europa.eu/eli/ontology#has_part"></see></summary>
    let has_part = _prefix "has_part"
    /// <summary>
    /// A related resource in which the described resource is physically included. Covers the case of text included in an Official Journal, or an article included in a text. For the notion of conceptual/temporal inclusion, use eli:is_member_of.
    /// <see href="http://data.europa.eu/eli/ontology#is_part_of"></see></summary>
    let is_part_of = _prefix "is_part_of"
    /// <summary>
    /// The unique identifier used in a local reference system to maintain backwards compatibility. For examples the CELEX at EU level, or the NOR in France.
    /// <see href="http://data.europa.eu/eli/ontology#id_local"></see></summary>
    let id_local = _prefix "id_local"
    /// <summary>
    /// A value indicating the legal force of a legal resource or a legal expression. A set of values is defined by ELI in the corresponding concept scheme. These values are :
    ///   - in force
    ///   - partially in force
    ///   - not in force
    /// <see href="http://data.europa.eu/eli/ontology#in_force"></see></summary>
    let in_force = _prefix "in_force"
    /// <summary>
    ///   <see href="http://data.europa.eu/eli/ontology#originalName"></see>
    /// </summary>
    let originalName = _prefix "originalName"
    /// <summary>
    /// A subject for this legal resource. The use of Eurovoc (http://eurovoc.europa.eu) is encouraged to select values for this property. Member states are encouraged to align local values to Eurovoc.
    /// <see href="http://data.europa.eu/eli/ontology#is_about"></see></summary>
    let is_about = _prefix "is_about"
    /// <summary>
    /// Link to a concrete file URL.
    /// Relates a format to a single exemplar or instance of that format (definition adapted from RDA).
    /// <see href="http://data.europa.eu/eli/ontology#is_exemplified_by"></see></summary>
    let is_exemplified_by = _prefix "is_exemplified_by"
    /// <summary>
    /// Relates a legal resource to a legal expression of this resource in the form of a "sequence of signs" (typically alpha-numeric characters in a legal context). (definition adapted from RDA). Inverse of "realizes".
    /// <see href="http://data.europa.eu/eli/ontology#is_realized_by"></see></summary>
    let is_realized_by = _prefix "is_realized_by"
    /// <summary>
    /// Relates a legal expression to the legal resource realised through that expression. (definition adapted from RDA). Inverse of "is_realized_by".
    /// <see href="http://data.europa.eu/eli/ontology#realizes"></see></summary>
    let realizes = _prefix "realizes"
    /// <summary>
    /// The jurisdiction from which the legal resource originates.
    ///
    /// The place identifier can be taken from the Administrative Territorial Unit table published of the EU Publications Office at http://publications.europa.eu/mdr/authority/atu. Member States don't have to recreate their own list of values.
    /// <see href="http://data.europa.eu/eli/ontology#jurisdiction"></see></summary>
    let jurisdiction = _prefix "jurisdiction"
    /// <summary>
    /// Refers to a place or an area associated with the resource. This covers the notions of jurisdiction, sovereignty, applicability or administrative area. The place identifier can be taken from the Administrative Territorial Unit table published of the EU Publications Office at http://publications.europa.eu/mdr/authority/atu. Member States don't have to recreate their own list of values.
    ///
    /// The group notes the limitations of what can be said with a single property; member states can refine this notion by declaring specific sub properties.
    /// <see href="http://data.europa.eu/eli/ontology#relevant_for"></see></summary>
    let relevant_for = _prefix "relevant_for"
    /// <summary>
    /// The language of an expression.
    ///
    /// EU Publications Office provides a list of languages at http://publications.europa.eu/mdr/authority/language. This list is large enough so that member states should not have to declare local values.
    ///
    /// Note that, if needed, a language can also be stated on a legal resource using the DublinCore "language" property.
    /// <see href="http://data.europa.eu/eli/ontology#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// The legal value associated with a specific format of a resource. A set of values is defined by ELI in the corresponding concept scheme. These values are :
    ///   - unofficial : no particular or special standing;
    ///   - official : published by an organisation with the public task of making the information available (e.g. a consolidated version of a EU directive) ;
    ///   - authoritative : the publisher gives some special status to the publication (e.g. "the Queens Printer" version of an Act of Parliament, or the OJ version of a EU Directive);
    ///   - definitive : the text is conclusively what the law says, (e.g. the digitally signed version of an OJ).
    /// <see href="http://data.europa.eu/eli/ontology#legal_value"></see></summary>
    let legal_value = _prefix "legal_value"
    /// <summary>
    /// A legal document giving official permission to do something with the resource (Definition from Dublin Core)
    /// <see href="http://data.europa.eu/eli/ontology#licence"></see></summary>
    let licence = _prefix "licence"
    /// <summary>
    /// An identifier or other disambiguating feature for a legal resource or legal expression. This can be the number of a legislation, the number of an article, or the issue number of an official journal.
    /// <see href="http://data.europa.eu/eli/ontology#number"></see></summary>
    let number = _prefix "number"
    /// <summary>
    /// The person or organization that originally passed or made the law : typically parliament (for primary legislation) or government (for secondary legislation). This indicates the "legal author" of the law, as opposed to its physical author.
    ///
    /// This property can be used multiple times to indicate both the agent that authored the text, and/or the agent that signed the text, thus turning it into an actual legislation.
    ///
    /// The relationship between current and any former law making body should be represented in the description of the agent itself.
    ///
    /// Member states are encouraged to make their own list of Agents. EU Publications Office provides a list of corporate bodies at http://publications.europa.eu/mdr/authority/corporate-body.
    /// <see href="http://data.europa.eu/eli/ontology#passed_by"></see></summary>
    let passed_by = _prefix "passed_by"
    /// <summary>
    /// Reference to the Official Journal or other publication manifestation in which this format is published.
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "published_in_format" should be used.
    /// <see href="http://data.europa.eu/eli/ontology#published_in"></see></summary>
    let published_in = _prefix "published_in"
    /// <summary>
    /// Reference to the Official Journal or other publication manifestation in which this format is published.
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "published_in" should be used with a string value.
    /// <see href="http://data.europa.eu/eli/ontology#published_in_format"></see></summary>
    let published_in_format = _prefix "published_in_format"
    /// <summary>
    /// Inverse of "published_in_format". Note this property does not link a publisher with a resource, but rather a specific Format of a resource with a specific Format of another resource, indicating that the subject Format publishes the object Format.
    /// <see href="http://data.europa.eu/eli/ontology#publishes"></see></summary>
    let publishes = _prefix "publishes"
    /// <summary>
    /// An entity responsible for making the resource available (definition from Dublin Core).
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "publisher_agent" should be used.
    /// <see href="http://data.europa.eu/eli/ontology#publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// An entity responsible for making the resource available (definition from Dublin Core).
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "publisher" should be used with a string value.
    /// <see href="http://data.europa.eu/eli/ontology#publisher_agent"></see></summary>
    let publisher_agent = _prefix "publisher_agent"
    /// <summary>
    /// Indicates a somehow related other document, not necessarily a legal resource. Note that citation links should use the cites property.
    /// <see href="http://data.europa.eu/eli/ontology#related_to"></see></summary>
    let related_to = _prefix "related_to"
    /// <summary>
    /// Inverse of "repeals". Indicates that this legal resource or legal expression is being completely canceled, abrogated or replaced by another legal resource. If a resource is partially repealed by another, this link can be used at the corresponding subdivision level being completely repealed.
    /// <see href="http://data.europa.eu/eli/ontology#repealed_by"></see></summary>
    let repealed_by = _prefix "repealed_by"
    /// <summary>
    /// Indicates that this legal resource or legal expression completely cancels, abrogates or replaces another. If a resource partially repeals another, this link can be used at the corresponding subdivision level being completely repealed.
    /// <see href="http://data.europa.eu/eli/ontology#repeals"></see></summary>
    let repeals = _prefix "repeals"
    /// <summary>
    /// An individual, organisation or organisational unit that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "responsibility_of_agent" should be used.
    /// <see href="http://data.europa.eu/eli/ontology#responsibility_of"></see></summary>
    let responsibility_of = _prefix "responsibility_of"
    /// <summary>
    /// An individual, organisation or organisational unit that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "responsibility_of" should be used with a string value.
    /// <see href="http://data.europa.eu/eli/ontology#responsibility_of_agent"></see></summary>
    let responsibility_of_agent = _prefix "responsibility_of_agent"
    /// <summary>
    /// Information about rights held in and over the resource (definition from Dublin Core). For example, that property can be used to provide a link to a page that describes the licensing terms.
    /// <see href="http://data.europa.eu/eli/ontology#rights"></see></summary>
    let rights = _prefix "rights"
    /// <summary>
    /// A person or organisation owning or managing rights over the resource (definition from Dublin Core).
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "rightsholder_agent" should be used.
    /// <see href="http://data.europa.eu/eli/ontology#rightsholder"></see></summary>
    let rightsholder = _prefix "rightsholder"
    /// <summary>
    /// A person or organisation owning or managing rights over the resource (definition from Dublin Core).
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "rightsholder" should be used with a string value.
    /// <see href="http://data.europa.eu/eli/ontology#rightsholder_agent"></see></summary>
    let rightsholder_agent = _prefix "rightsholder_agent"
    /// <summary>
    /// The title, or name, of an expression.
    ///
    /// Note that, if needed, a title can also be stated on a legal resource using the Dublin Core "title" property.
    /// <see href="http://data.europa.eu/eli/ontology#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Established short title of the expression (if any)
    /// <see href="http://data.europa.eu/eli/ontology#title_short"></see></summary>
    let title_short = _prefix "title_short"
    /// <summary>
    /// An alternative title of the expression (if any).
    ///
    /// Note that, if needed, an alternative title can also be stated on a legal resource using the Dublin Core "alternative" property.
    /// <see href="http://data.europa.eu/eli/ontology#title_alternative"></see></summary>
    let title_alternative = _prefix "title_alternative"
    /// <summary>
    /// The type of a legal resource (e.g. "Directive", "Règlement grand ducal", "law", "règlement ministeriel", "draft proposition", "Parliamentary act", etc.).
    /// Member states are encouraged to make their own list of values in the corresponding concept scheme. EU Publications Office provides a list of values for EU resource types at http://publications.europa.eu/mdr/authority/resource-type
    /// <see href="http://data.europa.eu/eli/ontology#type_document"></see></summary>
    let type_document = _prefix "type_document"
    /// <summary>
    /// Schema describing the URI of an ELI instance. ELI uses URI template specifications (IETF RFC 6570). Schemes should be associated with member states and will be published in a registry.
    /// <see href="http://data.europa.eu/eli/ontology#uri_schema"></see></summary>
    let uri_schema = _prefix "uri_schema"
    /// <summary>
    /// A skos concept scheme, could be locally defined? Group proposal is to start with an initial ELI scheme, that might include concepts of "Official Journal" "made" "consolidated" "proposed" "prospective"
    /// <see href="http://data.europa.eu/eli/ontology#version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// The point-in-time at which the provided description of the legislation is valid.
    /// <see href="http://data.europa.eu/eli/ontology#version_date"></see></summary>
    let version_date = _prefix "version_date"
