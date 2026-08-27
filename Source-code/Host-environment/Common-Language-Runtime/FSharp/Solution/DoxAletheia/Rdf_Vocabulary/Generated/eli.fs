namespace http.data.europa.eu.eli.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eli =
    let _namespace_iri = Namespace_Iri eli |> NamespaceIRI
    /// <summary>
    ///   <para>eli:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"An ontology to describe legislation, based on the FRBR model, that encodes the ELI metadata fields.
    /// See the classes "LegalResource", "LegalExpression" and "Format" as entry points."</para>
    /// labels<para>"ELI Metadata Ontology"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#">http://data.europa.eu/eli/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(eli, "") |> PrefixedName
    /// <summary>
    ///   <para>eli:AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formally defined as the set of skos:Concept either in concept scheme eli:AdministrativeAreaTable or in concept scheme http://publications.europa.eu/mdr/authority/atu (Administrative Territorial Unit table published of the EU Publications Office)."</para>
    /// labels<para>"Administrative Area"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#AdministrativeArea">http://data.europa.eu/eli/ontology#AdministrativeArea</seealso>
    let AdministrativeArea = Prefixed_Name(eli, "AdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>eli:AdministrativeAreaTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"Administrative area table"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#AdministrativeAreaTable">http://data.europa.eu/eli/ontology#AdministrativeAreaTable</seealso>
    let AdministrativeAreaTable =
        Prefixed_Name(eli, "AdministrativeAreaTable") |> PrefixedName

    /// <summary>
    ///   <para>eli:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#Agent">http://data.europa.eu/eli/ontology#Agent</seealso>
    let Agent = Prefixed_Name(eli, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>eli:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The physical embodiment of a legal expression, either on paper or in any electronic format (definition adapted from RDA).
    /// For example, any electronic or physical format of the legal expression (XML, TIFF, PDF, etc.) ; e.g. PDF version of act 3 of 2005.  (adapted from Akoma Ntoso)"</para>
    /// labels<para>"Format"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#Format">http://data.europa.eu/eli/ontology#Format</seealso>
    let Format = Prefixed_Name(eli, "Format") |> PrefixedName
    /// <summary>
    ///   <para>eli:InForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formally defined as the set of skos:Concept in concept scheme eli:InForceTable"</para>
    /// labels<para>"In force"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#InForce">http://data.europa.eu/eli/ontology#InForce</seealso>
    let InForce = Prefixed_Name(eli, "InForce") |> PrefixedName
    /// <summary>
    ///   <para>eli:InForce-inForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>eli:InForce</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#InForce-inForce">http://data.europa.eu/eli/ontology#InForce-inForce</seealso>
    let InForce_inForce = Prefixed_Name(eli, "InForce-inForce") |> PrefixedName
    /// <summary>
    ///   <para>eli:InForce-notInForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>eli:InForce</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#InForce-notInForce">http://data.europa.eu/eli/ontology#InForce-notInForce</seealso>
    let InForce_notInForce = Prefixed_Name(eli, "InForce-notInForce") |> PrefixedName

    /// <summary>
    ///   <para>eli:InForce-partiallyInForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>eli:InForce</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#InForce-partiallyInForce">http://data.europa.eu/eli/ontology#InForce-partiallyInForce</seealso>
    let InForce_partiallyInForce =
        Prefixed_Name(eli, "InForce-partiallyInForce") |> PrefixedName

    /// <summary>
    ///   <para>eli:InForceTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"In force table"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#InForceTable">http://data.europa.eu/eli/ontology#InForceTable</seealso>
    let InForceTable = Prefixed_Name(eli, "InForceTable") |> PrefixedName
    /// <summary>
    ///   <para>eli:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formally defined as the set of skos:Concept in concept scheme http://data.europa.eu/eli/ontology#language"</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#Language">http://data.europa.eu/eli/ontology#Language</seealso>
    let Language = Prefixed_Name(eli, "Language") |> PrefixedName
    /// <summary>
    ///   <para>eli:LegalExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The intellectual realisation of a legal resource in the form of a "sequence of signs" (typically alpha-numeric characters in a legal context) (definition adapted from RDA)
    /// For example, any version of the legal resource whose content is specified and different from others for any reason: language, versions, etc.;
    ///
    /// Note that ELI ontology accommodates different point of view on what should be considered a new legal resource, or a new legal expression of the same resource. Typically, a consolidated version can be viewed, in the context of ELI, either as separate legal resource (linked to original version and previous consolidated version using corresponding ELI relations), or as a different legal expression of the same legal resource."</para>
    /// labels<para>"Legal Expression"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalExpression">http://data.europa.eu/eli/ontology#LegalExpression</seealso>
    let LegalExpression = Prefixed_Name(eli, "LegalExpression") |> PrefixedName
    /// <summary>
    ///   <para>eli:LegalRecontributor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalRecontributor">http://data.europa.eu/eli/ontology#LegalRecontributor</seealso>
    let LegalRecontributor = Prefixed_Name(eli, "LegalRecontributor") |> PrefixedName
    /// <summary>
    ///   <para>eli:LegalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A distinct intellectual creation (i.e., the intellectual content). (definition adapted from RDA - Resource Description and Access, see http://www.rdaregistry.info/).
    /// For example, the abstract concept of the legal resource; e.g. "act 3 of 2005" (adapted from Akoma Ntoso)
    ///
    /// Legal resource can be linked together using properties defined in the model.
    /// A legal resource can represent a legal act or any component of a legal act, like an article.
    ///
    /// Note that ELI ontology accommodates different point of view on what should be considered a new legal resource, or a new legal expression of the same resource. Typically, a consolidated version can be viewed, in the context of ELI, either as separate legal resource (linked to original version and previous consolidated version using corresponding ELI relations), or as a different legal expression of the same legal resource."</para>
    ///   <para>"A work in a legislative corpus. This applies to acts that have been legally enacted (whether or not they are still in force).
    /// For example, the abstract concept of the legal resource; e.g. &amp;quot;act 3 of 2005&amp;quot; (adapted from Akoma Ntoso)
    ///
    /// A legal resource can represent a legal act or any component of a legal act, like an article.  Legal resources can be linked together using properties defined in the model.
    ///
    /// Note that ELI ontology accommodates different point of view on what should be considered a new legal resource, or a new legal expression of the same resource. Typically, a consolidated version can be viewed, in the context of ELI, either as separate legal resource (linked to original version and previous consolidated version using corresponding ELI relations), or as a different legal expression of the same legal resource.&lt;/rdfs:comment&gt;"</para>
    /// labels<para>"Legal Resource"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalResource">http://data.europa.eu/eli/ontology#LegalResource</seealso>
    let LegalResource = Prefixed_Name(eli, "LegalResource") |> PrefixedName

    /// <summary>
    ///   <para>eli:LegalResourceSubdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A component of a legal act, at an arbitrary level of precision, like a chapter, an article, an alinea, a paragraph or an list item. A subdivision can be linked with its parent and children subdivision using the properties eli:has_part / eli:is_part_of."</para>
    /// labels<para>"Legal Resource Subdivision"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalResourceSubdivision">http://data.europa.eu/eli/ontology#LegalResourceSubdivision</seealso>
    let LegalResourceSubdivision =
        Prefixed_Name(eli, "LegalResourceSubdivision") |> PrefixedName

    /// <summary>
    ///   <para>eli:LegalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formally defined as the set of skos:Concept in concept scheme eli:LegalValueTable"</para>
    /// labels<para>"Legal value"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalValue">http://data.europa.eu/eli/ontology#LegalValue</seealso>
    let LegalValue = Prefixed_Name(eli, "LegalValue") |> PrefixedName

    /// <summary>
    ///   <para>eli:LegalValue-authoritative</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>eli:LegalValue</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalValue-authoritative">http://data.europa.eu/eli/ontology#LegalValue-authoritative</seealso>
    let LegalValue_authoritative =
        Prefixed_Name(eli, "LegalValue-authoritative") |> PrefixedName

    /// <summary>
    ///   <para>eli:LegalValue-definitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>eli:LegalValue</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalValue-definitive">http://data.europa.eu/eli/ontology#LegalValue-definitive</seealso>
    let LegalValue_definitive =
        Prefixed_Name(eli, "LegalValue-definitive") |> PrefixedName

    /// <summary>
    ///   <para>eli:LegalValue-official</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>eli:LegalValue</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalValue-official">http://data.europa.eu/eli/ontology#LegalValue-official</seealso>
    let LegalValue_official = Prefixed_Name(eli, "LegalValue-official") |> PrefixedName

    /// <summary>
    ///   <para>eli:LegalValue-unofficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>eli:LegalValue</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalValue-unofficial">http://data.europa.eu/eli/ontology#LegalValue-unofficial</seealso>
    let LegalValue_unofficial =
        Prefixed_Name(eli, "LegalValue-unofficial") |> PrefixedName

    /// <summary>
    ///   <para>eli:LegalValueTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"Legal value table"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#LegalValueTable">http://data.europa.eu/eli/ontology#LegalValueTable</seealso>
    let LegalValueTable = Prefixed_Name(eli, "LegalValueTable") |> PrefixedName
    /// <summary>
    ///   <para>eli:Organization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#Organization">http://data.europa.eu/eli/ontology#Organization</seealso>
    let Organization = Prefixed_Name(eli, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>eli:Person</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#Person">http://data.europa.eu/eli/ontology#Person</seealso>
    let Person = Prefixed_Name(eli, "Person") |> PrefixedName
    /// <summary>
    ///   <para>eli:ResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formally defined as the set of skos:Concept in concept scheme eli:ResourceTypeTable"</para>
    /// labels<para>"Resource type"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#ResourceType">http://data.europa.eu/eli/ontology#ResourceType</seealso>
    let ResourceType = Prefixed_Name(eli, "ResourceType") |> PrefixedName
    /// <summary>
    ///   <para>eli:ResourceTypeTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Resource type table"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#ResourceTypeTable">http://data.europa.eu/eli/ontology#ResourceTypeTable</seealso>
    let ResourceTypeTable = Prefixed_Name(eli, "ResourceTypeTable") |> PrefixedName
    /// <summary>
    ///   <para>eli:Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formally defined as the set of skos:Concept in concept scheme eli:VersionTable"</para>
    /// labels<para>"Version"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#Version">http://data.europa.eu/eli/ontology#Version</seealso>
    let Version = Prefixed_Name(eli, "Version") |> PrefixedName
    /// <summary>
    ///   <para>eli:VersionTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Version table"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#VersionTable">http://data.europa.eu/eli/ontology#VersionTable</seealso>
    let VersionTable = Prefixed_Name(eli, "VersionTable") |> PrefixedName
    /// <summary>
    ///   <para>eli:amended_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of "amends". Indicates a resource that introduced legal changes in this resource. For modifications that don’t have a legal impact, use eli:corrected_by."</para>
    /// labels<para>"amended by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#amended_by">http://data.europa.eu/eli/ontology#amended_by</seealso>
    let amended_by = Prefixed_Name(eli, "amended_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:amends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that this resource introduces legal changes in another resource. For modifications that don’t have a legal impact, use eli:corrects."</para>
    /// labels<para>"amends"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#amends">http://data.europa.eu/eli/ontology#amends</seealso>
    let amends = Prefixed_Name(eli, "amends") |> PrefixedName
    /// <summary>
    ///   <para>eli:applied_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of "applies".
    ///
    /// Note that this property is expressed on a legal resource, not on one of its language-specific legal expression."</para>
    /// labels<para>"applied by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#applied_by">http://data.europa.eu/eli/ontology#applied_by</seealso>
    let applied_by = Prefixed_Name(eli, "applied_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:applies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this legislation (or part of a legislation) somehow conforms with another legislation. This is an informative link, and it has no legal value. For legally-binding links of transposition, use the property transposes. This can be used for example :
    ///   - when a pre-existing law already conforms to a recent european directive (in that case it does not "transposes" it strictly speaking);
    ///   - when non-EU member states make sure their legislation is conformant with EU law without strictly speaking transposing it;
    ///   - when a legislation from a local authority conforms with a national legislation;
    ///
    /// Note that this should point to a LegalResource, not to a language-specific expression."</para>
    /// labels<para>"applies"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#applies">http://data.europa.eu/eli/ontology#applies</seealso>
    let applies = Prefixed_Name(eli, "applies") |> PrefixedName
    /// <summary>
    ///   <para>eli:based_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of "basis_for". Indicates that this legal resource is empowered by another one, typically a constitution, a treaty or an enabling act."</para>
    /// labels<para>"based on"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#based_on">http://data.europa.eu/eli/ontology#based_on</seealso>
    let based_on = Prefixed_Name(eli, "based_on") |> PrefixedName
    /// <summary>
    ///   <para>eli:basis_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this legal resource or expression empowers another . Typically primary legislation is the basis for secondary legislation."</para>
    /// labels<para>"basis for"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#basis_for">http://data.europa.eu/eli/ontology#basis_for</seealso>
    let basis_for = Prefixed_Name(eli, "basis_for") |> PrefixedName
    /// <summary>
    ///   <para>eli:changed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of « changes ». Indicates that this legal resource or expression is being legally changed by another. This encompasses the notions of amendment, replacement, repeal, or other types of change."</para>
    /// labels<para>"changed by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#changed_by">http://data.europa.eu/eli/ontology#changed_by</seealso>
    let changed_by = Prefixed_Name(eli, "changed_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:changes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this legal resource or expression legally changes another. This encompasses the notions of amendment, replacement, repeal, or other types of change. This may be a direct change (textual or non-textual amendment) or a consequential or indirect change. Note, the property is to be used to express the existence of a change relationship between two acts rather than the existence of a consolidated version of the text that shows the result of the change. For consolidation relationships, use the "consolidates" and "consolidated_by" properties."</para>
    /// labels<para>"changes"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#changes">http://data.europa.eu/eli/ontology#changes</seealso>
    let changes = Prefixed_Name(eli, "changes") |> PrefixedName
    /// <summary>
    ///   <para>eli:cited_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of "cites""</para>
    /// labels<para>"cited by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#cited_by">http://data.europa.eu/eli/ontology#cited_by</seealso>
    let cited_by = Prefixed_Name(eli, "cited_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Citation in the text of the legislation. This may be at the legal resource or legal expression level, as required by the implementation context. This includes verbatim citation and citations in referrals."</para>
    /// labels<para>"cites"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#cites">http://data.europa.eu/eli/ontology#cites</seealso>
    let cites = Prefixed_Name(eli, "cites") |> PrefixedName
    /// <summary>
    ///   <para>eli:commenced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of "commences". Indicates that this legal resource was set in force by another legal resource.
    /// Situations where a resource enters into force because of more than one resource are explicitely allowed."</para>
    /// labels<para>"commenced by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#commenced_by">http://data.europa.eu/eli/ontology#commenced_by</seealso>
    let commenced_by = Prefixed_Name(eli, "commenced_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:commences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this legal resource sets another legal resource into force.
    /// Note the the date of entry into force of the other resource should be modified accordingly.
    /// Note also that it is not possible to indicate when the entry into force should happen."</para>
    /// labels<para>"commences"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#commences">http://data.europa.eu/eli/ontology#commences</seealso>
    let commences = Prefixed_Name(eli, "commences") |> PrefixedName
    /// <summary>
    ///   <para>eli:consolidated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of "consolidates". Indicates that this legal resource or expression is taken into account in a consolidated text (which is usually the product of an editorial process that revises the legislation)."</para>
    /// labels<para>"consolidated by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#consolidated_by">http://data.europa.eu/eli/ontology#consolidated_by</seealso>
    let consolidated_by = Prefixed_Name(eli, "consolidated_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:consolidates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this consolidated legal resource or expression (which is usually the product of an editorial process that revises the legislation) takes into account another one. This property should be used multiple times to refer to both the original version or the previous consolidated version, and to the legislations making the change."</para>
    /// labels<para>"consolidates"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#consolidates">http://data.europa.eu/eli/ontology#consolidates</seealso>
    let consolidates = Prefixed_Name(eli, "consolidates") |> PrefixedName
    /// <summary>
    ///   <para>eli:corrected_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of "corrects". Indicates a resource that introduces textual modifications (like correction of spelling mistakes) with no legal change in this resource, expression or format; typically corrigenda in EU legislation. For modifications that have a legal impact, use eli:amended_by."</para>
    /// labels<para>"corrected by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#corrected_by">http://data.europa.eu/eli/ontology#corrected_by</seealso>
    let corrected_by = Prefixed_Name(eli, "corrected_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:corrects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that this resource introduces textual modifications (like correction of spelling mistakes) with no legal change in another resource, expression or format; typically corrigenda in EU legislation. For modifications that have a legal impact, use eli:amends."</para>
    /// labels<para>"corrects"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#corrects">http://data.europa.eu/eli/ontology#corrects</seealso>
    let corrects = Prefixed_Name(eli, "corrects") |> PrefixedName
    /// <summary>
    ///   <para>eli:countersigned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#countersigned_by">http://data.europa.eu/eli/ontology#countersigned_by</seealso>
    let countersigned_by = Prefixed_Name(eli, "countersigned_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:date_applicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date at which the legislation becomes applicable. This is distinct from the date of entry into force : a text may come in force today, and state it will become applicable in 3 months.
    ///
    /// The group notes that applicability dates can lead to complex situations, e.g. a text with different applicability dates for different jurisdictions; specific extensions to the model should be used for such situations."</para>
    /// labels<para>"date of applicability"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#date_applicability">http://data.europa.eu/eli/ontology#date_applicability</seealso>
    let date_applicability = Prefixed_Name(eli, "date_applicability") |> PrefixedName
    /// <summary>
    ///   <para>eli:date_document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Date of adoption or signature (of the form yyyy-mm-dd)"</para>
    /// labels<para>"date of the document"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#date_document">http://data.europa.eu/eli/ontology#date_document</seealso>
    let date_document = Prefixed_Name(eli, "date_document") |> PrefixedName

    /// <summary>
    ///   <para>eli:date_no_longer_in_force</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The last date any part of the legislation cease to be in force, if the date is known (can be seen as the end date of a dc:valid range for this resource)."</para>
    /// labels<para>"date no longer in force"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#date_no_longer_in_force">http://data.europa.eu/eli/ontology#date_no_longer_in_force</seealso>
    let date_no_longer_in_force =
        Prefixed_Name(eli, "date_no_longer_in_force") |> PrefixedName

    /// <summary>
    ///   <para>eli:date_publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of publication of the official version of the legislation, in hard copy or online, depending on what the official publication is, and when it was published. Publication dates at the level of legal expressions can be separately asserted, using standard Dublin Core properties."</para>
    /// labels<para>"date of publication"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#date_publication">http://data.europa.eu/eli/ontology#date_publication</seealso>
    let date_publication = Prefixed_Name(eli, "date_publication") |> PrefixedName
    /// <summary>
    ///   <para>eli:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An account of the resource (definition from Dubin Core), e.g a summary."</para>
    /// labels<para>"description"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#description">http://data.europa.eu/eli/ontology#description</seealso>
    let description = Prefixed_Name(eli, "description") |> PrefixedName
    /// <summary>
    ///   <para>eli:embodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a physical format to the legal expression embodied in that format (definition adapted from RDA). Inverse of "is_embodied_by"."</para>
    /// labels<para>"embodies"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#embodies">http://data.europa.eu/eli/ontology#embodies</seealso>
    let embodies = Prefixed_Name(eli, "embodies") |> PrefixedName

    /// <summary>
    ///   <para>eli:ensures_implementation_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#ensures_implementation_of">http://data.europa.eu/eli/ontology#ensures_implementation_of</seealso>
    let ensures_implementation_of =
        Prefixed_Name(eli, "ensures_implementation_of") |> PrefixedName

    /// <summary>
    ///   <para>eli:first_date_entry_in_force</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The first date any part of the legal resource or legal expression came into force (can be seen as the start date of a dc:valid range for this resource)"</para>
    /// labels<para>"first date of entry into force"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#first_date_entry_in_force">http://data.europa.eu/eli/ontology#first_date_entry_in_force</seealso>
    let first_date_entry_in_force =
        Prefixed_Name(eli, "first_date_entry_in_force") |> PrefixedName

    /// <summary>
    ///   <para>eli:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The file format, physical medium, or dimensions of the resource (definition from Dublin Core).
    /// Possible URIs values should be taken from http://www.iana.org/assignments/media-types (e.g. http://www.iana.org/assignments/media-types/application/xml), and can serve as a basis for content negotiation for the server to return the appropriate file based on the client preference."</para>
    /// labels<para>"format"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#format">http://data.europa.eu/eli/ontology#format</seealso>
    let format = Prefixed_Name(eli, "format") |> PrefixedName

    /// <summary>
    ///   <para>eli:has_another_publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of "is_another_publication_of"."</para>
    /// labels<para>"has another publication"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#has_another_publication">http://data.europa.eu/eli/ontology#has_another_publication</seealso>
    let has_another_publication =
        Prefixed_Name(eli, "has_another_publication") |> PrefixedName

    /// <summary>
    ///   <para>eli:has_member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this resource conceptually includes another one. For the notion of physical inclusion, use eli:has_part."</para>
    /// labels<para>"has member"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#has_member">http://data.europa.eu/eli/ontology#has_member</seealso>
    let has_member = Prefixed_Name(eli, "has_member") |> PrefixedName
    /// <summary>
    ///   <para>eli:has_part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse of "is_part_of""</para>
    /// labels<para>"has part"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#has_part">http://data.europa.eu/eli/ontology#has_part</seealso>
    let has_part = Prefixed_Name(eli, "has_part") |> PrefixedName
    /// <summary>
    ///   <para>eli:id_local</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The unique identifier used in a local reference system to maintain backwards compatibility. For examples the CELEX at EU level, or the NOR in France."</para>
    /// labels<para>"local id"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#id_local">http://data.europa.eu/eli/ontology#id_local</seealso>
    let id_local = Prefixed_Name(eli, "id_local") |> PrefixedName
    /// <summary>
    ///   <para>eli:implemented_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is deprecated. Use "applied_by" instead."</para>
    /// labels<para>"implemented by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#implemented_by">http://data.europa.eu/eli/ontology#implemented_by</seealso>
    let implemented_by = Prefixed_Name(eli, "implemented_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is deprecated. Use "applies" instead."</para>
    /// labels<para>"implements"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#implements">http://data.europa.eu/eli/ontology#implements</seealso>
    let implements = Prefixed_Name(eli, "implements") |> PrefixedName
    /// <summary>
    ///   <para>eli:in_force</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A value indicating the legal force of a legal resource or a legal expression. A set of values is defined by ELI in the corresponding concept scheme. These values are :
    ///   - in force
    ///   - partially in force
    ///   - not in force"</para>
    /// labels<para>"in force"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#in_force">http://data.europa.eu/eli/ontology#in_force</seealso>
    let in_force = Prefixed_Name(eli, "in_force") |> PrefixedName
    /// <summary>
    ///   <para>eli:is_about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A subject for this legal resource. The use of Eurovoc (http://eurovoc.europa.eu) is encouraged to select values for this property. Member states are encouraged to align local values to Eurovoc."</para>
    /// labels<para>"is about"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#is_about">http://data.europa.eu/eli/ontology#is_about</seealso>
    let is_about = Prefixed_Name(eli, "is_about") |> PrefixedName

    /// <summary>
    ///   <para>eli:is_another_publication_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this resource is a new publication, in a different official journal, of another resource already published elsewhere, and cannot be considered to be the same resource (owl:sameAs cannot be used to avoid potential duplication of certain metadata, like the date of publication, or the publisher).
    ///
    /// Note that this is different from the exceptionnal cases of "republication", where the same resource is actually republished in the same official journal a few days after its initial publication, in case of errors."</para>
    /// labels<para>"is another publication of"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#is_another_publication_of">http://data.europa.eu/eli/ontology#is_another_publication_of</seealso>
    let is_another_publication_of =
        Prefixed_Name(eli, "is_another_publication_of") |> PrefixedName

    /// <summary>
    ///   <para>eli:is_embodied_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a legal expression to a physical format of that expression (definition adapted from RDA). Inverse of "embodies"."</para>
    /// labels<para>"is embodied by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#is_embodied_by">http://data.europa.eu/eli/ontology#is_embodied_by</seealso>
    let is_embodied_by = Prefixed_Name(eli, "is_embodied_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:is_exemplified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link to a concrete file URL.
    /// Relates a format to a single exemplar or instance of that format (definition adapted from RDA). "</para>
    /// labels<para>"is exemplified by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#is_exemplified_by">http://data.europa.eu/eli/ontology#is_exemplified_by</seealso>
    let is_exemplified_by = Prefixed_Name(eli, "is_exemplified_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:is_member_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this resource is conceptually included in another one. Typically the successive temporal versions of a given legislation are conceptually members of a single « abstract » resource. For the notion of physical inclusion, use eli:is_part_of."</para>
    /// labels<para>"is member of"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#is_member_of">http://data.europa.eu/eli/ontology#is_member_of</seealso>
    let is_member_of = Prefixed_Name(eli, "is_member_of") |> PrefixedName
    /// <summary>
    ///   <para>eli:is_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A related resource in which the described resource is physically included. Covers the case of text included in an Official Journal, or an article included in a text. For the notion of conceptual/temporal inclusion, use eli:is_member_of."</para>
    /// labels<para>"is part of"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#is_part_of">http://data.europa.eu/eli/ontology#is_part_of</seealso>
    let is_part_of = Prefixed_Name(eli, "is_part_of") |> PrefixedName
    /// <summary>
    ///   <para>eli:is_realized_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a legal resource to a legal expression of this resource in the form of a "sequence of signs" (typically alpha-numeric characters in a legal context). (definition adapted from RDA). Inverse of "realizes"."</para>
    /// labels<para>"is realized by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#is_realized_by">http://data.europa.eu/eli/ontology#is_realized_by</seealso>
    let is_realized_by = Prefixed_Name(eli, "is_realized_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The jurisdiction from which the legal resource originates.
    ///
    /// The place identifier can be taken from the Administrative Territorial Unit table published of the EU Publications Office at http://publications.europa.eu/mdr/authority/atu. Member States don't have to recreate their own list of values."</para>
    /// labels<para>"jurisdiction"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#jurisdiction">http://data.europa.eu/eli/ontology#jurisdiction</seealso>
    let jurisdiction = Prefixed_Name(eli, "jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>eli:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The language of an expression.
    ///
    /// EU Publications Office provides a list of languages at http://publications.europa.eu/mdr/authority/language. This list is large enough so that member states should not have to declare local values.
    ///
    /// Note that, if needed, a language can also be stated on a legal resource using the DublinCore "language" property."</para>
    /// labels<para>"language"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#language">http://data.europa.eu/eli/ontology#language</seealso>
    let language = Prefixed_Name(eli, "language") |> PrefixedName
    /// <summary>
    ///   <para>eli:legal_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The legal value associated with a specific format of a resource. A set of values is defined by ELI in the corresponding concept scheme. These values are :
    ///   - unofficial : no particular or special standing;
    ///   - official : published by an organisation with the public task of making the information available (e.g. a consolidated version of a EU directive) ;
    ///   - authoritative : the publisher gives some special status to the publication (e.g. "the Queens Printer" version of an Act of Parliament, or the OJ version of a EU Directive);
    ///   - definitive : the text is conclusively what the law says, (e.g. the digitally signed version of an OJ)."</para>
    /// labels<para>"legal value"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#legal_value">http://data.europa.eu/eli/ontology#legal_value</seealso>
    let legal_value = Prefixed_Name(eli, "legal_value") |> PrefixedName
    /// <summary>
    ///   <para>eli:licence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A legal document giving official permission to do something with the resource (Definition from Dublin Core)"</para>
    /// labels<para>"licence"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#licence">http://data.europa.eu/eli/ontology#licence</seealso>
    let licence = Prefixed_Name(eli, "licence") |> PrefixedName
    /// <summary>
    ///   <para>eli:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier or other disambiguating feature for a legal resource or legal expression. This can be the number of a legislation, the number of an article, or the issue number of an official journal."</para>
    /// labels<para>"number"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#number">http://data.europa.eu/eli/ontology#number</seealso>
    let number = Prefixed_Name(eli, "number") |> PrefixedName
    /// <summary>
    ///   <para>eli:originalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#originalName">http://data.europa.eu/eli/ontology#originalName</seealso>
    let originalName = Prefixed_Name(eli, "originalName") |> PrefixedName
    /// <summary>
    ///   <para>eli:passed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The person or organization that originally passed or made the law : typically parliament (for primary legislation) or government (for secondary legislation). This indicates the "legal author" of the law, as opposed to its physical author.
    ///
    /// This property can be used multiple times to indicate both the agent that authored the text, and/or the agent that signed the text, thus turning it into an actual legislation.
    ///
    /// The relationship between current and any former law making body should be represented in the description of the agent itself.
    ///
    /// Member states are encouraged to make their own list of Agents. EU Publications Office provides a list of corporate bodies at http://publications.europa.eu/mdr/authority/corporate-body."</para>
    /// labels<para>"passed by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#passed_by">http://data.europa.eu/eli/ontology#passed_by</seealso>
    let passed_by = Prefixed_Name(eli, "passed_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:published_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Reference to the Official Journal or other publication manifestation in which this format is published.
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "published_in_format" should be used."</para>
    /// labels<para>"published in"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#published_in">http://data.europa.eu/eli/ontology#published_in</seealso>
    let published_in = Prefixed_Name(eli, "published_in") |> PrefixedName
    /// <summary>
    ///   <para>eli:published_in_format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference to the Official Journal or other publication manifestation in which this format is published.
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "published_in" should be used with a string value."</para>
    /// labels<para>"published in format"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#published_in_format">http://data.europa.eu/eli/ontology#published_in_format</seealso>
    let published_in_format = Prefixed_Name(eli, "published_in_format") |> PrefixedName
    /// <summary>
    ///   <para>eli:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An entity responsible for making the resource available (definition from Dublin Core).
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "publisher_agent" should be used."</para>
    /// labels<para>"publisher"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#publisher">http://data.europa.eu/eli/ontology#publisher</seealso>
    let publisher = Prefixed_Name(eli, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>eli:publisher_agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An entity responsible for making the resource available (definition from Dublin Core).
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "publisher" should be used with a string value."</para>
    /// labels<para>"publisher agent"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#publisher_agent">http://data.europa.eu/eli/ontology#publisher_agent</seealso>
    let publisher_agent = Prefixed_Name(eli, "publisher_agent") |> PrefixedName
    /// <summary>
    ///   <para>eli:publishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of "published_in_format". Note this property does not link a publisher with a resource, but rather a specific Format of a resource with a specific Format of another resource, indicating that the subject Format publishes the object Format."</para>
    /// labels<para>"publishes"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#publishes">http://data.europa.eu/eli/ontology#publishes</seealso>
    let publishes = Prefixed_Name(eli, "publishes") |> PrefixedName
    /// <summary>
    ///   <para>eli:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a legal expression to the legal resource realised through that expression. (definition adapted from RDA). Inverse of "is_realized_by"."</para>
    /// labels<para>"realizes"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#realizes">http://data.europa.eu/eli/ontology#realizes</seealso>
    let realizes = Prefixed_Name(eli, "realizes") |> PrefixedName
    /// <summary>
    ///   <para>eli:related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates a somehow related other document, not necessarily a legal resource. Note that citation links should use the cites property."</para>
    /// labels<para>"related to"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#related_to">http://data.europa.eu/eli/ontology#related_to</seealso>
    let related_to = Prefixed_Name(eli, "related_to") |> PrefixedName
    /// <summary>
    ///   <para>eli:relevant_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to a place or an area associated with the resource. This covers the notions of jurisdiction, sovereignty, applicability or administrative area. The place identifier can be taken from the Administrative Territorial Unit table published of the EU Publications Office at http://publications.europa.eu/mdr/authority/atu. Member States don't have to recreate their own list of values.
    ///
    /// The group notes the limitations of what can be said with a single property; member states can refine this notion by declaring specific sub properties."</para>
    /// labels<para>"relevant for"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#relevant_for">http://data.europa.eu/eli/ontology#relevant_for</seealso>
    let relevant_for = Prefixed_Name(eli, "relevant_for") |> PrefixedName
    /// <summary>
    ///   <para>eli:repealed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inverse of "repeals". Indicates that this legal resource or legal expression is being completely canceled, abrogated or replaced by another legal resource. If a resource is partially repealed by another, this link can be used at the corresponding subdivision level being completely repealed."</para>
    /// labels<para>"repealed by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#repealed_by">http://data.europa.eu/eli/ontology#repealed_by</seealso>
    let repealed_by = Prefixed_Name(eli, "repealed_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:repeals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that this legal resource or legal expression completely cancels, abrogates or replaces another. If a resource partially repeals another, this link can be used at the corresponding subdivision level being completely repealed."</para>
    /// labels<para>"repeals"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#repeals">http://data.europa.eu/eli/ontology#repeals</seealso>
    let repeals = Prefixed_Name(eli, "repeals") |> PrefixedName
    /// <summary>
    ///   <para>eli:responsibility_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An individual, organisation or organisational unit that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "responsibility_of_agent" should be used."</para>
    /// labels<para>"responsibility of"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#responsibility_of">http://data.europa.eu/eli/ontology#responsibility_of</seealso>
    let responsibility_of = Prefixed_Name(eli, "responsibility_of") |> PrefixedName

    /// <summary>
    ///   <para>eli:responsibility_of_agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An individual, organisation or organisational unit that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "responsibility_of" should be used with a string value."</para>
    /// labels<para>"responsibility of agent"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#responsibility_of_agent">http://data.europa.eu/eli/ontology#responsibility_of_agent</seealso>
    let responsibility_of_agent =
        Prefixed_Name(eli, "responsibility_of_agent") |> PrefixedName

    /// <summary>
    ///   <para>eli:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Information about rights held in and over the resource (definition from Dublin Core). For example, that property can be used to provide a link to a page that describes the licensing terms."</para>
    /// labels<para>"rights"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#rights">http://data.europa.eu/eli/ontology#rights</seealso>
    let rights = Prefixed_Name(eli, "rights") |> PrefixedName
    /// <summary>
    ///   <para>eli:rightsholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A person or organisation owning or managing rights over the resource (definition from Dublin Core).
    /// This property should be used when the value cannot be identified by a suitable URI; if a URI is available, the property "rightsholder_agent" should be used."</para>
    /// labels<para>"rights holder"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#rightsholder">http://data.europa.eu/eli/ontology#rightsholder</seealso>
    let rightsholder = Prefixed_Name(eli, "rightsholder") |> PrefixedName
    /// <summary>
    ///   <para>eli:rightsholder_agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A person or organisation owning or managing rights over the resource (definition from Dublin Core).
    /// This property should be used when the value can be identified by a suitable URI; in the absence of such a URI, the property "rightsholder" should be used with a string value."</para>
    /// labels<para>"rightsholder agent"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#rightsholder_agent">http://data.europa.eu/eli/ontology#rightsholder_agent</seealso>
    let rightsholder_agent = Prefixed_Name(eli, "rightsholder_agent") |> PrefixedName
    /// <summary>
    ///   <para>eli:specificPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Indicates that a property is, in a generic sense, a more specific property of another one. This does not entail the same logical reasoning as rdfs:subPropertyOf.
    /// This is used to indicate the alignement to DublinCore properties, without redeclaring the DublinCore property in Protégé, and without commiting to choose that a DubinCore property is either a datatype or an object property."</para>
    /// labels<para>"specific property of"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#specificPropertyOf">http://data.europa.eu/eli/ontology#specificPropertyOf</seealso>
    let specificPropertyOf = Prefixed_Name(eli, "specificPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>eli:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The title, or name, of an expression.
    ///
    /// Note that, if needed, a title can also be stated on a legal resource using the Dublin Core "title" property."</para>
    /// labels<para>"title"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#title">http://data.europa.eu/eli/ontology#title</seealso>
    let title = Prefixed_Name(eli, "title") |> PrefixedName
    /// <summary>
    ///   <para>eli:title_alternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An alternative title of the expression (if any).
    ///
    /// Note that, if needed, an alternative title can also be stated on a legal resource using the Dublin Core "alternative" property."</para>
    /// labels<para>"alternative title"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#title_alternative">http://data.europa.eu/eli/ontology#title_alternative</seealso>
    let title_alternative = Prefixed_Name(eli, "title_alternative") |> PrefixedName
    /// <summary>
    ///   <para>eli:title_short</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Established short title of the expression (if any)"</para>
    /// labels<para>"short title"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#title_short">http://data.europa.eu/eli/ontology#title_short</seealso>
    let title_short = Prefixed_Name(eli, "title_short") |> PrefixedName
    /// <summary>
    ///   <para>eli:transposed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of "transposes".
    ///
    /// Note that this property is expressed on a legal resource, not on one of its language-specific legal expression."</para>
    /// labels<para>"transposed by"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#transposed_by">http://data.europa.eu/eli/ontology#transposed_by</seealso>
    let transposed_by = Prefixed_Name(eli, "transposed_by") |> PrefixedName
    /// <summary>
    ///   <para>eli:transposes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that this legislation (or part of legislation) fulfills the objectives set by another legislation, by passing appropriate implementation measures. Typically, some legislations of European Union's member states or regions transpose European Directives. This indicates a legally binding link between the 2 legislations, at act or article level, from the original version of a national implementing measure to the legal resource Directive as published in the EU Official Journal. Can be used for transposition tables, once EU Publication Office has introduced ELI support down to the article level.
    ///
    /// Note that this should point to the legal resource of the Directive itself, not to one of its language-specific legal expression."</para>
    /// labels<para>"transposes"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#transposes">http://data.europa.eu/eli/ontology#transposes</seealso>
    let transposes = Prefixed_Name(eli, "transposes") |> PrefixedName
    /// <summary>
    ///   <para>eli:type_document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The type of a legal resource (e.g. "Directive", "Règlement grand ducal", "law", "règlement ministeriel", "draft proposition", "Parliamentary act", etc.).
    /// Member states are encouraged to make their own list of values in the corresponding concept scheme. EU Publications Office provides a list of values for EU resource types at http://publications.europa.eu/mdr/authority/resource-type"</para>
    /// labels<para>"type document"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#type_document">http://data.europa.eu/eli/ontology#type_document</seealso>
    let type_document = Prefixed_Name(eli, "type_document") |> PrefixedName
    /// <summary>
    ///   <para>eli:uri_schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Schema describing the URI of an ELI instance. ELI uses URI template specifications (IETF RFC 6570). Schemes should be associated with member states and will be published in a registry."</para>
    /// labels<para>"uri schema"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#uri_schema">http://data.europa.eu/eli/ontology#uri_schema</seealso>
    let uri_schema = Prefixed_Name(eli, "uri_schema") |> PrefixedName
    /// <summary>
    ///   <para>eli:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A skos concept scheme, could be locally defined? Group proposal is to start with an initial ELI scheme, that might include concepts of "Official Journal" "made" "consolidated" "proposed" "prospective""</para>
    /// labels<para>"version"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#version">http://data.europa.eu/eli/ontology#version</seealso>
    let version = Prefixed_Name(eli, "version") |> PrefixedName
    /// <summary>
    ///   <para>eli:version_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The point-in-time at which the provided description of the legislation is valid."</para>
    /// labels<para>"version date"</para></remarks>
    /// <seealso href="http://data.europa.eu/eli/ontology#version_date">http://data.europa.eu/eli/ontology#version_date</seealso>
    let version_date = Prefixed_Name(eli, "version_date") |> PrefixedName
