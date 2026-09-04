#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gvp =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.getty.edu/ontology#" "gvp"
    /// <summary>
    ///   <para>skos:example : Burgundy region in France (TGN)^^xsd:string</para>
    ///   <para>rdfs:comment : Place defined by administrative boundaries and conditions, including inhabited places, nations, and empires. Used in TGN only^^xsd:string</para>
    ///   <para>dcterms:description : Place defined by administrative boundaries and conditions, including inhabited places, nations, and empires. Used in TGN only.
    /// Example: Burgundy region in France (TGN)^^xsd:string</para>
    ///   <para>rdfs:label : AdminPlaceConcept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#AdminPlaceConcept">gvp:AdminPlaceConcept</a>
    /// </summary>
    let AdminPlaceConcept = _prefixId.prefix "AdminPlaceConcept"
    /// <summary>
    ///   <para>rdfs:comment : Biography of a ULAN agent (schema:Person|Organization). Depending on the agent, has these fields:
    /// - schema:description: one-line-biography
    /// - gvp:estStart
    /// - schema:birthPlace | foundationLocation, pointing to TGN
    /// - gvp:estEnd
    /// - schema:deathPlace | dissolutionLocation, pointing to TGN
    /// - schema:gender, pointing to AAT (male, female, other)
    /// - dct:contributor
    /// The fields of the preferred biogrpahy are also available in the agent.^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#Biography">gvp:Biography</a>
    /// </summary>
    let Biography = _prefixId.prefix "Biography"
    /// <summary>
    ///   <para>rdfs:comment : Proper concept. Used in AAT only; TGN &amp; ULAN have their own, e.g. gvp:PhysPlaceConcept &amp; gvp:PersonConcept. Used for indexing and cataloguing^^xsd:string</para>
    ///   <para>skos:example : rhyta (AAT)^^xsd:string</para>
    ///   <para>dcterms:description : Proper concept. Used in AAT only; TGN &amp; ULAN have their own, e.g. gvp:PhysPlaceConcept &amp; gvp:PersonConcept. Used for indexing and cataloguing.
    /// Example: rhyta (AAT)^^xsd:string</para>
    ///   <para>rdfs:label : Concept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#Concept">gvp:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>rdfs:comment : One of the major divisions of a vocabulary^^xsd:string</para>
    ///   <para>dcterms:description : One of the major divisions of a vocabulary.
    /// Example: Objects Facet (AAT), World (TGN), Artists (ULAN)^^xsd:string</para>
    ///   <para>skos:example : Objects Facet (AAT), World (TGN), Artists (ULAN)^^xsd:string</para>
    ///   <para>rdfs:label : Facet^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#Facet">gvp:Facet</a>
    /// </summary>
    let Facet = _prefixId.prefix "Facet"
    /// <summary>
    ///   <para>dcterms:description : Two or more people who generally worked together to collectively create art. Not necessarily legally incorporated. A family of artists may be considered a "corporate body". Corresponds to crm:E74_Group, not its subclass crm:E40_Legal_Body.
    /// Example: 500356337 Albrecht Duerer Workshop (ULAN)^^xsd:string</para>
    ///   <para>skos:example : 500356337 Albrecht Duerer Workshop (ULAN)^^xsd:string</para>
    ///   <para>rdfs:comment : Two or more people who generally worked together to collectively create art. Not necessarily legally incorporated. A family of artists may be considered a "corporate body". Corresponds to crm:E74_Group, not its subclass crm:E40_Legal_Body^^xsd:string</para>
    ///   <para>rdfs:label : GroupConcept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#GroupConcept">gvp:GroupConcept</a>
    /// </summary>
    let GroupConcept = _prefixId.prefix "GroupConcept"
    /// <summary>
    ///   <para>dcterms:description : Guide Term: place holder to create a level in the hierarchy. Used in AAT and ULAN. Not used for indexing or cataloguing..
    /// Example: &lt;vessels for serving and consuming food&gt; (AAT), ulan:500353455 &lt;named animals&gt; under facet Non-Artists (ULAN)^^xsd:string</para>
    ///   <para>rdfs:comment : Guide Term: place holder to create a level in the hierarchy. Used in AAT and ULAN. Not used for indexing or cataloguing.^^xsd:string</para>
    ///   <para>skos:example : &lt;vessels for serving and consuming food&gt; (AAT), ulan:500353455 &lt;named animals&gt; under facet Non-Artists (ULAN)^^xsd:string</para>
    ///   <para>rdfs:label : GuideTerm^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#GuideTerm">gvp:GuideTerm</a>
    /// </summary>
    let GuideTerm = _prefixId.prefix "GuideTerm"
    /// <summary>
    ///   <para>dcterms:description : Top of a hierarchy. Used in AAT only. Not used for indexing or cataloguing.
    /// Example: Containers (Hierarchy Name) (AAT)^^xsd:string</para>
    ///   <para>rdfs:comment : Top of a hierarchy. Used in AAT only. Not used for indexing or cataloguing^^xsd:string</para>
    ///   <para>skos:example : Containers (Hierarchy Name) (AAT)^^xsd:string</para>
    ///   <para>rdfs:label : Hierarchy^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#Hierarchy">gvp:Hierarchy</a>
    /// </summary>
    let Hierarchy = _prefixId.prefix "Hierarchy"

    let Infer_broaderNonConcept_PropChainType2 =
        _prefixId.prefix "Infer_broaderNonConcept_PropChainType2"

    let Infer_broaderNonConcept_TypeRestr =
        _prefixId.prefix "Infer_broaderNonConcept_TypeRestr"

    let Infer_broaderPreferredExtended =
        _prefixId.prefix "Infer_broaderPreferredExtended"

    let Infer_isoBroaderGeneric = _prefixId.prefix "Infer_isoBroaderGeneric"
    let Infer_isoBroaderInstantial = _prefixId.prefix "Infer_isoBroaderInstantial"
    let Infer_isoBroaderPartitive = _prefixId.prefix "Infer_isoBroaderPartitive"

    let Infer_skosBroader_PropChainType2 =
        _prefixId.prefix "Infer_skosBroader_PropChainType2"

    let Infer_skosBroader_TypeRestr = _prefixId.prefix "Infer_skosBroader_TypeRestr"
    /// <summary>
    ///   <para>dcterms:description : Obsolete subject: moved out of the publishable hierarchy, or merged to another (pointed by dct:isReplacedBy).
    /// Example: 300375205 "shranks" (AAT) was merged to 300039264 "schranks" (AAT), so aat:300375205 dct:isReplacedBy aat:300039264^^xsd:string</para>
    ///   <para>rdfs:comment : Obsolete subject: moved out of the publishable hierarchy, or merged to another (pointed by dct:isReplacedBy)^^xsd:string</para>
    ///   <para>skos:example : 300375205 "shranks" (AAT) was merged to 300039264 "schranks" (AAT), so aat:300375205 dct:isReplacedBy aat:300039264^^xsd:string</para>
    ///   <para>rdfs:label : ObsoleteSubject^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ObsoleteSubject">gvp:ObsoleteSubject</a>
    /// </summary>
    let ObsoleteSubject = _prefixId.prefix "ObsoleteSubject"
    /// <summary>
    ///   <para>skos:example : 500115493 Duerer, Albrecht (ULAN)^^xsd:string</para>
    ///   <para>dcterms:description : A single individual. Usually people engaged in the design or creation of art or architecture ("Artists"); but may also include donors, patrons, rulers, sitters, art historians, etc ("Non-Artists").
    /// Example: 500115493 Duerer, Albrecht (ULAN)^^xsd:string</para>
    ///   <para>rdfs:comment : A single individual. Usually people engaged in the design or creation of art or architecture ("Artists"); but may also include donors, patrons, rulers, sitters, art historians, etc ("Non-Artists")^^xsd:string</para>
    ///   <para>rdfs:label : PersonConcept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#PersonConcept">gvp:PersonConcept</a>
    /// </summary>
    let PersonConcept = _prefixId.prefix "PersonConcept"
    /// <summary>
    ///   <para>dcterms:description : Place that is both administrative and physical. Rarely used. Used in TGN only.
    /// Example: 6003090 Kiik-Koba (TGN)^^xsd:string</para>
    ///   <para>rdfs:comment : Place that is both administrative and physical. Rarely used. Used in TGN only^^xsd:string</para>
    ///   <para>skos:example : 6003090 Kiik-Koba (TGN)^^xsd:string</para>
    ///   <para>rdfs:label : PhysAdminPlaceConcept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#PhysAdminPlaceConcept">gvp:PhysAdminPlaceConcept</a>
    /// </summary>
    let PhysAdminPlaceConcept = _prefixId.prefix "PhysAdminPlaceConcept"
    /// <summary>
    ///   <para>dcterms:description : Physical feature, defined by its physical characteristics on planet Earth, including mountains, rivers, and oceans. Used in TGN only.
    /// Example: Amazon River (TGN)^^xsd:string</para>
    ///   <para>skos:example : Amazon River (TGN)^^xsd:string</para>
    ///   <para>rdfs:comment : Physical feature, defined by its physical characteristics on planet Earth, including mountains, rivers, and oceans. Used in TGN only^^xsd:string</para>
    ///   <para>rdfs:label : PhysPlaceConcept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#PhysPlaceConcept">gvp:PhysPlaceConcept</a>
    /// </summary>
    let PhysPlaceConcept = _prefixId.prefix "PhysPlaceConcept"
    /// <summary>
    ///   <para>rdfs:comment : Defines a GVP subject or provides usage information. Has fields:
    /// - dc:identifier: numeric ID, also used in the URL.
    /// - rdf:value: the note itself (as per SKOS Primer: 4.2 Advanced Documentation Features) with language tag
    /// - dct:language: matches the language tag
    /// - gvp:displayOrder, order of this note amongst others
    /// - gvp:historicFlag, gvp:estStart, gvp:estEnd, rdfs:comment: Historic Information about applicability
    /// - dct:source or subproperties thereof
    /// - dct:contributor or subproperties thereof^^xsd:string</para>
    ///   <para>dcterms:description : Defines a GVP subject or provides usage information. Has fields:
    /// - dc:identifier: numeric ID, also used in the URL.
    /// - rdf:value: the note itself (as per SKOS Primer: 4.2 Advanced Documentation Features) with language tag
    /// - dct:language: matches the language tag
    /// - gvp:displayOrder, order of this note amongst others
    /// - gvp:historicFlag, vp:estStart, gvp:estEnd, rdfs:comment: Historic Information about applicability
    /// - dct:source or subproperties thereof
    /// - dct:contributor or subproperties thereof^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ScopeNote">gvp:ScopeNote</a>
    /// </summary>
    let ScopeNote = _prefixId.prefix "ScopeNote"
    /// <summary>
    ///   <para>dcterms:description : Node in a GVP vocabulary hierarchy.
    /// May be Facet, GuideTerm, Hierarchy, Concept, AdminPlaceConcept, PhysPlaceConcept, PhysAdminPlaceConcept, or ObsoleteSubject.
    /// Implemented as skos:Concept or iso:ThesaurusArray and skos:Collection^^xsd:string</para>
    ///   <para>rdfs:comment : Node in a GVP vocabulary hierarchy.
    /// May be Facet, GuideTerm, Hierarchy, Concept, AdminPlaceConcept, PhysPlaceConcept, PhysAdminPlaceConcept, or ObsoleteSubject.
    /// Implemented as skos:Concept or iso:ThesaurusArray and skos:Collection^^xsd:string</para>
    ///   <para>rdfs:label : Subject^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#Subject">gvp:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>dcterms:description : Unknown person representing a nationality/culture (the Unknown People by Culture facet).
    /// Example: 500355202 Unknown Bulgarian (modern) (ULAN)^^xsd:string</para>
    ///   <para>rdfs:comment : Unknown person representing a nationality/culture (the Unknown People by Culture facet)^^xsd:string</para>
    ///   <para>skos:example : 500355202 Unknown Bulgarian (modern) (ULAN)^^xsd:string</para>
    ///   <para>rdfs:label : UnknownPersonConcept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#UnknownPersonConcept">gvp:UnknownPersonConcept</a>
    /// </summary>
    let UnknownPersonConcept = _prefixId.prefix "UnknownPersonConcept"
    /// <summary>
    ///   <para>skos:prefLabel : aat2000_related_to^^xsd:string</para>
    ///   <para>dcterms:description : any - related to - any; generic relationship, not explained.
    /// Example: gulf red is related to light red (pigment)^^xsd:string</para>
    ///   <para>skos:scopeNote : generic relationship, not explained^^xsd:string</para>
    ///   <para>dce:identifier : 2000^^xsd:string</para>
    ///   <para>skos:example : gulf red is related to light red (pigment)^^xsd:string</para>
    ///   <para>dce:title : related to - any^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2000_related_to">gvp:aat2000_related_to</a>
    /// </summary>
    let aat2000_related_to = _prefixId.prefix "aat2000_related_to"
    /// <summary>
    ///   <para>dcterms:description : any - formerly referred - any.
    /// Example: gigues formerly referred to fiddles^^xsd:string</para>
    ///   <para>dce:title : formerly referred to - any^^xsd:string</para>
    ///   <para>skos:example : gigues formerly referred to fiddles^^xsd:string</para>
    ///   <para>dce:identifier : 2001^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2001_formerly_referred_to^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2001_formerly_referred_to">gvp:aat2001_formerly_referred_to</a>
    /// </summary>
    let aat2001_formerly_referred_to = _prefixId.prefix "aat2001_formerly_referred_to"
    /// <summary>
    ///   <para>skos:example : historic farms are distinguished from abandoned farms^^xsd:stringskos:example : naive art is distinguished from outsider art^^xsd:string</para>
    ///   <para>dce:identifier : 2100^^xsd:string</para>
    ///   <para>dcterms:description : any - distinguished from - any.
    /// Example: historic farms are distinguished from abandoned farms; naive art is distinguished from outsider art^^xsd:string</para>
    ///   <para>dce:title : distinguished from - any^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2100_distinguished_from^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2100_distinguished_from">gvp:aat2100_distinguished_from</a>
    /// </summary>
    let aat2100_distinguished_from = _prefixId.prefix "aat2100_distinguished_from"

    /// <summary>
    ///   <para>skos:example : scribes has meaning/usage that overlaps with copyists^^xsd:stringskos:example : chimney hoods has meaning/usage that overlaps with chimney caps^^xsd:string</para>
    ///   <para>dce:identifier : 2110^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2110_meaning-usage_overlaps_with^^xsd:string</para>
    ///   <para>dce:title : meaning/usage overlaps with - any^^xsd:string</para>
    ///   <para>dcterms:description : any - meaning/usage overlaps with - any.
    /// Example: chimney hoods has meaning/usage that overlaps with chimney caps; scribes has meaning/usage that overlaps with copyists^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2110_meaning-usage_overlaps_with">gvp:aat2110_meaning-usage_overlaps_with</a>
    /// </summary>
    let aat2110_meaning_usage_overlaps_with =
        _prefixId.prefix "aat2110_meaning-usage_overlaps_with"

    /// <summary>
    ///   <para>dce:identifier : 2203^^xsd:string</para>
    ///   <para>skos:example : Easter is associated with Lent^^xsd:stringskos:example : cavalry exercises are associated with dressage^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - [is] associated with - activity/event/[process/function].
    /// Example: Easter is associated with Lent; cavalry exercises are associated with dressage^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2203_associated_with^^xsd:string</para>
    ///   <para>dce:title : associated with - activity/event^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2203_associated_with">gvp:aat2203_associated_with</a>
    /// </summary>
    let aat2203_associated_with = _prefixId.prefix "aat2203_associated_with"
    /// <summary>
    ///   <para>skos:example : on-demand printing causes/is required for on-demand publishing^^xsd:stringskos:example : preserving causes/is required for preservation^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2205_causes-is_required^^xsd:string</para>
    ///   <para>dce:identifier : 2205^^xsd:string</para>
    ///   <para>dce:title : causes/is required - activity/event^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - causes/is required for - activity/event/[process/function].
    /// Example: on-demand printing causes/is required for on-demand publishing;  preserving causes/is required for preservation^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2205_causes-is_required">gvp:aat2205_causes-is_required</a>
    /// </summary>
    let aat2205_causes_is_required = _prefixId.prefix "aat2205_causes-is_required"
    /// <summary>
    ///   <para>skos:example : on-demand publishing is caused by/requires on-demand printing^^xsd:stringskos:example : preservation is caused by/requires preserving^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2206_caused_by-requires^^xsd:string</para>
    ///   <para>dce:title : caused by/requires - activity/event^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - [is] caused by/dependent upon - activity/event/[process/function].
    /// Example: on-demand publishing is caused by/requires on-demand printing; preservation is caused by/requires preserving^^xsd:string</para>
    ///   <para>dce:identifier : 2206^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2206_caused_by-requires">gvp:aat2206_caused_by-requires</a>
    /// </summary>
    let aat2206_caused_by_requires = _prefixId.prefix "aat2206_caused_by-requires"
    /// <summary>
    ///   <para>dcterms:description : locus/setting - [is] locus/setting for - things.
    /// Example: glassworks (buildings) are the locus/setting for glassware; caves are the locus/setting for cave paintings^^xsd:string</para>
    ///   <para>dce:identifier : 2208^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2208_locus-setting_for^^xsd:string</para>
    ///   <para>dce:title : locus/setting for - things^^xsd:string</para>
    ///   <para>skos:example : caves are the locus/setting for cave paintings^^xsd:stringskos:example : glassworks (buildings) are the locus/setting for glassware^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2208_locus-setting_for">gvp:aat2208_locus-setting_for</a>
    /// </summary>
    let aat2208_locus_setting_for = _prefixId.prefix "aat2208_locus-setting_for"
    /// <summary>
    ///   <para>skos:example : cave paintings are located in caves^^xsd:stringskos:example : glassware is used/located in glassworks (buildings)^^xsd:string</para>
    ///   <para>dcterms:description : things -used/located in -  locus/setting.
    /// Example: glassware is used/located in glassworks (buildings); cave paintings are located in caves^^xsd:string</para>
    ///   <para>dce:identifier : 2209^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2209_used-located_in^^xsd:string</para>
    ///   <para>dce:title : used/located in - locus/setting^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2209_used-located_in">gvp:aat2209_used-located_in</a>
    /// </summary>
    let aat2209_used_located_in = _prefixId.prefix "aat2209_used-located_in"
    /// <summary>
    ///   <para>dcterms:description : things/[equipment] - produce - things.
    /// Example: stereoscopic cameras produce stereoscopic photographs; punches (marking tools) produce punchwork^^xsd:string</para>
    ///   <para>dce:identifier : 2211^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2211_produce^^xsd:string</para>
    ///   <para>skos:example : punches (marking tools) produce punchwork^^xsd:stringskos:example : stereoscopic cameras produce stereoscopic photographs^^xsd:string</para>
    ///   <para>dce:title : produce - things^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2211_produce">gvp:aat2211_produce</a>
    /// </summary>
    let aat2211_produce = _prefixId.prefix "aat2211_produce"
    /// <summary>
    ///   <para>skos:example : stereoscopic photographs are produced by stereoscopic cameras^^xsd:stringskos:example : punchwork is produced by punches (marking tools)^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] produced by - things/[equipment].
    /// Example: stereoscopic photographs are produced by stereoscopic cameras; punchwork is produced by punches (marking tools)^^xsd:string</para>
    ///   <para>dce:identifier : 2212^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2212_produced_by^^xsd:string</para>
    ///   <para>dce:title : produced by - things^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2212_produced_by">gvp:aat2212_produced_by</a>
    /// </summary>
    let aat2212_produced_by = _prefixId.prefix "aat2212_produced_by"
    /// <summary>
    ///   <para>skos:prefLabel : aat2215_required_for^^xsd:string</para>
    ///   <para>dce:identifier : 2215^^xsd:string</para>
    ///   <para>skos:example : compact discs are required for compact disc players^^xsd:stringskos:example : eyelets are required for broderie anglaise^^xsd:string</para>
    ///   <para>dce:title : required for - things^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] required for -  things.
    /// Example: eyelets are required for broderie anglaise; compact discs are required for compact disc players^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2215_required_for">gvp:aat2215_required_for</a>
    /// </summary>
    let aat2215_required_for = _prefixId.prefix "aat2215_required_for"
    /// <summary>
    ///   <para>dce:title : require - things^^xsd:string</para>
    ///   <para>skos:example : compact disc players require compact discs^^xsd:stringskos:example : broderie anglaise requires eyelets^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2216_require^^xsd:string</para>
    ///   <para>dce:identifier : 2216^^xsd:string</para>
    ///   <para>dcterms:description : things - require - things [in order to exist or work].
    /// Example: broderie anglaise requires eyelets; compact disc players require compact discs^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2216_require">gvp:aat2216_require</a>
    /// </summary>
    let aat2216_require = _prefixId.prefix "aat2216_require"
    /// <summary>
    ///   <para>dcterms:description : things - [are] used/function as - things.
    /// Example: arc lamps are used/function as lighthouse lamps;  toile peinte is used/function as cartoons (working drawings)^^xsd:string</para>
    ///   <para>skos:example : arc lamps are used/function as lighthouse lamps^^xsd:stringskos:example : toile peinte is used/function as cartoons (working drawings)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2218_used-function_as^^xsd:string</para>
    ///   <para>dce:title : used/function as - things^^xsd:string</para>
    ///   <para>dce:identifier : 2218^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2218_used-function_as">gvp:aat2218_used-function_as</a>
    /// </summary>
    let aat2218_used_function_as = _prefixId.prefix "aat2218_used-function_as"
    /// <summary>
    ///   <para>dce:title : have form - things^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2219_have_form^^xsd:string</para>
    ///   <para>skos:example : cartoons (working drawings) have the form of toile peinte^^xsd:stringskos:example : lighthouse lamps have the form of arc lamps^^xsd:string</para>
    ///   <para>dce:identifier : 2219^^xsd:string</para>
    ///   <para>dcterms:description : things - have form [of] - things.
    /// Example: lighthouse lamps have the form of arc lamps; cartoons (working drawings) have the form of toile peinte^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2219_have_form">gvp:aat2219_have_form</a>
    /// </summary>
    let aat2219_have_form = _prefixId.prefix "aat2219_have_form"
    /// <summary>
    ///   <para>skos:prefLabel : aat2221_act_upon^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role - act upon - genus/species.
    /// Example: jockeys act upon Equus caballus(species); tappers act upon Acer saccharum(species)^^xsd:string</para>
    ///   <para>dce:title : act upon - genus/species^^xsd:string</para>
    ///   <para>skos:example : tappers act upon Acer saccharum(species)^^xsd:stringskos:example : jockeys act upon Equus caballus(species)^^xsd:string</para>
    ///   <para>dce:identifier : 2221^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2221_act_upon">gvp:aat2221_act_upon</a>
    /// </summary>
    let aat2221_act_upon = _prefixId.prefix "aat2221_act_upon"
    /// <summary>
    ///   <para>dcterms:description : genus/species - is acted upon [by] - [actors having] role.
    /// Example: Equus caballus(species) is acted upon by jockeys; Acer saccharum(species) is acted upon by tappers^^xsd:string</para>
    ///   <para>skos:example : Acer saccharum(species) is acted upon by tappers^^xsd:stringskos:example : Equus caballus(species) is acted upon by jockeys^^xsd:string</para>
    ///   <para>dce:title : are acted upon - role^^xsd:string</para>
    ///   <para>dce:identifier : 2222^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2222_are_acted_upon^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2222_are_acted_upon">gvp:aat2222_are_acted_upon</a>
    /// </summary>
    let aat2222_are_acted_upon = _prefixId.prefix "aat2222_are_acted_upon"
    /// <summary>
    ///   <para>dce:title : have counterpart - role^^xsd:string</para>
    ///   <para>skos:example : duchesses have counterpart dukes^^xsd:stringskos:example : godesses have counterpart gods^^xsd:string</para>
    ///   <para>dce:identifier : 2281^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2281_have_counterpart^^xsd:string</para>
    ///   <para>dcterms:description : role -[is] counterpart to - role.
    /// Example: duchesses have counterpart dukes; godesses have counterpart gods^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2281_have_counterpart">gvp:aat2281_have_counterpart</a>
    /// </summary>
    let aat2281_have_counterpart = _prefixId.prefix "aat2281_have_counterpart"
    /// <summary>
    ///   <para>dce:title : practiced/studied by - role^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2285_practiced-studied_by^^xsd:string</para>
    ///   <para>dce:identifier : 2285^^xsd:string</para>
    ///   <para>dcterms:description : field [of study, genre]/discipline - [is] practiced/studied by - a role.
    /// Example: Egyptology is practiced/studied by Egyptologists; architectural history is practiced/studied by architectural historians^^xsd:string</para>
    ///   <para>skos:example : architectural history is practiced/studied by architectural historians^^xsd:stringskos:example : Egyptology is practiced/studied by Egyptologists^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2285_practiced-studied_by">gvp:aat2285_practiced-studied_by</a>
    /// </summary>
    let aat2285_practiced_studied_by = _prefixId.prefix "aat2285_practiced-studied_by"
    /// <summary>
    ///   <para>skos:example : Egyptologists practice/study Egyptology^^xsd:stringskos:example : architectural historians practice/study architectural history^^xsd:string</para>
    ///   <para>dce:identifier : 2286^^xsd:string</para>
    ///   <para>dcterms:description : [actor having] role - practice/study - field [of study, genre]/discipline.
    /// Example: Egyptologists practice/study Egyptology; architectural historians practice/study architectural history^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2286_practice-study^^xsd:string</para>
    ///   <para>dce:title : practice/study - field/discipline^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2286_practice-study">gvp:aat2286_practice-study</a>
    /// </summary>
    let aat2286_practice_study = _prefixId.prefix "aat2286_practice-study"
    /// <summary>
    ///   <para>dcterms:description : locus/setting - [is] locus setting for - [actor or institution having] role.
    /// Example: roperies are the locus/setting of rope-makers; convents (built complexes) are the locus/setting of nuns; libraries (buildings) are the locus/setting of libraries (institutions)^^xsd:string</para>
    ///   <para>skos:example : roperies are the locus/setting of rope-makers^^xsd:stringskos:example : convents (built complexes) are the locus/setting of nuns^^xsd:stringskos:example : libraries (buildings) are the locus/setting of libraries (institutions)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2291_locus-setting_for^^xsd:string</para>
    ///   <para>dce:title : locus/setting for - role^^xsd:string</para>
    ///   <para>dce:identifier : 2291^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2291_locus-setting_for">gvp:aat2291_locus-setting_for</a>
    /// </summary>
    let aat2291_locus_setting_for = _prefixId.prefix "aat2291_locus-setting_for"
    /// <summary>
    ///   <para>skos:example : nuns live/work in convents (nunneries)^^xsd:stringskos:example : libraries (institutions) live/work in libraries (buildings)^^xsd:stringskos:example : rope-makers live/work in roperies^^xsd:string</para>
    ///   <para>dce:title : work/live in - locus/setting^^xsd:string</para>
    ///   <para>dce:identifier : 2292^^xsd:string</para>
    ///   <para>dcterms:description : [actor or institution having] role - work/live/[exist] in - locus/setting.
    /// Example: rope-makers live/work in roperies; nuns live/work in convents (nunneries); libraries (institutions) live/work in libraries (buildings)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2292_work-live_in^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2292_work-live_in">gvp:aat2292_work-live_in</a>
    /// </summary>
    let aat2292_work_live_in = _prefixId.prefix "aat2292_work-live_in"
    /// <summary>
    ///   <para>dce:title : locus/setting for - locus/setting^^xsd:string</para>
    ///   <para>dcterms:description : locus/setting - [is] locus setting for - locus/setting.
    /// Example: nations are the locus/setting for national capitals; mountain ranges are the locus/setting for mountains^^xsd:string</para>
    ///   <para>dce:identifier : 2294^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2294_locus-setting_for^^xsd:string</para>
    ///   <para>skos:example : mountain ranges are the locus/setting for mountains^^xsd:stringskos:example : nations are the locus/setting for national capitals^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2294_locus-setting_for">gvp:aat2294_locus-setting_for</a>
    /// </summary>
    let aat2294_locus_setting_for = _prefixId.prefix "aat2294_locus-setting_for"
    /// <summary>
    ///   <para>skos:example : mountains are located in mountain ranges^^xsd:stringskos:example : national capitals are located in nations^^xsd:string</para>
    ///   <para>dce:title : located in - locus/setting^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2295_located_in^^xsd:string</para>
    ///   <para>dcterms:description : locus/setting - [is] located in - locus/setting.
    /// Example: national capitals are located in nations; mountains are located in mountain ranges^^xsd:string</para>
    ///   <para>dce:identifier : 2295^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2295_located_in">gvp:aat2295_located_in</a>
    /// </summary>
    let aat2295_located_in = _prefixId.prefix "aat2295_located_in"
    /// <summary>
    ///   <para>skos:example : clockmaking is performed by clockmakers^^xsd:stringskos:example : curating is performed by curators^^xsd:string</para>
    ///   <para>dce:identifier : 2311^^xsd:string</para>
    ///   <para>dce:title : performed by - role^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2311_performed_by^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - [is] performed by - [actors having] a role.
    /// Example: clockmaking is performed by clockmakers; curating is performed by curators^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2311_performed_by">gvp:aat2311_performed_by</a>
    /// </summary>
    let aat2311_performed_by = _prefixId.prefix "aat2311_performed_by"
    /// <summary>
    ///   <para>skos:example : curators perform curating^^xsd:stringskos:example : clockmakers perform clockmaking^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2312_perform^^xsd:string</para>
    ///   <para>dce:identifier : 2312^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] a role - perform - activity/event/process.
    /// Example: clockmakers perform clockmaking; curators perform curating^^xsd:string</para>
    ///   <para>dce:title : perform - activity/event^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2312_perform">gvp:aat2312_perform</a>
    /// </summary>
    let aat2312_perform = _prefixId.prefix "aat2312_perform"
    /// <summary>
    ///   <para>skos:example : precious stone is used by lapidiaries^^xsd:stringskos:example : brass (alloy) is used by braziers (metalworkers)^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] used by - [actor having] role.
    /// Example: precious stone is used by lapidiaries; brass (alloy) is used by braziers (metalworkers)^^xsd:string</para>
    ///   <para>dce:identifier : 2315^^xsd:string</para>
    ///   <para>dce:title : used by - role^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2315_used_by^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2315_used_by">gvp:aat2315_used_by</a>
    /// </summary>
    let aat2315_used_by = _prefixId.prefix "aat2315_used_by"
    /// <summary>
    ///   <para>skos:example : lapidaries use precious stone^^xsd:stringskos:example : braziers (metalworkers) use brass (alloy)^^xsd:string</para>
    ///   <para>dce:title : use - material^^xsd:string</para>
    ///   <para>dce:identifier : 2316^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role - use - material.
    /// Example: lapidaries use precious stone; braziers (metalworkers) use brass (alloy)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2316_use^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2316_use">gvp:aat2316_use</a>
    /// </summary>
    let aat2316_use = _prefixId.prefix "aat2316_use"
    /// <summary>
    ///   <para>dce:identifier : 2318^^xsd:string</para>
    ///   <para>skos:example : martyrs are involved in martyrdoms^^xsd:stringskos:example : bridegrooms are involved in weddings^^xsd:string</para>
    ///   <para>dce:title : involved in - activity/event^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2318_involved_in^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role -[are] involved - activity/event.
    /// Example: bridegrooms are involved in weddings; martyrs are involved in martyrdoms^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2318_involved_in">gvp:aat2318_involved_in</a>
    /// </summary>
    let aat2318_involved_in = _prefixId.prefix "aat2318_involved_in"
    /// <summary>
    ///   <para>dcterms:description : activity/event - involves - [actors having] role.
    /// Example: weddings involve bridegrooms; martyrdoms involve martyrs^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2319_involves^^xsd:string</para>
    ///   <para>skos:example : weddings involve bridegrooms^^xsd:stringskos:example : martyrdoms involve martyrs^^xsd:string</para>
    ///   <para>dce:title : involves - role^^xsd:string</para>
    ///   <para>dce:identifier : 2319^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2319_involves">gvp:aat2319_involves</a>
    /// </summary>
    let aat2319_involves = _prefixId.prefix "aat2319_involves"
    /// <summary>
    ///   <para>skos:example : violoncellos are used by violoncellists^^xsd:stringskos:example : surveying instruments are used by surveyors^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2321_used_by^^xsd:string</para>
    ///   <para>dce:title : used by - role^^xsd:string</para>
    ///   <para>dce:identifier : 2321^^xsd:string</para>
    ///   <para>dcterms:description : things/equipment - [are] used by - [actors having] role.
    /// Example: violoncellos are used by violoncellists; surveying instruments are used by surveyors^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2321_used_by">gvp:aat2321_used_by</a>
    /// </summary>
    let aat2321_used_by = _prefixId.prefix "aat2321_used_by"
    /// <summary>
    ///   <para>skos:prefLabel : aat2322_use^^xsd:string</para>
    ///   <para>dce:identifier : 2322^^xsd:string</para>
    ///   <para>dce:title : use - things^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role - use - things/equipment.
    /// Example: violoncellists use violoncellos; surveyors use surveying instruments^^xsd:string</para>
    ///   <para>skos:example : violoncellists use violoncellos^^xsd:stringskos:example : surveyors use surveying instruments^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2322_use">gvp:aat2322_use</a>
    /// </summary>
    let aat2322_use = _prefixId.prefix "aat2322_use"
    /// <summary>
    ///   <para>dce:title : created by - role^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2325_created_by^^xsd:string</para>
    ///   <para>dce:identifier : 2325^^xsd:string</para>
    ///   <para>skos:example : poems are created by poets^^xsd:stringskos:example : drawings are created by draftsmen^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] created by - [actors having] role.
    /// Example: drawings are created by draftsmen; poems are created by poets^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2325_created_by">gvp:aat2325_created_by</a>
    /// </summary>
    let aat2325_created_by = _prefixId.prefix "aat2325_created_by"
    /// <summary>
    ///   <para>skos:example : draftsmen create drawings^^xsd:stringskos:example : poets create poems^^xsd:string</para>
    ///   <para>dce:title : create - things^^xsd:string</para>
    ///   <para>dce:identifier : 2326^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role - create - things.
    /// Example: draftsmen create drawings; poets create poems^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2326_create^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2326_create">gvp:aat2326_create</a>
    /// </summary>
    let aat2326_create = _prefixId.prefix "aat2326_create"
    /// <summary>
    ///   <para>dce:identifier : 2328^^xsd:string</para>
    ///   <para>skos:example : actors (performing artists) are involved with motion pictures (visual works)^^xsd:stringskos:example : sitters are involved with portraits^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2328_involved_with^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role - [are] involved in- things.
    /// Example: sitters are involved with portraits; actors (performing artists) are involved with motion pictures (visual works)^^xsd:string</para>
    ///   <para>dce:title : involved with - things^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2328_involved_with">gvp:aat2328_involved_with</a>
    /// </summary>
    let aat2328_involved_with = _prefixId.prefix "aat2328_involved_with"
    /// <summary>
    ///   <para>dce:title : involves - role^^xsd:string</para>
    ///   <para>skos:example : portraits involve sitters^^xsd:stringskos:example : motion pictures (visual works) involve actors (performing artists)^^xsd:string</para>
    ///   <para>dce:identifier : 2329^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2329_involves^^xsd:string</para>
    ///   <para>dcterms:description : things - involve - [actors having] role.
    /// Example: portraits involve sitters; motion pictures (visual works) involve actors (performing artists)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2329_involves">gvp:aat2329_involves</a>
    /// </summary>
    let aat2329_involves = _prefixId.prefix "aat2329_involves"
    /// <summary>
    ///   <para>dce:identifier : 2332^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role - [are] affiliated with - role [organization].
    /// Example: students are affiliated with schools (organizations); dukes are affiliated with duchies^^xsd:string</para>
    ///   <para>skos:example : dukes are affiliated with duchies^^xsd:stringskos:example : students are affiliated with schools (organizations)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2332_affiliated_with^^xsd:string</para>
    ///   <para>dce:title : affiliated with - role^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2332_affiliated_with">gvp:aat2332_affiliated_with</a>
    /// </summary>
    let aat2332_affiliated_with = _prefixId.prefix "aat2332_affiliated_with"
    /// <summary>
    ///   <para>skos:prefLabel : aat2333_have_affiliates^^xsd:string</para>
    ///   <para>dce:identifier : 2333^^xsd:string</para>
    ///   <para>skos:example : schools (organizations) have as affiliates students^^xsd:stringskos:example : duchies have as affiliates dukes^^xsd:string</para>
    ///   <para>dce:title : have affiliates - role^^xsd:string</para>
    ///   <para>dcterms:description : role [organizations] - have affiliates - [actors having] role.
    /// Example: schools (organizations) have as affiliates students; duchies have as affiliates dukes^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2333_have_affiliates">gvp:aat2333_have_affiliates</a>
    /// </summary>
    let aat2333_have_affiliates = _prefixId.prefix "aat2333_have_affiliates"
    /// <summary>
    ///   <para>dce:identifier : 2335^^xsd:string</para>
    ///   <para>skos:example : popes are associated with Roman Catholicism^^xsd:stringskos:example : abstract artists are associated with Abstract (fine arts style)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2335_associated_with^^xsd:string</para>
    ///   <para>dce:title : associated with - style/period/culture^^xsd:string</para>
    ///   <para>dcterms:description : [actors having] role - [are] associated with - style/period/culture/[religion/ideology].
    /// Example: abstract artists are associated with Abstract (fine arts style); popes are associated with Roman Catholicism^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2335_associated_with">gvp:aat2335_associated_with</a>
    /// </summary>
    let aat2335_associated_with = _prefixId.prefix "aat2335_associated_with"
    /// <summary>
    ///   <para>dcterms:description : style/period/culture/[relgion] - has associates - [actors having] role.
    /// Example: Abstract (fine arts style) has associates abstract artists; Roman Catholicism has associates popes^^xsd:string</para>
    ///   <para>dce:title : has associates - role^^xsd:string</para>
    ///   <para>skos:example : Abstract (fine arts style) has associates abstract artists^^xsd:stringskos:example : Roman Catholicism has associates popes^^xsd:string</para>
    ///   <para>dce:identifier : 2336^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2336_has_associates^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2336_has_associates">gvp:aat2336_has_associates</a>
    /// </summary>
    let aat2336_has_associates = _prefixId.prefix "aat2336_has_associates"
    /// <summary>
    ///   <para>dce:title : focus of - field/discipline^^xsd:string</para>
    ///   <para>skos:example : manuscripts are the focus of codicology^^xsd:stringskos:example : Plantae (kingdom) is the focus of botany^^xsd:stringskos:example : music is the focus of musicology^^xsd:string</para>
    ///   <para>dcterms:description : any - [is] focus of - field [of study]/discipline.
    /// Example: manuscripts are the focus of codicology; music is the focus of musicology; Plantae (kingdom) is the focus of botany^^xsd:string</para>
    ///   <para>dce:identifier : 2397^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2397_focus_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2397_focus_of">gvp:aat2397_focus_of</a>
    /// </summary>
    let aat2397_focus_of = _prefixId.prefix "aat2397_focus_of"
    /// <summary>
    ///   <para>dcterms:description : field [of study]/discipline - focuses on - any.
    /// Example: codicology focuses on manuscripts; musicology focuses on music; bontany focuses on Plantae (kingdom)^^xsd:string</para>
    ///   <para>dce:identifier : 2398^^xsd:string</para>
    ///   <para>dce:title : focuses on - any^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2398_focuses_on^^xsd:string</para>
    ///   <para>skos:example : codicology focuses on manuscripts^^xsd:stringskos:example : musicology focuses on music^^xsd:stringskos:example : bontany focuses on Plantae (kingdom)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2398_focuses_on">gvp:aat2398_focuses_on</a>
    /// </summary>
    let aat2398_focuses_on = _prefixId.prefix "aat2398_focuses_on"
    /// <summary>
    ///   <para>dce:identifier : 2408^^xsd:string</para>
    ///   <para>skos:example : hospitals (buildings) are the locus/setting for medicine (discipline)^^xsd:stringskos:example : schools (buildings) are the locus/setting for education^^xsd:string</para>
    ///   <para>dce:title : locus/setting for - field/discipline^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2408_locus-setting_for^^xsd:string</para>
    ///   <para>dcterms:description : locus/setting - [is] locus/setting for - field of study/discipline.
    /// Example: schools (buildings) are the locus/setting for education; hospitals (buildings) are the locus/setting for medicine (discipline)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2408_locus-setting_for">gvp:aat2408_locus-setting_for</a>
    /// </summary>
    let aat2408_locus_setting_for = _prefixId.prefix "aat2408_locus-setting_for"
    /// <summary>
    ///   <para>dce:identifier : 2409^^xsd:string</para>
    ///   <para>skos:example : medicine (discipline) takes place in hospitals (buildings)^^xsd:stringskos:example : education takes place in schools (buildings)^^xsd:string</para>
    ///   <para>dce:title : takes place in - locus/setting^^xsd:string</para>
    ///   <para>dcterms:description : field of study/discipline - takes place in - locus/setting.
    /// Example: education takes place in schools (buildings); medicine (discipline) takes place in hospitals (buildings)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2409_takes_place_in^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2409_takes_place_in">gvp:aat2409_takes_place_in</a>
    /// </summary>
    let aat2409_takes_place_in = _prefixId.prefix "aat2409_takes_place_in"
    /// <summary>
    ///   <para>skos:example : gardening is involved in horticulture^^xsd:stringskos:example : journalistic photography is involved in photojournalism (discipline)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2411_involved_in^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - [is] involved in - field/discipline.
    /// Example: journalistic photography is involved in photojournalism (discipline); gardening is involved in horticulture^^xsd:string</para>
    ///   <para>dce:identifier : 2411^^xsd:string</para>
    ///   <para>dce:title : involved in - field/discipline^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2411_involved_in">gvp:aat2411_involved_in</a>
    /// </summary>
    let aat2411_involved_in = _prefixId.prefix "aat2411_involved_in"
    /// <summary>
    ///   <para>skos:prefLabel : aat2412_involves^^xsd:string</para>
    ///   <para>skos:example : horticulture involves gardening^^xsd:stringskos:example : photojournalism (discipline) involves journalistic photography^^xsd:string</para>
    ///   <para>dce:identifier : 2412^^xsd:string</para>
    ///   <para>dce:title : involves - activity/event^^xsd:string</para>
    ///   <para>dcterms:description : field/discipline - involves - activity/event/[process/function].
    /// Example: photojournalism (discipline) involves journalistic photography; horticulture involves gardening^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2412_involves">gvp:aat2412_involves</a>
    /// </summary>
    let aat2412_involves = _prefixId.prefix "aat2412_involves"
    /// <summary>
    ///   <para>dce:title : required for - activity/event^^xsd:string</para>
    ///   <para>skos:example : pewter is required for pewtersmithing^^xsd:stringskos:example : dye is required for dying^^xsd:string</para>
    ///   <para>dce:identifier : 2415^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] required for - activity/event/[process/function].
    /// Example: dye is required for dying; pewter is required for pewtersmithing^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2415_required_for^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2415_required_for">gvp:aat2415_required_for</a>
    /// </summary>
    let aat2415_required_for = _prefixId.prefix "aat2415_required_for"
    /// <summary>
    ///   <para>skos:prefLabel : aat2416_requires^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - requires - material.
    /// Example: dying requires dye; pewtersmithing requires pewter^^xsd:string</para>
    ///   <para>dce:title : requires - material^^xsd:string</para>
    ///   <para>skos:example : dying requires dye^^xsd:stringskos:example : pewtersmithing requires pewter^^xsd:string</para>
    ///   <para>dce:identifier : 2416^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2416_requires">gvp:aat2416_requires</a>
    /// </summary>
    let aat2416_requires = _prefixId.prefix "aat2416_requires"
    /// <summary>
    ///   <para>skos:example : astronomy uses astronomical instruments^^xsd:stringskos:example : divination [discipline] uses divination objects^^xsd:string</para>
    ///   <para>dcterms:description : field [of study]/discipline - uses - things/[equipment].
    /// Example: astronomy uses astronomical instruments; divination [discipline] uses divination objects^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2418_uses^^xsd:string</para>
    ///   <para>dce:title : uses - things^^xsd:string</para>
    ///   <para>dce:identifier : 2418^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2418_uses">gvp:aat2418_uses</a>
    /// </summary>
    let aat2418_uses = _prefixId.prefix "aat2418_uses"
    /// <summary>
    ///   <para>skos:example : astronomical instruments are used for astronomy^^xsd:stringskos:example : divination objects are used for divination [discipline]^^xsd:string</para>
    ///   <para>dce:title : used for - field/discipline^^xsd:string</para>
    ///   <para>dcterms:description : things/[equipment] - [are] used for - field [of study]/discipline.
    /// Example: astronomical instruments are used for astronomy; divination objects are used for divination [discipline]^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2419_used_for^^xsd:string</para>
    ///   <para>dce:identifier : 2419^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2419_used_for">gvp:aat2419_used_for</a>
    /// </summary>
    let aat2419_used_for = _prefixId.prefix "aat2419_used_for"
    /// <summary>
    ///   <para>dcterms:description : locus/setting - [is] locus/setting for - activity/event/[process/function].
    /// Example: smelters (metalworking plants) are the locus/setting for smelting; pilgrimage centers are the locus/setting for pilgrimages^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2421_locus-setting_for^^xsd:string</para>
    ///   <para>skos:example : smelters (metalworking plants) are the locus/setting for smelting^^xsd:stringskos:example : pilgrimage centers are the locus/setting for pilgrimages^^xsd:string</para>
    ///   <para>dce:title : locus/setting for - activity/event^^xsd:string</para>
    ///   <para>dce:identifier : 2421^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2421_locus-setting_for">gvp:aat2421_locus-setting_for</a>
    /// </summary>
    let aat2421_locus_setting_for = _prefixId.prefix "aat2421_locus-setting_for"
    /// <summary>
    ///   <para>skos:example : pilgrimages take place in pilgrimage centers^^xsd:stringskos:example : smelting takes place in smelters (metalworking plants)^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - takes place in - locus/setting.
    /// Example: smelting takes place in smelters (metalworking plants); pilgrimages take place in pilgrimage centers^^xsd:string</para>
    ///   <para>dce:identifier : 2422^^xsd:string</para>
    ///   <para>dce:title : takes place in - locus/setting^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2422_takes_place_in^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2422_takes_place_in">gvp:aat2422_takes_place_in</a>
    /// </summary>
    let aat2422_takes_place_in = _prefixId.prefix "aat2422_takes_place_in"
    /// <summary>
    ///   <para>dcterms:description : material - [is] produced by - activity/event/process.
    /// Example: wire is produced by wiredrawing; paper is produced by papermaking^^xsd:string</para>
    ///   <para>skos:example : paper is produced by papermaking^^xsd:stringskos:example : wire is produced by wiredrawing^^xsd:string</para>
    ///   <para>dce:title : produced by - activity/event/process^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2424_produced_by^^xsd:string</para>
    ///   <para>dce:identifier : 2424^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2424_produced_by">gvp:aat2424_produced_by</a>
    /// </summary>
    let aat2424_produced_by = _prefixId.prefix "aat2424_produced_by"
    /// <summary>
    ///   <para>skos:prefLabel : aat2425_produces^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/process - produces - material.
    /// Example: wiredrawing produces wire; papermaking produces paper^^xsd:string</para>
    ///   <para>skos:example : wiredrawing produces wire^^xsd:stringskos:example : papermaking produces paper^^xsd:string</para>
    ///   <para>dce:title : produces - material^^xsd:string</para>
    ///   <para>dce:identifier : 2425^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2425_produces">gvp:aat2425_produces</a>
    /// </summary>
    let aat2425_produces = _prefixId.prefix "aat2425_produces"
    /// <summary>
    ///   <para>skos:example : forgeries are produced by forging (copying)^^xsd:stringskos:example : vase paintings (visual works) are produced by vase painting (image making)^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] produced by - activity/event/process.
    /// Example: vase paintings (visual works) are produced by vase painting (image making); forgeries are produced by forging (copying)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2427_produced_by^^xsd:string</para>
    ///   <para>dce:title : produced by - activity/event/process^^xsd:string</para>
    ///   <para>dce:identifier : 2427^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2427_produced_by">gvp:aat2427_produced_by</a>
    /// </summary>
    let aat2427_produced_by = _prefixId.prefix "aat2427_produced_by"
    /// <summary>
    ///   <para>dce:title : produces - things^^xsd:string</para>
    ///   <para>dce:identifier : 2428^^xsd:string</para>
    ///   <para>skos:example : forging (copying) produces forgeries^^xsd:stringskos:example : vase painting (image making) produces vase paintings (visual works)^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/process - produces - things.
    /// Example: vase painting (image making) produces vase paintings (visual works); forging (copying) produces forgeries^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2428_produces^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2428_produces">gvp:aat2428_produces</a>
    /// </summary>
    let aat2428_produces = _prefixId.prefix "aat2428_produces"
    /// <summary>
    ///   <para>dce:title : required for - activity/event/process^^xsd:string</para>
    ///   <para>skos:example : dowels are required for doweling^^xsd:stringskos:example : painting equipment is required for painting (image making)^^xsd:string</para>
    ///   <para>dcterms:description : things/equipment - [are] required for - activity/event/process.
    /// Example: painting equipment is required for painting (image making); dowels are required for doweling^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2431_required_for^^xsd:string</para>
    ///   <para>dce:identifier : 2431^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2431_required_for">gvp:aat2431_required_for</a>
    /// </summary>
    let aat2431_required_for = _prefixId.prefix "aat2431_required_for"
    /// <summary>
    ///   <para>skos:example : doweling requires dowels^^xsd:stringskos:example : painting (image making) requires painting equipment^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/process - requires - things/equipment.
    /// Example: painting (image making) requires painting equipment; doweling requires dowels^^xsd:string</para>
    ///   <para>dce:title : requires - things^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2432_requires^^xsd:string</para>
    ///   <para>dce:identifier : 2432^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2432_requires">gvp:aat2432_requires</a>
    /// </summary>
    let aat2432_requires = _prefixId.prefix "aat2432_requires"
    /// <summary>
    ///   <para>dcterms:description : things - [are] context for - activity/event/process.
    /// Example: funeral books are contextualized in funerals; Christmas trees are contextualized in Christmas^^xsd:string</para>
    ///   <para>dce:title : contextualized in - activity/event/process^^xsd:string</para>
    ///   <para>skos:example : funeral books are contextualized in funerals^^xsd:stringskos:example : Christmas trees are contextualized in Christmas^^xsd:string</para>
    ///   <para>dce:identifier : 2434^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2434_contextualized_in^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2434_contextualized_in">gvp:aat2434_contextualized_in</a>
    /// </summary>
    let aat2434_contextualized_in = _prefixId.prefix "aat2434_contextualized_in"
    /// <summary>
    ///   <para>dce:identifier : 2435^^xsd:string</para>
    ///   <para>skos:example : funerals are the context for funeral books^^xsd:stringskos:example : Christmas is the context for Christmas trees^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2435_context_for^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/process - [is] contextualized in - thing.
    /// Example: funerals are the context for funeral books; Christmas is the context for Christmas trees^^xsd:string</para>
    ///   <para>dce:title : context for - things^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2435_context_for">gvp:aat2435_context_for</a>
    /// </summary>
    let aat2435_context_for = _prefixId.prefix "aat2435_context_for"
    /// <summary>
    ///   <para>dce:title : made of/require - material^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] made of/require - material.
    /// Example: obsidian mirrors are made of/require obsidian; ivories (sculptures) are made of/require ivory^^xsd:string</para>
    ///   <para>skos:example : ivories (sculptures) are made of/require ivory^^xsd:stringskos:example : obsidian mirrors are made of/require obsidian^^xsd:string</para>
    ///   <para>dce:identifier : 2501^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2501_made_of-require^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2501_made_of-require">gvp:aat2501_made_of-require</a>
    /// </summary>
    let aat2501_made_of_require = _prefixId.prefix "aat2501_made_of-require"
    /// <summary>
    ///   <para>skos:prefLabel : aat2502_material_for^^xsd:string</para>
    ///   <para>skos:example : ivory is material for ivories (sculptures)^^xsd:stringskos:example : obsidian is material for obsidian mirrors^^xsd:string</para>
    ///   <para>dce:title : material for - things^^xsd:string</para>
    ///   <para>dce:identifier : 2502^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] material for - things.
    /// Example: obsidian is material for obsidian mirrors; ivory is material for ivories (sculptures)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2502_material_for">gvp:aat2502_material_for</a>
    /// </summary>
    let aat2502_material_for = _prefixId.prefix "aat2502_material_for"
    /// <summary>
    ///   <para>dcterms:description : material - [is] used/located in - locus/setting.
    /// Example: tephra is used/located in [at] volcanoes; brick (clay product) is used/located in brickworks (factories)^^xsd:string</para>
    ///   <para>skos:example : brick (clay product) is used/located in brickworks (factories)^^xsd:stringskos:example : tephra is used/located in [at] volcanoes^^xsd:string</para>
    ///   <para>dce:title : used/located in - locus/setting^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2504_used-located_in^^xsd:string</para>
    ///   <para>dce:identifier : 2504^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2504_used-located_in">gvp:aat2504_used-located_in</a>
    /// </summary>
    let aat2504_used_located_in = _prefixId.prefix "aat2504_used-located_in"
    /// <summary>
    ///   <para>skos:example : volcanoes are locus/setting for  tephra^^xsd:stringskos:example : brickworks (factories) are locus/setting for brick (clay product)^^xsd:string</para>
    ///   <para>dcterms:description : locus/setting - [is] locus/setting for - material.
    /// Example: volcanoes are locus/setting for  tephra; brickworks (factories) are locus/setting for brick (clay product)^^xsd:string</para>
    ///   <para>dce:identifier : 2505^^xsd:string</para>
    ///   <para>dce:title : locus/setting for - material^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2505_locus-setting_for^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2505_locus-setting_for">gvp:aat2505_locus-setting_for</a>
    /// </summary>
    let aat2505_locus_setting_for = _prefixId.prefix "aat2505_locus-setting_for"
    /// <summary>
    ///   <para>skos:prefLabel : aat2507_produce-process^^xsd:string</para>
    ///   <para>dcterms:description : things/[equipment] - produce/process - material.
    /// Example: cotton (fiber) is produced/processed by cotton gins; groundwater is produced/processed by water wells^^xsd:string</para>
    ///   <para>skos:example : cotton (fiber) is produced/processed by cotton gins^^xsd:stringskos:example : groundwater is produced/processed by water wells^^xsd:string</para>
    ///   <para>dce:title : produce/process - material^^xsd:string</para>
    ///   <para>dce:identifier : 2507^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2507_produce-process">gvp:aat2507_produce-process</a>
    /// </summary>
    let aat2507_produce_process = _prefixId.prefix "aat2507_produce-process"
    /// <summary>
    ///   <para>dce:title : produced/processed by - things^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] produced/processed by - things/[equipment].
    /// Example: cotton gins produce/process cotton (fiber); waterwells produce/process groundwater^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2508_produced-processed_by^^xsd:string</para>
    ///   <para>skos:example : cotton gins produce/process cotton (fiber)^^xsd:stringskos:example : waterwells produce/process groundwater^^xsd:string</para>
    ///   <para>dce:identifier : 2508^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2508_produced-processed_by">gvp:aat2508_produced-processed_by</a>
    /// </summary>
    let aat2508_produced_processed_by = _prefixId.prefix "aat2508_produced-processed_by"
    /// <summary>
    ///   <para>skos:example : Judaica reflects/is produced by Judaism^^xsd:stringskos:example : Nasca lines reflect/are produced by Nasca [culture]^^xsd:string</para>
    ///   <para>dcterms:description : things - reflect/[are] produced by - style/period/culture/[religion/ideology].
    /// Example: Nasca lines reflect/are produced by Nasca [culture]; Judaica reflects/is produced by Judaism^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2551_reflect-produced_by^^xsd:string</para>
    ///   <para>dce:identifier : 2551^^xsd:string</para>
    ///   <para>dce:title : reflect/produced by - style/period/culture^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2551_reflect-produced_by">gvp:aat2551_reflect-produced_by</a>
    /// </summary>
    let aat2551_reflect_produced_by = _prefixId.prefix "aat2551_reflect-produced_by"
    /// <summary>
    ///   <para>skos:prefLabel : aat2552_reflected_in-produces^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture/[religion/ideology] - [is] reflected in/produces - things.
    /// Example: Nasca [culture] produces/is reflected in Nasca lines; Judaism produces/is reflected in Judaica^^xsd:string</para>
    ///   <para>dce:identifier : 2552^^xsd:string</para>
    ///   <para>skos:example : Nasca [culture] produces/is reflected in Nasca lines^^xsd:stringskos:example : Judaism produces/is reflected in Judaica^^xsd:string</para>
    ///   <para>dce:title : reflected in/produces - things^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2552_reflected_in-produces">gvp:aat2552_reflected_in-produces</a>
    /// </summary>
    let aat2552_reflected_in_produces = _prefixId.prefix "aat2552_reflected_in-produces"
    /// <summary>
    ///   <para>skos:example : dhokra (casting technique) reflects Dhokra (culture)^^xsd:stringskos:example : red-figure vase painting reflects Red-figure [style]^^xsd:string</para>
    ///   <para>dcterms:description : activity/event - reflects - style/period/culture /[religion/ideology].
    /// Example: dhokra (casting technique) reflects Dhokra (culture); red-figure vase painting reflects Red-figure [style]^^xsd:string</para>
    ///   <para>dce:identifier : 2554^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2554_reflects^^xsd:string</para>
    ///   <para>dce:title : reflects - style/period/culture^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2554_reflects">gvp:aat2554_reflects</a>
    /// </summary>
    let aat2554_reflects = _prefixId.prefix "aat2554_reflects"
    /// <summary>
    ///   <para>dce:title : reflected in - activity/event^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture /[religion/ideology] - [is] reflected in activity/event.
    /// Example: Dhokra (culture) is reflected in dhokra (casting technique); Red-figure [style] is reflected in red-figure vase painting^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2555_reflected_in^^xsd:string</para>
    ///   <para>dce:identifier : 2555^^xsd:string</para>
    ///   <para>skos:example : Dhokra (culture) is reflected in dhokra (casting technique)^^xsd:stringskos:example : Red-figure [style] is reflected in red-figure vase painting^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2555_reflected_in">gvp:aat2555_reflected_in</a>
    /// </summary>
    let aat2555_reflected_in = _prefixId.prefix "aat2555_reflected_in"
    /// <summary>
    ///   <para>skos:example : classics (discipline) reflects Ancient Greek [culture]^^xsd:stringskos:example : church history reflects Christianity^^xsd:stringskos:example : bugatu [dance discipline] reflects Buddhism^^xsd:string</para>
    ///   <para>dce:title : reflects - style/period/culture^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2557_reflects^^xsd:string</para>
    ///   <para>dcterms:description : field/discipline - reflects - style/period/culture /[religion/ideology].
    /// Example: bugatu [dance discipline] reflects Buddhism; church history reflects Christianity; classics (discipline) reflects Ancient Greek [culture]^^xsd:string</para>
    ///   <para>dce:identifier : 2557^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2557_reflects">gvp:aat2557_reflects</a>
    /// </summary>
    let aat2557_reflects = _prefixId.prefix "aat2557_reflects"
    /// <summary>
    ///   <para>skos:example : Ancient Greek [culture] is reflected in classics (discipline)^^xsd:stringskos:example : Buddhism is reflected in bugatu [dance discipline]^^xsd:stringskos:example : Christianity is reflected in church history^^xsd:string</para>
    ///   <para>dce:identifier : 2558^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2558_reflected_in^^xsd:string</para>
    ///   <para>dce:title : reflected in - field/discipline^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture /[religion/ideology] - [is] reflected in field/discipline.
    /// Example: Buddhism is reflected in bugatu [dance discipline]; Christianity is reflected in church history; Ancient Greek [culture] is reflected in classics (discipline)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2558_reflected_in">gvp:aat2558_reflected_in</a>
    /// </summary>
    let aat2558_reflected_in = _prefixId.prefix "aat2558_reflected_in"
    /// <summary>
    ///   <para>dce:title : locus/setting for - style/period/culture^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2562_locus-setting_for^^xsd:string</para>
    ///   <para>dce:identifier : 2562^^xsd:string</para>
    ///   <para>skos:example : agraharas are the locus/setting for Brahmanism^^xsd:stringskos:example : First Nations reserves are the locus/setting for First Nations (culture)^^xsd:string</para>
    ///   <para>dcterms:description : locus/setting - [is] locus/setting for - style/period/culture/[religion/ideology].
    /// Example: First Nations reserves are the locus/setting for First Nations (culture); agraharas are the locus/setting for Brahmanism^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2562_locus-setting_for">gvp:aat2562_locus-setting_for</a>
    /// </summary>
    let aat2562_locus_setting_for = _prefixId.prefix "aat2562_locus-setting_for"
    /// <summary>
    ///   <para>skos:example : First Nations (culture) is located/reflected in First Nations reserves^^xsd:stringskos:example : Brahmanism is located/reflected in agraharas^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture/[religion/ideology] - is located/[reflected] in - locus/setting.
    /// Example: First Nations (culture) is located/reflected in First Nations reserves; Brahmanism is located/reflected in agraharas^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2563_located_in^^xsd:string</para>
    ///   <para>dce:identifier : 2563^^xsd:string</para>
    ///   <para>dce:title : located in - locus/setting^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2563_located_in">gvp:aat2563_located_in</a>
    /// </summary>
    let aat2563_located_in = _prefixId.prefix "aat2563_located_in"

    /// <summary>
    ///   <para>skos:example : adulthood is possessed by/existing in adults^^xsd:stringskos:example : nomadism is possessed by/existing in nomads^^xsd:string</para>
    ///   <para>dce:identifier : 2601^^xsd:string</para>
    ///   <para>dcterms:description : attributes /associated concepts - [is] possessed by/existing in - role [of actors].
    /// Example: adulthood is possessed by/existing in adults; nomadism is possessed by/existing in nomads^^xsd:string</para>
    ///   <para>dce:title : possessed by/existing in - role^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2601_possessed_by-existing_in^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2601_possessed_by-existing_in">gvp:aat2601_possessed_by-existing_in</a>
    /// </summary>
    let aat2601_possessed_by_existing_in =
        _prefixId.prefix "aat2601_possessed_by-existing_in"

    /// <summary>
    ///   <para>skos:example : nomads possess/exist in [state of] nomadism^^xsd:stringskos:example : adults possess/exist in adulthood^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2602_possess-exist_in^^xsd:string</para>
    ///   <para>dce:identifier : 2602^^xsd:string</para>
    ///   <para>dcterms:description : role [of actors] - possess/exist in - attributes /associated concepts.
    /// Example: adults possess/exist in adulthood; nomads possess/exist in [state of] nomadism^^xsd:string</para>
    ///   <para>dce:title : possess/exist in - attributes /associated concepts^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2602_possess-exist_in">gvp:aat2602_possess-exist_in</a>
    /// </summary>
    let aat2602_possess_exist_in = _prefixId.prefix "aat2602_possess-exist_in"

    /// <summary>
    ///   <para>dcterms:description : attributes /associated concepts - [is] possessed by/existing in - things.
    /// Example: boudoir (photograph size) is possessed by/existing in boudoir photographs; ruined [condition] is possessed by/existing in ruins^^xsd:string</para>
    ///   <para>skos:example : ruined [condition] is possessed by/existing in ruins^^xsd:stringskos:example : boudoir (photograph size) is possessed by/existing in boudoir photographs^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2604_possessed_by-existing_in^^xsd:string</para>
    ///   <para>dce:title : possessed by/existing in - things^^xsd:string</para>
    ///   <para>dce:identifier : 2604^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2604_possessed_by-existing_in">gvp:aat2604_possessed_by-existing_in</a>
    /// </summary>
    let aat2604_possessed_by_existing_in =
        _prefixId.prefix "aat2604_possessed_by-existing_in"

    /// <summary>
    ///   <para>dce:identifier : 2605^^xsd:string</para>
    ///   <para>skos:example : boudoir photographs possess/exist in boudoir (photograph size)^^xsd:stringskos:example : ruins possess/exist in ruined [contition]^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2605_possess-exist_in^^xsd:string</para>
    ///   <para>dce:title : possess/exist in - attributes /associated concepts^^xsd:string</para>
    ///   <para>dcterms:description : things - possess/exist in - attributes /associated concepts.
    /// Example: boudoir photographs possess/exist in boudoir (photograph size); ruins possess/exist in ruined [contition]^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2605_possess-exist_in">gvp:aat2605_possess-exist_in</a>
    /// </summary>
    let aat2605_possess_exist_in = _prefixId.prefix "aat2605_possess-exist_in"
    /// <summary>
    ///   <para>skos:prefLabel : aat2607_caused_by-requires^^xsd:string</para>
    ///   <para>dce:identifier : 2607^^xsd:string</para>
    ///   <para>dcterms:description : attributes /associated concepts - [is] caused by/requires - an activity/event/[process/function].
    /// Example: watertightness is caused by/requires waterproofing; creases (condition) is caused by/requires creasing (process)^^xsd:string</para>
    ///   <para>skos:example : creases (condition) is caused by/requires creasing (process)^^xsd:stringskos:example : watertightness is caused by/requires waterproofing^^xsd:string</para>
    ///   <para>dce:title : caused by/requires - activity/event^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2607_caused_by-requires">gvp:aat2607_caused_by-requires</a>
    /// </summary>
    let aat2607_caused_by_requires = _prefixId.prefix "aat2607_caused_by-requires"
    /// <summary>
    ///   <para>skos:prefLabel : aat2608_causes-required_for^^xsd:string</para>
    ///   <para>skos:example : creasing (process) causes/is required for creases (condition)^^xsd:stringskos:example : waterproofing causes/is required for watertighness^^xsd:string</para>
    ///   <para>dce:identifier : 2608^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - causes/[is] required for - [a] state/condition/attributes.
    /// Example: waterproofing causes/is required for watertighness; creasing (process) causes/is required for creases (condition)^^xsd:string</para>
    ///   <para>dce:title : causes/required for - attributes /associated concepts^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2608_causes-required_for">gvp:aat2608_causes-required_for</a>
    /// </summary>
    let aat2608_causes_required_for = _prefixId.prefix "aat2608_causes-required_for"

    /// <summary>
    ///   <para>skos:example : dry rot is possessed by/existing in wood(plant material)^^xsd:stringskos:example : dielectric properties are possessed by/existing in dielectric (material)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2612_possessed_by-existing_in^^xsd:string</para>
    ///   <para>dce:identifier : 2612^^xsd:string</para>
    ///   <para>dcterms:description : attributes /associated concepts - is possessed by/existing in - material.
    /// Example: dry rot is possessed by/existing in wood(plant material); dielectric properties are possessed by/existing in dielectric (material)^^xsd:string</para>
    ///   <para>dce:title : possessed by/existing in - material^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2612_possessed_by-existing_in">gvp:aat2612_possessed_by-existing_in</a>
    /// </summary>
    let aat2612_possessed_by_existing_in =
        _prefixId.prefix "aat2612_possessed_by-existing_in"

    /// <summary>
    ///   <para>dcterms:description : material - possesses/exists in - condition/state/[property].
    /// Example: wood(plant material) possesses/exists in [condition of] dry rot; dielectric (material) possesses/exists in dielectric properties^^xsd:string</para>
    ///   <para>dce:identifier : 2613^^xsd:string</para>
    ///   <para>dce:title : possess/exist in - attributes /associated concepts^^xsd:string</para>
    ///   <para>skos:example : wood(plant material) possesses/exists in [condition of] dry rot^^xsd:stringskos:example : dielectric (material) possesses/exists in dielectric properties^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2613_possess-exist_in^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2613_possess-exist_in">gvp:aat2613_possess-exist_in</a>
    /// </summary>
    let aat2613_possess_exist_in = _prefixId.prefix "aat2613_possess-exist_in"
    /// <summary>
    ///   <para>skos:example : dining tables are conjuncted with dining chairs^^xsd:stringskos:example : cups are conjuncted with saucers^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] conjuncted with - things.
    /// Example: cups are conjuncted with saucers; dining tables are conjuncted with dining chairs^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2801_conjuncted_with^^xsd:string</para>
    ///   <para>dce:title : conjuncted with - things^^xsd:string</para>
    ///   <para>dce:identifier : 2801^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2801_conjuncted_with">gvp:aat2801_conjuncted_with</a>
    /// </summary>
    let aat2801_conjuncted_with = _prefixId.prefix "aat2801_conjuncted_with"
    /// <summary>
    ///   <para>dcterms:description : material - [is] exemplified by - brand name.
    /// Example: petrolium jelly is exemplified by Vaseline (TM); polytetrafluoroethyelene is exemplified by Teflon (TM)^^xsd:string</para>
    ///   <para>skos:example : polytetrafluoroethyelene is exemplified by Teflon (TM)^^xsd:stringskos:example : petrolium jelly is exemplified by Vaseline (TM)^^xsd:string</para>
    ///   <para>dce:title : exemplified by - brand name^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2802_exemplified_by^^xsd:string</para>
    ///   <para>dce:identifier : 2802^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2802_exemplified_by">gvp:aat2802_exemplified_by</a>
    /// </summary>
    let aat2802_exemplified_by = _prefixId.prefix "aat2802_exemplified_by"
    /// <summary>
    ///   <para>skos:prefLabel : aat2803_example_of^^xsd:string</para>
    ///   <para>skos:example : Vaseline (TM) is an example of petrolium jelly^^xsd:stringskos:example : Teflon (TM) is an example of polytetrafluoroethyelene^^xsd:string</para>
    ///   <para>dce:title : example of - material^^xsd:string</para>
    ///   <para>dcterms:description : brand name - [is] example of - material.
    /// Example: Vaseline (TM) is an example of petrolium jelly; Teflon (TM) is an example of polytetrafluoroethyelene^^xsd:string</para>
    ///   <para>dce:identifier : 2803^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2803_example_of">gvp:aat2803_example_of</a>
    /// </summary>
    let aat2803_example_of = _prefixId.prefix "aat2803_example_of"
    /// <summary>
    ///   <para>dce:title : contextualized in - things^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2805_contextualized_in^^xsd:string</para>
    ///   <para>skos:example : predellas are contextualized in altarpieces^^xsd:stringskos:example : chapters are contextualized in books^^xsd:string</para>
    ///   <para>dcterms:description : [smaller] things - [are] contextualized in - [larger] things.
    /// Example: predellas are contextualized in altarpieces; chapters are contextualized in books^^xsd:string</para>
    ///   <para>dce:identifier : 2805^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2805_contextualized_in">gvp:aat2805_contextualized_in</a>
    /// </summary>
    let aat2805_contextualized_in = _prefixId.prefix "aat2805_contextualized_in"
    /// <summary>
    ///   <para>skos:example : altarpieces provide context for predellas^^xsd:stringskos:example : books provide context for chapters^^xsd:string</para>
    ///   <para>dcterms:description : [larger] things - provide context [for] - [smaller] things.
    /// Example: altarpieces provide context for predellas; books provide context for chapters^^xsd:string</para>
    ///   <para>dce:identifier : 2806^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2806_provide_context^^xsd:string</para>
    ///   <para>dce:title : provide context - things^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2806_provide_context">gvp:aat2806_provide_context</a>
    /// </summary>
    let aat2806_provide_context = _prefixId.prefix "aat2806_provide_context"

    /// <summary>
    ///   <para>skos:example : mustard(material) is derived from common source with mustard oil^^xsd:stringskos:example : malachite (mineral) is derived from common source with azurite (mineral)^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] derived from common source [as] - material.
    /// Example: malachite (mineral) is derived from common source with azurite (mineral); mustard(material) is derived from common source with mustard oil^^xsd:string</para>
    ///   <para>dce:title : derived from common source - material^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2807_derived_from_common_source^^xsd:string</para>
    ///   <para>dce:identifier : 2807^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2807_derived_from_common_source">gvp:aat2807_derived_from_common_source</a>
    /// </summary>
    let aat2807_derived_from_common_source =
        _prefixId.prefix "aat2807_derived_from_common_source"

    /// <summary>
    ///   <para>skos:example : Early Minoan coexisted with Prepalatial^^xsd:stringskos:example : Sangoan coexisted with Fauresmith^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture/[religion/ideology] - coexisted with -  style/period/culture/[religion/ideology].
    /// Example: Sangoan coexisted with Fauresmith; Early Minoan coexisted with Prepalatial^^xsd:string</para>
    ///   <para>dce:title : coexisted with - style/period/culture^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2809_coexisted_with^^xsd:string</para>
    ///   <para>dce:identifier : 2809^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2809_coexisted_with">gvp:aat2809_coexisted_with</a>
    /// </summary>
    let aat2809_coexisted_with = _prefixId.prefix "aat2809_coexisted_with"
    /// <summary>
    ///   <para>skos:example : Acheulian preceded Micoquian^^xsd:stringskos:example : Impressionist preceded Abstract Impressionist^^xsd:string</para>
    ///   <para>dce:identifier : 2811^^xsd:string</para>
    ///   <para>dce:title : preceded - style/period/culture^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2811_preceded^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture/[religion/ideology] - preceded  - style/period/culture/[religion/ideology].
    /// Example: Impressionist preceded Abstract Impressionist; Acheulian preceded Micoquian^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2811_preceded">gvp:aat2811_preceded</a>
    /// </summary>
    let aat2811_preceded = _prefixId.prefix "aat2811_preceded"
    /// <summary>
    ///   <para>skos:example : Micoquian followed Acheulian^^xsd:stringskos:example : Abstract Impressionism followed Impressionist^^xsd:string</para>
    ///   <para>dce:identifier : 2812^^xsd:string</para>
    ///   <para>dce:title : followed - style/period/culture^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2812_followed^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture/[religion/ideology] - followed  - style/period/culture/[religion/ideology].
    /// Example: Abstract Impressionism followed Impressionist; Micoquian followed Acheulian^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2812_followed">gvp:aat2812_followed</a>
    /// </summary>
    let aat2812_followed = _prefixId.prefix "aat2812_followed"
    /// <summary>
    ///   <para>dce:identifier : 2814^^xsd:string</para>
    ///   <para>skos:example : iron oxide is a constituent of desert varnish^^xsd:stringskos:example : titanium white is a constituent of composite white^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] constituent of - material.
    /// Example: titanium white is a constituent of composite white; iron oxide is a constituent of desert varnish^^xsd:string</para>
    ///   <para>dce:title : constituent of - material^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2814_constituent_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2814_constituent_of">gvp:aat2814_constituent_of</a>
    /// </summary>
    let aat2814_constituent_of = _prefixId.prefix "aat2814_constituent_of"
    /// <summary>
    ///   <para>dcterms:description : material - [is] composed of - material.
    /// Example: composite white is composed of titanium white; desert varnish is composed of iron oxide^^xsd:string</para>
    ///   <para>skos:example : composite white is composed of titanium white^^xsd:stringskos:example : desert varnish is composed of iron oxide^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2815_composed_of^^xsd:string</para>
    ///   <para>dce:title : composed of - material^^xsd:string</para>
    ///   <para>dce:identifier : 2815^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2815_composed_of">gvp:aat2815_composed_of</a>
    /// </summary>
    let aat2815_composed_of = _prefixId.prefix "aat2815_composed_of"
    /// <summary>
    ///   <para>dce:identifier : 2817^^xsd:string</para>
    ///   <para>dce:title : derived/made from - material^^xsd:string</para>
    ///   <para>skos:example : gypsum is derived/made from from anhydrite^^xsd:stringskos:example : wood board is derived/made from timber (lumber)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2817_derived-made_from^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] derived/made from - material.
    /// Example: gypsum is derived/made from from anhydrite; wood board is derived/made from timber (lumber)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2817_derived-made_from">gvp:aat2817_derived-made_from</a>
    /// </summary>
    let aat2817_derived_made_from = _prefixId.prefix "aat2817_derived-made_from"
    /// <summary>
    ///   <para>skos:example : timber (lumber) is the source for wood board^^xsd:stringskos:example : anhydrite is the source for gypsum^^xsd:string</para>
    ///   <para>dce:identifier : 2818^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2818_source_for^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] source for - material.
    /// Example: anhydrite is the source for gypsum; timber (lumber) is the source for wood board^^xsd:string</para>
    ///   <para>dce:title : source for - material^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2818_source_for">gvp:aat2818_source_for</a>
    /// </summary>
    let aat2818_source_for = _prefixId.prefix "aat2818_source_for"
    /// <summary>
    ///   <para>skos:example : pencils are based on plummets^^xsd:stringskos:example : Neo-Gothic is based on Gothic (Medieval)^^xsd:stringskos:example : curved [form attribute] is based on curves (geometric figures)^^xsd:string</para>
    ///   <para>dce:identifier : 2821^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2821_based_on^^xsd:string</para>
    ///   <para>dce:title : based on - any^^xsd:string</para>
    ///   <para>dcterms:description : any - [is] based on - any.
    /// Example: Neo-Gothic is based on Gothic (Medieval); curved [form attribute] is based on curves (geometric figures); pencils are based on plummets^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2821_based_on">gvp:aat2821_based_on</a>
    /// </summary>
    let aat2821_based_on = _prefixId.prefix "aat2821_based_on"
    /// <summary>
    ///   <para>skos:example : plummets are the basis of pencils^^xsd:stringskos:example : Gothic (Medieval) is the basis of Neo-Gothic^^xsd:stringskos:example : curves (geometric figures) are the basis of curved [form attribute]^^xsd:string</para>
    ///   <para>dcterms:description : any - [is] basis of - any.
    /// Example: Gothic (Medieval) is the basis of Neo-Gothic; curves (geometric figures) are the basis of curved [form attribute]; plummets are the basis of pencils^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2822_basis_of^^xsd:string</para>
    ///   <para>dce:title : basis of - any^^xsd:string</para>
    ///   <para>dce:identifier : 2822^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2822_basis_of">gvp:aat2822_basis_of</a>
    /// </summary>
    let aat2822_basis_of = _prefixId.prefix "aat2822_basis_of"
    /// <summary>
    ///   <para>skos:example : Gnathian (pottery style) has parallels with West Slope (pottery style)^^xsd:stringskos:example : Lagozza [culture] has parallels with Chasseen [culture]^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture/[religion/ideology] - has parallels with - style/period/culture/[religion/ideology].
    /// Example: Lagozza [culture] has parallels with Chasseen [culture];  Gnathian (pottery style) has parallels with West Slope (pottery style)^^xsd:string</para>
    ///   <para>dce:title : has parallels with - style/period/culture^^xsd:string</para>
    ///   <para>dce:identifier : 2824^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2824_has_parallels_with^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2824_has_parallels_with">gvp:aat2824_has_parallels_with</a>
    /// </summary>
    let aat2824_has_parallels_with = _prefixId.prefix "aat2824_has_parallels_with"
    /// <summary>
    ///   <para>dce:identifier : 2826^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2826_used_with^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] used with - material.
    /// Example: watercolor paper is used with watercolor (paint); arriccio is used with intonaco^^xsd:string</para>
    ///   <para>skos:example : arriccio is used with intonaco^^xsd:stringskos:example : watercolor paper is used with watercolor (paint)^^xsd:string</para>
    ///   <para>dce:title : used with - material^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2826_used_with">gvp:aat2826_used_with</a>
    /// </summary>
    let aat2826_used_with = _prefixId.prefix "aat2826_used_with"
    /// <summary>
    ///   <para>skos:example : wine glasses use/require wine^^xsd:stringskos:example : oil paintings use/require varnish^^xsd:string</para>
    ///   <para>dcterms:description : things - use/require - material.
    /// Example: oil paintings use/require varnish; wine glasses use/require wine^^xsd:string</para>
    ///   <para>dce:title : use/require - material^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2828_use-require^^xsd:string</para>
    ///   <para>dce:identifier : 2828^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2828_use-require">gvp:aat2828_use-require</a>
    /// </summary>
    let aat2828_use_require = _prefixId.prefix "aat2828_use-require"
    /// <summary>
    ///   <para>dce:title : used/required for - things^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2829_used-required_for^^xsd:string</para>
    ///   <para>skos:example : varnish is used/required for oil paintings^^xsd:stringskos:example : wine is required/used for wine glasses^^xsd:string</para>
    ///   <para>dce:identifier : 2829^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] required/used for - things.
    /// Example: varnish is used/required for oil paintings; wine is required/used for wine glasses^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2829_used-required_for">gvp:aat2829_used-required_for</a>
    /// </summary>
    let aat2829_used_required_for = _prefixId.prefix "aat2829_used-required_for"
    /// <summary>
    ///   <para>skos:example : Anthonomus grandis (species) [boll weevil] is associated with Gossypium (genus) [cotton]^^xsd:stringskos:example : Amphiprioninae (subfamily) [clown fish] is associated with Actiniaria (order) [sea anemone]^^xsd:string</para>
    ///   <para>dcterms:description : genus/species/[other living organism term] - [is] associated with - genus/species.
    /// Example: Anthonomus grandis (species) [boll weevil] is associated with Gossypium (genus) [cotton]; Amphiprioninae (subfamily) [clown fish] is associated with Actiniaria (order) [sea anemone]^^xsd:string</para>
    ///   <para>dce:title : associated with - genus/species^^xsd:string</para>
    ///   <para>dce:identifier : 2831^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2831_associated_with^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2831_associated_with">gvp:aat2831_associated_with</a>
    /// </summary>
    let aat2831_associated_with = _prefixId.prefix "aat2831_associated_with"
    /// <summary>
    ///   <para>dce:identifier : 2833^^xsd:string</para>
    ///   <para>skos:example : Equus asinus is the ancestor of donkeys^^xsd:stringskos:example : Canis lupus is the ancestor of Canis familiaris^^xsd:string</para>
    ///   <para>dcterms:description : genus/species - is ancestor of -  another genus/species.
    /// Example: Canis lupus is the ancestor of Canis familiaris; Equus asinus is the ancestor of donkeys^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2833_ancestor_of^^xsd:string</para>
    ///   <para>dce:title : ancestor of - genus/species^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2833_ancestor_of">gvp:aat2833_ancestor_of</a>
    /// </summary>
    let aat2833_ancestor_of = _prefixId.prefix "aat2833_ancestor_of"
    /// <summary>
    ///   <para>skos:example : Canis familiaris is the descendant of Canis lupus^^xsd:stringskos:example : donkeys are the descendents of Equus asinus^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2834_decendant_of^^xsd:string</para>
    ///   <para>dce:title : decendant of - genus/species^^xsd:string</para>
    ///   <para>dce:identifier : 2834^^xsd:string</para>
    ///   <para>dcterms:description : genus/species - is decendant of -  genus/species.
    /// Example: Canis familiaris is the descendant of Canis lupus; donkeys are the descendents of Equus asinus^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2834_decendant_of">gvp:aat2834_decendant_of</a>
    /// </summary>
    let aat2834_decendant_of = _prefixId.prefix "aat2834_decendant_of"
    /// <summary>
    ///   <para>dce:title : derived/made from - genus/species^^xsd:string</para>
    ///   <para>dce:identifier : 2836^^xsd:string</para>
    ///   <para>skos:example : k?kaku are derived/made from Phormium tenax (species)^^xsd:stringskos:example : ostrich-egg cups are derived/made from Struthio camelus (species)^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] derived/made from - genus/species [or its parts].
    /// Example: k?kaku are derived/made from Phormium tenax (species); ostrich-egg cups are derived/made from Struthio camelus (species)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2836_derived-made_from^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2836_derived-made_from">gvp:aat2836_derived-made_from</a>
    /// </summary>
    let aat2836_derived_made_from = _prefixId.prefix "aat2836_derived-made_from"
    /// <summary>
    ///   <para>dce:identifier : 2837^^xsd:string</para>
    ///   <para>dce:title : source for - things^^xsd:string</para>
    ///   <para>skos:example : Struthio camelus(species) is the source for ostrich-egg cups^^xsd:stringskos:example : Phormium tenax (species) is the source for k?kaku^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2837_source_for^^xsd:string</para>
    ///   <para>dcterms:description : genus/species [or its parts] - [is] source for - things.
    /// Example: Phormium tenax (species) is the source for k?kaku; Struthio camelus(species) is the source for ostrich-egg cups^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2837_source_for">gvp:aat2837_source_for</a>
    /// </summary>
    let aat2837_source_for = _prefixId.prefix "aat2837_source_for"
    /// <summary>
    ///   <para>skos:example : maple (wood) is derived from Acer (genus)^^xsd:stringskos:example : alpaca (wool) is derived from Vicugna pacos (species)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2841_derived-made_from^^xsd:string</para>
    ///   <para>dce:identifier : 2841^^xsd:string</para>
    ///   <para>dce:title : derived/made from - genus/species^^xsd:string</para>
    ///   <para>dcterms:description : material - [is] derived/made from - genus/species.
    /// Example: alpaca (wool) is derived from Vicugna pacos (species); maple (wood) is derived from Acer (genus)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2841_derived-made_from">gvp:aat2841_derived-made_from</a>
    /// </summary>
    let aat2841_derived_made_from = _prefixId.prefix "aat2841_derived-made_from"
    /// <summary>
    ///   <para>dce:identifier : 2842^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2842_source_for^^xsd:string</para>
    ///   <para>skos:example : Acer (genus) is the source for maple (wood)^^xsd:stringskos:example : Vicugna pacos (species) is the source for alpaca (wool)^^xsd:string</para>
    ///   <para>dcterms:description : genus/species - [is] source for - material.
    /// Example: Vicugna pacos (species) is the source for alpaca (wool); Acer (genus) is the source for maple (wood)^^xsd:string</para>
    ///   <para>dce:title : source for - material^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2842_source_for">gvp:aat2842_source_for</a>
    /// </summary>
    let aat2842_source_for = _prefixId.prefix "aat2842_source_for"
    /// <summary>
    ///   <para>skos:prefLabel : aat2845_used-located_in^^xsd:string</para>
    ///   <para>dce:identifier : 2845^^xsd:string</para>
    ///   <para>dcterms:description : genus/species - [is] used/located in -  locus/setting.
    /// Example: Elephantidae(family) are used/located in elephant houses; Vitaceae (family) is used/located in vineyards^^xsd:string</para>
    ///   <para>skos:example : Elephantidae(family) are used/located in elephant houses^^xsd:stringskos:example : Vitaceae (family) is used/located in vineyards^^xsd:string</para>
    ///   <para>dce:title : used/located in - locus/setting^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2845_used-located_in">gvp:aat2845_used-located_in</a>
    /// </summary>
    let aat2845_used_located_in = _prefixId.prefix "aat2845_used-located_in"
    /// <summary>
    ///   <para>skos:prefLabel : aat2846_locus-setting_for^^xsd:string</para>
    ///   <para>dce:identifier : 2846^^xsd:string</para>
    ///   <para>skos:example : vineyards are the locus/setting of Vitaceae (family)^^xsd:stringskos:example : elephant houses are the locus/setting for Elephantidae(family)^^xsd:string</para>
    ///   <para>dce:title : locus/setting for - genus/species^^xsd:string</para>
    ///   <para>dcterms:description : locus/setting - [is] locus/setting for - genus/species.
    /// Example: elephant houses are the locus/setting for Elephantidae(family); vineyards are the locus/setting of Vitaceae (family)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2846_locus-setting_for">gvp:aat2846_locus-setting_for</a>
    /// </summary>
    let aat2846_locus_setting_for = _prefixId.prefix "aat2846_locus-setting_for"
    /// <summary>
    ///   <para>skos:prefLabel : aat2848_involved_in^^xsd:string</para>
    ///   <para>dce:title : involved in - activity/event^^xsd:string</para>
    ///   <para>dcterms:description : genus/species - is involved in - activity/event.
    /// Example: bulls (animals) are involved in bullfighting; Equus caballus (species) is involved in polo(field sport)^^xsd:string</para>
    ///   <para>skos:example : Equus caballus (species) is involved in polo(field sport)^^xsd:stringskos:example : bulls (animals) are involved in bullfighting^^xsd:string</para>
    ///   <para>dce:identifier : 2848^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2848_involved_in">gvp:aat2848_involved_in</a>
    /// </summary>
    let aat2848_involved_in = _prefixId.prefix "aat2848_involved_in"
    /// <summary>
    ///   <para>skos:example : bullfighting involves bulls (animals)^^xsd:stringskos:example : polo (field sport) involves Equus caballus (species)^^xsd:string</para>
    ///   <para>dcterms:description : activity/event - involves - genus/species.
    /// Example: bullfighting involves bulls (animals); polo (field sport) involves Equus caballus (species)^^xsd:string</para>
    ///   <para>dce:identifier : 2849^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2849_involves^^xsd:string</para>
    ///   <para>dce:title : involves - genus/species^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2849_involves">gvp:aat2849_involves</a>
    /// </summary>
    let aat2849_involves = _prefixId.prefix "aat2849_involves"
    /// <summary>
    ///   <para>dce:title : involved with - things^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2852_involved_with^^xsd:string</para>
    ///   <para>dce:identifier : 2852^^xsd:string</para>
    ///   <para>skos:example : Rosa (genus) is involved with rose bowls^^xsd:stringskos:example : Camelus (genus) is involved with camel saddles^^xsd:string</para>
    ///   <para>dcterms:description : genus/species - [is] involved with - things/[equipment].
    /// Example: Rosa (genus) is involved with rose bowls; Camelus (genus) is involved with camel saddles^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2852_involved_with">gvp:aat2852_involved_with</a>
    /// </summary>
    let aat2852_involved_with = _prefixId.prefix "aat2852_involved_with"
    /// <summary>
    ///   <para>skos:example : camel saddles involve Camelus (genus)^^xsd:stringskos:example : rose bowls involve Rosa (genus)^^xsd:string</para>
    ///   <para>dcterms:description : things/[equipment] - involve - genus/species.
    /// Example: rose bowls involve Rosa (genus); camel saddles involve Camelus (genus)^^xsd:string</para>
    ///   <para>dce:identifier : 2853^^xsd:string</para>
    ///   <para>dce:title : involve - genus/species^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2853_involve^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2853_involve">gvp:aat2853_involve</a>
    /// </summary>
    let aat2853_involve = _prefixId.prefix "aat2853_involve"
    /// <summary>
    ///   <para>dcterms:description : language - [is] characteristic of - style/period/culture.
    /// Example: Afar (language) is characteristic of Afar (culture); Celtic (language) was characteristic of Celtic (culture)^^xsd:string</para>
    ///   <para>dce:title : characteristic of - style/period/culture^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2875_characteristic_of^^xsd:string</para>
    ///   <para>skos:example : Celtic (language) was characteristic of Celtic (culture)^^xsd:stringskos:example : Afar (language) is characteristic of Afar (culture)^^xsd:string</para>
    ///   <para>dce:identifier : 2875^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2875_characteristic_of">gvp:aat2875_characteristic_of</a>
    /// </summary>
    let aat2875_characteristic_of = _prefixId.prefix "aat2875_characteristic_of"
    /// <summary>
    ///   <para>skos:example : Celtic (culture) is characterized by Celtic (language)^^xsd:stringskos:example : Afar (culture) is characterized by Afar (language)^^xsd:string</para>
    ///   <para>dcterms:description : style/period/culture - [is] characterized by - language.
    /// Example: Afar (culture) is characterized by Afar (language); Celtic (culture) is characterized by Celtic (language)^^xsd:string</para>
    ///   <para>dce:title : characterized by - language^^xsd:string</para>
    ///   <para>dce:identifier : 2876^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2876_characterized_by^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2876_characterized_by">gvp:aat2876_characterized_by</a>
    /// </summary>
    let aat2876_characterized_by = _prefixId.prefix "aat2876_characterized_by"
    /// <summary>
    ///   <para>skos:example : Ancient Egyptian (language) preceded/is source for Egyptian, Coptic (language)^^xsd:stringskos:example : Ancient Greek (language) preceded/is source for Greek (modern language)^^xsd:string</para>
    ///   <para>dce:identifier : 2878^^xsd:string</para>
    ///   <para>dce:title : preceded/source for - language^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2878_preceded-source_for^^xsd:string</para>
    ///   <para>dcterms:description : language - preceded/[is] source for - language.
    /// Example: Ancient Greek (language) preceded/is source for Greek (modern language); Ancient Egyptian (language) preceded/is source for Egyptian, Coptic (language)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2878_preceded-source_for">gvp:aat2878_preceded-source_for</a>
    /// </summary>
    let aat2878_preceded_source_for = _prefixId.prefix "aat2878_preceded-source_for"

    /// <summary>
    ///   <para>skos:example : Greek (modern language) followed/developed from Ancient Greek (language)^^xsd:stringskos:example : Egyptian, Coptic (language) followed/developed from Ancient Egyptian (language)^^xsd:string</para>
    ///   <para>dce:title : followed/developed from - language^^xsd:string</para>
    ///   <para>dce:identifier : 2879^^xsd:string</para>
    ///   <para>dcterms:description : language - followed/developed from - language.
    /// Example: Greek (modern language) followed/developed from Ancient Greek (language); Egyptian, Coptic (language) followed/developed from Ancient Egyptian (language)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2879_followed-developed_from^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2879_followed-developed_from">gvp:aat2879_followed-developed_from</a>
    /// </summary>
    let aat2879_followed_developed_from =
        _prefixId.prefix "aat2879_followed-developed_from"

    /// <summary>
    ///   <para>skos:prefLabel : aat2881_reflected_in^^xsd:string</para>
    ///   <para>skos:example : Sanskrit is reflected in Vedas^^xsd:stringskos:example : Greek (language) is reflected in Greek alphabet^^xsd:string</para>
    ///   <para>dcterms:description : language - [is] reflected in - things.
    /// Example: Greek (language) is reflected in Greek alphabet; Sanskrit is reflected in Vedas^^xsd:string</para>
    ///   <para>dce:identifier : 2881^^xsd:string</para>
    ///   <para>dce:title : reflected in - things^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2881_reflected_in">gvp:aat2881_reflected_in</a>
    /// </summary>
    let aat2881_reflected_in = _prefixId.prefix "aat2881_reflected_in"
    /// <summary>
    ///   <para>skos:prefLabel : aat2882_reflect^^xsd:string</para>
    ///   <para>dce:identifier : 2882^^xsd:string</para>
    ///   <para>dcterms:description : things - reflect - language.
    /// Example: Greek alphabet reflects Greek (language); Vedas reflect Sanskrit^^xsd:string</para>
    ///   <para>dce:title : reflect - language^^xsd:string</para>
    ///   <para>skos:example : Vedas reflect Sanskrit^^xsd:stringskos:example : Greek alphabet reflects Greek (language)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2882_reflect">gvp:aat2882_reflect</a>
    /// </summary>
    let aat2882_reflect = _prefixId.prefix "aat2882_reflect"
    /// <summary>
    ///   <para>dce:identifier : 2884^^xsd:string</para>
    ///   <para>skos:example : insect damage is involved with infestation^^xsd:stringskos:example : climate is involved with climate change^^xsd:stringskos:example : Celtic crosses (design motif) are involved with Celtic culture^^xsd:string</para>
    ///   <para>dce:title : involved with - any^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2884_involved_with^^xsd:string</para>
    ///   <para>dcterms:description : attributes /associated concepts - [are] involved with - any.
    /// Example: climate is involved with climate change; insect damage is involved with infestation; Celtic crosses (design motif) are involved with Celtic culture^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2884_involved_with">gvp:aat2884_involved_with</a>
    /// </summary>
    let aat2884_involved_with = _prefixId.prefix "aat2884_involved_with"
    /// <summary>
    ///   <para>skos:example : Celtic culture involves Celtic crosses (design motif)^^xsd:stringskos:example : climate change involves climate^^xsd:stringskos:example : infestation involves insect damage^^xsd:string</para>
    ///   <para>dce:identifier : 2885^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2885_involves^^xsd:string</para>
    ///   <para>dcterms:description : any - involves - attributes /associated concepts.
    /// Example: climate change involves climate;  infestation involves insect damage; Celtic culture involves Celtic crosses (design motif)^^xsd:string</para>
    ///   <para>dce:title : involves - attributes /associated concepts^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2885_involves">gvp:aat2885_involves</a>
    /// </summary>
    let aat2885_involves = _prefixId.prefix "aat2885_involves"
    /// <summary>
    ///   <para>dce:identifier : 2891^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2891_exemplified_by^^xsd:string</para>
    ///   <para>dce:title : exemplified by - brand name^^xsd:string</para>
    ///   <para>skos:example : photothermographic transfer prints are exemplified by Pictrography (TM) prints^^xsd:string</para>
    ///   <para>dcterms:description : things - [are] exemplied by - brand name.
    /// Example: photothermographic transfer prints are exemplified by Pictrography (TM) prints^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2891_exemplified_by">gvp:aat2891_exemplified_by</a>
    /// </summary>
    let aat2891_exemplified_by = _prefixId.prefix "aat2891_exemplified_by"
    /// <summary>
    ///   <para>skos:prefLabel : aat2892_example_of^^xsd:string</para>
    ///   <para>skos:example : Pictrography (TM) prints are examples of photothermographic transfer prints^^xsd:string</para>
    ///   <para>dce:identifier : 2892^^xsd:string</para>
    ///   <para>dce:title : example of - things^^xsd:string</para>
    ///   <para>dcterms:description : brand name - [is] example of - things.
    /// Example: Pictrography (TM) prints are examples of photothermographic transfer prints^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2892_example_of">gvp:aat2892_example_of</a>
    /// </summary>
    let aat2892_example_of = _prefixId.prefix "aat2892_example_of"
    /// <summary>
    ///   <para>dce:identifier : 2894^^xsd:string</para>
    ///   <para>dcterms:description : activity/event/[process/function] - [is] exemplified by - brand name.
    /// Example: deacidification [process/function] is exemplified by Papersave Process (TM)^^xsd:string</para>
    ///   <para>skos:example : deacidification [process/function] is exemplified by Papersave Process (TM)^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2894_exemplified_by^^xsd:string</para>
    ///   <para>dce:title : exemplified by - brand name^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2894_exemplified_by">gvp:aat2894_exemplified_by</a>
    /// </summary>
    let aat2894_exemplified_by = _prefixId.prefix "aat2894_exemplified_by"
    /// <summary>
    ///   <para>dce:identifier : 2895^^xsd:string</para>
    ///   <para>dce:title : example of - activity/event^^xsd:string</para>
    ///   <para>skos:example : Papersave Process (TM) is example of deacidification [process/function]^^xsd:string</para>
    ///   <para>dcterms:description : brand name - [is] example of - activity/event/[process/function].
    /// Example: Papersave Process (TM) is example of deacidification [process/function]^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2895_example_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2895_example_of">gvp:aat2895_example_of</a>
    /// </summary>
    let aat2895_example_of = _prefixId.prefix "aat2895_example_of"

    /// <summary>
    ///   <para>dce:identifier : 2900^^xsd:string</para>
    ///   <para>skos:prefLabel : aat2900_miscellaneous_relationship^^xsd:string</para>
    ///   <para>dcterms:description : any - [has] miscellaneous relationship [to] - any.
    /// Example: Conditions and Effects has miscellaneous relationship with Processes and Techniques^^xsd:string</para>
    ///   <para>dce:title : miscellaneous relationship - any^^xsd:string</para>
    ///   <para>skos:example : Conditions and Effects has miscellaneous relationship with Processes and Techniques^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#aat2900_miscellaneous_relationship">gvp:aat2900_miscellaneous_relationship</a>
    /// </summary>
    let aat2900_miscellaneous_relationship =
        _prefixId.prefix "aat2900_miscellaneous_relationship"

    /// <summary>
    ///   <para>rdfs:comment : Type of a ULAN PersonConcept or GroupConcept. Domain is ULAN concept, range is AAT concept^^xsd:string</para>
    ///   <para>dcterms:description : Type of a ULAN PersonConcept or GroupConcept. Domain is ULAN concept, range is AAT concept^^xsd:string</para>
    ///   <para>rdfs:label : agentType^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#agentType">gvp:agentType</a>
    /// </summary>
    let agentType = _prefixId.prefix "agentType"
    /// <summary>
    ///   <para>skos:example : Non-preferred types of "Albrecht Duerer Workshop" (ULAN) include "printmakers" and painters" (AAT)^^xsd:string</para>
    ///   <para>rdfs:comment : A secondary type of a ULAN Person or Corporate body. Domain is ULAN concept, range is AAT concept^^xsd:string</para>
    ///   <para>dcterms:description : A secondary type of a ULAN Person or Corporate body. Domain is ULAN concept, range is AAT concept.
    /// Example: Non-preferred types of "Albrecht Duerer Workshop" (ULAN) include "printmakers" and painters" (AAT)^^xsd:string</para>
    ///   <para>rdfs:label : agentTypeNonPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#agentTypeNonPreferred">gvp:agentTypeNonPreferred</a>
    /// </summary>
    let agentTypeNonPreferred = _prefixId.prefix "agentTypeNonPreferred"
    /// <summary>
    ///   <para>skos:example : The preferred type of "Albrecht Duerer Workshop" (ULAN) is "workshop" (AAT)^^xsd:string</para>
    ///   <para>dcterms:description : The primary type of a ULAN Person or Corporate body. Domain is ULAN concept, range is AAT concept.
    /// Example: The preferred type of "Albrecht Duerer Workshop" (ULAN) is "workshop" (AAT)^^xsd:string</para>
    ///   <para>rdfs:label : agentTypePreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#agentTypePreferred">gvp:agentTypePreferred</a>
    /// </summary>
    let agentTypePreferred = _prefixId.prefix "agentTypePreferred"
    /// <summary>
    ///   <para>rdfs:comment : Biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The preferred biography fields are also directly available in the Person/Organization^^xsd:string</para>
    ///   <para>dcterms:description : Biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The preferred biography fields are also directly available in the Person/Organization^^xsd:string</para>
    ///   <para>rdfs:label : biography^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#biography">gvp:biography</a>
    /// </summary>
    let biography = _prefixId.prefix "biography"
    /// <summary>
    ///   <para>dcterms:description : Non-preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography^^xsd:string</para>
    ///   <para>rdfs:comment : Non-preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography^^xsd:string</para>
    ///   <para>rdfs:label : biographyNonPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#biographyNonPreferred">gvp:biographyNonPreferred</a>
    /// </summary>
    let biographyNonPreferred = _prefixId.prefix "biographyNonPreferred"
    /// <summary>
    ///   <para>dcterms:description : Preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The biography fields are also directly available in the Person/Organization^^xsd:string</para>
    ///   <para>rdfs:comment : Preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The biography fields are also directly available in the Person/Organization^^xsd:string</para>
    ///   <para>rdfs:label : biographyPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#biographyPreferred">gvp:biographyPreferred</a>
    /// </summary>
    let biographyPreferred = _prefixId.prefix "biographyPreferred"
    /// <summary>
    ///   <para>rdfs:comment : Parents of a subject. Each broader is also Preferred|NonPreferred and Partitive|Instantial|Generic^^xsd:string</para>
    ///   <para>dcterms:description : Parents of a subject. Each broader is also Preferred|NonPreferred and Partitive|Instantial|Generic^^xsd:string</para>
    ///   <para>rdfs:label : broader^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broader">gvp:broader</a>
    /// </summary>
    let broader = _prefixId.prefix "broader"
    /// <summary>
    ///   <para>dcterms:description : Appropriate ancestors. Meaningful closure of gvp:broader for query expansion. Use this, not skos:broaderTransitive.
    /// Example: Mt Athos has ancestor places (BTPE) World, Europe, Greece, Macedonia, Pangaíon Óros regional division;
    /// and place types (BTIE) inhabited place; and orthodox religious center, Christian religious center, religious center^^xsd:string</para>
    ///   <para>rdfs:comment : Appropriate ancestors. Meaningful closure of gvp:broader for query expansion. Use this, not skos:broaderTransitive^^xsd:string</para>
    ///   <para>skos:example : Mt Athos has ancestor places (BTPE) World, Europe, Greece, Macedonia, Pangaíon Óros regional division;
    /// and place types (BTIE) inhabited place; and orthodox religious center, Christian religious center, religious center^^xsd:string</para>
    ///   <para>rdfs:label : broaderExtended^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderExtended">gvp:broaderExtended</a>
    /// </summary>
    let broaderExtended = _prefixId.prefix "broaderExtended"
    /// <summary>
    ///   <para>dcterms:description : BTG (Genus/Species, "is a") relation. We also infer iso-thes:broaderGeneric, which goes only between Concepts.
    /// Example: calcite (AAT) BTG mineral (AAT)^^xsd:string</para>
    ///   <para>rdfs:comment : BTG (Genus/Species, "is a") relation. We also infer iso-thes:broaderGeneric, which goes only between Concepts^^xsd:string</para>
    ///   <para>skos:example : calcite (AAT) BTG mineral (AAT)^^xsd:string</para>
    ///   <para>rdfs:label : broaderGeneric^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderGeneric">gvp:broaderGeneric</a>
    /// </summary>
    let broaderGeneric = _prefixId.prefix "broaderGeneric"
    /// <summary>
    ///   <para>rdfs:label : broaderGenericExtended^^xsd:string</para>
    ///   <para>rdfs:comment : Ancestors (Generic). Meaningful closure of gvp:broaderGeneric. Infers iso:broaderGeneric for pairs of directly related skos:Concepts^^xsd:string</para>
    ///   <para>dcterms:description : Ancestors (Generic). Meaningful closure of gvp:broaderGeneric. Infers iso:broaderGeneric for pairs of directly related skos:Concepts.
    /// Example: &lt;anvils and anvil accessories&gt; BTG &lt;forging and metal-shaping tools&gt; BTG &lt;forging and metal-shaping equipment&gt;,
    /// so &lt;anvils and anvil accessories&gt; BTGE &lt;forging and metal-shaping equipment&gt;^^xsd:string</para>
    ///   <para>skos:example : &lt;anvils and anvil accessories&gt; BTG &lt;forging and metal-shaping tools&gt; BTG &lt;forging and metal-shaping equipment&gt;,
    /// so &lt;anvils and anvil accessories&gt; BTGE &lt;forging and metal-shaping equipment&gt;^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderGenericExtended">gvp:broaderGenericExtended</a>
    /// </summary>
    let broaderGenericExtended = _prefixId.prefix "broaderGenericExtended"
    /// <summary>
    ///   <para>skos:example : Rembrandt van Rijn BTI Persons/Artists (ULAN)^^xsd:string</para>
    ///   <para>dcterms:description : BTI (Kind/Instance, "example of") relation. We also infer iso-thes:broaderInstantial, which goes only between Concepts.
    /// Example: Rembrandt van Rijn BTI Persons/Artists (ULAN)^^xsd:string</para>
    ///   <para>rdfs:comment : BTI (Kind/Instance, "example of") relation. We also infer iso-thes:broaderInstantial, which goes only between Concepts^^xsd:string</para>
    ///   <para>rdfs:label : broaderInstantial^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderInstantial">gvp:broaderInstantial</a>
    /// </summary>
    let broaderInstantial = _prefixId.prefix "broaderInstantial"
    /// <summary>
    ///   <para>dcterms:description : Ancestors (Instantial). Meaningful closure of gvp:broaderInstantial. Infers iso:broaderInstantial for pairs of directly related skos:Concepts.^^xsd:string</para>
    ///   <para>skos:example : Mt Athos (TGN) BTI orthodox religious center (AAT) BTG Christian religious center (AAT),
    /// so Mt Athos (TGN) BTIE Christian religious center (AAT)^^xsd:string</para>
    ///   <para>rdfs:label : broaderInstantialExtended^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderInstantialExtended">gvp:broaderInstantialExtended</a>
    /// </summary>
    let broaderInstantialExtended = _prefixId.prefix "broaderInstantialExtended"
    /// <summary>
    ///   <para>rdfs:comment : Chain of gvp:broader from Concept to GuideTerms, without intervening Concept^^xsd:string</para>
    ///   <para>dcterms:description : Chain of gvp:broader from Concept to GuideTerms, without intervening Concept^^xsd:string</para>
    ///   <para>rdfs:label : broaderNonConcept^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderNonConcept">gvp:broaderNonConcept</a>
    /// </summary>
    let broaderNonConcept = _prefixId.prefix "broaderNonConcept"
    /// <summary>
    ///   <para>dcterms:description : Auxiliary parents of a subject. Very often there are several non-preferred parents (poly-hierarchy). Can use to mark such parents with [N] in displays .
    /// Example: Non-preferred: "baking dishes" BTG "dishes (vessels)" (AAT)^^xsd:string</para>
    ///   <para>rdfs:comment : Auxiliary parents of a subject. Very often there are several non-preferred parents (poly-hierarchy). Can use to mark such parents with [N] in displays ^^xsd:string</para>
    ///   <para>skos:example : Non-preferred: "baking dishes" BTG "dishes (vessels)" (AAT)^^xsd:string</para>
    ///   <para>rdfs:label : broaderNonPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderNonPreferred">gvp:broaderNonPreferred</a>
    /// </summary>
    let broaderNonPreferred = _prefixId.prefix "broaderNonPreferred"
    /// <summary>
    ///   <para>dcterms:description : BTP (Part/Whole, "part of") relation. We also infer iso-thes:broaderPartitive, which goes only between Concepts.
    /// Example: Tuscany (TGN) BTP Italy (TGN)^^xsd:string</para>
    ///   <para>skos:example : Tuscany (TGN) BTP Italy (TGN)^^xsd:string</para>
    ///   <para>rdfs:comment : BTP (Part/Whole, "part of") relation. We also infer iso-thes:broaderPartitive, which goes only between Concepts^^xsd:string</para>
    ///   <para>rdfs:label : broaderPartitive^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderPartitive">gvp:broaderPartitive</a>
    /// </summary>
    let broaderPartitive = _prefixId.prefix "broaderPartitive"
    /// <summary>
    ///   <para>rdfs:label : broaderPartitiveExtended^^xsd:string</para>
    ///   <para>rdfs:comment : Ancestors (Partitive). Meaningful closure of gvp:broaderPartitive. Infers iso:broaderPartitive for pairs of directly related skos:Concepts^^xsd:string</para>
    ///   <para>dcterms:description : Ancestors (Partitive). Meaningful closure of gvp:broaderPartitive. Infers iso:broaderPartitive for pairs of directly related skos:Concepts.
    /// Example: anvil components BTP &lt;anvils and anvil accessories&gt; BTG &lt;forging and metal-shaping tools&gt;,
    /// so anvil components BTPE &lt;forging and metal-shaping tools&gt;^^xsd:string</para>
    ///   <para>skos:example : anvil components BTP &lt;anvils and anvil accessories&gt; BTG &lt;forging and metal-shaping tools&gt;,
    /// so anvil components BTPE &lt;forging and metal-shaping tools&gt;^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderPartitiveExtended">gvp:broaderPartitiveExtended</a>
    /// </summary>
    let broaderPartitiveExtended = _prefixId.prefix "broaderPartitiveExtended"
    /// <summary>
    ///   <para>rdfs:comment : Main parent of a subject. Needed to display the hierarchy^^xsd:string</para>
    ///   <para>skos:example : Preferred: "baking dishes" (AAT) BTG "bakeware" (AAT); Sofia (TGN) BTP Bulgaria (TGN)^^xsd:string</para>
    ///   <para>rdfs:label : broaderPreferred^^xsd:string</para>
    ///   <para>dcterms:description : Main parent of a subject. Needed to display the hierarchy.
    /// Example: Preferred: "baking dishes" (AAT) BTG "bakeware" (AAT); Sofia (TGN) BTP Bulgaria (TGN)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderPreferred">gvp:broaderPreferred</a>
    /// </summary>
    let broaderPreferred = _prefixId.prefix "broaderPreferred"
    /// <summary>
    ///   <para>dcterms:description : Preferred Ancestors. Meaningful closure of gvp:broaderPreferred. Needed to display the hierarchy.
    /// Example: Mt Athos has preferred ancestor places (BTPE) World, Europe, Greece, Macedonia, Pangaíon Óros regional division;
    /// and prefererd place type (BTIE) inhabited place^^xsd:string</para>
    ///   <para>skos:example : Mt Athos has preferred ancestor places (BTPE) World, Europe, Greece, Macedonia, Pangaíon Óros regional division;
    /// and prefererd place type (BTIE) inhabited place^^xsd:string</para>
    ///   <para>rdfs:comment : Preferred Ancestors. Meaningful closure of gvp:broaderPreferred. Needed to display the hierarchy^^xsd:string</para>
    ///   <para>rdfs:label : broaderPreferredExtended^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#broaderPreferredExtended">gvp:broaderPreferredExtended</a>
    /// </summary>
    let broaderPreferredExtended = _prefixId.prefix "broaderPreferredExtended"
    /// <summary>
    ///   <para>rdfs:comment : Contributor for which the term is Alternate Preferred. Range is foaf:Agent^^xsd:string</para>
    ///   <para>dcterms:description : Contributor for which the term is Alternate Preferred. Range is foaf:Agent^^xsd:string</para>
    ///   <para>rdfs:label : contributorAlternatePreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#contributorAlternatePreferred">gvp:contributorAlternatePreferred</a>
    /// </summary>
    let contributorAlternatePreferred = _prefixId.prefix "contributorAlternatePreferred"
    /// <summary>
    ///   <para>skos:example : "Lycra" is non-preferred term for WHS^^xsd:string</para>
    ///   <para>rdfs:label : contributorNonPreferred^^xsd:string</para>
    ///   <para>rdfs:comment : Contributor for which the term is Non-preferred. Range is foaf:Agent^^xsd:string</para>
    ///   <para>dcterms:description : Contributor for which the term is Non-preferred. Range is foaf:Agent.
    /// Example: "Lycra" is non-preferred term for WHS^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#contributorNonPreferred">gvp:contributorNonPreferred</a>
    /// </summary>
    let contributorNonPreferred = _prefixId.prefix "contributorNonPreferred"
    /// <summary>
    ///   <para>dcterms:description : Contributor for which the term is Preferred. Range is foaf:Agent.
    /// Example: "organza" is preferred term for WHS^^xsd:string</para>
    ///   <para>rdfs:label : contributorPreferred^^xsd:string</para>
    ///   <para>skos:example : "organza" is preferred term for WHS^^xsd:string</para>
    ///   <para>rdfs:comment : Contributor for which the term is Preferred. Range is foaf:Agent^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#contributorPreferred">gvp:contributorPreferred</a>
    /// </summary>
    let contributorPreferred = _prefixId.prefix "contributorPreferred"
    /// <summary>
    ///   <para>rdfs:comment : Display order of subject or term amongst its siblings.
    /// If all are 1 then use alphabetical. Domain is gvp:Subject or skosxl:Label^^xsd:string</para>
    ///   <para>dcterms:description : Display order of subject or term amongst its siblings.
    /// If all are 1 then use alphabetical. Domain is gvp:Subject or skosxl:Label^^xsd:string</para>
    ///   <para>rdfs:label : displayOrder^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#displayOrder">gvp:displayOrder</a>
    /// </summary>
    let displayOrder = _prefixId.prefix "displayOrder"
    /// <summary>
    ///   <para>rdfs:comment : Estimated end date of term, relation, type assignment, event, biography^^xsd:string</para>
    ///   <para>dcterms:description : Estimated end date of term, relation, type assignment, event, biography^^xsd:string</para>
    ///   <para>rdfs:label : estEnd^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#estEnd">gvp:estEnd</a>
    /// </summary>
    let estEnd = _prefixId.prefix "estEnd"
    /// <summary>
    ///   <para>dcterms:description : Estimated start date of term, relation, type assignment, event, biography^^xsd:string</para>
    ///   <para>rdfs:comment : Estimated start date of term, relation, type assignment, event, biography^^xsd:string</para>
    ///   <para>rdfs:label : estStart^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#estStart">gvp:estStart</a>
    /// </summary>
    let estStart = _prefixId.prefix "estStart"
    /// <summary>
    ///   <para>dcterms:description : Non-preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event^^xsd:string</para>
    ///   <para>rdfs:comment : Non-preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event^^xsd:string</para>
    ///   <para>rdfs:label : eventNonPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#eventNonPreferred">gvp:eventNonPreferred</a>
    /// </summary>
    let eventNonPreferred = _prefixId.prefix "eventNonPreferred"
    /// <summary>
    ///   <para>dcterms:description : Preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event^^xsd:string</para>
    ///   <para>rdfs:comment : Preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event^^xsd:string</para>
    ///   <para>rdfs:label : eventPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#eventPreferred">gvp:eventPreferred</a>
    /// </summary>
    let eventPreferred = _prefixId.prefix "eventPreferred"
    /// <summary>
    ///   <para>dcterms:description : Historic Flag^^xsd:string</para>
    ///   <para>rdfs:label : historicFlag^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#historicFlag">gvp:historicFlag</a>
    /// </summary>
    let historicFlag = _prefixId.prefix "historicFlag"
    /// <summary>
    ///   <para>rdfs:comment : Non-preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept^^xsd:string</para>
    ///   <para>dcterms:description : Non-preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept^^xsd:string</para>
    ///   <para>rdfs:label : nationalityNonPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#nationalityNonPreferred">gvp:nationalityNonPreferred</a>
    /// </summary>
    let nationalityNonPreferred = _prefixId.prefix "nationalityNonPreferred"
    /// <summary>
    ///   <para>rdfs:comment : Preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept^^xsd:string</para>
    ///   <para>dcterms:description : Preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept^^xsd:string</para>
    ///   <para>rdfs:label : nationalityPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#nationalityPreferred">gvp:nationalityPreferred</a>
    /// </summary>
    let nationalityPreferred = _prefixId.prefix "nationalityPreferred"
    /// <summary>
    ///   <para>dcterms:description : Preferred labels of *all* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's full context.
    /// Display version of gvp:broaderPreferredExtended.
    /// Example for baking dishes [300226882]: bakeware, &lt;vessels for cooking food&gt;, &lt;containers for cooking food&gt;, &lt;culinary containers&gt;, &lt;containers by function or context&gt;, containers (receptacles), Containers (Hierarchy Name), Furnishings and Equipment (Hierarchy Name), Objects Facet^^xsd:string</para>
    ///   <para>skos:example : Example for baking dishes [300226882]: bakeware, &lt;vessels for cooking food&gt;, &lt;containers for cooking food&gt;, &lt;culinary containers&gt;, &lt;containers by function or context&gt;, containers (receptacles), Containers (Hierarchy Name), Furnishings and Equipment (Hierarchy Name), Objects Facet^^xsd:string</para>
    ///   <para>rdfs:label : parentString^^xsd:string</para>
    ///   <para>rdfs:comment : Preferred labels of *all* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's full context^^xsd:string</para>
    ///   <para>skos:note : Display version of gvp:broaderPreferredExtended^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#parentString">gvp:parentString</a>
    /// </summary>
    let parentString = _prefixId.prefix "parentString"
    /// <summary>
    ///   <para>rdfs:label : parentStringAbbrev^^xsd:string</para>
    ///   <para>dcterms:description : Preferred labels of *some* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's context.
    /// Shortened display version of gvp:broaderPreferredExtended.
    /// Example for baking dishes [300226882]: bakeware, &lt;vessels for cooking food&gt;, ... Furnishings and Equipment (Hierarchy Name)^^xsd:string</para>
    ///   <para>rdfs:comment : Preferred labels of *some* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's context^^xsd:string</para>
    ///   <para>skos:example : Example for baking dishes [300226882]: bakeware, &lt;vessels for cooking food&gt;, ... Furnishings and Equipment (Hierarchy Name)^^xsd:string</para>
    ///   <para>skos:note : Shortened display version of gvp:broaderPreferredExtended^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#parentStringAbbrev">gvp:parentStringAbbrev</a>
    /// </summary>
    let parentStringAbbrev = _prefixId.prefix "parentStringAbbrev"
    /// <summary>
    ///   <para>dcterms:description : Type for a TGN place. Domain is TGN concept (AdminPlaceConcept or PhysPlaceConcept), range is AAT Concept.
    /// Example: Machupicchu, Peru has preferred type "deserted settlement" (current) and non-preferred type "Inca center" (historic)^^xsd:string</para>
    ///   <para>skos:example : Machupicchu, Peru has preferred type "deserted settlement" (current) and non-preferred type "Inca center" (historic)^^xsd:string</para>
    ///   <para>rdfs:comment : Type for a TGN place. Domain is TGN concept (AdminPlaceConcept or PhysPlaceConcept), range is AAT Concept^^xsd:string</para>
    ///   <para>rdfs:label : placeType^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#placeType">gvp:placeType</a>
    /// </summary>
    let placeType = _prefixId.prefix "placeType"
    /// <summary>
    ///   <para>rdfs:comment : A secondary type for a TGN Place. Domain is TGN concept, range is AAT concept^^xsd:string</para>
    ///   <para>dcterms:description : A secondary type for a TGN Place. Domain is TGN concept, range is AAT concept.
    /// Example: A non-preferred type of Machupicchu, Peru is "Inca center" (historical)^^xsd:string</para>
    ///   <para>skos:example : A non-preferred type of Machupicchu, Peru is "Inca center" (historical)^^xsd:string</para>
    ///   <para>rdfs:label : placeTypeNonPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#placeTypeNonPreferred">gvp:placeTypeNonPreferred</a>
    /// </summary>
    let placeTypeNonPreferred = _prefixId.prefix "placeTypeNonPreferred"
    /// <summary>
    ///   <para>rdfs:comment : The primary type of a TGN Place. Domain is TGN concept, range is AAT concept^^xsd:string</para>
    ///   <para>skos:example : The preferred place type of Machupicchu, Peru is "deserted settlement" (current)^^xsd:string</para>
    ///   <para>dcterms:description : The primary type of a TGN Place. Domain is TGN concept, range is AAT concept.
    /// Example: The preferred place type of Machupicchu, Peru is "deserted settlement" (current)^^xsd:string</para>
    ///   <para>rdfs:label : placeTypePreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#placeTypePreferred">gvp:placeTypePreferred</a>
    /// </summary>
    let placeTypePreferred = _prefixId.prefix "placeTypePreferred"
    /// <summary>
    ///   <para>rdfs:comment : Term preferred by the Getty Vocabulary Program. The language is usually English. Applicable to AAT, ULAN, TGN. Used with skosxl:prefLabel^^xsd:string</para>
    ///   <para>dcterms:description : Term preferred by the Getty Vocabulary Program. The language is usually English. Applicable to AAT, ULAN, TGN. Used with skosxl:prefLabel^^xsd:string</para>
    ///   <para>rdfs:label : prefLabelGVP^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#prefLabelGVP">gvp:prefLabelGVP</a>
    /// </summary>
    let prefLabelGVP = _prefixId.prefix "prefLabelGVP"
    /// <summary>
    ///   <para>dcterms:description : Term preferred by Library of Congress, thus used for cataloging according to AACR2. Applicable to AAT and ULAN. Used with skosxl:prefLabel^^xsd:string</para>
    ///   <para>rdfs:comment : Term preferred by Library of Congress, thus used for cataloging according to AACR2. Applicable to AAT and ULAN. Used with skosxl:prefLabel^^xsd:string</para>
    ///   <para>rdfs:label : prefLabelLoC^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#prefLabelLoC">gvp:prefLabelLoC</a>
    /// </summary>
    let prefLabelLoC = _prefixId.prefix "prefLabelLoC"
    /// <summary>
    ///   <para>dcterms:description : Clarifies and disambiguates terms with the same spelling but different meaning.
    /// Appended in parentheses to gvp:term, forming skosxsl:literalForm.
    /// Every qualifier is in the same language as the term.
    /// Example: "Rhea (vessels)"=rhyta (a kind of drinking vessel) vs "Rhea (species)"=Boehmeria nivea (Chinese grass)^^xsd:string</para>
    ///   <para>skos:example : Rhea (vessels)=rhyta (a kind of drinking vessel) vs rhea (species)=Boehmeria nivea (Chinese grass)^^xsd:string</para>
    ///   <para>rdfs:comment : Clarifies and disambiguates terms with the same spelling but different meaning.
    /// Appended in parentheses to gvp:term, forming skosxsl:literalForm.
    /// Every qualifier is in the same language as the term^^xsd:string</para>
    ///   <para>rdfs:label : qualifier^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#qualifier">gvp:qualifier</a>
    /// </summary>
    let qualifier = _prefixId.prefix "qualifier"
    /// <summary>
    ///   <para>dcterms:description : Source for which the term is Alternate Preferred. Range is bibo:Document or bibo:DocumentPart.
    /// Example: "Kayseri" is alternate preferred in Webster's New Geographical Dictionary (1988)^^xsd:string</para>
    ///   <para>rdfs:comment : Source for which the term is Alternate Preferred. Range is bibo:Document or bibo:DocumentPart^^xsd:string</para>
    ///   <para>skos:example : "Kayseri" is alternate preferred in Webster's New Geographical Dictionary (1988)^^xsd:string</para>
    ///   <para>rdfs:label : sourceAlternatePreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#sourceAlternatePreferred">gvp:sourceAlternatePreferred</a>
    /// </summary>
    let sourceAlternatePreferred = _prefixId.prefix "sourceAlternatePreferred"
    /// <summary>
    ///   <para>dcterms:description : Source for which the term is Non-preferred. Range is bibo:Document or bibo:DocumentPart.
    /// Example: "Panderma" is non-preferred in Webster's New Geographical Dictionary (1988)^^xsd:string</para>
    ///   <para>skos:example : "Panderma" is non-preferred in Webster's New Geographical Dictionary (1988)^^xsd:string</para>
    ///   <para>rdfs:comment : Source for which the term is Non-preferred. Range is bibo:Document or bibo:DocumentPart^^xsd:string</para>
    ///   <para>rdfs:label : sourceNonPreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#sourceNonPreferred">gvp:sourceNonPreferred</a>
    /// </summary>
    let sourceNonPreferred = _prefixId.prefix "sourceNonPreferred"
    /// <summary>
    ///   <para>skos:example : "Isfahan" is preferred in Webster's New Geographical Dictionary (1988)^^xsd:string</para>
    ///   <para>dcterms:description : Source for which the term is Preferred. Range is bibo:Document or bibo:DocumentPart.
    /// Example: "Isfahan" is preferred in Webster's New Geographical Dictionary (1988)^^xsd:string</para>
    ///   <para>rdfs:comment : Source for which the term is Preferred. Range is bibo:Document or bibo:DocumentPart^^xsd:string</para>
    ///   <para>rdfs:label : sourcePreferred^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#sourcePreferred">gvp:sourcePreferred</a>
    /// </summary>
    let sourcePreferred = _prefixId.prefix "sourcePreferred"
    /// <summary>
    ///   <para>dcterms:description : Term (label), used as the basic (prefix) part of skosxsl:literalForm^^xsd:string</para>
    ///   <para>rdfs:comment : Term (label), used as the basic (prefix) part of skosxsl:literalForm^^xsd:string</para>
    ///   <para>rdfs:label : term^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#term">gvp:term</a>
    /// </summary>
    let term = _prefixId.prefix "term"
    /// <summary>
    ///   <para>dcterms:description : Term Display^^xsd:string</para>
    ///   <para>rdfs:label : termDisplay^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#termDisplay">gvp:termDisplay</a>
    /// </summary>
    let termDisplay = _prefixId.prefix "termDisplay"
    /// <summary>
    ///   <para>dcterms:description : Term Flag^^xsd:string</para>
    ///   <para>rdfs:label : termFlag^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#termFlag">gvp:termFlag</a>
    /// </summary>
    let termFlag = _prefixId.prefix "termFlag"
    /// <summary>
    ///   <para>dcterms:description : Term Kind^^xsd:string</para>
    ///   <para>rdfs:label : termKind^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#termKind">gvp:termKind</a>
    /// </summary>
    let termKind = _prefixId.prefix "termKind"
    /// <summary>
    ///   <para>dcterms:description : Part of Speech^^xsd:string</para>
    ///   <para>rdfs:label : termPOS^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#termPOS">gvp:termPOS</a>
    /// </summary>
    let termPOS = _prefixId.prefix "termPOS"
    /// <summary>
    ///   <para>dcterms:description : Term Type^^xsd:string</para>
    ///   <para>rdfs:label : termType^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#termType">gvp:termType</a>
    /// </summary>
    let termType = _prefixId.prefix "termType"
    /// <summary>
    ///   <para>dce:identifier : 3000^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3000_related_to^^xsd:string</para>
    ///   <para>dce:title : related to - any^^xsd:string</para>
    ///   <para>skos:example : Fountains Abbey is related to Studley Royal^^xsd:stringskos:example : Austria-Hungary is related to Magyarorszag^^xsd:string</para>
    ///   <para>dcterms:description : any - related to - any.
    /// Example: Fountains Abbey is related to Studley Royal; Austria-Hungary is related to Magyarorszag^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3000_related_to">gvp:tgn3000_related_to</a>
    /// </summary>
    let tgn3000_related_to = _prefixId.prefix "tgn3000_related_to"
    /// <summary>
    ///   <para>skos:prefLabel : tgn3001_distinguished_from^^xsd:string</para>
    ///   <para>dcterms:description : any - distinguished from - any.
    /// Example: The Ancient Mesopotamian Kingdom 'Assyria' is distinguished from the Roman Province of the same name^^xsd:string</para>
    ///   <para>dce:title : distinguished from - any^^xsd:string</para>
    ///   <para>skos:example : The Ancient Mesopotamian Kingdom 'Assyria' is distinguished from the Roman Province of the same name^^xsd:string</para>
    ///   <para>dce:identifier : 3001^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3001_distinguished_from">gvp:tgn3001_distinguished_from</a>
    /// </summary>
    let tgn3001_distinguished_from = _prefixId.prefix "tgn3001_distinguished_from"

    /// <summary>
    ///   <para>dce:title : possibly identified as - place^^xsd:string</para>
    ///   <para>skos:example : The lost settlement of Sharuhen is possibly identified as Tel el-Far'ah (As Suwayda', Syria) (deserted settlement)^^xsd:string</para>
    ///   <para>dcterms:description : place - possibly identified as - place.
    /// Example: The lost settlement of Sharuhen is possibly identified as Tel el-Far'ah (As Suwayda', Syria) (deserted settlement)^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3005_possibly_identified_as^^xsd:string</para>
    ///   <para>dce:identifier : 3005^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3005_possibly_identified_as">gvp:tgn3005_possibly_identified_as</a>
    /// </summary>
    let tgn3005_possibly_identified_as =
        _prefixId.prefix "tgn3005_possibly_identified_as"

    /// <summary>
    ///   <para>dcterms:description : place - formerly identified as - place; New.
    /// Example: The deserted settlement of Machupicchu was formerly identified as Tampu Tocco^^xsd:string</para>
    ///   <para>skos:example : The deserted settlement of Machupicchu was formerly identified as Tampu Tocco^^xsd:string</para>
    ///   <para>skos:scopeNote : New^^xsd:string</para>
    ///   <para>dce:identifier : 3006^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3006_formerly_identified_as^^xsd:string</para>
    ///   <para>dce:title : formerly identified as - place^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3006_formerly_identified_as">gvp:tgn3006_formerly_identified_as</a>
    /// </summary>
    let tgn3006_formerly_identified_as =
        _prefixId.prefix "tgn3006_formerly_identified_as"

    /// <summary>
    ///   <para>dce:identifier : 3101^^xsd:string</para>
    ///   <para>dcterms:description : any - near/adjacent to - any.
    /// Example: Saint Paul (Minnesota, USA), is linked to its 'Twin City' Minneapolis (Hennepin county, Minnesota, USA)^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3101_near-adjacent_to^^xsd:string</para>
    ///   <para>dce:title : near/adjacent to - any^^xsd:string</para>
    ///   <para>skos:example : Saint Paul (Minnesota, USA), is linked to its 'Twin City' Minneapolis (Hennepin county, Minnesota, USA)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3101_near-adjacent_to">gvp:tgn3101_near-adjacent_to</a>
    /// </summary>
    let tgn3101_near_adjacent_to = _prefixId.prefix "tgn3101_near-adjacent_to"
    /// <summary>
    ///   <para>skos:prefLabel : tgn3102_coextensive_with^^xsd:string</para>
    ///   <para>dce:title : coextensive with - place^^xsd:string</para>
    ///   <para>dcterms:description : place - coextensive with - place.
    /// Example: Kings county (New York, USA) is coextensive with Brooklyn (New York, USA)^^xsd:string</para>
    ///   <para>dce:identifier : 3102^^xsd:string</para>
    ///   <para>skos:example : Kings county (New York, USA) is coextensive with Brooklyn (New York, USA)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3102_coextensive_with">gvp:tgn3102_coextensive_with</a>
    /// </summary>
    let tgn3102_coextensive_with = _prefixId.prefix "tgn3102_coextensive_with"

    /// <summary>
    ///   <para>dce:identifier : 3110^^xsd:string</para>
    ///   <para>skos:example : Judaea (Israel) (historical region) meaning/usage overlaps with Holy Land (Asia) (historical region)^^xsd:string</para>
    ///   <para>dce:title : meaning/usage overlaps with - any^^xsd:string</para>
    ///   <para>dcterms:description : any - meaning/usage overlaps with - any.
    /// Example: Judaea (Israel) (historical region) meaning/usage overlaps with Holy Land (Asia) (historical region)^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3110_meaning-usage_overlaps_with^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3110_meaning-usage_overlaps_with">gvp:tgn3110_meaning-usage_overlaps_with</a>
    /// </summary>
    let tgn3110_meaning_usage_overlaps_with =
        _prefixId.prefix "tgn3110_meaning-usage_overlaps_with"

    /// <summary>
    ///   <para>skos:example : Thecapital of Maxima Caesariensis from 296 to 800 CE was London^^xsd:string</para>
    ///   <para>dce:title : capital of - nation^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3201_capital_of^^xsd:string</para>
    ///   <para>dcterms:description : city - capital of - nation.
    /// Example: Thecapital of Maxima Caesariensis from 296 to 800 CE was London^^xsd:string</para>
    ///   <para>dce:identifier : 3201^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3201_capital_of">gvp:tgn3201_capital_of</a>
    /// </summary>
    let tgn3201_capital_of = _prefixId.prefix "tgn3201_capital_of"
    /// <summary>
    ///   <para>skos:prefLabel : tgn3202_capital_is^^xsd:string</para>
    ///   <para>dce:identifier : 3202^^xsd:string</para>
    ///   <para>dce:title : capital is - city^^xsd:string</para>
    ///   <para>skos:example : London was the capital of Maxima Caesariensis from 296 to 800 CE^^xsd:string</para>
    ///   <para>dcterms:description : nation - capital is - city.
    /// Example: London was the capital of Maxima Caesariensis from 296 to 800 CE^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3202_capital_is">gvp:tgn3202_capital_is</a>
    /// </summary>
    let tgn3202_capital_is = _prefixId.prefix "tgn3202_capital_is"
    /// <summary>
    ///   <para>skos:example : Siena, Arezzo, Pisa, and Pistoia were Ghibeline allies during the 13th and 14th centuries.^^xsd:string</para>
    ///   <para>dcterms:description : nation - ally of - nation.
    /// Example: Siena, Arezzo, Pisa, and Pistoia were Ghibeline allies during the 13th and 14th centuries.^^xsd:string</para>
    ///   <para>dce:identifier : 3301^^xsd:string</para>
    ///   <para>dce:title : ally of - nation^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3301_ally_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3301_ally_of">gvp:tgn3301_ally_of</a>
    /// </summary>
    let tgn3301_ally_of = _prefixId.prefix "tgn3301_ally_of"
    /// <summary>
    ///   <para>dce:identifier : 3317^^xsd:string</para>
    ///   <para>dcterms:description : nation - member of - union.
    /// Example: Austria is a member of the European Union since 1915; Belgium is a member of the European Union since 1958^^xsd:string</para>
    ///   <para>dce:title : member of - union^^xsd:string</para>
    ///   <para>skos:example : Belgium is a member of the European Union since 1958^^xsd:stringskos:example : Austria is a member of the European Union since 1915^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3317_member_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3317_member_of">gvp:tgn3317_member_of</a>
    /// </summary>
    let tgn3317_member_of = _prefixId.prefix "tgn3317_member_of"
    /// <summary>
    ///   <para>skos:prefLabel : tgn3318_member_is^^xsd:string</para>
    ///   <para>skos:example : Austria is a member of the European Union since 1915^^xsd:stringskos:example : Belgium is a member of the European Union since 1958^^xsd:string</para>
    ///   <para>dce:title : member is - nation^^xsd:string</para>
    ///   <para>dce:identifier : 3318^^xsd:string</para>
    ///   <para>dcterms:description : union - member is - nation.
    /// Example: Austria is a member of the European Union since 1915; Belgium is a member of the European Union since 1958^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3318_member_is">gvp:tgn3318_member_is</a>
    /// </summary>
    let tgn3318_member_is = _prefixId.prefix "tgn3318_member_is"
    /// <summary>
    ///   <para>dce:title : moved from - place^^xsd:string</para>
    ///   <para>dcterms:description : place - moved from - place; Note: places that were physically moved from one location to another, often due to the threat or occurrence of natural disaster..
    /// Example: Troupville, Georgia, USA was moved to Valdosta (Lowndes county, Georgia, USA)^^xsd:string</para>
    ///   <para>dce:identifier : 3401^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3401_moved_from^^xsd:string</para>
    ///   <para>skos:example : Troupville, Georgia, USA was moved to Valdosta (Lowndes county, Georgia, USA)^^xsd:string</para>
    ///   <para>skos:scopeNote : Note: places that were physically moved from one location to another, often due to the threat or occurrence of natural disaster.^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3401_moved_from">gvp:tgn3401_moved_from</a>
    /// </summary>
    let tgn3401_moved_from = _prefixId.prefix "tgn3401_moved_from"
    /// <summary>
    ///   <para>skos:example : Valdosta (Lowndes county, Georgia, USA) moved from Troupville (Georgia, USA)^^xsd:string</para>
    ///   <para>dcterms:description : place - moved to - place.
    /// Example: Valdosta (Lowndes county, Georgia, USA) moved from Troupville (Georgia, USA)^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3402_moved_to^^xsd:string</para>
    ///   <para>dce:title : moved to - place^^xsd:string</para>
    ///   <para>dce:identifier : 3402^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3402_moved_to">gvp:tgn3402_moved_to</a>
    /// </summary>
    let tgn3402_moved_to = _prefixId.prefix "tgn3402_moved_to"
    /// <summary>
    ///   <para>skos:example : Iran (nation) is the successor of Persia^^xsd:string</para>
    ///   <para>dcterms:description : nation - successor of - nation.
    /// Example: Iran (nation) is the successor of Persia^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3411_successor_of^^xsd:string</para>
    ///   <para>dce:identifier : 3411^^xsd:string</para>
    ///   <para>dce:title : successor of - nation^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3411_successor_of">gvp:tgn3411_successor_of</a>
    /// </summary>
    let tgn3411_successor_of = _prefixId.prefix "tgn3411_successor_of"
    /// <summary>
    ///   <para>dce:title : predecessor of - nation^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3412_predecessor_of^^xsd:string</para>
    ///   <para>dcterms:description : nation - predecessor of - nation.
    /// Example: Persia is the predecessor of Iran (nation)^^xsd:string</para>
    ///   <para>skos:example : Persia is the predecessor of Iran (nation)^^xsd:string</para>
    ///   <para>dce:identifier : 3412^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3412_predecessor_of">gvp:tgn3412_predecessor_of</a>
    /// </summary>
    let tgn3412_predecessor_of = _prefixId.prefix "tgn3412_predecessor_of"
    /// <summary>
    ///   <para>dce:title : historical connection - any^^xsd:string</para>
    ///   <para>dcterms:description : any - historical connection - any.
    /// Example: Guyenne, France (historical region) has a historical connection to Gascogne (France) (historical region)^^xsd:string</para>
    ///   <para>dce:identifier : 3510^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3510_historical_connection^^xsd:string</para>
    ///   <para>skos:example : Guyenne, France (historical region) has a historical connection to Gascogne (France) (historical region)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3510_historical_connection">gvp:tgn3510_historical_connection</a>
    /// </summary>
    let tgn3510_historical_connection = _prefixId.prefix "tgn3510_historical_connection"

    /// <summary>
    ///   <para>skos:example : Luni (La Spezia province, Liguria, Italy) is the admisistrative dependent of Ortonovo (Massa-Carrara province, Tuscany, Italy)^^xsd:string</para>
    ///   <para>skos:prefLabel : tgn3611_administrative_dependent_of^^xsd:string</para>
    ///   <para>dcterms:description : place - administrative dependent of - place; New.
    /// Example: Luni (La Spezia province, Liguria, Italy) is the admisistrative dependent of Ortonovo (Massa-Carrara province, Tuscany, Italy)^^xsd:string</para>
    ///   <para>dce:identifier : 3611^^xsd:string</para>
    ///   <para>skos:scopeNote : New^^xsd:string</para>
    ///   <para>dce:title : administrative dependent of - place^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3611_administrative_dependent_of">gvp:tgn3611_administrative_dependent_of</a>
    /// </summary>
    let tgn3611_administrative_dependent_of =
        _prefixId.prefix "tgn3611_administrative_dependent_of"

    /// <summary>
    ///   <para>skos:prefLabel : tgn3612_administrative_entity_for^^xsd:string</para>
    ///   <para>dce:title : administrative entity for - place^^xsd:string</para>
    ///   <para>skos:example : Ortonovo (Massa-Carra province, Tuscany, Italy) is the administrative entity for Luni (La Spezia province, Liguria, Italy)^^xsd:string</para>
    ///   <para>dce:identifier : 3612^^xsd:string</para>
    ///   <para>dcterms:description : place - administrative entity for - place.
    /// Example: Ortonovo (Massa-Carra province, Tuscany, Italy) is the administrative entity for Luni (La Spezia province, Liguria, Italy)^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#tgn3612_administrative_entity_for">gvp:tgn3612_administrative_entity_for</a>
    /// </summary>
    let tgn3612_administrative_entity_for =
        _prefixId.prefix "tgn3612_administrative_entity_for"

    /// <summary>
    ///   <para>skos:example : Herman Miller, Inc. is related to Irving Harper^^xsd:stringskos:example : Frank Lloyd Wright is related to Francis Conroy Sullivan^^xsd:stringskos:example : National Endowment for the Humanities is related to Connecticut Humanities Council^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1000_related_to^^xsd:string</para>
    ///   <para>dce:identifier : 1000^^xsd:string</para>
    ///   <para>dcterms:description : any - related to - any.
    /// Example: Frank Lloyd Wright is related to Francis Conroy Sullivan; Herman Miller, Inc. is related to Irving Harper; National Endowment for the Humanities is related to Connecticut Humanities Council^^xsd:string</para>
    ///   <para>dce:title : related to - any^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1000_related_to">gvp:ulan1000_related_to</a>
    /// </summary>
    let ulan1000_related_to = _prefixId.prefix "ulan1000_related_to"
    /// <summary>
    ///   <para>skos:example : United Nations is associated with World Bank^^xsd:stringskos:example : Richard Meier is associated with Renny B.Saltzman^^xsd:string</para>
    ///   <para>dce:title : associated with - any^^xsd:string</para>
    ///   <para>dce:identifier : 1003^^xsd:string</para>
    ///   <para>dcterms:description : any - associated with - any.
    /// Example: Richard Meier is associated with Renny B.Saltzman; United Nations is associated with World Bank^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1003_associated_with^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1003_associated_with">gvp:ulan1003_associated_with</a>
    /// </summary>
    let ulan1003_associated_with = _prefixId.prefix "ulan1003_associated_with"

    /// <summary>
    ///   <para>dcterms:description : any - possibly identified with - any.
    /// Example: Master of the Saint John Altarpiece is possibly identified with Hughe Jacobsz; Bauart is possibly identified with Gruppe BAUart^^xsd:string</para>
    ///   <para>dce:identifier : 1005^^xsd:string</para>
    ///   <para>skos:example : Bauart is possibly identified with Gruppe BAUart^^xsd:stringskos:example : Master of the Saint John Altarpiece is possibly identified with Hughe Jacobsz^^xsd:string</para>
    ///   <para>dce:title : possibly identified with - any^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1005_possibly_identified_with^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1005_possibly_identified_with">gvp:ulan1005_possibly_identified_with</a>
    /// </summary>
    let ulan1005_possibly_identified_with =
        _prefixId.prefix "ulan1005_possibly_identified_with"

    /// <summary>
    ///   <para>dce:identifier : 1006^^xsd:string</para>
    ///   <para>dcterms:description : any - formerly identified with - any.
    /// Example: Tommaso is formerly identified with Tommaso di Stefano Lunetti; GreenWorks is formerly identified with Mike Faha &amp; Associates^^xsd:string</para>
    ///   <para>dce:title : formerly identified with - any^^xsd:string</para>
    ///   <para>skos:example : Tommaso is formerly identified with Tommaso di Stefano Lunetti^^xsd:stringskos:example : GreenWorks is formerly identified with Mike Faha &amp; Associates^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1006_formerly_identified_with^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1006_formerly_identified_with">gvp:ulan1006_formerly_identified_with</a>
    /// </summary>
    let ulan1006_formerly_identified_with =
        _prefixId.prefix "ulan1006_formerly_identified_with"

    /// <summary>
    ///   <para>dce:identifier : 1007^^xsd:string</para>
    ///   <para>dce:title : distinguished from - any^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1007_distinguished_from^^xsd:string</para>
    ///   <para>skos:example : The Noguchi Museum is distinguished form Isamu Noguchi Garden Museum Japan^^xsd:stringskos:example : Laura Theresa Alma-Tadema is distinguished from Lawrence Alma-Tadema^^xsd:string</para>
    ///   <para>dcterms:description : any - distinguished from - any.
    /// Example: Laura Theresa Alma-Tadema is distinguished from Lawrence Alma-Tadema; The Noguchi Museum is distinguished form Isamu Noguchi Garden Museum Japan^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1007_distinguished_from">gvp:ulan1007_distinguished_from</a>
    /// </summary>
    let ulan1007_distinguished_from = _prefixId.prefix "ulan1007_distinguished_from"

    /// <summary>
    ///   <para>dcterms:description : any - meaning /usage overlaps with - any.
    /// Example: The meaning or usage of unknown Zimbabwean overlaps with unknown Rodesian^^xsd:string</para>
    ///   <para>dce:title : meaning /usage overlaps with - any^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1008_meaning_-usage_overlaps_with^^xsd:string</para>
    ///   <para>dce:identifier : 1008^^xsd:string</para>
    ///   <para>skos:example : The meaning or usage of unknown Zimbabwean overlaps with unknown Rodesian^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1008_meaning_-usage_overlaps_with">gvp:ulan1008_meaning_-usage_overlaps_with</a>
    /// </summary>
    let ulan1008_meaning__usage_overlaps_with =
        _prefixId.prefix "ulan1008_meaning_-usage_overlaps_with"

    /// <summary>
    ///   <para>dcterms:description : person - teacher of - person.
    /// Example: Rivalz, Antoine was the teacher of Pierre Subleyras^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1101_teacher_of^^xsd:string</para>
    ///   <para>dce:identifier : 1101^^xsd:string</para>
    ///   <para>skos:example : Rivalz, Antoine was the teacher of Pierre Subleyras^^xsd:string</para>
    ///   <para>dce:title : teacher of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1101_teacher_of">gvp:ulan1101_teacher_of</a>
    /// </summary>
    let ulan1101_teacher_of = _prefixId.prefix "ulan1101_teacher_of"
    /// <summary>
    ///   <para>dce:title : student of - person^^xsd:string</para>
    ///   <para>skos:example : Pierre Subleyras was the student of Rivalz, Antoine^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1102_student_of^^xsd:string</para>
    ///   <para>dcterms:description : person - student of - person.
    /// Example: Pierre Subleyras was the student of Rivalz, Antoine^^xsd:string</para>
    ///   <para>dce:identifier : 1102^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1102_student_of">gvp:ulan1102_student_of</a>
    /// </summary>
    let ulan1102_student_of = _prefixId.prefix "ulan1102_student_of"
    /// <summary>
    ///   <para>dce:identifier : 1105^^xsd:string</para>
    ///   <para>skos:example : Nicolas Hawksmoor was the apprentice of Christopher Wren^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1105_apprentice_of^^xsd:string</para>
    ///   <para>dcterms:description : person - apprentice of - person.
    /// Example: Nicolas Hawksmoor was the apprentice of Christopher Wren^^xsd:string</para>
    ///   <para>dce:title : apprentice of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1105_apprentice_of">gvp:ulan1105_apprentice_of</a>
    /// </summary>
    let ulan1105_apprentice_of = _prefixId.prefix "ulan1105_apprentice_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1106_apprentice_was^^xsd:string</para>
    ///   <para>dce:title : apprentice was - person^^xsd:string</para>
    ///   <para>dcterms:description : person - apprentice was - person.
    /// Example: Nicolas Hawksmoor was the apprentice of Christopher Wren^^xsd:string</para>
    ///   <para>dce:identifier : 1106^^xsd:string</para>
    ///   <para>skos:example : Nicolas Hawksmoor was the apprentice of Christopher Wren^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1106_apprentice_was">gvp:ulan1106_apprentice_was</a>
    /// </summary>
    let ulan1106_apprentice_was = _prefixId.prefix "ulan1106_apprentice_was"
    /// <summary>
    ///   <para>dcterms:description : person - influenced - person.
    /// Example: Rembrandt van Rijn influenced Salomon Koninck^^xsd:string</para>
    ///   <para>skos:example : Rembrandt van Rijn influenced Salomon Koninck^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1107_influenced^^xsd:string</para>
    ///   <para>dce:title : influenced - person^^xsd:string</para>
    ///   <para>dce:identifier : 1107^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1107_influenced">gvp:ulan1107_influenced</a>
    /// </summary>
    let ulan1107_influenced = _prefixId.prefix "ulan1107_influenced"
    /// <summary>
    ///   <para>dcterms:description : person - influenced by - person.
    /// Example: Salomon Koninck was influenced by Rembrandt van Rijn^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1108_influenced_by^^xsd:string</para>
    ///   <para>dce:identifier : 1108^^xsd:string</para>
    ///   <para>skos:example : Salomon Koninck was influenced by Rembrandt van Rijn^^xsd:string</para>
    ///   <para>dce:title : influenced by - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1108_influenced_by">gvp:ulan1108_influenced_by</a>
    /// </summary>
    let ulan1108_influenced_by = _prefixId.prefix "ulan1108_influenced_by"
    /// <summary>
    ///   <para>dcterms:description : person - master of - person.
    /// Example: Peter Paul Rubens - master of Jan Thomas^^xsd:string</para>
    ///   <para>dce:identifier : 1111^^xsd:string</para>
    ///   <para>dce:title : master of - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1111_master_of^^xsd:string</para>
    ///   <para>skos:example : Peter Paul Rubens - master of Jan Thomas^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1111_master_of">gvp:ulan1111_master_of</a>
    /// </summary>
    let ulan1111_master_of = _prefixId.prefix "ulan1111_master_of"
    /// <summary>
    ///   <para>dce:title : master was - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1112_master_was^^xsd:string</para>
    ///   <para>skos:example : Peter Paul Rubens - master of Jan Thomas^^xsd:string</para>
    ///   <para>dcterms:description : person - master was - person.
    /// Example: Peter Paul Rubens - master of Jan Thomas^^xsd:string</para>
    ///   <para>dce:identifier : 1112^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1112_master_was">gvp:ulan1112_master_was</a>
    /// </summary>
    let ulan1112_master_was = _prefixId.prefix "ulan1112_master_was"
    /// <summary>
    ///   <para>skos:example : John Sloan was a fellow student of Thomas Hart Benton^^xsd:stringskos:example : Alexander Calder was a fellow student of John Sloan^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1113_fellow_student_of^^xsd:string</para>
    ///   <para>dcterms:description : person - fellow student of - person.
    /// Example: Alexander Calder was a fellow student of John Sloan; John Sloan was a fellow student of Thomas Hart Benton^^xsd:string</para>
    ///   <para>dce:identifier : 1113^^xsd:string</para>
    ///   <para>dce:title : fellow student of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1113_fellow_student_of">gvp:ulan1113_fellow_student_of</a>
    /// </summary>
    let ulan1113_fellow_student_of = _prefixId.prefix "ulan1113_fellow_student_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1201_patron_of^^xsd:string</para>
    ///   <para>dce:identifier : 1201^^xsd:string</para>
    ///   <para>dce:title : patron of - person/firm/family^^xsd:string</para>
    ///   <para>skos:example : Cosimo I, Grand-Duke of Tuscany was the patron of Donatello^^xsd:string</para>
    ///   <para>dcterms:description : person - patron of - person/firm/family.
    /// Example: Cosimo I, Grand-Duke of Tuscany was the patron of Donatello^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1201_patron_of">gvp:ulan1201_patron_of</a>
    /// </summary>
    let ulan1201_patron_of = _prefixId.prefix "ulan1201_patron_of"
    /// <summary>
    ///   <para>dce:identifier : 1202^^xsd:string</para>
    ///   <para>skos:example : The patron of Donatello was Cosimo I, Grand-Duke of Tuscany^^xsd:string</para>
    ///   <para>dcterms:description : person/firm/family - patron was - person.
    /// Example: The patron of Donatello was Cosimo I, Grand-Duke of Tuscany^^xsd:string</para>
    ///   <para>dce:title : patron was - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1202_patron_was^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1202_patron_was">gvp:ulan1202_patron_was</a>
    /// </summary>
    let ulan1202_patron_was = _prefixId.prefix "ulan1202_patron_was"
    /// <summary>
    ///   <para>dce:identifier : 1203^^xsd:string</para>
    ///   <para>skos:example : Andrew W. Mellon was a donor of National Gallery of Art^^xsd:string</para>
    ///   <para>dcterms:description : person/firm/family - donor of - person/firm/family.
    /// Example: Andrew W. Mellon was a donor of National Gallery of Art^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1203_donor_of^^xsd:string</para>
    ///   <para>dce:title : donor of - person/firm/family^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1203_donor_of">gvp:ulan1203_donor_of</a>
    /// </summary>
    let ulan1203_donor_of = _prefixId.prefix "ulan1203_donor_of"
    /// <summary>
    ///   <para>dce:identifier : 1204^^xsd:string</para>
    ///   <para>dce:title : donor was - person/firm/family^^xsd:string</para>
    ///   <para>skos:example : Donor to the National Gallery of Art was Andrew W. Mellon^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1204_donor_was^^xsd:string</para>
    ///   <para>dcterms:description : person/firm/family - donor was - person/firm/family.
    /// Example: Donor to the National Gallery of Art was Andrew W. Mellon^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1204_donor_was">gvp:ulan1204_donor_was</a>
    /// </summary>
    let ulan1204_donor_was = _prefixId.prefix "ulan1204_donor_was"
    /// <summary>
    ///   <para>dce:identifier : 1205^^xsd:string</para>
    ///   <para>dcterms:description : person/firm/family - client of - person/firm/family.
    /// Example: The Chicago Herald was the client of Burnham and Root^^xsd:string</para>
    ///   <para>dce:title : client of - person/firm/family^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1205_client_of^^xsd:string</para>
    ///   <para>skos:example : The Chicago Herald was the client of Burnham and Root^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1205_client_of">gvp:ulan1205_client_of</a>
    /// </summary>
    let ulan1205_client_of = _prefixId.prefix "ulan1205_client_of"
    /// <summary>
    ///   <para>dce:title : client was - person/firm/family^^xsd:string</para>
    ///   <para>skos:example : Burnham and Root's client was the Chicago Herald^^xsd:string</para>
    ///   <para>dcterms:description : person/firm/family - client was - person/firm/family.
    /// Example: Burnham and Root's client was the Chicago Herald^^xsd:string</para>
    ///   <para>dce:identifier : 1206^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1206_client_was^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1206_client_was">gvp:ulan1206_client_was</a>
    /// </summary>
    let ulan1206_client_was = _prefixId.prefix "ulan1206_client_was"
    /// <summary>
    ///   <para>dce:identifier : 1211^^xsd:string</para>
    ///   <para>dcterms:description : person - artist to - person.
    /// Example: Artist to Louis XIV, King of France was Charles-Pierre Coustou^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1211_artist_to^^xsd:string</para>
    ///   <para>skos:example : Artist to Louis XIV, King of France was Charles-Pierre Coustou^^xsd:string</para>
    ///   <para>dce:title : artist to - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1211_artist_to">gvp:ulan1211_artist_to</a>
    /// </summary>
    let ulan1211_artist_to = _prefixId.prefix "ulan1211_artist_to"
    /// <summary>
    ///   <para>dce:identifier : 1212^^xsd:string</para>
    ///   <para>dce:title : artist was - person^^xsd:string</para>
    ///   <para>dcterms:description : person - artist was - person.
    /// Example: Charles-Pierre Coustou was artist to Louis XIV, King of France^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1212_artist_was^^xsd:string</para>
    ///   <para>skos:example : Charles-Pierre Coustou was artist to Louis XIV, King of France^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1212_artist_was">gvp:ulan1212_artist_was</a>
    /// </summary>
    let ulan1212_artist_was = _prefixId.prefix "ulan1212_artist_was"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1213_court_artist_to^^xsd:string</para>
    ///   <para>dce:title : court artist to - person^^xsd:string</para>
    ///   <para>dce:identifier : 1213^^xsd:string</para>
    ///   <para>skos:example : Court artist to Gonzaga Vincenzo I, Duke of Mantua was Peter Paul Rubens^^xsd:stringskos:example : court artist to Charles IV, King of Spain was Francisco de Goya^^xsd:string</para>
    ///   <para>dcterms:description : person - court artist to - person.
    /// Example: Court artist to Gonzaga Vincenzo I, Duke of Mantua was Peter Paul Rubens; court artist to Charles IV, King of Spain was Francisco de Goya^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1213_court_artist_to">gvp:ulan1213_court_artist_to</a>
    /// </summary>
    let ulan1213_court_artist_to = _prefixId.prefix "ulan1213_court_artist_to"
    /// <summary>
    ///   <para>dcterms:description : person - court artist was - person.
    /// Example: Peter Paul Rubens was court artist to Gonzaga Vincenzo I, Duke of Mantua; Francisco de Goya was court artist to Charles IV, King of Spain^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1214_court_artist_was^^xsd:string</para>
    ///   <para>skos:example : Francisco de Goya was court artist to Charles IV, King of Spain^^xsd:stringskos:example : Peter Paul Rubens was court artist to Gonzaga Vincenzo I, Duke of Mantua^^xsd:string</para>
    ///   <para>dce:identifier : 1214^^xsd:string</para>
    ///   <para>dce:title : court artist was - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1214_court_artist_was">gvp:ulan1214_court_artist_was</a>
    /// </summary>
    let ulan1214_court_artist_was = _prefixId.prefix "ulan1214_court_artist_was"
    /// <summary>
    ///   <para>dcterms:description : person/firm - employee of - person.
    /// Example: Employee of Christopher Wren was Jean Tijou^^xsd:string</para>
    ///   <para>skos:example : Employee of Christopher Wren was Jean Tijou^^xsd:string</para>
    ///   <para>dce:identifier : 1217^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1217_employee_of^^xsd:string</para>
    ///   <para>dce:title : employee of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1217_employee_of">gvp:ulan1217_employee_of</a>
    /// </summary>
    let ulan1217_employee_of = _prefixId.prefix "ulan1217_employee_of"
    /// <summary>
    ///   <para>dce:identifier : 1218^^xsd:string</para>
    ///   <para>dce:title : employee was - person/firm^^xsd:string</para>
    ///   <para>skos:example : Jean Tijou was an employee of Christopher Wren^^xsd:string</para>
    ///   <para>dcterms:description : person - employee was - person/firm.
    /// Example: Jean Tijou was an employee of Christopher Wren^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1218_employee_was^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1218_employee_was">gvp:ulan1218_employee_was</a>
    /// </summary>
    let ulan1218_employee_was = _prefixId.prefix "ulan1218_employee_was"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1221_appointed_by^^xsd:string</para>
    ///   <para>dce:title : appointed by - person^^xsd:string</para>
    ///   <para>skos:example : Pope Urban VIII appointed Virginio Cesarini^^xsd:string</para>
    ///   <para>dce:identifier : 1221^^xsd:string</para>
    ///   <para>dcterms:description : person - appointed by - person.
    /// Example: Pope Urban VIII appointed Virginio Cesarini^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1221_appointed_by">gvp:ulan1221_appointed_by</a>
    /// </summary>
    let ulan1221_appointed_by = _prefixId.prefix "ulan1221_appointed_by"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1222_appointee_of^^xsd:string</para>
    ///   <para>dcterms:description : person - appointee of - person.
    /// Example: Virginio Cesarini was appointee by Pope Urban VIII^^xsd:string</para>
    ///   <para>skos:example : Virginio Cesarini was appointee by Pope Urban VIII^^xsd:string</para>
    ///   <para>dce:title : appointee of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1222^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1222_appointee_of">gvp:ulan1222_appointee_of</a>
    /// </summary>
    let ulan1222_appointee_of = _prefixId.prefix "ulan1222_appointee_of"
    /// <summary>
    ///   <para>dce:title : crowned by - person^^xsd:string</para>
    ///   <para>skos:example : Pope Leo III crowned Emperor Charlemagne^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1223_crowned_by^^xsd:string</para>
    ///   <para>dcterms:description : person - crowned by - person.
    /// Example: Pope Leo III crowned Emperor Charlemagne^^xsd:string</para>
    ///   <para>dce:identifier : 1223^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1223_crowned_by">gvp:ulan1223_crowned_by</a>
    /// </summary>
    let ulan1223_crowned_by = _prefixId.prefix "ulan1223_crowned_by"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1224_crowned^^xsd:string</para>
    ///   <para>dce:identifier : 1224^^xsd:string</para>
    ///   <para>dce:title : crowned - person^^xsd:string</para>
    ///   <para>skos:example : Emperor Charlemagne was crowned by Pope Leo III^^xsd:string</para>
    ///   <para>dcterms:description : person - crowned - person.
    /// Example: Emperor Charlemagne was crowned by Pope Leo III^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1224_crowned">gvp:ulan1224_crowned</a>
    /// </summary>
    let ulan1224_crowned = _prefixId.prefix "ulan1224_crowned"
    /// <summary>
    ///   <para>skos:example : Titian was a colleague of Maria Giovanni Verdizotti^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1301_colleague_of^^xsd:string</para>
    ///   <para>dcterms:description : person - colleague of - person.
    /// Example: Titian was a colleague of Maria Giovanni Verdizotti^^xsd:string</para>
    ///   <para>dce:identifier : 1301^^xsd:string</para>
    ///   <para>dce:title : colleague of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1301_colleague_of">gvp:ulan1301_colleague_of</a>
    /// </summary>
    let ulan1301_colleague_of = _prefixId.prefix "ulan1301_colleague_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1302_associate_of^^xsd:string</para>
    ///   <para>dce:title : associate of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - associate of - person.
    /// Example: Frank Lloyd Wright was an associate of Giannini and Hilgart^^xsd:string</para>
    ///   <para>dce:identifier : 1302^^xsd:string</para>
    ///   <para>skos:example : Frank Lloyd Wright was an associate of Giannini and Hilgart^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1302_associate_of">gvp:ulan1302_associate_of</a>
    /// </summary>
    let ulan1302_associate_of = _prefixId.prefix "ulan1302_associate_of"
    /// <summary>
    ///   <para>dce:title : collaborated with - person^^xsd:string</para>
    ///   <para>dcterms:description : person - collaborated with - person.
    /// Example: Pablo Picasso collaborated with Georges Braque^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1303_collaborated_with^^xsd:string</para>
    ///   <para>skos:example : Pablo Picasso collaborated with Georges Braque^^xsd:string</para>
    ///   <para>dce:identifier : 1303^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1303_collaborated_with">gvp:ulan1303_collaborated_with</a>
    /// </summary>
    let ulan1303_collaborated_with = _prefixId.prefix "ulan1303_collaborated_with"
    /// <summary>
    ///   <para>dce:identifier : 1305^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1305_worked_with^^xsd:string</para>
    ///   <para>dcterms:description : person - worked with - person.
    /// Example: William Cleare worked with Christopher Wren; Frank Lloyd Wright work with Aaron G. Green^^xsd:string</para>
    ///   <para>skos:example : Frank Lloyd Wright work with Aaron G. Green^^xsd:stringskos:example : William Cleare worked with Christopher Wren^^xsd:string</para>
    ///   <para>dce:title : worked with - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1305_worked_with">gvp:ulan1305_worked_with</a>
    /// </summary>
    let ulan1305_worked_with = _prefixId.prefix "ulan1305_worked_with"
    /// <summary>
    ///   <para>dcterms:description : person - performs with - person.
    /// Example: Harry Kipper performs with Harry Kipper (as part of 'The Kipper Kids')^^xsd:string</para>
    ///   <para>skos:example : Harry Kipper performs with Harry Kipper (as part of 'The Kipper Kids')^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1306_performs_with^^xsd:string</para>
    ///   <para>dce:identifier : 1306^^xsd:string</para>
    ///   <para>dce:title : performs with - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1306_performs_with">gvp:ulan1306_performs_with</a>
    /// </summary>
    let ulan1306_performs_with = _prefixId.prefix "ulan1306_performs_with"
    /// <summary>
    ///   <para>skos:example : Bernard Castelli was assistant of Pablo Picasso^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1307_assistant_of^^xsd:string</para>
    ///   <para>dce:title : assistant of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1307^^xsd:string</para>
    ///   <para>dcterms:description : person - assistant of - person.
    /// Example: Bernard Castelli was assistant of Pablo Picasso^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1307_assistant_of">gvp:ulan1307_assistant_of</a>
    /// </summary>
    let ulan1307_assistant_of = _prefixId.prefix "ulan1307_assistant_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1308_assisted_by^^xsd:string</para>
    ///   <para>skos:example : Pablo Picasso was assisted by Bernard Castelli^^xsd:string</para>
    ///   <para>dcterms:description : person - assisted by - person.
    /// Example: Pablo Picasso was assisted by Bernard Castelli^^xsd:string</para>
    ///   <para>dce:identifier : 1308^^xsd:string</para>
    ///   <para>dce:title : assisted by - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1308_assisted_by">gvp:ulan1308_assisted_by</a>
    /// </summary>
    let ulan1308_assisted_by = _prefixId.prefix "ulan1308_assisted_by"
    /// <summary>
    ///   <para>skos:example : Thomas Cromwell, Earl of Essex was the advisor of Henry VIII, King of England^^xsd:string</para>
    ///   <para>dcterms:description : person - advisor of - person.
    /// Example: Thomas Cromwell, Earl of Essex was the advisor of Henry VIII, King of England^^xsd:string</para>
    ///   <para>dce:title : advisor of - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1309_advisor_of^^xsd:string</para>
    ///   <para>dce:identifier : 1309^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1309_advisor_of">gvp:ulan1309_advisor_of</a>
    /// </summary>
    let ulan1309_advisor_of = _prefixId.prefix "ulan1309_advisor_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1310_advised_by^^xsd:string</para>
    ///   <para>dce:identifier : 1310^^xsd:string</para>
    ///   <para>dce:title : advised by - person^^xsd:string</para>
    ///   <para>dcterms:description : person - advised by - person.
    /// Example: Henry VIII, King of England was advised by Thomas Cromwell, Earl of Essex^^xsd:string</para>
    ///   <para>skos:example : Henry VIII, King of England was advised by Thomas Cromwell, Earl of Essex^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1310_advised_by">gvp:ulan1310_advised_by</a>
    /// </summary>
    let ulan1310_advised_by = _prefixId.prefix "ulan1310_advised_by"
    /// <summary>
    ///   <para>dcterms:description : person - partner of - person.
    /// Example: Frank Gehry and James Glymph are partners^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1311_partner_of^^xsd:string</para>
    ///   <para>dce:title : partner of - person^^xsd:string</para>
    ///   <para>skos:example : Frank Gehry and James Glymph are partners^^xsd:string</para>
    ///   <para>dce:identifier : 1311^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1311_partner_of">gvp:ulan1311_partner_of</a>
    /// </summary>
    let ulan1311_partner_of = _prefixId.prefix "ulan1311_partner_of"
    /// <summary>
    ///   <para>dce:title : partner in - firm^^xsd:string</para>
    ///   <para>skos:example : Parners of Adler and Sullivan included Louis H. Sullivan and Dankmar Adler^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1313_partner_in^^xsd:string</para>
    ///   <para>dcterms:description : person - partner in - firm.
    /// Example: Parners of Adler and Sullivan included Louis H. Sullivan and Dankmar Adler^^xsd:string</para>
    ///   <para>dce:identifier : 1313^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1313_partner_in">gvp:ulan1313_partner_in</a>
    /// </summary>
    let ulan1313_partner_in = _prefixId.prefix "ulan1313_partner_in"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1314_partner_was^^xsd:string</para>
    ///   <para>dce:title : partner was - person^^xsd:string</para>
    ///   <para>dce:identifier : 1314^^xsd:string</para>
    ///   <para>dcterms:description : firm - partner was - person.
    /// Example: Louis H. Sullivan and Dankmar Adler were partners in Adler and Sullivan^^xsd:string</para>
    ///   <para>skos:example : Louis H. Sullivan and Dankmar Adler were partners in Adler and Sullivan^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1314_partner_was">gvp:ulan1314_partner_was</a>
    /// </summary>
    let ulan1314_partner_was = _prefixId.prefix "ulan1314_partner_was"
    /// <summary>
    ///   <para>dce:title : principal in - firm^^xsd:string</para>
    ///   <para>dcterms:description : person - principal in - firm.
    /// Example: Principal in Fontana Workshop was Orazio Fontana^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1315_principal_in^^xsd:string</para>
    ///   <para>skos:example : Principal in Fontana Workshop was Orazio Fontana^^xsd:string</para>
    ///   <para>dce:identifier : 1315^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1315_principal_in">gvp:ulan1315_principal_in</a>
    /// </summary>
    let ulan1315_principal_in = _prefixId.prefix "ulan1315_principal_in"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1316_principal_was^^xsd:string</para>
    ///   <para>dce:title : principal was - person^^xsd:string</para>
    ///   <para>dce:identifier : 1316^^xsd:string</para>
    ///   <para>skos:example : Orazio Fontana was principal in Fontana Workshop^^xsd:string</para>
    ///   <para>dcterms:description : firm - principal was - person.
    /// Example: Orazio Fontana was principal in Fontana Workshop^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1316_principal_was">gvp:ulan1316_principal_was</a>
    /// </summary>
    let ulan1316_principal_was = _prefixId.prefix "ulan1316_principal_was"
    /// <summary>
    ///   <para>skos:example : A member of the Foundation of Documents of Architecture is the National Gallery of Art^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1317_member_of^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - member of - person/firm/group.
    /// Example: A member of the Foundation of Documents of Architecture is the National Gallery of Art^^xsd:string</para>
    ///   <para>dce:identifier : 1317^^xsd:string</para>
    ///   <para>dce:title : member of - person/firm/group^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1317_member_of">gvp:ulan1317_member_of</a>
    /// </summary>
    let ulan1317_member_of = _prefixId.prefix "ulan1317_member_of"
    /// <summary>
    ///   <para>dce:identifier : 1318^^xsd:string</para>
    ///   <para>dcterms:description : person/firm/group - member was - firm/group.
    /// Example: The National Gallery of Art was/is a member of the Foundation of Documentation of Architecture^^xsd:string</para>
    ///   <para>dce:title : member was - firm/group^^xsd:string</para>
    ///   <para>skos:example : The National Gallery of Art was/is a member of the Foundation of Documentation of Architecture^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1318_member_was^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1318_member_was">gvp:ulan1318_member_was</a>
    /// </summary>
    let ulan1318_member_was = _prefixId.prefix "ulan1318_member_was"
    /// <summary>
    ///   <para>skos:example : The school of Pierre Saalburg was the Architectural Association. School of Architecture^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1321_school_of^^xsd:string</para>
    ///   <para>dcterms:description : person - school of - firm/group.
    /// Example: The school of Pierre Saalburg was the Architectural Association. School of Architecture^^xsd:string</para>
    ///   <para>dce:identifier : 1321^^xsd:string</para>
    ///   <para>dce:title : school of - firm/group^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1321_school_of">gvp:ulan1321_school_of</a>
    /// </summary>
    let ulan1321_school_of = _prefixId.prefix "ulan1321_school_of"
    /// <summary>
    ///   <para>dce:title : school was - person^^xsd:string</para>
    ///   <para>dce:identifier : 1322^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1322_school_was^^xsd:string</para>
    ///   <para>skos:example : Pierre Saalburg attended Architectural Association. School of Architecture^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - school was - person.
    /// Example: Pierre Saalburg attended Architectural Association. School of Architecture^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1322_school_was">gvp:ulan1322_school_was</a>
    /// </summary>
    let ulan1322_school_was = _prefixId.prefix "ulan1322_school_was"
    /// <summary>
    ///   <para>skos:example : Scarsellino and Domenichino worked with the Carracci family^^xsd:string</para>
    ///   <para>dce:title : worked with - person^^xsd:string</para>
    ///   <para>dce:identifier : 1331^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1331_worked_with^^xsd:string</para>
    ///   <para>dcterms:description : any - worked with - person.
    /// Example: Scarsellino and Domenichino worked with the Carracci family^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1331_worked_with">gvp:ulan1331_worked_with</a>
    /// </summary>
    let ulan1331_worked_with = _prefixId.prefix "ulan1331_worked_with"
    /// <summary>
    ///   <para>dce:identifier : 1332^^xsd:string</para>
    ///   <para>skos:example : Workers for the Carracci family included Scarsellino and Domenichino^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1332_worker_was^^xsd:string</para>
    ///   <para>dcterms:description : person - worker was - any.
    /// Example: Workers for the Carracci family included Scarsellino and Domenichino^^xsd:string</para>
    ///   <para>dce:title : worker was - any^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1332_worker_was">gvp:ulan1332_worker_was</a>
    /// </summary>
    let ulan1332_worker_was = _prefixId.prefix "ulan1332_worker_was"
    /// <summary>
    ///   <para>skos:example : Richard Meier &amp; Partners Architects LLP is the successor of Richard Meier &amp; Associates^^xsd:string</para>
    ///   <para>dce:title : successor of - firm/group^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1411_successor_of^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - successor of - firm/group.
    /// Example: Richard Meier &amp; Partners Architects LLP is the successor of Richard Meier &amp; Associates^^xsd:string</para>
    ///   <para>dce:identifier : 1411^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1411_successor_of">gvp:ulan1411_successor_of</a>
    /// </summary>
    let ulan1411_successor_of = _prefixId.prefix "ulan1411_successor_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1412_predecessor_of^^xsd:string</para>
    ///   <para>dce:identifier : 1412^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - predecessor of - firm/group.
    /// Example: Richard Meier &amp; Associates is the predecessor of Richard Meier &amp; Partners Architects LLP^^xsd:string</para>
    ///   <para>dce:title : predecessor of - firm/group^^xsd:string</para>
    ///   <para>skos:example : Richard Meier &amp; Associates is the predecessor of Richard Meier &amp; Partners Architects LLP^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1412_predecessor_of">gvp:ulan1412_predecessor_of</a>
    /// </summary>
    let ulan1412_predecessor_of = _prefixId.prefix "ulan1412_predecessor_of"

    /// <summary>
    ///   <para>skos:prefLabel : ulan1413_administration_overlaps_with^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - administration overlaps with - firm/group.
    /// Example: The administration of the Numismatic Collection overlaps with Bode Museum^^xsd:string</para>
    ///   <para>skos:example : The administration of the Numismatic Collection overlaps with Bode Museum^^xsd:string</para>
    ///   <para>dce:title : administration overlaps with - firm/group^^xsd:string</para>
    ///   <para>dce:identifier : 1413^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1413_administration_overlaps_with">gvp:ulan1413_administration_overlaps_with</a>
    /// </summary>
    let ulan1413_administration_overlaps_with =
        _prefixId.prefix "ulan1413_administration_overlaps_with"

    /// <summary>
    ///   <para>skos:prefLabel : ulan1414_joint_venture_with^^xsd:string</para>
    ///   <para>dce:identifier : 1414^^xsd:string</para>
    ///   <para>skos:example : Schwetye Luchini Architects is in a joint venture with ACME Architects^^xsd:string</para>
    ///   <para>dce:title : joint venture with - firm/group^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - joint venture with - firm/group.
    /// Example: Schwetye Luchini Architects is in a joint venture with ACME Architects^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1414_joint_venture_with">gvp:ulan1414_joint_venture_with</a>
    /// </summary>
    let ulan1414_joint_venture_with = _prefixId.prefix "ulan1414_joint_venture_with"
    /// <summary>
    ///   <para>skos:example : National Gallery of Art was founded by United States Congress^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - founded by - firm/group.
    /// Example: National Gallery of Art was founded by United States Congress^^xsd:string</para>
    ///   <para>dce:title : founded by - firm/group^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1421_founded_by^^xsd:string</para>
    ///   <para>dce:identifier : 1421^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1421_founded_by">gvp:ulan1421_founded_by</a>
    /// </summary>
    let ulan1421_founded_by = _prefixId.prefix "ulan1421_founded_by"
    /// <summary>
    ///   <para>skos:example : The United States Congress founded the National Gallery of Art^^xsd:string</para>
    ///   <para>dce:title : founded - firm/group^^xsd:string</para>
    ///   <para>dce:identifier : 1422^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1422_founded^^xsd:string</para>
    ///   <para>dcterms:description : firm/group - founded - firm/group.
    /// Example: The United States Congress founded the National Gallery of Art^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1422_founded">gvp:ulan1422_founded</a>
    /// </summary>
    let ulan1422_founded = _prefixId.prefix "ulan1422_founded"
    /// <summary>
    ///   <para>skos:example : Titian and Tizianello have a familial relationship with each other^^xsd:string</para>
    ///   <para>dcterms:description : person - related to (familial relationship) - person.
    /// Example: Titian and Tizianello have a familial relationship with each other^^xsd:string</para>
    ///   <para>dce:title : related to - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1500_related_to^^xsd:string</para>
    ///   <para>dce:identifier : 1500^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1500_related_to">gvp:ulan1500_related_to</a>
    /// </summary>
    let ulan1500_related_to = _prefixId.prefix "ulan1500_related_to"
    /// <summary>
    ///   <para>skos:example : Philippe Rubens is the sibling of Peter Paul Rubens^^xsd:string</para>
    ///   <para>dce:title : sibling of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1501^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1501_sibling_of^^xsd:string</para>
    ///   <para>dcterms:description : person - sibling of - person.
    /// Example: Philippe Rubens is the sibling of Peter Paul Rubens^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1501_sibling_of">gvp:ulan1501_sibling_of</a>
    /// </summary>
    let ulan1501_sibling_of = _prefixId.prefix "ulan1501_sibling_of"
    /// <summary>
    ///   <para>dce:title : child of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - child of - person.
    /// Example: Rembrandt van Rijn is the child of Neeltgen Willemsdr van Zuydtbroeck^^xsd:string</para>
    ///   <para>skos:example : Rembrandt van Rijn is the child of Neeltgen Willemsdr van Zuydtbroeck^^xsd:string</para>
    ///   <para>dce:identifier : 1511^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1511_child_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1511_child_of">gvp:ulan1511_child_of</a>
    /// </summary>
    let ulan1511_child_of = _prefixId.prefix "ulan1511_child_of"
    /// <summary>
    ///   <para>dce:title : parent of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - parent of - person.
    /// Example: Rembrandt van Rijn is the parent of Rumbertus van Rijn^^xsd:string</para>
    ///   <para>skos:example : Rembrandt van Rijn is the parent of Rumbertus van Rijn^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1512_parent_of^^xsd:string</para>
    ///   <para>dce:identifier : 1512^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1512_parent_of">gvp:ulan1512_parent_of</a>
    /// </summary>
    let ulan1512_parent_of = _prefixId.prefix "ulan1512_parent_of"
    /// <summary>
    ///   <para>dcterms:description : person - grandchild of - person.
    /// Example: Eric Lloyd Wright is the grandchild of Frank Lloyd Wright^^xsd:string</para>
    ///   <para>skos:example : Eric Lloyd Wright is the grandchild of Frank Lloyd Wright^^xsd:string</para>
    ///   <para>dce:identifier : 1513^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1513_grandchild_of^^xsd:string</para>
    ///   <para>dce:title : grandchild of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1513_grandchild_of">gvp:ulan1513_grandchild_of</a>
    /// </summary>
    let ulan1513_grandchild_of = _prefixId.prefix "ulan1513_grandchild_of"
    /// <summary>
    ///   <para>dcterms:description : person - gandparent of - person.
    /// Example: Frank Lloyd Wright is the grandparent of Eric Lloyd Wright^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1514_gandparent_of^^xsd:string</para>
    ///   <para>skos:example : Frank Lloyd Wright is the grandparent of Eric Lloyd Wright^^xsd:string</para>
    ///   <para>dce:title : gandparent of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1514^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1514_gandparent_of">gvp:ulan1514_gandparent_of</a>
    /// </summary>
    let ulan1514_gandparent_of = _prefixId.prefix "ulan1514_gandparent_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1515_great-grandparent_of^^xsd:string</para>
    ///   <para>skos:example : Albrecht Adam is the great-grandparent of Richard Benno Adam^^xsd:string</para>
    ///   <para>dce:title : great-grandparent of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1515^^xsd:string</para>
    ///   <para>dcterms:description : person - great-grandparent of - person.
    /// Example: Albrecht Adam is the great-grandparent of Richard Benno Adam^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1515_great-grandparent_of">gvp:ulan1515_great-grandparent_of</a>
    /// </summary>
    let ulan1515_great_grandparent_of = _prefixId.prefix "ulan1515_great-grandparent_of"
    /// <summary>
    ///   <para>dcterms:description : person - great-grandchild of - person.
    /// Example: Richard Benno Adam is the great-grandchild of Albrecht Adam^^xsd:string</para>
    ///   <para>dce:title : great-grandchild of - person^^xsd:string</para>
    ///   <para>skos:example : Richard Benno Adam is the great-grandchild of Albrecht Adam^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1516_great-grandchild_of^^xsd:string</para>
    ///   <para>dce:identifier : 1516^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1516_great-grandchild_of">gvp:ulan1516_great-grandchild_of</a>
    /// </summary>
    let ulan1516_great_grandchild_of = _prefixId.prefix "ulan1516_great-grandchild_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1521_cousin_of^^xsd:string</para>
    ///   <para>dce:identifier : 1521^^xsd:string</para>
    ///   <para>dcterms:description : person - cousin of - person.
    /// Example: Richard Meier and Frank Gehry are cousins^^xsd:string</para>
    ///   <para>dce:title : cousin of - person^^xsd:string</para>
    ///   <para>skos:example : Richard Meier and Frank Gehry are cousins^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1521_cousin_of">gvp:ulan1521_cousin_of</a>
    /// </summary>
    let ulan1521_cousin_of = _prefixId.prefix "ulan1521_cousin_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1531_nephew-niece_of^^xsd:string</para>
    ///   <para>dce:title : nephew/niece of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1531^^xsd:string</para>
    ///   <para>skos:example : Jan Brueghel, the elder is the nephew/neice of  Pieter Coecke van Aeist, the younger^^xsd:string</para>
    ///   <para>dcterms:description : person - nephew/niece of - person.
    /// Example: Jan Brueghel, the elder is the nephew/neice of  Pieter Coecke van Aeist, the younger^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1531_nephew-niece_of">gvp:ulan1531_nephew-niece_of</a>
    /// </summary>
    let ulan1531_nephew_niece_of = _prefixId.prefix "ulan1531_nephew-niece_of"
    /// <summary>
    ///   <para>dce:title : uncle/aunt of - person^^xsd:string</para>
    ///   <para>skos:example : Edouard Manet is the uncle/aunt of Julie Manet^^xsd:string</para>
    ///   <para>dcterms:description : person - uncle/aunt of - person.
    /// Example: Edouard Manet is the uncle/aunt of Julie Manet^^xsd:string</para>
    ///   <para>dce:identifier : 1532^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1532_uncle-aunt_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1532_uncle-aunt_of">gvp:ulan1532_uncle-aunt_of</a>
    /// </summary>
    let ulan1532_uncle_aunt_of = _prefixId.prefix "ulan1532_uncle-aunt_of"
    /// <summary>
    ///   <para>dcterms:description : person - spouse of - person.
    /// Example: Alfred Stieglitz and Georgia O'Keeffe were married to each other^^xsd:string</para>
    ///   <para>dce:identifier : 1541^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1541_spouse_of^^xsd:string</para>
    ///   <para>skos:example : Alfred Stieglitz and Georgia O'Keeffe were married to each other^^xsd:string</para>
    ///   <para>dce:title : spouse of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1541_spouse_of">gvp:ulan1541_spouse_of</a>
    /// </summary>
    let ulan1541_spouse_of = _prefixId.prefix "ulan1541_spouse_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1542_consort_of^^xsd:string</para>
    ///   <para>dce:identifier : 1542^^xsd:string</para>
    ///   <para>dcterms:description : person - consort of - person.
    /// Example: Empress Livia was the consort of Augustus, Emperor of Rome^^xsd:string</para>
    ///   <para>dce:title : consort of - person^^xsd:string</para>
    ///   <para>skos:example : Empress Livia was the consort of Augustus, Emperor of Rome^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1542_consort_of">gvp:ulan1542_consort_of</a>
    /// </summary>
    let ulan1542_consort_of = _prefixId.prefix "ulan1542_consort_of"
    /// <summary>
    ///   <para>dcterms:description : person - consort was - person.
    /// Example: Augustus, Emperor of Rome's consort was Empress Livia^^xsd:string</para>
    ///   <para>dce:title : consort was - person^^xsd:string</para>
    ///   <para>skos:example : Augustus, Emperor of Rome's consort was Empress Livia^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1543_consort_was^^xsd:string</para>
    ///   <para>dce:identifier : 1543^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1543_consort_was">gvp:ulan1543_consort_was</a>
    /// </summary>
    let ulan1543_consort_was = _prefixId.prefix "ulan1543_consort_was"
    /// <summary>
    ///   <para>dcterms:description : person - significant other of - person.
    /// Example: Jeanne Hebuterne was the significant other of Amedeo Modigliani^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1544_significant_other_of^^xsd:string</para>
    ///   <para>skos:example : Jeanne Hebuterne was the significant other of Amedeo Modigliani^^xsd:string</para>
    ///   <para>dce:title : significant other of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1544^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1544_significant_other_of">gvp:ulan1544_significant_other_of</a>
    /// </summary>
    let ulan1544_significant_other_of = _prefixId.prefix "ulan1544_significant_other_of"
    /// <summary>
    ///   <para>dce:title : romantic partner of - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1547_romantic_partner_of^^xsd:string</para>
    ///   <para>skos:example : Pablo Picasso and Gaby Lespinasse were romantic partners^^xsd:stringskos:example : Vincent van Gogh and Clasina Hoornik were romantic partners^^xsd:string</para>
    ///   <para>dce:identifier : 1547^^xsd:string</para>
    ///   <para>dcterms:description : person - romantic partner of - person.
    /// Example: Pablo Picasso and Gaby Lespinasse were romantic partners; Vincent van Gogh and Clasina Hoornik were romantic partners^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1547_romantic_partner_of">gvp:ulan1547_romantic_partner_of</a>
    /// </summary>
    let ulan1547_romantic_partner_of = _prefixId.prefix "ulan1547_romantic_partner_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1548_domestic_partner_of^^xsd:string</para>
    ///   <para>dce:identifier : 1548^^xsd:string</para>
    ///   <para>dce:title : domestic partner of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - domestic partner of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1548_domestic_partner_of">gvp:ulan1548_domestic_partner_of</a>
    /// </summary>
    let ulan1548_domestic_partner_of = _prefixId.prefix "ulan1548_domestic_partner_of"
    /// <summary>
    ///   <para>dce:title : relative by marriage - person^^xsd:string</para>
    ///   <para>dcterms:description : person - relative by marriage (in-law) - person.
    /// Example: Juana Galarza d Goicoechea and Francisco de Goya are related by marriage^^xsd:string</para>
    ///   <para>dce:identifier : 1550^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1550_relative_by_marriage^^xsd:string</para>
    ///   <para>skos:example : Juana Galarza d Goicoechea and Francisco de Goya are related by marriage^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1550_relative_by_marriage">gvp:ulan1550_relative_by_marriage</a>
    /// </summary>
    let ulan1550_relative_by_marriage = _prefixId.prefix "ulan1550_relative_by_marriage"

    /// <summary>
    ///   <para>dce:title : sibling by marriage of - person^^xsd:string</para>
    ///   <para>skos:example : Peter Paul Rubens and Susanne Fourment are siblings by marriage^^xsd:string</para>
    ///   <para>dce:identifier : 1551^^xsd:string</para>
    ///   <para>dcterms:description : person - sibling by marriage (step sibling) - person.
    /// Example: Peter Paul Rubens and Susanne Fourment are siblings by marriage^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1551_sibling_by_marriage_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1551_sibling_by_marriage_of">gvp:ulan1551_sibling_by_marriage_of</a>
    /// </summary>
    let ulan1551_sibling_by_marriage_of =
        _prefixId.prefix "ulan1551_sibling_by_marriage_of"

    /// <summary>
    ///   <para>dce:identifier : 1552^^xsd:string</para>
    ///   <para>skos:example : Frans Hals is a parent by marriage of Pieter Gerritsz van Roestraten^^xsd:string</para>
    ///   <para>dcterms:description : person - parent by marriage (step parent) - person.
    /// Example: Frans Hals is a parent by marriage of Pieter Gerritsz van Roestraten^^xsd:string</para>
    ///   <para>dce:title : parent by marriage of - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1552_parent_by_marriage_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1552_parent_by_marriage_of">gvp:ulan1552_parent_by_marriage_of</a>
    /// </summary>
    let ulan1552_parent_by_marriage_of =
        _prefixId.prefix "ulan1552_parent_by_marriage_of"

    /// <summary>
    ///   <para>dce:identifier : 1553^^xsd:string</para>
    ///   <para>skos:example : Pieter Gerritsz van Roestraten is the child by marriage of Frans Hals^^xsd:string</para>
    ///   <para>dcterms:description : person - child by marriage (step child) - person.
    /// Example: Pieter Gerritsz van Roestraten is the child by marriage of Frans Hals^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1553_child_by_marriage_of^^xsd:string</para>
    ///   <para>dce:title : child by marriage of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1553_child_by_marriage_of">gvp:ulan1553_child_by_marriage_of</a>
    /// </summary>
    let ulan1553_child_by_marriage_of = _prefixId.prefix "ulan1553_child_by_marriage_of"
    /// <summary>
    ///   <para>skos:example : Julius Caesar is the adoptive parent of Augustus, Emperor of Rome^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1554_adoptive_parent_of^^xsd:string</para>
    ///   <para>dce:identifier : 1554^^xsd:string</para>
    ///   <para>dce:title : adoptive parent of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - adoptive parent of - person.
    /// Example: Julius Caesar is the adoptive parent of Augustus, Emperor of Rome^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1554_adoptive_parent_of">gvp:ulan1554_adoptive_parent_of</a>
    /// </summary>
    let ulan1554_adoptive_parent_of = _prefixId.prefix "ulan1554_adoptive_parent_of"
    /// <summary>
    ///   <para>dce:identifier : 1555^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1555_adopted_child_of^^xsd:string</para>
    ///   <para>dce:title : adopted child of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - adopted child of - person.
    /// Example: Augusts, Emperor of Rome is the adopted child of Julius Caesar^^xsd:string</para>
    ///   <para>skos:example : Augusts, Emperor of Rome is the adopted child of Julius Caesar^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1555_adopted_child_of">gvp:ulan1555_adopted_child_of</a>
    /// </summary>
    let ulan1555_adopted_child_of = _prefixId.prefix "ulan1555_adopted_child_of"
    /// <summary>
    ///   <para>dcterms:description : person - half-sibling of - person.
    /// Example: Juan Bautista Monegro and Luis de Carbajal are half siblings^^xsd:string</para>
    ///   <para>dce:title : half-sibling of - person^^xsd:string</para>
    ///   <para>dce:identifier : 1556^^xsd:string</para>
    ///   <para>skos:example : Juan Bautista Monegro and Luis de Carbajal are half siblings^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1556_half-sibling_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1556_half-sibling_of">gvp:ulan1556_half-sibling_of</a>
    /// </summary>
    let ulan1556_half_sibling_of = _prefixId.prefix "ulan1556_half-sibling_of"
    /// <summary>
    ///   <para>dce:identifier : 1557^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1557_step-sibling_of^^xsd:string</para>
    ///   <para>dce:title : step-sibling of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - step-sibling of - person.
    /// Example: W. L. Wyllie and Lionel Percy Smythe are step-siblings^^xsd:string</para>
    ///   <para>skos:example : W. L. Wyllie and Lionel Percy Smythe are step-siblings^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1557_step-sibling_of">gvp:ulan1557_step-sibling_of</a>
    /// </summary>
    let ulan1557_step_sibling_of = _prefixId.prefix "ulan1557_step-sibling_of"
    /// <summary>
    ///   <para>dce:identifier : 1561^^xsd:string</para>
    ///   <para>dcterms:description : person - step-child of - person.
    /// Example: Hortense, Quene consort of Louis Bonaparte is the step-child of Napoleon I, Emperor of the French^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1561_step-child_of^^xsd:string</para>
    ///   <para>dce:title : step-child of - person^^xsd:string</para>
    ///   <para>skos:example : Hortense, Quene consort of Louis Bonaparte is the step-child of Napoleon I, Emperor of the French^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1561_step-child_of">gvp:ulan1561_step-child_of</a>
    /// </summary>
    let ulan1561_step_child_of = _prefixId.prefix "ulan1561_step-child_of"
    /// <summary>
    ///   <para>dcterms:description : person - step-parent of - person.
    /// Example: Napoleon I, Emperor of the French is the step-parent of Hortense, Quene consort of Louis Bonaparte^^xsd:string</para>
    ///   <para>skos:example : Napoleon I, Emperor of the French is the step-parent of Hortense, Quene consort of Louis Bonaparte^^xsd:string</para>
    ///   <para>dce:title : step-parent of - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1562_step-parent_of^^xsd:string</para>
    ///   <para>dce:identifier : 1562^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1562_step-parent_of">gvp:ulan1562_step-parent_of</a>
    /// </summary>
    let ulan1562_step_parent_of = _prefixId.prefix "ulan1562_step-parent_of"
    /// <summary>
    ///   <para>dcterms:description : person - guardian of - person.
    /// Example: John Hoskins, the elder was the guardian of Samuel Cooper^^xsd:string</para>
    ///   <para>dce:identifier : 1571^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1571_guardian_of^^xsd:string</para>
    ///   <para>skos:example : John Hoskins, the elder was the guardian of Samuel Cooper^^xsd:string</para>
    ///   <para>dce:title : guardian of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1571_guardian_of">gvp:ulan1571_guardian_of</a>
    /// </summary>
    let ulan1571_guardian_of = _prefixId.prefix "ulan1571_guardian_of"
    /// <summary>
    ///   <para>skos:example : Samuel Cooper was a ward of John Hoskins, the elder^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1573_ward_of^^xsd:string</para>
    ///   <para>dce:identifier : 1573^^xsd:string</para>
    ///   <para>dce:title : ward of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - ward of - person.
    /// Example: Samuel Cooper was a ward of John Hoskins, the elder^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1573_ward_of">gvp:ulan1573_ward_of</a>
    /// </summary>
    let ulan1573_ward_of = _prefixId.prefix "ulan1573_ward_of"
    /// <summary>
    ///   <para>dce:identifier : 1574^^xsd:string</para>
    ///   <para>skos:example : Jean-Baptiste Goy is godparent of Jean I Nocret^^xsd:string</para>
    ///   <para>dcterms:description : person - godparent of - person.
    /// Example: Jean-Baptiste Goy is godparent of Jean I Nocret^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1574_godparent_of^^xsd:string</para>
    ///   <para>dce:title : godparent of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1574_godparent_of">gvp:ulan1574_godparent_of</a>
    /// </summary>
    let ulan1574_godparent_of = _prefixId.prefix "ulan1574_godparent_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan1575_godchild_of^^xsd:string</para>
    ///   <para>skos:example : Jean I Nocret is the godchild of Jean-Baptiste Goy^^xsd:string</para>
    ///   <para>dce:identifier : 1575^^xsd:string</para>
    ///   <para>dcterms:description : person - godchild of - person.
    /// Example: Jean I Nocret is the godchild of Jean-Baptiste Goy^^xsd:string</para>
    ///   <para>dce:title : godchild of - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1575_godchild_of">gvp:ulan1575_godchild_of</a>
    /// </summary>
    let ulan1575_godchild_of = _prefixId.prefix "ulan1575_godchild_of"
    /// <summary>
    ///   <para>dce:identifier : 1581^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1581_descendant_of^^xsd:string</para>
    ///   <para>dce:title : descendant of - person^^xsd:string</para>
    ///   <para>dcterms:description : person - descendant of - person.
    /// Example: Paolo Caliari is the descendant of Paolo Veronese^^xsd:string</para>
    ///   <para>skos:example : Paolo Caliari is the descendant of Paolo Veronese^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1581_descendant_of">gvp:ulan1581_descendant_of</a>
    /// </summary>
    let ulan1581_descendant_of = _prefixId.prefix "ulan1581_descendant_of"
    /// <summary>
    ///   <para>skos:example : Paolo Veronese is the ancestor of Paolo Caliari^^xsd:string</para>
    ///   <para>dce:title : ancestor of - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1582_ancestor_of^^xsd:string</para>
    ///   <para>dce:identifier : 1582^^xsd:string</para>
    ///   <para>dcterms:description : person - ancestor of - person.
    /// Example: Paolo Veronese is the ancestor of Paolo Caliari^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1582_ancestor_of">gvp:ulan1582_ancestor_of</a>
    /// </summary>
    let ulan1582_ancestor_of = _prefixId.prefix "ulan1582_ancestor_of"
    /// <summary>
    ///   <para>dcterms:description : person - possibly related to (familial relationship) - person.
    /// Example: A familial relationship between Ramon Destorrents, the younger and Ramon Destorrents, the elder is possible^^xsd:string</para>
    ///   <para>dce:title : possibly related to - person^^xsd:string</para>
    ///   <para>dce:identifier : 1590^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan1590_possibly_related_to^^xsd:string</para>
    ///   <para>skos:example : A familial relationship between Ramon Destorrents, the younger and Ramon Destorrents, the elder is possible^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan1590_possibly_related_to">gvp:ulan1590_possibly_related_to</a>
    /// </summary>
    let ulan1590_possibly_related_to = _prefixId.prefix "ulan1590_possibly_related_to"
    /// <summary>
    ///   <para>dce:title : friend of - person^^xsd:string</para>
    ///   <para>dce:identifier : 2550^^xsd:string</para>
    ///   <para>dcterms:description : person - friend of (personal relationship) - person.
    /// Example: Alfred Stieglitz and Frank Simon Herrmann were friends^^xsd:string</para>
    ///   <para>skos:example : Alfred Stieglitz and Frank Simon Herrmann were friends^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2550_friend_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2550_friend_of">gvp:ulan2550_friend_of</a>
    /// </summary>
    let ulan2550_friend_of = _prefixId.prefix "ulan2550_friend_of"
    /// <summary>
    ///   <para>dce:title : founder of - institution^^xsd:string</para>
    ///   <para>dcterms:description : person - founder of - institution.
    /// Example: Louis Comfort Tiffany was the founder of Tiffany Glass &amp; Decorating Company^^xsd:string</para>
    ///   <para>skos:example : Louis Comfort Tiffany was the founder of Tiffany Glass &amp; Decorating Company^^xsd:string</para>
    ///   <para>dce:identifier : 2572^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2572_founder_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2572_founder_of">gvp:ulan2572_founder_of</a>
    /// </summary>
    let ulan2572_founder_of = _prefixId.prefix "ulan2572_founder_of"
    /// <summary>
    ///   <para>dce:title : founded by - person^^xsd:string</para>
    ///   <para>dce:identifier : 2573^^xsd:string</para>
    ///   <para>skos:example : Tiffany Glass &amp; Decorating Company was founded by Louis Comfort Tiffany^^xsd:string</para>
    ///   <para>dcterms:description : institution - founded by - person.
    /// Example: Tiffany Glass &amp; Decorating Company was founded by Louis Comfort Tiffany^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2573_founded_by^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2573_founded_by">gvp:ulan2573_founded_by</a>
    /// </summary>
    let ulan2573_founded_by = _prefixId.prefix "ulan2573_founded_by"
    /// <summary>
    ///   <para>skos:prefLabel : ulan2574_director_of^^xsd:string</para>
    ///   <para>dce:identifier : 2574^^xsd:string</para>
    ///   <para>skos:example : Jean Jans I directed Gobelins Tapestry Manufactory^^xsd:string</para>
    ///   <para>dcterms:description : person - director of - institution.
    /// Example: Jean Jans I directed Gobelins Tapestry Manufactory^^xsd:string</para>
    ///   <para>dce:title : director of - institution^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2574_director_of">gvp:ulan2574_director_of</a>
    /// </summary>
    let ulan2574_director_of = _prefixId.prefix "ulan2574_director_of"
    /// <summary>
    ///   <para>skos:example : Gobelins Tapestry Manufactory was directed by Jean Jans I^^xsd:string</para>
    ///   <para>dcterms:description : institution - directed by - person.
    /// Example: Gobelins Tapestry Manufactory was directed by Jean Jans I^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2575_directed_by^^xsd:string</para>
    ///   <para>dce:title : directed by - person^^xsd:string</para>
    ///   <para>dce:identifier : 2575^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2575_directed_by">gvp:ulan2575_directed_by</a>
    /// </summary>
    let ulan2575_directed_by = _prefixId.prefix "ulan2575_directed_by"
    /// <summary>
    ///   <para>dce:title : patron of - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2576_patron_of^^xsd:string</para>
    ///   <para>dcterms:description : person - patron of - person.
    /// Example: The patron of William Chambers was James Caulfiel, Earl of Charlemont^^xsd:string</para>
    ///   <para>dce:identifier : 2576^^xsd:string</para>
    ///   <para>skos:example : The patron of William Chambers was James Caulfiel, Earl of Charlemont^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2576_patron_of">gvp:ulan2576_patron_of</a>
    /// </summary>
    let ulan2576_patron_of = _prefixId.prefix "ulan2576_patron_of"
    /// <summary>
    ///   <para>skos:example : James Caulfiel, Earl of Charlemont was the patron of William Chambers^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2577_patron_was^^xsd:string</para>
    ///   <para>dce:title : patron was - person^^xsd:string</para>
    ///   <para>dcterms:description : person - patron was - person.
    /// Example: James Caulfiel, Earl of Charlemont was the patron of William Chambers^^xsd:string</para>
    ///   <para>dce:identifier : 2577^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2577_patron_was">gvp:ulan2577_patron_was</a>
    /// </summary>
    let ulan2577_patron_was = _prefixId.prefix "ulan2577_patron_was"
    /// <summary>
    ///   <para>skos:example : George Douglas Haig was a trustee of the National Galleries of Scotland^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2578_trustee_of^^xsd:string</para>
    ///   <para>dce:title : trustee of - institution^^xsd:string</para>
    ///   <para>dce:identifier : 2578^^xsd:string</para>
    ///   <para>dcterms:description : person - trustee of - institution.
    /// Example: George Douglas Haig was a trustee of the National Galleries of Scotland^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2578_trustee_of">gvp:ulan2578_trustee_of</a>
    /// </summary>
    let ulan2578_trustee_of = _prefixId.prefix "ulan2578_trustee_of"
    /// <summary>
    ///   <para>dcterms:description : institution - trustee was - person.
    /// Example: National Galleries of Scotland trustee was George Douglas Haig^^xsd:string</para>
    ///   <para>dce:title : trustee was - person^^xsd:string</para>
    ///   <para>dce:identifier : 2579^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2579_trustee_was^^xsd:string</para>
    ///   <para>skos:example : National Galleries of Scotland trustee was George Douglas Haig^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2579_trustee_was">gvp:ulan2579_trustee_was</a>
    /// </summary>
    let ulan2579_trustee_was = _prefixId.prefix "ulan2579_trustee_was"
    /// <summary>
    ///   <para>skos:example : Georges Mathieu was the administrator of Societe nationale des chemins de fer Francais. Agence des gares^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2581_administrator_of^^xsd:string</para>
    ///   <para>dcterms:description : person - administrator of - institution.
    /// Example: Georges Mathieu was the administrator of Societe nationale des chemins de fer Francais. Agence des gares^^xsd:string</para>
    ///   <para>dce:identifier : 2581^^xsd:string</para>
    ///   <para>dce:title : administrator of - institution^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2581_administrator_of">gvp:ulan2581_administrator_of</a>
    /// </summary>
    let ulan2581_administrator_of = _prefixId.prefix "ulan2581_administrator_of"
    /// <summary>
    ///   <para>dcterms:description : institution - administered by - person.
    /// Example: Societe nationale des chemins de fer Francais. Agence des gares was administered by Georges Mathieu^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2582_administered_by^^xsd:string</para>
    ///   <para>skos:example : Societe nationale des chemins de fer Francais. Agence des gares was administered by Georges Mathieu^^xsd:string</para>
    ///   <para>dce:title : administered by - person^^xsd:string</para>
    ///   <para>dce:identifier : 2582^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2582_administered_by">gvp:ulan2582_administered_by</a>
    /// </summary>
    let ulan2582_administered_by = _prefixId.prefix "ulan2582_administered_by"
    /// <summary>
    ///   <para>dce:identifier : 2650^^xsd:string</para>
    ///   <para>skos:example : The publisher for Pierre Joseph Rossier was Negretti and Zambra^^xsd:string</para>
    ///   <para>dcterms:description : person - publisher was - firm.
    /// Example: The publisher for Pierre Joseph Rossier was Negretti and Zambra^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2650_publisher_was^^xsd:string</para>
    ///   <para>dce:title : publisher was - firm^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2650_publisher_was">gvp:ulan2650_publisher_was</a>
    /// </summary>
    let ulan2650_publisher_was = _prefixId.prefix "ulan2650_publisher_was"
    /// <summary>
    ///   <para>dce:identifier : 2651^^xsd:string</para>
    ///   <para>skos:example : Negretti and Zambra was the publisher of Pierre Joseph Rossier^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2651_publisher_of^^xsd:string</para>
    ///   <para>dce:title : publisher of - person^^xsd:string</para>
    ///   <para>dcterms:description : firm - publisher of - person.
    /// Example: Negretti and Zambra was the publisher of Pierre Joseph Rossier^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2651_publisher_of">gvp:ulan2651_publisher_of</a>
    /// </summary>
    let ulan2651_publisher_of = _prefixId.prefix "ulan2651_publisher_of"
    /// <summary>
    ///   <para>dce:title : professor at - institution^^xsd:string</para>
    ///   <para>skos:example : Paul Klee was a professor at Bauhaus^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2674_professor_at^^xsd:string</para>
    ///   <para>dcterms:description : person - professor at - institution.
    /// Example: Paul Klee was a professor at Bauhaus^^xsd:string</para>
    ///   <para>dce:identifier : 2674^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2674_professor_at">gvp:ulan2674_professor_at</a>
    /// </summary>
    let ulan2674_professor_at = _prefixId.prefix "ulan2674_professor_at"
    /// <summary>
    ///   <para>dcterms:description : institution - professor was - person.
    /// Example: A professor at Bauhaus was Paul Klee^^xsd:string</para>
    ///   <para>dce:title : professor was - person^^xsd:string</para>
    ///   <para>dce:identifier : 2675^^xsd:string</para>
    ///   <para>skos:example : A professor at Bauhaus was Paul Klee^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2675_professor_was^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2675_professor_was">gvp:ulan2675_professor_was</a>
    /// </summary>
    let ulan2675_professor_was = _prefixId.prefix "ulan2675_professor_was"
    /// <summary>
    ///   <para>dce:identifier : 2676^^xsd:string</para>
    ///   <para>dce:title : teacher at - institution^^xsd:string</para>
    ///   <para>skos:example : Willem De Kooning was a teacher at Black Mountain College^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2676_teacher_at^^xsd:string</para>
    ///   <para>dcterms:description : person - teacher at - institution.
    /// Example: Willem De Kooning was a teacher at Black Mountain College^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2676_teacher_at">gvp:ulan2676_teacher_at</a>
    /// </summary>
    let ulan2676_teacher_at = _prefixId.prefix "ulan2676_teacher_at"
    /// <summary>
    ///   <para>dcterms:description : institution - teacher was - person.
    /// Example: A teacher at Black Mountain College was Willem De Kooning^^xsd:string</para>
    ///   <para>dce:title : teacher was - person^^xsd:string</para>
    ///   <para>skos:example : A teacher at Black Mountain College was Willem De Kooning^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2677_teacher_was^^xsd:string</para>
    ///   <para>dce:identifier : 2677^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2677_teacher_was">gvp:ulan2677_teacher_was</a>
    /// </summary>
    let ulan2677_teacher_was = _prefixId.prefix "ulan2677_teacher_was"
    /// <summary>
    ///   <para>dcterms:description : person - president of - institution.
    /// Example: David K. E. Bruce was president of National Gallery of Art^^xsd:string</para>
    ///   <para>skos:example : David K. E. Bruce was president of National Gallery of Art^^xsd:string</para>
    ///   <para>dce:title : president of - institution^^xsd:string</para>
    ///   <para>dce:identifier : 2692^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2692_president_of^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2692_president_of">gvp:ulan2692_president_of</a>
    /// </summary>
    let ulan2692_president_of = _prefixId.prefix "ulan2692_president_of"
    /// <summary>
    ///   <para>dcterms:description : institution - president was - person.
    /// Example: A president of National Gallery of Art was David K. E. Bruce^^xsd:string</para>
    ///   <para>skos:example : A president of National Gallery of Art was David K. E. Bruce^^xsd:string</para>
    ///   <para>dce:identifier : 2693^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2693_president_was^^xsd:string</para>
    ///   <para>dce:title : president was - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2693_president_was">gvp:ulan2693_president_was</a>
    /// </summary>
    let ulan2693_president_was = _prefixId.prefix "ulan2693_president_was"
    /// <summary>
    ///   <para>dce:title : leader of - institution^^xsd:string</para>
    ///   <para>dcterms:description : person - leader of - institution.
    /// Example: Rush Harrison Kress was the leader of Samuel H. Kress Foundation^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2696_leader_of^^xsd:string</para>
    ///   <para>skos:example : Rush Harrison Kress was the leader of Samuel H. Kress Foundation^^xsd:string</para>
    ///   <para>dce:identifier : 2696^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2696_leader_of">gvp:ulan2696_leader_of</a>
    /// </summary>
    let ulan2696_leader_of = _prefixId.prefix "ulan2696_leader_of"
    /// <summary>
    ///   <para>dce:title : leader was - person^^xsd:string</para>
    ///   <para>dce:identifier : 2697^^xsd:string</para>
    ///   <para>dcterms:description : institution - leader was - person.
    /// Example: The leader of Samuel H. Kress Foundation was Rush Harrison Kress^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2697_leader_was^^xsd:string</para>
    ///   <para>skos:example : The leader of Samuel H. Kress Foundation was Rush Harrison Kress^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2697_leader_was">gvp:ulan2697_leader_was</a>
    /// </summary>
    let ulan2697_leader_was = _prefixId.prefix "ulan2697_leader_was"
    /// <summary>
    ///   <para>dce:title : owner of - person^^xsd:string</para>
    ///   <para>dcterms:description : firm - owner of - person.
    /// Example: Walter Scott Lenox was the owner of Lenox China Co.^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2778_owner_of^^xsd:string</para>
    ///   <para>dce:identifier : 2778^^xsd:string</para>
    ///   <para>skos:example : Walter Scott Lenox was the owner of Lenox China Co.^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2778_owner_of">gvp:ulan2778_owner_of</a>
    /// </summary>
    let ulan2778_owner_of = _prefixId.prefix "ulan2778_owner_of"
    /// <summary>
    ///   <para>skos:prefLabel : ulan2779_owned_by^^xsd:string</para>
    ///   <para>dcterms:description : person - owned by - firm.
    /// Example: Walter Scott Lenox was owned by Lenox China Co.^^xsd:string</para>
    ///   <para>skos:example : Walter Scott Lenox was owned by Lenox China Co.^^xsd:string</para>
    ///   <para>dce:title : owned by - firm^^xsd:string</para>
    ///   <para>dce:identifier : 2779^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2779_owned_by">gvp:ulan2779_owned_by</a>
    /// </summary>
    let ulan2779_owned_by = _prefixId.prefix "ulan2779_owned_by"
    /// <summary>
    ///   <para>skos:example : Auguste Rodin is the dedicatee of The Rodin Museum in Philadelphia^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2781_dedicatee_of^^xsd:string</para>
    ///   <para>dce:title : dedicatee of - institution^^xsd:string</para>
    ///   <para>dcterms:description : person - dedicatee of - institution.
    /// Example: Auguste Rodin is the dedicatee of The Rodin Museum in Philadelphia^^xsd:string</para>
    ///   <para>dce:identifier : 2781^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2781_dedicatee_of">gvp:ulan2781_dedicatee_of</a>
    /// </summary>
    let ulan2781_dedicatee_of = _prefixId.prefix "ulan2781_dedicatee_of"
    /// <summary>
    ///   <para>skos:example : The Rodin Museum in Philadelphia is didicated to Auguste Rodin^^xsd:string</para>
    ///   <para>dce:title : dedicated to - person^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2782_dedicated_to^^xsd:string</para>
    ///   <para>dcterms:description : institution - dedicated to - person.
    /// Example: The Rodin Museum in Philadelphia is didicated to Auguste Rodin^^xsd:string</para>
    ///   <para>dce:identifier : 2782^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2782_dedicated_to">gvp:ulan2782_dedicated_to</a>
    /// </summary>
    let ulan2782_dedicated_to = _prefixId.prefix "ulan2782_dedicated_to"
    /// <summary>
    ///   <para>dce:title : representative of - institution^^xsd:string</para>
    ///   <para>dcterms:description : person - representative of - institution.
    /// Example: The Noguch Museum - representative was Isamu Noguchi^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2794_representative_of^^xsd:string</para>
    ///   <para>skos:example : The Noguch Museum - representative was Isamu Noguchi^^xsd:string</para>
    ///   <para>dce:identifier : 2794^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2794_representative_of">gvp:ulan2794_representative_of</a>
    /// </summary>
    let ulan2794_representative_of = _prefixId.prefix "ulan2794_representative_of"
    /// <summary>
    ///   <para>skos:example : The Noguch Museum - representative was Isamu Noguchi^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2795_representative_was^^xsd:string</para>
    ///   <para>dce:identifier : 2795^^xsd:string</para>
    ///   <para>dce:title : representative was - person^^xsd:string</para>
    ///   <para>dcterms:description : institution - representative was - person.
    /// Example: The Noguch Museum - representative was Isamu Noguchi^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2795_representative_was">gvp:ulan2795_representative_was</a>
    /// </summary>
    let ulan2795_representative_was = _prefixId.prefix "ulan2795_representative_was"
    /// <summary>
    ///   <para>skos:example : Zdanek Rossman was a student at Bauhaus^^xsd:string</para>
    ///   <para>dce:title : student at - institution^^xsd:string</para>
    ///   <para>dcterms:description : person - student at - institution.
    /// Example: Zdanek Rossman was a student at Bauhaus^^xsd:string</para>
    ///   <para>dce:identifier : 2828^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2828_student_at^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2828_student_at">gvp:ulan2828_student_at</a>
    /// </summary>
    let ulan2828_student_at = _prefixId.prefix "ulan2828_student_at"
    /// <summary>
    ///   <para>skos:prefLabel : ulan2829_student_was^^xsd:string</para>
    ///   <para>dcterms:description : institution - student was - person.
    /// Example: Bauhaus student was Zdanek Rossman^^xsd:string</para>
    ///   <para>dce:title : student was - person^^xsd:string</para>
    ///   <para>skos:example : Bauhaus student was Zdanek Rossman^^xsd:string</para>
    ///   <para>dce:identifier : 2829^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2829_student_was">gvp:ulan2829_student_was</a>
    /// </summary>
    let ulan2829_student_was = _prefixId.prefix "ulan2829_student_was"
    /// <summary>
    ///   <para>dce:identifier : 2840^^xsd:string</para>
    ///   <para>skos:prefLabel : ulan2840_performer_with^^xsd:string</para>
    ///   <para>dcterms:description : person - performer with - group^^xsd:string</para>
    ///   <para>dce:title : performer with - group^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2840_performer_with">gvp:ulan2840_performer_with</a>
    /// </summary>
    let ulan2840_performer_with = _prefixId.prefix "ulan2840_performer_with"
    /// <summary>
    ///   <para>skos:prefLabel : ulan2841_performer_was^^xsd:string</para>
    ///   <para>dce:title : performer was - person^^xsd:string</para>
    ///   <para>dce:identifier : 2841^^xsd:string</para>
    ///   <para>dcterms:description : group - performer was - person^^xsd:string</para>
    ///   <a href="http://vocab.getty.edu/ontology#ulan2841_performer_was">gvp:ulan2841_performer_was</a>
    /// </summary>
    let ulan2841_performer_was = _prefixId.prefix "ulan2841_performer_was"
