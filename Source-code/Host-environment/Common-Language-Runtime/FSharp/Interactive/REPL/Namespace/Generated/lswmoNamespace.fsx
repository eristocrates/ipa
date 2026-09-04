#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lswmo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#" "lswmo"

    /// <summary>
    ///   <para>sio:example : Bioclim^^xsd:string</para>
    ///   <para>rdfs:label : species modelling algorithm^^xsd:string</para>
    ///   <para>rdfs:comment : Following SIO's definition of algorithm, a species modelling algorithm is an effective method expressed as a finite list of well-defined instructions for calculating a model about species.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingAlgorithm">lswmo:SpeciesModellingAlgorithm</a>
    /// </summary>
    let SpeciesModellingAlgorithm = _prefixId.prefix "SpeciesModellingAlgorithm"
    /// <summary>
    ///   <para>sio:example : Standard deviation cutoff^^xsd:string</para>
    ///   <para>rdfs:label : species modelling parameter^^xsd:string</para>
    ///   <para>rdfs:comment : Following SIO's definition of parameter, a species modelling parameter  is variable whose value changes the characteristics of a species model.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameter">lswmo:SpeciesModellingParameter</a>
    /// </summary>
    let SpeciesModellingParameter = _prefixId.prefix "SpeciesModellingParameter"
    /// <summary>
    ///   <para>rdfs:label : species modelling parameters^^xsd:string</para>
    ///   <para>rdfs:comment : A set of modelling parameter(s) required by a specific species modeling algorithm.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameters">lswmo:SpeciesModellingParameters</a>
    /// </summary>
    let SpeciesModellingParameters = _prefixId.prefix "SpeciesModellingParameters"
    /// <summary>
    ///   <para>rdfs:label : species modelling software^^xsd:string</para>
    ///   <para>rdfs:comment : Following SIO's definition of software application, a species modelling software is a software that can be directly executed by some processing unit and offers species modelling services.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingSoftware">lswmo:SpeciesModellingSoftware</a>
    /// </summary>
    let SpeciesModellingSoftware = _prefixId.prefix "SpeciesModellingSoftware"
    /// <summary>
    ///   <para>rdfs:label : behaviour controlled by^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#behaviorControlledBy">lswmo:behaviorControlledBy</a>
    /// </summary>
    let behaviorControlledBy = _prefixId.prefix "behaviorControlledBy"
    /// <summary>
    ///   <para>rdfs:label : bound to value^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#boundToValue">lswmo:boundToValue</a>
    /// </summary>
    let boundToValue = _prefixId.prefix "boundToValue"
    /// <summary>
    ///   <para>rdfs:label : controls behavior of^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#controlsBehaviorOf">lswmo:controlsBehaviorOf</a>
    /// </summary>
    let controlsBehaviorOf = _prefixId.prefix "controlsBehaviorOf"
    /// <summary>
    ///   <para>rdfs:label : has algorithm name^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasAlgorithmName">lswmo:hasAlgorithmName</a>
    /// </summary>
    let hasAlgorithmName = _prefixId.prefix "hasAlgorithmName"
    /// <summary>
    ///   <para>rdfs:label : has parameter member^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterMember">lswmo:hasParameterMember</a>
    /// </summary>
    let hasParameterMember = _prefixId.prefix "hasParameterMember"
    /// <summary>
    ///   <para>rdfs:label : has parameter name^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterName">lswmo:hasParameterName</a>
    /// </summary>
    let hasParameterName = _prefixId.prefix "hasParameterName"
    /// <summary>
    ///   <para>rdfs:label : implemented in^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#implementedIn">lswmo:implementedIn</a>
    /// </summary>
    let implementedIn = _prefixId.prefix "implementedIn"
