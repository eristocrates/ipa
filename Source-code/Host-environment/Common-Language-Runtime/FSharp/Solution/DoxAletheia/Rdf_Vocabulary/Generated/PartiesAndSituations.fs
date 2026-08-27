namespace https.www.omg.org.spec.Commons.PartiesAndSituations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module PartiesAndSituations =
    let _namespace_iri = Namespace_Iri PartiesAndSituations |> NamespaceIRI
    /// <summary>
    ///   <para>PartiesAndSituations:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/">https://www.omg.org/spec/Commons/PartiesAndSituations/</seealso>
    let _prefix_iri = Prefixed_Name(PartiesAndSituations, "") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:Actor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/Actor">https://www.omg.org/spec/Commons/PartiesAndSituations/Actor</seealso>
    let Actor = Prefixed_Name(PartiesAndSituations, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/Agent">https://www.omg.org/spec/Commons/PartiesAndSituations/Agent</seealso>
    let Agent = Prefixed_Name(PartiesAndSituations, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:AgentRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/AgentRole">https://www.omg.org/spec/Commons/PartiesAndSituations/AgentRole</seealso>
    let AgentRole = Prefixed_Name(PartiesAndSituations, "AgentRole") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/Party">https://www.omg.org/spec/Commons/PartiesAndSituations/Party</seealso>
    let Party = Prefixed_Name(PartiesAndSituations, "Party") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:PartyRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/PartyRole">https://www.omg.org/spec/Commons/PartiesAndSituations/PartyRole</seealso>
    let PartyRole = Prefixed_Name(PartiesAndSituations, "PartyRole") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:Situation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/Situation">https://www.omg.org/spec/Commons/PartiesAndSituations/Situation</seealso>
    let Situation = Prefixed_Name(PartiesAndSituations, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:Undergoer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/Undergoer">https://www.omg.org/spec/Commons/PartiesAndSituations/Undergoer</seealso>
    let Undergoer = Prefixed_Name(PartiesAndSituations, "Undergoer") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:actsIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/actsIn">https://www.omg.org/spec/Commons/PartiesAndSituations/actsIn</seealso>
    let actsIn = Prefixed_Name(PartiesAndSituations, "actsIn") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:actsOn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/actsOn">https://www.omg.org/spec/Commons/PartiesAndSituations/actsOn</seealso>
    let actsOn = Prefixed_Name(PartiesAndSituations, "actsOn") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:directlyAffects</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/directlyAffects">https://www.omg.org/spec/Commons/PartiesAndSituations/directlyAffects</seealso>
    let directlyAffects =
        Prefixed_Name(PartiesAndSituations, "directlyAffects") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:experiences</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/experiences">https://www.omg.org/spec/Commons/PartiesAndSituations/experiences</seealso>
    let experiences = Prefixed_Name(PartiesAndSituations, "experiences") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:experiencesDirectly</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/experiencesDirectly">https://www.omg.org/spec/Commons/PartiesAndSituations/experiencesDirectly</seealso>
    let experiencesDirectly =
        Prefixed_Name(PartiesAndSituations, "experiencesDirectly") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:experiencesWith</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/experiencesWith">https://www.omg.org/spec/Commons/PartiesAndSituations/experiencesWith</seealso>
    let experiencesWith =
        Prefixed_Name(PartiesAndSituations, "experiencesWith") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:hasActiveParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasActiveParty">https://www.omg.org/spec/Commons/PartiesAndSituations/hasActiveParty</seealso>
    let hasActiveParty =
        Prefixed_Name(PartiesAndSituations, "hasActiveParty") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:hasActor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasActor">https://www.omg.org/spec/Commons/PartiesAndSituations/hasActor</seealso>
    let hasActor = Prefixed_Name(PartiesAndSituations, "hasActor") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:hasParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasParty">https://www.omg.org/spec/Commons/PartiesAndSituations/hasParty</seealso>
    let hasParty = Prefixed_Name(PartiesAndSituations, "hasParty") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:hasPartyRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasPartyRole">https://www.omg.org/spec/Commons/PartiesAndSituations/hasPartyRole</seealso>
    let hasPartyRole =
        Prefixed_Name(PartiesAndSituations, "hasPartyRole") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:hasUndergoer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/hasUndergoer">https://www.omg.org/spec/Commons/PartiesAndSituations/hasUndergoer</seealso>
    let hasUndergoer =
        Prefixed_Name(PartiesAndSituations, "hasUndergoer") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:holdsDuring</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/holdsDuring">https://www.omg.org/spec/Commons/PartiesAndSituations/holdsDuring</seealso>
    let holdsDuring = Prefixed_Name(PartiesAndSituations, "holdsDuring") |> PrefixedName
    /// <summary>
    ///   <para>PartiesAndSituations:isAPartyTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/isAPartyTo">https://www.omg.org/spec/Commons/PartiesAndSituations/isAPartyTo</seealso>
    let isAPartyTo = Prefixed_Name(PartiesAndSituations, "isAPartyTo") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:isAffectedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/isAffectedBy">https://www.omg.org/spec/Commons/PartiesAndSituations/isAffectedBy</seealso>
    let isAffectedBy =
        Prefixed_Name(PartiesAndSituations, "isAffectedBy") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:isDirectlyAffectedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/isDirectlyAffectedBy">https://www.omg.org/spec/Commons/PartiesAndSituations/isDirectlyAffectedBy</seealso>
    let isDirectlyAffectedBy =
        Prefixed_Name(PartiesAndSituations, "isDirectlyAffectedBy") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:isExperiencedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/isExperiencedBy">https://www.omg.org/spec/Commons/PartiesAndSituations/isExperiencedBy</seealso>
    let isExperiencedBy =
        Prefixed_Name(PartiesAndSituations, "isExperiencedBy") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:playsActivePartyIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/playsActivePartyIn">https://www.omg.org/spec/Commons/PartiesAndSituations/playsActivePartyIn</seealso>
    let playsActivePartyIn =
        Prefixed_Name(PartiesAndSituations, "playsActivePartyIn") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:playsActiveRoleIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/playsActiveRoleIn">https://www.omg.org/spec/Commons/PartiesAndSituations/playsActiveRoleIn</seealso>
    let playsActiveRoleIn =
        Prefixed_Name(PartiesAndSituations, "playsActiveRoleIn") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:playsActiveRoleThatDirectlyAffects</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/playsActiveRoleThatDirectlyAffects">https://www.omg.org/spec/Commons/PartiesAndSituations/playsActiveRoleThatDirectlyAffects</seealso>
    let playsActiveRoleThatDirectlyAffects =
        Prefixed_Name(PartiesAndSituations, "playsActiveRoleThatDirectlyAffects") |> PrefixedName

    /// <summary>
    ///   <para>PartiesAndSituations:undergoes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/PartiesAndSituations/undergoes">https://www.omg.org/spec/Commons/PartiesAndSituations/undergoes</seealso>
    let undergoes = Prefixed_Name(PartiesAndSituations, "undergoes") |> PrefixedName
