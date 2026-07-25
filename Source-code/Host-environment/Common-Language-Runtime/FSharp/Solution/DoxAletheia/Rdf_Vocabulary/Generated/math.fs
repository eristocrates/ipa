namespace http.www.w3.org._2000._10.swap.math.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module math =
    let _namespace_iri = Namespace_Iri math |> NamespaceIRI
    /// <summary>
    ///   <para>math:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of things that are DAML lists were all of the
    ///       members are math:Value items.</para>
    /// labels<para>List</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#List">http://www.w3.org/2000/10/swap/math#List</seealso>
    let List = Prefixed_Name(math, "List") |> PrefixedName
    /// <summary>
    ///   <para>math:StrictProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>StrictProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#StrictProperty">http://www.w3.org/2000/10/swap/math#StrictProperty</seealso>
    let StrictProperty = Prefixed_Name(math, "StrictProperty") |> PrefixedName
    /// <summary>
    ///   <para>math:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of things that are numeric float values as in Python.</para>
    /// labels<para>Value</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#Value">http://www.w3.org/2000/10/swap/math#Value</seealso>
    let Value = Prefixed_Name(math, "Value") |> PrefixedName
    /// <summary>
    ///   <para>math:ReverseFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A math:ReverseFunction is unambiguous in terms of math:EqualTo. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#ReverseFunction">http://www.w3.org/2000/10/swap/math#ReverseFunction</seealso>
    let ReverseFunction = Prefixed_Name(math, "ReverseFunction") |> PrefixedName
    /// <summary>
    ///   <para>math:absoluteValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object is calulated as the absolute value of the subject.</para>
    /// labels<para>negation</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#absoluteValue">http://www.w3.org/2000/10/swap/math#absoluteValue</seealso>
    let absoluteValue = Prefixed_Name(math, "absoluteValue") |> PrefixedName
    /// <summary>
    ///   <para>math:degrees</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is an angle expressed in radians. The object is calulated as the conversion in degrees of the value of the subject.</para>
    /// labels<para>degrees</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#degrees">http://www.w3.org/2000/10/swap/math#degrees</seealso>
    let degrees = Prefixed_Name(math, "degrees") |> PrefixedName
    /// <summary>
    ///   <para>math:difference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a pair of numbers. The object
    /// is calculated by subtracting the second number of the pair from the first.
    /// </para>
    /// labels<para>difference</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#difference">http://www.w3.org/2000/10/swap/math#difference</seealso>
    let difference = Prefixed_Name(math, "difference") |> PrefixedName
    /// <summary>
    ///   <para>math:integerQuotient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a pair of integer numbers. The object
    /// is calculated by dividing the first number of the pair by the second, ignoring remainder.
    /// </para>
    /// labels<para>integerQuotient</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#integerQuotient">http://www.w3.org/2000/10/swap/math#integerQuotient</seealso>
    let integerQuotient = Prefixed_Name(math, "integerQuotient") |> PrefixedName
    /// <summary>
    ///   <para>math:negation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject or object is calculated to be the negation of the other.</para>
    /// labels<para>negation</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#negation">http://www.w3.org/2000/10/swap/math#negation</seealso>
    let negation = Prefixed_Name(math, "negation") |> PrefixedName
    /// <summary>
    ///   <para>math:notLessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>math:StrictProperty</para>
    ///   <para>True iff the subject is a string representation of a number which  is NOT LESS than a number of which the object is a string representation.</para>
    /// labels<para>notlessThan</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#notLessThan">http://www.w3.org/2000/10/swap/math#notLessThan</seealso>
    let notLessThan = Prefixed_Name(math, "notLessThan") |> PrefixedName
    /// <summary>
    ///   <para>math:sin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is an angle expressed in radians. The object is calulated as the sine value of the subject.</para>
    /// labels<para>sin</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#sin">http://www.w3.org/2000/10/swap/math#sin</seealso>
    let sin = Prefixed_Name(math, "sin") |> PrefixedName
    /// <summary>
    ///   <para>math:atan2</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a pair of numbers. The object is calulated as the arc tangent value of the ratio of the two subject values.</para>
    /// labels<para>atan2</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#atan2">http://www.w3.org/2000/10/swap/math#atan2</seealso>
    let atan2 = Prefixed_Name(math, "atan2") |> PrefixedName
    /// <summary>
    ///   <para>math:greaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>math:StrictProperty</para>
    ///   <para>True iff the subject is a string representation of a number which  is greater than the number of which the object is a string representation.</para>
    /// labels<para>greaterThan</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#greaterThan">http://www.w3.org/2000/10/swap/math#greaterThan</seealso>
    let greaterThan = Prefixed_Name(math, "greaterThan") |> PrefixedName
    /// <summary>
    ///   <para>math:notEqualTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>math:StrictProperty</para>
    ///   <para>True iff the subject is a string representation of a number which  is NOT EQUAL to a number of which the object is a string representation.</para>
    /// labels<para>notEqualTo</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#notEqualTo">http://www.w3.org/2000/10/swap/math#notEqualTo</seealso>
    let notEqualTo = Prefixed_Name(math, "notEqualTo") |> PrefixedName
    /// <summary>
    ///   <para>math:memberCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>math:Function</para>
    ///   <para>The number of items in a list. The subject is a list,
    /// the object is calculated as the number of members.</para>
    /// labels<para>memberCount</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#memberCount">http://www.w3.org/2000/10/swap/math#memberCount</seealso>
    let memberCount = Prefixed_Name(math, "memberCount") |> PrefixedName
    /// <summary>
    ///   <para>math:notGreaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>math:StrictProperty</para>
    ///   <para>True iff the subject is a string representation of a number which is NOT greater than the number of which the object is a string representation.</para>
    /// labels<para>notGreaterThan</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#notGreaterThan">http://www.w3.org/2000/10/swap/math#notGreaterThan</seealso>
    let notGreaterThan = Prefixed_Name(math, "notGreaterThan") |> PrefixedName
    /// <summary>
    ///   <para>math:rounded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object is calulated as the subject rounded to the nearest integer.</para>
    /// labels<para>rounded</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#rounded">http://www.w3.org/2000/10/swap/math#rounded</seealso>
    let rounded = Prefixed_Name(math, "rounded") |> PrefixedName
    /// <summary>
    ///   <para>math:sinh</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is an angle expressed in radians. The object is calulated as the hyperbolic sine value of the subject.</para>
    /// labels<para>sinh</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#sinh">http://www.w3.org/2000/10/swap/math#sinh</seealso>
    let sinh = Prefixed_Name(math, "sinh") |> PrefixedName
    /// <summary>
    ///   <para>math:quotient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a pair of numbers. The object
    /// is calculated by dividing the first number of the pair by the second.
    /// </para>
    /// labels<para>quotient</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#quotient">http://www.w3.org/2000/10/swap/math#quotient</seealso>
    let quotient = Prefixed_Name(math, "quotient") |> PrefixedName
    /// <summary>
    ///   <para>math:tanh</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is an angle expressed in radians. The object is calulated as the hyperbolic tangent value of the subject.</para>
    /// labels<para>tanh</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#tanh">http://www.w3.org/2000/10/swap/math#tanh</seealso>
    let tanh = Prefixed_Name(math, "tanh") |> PrefixedName
    /// <summary>
    ///   <para>math:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A math:Function is unique in terms of math:EqualTo. </para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#Function">http://www.w3.org/2000/10/swap/math#Function</seealso>
    let Function = Prefixed_Name(math, "Function") |> PrefixedName
    /// <summary>
    ///   <para>math:LogicalOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>a logical operator allows evaluation eihter way, or testing relationship
    ///          between two values</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#LogicalOperator">http://www.w3.org/2000/10/swap/math#LogicalOperator</seealso>
    let LogicalOperator = Prefixed_Name(math, "LogicalOperator") |> PrefixedName
    /// <summary>
    ///   <para>math:TwoMemberedList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This is the class of things that are math lists with only two members.</para>
    /// labels<para>TwoMemberedList</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#TwoMemberedList">http://www.w3.org/2000/10/swap/math#TwoMemberedList</seealso>
    let TwoMemberedList = Prefixed_Name(math, "TwoMemberedList") |> PrefixedName
    /// <summary>
    ///   <para>math:cos</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is an angle expressed in radians. The object is calulated as the cosine value of the subject.</para>
    /// labels<para>cos</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#cos">http://www.w3.org/2000/10/swap/math#cos</seealso>
    let cos = Prefixed_Name(math, "cos") |> PrefixedName
    /// <summary>
    ///   <para>math:equalTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>math:StrictProperty</para>
    ///   <para>True iff the subject is a string representation of a number which  is EQUAL TO a number of which the object is a string representation.</para>
    /// labels<para>equalTo</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#equalTo">http://www.w3.org/2000/10/swap/math#equalTo</seealso>
    let equalTo = Prefixed_Name(math, "equalTo") |> PrefixedName
    /// <summary>
    ///   <para>math:exponentiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a pair of numbers. The object
    /// is calculated by raising the first number of the power of the second.
    /// </para>
    /// labels<para>exponentiation</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#exponentiation">http://www.w3.org/2000/10/swap/math#exponentiation</seealso>
    let exponentiation = Prefixed_Name(math, "exponentiation") |> PrefixedName
    /// <summary>
    ///   <para>math:lessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>math:StrictProperty</para>
    ///   <para>True iff the subject is a string representation of a number which  is LESS than a number of which the object is a string representation.</para>
    /// labels<para>lessThan</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#lessThan">http://www.w3.org/2000/10/swap/math#lessThan</seealso>
    let lessThan = Prefixed_Name(math, "lessThan") |> PrefixedName
    /// <summary>
    ///   <para>math:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a list of numbers.
    /// The object is calculated as the arithmentic product of those numbers.
    /// </para>
    /// labels<para>product</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#product">http://www.w3.org/2000/10/swap/math#product</seealso>
    let product = Prefixed_Name(math, "product") |> PrefixedName
    /// <summary>
    ///   <para>math:remainder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a pair of integers. The object
    /// is calculated by dividing the first number of the pair by the second and taking the remainder.
    /// </para>
    /// labels<para>remainder</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#remainder">http://www.w3.org/2000/10/swap/math#remainder</seealso>
    let remainder = Prefixed_Name(math, "remainder") |> PrefixedName
    /// <summary>
    ///   <para>math:sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a list of numbers.
    /// The object is calculated as the arithmentic sum of those numbers.
    /// </para>
    /// labels<para>sum</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#sum">http://www.w3.org/2000/10/swap/math#sum</seealso>
    let sum = Prefixed_Name(math, "sum") |> PrefixedName
    /// <summary>
    ///   <para>math:tan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is an angle expressed in radians. The object is calulated as the tangent value of the subject.</para>
    /// labels<para>tan</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/math#tan">http://www.w3.org/2000/10/swap/math#tan</seealso>
    let tan = Prefixed_Name(math, "tan") |> PrefixedName
