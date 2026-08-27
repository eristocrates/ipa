namespace https.yogaontology.org.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module yoga =
    let _namespace_iri = Namespace_Iri yoga |> NamespaceIRI
    /// <summary>
    ///   <para>yoga:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"First publication v0.1"</para>
    /// </remarks>
    /// <seealso href="https://yogaontology.org/ontology/">https://yogaontology.org/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(yoga, "") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Acidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Acidity"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Acidity">https://yogaontology.org/ontology/Acidity</seealso>
    let Acidity = Prefixed_Name(yoga, "Acidity") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Arm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Arm"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Arm">https://yogaontology.org/ontology/Arm</seealso>
    let Arm = Prefixed_Name(yoga, "Arm") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Asana</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asana is a comfortable and stable body posture in yoga."</para>
    /// labels<para>"Asana"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Asana">https://yogaontology.org/ontology/Asana</seealso>
    let Asana = Prefixed_Name(yoga, "Asana") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Block</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Block"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Block">https://yogaontology.org/ontology/Block</seealso>
    let Block = Prefixed_Name(yoga, "Block") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Body"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Body">https://yogaontology.org/ontology/Body</seealso>
    let Body = Prefixed_Name(yoga, "Body") |> PrefixedName
    /// <summary>
    ///   <para>yoga:BodyPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Body part is any part of an organism, such as a limb or an organ."</para>
    /// labels<para>"Body part"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/BodyPart">https://yogaontology.org/ontology/BodyPart</seealso>
    let BodyPart = Prefixed_Name(yoga, "BodyPart") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Health complaints"</para>
    /// labels<para>"Condition"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Condition">https://yogaontology.org/ontology/Condition</seealso>
    let Condition = Prefixed_Name(yoga, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>yoga:LeftArm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LeftArm"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/LeftArm">https://yogaontology.org/ontology/LeftArm</seealso>
    let LeftArm = Prefixed_Name(yoga, "LeftArm") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Mind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mind is the totality of conscious and unconscious mental processes and activities"</para>
    /// labels<para>"Mind"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Mind">https://yogaontology.org/ontology/Mind</seealso>
    let Mind = Prefixed_Name(yoga, "Mind") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Position is the way the body is placed in the space"</para>
    /// labels<para>"Position"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Position">https://yogaontology.org/ontology/Position</seealso>
    let Position = Prefixed_Name(yoga, "Position") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Pranayama</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Prana means the breath, life, vitality, respiration; Ayama could be translated as stretch, extension, restrain or control. Thus pranayama is the control of breath (inhalation and exhalation) in a steady pose."</para>
    /// labels<para>"Pranayama"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Pranayama">https://yogaontology.org/ontology/Pranayama</seealso>
    let Pranayama = Prefixed_Name(yoga, "Pranayama") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Props</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Different equipment that could be used for yoga practice."</para>
    /// labels<para>"Props"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Props">https://yogaontology.org/ontology/Props</seealso>
    let Props = Prefixed_Name(yoga, "Props") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Pubis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pubis"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Pubis">https://yogaontology.org/ontology/Pubis</seealso>
    let Pubis = Prefixed_Name(yoga, "Pubis") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sequence"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Sequence">https://yogaontology.org/ontology/Sequence</seealso>
    let Sequence = Prefixed_Name(yoga, "Sequence") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Sitting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sitting"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Sitting">https://yogaontology.org/ontology/Sitting</seealso>
    let Sitting = Prefixed_Name(yoga, "Sitting") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Standing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Standing"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Standing">https://yogaontology.org/ontology/Standing</seealso>
    let Standing = Prefixed_Name(yoga, "Standing") |> PrefixedName
    /// <summary>
    ///   <para>yoga:Viloma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Viloma"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/Viloma">https://yogaontology.org/ontology/Viloma</seealso>
    let Viloma = Prefixed_Name(yoga, "Viloma") |> PrefixedName
    /// <summary>
    ///   <para>yoga:consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"consists of"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/consistsOf">https://yogaontology.org/ontology/consistsOf</seealso>
    let consistsOf = Prefixed_Name(yoga, "consistsOf") |> PrefixedName
    /// <summary>
    ///   <para>yoga:hasEffectOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has effect on"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/hasEffectOn">https://yogaontology.org/ontology/hasEffectOn</seealso>
    let hasEffectOn = Prefixed_Name(yoga, "hasEffectOn") |> PrefixedName
    /// <summary>
    ///   <para>yoga:hasPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has position"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/hasPosition">https://yogaontology.org/ontology/hasPosition</seealso>
    let hasPosition = Prefixed_Name(yoga, "hasPosition") |> PrefixedName
    /// <summary>
    ///   <para>yoga:performedInPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"performed in position"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/performedInPosition">https://yogaontology.org/ontology/performedInPosition</seealso>
    let performedInPosition = Prefixed_Name(yoga, "performedInPosition") |> PrefixedName
    /// <summary>
    ///   <para>yoga:preparesFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prepares for"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/preparesFor">https://yogaontology.org/ontology/preparesFor</seealso>
    let preparesFor = Prefixed_Name(yoga, "preparesFor") |> PrefixedName
    /// <summary>
    ///   <para>yoga:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses"</para></remarks>
    /// <seealso href="https://yogaontology.org/ontology/uses">https://yogaontology.org/ontology/uses</seealso>
    let uses = Prefixed_Name(yoga, "uses") |> PrefixedName
