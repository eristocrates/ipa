#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ru =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/imbi/ru-meta.owl#" "ru"
    /// <summary>
    ///   <para>rdfs:comment : A link to a UMLS semantic Type CUI.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#UMLS_connect">ru:UMLS_connect</a>
    /// </summary>
    let UMLS_connect = _prefixId.prefix "UMLS_connect"
    /// <summary>
    ///   <para>rdfs:comment : This residual category holds deleted classes^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#_deleted">ru:_deleted</a>
    /// </summary>
    let _deleted = _prefixId.prefix "_deleted"
    /// <summary>
    ///   <para>rdfs:comment : This residual category holds yet to be classified (mass-)imported terms as a simple list.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#_inclusion_list">ru:_inclusion_list</a>
    /// </summary>
    let _inclusion_list = _prefixId.prefix "_inclusion_list"
    /// <summary>
    ///   <para>rdfs:comment : A temporal store for classes that are being worked on.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#_temp_orphan">ru:_temp_orphan</a>
    /// </summary>
    let _temp_orphan = _prefixId.prefix "_temp_orphan"
    /// <summary>
    ///   <para>rdfs:comment : A common accepted abbreviation for the RU-name. A word formed from the initials of one or more words describing the name, that is pronounceable like a normal word.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#abbrev">ru:abbrev</a>
    /// </summary>
    let abbrev = _prefixId.prefix "abbrev"
    /// <summary>
    ///   <para>rdfs:comment : A common accepted acronyn for the RU-name.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#acronym">ru:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>rdfs:comment : A description of a task / action for the RU editor to solve an issue related to the RU.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#action_item">ru:action_item</a>
    /// </summary>
    let action_item = _prefixId.prefix "action_item"
    /// <summary>
    ///   <para>rdfs:comment : An alternative definition. Usually the non-aristotelian natural language definition initially provided by domain specialists.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#alt_def">ru:alt_def</a>
    /// </summary>
    let alt_def = _prefixId.prefix "alt_def"
    /// <summary>
    ///   <para>rdfs:comment : An alternative superclass assertion. Used to capture multiple parenthood.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#alt_spr_cls">ru:alt_spr_cls</a>
    /// </summary>
    let alt_spr_cls = _prefixId.prefix "alt_spr_cls"
    /// <summary>
    ///   <para>rdfs:comment : General axioms to be fulfilled by instances of the class can be captured in an informal way in natural language here.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#axiom">ru:axiom</a>
    /// </summary>
    let axiom = _prefixId.prefix "axiom"
    /// <summary>
    ///   <para>rdfs:comment : A note that indicates what was modified or changed concerning the RU.
    /// Might become RU specific, i.e. cls_change_note AND prpty_change_note^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#change_note">ru:change_note</a>
    /// </summary>
    let change_note = _prefixId.prefix "change_note"
    /// <summary>
    ///   <para>rdfs:comment : Allows to state the reason why a RU has been deleted.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#cls_del">ru:cls_del</a>
    /// </summary>
    let cls_del = _prefixId.prefix "cls_del"
    /// <summary>
    ///   <para>rdfs:comment : A prototypical example subclass for the class.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#cls_expl">ru:cls_expl</a>
    /// </summary>
    let cls_expl = _prefixId.prefix "cls_expl"
    /// <summary>
    ///   <para>rdfs:comment : A unique Identifyer for the class, consisting of a groups prefix, underscore and unique number.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#cls_id">ru:cls_id</a>
    /// </summary>
    let cls_id = _prefixId.prefix "cls_id"
    /// <summary>
    ///   <para>rdfs:comment : Any name of the class. ??? Will change according to Synonym implementation...^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#cls_name">ru:cls_name</a>
    /// </summary>
    let cls_name = _prefixId.prefix "cls_name"
    /// <summary>
    ///   <para>rdfs:comment : The class name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#cls_prov">ru:cls_prov</a>
    /// </summary>
    let cls_prov = _prefixId.prefix "cls_prov"
    /// <summary>
    ///   <para>rdfs:comment : The main usage contexts can be stated, e.g. for text mining purposes or translation purposes.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#context_keyword">ru:context_keyword</a>
    /// </summary>
    let context_keyword = _prefixId.prefix "context_keyword"
    /// <summary>
    ///   <para>rdfs:comment : The date when a RU was first created. (Will be provided automatically by Protege 4).^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#creation_date">ru:creation_date</a>
    /// </summary>
    let creation_date = _prefixId.prefix "creation_date"
    /// <summary>
    ///   <para>rdfs:comment : The status (stability level) of the class. Specifies tracking information. E.g. unstable, experimental, stable.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#curation_status">ru:curation_status</a>
    /// </summary>
    let curation_status = _prefixId.prefix "curation_status"
    /// <summary>
    ///   <para>rdfs:comment : The arestotelian, formalized and normalized class definition layed out according to IFOMIS-best practice, explanaining the meaning of a class.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#def">ru:def</a>
    /// </summary>
    let def = _prefixId.prefix "def"
    /// <summary>
    ///   <para>rdfs:comment : The definition provenance (was: Defsource). It can be a source publication, a database or ontology entry, a group or person name or a URL (dbxref in obo)^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#def_prov">ru:def_prov</a>
    /// </summary>
    let def_prov = _prefixId.prefix "def_prov"
    /// <summary>
    ///   <para>rdfs:comment : The date a RU was deleted.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#del_date">ru:del_date</a>
    /// </summary>
    let del_date = _prefixId.prefix "del_date"
    /// <summary>
    ///   <para>rdfs:comment : The name of a specific editior/curator who is responsible for and edits this RU.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#editor">ru:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:comment : A note related to the RU intended for its editor.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#editor_note">ru:editor_note</a>
    /// </summary>
    let editor_note = _prefixId.prefix "editor_note"
    /// <summary>
    ///   <para>rdfs:comment : A name for the class that is formaly controlled through linguistical rules and axioms. E.G. OBOL normalized ones that adhere to defined principles of word/morpheme/affix order and form. ???^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#formal_cls_name">ru:formal_cls_name</a>
    /// </summary>
    let formal_cls_name = _prefixId.prefix "formal_cls_name"
    /// <summary>
    ///   <para>rdfs:comment : An example  value or instance for the class or Database entry which will be annotated through this RU.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#inst_expl">ru:inst_expl</a>
    /// </summary>
    let inst_expl = _prefixId.prefix "inst_expl"
    /// <summary>
    ///   <para>rdfs:comment : The date on which the RU was last modified.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#modif_date">ru:modif_date</a>
    /// </summary>
    let modif_date = _prefixId.prefix "modif_date"
    /// <summary>
    ///   <para>rdfs:comment : State wheather a class was defined or primitive when deleted.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#old_cls_state">ru:old_cls_state</a>
    /// </summary>
    let old_cls_state = _prefixId.prefix "old_cls_state"
    /// <summary>
    ///   <para>rdfs:comment : For deleted classes state their last position within the ontology, state the old superclasses.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#old_spr_cls">ru:old_spr_cls</a>
    /// </summary>
    let old_spr_cls = _prefixId.prefix "old_spr_cls"
    /// <summary>
    ///   <para>rdfs:comment : For deleted classes state their last position within the ontology, state the old subclasses.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#old_sub_cls">ru:old_sub_cls</a>
    /// </summary>
    let old_sub_cls = _prefixId.prefix "old_sub_cls"
    /// <summary>
    ///   <para>rdfs:comment : To mark from where on in the Class-hierarchy we want to import / refer to a complete subclass hierarchy from an other ontology (was: refer to) ??? Maybe better: cls_imp^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#ont_imp">ru:ont_imp</a>
    /// </summary>
    let ont_imp = _prefixId.prefix "ont_imp"
    /// <summary>
    ///   <para>rdfs:comment : The preferred name for a class, usually the one used to display in the Hierarchy-browser. As now captured in the rdf:label ???^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#pref_cls_name">ru:pref_cls_name</a>
    /// </summary>
    let pref_cls_name = _prefixId.prefix "pref_cls_name"
    /// <summary>
    ///   <para>rdfs:comment : The preferred name for a class, usually the one used to display in the Hierarchy-browser.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#pref_propty_name">ru:pref_propty_name</a>
    /// </summary>
    let pref_propty_name = _prefixId.prefix "pref_propty_name"
    /// <summary>
    ///   <para>rdfs:comment : State the reason why a property was deleted, analogously as for cla_del.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#prpty_del">ru:prpty_del</a>
    /// </summary>
    let prpty_del = _prefixId.prefix "prpty_del"
    /// <summary>
    ///   <para>rdfs:comment : A prototypic example od a sub-property of this property )when property hierarchies are allowed.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#prpty_expl">ru:prpty_expl</a>
    /// </summary>
    let prpty_expl = _prefixId.prefix "prpty_expl"
    /// <summary>
    ///   <para>rdfs:comment : A unique formal identifyer for the property, analogously to the cls_id.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#prpty_id">ru:prpty_id</a>
    /// </summary>
    let prpty_id = _prefixId.prefix "prpty_id"
    /// <summary>
    ///   <para>rdfs:comment : A name of the property, analogously as a cls_name.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#prpty_name">ru:prpty_name</a>
    /// </summary>
    let prpty_name = _prefixId.prefix "prpty_name"
    /// <summary>
    ///   <para>rdfs:comment : The property name provenance. It can be a source publication, a database or ontology entry, a group,  person name or a URL (dbxref in obo)
    /// A database cross reference. ???^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#prpty_prov">ru:prpty_prov</a>
    /// </summary>
    let prpty_prov = _prefixId.prefix "prpty_prov"
    /// <summary>
    ///   <para>rdfs:comment : When a class has been refactored into more atomic classes, then the original compound class is made obsolete and this deleted source class which gave birth to the new atomic child classes is mentioned here for all new atomic classes.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#refact">ru:refact</a>
    /// </summary>
    let refact = _prefixId.prefix "refact"
    /// <summary>
    ///   <para>rdfs:comment : When a new RU-name replaces an old one, state here which one was replaced. ???^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#replace">ru:replace</a>
    /// </summary>
    let replace = _prefixId.prefix "replace"
    /// <summary>
    ///   <para>rdfs:comment : Indicate access rights for a RU. The security policy should be compliant with the rule-based access control standards,INCITS, InterNational Committee for Information Technology Standards (formerly NCITS). (2003). Role Based Access Control. INCITS 359 DRAF, 4/4/2003. http://csrc.nist.gov/rbac/ Those offer, in at the same time, a consistent layered approach for security policy definition and management and for compliance with a growing set of supporting tools.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#rights">ru:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>rdfs:comment : Any general formless remark or note about the scope of the RU (was: rem, note).^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#scope_note">ru:scope_note</a>
    /// </summary>
    let scope_note = _prefixId.prefix "scope_note"
    /// <summary>
    ///   <para>rdfs:comment : A short class name suitable for graph visualisations etc.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#short_cls_name">ru:short_cls_name</a>
    /// </summary>
    let short_cls_name = _prefixId.prefix "short_cls_name"
    /// <summary>
    ///   <para>rdfs:comment : A shortproperty name suitable for graph visualisations etc.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#short_prpty_name">ru:short_prpty_name</a>
    /// </summary>
    let short_prpty_name = _prefixId.prefix "short_prpty_name"
    /// <summary>
    ///   <para>rdfs:comment : ??? rel to ont_imp
    /// ??? rel to def_prov or cls_prov ?
    /// Do we need this separately for diff RUs? Eg. cls_src, prprty_src,…?^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#source">ru:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:comment : An alternative name for the RU used as synonym (can be used in the same manner as the name in different contexts).^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#synonym">ru:synonym</a>
    /// </summary>
    let synonym = _prefixId.prefix "synonym"
    /// <summary>
    ///   <para>rdfs:comment : Indicates definitions which need to be refined.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#temp_def">ru:temp_def</a>
    /// </summary>
    let temp_def = _prefixId.prefix "temp_def"
    /// <summary>
    ///   <para>rdfs:comment : An important problematic issue that has to be tackled by the editors.^^xsd:string</para>
    ///   <a href="http://purl.org/imbi/ru-meta.owl#unresolved_issue">ru:unresolved_issue</a>
    /// </summary>
    let unresolved_issue = _prefixId.prefix "unresolved_issue"
