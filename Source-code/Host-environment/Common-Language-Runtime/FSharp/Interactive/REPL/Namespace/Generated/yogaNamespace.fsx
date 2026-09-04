#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module yoga =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://yogaontology.org/ontology/" "yoga"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Acidity</para>
    ///   <a href="https://yogaontology.org/ontology/Acidity">yoga:Acidity</a>
    /// </summary>
    let Acidity = _prefixId.prefix "Acidity"
    /// <summary>
    ///   <para>rdfs:label : Arm</para>
    ///   <a href="https://yogaontology.org/ontology/Arm">yoga:Arm</a>
    /// </summary>
    let Arm = _prefixId.prefix "Arm"
    /// <summary>
    ///   <para>rdfs:comment : Asana is a comfortable and stable body posture in yoga.</para>
    ///   <para>rdfs:label : Asana</para>
    ///   <a href="https://yogaontology.org/ontology/Asana">yoga:Asana</a>
    /// </summary>
    let Asana = _prefixId.prefix "Asana"
    /// <summary>
    ///   <para>rdfs:label : Block</para>
    ///   <a href="https://yogaontology.org/ontology/Block">yoga:Block</a>
    /// </summary>
    let Block = _prefixId.prefix "Block"
    /// <summary>
    ///   <para>rdfs:label : Body</para>
    ///   <a href="https://yogaontology.org/ontology/Body">yoga:Body</a>
    /// </summary>
    let Body = _prefixId.prefix "Body"
    /// <summary>
    ///   <para>rdfs:comment : Body part is any part of an organism, such as a limb or an organ.</para>
    ///   <para>rdfs:label : Body part</para>
    ///   <a href="https://yogaontology.org/ontology/BodyPart">yoga:BodyPart</a>
    /// </summary>
    let BodyPart = _prefixId.prefix "BodyPart"
    /// <summary>
    ///   <para>rdfs:comment : Health complaints</para>
    ///   <para>rdfs:label : Condition</para>
    ///   <a href="https://yogaontology.org/ontology/Condition">yoga:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:label : LeftArm</para>
    ///   <a href="https://yogaontology.org/ontology/LeftArm">yoga:LeftArm</a>
    /// </summary>
    let LeftArm = _prefixId.prefix "LeftArm"
    /// <summary>
    ///   <para>rdfs:comment : Mind is the totality of conscious and unconscious mental processes and activities</para>
    ///   <para>rdfs:label : Mind</para>
    ///   <a href="https://yogaontology.org/ontology/Mind">yoga:Mind</a>
    /// </summary>
    let Mind = _prefixId.prefix "Mind"
    /// <summary>
    ///   <para>rdfs:comment : Position is the way the body is placed in the space</para>
    ///   <para>rdfs:label : Position</para>
    ///   <a href="https://yogaontology.org/ontology/Position">yoga:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:comment : Prana means the breath, life, vitality, respiration; Ayama could be translated as stretch, extension, restrain or control. Thus pranayama is the control of breath (inhalation and exhalation) in a steady pose.</para>
    ///   <para>rdfs:label : Pranayama</para>
    ///   <a href="https://yogaontology.org/ontology/Pranayama">yoga:Pranayama</a>
    /// </summary>
    let Pranayama = _prefixId.prefix "Pranayama"
    /// <summary>
    ///   <para>rdfs:comment : Different equipment that could be used for yoga practice.</para>
    ///   <para>rdfs:label : Props</para>
    ///   <a href="https://yogaontology.org/ontology/Props">yoga:Props</a>
    /// </summary>
    let Props = _prefixId.prefix "Props"
    /// <summary>
    ///   <para>rdfs:label : Pubis</para>
    ///   <a href="https://yogaontology.org/ontology/Pubis">yoga:Pubis</a>
    /// </summary>
    let Pubis = _prefixId.prefix "Pubis"
    /// <summary>
    ///   <para>rdfs:label : Sequence</para>
    ///   <a href="https://yogaontology.org/ontology/Sequence">yoga:Sequence</a>
    /// </summary>
    let Sequence = _prefixId.prefix "Sequence"
    /// <summary>
    ///   <para>rdfs:label : Sitting</para>
    ///   <a href="https://yogaontology.org/ontology/Sitting">yoga:Sitting</a>
    /// </summary>
    let Sitting = _prefixId.prefix "Sitting"
    /// <summary>
    ///   <para>rdfs:label : Standing</para>
    ///   <a href="https://yogaontology.org/ontology/Standing">yoga:Standing</a>
    /// </summary>
    let Standing = _prefixId.prefix "Standing"
    /// <summary>
    ///   <para>rdfs:label : Viloma</para>
    ///   <a href="https://yogaontology.org/ontology/Viloma">yoga:Viloma</a>
    /// </summary>
    let Viloma = _prefixId.prefix "Viloma"
    /// <summary>
    ///   <para>rdfs:label : consists of</para>
    ///   <a href="https://yogaontology.org/ontology/consistsOf">yoga:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>rdfs:label : has effect on</para>
    ///   <a href="https://yogaontology.org/ontology/hasEffectOn">yoga:hasEffectOn</a>
    /// </summary>
    let hasEffectOn = _prefixId.prefix "hasEffectOn"
    /// <summary>
    ///   <para>rdfs:label : has position</para>
    ///   <a href="https://yogaontology.org/ontology/hasPosition">yoga:hasPosition</a>
    /// </summary>
    let hasPosition = _prefixId.prefix "hasPosition"
    /// <summary>
    ///   <para>rdfs:label : performed in position</para>
    ///   <a href="https://yogaontology.org/ontology/performedInPosition">yoga:performedInPosition</a>
    /// </summary>
    let performedInPosition = _prefixId.prefix "performedInPosition"
    /// <summary>
    ///   <para>rdfs:label : prepares for</para>
    ///   <a href="https://yogaontology.org/ontology/preparesFor">yoga:preparesFor</a>
    /// </summary>
    let preparesFor = _prefixId.prefix "preparesFor"
    /// <summary>
    ///   <para>rdfs:label : uses</para>
    ///   <a href="https://yogaontology.org/ontology/uses">yoga:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
