namespace http.ns.inria.fr.emoca.hash

open DoxAletheia

module emotion =
    let _namespace_name = "http://ns.inria.fr/emoca#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Anger"></see>
    /// </summary>
    let Anger = _prefix "Anger"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Emotion"></see>
    /// </summary>
    let Emotion = _prefix "Emotion"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Arousal"></see>
    /// </summary>
    let Arousal = _prefix "Arousal"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Component"></see>
    /// </summary>
    let Component = _prefix "Component"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Coordinate"></see>
    /// </summary>
    let Coordinate = _prefix "Coordinate"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Disgust"></see>
    /// </summary>
    let Disgust = _prefix "Disgust"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Fear"></see>
    /// </summary>
    let Fear = _prefix "Fear"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Impact"></see>
    /// </summary>
    let Impact = _prefix "Impact"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Joy"></see>
    /// </summary>
    let Joy = _prefix "Joy"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Radius"></see>
    /// </summary>
    let Radius = _prefix "Radius"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Sadness"></see>
    /// </summary>
    let Sadness = _prefix "Sadness"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Stimulus"></see>
    /// </summary>
    let Stimulus = _prefix "Stimulus"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Surprise"></see>
    /// </summary>
    let Surprise = _prefix "Surprise"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Trait"></see>
    /// </summary>
    let Trait = _prefix "Trait"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#Valence"></see>
    /// </summary>
    let Valence = _prefix "Valence"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasEffect"></see>
    /// </summary>
    let hasEffect = _prefix "hasEffect"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasImpact"></see>
    /// </summary>
    let hasImpact = _prefix "hasImpact"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasMaximum"></see>
    /// </summary>
    let hasMaximum = _prefix "hasMaximum"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasMinimum"></see>
    /// </summary>
    let hasMinimum = _prefix "hasMinimum"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#hasTrait"></see>
    /// </summary>
    let hasTrait = _prefix "hasTrait"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#involves"></see>
    /// </summary>
    let involves = _prefix "involves"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#isDefinedBy"></see>
    /// </summary>
    let isDefinedBy = _prefix "isDefinedBy"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#pertainsTo"></see>
    /// </summary>
    let pertainsTo = _prefix "pertainsTo"
    /// <summary>
    ///   <see href="http://ns.inria.fr/emoca#relatesTo"></see>
    /// </summary>
    let relatesTo = _prefix "relatesTo"
