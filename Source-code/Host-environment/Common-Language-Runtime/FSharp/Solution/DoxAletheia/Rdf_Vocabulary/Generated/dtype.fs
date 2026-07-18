namespace http.www.linkedmodel.org.schema.dtype.hash

open DoxAletheia.Rdf_Vocabulary

module dtype =
    let _namespace_name = "http://www.linkedmodel.org/schema/dtype#"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#CodeList"></see>
    /// </summary>
    let CodeList = Namespaced_IRI.parse _namespace_name "CodeList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#Enumeration"></see>
    /// </summary>
    let Enumeration =
        Namespaced_IRI.parse _namespace_name "Enumeration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#CompositeCodeList"></see>
    /// </summary>
    let CompositeCodeList =
        Namespaced_IRI.parse _namespace_name "CompositeCodeList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#compositeOf"></see>
    /// </summary>
    let compositeOf =
        Namespaced_IRI.parse _namespace_name "compositeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#DerivedCodeList"></see>
    /// </summary>
    let DerivedCodeList =
        Namespaced_IRI.parse _namespace_name "DerivedCodeList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#SimpleCodeList"></see>
    /// </summary>
    let SimpleCodeList =
        Namespaced_IRI.parse _namespace_name "SimpleCodeList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#derivedFrom"></see>
    /// </summary>
    let derivedFrom =
        Namespaced_IRI.parse _namespace_name "derivedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#ValueReference"></see>
    /// </summary>
    let ValueReference =
        Namespaced_IRI.parse _namespace_name "ValueReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#hasMember"></see>
    /// </summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#EnumeratedValue"></see>
    /// </summary>
    let EnumeratedValue =
        Namespaced_IRI.parse _namespace_name "EnumeratedValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#position"></see>
    /// </summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#code"></see>
    /// </summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#order"></see>
    /// </summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#defaultValue"></see>
    /// </summary>
    let defaultValue =
        Namespaced_IRI.parse _namespace_name "defaultValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#refersTo"></see>
    /// </summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#isInvalid"></see>
    /// </summary>
    let isInvalid = Namespaced_IRI.parse _namespace_name "isInvalid" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#literal"></see>
    /// </summary>
    let literal = Namespaced_IRI.parse _namespace_name "literal" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#numericUnion"></see>
    /// </summary>
    let numericUnion =
        Namespaced_IRI.parse _namespace_name "numericUnion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#orderIndex"></see>
    /// </summary>
    let orderIndex = Namespaced_IRI.parse _namespace_name "orderIndex" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
