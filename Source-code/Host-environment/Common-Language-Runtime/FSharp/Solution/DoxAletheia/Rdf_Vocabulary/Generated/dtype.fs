namespace http.www.linkedmodel.org.schema.dtype.hash

open DoxAletheia

module dtype =
    let _namespace_name = "http://www.linkedmodel.org/schema/dtype#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#CodeList"></see>
    /// </summary>
    let CodeList = _prefix "CodeList"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#Enumeration"></see>
    /// </summary>
    let Enumeration = _prefix "Enumeration"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#CompositeCodeList"></see>
    /// </summary>
    let CompositeCodeList = _prefix "CompositeCodeList"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#compositeOf"></see>
    /// </summary>
    let compositeOf = _prefix "compositeOf"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#DerivedCodeList"></see>
    /// </summary>
    let DerivedCodeList = _prefix "DerivedCodeList"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#SimpleCodeList"></see>
    /// </summary>
    let SimpleCodeList = _prefix "SimpleCodeList"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#derivedFrom"></see>
    /// </summary>
    let derivedFrom = _prefix "derivedFrom"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#ValueReference"></see>
    /// </summary>
    let ValueReference = _prefix "ValueReference"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#hasMember"></see>
    /// </summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#EnumeratedValue"></see>
    /// </summary>
    let EnumeratedValue = _prefix "EnumeratedValue"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#position"></see>
    /// </summary>
    let position = _prefix "position"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#code"></see>
    /// </summary>
    let code = _prefix "code"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#order"></see>
    /// </summary>
    let order = _prefix "order"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#defaultValue"></see>
    /// </summary>
    let defaultValue = _prefix "defaultValue"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#refersTo"></see>
    /// </summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#isInvalid"></see>
    /// </summary>
    let isInvalid = _prefix "isInvalid"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#literal"></see>
    /// </summary>
    let literal = _prefix "literal"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#numericUnion"></see>
    /// </summary>
    let numericUnion = _prefix "numericUnion"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#orderIndex"></see>
    /// </summary>
    let orderIndex = _prefix "orderIndex"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/dtype#type"></see>
    /// </summary>
    let type_ = _prefix "type"
