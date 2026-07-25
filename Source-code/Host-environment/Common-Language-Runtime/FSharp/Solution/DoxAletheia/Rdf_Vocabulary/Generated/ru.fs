namespace http.purl.org.imbi.ru_meta.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ru =
    let _namespace_iri = Namespace_Iri ru |> NamespaceIRI
    /// <summary>
    ///   <para>ru:_deleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This residual category holds deleted classes</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#_deleted">http://purl.org/imbi/ru-meta.owl#_deleted</seealso>
    let _deleted = Prefixed_Name(ru, "_deleted") |> PrefixedName
    /// <summary>
    ///   <para>ru:abbrev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A common accepted abbreviation for the RU-name. A word formed from the initials of one or more words describing the name, that is pronounceable like a normal word.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#abbrev">http://purl.org/imbi/ru-meta.owl#abbrev</seealso>
    let abbrev = Prefixed_Name(ru, "abbrev") |> PrefixedName
    /// <summary>
    ///   <para>ru:del_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The date a RU was deleted.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#del_date">http://purl.org/imbi/ru-meta.owl#del_date</seealso>
    let del_date = Prefixed_Name(ru, "del_date") |> PrefixedName
    /// <summary>
    ///   <para>ru:modif_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The date on which the RU was last modified.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#modif_date">http://purl.org/imbi/ru-meta.owl#modif_date</seealso>
    let modif_date = Prefixed_Name(ru, "modif_date") |> PrefixedName
    /// <summary>
    ///   <para>ru:ont_imp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>To mark from where on in the Class-hierarchy we want to import / refer to a complete subclass hierarchy from an other ontology (was: refer to) ??? Maybe better: cls_imp</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#ont_imp">http://purl.org/imbi/ru-meta.owl#ont_imp</seealso>
    let ont_imp = Prefixed_Name(ru, "ont_imp") |> PrefixedName
    /// <summary>
    ///   <para>ru:prpty_expl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A prototypic example od a sub-property of this property )when property hierarchies are allowed.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#prpty_expl">http://purl.org/imbi/ru-meta.owl#prpty_expl</seealso>
    let prpty_expl = Prefixed_Name(ru, "prpty_expl") |> PrefixedName
    /// <summary>
    ///   <para>ru:refact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>When a class has been refactored into more atomic classes, then the original compound class is made obsolete and this deleted source class which gave birth to the new atomic child classes is mentioned here for all new atomic classes.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#refact">http://purl.org/imbi/ru-meta.owl#refact</seealso>
    let refact = Prefixed_Name(ru, "refact") |> PrefixedName
    /// <summary>
    ///   <para>ru:scope_note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Any general formless remark or note about the scope of the RU (was: rem, note).</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#scope_note">http://purl.org/imbi/ru-meta.owl#scope_note</seealso>
    let scope_note = Prefixed_Name(ru, "scope_note") |> PrefixedName
    /// <summary>
    ///   <para>ru:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An alternative name for the RU used as synonym (can be used in the same manner as the name in different contexts).</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#synonym">http://purl.org/imbi/ru-meta.owl#synonym</seealso>
    let synonym = Prefixed_Name(ru, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>ru:cls_expl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A prototypical example subclass for the class.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#cls_expl">http://purl.org/imbi/ru-meta.owl#cls_expl</seealso>
    let cls_expl = Prefixed_Name(ru, "cls_expl") |> PrefixedName
    /// <summary>
    ///   <para>ru:curation_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The status (stability level) of the class. Specifies tracking information. E.g. unstable, experimental, stable.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#curation_status">http://purl.org/imbi/ru-meta.owl#curation_status</seealso>
    let curation_status = Prefixed_Name(ru, "curation_status") |> PrefixedName
    /// <summary>
    ///   <para>ru:_temp_orphan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal store for classes that are being worked on.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#_temp_orphan">http://purl.org/imbi/ru-meta.owl#_temp_orphan</seealso>
    let _temp_orphan = Prefixed_Name(ru, "_temp_orphan") |> PrefixedName
    /// <summary>
    ///   <para>ru:action_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A description of a task / action for the RU editor to solve an issue related to the RU.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#action_item">http://purl.org/imbi/ru-meta.owl#action_item</seealso>
    let action_item = Prefixed_Name(ru, "action_item") |> PrefixedName
    /// <summary>
    ///   <para>ru:alt_def</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An alternative definition. Usually the non-aristotelian natural language definition initially provided by domain specialists.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#alt_def">http://purl.org/imbi/ru-meta.owl#alt_def</seealso>
    let alt_def = Prefixed_Name(ru, "alt_def") |> PrefixedName
    /// <summary>
    ///   <para>ru:temp_def</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Indicates definitions which need to be refined.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#temp_def">http://purl.org/imbi/ru-meta.owl#temp_def</seealso>
    let temp_def = Prefixed_Name(ru, "temp_def") |> PrefixedName
    /// <summary>
    ///   <para>ru:change_note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A note that indicates what was modified or changed concerning the RU.
    /// Might become RU specific, i.e. cls_change_note AND prpty_change_note</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#change_note">http://purl.org/imbi/ru-meta.owl#change_note</seealso>
    let change_note = Prefixed_Name(ru, "change_note") |> PrefixedName
    /// <summary>
    ///   <para>ru:cls_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A unique Identifyer for the class, consisting of a groups prefix, underscore and unique number.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#cls_id">http://purl.org/imbi/ru-meta.owl#cls_id</seealso>
    let cls_id = Prefixed_Name(ru, "cls_id") |> PrefixedName
    /// <summary>
    ///   <para>ru:cls_prov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The class name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#cls_prov">http://purl.org/imbi/ru-meta.owl#cls_prov</seealso>
    let cls_prov = Prefixed_Name(ru, "cls_prov") |> PrefixedName
    /// <summary>
    ///   <para>ru:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A common accepted acronyn for the RU-name.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#acronym">http://purl.org/imbi/ru-meta.owl#acronym</seealso>
    let acronym = Prefixed_Name(ru, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>ru:axiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>General axioms to be fulfilled by instances of the class can be captured in an informal way in natural language here.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#axiom">http://purl.org/imbi/ru-meta.owl#axiom</seealso>
    let axiom = Prefixed_Name(ru, "axiom") |> PrefixedName
    /// <summary>
    ///   <para>ru:cls_del</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Allows to state the reason why a RU has been deleted.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#cls_del">http://purl.org/imbi/ru-meta.owl#cls_del</seealso>
    let cls_del = Prefixed_Name(ru, "cls_del") |> PrefixedName
    /// <summary>
    ///   <para>ru:cls_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Any name of the class. ??? Will change according to Synonym implementation...</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#cls_name">http://purl.org/imbi/ru-meta.owl#cls_name</seealso>
    let cls_name = Prefixed_Name(ru, "cls_name") |> PrefixedName
    /// <summary>
    ///   <para>ru:context_keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The main usage contexts can be stated, e.g. for text mining purposes or translation purposes.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#context_keyword">http://purl.org/imbi/ru-meta.owl#context_keyword</seealso>
    let context_keyword = Prefixed_Name(ru, "context_keyword") |> PrefixedName
    /// <summary>
    ///   <para>ru:alt_spr_cls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An alternative superclass assertion. Used to capture multiple parenthood.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#alt_spr_cls">http://purl.org/imbi/ru-meta.owl#alt_spr_cls</seealso>
    let alt_spr_cls = Prefixed_Name(ru, "alt_spr_cls") |> PrefixedName
    /// <summary>
    ///   <para>ru:creation_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The date when a RU was first created. (Will be provided automatically by Protege 4).</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#creation_date">http://purl.org/imbi/ru-meta.owl#creation_date</seealso>
    let creation_date = Prefixed_Name(ru, "creation_date") |> PrefixedName
    /// <summary>
    ///   <para>ru:def</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The arestotelian, formalized and normalized class definition layed out according to IFOMIS-best practice, explanaining the meaning of a class.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#def">http://purl.org/imbi/ru-meta.owl#def</seealso>
    let def = Prefixed_Name(ru, "def") |> PrefixedName
    /// <summary>
    ///   <para>ru:def_prov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The definition provenance (was: Defsource). It can be a source publication, a database or ontology entry, a group or person name or a URL (dbxref in obo)</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#def_prov">http://purl.org/imbi/ru-meta.owl#def_prov</seealso>
    let def_prov = Prefixed_Name(ru, "def_prov") |> PrefixedName
    /// <summary>
    ///   <para>ru:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The name of a specific editior/curator who is responsible for and edits this RU.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#editor">http://purl.org/imbi/ru-meta.owl#editor</seealso>
    let editor = Prefixed_Name(ru, "editor") |> PrefixedName
    /// <summary>
    ///   <para>ru:formal_cls_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A name for the class that is formaly controlled through linguistical rules and axioms. E.G. OBOL normalized ones that adhere to defined principles of word/morpheme/affix order and form. ???</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#formal_cls_name">http://purl.org/imbi/ru-meta.owl#formal_cls_name</seealso>
    let formal_cls_name = Prefixed_Name(ru, "formal_cls_name") |> PrefixedName
    /// <summary>
    ///   <para>ru:inst_expl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An example  value or instance for the class or Database entry which will be annotated through this RU.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#inst_expl">http://purl.org/imbi/ru-meta.owl#inst_expl</seealso>
    let inst_expl = Prefixed_Name(ru, "inst_expl") |> PrefixedName
    /// <summary>
    ///   <para>ru:old_spr_cls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>For deleted classes state their last position within the ontology, state the old superclasses.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#old_spr_cls">http://purl.org/imbi/ru-meta.owl#old_spr_cls</seealso>
    let old_spr_cls = Prefixed_Name(ru, "old_spr_cls") |> PrefixedName
    /// <summary>
    ///   <para>ru:pref_cls_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The preferred name for a class, usually the one used to display in the Hierarchy-browser. As now captured in the rdf:label ???</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#pref_cls_name">http://purl.org/imbi/ru-meta.owl#pref_cls_name</seealso>
    let pref_cls_name = Prefixed_Name(ru, "pref_cls_name") |> PrefixedName
    /// <summary>
    ///   <para>ru:prpty_del</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>State the reason why a property was deleted, analogously as for cla_del.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#prpty_del">http://purl.org/imbi/ru-meta.owl#prpty_del</seealso>
    let prpty_del = Prefixed_Name(ru, "prpty_del") |> PrefixedName
    /// <summary>
    ///   <para>ru:prpty_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A unique formal identifyer for the property, analogously to the cls_id.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#prpty_id">http://purl.org/imbi/ru-meta.owl#prpty_id</seealso>
    let prpty_id = Prefixed_Name(ru, "prpty_id") |> PrefixedName
    /// <summary>
    ///   <para>ru:prpty_prov</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The property name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#prpty_prov">http://purl.org/imbi/ru-meta.owl#prpty_prov</seealso>
    let prpty_prov = Prefixed_Name(ru, "prpty_prov") |> PrefixedName
    /// <summary>
    ///   <para>ru:replace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>When a new RU-name replaces an old one, state here which one was replaced. ???</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#replace">http://purl.org/imbi/ru-meta.owl#replace</seealso>
    let replace = Prefixed_Name(ru, "replace") |> PrefixedName
    /// <summary>
    ///   <para>ru:short_cls_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A short class name suitable for graph visualisations etc.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#short_cls_name">http://purl.org/imbi/ru-meta.owl#short_cls_name</seealso>
    let short_cls_name = Prefixed_Name(ru, "short_cls_name") |> PrefixedName
    /// <summary>
    ///   <para>ru:old_sub_cls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>For deleted classes state their last position within the ontology, state the old subclasses.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#old_sub_cls">http://purl.org/imbi/ru-meta.owl#old_sub_cls</seealso>
    let old_sub_cls = Prefixed_Name(ru, "old_sub_cls") |> PrefixedName
    /// <summary>
    ///   <para>ru:pref_propty_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The preferred name for a class, usually the one used to display in the Hierarchy-browser.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#pref_propty_name">http://purl.org/imbi/ru-meta.owl#pref_propty_name</seealso>
    let pref_propty_name = Prefixed_Name(ru, "pref_propty_name") |> PrefixedName
    /// <summary>
    ///   <para>ru:prpty_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A name of the property, analogously as a cls_name.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#prpty_name">http://purl.org/imbi/ru-meta.owl#prpty_name</seealso>
    let prpty_name = Prefixed_Name(ru, "prpty_name") |> PrefixedName
    /// <summary>
    ///   <para>ru:short_prpty_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A shortproperty name suitable for graph visualisations etc.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#short_prpty_name">http://purl.org/imbi/ru-meta.owl#short_prpty_name</seealso>
    let short_prpty_name = Prefixed_Name(ru, "short_prpty_name") |> PrefixedName
    /// <summary>
    ///   <para>ru:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>??? rel to ont_imp
    /// ??? rel to def_prov or cls_prov ?
    /// Do we need this separately for diff RUs? Eg. cls_src, prprty_src,…?</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#source">http://purl.org/imbi/ru-meta.owl#source</seealso>
    let source = Prefixed_Name(ru, "source") |> PrefixedName
    /// <summary>
    ///   <para>ru:unresolved_issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An important problematic issue that has to be tackled by the editors.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#unresolved_issue">http://purl.org/imbi/ru-meta.owl#unresolved_issue</seealso>
    let unresolved_issue = Prefixed_Name(ru, "unresolved_issue") |> PrefixedName
    /// <summary>
    ///   <para>ru:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Indicate access rights for a RU. The security policy should be compliant with the rule-based access control standards,INCITS, InterNational Committee for Information Technology Standards (formerly NCITS). (2003). Role Based Access Control. INCITS 359 DRAF, 4/4/2003. http://csrc.nist.gov/rbac/ Those offer, in at the same time, a consistent layered approach for security policy definition and management and for compliance with a growing set of supporting tools.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#rights">http://purl.org/imbi/ru-meta.owl#rights</seealso>
    let rights = Prefixed_Name(ru, "rights") |> PrefixedName
    /// <summary>
    ///   <para>ru:UMLS_connect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A link to a UMLS semantic Type CUI.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#UMLS_connect">http://purl.org/imbi/ru-meta.owl#UMLS_connect</seealso>
    let UMLS_connect = Prefixed_Name(ru, "UMLS_connect") |> PrefixedName
    /// <summary>
    ///   <para>ru:_inclusion_list</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This residual category holds yet to be classified (mass-)imported terms as a simple list.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#_inclusion_list">http://purl.org/imbi/ru-meta.owl#_inclusion_list</seealso>
    let _inclusion_list = Prefixed_Name(ru, "_inclusion_list") |> PrefixedName
    /// <summary>
    ///   <para>ru:editor_note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A note related to the RU intended for its editor.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#editor_note">http://purl.org/imbi/ru-meta.owl#editor_note</seealso>
    let editor_note = Prefixed_Name(ru, "editor_note") |> PrefixedName
    /// <summary>
    ///   <para>ru:old_cls_state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>State wheather a class was defined or primitive when deleted.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/imbi/ru-meta.owl#old_cls_state">http://purl.org/imbi/ru-meta.owl#old_cls_state</seealso>
    let old_cls_state = Prefixed_Name(ru, "old_cls_state") |> PrefixedName
