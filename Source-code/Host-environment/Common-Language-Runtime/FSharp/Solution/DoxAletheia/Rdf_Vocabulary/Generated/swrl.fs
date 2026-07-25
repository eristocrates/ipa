namespace http.www.w3.org._2003._11.swrl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swrl =
    let _namespace_iri = Namespace_Iri swrl |> NamespaceIRI
    /// <summary>
    ///   <para>swrl:Builtin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#Builtin">http://www.w3.org/2003/11/swrl#Builtin</seealso>
    let Builtin = Prefixed_Name(swrl, "Builtin") |> PrefixedName
    /// <summary>
    ///   <para>swrl:DataRangeAtom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>consists of a dataRange and argument1</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#DataRangeAtom">http://www.w3.org/2003/11/swrl#DataRangeAtom</seealso>
    let DataRangeAtom = Prefixed_Name(swrl, "DataRangeAtom") |> PrefixedName

    /// <summary>
    ///   <para>swrl:DatavaluedPropertyAtom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>consists of a propertyPredicate (owl:DatatypeProperty), argument1 (owl:Thing), and argument2 (rdfs:Literal)</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#DatavaluedPropertyAtom">http://www.w3.org/2003/11/swrl#DatavaluedPropertyAtom</seealso>
    let DatavaluedPropertyAtom =
        Prefixed_Name(swrl, "DatavaluedPropertyAtom") |> PrefixedName

    /// <summary>
    ///   <para>swrl:Imp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>implication (rule)</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#Imp">http://www.w3.org/2003/11/swrl#Imp</seealso>
    let Imp = Prefixed_Name(swrl, "Imp") |> PrefixedName

    /// <summary>
    ///   <para>swrl:IndividualPropertyAtom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>consists of a propertyPredicate (owl:ObjectProperty), argument1 (owl:Thing), and argument2 (owl:Thing)</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#IndividualPropertyAtom">http://www.w3.org/2003/11/swrl#IndividualPropertyAtom</seealso>
    let IndividualPropertyAtom =
        Prefixed_Name(swrl, "IndividualPropertyAtom") |> PrefixedName

    /// <summary>
    ///   <para>swrl:BuiltinAtom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>consists of a builtin and a List of arguments</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#BuiltinAtom">http://www.w3.org/2003/11/swrl#BuiltinAtom</seealso>
    let BuiltinAtom = Prefixed_Name(swrl, "BuiltinAtom") |> PrefixedName

    /// <summary>
    ///   <para>swrl:DifferentIndividualsAtom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>consists of argument1 (owl:Thing) and argument2 (owl:Thing)</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#DifferentIndividualsAtom">http://www.w3.org/2003/11/swrl#DifferentIndividualsAtom</seealso>
    let DifferentIndividualsAtom =
        Prefixed_Name(swrl, "DifferentIndividualsAtom") |> PrefixedName

    /// <summary>
    ///   <para>swrl:argument2</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>can be a Literal or Resource</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#argument2">http://www.w3.org/2003/11/swrl#argument2</seealso>
    let argument2 = Prefixed_Name(swrl, "argument2") |> PrefixedName
    /// <summary>
    ///   <para>swrl:builtin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#builtin">http://www.w3.org/2003/11/swrl#builtin</seealso>
    let builtin = Prefixed_Name(swrl, "builtin") |> PrefixedName
    /// <summary>
    ///   <para>swrl:SameIndividualAtom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>consists of argument1 (owl:Thing) and argument2 (owl:Thing)</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#SameIndividualAtom">http://www.w3.org/2003/11/swrl#SameIndividualAtom</seealso>
    let SameIndividualAtom = Prefixed_Name(swrl, "SameIndividualAtom") |> PrefixedName
    /// <summary>
    ///   <para>swrl:argument1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#argument1">http://www.w3.org/2003/11/swrl#argument1</seealso>
    let argument1 = Prefixed_Name(swrl, "argument1") |> PrefixedName
    /// <summary>
    ///   <para>swrl:body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>rule body (antecedent):  List of Atom</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#body">http://www.w3.org/2003/11/swrl#body</seealso>
    let body = Prefixed_Name(swrl, "body") |> PrefixedName
    /// <summary>
    ///   <para>swrl:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>indicate that a URI is being used as a variable</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#Variable">http://www.w3.org/2003/11/swrl#Variable</seealso>
    let Variable = Prefixed_Name(swrl, "Variable") |> PrefixedName
    /// <summary>
    ///   <para>swrl:arguments</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#arguments">http://www.w3.org/2003/11/swrl#arguments</seealso>
    let arguments = Prefixed_Name(swrl, "arguments") |> PrefixedName
    /// <summary>
    ///   <para>swrl:classPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#classPredicate">http://www.w3.org/2003/11/swrl#classPredicate</seealso>
    let classPredicate = Prefixed_Name(swrl, "classPredicate") |> PrefixedName
    /// <summary>
    ///   <para>swrl:head</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>rule head (consequent):  List of Atom</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#head">http://www.w3.org/2003/11/swrl#head</seealso>
    let head = Prefixed_Name(swrl, "head") |> PrefixedName
    /// <summary>
    ///   <para>swrl:propertyPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#propertyPredicate">http://www.w3.org/2003/11/swrl#propertyPredicate</seealso>
    let propertyPredicate = Prefixed_Name(swrl, "propertyPredicate") |> PrefixedName
    /// <summary>
    ///   <para>swrl:dataRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#dataRange">http://www.w3.org/2003/11/swrl#dataRange</seealso>
    let dataRange = Prefixed_Name(swrl, "dataRange") |> PrefixedName
    /// <summary>
    ///   <para>swrl:Atom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>common superclass</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#Atom">http://www.w3.org/2003/11/swrl#Atom</seealso>
    let Atom = Prefixed_Name(swrl, "Atom") |> PrefixedName
    /// <summary>
    ///   <para>swrl:ClassAtom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>consists of a classPredicate and argument1</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrl#ClassAtom">http://www.w3.org/2003/11/swrl#ClassAtom</seealso>
    let ClassAtom = Prefixed_Name(swrl, "ClassAtom") |> PrefixedName
