namespace https.w3id.org.iadopt.ont.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module iadopt =
    let _namespace_iri = Namespace_Iri iadopt |> NamespaceIRI
    /// <summary>
    ///   <para>iadopt:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Variable has a Property that characterizes an Entity.</para>
    /// labels<para>hasProperty</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/hasProperty">https://w3id.org/iadopt/ont/hasProperty</seealso>
    let hasProperty = Prefixed_Name(iadopt, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:hasMatrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Variable might have an Entity in which the ObjectOfInterest is contained.</para>
    /// labels<para>hasMatrix</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/hasMatrix">https://w3id.org/iadopt/ont/hasMatrix</seealso>
    let hasMatrix = Prefixed_Name(iadopt, "hasMatrix") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:0.9.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/0.9.1">https://w3id.org/iadopt/ont/0.9.1</seealso>
    let ``_0.9.1`` = Prefixed_Name(iadopt, "0.9.1") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of a characteristic of the ObjectOfInterest.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/Property">https://w3id.org/iadopt/ont/Property</seealso>
    let Property = Prefixed_Name(iadopt, "Property") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description of something observed or derived, minimally consisting of  an ObjectOfInterest and its Property.</para>
    /// labels<para>Variable</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/Variable">https://w3id.org/iadopt/ont/Variable</seealso>
    let Variable = Prefixed_Name(iadopt, "Variable") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Constraint limits the scope of the observation and confines the context to a particular state. It describes properties of the involved entities that are relevant to the particular observation.</para>
    /// labels<para>Constraint</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/Constraint">https://w3id.org/iadopt/ont/Constraint</seealso>
    let Constraint = Prefixed_Name(iadopt, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object or process that has a role in an observation. An Entity may play one of the following roles: ObjectOfInterest, ContextObject, Matrix. Whether the involvement of a particular entity is meaningful enough to include in the variable description depends on the specific context.</para>
    /// labels<para>Entity</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/Entity">https://w3id.org/iadopt/ont/Entity</seealso>
    let Entity = Prefixed_Name(iadopt, "Entity") |> PrefixedName

    /// <summary>
    ///   <para>iadopt:hasObjectOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Variable has an Entity whose Property is observed.</para>
    /// labels<para>hasObjectOfInterest</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/hasObjectOfInterest">https://w3id.org/iadopt/ont/hasObjectOfInterest</seealso>
    let hasObjectOfInterest =
        Prefixed_Name(iadopt, "hasObjectOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>iadopt:constrains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Constraint constrains an Entity having a role in the Variable description.</para>
    /// labels<para>constrains</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/constrains">https://w3id.org/iadopt/ont/constrains</seealso>
    let constrains = Prefixed_Name(iadopt, "constrains") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:hasContextObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Variable has an Entity that provides additional background information regarding the ObjectOfInterest.</para>
    /// labels<para>hasContextObject</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/hasContextObject">https://w3id.org/iadopt/ont/hasContextObject</seealso>
    let hasContextObject = Prefixed_Name(iadopt, "hasContextObject") |> PrefixedName
    /// <summary>
    ///   <para>iadopt:hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Variable has a Constraint, that confines an Entity involved in the observation.</para>
    /// labels<para>hasConstraint</para></remarks>
    /// <seealso href="https://w3id.org/iadopt/ont/hasConstraint">https://w3id.org/iadopt/ont/hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(iadopt, "hasConstraint") |> PrefixedName
