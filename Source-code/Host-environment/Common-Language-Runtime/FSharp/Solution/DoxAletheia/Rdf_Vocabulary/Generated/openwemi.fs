namespace https.ns.dublincore.org.openwemi.slash

open DoxAletheia.Rdf_Vocabulary

module openwemi =
    let _namespace_name = "https://ns.dublincore.org/openwemi/"
    /// <summary>
    /// A creation.
    /// <see href="https://ns.dublincore.org/openwemi/Endeavor"></see></summary>
    let Endeavor = Namespaced_IRI.parse _namespace_name "Endeavor" |> NamespacedName
    /// <summary>
    /// A perceivable form of the creation.
    /// <see href="https://ns.dublincore.org/openwemi/Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName
    /// <summary>
    /// An exemplar of a creation.
    /// <see href="https://ns.dublincore.org/openwemi/Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    /// The physical embodiment of a creation.
    /// <see href="https://ns.dublincore.org/openwemi/Manifestation"></see></summary>
    let Manifestation =
        Namespaced_IRI.parse _namespace_name "Manifestation" |> NamespacedName

    /// <summary>
    /// An abstract notion of an artistic or intellectual creation.
    /// <see href="https://ns.dublincore.org/openwemi/Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName

    /// <summary>
    /// Relates any two resources that are or contain the same endeavor.
    /// <see href="https://ns.dublincore.org/openwemi/commonEndeavor"></see></summary>
    let commonEndeavor =
        Namespaced_IRI.parse _namespace_name "commonEndeavor" |> NamespacedName

    /// <summary>
    /// Relates any two resources that are or contain the same Expression.
    /// <see href="https://ns.dublincore.org/openwemi/commonExpression"></see></summary>
    let commonExpression =
        Namespaced_IRI.parse _namespace_name "commonExpression" |> NamespacedName

    /// <summary>
    /// Relates any two resources that are or contain the same Item.
    /// <see href="https://ns.dublincore.org/openwemi/commonItem"></see></summary>
    let commonItem = Namespaced_IRI.parse _namespace_name "commonItem" |> NamespacedName

    /// <summary>
    /// Relates any two resources that are or contain the same Manifestation.
    /// <see href="https://ns.dublincore.org/openwemi/commonManifestation"></see></summary>
    let commonManifestation =
        Namespaced_IRI.parse _namespace_name "commonManifestation" |> NamespacedName

    /// <summary>
    /// Relates any two resources that are or contain the same Work.
    /// <see href="https://ns.dublincore.org/openwemi/commonWork"></see></summary>
    let commonWork = Namespaced_IRI.parse _namespace_name "commonWork" |> NamespacedName

    /// <summary>
    /// An Expression of a Work.
    /// <see href="https://ns.dublincore.org/openwemi/expressedBy"></see></summary>
    let expressedBy =
        Namespaced_IRI.parse _namespace_name "expressedBy" |> NamespacedName

    /// <summary>
    /// An Endeavor that expresses a Work.
    /// <see href="https://ns.dublincore.org/openwemi/expresses"></see></summary>
    let expresses = Namespaced_IRI.parse _namespace_name "expresses" |> NamespacedName

    /// <summary>
    /// An instantiation of a Manifestation, an Expression or a Work.
    /// <see href="https://ns.dublincore.org/openwemi/instantiatedBy"></see></summary>
    let instantiatedBy =
        Namespaced_IRI.parse _namespace_name "instantiatedBy" |> NamespacedName

    /// <summary>
    /// An Endeavor that instantiates a Manifestation, an Expression or a Work.
    /// <see href="https://ns.dublincore.org/openwemi/instantiates"></see></summary>
    let instantiates =
        Namespaced_IRI.parse _namespace_name "instantiates" |> NamespacedName

    /// <summary>
    /// A Manifestation of a Work or an Expression.
    /// <see href="https://ns.dublincore.org/openwemi/manifestedBy"></see></summary>
    let manifestedBy =
        Namespaced_IRI.parse _namespace_name "manifestedBy" |> NamespacedName

    /// <summary>
    /// An Endeavor that manifests an Expression or a Work.
    /// <see href="https://ns.dublincore.org/openwemi/manifests"></see></summary>
    let manifests = Namespaced_IRI.parse _namespace_name "manifests" |> NamespacedName

    /// <summary>
    /// An Expression that is related in some way to another Expression.
    /// <see href="https://ns.dublincore.org/openwemi/relatedExpression"></see></summary>
    let relatedExpression =
        Namespaced_IRI.parse _namespace_name "relatedExpression" |> NamespacedName

    /// <summary>
    /// An Item that is related in some way to another Item.
    /// <see href="https://ns.dublincore.org/openwemi/relatedItem"></see></summary>
    let relatedItem =
        Namespaced_IRI.parse _namespace_name "relatedItem" |> NamespacedName

    /// <summary>
    /// A Manifestation that is related in some way to another Manifestation.
    /// <see href="https://ns.dublincore.org/openwemi/relatedManifestation"></see></summary>
    let relatedManifestation =
        Namespaced_IRI.parse _namespace_name "relatedManifestation" |> NamespacedName

    /// <summary>
    /// A Work that is related in some way to another Work.
    /// <see href="https://ns.dublincore.org/openwemi/relatedWork"></see></summary>
    let relatedWork =
        Namespaced_IRI.parse _namespace_name "relatedWork" |> NamespacedName
