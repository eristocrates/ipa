#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module emotion =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.inria.fr/emoca#" "emotion"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Anger</para>
    ///   <a href="http://ns.inria.fr/emoca#Anger">emotion:Anger</a>
    /// </summary>
    let Anger = _prefixId.prefix "Anger"
    /// <summary>
    ///   <para>rdfs:label : Arousal</para>
    ///   <a href="http://ns.inria.fr/emoca#Arousal">emotion:Arousal</a>
    /// </summary>
    let Arousal = _prefixId.prefix "Arousal"
    /// <summary>
    ///   <para>rdfs:label : Component</para>
    ///   <a href="http://ns.inria.fr/emoca#Component">emotion:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>rdfs:label : Coordinate</para>
    ///   <a href="http://ns.inria.fr/emoca#Coordinate">emotion:Coordinate</a>
    /// </summary>
    let Coordinate = _prefixId.prefix "Coordinate"
    /// <summary>
    ///   <para>rdfs:label : Disgust</para>
    ///   <a href="http://ns.inria.fr/emoca#Disgust">emotion:Disgust</a>
    /// </summary>
    let Disgust = _prefixId.prefix "Disgust"
    /// <summary>
    ///   <para>rdfs:label : Emotion</para>
    ///   <a href="http://ns.inria.fr/emoca#Emotion">emotion:Emotion</a>
    /// </summary>
    let Emotion = _prefixId.prefix "Emotion"
    /// <summary>
    ///   <para>rdfs:label : Fear</para>
    ///   <a href="http://ns.inria.fr/emoca#Fear">emotion:Fear</a>
    /// </summary>
    let Fear = _prefixId.prefix "Fear"
    /// <summary>
    ///   <para>rdfs:label : Impact</para>
    ///   <a href="http://ns.inria.fr/emoca#Impact">emotion:Impact</a>
    /// </summary>
    let Impact = _prefixId.prefix "Impact"
    /// <summary>
    ///   <para>rdfs:label : Joy</para>
    ///   <a href="http://ns.inria.fr/emoca#Joy">emotion:Joy</a>
    /// </summary>
    let Joy = _prefixId.prefix "Joy"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <a href="http://ns.inria.fr/emoca#Person">emotion:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Radius</para>
    ///   <a href="http://ns.inria.fr/emoca#Radius">emotion:Radius</a>
    /// </summary>
    let Radius = _prefixId.prefix "Radius"
    /// <summary>
    ///   <para>rdfs:label : Sadness</para>
    ///   <a href="http://ns.inria.fr/emoca#Sadness">emotion:Sadness</a>
    /// </summary>
    let Sadness = _prefixId.prefix "Sadness"
    /// <summary>
    ///   <para>rdfs:label : Stimulus</para>
    ///   <a href="http://ns.inria.fr/emoca#Stimulus">emotion:Stimulus</a>
    /// </summary>
    let Stimulus = _prefixId.prefix "Stimulus"
    /// <summary>
    ///   <para>rdfs:label : Surprise</para>
    ///   <a href="http://ns.inria.fr/emoca#Surprise">emotion:Surprise</a>
    /// </summary>
    let Surprise = _prefixId.prefix "Surprise"
    /// <summary>
    ///   <para>rdfs:label : Trait</para>
    ///   <a href="http://ns.inria.fr/emoca#Trait">emotion:Trait</a>
    /// </summary>
    let Trait = _prefixId.prefix "Trait"
    /// <summary>
    ///   <para>rdfs:label : Valence</para>
    ///   <a href="http://ns.inria.fr/emoca#Valence">emotion:Valence</a>
    /// </summary>
    let Valence = _prefixId.prefix "Valence"
    /// <summary>
    ///   <para>rdfs:label : has effect</para>
    ///   <a href="http://ns.inria.fr/emoca#hasEffect">emotion:hasEffect</a>
    /// </summary>
    let hasEffect = _prefixId.prefix "hasEffect"
    /// <summary>
    ///   <para>rdfs:label : has impact</para>
    ///   <a href="http://ns.inria.fr/emoca#hasImpact">emotion:hasImpact</a>
    /// </summary>
    let hasImpact = _prefixId.prefix "hasImpact"
    /// <summary>
    ///   <para>rdfs:label : has maximum</para>
    ///   <a href="http://ns.inria.fr/emoca#hasMaximum">emotion:hasMaximum</a>
    /// </summary>
    let hasMaximum = _prefixId.prefix "hasMaximum"
    /// <summary>
    ///   <para>rdfs:label : has minimum</para>
    ///   <a href="http://ns.inria.fr/emoca#hasMinimum">emotion:hasMinimum</a>
    /// </summary>
    let hasMinimum = _prefixId.prefix "hasMinimum"
    /// <summary>
    ///   <para>rdfs:label : has trait</para>
    ///   <a href="http://ns.inria.fr/emoca#hasTrait">emotion:hasTrait</a>
    /// </summary>
    let hasTrait = _prefixId.prefix "hasTrait"
    /// <summary>
    ///   <para>rdfs:label : involves</para>
    ///   <a href="http://ns.inria.fr/emoca#involves">emotion:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>rdfs:label : is defined by</para>
    ///   <a href="http://ns.inria.fr/emoca#isDefinedBy">emotion:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = _prefixId.prefix "isDefinedBy"
    /// <summary>
    ///   <para>rdfs:label : pertains to</para>
    ///   <a href="http://ns.inria.fr/emoca#pertainsTo">emotion:pertainsTo</a>
    /// </summary>
    let pertainsTo = _prefixId.prefix "pertainsTo"
    /// <summary>
    ///   <para>rdfs:label : relates to</para>
    ///   <a href="http://ns.inria.fr/emoca#relatesTo">emotion:relatesTo</a>
    /// </summary>
    let relatesTo = _prefixId.prefix "relatesTo"
