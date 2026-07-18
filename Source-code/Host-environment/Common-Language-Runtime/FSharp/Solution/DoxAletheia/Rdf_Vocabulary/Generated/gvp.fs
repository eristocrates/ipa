namespace http.vocab.getty.edu.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module gvp =
    let _namespace_name = "http://vocab.getty.edu/ontology#"

    /// <summary>
    /// Place defined by administrative boundaries and conditions, including inhabited places, nations, and empires. Used in TGN only
    /// <see href="http://vocab.getty.edu/ontology#AdminPlaceConcept"></see></summary>
    let AdminPlaceConcept =
        Namespaced_IRI.parse _namespace_name "AdminPlaceConcept" |> NamespacedName

    /// <summary>
    /// Node in a GVP vocabulary hierarchy.
    /// May be Facet, GuideTerm, Hierarchy, Concept, AdminPlaceConcept, PhysPlaceConcept, PhysAdminPlaceConcept, or ObsoleteSubject.
    /// Implemented as skos:Concept or iso:ThesaurusArray and skos:Collection
    /// <see href="http://vocab.getty.edu/ontology#Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
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
    let Biography = Namespaced_IRI.parse _namespace_name "Biography" |> NamespacedName
    /// <summary>
    /// Proper concept. Used in AAT only; TGN &amp; ULAN have their own, e.g. gvp:PhysPlaceConcept &amp; gvp:PersonConcept. Used for indexing and cataloguing
    /// <see href="http://vocab.getty.edu/ontology#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName
    /// <summary>
    /// One of the major divisions of a vocabulary
    /// <see href="http://vocab.getty.edu/ontology#Facet"></see></summary>
    let Facet = Namespaced_IRI.parse _namespace_name "Facet" |> NamespacedName

    /// <summary>
    /// Two or more people who generally worked together to collectively create art. Not necessarily legally incorporated. A family of artists may be considered a "corporate body". Corresponds to crm:E74_Group, not its subclass crm:E40_Legal_Body
    /// <see href="http://vocab.getty.edu/ontology#GroupConcept"></see></summary>
    let GroupConcept =
        Namespaced_IRI.parse _namespace_name "GroupConcept" |> NamespacedName

    /// <summary>
    /// Guide Term: place holder to create a level in the hierarchy. Used in AAT and ULAN. Not used for indexing or cataloguing.
    /// <see href="http://vocab.getty.edu/ontology#GuideTerm"></see></summary>
    let GuideTerm = Namespaced_IRI.parse _namespace_name "GuideTerm" |> NamespacedName
    /// <summary>
    /// Top of a hierarchy. Used in AAT only. Not used for indexing or cataloguing
    /// <see href="http://vocab.getty.edu/ontology#Hierarchy"></see></summary>
    let Hierarchy = Namespaced_IRI.parse _namespace_name "Hierarchy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_broaderNonConcept_PropChainType2"></see>
    /// </summary>
    let Infer_broaderNonConcept_PropChainType2 =
        Namespaced_IRI.parse _namespace_name "Infer_broaderNonConcept_PropChainType2" |> NamespacedName

    /// <summary>
    /// Chain of gvp:broader from Concept to GuideTerms, without intervening Concept
    /// <see href="http://vocab.getty.edu/ontology#broaderNonConcept"></see></summary>
    let broaderNonConcept =
        Namespaced_IRI.parse _namespace_name "broaderNonConcept" |> NamespacedName

    /// <summary>
    /// Parents of a subject. Each broader is also Preferred|NonPreferred and Partitive|Instantial|Generic
    /// <see href="http://vocab.getty.edu/ontology#broader"></see></summary>
    let broader = Namespaced_IRI.parse _namespace_name "broader" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_broaderNonConcept_TypeRestr"></see>
    /// </summary>
    let Infer_broaderNonConcept_TypeRestr =
        Namespaced_IRI.parse _namespace_name "Infer_broaderNonConcept_TypeRestr" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_broaderPreferredExtended"></see>
    /// </summary>
    let Infer_broaderPreferredExtended =
        Namespaced_IRI.parse _namespace_name "Infer_broaderPreferredExtended" |> NamespacedName

    /// <summary>
    /// Preferred Ancestors. Meaningful closure of gvp:broaderPreferred. Needed to display the hierarchy
    /// <see href="http://vocab.getty.edu/ontology#broaderPreferredExtended"></see></summary>
    let broaderPreferredExtended =
        Namespaced_IRI.parse _namespace_name "broaderPreferredExtended" |> NamespacedName

    /// <summary>
    /// Main parent of a subject. Needed to display the hierarchy
    /// <see href="http://vocab.getty.edu/ontology#broaderPreferred"></see></summary>
    let broaderPreferred =
        Namespaced_IRI.parse _namespace_name "broaderPreferred" |> NamespacedName

    /// <summary>
    /// Appropriate ancestors. Meaningful closure of gvp:broader for query expansion. Use this, not skos:broaderTransitive
    /// <see href="http://vocab.getty.edu/ontology#broaderExtended"></see></summary>
    let broaderExtended =
        Namespaced_IRI.parse _namespace_name "broaderExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_isoBroaderGeneric"></see>
    /// </summary>
    let Infer_isoBroaderGeneric =
        Namespaced_IRI.parse _namespace_name "Infer_isoBroaderGeneric" |> NamespacedName

    /// <summary>
    /// Ancestors (Generic). Meaningful closure of gvp:broaderGeneric. Infers iso:broaderGeneric for pairs of directly related skos:Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderGenericExtended"></see></summary>
    let broaderGenericExtended =
        Namespaced_IRI.parse _namespace_name "broaderGenericExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_isoBroaderInstantial"></see>
    /// </summary>
    let Infer_isoBroaderInstantial =
        Namespaced_IRI.parse _namespace_name "Infer_isoBroaderInstantial" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#broaderInstantialExtended"></see>
    /// </summary>
    let broaderInstantialExtended =
        Namespaced_IRI.parse _namespace_name "broaderInstantialExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_isoBroaderPartitive"></see>
    /// </summary>
    let Infer_isoBroaderPartitive =
        Namespaced_IRI.parse _namespace_name "Infer_isoBroaderPartitive" |> NamespacedName

    /// <summary>
    /// Ancestors (Partitive). Meaningful closure of gvp:broaderPartitive. Infers iso:broaderPartitive for pairs of directly related skos:Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderPartitiveExtended"></see></summary>
    let broaderPartitiveExtended =
        Namespaced_IRI.parse _namespace_name "broaderPartitiveExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_skosBroader_PropChainType2"></see>
    /// </summary>
    let Infer_skosBroader_PropChainType2 =
        Namespaced_IRI.parse _namespace_name "Infer_skosBroader_PropChainType2" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#Infer_skosBroader_TypeRestr"></see>
    /// </summary>
    let Infer_skosBroader_TypeRestr =
        Namespaced_IRI.parse _namespace_name "Infer_skosBroader_TypeRestr" |> NamespacedName

    /// <summary>
    /// Obsolete subject: moved out of the publishable hierarchy, or merged to another (pointed by dct:isReplacedBy)
    /// <see href="http://vocab.getty.edu/ontology#ObsoleteSubject"></see></summary>
    let ObsoleteSubject =
        Namespaced_IRI.parse _namespace_name "ObsoleteSubject" |> NamespacedName

    /// <summary>
    /// A single individual. Usually people engaged in the design or creation of art or architecture ("Artists"); but may also include donors, patrons, rulers, sitters, art historians, etc ("Non-Artists")
    /// <see href="http://vocab.getty.edu/ontology#PersonConcept"></see></summary>
    let PersonConcept =
        Namespaced_IRI.parse _namespace_name "PersonConcept" |> NamespacedName

    /// <summary>
    /// Place that is both administrative and physical. Rarely used. Used in TGN only
    /// <see href="http://vocab.getty.edu/ontology#PhysAdminPlaceConcept"></see></summary>
    let PhysAdminPlaceConcept =
        Namespaced_IRI.parse _namespace_name "PhysAdminPlaceConcept" |> NamespacedName

    /// <summary>
    /// Physical feature, defined by its physical characteristics on planet Earth, including mountains, rivers, and oceans. Used in TGN only
    /// <see href="http://vocab.getty.edu/ontology#PhysPlaceConcept"></see></summary>
    let PhysPlaceConcept =
        Namespaced_IRI.parse _namespace_name "PhysPlaceConcept" |> NamespacedName

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
    let ScopeNote = Namespaced_IRI.parse _namespace_name "ScopeNote" |> NamespacedName

    /// <summary>
    /// Unknown person representing a nationality/culture (the Unknown People by Culture facet)
    /// <see href="http://vocab.getty.edu/ontology#UnknownPersonConcept"></see></summary>
    let UnknownPersonConcept =
        Namespaced_IRI.parse _namespace_name "UnknownPersonConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2000_related_to"></see>
    /// </summary>
    let aat2000_related_to =
        Namespaced_IRI.parse _namespace_name "aat2000_related_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2001_formerly_referred_to"></see>
    /// </summary>
    let aat2001_formerly_referred_to =
        Namespaced_IRI.parse _namespace_name "aat2001_formerly_referred_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2100_distinguished_from"></see>
    /// </summary>
    let aat2100_distinguished_from =
        Namespaced_IRI.parse _namespace_name "aat2100_distinguished_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2110_meaning-usage_overlaps_with"></see>
    /// </summary>
    let ``aat2110_meaning-usage_overlaps_with`` =
        Namespaced_IRI.parse _namespace_name "aat2110_meaning-usage_overlaps_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2203_associated_with"></see>
    /// </summary>
    let aat2203_associated_with =
        Namespaced_IRI.parse _namespace_name "aat2203_associated_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2205_causes-is_required"></see>
    /// </summary>
    let ``aat2205_causes-is_required`` =
        Namespaced_IRI.parse _namespace_name "aat2205_causes-is_required" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2206_caused_by-requires"></see>
    /// </summary>
    let ``aat2206_caused_by-requires`` =
        Namespaced_IRI.parse _namespace_name "aat2206_caused_by-requires" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2208_locus-setting_for"></see>
    /// </summary>
    let ``aat2208_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2208_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2209_used-located_in"></see>
    /// </summary>
    let ``aat2209_used-located_in`` =
        Namespaced_IRI.parse _namespace_name "aat2209_used-located_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2211_produce"></see>
    /// </summary>
    let aat2211_produce =
        Namespaced_IRI.parse _namespace_name "aat2211_produce" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2212_produced_by"></see>
    /// </summary>
    let aat2212_produced_by =
        Namespaced_IRI.parse _namespace_name "aat2212_produced_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2215_required_for"></see>
    /// </summary>
    let aat2215_required_for =
        Namespaced_IRI.parse _namespace_name "aat2215_required_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2216_require"></see>
    /// </summary>
    let aat2216_require =
        Namespaced_IRI.parse _namespace_name "aat2216_require" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2218_used-function_as"></see>
    /// </summary>
    let ``aat2218_used-function_as`` =
        Namespaced_IRI.parse _namespace_name "aat2218_used-function_as" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2219_have_form"></see>
    /// </summary>
    let aat2219_have_form =
        Namespaced_IRI.parse _namespace_name "aat2219_have_form" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2221_act_upon"></see>
    /// </summary>
    let aat2221_act_upon =
        Namespaced_IRI.parse _namespace_name "aat2221_act_upon" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2222_are_acted_upon"></see>
    /// </summary>
    let aat2222_are_acted_upon =
        Namespaced_IRI.parse _namespace_name "aat2222_are_acted_upon" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2281_have_counterpart"></see>
    /// </summary>
    let aat2281_have_counterpart =
        Namespaced_IRI.parse _namespace_name "aat2281_have_counterpart" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2285_practiced-studied_by"></see>
    /// </summary>
    let ``aat2285_practiced-studied_by`` =
        Namespaced_IRI.parse _namespace_name "aat2285_practiced-studied_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2286_practice-study"></see>
    /// </summary>
    let ``aat2286_practice-study`` =
        Namespaced_IRI.parse _namespace_name "aat2286_practice-study" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2291_locus-setting_for"></see>
    /// </summary>
    let ``aat2291_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2291_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2292_work-live_in"></see>
    /// </summary>
    let ``aat2292_work-live_in`` =
        Namespaced_IRI.parse _namespace_name "aat2292_work-live_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2294_locus-setting_for"></see>
    /// </summary>
    let ``aat2294_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2294_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2295_located_in"></see>
    /// </summary>
    let aat2295_located_in =
        Namespaced_IRI.parse _namespace_name "aat2295_located_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2311_performed_by"></see>
    /// </summary>
    let aat2311_performed_by =
        Namespaced_IRI.parse _namespace_name "aat2311_performed_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2312_perform"></see>
    /// </summary>
    let aat2312_perform =
        Namespaced_IRI.parse _namespace_name "aat2312_perform" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2315_used_by"></see>
    /// </summary>
    let aat2315_used_by =
        Namespaced_IRI.parse _namespace_name "aat2315_used_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2316_use"></see>
    /// </summary>
    let aat2316_use =
        Namespaced_IRI.parse _namespace_name "aat2316_use" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2318_involved_in"></see>
    /// </summary>
    let aat2318_involved_in =
        Namespaced_IRI.parse _namespace_name "aat2318_involved_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2319_involves"></see>
    /// </summary>
    let aat2319_involves =
        Namespaced_IRI.parse _namespace_name "aat2319_involves" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2321_used_by"></see>
    /// </summary>
    let aat2321_used_by =
        Namespaced_IRI.parse _namespace_name "aat2321_used_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2322_use"></see>
    /// </summary>
    let aat2322_use =
        Namespaced_IRI.parse _namespace_name "aat2322_use" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2325_created_by"></see>
    /// </summary>
    let aat2325_created_by =
        Namespaced_IRI.parse _namespace_name "aat2325_created_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2326_create"></see>
    /// </summary>
    let aat2326_create =
        Namespaced_IRI.parse _namespace_name "aat2326_create" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2328_involved_with"></see>
    /// </summary>
    let aat2328_involved_with =
        Namespaced_IRI.parse _namespace_name "aat2328_involved_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2329_involves"></see>
    /// </summary>
    let aat2329_involves =
        Namespaced_IRI.parse _namespace_name "aat2329_involves" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2332_affiliated_with"></see>
    /// </summary>
    let aat2332_affiliated_with =
        Namespaced_IRI.parse _namespace_name "aat2332_affiliated_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2333_have_affiliates"></see>
    /// </summary>
    let aat2333_have_affiliates =
        Namespaced_IRI.parse _namespace_name "aat2333_have_affiliates" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2335_associated_with"></see>
    /// </summary>
    let aat2335_associated_with =
        Namespaced_IRI.parse _namespace_name "aat2335_associated_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2336_has_associates"></see>
    /// </summary>
    let aat2336_has_associates =
        Namespaced_IRI.parse _namespace_name "aat2336_has_associates" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2397_focus_of"></see>
    /// </summary>
    let aat2397_focus_of =
        Namespaced_IRI.parse _namespace_name "aat2397_focus_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2398_focuses_on"></see>
    /// </summary>
    let aat2398_focuses_on =
        Namespaced_IRI.parse _namespace_name "aat2398_focuses_on" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2408_locus-setting_for"></see>
    /// </summary>
    let ``aat2408_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2408_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2409_takes_place_in"></see>
    /// </summary>
    let aat2409_takes_place_in =
        Namespaced_IRI.parse _namespace_name "aat2409_takes_place_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2411_involved_in"></see>
    /// </summary>
    let aat2411_involved_in =
        Namespaced_IRI.parse _namespace_name "aat2411_involved_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2412_involves"></see>
    /// </summary>
    let aat2412_involves =
        Namespaced_IRI.parse _namespace_name "aat2412_involves" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2415_required_for"></see>
    /// </summary>
    let aat2415_required_for =
        Namespaced_IRI.parse _namespace_name "aat2415_required_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2416_requires"></see>
    /// </summary>
    let aat2416_requires =
        Namespaced_IRI.parse _namespace_name "aat2416_requires" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2418_uses"></see>
    /// </summary>
    let aat2418_uses =
        Namespaced_IRI.parse _namespace_name "aat2418_uses" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2419_used_for"></see>
    /// </summary>
    let aat2419_used_for =
        Namespaced_IRI.parse _namespace_name "aat2419_used_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2421_locus-setting_for"></see>
    /// </summary>
    let ``aat2421_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2421_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2422_takes_place_in"></see>
    /// </summary>
    let aat2422_takes_place_in =
        Namespaced_IRI.parse _namespace_name "aat2422_takes_place_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2424_produced_by"></see>
    /// </summary>
    let aat2424_produced_by =
        Namespaced_IRI.parse _namespace_name "aat2424_produced_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2425_produces"></see>
    /// </summary>
    let aat2425_produces =
        Namespaced_IRI.parse _namespace_name "aat2425_produces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2427_produced_by"></see>
    /// </summary>
    let aat2427_produced_by =
        Namespaced_IRI.parse _namespace_name "aat2427_produced_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2428_produces"></see>
    /// </summary>
    let aat2428_produces =
        Namespaced_IRI.parse _namespace_name "aat2428_produces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2431_required_for"></see>
    /// </summary>
    let aat2431_required_for =
        Namespaced_IRI.parse _namespace_name "aat2431_required_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2432_requires"></see>
    /// </summary>
    let aat2432_requires =
        Namespaced_IRI.parse _namespace_name "aat2432_requires" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2434_contextualized_in"></see>
    /// </summary>
    let aat2434_contextualized_in =
        Namespaced_IRI.parse _namespace_name "aat2434_contextualized_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2435_context_for"></see>
    /// </summary>
    let aat2435_context_for =
        Namespaced_IRI.parse _namespace_name "aat2435_context_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2501_made_of-require"></see>
    /// </summary>
    let ``aat2501_made_of-require`` =
        Namespaced_IRI.parse _namespace_name "aat2501_made_of-require" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2502_material_for"></see>
    /// </summary>
    let aat2502_material_for =
        Namespaced_IRI.parse _namespace_name "aat2502_material_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2504_used-located_in"></see>
    /// </summary>
    let ``aat2504_used-located_in`` =
        Namespaced_IRI.parse _namespace_name "aat2504_used-located_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2505_locus-setting_for"></see>
    /// </summary>
    let ``aat2505_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2505_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2507_produce-process"></see>
    /// </summary>
    let ``aat2507_produce-process`` =
        Namespaced_IRI.parse _namespace_name "aat2507_produce-process" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2508_produced-processed_by"></see>
    /// </summary>
    let ``aat2508_produced-processed_by`` =
        Namespaced_IRI.parse _namespace_name "aat2508_produced-processed_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2551_reflect-produced_by"></see>
    /// </summary>
    let ``aat2551_reflect-produced_by`` =
        Namespaced_IRI.parse _namespace_name "aat2551_reflect-produced_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2552_reflected_in-produces"></see>
    /// </summary>
    let ``aat2552_reflected_in-produces`` =
        Namespaced_IRI.parse _namespace_name "aat2552_reflected_in-produces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2554_reflects"></see>
    /// </summary>
    let aat2554_reflects =
        Namespaced_IRI.parse _namespace_name "aat2554_reflects" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2555_reflected_in"></see>
    /// </summary>
    let aat2555_reflected_in =
        Namespaced_IRI.parse _namespace_name "aat2555_reflected_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2557_reflects"></see>
    /// </summary>
    let aat2557_reflects =
        Namespaced_IRI.parse _namespace_name "aat2557_reflects" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2558_reflected_in"></see>
    /// </summary>
    let aat2558_reflected_in =
        Namespaced_IRI.parse _namespace_name "aat2558_reflected_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2562_locus-setting_for"></see>
    /// </summary>
    let ``aat2562_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2562_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2563_located_in"></see>
    /// </summary>
    let aat2563_located_in =
        Namespaced_IRI.parse _namespace_name "aat2563_located_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2601_possessed_by-existing_in"></see>
    /// </summary>
    let ``aat2601_possessed_by-existing_in`` =
        Namespaced_IRI.parse _namespace_name "aat2601_possessed_by-existing_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2602_possess-exist_in"></see>
    /// </summary>
    let ``aat2602_possess-exist_in`` =
        Namespaced_IRI.parse _namespace_name "aat2602_possess-exist_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2604_possessed_by-existing_in"></see>
    /// </summary>
    let ``aat2604_possessed_by-existing_in`` =
        Namespaced_IRI.parse _namespace_name "aat2604_possessed_by-existing_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2605_possess-exist_in"></see>
    /// </summary>
    let ``aat2605_possess-exist_in`` =
        Namespaced_IRI.parse _namespace_name "aat2605_possess-exist_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2607_caused_by-requires"></see>
    /// </summary>
    let ``aat2607_caused_by-requires`` =
        Namespaced_IRI.parse _namespace_name "aat2607_caused_by-requires" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2608_causes-required_for"></see>
    /// </summary>
    let ``aat2608_causes-required_for`` =
        Namespaced_IRI.parse _namespace_name "aat2608_causes-required_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2612_possessed_by-existing_in"></see>
    /// </summary>
    let ``aat2612_possessed_by-existing_in`` =
        Namespaced_IRI.parse _namespace_name "aat2612_possessed_by-existing_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2613_possess-exist_in"></see>
    /// </summary>
    let ``aat2613_possess-exist_in`` =
        Namespaced_IRI.parse _namespace_name "aat2613_possess-exist_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2801_conjuncted_with"></see>
    /// </summary>
    let aat2801_conjuncted_with =
        Namespaced_IRI.parse _namespace_name "aat2801_conjuncted_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2802_exemplified_by"></see>
    /// </summary>
    let aat2802_exemplified_by =
        Namespaced_IRI.parse _namespace_name "aat2802_exemplified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2803_example_of"></see>
    /// </summary>
    let aat2803_example_of =
        Namespaced_IRI.parse _namespace_name "aat2803_example_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2805_contextualized_in"></see>
    /// </summary>
    let aat2805_contextualized_in =
        Namespaced_IRI.parse _namespace_name "aat2805_contextualized_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2806_provide_context"></see>
    /// </summary>
    let aat2806_provide_context =
        Namespaced_IRI.parse _namespace_name "aat2806_provide_context" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2807_derived_from_common_source"></see>
    /// </summary>
    let aat2807_derived_from_common_source =
        Namespaced_IRI.parse _namespace_name "aat2807_derived_from_common_source" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2809_coexisted_with"></see>
    /// </summary>
    let aat2809_coexisted_with =
        Namespaced_IRI.parse _namespace_name "aat2809_coexisted_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2811_preceded"></see>
    /// </summary>
    let aat2811_preceded =
        Namespaced_IRI.parse _namespace_name "aat2811_preceded" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2812_followed"></see>
    /// </summary>
    let aat2812_followed =
        Namespaced_IRI.parse _namespace_name "aat2812_followed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2814_constituent_of"></see>
    /// </summary>
    let aat2814_constituent_of =
        Namespaced_IRI.parse _namespace_name "aat2814_constituent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2815_composed_of"></see>
    /// </summary>
    let aat2815_composed_of =
        Namespaced_IRI.parse _namespace_name "aat2815_composed_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2817_derived-made_from"></see>
    /// </summary>
    let ``aat2817_derived-made_from`` =
        Namespaced_IRI.parse _namespace_name "aat2817_derived-made_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2818_source_for"></see>
    /// </summary>
    let aat2818_source_for =
        Namespaced_IRI.parse _namespace_name "aat2818_source_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2821_based_on"></see>
    /// </summary>
    let aat2821_based_on =
        Namespaced_IRI.parse _namespace_name "aat2821_based_on" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2822_basis_of"></see>
    /// </summary>
    let aat2822_basis_of =
        Namespaced_IRI.parse _namespace_name "aat2822_basis_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2824_has_parallels_with"></see>
    /// </summary>
    let aat2824_has_parallels_with =
        Namespaced_IRI.parse _namespace_name "aat2824_has_parallels_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2826_used_with"></see>
    /// </summary>
    let aat2826_used_with =
        Namespaced_IRI.parse _namespace_name "aat2826_used_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2828_use-require"></see>
    /// </summary>
    let ``aat2828_use-require`` =
        Namespaced_IRI.parse _namespace_name "aat2828_use-require" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2829_used-required_for"></see>
    /// </summary>
    let ``aat2829_used-required_for`` =
        Namespaced_IRI.parse _namespace_name "aat2829_used-required_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2831_associated_with"></see>
    /// </summary>
    let aat2831_associated_with =
        Namespaced_IRI.parse _namespace_name "aat2831_associated_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2833_ancestor_of"></see>
    /// </summary>
    let aat2833_ancestor_of =
        Namespaced_IRI.parse _namespace_name "aat2833_ancestor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2834_decendant_of"></see>
    /// </summary>
    let aat2834_decendant_of =
        Namespaced_IRI.parse _namespace_name "aat2834_decendant_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2836_derived-made_from"></see>
    /// </summary>
    let ``aat2836_derived-made_from`` =
        Namespaced_IRI.parse _namespace_name "aat2836_derived-made_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2837_source_for"></see>
    /// </summary>
    let aat2837_source_for =
        Namespaced_IRI.parse _namespace_name "aat2837_source_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2841_derived-made_from"></see>
    /// </summary>
    let ``aat2841_derived-made_from`` =
        Namespaced_IRI.parse _namespace_name "aat2841_derived-made_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2842_source_for"></see>
    /// </summary>
    let aat2842_source_for =
        Namespaced_IRI.parse _namespace_name "aat2842_source_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2845_used-located_in"></see>
    /// </summary>
    let ``aat2845_used-located_in`` =
        Namespaced_IRI.parse _namespace_name "aat2845_used-located_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2846_locus-setting_for"></see>
    /// </summary>
    let ``aat2846_locus-setting_for`` =
        Namespaced_IRI.parse _namespace_name "aat2846_locus-setting_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2848_involved_in"></see>
    /// </summary>
    let aat2848_involved_in =
        Namespaced_IRI.parse _namespace_name "aat2848_involved_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2849_involves"></see>
    /// </summary>
    let aat2849_involves =
        Namespaced_IRI.parse _namespace_name "aat2849_involves" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2852_involved_with"></see>
    /// </summary>
    let aat2852_involved_with =
        Namespaced_IRI.parse _namespace_name "aat2852_involved_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2853_involve"></see>
    /// </summary>
    let aat2853_involve =
        Namespaced_IRI.parse _namespace_name "aat2853_involve" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2875_characteristic_of"></see>
    /// </summary>
    let aat2875_characteristic_of =
        Namespaced_IRI.parse _namespace_name "aat2875_characteristic_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2876_characterized_by"></see>
    /// </summary>
    let aat2876_characterized_by =
        Namespaced_IRI.parse _namespace_name "aat2876_characterized_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2878_preceded-source_for"></see>
    /// </summary>
    let ``aat2878_preceded-source_for`` =
        Namespaced_IRI.parse _namespace_name "aat2878_preceded-source_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2879_followed-developed_from"></see>
    /// </summary>
    let ``aat2879_followed-developed_from`` =
        Namespaced_IRI.parse _namespace_name "aat2879_followed-developed_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2881_reflected_in"></see>
    /// </summary>
    let aat2881_reflected_in =
        Namespaced_IRI.parse _namespace_name "aat2881_reflected_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2882_reflect"></see>
    /// </summary>
    let aat2882_reflect =
        Namespaced_IRI.parse _namespace_name "aat2882_reflect" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2884_involved_with"></see>
    /// </summary>
    let aat2884_involved_with =
        Namespaced_IRI.parse _namespace_name "aat2884_involved_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2885_involves"></see>
    /// </summary>
    let aat2885_involves =
        Namespaced_IRI.parse _namespace_name "aat2885_involves" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2891_exemplified_by"></see>
    /// </summary>
    let aat2891_exemplified_by =
        Namespaced_IRI.parse _namespace_name "aat2891_exemplified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2892_example_of"></see>
    /// </summary>
    let aat2892_example_of =
        Namespaced_IRI.parse _namespace_name "aat2892_example_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2894_exemplified_by"></see>
    /// </summary>
    let aat2894_exemplified_by =
        Namespaced_IRI.parse _namespace_name "aat2894_exemplified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2895_example_of"></see>
    /// </summary>
    let aat2895_example_of =
        Namespaced_IRI.parse _namespace_name "aat2895_example_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#aat2900_miscellaneous_relationship"></see>
    /// </summary>
    let aat2900_miscellaneous_relationship =
        Namespaced_IRI.parse _namespace_name "aat2900_miscellaneous_relationship" |> NamespacedName

    /// <summary>
    /// Type of a ULAN PersonConcept or GroupConcept. Domain is ULAN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#agentType"></see></summary>
    let agentType = Namespaced_IRI.parse _namespace_name "agentType" |> NamespacedName

    /// <summary>
    /// A secondary type of a ULAN Person or Corporate body. Domain is ULAN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#agentTypeNonPreferred"></see></summary>
    let agentTypeNonPreferred =
        Namespaced_IRI.parse _namespace_name "agentTypeNonPreferred" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#agentTypePreferred"></see>
    /// </summary>
    let agentTypePreferred =
        Namespaced_IRI.parse _namespace_name "agentTypePreferred" |> NamespacedName

    /// <summary>
    /// Biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The preferred biography fields are also directly available in the Person/Organization
    /// <see href="http://vocab.getty.edu/ontology#biography"></see></summary>
    let biography = Namespaced_IRI.parse _namespace_name "biography" |> NamespacedName

    /// <summary>
    /// Non-preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography
    /// <see href="http://vocab.getty.edu/ontology#biographyNonPreferred"></see></summary>
    let biographyNonPreferred =
        Namespaced_IRI.parse _namespace_name "biographyNonPreferred" |> NamespacedName

    /// <summary>
    /// Preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The biography fields are also directly available in the Person/Organization
    /// <see href="http://vocab.getty.edu/ontology#biographyPreferred"></see></summary>
    let biographyPreferred =
        Namespaced_IRI.parse _namespace_name "biographyPreferred" |> NamespacedName

    /// <summary>
    /// BTG (Genus/Species, "is a") relation. We also infer iso-thes:broaderGeneric, which goes only between Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderGeneric"></see></summary>
    let broaderGeneric =
        Namespaced_IRI.parse _namespace_name "broaderGeneric" |> NamespacedName

    /// <summary>
    /// BTI (Kind/Instance, "example of") relation. We also infer iso-thes:broaderInstantial, which goes only between Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderInstantial"></see></summary>
    let broaderInstantial =
        Namespaced_IRI.parse _namespace_name "broaderInstantial" |> NamespacedName

    /// <summary>
    /// Auxiliary parents of a subject. Very often there are several non-preferred parents (poly-hierarchy). Can use to mark such parents with [N] in displays
    /// <see href="http://vocab.getty.edu/ontology#broaderNonPreferred"></see></summary>
    let broaderNonPreferred =
        Namespaced_IRI.parse _namespace_name "broaderNonPreferred" |> NamespacedName

    /// <summary>
    /// BTP (Part/Whole, "part of") relation. We also infer iso-thes:broaderPartitive, which goes only between Concepts
    /// <see href="http://vocab.getty.edu/ontology#broaderPartitive"></see></summary>
    let broaderPartitive =
        Namespaced_IRI.parse _namespace_name "broaderPartitive" |> NamespacedName

    /// <summary>
    /// Contributor for which the term is Alternate Preferred. Range is foaf:Agent
    /// <see href="http://vocab.getty.edu/ontology#contributorAlternatePreferred"></see></summary>
    let contributorAlternatePreferred =
        Namespaced_IRI.parse _namespace_name "contributorAlternatePreferred" |> NamespacedName

    /// <summary>
    /// Contributor for which the term is Non-preferred. Range is foaf:Agent
    /// <see href="http://vocab.getty.edu/ontology#contributorNonPreferred"></see></summary>
    let contributorNonPreferred =
        Namespaced_IRI.parse _namespace_name "contributorNonPreferred" |> NamespacedName

    /// <summary>
    /// Contributor for which the term is Preferred. Range is foaf:Agent
    /// <see href="http://vocab.getty.edu/ontology#contributorPreferred"></see></summary>
    let contributorPreferred =
        Namespaced_IRI.parse _namespace_name "contributorPreferred" |> NamespacedName

    /// <summary>
    /// Display order of subject or term amongst its siblings.
    /// If all are 1 then use alphabetical. Domain is gvp:Subject or skosxl:Label
    /// <see href="http://vocab.getty.edu/ontology#displayOrder"></see></summary>
    let displayOrder =
        Namespaced_IRI.parse _namespace_name "displayOrder" |> NamespacedName

    /// <summary>
    /// Estimated end date of term, relation, type assignment, event, biography
    /// <see href="http://vocab.getty.edu/ontology#estEnd"></see></summary>
    let estEnd = Namespaced_IRI.parse _namespace_name "estEnd" |> NamespacedName
    /// <summary>
    /// Estimated start date of term, relation, type assignment, event, biography
    /// <see href="http://vocab.getty.edu/ontology#estStart"></see></summary>
    let estStart = Namespaced_IRI.parse _namespace_name "estStart" |> NamespacedName

    /// <summary>
    /// Non-preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event
    /// <see href="http://vocab.getty.edu/ontology#eventNonPreferred"></see></summary>
    let eventNonPreferred =
        Namespaced_IRI.parse _namespace_name "eventNonPreferred" |> NamespacedName

    /// <summary>
    /// Preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event
    /// <see href="http://vocab.getty.edu/ontology#eventPreferred"></see></summary>
    let eventPreferred =
        Namespaced_IRI.parse _namespace_name "eventPreferred" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#historicFlag"></see>
    /// </summary>
    let historicFlag =
        Namespaced_IRI.parse _namespace_name "historicFlag" |> NamespacedName

    /// <summary>
    /// Non-preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#nationalityNonPreferred"></see></summary>
    let nationalityNonPreferred =
        Namespaced_IRI.parse _namespace_name "nationalityNonPreferred" |> NamespacedName

    /// <summary>
    /// Preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#nationalityPreferred"></see></summary>
    let nationalityPreferred =
        Namespaced_IRI.parse _namespace_name "nationalityPreferred" |> NamespacedName

    /// <summary>
    /// Preferred labels of *all* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's full context
    /// <see href="http://vocab.getty.edu/ontology#parentString"></see></summary>
    let parentString =
        Namespaced_IRI.parse _namespace_name "parentString" |> NamespacedName

    /// <summary>
    /// Preferred labels of *some* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's context
    /// <see href="http://vocab.getty.edu/ontology#parentStringAbbrev"></see></summary>
    let parentStringAbbrev =
        Namespaced_IRI.parse _namespace_name "parentStringAbbrev" |> NamespacedName

    /// <summary>
    /// Type for a TGN place. Domain is TGN concept (AdminPlaceConcept or PhysPlaceConcept), range is AAT Concept
    /// <see href="http://vocab.getty.edu/ontology#placeType"></see></summary>
    let placeType = Namespaced_IRI.parse _namespace_name "placeType" |> NamespacedName

    /// <summary>
    /// A secondary type for a TGN Place. Domain is TGN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#placeTypeNonPreferred"></see></summary>
    let placeTypeNonPreferred =
        Namespaced_IRI.parse _namespace_name "placeTypeNonPreferred" |> NamespacedName

    /// <summary>
    /// The primary type of a TGN Place. Domain is TGN concept, range is AAT concept
    /// <see href="http://vocab.getty.edu/ontology#placeTypePreferred"></see></summary>
    let placeTypePreferred =
        Namespaced_IRI.parse _namespace_name "placeTypePreferred" |> NamespacedName

    /// <summary>
    /// Term preferred by the Getty Vocabulary Program. The language is usually English. Applicable to AAT, ULAN, TGN. Used with skosxl:prefLabel
    /// <see href="http://vocab.getty.edu/ontology#prefLabelGVP"></see></summary>
    let prefLabelGVP =
        Namespaced_IRI.parse _namespace_name "prefLabelGVP" |> NamespacedName

    /// <summary>
    /// Term preferred by Library of Congress, thus used for cataloging according to AACR2. Applicable to AAT and ULAN. Used with skosxl:prefLabel
    /// <see href="http://vocab.getty.edu/ontology#prefLabelLoC"></see></summary>
    let prefLabelLoC =
        Namespaced_IRI.parse _namespace_name "prefLabelLoC" |> NamespacedName

    /// <summary>
    /// Clarifies and disambiguates terms with the same spelling but different meaning.
    /// Appended in parentheses to gvp:term, forming skosxsl:literalForm.
    /// Every qualifier is in the same language as the term
    /// <see href="http://vocab.getty.edu/ontology#qualifier"></see></summary>
    let qualifier = Namespaced_IRI.parse _namespace_name "qualifier" |> NamespacedName

    /// <summary>
    /// Source for which the term is Alternate Preferred. Range is bibo:Document or bibo:DocumentPart
    /// <see href="http://vocab.getty.edu/ontology#sourceAlternatePreferred"></see></summary>
    let sourceAlternatePreferred =
        Namespaced_IRI.parse _namespace_name "sourceAlternatePreferred" |> NamespacedName

    /// <summary>
    /// Source for which the term is Non-preferred. Range is bibo:Document or bibo:DocumentPart
    /// <see href="http://vocab.getty.edu/ontology#sourceNonPreferred"></see></summary>
    let sourceNonPreferred =
        Namespaced_IRI.parse _namespace_name "sourceNonPreferred" |> NamespacedName

    /// <summary>
    /// Source for which the term is Preferred. Range is bibo:Document or bibo:DocumentPart
    /// <see href="http://vocab.getty.edu/ontology#sourcePreferred"></see></summary>
    let sourcePreferred =
        Namespaced_IRI.parse _namespace_name "sourcePreferred" |> NamespacedName

    /// <summary>
    /// Term (label), used as the basic (prefix) part of skosxsl:literalForm
    /// <see href="http://vocab.getty.edu/ontology#term"></see></summary>
    let term = Namespaced_IRI.parse _namespace_name "term" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termDisplay"></see>
    /// </summary>
    let termDisplay =
        Namespaced_IRI.parse _namespace_name "termDisplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termFlag"></see>
    /// </summary>
    let termFlag = Namespaced_IRI.parse _namespace_name "termFlag" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termKind"></see>
    /// </summary>
    let termKind = Namespaced_IRI.parse _namespace_name "termKind" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termPOS"></see>
    /// </summary>
    let termPOS = Namespaced_IRI.parse _namespace_name "termPOS" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#termType"></see>
    /// </summary>
    let termType = Namespaced_IRI.parse _namespace_name "termType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3000_related_to"></see>
    /// </summary>
    let tgn3000_related_to =
        Namespaced_IRI.parse _namespace_name "tgn3000_related_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3001_distinguished_from"></see>
    /// </summary>
    let tgn3001_distinguished_from =
        Namespaced_IRI.parse _namespace_name "tgn3001_distinguished_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3005_possibly_identified_as"></see>
    /// </summary>
    let tgn3005_possibly_identified_as =
        Namespaced_IRI.parse _namespace_name "tgn3005_possibly_identified_as" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3006_formerly_identified_as"></see>
    /// </summary>
    let tgn3006_formerly_identified_as =
        Namespaced_IRI.parse _namespace_name "tgn3006_formerly_identified_as" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3101_near-adjacent_to"></see>
    /// </summary>
    let ``tgn3101_near-adjacent_to`` =
        Namespaced_IRI.parse _namespace_name "tgn3101_near-adjacent_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3102_coextensive_with"></see>
    /// </summary>
    let tgn3102_coextensive_with =
        Namespaced_IRI.parse _namespace_name "tgn3102_coextensive_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3110_meaning-usage_overlaps_with"></see>
    /// </summary>
    let ``tgn3110_meaning-usage_overlaps_with`` =
        Namespaced_IRI.parse _namespace_name "tgn3110_meaning-usage_overlaps_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3201_capital_of"></see>
    /// </summary>
    let tgn3201_capital_of =
        Namespaced_IRI.parse _namespace_name "tgn3201_capital_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3202_capital_is"></see>
    /// </summary>
    let tgn3202_capital_is =
        Namespaced_IRI.parse _namespace_name "tgn3202_capital_is" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3301_ally_of"></see>
    /// </summary>
    let tgn3301_ally_of =
        Namespaced_IRI.parse _namespace_name "tgn3301_ally_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3317_member_of"></see>
    /// </summary>
    let tgn3317_member_of =
        Namespaced_IRI.parse _namespace_name "tgn3317_member_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3318_member_is"></see>
    /// </summary>
    let tgn3318_member_is =
        Namespaced_IRI.parse _namespace_name "tgn3318_member_is" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3401_moved_from"></see>
    /// </summary>
    let tgn3401_moved_from =
        Namespaced_IRI.parse _namespace_name "tgn3401_moved_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3402_moved_to"></see>
    /// </summary>
    let tgn3402_moved_to =
        Namespaced_IRI.parse _namespace_name "tgn3402_moved_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3411_successor_of"></see>
    /// </summary>
    let tgn3411_successor_of =
        Namespaced_IRI.parse _namespace_name "tgn3411_successor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3412_predecessor_of"></see>
    /// </summary>
    let tgn3412_predecessor_of =
        Namespaced_IRI.parse _namespace_name "tgn3412_predecessor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3510_historical_connection"></see>
    /// </summary>
    let tgn3510_historical_connection =
        Namespaced_IRI.parse _namespace_name "tgn3510_historical_connection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3611_administrative_dependent_of"></see>
    /// </summary>
    let tgn3611_administrative_dependent_of =
        Namespaced_IRI.parse _namespace_name "tgn3611_administrative_dependent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#tgn3612_administrative_entity_for"></see>
    /// </summary>
    let tgn3612_administrative_entity_for =
        Namespaced_IRI.parse _namespace_name "tgn3612_administrative_entity_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1000_related_to"></see>
    /// </summary>
    let ulan1000_related_to =
        Namespaced_IRI.parse _namespace_name "ulan1000_related_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1003_associated_with"></see>
    /// </summary>
    let ulan1003_associated_with =
        Namespaced_IRI.parse _namespace_name "ulan1003_associated_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1005_possibly_identified_with"></see>
    /// </summary>
    let ulan1005_possibly_identified_with =
        Namespaced_IRI.parse _namespace_name "ulan1005_possibly_identified_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1006_formerly_identified_with"></see>
    /// </summary>
    let ulan1006_formerly_identified_with =
        Namespaced_IRI.parse _namespace_name "ulan1006_formerly_identified_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1007_distinguished_from"></see>
    /// </summary>
    let ulan1007_distinguished_from =
        Namespaced_IRI.parse _namespace_name "ulan1007_distinguished_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1008_meaning_-usage_overlaps_with"></see>
    /// </summary>
    let ``ulan1008_meaning_-usage_overlaps_with`` =
        Namespaced_IRI.parse _namespace_name "ulan1008_meaning_-usage_overlaps_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1101_teacher_of"></see>
    /// </summary>
    let ulan1101_teacher_of =
        Namespaced_IRI.parse _namespace_name "ulan1101_teacher_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1102_student_of"></see>
    /// </summary>
    let ulan1102_student_of =
        Namespaced_IRI.parse _namespace_name "ulan1102_student_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1105_apprentice_of"></see>
    /// </summary>
    let ulan1105_apprentice_of =
        Namespaced_IRI.parse _namespace_name "ulan1105_apprentice_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1106_apprentice_was"></see>
    /// </summary>
    let ulan1106_apprentice_was =
        Namespaced_IRI.parse _namespace_name "ulan1106_apprentice_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1107_influenced"></see>
    /// </summary>
    let ulan1107_influenced =
        Namespaced_IRI.parse _namespace_name "ulan1107_influenced" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1108_influenced_by"></see>
    /// </summary>
    let ulan1108_influenced_by =
        Namespaced_IRI.parse _namespace_name "ulan1108_influenced_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1111_master_of"></see>
    /// </summary>
    let ulan1111_master_of =
        Namespaced_IRI.parse _namespace_name "ulan1111_master_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1112_master_was"></see>
    /// </summary>
    let ulan1112_master_was =
        Namespaced_IRI.parse _namespace_name "ulan1112_master_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1113_fellow_student_of"></see>
    /// </summary>
    let ulan1113_fellow_student_of =
        Namespaced_IRI.parse _namespace_name "ulan1113_fellow_student_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1201_patron_of"></see>
    /// </summary>
    let ulan1201_patron_of =
        Namespaced_IRI.parse _namespace_name "ulan1201_patron_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1202_patron_was"></see>
    /// </summary>
    let ulan1202_patron_was =
        Namespaced_IRI.parse _namespace_name "ulan1202_patron_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1203_donor_of"></see>
    /// </summary>
    let ulan1203_donor_of =
        Namespaced_IRI.parse _namespace_name "ulan1203_donor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1204_donor_was"></see>
    /// </summary>
    let ulan1204_donor_was =
        Namespaced_IRI.parse _namespace_name "ulan1204_donor_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1205_client_of"></see>
    /// </summary>
    let ulan1205_client_of =
        Namespaced_IRI.parse _namespace_name "ulan1205_client_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1206_client_was"></see>
    /// </summary>
    let ulan1206_client_was =
        Namespaced_IRI.parse _namespace_name "ulan1206_client_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1211_artist_to"></see>
    /// </summary>
    let ulan1211_artist_to =
        Namespaced_IRI.parse _namespace_name "ulan1211_artist_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1212_artist_was"></see>
    /// </summary>
    let ulan1212_artist_was =
        Namespaced_IRI.parse _namespace_name "ulan1212_artist_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1213_court_artist_to"></see>
    /// </summary>
    let ulan1213_court_artist_to =
        Namespaced_IRI.parse _namespace_name "ulan1213_court_artist_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1214_court_artist_was"></see>
    /// </summary>
    let ulan1214_court_artist_was =
        Namespaced_IRI.parse _namespace_name "ulan1214_court_artist_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1217_employee_of"></see>
    /// </summary>
    let ulan1217_employee_of =
        Namespaced_IRI.parse _namespace_name "ulan1217_employee_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1218_employee_was"></see>
    /// </summary>
    let ulan1218_employee_was =
        Namespaced_IRI.parse _namespace_name "ulan1218_employee_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1221_appointed_by"></see>
    /// </summary>
    let ulan1221_appointed_by =
        Namespaced_IRI.parse _namespace_name "ulan1221_appointed_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1222_appointee_of"></see>
    /// </summary>
    let ulan1222_appointee_of =
        Namespaced_IRI.parse _namespace_name "ulan1222_appointee_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1223_crowned_by"></see>
    /// </summary>
    let ulan1223_crowned_by =
        Namespaced_IRI.parse _namespace_name "ulan1223_crowned_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1224_crowned"></see>
    /// </summary>
    let ulan1224_crowned =
        Namespaced_IRI.parse _namespace_name "ulan1224_crowned" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1301_colleague_of"></see>
    /// </summary>
    let ulan1301_colleague_of =
        Namespaced_IRI.parse _namespace_name "ulan1301_colleague_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1302_associate_of"></see>
    /// </summary>
    let ulan1302_associate_of =
        Namespaced_IRI.parse _namespace_name "ulan1302_associate_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1303_collaborated_with"></see>
    /// </summary>
    let ulan1303_collaborated_with =
        Namespaced_IRI.parse _namespace_name "ulan1303_collaborated_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1305_worked_with"></see>
    /// </summary>
    let ulan1305_worked_with =
        Namespaced_IRI.parse _namespace_name "ulan1305_worked_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1306_performs_with"></see>
    /// </summary>
    let ulan1306_performs_with =
        Namespaced_IRI.parse _namespace_name "ulan1306_performs_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1307_assistant_of"></see>
    /// </summary>
    let ulan1307_assistant_of =
        Namespaced_IRI.parse _namespace_name "ulan1307_assistant_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1308_assisted_by"></see>
    /// </summary>
    let ulan1308_assisted_by =
        Namespaced_IRI.parse _namespace_name "ulan1308_assisted_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1309_advisor_of"></see>
    /// </summary>
    let ulan1309_advisor_of =
        Namespaced_IRI.parse _namespace_name "ulan1309_advisor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1310_advised_by"></see>
    /// </summary>
    let ulan1310_advised_by =
        Namespaced_IRI.parse _namespace_name "ulan1310_advised_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1311_partner_of"></see>
    /// </summary>
    let ulan1311_partner_of =
        Namespaced_IRI.parse _namespace_name "ulan1311_partner_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1313_partner_in"></see>
    /// </summary>
    let ulan1313_partner_in =
        Namespaced_IRI.parse _namespace_name "ulan1313_partner_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1314_partner_was"></see>
    /// </summary>
    let ulan1314_partner_was =
        Namespaced_IRI.parse _namespace_name "ulan1314_partner_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1315_principal_in"></see>
    /// </summary>
    let ulan1315_principal_in =
        Namespaced_IRI.parse _namespace_name "ulan1315_principal_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1316_principal_was"></see>
    /// </summary>
    let ulan1316_principal_was =
        Namespaced_IRI.parse _namespace_name "ulan1316_principal_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1317_member_of"></see>
    /// </summary>
    let ulan1317_member_of =
        Namespaced_IRI.parse _namespace_name "ulan1317_member_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1318_member_was"></see>
    /// </summary>
    let ulan1318_member_was =
        Namespaced_IRI.parse _namespace_name "ulan1318_member_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1321_school_of"></see>
    /// </summary>
    let ulan1321_school_of =
        Namespaced_IRI.parse _namespace_name "ulan1321_school_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1322_school_was"></see>
    /// </summary>
    let ulan1322_school_was =
        Namespaced_IRI.parse _namespace_name "ulan1322_school_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1331_worked_with"></see>
    /// </summary>
    let ulan1331_worked_with =
        Namespaced_IRI.parse _namespace_name "ulan1331_worked_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1332_worker_was"></see>
    /// </summary>
    let ulan1332_worker_was =
        Namespaced_IRI.parse _namespace_name "ulan1332_worker_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1411_successor_of"></see>
    /// </summary>
    let ulan1411_successor_of =
        Namespaced_IRI.parse _namespace_name "ulan1411_successor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1412_predecessor_of"></see>
    /// </summary>
    let ulan1412_predecessor_of =
        Namespaced_IRI.parse _namespace_name "ulan1412_predecessor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1413_administration_overlaps_with"></see>
    /// </summary>
    let ulan1413_administration_overlaps_with =
        Namespaced_IRI.parse _namespace_name "ulan1413_administration_overlaps_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1414_joint_venture_with"></see>
    /// </summary>
    let ulan1414_joint_venture_with =
        Namespaced_IRI.parse _namespace_name "ulan1414_joint_venture_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1421_founded_by"></see>
    /// </summary>
    let ulan1421_founded_by =
        Namespaced_IRI.parse _namespace_name "ulan1421_founded_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1422_founded"></see>
    /// </summary>
    let ulan1422_founded =
        Namespaced_IRI.parse _namespace_name "ulan1422_founded" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1500_related_to"></see>
    /// </summary>
    let ulan1500_related_to =
        Namespaced_IRI.parse _namespace_name "ulan1500_related_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1501_sibling_of"></see>
    /// </summary>
    let ulan1501_sibling_of =
        Namespaced_IRI.parse _namespace_name "ulan1501_sibling_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1511_child_of"></see>
    /// </summary>
    let ulan1511_child_of =
        Namespaced_IRI.parse _namespace_name "ulan1511_child_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1512_parent_of"></see>
    /// </summary>
    let ulan1512_parent_of =
        Namespaced_IRI.parse _namespace_name "ulan1512_parent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1513_grandchild_of"></see>
    /// </summary>
    let ulan1513_grandchild_of =
        Namespaced_IRI.parse _namespace_name "ulan1513_grandchild_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1514_gandparent_of"></see>
    /// </summary>
    let ulan1514_gandparent_of =
        Namespaced_IRI.parse _namespace_name "ulan1514_gandparent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1515_great-grandparent_of"></see>
    /// </summary>
    let ``ulan1515_great-grandparent_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1515_great-grandparent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1516_great-grandchild_of"></see>
    /// </summary>
    let ``ulan1516_great-grandchild_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1516_great-grandchild_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1521_cousin_of"></see>
    /// </summary>
    let ulan1521_cousin_of =
        Namespaced_IRI.parse _namespace_name "ulan1521_cousin_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1531_nephew-niece_of"></see>
    /// </summary>
    let ``ulan1531_nephew-niece_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1531_nephew-niece_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1532_uncle-aunt_of"></see>
    /// </summary>
    let ``ulan1532_uncle-aunt_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1532_uncle-aunt_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1541_spouse_of"></see>
    /// </summary>
    let ulan1541_spouse_of =
        Namespaced_IRI.parse _namespace_name "ulan1541_spouse_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1542_consort_of"></see>
    /// </summary>
    let ulan1542_consort_of =
        Namespaced_IRI.parse _namespace_name "ulan1542_consort_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1543_consort_was"></see>
    /// </summary>
    let ulan1543_consort_was =
        Namespaced_IRI.parse _namespace_name "ulan1543_consort_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1544_significant_other_of"></see>
    /// </summary>
    let ulan1544_significant_other_of =
        Namespaced_IRI.parse _namespace_name "ulan1544_significant_other_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1547_romantic_partner_of"></see>
    /// </summary>
    let ulan1547_romantic_partner_of =
        Namespaced_IRI.parse _namespace_name "ulan1547_romantic_partner_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1548_domestic_partner_of"></see>
    /// </summary>
    let ulan1548_domestic_partner_of =
        Namespaced_IRI.parse _namespace_name "ulan1548_domestic_partner_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1550_relative_by_marriage"></see>
    /// </summary>
    let ulan1550_relative_by_marriage =
        Namespaced_IRI.parse _namespace_name "ulan1550_relative_by_marriage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1551_sibling_by_marriage_of"></see>
    /// </summary>
    let ulan1551_sibling_by_marriage_of =
        Namespaced_IRI.parse _namespace_name "ulan1551_sibling_by_marriage_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1552_parent_by_marriage_of"></see>
    /// </summary>
    let ulan1552_parent_by_marriage_of =
        Namespaced_IRI.parse _namespace_name "ulan1552_parent_by_marriage_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1553_child_by_marriage_of"></see>
    /// </summary>
    let ulan1553_child_by_marriage_of =
        Namespaced_IRI.parse _namespace_name "ulan1553_child_by_marriage_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1554_adoptive_parent_of"></see>
    /// </summary>
    let ulan1554_adoptive_parent_of =
        Namespaced_IRI.parse _namespace_name "ulan1554_adoptive_parent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1555_adopted_child_of"></see>
    /// </summary>
    let ulan1555_adopted_child_of =
        Namespaced_IRI.parse _namespace_name "ulan1555_adopted_child_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1556_half-sibling_of"></see>
    /// </summary>
    let ``ulan1556_half-sibling_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1556_half-sibling_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1557_step-sibling_of"></see>
    /// </summary>
    let ``ulan1557_step-sibling_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1557_step-sibling_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1561_step-child_of"></see>
    /// </summary>
    let ``ulan1561_step-child_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1561_step-child_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1562_step-parent_of"></see>
    /// </summary>
    let ``ulan1562_step-parent_of`` =
        Namespaced_IRI.parse _namespace_name "ulan1562_step-parent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1571_guardian_of"></see>
    /// </summary>
    let ulan1571_guardian_of =
        Namespaced_IRI.parse _namespace_name "ulan1571_guardian_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1573_ward_of"></see>
    /// </summary>
    let ulan1573_ward_of =
        Namespaced_IRI.parse _namespace_name "ulan1573_ward_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1574_godparent_of"></see>
    /// </summary>
    let ulan1574_godparent_of =
        Namespaced_IRI.parse _namespace_name "ulan1574_godparent_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1575_godchild_of"></see>
    /// </summary>
    let ulan1575_godchild_of =
        Namespaced_IRI.parse _namespace_name "ulan1575_godchild_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1581_descendant_of"></see>
    /// </summary>
    let ulan1581_descendant_of =
        Namespaced_IRI.parse _namespace_name "ulan1581_descendant_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1582_ancestor_of"></see>
    /// </summary>
    let ulan1582_ancestor_of =
        Namespaced_IRI.parse _namespace_name "ulan1582_ancestor_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan1590_possibly_related_to"></see>
    /// </summary>
    let ulan1590_possibly_related_to =
        Namespaced_IRI.parse _namespace_name "ulan1590_possibly_related_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2550_friend_of"></see>
    /// </summary>
    let ulan2550_friend_of =
        Namespaced_IRI.parse _namespace_name "ulan2550_friend_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2572_founder_of"></see>
    /// </summary>
    let ulan2572_founder_of =
        Namespaced_IRI.parse _namespace_name "ulan2572_founder_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2573_founded_by"></see>
    /// </summary>
    let ulan2573_founded_by =
        Namespaced_IRI.parse _namespace_name "ulan2573_founded_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2574_director_of"></see>
    /// </summary>
    let ulan2574_director_of =
        Namespaced_IRI.parse _namespace_name "ulan2574_director_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2575_directed_by"></see>
    /// </summary>
    let ulan2575_directed_by =
        Namespaced_IRI.parse _namespace_name "ulan2575_directed_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2576_patron_of"></see>
    /// </summary>
    let ulan2576_patron_of =
        Namespaced_IRI.parse _namespace_name "ulan2576_patron_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2577_patron_was"></see>
    /// </summary>
    let ulan2577_patron_was =
        Namespaced_IRI.parse _namespace_name "ulan2577_patron_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2578_trustee_of"></see>
    /// </summary>
    let ulan2578_trustee_of =
        Namespaced_IRI.parse _namespace_name "ulan2578_trustee_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2579_trustee_was"></see>
    /// </summary>
    let ulan2579_trustee_was =
        Namespaced_IRI.parse _namespace_name "ulan2579_trustee_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2581_administrator_of"></see>
    /// </summary>
    let ulan2581_administrator_of =
        Namespaced_IRI.parse _namespace_name "ulan2581_administrator_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2582_administered_by"></see>
    /// </summary>
    let ulan2582_administered_by =
        Namespaced_IRI.parse _namespace_name "ulan2582_administered_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2650_publisher_was"></see>
    /// </summary>
    let ulan2650_publisher_was =
        Namespaced_IRI.parse _namespace_name "ulan2650_publisher_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2651_publisher_of"></see>
    /// </summary>
    let ulan2651_publisher_of =
        Namespaced_IRI.parse _namespace_name "ulan2651_publisher_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2674_professor_at"></see>
    /// </summary>
    let ulan2674_professor_at =
        Namespaced_IRI.parse _namespace_name "ulan2674_professor_at" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2675_professor_was"></see>
    /// </summary>
    let ulan2675_professor_was =
        Namespaced_IRI.parse _namespace_name "ulan2675_professor_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2676_teacher_at"></see>
    /// </summary>
    let ulan2676_teacher_at =
        Namespaced_IRI.parse _namespace_name "ulan2676_teacher_at" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2677_teacher_was"></see>
    /// </summary>
    let ulan2677_teacher_was =
        Namespaced_IRI.parse _namespace_name "ulan2677_teacher_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2692_president_of"></see>
    /// </summary>
    let ulan2692_president_of =
        Namespaced_IRI.parse _namespace_name "ulan2692_president_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2693_president_was"></see>
    /// </summary>
    let ulan2693_president_was =
        Namespaced_IRI.parse _namespace_name "ulan2693_president_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2696_leader_of"></see>
    /// </summary>
    let ulan2696_leader_of =
        Namespaced_IRI.parse _namespace_name "ulan2696_leader_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2697_leader_was"></see>
    /// </summary>
    let ulan2697_leader_was =
        Namespaced_IRI.parse _namespace_name "ulan2697_leader_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2778_owner_of"></see>
    /// </summary>
    let ulan2778_owner_of =
        Namespaced_IRI.parse _namespace_name "ulan2778_owner_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2779_owned_by"></see>
    /// </summary>
    let ulan2779_owned_by =
        Namespaced_IRI.parse _namespace_name "ulan2779_owned_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2781_dedicatee_of"></see>
    /// </summary>
    let ulan2781_dedicatee_of =
        Namespaced_IRI.parse _namespace_name "ulan2781_dedicatee_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2782_dedicated_to"></see>
    /// </summary>
    let ulan2782_dedicated_to =
        Namespaced_IRI.parse _namespace_name "ulan2782_dedicated_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2794_representative_of"></see>
    /// </summary>
    let ulan2794_representative_of =
        Namespaced_IRI.parse _namespace_name "ulan2794_representative_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2795_representative_was"></see>
    /// </summary>
    let ulan2795_representative_was =
        Namespaced_IRI.parse _namespace_name "ulan2795_representative_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2828_student_at"></see>
    /// </summary>
    let ulan2828_student_at =
        Namespaced_IRI.parse _namespace_name "ulan2828_student_at" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2829_student_was"></see>
    /// </summary>
    let ulan2829_student_was =
        Namespaced_IRI.parse _namespace_name "ulan2829_student_was" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2840_performer_with"></see>
    /// </summary>
    let ulan2840_performer_with =
        Namespaced_IRI.parse _namespace_name "ulan2840_performer_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.getty.edu/ontology#ulan2841_performer_was"></see>
    /// </summary>
    let ulan2841_performer_was =
        Namespaced_IRI.parse _namespace_name "ulan2841_performer_was" |> NamespacedName
