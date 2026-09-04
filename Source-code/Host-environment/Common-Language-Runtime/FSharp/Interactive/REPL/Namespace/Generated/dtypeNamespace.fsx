#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dtype =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.linkedmodel.org/schema/dtype#" "dtype"

    /// <summary>
    ///   <para>vaem:comment : A codelist is a controlled vocabulary of terms that are used to represent permissible values of a variable in information systems. The representaiton of codes in "dtype" has been influenced by CCTS and UBL.^^xsd:string</para>
    ///   <para>rdfs:label : Codelist^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#CodeList">dtype:CodeList</a>
    /// </summary>
    let CodeList = _prefixId.prefix "CodeList"
    /// <summary>
    ///   <para>vaem:comment : A composite codelist is a codelist made up of other codelists. It does not introduce any new codes.^^xsd:string</para>
    ///   <para>rdfs:label : Composite Code List^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#CompositeCodeList">dtype:CompositeCodeList</a>
    /// </summary>
    let CompositeCodeList = _prefixId.prefix "CompositeCodeList"
    /// <summary>
    ///   <para>rdfs:label : Derived Code List^^xsd:string</para>
    ///   <para>vaem:comment : A derived codelist is a sublist of another codelist. The members that it has must be members of the source list.^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#DerivedCodeList">dtype:DerivedCodeList</a>
    /// </summary>
    let DerivedCodeList = _prefixId.prefix "DerivedCodeList"
    /// <summary>
    ///   <para>rdfs:label : DTYPE Enumerated value^^xsd:string</para>
    ///   <para>dce:description : The base class for datatypes that have values that are restriced to a set of literals or tokens. The members of the restriction may themselve be restriced by facets that apply to scalar data types.^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#EnumeratedValue">dtype:EnumeratedValue</a>
    /// </summary>
    let EnumeratedValue = _prefixId.prefix "EnumeratedValue"
    /// <summary>
    ///   <para>vaem:comment : A type that serves as a container for the enumerated values of an enumeration. This enables the enumeration itself to be referenceable. One need for this is in determing the default value of an enumeration , another need is in the management of sub-enumerations and composite enumerations.^^xsd:string</para>
    ///   <para>rdfs:label : DTYPE Enumeration^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#Enumeration">dtype:Enumeration</a>
    /// </summary>
    let Enumeration = _prefixId.prefix "Enumeration"
    /// <summary>
    ///   <para>vaem:comment : A simple codelist is one made up only of enumerated values.^^xsd:string</para>
    ///   <para>rdfs:label : Simple Code List^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#SimpleCodeList">dtype:SimpleCodeList</a>
    /// </summary>
    let SimpleCodeList = _prefixId.prefix "SimpleCodeList"
    /// <summary>
    ///   <para>vaem:comment : A value reference is a pointer to an Enumerated Value. The original position of the value can be overridden by the position attribute.^^xsd:string</para>
    ///   <para>rdfs:label : Value Reference^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#ValueReference">dtype:ValueReference</a>
    /// </summary>
    let ValueReference = _prefixId.prefix "ValueReference"
    /// <summary>
    ///   <para>vaem:comment : A property for expressing an encoded value. The range has been set to "xsd:anySimpleType" to allow for a variety of scalar datatypes.^^xsd:string</para>
    ///   <para>rdfs:label : code^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#code">dtype:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>vaem:comment : Aproperty for constructing composite data structures^^xsd:string</para>
    ///   <para>rdfs:label : composite of^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#compositeOf">dtype:compositeOf</a>
    /// </summary>
    let compositeOf = _prefixId.prefix "compositeOf"
    /// <summary>
    ///   <para>vaem:comment : The property "dtype:defaultValue" is a general property for specifying a value in situations where none is specified, or can be determined. In some cases of use, this property could have a scalar value and in other cases may need to refer to a first class concept that holds a "value object".  For this reason, the  type of this property is set as "rdf:Property" and the property is rangeless.^^xsd:string</para>
    ///   <para>rdfs:label : default value^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#defaultValue">dtype:defaultValue</a>
    /// </summary>
    let defaultValue = _prefixId.prefix "defaultValue"
    /// <summary>
    ///   <para>vaem:comment : A property for specifying a derivation relationship.^^xsd:string</para>
    ///   <para>rdfs:label : derived from^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#derivedFrom">dtype:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    /// <summary>
    ///   <para>vaem:comment : A property for specifying how member elements make up a data structure.^^xsd:string</para>
    ///   <para>rdfs:label : has member^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#hasMember">dtype:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>vaem:comment : A boolean flag to state that a value is invalid with respect to its type.^^xsd:string</para>
    ///   <para>rdfs:label : is invalid^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#isInvalid">dtype:isInvalid</a>
    /// </summary>
    let isInvalid = _prefixId.prefix "isInvalid"
    /// <summary>
    ///   <para>vaem:comment : A general purpose property for holding string literals.^^xsd:string</para>
    ///   <para>rdfs:label : literal^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#literal">dtype:literal</a>
    /// </summary>
    let literal = _prefixId.prefix "literal"
    let numericUnion = _prefixId.prefix "numericUnion"
    /// <summary>
    ///   <para>vaem:comment : The property "dtype:order" provides a means to specify a precedence. One use of order is in specifying ordered enumerations such as "voag:ConfidentialityLevel".  A similar property, but with an important type difference, is "vaem:orderIndex". This is for use on property occurrences in class axioms where it can be placed on a restriction to specify how that property may be transformed into other representations where ordering has some importance, for example, in XML Schema sequences.  Whereas "vaem:order" is a datatype property, "vaem:orderIndex" is an annotation property.^^xsd:string</para>
    ///   <para>rdfs:label : order^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#order">dtype:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>vaem:comment : The property "dtype:orderIndex" is an annotation property to specify a position that some value or structure will have. One use is to specify the place that a resource has in a sequence. One use is on property occurrences in class axioms. Here "vaem:orderIndex" is placed on a restriction to specify how that property may be transformed into a representation where ordering has some importance, for example, in XML Schema sequences.^^xsd:string</para>
    ///   <para>rdfs:label : order index^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#orderIndex">dtype:orderIndex</a>
    /// </summary>
    let orderIndex = _prefixId.prefix "orderIndex"
    /// <summary>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#position">dtype:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>vaem:comment : An indirection pointer for relating a slot in am occurrence data structure, such as "dtype:ValueReference" with another resource.^^xsd:string</para>
    ///   <para>rdfs:label : refers to^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#refersTo">dtype:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:label : datatype^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#type">dtype:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>vaem:comment : The property "dtype:value" is a general property that in some cases could have scalar values and in other cases may refer to a first class concept that is a "value object". For this reason, the  type of this property is set as "rdf:Property" and the property is rangeless.^^xsd:string</para>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/dtype#value">dtype:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
