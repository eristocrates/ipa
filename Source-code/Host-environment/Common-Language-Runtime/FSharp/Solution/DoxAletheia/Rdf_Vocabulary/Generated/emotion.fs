namespace http.ns.inria.fr.emoca.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module emotion =
    let _namespace_iri = Namespace_Iri emotion |> NamespaceIRI
    /// <summary>
    ///   <para>emotion:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#">http://ns.inria.fr/emoca#</seealso>
    let _prefix_iri = Prefixed_Name(emotion, "") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Anger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Anger"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Anger">http://ns.inria.fr/emoca#Anger</seealso>
    let Anger = Prefixed_Name(emotion, "Anger") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Arousal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Arousal"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Arousal">http://ns.inria.fr/emoca#Arousal</seealso>
    let Arousal = Prefixed_Name(emotion, "Arousal") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Component"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Component">http://ns.inria.fr/emoca#Component</seealso>
    let Component = Prefixed_Name(emotion, "Component") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Coordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Coordinate"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Coordinate">http://ns.inria.fr/emoca#Coordinate</seealso>
    let Coordinate = Prefixed_Name(emotion, "Coordinate") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Disgust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Disgust"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Disgust">http://ns.inria.fr/emoca#Disgust</seealso>
    let Disgust = Prefixed_Name(emotion, "Disgust") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Emotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Emotion"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Emotion">http://ns.inria.fr/emoca#Emotion</seealso>
    let Emotion = Prefixed_Name(emotion, "Emotion") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Fear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Fear"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Fear">http://ns.inria.fr/emoca#Fear</seealso>
    let Fear = Prefixed_Name(emotion, "Fear") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Impact"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Impact">http://ns.inria.fr/emoca#Impact</seealso>
    let Impact = Prefixed_Name(emotion, "Impact") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Joy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Joy"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Joy">http://ns.inria.fr/emoca#Joy</seealso>
    let Joy = Prefixed_Name(emotion, "Joy") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Person">http://ns.inria.fr/emoca#Person</seealso>
    let Person = Prefixed_Name(emotion, "Person") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Radius"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Radius">http://ns.inria.fr/emoca#Radius</seealso>
    let Radius = Prefixed_Name(emotion, "Radius") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Sadness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Sadness"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Sadness">http://ns.inria.fr/emoca#Sadness</seealso>
    let Sadness = Prefixed_Name(emotion, "Sadness") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Stimulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stimulus"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Stimulus">http://ns.inria.fr/emoca#Stimulus</seealso>
    let Stimulus = Prefixed_Name(emotion, "Stimulus") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Surprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Surprise"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Surprise">http://ns.inria.fr/emoca#Surprise</seealso>
    let Surprise = Prefixed_Name(emotion, "Surprise") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Trait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Trait"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Trait">http://ns.inria.fr/emoca#Trait</seealso>
    let Trait = Prefixed_Name(emotion, "Trait") |> PrefixedName
    /// <summary>
    ///   <para>emotion:Valence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Valence"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#Valence">http://ns.inria.fr/emoca#Valence</seealso>
    let Valence = Prefixed_Name(emotion, "Valence") |> PrefixedName
    /// <summary>
    ///   <para>emotion:hasEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has effect"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#hasEffect">http://ns.inria.fr/emoca#hasEffect</seealso>
    let hasEffect = Prefixed_Name(emotion, "hasEffect") |> PrefixedName
    /// <summary>
    ///   <para>emotion:hasImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has impact"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#hasImpact">http://ns.inria.fr/emoca#hasImpact</seealso>
    let hasImpact = Prefixed_Name(emotion, "hasImpact") |> PrefixedName
    /// <summary>
    ///   <para>emotion:hasMaximum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has maximum"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#hasMaximum">http://ns.inria.fr/emoca#hasMaximum</seealso>
    let hasMaximum = Prefixed_Name(emotion, "hasMaximum") |> PrefixedName
    /// <summary>
    ///   <para>emotion:hasMinimum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has minimum"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#hasMinimum">http://ns.inria.fr/emoca#hasMinimum</seealso>
    let hasMinimum = Prefixed_Name(emotion, "hasMinimum") |> PrefixedName
    /// <summary>
    ///   <para>emotion:hasTrait</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has trait"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#hasTrait">http://ns.inria.fr/emoca#hasTrait</seealso>
    let hasTrait = Prefixed_Name(emotion, "hasTrait") |> PrefixedName
    /// <summary>
    ///   <para>emotion:involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"involves"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#involves">http://ns.inria.fr/emoca#involves</seealso>
    let involves = Prefixed_Name(emotion, "involves") |> PrefixedName
    /// <summary>
    ///   <para>emotion:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is defined by"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#isDefinedBy">http://ns.inria.fr/emoca#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(emotion, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>emotion:pertainsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"pertains to"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#pertainsTo">http://ns.inria.fr/emoca#pertainsTo</seealso>
    let pertainsTo = Prefixed_Name(emotion, "pertainsTo") |> PrefixedName
    /// <summary>
    ///   <para>emotion:relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"relates to"</para></remarks>
    /// <seealso href="http://ns.inria.fr/emoca#relatesTo">http://ns.inria.fr/emoca#relatesTo</seealso>
    let relatesTo = Prefixed_Name(emotion, "relatesTo") |> PrefixedName
