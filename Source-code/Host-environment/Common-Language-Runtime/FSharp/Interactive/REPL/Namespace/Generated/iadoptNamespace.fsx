#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module iadopt =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/iadopt/ont/" "iadopt"
    let ``_0.9.1`` = _prefixId.prefix "0.9.1"
    /// <summary>
    ///   <para>rdfs:label : Constraint^^xsd:string</para>
    ///   <para>rdfs:comment : A Constraint limits the scope of the observation and confines the context to a particular state. It describes properties of the involved entities that are relevant to the particular observation.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/Constraint">iadopt:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <para>rdfs:comment : An object or process that has a role in an observation. An Entity may play one of the following roles: ObjectOfInterest, ContextObject, Matrix. Whether the involvement of a particular entity is meaningful enough to include in the variable description depends on the specific context.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/Entity">iadopt:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <para>rdfs:comment : A type of a characteristic of the ObjectOfInterest.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/Property">iadopt:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : Variable^^xsd:string</para>
    ///   <para>rdfs:comment : A description of something observed or derived, minimally consisting of  an ObjectOfInterest and its Property.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/Variable">iadopt:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:label : constrains^^xsd:string</para>
    ///   <para>rdfs:comment : A Constraint constrains an Entity having a role in the Variable description.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/constrains">iadopt:constrains</a>
    /// </summary>
    let constrains = _prefixId.prefix "constrains"
    /// <summary>
    ///   <para>rdfs:label : hasConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : A Variable has a Constraint, that confines an Entity involved in the observation.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/hasConstraint">iadopt:hasConstraint</a>
    /// </summary>
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>rdfs:label : hasContextObject^^xsd:string</para>
    ///   <para>rdfs:comment : A Variable has an Entity that provides additional background information regarding the ObjectOfInterest.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/hasContextObject">iadopt:hasContextObject</a>
    /// </summary>
    let hasContextObject = _prefixId.prefix "hasContextObject"
    /// <summary>
    ///   <para>rdfs:label : hasMatrix^^xsd:string</para>
    ///   <para>rdfs:comment : A Variable might have an Entity in which the ObjectOfInterest is contained.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/hasMatrix">iadopt:hasMatrix</a>
    /// </summary>
    let hasMatrix = _prefixId.prefix "hasMatrix"
    /// <summary>
    ///   <para>rdfs:label : hasObjectOfInterest^^xsd:string</para>
    ///   <para>rdfs:comment : A Variable has an Entity whose Property is observed.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/hasObjectOfInterest">iadopt:hasObjectOfInterest</a>
    /// </summary>
    let hasObjectOfInterest = _prefixId.prefix "hasObjectOfInterest"
    /// <summary>
    ///   <para>rdfs:label : hasProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A Variable has a Property that characterizes an Entity.^^xsd:string</para>
    ///   <a href="https://w3id.org/iadopt/ont/hasProperty">iadopt:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
