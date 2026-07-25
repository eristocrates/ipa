namespace https.w3id.org._function.vocabulary.composition.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3compo =
    let _namespace_iri = Namespace_Iri w3compo |> NamespaceIRI

    /// <summary>
    ///   <para>w3compo:CompositionMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connects one [fno:Function]'s [fno:Parameter] or [fno:Output] to another function's
    ///     parameter or output. The properties used for this are [:mapFrom] and [:mapTo] . Exception: mapping from a parameter
    ///      to an output allowed. Alternatively, a [:CompositionMapping] can link to a constant term via [:mapFromTerm] instead of [:mapFrom].</para>
    /// labels<para>CompositionMapping</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#CompositionMapping">https://w3id.org/function/vocabulary/composition#CompositionMapping</seealso>
    let CompositionMapping =
        Prefixed_Name(w3compo, "CompositionMapping") |> PrefixedName

    /// <summary>
    ///   <para>w3compo:PartiallyAppliedFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A [fno:Function] derived from another function by providing one or more, but not all parameter values.</para>
    /// labels<para>PartiallyAppliedFunction</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#PartiallyAppliedFunction">https://w3id.org/function/vocabulary/composition#PartiallyAppliedFunction</seealso>
    let PartiallyAppliedFunction =
        Prefixed_Name(w3compo, "PartiallyAppliedFunction") |> PrefixedName

    /// <summary>
    ///   <para>w3compo:mapFromTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a constant term (literal or resource) as the `source` endpoint of a [:CompositionMapping].</para>
    /// labels<para>mapFromTerm</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#mapFromTerm">https://w3id.org/function/vocabulary/composition#mapFromTerm</seealso>
    let mapFromTerm = Prefixed_Name(w3compo, "mapFromTerm") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:Composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a composition of [fno:Function] individuals</para>
    /// labels<para>Composition</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#Composition">https://w3id.org/function/vocabulary/composition#Composition</seealso>
    let Composition = Prefixed_Name(w3compo, "Composition") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:ParameterBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Associates a constant term with a [fno:Parameter] in the specification of a [:PartiallyAppliedFunction]. The constant term is referenced via [:boundToTerm], the parameter via [:boundParameter].</para>
    /// labels<para>:ParameterBinding</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#ParameterBinding">https://w3id.org/function/vocabulary/composition#ParameterBinding</seealso>
    let ParameterBinding = Prefixed_Name(w3compo, "ParameterBinding") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:boundParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the [:Parameter] of a [:ParameterBinding].</para>
    /// labels<para>:boundParameter</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#boundParameter">https://w3id.org/function/vocabulary/composition#boundParameter</seealso>
    let boundParameter = Prefixed_Name(w3compo, "boundParameter") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:composedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a [:Composition] with the [:CompositionMapping]s that define it.</para>
    /// labels<para>composedOf</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#composedOf">https://w3id.org/function/vocabulary/composition#composedOf</seealso>
    let composedOf = Prefixed_Name(w3compo, "composedOf") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:functionOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>References the [fno:Output] of a [fno:Function] as the `source` or the `target` of a [fno:CompositionMapping].</para>
    /// labels<para>functionOutput</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#functionOutput">https://w3id.org/function/vocabulary/composition#functionOutput</seealso>
    let functionOutput = Prefixed_Name(w3compo, "functionOutput") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:functionParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>References the [fno:Parameter] of a [fno:Function] as the `source` or the `target` of a [fno:CompositionMapping].</para>
    /// labels<para>functionParameter</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#functionParameter">https://w3id.org/function/vocabulary/composition#functionParameter</seealso>
    let functionParameter = Prefixed_Name(w3compo, "functionParameter") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:mapTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a [:CompopsitionMapping] to its `target` [:CompositionMappingEndpoint]</para>
    /// labels<para>mapTo</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#mapTo">https://w3id.org/function/vocabulary/composition#mapTo</seealso>
    let mapTo = Prefixed_Name(w3compo, "mapTo") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:parameterBinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies a [:ParameterBinding] of a [:PartiallyAppliedFunction].</para>
    /// labels<para>::parameterBinding</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#parameterBinding">https://w3id.org/function/vocabulary/composition#parameterBinding</seealso>
    let parameterBinding = Prefixed_Name(w3compo, "parameterBinding") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>
    /// - Version 0.1.0: creation.</para>
    /// labels<para>The Function Ontology - Composition vocabulary</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#">https://w3id.org/function/vocabulary/composition#</seealso>
    let _prefix_iri = Prefixed_Name(w3compo, "") |> PrefixedName

    /// <summary>
    ///   <para>w3compo:CompositionMappingEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The `source` or `target` of a [:CompositionMapping], defining a combination of [fno:Function] and either [fno:Parameter] or [fno:Output].</para>
    /// labels<para>CompositionMappingEndpoint</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#CompositionMappingEndpoint">https://w3id.org/function/vocabulary/composition#CompositionMappingEndpoint</seealso>
    let CompositionMappingEndpoint =
        Prefixed_Name(w3compo, "CompositionMappingEndpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3compo:applies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the [fno:Function] in the subject is a distinct application of the function in the
    ///                       object of the triple. The distinct application has the same properties as the original. This construction allows
    ///                       for making assertions about different applications of the same function.</para>
    /// labels<para>applies</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#applies">https://w3id.org/function/vocabulary/composition#applies</seealso>
    let applies = Prefixed_Name(w3compo, "applies") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:boundToTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the constant value of a [:ParameterBinding], which can be any RDF term.</para>
    /// labels<para>:boundToTerm</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#boundToTerm">https://w3id.org/function/vocabulary/composition#boundToTerm</seealso>
    let boundToTerm = Prefixed_Name(w3compo, "boundToTerm") |> PrefixedName

    /// <summary>
    ///   <para>w3compo:constituentFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines </para>
    /// labels<para>constituentFunction</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#constituentFunction">https://w3id.org/function/vocabulary/composition#constituentFunction</seealso>
    let constituentFunction =
        Prefixed_Name(w3compo, "constituentFunction") |> PrefixedName

    /// <summary>
    ///   <para>w3compo:mapFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a [:CompopsitionMapping] to its `source` [:CompositionMappingEndpoint]</para>
    /// labels<para>mapFrom</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#mapFrom">https://w3id.org/function/vocabulary/composition#mapFrom</seealso>
    let mapFrom = Prefixed_Name(w3compo, "mapFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3compo:partiallyApplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Expresses that the [fno:Function] in the subject is a partial application of the [fno:Function] referenced by the object.
    ///                   It is expected that the partial application provides a constant value for at least one of the function's [fno:Parameter]s.
    ///                    If no parameter values are specified the use of [:partiallyApplies] is equivalent to [:applies].</para>
    /// labels<para>partiallyApplies</para></remarks>
    /// <seealso href="https://w3id.org/function/vocabulary/composition#partiallyApplies">https://w3id.org/function/vocabulary/composition#partiallyApplies</seealso>
    let partiallyApplies = Prefixed_Name(w3compo, "partiallyApplies") |> PrefixedName
