namespace https.yogaontology.org.ontology.slash

open DoxAletheia

module yoga =
    let _namespace_name = "https://yogaontology.org/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Acidity"></see>
    /// </summary>
    let Acidity = _prefix "Acidity"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Arm"></see>
    /// </summary>
    let Arm = _prefix "Arm"
    /// <summary>
    /// Body part is any part of an organism, such as a limb or an organ.
    /// <see href="https://yogaontology.org/ontology/BodyPart"></see></summary>
    let BodyPart = _prefix "BodyPart"
    /// <summary>
    /// Asana is a comfortable and stable body posture in yoga.
    /// <see href="https://yogaontology.org/ontology/Asana"></see></summary>
    let Asana = _prefix "Asana"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Sequence"></see>
    /// </summary>
    let Sequence = _prefix "Sequence"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Block"></see>
    /// </summary>
    let Block = _prefix "Block"
    /// <summary>
    /// Different equipment that could be used for yoga practice.
    /// <see href="https://yogaontology.org/ontology/Props"></see></summary>
    let Props = _prefix "Props"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Body"></see>
    /// </summary>
    let Body = _prefix "Body"
    /// <summary>
    /// Health complaints
    /// <see href="https://yogaontology.org/ontology/Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/LeftArm"></see>
    /// </summary>
    let LeftArm = _prefix "LeftArm"
    /// <summary>
    /// Mind is the totality of conscious and unconscious mental processes and activities
    /// <see href="https://yogaontology.org/ontology/Mind"></see></summary>
    let Mind = _prefix "Mind"
    /// <summary>
    /// Position is the way the body is placed in the space
    /// <see href="https://yogaontology.org/ontology/Position"></see></summary>
    let Position = _prefix "Position"
    /// <summary>
    /// Prana means the breath, life, vitality, respiration; Ayama could be translated as stretch, extension, restrain or control. Thus pranayama is the control of breath (inhalation and exhalation) in a steady pose.
    /// <see href="https://yogaontology.org/ontology/Pranayama"></see></summary>
    let Pranayama = _prefix "Pranayama"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Pubis"></see>
    /// </summary>
    let Pubis = _prefix "Pubis"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Sitting"></see>
    /// </summary>
    let Sitting = _prefix "Sitting"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Standing"></see>
    /// </summary>
    let Standing = _prefix "Standing"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/Viloma"></see>
    /// </summary>
    let Viloma = _prefix "Viloma"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/consistsOf"></see>
    /// </summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/hasEffectOn"></see>
    /// </summary>
    let hasEffectOn = _prefix "hasEffectOn"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/hasPosition"></see>
    /// </summary>
    let hasPosition = _prefix "hasPosition"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/performedInPosition"></see>
    /// </summary>
    let performedInPosition = _prefix "performedInPosition"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/preparesFor"></see>
    /// </summary>
    let preparesFor = _prefix "preparesFor"
    /// <summary>
    ///   <see href="https://yogaontology.org/ontology/uses"></see>
    /// </summary>
    let uses = _prefix "uses"
