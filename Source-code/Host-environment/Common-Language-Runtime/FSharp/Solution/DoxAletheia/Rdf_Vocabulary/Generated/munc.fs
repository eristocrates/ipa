namespace http.ns.inria.fr.munc.hash

open DoxAletheia

module munc =
    let _namespace_name = "http://ns.inria.fr/munc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The metadata associated to a Sentence in a certain World (Context).
    /// <see href="http://ns.inria.fr/munc#Meta"></see></summary>
    let Meta = _prefix "Meta"
    /// <summary>
    /// The Sentence (Triple, Graph, Graph Pattern) to which Meta is associated in a specific World.
    /// <see href="http://ns.inria.fr/munc#Sentence"></see></summary>
    let Sentence = _prefix "Sentence"
    /// <summary>
    /// Individuals of this class are LDScript functions enabling translating uncertainty information from one approach to another.
    /// <see href="http://ns.inria.fr/munc#TranslationFunction"></see></summary>
    let TranslationFunction = _prefix "TranslationFunction"
    /// <summary>
    /// A subclass of Meta, it enables annotating the Sentence associated to the metadata with uncertainty information.
    /// <see href="http://ns.inria.fr/munc#Uncertainty"></see></summary>
    let Uncertainty = _prefix "Uncertainty"
    /// <summary>
    /// Individuals of this class represent uncertainty approaches, which are detailed in the appendix A.
    /// <see href="http://ns.inria.fr/munc#UncertaintyApproach"></see></summary>
    let UncertaintyApproach = _prefix "UncertaintyApproach"
    /// <summary>
    /// The Calculus to apply on the Values of a defined Uncertainty Feature.
    /// <see href="http://ns.inria.fr/munc#UncertaintyOperation"></see></summary>
    let UncertaintyOperation = _prefix "UncertaintyOperation"
    /// <summary>
    /// For each Uncertainty Feature, exists (when declared) a corresponding value.
    /// <see href="http://ns.inria.fr/munc#UncertaintyValue"></see></summary>
    let UncertaintyValue = _prefix "UncertaintyValue"
    /// <summary>
    /// The context (Graph, Default Graph, etc.) in which the Sentence is associated to Meta. This is used generally by datastores which are unable to represent named graphs.
    /// <see href="http://ns.inria.fr/munc#World"></see></summary>
    let World = _prefix "World"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasFullTranslation"></see>
    /// </summary>
    let hasFullTranslation = _prefix "hasFullTranslation"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasIdealTranslation"></see>
    /// </summary>
    let hasIdealTranslation = _prefix "hasIdealTranslation"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasTranslation"></see>
    /// </summary>
    let hasTranslation = _prefix "hasTranslation"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasMeta"></see>
    /// </summary>
    let hasMeta = _prefix "hasMeta"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasUncertaintyApproach"></see>
    /// </summary>
    let hasUncertaintyApproach = _prefix "hasUncertaintyApproach"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasUncertaintyFeature"></see>
    /// </summary>
    let hasUncertaintyFeature = _prefix "hasUncertaintyFeature"
    /// <summary>
    /// Each Uncertainty approach has some features, which can be metrics or measures to compare, infer or reason over to have a decision about knowledge.
    /// <see href="http://ns.inria.fr/munc#uncertaintyFeature"></see></summary>
    let uncertaintyFeature = _prefix "uncertaintyFeature"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#hasUncertaintyOperator"></see>
    /// </summary>
    let hasUncertaintyOperator = _prefix "hasUncertaintyOperator"
    /// <summary>
    /// Each Uncertainty approach has its own logic to reason over metadata, This class defines the methods that can be applied over Uncertainty Values. Such logic is the same used in reasoners and inference engines.
    /// <see href="http://ns.inria.fr/munc#uncertaintyOperator"></see></summary>
    let uncertaintyOperator = _prefix "uncertaintyOperator"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#statedIn"></see>
    /// </summary>
    let statedIn = _prefix "statedIn"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#translateFrom"></see>
    /// </summary>
    let translateFrom = _prefix "translateFrom"
    /// <summary>
    ///   <see href="http://ns.inria.fr/munc#translateTo"></see>
    /// </summary>
    let translateTo = _prefix "translateTo"
