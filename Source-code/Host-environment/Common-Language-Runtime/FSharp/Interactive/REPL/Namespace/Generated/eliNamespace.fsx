#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module eli =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.europa.eu/eli/ontology#" "eli"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:historyNote : Starting from v1.1, the values for administrative areas can be taken from the Administrative Territorial Unit table published of the EU Publications Office.</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Administrative Area</para>
    ///   <para>rdfs:comment : Formally defined as the set of skos:Concept either in concept scheme eli:AdministrativeAreaTable or in concept scheme http://publications.europa.eu/mdr/authority/atu (Administrative Territorial Unit table published of the EU Publications Office).</para>
    ///   <a href="http://data.europa.eu/eli/ontology#AdministrativeArea">eli:AdministrativeArea</a>
    /// </summary>
    let AdministrativeArea = _prefixId.prefix "AdministrativeArea"
    let AdministrativeAreaTable = _prefixId.prefix "AdministrativeAreaTable"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://data.europa.eu/eli/ontology#Agent">eli:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Format</para>
    ///   <para>rdfs:comment : The physical embodiment of a legal expression, either on paper or in any electronic format (definition adapted from RDA).
    /// For example, any electronic or physical format of the legal expression (XML, TIFF, PDF, etc.) ; e.g. PDF version of act 3 of 2005.  (adapted from Akoma Ntoso)</para>
    ///   <a href="http://data.europa.eu/eli/ontology#Format">eli:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : In force</para>
    ///   <para>rdfs:comment : Formally defined as the set of skos:Concept in concept scheme eli:InForceTable</para>
    ///   <a href="http://data.europa.eu/eli/ontology#InForce">eli:InForce</a>
    /// </summary>
    let InForce = _prefixId.prefix "InForce"
    let InForce_inForce = _prefixId.prefix "InForce-inForce"
    let InForce_notInForce = _prefixId.prefix "InForce-notInForce"
    let InForce_partiallyInForce = _prefixId.prefix "InForce-partiallyInForce"
    let InForceTable = _prefixId.prefix "InForceTable"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : Formally defined as the set of skos:Concept in concept scheme http://data.europa.eu/eli/ontology#language</para>
    ///   <a href="http://data.europa.eu/eli/ontology#Language">eli:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Legal Expression</para>
    ///   <para>rdfs:comment : The intellectual realisation of a legal resource in the form of a "sequence of signs" (typically alpha-numeric characters in a legal context) (definition adapted from RDA)
    /// For example, any version of the legal resource whose content is specified and different from others for any reason: language, versions, etc.;
    ///
    /// Note that ELI ontology accommodates different point of view on what should be considered a new legal resource, or a new legal expression of the same resource. Typically, a consolidated version can be viewed, in the context of ELI, either as separate legal resource (linked to original version and previous consolidated version using corresponding ELI relations), or as a different legal expression of the same legal resource.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#LegalExpression">eli:LegalExpression</a>
    /// </summary>
    let LegalExpression = _prefixId.prefix "LegalExpression"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Legal Resource</para>
    ///   <para>rdfs:comment : A distinct intellectual creation (i.e., the intellectual content). (definition adapted from RDA - Resource Description and Access, see http://www.rdaregistry.info/).
    /// For example, the abstract concept of the legal resource; e.g. "act 3 of 2005" (adapted from Akoma Ntoso)
    ///
    /// Legal resource can be linked together using properties defined in the model.
    /// A legal resource can represent a legal act or any component of a legal act, like an article.
    ///
    /// Note that ELI ontology accommodates different point of view on what should be considered a new legal resource, or a new legal expression of the same resource. Typically, a consolidated version can be viewed, in the context of ELI, either as separate legal resource (linked to original version and previous consolidated version using corresponding ELI relations), or as a different legal expression of the same legal resource.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#LegalResource">eli:LegalResource</a>
    /// </summary>
    let LegalResource = _prefixId.prefix "LegalResource"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : Legal Resource Subdivision</para>
    ///   <para>rdfs:comment : A component of a legal act, at an arbitrary level of precision, like a chapter, an article, an alinea, a paragraph or an list item. A subdivision can be linked with its parent and children subdivision using the properties eli:has_part / eli:is_part_of.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#LegalResourceSubdivision">eli:LegalResourceSubdivision</a>
    /// </summary>
    let LegalResourceSubdivision = _prefixId.prefix "LegalResourceSubdivision"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Legal value</para>
    ///   <para>rdfs:comment : Formally defined as the set of skos:Concept in concept scheme eli:LegalValueTable</para>
    ///   <a href="http://data.europa.eu/eli/ontology#LegalValue">eli:LegalValue</a>
    /// </summary>
    let LegalValue = _prefixId.prefix "LegalValue"
    let LegalValue_authoritative = _prefixId.prefix "LegalValue-authoritative"
    let LegalValue_definitive = _prefixId.prefix "LegalValue-definitive"
    let LegalValue_official = _prefixId.prefix "LegalValue-official"
    let LegalValue_unofficial = _prefixId.prefix "LegalValue-unofficial"
    let LegalValueTable = _prefixId.prefix "LegalValueTable"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Resource type</para>
    ///   <para>rdfs:comment : Formally defined as the set of skos:Concept in concept scheme eli:ResourceTypeTable</para>
    ///   <a href="http://data.europa.eu/eli/ontology#ResourceType">eli:ResourceType</a>
    /// </summary>
    let ResourceType = _prefixId.prefix "ResourceType"
    let ResourceTypeTable = _prefixId.prefix "ResourceTypeTable"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : Version</para>
    ///   <para>rdfs:comment : Formally defined as the set of skos:Concept in concept scheme eli:VersionTable</para>
    ///   <a href="http://data.europa.eu/eli/ontology#Version">eli:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    let VersionTable = _prefixId.prefix "VersionTable"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : amended by</para>
    ///   <para>rdfs:comment : Inverse of "amends". Indicates a resource that introduced legal changes in this resource. For modifications that don’t have a legal impact, use eli:corrected_by.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#amended_by">eli:amended_by</a>
    /// </summary>
    let amended_by = _prefixId.prefix "amended_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : amends</para>
    ///   <para>rdfs:comment : Indicates that this resource introduces legal changes in another resource. For modifications that don’t have a legal impact, use eli:corrects.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#amends">eli:amends</a>
    /// </summary>
    let amends = _prefixId.prefix "amends"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : applied by</para>
    ///   <para>rdfs:comment : Inverse of "applies".
    ///
    /// Note that this property is expressed on a legal resource, not on one of its language-specific legal expression.</para>
    ///   <para>skos:historyNote : v1.1 : this property was deprecated in favor of the more generic term "applied_by" to avoid confusion</para>
    ///   <a href="http://data.europa.eu/eli/ontology#applied_by">eli:applied_by</a>
    /// </summary>
    let applied_by = _prefixId.prefix "applied_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : applies</para>
    ///   <para>rdfs:comment : Indicates that this legislation (or part of a legislation) somehow conforms with another legislation. This is an informative link, and it has no legal value. For legally-binding links of transposition, use the property transposes. This can be used for example :
    ///   - when a pre-existing law already conforms to a recent european directive (in that case it does not "transposes" it strictly speaking);
    ///   - when non-EU member states make sure their legislation is conformant with EU law without strictly speaking transposing it;
    ///   - when a legislation from a local authority conforms with a national legislation;
    ///
    /// Note that this should point to a LegalResource, not to a language-specific expression.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#applies">eli:applies</a>
    /// </summary>
    let applies = _prefixId.prefix "applies"
    /// <summary>
    ///   <para>rdfs:label : based on</para>
    ///   <para>rdfs:comment : Inverse of "basis_for". Indicates that this legal resource is empowered by another one, typically a constitution, a treaty or an enabling act.</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1</para>
    ///   <para>skos:historyNote : v1.1 : improved definition</para>
    ///   <a href="http://data.europa.eu/eli/ontology#based_on">eli:based_on</a>
    /// </summary>
    let based_on = _prefixId.prefix "based_on"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : improved definition</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : basis for</para>
    ///   <para>rdfs:comment : Indicates that this legal resource or expression empowers another . Typically primary legislation is the basis for secondary legislation.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#basis_for">eli:basis_for</a>
    /// </summary>
    let basis_for = _prefixId.prefix "basis_for"
    /// <summary>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>skos:historyNote : v1.1 : improved definition</para>
    ///   <para>rdfs:label : changed by</para>
    ///   <para>rdfs:comment : Inverse of « changes ». Indicates that this legal resource or expression is being legally changed by another. This encompasses the notions of amendment, replacement, repeal, or other types of change.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#changed_by">eli:changed_by</a>
    /// </summary>
    let changed_by = _prefixId.prefix "changed_by"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : improved definition.</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : changes</para>
    ///   <para>rdfs:comment : Indicates that this legal resource or expression legally changes another. This encompasses the notions of amendment, replacement, repeal, or other types of change. This may be a direct change (textual or non-textual amendment) or a consequential or indirect change. Note, the property is to be used to express the existence of a change relationship between two acts rather than the existence of a consolidated version of the text that shows the result of the change. For consolidation relationships, use the "consolidates" and "consolidated_by" properties.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#changes">eli:changes</a>
    /// </summary>
    let changes = _prefixId.prefix "changes"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : cited by</para>
    ///   <para>rdfs:comment : Inverse of "cites"</para>
    ///   <a href="http://data.europa.eu/eli/ontology#cited_by">eli:cited_by</a>
    /// </summary>
    let cited_by = _prefixId.prefix "cited_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : cites</para>
    ///   <para>rdfs:comment : Citation in the text of the legislation. This may be at the legal resource or legal expression level, as required by the implementation context. This includes verbatim citation and citations in referrals.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#cites">eli:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : commenced by</para>
    ///   <para>rdfs:comment : Inverse of "commences". Indicates that this legal resource was set in force by another legal resource.
    /// Situations where a resource enters into force because of more than one resource are explicitely allowed.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#commenced_by">eli:commenced_by</a>
    /// </summary>
    let commenced_by = _prefixId.prefix "commenced_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : commences</para>
    ///   <para>rdfs:comment : Indicates that this legal resource sets another legal resource into force.
    /// Note the the date of entry into force of the other resource should be modified accordingly.
    /// Note also that it is not possible to indicate when the entry into force should happen.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#commences">eli:commences</a>
    /// </summary>
    let commences = _prefixId.prefix "commences"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : improved definition</para>
    ///   <para>rdfs:comment : Inverse of "consolidates". Indicates that this legal resource or expression is taken into account in a consolidated text (which is usually the product of an editorial process that revises the legislation).</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1</para>
    ///   <para>rdfs:label : consolidated by</para>
    ///   <a href="http://data.europa.eu/eli/ontology#consolidated_by">eli:consolidated_by</a>
    /// </summary>
    let consolidated_by = _prefixId.prefix "consolidated_by"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : improved definition</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : consolidates</para>
    ///   <para>rdfs:comment : Indicates that this consolidated legal resource or expression (which is usually the product of an editorial process that revises the legislation) takes into account another one. This property should be used multiple times to refer to both the original version or the previous consolidated version, and to the legislations making the change.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#consolidates">eli:consolidates</a>
    /// </summary>
    let consolidates = _prefixId.prefix "consolidates"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : corrected by</para>
    ///   <para>rdfs:comment : Inverse of "corrects". Indicates a resource that introduces textual modifications (like correction of spelling mistakes) with no legal change in this resource, expression or format; typically corrigenda in EU legislation. For modifications that have a legal impact, use eli:amended_by.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#corrected_by">eli:corrected_by</a>
    /// </summary>
    let corrected_by = _prefixId.prefix "corrected_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : corrects</para>
    ///   <para>rdfs:comment : Indicates that this resource introduces textual modifications (like correction of spelling mistakes) with no legal change in another resource, expression or format; typically corrigenda in EU legislation. For modifications that have a legal impact, use eli:amends.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#corrects">eli:corrects</a>
    /// </summary>
    let corrects = _prefixId.prefix "corrects"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : date of applicability</para>
    ///   <para>rdfs:comment : The date at which the legislation becomes applicable. This is distinct from the date of entry into force : a text may come in force today, and state it will become applicable in 3 months.
    ///
    /// The group notes that applicability dates can lead to complex situations, e.g. a text with different applicability dates for different jurisdictions; specific extensions to the model should be used for such situations.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#date_applicability">eli:date_applicability</a>
    /// </summary>
    let date_applicability = _prefixId.prefix "date_applicability"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : date of the document</para>
    ///   <para>rdfs:comment : Date of adoption or signature (of the form yyyy-mm-dd)</para>
    ///   <a href="http://data.europa.eu/eli/ontology#date_document">eli:date_document</a>
    /// </summary>
    let date_document = _prefixId.prefix "date_document"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1</para>
    ///   <para>skos:historyNote : v1.1 : improved definition so it symmetric to date_entry_into_force.</para>
    ///   <para>rdfs:label : date no longer in force</para>
    ///   <para>rdfs:comment : The last date any part of the legislation cease to be in force, if the date is known (can be seen as the end date of a dc:valid range for this resource).</para>
    ///   <a href="http://data.europa.eu/eli/ontology#date_no_longer_in_force">eli:date_no_longer_in_force</a>
    /// </summary>
    let date_no_longer_in_force = _prefixId.prefix "date_no_longer_in_force"
    /// <summary>
    ///   <para>rdfs:label : date of publication</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>skos:historyNote : In v1.1, the domain was broaden to add LegalExpression.</para>
    ///   <para>rdfs:comment : Date of publication of the official version of the legislation, in hard copy or online, depending on what the official publication is, and when it was published. Publication dates at the level of legal expressions can be separately asserted, using standard Dublin Core properties.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#date_publication">eli:date_publication</a>
    /// </summary>
    let date_publication = _prefixId.prefix "date_publication"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : An account of the resource (definition from Dubin Core), e.g a summary.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#description">eli:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : embodies</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in 1.1</para>
    ///   <para>rdfs:comment : Relates a physical format to the legal expression embodied in that format (definition adapted from RDA). Inverse of "is_embodied_by".</para>
    ///   <para>skos:historyNote : In v1.1, this was declared functional (the constraint was missing in 1.0)</para>
    ///   <a href="http://data.europa.eu/eli/ontology#embodies">eli:embodies</a>
    /// </summary>
    let embodies = _prefixId.prefix "embodies"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : first date of entry into force</para>
    ///   <para>rdfs:comment : The first date any part of the legal resource or legal expression came into force (can be seen as the start date of a dc:valid range for this resource)</para>
    ///   <a href="http://data.europa.eu/eli/ontology#first_date_entry_in_force">eli:first_date_entry_in_force</a>
    /// </summary>
    let first_date_entry_in_force = _prefixId.prefix "first_date_entry_in_force"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : format</para>
    ///   <para>rdfs:comment : The file format, physical medium, or dimensions of the resource (definition from Dublin Core).
    /// Possible URIs values should be taken from http://www.iana.org/assignments/media-types (e.g. http://www.iana.org/assignments/media-types/application/xml), and can serve as a basis for content negotiation for the server to return the appropriate file based on the client preference.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#format">eli:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : has another publication</para>
    ///   <para>rdfs:comment : Inverse of "is_another_publication_of".</para>
    ///   <a href="http://data.europa.eu/eli/ontology#has_another_publication">eli:has_another_publication</a>
    /// </summary>
    let has_another_publication = _prefixId.prefix "has_another_publication"
    /// <summary>
    ///   <para>rdfs:label : has member</para>
    ///   <para>rdfs:comment : Indicates that this resource conceptually includes another one. For the notion of physical inclusion, use eli:has_part.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#has_member">eli:has_member</a>
    /// </summary>
    let has_member = _prefixId.prefix "has_member"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : has part</para>
    ///   <para>rdfs:comment : inverse of "is_part_of"</para>
    ///   <a href="http://data.europa.eu/eli/ontology#has_part">eli:has_part</a>
    /// </summary>
    let has_part = _prefixId.prefix "has_part"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : local id</para>
    ///   <para>rdfs:comment : The unique identifier used in a local reference system to maintain backwards compatibility. For examples the CELEX at EU level, or the NOR in France.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#id_local">eli:id_local</a>
    /// </summary>
    let id_local = _prefixId.prefix "id_local"
    /// <summary>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : implemented by</para>
    ///   <para>rdfs:comment : This property is deprecated. Use "applied_by" instead.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#implemented_by">eli:implemented_by</a>
    /// </summary>
    let implemented_by = _prefixId.prefix "implemented_by"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : this property was deprecated in favor of the more generic term "applies" to avoid confusion.</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : implements</para>
    ///   <para>rdfs:comment : This property is deprecated. Use "applies" instead.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#implements">eli:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:label : in force</para>
    ///   <para>rdfs:comment : A value indicating the legal force of a legal resource or a legal expression. A set of values is defined by ELI in the corresponding concept scheme. These values are :
    ///   - in force
    ///   - partially in force
    ///   - not in force</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>eli:originalName : status</para>
    ///   <a href="http://data.europa.eu/eli/ontology#in_force">eli:in_force</a>
    /// </summary>
    let in_force = _prefixId.prefix "in_force"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : is about</para>
    ///   <para>rdfs:comment : A subject for this legal resource. The use of Eurovoc (http://eurovoc.europa.eu) is encouraged to select values for this property. Member states are encouraged to align local values to Eurovoc.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#is_about">eli:is_about</a>
    /// </summary>
    let is_about = _prefixId.prefix "is_about"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : is another publication of</para>
    ///   <para>rdfs:comment : Indicates that this resource is a new publication, in a different official journal, of another resource already published elsewhere, and cannot be considered to be the same resource (owl:sameAs cannot be used to avoid potential duplication of certain metadata, like the date of publication, or the publisher).
    ///
    /// Note that this is different from the exceptionnal cases of "republication", where the same resource is actually republished in the same official journal a few days after its initial publication, in case of errors.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#is_another_publication_of">eli:is_another_publication_of</a>
    /// </summary>
    let is_another_publication_of = _prefixId.prefix "is_another_publication_of"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : is embodied by</para>
    ///   <para>rdfs:comment : Relates a legal expression to a physical format of that expression (definition adapted from RDA). Inverse of "embodies".</para>
    ///   <a href="http://data.europa.eu/eli/ontology#is_embodied_by">eli:is_embodied_by</a>
    /// </summary>
    let is_embodied_by = _prefixId.prefix "is_embodied_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : is exemplified by</para>
    ///   <para>rdfs:comment : Link to a concrete file URL.
    /// Relates a format to a single exemplar or instance of that format (definition adapted from RDA). </para>
    ///   <a href="http://data.europa.eu/eli/ontology#is_exemplified_by">eli:is_exemplified_by</a>
    /// </summary>
    let is_exemplified_by = _prefixId.prefix "is_exemplified_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : is member of</para>
    ///   <para>rdfs:comment : Indicates that this resource is conceptually included in another one. Typically the successive temporal versions of a given legislation are conceptually members of a single « abstract » resource. For the notion of physical inclusion, use eli:is_part_of.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#is_member_of">eli:is_member_of</a>
    /// </summary>
    let is_member_of = _prefixId.prefix "is_member_of"
    /// <summary>
    ///   <para>skos:historyNote : Starting with v1.1, the notion of conceptual inclusion is expressed with eli:is_member_of instead of eli:is_part_of.</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1^^xsd:string</para>
    ///   <para>rdfs:comment : A related resource in which the described resource is physically included. Covers the case of text included in an Official Journal, or an article included in a text. For the notion of conceptual/temporal inclusion, use eli:is_member_of.</para>
    ///   <para>rdfs:label : is part of</para>
    ///   <para>eli:originalName : composed</para>
    ///   <a href="http://data.europa.eu/eli/ontology#is_part_of">eli:is_part_of</a>
    /// </summary>
    let is_part_of = _prefixId.prefix "is_part_of"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : is realized by</para>
    ///   <para>rdfs:comment : Relates a legal resource to a legal expression of this resource in the form of a "sequence of signs" (typically alpha-numeric characters in a legal context). (definition adapted from RDA). Inverse of "realizes".</para>
    ///   <a href="http://data.europa.eu/eli/ontology#is_realized_by">eli:is_realized_by</a>
    /// </summary>
    let is_realized_by = _prefixId.prefix "is_realized_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : jurisdiction</para>
    ///   <para>rdfs:comment : The jurisdiction from which the legal resource originates.
    ///
    /// The place identifier can be taken from the Administrative Territorial Unit table published of the EU Publications Office at http://publications.europa.eu/mdr/authority/atu. Member States don't have to recreate their own list of values.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#jurisdiction">eli:jurisdiction</a>
    /// </summary>
    let jurisdiction = _prefixId.prefix "jurisdiction"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : language</para>
    ///   <para>rdfs:comment : The language of an expression.
    ///
    /// EU Publications Office provides a list of languages at http://publications.europa.eu/mdr/authority/language. This list is large enough so that member states should not have to declare local values.
    ///
    /// Note that, if needed, a language can also be stated on a legal resource using the DublinCore "language" property.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#language">eli:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : The legal value associated with a specific format of a resource. A set of values is defined by ELI in the corresponding concept scheme. These values are :
    ///   - unofficial : no particular or special standing;
    ///   - official : published by an organisation with the public task of making the information available (e.g. a consolidated version of a EU directive) ;
    ///   - authoritative : the publisher gives some special status to the publication (e.g. "the Queens Printer" version of an Act of Parliament, or the OJ version of a EU Directive);
    ///   - definitive : the text is conclusively what the law says, (e.g. the digitally signed version of an OJ).</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : legal value</para>
    ///   <a href="http://data.europa.eu/eli/ontology#legal_value">eli:legal_value</a>
    /// </summary>
    let legal_value = _prefixId.prefix "legal_value"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : licence</para>
    ///   <para>rdfs:comment : A legal document giving official permission to do something with the resource (Definition from Dublin Core)</para>
    ///   <a href="http://data.europa.eu/eli/ontology#licence">eli:licence</a>
    /// </summary>
    let licence = _prefixId.prefix "licence"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : number</para>
    ///   <para>rdfs:comment : An identifier or other disambiguating feature for a legal resource or legal expression. This can be the number of a legislation, the number of an article, or the issue number of an official journal.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#number">eli:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    let originalName = _prefixId.prefix "originalName"
    /// <summary>
    ///   <para>eli:originalName : agent_document</para>
    ///   <para>rdfs:label : passed by</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1</para>
    ///   <para>rdfs:comment : The person or organization that originally passed or made the law : typically parliament (for primary legislation) or government (for secondary legislation). This indicates the "legal author" of the law, as opposed to its physical author.
    ///
    /// This property can be used multiple times to indicate both the agent that authored the text, and/or the agent that signed the text, thus turning it into an actual legislation.
    ///
    /// The relationship between current and any former law making body should be represented in the description of the agent itself.
    ///
    /// Member states are encouraged to make their own list of Agents. EU Publications Office provides a list of corporate bodies at http://publications.europa.eu/mdr/authority/corporate-body.</para>
    ///   <para>skos:historyNote : In v1.1, the semantic of this property was broaden to encompass organisations/persons that « drafted the text » and « signed it ».</para>
    ///   <a href="http://data.europa.eu/eli/ontology#passed_by">eli:passed_by</a>
    /// </summary>
    let passed_by = _prefixId.prefix "passed_by"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : modified the range to xsd:string, and introduced the corresponding object property published_in_format.</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : published in</para>
    ///   <para>rdfs:comment : Reference to the Official Journal or other publication manifestation in which this format is published.
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "published_in_format" should be used.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#published_in">eli:published_in</a>
    /// </summary>
    let published_in = _prefixId.prefix "published_in"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : published in format</para>
    ///   <para>rdfs:comment : Reference to the Official Journal or other publication manifestation in which this format is published.
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "published_in" should be used with a string value.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#published_in_format">eli:published_in_format</a>
    /// </summary>
    let published_in_format = _prefixId.prefix "published_in_format"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : modified the range to xsd:string and introduced the corresponding object property publisher_agent.</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource available (definition from Dublin Core).
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "publisher_agent" should be used.</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1</para>
    ///   <para>rdfs:label : publisher</para>
    ///   <a href="http://data.europa.eu/eli/ontology#publisher">eli:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : publisher agent</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource available (definition from Dublin Core).
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "publisher" should be used with a string value.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#publisher_agent">eli:publisher_agent</a>
    /// </summary>
    let publisher_agent = _prefixId.prefix "publisher_agent"
    /// <summary>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : publishes</para>
    ///   <para>rdfs:comment : Inverse of "published_in_format". Note this property does not link a publisher with a resource, but rather a specific Format of a resource with a specific Format of another resource, indicating that the subject Format publishes the object Format.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#publishes">eli:publishes</a>
    /// </summary>
    let publishes = _prefixId.prefix "publishes"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : realizes</para>
    ///   <para>rdfs:comment : Relates a legal expression to the legal resource realised through that expression. (definition adapted from RDA). Inverse of "is_realized_by".</para>
    ///   <a href="http://data.europa.eu/eli/ontology#realizes">eli:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : related to</para>
    ///   <para>rdfs:comment : Indicates a somehow related other document, not necessarily a legal resource. Note that citation links should use the cites property.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#related_to">eli:related_to</a>
    /// </summary>
    let related_to = _prefixId.prefix "related_to"
    /// <summary>
    ///   <para>skos:historyNote : Starting from v1.1, the values for this property can be taken from the named authority list published by the Office of Publications instead of defining new values.</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : relevant for</para>
    ///   <para>rdfs:comment : Refers to a place or an area associated with the resource. This covers the notions of jurisdiction, sovereignty, applicability or administrative area. The place identifier can be taken from the Administrative Territorial Unit table published of the EU Publications Office at http://publications.europa.eu/mdr/authority/atu. Member States don't have to recreate their own list of values.
    ///
    /// The group notes the limitations of what can be said with a single property; member states can refine this notion by declaring specific sub properties.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#relevant_for">eli:relevant_for</a>
    /// </summary>
    let relevant_for = _prefixId.prefix "relevant_for"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : repealed by</para>
    ///   <para>rdfs:comment : Inverse of "repeals". Indicates that this legal resource or legal expression is being completely canceled, abrogated or replaced by another legal resource. If a resource is partially repealed by another, this link can be used at the corresponding subdivision level being completely repealed.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#repealed_by">eli:repealed_by</a>
    /// </summary>
    let repealed_by = _prefixId.prefix "repealed_by"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : repeals</para>
    ///   <para>rdfs:comment : Indicates that this legal resource or legal expression completely cancels, abrogates or replaces another. If a resource partially repeals another, this link can be used at the corresponding subdivision level being completely repealed.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#repeals">eli:repeals</a>
    /// </summary>
    let repeals = _prefixId.prefix "repeals"
    /// <summary>
    ///   <para>rdfs:label : responsibility of</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1</para>
    ///   <para>skos:historyNote : v1.1 : the definition was made more precise, with examples. Introduced the corresponding object property responsibility_of_agent.</para>
    ///   <para>eli:originalName : service</para>
    ///   <para>rdfs:comment : An individual, organisation or organisational unit that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "responsibility_of_agent" should be used.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#responsibility_of">eli:responsibility_of</a>
    /// </summary>
    let responsibility_of = _prefixId.prefix "responsibility_of"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : responsibility of agent</para>
    ///   <para>rdfs:comment : An individual, organisation or organisational unit that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "responsibility_of" should be used with a string value.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#responsibility_of_agent">eli:responsibility_of_agent</a>
    /// </summary>
    let responsibility_of_agent = _prefixId.prefix "responsibility_of_agent"
    /// <summary>
    ///   <para>rdfs:comment : Information about rights held in and over the resource (definition from Dublin Core). For example, that property can be used to provide a link to a page that describes the licensing terms.</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:stringowl:versionInfo : modified in v1.1</para>
    ///   <para>rdfs:label : rights</para>
    ///   <para>skos:historyNote : v1.1 : improved definition and changed the range to xsd:string</para>
    ///   <a href="http://data.europa.eu/eli/ontology#rights">eli:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : modified the range to xsd:string, and introduced the corresponding object property rightsholder_agent.</para>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : rights holder</para>
    ///   <para>rdfs:comment : A person or organisation owning or managing rights over the resource (definition from Dublin Core).
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "rightsholder_agent" should be used.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#rightsholder">eli:rightsholder</a>
    /// </summary>
    let rightsholder = _prefixId.prefix "rightsholder"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.1</para>
    ///   <para>rdfs:label : rightsholder agent</para>
    ///   <para>rdfs:comment : A person or organisation owning or managing rights over the resource (definition from Dublin Core).
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "rightsholder" should be used with a string value.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#rightsholder_agent">eli:rightsholder_agent</a>
    /// </summary>
    let rightsholder_agent = _prefixId.prefix "rightsholder_agent"
    /// <summary>
    ///   <para>rdfs:label : specific property of</para>
    ///   <para>rdfs:comment : Indicates that a property is, in a generic sense, a more specific property of another one. This does not entail the same logical reasoning as rdfs:subPropertyOf.
    /// This is used to indicate the alignement to DublinCore properties, without redeclaring the DublinCore property in Protégé, and without commiting to choose that a DubinCore property is either a datatype or an object property.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#specificPropertyOf">eli:specificPropertyOf</a>
    /// </summary>
    let specificPropertyOf = _prefixId.prefix "specificPropertyOf"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : The title, or name, of an expression.
    ///
    /// Note that, if needed, a title can also be stated on a legal resource using the Dublin Core "title" property.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#title">eli:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : alternative title</para>
    ///   <para>rdfs:comment : An alternative title of the expression (if any).
    ///
    /// Note that, if needed, an alternative title can also be stated on a legal resource using the Dublin Core "alternative" property.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#title_alternative">eli:title_alternative</a>
    /// </summary>
    let title_alternative = _prefixId.prefix "title_alternative"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : short title</para>
    ///   <para>rdfs:comment : Established short title of the expression (if any)</para>
    ///   <a href="http://data.europa.eu/eli/ontology#title_short">eli:title_short</a>
    /// </summary>
    let title_short = _prefixId.prefix "title_short"
    /// <summary>
    ///   <para>rdfs:label : transposed by</para>
    ///   <para>rdfs:comment : Inverse of "transposes".
    ///
    /// Note that this property is expressed on a legal resource, not on one of its language-specific legal expression.</para>
    ///   <para>skos:historyNote : v1.1 : this property was made a subproperty of "applied_by"</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <a href="http://data.europa.eu/eli/ontology#transposed_by">eli:transposed_by</a>
    /// </summary>
    let transposed_by = _prefixId.prefix "transposed_by"
    /// <summary>
    ///   <para>skos:historyNote : v1.1 : this property was made a subproperty of "applies", and the definition was improved.</para>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : transposes</para>
    ///   <para>rdfs:comment : Indicates that this legislation (or part of legislation) fulfills the objectives set by another legislation, by passing appropriate implementation measures. Typically, some legislations of European Union's member states or regions transpose European Directives. This indicates a legally binding link between the 2 legislations, at act or article level, from the original version of a national implementing measure to the legal resource Directive as published in the EU Official Journal. Can be used for transposition tables, once EU Publication Office has introduced ELI support down to the article level.
    ///
    /// Note that this should point to the legal resource of the Directive itself, not to one of its language-specific legal expression.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#transposes">eli:transposes</a>
    /// </summary>
    let transposes = _prefixId.prefix "transposes"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : type document</para>
    ///   <para>rdfs:comment : The type of a legal resource (e.g. "Directive", "Règlement grand ducal", "law", "règlement ministeriel", "draft proposition", "Parliamentary act", etc.).
    /// Member states are encouraged to make their own list of values in the corresponding concept scheme. EU Publications Office provides a list of values for EU resource types at http://publications.europa.eu/mdr/authority/resource-type</para>
    ///   <a href="http://data.europa.eu/eli/ontology#type_document">eli:type_document</a>
    /// </summary>
    let type_document = _prefixId.prefix "type_document"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : uri schema</para>
    ///   <para>rdfs:comment : Schema describing the URI of an ELI instance. ELI uses URI template specifications (IETF RFC 6570). Schemes should be associated with member states and will be published in a registry.</para>
    ///   <a href="http://data.europa.eu/eli/ontology#uri_schema">eli:uri_schema</a>
    /// </summary>
    let uri_schema = _prefixId.prefix "uri_schema"
    /// <summary>
    ///   <para>owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:label : version</para>
    ///   <para>rdfs:comment : A skos concept scheme, could be locally defined? Group proposal is to start with an initial ELI scheme, that might include concepts of "Official Journal" "made" "consolidated" "proposed" "prospective"</para>
    ///   <a href="http://data.europa.eu/eli/ontology#version">eli:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>owl:versionInfo : modified in v1.1owl:versionInfo : created in v1.0^^xsd:string</para>
    ///   <para>rdfs:comment : The point-in-time at which the provided description of the legislation is valid.</para>
    ///   <para>rdfs:label : version date</para>
    ///   <para>skos:historyNote : v1.1 : improved definition</para>
    ///   <a href="http://data.europa.eu/eli/ontology#version_date">eli:version_date</a>
    /// </summary>
    let version_date = _prefixId.prefix "version_date"
