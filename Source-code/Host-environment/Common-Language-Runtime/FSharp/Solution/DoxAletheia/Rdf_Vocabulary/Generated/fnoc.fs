namespace https.w3id.org._function.vocabulary.composition.hash

open DoxAletheia

module fnoc =
    let _namespace_name = "https://w3id.org/function/vocabulary/composition#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents a composition of [fno:Function] individuals
    /// <see href="https://w3id.org/function/vocabulary/composition#Composition"></see></summary>
    let Composition = _prefix "Composition"
    /// <summary>
    /// Connects one [fno:Function]'s [fno:Parameter] or [fno:Output] to another function's
    ///     parameter or output. The properties used for this are [:mapFrom] and [:mapTo] . Exception: mapping from a parameter
    ///      to an output allowed. Alternatively, a [:CompositionMapping] can link to a constant term via [:mapFromTerm] instead of [:mapFrom].
    /// <see href="https://w3id.org/function/vocabulary/composition#CompositionMapping"></see></summary>
    let CompositionMapping = _prefix "CompositionMapping"
    /// <summary>
    /// The `source` or `target` of a [:CompositionMapping], defining a combination of [fno:Function] and either [fno:Parameter] or [fno:Output].
    /// <see href="https://w3id.org/function/vocabulary/composition#CompositionMappingEndpoint"></see></summary>
    let CompositionMappingEndpoint = _prefix "CompositionMappingEndpoint"
    /// <summary>
    /// Associates a constant term with a [fno:Parameter] in the specification of a [:PartiallyAppliedFunction]. The constant term is referenced via [:boundToTerm], the parameter via [:boundParameter].
    /// <see href="https://w3id.org/function/vocabulary/composition#ParameterBinding"></see></summary>
    let ParameterBinding = _prefix "ParameterBinding"
    /// <summary>
    /// A [fno:Function] derived from another function by providing one or more, but not all parameter values.
    /// <see href="https://w3id.org/function/vocabulary/composition#PartiallyAppliedFunction"></see></summary>
    let PartiallyAppliedFunction = _prefix "PartiallyAppliedFunction"
    /// <summary>
    /// Indicates that the [fno:Function] in the subject is a distinct application of the function in the
    ///                       object of the triple. The distinct application has the same properties as the original. This construction allows
    ///                       for making assertions about different applications of the same function.
    /// <see href="https://w3id.org/function/vocabulary/composition#applies"></see></summary>
    let applies = _prefix "applies"
    /// <summary>
    /// Specifies the [:Parameter] of a [:ParameterBinding].
    /// <see href="https://w3id.org/function/vocabulary/composition#boundParameter"></see></summary>
    let boundParameter = _prefix "boundParameter"
    /// <summary>
    /// Specifies the constant value of a [:ParameterBinding], which can be any RDF term.
    /// <see href="https://w3id.org/function/vocabulary/composition#boundToTerm"></see></summary>
    let boundToTerm = _prefix "boundToTerm"
    /// <summary>
    /// Connects a [:Composition] with the [:CompositionMapping]s that define it.
    /// <see href="https://w3id.org/function/vocabulary/composition#composedOf"></see></summary>
    let composedOf = _prefix "composedOf"
    /// <summary>
    /// Defines
    /// <see href="https://w3id.org/function/vocabulary/composition#constituentFunction"></see></summary>
    let constituentFunction = _prefix "constituentFunction"
    /// <summary>
    /// References the [fno:Output] of a [fno:Function] as the `source` or the `target` of a [fno:CompositionMapping].
    /// <see href="https://w3id.org/function/vocabulary/composition#functionOutput"></see></summary>
    let functionOutput = _prefix "functionOutput"
    /// <summary>
    /// References the [fno:Parameter] of a [fno:Function] as the `source` or the `target` of a [fno:CompositionMapping].
    /// <see href="https://w3id.org/function/vocabulary/composition#functionParameter"></see></summary>
    let functionParameter = _prefix "functionParameter"
    /// <summary>
    /// Links a [:CompopsitionMapping] to its `source` [:CompositionMappingEndpoint]
    /// <see href="https://w3id.org/function/vocabulary/composition#mapFrom"></see></summary>
    let mapFrom = _prefix "mapFrom"
    /// <summary>
    /// Defines a constant term (literal or resource) as the `source` endpoint of a [:CompositionMapping].
    /// <see href="https://w3id.org/function/vocabulary/composition#mapFromTerm"></see></summary>
    let mapFromTerm = _prefix "mapFromTerm"
    /// <summary>
    /// Links a [:CompopsitionMapping] to its `target` [:CompositionMappingEndpoint]
    /// <see href="https://w3id.org/function/vocabulary/composition#mapTo"></see></summary>
    let mapTo = _prefix "mapTo"
    /// <summary>
    /// Specifies a [:ParameterBinding] of a [:PartiallyAppliedFunction].
    /// <see href="https://w3id.org/function/vocabulary/composition#parameterBinding"></see></summary>
    let parameterBinding = _prefix "parameterBinding"
    /// <summary>
    /// Expresses that the [fno:Function] in the subject is a partial application of the [fno:Function] referenced by the object.
    ///                   It is expected that the partial application provides a constant value for at least one of the function's [fno:Parameter]s.
    ///                    If no parameter values are specified the use of [:partiallyApplies] is equivalent to [:applies].
    /// <see href="https://w3id.org/function/vocabulary/composition#partiallyApplies"></see></summary>
    let partiallyApplies = _prefix "partiallyApplies"
