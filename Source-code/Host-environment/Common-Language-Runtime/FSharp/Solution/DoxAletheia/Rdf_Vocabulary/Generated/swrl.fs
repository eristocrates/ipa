namespace http.www.w3.org._2003._11.swrl.hash

open DoxAletheia

module swrl =
    let _namespace_name = "http://www.w3.org/2003/11/swrl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// common superclass
    /// <see href="http://www.w3.org/2003/11/swrl#Atom"></see></summary>
    let Atom = _prefix "Atom"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#Builtin"></see>
    /// </summary>
    let Builtin = _prefix "Builtin"
    /// <summary>
    /// consists of a builtin and a List of arguments
    /// <see href="http://www.w3.org/2003/11/swrl#BuiltinAtom"></see></summary>
    let BuiltinAtom = _prefix "BuiltinAtom"
    /// <summary>
    /// consists of a classPredicate and argument1
    /// <see href="http://www.w3.org/2003/11/swrl#ClassAtom"></see></summary>
    let ClassAtom = _prefix "ClassAtom"
    /// <summary>
    /// consists of a dataRange and argument1
    /// <see href="http://www.w3.org/2003/11/swrl#DataRangeAtom"></see></summary>
    let DataRangeAtom = _prefix "DataRangeAtom"
    /// <summary>
    /// consists of a propertyPredicate (owl:DatatypeProperty), argument1 (owl:Thing), and argument2 (rdfs:Literal)
    /// <see href="http://www.w3.org/2003/11/swrl#DatavaluedPropertyAtom"></see></summary>
    let DatavaluedPropertyAtom = _prefix "DatavaluedPropertyAtom"
    /// <summary>
    /// consists of argument1 (owl:Thing) and argument2 (owl:Thing)
    /// <see href="http://www.w3.org/2003/11/swrl#DifferentIndividualsAtom"></see></summary>
    let DifferentIndividualsAtom = _prefix "DifferentIndividualsAtom"
    /// <summary>
    /// implication (rule)
    /// <see href="http://www.w3.org/2003/11/swrl#Imp"></see></summary>
    let Imp = _prefix "Imp"
    /// <summary>
    /// consists of a propertyPredicate (owl:ObjectProperty), argument1 (owl:Thing), and argument2 (owl:Thing)
    /// <see href="http://www.w3.org/2003/11/swrl#IndividualPropertyAtom"></see></summary>
    let IndividualPropertyAtom = _prefix "IndividualPropertyAtom"
    /// <summary>
    /// consists of argument1 (owl:Thing) and argument2 (owl:Thing)
    /// <see href="http://www.w3.org/2003/11/swrl#SameIndividualAtom"></see></summary>
    let SameIndividualAtom = _prefix "SameIndividualAtom"
    /// <summary>
    /// indicate that a URI is being used as a variable
    /// <see href="http://www.w3.org/2003/11/swrl#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#argument1"></see>
    /// </summary>
    let argument1 = _prefix "argument1"
    /// <summary>
    /// can be a Literal or Resource
    /// <see href="http://www.w3.org/2003/11/swrl#argument2"></see></summary>
    let argument2 = _prefix "argument2"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#arguments"></see>
    /// </summary>
    let arguments = _prefix "arguments"
    /// <summary>
    /// rule body (antecedent):  List of Atom
    /// <see href="http://www.w3.org/2003/11/swrl#body"></see></summary>
    let body = _prefix "body"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#builtin"></see>
    /// </summary>
    let builtin = _prefix "builtin"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#classPredicate"></see>
    /// </summary>
    let classPredicate = _prefix "classPredicate"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#dataRange"></see>
    /// </summary>
    let dataRange = _prefix "dataRange"
    /// <summary>
    /// rule head (consequent):  List of Atom
    /// <see href="http://www.w3.org/2003/11/swrl#head"></see></summary>
    let head = _prefix "head"
    /// <summary>
    ///   <see href="http://www.w3.org/2003/11/swrl#propertyPredicate"></see>
    /// </summary>
    let propertyPredicate = _prefix "propertyPredicate"
