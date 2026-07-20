namespace http.www.w3.org._2000._10.swap.math.hash

open DoxAletheia

module math =
    let _namespace_name = "http://www.w3.org/2000/10/swap/math#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A math:Function is unique in terms of math:EqualTo.
    /// <see href="http://www.w3.org/2000/10/swap/math#Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// The class of things that are DAML lists were all of the
    ///       members are math:Value items.
    /// <see href="http://www.w3.org/2000/10/swap/math#List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// a logical operator allows evaluation eihter way, or testing relationship
    ///          between two values
    /// <see href="http://www.w3.org/2000/10/swap/math#LogicalOperator"></see></summary>
    let LogicalOperator = _prefix "LogicalOperator"
    /// <summary>
    /// A math:ReverseFunction is unambiguous in terms of math:EqualTo.
    /// <see href="http://www.w3.org/2000/10/swap/math#ReverseFunction"></see></summary>
    let ReverseFunction = _prefix "ReverseFunction"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/math#StrictProperty"></see>
    /// </summary>
    let StrictProperty = _prefix "StrictProperty"
    /// <summary>
    /// This is the class of things that are math lists with only two members.
    /// <see href="http://www.w3.org/2000/10/swap/math#TwoMemberedList"></see></summary>
    let TwoMemberedList = _prefix "TwoMemberedList"
    /// <summary>
    /// The class of things that are numeric float values as in Python.
    /// <see href="http://www.w3.org/2000/10/swap/math#Value"></see></summary>
    let Value = _prefix "Value"
    /// <summary>
    /// The object is calulated as the absolute value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#absoluteValue"></see></summary>
    let absoluteValue = _prefix "absoluteValue"
    /// <summary>
    /// The subject is a pair of numbers. The object is calulated as the arc tangent value of the ratio of the two subject values.
    /// <see href="http://www.w3.org/2000/10/swap/math#atan2"></see></summary>
    let atan2 = _prefix "atan2"
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the cosine value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#cos"></see></summary>
    let cos = _prefix "cos"
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the conversion in degrees of the value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#degrees"></see></summary>
    let degrees = _prefix "degrees"
    /// <summary>
    /// The subject is a pair of numbers. The object
    /// is calculated by subtracting the second number of the pair from the first.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#difference"></see></summary>
    let difference = _prefix "difference"
    /// <summary>
    /// True iff the subject is a string representation of a number which  is EQUAL TO a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#equalTo"></see></summary>
    let equalTo = _prefix "equalTo"
    /// <summary>
    /// The subject is a pair of numbers. The object
    /// is calculated by raising the first number of the power of the second.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#exponentiation"></see></summary>
    let exponentiation = _prefix "exponentiation"
    /// <summary>
    /// True iff the subject is a string representation of a number which  is greater than the number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#greaterThan"></see></summary>
    let greaterThan = _prefix "greaterThan"
    /// <summary>
    /// The subject is a pair of integer numbers. The object
    /// is calculated by dividing the first number of the pair by the second, ignoring remainder.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#integerQuotient"></see></summary>
    let integerQuotient = _prefix "integerQuotient"
    /// <summary>
    /// True iff the subject is a string representation of a number which  is LESS than a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#lessThan"></see></summary>
    let lessThan = _prefix "lessThan"
    /// <summary>
    /// The number of items in a list. The subject is a list,
    /// the object is calculated as the number of members.
    /// <see href="http://www.w3.org/2000/10/swap/math#memberCount"></see></summary>
    let memberCount = _prefix "memberCount"
    /// <summary>
    /// The subject or object is calculated to be the negation of the other.
    /// <see href="http://www.w3.org/2000/10/swap/math#negation"></see></summary>
    let negation = _prefix "negation"
    /// <summary>
    /// True iff the subject is a string representation of a number which  is NOT EQUAL to a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#notEqualTo"></see></summary>
    let notEqualTo = _prefix "notEqualTo"
    /// <summary>
    /// True iff the subject is a string representation of a number which is NOT greater than the number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#notGreaterThan"></see></summary>
    let notGreaterThan = _prefix "notGreaterThan"
    /// <summary>
    /// True iff the subject is a string representation of a number which  is NOT LESS than a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#notLessThan"></see></summary>
    let notLessThan = _prefix "notLessThan"
    /// <summary>
    /// The subject is a list of numbers.
    /// The object is calculated as the arithmentic product of those numbers.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#product"></see></summary>
    let product = _prefix "product"
    /// <summary>
    /// The subject is a pair of numbers. The object
    /// is calculated by dividing the first number of the pair by the second.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#quotient"></see></summary>
    let quotient = _prefix "quotient"
    /// <summary>
    /// The subject is a pair of integers. The object
    /// is calculated by dividing the first number of the pair by the second and taking the remainder.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#remainder"></see></summary>
    let remainder = _prefix "remainder"
    /// <summary>
    /// The object is calulated as the subject rounded to the nearest integer.
    /// <see href="http://www.w3.org/2000/10/swap/math#rounded"></see></summary>
    let rounded = _prefix "rounded"
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the sine value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#sin"></see></summary>
    let sin = _prefix "sin"
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the hyperbolic sine value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#sinh"></see></summary>
    let sinh = _prefix "sinh"
    /// <summary>
    /// The subject is a list of numbers.
    /// The object is calculated as the arithmentic sum of those numbers.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#sum"></see></summary>
    let sum = _prefix "sum"
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the tangent value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#tan"></see></summary>
    let tan = _prefix "tan"
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the hyperbolic tangent value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#tanh"></see></summary>
    let tanh = _prefix "tanh"
