namespace http.vocab.getty.edu.ontology.hash

open DoxAletheia

module gvp =
    let _namespace_name = "http://vocab.getty.edu/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Place defined by administrative boundaries and conditions, including inhabited places, nations, and empires. Used in TGN only
    /// <see href="http://vocab.getty.edu/ontology#AdminPlaceConcept"></see></summary>
    let AdminPlaceConcept = _prefix "AdminPlaceConcept"
    /// <summary>
    /// Node in a GVP vocabulary hierarchy.
    /// May be Facet, GuideTerm, Hierarchy, Concept, AdminPlaceConcept, PhysPlaceConcept, PhysAdminPlaceConcept, or ObsoleteSubject.
    /// Implemented as skos:Concept or iso:ThesaurusArray and skos:Collection
    /// <see href="http://vocab.getty.edu/ontology#Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    /// Biography of a ULAN agent (schema:Person|Organization). Depending on the agent, has these fields:
    /// - schema:description: one-line-biography
    /// - gvp:estStart
    /// - schema:birthPlace | foundationLocation, pointing to TGN
    /// - gvp:estEnd
    /// - schema:deathPlace | dissolutionLocation, pointing to TGN
    /// - schema:gender, pointing to AAT (male, female, other)
    /// - dct:contributor
    /// The fields of the preferred biogrpahy are also available in the agent.
    /// <see href="http://vocab.getty.edu/ontology#Biography"></see></summary>
    let Biography = _prefix "Biography"
    /// <summary>
    /// Proper concept. Used in AAT only; TGN &amp; ULAN have their own, e.g. gvp:PhysPlaceConcept &amp; gvp:PersonConcept. Used for indexing and cataloguing
    /// <see href="http://vocab.getty.edu/ontology#Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// One of the major divisions of a vocabulary
    /// <see href="http://vocab.getty.edu/ontology#Facet"></see></summary>
    let Facet = _prefix "Facet"
    /// <summary>
    /// Two or more people who generally worked together to collectively create art. Not necessarily legally incorporated. A family of artists may be considered a "corporate body". Corresponds to crm:E74_Group, not its subclass crm:E40_Legal_Body
    /// <see href="http://vocab.getty.edu/ontology#GroupConcept"></see></summary>
    let GroupConcept = _prefix "GroupConcept"
    /// <summary>
    /// Guide Term: place holder to create a level in the hierarchy. Used in AAT and ULAN. Not used for indexing or cataloguing.
    /// <see href="http://vocab.getty.edu/ontology#GuideTerm"></see></summary>
    let GuideTerm = _prefix "GuideTerm"
    /// <summary>
    /// Top of a hierarchy. Used in AAT only. Not used for indexing or cataloguing
    /// <see href="http://vocab.getty.edu/ontology#Hierarchy"></see></summary>
    let Hierarchy = _prefix "Hierarchy"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_broaderNonConcept_PropChainType2"></see>
    /// </summary>
    let Infer_broaderNonConcept_PropChainType2 =
        _prefix "Infer_broaderNonConcept_PropChainType2"

    /// <summary>
    /// Chain of gvp:broader from Concept to GuideTerms, without intervening Concept
    /// <see href="http://vocab.getty.edu/ontology#broaderNonConcept"></see></summary>
    let broaderNonConcept = _prefix "broaderNonConcept"
    /// <summary>
    /// Parents of a subject. Each broader is also Preferred|NonPreferred and Partitive|Instantial|Generic
    /// <see href="http://vocab.getty.edu/ontology#broader"></see></summary>
    let broader = _prefix "broader"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_broaderNonConcept_TypeRestr"></see>
    /// </summary>
    let Infer_broaderNonConcept_TypeRestr = _prefix "Infer_broaderNonConcept_TypeRestr"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_broaderPreferredExtended"></see>
    /// </summary>
    let Infer_broaderPreferredExtended = _prefix "Infer_broaderPreferredExtended"
    /// <summary>
    /// Preferred Ancestors. Meaningful closure of gvp:broaderPreferred. Needed to display the hierarchy
    /// <see href="http://vocab.getty.edu/ontology#broaderPreferredExtended"></see></summary>
    let broaderPreferredExtended = _prefix "broaderPreferredExtended"
    /// <summary>
    /// Main parent of a subject. Needed to display the hierarchy
    /// <see href="http://vocab.getty.edu/ontology#broaderPreferred"></see></summary>
    let broaderPreferred = _prefix "broaderPreferred"
    /// <summary>
    /// Appropriate ancestors. Meaningful closure of gvp:broader for query expansion. Use this, not skos:broaderTransitive
    /// <see href="http://vocab.getty.edu/ontology#broaderExtended"></see></summary>
    let broaderExtended = _prefix "broaderExtended"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_isoBroaderGeneric"></see>
    /// </summary>
    let Infer_isoBroaderGeneric = _prefix "Infer_isoBroaderGeneric"
    /// <summary>
    /// Ancestors (Generic). Meaningful closure of gvp:broaderGeneric. Infers iso:broaderGeneric for pairs of directly related skos:Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderGenericExtended"></see></summary>
    let broaderGenericExtended = _prefix "broaderGenericExtended"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_isoBroaderInstantial"></see>
    /// </summary>
    let Infer_isoBroaderInstantial = _prefix "Infer_isoBroaderInstantial"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#broaderInstantialExtended"></see>
    /// </summary>
    let broaderInstantialExtended = _prefix "broaderInstantialExtended"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_isoBroaderPartitive"></see>
    /// </summary>
    let Infer_isoBroaderPartitive = _prefix "Infer_isoBroaderPartitive"
    /// <summary>
    /// Ancestors (Partitive). Meaningful closure of gvp:broaderPartitive. Infers iso:broaderPartitive for pairs of directly related skos:Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderPartitiveExtended"></see></summary>
    let broaderPartitiveExtended = _prefix "broaderPartitiveExtended"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_skosBroader_PropChainType2"></see>
    /// </summary>
    let Infer_skosBroader_PropChainType2 = _prefix "Infer_skosBroader_PropChainType2"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_skosBroader_TypeRestr"></see>
    /// </summary>
    let Infer_skosBroader_TypeRestr = _prefix "Infer_skosBroader_TypeRestr"
    /// <summary>
    /// Obsolete subject: moved out of the publishable hierarchy, or merged to another (pointed by dct:isReplacedBy)
    /// <see href="http://vocab.getty.edu/ontology#ObsoleteSubject"></see></summary>
    let ObsoleteSubject = _prefix "ObsoleteSubject"
    /// <summary>
    /// A single individual. Usually people engaged in the design or creation of art or architecture ("Artists"); but may also include donors, patrons, rulers, sitters, art historians, etc ("Non-Artists")
    /// <see href="http://vocab.getty.edu/ontology#PersonConcept"></see></summary>
    let PersonConcept = _prefix "PersonConcept"
    /// <summary>
    /// Place that is both administrative and physical. Rarely used. Used in TGN only
    /// <see href="http://vocab.getty.edu/ontology#PhysAdminPlaceConcept"></see></summary>
    let PhysAdminPlaceConcept = _prefix "PhysAdminPlaceConcept"
    /// <summary>
    /// Physical feature, defined by its physical characteristics on planet Earth, including mountains, rivers, and oceans. Used in TGN only
    /// <see href="http://vocab.getty.edu/ontology#PhysPlaceConcept"></see></summary>
    let PhysPlaceConcept = _prefix "PhysPlaceConcept"
    /// <summary>
    /// Defines a GVP subject or provides usage information. Has fields:
    /// - dc:identifier: numeric ID, also used in the URL.
    /// - rdf:value: the note itself (as per SKOS Primer: 4.2 Advanced Documentation Features) with language tag
    /// - dct:language: matches the language tag
    /// - gvp:displayOrder, order of this note amongst others
    /// - gvp:historicFlag, gvp:estStart, gvp:estEnd, rdfs:comment: Historic Information about applicability
    /// - dct:source or subproperties thereof
    /// - dct:contributor or subproperties thereof
    /// <see href="http://vocab.getty.edu/ontology#ScopeNote"></see></summary>
    let ScopeNote = _prefix "ScopeNote"
    /// <summary>
    /// Unknown person representing a nationality/culture (the Unknown People by Culture facet)
    /// <see href="http://vocab.getty.edu/ontology#UnknownPersonConcept"></see></summary>
    let UnknownPersonConcept = _prefix "UnknownPersonConcept"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2000_related_to"></see>
    /// </summary>
    let aat2000_related_to = _prefix "aat2000_related_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2001_formerly_referred_to"></see>
    /// </summary>
    let aat2001_formerly_referred_to = _prefix "aat2001_formerly_referred_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2100_distinguished_from"></see>
    /// </summary>
    let aat2100_distinguished_from = _prefix "aat2100_distinguished_from"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2110_meaning-usage_overlaps_with"></see>
    /// </summary>
    let ``aat2110_meaning-usage_overlaps_with`` =
        _prefix "aat2110_meaning-usage_overlaps_with"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2203_associated_with"></see>
    /// </summary>
    let aat2203_associated_with = _prefix "aat2203_associated_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2205_causes-is_required"></see>
    /// </summary>
    let ``aat2205_causes-is_required`` = _prefix "aat2205_causes-is_required"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2206_caused_by-requires"></see>
    /// </summary>
    let ``aat2206_caused_by-requires`` = _prefix "aat2206_caused_by-requires"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2208_locus-setting_for"></see>
    /// </summary>
    let ``aat2208_locus-setting_for`` = _prefix "aat2208_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2209_used-located_in"></see>
    /// </summary>
    let ``aat2209_used-located_in`` = _prefix "aat2209_used-located_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2211_produce"></see>
    /// </summary>
    let aat2211_produce = _prefix "aat2211_produce"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2212_produced_by"></see>
    /// </summary>
    let aat2212_produced_by = _prefix "aat2212_produced_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2215_required_for"></see>
    /// </summary>
    let aat2215_required_for = _prefix "aat2215_required_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2216_require"></see>
    /// </summary>
    let aat2216_require = _prefix "aat2216_require"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2218_used-function_as"></see>
    /// </summary>
    let ``aat2218_used-function_as`` = _prefix "aat2218_used-function_as"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2219_have_form"></see>
    /// </summary>
    let aat2219_have_form = _prefix "aat2219_have_form"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2221_act_upon"></see>
    /// </summary>
    let aat2221_act_upon = _prefix "aat2221_act_upon"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2222_are_acted_upon"></see>
    /// </summary>
    let aat2222_are_acted_upon = _prefix "aat2222_are_acted_upon"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2281_have_counterpart"></see>
    /// </summary>
    let aat2281_have_counterpart = _prefix "aat2281_have_counterpart"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2285_practiced-studied_by"></see>
    /// </summary>
    let ``aat2285_practiced-studied_by`` = _prefix "aat2285_practiced-studied_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2286_practice-study"></see>
    /// </summary>
    let ``aat2286_practice-study`` = _prefix "aat2286_practice-study"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2291_locus-setting_for"></see>
    /// </summary>
    let ``aat2291_locus-setting_for`` = _prefix "aat2291_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2292_work-live_in"></see>
    /// </summary>
    let ``aat2292_work-live_in`` = _prefix "aat2292_work-live_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2294_locus-setting_for"></see>
    /// </summary>
    let ``aat2294_locus-setting_for`` = _prefix "aat2294_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2295_located_in"></see>
    /// </summary>
    let aat2295_located_in = _prefix "aat2295_located_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2311_performed_by"></see>
    /// </summary>
    let aat2311_performed_by = _prefix "aat2311_performed_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2312_perform"></see>
    /// </summary>
    let aat2312_perform = _prefix "aat2312_perform"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2315_used_by"></see>
    /// </summary>
    let aat2315_used_by = _prefix "aat2315_used_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2316_use"></see>
    /// </summary>
    let aat2316_use = _prefix "aat2316_use"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2318_involved_in"></see>
    /// </summary>
    let aat2318_involved_in = _prefix "aat2318_involved_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2319_involves"></see>
    /// </summary>
    let aat2319_involves = _prefix "aat2319_involves"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2321_used_by"></see>
    /// </summary>
    let aat2321_used_by = _prefix "aat2321_used_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2322_use"></see>
    /// </summary>
    let aat2322_use = _prefix "aat2322_use"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2325_created_by"></see>
    /// </summary>
    let aat2325_created_by = _prefix "aat2325_created_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2326_create"></see>
    /// </summary>
    let aat2326_create = _prefix "aat2326_create"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2328_involved_with"></see>
    /// </summary>
    let aat2328_involved_with = _prefix "aat2328_involved_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2329_involves"></see>
    /// </summary>
    let aat2329_involves = _prefix "aat2329_involves"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2332_affiliated_with"></see>
    /// </summary>
    let aat2332_affiliated_with = _prefix "aat2332_affiliated_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2333_have_affiliates"></see>
    /// </summary>
    let aat2333_have_affiliates = _prefix "aat2333_have_affiliates"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2335_associated_with"></see>
    /// </summary>
    let aat2335_associated_with = _prefix "aat2335_associated_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2336_has_associates"></see>
    /// </summary>
    let aat2336_has_associates = _prefix "aat2336_has_associates"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2397_focus_of"></see>
    /// </summary>
    let aat2397_focus_of = _prefix "aat2397_focus_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2398_focuses_on"></see>
    /// </summary>
    let aat2398_focuses_on = _prefix "aat2398_focuses_on"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2408_locus-setting_for"></see>
    /// </summary>
    let ``aat2408_locus-setting_for`` = _prefix "aat2408_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2409_takes_place_in"></see>
    /// </summary>
    let aat2409_takes_place_in = _prefix "aat2409_takes_place_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2411_involved_in"></see>
    /// </summary>
    let aat2411_involved_in = _prefix "aat2411_involved_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2412_involves"></see>
    /// </summary>
    let aat2412_involves = _prefix "aat2412_involves"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2415_required_for"></see>
    /// </summary>
    let aat2415_required_for = _prefix "aat2415_required_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2416_requires"></see>
    /// </summary>
    let aat2416_requires = _prefix "aat2416_requires"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2418_uses"></see>
    /// </summary>
    let aat2418_uses = _prefix "aat2418_uses"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2419_used_for"></see>
    /// </summary>
    let aat2419_used_for = _prefix "aat2419_used_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2421_locus-setting_for"></see>
    /// </summary>
    let ``aat2421_locus-setting_for`` = _prefix "aat2421_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2422_takes_place_in"></see>
    /// </summary>
    let aat2422_takes_place_in = _prefix "aat2422_takes_place_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2424_produced_by"></see>
    /// </summary>
    let aat2424_produced_by = _prefix "aat2424_produced_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2425_produces"></see>
    /// </summary>
    let aat2425_produces = _prefix "aat2425_produces"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2427_produced_by"></see>
    /// </summary>
    let aat2427_produced_by = _prefix "aat2427_produced_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2428_produces"></see>
    /// </summary>
    let aat2428_produces = _prefix "aat2428_produces"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2431_required_for"></see>
    /// </summary>
    let aat2431_required_for = _prefix "aat2431_required_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2432_requires"></see>
    /// </summary>
    let aat2432_requires = _prefix "aat2432_requires"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2434_contextualized_in"></see>
    /// </summary>
    let aat2434_contextualized_in = _prefix "aat2434_contextualized_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2435_context_for"></see>
    /// </summary>
    let aat2435_context_for = _prefix "aat2435_context_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2501_made_of-require"></see>
    /// </summary>
    let ``aat2501_made_of-require`` = _prefix "aat2501_made_of-require"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2502_material_for"></see>
    /// </summary>
    let aat2502_material_for = _prefix "aat2502_material_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2504_used-located_in"></see>
    /// </summary>
    let ``aat2504_used-located_in`` = _prefix "aat2504_used-located_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2505_locus-setting_for"></see>
    /// </summary>
    let ``aat2505_locus-setting_for`` = _prefix "aat2505_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2507_produce-process"></see>
    /// </summary>
    let ``aat2507_produce-process`` = _prefix "aat2507_produce-process"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2508_produced-processed_by"></see>
    /// </summary>
    let ``aat2508_produced-processed_by`` = _prefix "aat2508_produced-processed_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2551_reflect-produced_by"></see>
    /// </summary>
    let ``aat2551_reflect-produced_by`` = _prefix "aat2551_reflect-produced_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2552_reflected_in-produces"></see>
    /// </summary>
    let ``aat2552_reflected_in-produces`` = _prefix "aat2552_reflected_in-produces"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2554_reflects"></see>
    /// </summary>
    let aat2554_reflects = _prefix "aat2554_reflects"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2555_reflected_in"></see>
    /// </summary>
    let aat2555_reflected_in = _prefix "aat2555_reflected_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2557_reflects"></see>
    /// </summary>
    let aat2557_reflects = _prefix "aat2557_reflects"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2558_reflected_in"></see>
    /// </summary>
    let aat2558_reflected_in = _prefix "aat2558_reflected_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2562_locus-setting_for"></see>
    /// </summary>
    let ``aat2562_locus-setting_for`` = _prefix "aat2562_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2563_located_in"></see>
    /// </summary>
    let aat2563_located_in = _prefix "aat2563_located_in"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2601_possessed_by-existing_in"></see>
    /// </summary>
    let ``aat2601_possessed_by-existing_in`` =
        _prefix "aat2601_possessed_by-existing_in"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2602_possess-exist_in"></see>
    /// </summary>
    let ``aat2602_possess-exist_in`` = _prefix "aat2602_possess-exist_in"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2604_possessed_by-existing_in"></see>
    /// </summary>
    let ``aat2604_possessed_by-existing_in`` =
        _prefix "aat2604_possessed_by-existing_in"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2605_possess-exist_in"></see>
    /// </summary>
    let ``aat2605_possess-exist_in`` = _prefix "aat2605_possess-exist_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2607_caused_by-requires"></see>
    /// </summary>
    let ``aat2607_caused_by-requires`` = _prefix "aat2607_caused_by-requires"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2608_causes-required_for"></see>
    /// </summary>
    let ``aat2608_causes-required_for`` = _prefix "aat2608_causes-required_for"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2612_possessed_by-existing_in"></see>
    /// </summary>
    let ``aat2612_possessed_by-existing_in`` =
        _prefix "aat2612_possessed_by-existing_in"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2613_possess-exist_in"></see>
    /// </summary>
    let ``aat2613_possess-exist_in`` = _prefix "aat2613_possess-exist_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2801_conjuncted_with"></see>
    /// </summary>
    let aat2801_conjuncted_with = _prefix "aat2801_conjuncted_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2802_exemplified_by"></see>
    /// </summary>
    let aat2802_exemplified_by = _prefix "aat2802_exemplified_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2803_example_of"></see>
    /// </summary>
    let aat2803_example_of = _prefix "aat2803_example_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2805_contextualized_in"></see>
    /// </summary>
    let aat2805_contextualized_in = _prefix "aat2805_contextualized_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2806_provide_context"></see>
    /// </summary>
    let aat2806_provide_context = _prefix "aat2806_provide_context"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2807_derived_from_common_source"></see>
    /// </summary>
    let aat2807_derived_from_common_source =
        _prefix "aat2807_derived_from_common_source"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2809_coexisted_with"></see>
    /// </summary>
    let aat2809_coexisted_with = _prefix "aat2809_coexisted_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2811_preceded"></see>
    /// </summary>
    let aat2811_preceded = _prefix "aat2811_preceded"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2812_followed"></see>
    /// </summary>
    let aat2812_followed = _prefix "aat2812_followed"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2814_constituent_of"></see>
    /// </summary>
    let aat2814_constituent_of = _prefix "aat2814_constituent_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2815_composed_of"></see>
    /// </summary>
    let aat2815_composed_of = _prefix "aat2815_composed_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2817_derived-made_from"></see>
    /// </summary>
    let ``aat2817_derived-made_from`` = _prefix "aat2817_derived-made_from"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2818_source_for"></see>
    /// </summary>
    let aat2818_source_for = _prefix "aat2818_source_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2821_based_on"></see>
    /// </summary>
    let aat2821_based_on = _prefix "aat2821_based_on"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2822_basis_of"></see>
    /// </summary>
    let aat2822_basis_of = _prefix "aat2822_basis_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2824_has_parallels_with"></see>
    /// </summary>
    let aat2824_has_parallels_with = _prefix "aat2824_has_parallels_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2826_used_with"></see>
    /// </summary>
    let aat2826_used_with = _prefix "aat2826_used_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2828_use-require"></see>
    /// </summary>
    let ``aat2828_use-require`` = _prefix "aat2828_use-require"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2829_used-required_for"></see>
    /// </summary>
    let ``aat2829_used-required_for`` = _prefix "aat2829_used-required_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2831_associated_with"></see>
    /// </summary>
    let aat2831_associated_with = _prefix "aat2831_associated_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2833_ancestor_of"></see>
    /// </summary>
    let aat2833_ancestor_of = _prefix "aat2833_ancestor_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2834_decendant_of"></see>
    /// </summary>
    let aat2834_decendant_of = _prefix "aat2834_decendant_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2836_derived-made_from"></see>
    /// </summary>
    let ``aat2836_derived-made_from`` = _prefix "aat2836_derived-made_from"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2837_source_for"></see>
    /// </summary>
    let aat2837_source_for = _prefix "aat2837_source_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2841_derived-made_from"></see>
    /// </summary>
    let ``aat2841_derived-made_from`` = _prefix "aat2841_derived-made_from"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2842_source_for"></see>
    /// </summary>
    let aat2842_source_for = _prefix "aat2842_source_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2845_used-located_in"></see>
    /// </summary>
    let ``aat2845_used-located_in`` = _prefix "aat2845_used-located_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2846_locus-setting_for"></see>
    /// </summary>
    let ``aat2846_locus-setting_for`` = _prefix "aat2846_locus-setting_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2848_involved_in"></see>
    /// </summary>
    let aat2848_involved_in = _prefix "aat2848_involved_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2849_involves"></see>
    /// </summary>
    let aat2849_involves = _prefix "aat2849_involves"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2852_involved_with"></see>
    /// </summary>
    let aat2852_involved_with = _prefix "aat2852_involved_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2853_involve"></see>
    /// </summary>
    let aat2853_involve = _prefix "aat2853_involve"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2875_characteristic_of"></see>
    /// </summary>
    let aat2875_characteristic_of = _prefix "aat2875_characteristic_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2876_characterized_by"></see>
    /// </summary>
    let aat2876_characterized_by = _prefix "aat2876_characterized_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2878_preceded-source_for"></see>
    /// </summary>
    let ``aat2878_preceded-source_for`` = _prefix "aat2878_preceded-source_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2879_followed-developed_from"></see>
    /// </summary>
    let ``aat2879_followed-developed_from`` = _prefix "aat2879_followed-developed_from"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2881_reflected_in"></see>
    /// </summary>
    let aat2881_reflected_in = _prefix "aat2881_reflected_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2882_reflect"></see>
    /// </summary>
    let aat2882_reflect = _prefix "aat2882_reflect"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2884_involved_with"></see>
    /// </summary>
    let aat2884_involved_with = _prefix "aat2884_involved_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2885_involves"></see>
    /// </summary>
    let aat2885_involves = _prefix "aat2885_involves"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2891_exemplified_by"></see>
    /// </summary>
    let aat2891_exemplified_by = _prefix "aat2891_exemplified_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2892_example_of"></see>
    /// </summary>
    let aat2892_example_of = _prefix "aat2892_example_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2894_exemplified_by"></see>
    /// </summary>
    let aat2894_exemplified_by = _prefix "aat2894_exemplified_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2895_example_of"></see>
    /// </summary>
    let aat2895_example_of = _prefix "aat2895_example_of"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2900_miscellaneous_relationship"></see>
    /// </summary>
    let aat2900_miscellaneous_relationship =
        _prefix "aat2900_miscellaneous_relationship"

    /// <summary>
    /// Type of a ULAN PersonConcept or GroupConcept. Domain is ULAN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#agentType"></see></summary>
    let agentType = _prefix "agentType"
    /// <summary>
    /// A secondary type of a ULAN Person or Corporate body. Domain is ULAN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#agentTypeNonPreferred"></see></summary>
    let agentTypeNonPreferred = _prefix "agentTypeNonPreferred"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#agentTypePreferred"></see>
    /// </summary>
    let agentTypePreferred = _prefix "agentTypePreferred"
    /// <summary>
    /// Biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The preferred biography fields are also directly available in the Person/Organization
    /// <see href="http://vocab.getty.edu/ontology#biography"></see></summary>
    let biography = _prefix "biography"
    /// <summary>
    /// Non-preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography
    /// <see href="http://vocab.getty.edu/ontology#biographyNonPreferred"></see></summary>
    let biographyNonPreferred = _prefix "biographyNonPreferred"
    /// <summary>
    /// Preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The biography fields are also directly available in the Person/Organization
    /// <see href="http://vocab.getty.edu/ontology#biographyPreferred"></see></summary>
    let biographyPreferred = _prefix "biographyPreferred"
    /// <summary>
    /// BTG (Genus/Species, "is a") relation. We also infer iso-thes:broaderGeneric, which goes only between Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderGeneric"></see></summary>
    let broaderGeneric = _prefix "broaderGeneric"
    /// <summary>
    /// BTI (Kind/Instance, "example of") relation. We also infer iso-thes:broaderInstantial, which goes only between Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderInstantial"></see></summary>
    let broaderInstantial = _prefix "broaderInstantial"
    /// <summary>
    /// Auxiliary parents of a subject. Very often there are several non-preferred parents (poly-hierarchy). Can use to mark such parents with [N] in displays
    /// <see href="http://vocab.getty.edu/ontology#broaderNonPreferred"></see></summary>
    let broaderNonPreferred = _prefix "broaderNonPreferred"
    /// <summary>
    /// BTP (Part/Whole, "part of") relation. We also infer iso-thes:broaderPartitive, which goes only between Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderPartitive"></see></summary>
    let broaderPartitive = _prefix "broaderPartitive"
    /// <summary>
    /// Contributor for which the term is Alternate Preferred. Range is foaf:Agent
    /// <see href="http://vocab.getty.edu/ontology#contributorAlternatePreferred"></see></summary>
    let contributorAlternatePreferred = _prefix "contributorAlternatePreferred"
    /// <summary>
    /// Contributor for which the term is Non-preferred. Range is foaf:Agent
    /// <see href="http://vocab.getty.edu/ontology#contributorNonPreferred"></see></summary>
    let contributorNonPreferred = _prefix "contributorNonPreferred"
    /// <summary>
    /// Contributor for which the term is Preferred. Range is foaf:Agent
    /// <see href="http://vocab.getty.edu/ontology#contributorPreferred"></see></summary>
    let contributorPreferred = _prefix "contributorPreferred"
    /// <summary>
    /// Display order of subject or term amongst its siblings.
    /// If all are 1 then use alphabetical. Domain is gvp:Subject or skosxl:Label
    /// <see href="http://vocab.getty.edu/ontology#displayOrder"></see></summary>
    let displayOrder = _prefix "displayOrder"
    /// <summary>
    /// Estimated end date of term, relation, type assignment, event, biography
    /// <see href="http://vocab.getty.edu/ontology#estEnd"></see></summary>
    let estEnd = _prefix "estEnd"
    /// <summary>
    /// Estimated start date of term, relation, type assignment, event, biography
    /// <see href="http://vocab.getty.edu/ontology#estStart"></see></summary>
    let estStart = _prefix "estStart"
    /// <summary>
    /// Non-preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event
    /// <see href="http://vocab.getty.edu/ontology#eventNonPreferred"></see></summary>
    let eventNonPreferred = _prefix "eventNonPreferred"
    /// <summary>
    /// Preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event
    /// <see href="http://vocab.getty.edu/ontology#eventPreferred"></see></summary>
    let eventPreferred = _prefix "eventPreferred"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#historicFlag"></see>
    /// </summary>
    let historicFlag = _prefix "historicFlag"
    /// <summary>
    /// Non-preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#nationalityNonPreferred"></see></summary>
    let nationalityNonPreferred = _prefix "nationalityNonPreferred"
    /// <summary>
    /// Preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#nationalityPreferred"></see></summary>
    let nationalityPreferred = _prefix "nationalityPreferred"
    /// <summary>
    /// Preferred labels of *all* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's full context
    /// <see href="http://vocab.getty.edu/ontology#parentString"></see></summary>
    let parentString = _prefix "parentString"
    /// <summary>
    /// Preferred labels of *some* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's context
    /// <see href="http://vocab.getty.edu/ontology#parentStringAbbrev"></see></summary>
    let parentStringAbbrev = _prefix "parentStringAbbrev"
    /// <summary>
    /// Type for a TGN place. Domain is TGN concept (AdminPlaceConcept or PhysPlaceConcept), range is AAT Concept
    /// <see href="http://vocab.getty.edu/ontology#placeType"></see></summary>
    let placeType = _prefix "placeType"
    /// <summary>
    /// A secondary type for a TGN Place. Domain is TGN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#placeTypeNonPreferred"></see></summary>
    let placeTypeNonPreferred = _prefix "placeTypeNonPreferred"
    /// <summary>
    /// The primary type of a TGN Place. Domain is TGN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#placeTypePreferred"></see></summary>
    let placeTypePreferred = _prefix "placeTypePreferred"
    /// <summary>
    /// Term preferred by the Getty Vocabulary Program. The language is usually English. Applicable to AAT, ULAN, TGN. Used with skosxl:prefLabel
    /// <see href="http://vocab.getty.edu/ontology#prefLabelGVP"></see></summary>
    let prefLabelGVP = _prefix "prefLabelGVP"
    /// <summary>
    /// Term preferred by Library of Congress, thus used for cataloging according to AACR2. Applicable to AAT and ULAN. Used with skosxl:prefLabel
    /// <see href="http://vocab.getty.edu/ontology#prefLabelLoC"></see></summary>
    let prefLabelLoC = _prefix "prefLabelLoC"
    /// <summary>
    /// Clarifies and disambiguates terms with the same spelling but different meaning.
    /// Appended in parentheses to gvp:term, forming skosxsl:literalForm.
    /// Every qualifier is in the same language as the term
    /// <see href="http://vocab.getty.edu/ontology#qualifier"></see></summary>
    let qualifier = _prefix "qualifier"
    /// <summary>
    /// Source for which the term is Alternate Preferred. Range is bibo:Document or bibo:DocumentPart
    /// <see href="http://vocab.getty.edu/ontology#sourceAlternatePreferred"></see></summary>
    let sourceAlternatePreferred = _prefix "sourceAlternatePreferred"
    /// <summary>
    /// Source for which the term is Non-preferred. Range is bibo:Document or bibo:DocumentPart
    /// <see href="http://vocab.getty.edu/ontology#sourceNonPreferred"></see></summary>
    let sourceNonPreferred = _prefix "sourceNonPreferred"
    /// <summary>
    /// Source for which the term is Preferred. Range is bibo:Document or bibo:DocumentPart
    /// <see href="http://vocab.getty.edu/ontology#sourcePreferred"></see></summary>
    let sourcePreferred = _prefix "sourcePreferred"
    /// <summary>
    /// Term (label), used as the basic (prefix) part of skosxsl:literalForm
    /// <see href="http://vocab.getty.edu/ontology#term"></see></summary>
    let term = _prefix "term"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termDisplay"></see>
    /// </summary>
    let termDisplay = _prefix "termDisplay"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termFlag"></see>
    /// </summary>
    let termFlag = _prefix "termFlag"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termKind"></see>
    /// </summary>
    let termKind = _prefix "termKind"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termPOS"></see>
    /// </summary>
    let termPOS = _prefix "termPOS"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termType"></see>
    /// </summary>
    let termType = _prefix "termType"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3000_related_to"></see>
    /// </summary>
    let tgn3000_related_to = _prefix "tgn3000_related_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3001_distinguished_from"></see>
    /// </summary>
    let tgn3001_distinguished_from = _prefix "tgn3001_distinguished_from"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3005_possibly_identified_as"></see>
    /// </summary>
    let tgn3005_possibly_identified_as = _prefix "tgn3005_possibly_identified_as"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3006_formerly_identified_as"></see>
    /// </summary>
    let tgn3006_formerly_identified_as = _prefix "tgn3006_formerly_identified_as"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3101_near-adjacent_to"></see>
    /// </summary>
    let ``tgn3101_near-adjacent_to`` = _prefix "tgn3101_near-adjacent_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3102_coextensive_with"></see>
    /// </summary>
    let tgn3102_coextensive_with = _prefix "tgn3102_coextensive_with"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3110_meaning-usage_overlaps_with"></see>
    /// </summary>
    let ``tgn3110_meaning-usage_overlaps_with`` =
        _prefix "tgn3110_meaning-usage_overlaps_with"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3201_capital_of"></see>
    /// </summary>
    let tgn3201_capital_of = _prefix "tgn3201_capital_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3202_capital_is"></see>
    /// </summary>
    let tgn3202_capital_is = _prefix "tgn3202_capital_is"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3301_ally_of"></see>
    /// </summary>
    let tgn3301_ally_of = _prefix "tgn3301_ally_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3317_member_of"></see>
    /// </summary>
    let tgn3317_member_of = _prefix "tgn3317_member_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3318_member_is"></see>
    /// </summary>
    let tgn3318_member_is = _prefix "tgn3318_member_is"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3401_moved_from"></see>
    /// </summary>
    let tgn3401_moved_from = _prefix "tgn3401_moved_from"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3402_moved_to"></see>
    /// </summary>
    let tgn3402_moved_to = _prefix "tgn3402_moved_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3411_successor_of"></see>
    /// </summary>
    let tgn3411_successor_of = _prefix "tgn3411_successor_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3412_predecessor_of"></see>
    /// </summary>
    let tgn3412_predecessor_of = _prefix "tgn3412_predecessor_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3510_historical_connection"></see>
    /// </summary>
    let tgn3510_historical_connection = _prefix "tgn3510_historical_connection"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3611_administrative_dependent_of"></see>
    /// </summary>
    let tgn3611_administrative_dependent_of =
        _prefix "tgn3611_administrative_dependent_of"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3612_administrative_entity_for"></see>
    /// </summary>
    let tgn3612_administrative_entity_for = _prefix "tgn3612_administrative_entity_for"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1000_related_to"></see>
    /// </summary>
    let ulan1000_related_to = _prefix "ulan1000_related_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1003_associated_with"></see>
    /// </summary>
    let ulan1003_associated_with = _prefix "ulan1003_associated_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1005_possibly_identified_with"></see>
    /// </summary>
    let ulan1005_possibly_identified_with = _prefix "ulan1005_possibly_identified_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1006_formerly_identified_with"></see>
    /// </summary>
    let ulan1006_formerly_identified_with = _prefix "ulan1006_formerly_identified_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1007_distinguished_from"></see>
    /// </summary>
    let ulan1007_distinguished_from = _prefix "ulan1007_distinguished_from"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1008_meaning_-usage_overlaps_with"></see>
    /// </summary>
    let ``ulan1008_meaning_-usage_overlaps_with`` =
        _prefix "ulan1008_meaning_-usage_overlaps_with"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1101_teacher_of"></see>
    /// </summary>
    let ulan1101_teacher_of = _prefix "ulan1101_teacher_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1102_student_of"></see>
    /// </summary>
    let ulan1102_student_of = _prefix "ulan1102_student_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1105_apprentice_of"></see>
    /// </summary>
    let ulan1105_apprentice_of = _prefix "ulan1105_apprentice_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1106_apprentice_was"></see>
    /// </summary>
    let ulan1106_apprentice_was = _prefix "ulan1106_apprentice_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1107_influenced"></see>
    /// </summary>
    let ulan1107_influenced = _prefix "ulan1107_influenced"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1108_influenced_by"></see>
    /// </summary>
    let ulan1108_influenced_by = _prefix "ulan1108_influenced_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1111_master_of"></see>
    /// </summary>
    let ulan1111_master_of = _prefix "ulan1111_master_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1112_master_was"></see>
    /// </summary>
    let ulan1112_master_was = _prefix "ulan1112_master_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1113_fellow_student_of"></see>
    /// </summary>
    let ulan1113_fellow_student_of = _prefix "ulan1113_fellow_student_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1201_patron_of"></see>
    /// </summary>
    let ulan1201_patron_of = _prefix "ulan1201_patron_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1202_patron_was"></see>
    /// </summary>
    let ulan1202_patron_was = _prefix "ulan1202_patron_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1203_donor_of"></see>
    /// </summary>
    let ulan1203_donor_of = _prefix "ulan1203_donor_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1204_donor_was"></see>
    /// </summary>
    let ulan1204_donor_was = _prefix "ulan1204_donor_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1205_client_of"></see>
    /// </summary>
    let ulan1205_client_of = _prefix "ulan1205_client_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1206_client_was"></see>
    /// </summary>
    let ulan1206_client_was = _prefix "ulan1206_client_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1211_artist_to"></see>
    /// </summary>
    let ulan1211_artist_to = _prefix "ulan1211_artist_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1212_artist_was"></see>
    /// </summary>
    let ulan1212_artist_was = _prefix "ulan1212_artist_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1213_court_artist_to"></see>
    /// </summary>
    let ulan1213_court_artist_to = _prefix "ulan1213_court_artist_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1214_court_artist_was"></see>
    /// </summary>
    let ulan1214_court_artist_was = _prefix "ulan1214_court_artist_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1217_employee_of"></see>
    /// </summary>
    let ulan1217_employee_of = _prefix "ulan1217_employee_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1218_employee_was"></see>
    /// </summary>
    let ulan1218_employee_was = _prefix "ulan1218_employee_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1221_appointed_by"></see>
    /// </summary>
    let ulan1221_appointed_by = _prefix "ulan1221_appointed_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1222_appointee_of"></see>
    /// </summary>
    let ulan1222_appointee_of = _prefix "ulan1222_appointee_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1223_crowned_by"></see>
    /// </summary>
    let ulan1223_crowned_by = _prefix "ulan1223_crowned_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1224_crowned"></see>
    /// </summary>
    let ulan1224_crowned = _prefix "ulan1224_crowned"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1301_colleague_of"></see>
    /// </summary>
    let ulan1301_colleague_of = _prefix "ulan1301_colleague_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1302_associate_of"></see>
    /// </summary>
    let ulan1302_associate_of = _prefix "ulan1302_associate_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1303_collaborated_with"></see>
    /// </summary>
    let ulan1303_collaborated_with = _prefix "ulan1303_collaborated_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1305_worked_with"></see>
    /// </summary>
    let ulan1305_worked_with = _prefix "ulan1305_worked_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1306_performs_with"></see>
    /// </summary>
    let ulan1306_performs_with = _prefix "ulan1306_performs_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1307_assistant_of"></see>
    /// </summary>
    let ulan1307_assistant_of = _prefix "ulan1307_assistant_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1308_assisted_by"></see>
    /// </summary>
    let ulan1308_assisted_by = _prefix "ulan1308_assisted_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1309_advisor_of"></see>
    /// </summary>
    let ulan1309_advisor_of = _prefix "ulan1309_advisor_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1310_advised_by"></see>
    /// </summary>
    let ulan1310_advised_by = _prefix "ulan1310_advised_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1311_partner_of"></see>
    /// </summary>
    let ulan1311_partner_of = _prefix "ulan1311_partner_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1313_partner_in"></see>
    /// </summary>
    let ulan1313_partner_in = _prefix "ulan1313_partner_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1314_partner_was"></see>
    /// </summary>
    let ulan1314_partner_was = _prefix "ulan1314_partner_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1315_principal_in"></see>
    /// </summary>
    let ulan1315_principal_in = _prefix "ulan1315_principal_in"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1316_principal_was"></see>
    /// </summary>
    let ulan1316_principal_was = _prefix "ulan1316_principal_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1317_member_of"></see>
    /// </summary>
    let ulan1317_member_of = _prefix "ulan1317_member_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1318_member_was"></see>
    /// </summary>
    let ulan1318_member_was = _prefix "ulan1318_member_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1321_school_of"></see>
    /// </summary>
    let ulan1321_school_of = _prefix "ulan1321_school_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1322_school_was"></see>
    /// </summary>
    let ulan1322_school_was = _prefix "ulan1322_school_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1331_worked_with"></see>
    /// </summary>
    let ulan1331_worked_with = _prefix "ulan1331_worked_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1332_worker_was"></see>
    /// </summary>
    let ulan1332_worker_was = _prefix "ulan1332_worker_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1411_successor_of"></see>
    /// </summary>
    let ulan1411_successor_of = _prefix "ulan1411_successor_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1412_predecessor_of"></see>
    /// </summary>
    let ulan1412_predecessor_of = _prefix "ulan1412_predecessor_of"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1413_administration_overlaps_with"></see>
    /// </summary>
    let ulan1413_administration_overlaps_with =
        _prefix "ulan1413_administration_overlaps_with"

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1414_joint_venture_with"></see>
    /// </summary>
    let ulan1414_joint_venture_with = _prefix "ulan1414_joint_venture_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1421_founded_by"></see>
    /// </summary>
    let ulan1421_founded_by = _prefix "ulan1421_founded_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1422_founded"></see>
    /// </summary>
    let ulan1422_founded = _prefix "ulan1422_founded"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1500_related_to"></see>
    /// </summary>
    let ulan1500_related_to = _prefix "ulan1500_related_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1501_sibling_of"></see>
    /// </summary>
    let ulan1501_sibling_of = _prefix "ulan1501_sibling_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1511_child_of"></see>
    /// </summary>
    let ulan1511_child_of = _prefix "ulan1511_child_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1512_parent_of"></see>
    /// </summary>
    let ulan1512_parent_of = _prefix "ulan1512_parent_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1513_grandchild_of"></see>
    /// </summary>
    let ulan1513_grandchild_of = _prefix "ulan1513_grandchild_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1514_gandparent_of"></see>
    /// </summary>
    let ulan1514_gandparent_of = _prefix "ulan1514_gandparent_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1515_great-grandparent_of"></see>
    /// </summary>
    let ``ulan1515_great-grandparent_of`` = _prefix "ulan1515_great-grandparent_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1516_great-grandchild_of"></see>
    /// </summary>
    let ``ulan1516_great-grandchild_of`` = _prefix "ulan1516_great-grandchild_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1521_cousin_of"></see>
    /// </summary>
    let ulan1521_cousin_of = _prefix "ulan1521_cousin_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1531_nephew-niece_of"></see>
    /// </summary>
    let ``ulan1531_nephew-niece_of`` = _prefix "ulan1531_nephew-niece_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1532_uncle-aunt_of"></see>
    /// </summary>
    let ``ulan1532_uncle-aunt_of`` = _prefix "ulan1532_uncle-aunt_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1541_spouse_of"></see>
    /// </summary>
    let ulan1541_spouse_of = _prefix "ulan1541_spouse_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1542_consort_of"></see>
    /// </summary>
    let ulan1542_consort_of = _prefix "ulan1542_consort_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1543_consort_was"></see>
    /// </summary>
    let ulan1543_consort_was = _prefix "ulan1543_consort_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1544_significant_other_of"></see>
    /// </summary>
    let ulan1544_significant_other_of = _prefix "ulan1544_significant_other_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1547_romantic_partner_of"></see>
    /// </summary>
    let ulan1547_romantic_partner_of = _prefix "ulan1547_romantic_partner_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1548_domestic_partner_of"></see>
    /// </summary>
    let ulan1548_domestic_partner_of = _prefix "ulan1548_domestic_partner_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1550_relative_by_marriage"></see>
    /// </summary>
    let ulan1550_relative_by_marriage = _prefix "ulan1550_relative_by_marriage"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1551_sibling_by_marriage_of"></see>
    /// </summary>
    let ulan1551_sibling_by_marriage_of = _prefix "ulan1551_sibling_by_marriage_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1552_parent_by_marriage_of"></see>
    /// </summary>
    let ulan1552_parent_by_marriage_of = _prefix "ulan1552_parent_by_marriage_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1553_child_by_marriage_of"></see>
    /// </summary>
    let ulan1553_child_by_marriage_of = _prefix "ulan1553_child_by_marriage_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1554_adoptive_parent_of"></see>
    /// </summary>
    let ulan1554_adoptive_parent_of = _prefix "ulan1554_adoptive_parent_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1555_adopted_child_of"></see>
    /// </summary>
    let ulan1555_adopted_child_of = _prefix "ulan1555_adopted_child_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1556_half-sibling_of"></see>
    /// </summary>
    let ``ulan1556_half-sibling_of`` = _prefix "ulan1556_half-sibling_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1557_step-sibling_of"></see>
    /// </summary>
    let ``ulan1557_step-sibling_of`` = _prefix "ulan1557_step-sibling_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1561_step-child_of"></see>
    /// </summary>
    let ``ulan1561_step-child_of`` = _prefix "ulan1561_step-child_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1562_step-parent_of"></see>
    /// </summary>
    let ``ulan1562_step-parent_of`` = _prefix "ulan1562_step-parent_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1571_guardian_of"></see>
    /// </summary>
    let ulan1571_guardian_of = _prefix "ulan1571_guardian_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1573_ward_of"></see>
    /// </summary>
    let ulan1573_ward_of = _prefix "ulan1573_ward_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1574_godparent_of"></see>
    /// </summary>
    let ulan1574_godparent_of = _prefix "ulan1574_godparent_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1575_godchild_of"></see>
    /// </summary>
    let ulan1575_godchild_of = _prefix "ulan1575_godchild_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1581_descendant_of"></see>
    /// </summary>
    let ulan1581_descendant_of = _prefix "ulan1581_descendant_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1582_ancestor_of"></see>
    /// </summary>
    let ulan1582_ancestor_of = _prefix "ulan1582_ancestor_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1590_possibly_related_to"></see>
    /// </summary>
    let ulan1590_possibly_related_to = _prefix "ulan1590_possibly_related_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2550_friend_of"></see>
    /// </summary>
    let ulan2550_friend_of = _prefix "ulan2550_friend_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2572_founder_of"></see>
    /// </summary>
    let ulan2572_founder_of = _prefix "ulan2572_founder_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2573_founded_by"></see>
    /// </summary>
    let ulan2573_founded_by = _prefix "ulan2573_founded_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2574_director_of"></see>
    /// </summary>
    let ulan2574_director_of = _prefix "ulan2574_director_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2575_directed_by"></see>
    /// </summary>
    let ulan2575_directed_by = _prefix "ulan2575_directed_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2576_patron_of"></see>
    /// </summary>
    let ulan2576_patron_of = _prefix "ulan2576_patron_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2577_patron_was"></see>
    /// </summary>
    let ulan2577_patron_was = _prefix "ulan2577_patron_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2578_trustee_of"></see>
    /// </summary>
    let ulan2578_trustee_of = _prefix "ulan2578_trustee_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2579_trustee_was"></see>
    /// </summary>
    let ulan2579_trustee_was = _prefix "ulan2579_trustee_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2581_administrator_of"></see>
    /// </summary>
    let ulan2581_administrator_of = _prefix "ulan2581_administrator_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2582_administered_by"></see>
    /// </summary>
    let ulan2582_administered_by = _prefix "ulan2582_administered_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2650_publisher_was"></see>
    /// </summary>
    let ulan2650_publisher_was = _prefix "ulan2650_publisher_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2651_publisher_of"></see>
    /// </summary>
    let ulan2651_publisher_of = _prefix "ulan2651_publisher_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2674_professor_at"></see>
    /// </summary>
    let ulan2674_professor_at = _prefix "ulan2674_professor_at"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2675_professor_was"></see>
    /// </summary>
    let ulan2675_professor_was = _prefix "ulan2675_professor_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2676_teacher_at"></see>
    /// </summary>
    let ulan2676_teacher_at = _prefix "ulan2676_teacher_at"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2677_teacher_was"></see>
    /// </summary>
    let ulan2677_teacher_was = _prefix "ulan2677_teacher_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2692_president_of"></see>
    /// </summary>
    let ulan2692_president_of = _prefix "ulan2692_president_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2693_president_was"></see>
    /// </summary>
    let ulan2693_president_was = _prefix "ulan2693_president_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2696_leader_of"></see>
    /// </summary>
    let ulan2696_leader_of = _prefix "ulan2696_leader_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2697_leader_was"></see>
    /// </summary>
    let ulan2697_leader_was = _prefix "ulan2697_leader_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2778_owner_of"></see>
    /// </summary>
    let ulan2778_owner_of = _prefix "ulan2778_owner_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2779_owned_by"></see>
    /// </summary>
    let ulan2779_owned_by = _prefix "ulan2779_owned_by"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2781_dedicatee_of"></see>
    /// </summary>
    let ulan2781_dedicatee_of = _prefix "ulan2781_dedicatee_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2782_dedicated_to"></see>
    /// </summary>
    let ulan2782_dedicated_to = _prefix "ulan2782_dedicated_to"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2794_representative_of"></see>
    /// </summary>
    let ulan2794_representative_of = _prefix "ulan2794_representative_of"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2795_representative_was"></see>
    /// </summary>
    let ulan2795_representative_was = _prefix "ulan2795_representative_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2828_student_at"></see>
    /// </summary>
    let ulan2828_student_at = _prefix "ulan2828_student_at"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2829_student_was"></see>
    /// </summary>
    let ulan2829_student_was = _prefix "ulan2829_student_was"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2840_performer_with"></see>
    /// </summary>
    let ulan2840_performer_with = _prefix "ulan2840_performer_with"
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2841_performer_was"></see>
    /// </summary>
    let ulan2841_performer_was = _prefix "ulan2841_performer_was"
