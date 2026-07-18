namespace http.www.w3.org._2003._11.swrl.hash

open DoxAletheia.Rdf_Vocabulary

module swrl =
    let _namespace_name = "http://www.w3.org/2003/11/swrl#"
    /// <summary>
    /// common superclass
    /// <see href="http://www.w3.org/2003/11/swrl#Atom"></see></summary>
    let Atom = Namespaced_IRI.parse _namespace_name "Atom" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#Builtin"></see>
    /// </summary>
    let Builtin = Namespaced_IRI.parse _namespace_name "Builtin" |> NamespacedName

    /// <summary>
    /// consists of a builtin and a List of arguments
    /// <see href="http://www.w3.org/2003/11/swrl#BuiltinAtom"></see></summary>
    let BuiltinAtom =
        Namespaced_IRI.parse _namespace_name "BuiltinAtom" |> NamespacedName

    /// <summary>
    /// consists of a classPredicate and argument1
    /// <see href="http://www.w3.org/2003/11/swrl#ClassAtom"></see></summary>
    let ClassAtom = Namespaced_IRI.parse _namespace_name "ClassAtom" |> NamespacedName

    /// <summary>
    /// consists of a dataRange and argument1
    /// <see href="http://www.w3.org/2003/11/swrl#DataRangeAtom"></see></summary>
    let DataRangeAtom =
        Namespaced_IRI.parse _namespace_name "DataRangeAtom" |> NamespacedName

    /// <summary>
    /// consists of a propertyPredicate (owl:DatatypeProperty), argument1 (owl:Thing), and argument2 (rdfs:Literal)
    /// <see href="http://www.w3.org/2003/11/swrl#DatavaluedPropertyAtom"></see></summary>
    let DatavaluedPropertyAtom =
        Namespaced_IRI.parse _namespace_name "DatavaluedPropertyAtom" |> NamespacedName

    /// <summary>
    /// consists of argument1 (owl:Thing) and argument2 (owl:Thing)
    /// <see href="http://www.w3.org/2003/11/swrl#DifferentIndividualsAtom"></see></summary>
    let DifferentIndividualsAtom =
        Namespaced_IRI.parse _namespace_name "DifferentIndividualsAtom" |> NamespacedName

    /// <summary>
    /// implication (rule)
    /// <see href="http://www.w3.org/2003/11/swrl#Imp"></see></summary>
    let Imp = Namespaced_IRI.parse _namespace_name "Imp" |> NamespacedName

    /// <summary>
    /// consists of a propertyPredicate (owl:ObjectProperty), argument1 (owl:Thing), and argument2 (owl:Thing)
    /// <see href="http://www.w3.org/2003/11/swrl#IndividualPropertyAtom"></see></summary>
    let IndividualPropertyAtom =
        Namespaced_IRI.parse _namespace_name "IndividualPropertyAtom" |> NamespacedName

    /// <summary>
    /// consists of argument1 (owl:Thing) and argument2 (owl:Thing)
    /// <see href="http://www.w3.org/2003/11/swrl#SameIndividualAtom"></see></summary>
    let SameIndividualAtom =
        Namespaced_IRI.parse _namespace_name "SameIndividualAtom" |> NamespacedName

    /// <summary>
    /// indicate that a URI is being used as a variable
    /// <see href="http://www.w3.org/2003/11/swrl#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#argument1"></see>
    /// </summary>
    let argument1 = Namespaced_IRI.parse _namespace_name "argument1" |> NamespacedName
    /// <summary>
    /// can be a Literal or Resource
    /// <see href="http://www.w3.org/2003/11/swrl#argument2"></see></summary>
    let argument2 = Namespaced_IRI.parse _namespace_name "argument2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#arguments"></see>
    /// </summary>
    let arguments = Namespaced_IRI.parse _namespace_name "arguments" |> NamespacedName
    /// <summary>
    /// rule body (antecedent):  List of Atom
    /// <see href="http://www.w3.org/2003/11/swrl#body"></see></summary>
    let body = Namespaced_IRI.parse _namespace_name "body" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#builtin"></see>
    /// </summary>
    let builtin = Namespaced_IRI.parse _namespace_name "builtin" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#classPredicate"></see>
    /// </summary>
    let classPredicate =
        Namespaced_IRI.parse _namespace_name "classPredicate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#dataRange"></see>
    /// </summary>
    let dataRange = Namespaced_IRI.parse _namespace_name "dataRange" |> NamespacedName
    /// <summary>
    /// rule head (consequent):  List of Atom
    /// <see href="http://www.w3.org/2003/11/swrl#head"></see></summary>
    let head = Namespaced_IRI.parse _namespace_name "head" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#propertyPredicate"></see>
    /// </summary>
    let propertyPredicate =
        Namespaced_IRI.parse _namespace_name "propertyPredicate" |> NamespacedName
