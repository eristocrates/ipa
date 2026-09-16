#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module openwemi =
    let _prefixId = PrefixId.fromNamespaceLabel "https://ns.dublincore.org/openwemi/" "openwemi"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Endeavor</para>
    ///   <para>rdfs:comment : A creation.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/Endeavor">openwemi:Endeavor</a>
    /// </summary>
    let Endeavor = _prefixId.prefix "Endeavor"
    /// <summary>
    ///   <para>rdfs:label : Expression</para>
    ///   <para>rdfs:comment : A perceivable form of the creation.</para>
    ///   <para>dcterms:description : Endeavors are made tangible through some kind of expression, such as text, sound, or a visual form. There may be more than one expression of a work of the same type or of different types.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/Expression">openwemi:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : An exemplar of a creation.</para>
    ///   <para>dcterms:description : An Item is a single instance of an Endeavor, something that can have a place on a shelf or a location online.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/Item">openwemi:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Manifestation</para>
    ///   <para>rdfs:comment : The physical embodiment of a creation.</para>
    ///   <para>dcterms:description : A manifestation is an Endeavor that has been realized in some physical or digital form. A manifestation may be a single realization or a realization that is produced in multiple copies such as the publication of a music compact disk or the manufacture of a shirt.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/Manifestation">openwemi:Manifestation</a>
    /// </summary>
    let Manifestation = _prefixId.prefix "Manifestation"
    /// <summary>
    ///   <para>rdfs:label : Work</para>
    ///   <para>rdfs:comment : An abstract notion of an artistic or intellectual creation.</para>
    ///   <para>dcterms:description : A work is an abstraction that represents the concepts behind an Endeavor. Each metadata community will have a different definition of Work, but it should be the broadest definition of the Endeavors being described.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/Work">openwemi:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : common Endeavor</para>
    ///   <para>rdfs:comment : Relates any two resources that are or contain the same endeavor.^^xsd:string</para>
    ///   <para>dcterms:description : commonEndeavour is intended to define a relationship between two resources that may or may not be modeled as OpenWEMI. This makes it possible to assert that a resource modeled using a vocabulary that does not use the  entity model explicitly is describing the same Work, Expression, Manifestation, and/or Item as another resource.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/commonEndeavor">openwemi:commonEndeavor</a>
    /// </summary>
    let commonEndeavor = _prefixId.prefix "commonEndeavor"
    /// <summary>
    ///   <para>rdfs:label : common Expression</para>
    ///   <para>rdfs:comment : Relates any two resources that are or contain the same Expression.^^xsd:string</para>
    ///   <para>dcterms:description : commonExpression is intended to define a relationship between two resources that may or may not be modeled as OpenWEMI. This makes it possible to assert that a resource modeled using a vocabulary that does not use the OpenWEMI entity model explicitly is describing the Expression as another resource.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/commonExpression">openwemi:commonExpression</a>
    /// </summary>
    let commonExpression = _prefixId.prefix "commonExpression"
    /// <summary>
    ///   <para>rdfs:label : common Item</para>
    ///   <para>rdfs:comment : Relates any two resources that are or contain the same Item.^^xsd:string</para>
    ///   <para>dcterms:description : commonItem is intended to define a relationship between two resources that may or may not be modeled as OpenWEMI. This makes it possible to assert that a resource modeled using a vocabulary that does not use the OpenWEMI entity model explicitly is describing the same Item as another resource.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/commonItem">openwemi:commonItem</a>
    /// </summary>
    let commonItem = _prefixId.prefix "commonItem"
    /// <summary>
    ///   <para>rdfs:label : common Manifestation</para>
    ///   <para>rdfs:comment : Relates any two resources that are or contain the same Manifestation.^^xsd:string</para>
    ///   <para>dcterms:description : commonManifestation is intended to define a relationship between two resources that may or may not be modeled as OpenWEMI. This makes it possible to assert that a resource modeled using a vocabulary that does not use the OpenWEMI entity model explicitly is describing the same Manifestation as another resource.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/commonManifestation">openwemi:commonManifestation</a>
    /// </summary>
    let commonManifestation = _prefixId.prefix "commonManifestation"
    /// <summary>
    ///   <para>rdfs:label : common Work</para>
    ///   <para>rdfs:comment : Relates any two resources that are or contain the same Work.^^xsd:string</para>
    ///   <para>dcterms:description : commonWork is intended to define a relationship between two resources that may or may not be modeled as OpenWEMI. This makes it possible to assert that a resource modeled using a vocabulary that does not use the OpenWEMI entity model explicitly is describing the same Work as another resource.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/commonWork">openwemi:commonWork</a>
    /// </summary>
    let commonWork = _prefixId.prefix "commonWork"
    /// <summary>
    ///   <para>rdfs:label : expressed by</para>
    ///   <para>rdfs:comment : An Expression of a Work.</para>
    ///   <para>dcterms:description : A relationship asserted from a Work to an Expression that expresses the Work.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/expressedBy">openwemi:expressedBy</a>
    /// </summary>
    let expressedBy = _prefixId.prefix "expressedBy"
    /// <summary>
    ///   <para>rdfs:label : expresses</para>
    ///   <para>rdfs:comment : An Endeavor that expresses a Work.</para>
    ///   <para>dcterms:description : A relationship asserted from an Expression to a Work that it expresses.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/expresses">openwemi:expresses</a>
    /// </summary>
    let expresses = _prefixId.prefix "expresses"
    /// <summary>
    ///   <para>rdfs:label : instantiated by</para>
    ///   <para>rdfs:comment : An instantiation of a Manifestation, an Expression or a Work.</para>
    ///   <para>dcterms:description : A relationship asserted from a Work, an Expression, or a Manifestation to an Item.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/instantiatedBy">openwemi:instantiatedBy</a>
    /// </summary>
    let instantiatedBy = _prefixId.prefix "instantiatedBy"
    /// <summary>
    ///   <para>rdfs:label : instantiates</para>
    ///   <para>rdfs:comment : An Endeavor that instantiates a Manifestation, an Expression or a Work.</para>
    ///   <para>dcterms:description : A relationship asserted from an Item to a Manifestation, an Expression, or a Work.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/instantiates">openwemi:instantiates</a>
    /// </summary>
    let instantiates = _prefixId.prefix "instantiates"
    /// <summary>
    ///   <para>rdfs:label : manifested by</para>
    ///   <para>rdfs:comment : A Manifestation of a Work or an Expression.</para>
    ///   <para>dcterms:description : A relationship asserted from a Work or an Expression to a Manifestation.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/manifestedBy">openwemi:manifestedBy</a>
    /// </summary>
    let manifestedBy = _prefixId.prefix "manifestedBy"
    /// <summary>
    ///   <para>rdfs:label : manifests</para>
    ///   <para>rdfs:comment : An Endeavor that manifests an Expression or a Work.</para>
    ///   <para>dcterms:description : A relationship asserted from a Manifestation to an Expression or a Work.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/manifests">openwemi:manifests</a>
    /// </summary>
    let manifests = _prefixId.prefix "manifests"
    /// <summary>
    ///   <para>rdfs:label : related Expression</para>
    ///   <para>rdfs:comment : An Expression that is related in some way to another Expression.</para>
    ///   <para>dcterms:description : This provides a non-specific relationship between two Expressions. The specific relationship type can be defined as a sub-property of relatedExpression.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/relatedExpression">openwemi:relatedExpression</a>
    /// </summary>
    let relatedExpression = _prefixId.prefix "relatedExpression"
    /// <summary>
    ///   <para>rdfs:label : related Item</para>
    ///   <para>rdfs:comment : An Item that is related in some way to another Item.</para>
    ///   <para>dcterms:description : This provides a non-specific relationship between two Items. The specific relationship type can be defined as a sub-property of relatedItem.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/relatedItem">openwemi:relatedItem</a>
    /// </summary>
    let relatedItem = _prefixId.prefix "relatedItem"
    /// <summary>
    ///   <para>rdfs:label : related Manifestation</para>
    ///   <para>rdfs:comment : A Manifestation that is related in some way to another Manifestation.</para>
    ///   <para>dcterms:description : This provides a non-specific relationship between two Manifestations. The specific relationship type can be defined as a sub-property of relatedManifestation.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/relatedManifestation">openwemi:relatedManifestation</a>
    /// </summary>
    let relatedManifestation = _prefixId.prefix "relatedManifestation"
    /// <summary>
    ///   <para>rdfs:label : related Work</para>
    ///   <para>rdfs:comment : A Work that is related in some way to another Work.</para>
    ///   <para>dcterms:description : This provides a non-specific relationship between two Works. The specific relationship type can be defined as a sub-property of relatedWork.</para>
    ///   <a href="https://ns.dublincore.org/openwemi/relatedWork">openwemi:relatedWork</a>
    /// </summary>
    let relatedWork = _prefixId.prefix "relatedWork"
