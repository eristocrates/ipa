namespace https.w3id.org._function.vocabulary.composition.hash

open DoxAletheia.Rdf_Vocabulary

module fnoc =
    let _namespace_name = "https://w3id.org/function/vocabulary/composition#"

    /// <summary>
    /// Represents a composition of [fno:Function] individuals
    /// <see href="https://w3id.org/function/vocabulary/composition#Composition"></see></summary>
    let Composition =
        Namespaced_IRI.parse _namespace_name "Composition" |> NamespacedName

    /// <summary>
    /// Connects one [fno:Function]'s [fno:Parameter] or [fno:Output] to another function's
    ///     parameter or output. The properties used for this are [:mapFrom] and [:mapTo] . Exception: mapping from a parameter
    ///      to an output allowed. Alternatively, a [:CompositionMapping] can link to a constant term via [:mapFromTerm] instead of [:mapFrom].
    /// <see href="https://w3id.org/function/vocabulary/composition#CompositionMapping"></see></summary>
    let CompositionMapping =
        Namespaced_IRI.parse _namespace_name "CompositionMapping" |> NamespacedName

    /// <summary>
    /// The `source` or `target` of a [:CompositionMapping], defining a combination of [fno:Function] and either [fno:Parameter] or [fno:Output].
    /// <see href="https://w3id.org/function/vocabulary/composition#CompositionMappingEndpoint"></see></summary>
    let CompositionMappingEndpoint =
        Namespaced_IRI.parse _namespace_name "CompositionMappingEndpoint" |> NamespacedName

    /// <summary>
    /// Associates a constant term with a [fno:Parameter] in the specification of a [:PartiallyAppliedFunction]. The constant term is referenced via [:boundToTerm], the parameter via [:boundParameter].
    /// <see href="https://w3id.org/function/vocabulary/composition#ParameterBinding"></see></summary>
    let ParameterBinding =
        Namespaced_IRI.parse _namespace_name "ParameterBinding" |> NamespacedName

    /// <summary>
    /// A [fno:Function] derived from another function by providing one or more, but not all parameter values.
    /// <see href="https://w3id.org/function/vocabulary/composition#PartiallyAppliedFunction"></see></summary>
    let PartiallyAppliedFunction =
        Namespaced_IRI.parse _namespace_name "PartiallyAppliedFunction" |> NamespacedName

    /// <summary>
    /// Indicates that the [fno:Function] in the subject is a distinct application of the function in the
    ///                       object of the triple. The distinct application has the same properties as the original. This construction allows
    ///                       for making assertions about different applications of the same function.
    /// <see href="https://w3id.org/function/vocabulary/composition#applies"></see></summary>
    let applies = Namespaced_IRI.parse _namespace_name "applies" |> NamespacedName

    /// <summary>
    /// Specifies the [:Parameter] of a [:ParameterBinding].
    /// <see href="https://w3id.org/function/vocabulary/composition#boundParameter"></see></summary>
    let boundParameter =
        Namespaced_IRI.parse _namespace_name "boundParameter" |> NamespacedName

    /// <summary>
    /// Specifies the constant value of a [:ParameterBinding], which can be any RDF term.
    /// <see href="https://w3id.org/function/vocabulary/composition#boundToTerm"></see></summary>
    let boundToTerm =
        Namespaced_IRI.parse _namespace_name "boundToTerm" |> NamespacedName

    /// <summary>
    /// Connects a [:Composition] with the [:CompositionMapping]s that define it.
    /// <see href="https://w3id.org/function/vocabulary/composition#composedOf"></see></summary>
    let composedOf = Namespaced_IRI.parse _namespace_name "composedOf" |> NamespacedName

    /// <summary>
    /// Defines
    /// <see href="https://w3id.org/function/vocabulary/composition#constituentFunction"></see></summary>
    let constituentFunction =
        Namespaced_IRI.parse _namespace_name "constituentFunction" |> NamespacedName

    /// <summary>
    /// References the [fno:Output] of a [fno:Function] as the `source` or the `target` of a [fno:CompositionMapping].
    /// <see href="https://w3id.org/function/vocabulary/composition#functionOutput"></see></summary>
    let functionOutput =
        Namespaced_IRI.parse _namespace_name "functionOutput" |> NamespacedName

    /// <summary>
    /// References the [fno:Parameter] of a [fno:Function] as the `source` or the `target` of a [fno:CompositionMapping].
    /// <see href="https://w3id.org/function/vocabulary/composition#functionParameter"></see></summary>
    let functionParameter =
        Namespaced_IRI.parse _namespace_name "functionParameter" |> NamespacedName

    /// <summary>
    /// Links a [:CompopsitionMapping] to its `source` [:CompositionMappingEndpoint]
    /// <see href="https://w3id.org/function/vocabulary/composition#mapFrom"></see></summary>
    let mapFrom = Namespaced_IRI.parse _namespace_name "mapFrom" |> NamespacedName

    /// <summary>
    /// Defines a constant term (literal or resource) as the `source` endpoint of a [:CompositionMapping].
    /// <see href="https://w3id.org/function/vocabulary/composition#mapFromTerm"></see></summary>
    let mapFromTerm =
        Namespaced_IRI.parse _namespace_name "mapFromTerm" |> NamespacedName

    /// <summary>
    /// Links a [:CompopsitionMapping] to its `target` [:CompositionMappingEndpoint]
    /// <see href="https://w3id.org/function/vocabulary/composition#mapTo"></see></summary>
    let mapTo = Namespaced_IRI.parse _namespace_name "mapTo" |> NamespacedName

    /// <summary>
    /// Specifies a [:ParameterBinding] of a [:PartiallyAppliedFunction].
    /// <see href="https://w3id.org/function/vocabulary/composition#parameterBinding"></see></summary>
    let parameterBinding =
        Namespaced_IRI.parse _namespace_name "parameterBinding" |> NamespacedName

    /// <summary>
    /// Expresses that the [fno:Function] in the subject is a partial application of the [fno:Function] referenced by the object.
    ///                   It is expected that the partial application provides a constant value for at least one of the function's [fno:Parameter]s.
    ///                    If no parameter values are specified the use of [:partiallyApplies] is equivalent to [:applies].
    /// <see href="https://w3id.org/function/vocabulary/composition#partiallyApplies"></see></summary>
    let partiallyApplies =
        Namespaced_IRI.parse _namespace_name "partiallyApplies" |> NamespacedName
