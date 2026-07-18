namespace http.ns.inria.fr.munc.hash

open DoxAletheia.Rdf_Vocabulary

module munc =
    let _namespace_name = "http://ns.inria.fr/munc#"
    /// <summary>
    /// The metadata associated to a Sentence in a certain World (Context).
    /// <see href="http://ns.inria.fr/munc#Meta"></see></summary>
    let Meta = Namespaced_IRI.parse _namespace_name "Meta" |> NamespacedName
    /// <summary>
    /// The Sentence (Triple, Graph, Graph Pattern) to which Meta is associated in a specific World.
    /// <see href="http://ns.inria.fr/munc#Sentence"></see></summary>
    let Sentence = Namespaced_IRI.parse _namespace_name "Sentence" |> NamespacedName

    /// <summary>
    /// Individuals of this class are LDScript functions enabling translating uncertainty information from one approach to another.
    /// <see href="http://ns.inria.fr/munc#TranslationFunction"></see></summary>
    let TranslationFunction =
        Namespaced_IRI.parse _namespace_name "TranslationFunction" |> NamespacedName

    /// <summary>
    /// A subclass of Meta, it enables annotating the Sentence associated to the metadata with uncertainty information.
    /// <see href="http://ns.inria.fr/munc#Uncertainty"></see></summary>
    let Uncertainty =
        Namespaced_IRI.parse _namespace_name "Uncertainty" |> NamespacedName

    /// <summary>
    /// Individuals of this class represent uncertainty approaches, which are detailed in the appendix A.
    /// <see href="http://ns.inria.fr/munc#UncertaintyApproach"></see></summary>
    let UncertaintyApproach =
        Namespaced_IRI.parse _namespace_name "UncertaintyApproach" |> NamespacedName

    /// <summary>
    /// The Calculus to apply on the Values of a defined Uncertainty Feature.
    /// <see href="http://ns.inria.fr/munc#UncertaintyOperation"></see></summary>
    let UncertaintyOperation =
        Namespaced_IRI.parse _namespace_name "UncertaintyOperation" |> NamespacedName

    /// <summary>
    /// For each Uncertainty Feature, exists (when declared) a corresponding value.
    /// <see href="http://ns.inria.fr/munc#UncertaintyValue"></see></summary>
    let UncertaintyValue =
        Namespaced_IRI.parse _namespace_name "UncertaintyValue" |> NamespacedName

    /// <summary>
    /// The context (Graph, Default Graph, etc.) in which the Sentence is associated to Meta. This is used generally by datastores which are unable to represent named graphs.
    /// <see href="http://ns.inria.fr/munc#World"></see></summary>
    let World = Namespaced_IRI.parse _namespace_name "World" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasFullTranslation"></see>
    /// </summary>
    let hasFullTranslation =
        Namespaced_IRI.parse _namespace_name "hasFullTranslation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasIdealTranslation"></see>
    /// </summary>
    let hasIdealTranslation =
        Namespaced_IRI.parse _namespace_name "hasIdealTranslation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasTranslation"></see>
    /// </summary>
    let hasTranslation =
        Namespaced_IRI.parse _namespace_name "hasTranslation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasMeta"></see>
    /// </summary>
    let hasMeta = Namespaced_IRI.parse _namespace_name "hasMeta" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasUncertaintyApproach"></see>
    /// </summary>
    let hasUncertaintyApproach =
        Namespaced_IRI.parse _namespace_name "hasUncertaintyApproach" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasUncertaintyFeature"></see>
    /// </summary>
    let hasUncertaintyFeature =
        Namespaced_IRI.parse _namespace_name "hasUncertaintyFeature" |> NamespacedName

    /// <summary>
    /// Each Uncertainty approach has some features, which can be metrics or measures to compare, infer or reason over to have a decision about knowledge.
    /// <see href="http://ns.inria.fr/munc#uncertaintyFeature"></see></summary>
    let uncertaintyFeature =
        Namespaced_IRI.parse _namespace_name "uncertaintyFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasUncertaintyOperator"></see>
    /// </summary>
    let hasUncertaintyOperator =
        Namespaced_IRI.parse _namespace_name "hasUncertaintyOperator" |> NamespacedName

    /// <summary>
    /// Each Uncertainty approach has its own logic to reason over metadata, This class defines the methods that can be applied over Uncertainty Values. Such logic is the same used in reasoners and inference engines.
    /// <see href="http://ns.inria.fr/munc#uncertaintyOperator"></see></summary>
    let uncertaintyOperator =
        Namespaced_IRI.parse _namespace_name "uncertaintyOperator" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#statedIn"></see>
    /// </summary>
    let statedIn = Namespaced_IRI.parse _namespace_name "statedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#translateFrom"></see>
    /// </summary>
    let translateFrom =
        Namespaced_IRI.parse _namespace_name "translateFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#translateTo"></see>
    /// </summary>
    let translateTo =
        Namespaced_IRI.parse _namespace_name "translateTo" |> NamespacedName
