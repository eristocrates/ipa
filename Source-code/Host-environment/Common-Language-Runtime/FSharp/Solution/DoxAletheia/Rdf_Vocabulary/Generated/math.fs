namespace http.www.w3.org._2000._10.swap.math.hash

open DoxAletheia.Rdf_Vocabulary

module math =
    let _namespace_name = "http://www.w3.org/2000/10/swap/math#"
    /// <summary>
    /// A math:Function is unique in terms of math:EqualTo.
    /// <see href="http://www.w3.org/2000/10/swap/math#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName
    /// <summary>
    /// The class of things that are DAML lists were all of the
    ///       members are math:Value items.
    /// <see href="http://www.w3.org/2000/10/swap/math#List"></see></summary>
    let List = Namespaced_IRI.parse _namespace_name "List" |> NamespacedName

    /// <summary>
    /// a logical operator allows evaluation eihter way, or testing relationship
    ///          between two values
    /// <see href="http://www.w3.org/2000/10/swap/math#LogicalOperator"></see></summary>
    let LogicalOperator =
        Namespaced_IRI.parse _namespace_name "LogicalOperator" |> NamespacedName

    /// <summary>
    /// A math:ReverseFunction is unambiguous in terms of math:EqualTo.
    /// <see href="http://www.w3.org/2000/10/swap/math#ReverseFunction"></see></summary>
    let ReverseFunction =
        Namespaced_IRI.parse _namespace_name "ReverseFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/math#StrictProperty"></see>
    /// </summary>
    let StrictProperty =
        Namespaced_IRI.parse _namespace_name "StrictProperty" |> NamespacedName

    /// <summary>
    /// This is the class of things that are math lists with only two members.
    /// <see href="http://www.w3.org/2000/10/swap/math#TwoMemberedList"></see></summary>
    let TwoMemberedList =
        Namespaced_IRI.parse _namespace_name "TwoMemberedList" |> NamespacedName

    /// <summary>
    /// The class of things that are numeric float values as in Python.
    /// <see href="http://www.w3.org/2000/10/swap/math#Value"></see></summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName

    /// <summary>
    /// The object is calulated as the absolute value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#absoluteValue"></see></summary>
    let absoluteValue =
        Namespaced_IRI.parse _namespace_name "absoluteValue" |> NamespacedName

    /// <summary>
    /// The subject is a pair of numbers. The object is calulated as the arc tangent value of the ratio of the two subject values.
    /// <see href="http://www.w3.org/2000/10/swap/math#atan2"></see></summary>
    let atan2 = Namespaced_IRI.parse _namespace_name "atan2" |> NamespacedName
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the cosine value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#cos"></see></summary>
    let cos = Namespaced_IRI.parse _namespace_name "cos" |> NamespacedName
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the conversion in degrees of the value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#degrees"></see></summary>
    let degrees = Namespaced_IRI.parse _namespace_name "degrees" |> NamespacedName
    /// <summary>
    /// The subject is a pair of numbers. The object
    /// is calculated by subtracting the second number of the pair from the first.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#difference"></see></summary>
    let difference = Namespaced_IRI.parse _namespace_name "difference" |> NamespacedName
    /// <summary>
    /// True iff the subject is a string representation of a number which  is EQUAL TO a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#equalTo"></see></summary>
    let equalTo = Namespaced_IRI.parse _namespace_name "equalTo" |> NamespacedName

    /// <summary>
    /// The subject is a pair of numbers. The object
    /// is calculated by raising the first number of the power of the second.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#exponentiation"></see></summary>
    let exponentiation =
        Namespaced_IRI.parse _namespace_name "exponentiation" |> NamespacedName

    /// <summary>
    /// True iff the subject is a string representation of a number which  is greater than the number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#greaterThan"></see></summary>
    let greaterThan =
        Namespaced_IRI.parse _namespace_name "greaterThan" |> NamespacedName

    /// <summary>
    /// The subject is a pair of integer numbers. The object
    /// is calculated by dividing the first number of the pair by the second, ignoring remainder.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#integerQuotient"></see></summary>
    let integerQuotient =
        Namespaced_IRI.parse _namespace_name "integerQuotient" |> NamespacedName

    /// <summary>
    /// True iff the subject is a string representation of a number which  is LESS than a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#lessThan"></see></summary>
    let lessThan = Namespaced_IRI.parse _namespace_name "lessThan" |> NamespacedName

    /// <summary>
    /// The number of items in a list. The subject is a list,
    /// the object is calculated as the number of members.
    /// <see href="http://www.w3.org/2000/10/swap/math#memberCount"></see></summary>
    let memberCount =
        Namespaced_IRI.parse _namespace_name "memberCount" |> NamespacedName

    /// <summary>
    /// The subject or object is calculated to be the negation of the other.
    /// <see href="http://www.w3.org/2000/10/swap/math#negation"></see></summary>
    let negation = Namespaced_IRI.parse _namespace_name "negation" |> NamespacedName
    /// <summary>
    /// True iff the subject is a string representation of a number which  is NOT EQUAL to a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#notEqualTo"></see></summary>
    let notEqualTo = Namespaced_IRI.parse _namespace_name "notEqualTo" |> NamespacedName

    /// <summary>
    /// True iff the subject is a string representation of a number which is NOT greater than the number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#notGreaterThan"></see></summary>
    let notGreaterThan =
        Namespaced_IRI.parse _namespace_name "notGreaterThan" |> NamespacedName

    /// <summary>
    /// True iff the subject is a string representation of a number which  is NOT LESS than a number of which the object is a string representation.
    /// <see href="http://www.w3.org/2000/10/swap/math#notLessThan"></see></summary>
    let notLessThan =
        Namespaced_IRI.parse _namespace_name "notLessThan" |> NamespacedName

    /// <summary>
    /// The subject is a list of numbers.
    /// The object is calculated as the arithmentic product of those numbers.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#product"></see></summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName
    /// <summary>
    /// The subject is a pair of numbers. The object
    /// is calculated by dividing the first number of the pair by the second.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#quotient"></see></summary>
    let quotient = Namespaced_IRI.parse _namespace_name "quotient" |> NamespacedName
    /// <summary>
    /// The subject is a pair of integers. The object
    /// is calculated by dividing the first number of the pair by the second and taking the remainder.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#remainder"></see></summary>
    let remainder = Namespaced_IRI.parse _namespace_name "remainder" |> NamespacedName
    /// <summary>
    /// The object is calulated as the subject rounded to the nearest integer.
    /// <see href="http://www.w3.org/2000/10/swap/math#rounded"></see></summary>
    let rounded = Namespaced_IRI.parse _namespace_name "rounded" |> NamespacedName
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the sine value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#sin"></see></summary>
    let sin = Namespaced_IRI.parse _namespace_name "sin" |> NamespacedName
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the hyperbolic sine value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#sinh"></see></summary>
    let sinh = Namespaced_IRI.parse _namespace_name "sinh" |> NamespacedName
    /// <summary>
    /// The subject is a list of numbers.
    /// The object is calculated as the arithmentic sum of those numbers.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/math#sum"></see></summary>
    let sum = Namespaced_IRI.parse _namespace_name "sum" |> NamespacedName
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the tangent value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#tan"></see></summary>
    let tan = Namespaced_IRI.parse _namespace_name "tan" |> NamespacedName
    /// <summary>
    /// The subject is an angle expressed in radians. The object is calulated as the hyperbolic tangent value of the subject.
    /// <see href="http://www.w3.org/2000/10/swap/math#tanh"></see></summary>
    let tanh = Namespaced_IRI.parse _namespace_name "tanh" |> NamespacedName
