namespace https.w3id.org.airo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module airo =
    let _namespace_iri = Namespace_Iri airo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:airo#AICapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AICapability">https://w3id.org/airo#AICapability</seealso>
    let AICapability = Prefixed_Name(airo, "AICapability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AIComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AIComponent">https://w3id.org/airo#AIComponent</seealso>
    let AIComponent = Prefixed_Name(airo, "AIComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AILifecyclePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AILifecyclePhase">https://w3id.org/airo#AILifecyclePhase</seealso>
    let AILifecyclePhase = Prefixed_Name(airo, "AILifecyclePhase") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AIOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AIOperator">https://w3id.org/airo#AIOperator</seealso>
    let AIOperator = Prefixed_Name(airo, "AIOperator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AISubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AISubject">https://w3id.org/airo#AISubject</seealso>
    let AISubject = Prefixed_Name(airo, "AISubject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AISystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AISystem">https://w3id.org/airo#AISystem</seealso>
    let AISystem = Prefixed_Name(airo, "AISystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AITechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AITechnique">https://w3id.org/airo#AITechnique</seealso>
    let AITechnique = Prefixed_Name(airo, "AITechnique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AreaOfImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AreaOfImpact">https://w3id.org/airo#AreaOfImpact</seealso>
    let AreaOfImpact = Prefixed_Name(airo, "AreaOfImpact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#AutomationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#AutomationLevel">https://w3id.org/airo#AutomationLevel</seealso>
    let AutomationLevel = Prefixed_Name(airo, "AutomationLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#Consequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Consequence">https://w3id.org/airo#Consequence</seealso>
    let Consequence = Prefixed_Name(airo, "Consequence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Documentation">https://w3id.org/airo#Documentation</seealso>
    let Documentation = Prefixed_Name(airo, "Documentation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Domain">https://w3id.org/airo#Domain</seealso>
    let Domain = Prefixed_Name(airo, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#HumanInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#HumanInvolvement">https://w3id.org/airo#HumanInvolvement</seealso>
    let HumanInvolvement = Prefixed_Name(airo, "HumanInvolvement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Impact">https://w3id.org/airo#Impact</seealso>
    let Impact = Prefixed_Name(airo, "Impact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#Modality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Modality">https://w3id.org/airo#Modality</seealso>
    let Modality = Prefixed_Name(airo, "Modality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:airo#ModeOfOutputControllability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#ModeOfOutputControllability">https://w3id.org/airo#ModeOfOutputControllability</seealso>
    let ModeOfOutputControllability =
        Prefixed_Name(airo, "ModeOfOutputControllability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:airo#Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Output">https://w3id.org/airo#Output</seealso>
    let Output = Prefixed_Name(airo, "Output") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#Purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Purpose">https://w3id.org/airo#Purpose</seealso>
    let Purpose = Prefixed_Name(airo, "Purpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#RiskControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#RiskControl">https://w3id.org/airo#RiskControl</seealso>
    let RiskControl = Prefixed_Name(airo, "RiskControl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#RiskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#RiskSource">https://w3id.org/airo#RiskSource</seealso>
    let RiskSource = Prefixed_Name(airo, "RiskSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:airo#Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/airo#Standard">https://w3id.org/airo#Standard</seealso>
    let Standard = Prefixed_Name(airo, "Standard") |> PrefixedName
