namespace http.ns.inria.fr.nrv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nrv =
    let _namespace_iri = Namespace_Iri nrv |> NamespaceIRI
    /// <summary>
    ///   <para>nrv:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>"This file specifies the set of OWL classes and properties proposed by the MIREL project to represent normative requirements."</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/nrv#">http://ns.inria.fr/nrv#</seealso>
    let _prefix_iri = Prefixed_Name(nrv, "") |> PrefixedName
    /// <summary>
    ///   <para>nrv:Achievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"an obligation for which achieving the content at least once is enough to fulfil it."</para>
    /// labels<para>"achievement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#Achievement">http://ns.inria.fr/nrv#Achievement</seealso>
    let Achievement = Prefixed_Name(nrv, "Achievement") |> PrefixedName
    /// <summary>
    ///   <para>nrv:CoOccurantPunctual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"TODO."</para>
    /// labels<para>"co-occurant punctual requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#CoOccurantPunctual">http://ns.inria.fr/nrv#CoOccurantPunctual</seealso>
    let CoOccurantPunctual = Prefixed_Name(nrv, "CoOccurantPunctual") |> PrefixedName

    /// <summary>
    ///   <para>nrv:CompensableRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement that can be compensated."</para>
    /// labels<para>"compensable requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#CompensableRequirement">http://ns.inria.fr/nrv#CompensableRequirement</seealso>
    let CompensableRequirement =
        Prefixed_Name(nrv, "CompensableRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:CompensatedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement violated in a state of affairs and compensated in that same state of affairs."</para>
    /// labels<para>"compensated requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#CompensatedRequirement">http://ns.inria.fr/nrv#CompensatedRequirement</seealso>
    let CompensatedRequirement =
        Prefixed_Name(nrv, "CompensatedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:Compensation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a set of penalties or sanctions imposed on the violator ; fulfilling them makes amends for the violation."</para>
    /// labels<para>"compensation"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#Compensation">http://ns.inria.fr/nrv#Compensation</seealso>
    let Compensation = Prefixed_Name(nrv, "Compensation") |> PrefixedName

    /// <summary>
    ///   <para>nrv:CompliantRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement being compliant with a state of affairs."</para>
    /// labels<para>"compliant requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#CompliantRequirement">http://ns.inria.fr/nrv#CompliantRequirement</seealso>
    let CompliantRequirement =
        Prefixed_Name(nrv, "CompliantRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"an obligation that needs to be obeyed for the whole duration within the interval in which it is in force."</para>
    /// labels<para>"maintenance"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#Maintenance">http://ns.inria.fr/nrv#Maintenance</seealso>
    let Maintenance = Prefixed_Name(nrv, "Maintenance") |> PrefixedName

    /// <summary>
    ///   <para>nrv:NonCoOccurantPunctual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"TODO."</para>
    /// labels<para>"non co-occurant punctual requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#NonCoOccurantPunctual">http://ns.inria.fr/nrv#NonCoOccurantPunctual</seealso>
    let NonCoOccurantPunctual =
        Prefixed_Name(nrv, "NonCoOccurantPunctual") |> PrefixedName

    /// <summary>
    ///   <para>nrv:NonCompensableRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement that cannot be compensated."</para>
    /// labels<para>"non compensable requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#NonCompensableRequirement">http://ns.inria.fr/nrv#NonCompensableRequirement</seealso>
    let NonCompensableRequirement =
        Prefixed_Name(nrv, "NonCompensableRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:NonPerdurantAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"achievement requirement that does not persist after being violated."</para>
    /// labels<para>"non perdurant requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#NonPerdurantAchievement">http://ns.inria.fr/nrv#NonPerdurantAchievement</seealso>
    let NonPerdurantAchievement =
        Prefixed_Name(nrv, "NonPerdurantAchievement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:NonPersistentRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement that is in force at a particular time point only or for the instance it is in force."</para>
    /// labels<para>"non persistent requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#NonPersistentRequirement">http://ns.inria.fr/nrv#NonPersistentRequirement</seealso>
    let NonPersistentRequirement =
        Prefixed_Name(nrv, "NonPersistentRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:NonPreemptiveAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"an achievement requirement that cannot be fulfilled even before it is actually in force."</para>
    /// labels<para>"non preemptive achievement requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#NonPreemptiveAchievement">http://ns.inria.fr/nrv#NonPreemptiveAchievement</seealso>
    let NonPreemptiveAchievement =
        Prefixed_Name(nrv, "NonPreemptiveAchievement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:NonViolableRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement that cannot be violated."</para>
    /// labels<para>"non violable requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#NonViolableRequirement">http://ns.inria.fr/nrv#NonViolableRequirement</seealso>
    let NonViolableRequirement =
        Prefixed_Name(nrv, "NonViolableRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:NormativeRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement implying, creating, or prescribing a norm."</para>
    /// labels<para>"Normative Requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#NormativeRequirement">http://ns.inria.fr/nrv#NormativeRequirement</seealso>
    let NormativeRequirement =
        Prefixed_Name(nrv, "NormativeRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:PerdurantAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"achievement requirement that persists after being violated."</para>
    /// labels<para>"perdurant achievement requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#PerdurantAchievement">http://ns.inria.fr/nrv#PerdurantAchievement</seealso>
    let PerdurantAchievement =
        Prefixed_Name(nrv, "PerdurantAchievement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:PersistentRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement that needs to be obeyed for the whole duration within the interval in which it is in force."</para>
    /// labels<para>"persistent requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#PersistentRequirement">http://ns.inria.fr/nrv#PersistentRequirement</seealso>
    let PersistentRequirement =
        Prefixed_Name(nrv, "PersistentRequirement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:PreemptiveAchievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"an achievement requirement that can be fulfilled even before it is actually in force."</para>
    /// labels<para>"preemptive achievement requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#PreemptiveAchievement">http://ns.inria.fr/nrv#PreemptiveAchievement</seealso>
    let PreemptiveAchievement =
        Prefixed_Name(nrv, "PreemptiveAchievement") |> PrefixedName

    /// <summary>
    ///   <para>nrv:Punctual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"an obligation for which the contents must be immediately achieved."</para>
    /// labels<para>"punctual"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#Punctual">http://ns.inria.fr/nrv#Punctual</seealso>
    let Punctual = Prefixed_Name(nrv, "Punctual") |> PrefixedName
    /// <summary>
    ///   <para>nrv:ViolableRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement that can be violated."</para>
    /// labels<para>"violable requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#ViolableRequirement">http://ns.inria.fr/nrv#ViolableRequirement</seealso>
    let ViolableRequirement = Prefixed_Name(nrv, "ViolableRequirement") |> PrefixedName
    /// <summary>
    ///   <para>nrv:ViolatedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"a requirement violated by a state of affairs."</para>
    /// labels<para>"violated requirement"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#ViolatedRequirement">http://ns.inria.fr/nrv#ViolatedRequirement</seealso>
    let ViolatedRequirement = Prefixed_Name(nrv, "ViolatedRequirement") |> PrefixedName
    /// <summary>
    ///   <para>nrv:hasCompensation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links a compensable requirement to a compensation."</para>
    /// labels<para>"has for compensation"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#hasCompensation">http://ns.inria.fr/nrv#hasCompensation</seealso>
    let hasCompensation = Prefixed_Name(nrv, "hasCompensation") |> PrefixedName
    /// <summary>
    ///   <para>nrv:hasCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links a violable requirement to compliance."</para>
    /// labels<para>"has for compliance"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#hasCompliance">http://ns.inria.fr/nrv#hasCompliance</seealso>
    let hasCompliance = Prefixed_Name(nrv, "hasCompliance") |> PrefixedName
    /// <summary>
    ///   <para>nrv:hasViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links a violable requirement to a violation."</para>
    /// labels<para>"has for violation"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nrv#hasViolation">http://ns.inria.fr/nrv#hasViolation</seealso>
    let hasViolation = Prefixed_Name(nrv, "hasViolation") |> PrefixedName
