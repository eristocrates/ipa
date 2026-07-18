namespace http.ns.inria.fr.emoca.hash

open DoxAletheia.Rdf_Vocabulary

module emotion =
    let _namespace_name = "http://ns.inria.fr/emoca#"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Anger"></see>
    /// </summary>
    let Anger = Namespaced_IRI.parse _namespace_name "Anger" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Emotion"></see>
    /// </summary>
    let Emotion = Namespaced_IRI.parse _namespace_name "Emotion" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Arousal"></see>
    /// </summary>
    let Arousal = Namespaced_IRI.parse _namespace_name "Arousal" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Component"></see>
    /// </summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Coordinate"></see>
    /// </summary>
    let Coordinate = Namespaced_IRI.parse _namespace_name "Coordinate" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Disgust"></see>
    /// </summary>
    let Disgust = Namespaced_IRI.parse _namespace_name "Disgust" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Fear"></see>
    /// </summary>
    let Fear = Namespaced_IRI.parse _namespace_name "Fear" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Impact"></see>
    /// </summary>
    let Impact = Namespaced_IRI.parse _namespace_name "Impact" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Joy"></see>
    /// </summary>
    let Joy = Namespaced_IRI.parse _namespace_name "Joy" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Radius"></see>
    /// </summary>
    let Radius = Namespaced_IRI.parse _namespace_name "Radius" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Sadness"></see>
    /// </summary>
    let Sadness = Namespaced_IRI.parse _namespace_name "Sadness" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Stimulus"></see>
    /// </summary>
    let Stimulus = Namespaced_IRI.parse _namespace_name "Stimulus" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Surprise"></see>
    /// </summary>
    let Surprise = Namespaced_IRI.parse _namespace_name "Surprise" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Trait"></see>
    /// </summary>
    let Trait = Namespaced_IRI.parse _namespace_name "Trait" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Valence"></see>
    /// </summary>
    let Valence = Namespaced_IRI.parse _namespace_name "Valence" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasEffect"></see>
    /// </summary>
    let hasEffect = Namespaced_IRI.parse _namespace_name "hasEffect" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasImpact"></see>
    /// </summary>
    let hasImpact = Namespaced_IRI.parse _namespace_name "hasImpact" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasMaximum"></see>
    /// </summary>
    let hasMaximum = Namespaced_IRI.parse _namespace_name "hasMaximum" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasMinimum"></see>
    /// </summary>
    let hasMinimum = Namespaced_IRI.parse _namespace_name "hasMinimum" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasTrait"></see>
    /// </summary>
    let hasTrait = Namespaced_IRI.parse _namespace_name "hasTrait" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#involves"></see>
    /// </summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#isDefinedBy"></see>
    /// </summary>
    let isDefinedBy =
        Namespaced_IRI.parse _namespace_name "isDefinedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#pertainsTo"></see>
    /// </summary>
    let pertainsTo = Namespaced_IRI.parse _namespace_name "pertainsTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#relatesTo"></see>
    /// </summary>
    let relatesTo = Namespaced_IRI.parse _namespace_name "relatesTo" |> NamespacedName
