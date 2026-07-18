namespace http.purl.org.imbi.ru_meta.owl.hash

open DoxAletheia.Rdf_Vocabulary

module ru =
    let _namespace_name = "http://purl.org/imbi/ru-meta.owl#"

    /// <summary>
    /// A link to a UMLS semantic Type CUI.
    /// <see href="http://purl.org/imbi/ru-meta.owl#UMLS_connect"></see></summary>
    let UMLS_connect =
        Namespaced_IRI.parse _namespace_name "UMLS_connect" |> NamespacedName

    /// <summary>
    /// This residual category holds deleted classes
    /// <see href="http://purl.org/imbi/ru-meta.owl#_deleted"></see></summary>
    let _deleted = Namespaced_IRI.parse _namespace_name "_deleted" |> NamespacedName

    /// <summary>
    /// This residual category holds yet to be classified (mass-)imported terms as a simple list.
    /// <see href="http://purl.org/imbi/ru-meta.owl#_inclusion_list"></see></summary>
    let _inclusion_list =
        Namespaced_IRI.parse _namespace_name "_inclusion_list" |> NamespacedName

    /// <summary>
    /// A temporal store for classes that are being worked on.
    /// <see href="http://purl.org/imbi/ru-meta.owl#_temp_orphan"></see></summary>
    let _temp_orphan =
        Namespaced_IRI.parse _namespace_name "_temp_orphan" |> NamespacedName

    /// <summary>
    /// A common accepted abbreviation for the RU-name. A word formed from the initials of one or more words describing the name, that is pronounceable like a normal word.
    /// <see href="http://purl.org/imbi/ru-meta.owl#abbrev"></see></summary>
    let abbrev = Namespaced_IRI.parse _namespace_name "abbrev" |> NamespacedName
    /// <summary>
    /// A common accepted acronyn for the RU-name.
    /// <see href="http://purl.org/imbi/ru-meta.owl#acronym"></see></summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName

    /// <summary>
    /// A description of a task / action for the RU editor to solve an issue related to the RU.
    /// <see href="http://purl.org/imbi/ru-meta.owl#action_item"></see></summary>
    let action_item =
        Namespaced_IRI.parse _namespace_name "action_item" |> NamespacedName

    /// <summary>
    /// An alternative definition. Usually the non-aristotelian natural language definition initially provided by domain specialists.
    /// <see href="http://purl.org/imbi/ru-meta.owl#alt_def"></see></summary>
    let alt_def = Namespaced_IRI.parse _namespace_name "alt_def" |> NamespacedName

    /// <summary>
    /// An alternative superclass assertion. Used to capture multiple parenthood.
    /// <see href="http://purl.org/imbi/ru-meta.owl#alt_spr_cls"></see></summary>
    let alt_spr_cls =
        Namespaced_IRI.parse _namespace_name "alt_spr_cls" |> NamespacedName

    /// <summary>
    /// General axioms to be fulfilled by instances of the class can be captured in an informal way in natural language here.
    /// <see href="http://purl.org/imbi/ru-meta.owl#axiom"></see></summary>
    let axiom = Namespaced_IRI.parse _namespace_name "axiom" |> NamespacedName

    /// <summary>
    /// A note that indicates what was modified or changed concerning the RU.
    /// Might become RU specific, i.e. cls_change_note AND prpty_change_note
    /// <see href="http://purl.org/imbi/ru-meta.owl#change_note"></see></summary>
    let change_note =
        Namespaced_IRI.parse _namespace_name "change_note" |> NamespacedName

    /// <summary>
    /// Allows to state the reason why a RU has been deleted.
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_del"></see></summary>
    let cls_del = Namespaced_IRI.parse _namespace_name "cls_del" |> NamespacedName
    /// <summary>
    /// A prototypical example subclass for the class.
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_expl"></see></summary>
    let cls_expl = Namespaced_IRI.parse _namespace_name "cls_expl" |> NamespacedName
    /// <summary>
    /// A unique Identifyer for the class, consisting of a groups prefix, underscore and unique number.
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_id"></see></summary>
    let cls_id = Namespaced_IRI.parse _namespace_name "cls_id" |> NamespacedName
    /// <summary>
    /// Any name of the class. ??? Will change according to Synonym implementation...
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_name"></see></summary>
    let cls_name = Namespaced_IRI.parse _namespace_name "cls_name" |> NamespacedName
    /// <summary>
    /// The class name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#cls_prov"></see></summary>
    let cls_prov = Namespaced_IRI.parse _namespace_name "cls_prov" |> NamespacedName

    /// <summary>
    /// The main usage contexts can be stated, e.g. for text mining purposes or translation purposes.
    /// <see href="http://purl.org/imbi/ru-meta.owl#context_keyword"></see></summary>
    let context_keyword =
        Namespaced_IRI.parse _namespace_name "context_keyword" |> NamespacedName

    /// <summary>
    /// The date when a RU was first created. (Will be provided automatically by Protege 4).
    /// <see href="http://purl.org/imbi/ru-meta.owl#creation_date"></see></summary>
    let creation_date =
        Namespaced_IRI.parse _namespace_name "creation_date" |> NamespacedName

    /// <summary>
    /// The status (stability level) of the class. Specifies tracking information. E.g. unstable, experimental, stable.
    /// <see href="http://purl.org/imbi/ru-meta.owl#curation_status"></see></summary>
    let curation_status =
        Namespaced_IRI.parse _namespace_name "curation_status" |> NamespacedName

    /// <summary>
    /// The arestotelian, formalized and normalized class definition layed out according to IFOMIS-best practice, explanaining the meaning of a class.
    /// <see href="http://purl.org/imbi/ru-meta.owl#def"></see></summary>
    let def = Namespaced_IRI.parse _namespace_name "def" |> NamespacedName
    /// <summary>
    /// The definition provenance (was: Defsource). It can be a source publication, a database or ontology entry, a group or person name or a URL (dbxref in obo)
    /// <see href="http://purl.org/imbi/ru-meta.owl#def_prov"></see></summary>
    let def_prov = Namespaced_IRI.parse _namespace_name "def_prov" |> NamespacedName
    /// <summary>
    /// The date a RU was deleted.
    /// <see href="http://purl.org/imbi/ru-meta.owl#del_date"></see></summary>
    let del_date = Namespaced_IRI.parse _namespace_name "del_date" |> NamespacedName
    /// <summary>
    /// The name of a specific editior/curator who is responsible for and edits this RU.
    /// <see href="http://purl.org/imbi/ru-meta.owl#editor"></see></summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName

    /// <summary>
    /// A note related to the RU intended for its editor.
    /// <see href="http://purl.org/imbi/ru-meta.owl#editor_note"></see></summary>
    let editor_note =
        Namespaced_IRI.parse _namespace_name "editor_note" |> NamespacedName

    /// <summary>
    /// A name for the class that is formaly controlled through linguistical rules and axioms. E.G. OBOL normalized ones that adhere to defined principles of word/morpheme/affix order and form. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#formal_cls_name"></see></summary>
    let formal_cls_name =
        Namespaced_IRI.parse _namespace_name "formal_cls_name" |> NamespacedName

    /// <summary>
    /// An example  value or instance for the class or Database entry which will be annotated through this RU.
    /// <see href="http://purl.org/imbi/ru-meta.owl#inst_expl"></see></summary>
    let inst_expl = Namespaced_IRI.parse _namespace_name "inst_expl" |> NamespacedName
    /// <summary>
    /// The date on which the RU was last modified.
    /// <see href="http://purl.org/imbi/ru-meta.owl#modif_date"></see></summary>
    let modif_date = Namespaced_IRI.parse _namespace_name "modif_date" |> NamespacedName

    /// <summary>
    /// State wheather a class was defined or primitive when deleted.
    /// <see href="http://purl.org/imbi/ru-meta.owl#old_cls_state"></see></summary>
    let old_cls_state =
        Namespaced_IRI.parse _namespace_name "old_cls_state" |> NamespacedName

    /// <summary>
    /// For deleted classes state their last position within the ontology, state the old superclasses.
    /// <see href="http://purl.org/imbi/ru-meta.owl#old_spr_cls"></see></summary>
    let old_spr_cls =
        Namespaced_IRI.parse _namespace_name "old_spr_cls" |> NamespacedName

    /// <summary>
    /// For deleted classes state their last position within the ontology, state the old subclasses.
    /// <see href="http://purl.org/imbi/ru-meta.owl#old_sub_cls"></see></summary>
    let old_sub_cls =
        Namespaced_IRI.parse _namespace_name "old_sub_cls" |> NamespacedName

    /// <summary>
    /// To mark from where on in the Class-hierarchy we want to import / refer to a complete subclass hierarchy from an other ontology (was: refer to) ??? Maybe better: cls_imp
    /// <see href="http://purl.org/imbi/ru-meta.owl#ont_imp"></see></summary>
    let ont_imp = Namespaced_IRI.parse _namespace_name "ont_imp" |> NamespacedName

    /// <summary>
    /// The preferred name for a class, usually the one used to display in the Hierarchy-browser. As now captured in the rdf:label ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#pref_cls_name"></see></summary>
    let pref_cls_name =
        Namespaced_IRI.parse _namespace_name "pref_cls_name" |> NamespacedName

    /// <summary>
    /// The preferred name for a class, usually the one used to display in the Hierarchy-browser.
    /// <see href="http://purl.org/imbi/ru-meta.owl#pref_propty_name"></see></summary>
    let pref_propty_name =
        Namespaced_IRI.parse _namespace_name "pref_propty_name" |> NamespacedName

    /// <summary>
    /// State the reason why a property was deleted, analogously as for cla_del.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_del"></see></summary>
    let prpty_del = Namespaced_IRI.parse _namespace_name "prpty_del" |> NamespacedName
    /// <summary>
    /// A prototypic example od a sub-property of this property )when property hierarchies are allowed.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_expl"></see></summary>
    let prpty_expl = Namespaced_IRI.parse _namespace_name "prpty_expl" |> NamespacedName
    /// <summary>
    /// A unique formal identifyer for the property, analogously to the cls_id.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_id"></see></summary>
    let prpty_id = Namespaced_IRI.parse _namespace_name "prpty_id" |> NamespacedName
    /// <summary>
    /// A name of the property, analogously as a cls_name.
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_name"></see></summary>
    let prpty_name = Namespaced_IRI.parse _namespace_name "prpty_name" |> NamespacedName
    /// <summary>
    /// The property name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#prpty_prov"></see></summary>
    let prpty_prov = Namespaced_IRI.parse _namespace_name "prpty_prov" |> NamespacedName
    /// <summary>
    /// When a class has been refactored into more atomic classes, then the original compound class is made obsolete and this deleted source class which gave birth to the new atomic child classes is mentioned here for all new atomic classes.
    /// <see href="http://purl.org/imbi/ru-meta.owl#refact"></see></summary>
    let refact = Namespaced_IRI.parse _namespace_name "refact" |> NamespacedName
    /// <summary>
    /// When a new RU-name replaces an old one, state here which one was replaced. ???
    /// <see href="http://purl.org/imbi/ru-meta.owl#replace"></see></summary>
    let replace = Namespaced_IRI.parse _namespace_name "replace" |> NamespacedName
    /// <summary>
    /// Indicate access rights for a RU. The security policy should be compliant with the rule-based access control standards,INCITS, InterNational Committee for Information Technology Standards (formerly NCITS). (2003). Role Based Access Control. INCITS 359 DRAF, 4/4/2003. http://csrc.nist.gov/rbac/ Those offer, in at the same time, a consistent layered approach for security policy definition and management and for compliance with a growing set of supporting tools.
    /// <see href="http://purl.org/imbi/ru-meta.owl#rights"></see></summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName
    /// <summary>
    /// Any general formless remark or note about the scope of the RU (was: rem, note).
    /// <see href="http://purl.org/imbi/ru-meta.owl#scope_note"></see></summary>
    let scope_note = Namespaced_IRI.parse _namespace_name "scope_note" |> NamespacedName

    /// <summary>
    /// A short class name suitable for graph visualisations etc.
    /// <see href="http://purl.org/imbi/ru-meta.owl#short_cls_name"></see></summary>
    let short_cls_name =
        Namespaced_IRI.parse _namespace_name "short_cls_name" |> NamespacedName

    /// <summary>
    /// A shortproperty name suitable for graph visualisations etc.
    /// <see href="http://purl.org/imbi/ru-meta.owl#short_prpty_name"></see></summary>
    let short_prpty_name =
        Namespaced_IRI.parse _namespace_name "short_prpty_name" |> NamespacedName

    /// <summary>
    /// ??? rel to ont_imp
    /// ??? rel to def_prov or cls_prov ?
    /// Do we need this separately for diff RUs? Eg. cls_src, prprty_src,…?
    /// <see href="http://purl.org/imbi/ru-meta.owl#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// An alternative name for the RU used as synonym (can be used in the same manner as the name in different contexts).
    /// <see href="http://purl.org/imbi/ru-meta.owl#synonym"></see></summary>
    let synonym = Namespaced_IRI.parse _namespace_name "synonym" |> NamespacedName
    /// <summary>
    /// Indicates definitions which need to be refined.
    /// <see href="http://purl.org/imbi/ru-meta.owl#temp_def"></see></summary>
    let temp_def = Namespaced_IRI.parse _namespace_name "temp_def" |> NamespacedName

    /// <summary>
    /// An important problematic issue that has to be tackled by the editors.
    /// <see href="http://purl.org/imbi/ru-meta.owl#unresolved_issue"></see></summary>
    let unresolved_issue =
        Namespaced_IRI.parse _namespace_name "unresolved_issue" |> NamespacedName
