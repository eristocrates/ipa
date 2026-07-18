namespace https.yogaontology.org.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module yoga =
    let _namespace_name = "https://yogaontology.org/ontology/"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Acidity"></see>
    /// </summary>
    let Acidity = Namespaced_IRI.parse _namespace_name "Acidity" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Arm"></see>
    /// </summary>
    let Arm = Namespaced_IRI.parse _namespace_name "Arm" |> NamespacedName
    /// <summary>
    /// Body part is any part of an organism, such as a limb or an organ.
    /// <see href="https://yogaontology.org/ontology/BodyPart"></see></summary>
    let BodyPart = Namespaced_IRI.parse _namespace_name "BodyPart" |> NamespacedName
    /// <summary>
    /// Asana is a comfortable and stable body posture in yoga.
    /// <see href="https://yogaontology.org/ontology/Asana"></see></summary>
    let Asana = Namespaced_IRI.parse _namespace_name "Asana" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Sequence"></see>
    /// </summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Block"></see>
    /// </summary>
    let Block = Namespaced_IRI.parse _namespace_name "Block" |> NamespacedName
    /// <summary>
    /// Different equipment that could be used for yoga practice.
    /// <see href="https://yogaontology.org/ontology/Props"></see></summary>
    let Props = Namespaced_IRI.parse _namespace_name "Props" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Body"></see>
    /// </summary>
    let Body = Namespaced_IRI.parse _namespace_name "Body" |> NamespacedName
    /// <summary>
    /// Health complaints
    /// <see href="https://yogaontology.org/ontology/Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/LeftArm"></see>
    /// </summary>
    let LeftArm = Namespaced_IRI.parse _namespace_name "LeftArm" |> NamespacedName
    /// <summary>
    /// Mind is the totality of conscious and unconscious mental processes and activities
    /// <see href="https://yogaontology.org/ontology/Mind"></see></summary>
    let Mind = Namespaced_IRI.parse _namespace_name "Mind" |> NamespacedName
    /// <summary>
    /// Position is the way the body is placed in the space
    /// <see href="https://yogaontology.org/ontology/Position"></see></summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName
    /// <summary>
    /// Prana means the breath, life, vitality, respiration; Ayama could be translated as stretch, extension, restrain or control. Thus pranayama is the control of breath (inhalation and exhalation) in a steady pose.
    /// <see href="https://yogaontology.org/ontology/Pranayama"></see></summary>
    let Pranayama = Namespaced_IRI.parse _namespace_name "Pranayama" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Pubis"></see>
    /// </summary>
    let Pubis = Namespaced_IRI.parse _namespace_name "Pubis" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Sitting"></see>
    /// </summary>
    let Sitting = Namespaced_IRI.parse _namespace_name "Sitting" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Standing"></see>
    /// </summary>
    let Standing = Namespaced_IRI.parse _namespace_name "Standing" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Viloma"></see>
    /// </summary>
    let Viloma = Namespaced_IRI.parse _namespace_name "Viloma" |> NamespacedName
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/consistsOf"></see>
    /// </summary>
    let consistsOf = Namespaced_IRI.parse _namespace_name "consistsOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/hasEffectOn"></see>
    /// </summary>
    let hasEffectOn =
        Namespaced_IRI.parse _namespace_name "hasEffectOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/hasPosition"></see>
    /// </summary>
    let hasPosition =
        Namespaced_IRI.parse _namespace_name "hasPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/performedInPosition"></see>
    /// </summary>
    let performedInPosition =
        Namespaced_IRI.parse _namespace_name "performedInPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/preparesFor"></see>
    /// </summary>
    let preparesFor =
        Namespaced_IRI.parse _namespace_name "preparesFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/uses"></see>
    /// </summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName
