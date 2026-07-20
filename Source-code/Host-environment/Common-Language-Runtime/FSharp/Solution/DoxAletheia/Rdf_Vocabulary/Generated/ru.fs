namespace http.purl.org.imbi.ru_meta.owl.hash

open DoxAletheia

module ru =
    let _namespace_name = "http://purl.org/imbi/ru-meta.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A link to a UMLS semantic Type CUI.
    /// <see href="http://purl.org/imbi/ru-meta.owl#UMLS_connect"></see></summary>
    let UMLS_connect = _prefix "UMLS_connect"
    /// <summary>
    /// This residual category holds deleted classes
    /// <see href="http://purl.org/imbi/ru-meta.owl#_deleted"></see></summary>
    let _deleted = _prefix "_deleted"
    /// <summary>
    /// This residual category holds yet to be classified (mass-)imported terms as a simple list.
    /// <see href="http://purl.org/imbi/ru-meta.owl#_inclusion_list"></see></summary>
    let _inclusion_list = _prefix "_inclusion_list"
    /// <summary>
    /// A temporal store for classes that are being worked on.
    /// <see href="http://purl.org/imbi/ru-meta.owl#_temp_orphan"></see></summary>
    let _temp_orphan = _prefix "_temp_orphan"
    /// <summary>
    /// A common accepted abbreviation for the RU-name. A word formed from the initials of one or more words describing the name, that is pronounceable like a normal word.
    /// <see href="http://purl.org/imbi/ru-meta.owl#abbrev"></see></summary>
    let abbrev = _prefix "abbrev"
    /// <summary>
    /// A common accepted acronyn for the RU-name.
    /// <see href="http://purl.org/imbi/ru-meta.owl#acronym"></see></summary>
    let acronym = _prefix "acronym"
    /// <summary>
    /// A description of a task / action for the RU editor to solve an issue related to the RU.
    /// <see href="http://purl.org/imbi/ru-meta.owl#action_item"></see></summary>
    let action_item = _prefix "action_item"
    /// <summary>
    /// An alternative definition. Usually the non-aristotelian natural language definition initially provided by domain specialists.
    /// <see href="http://purl.org/imbi/ru-meta.owl#alt_def"></see></summary>
    let alt_def = _prefix "alt_def"
    /// <summary>
    /// An alternative superclass assertion. Used to capture multiple parenthood.
    /// <see href="http://purl.org/imbi/ru-meta.owl#alt_spr_cls"></see></summary>
    let alt_spr_cls = _prefix "alt_spr_cls"
    /// <summary>
    /// General axioms to be fulfilled by instances of the class can be captured in an informal way in natural language here.
    /// <see href="http://purl.org/imbi/ru-meta.owl#axiom"></see></summary>
    let axiom = _prefix "axiom"
    /// <summary>
    /// A note that indicates what was modified or changed concerning the RU.
    /// Might become RU specific, i.e. cls_change_note AND prpty_change_note
    /// <see href="http://purl.org/imbi/ru-meta.owl#change_note"></see></summary>
    let change_note = _prefix "change_note"
    /// <summary>
    /// Allows to state the reason why a RU has been deleted.
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_del"></see></summary>
    let cls_del = _prefix "cls_del"
    /// <summary>
    /// A prototypical example subclass for the class.
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_expl"></see></summary>
    let cls_expl = _prefix "cls_expl"
    /// <summary>
    /// A unique Identifyer for the class, consisting of a groups prefix, underscore and unique number.
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_id"></see></summary>
    let cls_id = _prefix "cls_id"
    /// <summary>
    /// Any name of the class. ??? Will change according to Synonym implementation...
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_name"></see></summary>
    let cls_name = _prefix "cls_name"
    /// <summary>
    /// The class name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_prov"></see></summary>
    let cls_prov = _prefix "cls_prov"
    /// <summary>
    /// The main usage contexts can be stated, e.g. for text mining purposes or translation purposes.
    /// <see href="http://purl.org/imbi/ru-meta.owl#context_keyword"></see></summary>
    let context_keyword = _prefix "context_keyword"
    /// <summary>
    /// The date when a RU was first created. (Will be provided automatically by Protege 4).
    /// <see href="http://purl.org/imbi/ru-meta.owl#creation_date"></see></summary>
    let creation_date = _prefix "creation_date"
    /// <summary>
    /// The status (stability level) of the class. Specifies tracking information. E.g. unstable, experimental, stable.
    /// <see href="http://purl.org/imbi/ru-meta.owl#curation_status"></see></summary>
    let curation_status = _prefix "curation_status"
    /// <summary>
    /// The arestotelian, formalized and normalized class definition layed out according to IFOMIS-best practice, explanaining the meaning of a class.
    /// <see href="http://purl.org/imbi/ru-meta.owl#def"></see></summary>
    let def = _prefix "def"
    /// <summary>
    /// The definition provenance (was: Defsource). It can be a source publication, a database or ontology entry, a group or person name or a URL (dbxref in obo)
    /// <see href="http://purl.org/imbi/ru-meta.owl#def_prov"></see></summary>
    let def_prov = _prefix "def_prov"
    /// <summary>
    /// The date a RU was deleted.
    /// <see href="http://purl.org/imbi/ru-meta.owl#del_date"></see></summary>
    let del_date = _prefix "del_date"
    /// <summary>
    /// The name of a specific editior/curator who is responsible for and edits this RU.
    /// <see href="http://purl.org/imbi/ru-meta.owl#editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// A note related to the RU intended for its editor.
    /// <see href="http://purl.org/imbi/ru-meta.owl#editor_note"></see></summary>
    let editor_note = _prefix "editor_note"
    /// <summary>
    /// A name for the class that is formaly controlled through linguistical rules and axioms. E.G. OBOL normalized ones that adhere to defined principles of word/morpheme/affix order and form. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#formal_cls_name"></see></summary>
    let formal_cls_name = _prefix "formal_cls_name"
    /// <summary>
    /// An example  value or instance for the class or Database entry which will be annotated through this RU.
    /// <see href="http://purl.org/imbi/ru-meta.owl#inst_expl"></see></summary>
    let inst_expl = _prefix "inst_expl"
    /// <summary>
    /// The date on which the RU was last modified.
    /// <see href="http://purl.org/imbi/ru-meta.owl#modif_date"></see></summary>
    let modif_date = _prefix "modif_date"
    /// <summary>
    /// State wheather a class was defined or primitive when deleted.
    /// <see href="http://purl.org/imbi/ru-meta.owl#old_cls_state"></see></summary>
    let old_cls_state = _prefix "old_cls_state"
    /// <summary>
    /// For deleted classes state their last position within the ontology, state the old superclasses.
    /// <see href="http://purl.org/imbi/ru-meta.owl#old_spr_cls"></see></summary>
    let old_spr_cls = _prefix "old_spr_cls"
    /// <summary>
    /// For deleted classes state their last position within the ontology, state the old subclasses.
    /// <see href="http://purl.org/imbi/ru-meta.owl#old_sub_cls"></see></summary>
    let old_sub_cls = _prefix "old_sub_cls"
    /// <summary>
    /// To mark from where on in the Class-hierarchy we want to import / refer to a complete subclass hierarchy from an other ontology (was: refer to) ??? Maybe better: cls_imp
    /// <see href="http://purl.org/imbi/ru-meta.owl#ont_imp"></see></summary>
    let ont_imp = _prefix "ont_imp"
    /// <summary>
    /// The preferred name for a class, usually the one used to display in the Hierarchy-browser. As now captured in the rdf:label ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#pref_cls_name"></see></summary>
    let pref_cls_name = _prefix "pref_cls_name"
    /// <summary>
    /// The preferred name for a class, usually the one used to display in the Hierarchy-browser.
    /// <see href="http://purl.org/imbi/ru-meta.owl#pref_propty_name"></see></summary>
    let pref_propty_name = _prefix "pref_propty_name"
    /// <summary>
    /// State the reason why a property was deleted, analogously as for cla_del.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_del"></see></summary>
    let prpty_del = _prefix "prpty_del"
    /// <summary>
    /// A prototypic example od a sub-property of this property )when property hierarchies are allowed.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_expl"></see></summary>
    let prpty_expl = _prefix "prpty_expl"
    /// <summary>
    /// A unique formal identifyer for the property, analogously to the cls_id.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_id"></see></summary>
    let prpty_id = _prefix "prpty_id"
    /// <summary>
    /// A name of the property, analogously as a cls_name.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_name"></see></summary>
    let prpty_name = _prefix "prpty_name"
    /// <summary>
    /// The property name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_prov"></see></summary>
    let prpty_prov = _prefix "prpty_prov"
    /// <summary>
    /// When a class has been refactored into more atomic classes, then the original compound class is made obsolete and this deleted source class which gave birth to the new atomic child classes is mentioned here for all new atomic classes.
    /// <see href="http://purl.org/imbi/ru-meta.owl#refact"></see></summary>
    let refact = _prefix "refact"
    /// <summary>
    /// When a new RU-name replaces an old one, state here which one was replaced. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#replace"></see></summary>
    let replace = _prefix "replace"
    /// <summary>
    /// Indicate access rights for a RU. The security policy should be compliant with the rule-based access control standards,INCITS, InterNational Committee for Information Technology Standards (formerly NCITS). (2003). Role Based Access Control. INCITS 359 DRAF, 4/4/2003. http://csrc.nist.gov/rbac/ Those offer, in at the same time, a consistent layered approach for security policy definition and management and for compliance with a growing set of supporting tools.
    /// <see href="http://purl.org/imbi/ru-meta.owl#rights"></see></summary>
    let rights = _prefix "rights"
    /// <summary>
    /// Any general formless remark or note about the scope of the RU (was: rem, note).
    /// <see href="http://purl.org/imbi/ru-meta.owl#scope_note"></see></summary>
    let scope_note = _prefix "scope_note"
    /// <summary>
    /// A short class name suitable for graph visualisations etc.
    /// <see href="http://purl.org/imbi/ru-meta.owl#short_cls_name"></see></summary>
    let short_cls_name = _prefix "short_cls_name"
    /// <summary>
    /// A shortproperty name suitable for graph visualisations etc.
    /// <see href="http://purl.org/imbi/ru-meta.owl#short_prpty_name"></see></summary>
    let short_prpty_name = _prefix "short_prpty_name"
    /// <summary>
    /// ??? rel to ont_imp
    /// ??? rel to def_prov or cls_prov ?
    /// Do we need this separately for diff RUs? Eg. cls_src, prprty_src,…?
    /// <see href="http://purl.org/imbi/ru-meta.owl#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// An alternative name for the RU used as synonym (can be used in the same manner as the name in different contexts).
    /// <see href="http://purl.org/imbi/ru-meta.owl#synonym"></see></summary>
    let synonym = _prefix "synonym"
    /// <summary>
    /// Indicates definitions which need to be refined.
    /// <see href="http://purl.org/imbi/ru-meta.owl#temp_def"></see></summary>
    let temp_def = _prefix "temp_def"
    /// <summary>
    /// An important problematic issue that has to be tackled by the editors.
    /// <see href="http://purl.org/imbi/ru-meta.owl#unresolved_issue"></see></summary>
    let unresolved_issue = _prefix "unresolved_issue"
