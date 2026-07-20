namespace https.ns.dublincore.org.openwemi.slash

open DoxAletheia

module openwemi =
    let _namespace_name = "https://ns.dublincore.org/openwemi/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A creation.
    /// <see href="https://ns.dublincore.org/openwemi/Endeavor"></see></summary>
    let Endeavor = _prefix "Endeavor"
    /// <summary>
    /// A perceivable form of the creation.
    /// <see href="https://ns.dublincore.org/openwemi/Expression"></see></summary>
    let Expression = _prefix "Expression"
    /// <summary>
    /// An exemplar of a creation.
    /// <see href="https://ns.dublincore.org/openwemi/Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// The physical embodiment of a creation.
    /// <see href="https://ns.dublincore.org/openwemi/Manifestation"></see></summary>
    let Manifestation = _prefix "Manifestation"
    /// <summary>
    /// An abstract notion of an artistic or intellectual creation.
    /// <see href="https://ns.dublincore.org/openwemi/Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    /// Relates any two resources that are or contain the same endeavor.
    /// <see href="https://ns.dublincore.org/openwemi/commonEndeavor"></see></summary>
    let commonEndeavor = _prefix "commonEndeavor"
    /// <summary>
    /// Relates any two resources that are or contain the same Expression.
    /// <see href="https://ns.dublincore.org/openwemi/commonExpression"></see></summary>
    let commonExpression = _prefix "commonExpression"
    /// <summary>
    /// Relates any two resources that are or contain the same Item.
    /// <see href="https://ns.dublincore.org/openwemi/commonItem"></see></summary>
    let commonItem = _prefix "commonItem"
    /// <summary>
    /// Relates any two resources that are or contain the same Manifestation.
    /// <see href="https://ns.dublincore.org/openwemi/commonManifestation"></see></summary>
    let commonManifestation = _prefix "commonManifestation"
    /// <summary>
    /// Relates any two resources that are or contain the same Work.
    /// <see href="https://ns.dublincore.org/openwemi/commonWork"></see></summary>
    let commonWork = _prefix "commonWork"
    /// <summary>
    /// An Expression of a Work.
    /// <see href="https://ns.dublincore.org/openwemi/expressedBy"></see></summary>
    let expressedBy = _prefix "expressedBy"
    /// <summary>
    /// An Endeavor that expresses a Work.
    /// <see href="https://ns.dublincore.org/openwemi/expresses"></see></summary>
    let expresses = _prefix "expresses"
    /// <summary>
    /// An instantiation of a Manifestation, an Expression or a Work.
    /// <see href="https://ns.dublincore.org/openwemi/instantiatedBy"></see></summary>
    let instantiatedBy = _prefix "instantiatedBy"
    /// <summary>
    /// An Endeavor that instantiates a Manifestation, an Expression or a Work.
    /// <see href="https://ns.dublincore.org/openwemi/instantiates"></see></summary>
    let instantiates = _prefix "instantiates"
    /// <summary>
    /// A Manifestation of a Work or an Expression.
    /// <see href="https://ns.dublincore.org/openwemi/manifestedBy"></see></summary>
    let manifestedBy = _prefix "manifestedBy"
    /// <summary>
    /// An Endeavor that manifests an Expression or a Work.
    /// <see href="https://ns.dublincore.org/openwemi/manifests"></see></summary>
    let manifests = _prefix "manifests"
    /// <summary>
    /// An Expression that is related in some way to another Expression.
    /// <see href="https://ns.dublincore.org/openwemi/relatedExpression"></see></summary>
    let relatedExpression = _prefix "relatedExpression"
    /// <summary>
    /// An Item that is related in some way to another Item.
    /// <see href="https://ns.dublincore.org/openwemi/relatedItem"></see></summary>
    let relatedItem = _prefix "relatedItem"
    /// <summary>
    /// A Manifestation that is related in some way to another Manifestation.
    /// <see href="https://ns.dublincore.org/openwemi/relatedManifestation"></see></summary>
    let relatedManifestation = _prefix "relatedManifestation"
    /// <summary>
    /// A Work that is related in some way to another Work.
    /// <see href="https://ns.dublincore.org/openwemi/relatedWork"></see></summary>
    let relatedWork = _prefix "relatedWork"
