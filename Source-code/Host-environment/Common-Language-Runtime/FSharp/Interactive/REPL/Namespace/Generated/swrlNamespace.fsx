#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module swrl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/11/swrl#" "swrl"
    /// <summary>
    ///   <para>rdfs:comment : common superclass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#Atom">swrl:Atom</a>
    /// </summary>
    let Atom = _prefixId.prefix "Atom"
    let Builtin = _prefixId.prefix "Builtin"
    /// <summary>
    ///   <para>rdfs:comment : consists of a builtin and a List of arguments^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#BuiltinAtom">swrl:BuiltinAtom</a>
    /// </summary>
    let BuiltinAtom = _prefixId.prefix "BuiltinAtom"
    /// <summary>
    ///   <para>rdfs:comment : consists of a classPredicate and argument1^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#ClassAtom">swrl:ClassAtom</a>
    /// </summary>
    let ClassAtom = _prefixId.prefix "ClassAtom"
    /// <summary>
    ///   <para>rdfs:comment : consists of a dataRange and argument1^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#DataRangeAtom">swrl:DataRangeAtom</a>
    /// </summary>
    let DataRangeAtom = _prefixId.prefix "DataRangeAtom"
    /// <summary>
    ///   <para>rdfs:comment : consists of a propertyPredicate (owl:DatatypeProperty), argument1 (owl:Thing), and argument2 (rdfs:Literal)^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#DatavaluedPropertyAtom">swrl:DatavaluedPropertyAtom</a>
    /// </summary>
    let DatavaluedPropertyAtom = _prefixId.prefix "DatavaluedPropertyAtom"
    /// <summary>
    ///   <para>rdfs:comment : consists of argument1 (owl:Thing) and argument2 (owl:Thing)^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#DifferentIndividualsAtom">swrl:DifferentIndividualsAtom</a>
    /// </summary>
    let DifferentIndividualsAtom = _prefixId.prefix "DifferentIndividualsAtom"
    /// <summary>
    ///   <para>rdfs:comment : implication (rule)^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#Imp">swrl:Imp</a>
    /// </summary>
    let Imp = _prefixId.prefix "Imp"
    /// <summary>
    ///   <para>rdfs:comment : consists of a propertyPredicate (owl:ObjectProperty), argument1 (owl:Thing), and argument2 (owl:Thing)^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#IndividualPropertyAtom">swrl:IndividualPropertyAtom</a>
    /// </summary>
    let IndividualPropertyAtom = _prefixId.prefix "IndividualPropertyAtom"
    /// <summary>
    ///   <para>rdfs:comment : consists of argument1 (owl:Thing) and argument2 (owl:Thing)^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#SameIndividualAtom">swrl:SameIndividualAtom</a>
    /// </summary>
    let SameIndividualAtom = _prefixId.prefix "SameIndividualAtom"
    /// <summary>
    ///   <para>rdfs:comment : indicate that a URI is being used as a variable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#Variable">swrl:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    let argument1 = _prefixId.prefix "argument1"
    /// <summary>
    ///   <para>rdfs:comment : can be a Literal or Resource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#argument2">swrl:argument2</a>
    /// </summary>
    let argument2 = _prefixId.prefix "argument2"
    let arguments = _prefixId.prefix "arguments"
    /// <summary>
    ///   <para>rdfs:comment : rule body (antecedent):  List of Atom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#body">swrl:body</a>
    /// </summary>
    let body = _prefixId.prefix "body"
    let builtin = _prefixId.prefix "builtin"
    let classPredicate = _prefixId.prefix "classPredicate"
    let dataRange = _prefixId.prefix "dataRange"
    /// <summary>
    ///   <para>rdfs:comment : rule head (consequent):  List of Atom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/11/swrl#head">swrl:head</a>
    /// </summary>
    let head = _prefixId.prefix "head"
    let propertyPredicate = _prefixId.prefix "propertyPredicate"
